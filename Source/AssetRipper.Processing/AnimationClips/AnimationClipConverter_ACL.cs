using AssetRipper.Assets.IO.Reading;
using AssetRipper.Assets.Utils;
using AssetRipper.Processing.AnimationClips.Editor;
using AssetRipper.SourceGenerated;
using AssetRipper.SourceGenerated.Classes.ClassID_74;
using AssetRipper.SourceGenerated.Extensions;
using AssetRipper.SourceGenerated.Extensions.Enums.AnimationClip;
using AssetRipper.GameChoiceClass;
using AssetRipper.SourceGenerated.Extensions.Enums.AnimationClip.GenericBinding;
using AssetRipper.SourceGenerated.Extensions.Enums.Keyframe;
using AssetRipper.SourceGenerated.Extensions.Enums.Keyframe.TangentMode;
using AssetRipper.SourceGenerated.Subclasses.AnimationClipBindingConstant;
using AssetRipper.SourceGenerated.Subclasses.Clip;
using AssetRipper.SourceGenerated.Subclasses.ConstantClip;
using AssetRipper.SourceGenerated.Subclasses.DenseClip;
using AssetRipper.SourceGenerated.Subclasses.FloatCurve;
using AssetRipper.SourceGenerated.Subclasses.GenericBinding;
using AssetRipper.SourceGenerated.Subclasses.Keyframe_Quaternionf;
using AssetRipper.SourceGenerated.Subclasses.Keyframe_Single;
using AssetRipper.SourceGenerated.Subclasses.Keyframe_Vector3f;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Object;
using AssetRipper.SourceGenerated.Subclasses.PPtrCurve;
using AssetRipper.SourceGenerated.Subclasses.PPtrKeyframe;
using AssetRipper.SourceGenerated.Subclasses.QuaternionCurve;
using AssetRipper.SourceGenerated.Subclasses.StreamedClip;
using AssetRipper.SourceGenerated.Subclasses.Vector3Curve;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using AssetRipper.IClasses.AnimationClip;
using AssetRipper.IClasses.Clip;
using AssetRipper.Processing.AnimationClips.ACL;
using AssetRipper.Import.Logging;

namespace AssetRipper.Processing.AnimationClips
{
	public sealed partial class AnimationClipConverter_ACL
	{
		private AnimationClipConverter_ACL(IAnimationClip_ACL clip)
		{
			if (clip == null)
			{
				throw new ArgumentNullException(nameof(clip));
			}
			m_clip = clip;
			m_customCurveResolver = new CustomCurveResolver_ACL(clip);
		}

		public static void Process(IAnimationClip_ACL clip, AnimationCache cache)
		{
			AnimationClipConverter_ACL converter = new AnimationClipConverter_ACL(clip);
			converter.ProcessInner(cache);
		}

		private void ProcessInner(AnimationCache animationCache)
		{
			if (m_clip.Has_MuscleClip_C74() && m_clip.Has_ClipBindingConstant_C74())
			{
				IClip_ACL clip = m_clip.MuscleClip_C74.Clip.Data;
				IAnimationClipBindingConstant bindings = m_clip.ClipBindingConstant_C74;
				IReadOnlyDictionary<uint, string> tos = m_clip.FindTOS(animationCache);

				IReadOnlyList<StreamedFrame> streamedFrames = GenerateFramesFromStreamedClip(clip.StreamedClip);
				float lastDenseFrame = clip.DenseClip.FrameCount / clip.DenseClip.SampleRate;
				float lastSampleFrame = streamedFrames.Count > 1 ? streamedFrames[streamedFrames.Count - 2].Time : 0.0f;
				float lastFrame = Math.Max(lastDenseFrame, lastSampleFrame);

				AclClip m_ACLClip = clip.AclClip;
				if (m_ACLClip.IsSet)
				{
					if (GameChoice.GetGame() != GameFlags.SR)
					{
						var lastACLFrame = ProcessAclClip(clip, bindings, tos);
						lastFrame = System.Math.Max(lastFrame, lastACLFrame);
					}
					ProcessStreams(streamedFrames, bindings, tos, clip.DenseClip.SampleRate, (int)m_ACLClip.CurveCount);
					ProcessDenses(clip, bindings, tos, (int)m_ACLClip.CurveCount);
					if (GameChoice.GetGame() == GameFlags.SR)
					{
						var lastACLFrame = ProcessAclClip(clip, bindings, tos);
						lastFrame = System.Math.Max(lastFrame, lastACLFrame);
					}
					if (clip.Has_ConstantClip())
					{
						ProcessConstant(clip, clip.ConstantClip, bindings, tos, lastFrame, (int)m_ACLClip.CurveCount);
					}
					if (m_clip.Has_MuscleClipInfo_C74())
					{
						m_clip.MuscleClipInfo_C74.Initialize(m_clip.MuscleClip_C74);
					}
				}
				else
				{
					ProcessStreams(streamedFrames, bindings, tos, clip.DenseClip.SampleRate, 0);
					ProcessDenses(clip, bindings, tos, 0);
					if (clip.Has_ConstantClip())
					{
						ProcessConstant(clip, clip.ConstantClip, bindings, tos, lastFrame, 0);
					}
					if (m_clip.Has_MuscleClipInfo_C74())
					{
						m_clip.MuscleClipInfo_C74.Initialize(m_clip.MuscleClip_C74);
					}
				}
			}
		}

