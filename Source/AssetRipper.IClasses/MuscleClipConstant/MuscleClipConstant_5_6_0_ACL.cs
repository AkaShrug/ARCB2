using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using AssetRipper.Assets;
using AssetRipper.Assets.Cloning;
using AssetRipper.Assets.Export;
using AssetRipper.Assets.Export.Dependencies;
using AssetRipper.Assets.Export.Yaml;
using AssetRipper.Assets.Generics;
using AssetRipper.Assets.Interfaces;
using AssetRipper.Assets.IO;
using AssetRipper.Assets.IO.Reading;
using AssetRipper.Assets.IO.Writing;
using AssetRipper.Assets.Metadata;
using AssetRipper.IO.Files.SerializedFiles.Parser.TypeTrees;
using AssetRipper.IClasses.OffsetPtr_Clip;
using AssetRipper.SourceGenerated.Helpers;
using AssetRipper.SourceGenerated.Subclasses.HumanPose;
using AssetRipper.SourceGenerated.Subclasses.ValueDelta;
using AssetRipper.SourceGenerated.Subclasses.Vector3Float;
using AssetRipper.SourceGenerated.Subclasses.Vector4Float;
using AssetRipper.SourceGenerated.Subclasses.Xform;
using AssetRipper.Yaml;

namespace AssetRipper.IClasses.MuscleClipConstant
{
	// Token: 0x020007B1 RID: 1969


	public sealed class MuscleClipConstant_5_6_0_ACL : UnityAssetBase, IMuscleClipConstant_ACL, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IEquatable<IMuscleClipConstant_ACL>, IEquatable<MuscleClipConstant_5_6_0_ACL>
	{
		// Token: 0x170034AB RID: 13483
		// (get) Token: 0x0600CFD1 RID: 53201 RVA: 0x001F1549 File Offset: 0x001EF749
		// (set) Token: 0x0600CFD2 RID: 53202 RVA: 0x001F154C File Offset: 0x001EF74C

		public int[] AdditionalCurveIndexArray
		{

			get
			{
				return null;
			}

			set
			{
			}
		}

		// Token: 0x170034AC RID: 13484
		// (get) Token: 0x0600CFD3 RID: 53203 RVA: 0x001F154E File Offset: 0x001EF74E
		// (set) Token: 0x0600CFD4 RID: 53204 RVA: 0x001F1556 File Offset: 0x001EF756
		public float AverageAngularSpeed
		{
			get
			{
				return this.m_AverageAngularSpeed;
			}
			set
			{
				this.m_AverageAngularSpeed = value;
			}
		}

		// Token: 0x170034AD RID: 13485
		// (get) Token: 0x0600CFD5 RID: 53205 RVA: 0x001F155F File Offset: 0x001EF75F

		public IVector3Float AverageSpeed3
		{

			[return: NotNull]
			get
			{
				return this.m_AverageSpeed3;
			}
		}

		// Token: 0x170034AE RID: 13486
		// (get) Token: 0x0600CFD6 RID: 53206 RVA: 0x001F1567 File Offset: 0x001EF767

		public Vector4Float_4_0_0 AverageSpeed4
		{

			get
			{
				return null;
			}
		}

		// Token: 0x170034AF RID: 13487
		// (get) Token: 0x0600CFD7 RID: 53207 RVA: 0x001F156A File Offset: 0x001EF76A
		public IOffsetPtr_Clip_ACL Clip
		{
			get
			{
				return this.m_Clip;
			}
		}

		// Token: 0x170034B0 RID: 13488
		// (get) Token: 0x0600CFD8 RID: 53208 RVA: 0x001F1572 File Offset: 0x001EF772
		// (set) Token: 0x0600CFD9 RID: 53209 RVA: 0x001F157A File Offset: 0x001EF77A
		public float CycleOffset
		{
			get
			{
				return this.m_CycleOffset;
			}
			set
			{
				this.m_CycleOffset = value;
			}
		}

		// Token: 0x170034B1 RID: 13489
		// (get) Token: 0x0600CFDA RID: 53210 RVA: 0x001F1583 File Offset: 0x001EF783
		public IHumanPose DeltaPose
		{
			get
			{
				return this.m_DeltaPose;
			}
		}

		// Token: 0x170034B2 RID: 13490
		// (get) Token: 0x0600CFDB RID: 53211 RVA: 0x001F158B File Offset: 0x001EF78B
		// (set) Token: 0x0600CFDC RID: 53212 RVA: 0x001F1593 File Offset: 0x001EF793
		public bool HeightFromFeet
		{
			get
			{
				return this.m_HeightFromFeet;
			}
			set
			{
				this.m_HeightFromFeet = value;
			}
		}

		// Token: 0x170034B3 RID: 13491
		// (get) Token: 0x0600CFDD RID: 53213 RVA: 0x001F159C File Offset: 0x001EF79C
		// (set) Token: 0x0600CFDE RID: 53214 RVA: 0x001F15A4 File Offset: 0x001EF7A4
		public int[] IndexArray
		{
			get
			{
				return this.m_IndexArray;
			}
			set
			{
				this.m_IndexArray = value;
			}
		}