		private void ProcessStreams(IReadOnlyList<StreamedFrame> streamFrames, IAnimationClipBindingConstant bindings, IReadOnlyDictionary<uint, string> tos, float sampleRate, int aclCurveCount)
		{
			float[] curveValues = new float[4];
			float[] inSlopeValues = new float[4];
			float[] outSlopeValues = new float[4];
			float interval = 1.0f / sampleRate;

			// first (index [0]) stream frame is for slope calculation for the first real frame (index [1])
			// last one (index [count - 1]) is +Infinity
			// it is made for slope processing, but we don't need them
			bool frameIndex0 = true;
			for (int frameIndex = 0; frameIndex < streamFrames.Count - 1; frameIndex++)
			{
				StreamedFrame frame = streamFrames[frameIndex];
				for (int curveIndex = 0; curveIndex < frame.Curves.Length;)
				{
					StreamedCurveKey curve = frame.Curves[curveIndex];
					IGenericBinding binding;

					if (GameChoice.GetGame() != GameFlags.SR)
					{
						binding = bindings.FindBinding(curve.Index + aclCurveCount);
					}
					else
					{
						binding = bindings.FindBinding(curve.Index);
					}

					string path = GetCurvePath(tos, binding.Path);
					if (binding.IsTransform())
					{
						if (frameIndex0)
						{
							curveIndex = GetNextCurve(frame, curveIndex);
							continue;
						}
						GetPreviousFrame(streamFrames, curve.Index, frameIndex, out int prevFrameIndex, out int prevCurveIndex);
						int dimension = binding.TransformType().GetDimension();
						for (int key = 0; key < dimension; key++)
						{
							StreamedCurveKey keyCurve = frame.Curves[curveIndex];//index out of bounds
							StreamedFrame prevFrame = streamFrames[prevFrameIndex];
							StreamedCurveKey prevKeyCurve = prevFrame.Curves[prevCurveIndex + key];
							float deltaTime = frame.Time - prevFrame.Time;
							curveValues[key] = keyCurve.Value;
							inSlopeValues[key] = prevKeyCurve.CalculateNextInSlope(deltaTime, keyCurve.Value);
							outSlopeValues[key] = keyCurve.OutSlope;
							curveIndex = GetNextCurve(frame, curveIndex);
						}

						AddTransformCurve(frame.Time, binding.TransformType(), curveValues, inSlopeValues, outSlopeValues, 0, path);
					}
					else if (binding.CustomType == (byte)BindingCustomType.None)
					{
						if (frameIndex0) { curveIndex = GetNextCurve(frame, curveIndex); continue; }
						AddDefaultCurve(binding, path, frame.Time, frame.Curves[curveIndex].Value);
						curveIndex = GetNextCurve(frame, curveIndex);
					}
					else
					{
						AddCustomCurve(bindings, binding, path, frame.Time, frame.Curves[curveIndex].Value);
						curveIndex = GetNextCurve(frame, curveIndex);
					}
				}
				if (frameIndex0)
				{
					frameIndex0 = false;
				}
			}
		}