		// Token: 0x170034B4 RID: 13492
		// (get) Token: 0x0600CFDF RID: 53215 RVA: 0x001F15AD File Offset: 0x001EF7AD
		// (set) Token: 0x0600CFE0 RID: 53216 RVA: 0x001F15B5 File Offset: 0x001EF7B5
		public bool KeepOriginalOrientation
		{
			get
			{
				return this.m_KeepOriginalOrientation;
			}
			set
			{
				this.m_KeepOriginalOrientation = value;
			}
		}

		// Token: 0x170034B5 RID: 13493
		// (get) Token: 0x0600CFE1 RID: 53217 RVA: 0x001F15BE File Offset: 0x001EF7BE
		// (set) Token: 0x0600CFE2 RID: 53218 RVA: 0x001F15C6 File Offset: 0x001EF7C6
		public bool KeepOriginalPositionXZ
		{
			get
			{
				return this.m_KeepOriginalPositionXZ;
			}
			set
			{
				this.m_KeepOriginalPositionXZ = value;
			}
		}

		// Token: 0x170034B6 RID: 13494
		// (get) Token: 0x0600CFE3 RID: 53219 RVA: 0x001F15CF File Offset: 0x001EF7CF
		// (set) Token: 0x0600CFE4 RID: 53220 RVA: 0x001F15D7 File Offset: 0x001EF7D7
		public bool KeepOriginalPositionY
		{
			get
			{
				return this.m_KeepOriginalPositionY;
			}
			set
			{
				this.m_KeepOriginalPositionY = value;
			}
		}

		// Token: 0x170034B7 RID: 13495
		// (get) Token: 0x0600CFE5 RID: 53221 RVA: 0x001F15E0 File Offset: 0x001EF7E0
		public IXform LeftFootStartX
		{
			get
			{
				return this.m_LeftFootStartX;
			}
		}

		// Token: 0x170034B8 RID: 13496
		// (get) Token: 0x0600CFE6 RID: 53222 RVA: 0x001F15E8 File Offset: 0x001EF7E8
		// (set) Token: 0x0600CFE7 RID: 53223 RVA: 0x001F15F0 File Offset: 0x001EF7F0
		public float Level
		{
			get
			{
				return this.m_Level;
			}
			set
			{
				this.m_Level = value;
			}
		}

		// Token: 0x170034B9 RID: 13497
		// (get) Token: 0x0600CFE8 RID: 53224 RVA: 0x001F15F9 File Offset: 0x001EF7F9
		// (set) Token: 0x0600CFE9 RID: 53225 RVA: 0x001F1601 File Offset: 0x001EF801
		public bool LoopBlend
		{
			get
			{
				return this.m_LoopBlend;
			}
			set
			{
				this.m_LoopBlend = value;
			}
		}

		// Token: 0x170034BA RID: 13498
		// (get) Token: 0x0600CFEA RID: 53226 RVA: 0x001F160A File Offset: 0x001EF80A
		// (set) Token: 0x0600CFEB RID: 53227 RVA: 0x001F1612 File Offset: 0x001EF812
		public bool LoopBlendOrientation
		{
			get
			{
				return this.m_LoopBlendOrientation;
			}
			set
			{
				this.m_LoopBlendOrientation = value;
			}
		}

		// Token: 0x170034BB RID: 13499
		// (get) Token: 0x0600CFEC RID: 53228 RVA: 0x001F161B File Offset: 0x001EF81B
		// (set) Token: 0x0600CFED RID: 53229 RVA: 0x001F1623 File Offset: 0x001EF823
		public bool LoopBlendPositionXZ
		{
			get
			{
				return this.m_LoopBlendPositionXZ;
			}
			set
			{
				this.m_LoopBlendPositionXZ = value;
			}
		}

		// Token: 0x170034BC RID: 13500
		// (get) Token: 0x0600CFEE RID: 53230 RVA: 0x001F162C File Offset: 0x001EF82C
		// (set) Token: 0x0600CFEF RID: 53231 RVA: 0x001F1634 File Offset: 0x001EF834
		public bool LoopBlendPositionY
		{
			get
			{
				return this.m_LoopBlendPositionY;
			}
			set
			{
				this.m_LoopBlendPositionY = value;
			}
		}

		// Token: 0x170034BD RID: 13501
		// (get) Token: 0x0600CFF0 RID: 53232 RVA: 0x001F163D File Offset: 0x001EF83D
		// (set) Token: 0x0600CFF1 RID: 53233 RVA: 0x001F1645 File Offset: 0x001EF845
		public bool LoopTime
		{
			get
			{
				return this.m_LoopTime;
			}
			set
			{
				this.m_LoopTime = value;
			}
		}