		private void ProcessDenses(IClip_ACL clip, IAnimationClipBindingConstant bindings, IReadOnlyDictionary<uint, string> tos, int aclCurveCount)
		{
			DenseClip dense = clip.DenseClip;
			int streamCount = (int)clip.StreamedClip.CurveCount;
			float[] slopeValues = new float[4]; // no slopes - 0 values
			for (int frameIndex = 0; frameIndex < dense.FrameCount; frameIndex++)
			{
				float time = frameIndex / dense.SampleRate;
				int frameOffset = frameIndex * (int)dense.CurveCount;
				for (int curveIndex = 0; curveIndex < dense.CurveCount;)
				{
					int index = streamCount + curveIndex;
					IGenericBinding binding;

					if (GameChoice.GetGame() != GameFlags.SR)
					{
						binding = bindings.FindBinding(index + aclCurveCount);
					}
					else
					{
						binding = bindings.FindBinding(index);
					}

					string path = GetCurvePath(tos, binding.Path);
					int framePosition = frameOffset + curveIndex;
					if (binding.IsTransform())
					{
						AddTransformCurve(time, binding.TransformType(), dense.SampleArray, slopeValues, slopeValues, framePosition, path);
						curveIndex += binding.TransformType().GetDimension();
					}
					else if (binding.CustomType == (byte)BindingCustomType.None)
					{
						AddDefaultCurve(binding, path, time, dense.SampleArray[framePosition]);
						curveIndex++;
					}
					else
					{
						AddCustomCurve(bindings, binding, path, time, dense.SampleArray[framePosition]);
						curveIndex++;
					}
				}
			}
		}

		private void ProcessConstant(IClip_ACL clip, IConstantClip constant, IAnimationClipBindingConstant bindings, IReadOnlyDictionary<uint, string> tos, float lastFrame, int aclCurveCount)
		{
			int streamCount = (int)clip.StreamedClip.CurveCount;
			int denseCount = (int)clip.DenseClip.CurveCount;
			float[] slopeValues = new float[4]; // no slopes - 0 values

			// only first and last frames
			float time = 0.0f;
			for (int i = 0; i < 2; i++, time += lastFrame)
			{
				for (int curveIndex = 0; curveIndex < constant.Data.Length;)
				{
					int index = streamCount + denseCount + curveIndex + aclCurveCount;
					IGenericBinding binding = bindings.FindBinding(index);
					string path = GetCurvePath(tos, binding.Path);
					if (binding.IsTransform())
					{
						AddTransformCurve(time, binding.TransformType(), constant.Data, slopeValues, slopeValues, curveIndex, path);
						curveIndex += binding.TransformType().GetDimension();
					}
					else if (binding.CustomType == (byte)BindingCustomType.None)
					{
						AddDefaultCurve(binding, path, time, constant.Data[curveIndex]);
						curveIndex++;
					}
					else
					{
						AddCustomCurve(bindings, binding, path, time, constant.Data[curveIndex]);
						curveIndex++;
					}
				}
			}
		}


		private float ProcessAclClip(IClip_ACL clip, IAnimationClipBindingConstant bindings, IReadOnlyDictionary<uint, string> tos)
		{
			float[] values;
			float[] times;
			AclClip m_ACLClip = clip.AclClip;
			float[] slopeValues = new float[4]; // no slopes - 0 values

			if (GameChoice.GetGame() != GameFlags.SR)
			{
				AclUtils.DecompressAll(m_ACLClip.ClipData, out values, out times);
			}
			else
			{
				AclUtilsForSR.DecompressAll(m_ACLClip.ClipDataUint, out values, out times);
			}

			for (int frameIndex = 0; frameIndex < times.Length; frameIndex++)
			{
				float time = times[frameIndex];
				int offset = frameIndex * (int)m_ACLClip.CurveCount;
				for (int curveIndex = 0; curveIndex < (int)m_ACLClip.CurveCount;)
				{
					var index = curveIndex;
					if (GameChoice.GetGame() == GameFlags.SR)
						index += (int)(clip.StreamedClip.CurveCount + clip.DenseClip.CurveCount);
					IGenericBinding binding = bindings.FindBinding(index);
					string path = GetCurvePath(tos, binding.Path);
					int framePosition = offset + curveIndex;

					if (binding.IsTransform())
					{
						AddTransformCurve(time, binding.TransformType(), values, slopeValues, slopeValues, framePosition, path);
						curveIndex += binding.TransformType().GetDimension();
						index += binding.TransformType().GetDimension();
					}
					else if (binding.CustomType == (byte)BindingCustomType.None)
					{
						AddDefaultCurve(binding, path, time, values[framePosition]);
						curveIndex++;
						index++;
					}
					else
					{
						AddCustomCurve(bindings, binding, path, time, values[framePosition]);
						curveIndex++;
						index++;
					}
				}
			}

			return times[times.Length - 1];
		}
		private void AddCustomCurve(IAnimationClipBindingConstant bindings, IGenericBinding binding, string path, float time, float value)
		{
			bool ProcessStreams_frameIndex0 = time != FrameIndex0Time;
			switch ((BindingCustomType)binding.CustomType)
			{
				case BindingCustomType.AnimatorMuscle:
					if (ProcessStreams_frameIndex0)
					{
						AddAnimatorMuscleCurve(binding, time, value);
					}

					break;

				default:
					string attribute = m_customCurveResolver.ToAttributeName((BindingCustomType)binding.CustomType, binding.Attribute, path);
					if (binding.IsPPtrCurve())
					{
						if (!ProcessStreams_frameIndex0)
						{
							time = 0.0f;
						}

						CurveData curve = new CurveData(path, attribute, binding.GetClassID(), binding.Script.FileID, binding.Script.PathID);
						AddPPtrKeyframe(curve, bindings, time, (int)value);
					}
					else if (ProcessStreams_frameIndex0)
					{
						CurveData curve = new CurveData(path, attribute, binding.GetClassID(), binding.Script.FileID, binding.Script.PathID);
						AddFloatKeyframe(curve, time, value);
					}
					break;
			}
		}