		// Token: 0x170034BE RID: 13502
		// (get) Token: 0x0600CFF2 RID: 53234 RVA: 0x001F164E File Offset: 0x001EF84E
		// (set) Token: 0x0600CFF3 RID: 53235 RVA: 0x001F1656 File Offset: 0x001EF856
		public bool Mirror
		{
			get
			{
				return this.m_Mirror;
			}
			set
			{
				this.m_Mirror = value;
			}
		}

		// Token: 0x170034BF RID: 13503
		// (get) Token: 0x0600CFF4 RID: 53236 RVA: 0x001F165F File Offset: 0x001EF85F

		public Xform_4_0_0 MotionStartX
		{

			get
			{
				return null;
			}
		}

		// Token: 0x170034C0 RID: 13504
		// (get) Token: 0x0600CFF5 RID: 53237 RVA: 0x001F1662 File Offset: 0x001EF862

		public Xform_4_0_0 MotionStopX
		{

			get
			{
				return null;
			}
		}

		// Token: 0x170034C1 RID: 13505
		// (get) Token: 0x0600CFF6 RID: 53238 RVA: 0x001F1665 File Offset: 0x001EF865
		// (set) Token: 0x0600CFF7 RID: 53239 RVA: 0x001F166D File Offset: 0x001EF86D
		public float OrientationOffsetY
		{
			get
			{
				return this.m_OrientationOffsetY;
			}
			set
			{
				this.m_OrientationOffsetY = value;
			}
		}

		// Token: 0x170034C2 RID: 13506
		// (get) Token: 0x0600CFF8 RID: 53240 RVA: 0x001F1676 File Offset: 0x001EF876
		public IXform RightFootStartX
		{
			get
			{
				return this.m_RightFootStartX;
			}
		}

		// Token: 0x170034C3 RID: 13507
		// (get) Token: 0x0600CFF9 RID: 53241 RVA: 0x001F167E File Offset: 0x001EF87E
		// (set) Token: 0x0600CFFA RID: 53242 RVA: 0x001F1686 File Offset: 0x001EF886
		public bool StartAtOrigin
		{
			get
			{
				return this.m_StartAtOrigin;
			}
			set
			{
				this.m_StartAtOrigin = value;
			}
		}

		// Token: 0x170034C4 RID: 13508
		// (get) Token: 0x0600CFFB RID: 53243 RVA: 0x001F168F File Offset: 0x001EF88F
		// (set) Token: 0x0600CFFC RID: 53244 RVA: 0x001F1697 File Offset: 0x001EF897
		public float StartTime
		{
			get
			{
				return this.m_StartTime;
			}
			set
			{
				this.m_StartTime = value;
			}
		}

		// Token: 0x170034C5 RID: 13509
		// (get) Token: 0x0600CFFD RID: 53245 RVA: 0x001F16A0 File Offset: 0x001EF8A0
		public IXform StartX
		{
			get
			{
				return this.m_StartX;
			}
		}

		// Token: 0x170034C6 RID: 13510
		// (get) Token: 0x0600CFFE RID: 53246 RVA: 0x001F16A8 File Offset: 0x001EF8A8
		// (set) Token: 0x0600CFFF RID: 53247 RVA: 0x001F16B0 File Offset: 0x001EF8B0
		public float StopTime
		{
			get
			{
				return this.m_StopTime;
			}
			set
			{
				this.m_StopTime = value;
			}
		}

		// Token: 0x170034C7 RID: 13511
		// (get) Token: 0x0600D000 RID: 53248 RVA: 0x001F16B9 File Offset: 0x001EF8B9

		public Xform_5_5_0 StopX
		{

			[return: NotNull]
			get
			{
				return this.m_StopX;
			}
		}

		// Token: 0x170034C8 RID: 13512
		// (get) Token: 0x0600D001 RID: 53249 RVA: 0x001F16C1 File Offset: 0x001EF8C1
		public AssetList<ValueDelta> ValueArrayDelta
		{
			get
			{
				return this.m_ValueArrayDelta;
			}
		}

		// Token: 0x170034C9 RID: 13513
		// (get) Token: 0x0600D002 RID: 53250 RVA: 0x001F16C9 File Offset: 0x001EF8C9
		// (set) Token: 0x0600D003 RID: 53251 RVA: 0x001F16D1 File Offset: 0x001EF8D1

		public float[] ValueArrayReferencePose
		{

			[return: NotNull]
			get
			{
				return this.m_ValueArrayReferencePose;
			}

			set
			{
				this.m_ValueArrayReferencePose = value ?? Array.Empty<float>();
			}
		}