		private void AddTransformCurve(float time, TransformType transType, IReadOnlyList<float> curveValues,
			IReadOnlyList<float> inSlopeValues, IReadOnlyList<float> outSlopeValues, int offset, string path)
		{
			switch (transType)
			{
				case TransformType.Translation:
					{
						if (!m_translations.TryGetValue(path, out IVector3Curve? curve))
						{
							curve = m_clip.PositionCurves_C74.AddNew();
							curve.SetValues(path);
							m_translations.Add(path, curve);
						}

						float x = curveValues[offset + 0];
						float y = curveValues[offset + 1];
						float z = curveValues[offset + 2];

						float inX = inSlopeValues[0];
						float inY = inSlopeValues[1];
						float inZ = inSlopeValues[2];

						float outX = outSlopeValues[0];
						float outY = outSlopeValues[1];
						float outZ = outSlopeValues[2];

						IKeyframe_Vector3f key = curve.Curve.Curve.AddNew();

						key.Value.SetValues(x, y, z);
						key.InSlope.SetValues(inX, inY, inZ);
						key.OutSlope.SetValues(outX, outY, outZ);
						key.Time = time;
						// this enum member is version agnostic
						key.TangentMode = TangentMode.FreeFree.ToTangent(Version);
						key.WeightedMode = (int)WeightedMode.None;
						key.InWeight?.SetValues(DefaultFloatWeight, DefaultFloatWeight, DefaultFloatWeight);
						key.OutWeight?.SetValues(DefaultFloatWeight, DefaultFloatWeight, DefaultFloatWeight);
					}
					break;

				case TransformType.Rotation:
					{
						if (!m_rotations.TryGetValue(path, out IQuaternionCurve? curve))
						{
							curve = m_clip.RotationCurves_C74.AddNew();
							curve.SetValues(path);
							m_rotations.Add(path, curve);
						}

						float x = curveValues[offset + 0];
						float y = curveValues[offset + 1];
						float z = curveValues[offset + 2];
						float w = curveValues[offset + 3];

						float inX = inSlopeValues[0];
						float inY = inSlopeValues[1];
						float inZ = inSlopeValues[2];
						float inW = inSlopeValues[3];

						float outX = outSlopeValues[0];
						float outY = outSlopeValues[1];
						float outZ = outSlopeValues[2];
						float outW = outSlopeValues[3];

						IKeyframe_Quaternionf key = curve.Curve.Curve.AddNew();

						key.Value.SetValues(x, y, z, w);
						key.InSlope.SetValues(inX, inY, inZ, inW);
						key.OutSlope.SetValues(outX, outY, outZ, outW);
						key.Time = time;
						// this enum member is version agnostic
						key.TangentMode = TangentMode.FreeFree.ToTangent(Version);
						key.WeightedMode = (int)WeightedMode.None;
						key.InWeight?.SetValues(DefaultFloatWeight, DefaultFloatWeight, DefaultFloatWeight, DefaultFloatWeight);
						key.OutWeight?.SetValues(DefaultFloatWeight, DefaultFloatWeight, DefaultFloatWeight, DefaultFloatWeight);
					}
					break;

				case TransformType.Scaling:
					{
						if (!m_scales.TryGetValue(path, out IVector3Curve? curve))
						{
							curve = m_clip.ScaleCurves_C74.AddNew();
							curve.SetValues(path);
							m_scales.Add(path, curve);
						}

						float x = curveValues[offset + 0];
						float y = curveValues[offset + 1];
						float z = curveValues[offset + 2];

						float inX = inSlopeValues[0];
						float inY = inSlopeValues[1];
						float inZ = inSlopeValues[2];

						float outX = outSlopeValues[0];
						float outY = outSlopeValues[1];
						float outZ = outSlopeValues[2];

						IKeyframe_Vector3f key = curve.Curve.Curve.AddNew();

						key.Value.SetValues(x, y, z);
						key.InSlope.SetValues(inX, inY, inZ);
						key.OutSlope.SetValues(outX, outY, outZ);
						key.Time = time;
						// this enum member is version agnostic
						key.TangentMode = TangentMode.FreeFree.ToTangent(Version);
						key.WeightedMode = (int)WeightedMode.None;
						key.InWeight?.SetValues(DefaultFloatWeight, DefaultFloatWeight, DefaultFloatWeight);
						key.OutWeight?.SetValues(DefaultFloatWeight, DefaultFloatWeight, DefaultFloatWeight);
					}
					break;

				case TransformType.EulerRotation:
					{
						if (!m_eulers.TryGetValue(path, out IVector3Curve? curve))
						{
							if (!m_clip.Has_EulerCurves_C74())
							{
								break;
							}
							curve = m_clip.EulerCurves_C74.AddNew();
							curve.SetValues(path);
							m_eulers.Add(path, curve);
						}

						float x = curveValues[offset + 0];
						float y = curveValues[offset + 1];
						float z = curveValues[offset + 2];

						float inX = inSlopeValues[0];
						float inY = inSlopeValues[1];
						float inZ = inSlopeValues[2];

						float outX = outSlopeValues[0];
						float outY = outSlopeValues[1];
						float outZ = outSlopeValues[2];

						IKeyframe_Vector3f key = curve.Curve.Curve.AddNew();

						key.Value.SetValues(x, y, z);
						key.InSlope.SetValues(inX, inY, inZ);
						key.OutSlope.SetValues(outX, outY, outZ);
						key.Time = time;
						// this enum member is version agnostic
						key.TangentMode = TangentMode.FreeFree.ToTangent(Version);
						key.WeightedMode = (int)WeightedMode.None;
						key.InWeight?.SetValues(DefaultFloatWeight, DefaultFloatWeight, DefaultFloatWeight);
						key.OutWeight?.SetValues(DefaultFloatWeight, DefaultFloatWeight, DefaultFloatWeight);
					}
					break;

				default:
					throw new NotImplementedException(transType.ToString());
			}
		}