		// Token: 0x0600D004 RID: 53252 RVA: 0x001F16E4 File Offset: 0x001EF8E4
		public MuscleClipConstant_5_6_0_ACL()
		{
			this.m_DeltaPose = new HumanPose_5_5_0();
			this.m_StartX = new Xform_5_5_0();
			this.m_StopX = new Xform_5_5_0();
			this.m_LeftFootStartX = new Xform_5_5_0();
			this.m_RightFootStartX = new Xform_5_5_0();
			this.m_AverageSpeed3 = new Vector3Float_5_5_0();
			this.m_Clip = new OffsetPtr_Clip_5_5_0_ACL();
			this.m_IndexArray = Array.Empty<int>();
			this.m_ValueArrayDelta = new AssetList<ValueDelta>();
			this.m_ValueArrayReferencePose = Array.Empty<float>();
		}

		// Token: 0x0600D005 RID: 53253 RVA: 0x001F1765 File Offset: 0x001EF965
		public bool Has_AdditionalCurveIndexArray()
		{
			return false;
		}

		// Token: 0x0600D006 RID: 53254 RVA: 0x001F1768 File Offset: 0x001EF968
		public bool Has_AverageSpeed3()
		{
			return true;
		}

		// Token: 0x0600D007 RID: 53255 RVA: 0x001F176B File Offset: 0x001EF96B
		public bool Has_AverageSpeed4()
		{
			return false;
		}

		// Token: 0x0600D008 RID: 53256 RVA: 0x001F176E File Offset: 0x001EF96E
		public bool Has_LoopTime()
		{
			return true;
		}

		// Token: 0x0600D009 RID: 53257 RVA: 0x001F1771 File Offset: 0x001EF971
		public bool Has_MotionStartX()
		{
			return false;
		}

		// Token: 0x0600D00A RID: 53258 RVA: 0x001F1774 File Offset: 0x001EF974
		public bool Has_MotionStopX()
		{
			return false;
		}

		// Token: 0x0600D00B RID: 53259 RVA: 0x001F1777 File Offset: 0x001EF977
		public bool Has_StartAtOrigin()
		{
			return true;
		}

		// Token: 0x0600D00C RID: 53260 RVA: 0x001F177A File Offset: 0x001EF97A
		public bool Has_StopX()
		{
			return true;
		}

		// Token: 0x0600D00D RID: 53261 RVA: 0x001F177D File Offset: 0x001EF97D
		public bool Has_ValueArrayReferencePose()
		{
			return true;
		}

		// Token: 0x0600D00E RID: 53262 RVA: 0x001F1780 File Offset: 0x001EF980
		public override void ReadRelease(AssetReader reader)
		{
			this.m_DeltaPose.ReadRelease(reader);
			this.m_StartX.ReadRelease(reader);
			this.m_StopX.ReadRelease(reader);
			this.m_LeftFootStartX.ReadRelease(reader);
			this.m_RightFootStartX.ReadRelease(reader);
			this.m_AverageSpeed3.ReadRelease(reader);
			this.m_Clip.ReadRelease(reader);
			this.m_StartTime = reader.ReadSingle();
			this.m_StopTime = reader.ReadSingle();
			this.m_OrientationOffsetY = reader.ReadSingle();
			this.m_Level = reader.ReadSingle();
			this.m_CycleOffset = reader.ReadSingle();
			this.m_AverageAngularSpeed = reader.ReadSingle();
			this.m_IndexArray = reader.ReadRelease_Array_Int32();
			this.m_ValueArrayDelta.ReadRelease_Array_Asset(reader);
			this.m_ValueArrayReferencePose = reader.ReadRelease_Array_Single();
			this.m_Mirror = reader.ReadBoolean();
			this.m_LoopTime = reader.ReadBoolean();
			this.m_LoopBlend = reader.ReadBoolean();
			this.m_LoopBlendOrientation = reader.ReadBoolean();
			this.m_LoopBlendPositionY = reader.ReadBoolean();
			this.m_LoopBlendPositionXZ = reader.ReadBoolean();
			this.m_StartAtOrigin = reader.ReadBoolean();
			this.m_KeepOriginalOrientation = reader.ReadBoolean();
			this.m_KeepOriginalPositionY = reader.ReadBoolean();
			this.m_KeepOriginalPositionXZ = reader.ReadBoolean();
			this.m_HeightFromFeet = reader.ReadRelease_BooleanAlign();
		}

		// Token: 0x0600D00F RID: 53263 RVA: 0x001F18D1 File Offset: 0x001EFAD1
		public override void ReadEditor(AssetReader reader)
		{
		}

		// Token: 0x0600D010 RID: 53264 RVA: 0x001F18D4 File Offset: 0x001EFAD4
		public override void WriteRelease(AssetWriter writer)
		{
			this.m_DeltaPose.WriteRelease(writer);
			this.m_StartX.WriteRelease(writer);
			this.m_StopX.WriteRelease(writer);
			this.m_LeftFootStartX.WriteRelease(writer);
			this.m_RightFootStartX.WriteRelease(writer);
			this.m_AverageSpeed3.WriteRelease(writer);
			this.m_Clip.WriteRelease(writer);
			this.m_StartTime.WriteRelease_Single(writer);
			this.m_StopTime.WriteRelease_Single(writer);
			this.m_OrientationOffsetY.WriteRelease_Single(writer);
			this.m_Level.WriteRelease_Single(writer);
			this.m_CycleOffset.WriteRelease_Single(writer);
			this.m_AverageAngularSpeed.WriteRelease_Single(writer);
			this.m_IndexArray.WriteRelease_Array_Int32(writer);
			this.m_ValueArrayDelta.WriteRelease_Array_Asset(writer);
			this.m_ValueArrayReferencePose.WriteRelease_Array_Single(writer);
			this.m_Mirror.WriteRelease_Boolean(writer);
			this.m_LoopTime.WriteRelease_Boolean(writer);
			this.m_LoopBlend.WriteRelease_Boolean(writer);
			this.m_LoopBlendOrientation.WriteRelease_Boolean(writer);
			this.m_LoopBlendPositionY.WriteRelease_Boolean(writer);
			this.m_LoopBlendPositionXZ.WriteRelease_Boolean(writer);
			this.m_StartAtOrigin.WriteRelease_Boolean(writer);
			this.m_KeepOriginalOrientation.WriteRelease_Boolean(writer);
			this.m_KeepOriginalPositionY.WriteRelease_Boolean(writer);
			this.m_KeepOriginalPositionXZ.WriteRelease_Boolean(writer);
			this.m_HeightFromFeet.WriteRelease_BooleanAlign(writer);
		}

		// Token: 0x0600D011 RID: 53265 RVA: 0x001F1A25 File Offset: 0x001EFC25
		public override void WriteEditor(AssetWriter writer)
		{
		}