		private void AddDefaultCurve(IGenericBinding binding, string path, float time, float value)
		{
			switch (binding.GetClassID())
			{
				case ClassIDType.GameObject:
					{
						AddGameObjectCurve(binding, path, time, value);
					}
					break;

				case ClassIDType.MonoBehaviour:
					{
						AddScriptCurve(binding, path, time, value);
					}
					break;

				default:
					AddEngineCurve(binding, path, time, value);
					break;
			}
		}

		private void AddGameObjectCurve(IGenericBinding binding, string path, float time, float value)
		{
			if (binding.Attribute == CrcUtils.CalculateDigestAscii("m_IsActive"))
			{
				CurveData curve = new CurveData(path, "m_IsActive", ClassIDType.GameObject);
				AddFloatKeyframe(curve, time, value);
				return;
			}
			else
			{
				// that means that dev exported animation clip with missing component
				CurveData curve = new CurveData(path, MissedPropertyPrefix + binding.Attribute, ClassIDType.GameObject);
				AddFloatKeyframe(curve, time, value);
			}
		}

		private void AddScriptCurve(IGenericBinding binding, string path, float time, float value)
		{
#warning TODO:
			if (GenshinUtils.animPathHash.ContainsKey(binding.Attribute))
			{
				CurveData curve1 = new CurveData(path, GenshinUtils.animPathHash[binding.Attribute], ClassIDType.MonoBehaviour, binding.Script.FileID, binding.Script.PathID);
				AddFloatKeyframe(curve1, time, value);
				return;
			}
				Logger.Warning("检查到未知hash: " + ScriptPropertyPrefix + binding.Attribute);
			CurveData curve = new CurveData(path, ScriptPropertyPrefix + binding.Attribute, ClassIDType.MonoBehaviour, binding.Script.FileID, binding.Script.PathID);
			AddFloatKeyframe(curve, time, value);
		}

		private void AddEngineCurve(IGenericBinding binding, string path, float time, float value)
		{
#warning TODO:
			if (GenshinUtils.animPathHash.ContainsKey(binding.Attribute))
			{
				CurveData curve1 = new CurveData(path, GenshinUtils.animPathHash[binding.Attribute], ClassIDType.MonoBehaviour, binding.Script.FileID, binding.Script.PathID);
				AddFloatKeyframe(curve1, time, value);
				return;
			}
				Logger.Warning("检查到未知hash" + TypeTreePropertyPrefix + binding.Attribute);
			CurveData curve = new CurveData(path, TypeTreePropertyPrefix + binding.Attribute, binding.GetClassID());
			AddFloatKeyframe(curve, time, value);
		}

		private void AddAnimatorMuscleCurve(IGenericBinding binding, float time, float value)
		{
			string attributeString = HumanoidMuscleTypeExtensions.ToAttributeString(binding.GetHumanoidMuscle(Version));
			CurveData curve = new CurveData(string.Empty, attributeString, ClassIDType.Animator);
			AddFloatKeyframe(curve, time, value);
		}

		private void AddFloatKeyframe(CurveData curveData, float time, float value)
		{
			if (!m_floats.TryGetValue(curveData, out IFloatCurve? curve))
			{
				curve = m_clip.FloatCurves_C74.AddNew();
				curve.Path.String = curveData.path;
				curve.Attribute.String = curveData.attribute;
				curve.ClassID = (int)curveData.classId;
				curve.Script.FileID = curveData.fileId;
				curve.Script.PathID = curveData.pathId;
				curve.Curve.SetDefaultRotationOrderAndCurveLoopType();
				m_floats.Add(curveData, curve);
			}

			IKeyframe_Single floatKey = curve.Curve.Curve.AddNew();
			floatKey.SetValues(Version, time, value, DefaultFloatWeight);
		}

		private void AddPPtrKeyframe(CurveData curveData, IAnimationClipBindingConstant bindings, float time, int index)
		{
			if (!m_pptrs.TryGetValue(curveData, out IPPtrCurve? curve))
			{
				if (!m_clip.Has_PPtrCurves_C74())
				{
					return;
				}
				curve = m_clip.PPtrCurves_C74.AddNew();
				curve.Path.String = curveData.path;
				curve.Attribute.String = curveData.attribute;
				curve.ClassID = (int)curveData.classId;
				curve.Script.FileID = curveData.fileId;
				curve.Script.PathID = curveData.pathId;
				m_pptrs.Add(curveData, curve);
			}

			IPPtr_Object value = bindings.PptrCurveMapping[index];
			IPPtrKeyframe key = curve.Curve.AddNew();
			key.Time = time;
			key.Value.FileID = value.FileID;
			key.Value.PathID = value.PathID;
		}

		private static void GetPreviousFrame(IReadOnlyList<StreamedFrame> streamFrames, int curveID, int currentFrame, out int frameIndex, out int curveIndex)
		{
			for (frameIndex = currentFrame - 1; frameIndex >= 0; frameIndex--)
			{
				StreamedFrame frame = streamFrames[frameIndex];
				for (curveIndex = 0; curveIndex < frame.Curves.Length; curveIndex++)
				{
					StreamedCurveKey curve = frame.Curves[curveIndex];
					if (curve.Index == curveID)
					{
						return;
					}
				}
			}
			throw new Exception($"There is no curve with index {curveID} in any of previous frames");
		}

		private static int GetNextCurve(StreamedFrame frame, int currentCurve)
		{
			StreamedCurveKey curve = frame.Curves[currentCurve];
			int i = currentCurve + 1;
			for (; i < frame.Curves.Length; i++)
			{
				if (frame.Curves[i].Index != curve.Index)
				{
					return i;
				}
			}
			return i;
		}

		private static string GetCurvePath(IReadOnlyDictionary<uint, string> tos, uint hash)
		{
			if (tos.TryGetValue(hash, out string? path))
			{
				return path;
			}
			else if (GenshinUtils.animPathHash.ContainsKey(hash))
			{
				return GenshinUtils.animPathHash[hash];
			}
			else
			{
				Logger.Warning("检查到未知hash: " + UnknownPathPrefix + hash);
				return UnknownPathPrefix + hash;
			}
		}

		public IReadOnlyList<StreamedFrame> GenerateFramesFromStreamedClip(StreamedClip clip)
		{
			List<StreamedFrame> frames = new List<StreamedFrame>();
			byte[] memStreamBuffer = new byte[clip.Data.Length * sizeof(uint)];
			Buffer.BlockCopy(clip.Data, 0, memStreamBuffer, 0, memStreamBuffer.Length);
			using MemoryStream stream = new MemoryStream(memStreamBuffer);
			using AssetReader reader = new AssetReader(stream, m_clip.Collection);
			while (reader.BaseStream.Position < reader.BaseStream.Length)
			{
				StreamedFrame frame = new StreamedFrame();
				frame.Read(reader);
				frames.Add(frame);
			}
			return frames;
		}

		private UnityVersion Version => m_clip.Collection.Version;

		public static readonly Regex UnknownPathRegex = new Regex($@"^{UnknownPathPrefix}[0-9]{{1,10}}$", RegexOptions.Compiled);

		private const string UnknownPathPrefix = "path_";
		private const string MissedPropertyPrefix = "missed_";
		private const string ScriptPropertyPrefix = "script_";
		private const string TypeTreePropertyPrefix = "typetree_";

		/// <summary>
		/// Used to detect when a StreamedFrame is from index 0.
		/// </summary>
		private const float FrameIndex0Time = float.MinValue;

		private readonly Dictionary<string, IVector3Curve> m_translations = new();
		private readonly Dictionary<string, IQuaternionCurve> m_rotations = new();
		private readonly Dictionary<string, IVector3Curve> m_scales = new();
		private readonly Dictionary<string, IVector3Curve> m_eulers = new();
		private readonly Dictionary<CurveData, IFloatCurve> m_floats = new();
		private readonly Dictionary<CurveData, IPPtrCurve> m_pptrs = new();

		private readonly IAnimationClip_ACL m_clip;
		private readonly CustomCurveResolver_ACL m_customCurveResolver;
		private const float DefaultFloatWeight = 1.0f / 3.0f;
	}
}