		// Token: 0x0600D012 RID: 53266 RVA: 0x001F1A28 File Offset: 0x001EFC28
		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 3);
			yamlMappingNode.Add(new YamlScalarNode("m_DeltaPose"), this.m_DeltaPose.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_StartX"), this.m_StartX.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_StopX"), this.m_StopX.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LeftFootStartX"), this.m_LeftFootStartX.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_RightFootStartX"), this.m_RightFootStartX.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AverageSpeed"), this.m_AverageSpeed3.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Clip"), this.m_Clip.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_StartTime"), this.m_StartTime.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_StopTime"), this.m_StopTime.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_OrientationOffsetY"), this.m_OrientationOffsetY.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Level"), this.m_Level.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_CycleOffset"), this.m_CycleOffset.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AverageAngularSpeed"), this.m_AverageAngularSpeed.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_IndexArray"), this.m_IndexArray.ExportYamlRelease_Array_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ValueArrayDelta"), this.m_ValueArrayDelta.ExportYamlRelease_Array_ValueDelta(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ValueArrayReferencePose"), this.m_ValueArrayReferencePose.ExportYamlRelease_Array_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Mirror"), this.m_Mirror.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LoopTime"), this.m_LoopTime.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LoopBlend"), this.m_LoopBlend.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LoopBlendOrientation"), this.m_LoopBlendOrientation.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LoopBlendPositionY"), this.m_LoopBlendPositionY.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LoopBlendPositionXZ"), this.m_LoopBlendPositionXZ.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_StartAtOrigin"), this.m_StartAtOrigin.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_KeepOriginalOrientation"), this.m_KeepOriginalOrientation.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_KeepOriginalPositionY"), this.m_KeepOriginalPositionY.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_KeepOriginalPositionXZ"), this.m_KeepOriginalPositionXZ.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_HeightFromFeet"), this.m_HeightFromFeet.ExportYamlRelease_Boolean(container));
			return yamlMappingNode;
		}

		// Token: 0x0600D013 RID: 53267 RVA: 0x001F1D35 File Offset: 0x001EFF35
		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			return new YamlMappingNode();
		}

		// Token: 0x0600D014 RID: 53268 RVA: 0x001F1D3C File Offset: 0x001EFF3C
		public override void Reset()
		{
			this.m_AverageAngularSpeed = 0f;
			this.m_AverageSpeed3.Reset();
			this.m_Clip.Reset();
			this.m_CycleOffset = 0f;
			this.m_DeltaPose.Reset();
			this.m_HeightFromFeet = false;
			this.m_IndexArray = Array.Empty<int>();
			this.m_KeepOriginalOrientation = false;
			this.m_KeepOriginalPositionXZ = false;
			this.m_KeepOriginalPositionY = false;
			this.m_LeftFootStartX.Reset();
			this.m_Level = 0f;
			this.m_LoopBlend = false;
			this.m_LoopBlendOrientation = false;
			this.m_LoopBlendPositionXZ = false;
			this.m_LoopBlendPositionY = false;
			this.m_LoopTime = false;
			this.m_Mirror = false;
			this.m_OrientationOffsetY = 0f;
			this.m_RightFootStartX.Reset();
			this.m_StartAtOrigin = false;
			this.m_StartTime = 0f;
			this.m_StartX.Reset();
			this.m_StopTime = 0f;
			this.m_StopX.Reset();
			this.m_ValueArrayDelta.Clear();
			this.m_ValueArrayReferencePose = Array.Empty<float>();
		}

		// Token: 0x0600D015 RID: 53269 RVA: 0x001F1E46 File Offset: 0x001F0046

		public override IEnumerable<ValueTuple<FieldName, PPtr<IUnityObjectBase>>> FetchDependencies(FieldName parent)
		{
			return Enumerable.Empty<ValueTuple<FieldName, PPtr<IUnityObjectBase>>>();
		}

		// Token: 0x0600D016 RID: 53270 RVA: 0x001F1E50 File Offset: 0x001F0050

		public void CopyValues(IMuscleClipConstant_ACL source)
		{
			if (source != null)
			{
				this.m_AverageAngularSpeed = source.AverageAngularSpeed;
				this.m_AverageSpeed3.CopyValues(source.AverageSpeed3);
				this.m_Clip.CopyValues(source.Clip);
				this.m_CycleOffset = source.CycleOffset;
				this.m_DeltaPose.CopyValues(source.DeltaPose);
				this.m_HeightFromFeet = source.HeightFromFeet;
				this.m_IndexArray = CopyValuesHelper.DuplicateArray<int>(source.IndexArray);
				this.m_KeepOriginalOrientation = source.KeepOriginalOrientation;
				this.m_KeepOriginalPositionXZ = source.KeepOriginalPositionXZ;
				this.m_KeepOriginalPositionY = source.KeepOriginalPositionY;
				this.m_LeftFootStartX.CopyValues(source.LeftFootStartX);
				this.m_Level = source.Level;
				this.m_LoopBlend = source.LoopBlend;
				this.m_LoopBlendOrientation = source.LoopBlendOrientation;
				this.m_LoopBlendPositionXZ = source.LoopBlendPositionXZ;
				this.m_LoopBlendPositionY = source.LoopBlendPositionY;
				this.m_LoopTime = source.LoopTime;
				this.m_Mirror = source.Mirror;
				this.m_OrientationOffsetY = source.OrientationOffsetY;
				this.m_RightFootStartX.CopyValues(source.RightFootStartX);
				this.m_StartAtOrigin = source.StartAtOrigin;
				this.m_StartTime = source.StartTime;
				this.m_StartX.CopyValues(source.StartX);
				this.m_StopTime = source.StopTime;
				this.m_StopX.CopyValues(source.StopX);
				CopyValuesHelper.CopyValues__AssetList_ValueDelta__AssetList_ValueDelta(this.m_ValueArrayDelta, source.ValueArrayDelta);
				this.m_ValueArrayReferencePose = CopyValuesHelper.DuplicateArray<float>(source.ValueArrayReferencePose);
				return;
			}
			this.Reset();
		}

		// Token: 0x0600D017 RID: 53271 RVA: 0x001F1FE0 File Offset: 0x001F01E0
		public IMuscleClipConstant_ACL DeepClone()
		{
			MuscleClipConstant_5_6_0_ACL muscleClipConstant_5_6_0_f = new MuscleClipConstant_5_6_0_ACL();
			muscleClipConstant_5_6_0_f.CopyValues(this);
			return muscleClipConstant_5_6_0_f;
		}

		// Token: 0x0600D018 RID: 53272 RVA: 0x001F1FF0 File Offset: 0x001F01F0

		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			IMuscleClipConstant_ACL muscleClipConstant = source as IMuscleClipConstant_ACL;
			if (muscleClipConstant != null)
			{
				this.CopyValues(muscleClipConstant);
				return;
			}
			this.Reset();
		}

		// Token: 0x0600D019 RID: 53273 RVA: 0x001F2018 File Offset: 0x001F0218

		public bool Equals(IMuscleClipConstant_ACL other)
		{
			return other != null && EqualityComparer<int[]>.Default.Equals(this.AdditionalCurveIndexArray, other.AdditionalCurveIndexArray) && this.AverageAngularSpeed == other.AverageAngularSpeed && EqualityComparer<IVector3Float>.Default.Equals(this.AverageSpeed3, other.AverageSpeed3) && EqualityComparer<Vector4Float_4_0_0>.Default.Equals(this.AverageSpeed4, other.AverageSpeed4) && EqualityComparer<IOffsetPtr_Clip_ACL>.Default.Equals(this.Clip, other.Clip) && this.CycleOffset == other.CycleOffset && EqualityComparer<IHumanPose>.Default.Equals(this.DeltaPose, other.DeltaPose) && this.HeightFromFeet == other.HeightFromFeet && EqualityComparer<int[]>.Default.Equals(this.IndexArray, other.IndexArray) && this.KeepOriginalOrientation == other.KeepOriginalOrientation && this.KeepOriginalPositionXZ == other.KeepOriginalPositionXZ && this.KeepOriginalPositionY == other.KeepOriginalPositionY && EqualityComparer<IXform>.Default.Equals(this.LeftFootStartX, other.LeftFootStartX) && this.Level == other.Level && this.LoopBlend == other.LoopBlend && this.LoopBlendOrientation == other.LoopBlendOrientation && this.LoopBlendPositionXZ == other.LoopBlendPositionXZ && this.LoopBlendPositionY == other.LoopBlendPositionY && this.LoopTime == other.LoopTime && this.Mirror == other.Mirror && EqualityComparer<Xform_4_0_0>.Default.Equals(this.MotionStartX, other.MotionStartX) && EqualityComparer<Xform_4_0_0>.Default.Equals(this.MotionStopX, other.MotionStopX) && this.OrientationOffsetY == other.OrientationOffsetY && EqualityComparer<IXform>.Default.Equals(this.RightFootStartX, other.RightFootStartX) && this.StartAtOrigin == other.StartAtOrigin && this.StartTime == other.StartTime && EqualityComparer<IXform>.Default.Equals(this.StartX, other.StartX) && this.StopTime == other.StopTime && EqualityComparer<Xform_5_5_0>.Default.Equals(this.StopX, other.StopX) && EqualityComparer<AssetList<ValueDelta>>.Default.Equals(this.ValueArrayDelta, other.ValueArrayDelta) && EqualityComparer<float[]>.Default.Equals(this.ValueArrayReferencePose, other.ValueArrayReferencePose);
		}

		// Token: 0x0600D01A RID: 53274 RVA: 0x001F22B4 File Offset: 0x001F04B4

		public bool Equals(MuscleClipConstant_5_6_0_ACL other)
		{
			return other != null && EqualityComparer<HumanPose_5_5_0>.Default.Equals(this.m_DeltaPose, other.m_DeltaPose) && EqualityComparer<Xform_5_5_0>.Default.Equals(this.m_StartX, other.m_StartX) && EqualityComparer<Xform_5_5_0>.Default.Equals(this.m_StopX, other.m_StopX) && EqualityComparer<Xform_5_5_0>.Default.Equals(this.m_LeftFootStartX, other.m_LeftFootStartX) && EqualityComparer<Xform_5_5_0>.Default.Equals(this.m_RightFootStartX, other.m_RightFootStartX) && EqualityComparer<Vector3Float_5_5_0>.Default.Equals(this.m_AverageSpeed3, other.m_AverageSpeed3) && EqualityComparer<OffsetPtr_Clip_5_5_0_ACL>.Default.Equals(this.m_Clip, other.m_Clip) && this.m_StartTime == other.m_StartTime && this.m_StopTime == other.m_StopTime && this.m_OrientationOffsetY == other.m_OrientationOffsetY && this.m_Level == other.m_Level && this.m_CycleOffset == other.m_CycleOffset && this.m_AverageAngularSpeed == other.m_AverageAngularSpeed && EqualityComparer<int[]>.Default.Equals(this.m_IndexArray, other.m_IndexArray) && EqualityComparer<AssetList<ValueDelta>>.Default.Equals(this.m_ValueArrayDelta, other.m_ValueArrayDelta) && EqualityComparer<float[]>.Default.Equals(this.m_ValueArrayReferencePose, other.m_ValueArrayReferencePose) && this.m_Mirror == other.m_Mirror && this.m_LoopTime == other.m_LoopTime && this.m_LoopBlend == other.m_LoopBlend && this.m_LoopBlendOrientation == other.m_LoopBlendOrientation && this.m_LoopBlendPositionY == other.m_LoopBlendPositionY && this.m_LoopBlendPositionXZ == other.m_LoopBlendPositionXZ && this.m_StartAtOrigin == other.m_StartAtOrigin && this.m_KeepOriginalOrientation == other.m_KeepOriginalOrientation && this.m_KeepOriginalPositionY == other.m_KeepOriginalPositionY && this.m_KeepOriginalPositionXZ == other.m_KeepOriginalPositionXZ && this.m_HeightFromFeet == other.m_HeightFromFeet;
		}

		// Token: 0x0600D01B RID: 53275 RVA: 0x001F24DE File Offset: 0x001F06DE

		public override bool Equals(object other)
		{
			return this.Equals(other as IMuscleClipConstant_ACL);
		}

		// Token: 0x0600D01C RID: 53276 RVA: 0x001F24EC File Offset: 0x001F06EC

		public static bool operator ==(MuscleClipConstant_5_6_0_ACL left, MuscleClipConstant_5_6_0_ACL right)
		{
			return EqualityComparer<MuscleClipConstant_5_6_0_ACL>.Default.Equals(left, right);
		}

		// Token: 0x0600D01D RID: 53277 RVA: 0x001F24FA File Offset: 0x001F06FA

		public static bool operator !=(MuscleClipConstant_5_6_0_ACL left, MuscleClipConstant_5_6_0_ACL right)
		{
			return !(left == right);
		}

		// Token: 0x0600D01E RID: 53278 RVA: 0x001F2508 File Offset: 0x001F0708
		public override int GetHashCode()
		{
			HashCode hashCode = default(HashCode);
			hashCode.Add<int[]>(this.AdditionalCurveIndexArray);
			hashCode.Add<float>(this.AverageAngularSpeed);
			hashCode.Add<IVector3Float>(this.AverageSpeed3);
			hashCode.Add<Vector4Float_4_0_0>(this.AverageSpeed4);
			hashCode.Add<IOffsetPtr_Clip_ACL>(this.Clip);
			hashCode.Add<float>(this.CycleOffset);
			hashCode.Add<IHumanPose>(this.DeltaPose);
			hashCode.Add<bool>(this.HeightFromFeet);
			hashCode.Add<int[]>(this.IndexArray);
			hashCode.Add<bool>(this.KeepOriginalOrientation);
			hashCode.Add<bool>(this.KeepOriginalPositionXZ);
			hashCode.Add<bool>(this.KeepOriginalPositionY);
			hashCode.Add<IXform>(this.LeftFootStartX);
			hashCode.Add<float>(this.Level);
			hashCode.Add<bool>(this.LoopBlend);
			hashCode.Add<bool>(this.LoopBlendOrientation);
			hashCode.Add<bool>(this.LoopBlendPositionXZ);
			hashCode.Add<bool>(this.LoopBlendPositionY);
			hashCode.Add<bool>(this.LoopTime);
			hashCode.Add<bool>(this.Mirror);
			hashCode.Add<Xform_4_0_0>(this.MotionStartX);
			hashCode.Add<Xform_4_0_0>(this.MotionStopX);
			hashCode.Add<float>(this.OrientationOffsetY);
			hashCode.Add<IXform>(this.RightFootStartX);
			hashCode.Add<bool>(this.StartAtOrigin);
			hashCode.Add<float>(this.StartTime);
			hashCode.Add<IXform>(this.StartX);
			hashCode.Add<float>(this.StopTime);
			hashCode.Add<Xform_5_5_0>(this.StopX);
			hashCode.Add<AssetList<ValueDelta>>(this.ValueArrayDelta);
			hashCode.Add<float[]>(this.ValueArrayReferencePose);
			return hashCode.ToHashCode();
		}

		// Token: 0x0600D01F RID: 53279 RVA: 0x001F26B7 File Offset: 0x001F08B7
		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600D020 RID: 53280 RVA: 0x001F26BE File Offset: 0x001F08BE
		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04002062 RID: 8290
		public HumanPose_5_5_0 m_DeltaPose;

		// Token: 0x04002063 RID: 8291
		public Xform_5_5_0 m_StartX;

		// Token: 0x04002064 RID: 8292
		public Xform_5_5_0 m_StopX;

		// Token: 0x04002065 RID: 8293
		public Xform_5_5_0 m_LeftFootStartX;

		// Token: 0x04002066 RID: 8294
		public Xform_5_5_0 m_RightFootStartX;

		// Token: 0x04002067 RID: 8295
		public Vector3Float_5_5_0 m_AverageSpeed3;

		// Token: 0x04002068 RID: 8296
		public OffsetPtr_Clip_5_5_0_ACL m_Clip;

		// Token: 0x04002069 RID: 8297
		public float m_StartTime;

		// Token: 0x0400206A RID: 8298
		public float m_StopTime;

		// Token: 0x0400206B RID: 8299
		public float m_OrientationOffsetY;

		// Token: 0x0400206C RID: 8300
		public float m_Level;

		// Token: 0x0400206D RID: 8301
		public float m_CycleOffset;

		// Token: 0x0400206E RID: 8302
		public float m_AverageAngularSpeed;

		// Token: 0x0400206F RID: 8303
		public int[] m_IndexArray;

		// Token: 0x04002070 RID: 8304
		public AssetList<ValueDelta> m_ValueArrayDelta;

		// Token: 0x04002071 RID: 8305
		public float[] m_ValueArrayReferencePose;

		// Token: 0x04002072 RID: 8306
		public bool m_Mirror;

		// Token: 0x04002073 RID: 8307
		public bool m_LoopTime;

		// Token: 0x04002074 RID: 8308
		public bool m_LoopBlend;

		// Token: 0x04002075 RID: 8309
		public bool m_LoopBlendOrientation;

		// Token: 0x04002076 RID: 8310
		public bool m_LoopBlendPositionY;

		// Token: 0x04002077 RID: 8311
		public bool m_LoopBlendPositionXZ;

		// Token: 0x04002078 RID: 8312
		public bool m_StartAtOrigin;

		// Token: 0x04002079 RID: 8313
		public bool m_KeepOriginalOrientation;

		// Token: 0x0400207A RID: 8314
		public bool m_KeepOriginalPositionY;

		// Token: 0x0400207B RID: 8315
		public bool m_KeepOriginalPositionXZ;

		// Token: 0x0400207C RID: 8316
		public bool m_HeightFromFeet;
	}
}
