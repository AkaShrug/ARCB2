using System;
using System.Runtime.CompilerServices;
using AssetRipper.Assets.Export;
using AssetRipper.Assets.Generics;
using AssetRipper.SourceGenerated.Subclasses.AddedComponent;
using AssetRipper.SourceGenerated.Subclasses.AddedGameObject;
using AssetRipper.SourceGenerated.Subclasses.AnimationClipOverride;
using AssetRipper.SourceGenerated.Subclasses.AnimationEvent;
using AssetRipper.SourceGenerated.Subclasses.AnimatorCondition;
using AssetRipper.SourceGenerated.Subclasses.Annotation;
using AssetRipper.SourceGenerated.Subclasses.Asset;
using AssetRipper.SourceGenerated.Subclasses.AssetBundleFullName;
using AssetRipper.SourceGenerated.Subclasses.AssetBundleInfo;
using AssetRipper.SourceGenerated.Subclasses.AssetBundleScriptInfo;
using AssetRipper.SourceGenerated.Subclasses.AssetImporterHashKey;
using AssetRipper.SourceGenerated.Subclasses.AssetImporter_ImportError;
using AssetRipper.SourceGenerated.Subclasses.AssetInfo;
using AssetRipper.SourceGenerated.Subclasses.AssetTimeStamp;
using AssetRipper.SourceGenerated.Subclasses.AutoOffMeshLinkData;
using AssetRipper.SourceGenerated.Subclasses.AvatarSkeletonMaskElement;
using AssetRipper.SourceGenerated.Subclasses.Axes;
using AssetRipper.SourceGenerated.Subclasses.BlendShapeVertex;
using AssetRipper.SourceGenerated.Subclasses.BoneWeights4;
using AssetRipper.SourceGenerated.Subclasses.BufferBinding;
using AssetRipper.SourceGenerated.Subclasses.BuildReportFile;
using AssetRipper.SourceGenerated.Subclasses.BuildReportPackedAssetInfo;
using AssetRipper.SourceGenerated.Subclasses.BuildReportScenesUsingAsset;
using AssetRipper.SourceGenerated.Subclasses.BuildStepInfo;
using AssetRipper.SourceGenerated.Subclasses.BuildStepMessage;
using AssetRipper.SourceGenerated.Subclasses.BuildTargetSettings_Material;
using AssetRipper.SourceGenerated.Subclasses.BuildTextureStackReference;
using AssetRipper.SourceGenerated.Subclasses.BuiltAssetBundleInfo;
using AssetRipper.SourceGenerated.Subclasses.CachedAssetMetaData;
using AssetRipper.SourceGenerated.Subclasses.Channel;
using AssetRipper.SourceGenerated.Subclasses.ChannelInfo;
using AssetRipper.SourceGenerated.Subclasses.CharacterInfo;
using AssetRipper.SourceGenerated.Subclasses.ChildAnimatorState;
using AssetRipper.SourceGenerated.Subclasses.ChildAnimatorStateMachine;
using AssetRipper.SourceGenerated.Subclasses.ChildMotion;
using AssetRipper.SourceGenerated.Subclasses.ClassInfo;
using AssetRipper.SourceGenerated.Subclasses.ClassMethodInfo;
using AssetRipper.SourceGenerated.Subclasses.ClipAnimationInfo;
using AssetRipper.SourceGenerated.Subclasses.ClipAnimationInfoCurve;
using AssetRipper.SourceGenerated.Subclasses.ClothAttachment;
using AssetRipper.SourceGenerated.Subclasses.ClothConstrainCoefficients;
using AssetRipper.SourceGenerated.Subclasses.ClothSphereColliderPair;
using AssetRipper.SourceGenerated.Subclasses.ClusterInput;
using AssetRipper.SourceGenerated.Subclasses.Collider;
using AssetRipper.SourceGenerated.Subclasses.ColorRGBA32;
using AssetRipper.SourceGenerated.Subclasses.ColorRGBAf;
using AssetRipper.SourceGenerated.Subclasses.ComponentPair;
using AssetRipper.SourceGenerated.Subclasses.CompressedAnimationCurve;
using AssetRipper.SourceGenerated.Subclasses.ComputeShaderBuiltinSampler;
using AssetRipper.SourceGenerated.Subclasses.ComputeShaderCB;
using AssetRipper.SourceGenerated.Subclasses.ComputeShaderKernel;
using AssetRipper.SourceGenerated.Subclasses.ComputeShaderKernelParent;
using AssetRipper.SourceGenerated.Subclasses.ComputeShaderParam;
using AssetRipper.SourceGenerated.Subclasses.ComputeShaderResource;
using AssetRipper.SourceGenerated.Subclasses.ComputeShaderVariant;
using AssetRipper.SourceGenerated.Subclasses.ConfigSetting;
using AssetRipper.SourceGenerated.Subclasses.ConstantBuffer;
using AssetRipper.SourceGenerated.Subclasses.ConstraintSource;
using AssetRipper.SourceGenerated.Subclasses.DefaultPreset;
using AssetRipper.SourceGenerated.Subclasses.DefaultPresetList;
using AssetRipper.SourceGenerated.Subclasses.DeletedItem;
using AssetRipper.SourceGenerated.Subclasses.DetailPatch;
using AssetRipper.SourceGenerated.Subclasses.DetailPrototype;
using AssetRipper.SourceGenerated.Subclasses.DirectorGenericBinding;
using AssetRipper.SourceGenerated.Subclasses.EffectConstant;
using AssetRipper.SourceGenerated.Subclasses.EnlightenRendererInformation;
using AssetRipper.SourceGenerated.Subclasses.EnlightenSystemAtlasInformation;
using AssetRipper.SourceGenerated.Subclasses.EnlightenSystemInformation;
using AssetRipper.SourceGenerated.Subclasses.EnlightenTerrainChunksInformation;
using AssetRipper.SourceGenerated.Subclasses.ExpandedData;
using AssetRipper.SourceGenerated.Subclasses.Expression;
using AssetRipper.SourceGenerated.Subclasses.ExtensionPropertyValue;
using AssetRipper.SourceGenerated.Subclasses.FastPropertyName;
using AssetRipper.SourceGenerated.Subclasses.FlareElement;
using AssetRipper.SourceGenerated.Subclasses.FloatCurve;
using AssetRipper.SourceGenerated.Subclasses.GenericBinding;
using AssetRipper.SourceGenerated.Subclasses.GroupConnection;
using AssetRipper.SourceGenerated.Subclasses.GroupConstant;
using AssetRipper.SourceGenerated.Subclasses.GUID;
using AssetRipper.SourceGenerated.Subclasses.Handle;
using AssetRipper.SourceGenerated.Subclasses.Hash128;
using AssetRipper.SourceGenerated.Subclasses.HeightmapData;
using AssetRipper.SourceGenerated.Subclasses.HeightMeshBVNode;
using AssetRipper.SourceGenerated.Subclasses.HeightMeshData;
using AssetRipper.SourceGenerated.Subclasses.HierarchicalSceneData;
using AssetRipper.SourceGenerated.Subclasses.HumanBone;
using AssetRipper.SourceGenerated.Subclasses.HumanGoal;
using AssetRipper.SourceGenerated.Subclasses.HumanHandle;
using AssetRipper.SourceGenerated.Subclasses.ImportLog_ImportLogEntry;
using AssetRipper.SourceGenerated.Subclasses.InputAxis;
using AssetRipper.SourceGenerated.Subclasses.InputImportSettings;
using AssetRipper.SourceGenerated.Subclasses.InputImportSettings_SubstanceValue;
using AssetRipper.SourceGenerated.Subclasses.IntegerString;
using AssetRipper.SourceGenerated.Subclasses.Item;
using AssetRipper.SourceGenerated.Subclasses.Keyframe_Quaternionf;
using AssetRipper.SourceGenerated.Subclasses.Keyframe_Single;
using AssetRipper.SourceGenerated.Subclasses.Keyframe_Vector3f;
using AssetRipper.SourceGenerated.Subclasses.LeafInfoConstant;
using AssetRipper.SourceGenerated.Subclasses.LibraryRepresentation;
using AssetRipper.SourceGenerated.Subclasses.LightBakingOutput;
using AssetRipper.SourceGenerated.Subclasses.LightmapData;
using AssetRipper.SourceGenerated.Subclasses.LightProbeOcclusion;
using AssetRipper.SourceGenerated.Subclasses.LOD;
using AssetRipper.SourceGenerated.Subclasses.LODRenderer;
using AssetRipper.SourceGenerated.Subclasses.MaterialImportOutput;
using AssetRipper.SourceGenerated.Subclasses.MaterialInstanceSettings;
using AssetRipper.SourceGenerated.Subclasses.Matrix4x4f;
using AssetRipper.SourceGenerated.Subclasses.MatrixParameter;
using AssetRipper.SourceGenerated.Subclasses.MeshBlendShape;
using AssetRipper.SourceGenerated.Subclasses.MeshBlendShapeChannel;
using AssetRipper.SourceGenerated.Subclasses.MeshBlendShapeVertex;
using AssetRipper.SourceGenerated.Subclasses.MinMaxAABB;
using AssetRipper.SourceGenerated.Subclasses.MipmapLimitSettings;
using AssetRipper.SourceGenerated.Subclasses.ModifiedItem;
using AssetRipper.SourceGenerated.Subclasses.Module;
using AssetRipper.SourceGenerated.Subclasses.MotionNeighborList;
using AssetRipper.SourceGenerated.Subclasses.NavMeshAreaData;
using AssetRipper.SourceGenerated.Subclasses.NavMeshBuildSettings;
using AssetRipper.SourceGenerated.Subclasses.NavMeshTileData;
using AssetRipper.SourceGenerated.Subclasses.NestedString;
using AssetRipper.SourceGenerated.Subclasses.Node;
using AssetRipper.SourceGenerated.Subclasses.NonAlignedStruct;
using AssetRipper.SourceGenerated.Subclasses.OcclusionScene;
using AssetRipper.SourceGenerated.Subclasses.OffsetPtr_BlendTreeConstant;
using AssetRipper.SourceGenerated.Subclasses.OffsetPtr_BlendTreeNodeConstant;
using AssetRipper.SourceGenerated.Subclasses.OffsetPtr_ConditionConstant;
using AssetRipper.SourceGenerated.Subclasses.OffsetPtr_LayerConstant;
using AssetRipper.SourceGenerated.Subclasses.OffsetPtr_SelectorStateConstant;
using AssetRipper.SourceGenerated.Subclasses.OffsetPtr_SelectorTransitionConstant;
using AssetRipper.SourceGenerated.Subclasses.OffsetPtr_StateConstant;
using AssetRipper.SourceGenerated.Subclasses.OffsetPtr_StateMachineConstant;
using AssetRipper.SourceGenerated.Subclasses.OffsetPtr_TransitionConstant;
using AssetRipper.SourceGenerated.Subclasses.Parameter;
using AssetRipper.SourceGenerated.Subclasses.ParticleSystemEmissionBurst;
using AssetRipper.SourceGenerated.Subclasses.PerLODSettings;
using AssetRipper.SourceGenerated.Subclasses.PhysicsShape;
using AssetRipper.SourceGenerated.Subclasses.PlatformSettingsData_Editor;
using AssetRipper.SourceGenerated.Subclasses.PlatformSettingsData_Plugin;
using AssetRipper.SourceGenerated.Subclasses.PlatformShaderDefines;
using AssetRipper.SourceGenerated.Subclasses.PPtrCurve;
using AssetRipper.SourceGenerated.Subclasses.PPtrKeyframe;
using AssetRipper.SourceGenerated.Subclasses.PPtr_AnimationClip;
using AssetRipper.SourceGenerated.Subclasses.PPtr_AnimatorStateMachine;
using AssetRipper.SourceGenerated.Subclasses.PPtr_AnimatorStateTransition;
using AssetRipper.SourceGenerated.Subclasses.PPtr_AnimatorTransition;
using AssetRipper.SourceGenerated.Subclasses.PPtr_AudioMixerGroup;
using AssetRipper.SourceGenerated.Subclasses.PPtr_AudioMixerSnapshot;
using AssetRipper.SourceGenerated.Subclasses.PPtr_AudioSource;
using AssetRipper.SourceGenerated.Subclasses.PPtr_CapsuleCollider;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Component;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtension;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Font;
using AssetRipper.SourceGenerated.Subclasses.PPtr_GameObject;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Material;
using AssetRipper.SourceGenerated.Subclasses.PPtr_MonoBehaviour;
using AssetRipper.SourceGenerated.Subclasses.PPtr_MonoScript;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Motion;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Object;
using AssetRipper.SourceGenerated.Subclasses.PPtr_OcclusionPortal;
using AssetRipper.SourceGenerated.Subclasses.PPtr_ParticleSystemForceField;
using AssetRipper.SourceGenerated.Subclasses.PPtr_ProceduralTexture;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Renderer;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Shader;
using AssetRipper.SourceGenerated.Subclasses.PPtr_ShaderVariantCollection;
using AssetRipper.SourceGenerated.Subclasses.PPtr_SphereCollider;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Sprite;
using AssetRipper.SourceGenerated.Subclasses.PPtr_State;
using AssetRipper.SourceGenerated.Subclasses.PPtr_StateMachine;
using AssetRipper.SourceGenerated.Subclasses.PPtr_TerrainLayer;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Texture;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Texture2D;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Transform;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Transition;
using AssetRipper.SourceGenerated.Subclasses.PresetType;
using AssetRipper.SourceGenerated.Subclasses.ProbeSetIndex;
using AssetRipper.SourceGenerated.Subclasses.ProceduralTextureAssignment;
using AssetRipper.SourceGenerated.Subclasses.PropertyModification;
using AssetRipper.SourceGenerated.Subclasses.PropertyModificationsTargetTestNativeObject;
using AssetRipper.SourceGenerated.Subclasses.QualitySetting;
using AssetRipper.SourceGenerated.Subclasses.QuaternionCurve;
using AssetRipper.SourceGenerated.Subclasses.RayTracingShaderBuiltinSampler;
using AssetRipper.SourceGenerated.Subclasses.RayTracingShaderConstantBuffer;
using AssetRipper.SourceGenerated.Subclasses.RayTracingShaderFunctionDesc;
using AssetRipper.SourceGenerated.Subclasses.RayTracingShaderParam;
using AssetRipper.SourceGenerated.Subclasses.RayTracingShaderResource;
using AssetRipper.SourceGenerated.Subclasses.RayTracingShaderVariant;
using AssetRipper.SourceGenerated.Subclasses.RendererData;
using AssetRipper.SourceGenerated.Subclasses.ResourceManager_Dependency;
using AssetRipper.SourceGenerated.Subclasses.SamplerParameter;
using AssetRipper.SourceGenerated.Subclasses.SampleSettings;
using AssetRipper.SourceGenerated.Subclasses.Scene;
using AssetRipper.SourceGenerated.Subclasses.SceneIdentifier;
using AssetRipper.SourceGenerated.Subclasses.SceneObjectIdentifier;
using AssetRipper.SourceGenerated.Subclasses.SceneVisibilityData;
using AssetRipper.SourceGenerated.Subclasses.SecondarySpriteTexture;
using AssetRipper.SourceGenerated.Subclasses.SecondaryTextureSettings;
using AssetRipper.SourceGenerated.Subclasses.SerializedCustomEditorForRenderPipeline;
using AssetRipper.SourceGenerated.Subclasses.SerializedPass;
using AssetRipper.SourceGenerated.Subclasses.SerializedPlayerSubProgram;
using AssetRipper.SourceGenerated.Subclasses.SerializedProperty;
using AssetRipper.SourceGenerated.Subclasses.SerializedShaderDependency;
using AssetRipper.SourceGenerated.Subclasses.SerializedSubProgram;
using AssetRipper.SourceGenerated.Subclasses.SerializedSubShader;
using AssetRipper.SourceGenerated.Subclasses.ShaderBindChannel;
using AssetRipper.SourceGenerated.Subclasses.ShaderInfo;
using AssetRipper.SourceGenerated.Subclasses.SkeletonBone;
using AssetRipper.SourceGenerated.Subclasses.SkeletonMaskElement;
using AssetRipper.SourceGenerated.Subclasses.SketchUpImportScene;
using AssetRipper.SourceGenerated.Subclasses.SnapshotConstant;
using AssetRipper.SourceGenerated.Subclasses.SortingLayerEntry;
using AssetRipper.SourceGenerated.Subclasses.SourceAssetIdentifier;
using AssetRipper.SourceGenerated.Subclasses.SphericalHarmonicsL2;
using AssetRipper.SourceGenerated.Subclasses.SplashScreenLogo;
using AssetRipper.SourceGenerated.Subclasses.SplatPrototype;
using AssetRipper.SourceGenerated.Subclasses.SpriteAtlasData;
using AssetRipper.SourceGenerated.Subclasses.SpriteBone;
using AssetRipper.SourceGenerated.Subclasses.SpriteData;
using AssetRipper.SourceGenerated.Subclasses.SpriteMetaData;
using AssetRipper.SourceGenerated.Subclasses.SpriteRenderData;
using AssetRipper.SourceGenerated.Subclasses.SpriteVertex;
using AssetRipper.SourceGenerated.Subclasses.StateKey;
using AssetRipper.SourceGenerated.Subclasses.StateRange;
using AssetRipper.SourceGenerated.Subclasses.StreamInfo;
using AssetRipper.SourceGenerated.Subclasses.StructParameter;
using AssetRipper.SourceGenerated.Subclasses.SubCollider;
using AssetRipper.SourceGenerated.Subclasses.SubEmitterData;
using AssetRipper.SourceGenerated.Subclasses.SubMesh;
using AssetRipper.SourceGenerated.Subclasses.SubstanceEnumItem;
using AssetRipper.SourceGenerated.Subclasses.SubstanceInput;
using AssetRipper.SourceGenerated.Subclasses.Tetrahedron;
using AssetRipper.SourceGenerated.Subclasses.TextureImporterPlatformSettings;
using AssetRipper.SourceGenerated.Subclasses.TextureParameter;
using AssetRipper.SourceGenerated.Subclasses.Tile;
using AssetRipper.SourceGenerated.Subclasses.TileAnimationData;
using AssetRipper.SourceGenerated.Subclasses.TilemapRefCountedData_ColorRGBAf;
using AssetRipper.SourceGenerated.Subclasses.TilemapRefCountedData_Matrix4x4f;
using AssetRipper.SourceGenerated.Subclasses.TilemapRefCountedData_PPtr_GameObject;
using AssetRipper.SourceGenerated.Subclasses.TilemapRefCountedData_PPtr_Object;
using AssetRipper.SourceGenerated.Subclasses.TilemapRefCountedData_PPtr_Sprite;
using AssetRipper.SourceGenerated.Subclasses.TransformMaskElement;
using AssetRipper.SourceGenerated.Subclasses.TreeInstance;
using AssetRipper.SourceGenerated.Subclasses.TreePrototype;
using AssetRipper.SourceGenerated.Subclasses.UAVParameter;
using AssetRipper.SourceGenerated.Subclasses.UnityTexEnv;
using AssetRipper.SourceGenerated.Subclasses.UpdateZoneInfo;
using AssetRipper.SourceGenerated.Subclasses.Utf8String;
using AssetRipper.SourceGenerated.Subclasses.ValueConstant;
using AssetRipper.SourceGenerated.Subclasses.ValueDelta;
using AssetRipper.SourceGenerated.Subclasses.VariantInfo;
using AssetRipper.SourceGenerated.Subclasses.Vector2f;
using AssetRipper.SourceGenerated.Subclasses.Vector2Int;
using AssetRipper.SourceGenerated.Subclasses.Vector2Long;
using AssetRipper.SourceGenerated.Subclasses.Vector3Curve;
using AssetRipper.SourceGenerated.Subclasses.Vector3f;
using AssetRipper.SourceGenerated.Subclasses.Vector3Float;
using AssetRipper.SourceGenerated.Subclasses.Vector3Int;
using AssetRipper.SourceGenerated.Subclasses.Vector4f;
using AssetRipper.SourceGenerated.Subclasses.Vector4Float;
using AssetRipper.SourceGenerated.Subclasses.VectorParameter;
using AssetRipper.SourceGenerated.Subclasses.VFXCPUBufferDesc;
using AssetRipper.SourceGenerated.Subclasses.VFXEditorSystemDesc;
using AssetRipper.SourceGenerated.Subclasses.VFXEditorTaskDesc;
using AssetRipper.SourceGenerated.Subclasses.VFXEntryExposed_AnimationCurve_Single;
using AssetRipper.SourceGenerated.Subclasses.VFXEntryExposed_bool;
using AssetRipper.SourceGenerated.Subclasses.VFXEntryExposed_float;
using AssetRipper.SourceGenerated.Subclasses.VFXEntryExposed_Gradient;
using AssetRipper.SourceGenerated.Subclasses.VFXEntryExposed_Matrix4x4f;
using AssetRipper.SourceGenerated.Subclasses.VFXEntryExposed_PPtr_NamedObject;
using AssetRipper.SourceGenerated.Subclasses.VFXEntryExposed_PPtr_Object;
using AssetRipper.SourceGenerated.Subclasses.VFXEntryExposed_SInt32;
using AssetRipper.SourceGenerated.Subclasses.VFXEntryExposed_UInt32;
using AssetRipper.SourceGenerated.Subclasses.VFXEntryExposed_Vector2f;
using AssetRipper.SourceGenerated.Subclasses.VFXEntryExposed_Vector3f;
using AssetRipper.SourceGenerated.Subclasses.VFXEntryExposed_Vector4f;
using AssetRipper.SourceGenerated.Subclasses.VFXEntryExpressionValue_AnimationCurve_Single;
using AssetRipper.SourceGenerated.Subclasses.VFXEntryExpressionValue_bool;
using AssetRipper.SourceGenerated.Subclasses.VFXEntryExpressionValue_float;
using AssetRipper.SourceGenerated.Subclasses.VFXEntryExpressionValue_Gradient;
using AssetRipper.SourceGenerated.Subclasses.VFXEntryExpressionValue_Matrix4x4f;
using AssetRipper.SourceGenerated.Subclasses.VFXEntryExpressionValue_PPtr_NamedObject;
using AssetRipper.SourceGenerated.Subclasses.VFXEntryExpressionValue_PPtr_Object;
using AssetRipper.SourceGenerated.Subclasses.VFXEntryExpressionValue_SInt32;
using AssetRipper.SourceGenerated.Subclasses.VFXEntryExpressionValue_UInt32;
using AssetRipper.SourceGenerated.Subclasses.VFXEntryExpressionValue_Vector2f;
using AssetRipper.SourceGenerated.Subclasses.VFXEntryExpressionValue_Vector3f;
using AssetRipper.SourceGenerated.Subclasses.VFXEntryExpressionValue_Vector4f;
using AssetRipper.SourceGenerated.Subclasses.VFXEventDesc;
using AssetRipper.SourceGenerated.Subclasses.VFXGPUBufferDesc;
using AssetRipper.SourceGenerated.Subclasses.VFXLayoutElementDesc;
using AssetRipper.SourceGenerated.Subclasses.VFXMapping;
using AssetRipper.SourceGenerated.Subclasses.VFXMappingTemporary;
using AssetRipper.SourceGenerated.Subclasses.VFXShaderSourceDesc;
using AssetRipper.SourceGenerated.Subclasses.VFXSystemDesc;
using AssetRipper.SourceGenerated.Subclasses.VFXTaskDesc;
using AssetRipper.SourceGenerated.Subclasses.VFXTemporaryGPUBufferDesc;
using AssetRipper.SourceGenerated.Subclasses.VideoClipImporterTargetSettings;
using AssetRipper.SourceGenerated.Subclasses.Xform;
using AssetRipper.Yaml;
using AssetRipper.Yaml.Extensions;

namespace AssetRipper.SourceGenerated.Helpers
{
	// Token: 0x02001C23 RID: 7203


	internal static class ExportYamlReleaseMethods
	{
		// Token: 0x060173B7 RID: 95159 RVA: 0x0036F218 File Offset: 0x0036D418
		public static YamlNode ExportYamlRelease_Array_AddedComponent(this AssetList<AddedComponent> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173B8 RID: 95160 RVA: 0x0036F258 File Offset: 0x0036D458
		public static YamlNode ExportYamlRelease_Array_AddedGameObject(this AssetList<AddedGameObject> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173B9 RID: 95161 RVA: 0x0036F298 File Offset: 0x0036D498
		public static YamlNode ExportYamlRelease_Array_AnimationClipOverride_4_3_0(this AssetList<AnimationClipOverride_4_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173BA RID: 95162 RVA: 0x0036F2D8 File Offset: 0x0036D4D8
		public static YamlNode ExportYamlRelease_Array_AnimationClipOverride_5_0_0(this AssetList<AnimationClipOverride_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173BB RID: 95163 RVA: 0x0036F318 File Offset: 0x0036D518
		public static YamlNode ExportYamlRelease_Array_AnimationEvent_3_4_0(this AssetList<AnimationEvent_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173BC RID: 95164 RVA: 0x0036F358 File Offset: 0x0036D558
		public static YamlNode ExportYamlRelease_Array_AnimationEvent_5_0_0(this AssetList<AnimationEvent_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173BD RID: 95165 RVA: 0x0036F398 File Offset: 0x0036D598
		public static YamlNode ExportYamlRelease_Array_AnimatorCondition_4_0_0(this AssetList<AnimatorCondition_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173BE RID: 95166 RVA: 0x0036F3D8 File Offset: 0x0036D5D8
		public static YamlNode ExportYamlRelease_Array_AnimatorCondition_5_0_0(this AssetList<AnimatorCondition_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173BF RID: 95167 RVA: 0x0036F418 File Offset: 0x0036D618
		public static YamlNode ExportYamlRelease_Array_Annotation_3_4_0(this AssetList<Annotation_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173C0 RID: 95168 RVA: 0x0036F458 File Offset: 0x0036D658
		public static YamlNode ExportYamlRelease_Array_Annotation_5_6_0(this AssetList<Annotation_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173C1 RID: 95169 RVA: 0x0036F498 File Offset: 0x0036D698
		public static YamlNode ExportYamlRelease_Array_Array_SerializedPlayerSubProgram_2021_3_10(this AssetList<AssetList<SerializedPlayerSubProgram_2021_3_10>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease_Array_SerializedPlayerSubProgram_2021_3_10(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173C2 RID: 95170 RVA: 0x0036F4D8 File Offset: 0x0036D6D8
		public static YamlNode ExportYamlRelease_Array_Array_SerializedPlayerSubProgram_2022_1_13(this AssetList<AssetList<SerializedPlayerSubProgram_2022_1_13>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease_Array_SerializedPlayerSubProgram_2022_1_13(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173C3 RID: 95171 RVA: 0x0036F518 File Offset: 0x0036D718
		public static YamlNode ExportYamlRelease_Array_Array_SerializedPlayerSubProgram_2022_2_0_b5(this AssetList<AssetList<SerializedPlayerSubProgram_2022_2_0_b5>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease_Array_SerializedPlayerSubProgram_2022_2_0_b5(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173C4 RID: 95172 RVA: 0x0036F558 File Offset: 0x0036D758
		public static YamlNode ExportYamlRelease_Array_Array_UInt32(this uint[][] value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int num = value.Length;
			for (int i = 0; i < num; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease_Array_UInt32(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173C5 RID: 95173 RVA: 0x0036F590 File Offset: 0x0036D790
		public static YamlNode ExportYamlRelease_Array_Array_Vector2f_3_5_0(this AssetList<AssetList<Vector2f_3_5_0>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease_Array_Vector2f_3_5_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173C6 RID: 95174 RVA: 0x0036F5D0 File Offset: 0x0036D7D0
		public static YamlNode ExportYamlRelease_Array_Array_Vector2Long(this AssetList<AssetList<Vector2Long>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease_Array_Vector2Long(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173C7 RID: 95175 RVA: 0x0036F610 File Offset: 0x0036D810
		public static YamlNode ExportYamlRelease_Array_AssetBundleScriptInfo(this AssetList<AssetBundleScriptInfo> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173C8 RID: 95176 RVA: 0x0036F650 File Offset: 0x0036D850
		public static YamlNode ExportYamlRelease_Array_AssetImporter_ImportError(this AssetList<AssetImporter_ImportError> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173C9 RID: 95177 RVA: 0x0036F690 File Offset: 0x0036D890
		public static YamlNode ExportYamlRelease_Array_AutoOffMeshLinkData(this AssetList<AutoOffMeshLinkData> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173CA RID: 95178 RVA: 0x0036F6D0 File Offset: 0x0036D8D0
		public static YamlNode ExportYamlRelease_Array_AvatarSkeletonMaskElement(this AssetList<AvatarSkeletonMaskElement> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173CB RID: 95179 RVA: 0x0036F710 File Offset: 0x0036D910
		public static YamlNode ExportYamlRelease_Array_Axes_4_0_0(this AssetList<Axes_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173CC RID: 95180 RVA: 0x0036F750 File Offset: 0x0036D950
		public static YamlNode ExportYamlRelease_Array_Axes_5_4_0(this AssetList<Axes_5_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173CD RID: 95181 RVA: 0x0036F790 File Offset: 0x0036D990
		public static YamlNode ExportYamlRelease_Array_Axes_5_5_0(this AssetList<Axes_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173CE RID: 95182 RVA: 0x0036F7D0 File Offset: 0x0036D9D0
		public static YamlNode ExportYamlRelease_Array_BlendShapeVertex(this AssetList<BlendShapeVertex> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173CF RID: 95183 RVA: 0x0036F810 File Offset: 0x0036DA10
		public static YamlNode ExportYamlRelease_Array_BoneWeights4_2017_1_0(this AssetList<BoneWeights4_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173D0 RID: 95184 RVA: 0x0036F850 File Offset: 0x0036DA50
		public static YamlNode ExportYamlRelease_Array_BoneWeights4_3_4_0(this AssetList<BoneWeights4_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173D1 RID: 95185 RVA: 0x0036F890 File Offset: 0x0036DA90
		public static YamlNode ExportYamlRelease_Array_Boolean(this bool[] value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int num = value.Length;
			for (int i = 0; i < num; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease_Boolean(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173D2 RID: 95186 RVA: 0x0036F8C8 File Offset: 0x0036DAC8
		public static YamlNode ExportYamlRelease_Array_BufferBinding_2020_1_0_a17(this AssetList<BufferBinding_2020_1_0_a17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173D3 RID: 95187 RVA: 0x0036F908 File Offset: 0x0036DB08
		public static YamlNode ExportYamlRelease_Array_BufferBinding_5_5_0(this AssetList<BufferBinding_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173D4 RID: 95188 RVA: 0x0036F948 File Offset: 0x0036DB48
		public static YamlNode ExportYamlRelease_Array_BuildReportFile(this AssetList<BuildReportFile> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173D5 RID: 95189 RVA: 0x0036F988 File Offset: 0x0036DB88
		public static YamlNode ExportYamlRelease_Array_BuildReportPackedAssetInfo_2019_3_0_a8(this AssetList<BuildReportPackedAssetInfo_2019_3_0_a8> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173D6 RID: 95190 RVA: 0x0036F9C8 File Offset: 0x0036DBC8
		public static YamlNode ExportYamlRelease_Array_BuildReportPackedAssetInfo_5_4_0(this AssetList<BuildReportPackedAssetInfo_5_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173D7 RID: 95191 RVA: 0x0036FA08 File Offset: 0x0036DC08
		public static YamlNode ExportYamlRelease_Array_BuildReportPackedAssetInfo_5_4_2(this AssetList<BuildReportPackedAssetInfo_5_4_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173D8 RID: 95192 RVA: 0x0036FA48 File Offset: 0x0036DC48
		public static YamlNode ExportYamlRelease_Array_BuildReportPackedAssetInfo_5_5_0(this AssetList<BuildReportPackedAssetInfo_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173D9 RID: 95193 RVA: 0x0036FA88 File Offset: 0x0036DC88
		public static YamlNode ExportYamlRelease_Array_BuildReportScenesUsingAsset(this AssetList<BuildReportScenesUsingAsset> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173DA RID: 95194 RVA: 0x0036FAC8 File Offset: 0x0036DCC8
		public static YamlNode ExportYamlRelease_Array_BuildStepInfo_2017_1_0(this AssetList<BuildStepInfo_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173DB RID: 95195 RVA: 0x0036FB08 File Offset: 0x0036DD08
		public static YamlNode ExportYamlRelease_Array_BuildStepInfo_2018_1_0(this AssetList<BuildStepInfo_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173DC RID: 95196 RVA: 0x0036FB48 File Offset: 0x0036DD48
		public static YamlNode ExportYamlRelease_Array_BuildStepInfo_5_4_0(this AssetList<BuildStepInfo_5_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173DD RID: 95197 RVA: 0x0036FB88 File Offset: 0x0036DD88
		public static YamlNode ExportYamlRelease_Array_BuildStepMessage(this AssetList<BuildStepMessage> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173DE RID: 95198 RVA: 0x0036FBC8 File Offset: 0x0036DDC8
		public static YamlNode ExportYamlRelease_Array_BuildTargetSettings_Material_3_5_0(this AssetList<BuildTargetSettings_Material_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173DF RID: 95199 RVA: 0x0036FC08 File Offset: 0x0036DE08
		public static YamlNode ExportYamlRelease_Array_BuildTargetSettings_Material_4_0_0(this AssetList<BuildTargetSettings_Material_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173E0 RID: 95200 RVA: 0x0036FC48 File Offset: 0x0036DE48
		public static YamlNode ExportYamlRelease_Array_BuildTextureStackReference(this AssetList<BuildTextureStackReference> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173E1 RID: 95201 RVA: 0x0036FC88 File Offset: 0x0036DE88
		public static YamlNode ExportYamlRelease_Array_BuiltAssetBundleInfo_2017_1_0_b4(this AssetList<BuiltAssetBundleInfo_2017_1_0_b4> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173E2 RID: 95202 RVA: 0x0036FCC8 File Offset: 0x0036DEC8
		public static YamlNode ExportYamlRelease_Array_BuiltAssetBundleInfo_5_5_4(this AssetList<BuiltAssetBundleInfo_5_5_4> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173E3 RID: 95203 RVA: 0x0036FD08 File Offset: 0x0036DF08
		public static YamlNode ExportYamlRelease_Array_BuiltAssetBundleInfo_5_6_2(this AssetList<BuiltAssetBundleInfo_5_6_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173E4 RID: 95204 RVA: 0x0036FD45 File Offset: 0x0036DF45
		public static YamlNode ExportYamlRelease_Array_Byte(this byte[] value, IExportContainer container)
		{
			return YamlArrayExtensions.ExportYaml(value);
		}

		// Token: 0x060173E5 RID: 95205 RVA: 0x0036FD50 File Offset: 0x0036DF50
		public static YamlNode ExportYamlRelease_Array_Channel_2017_1_0(this AssetList<Channel_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173E6 RID: 95206 RVA: 0x0036FD90 File Offset: 0x0036DF90
		public static YamlNode ExportYamlRelease_Array_Channel_2018_1_0(this AssetList<Channel_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173E7 RID: 95207 RVA: 0x0036FDD0 File Offset: 0x0036DFD0
		public static YamlNode ExportYamlRelease_Array_Channel_3_4_0(this AssetList<Channel_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173E8 RID: 95208 RVA: 0x0036FE10 File Offset: 0x0036E010
		public static YamlNode ExportYamlRelease_Array_Channel_5_3_0(this AssetList<Channel_5_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173E9 RID: 95209 RVA: 0x0036FE50 File Offset: 0x0036E050
		public static YamlNode ExportYamlRelease_Array_Channel_5_5_0(this AssetList<Channel_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173EA RID: 95210 RVA: 0x0036FE90 File Offset: 0x0036E090
		public static YamlNode ExportYamlRelease_Array_ChannelInfo(this AssetList<ChannelInfo> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173EB RID: 95211 RVA: 0x0036FED0 File Offset: 0x0036E0D0
		public static YamlNode ExportYamlRelease_Array_CharacterInfo_3_4_0(this AssetList<CharacterInfo_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173EC RID: 95212 RVA: 0x0036FF10 File Offset: 0x0036E110
		public static YamlNode ExportYamlRelease_Array_CharacterInfo_4_0_0(this AssetList<CharacterInfo_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173ED RID: 95213 RVA: 0x0036FF50 File Offset: 0x0036E150
		public static YamlNode ExportYamlRelease_Array_CharacterInfo_5_3_0(this AssetList<CharacterInfo_5_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173EE RID: 95214 RVA: 0x0036FF90 File Offset: 0x0036E190
		public static YamlNode ExportYamlRelease_Array_ChildAnimatorState(this AssetList<ChildAnimatorState> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173EF RID: 95215 RVA: 0x0036FFD0 File Offset: 0x0036E1D0
		public static YamlNode ExportYamlRelease_Array_ChildAnimatorStateMachine(this AssetList<ChildAnimatorStateMachine> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173F0 RID: 95216 RVA: 0x00370010 File Offset: 0x0036E210
		public static YamlNode ExportYamlRelease_Array_ChildMotion_4_0_0(this AssetList<ChildMotion_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173F1 RID: 95217 RVA: 0x00370050 File Offset: 0x0036E250
		public static YamlNode ExportYamlRelease_Array_ChildMotion_4_1_0(this AssetList<ChildMotion_4_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173F2 RID: 95218 RVA: 0x00370090 File Offset: 0x0036E290
		public static YamlNode ExportYamlRelease_Array_ChildMotion_5_0_0(this AssetList<ChildMotion_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173F3 RID: 95219 RVA: 0x003700D0 File Offset: 0x0036E2D0
		public static YamlNode ExportYamlRelease_Array_ClassInfo_2019_4_29(this AssetList<ClassInfo_2019_4_29> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173F4 RID: 95220 RVA: 0x00370110 File Offset: 0x0036E310
		public static YamlNode ExportYamlRelease_Array_ClassInfo_2020_1_0(this AssetList<ClassInfo_2020_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173F5 RID: 95221 RVA: 0x00370150 File Offset: 0x0036E350
		public static YamlNode ExportYamlRelease_Array_ClassInfo_5_0_0(this AssetList<ClassInfo_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173F6 RID: 95222 RVA: 0x00370190 File Offset: 0x0036E390
		public static YamlNode ExportYamlRelease_Array_ClassMethodInfo(this AssetList<ClassMethodInfo> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173F7 RID: 95223 RVA: 0x003701D0 File Offset: 0x0036E3D0
		public static YamlNode ExportYamlRelease_Array_ClipAnimationInfo_2017_1_0(this AssetList<ClipAnimationInfo_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173F8 RID: 95224 RVA: 0x00370210 File Offset: 0x0036E410
		public static YamlNode ExportYamlRelease_Array_ClipAnimationInfo_2018_1_0(this AssetList<ClipAnimationInfo_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173F9 RID: 95225 RVA: 0x00370250 File Offset: 0x0036E450
		public static YamlNode ExportYamlRelease_Array_ClipAnimationInfo_2019_1_0(this AssetList<ClipAnimationInfo_2019_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173FA RID: 95226 RVA: 0x00370290 File Offset: 0x0036E490
		public static YamlNode ExportYamlRelease_Array_ClipAnimationInfo_3_4_0(this AssetList<ClipAnimationInfo_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173FB RID: 95227 RVA: 0x003702D0 File Offset: 0x0036E4D0
		public static YamlNode ExportYamlRelease_Array_ClipAnimationInfo_4_0_0(this AssetList<ClipAnimationInfo_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173FC RID: 95228 RVA: 0x00370310 File Offset: 0x0036E510
		public static YamlNode ExportYamlRelease_Array_ClipAnimationInfo_4_1_0(this AssetList<ClipAnimationInfo_4_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173FD RID: 95229 RVA: 0x00370350 File Offset: 0x0036E550
		public static YamlNode ExportYamlRelease_Array_ClipAnimationInfo_4_3_0(this AssetList<ClipAnimationInfo_4_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173FE RID: 95230 RVA: 0x00370390 File Offset: 0x0036E590
		public static YamlNode ExportYamlRelease_Array_ClipAnimationInfo_5_0_0(this AssetList<ClipAnimationInfo_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060173FF RID: 95231 RVA: 0x003703D0 File Offset: 0x0036E5D0
		public static YamlNode ExportYamlRelease_Array_ClipAnimationInfo_5_3_0(this AssetList<ClipAnimationInfo_5_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017400 RID: 95232 RVA: 0x00370410 File Offset: 0x0036E610
		public static YamlNode ExportYamlRelease_Array_ClipAnimationInfo_5_5_0(this AssetList<ClipAnimationInfo_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017401 RID: 95233 RVA: 0x00370450 File Offset: 0x0036E650
		public static YamlNode ExportYamlRelease_Array_ClipAnimationInfoCurve_2017_1_0(this AssetList<ClipAnimationInfoCurve_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017402 RID: 95234 RVA: 0x00370490 File Offset: 0x0036E690
		public static YamlNode ExportYamlRelease_Array_ClipAnimationInfoCurve_2018_1_0(this AssetList<ClipAnimationInfoCurve_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017403 RID: 95235 RVA: 0x003704D0 File Offset: 0x0036E6D0
		public static YamlNode ExportYamlRelease_Array_ClipAnimationInfoCurve_4_0_0(this AssetList<ClipAnimationInfoCurve_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017404 RID: 95236 RVA: 0x00370510 File Offset: 0x0036E710
		public static YamlNode ExportYamlRelease_Array_ClipAnimationInfoCurve_5_3_0(this AssetList<ClipAnimationInfoCurve_5_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017405 RID: 95237 RVA: 0x00370550 File Offset: 0x0036E750
		public static YamlNode ExportYamlRelease_Array_ClipAnimationInfoCurve_5_5_0(this AssetList<ClipAnimationInfoCurve_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017406 RID: 95238 RVA: 0x00370590 File Offset: 0x0036E790
		public static YamlNode ExportYamlRelease_Array_ClothAttachment(this AssetList<ClothAttachment> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017407 RID: 95239 RVA: 0x003705D0 File Offset: 0x0036E7D0
		public static YamlNode ExportYamlRelease_Array_ClothConstrainCoefficients_3_4_0(this AssetList<ClothConstrainCoefficients_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017408 RID: 95240 RVA: 0x00370610 File Offset: 0x0036E810
		public static YamlNode ExportYamlRelease_Array_ClothConstrainCoefficients_5_0_0(this AssetList<ClothConstrainCoefficients_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017409 RID: 95241 RVA: 0x00370650 File Offset: 0x0036E850
		public static YamlNode ExportYamlRelease_Array_ClothSphereColliderPair(this AssetList<ClothSphereColliderPair> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601740A RID: 95242 RVA: 0x00370690 File Offset: 0x0036E890
		public static YamlNode ExportYamlRelease_Array_ClusterInput(this AssetList<ClusterInput> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601740B RID: 95243 RVA: 0x003706D0 File Offset: 0x0036E8D0
		public static YamlNode ExportYamlRelease_Array_Collider_4_0_0(this AssetList<Collider_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601740C RID: 95244 RVA: 0x00370710 File Offset: 0x0036E910
		public static YamlNode ExportYamlRelease_Array_Collider_5_4_0(this AssetList<Collider_5_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601740D RID: 95245 RVA: 0x00370750 File Offset: 0x0036E950
		public static YamlNode ExportYamlRelease_Array_Collider_5_5_0(this AssetList<Collider_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601740E RID: 95246 RVA: 0x00370790 File Offset: 0x0036E990
		public static YamlNode ExportYamlRelease_Array_ColorRGBA32(this AssetList<ColorRGBA32> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601740F RID: 95247 RVA: 0x003707D0 File Offset: 0x0036E9D0
		public static YamlNode ExportYamlRelease_Array_ComponentPair(this AssetList<ComponentPair> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017410 RID: 95248 RVA: 0x00370810 File Offset: 0x0036EA10
		public static YamlNode ExportYamlRelease_Array_CompressedAnimationCurve(this AssetList<CompressedAnimationCurve> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017411 RID: 95249 RVA: 0x00370850 File Offset: 0x0036EA50
		public static YamlNode ExportYamlRelease_Array_ComputeShaderBuiltinSampler_2017_1_0(this AssetList<ComputeShaderBuiltinSampler_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017412 RID: 95250 RVA: 0x00370890 File Offset: 0x0036EA90
		public static YamlNode ExportYamlRelease_Array_ComputeShaderBuiltinSampler_4_0_0(this AssetList<ComputeShaderBuiltinSampler_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017413 RID: 95251 RVA: 0x003708D0 File Offset: 0x0036EAD0
		public static YamlNode ExportYamlRelease_Array_ComputeShaderCB_2017_1_0(this AssetList<ComputeShaderCB_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017414 RID: 95252 RVA: 0x00370910 File Offset: 0x0036EB10
		public static YamlNode ExportYamlRelease_Array_ComputeShaderCB_2020_1_0_a9(this AssetList<ComputeShaderCB_2020_1_0_a9> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017415 RID: 95253 RVA: 0x00370950 File Offset: 0x0036EB50
		public static YamlNode ExportYamlRelease_Array_ComputeShaderCB_4_0_0(this AssetList<ComputeShaderCB_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017416 RID: 95254 RVA: 0x00370990 File Offset: 0x0036EB90
		public static YamlNode ExportYamlRelease_Array_ComputeShaderCB_5_6_0(this AssetList<ComputeShaderCB_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017417 RID: 95255 RVA: 0x003709D0 File Offset: 0x0036EBD0
		public static YamlNode ExportYamlRelease_Array_ComputeShaderKernel_2017_1_0(this AssetList<ComputeShaderKernel_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017418 RID: 95256 RVA: 0x00370A10 File Offset: 0x0036EC10
		public static YamlNode ExportYamlRelease_Array_ComputeShaderKernel_2018_1_0(this AssetList<ComputeShaderKernel_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017419 RID: 95257 RVA: 0x00370A50 File Offset: 0x0036EC50
		public static YamlNode ExportYamlRelease_Array_ComputeShaderKernel_2018_2_0(this AssetList<ComputeShaderKernel_2018_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601741A RID: 95258 RVA: 0x00370A90 File Offset: 0x0036EC90
		public static YamlNode ExportYamlRelease_Array_ComputeShaderKernel_2018_2_0_b9(this AssetList<ComputeShaderKernel_2018_2_0_b9> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601741B RID: 95259 RVA: 0x00370AD0 File Offset: 0x0036ECD0
		public static YamlNode ExportYamlRelease_Array_ComputeShaderKernel_2021_1_0_b7(this AssetList<ComputeShaderKernel_2021_1_0_b7> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601741C RID: 95260 RVA: 0x00370B10 File Offset: 0x0036ED10
		public static YamlNode ExportYamlRelease_Array_ComputeShaderKernel_4_0_0(this AssetList<ComputeShaderKernel_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601741D RID: 95261 RVA: 0x00370B50 File Offset: 0x0036ED50
		public static YamlNode ExportYamlRelease_Array_ComputeShaderKernel_5_1_0(this AssetList<ComputeShaderKernel_5_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601741E RID: 95262 RVA: 0x00370B90 File Offset: 0x0036ED90
		public static YamlNode ExportYamlRelease_Array_ComputeShaderKernel_5_2_3(this AssetList<ComputeShaderKernel_5_2_3> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601741F RID: 95263 RVA: 0x00370BD0 File Offset: 0x0036EDD0
		public static YamlNode ExportYamlRelease_Array_ComputeShaderKernel_5_4_0(this AssetList<ComputeShaderKernel_5_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017420 RID: 95264 RVA: 0x00370C10 File Offset: 0x0036EE10
		public static YamlNode ExportYamlRelease_Array_ComputeShaderKernel_5_6_0(this AssetList<ComputeShaderKernel_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017421 RID: 95265 RVA: 0x00370C50 File Offset: 0x0036EE50
		public static YamlNode ExportYamlRelease_Array_ComputeShaderKernelParent_2020_1_0_a17(this AssetList<ComputeShaderKernelParent_2020_1_0_a17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017422 RID: 95266 RVA: 0x00370C90 File Offset: 0x0036EE90
		public static YamlNode ExportYamlRelease_Array_ComputeShaderKernelParent_2020_1_0_a9(this AssetList<ComputeShaderKernelParent_2020_1_0_a9> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017423 RID: 95267 RVA: 0x00370CD0 File Offset: 0x0036EED0
		public static YamlNode ExportYamlRelease_Array_ComputeShaderKernelParent_2020_2_0_a15(this AssetList<ComputeShaderKernelParent_2020_2_0_a15> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017424 RID: 95268 RVA: 0x00370D10 File Offset: 0x0036EF10
		public static YamlNode ExportYamlRelease_Array_ComputeShaderKernelParent_2020_3_2(this AssetList<ComputeShaderKernelParent_2020_3_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017425 RID: 95269 RVA: 0x00370D50 File Offset: 0x0036EF50
		public static YamlNode ExportYamlRelease_Array_ComputeShaderKernelParent_2021_1_0(this AssetList<ComputeShaderKernelParent_2021_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017426 RID: 95270 RVA: 0x00370D90 File Offset: 0x0036EF90
		public static YamlNode ExportYamlRelease_Array_ComputeShaderKernelParent_2021_1_0_b7(this AssetList<ComputeShaderKernelParent_2021_1_0_b7> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017427 RID: 95271 RVA: 0x00370DD0 File Offset: 0x0036EFD0
		public static YamlNode ExportYamlRelease_Array_ComputeShaderKernelParent_2022_1_0_a15(this AssetList<ComputeShaderKernelParent_2022_1_0_a15> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017428 RID: 95272 RVA: 0x00370E10 File Offset: 0x0036F010
		public static YamlNode ExportYamlRelease_Array_ComputeShaderParam_2020_1_0_a9(this AssetList<ComputeShaderParam_2020_1_0_a9> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017429 RID: 95273 RVA: 0x00370E50 File Offset: 0x0036F050
		public static YamlNode ExportYamlRelease_Array_ComputeShaderParam_4_0_0(this AssetList<ComputeShaderParam_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601742A RID: 95274 RVA: 0x00370E90 File Offset: 0x0036F090
		public static YamlNode ExportYamlRelease_Array_ComputeShaderParam_5_6_0(this AssetList<ComputeShaderParam_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601742B RID: 95275 RVA: 0x00370ED0 File Offset: 0x0036F0D0
		public static YamlNode ExportYamlRelease_Array_ComputeShaderResource_2018_1_0(this AssetList<ComputeShaderResource_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601742C RID: 95276 RVA: 0x00370F10 File Offset: 0x0036F110
		public static YamlNode ExportYamlRelease_Array_ComputeShaderResource_2018_2_0(this AssetList<ComputeShaderResource_2018_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601742D RID: 95277 RVA: 0x00370F50 File Offset: 0x0036F150
		public static YamlNode ExportYamlRelease_Array_ComputeShaderResource_2018_2_0_b9(this AssetList<ComputeShaderResource_2018_2_0_b9> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601742E RID: 95278 RVA: 0x00370F90 File Offset: 0x0036F190
		public static YamlNode ExportYamlRelease_Array_ComputeShaderResource_4_0_0(this AssetList<ComputeShaderResource_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601742F RID: 95279 RVA: 0x00370FD0 File Offset: 0x0036F1D0
		public static YamlNode ExportYamlRelease_Array_ComputeShaderResource_5_1_0(this AssetList<ComputeShaderResource_5_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017430 RID: 95280 RVA: 0x00371010 File Offset: 0x0036F210
		public static YamlNode ExportYamlRelease_Array_ComputeShaderResource_5_2_3(this AssetList<ComputeShaderResource_5_2_3> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017431 RID: 95281 RVA: 0x00371050 File Offset: 0x0036F250
		public static YamlNode ExportYamlRelease_Array_ComputeShaderResource_5_6_0(this AssetList<ComputeShaderResource_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017432 RID: 95282 RVA: 0x00371090 File Offset: 0x0036F290
		public static YamlNode ExportYamlRelease_Array_ComputeShaderVariant_2017_1_0(this AssetList<ComputeShaderVariant_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017433 RID: 95283 RVA: 0x003710D0 File Offset: 0x0036F2D0
		public static YamlNode ExportYamlRelease_Array_ComputeShaderVariant_2018_1_0(this AssetList<ComputeShaderVariant_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017434 RID: 95284 RVA: 0x00371110 File Offset: 0x0036F310
		public static YamlNode ExportYamlRelease_Array_ComputeShaderVariant_2018_2_0(this AssetList<ComputeShaderVariant_2018_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017435 RID: 95285 RVA: 0x00371150 File Offset: 0x0036F350
		public static YamlNode ExportYamlRelease_Array_ComputeShaderVariant_2018_2_0_b9(this AssetList<ComputeShaderVariant_2018_2_0_b9> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017436 RID: 95286 RVA: 0x00371190 File Offset: 0x0036F390
		public static YamlNode ExportYamlRelease_Array_ComputeShaderVariant_2020_1_0_a17(this AssetList<ComputeShaderVariant_2020_1_0_a17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017437 RID: 95287 RVA: 0x003711D0 File Offset: 0x0036F3D0
		public static YamlNode ExportYamlRelease_Array_ComputeShaderVariant_2020_1_0_a9(this AssetList<ComputeShaderVariant_2020_1_0_a9> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017438 RID: 95288 RVA: 0x00371210 File Offset: 0x0036F410
		public static YamlNode ExportYamlRelease_Array_ComputeShaderVariant_2020_2_0_a15(this AssetList<ComputeShaderVariant_2020_2_0_a15> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017439 RID: 95289 RVA: 0x00371250 File Offset: 0x0036F450
		public static YamlNode ExportYamlRelease_Array_ComputeShaderVariant_2020_3_2(this AssetList<ComputeShaderVariant_2020_3_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601743A RID: 95290 RVA: 0x00371290 File Offset: 0x0036F490
		public static YamlNode ExportYamlRelease_Array_ComputeShaderVariant_2021_1_0(this AssetList<ComputeShaderVariant_2021_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601743B RID: 95291 RVA: 0x003712D0 File Offset: 0x0036F4D0
		public static YamlNode ExportYamlRelease_Array_ComputeShaderVariant_2021_1_0_b7(this AssetList<ComputeShaderVariant_2021_1_0_b7> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601743C RID: 95292 RVA: 0x00371310 File Offset: 0x0036F510
		public static YamlNode ExportYamlRelease_Array_ComputeShaderVariant_2021_2_0_a19(this AssetList<ComputeShaderVariant_2021_2_0_a19> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601743D RID: 95293 RVA: 0x00371350 File Offset: 0x0036F550
		public static YamlNode ExportYamlRelease_Array_ComputeShaderVariant_2022_1_0_a15(this AssetList<ComputeShaderVariant_2022_1_0_a15> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601743E RID: 95294 RVA: 0x00371390 File Offset: 0x0036F590
		public static YamlNode ExportYamlRelease_Array_ComputeShaderVariant_5_0_0(this AssetList<ComputeShaderVariant_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601743F RID: 95295 RVA: 0x003713D0 File Offset: 0x0036F5D0
		public static YamlNode ExportYamlRelease_Array_ComputeShaderVariant_5_1_0(this AssetList<ComputeShaderVariant_5_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017440 RID: 95296 RVA: 0x00371410 File Offset: 0x0036F610
		public static YamlNode ExportYamlRelease_Array_ComputeShaderVariant_5_2_3(this AssetList<ComputeShaderVariant_5_2_3> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017441 RID: 95297 RVA: 0x00371450 File Offset: 0x0036F650
		public static YamlNode ExportYamlRelease_Array_ComputeShaderVariant_5_4_0(this AssetList<ComputeShaderVariant_5_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017442 RID: 95298 RVA: 0x00371490 File Offset: 0x0036F690
		public static YamlNode ExportYamlRelease_Array_ComputeShaderVariant_5_6_0(this AssetList<ComputeShaderVariant_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017443 RID: 95299 RVA: 0x003714D0 File Offset: 0x0036F6D0
		public static YamlNode ExportYamlRelease_Array_ConstantBuffer_2017_1_0(this AssetList<ConstantBuffer_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017444 RID: 95300 RVA: 0x00371510 File Offset: 0x0036F710
		public static YamlNode ExportYamlRelease_Array_ConstantBuffer_2017_3_0(this AssetList<ConstantBuffer_2017_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017445 RID: 95301 RVA: 0x00371550 File Offset: 0x0036F750
		public static YamlNode ExportYamlRelease_Array_ConstantBuffer_2020_3_2(this AssetList<ConstantBuffer_2020_3_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017446 RID: 95302 RVA: 0x00371590 File Offset: 0x0036F790
		public static YamlNode ExportYamlRelease_Array_ConstantBuffer_2021_1_0(this AssetList<ConstantBuffer_2021_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017447 RID: 95303 RVA: 0x003715D0 File Offset: 0x0036F7D0
		public static YamlNode ExportYamlRelease_Array_ConstantBuffer_2021_1_1(this AssetList<ConstantBuffer_2021_1_1> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017448 RID: 95304 RVA: 0x00371610 File Offset: 0x0036F810
		public static YamlNode ExportYamlRelease_Array_ConstantBuffer_5_5_0(this AssetList<ConstantBuffer_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017449 RID: 95305 RVA: 0x00371650 File Offset: 0x0036F850
		public static YamlNode ExportYamlRelease_Array_ConstraintSource(this AssetList<ConstraintSource> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601744A RID: 95306 RVA: 0x00371690 File Offset: 0x0036F890
		public static YamlNode ExportYamlRelease_Array_DefaultPreset_2018_1_0(this AssetList<DefaultPreset_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601744B RID: 95307 RVA: 0x003716D0 File Offset: 0x0036F8D0
		public static YamlNode ExportYamlRelease_Array_DefaultPreset_2019_3_0_a10(this AssetList<DefaultPreset_2019_3_0_a10> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601744C RID: 95308 RVA: 0x00371710 File Offset: 0x0036F910
		public static YamlNode ExportYamlRelease_Array_DefaultPreset_2020_1_0_a23(this AssetList<DefaultPreset_2020_1_0_a23> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601744D RID: 95309 RVA: 0x00371750 File Offset: 0x0036F950
		public static YamlNode ExportYamlRelease_Array_DefaultPresetList(this AssetList<DefaultPresetList> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601744E RID: 95310 RVA: 0x00371790 File Offset: 0x0036F990
		public static YamlNode ExportYamlRelease_Array_DetailPatch_2020_2_0_b10(this AssetList<DetailPatch_2020_2_0_b10> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601744F RID: 95311 RVA: 0x003717D0 File Offset: 0x0036F9D0
		public static YamlNode ExportYamlRelease_Array_DetailPatch_2022_2_0(this AssetList<DetailPatch_2022_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017450 RID: 95312 RVA: 0x00371810 File Offset: 0x0036FA10
		public static YamlNode ExportYamlRelease_Array_DetailPatch_3_4_0(this AssetList<DetailPatch_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017451 RID: 95313 RVA: 0x00371850 File Offset: 0x0036FA50
		public static YamlNode ExportYamlRelease_Array_DetailPatch_3_5_0(this AssetList<DetailPatch_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017452 RID: 95314 RVA: 0x00371890 File Offset: 0x0036FA90
		public static YamlNode ExportYamlRelease_Array_DetailPrototype_2020_2_0_b10(this AssetList<DetailPrototype_2020_2_0_b10> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017453 RID: 95315 RVA: 0x003718D0 File Offset: 0x0036FAD0
		public static YamlNode ExportYamlRelease_Array_DetailPrototype_2021_2_0(this AssetList<DetailPrototype_2021_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017454 RID: 95316 RVA: 0x00371910 File Offset: 0x0036FB10
		public static YamlNode ExportYamlRelease_Array_DetailPrototype_2022_2_0(this AssetList<DetailPrototype_2022_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017455 RID: 95317 RVA: 0x00371950 File Offset: 0x0036FB50
		public static YamlNode ExportYamlRelease_Array_DetailPrototype_2022_2_0_a16(this AssetList<DetailPrototype_2022_2_0_a16> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017456 RID: 95318 RVA: 0x00371990 File Offset: 0x0036FB90
		public static YamlNode ExportYamlRelease_Array_DetailPrototype_3_4_0(this AssetList<DetailPrototype_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017457 RID: 95319 RVA: 0x003719D0 File Offset: 0x0036FBD0
		public static YamlNode ExportYamlRelease_Array_DetailPrototype_3_5_0(this AssetList<DetailPrototype_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017458 RID: 95320 RVA: 0x00371A10 File Offset: 0x0036FC10
		public static YamlNode ExportYamlRelease_Array_DetailPrototype_5_0_0(this AssetList<DetailPrototype_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017459 RID: 95321 RVA: 0x00371A50 File Offset: 0x0036FC50
		public static YamlNode ExportYamlRelease_Array_DirectorGenericBinding(this AssetList<DirectorGenericBinding> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601745A RID: 95322 RVA: 0x00371A90 File Offset: 0x0036FC90
		public static YamlNode ExportYamlRelease_Array_EffectConstant(this AssetList<EffectConstant> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601745B RID: 95323 RVA: 0x00371AD0 File Offset: 0x0036FCD0
		public static YamlNode ExportYamlRelease_Array_EnlightenRendererInformation(this AssetList<EnlightenRendererInformation> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601745C RID: 95324 RVA: 0x00371B10 File Offset: 0x0036FD10
		public static YamlNode ExportYamlRelease_Array_EnlightenSystemAtlasInformation(this AssetList<EnlightenSystemAtlasInformation> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601745D RID: 95325 RVA: 0x00371B50 File Offset: 0x0036FD50
		public static YamlNode ExportYamlRelease_Array_EnlightenSystemInformation(this AssetList<EnlightenSystemInformation> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601745E RID: 95326 RVA: 0x00371B90 File Offset: 0x0036FD90
		public static YamlNode ExportYamlRelease_Array_EnlightenTerrainChunksInformation(this AssetList<EnlightenTerrainChunksInformation> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601745F RID: 95327 RVA: 0x00371BD0 File Offset: 0x0036FDD0
		public static YamlNode ExportYamlRelease_Array_ExpandedData_2017_1_0(this AssetList<ExpandedData_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017460 RID: 95328 RVA: 0x00371C10 File Offset: 0x0036FE10
		public static YamlNode ExportYamlRelease_Array_ExpandedData_3_4_0(this AssetList<ExpandedData_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017461 RID: 95329 RVA: 0x00371C50 File Offset: 0x0036FE50
		public static YamlNode ExportYamlRelease_Array_ExpandedData_5_6_0(this AssetList<ExpandedData_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017462 RID: 95330 RVA: 0x00371C90 File Offset: 0x0036FE90
		public static YamlNode ExportYamlRelease_Array_Expression(this AssetList<Expression> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017463 RID: 95331 RVA: 0x00371CD0 File Offset: 0x0036FED0
		public static YamlNode ExportYamlRelease_Array_ExtensionPropertyValue(this AssetList<ExtensionPropertyValue> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017464 RID: 95332 RVA: 0x00371D10 File Offset: 0x0036FF10
		public static YamlNode ExportYamlRelease_Array_FlareElement_3_4_0(this AssetList<FlareElement_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017465 RID: 95333 RVA: 0x00371D50 File Offset: 0x0036FF50
		public static YamlNode ExportYamlRelease_Array_FlareElement_3_5_0(this AssetList<FlareElement_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017466 RID: 95334 RVA: 0x00371D90 File Offset: 0x0036FF90
		public static YamlNode ExportYamlRelease_Array_FloatCurve_2017_1_0(this AssetList<FloatCurve_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017467 RID: 95335 RVA: 0x00371DD0 File Offset: 0x0036FFD0
		public static YamlNode ExportYamlRelease_Array_FloatCurve_2018_1_0(this AssetList<FloatCurve_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017468 RID: 95336 RVA: 0x00371E10 File Offset: 0x00370010
		public static YamlNode ExportYamlRelease_Array_FloatCurve_2022_2_0(this AssetList<FloatCurve_2022_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017469 RID: 95337 RVA: 0x00371E50 File Offset: 0x00370050
		public static YamlNode ExportYamlRelease_Array_FloatCurve_3_4_0(this AssetList<FloatCurve_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601746A RID: 95338 RVA: 0x00371E90 File Offset: 0x00370090
		public static YamlNode ExportYamlRelease_Array_FloatCurve_5_0_0(this AssetList<FloatCurve_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601746B RID: 95339 RVA: 0x00371ED0 File Offset: 0x003700D0
		public static YamlNode ExportYamlRelease_Array_FloatCurve_5_3_0(this AssetList<FloatCurve_5_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601746C RID: 95340 RVA: 0x00371F10 File Offset: 0x00370110
		public static YamlNode ExportYamlRelease_Array_FloatCurve_5_5_0(this AssetList<FloatCurve_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601746D RID: 95341 RVA: 0x00371F50 File Offset: 0x00370150
		public static YamlNode ExportYamlRelease_Array_FloatCurve_5_6_0(this AssetList<FloatCurve_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601746E RID: 95342 RVA: 0x00371F90 File Offset: 0x00370190
		public static YamlNode ExportYamlRelease_Array_GenericBinding_2022_1_0_a12(this AssetList<GenericBinding_2022_1_0_a12> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601746F RID: 95343 RVA: 0x00371FD0 File Offset: 0x003701D0
		public static YamlNode ExportYamlRelease_Array_GenericBinding_2022_2_0(this AssetList<GenericBinding_2022_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017470 RID: 95344 RVA: 0x00372010 File Offset: 0x00370210
		public static YamlNode ExportYamlRelease_Array_GenericBinding_4_3_0(this AssetList<GenericBinding_4_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017471 RID: 95345 RVA: 0x00372050 File Offset: 0x00370250
		public static YamlNode ExportYamlRelease_Array_GenericBinding_4_5_0(this AssetList<GenericBinding_4_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017472 RID: 95346 RVA: 0x00372090 File Offset: 0x00370290
		public static YamlNode ExportYamlRelease_Array_GenericBinding_5_0_0(this AssetList<GenericBinding_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017473 RID: 95347 RVA: 0x003720D0 File Offset: 0x003702D0
		public static YamlNode ExportYamlRelease_Array_GenericBinding_5_6_0(this AssetList<GenericBinding_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017474 RID: 95348 RVA: 0x00372110 File Offset: 0x00370310
		public static YamlNode ExportYamlRelease_Array_GroupConnection(this AssetList<GroupConnection> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017475 RID: 95349 RVA: 0x00372150 File Offset: 0x00370350
		public static YamlNode ExportYamlRelease_Array_GroupConstant_2019_1_0_a13(this AssetList<GroupConstant_2019_1_0_a13> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017476 RID: 95350 RVA: 0x00372190 File Offset: 0x00370390
		public static YamlNode ExportYamlRelease_Array_GroupConstant_2019_4_32(this AssetList<GroupConstant_2019_4_32> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017477 RID: 95351 RVA: 0x003721D0 File Offset: 0x003703D0
		public static YamlNode ExportYamlRelease_Array_GroupConstant_2020_1_0(this AssetList<GroupConstant_2020_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017478 RID: 95352 RVA: 0x00372210 File Offset: 0x00370410
		public static YamlNode ExportYamlRelease_Array_GroupConstant_2020_3_21(this AssetList<GroupConstant_2020_3_21> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017479 RID: 95353 RVA: 0x00372250 File Offset: 0x00370450
		public static YamlNode ExportYamlRelease_Array_GroupConstant_2021_1_0(this AssetList<GroupConstant_2021_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601747A RID: 95354 RVA: 0x00372290 File Offset: 0x00370490
		public static YamlNode ExportYamlRelease_Array_GroupConstant_2021_1_26(this AssetList<GroupConstant_2021_1_26> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601747B RID: 95355 RVA: 0x003722D0 File Offset: 0x003704D0
		public static YamlNode ExportYamlRelease_Array_GroupConstant_2021_2_0(this AssetList<GroupConstant_2021_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601747C RID: 95356 RVA: 0x00372310 File Offset: 0x00370510
		public static YamlNode ExportYamlRelease_Array_GroupConstant_2021_2_0_a16(this AssetList<GroupConstant_2021_2_0_a16> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601747D RID: 95357 RVA: 0x00372350 File Offset: 0x00370550
		public static YamlNode ExportYamlRelease_Array_GroupConstant_2021_2_0_a21(this AssetList<GroupConstant_2021_2_0_a21> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601747E RID: 95358 RVA: 0x00372390 File Offset: 0x00370590
		public static YamlNode ExportYamlRelease_Array_GroupConstant_2021_2_1(this AssetList<GroupConstant_2021_2_1> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601747F RID: 95359 RVA: 0x003723D0 File Offset: 0x003705D0
		public static YamlNode ExportYamlRelease_Array_GroupConstant_2022_1_0(this AssetList<GroupConstant_2022_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017480 RID: 95360 RVA: 0x00372410 File Offset: 0x00370610
		public static YamlNode ExportYamlRelease_Array_GroupConstant_2022_1_0_a10(this AssetList<GroupConstant_2022_1_0_a10> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017481 RID: 95361 RVA: 0x00372450 File Offset: 0x00370650
		public static YamlNode ExportYamlRelease_Array_GroupConstant_5_0_0(this AssetList<GroupConstant_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017482 RID: 95362 RVA: 0x00372490 File Offset: 0x00370690
		public static YamlNode ExportYamlRelease_Array_GUID(this AssetList<GUID> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017483 RID: 95363 RVA: 0x003724D0 File Offset: 0x003706D0
		public static YamlNode ExportYamlRelease_Array_Handle_4_0_0(this AssetList<Handle_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017484 RID: 95364 RVA: 0x00372510 File Offset: 0x00370710
		public static YamlNode ExportYamlRelease_Array_Handle_5_4_0(this AssetList<Handle_5_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017485 RID: 95365 RVA: 0x00372550 File Offset: 0x00370750
		public static YamlNode ExportYamlRelease_Array_Handle_5_5_0(this AssetList<Handle_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017486 RID: 95366 RVA: 0x00372590 File Offset: 0x00370790
		public static YamlNode ExportYamlRelease_Array_Hash128(this AssetList<Hash128> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017487 RID: 95367 RVA: 0x003725D0 File Offset: 0x003707D0
		public static YamlNode ExportYamlRelease_Array_HeightmapData_2022_2_0(this AssetList<HeightmapData_2022_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017488 RID: 95368 RVA: 0x00372610 File Offset: 0x00370810
		public static YamlNode ExportYamlRelease_Array_HeightmapData_3_5_0(this AssetList<HeightmapData_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017489 RID: 95369 RVA: 0x00372650 File Offset: 0x00370850
		public static YamlNode ExportYamlRelease_Array_HeightmapData_5_0_0(this AssetList<HeightmapData_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601748A RID: 95370 RVA: 0x00372690 File Offset: 0x00370890
		public static YamlNode ExportYamlRelease_Array_HeightMeshBVNode(this AssetList<HeightMeshBVNode> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601748B RID: 95371 RVA: 0x003726D0 File Offset: 0x003708D0
		public static YamlNode ExportYamlRelease_Array_HeightMeshData_2017_1_0(this AssetList<HeightMeshData_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601748C RID: 95372 RVA: 0x00372710 File Offset: 0x00370910
		public static YamlNode ExportYamlRelease_Array_HeightMeshData_5_0_0(this AssetList<HeightMeshData_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601748D RID: 95373 RVA: 0x00372750 File Offset: 0x00370950
		public static YamlNode ExportYamlRelease_Array_HumanBone_4_0_0(this AssetList<HumanBone_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601748E RID: 95374 RVA: 0x00372790 File Offset: 0x00370990
		public static YamlNode ExportYamlRelease_Array_HumanBone_4_3_0(this AssetList<HumanBone_4_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601748F RID: 95375 RVA: 0x003727D0 File Offset: 0x003709D0
		public static YamlNode ExportYamlRelease_Array_HumanGoal_4_0_0(this AssetList<HumanGoal_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017490 RID: 95376 RVA: 0x00372810 File Offset: 0x00370A10
		public static YamlNode ExportYamlRelease_Array_HumanGoal_5_0_0(this AssetList<HumanGoal_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017491 RID: 95377 RVA: 0x00372850 File Offset: 0x00370A50
		public static YamlNode ExportYamlRelease_Array_HumanGoal_5_4_0(this AssetList<HumanGoal_5_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017492 RID: 95378 RVA: 0x00372890 File Offset: 0x00370A90
		public static YamlNode ExportYamlRelease_Array_HumanGoal_5_5_0(this AssetList<HumanGoal_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017493 RID: 95379 RVA: 0x003728D0 File Offset: 0x00370AD0
		public static YamlNode ExportYamlRelease_Array_HumanHandle(this AssetList<HumanHandle> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017494 RID: 95380 RVA: 0x00372910 File Offset: 0x00370B10
		public static YamlNode ExportYamlRelease_Array_ImportLog_ImportLogEntry(this AssetList<ImportLog_ImportLogEntry> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017495 RID: 95381 RVA: 0x00372950 File Offset: 0x00370B50
		public static YamlNode ExportYamlRelease_Array_InputAxis(this AssetList<InputAxis> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017496 RID: 95382 RVA: 0x00372990 File Offset: 0x00370B90
		public static YamlNode ExportYamlRelease_Array_InputImportSettings(this AssetList<InputImportSettings> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017497 RID: 95383 RVA: 0x003729D0 File Offset: 0x00370BD0
		public static YamlNode ExportYamlRelease_Array_InputImportSettings_SubstanceValue_2017_2_0_b4(this AssetList<InputImportSettings_SubstanceValue_2017_2_0_b4> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017498 RID: 95384 RVA: 0x00372A10 File Offset: 0x00370C10
		public static YamlNode ExportYamlRelease_Array_InputImportSettings_SubstanceValue_3_4_0(this AssetList<InputImportSettings_SubstanceValue_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017499 RID: 95385 RVA: 0x00372A50 File Offset: 0x00370C50
		public static YamlNode ExportYamlRelease_Array_InputImportSettings_SubstanceValue_5_0_0(this AssetList<InputImportSettings_SubstanceValue_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601749A RID: 95386 RVA: 0x00372A90 File Offset: 0x00370C90
		public static YamlNode ExportYamlRelease_Array_Int16(this short[] value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int num = value.Length;
			for (int i = 0; i < num; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease_Int16(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601749B RID: 95387 RVA: 0x00372AC8 File Offset: 0x00370CC8
		public static YamlNode ExportYamlRelease_Array_Int32(this int[] value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int num = value.Length;
			for (int i = 0; i < num; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease_Int32(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601749C RID: 95388 RVA: 0x00372B00 File Offset: 0x00370D00
		public static YamlNode ExportYamlRelease_Array_Int64(this long[] value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int num = value.Length;
			for (int i = 0; i < num; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease_Int64(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601749D RID: 95389 RVA: 0x00372B38 File Offset: 0x00370D38
		public static YamlNode ExportYamlRelease_Array_Keyframe_Quaternionf_2018_1_0(this AssetList<Keyframe_Quaternionf_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601749E RID: 95390 RVA: 0x00372B78 File Offset: 0x00370D78
		public static YamlNode ExportYamlRelease_Array_Keyframe_Quaternionf_3_4_0(this AssetList<Keyframe_Quaternionf_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601749F RID: 95391 RVA: 0x00372BB8 File Offset: 0x00370DB8
		public static YamlNode ExportYamlRelease_Array_Keyframe_Quaternionf_3_5_0(this AssetList<Keyframe_Quaternionf_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174A0 RID: 95392 RVA: 0x00372BF8 File Offset: 0x00370DF8
		public static YamlNode ExportYamlRelease_Array_Keyframe_Quaternionf_5_5_0(this AssetList<Keyframe_Quaternionf_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174A1 RID: 95393 RVA: 0x00372C38 File Offset: 0x00370E38
		public static YamlNode ExportYamlRelease_Array_Keyframe_Single_2018_1_0(this AssetList<Keyframe_Single_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174A2 RID: 95394 RVA: 0x00372C78 File Offset: 0x00370E78
		public static YamlNode ExportYamlRelease_Array_Keyframe_Single_3_4_0(this AssetList<Keyframe_Single_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174A3 RID: 95395 RVA: 0x00372CB8 File Offset: 0x00370EB8
		public static YamlNode ExportYamlRelease_Array_Keyframe_Single_5_5_0(this AssetList<Keyframe_Single_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174A4 RID: 95396 RVA: 0x00372CF8 File Offset: 0x00370EF8
		public static YamlNode ExportYamlRelease_Array_Keyframe_Vector3f_2018_1_0(this AssetList<Keyframe_Vector3f_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174A5 RID: 95397 RVA: 0x00372D38 File Offset: 0x00370F38
		public static YamlNode ExportYamlRelease_Array_Keyframe_Vector3f_3_4_0(this AssetList<Keyframe_Vector3f_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174A6 RID: 95398 RVA: 0x00372D78 File Offset: 0x00370F78
		public static YamlNode ExportYamlRelease_Array_Keyframe_Vector3f_3_5_0(this AssetList<Keyframe_Vector3f_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174A7 RID: 95399 RVA: 0x00372DB8 File Offset: 0x00370FB8
		public static YamlNode ExportYamlRelease_Array_Keyframe_Vector3f_5_5_0(this AssetList<Keyframe_Vector3f_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174A8 RID: 95400 RVA: 0x00372DF8 File Offset: 0x00370FF8
		public static YamlNode ExportYamlRelease_Array_LeafInfoConstant(this AssetList<LeafInfoConstant> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174A9 RID: 95401 RVA: 0x00372E38 File Offset: 0x00371038
		public static YamlNode ExportYamlRelease_Array_LibraryRepresentation_2019_3_0_a8(this AssetList<LibraryRepresentation_2019_3_0_a8> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174AA RID: 95402 RVA: 0x00372E78 File Offset: 0x00371078
		public static YamlNode ExportYamlRelease_Array_LibraryRepresentation_3_4_0(this AssetList<LibraryRepresentation_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174AB RID: 95403 RVA: 0x00372EB8 File Offset: 0x003710B8
		public static YamlNode ExportYamlRelease_Array_LibraryRepresentation_3_5_0(this AssetList<LibraryRepresentation_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174AC RID: 95404 RVA: 0x00372EF8 File Offset: 0x003710F8
		public static YamlNode ExportYamlRelease_Array_LibraryRepresentation_4_0_0(this AssetList<LibraryRepresentation_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174AD RID: 95405 RVA: 0x00372F38 File Offset: 0x00371138
		public static YamlNode ExportYamlRelease_Array_LibraryRepresentation_5_0_0(this AssetList<LibraryRepresentation_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174AE RID: 95406 RVA: 0x00372F78 File Offset: 0x00371178
		public static YamlNode ExportYamlRelease_Array_LibraryRepresentation_5_1_0(this AssetList<LibraryRepresentation_5_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174AF RID: 95407 RVA: 0x00372FB8 File Offset: 0x003711B8
		public static YamlNode ExportYamlRelease_Array_LibraryRepresentation_5_5_0(this AssetList<LibraryRepresentation_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174B0 RID: 95408 RVA: 0x00372FF8 File Offset: 0x003711F8
		public static YamlNode ExportYamlRelease_Array_LightBakingOutput_2017_3_0(this AssetList<LightBakingOutput_2017_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174B1 RID: 95409 RVA: 0x00373038 File Offset: 0x00371238
		public static YamlNode ExportYamlRelease_Array_LightBakingOutput_5_6_0_b2(this AssetList<LightBakingOutput_5_6_0_b2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174B2 RID: 95410 RVA: 0x00373078 File Offset: 0x00371278
		public static YamlNode ExportYamlRelease_Array_LightBakingOutput_5_6_0_b5(this AssetList<LightBakingOutput_5_6_0_b5> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174B3 RID: 95411 RVA: 0x003730B8 File Offset: 0x003712B8
		public static YamlNode ExportYamlRelease_Array_LightmapData_3_4_0(this AssetList<LightmapData_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174B4 RID: 95412 RVA: 0x003730F8 File Offset: 0x003712F8
		public static YamlNode ExportYamlRelease_Array_LightmapData_5_0_0(this AssetList<LightmapData_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174B5 RID: 95413 RVA: 0x00373138 File Offset: 0x00371338
		public static YamlNode ExportYamlRelease_Array_LightmapData_5_6_0_b2(this AssetList<LightmapData_5_6_0_b2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174B6 RID: 95414 RVA: 0x00373178 File Offset: 0x00371378
		public static YamlNode ExportYamlRelease_Array_LightProbeOcclusion_5_4_0(this AssetList<LightProbeOcclusion_5_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174B7 RID: 95415 RVA: 0x003731B8 File Offset: 0x003713B8
		public static YamlNode ExportYamlRelease_Array_LightProbeOcclusion_5_6_0_b2(this AssetList<LightProbeOcclusion_5_6_0_b2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174B8 RID: 95416 RVA: 0x003731F8 File Offset: 0x003713F8
		public static YamlNode ExportYamlRelease_Array_LightProbeOcclusion_5_6_0_b5(this AssetList<LightProbeOcclusion_5_6_0_b5> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174B9 RID: 95417 RVA: 0x00373238 File Offset: 0x00371438
		public static YamlNode ExportYamlRelease_Array_LOD_2017_1_0(this AssetList<LOD_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174BA RID: 95418 RVA: 0x00373278 File Offset: 0x00371478
		public static YamlNode ExportYamlRelease_Array_LOD_3_5_0(this AssetList<LOD_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174BB RID: 95419 RVA: 0x003732B8 File Offset: 0x003714B8
		public static YamlNode ExportYamlRelease_Array_LOD_5_0_0(this AssetList<LOD_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174BC RID: 95420 RVA: 0x003732F8 File Offset: 0x003714F8
		public static YamlNode ExportYamlRelease_Array_LOD_5_1_0(this AssetList<LOD_5_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174BD RID: 95421 RVA: 0x00373338 File Offset: 0x00371538
		public static YamlNode ExportYamlRelease_Array_LODRenderer_3_5_0(this AssetList<LODRenderer_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174BE RID: 95422 RVA: 0x00373378 File Offset: 0x00371578
		public static YamlNode ExportYamlRelease_Array_LODRenderer_5_0_0(this AssetList<LODRenderer_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174BF RID: 95423 RVA: 0x003733B8 File Offset: 0x003715B8
		public static YamlNode ExportYamlRelease_Array_MaterialImportOutput_4_0_0(this AssetList<MaterialImportOutput_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174C0 RID: 95424 RVA: 0x003733F8 File Offset: 0x003715F8
		public static YamlNode ExportYamlRelease_Array_MaterialImportOutput_4_1_0(this AssetList<MaterialImportOutput_4_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174C1 RID: 95425 RVA: 0x00373438 File Offset: 0x00371638
		public static YamlNode ExportYamlRelease_Array_MaterialImportOutput_4_2_0(this AssetList<MaterialImportOutput_4_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174C2 RID: 95426 RVA: 0x00373478 File Offset: 0x00371678
		public static YamlNode ExportYamlRelease_Array_MaterialImportOutput_4_3_0(this AssetList<MaterialImportOutput_4_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174C3 RID: 95427 RVA: 0x003734B8 File Offset: 0x003716B8
		public static YamlNode ExportYamlRelease_Array_MaterialInstanceSettings_2017_1_0(this AssetList<MaterialInstanceSettings_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174C4 RID: 95428 RVA: 0x003734F8 File Offset: 0x003716F8
		public static YamlNode ExportYamlRelease_Array_MaterialInstanceSettings_2017_2_0_b4(this AssetList<MaterialInstanceSettings_2017_2_0_b4> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174C5 RID: 95429 RVA: 0x00373538 File Offset: 0x00371738
		public static YamlNode ExportYamlRelease_Array_MaterialInstanceSettings_3_4_0(this AssetList<MaterialInstanceSettings_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174C6 RID: 95430 RVA: 0x00373578 File Offset: 0x00371778
		public static YamlNode ExportYamlRelease_Array_MaterialInstanceSettings_3_5_0(this AssetList<MaterialInstanceSettings_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174C7 RID: 95431 RVA: 0x003735B8 File Offset: 0x003717B8
		public static YamlNode ExportYamlRelease_Array_MaterialInstanceSettings_4_0_0(this AssetList<MaterialInstanceSettings_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174C8 RID: 95432 RVA: 0x003735F8 File Offset: 0x003717F8
		public static YamlNode ExportYamlRelease_Array_MaterialInstanceSettings_4_1_0(this AssetList<MaterialInstanceSettings_4_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174C9 RID: 95433 RVA: 0x00373638 File Offset: 0x00371838
		public static YamlNode ExportYamlRelease_Array_MaterialInstanceSettings_4_2_0(this AssetList<MaterialInstanceSettings_4_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174CA RID: 95434 RVA: 0x00373678 File Offset: 0x00371878
		public static YamlNode ExportYamlRelease_Array_MaterialInstanceSettings_4_3_0(this AssetList<MaterialInstanceSettings_4_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174CB RID: 95435 RVA: 0x003736B8 File Offset: 0x003718B8
		public static YamlNode ExportYamlRelease_Array_MaterialInstanceSettings_4_5_0(this AssetList<MaterialInstanceSettings_4_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174CC RID: 95436 RVA: 0x003736F8 File Offset: 0x003718F8
		public static YamlNode ExportYamlRelease_Array_MaterialInstanceSettings_5_0_0(this AssetList<MaterialInstanceSettings_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174CD RID: 95437 RVA: 0x00373738 File Offset: 0x00371938
		public static YamlNode ExportYamlRelease_Array_MaterialInstanceSettings_5_0_2(this AssetList<MaterialInstanceSettings_5_0_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174CE RID: 95438 RVA: 0x00373778 File Offset: 0x00371978
		public static YamlNode ExportYamlRelease_Array_MaterialInstanceSettings_5_3_4(this AssetList<MaterialInstanceSettings_5_3_4> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174CF RID: 95439 RVA: 0x003737B8 File Offset: 0x003719B8
		public static YamlNode ExportYamlRelease_Array_MaterialInstanceSettings_5_6_0(this AssetList<MaterialInstanceSettings_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174D0 RID: 95440 RVA: 0x003737F8 File Offset: 0x003719F8
		public static YamlNode ExportYamlRelease_Array_Matrix4x4f(this AssetList<Matrix4x4f> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174D1 RID: 95441 RVA: 0x00373838 File Offset: 0x00371A38
		public static YamlNode ExportYamlRelease_Array_MatrixParameter(this AssetList<MatrixParameter> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174D2 RID: 95442 RVA: 0x00373878 File Offset: 0x00371A78
		public static YamlNode ExportYamlRelease_Array_MeshBlendShape_4_1_0(this AssetList<MeshBlendShape_4_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174D3 RID: 95443 RVA: 0x003738B8 File Offset: 0x00371AB8
		public static YamlNode ExportYamlRelease_Array_MeshBlendShape_4_3_0(this AssetList<MeshBlendShape_4_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174D4 RID: 95444 RVA: 0x003738F8 File Offset: 0x00371AF8
		public static YamlNode ExportYamlRelease_Array_MeshBlendShapeChannel(this AssetList<MeshBlendShapeChannel> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174D5 RID: 95445 RVA: 0x00373938 File Offset: 0x00371B38
		public static YamlNode ExportYamlRelease_Array_MeshBlendShapeVertex(this AssetList<MeshBlendShapeVertex> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174D6 RID: 95446 RVA: 0x00373978 File Offset: 0x00371B78
		public static YamlNode ExportYamlRelease_Array_MinMaxAABB(this AssetList<MinMaxAABB> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174D7 RID: 95447 RVA: 0x003739B8 File Offset: 0x00371BB8
		public static YamlNode ExportYamlRelease_Array_MipmapLimitSettings(this AssetList<MipmapLimitSettings> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174D8 RID: 95448 RVA: 0x003739F8 File Offset: 0x00371BF8
		public static YamlNode ExportYamlRelease_Array_Module_2018_1_0(this AssetList<Module_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174D9 RID: 95449 RVA: 0x00373A38 File Offset: 0x00371C38
		public static YamlNode ExportYamlRelease_Array_Module_2018_2_0_b4(this AssetList<Module_2018_2_0_b4> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174DA RID: 95450 RVA: 0x00373A78 File Offset: 0x00371C78
		public static YamlNode ExportYamlRelease_Array_MotionNeighborList(this AssetList<MotionNeighborList> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174DB RID: 95451 RVA: 0x00373AB8 File Offset: 0x00371CB8
		public static YamlNode ExportYamlRelease_Array_NavMeshAreaData(this AssetList<NavMeshAreaData> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174DC RID: 95452 RVA: 0x00373AF8 File Offset: 0x00371CF8
		public static YamlNode ExportYamlRelease_Array_NavMeshBuildSettings_2017_2_0(this AssetList<NavMeshBuildSettings_2017_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174DD RID: 95453 RVA: 0x00373B38 File Offset: 0x00371D38
		public static YamlNode ExportYamlRelease_Array_NavMeshBuildSettings_2020_1_0_a23(this AssetList<NavMeshBuildSettings_2020_1_0_a23> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174DE RID: 95454 RVA: 0x00373B78 File Offset: 0x00371D78
		public static YamlNode ExportYamlRelease_Array_NavMeshBuildSettings_2020_1_0_a24(this AssetList<NavMeshBuildSettings_2020_1_0_a24> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174DF RID: 95455 RVA: 0x00373BB8 File Offset: 0x00371DB8
		public static YamlNode ExportYamlRelease_Array_NavMeshBuildSettings_2022_2_0(this AssetList<NavMeshBuildSettings_2022_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174E0 RID: 95456 RVA: 0x00373BF8 File Offset: 0x00371DF8
		public static YamlNode ExportYamlRelease_Array_NavMeshBuildSettings_5_6_0(this AssetList<NavMeshBuildSettings_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174E1 RID: 95457 RVA: 0x00373C38 File Offset: 0x00371E38
		public static YamlNode ExportYamlRelease_Array_NavMeshBuildSettings_5_6_0_f2(this AssetList<NavMeshBuildSettings_5_6_0_f2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174E2 RID: 95458 RVA: 0x00373C78 File Offset: 0x00371E78
		public static YamlNode ExportYamlRelease_Array_NavMeshTileData_5_0_0(this AssetList<NavMeshTileData_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174E3 RID: 95459 RVA: 0x00373CB8 File Offset: 0x00371EB8
		public static YamlNode ExportYamlRelease_Array_NavMeshTileData_5_6_0(this AssetList<NavMeshTileData_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174E4 RID: 95460 RVA: 0x00373CF8 File Offset: 0x00371EF8
		public static YamlNode ExportYamlRelease_Array_Node(this AssetList<Node> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174E5 RID: 95461 RVA: 0x00373D38 File Offset: 0x00371F38
		public static YamlNode ExportYamlRelease_Array_OcclusionScene(this AssetList<OcclusionScene> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174E6 RID: 95462 RVA: 0x00373D78 File Offset: 0x00371F78
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_BlendTreeConstant_4_0_0(this AssetList<OffsetPtr_BlendTreeConstant_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174E7 RID: 95463 RVA: 0x00373DB8 File Offset: 0x00371FB8
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_BlendTreeConstant_4_1_0(this AssetList<OffsetPtr_BlendTreeConstant_4_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174E8 RID: 95464 RVA: 0x00373DF8 File Offset: 0x00371FF8
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_BlendTreeConstant_4_1_3(this AssetList<OffsetPtr_BlendTreeConstant_4_1_3> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174E9 RID: 95465 RVA: 0x00373E38 File Offset: 0x00372038
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_BlendTreeConstant_4_5_0(this AssetList<OffsetPtr_BlendTreeConstant_4_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174EA RID: 95466 RVA: 0x00373E78 File Offset: 0x00372078
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_BlendTreeConstant_4_5_2(this AssetList<OffsetPtr_BlendTreeConstant_4_5_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174EB RID: 95467 RVA: 0x00373EB8 File Offset: 0x003720B8
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_BlendTreeConstant_5_0_0(this AssetList<OffsetPtr_BlendTreeConstant_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174EC RID: 95468 RVA: 0x00373EF8 File Offset: 0x003720F8
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_BlendTreeNodeConstant_4_0_0(this AssetList<OffsetPtr_BlendTreeNodeConstant_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174ED RID: 95469 RVA: 0x00373F38 File Offset: 0x00372138
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_BlendTreeNodeConstant_4_1_0(this AssetList<OffsetPtr_BlendTreeNodeConstant_4_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174EE RID: 95470 RVA: 0x00373F78 File Offset: 0x00372178
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_BlendTreeNodeConstant_4_1_3(this AssetList<OffsetPtr_BlendTreeNodeConstant_4_1_3> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174EF RID: 95471 RVA: 0x00373FB8 File Offset: 0x003721B8
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_BlendTreeNodeConstant_4_5_2(this AssetList<OffsetPtr_BlendTreeNodeConstant_4_5_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174F0 RID: 95472 RVA: 0x00373FF8 File Offset: 0x003721F8
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_BlendTreeNodeConstant_5_0_0(this AssetList<OffsetPtr_BlendTreeNodeConstant_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174F1 RID: 95473 RVA: 0x00374038 File Offset: 0x00372238
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_ConditionConstant(this AssetList<OffsetPtr_ConditionConstant> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174F2 RID: 95474 RVA: 0x00374078 File Offset: 0x00372278
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_LayerConstant_2018_2_0(this AssetList<OffsetPtr_LayerConstant_2018_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174F3 RID: 95475 RVA: 0x003740B8 File Offset: 0x003722B8
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_LayerConstant_4_0_0(this AssetList<OffsetPtr_LayerConstant_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174F4 RID: 95476 RVA: 0x003740F8 File Offset: 0x003722F8
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_LayerConstant_4_2_0(this AssetList<OffsetPtr_LayerConstant_4_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174F5 RID: 95477 RVA: 0x00374138 File Offset: 0x00372338
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_LayerConstant_4_3_0(this AssetList<OffsetPtr_LayerConstant_4_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174F6 RID: 95478 RVA: 0x00374178 File Offset: 0x00372378
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_LayerConstant_5_2_0(this AssetList<OffsetPtr_LayerConstant_5_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174F7 RID: 95479 RVA: 0x003741B8 File Offset: 0x003723B8
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_SelectorStateConstant(this AssetList<OffsetPtr_SelectorStateConstant> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174F8 RID: 95480 RVA: 0x003741F8 File Offset: 0x003723F8
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_SelectorTransitionConstant(this AssetList<OffsetPtr_SelectorTransitionConstant> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174F9 RID: 95481 RVA: 0x00374238 File Offset: 0x00372438
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_StateConstant_2017_2_0(this AssetList<OffsetPtr_StateConstant_2017_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174FA RID: 95482 RVA: 0x00374278 File Offset: 0x00372478
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_StateConstant_4_0_0(this AssetList<OffsetPtr_StateConstant_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174FB RID: 95483 RVA: 0x003742B8 File Offset: 0x003724B8
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_StateConstant_4_1_0(this AssetList<OffsetPtr_StateConstant_4_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174FC RID: 95484 RVA: 0x003742F8 File Offset: 0x003724F8
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_StateConstant_4_1_3(this AssetList<OffsetPtr_StateConstant_4_1_3> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174FD RID: 95485 RVA: 0x00374338 File Offset: 0x00372538
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_StateConstant_4_3_0(this AssetList<OffsetPtr_StateConstant_4_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174FE RID: 95486 RVA: 0x00374378 File Offset: 0x00372578
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_StateConstant_4_5_0(this AssetList<OffsetPtr_StateConstant_4_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060174FF RID: 95487 RVA: 0x003743B8 File Offset: 0x003725B8
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_StateConstant_4_5_2(this AssetList<OffsetPtr_StateConstant_4_5_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017500 RID: 95488 RVA: 0x003743F8 File Offset: 0x003725F8
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_StateConstant_5_0_0(this AssetList<OffsetPtr_StateConstant_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017501 RID: 95489 RVA: 0x00374438 File Offset: 0x00372638
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_StateConstant_5_1_0(this AssetList<OffsetPtr_StateConstant_5_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017502 RID: 95490 RVA: 0x00374478 File Offset: 0x00372678
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_StateConstant_5_2_0(this AssetList<OffsetPtr_StateConstant_5_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017503 RID: 95491 RVA: 0x003744B8 File Offset: 0x003726B8
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_StateConstant_5_2_2(this AssetList<OffsetPtr_StateConstant_5_2_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017504 RID: 95492 RVA: 0x003744F8 File Offset: 0x003726F8
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_StateMachineConstant_2017_2_0(this AssetList<OffsetPtr_StateMachineConstant_2017_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017505 RID: 95493 RVA: 0x00374538 File Offset: 0x00372738
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_StateMachineConstant_2018_2_0(this AssetList<OffsetPtr_StateMachineConstant_2018_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017506 RID: 95494 RVA: 0x00374578 File Offset: 0x00372778
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_StateMachineConstant_4_0_0(this AssetList<OffsetPtr_StateMachineConstant_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017507 RID: 95495 RVA: 0x003745B8 File Offset: 0x003727B8
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_StateMachineConstant_4_1_0(this AssetList<OffsetPtr_StateMachineConstant_4_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017508 RID: 95496 RVA: 0x003745F8 File Offset: 0x003727F8
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_StateMachineConstant_4_1_3(this AssetList<OffsetPtr_StateMachineConstant_4_1_3> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017509 RID: 95497 RVA: 0x00374638 File Offset: 0x00372838
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_StateMachineConstant_4_3_0(this AssetList<OffsetPtr_StateMachineConstant_4_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601750A RID: 95498 RVA: 0x00374678 File Offset: 0x00372878
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_StateMachineConstant_4_5_0(this AssetList<OffsetPtr_StateMachineConstant_4_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601750B RID: 95499 RVA: 0x003746B8 File Offset: 0x003728B8
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_StateMachineConstant_4_5_2(this AssetList<OffsetPtr_StateMachineConstant_4_5_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601750C RID: 95500 RVA: 0x003746F8 File Offset: 0x003728F8
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_StateMachineConstant_5_0_0(this AssetList<OffsetPtr_StateMachineConstant_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601750D RID: 95501 RVA: 0x00374738 File Offset: 0x00372938
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_StateMachineConstant_5_1_0(this AssetList<OffsetPtr_StateMachineConstant_5_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601750E RID: 95502 RVA: 0x00374778 File Offset: 0x00372978
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_StateMachineConstant_5_2_0(this AssetList<OffsetPtr_StateMachineConstant_5_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601750F RID: 95503 RVA: 0x003747B8 File Offset: 0x003729B8
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_StateMachineConstant_5_2_2(this AssetList<OffsetPtr_StateMachineConstant_5_2_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017510 RID: 95504 RVA: 0x003747F8 File Offset: 0x003729F8
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_TransitionConstant_4_0_0(this AssetList<OffsetPtr_TransitionConstant_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017511 RID: 95505 RVA: 0x00374838 File Offset: 0x00372A38
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_TransitionConstant_4_5_0(this AssetList<OffsetPtr_TransitionConstant_4_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017512 RID: 95506 RVA: 0x00374878 File Offset: 0x00372A78
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_TransitionConstant_5_0_0(this AssetList<OffsetPtr_TransitionConstant_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017513 RID: 95507 RVA: 0x003748B8 File Offset: 0x00372AB8
		public static YamlNode ExportYamlRelease_Array_OffsetPtr_TransitionConstant_5_1_0(this AssetList<OffsetPtr_TransitionConstant_5_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017514 RID: 95508 RVA: 0x003748F8 File Offset: 0x00372AF8
		public static YamlNode ExportYamlRelease_Array_Pair_Int32_PPtr_Component_3_4_0(this AssetList<AssetPair<int, PPtr_Component_3_4_0>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease_Pair_Int32_PPtr_Component_3_4_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017515 RID: 95509 RVA: 0x00374938 File Offset: 0x00372B38
		public static YamlNode ExportYamlRelease_Array_Pair_Int32_PPtr_Component_5_0_0(this AssetList<AssetPair<int, PPtr_Component_5_0_0>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease_Pair_Int32_PPtr_Component_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017516 RID: 95510 RVA: 0x00374978 File Offset: 0x00372B78
		public static YamlNode ExportYamlRelease_Array_Pair_Int32_Single(this AssetList<AssetPair<int, float>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease_Pair_Int32_Single(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017517 RID: 95511 RVA: 0x003749B8 File Offset: 0x00372BB8
		public static YamlNode ExportYamlRelease_Array_Pair_Int32_UInt32(this AssetList<AssetPair<int, uint>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease_Pair_Int32_UInt32(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017518 RID: 95512 RVA: 0x003749F8 File Offset: 0x00372BF8
		public static YamlNode ExportYamlRelease_Array_Pair_Pair_Int32_Int64_Utf8String(this AssetList<AssetPair<AssetPair<int, long>, Utf8String>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease_Pair_Pair_Int32_Int64_Utf8String(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017519 RID: 95513 RVA: 0x00374A38 File Offset: 0x00372C38
		public static YamlNode ExportYamlRelease_Array_Pair_PPtr_SphereCollider_PPtr_SphereCollider(this AssetList<AssetPair<PPtr_SphereCollider, PPtr_SphereCollider>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease_Pair_PPtr_SphereCollider_PPtr_SphereCollider(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601751A RID: 95514 RVA: 0x00374A78 File Offset: 0x00372C78
		public static YamlNode ExportYamlRelease_Array_Pair_Utf8String_Boolean(this AssetList<AssetPair<Utf8String, bool>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease_Pair_Utf8String_Boolean(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601751B RID: 95515 RVA: 0x00374AB8 File Offset: 0x00372CB8
		public static YamlNode ExportYamlRelease_Array_Pair_Utf8String_PPtr_Object_3_4_0(this AssetList<AssetPair<Utf8String, PPtr_Object_3_4_0>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease_Pair_Utf8String_PPtr_Object_3_4_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601751C RID: 95516 RVA: 0x00374AF8 File Offset: 0x00372CF8
		public static YamlNode ExportYamlRelease_Array_Pair_Utf8String_PPtr_Object_5_0_0(this AssetList<AssetPair<Utf8String, PPtr_Object_5_0_0>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease_Pair_Utf8String_PPtr_Object_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601751D RID: 95517 RVA: 0x00374B38 File Offset: 0x00372D38
		public static YamlNode ExportYamlRelease_Array_Pair_Utf8String_PPtr_Texture_3_4_0(this AssetList<AssetPair<Utf8String, PPtr_Texture_3_4_0>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease_Pair_Utf8String_PPtr_Texture_3_4_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601751E RID: 95518 RVA: 0x00374B78 File Offset: 0x00372D78
		public static YamlNode ExportYamlRelease_Array_Pair_Utf8String_PPtr_Texture_5_0_0(this AssetList<AssetPair<Utf8String, PPtr_Texture_5_0_0>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease_Pair_Utf8String_PPtr_Texture_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601751F RID: 95519 RVA: 0x00374BB8 File Offset: 0x00372DB8
		public static YamlNode ExportYamlRelease_Array_Pair_Utf8String_UInt32(this AssetList<AssetPair<Utf8String, uint>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease_Pair_Utf8String_UInt32(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017520 RID: 95520 RVA: 0x00374BF8 File Offset: 0x00372DF8
		public static YamlNode ExportYamlRelease_Array_Parameter(this AssetList<Parameter> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017521 RID: 95521 RVA: 0x00374C38 File Offset: 0x00372E38
		public static YamlNode ExportYamlRelease_Array_ParticleSystemEmissionBurst_2017_2_0(this AssetList<ParticleSystemEmissionBurst_2017_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017522 RID: 95522 RVA: 0x00374C78 File Offset: 0x00372E78
		public static YamlNode ExportYamlRelease_Array_ParticleSystemEmissionBurst_2017_3_0(this AssetList<ParticleSystemEmissionBurst_2017_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017523 RID: 95523 RVA: 0x00374CB8 File Offset: 0x00372EB8
		public static YamlNode ExportYamlRelease_Array_ParticleSystemEmissionBurst_2018_1_0(this AssetList<ParticleSystemEmissionBurst_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017524 RID: 95524 RVA: 0x00374CF8 File Offset: 0x00372EF8
		public static YamlNode ExportYamlRelease_Array_ParticleSystemEmissionBurst_2018_3_0(this AssetList<ParticleSystemEmissionBurst_2018_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017525 RID: 95525 RVA: 0x00374D38 File Offset: 0x00372F38
		public static YamlNode ExportYamlRelease_Array_ParticleSystemEmissionBurst_5_6_0_b5(this AssetList<ParticleSystemEmissionBurst_5_6_0_b5> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017526 RID: 95526 RVA: 0x00374D78 File Offset: 0x00372F78
		public static YamlNode ExportYamlRelease_Array_PerLODSettings_2018_3_0(this AssetList<PerLODSettings_2018_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017527 RID: 95527 RVA: 0x00374DB8 File Offset: 0x00372FB8
		public static YamlNode ExportYamlRelease_Array_PerLODSettings_5_0_0(this AssetList<PerLODSettings_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017528 RID: 95528 RVA: 0x00374DF8 File Offset: 0x00372FF8
		public static YamlNode ExportYamlRelease_Array_PhysicsShape(this AssetList<PhysicsShape> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017529 RID: 95529 RVA: 0x00374E38 File Offset: 0x00373038
		public static YamlNode ExportYamlRelease_Array_PlatformShaderDefines(this AssetList<PlatformShaderDefines> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601752A RID: 95530 RVA: 0x00374E78 File Offset: 0x00373078
		public static YamlNode ExportYamlRelease_Array_PPtr_AnimationClip_3_4_0(this AssetList<PPtr_AnimationClip_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601752B RID: 95531 RVA: 0x00374EB8 File Offset: 0x003730B8
		public static YamlNode ExportYamlRelease_Array_PPtr_AnimationClip_5_0_0(this AssetList<PPtr_AnimationClip_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601752C RID: 95532 RVA: 0x00374EF8 File Offset: 0x003730F8
		public static YamlNode ExportYamlRelease_Array_PPtr_AnimatorStateTransition(this AssetList<PPtr_AnimatorStateTransition> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601752D RID: 95533 RVA: 0x00374F38 File Offset: 0x00373138
		public static YamlNode ExportYamlRelease_Array_PPtr_AnimatorTransition(this AssetList<PPtr_AnimatorTransition> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601752E RID: 95534 RVA: 0x00374F78 File Offset: 0x00373178
		public static YamlNode ExportYamlRelease_Array_PPtr_AudioMixerGroup(this AssetList<PPtr_AudioMixerGroup> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601752F RID: 95535 RVA: 0x00374FB8 File Offset: 0x003731B8
		public static YamlNode ExportYamlRelease_Array_PPtr_AudioMixerSnapshot(this AssetList<PPtr_AudioMixerSnapshot> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017530 RID: 95536 RVA: 0x00374FF8 File Offset: 0x003731F8
		public static YamlNode ExportYamlRelease_Array_PPtr_AudioSource(this AssetList<PPtr_AudioSource> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017531 RID: 95537 RVA: 0x00375038 File Offset: 0x00373238
		public static YamlNode ExportYamlRelease_Array_PPtr_CapsuleCollider(this AssetList<PPtr_CapsuleCollider> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017532 RID: 95538 RVA: 0x00375078 File Offset: 0x00373278
		public static YamlNode ExportYamlRelease_Array_PPtr_Component_5_0_0(this AssetList<PPtr_Component_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017533 RID: 95539 RVA: 0x003750B8 File Offset: 0x003732B8
		public static YamlNode ExportYamlRelease_Array_PPtr_EditorExtension_3_4_0(this AssetList<PPtr_EditorExtension_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017534 RID: 95540 RVA: 0x003750F8 File Offset: 0x003732F8
		public static YamlNode ExportYamlRelease_Array_PPtr_Font_3_4_0(this AssetList<PPtr_Font_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017535 RID: 95541 RVA: 0x00375138 File Offset: 0x00373338
		public static YamlNode ExportYamlRelease_Array_PPtr_Font_5_0_0(this AssetList<PPtr_Font_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017536 RID: 95542 RVA: 0x00375178 File Offset: 0x00373378
		public static YamlNode ExportYamlRelease_Array_PPtr_GameObject_3_4_0(this AssetList<PPtr_GameObject_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017537 RID: 95543 RVA: 0x003751B8 File Offset: 0x003733B8
		public static YamlNode ExportYamlRelease_Array_PPtr_GameObject_5_0_0(this AssetList<PPtr_GameObject_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017538 RID: 95544 RVA: 0x003751F8 File Offset: 0x003733F8
		public static YamlNode ExportYamlRelease_Array_PPtr_Material_3_4_0(this AssetList<PPtr_Material_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017539 RID: 95545 RVA: 0x00375238 File Offset: 0x00373438
		public static YamlNode ExportYamlRelease_Array_PPtr_Material_5_0_0(this AssetList<PPtr_Material_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601753A RID: 95546 RVA: 0x00375278 File Offset: 0x00373478
		public static YamlNode ExportYamlRelease_Array_PPtr_MonoBehaviour_5_0_0(this AssetList<PPtr_MonoBehaviour_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601753B RID: 95547 RVA: 0x003752B8 File Offset: 0x003734B8
		public static YamlNode ExportYamlRelease_Array_PPtr_MonoScript_3_4_0(this AssetList<PPtr_MonoScript_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601753C RID: 95548 RVA: 0x003752F8 File Offset: 0x003734F8
		public static YamlNode ExportYamlRelease_Array_PPtr_MonoScript_5_0_0(this AssetList<PPtr_MonoScript_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601753D RID: 95549 RVA: 0x00375338 File Offset: 0x00373538
		public static YamlNode ExportYamlRelease_Array_PPtr_Motion_4_0_0(this AssetList<PPtr_Motion_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601753E RID: 95550 RVA: 0x00375378 File Offset: 0x00373578
		public static YamlNode ExportYamlRelease_Array_PPtr_Object_3_4_0(this AssetList<PPtr_Object_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601753F RID: 95551 RVA: 0x003753B8 File Offset: 0x003735B8
		public static YamlNode ExportYamlRelease_Array_PPtr_Object_5_0_0(this AssetList<PPtr_Object_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017540 RID: 95552 RVA: 0x003753F8 File Offset: 0x003735F8
		public static YamlNode ExportYamlRelease_Array_PPtr_OcclusionPortal_3_5_0(this AssetList<PPtr_OcclusionPortal_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017541 RID: 95553 RVA: 0x00375438 File Offset: 0x00373638
		public static YamlNode ExportYamlRelease_Array_PPtr_OcclusionPortal_5_0_0(this AssetList<PPtr_OcclusionPortal_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017542 RID: 95554 RVA: 0x00375478 File Offset: 0x00373678
		public static YamlNode ExportYamlRelease_Array_PPtr_OcclusionPortal_5_5_0(this AssetList<PPtr_OcclusionPortal_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017543 RID: 95555 RVA: 0x003754B8 File Offset: 0x003736B8
		public static YamlNode ExportYamlRelease_Array_PPtr_ParticleSystemForceField(this AssetList<PPtr_ParticleSystemForceField> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017544 RID: 95556 RVA: 0x003754F8 File Offset: 0x003736F8
		public static YamlNode ExportYamlRelease_Array_PPtr_ProceduralTexture_3_4_0(this AssetList<PPtr_ProceduralTexture_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017545 RID: 95557 RVA: 0x00375538 File Offset: 0x00373738
		public static YamlNode ExportYamlRelease_Array_PPtr_ProceduralTexture_5_0_0(this AssetList<PPtr_ProceduralTexture_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017546 RID: 95558 RVA: 0x00375578 File Offset: 0x00373778
		public static YamlNode ExportYamlRelease_Array_PPtr_Renderer_3_4_0(this AssetList<PPtr_Renderer_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017547 RID: 95559 RVA: 0x003755B8 File Offset: 0x003737B8
		public static YamlNode ExportYamlRelease_Array_PPtr_Renderer_5_0_0(this AssetList<PPtr_Renderer_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017548 RID: 95560 RVA: 0x003755F8 File Offset: 0x003737F8
		public static YamlNode ExportYamlRelease_Array_PPtr_Shader_3_4_0(this AssetList<PPtr_Shader_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017549 RID: 95561 RVA: 0x00375638 File Offset: 0x00373838
		public static YamlNode ExportYamlRelease_Array_PPtr_Shader_5_0_0(this AssetList<PPtr_Shader_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601754A RID: 95562 RVA: 0x00375678 File Offset: 0x00373878
		public static YamlNode ExportYamlRelease_Array_PPtr_ShaderVariantCollection(this AssetList<PPtr_ShaderVariantCollection> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601754B RID: 95563 RVA: 0x003756B8 File Offset: 0x003738B8
		public static YamlNode ExportYamlRelease_Array_PPtr_Sprite_5_0_0(this AssetList<PPtr_Sprite_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601754C RID: 95564 RVA: 0x003756F8 File Offset: 0x003738F8
		public static YamlNode ExportYamlRelease_Array_PPtr_State(this AssetList<PPtr_State> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601754D RID: 95565 RVA: 0x00375738 File Offset: 0x00373938
		public static YamlNode ExportYamlRelease_Array_PPtr_StateMachine(this AssetList<PPtr_StateMachine> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601754E RID: 95566 RVA: 0x00375778 File Offset: 0x00373978
		public static YamlNode ExportYamlRelease_Array_PPtr_TerrainLayer(this AssetList<PPtr_TerrainLayer> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601754F RID: 95567 RVA: 0x003757B8 File Offset: 0x003739B8
		public static YamlNode ExportYamlRelease_Array_PPtr_Texture_5_0_0(this AssetList<PPtr_Texture_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017550 RID: 95568 RVA: 0x003757F8 File Offset: 0x003739F8
		public static YamlNode ExportYamlRelease_Array_PPtr_Texture2D_3_4_0(this AssetList<PPtr_Texture2D_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017551 RID: 95569 RVA: 0x00375838 File Offset: 0x00373A38
		public static YamlNode ExportYamlRelease_Array_PPtr_Texture2D_5_0_0(this AssetList<PPtr_Texture2D_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017552 RID: 95570 RVA: 0x00375878 File Offset: 0x00373A78
		public static YamlNode ExportYamlRelease_Array_PPtr_Transform_3_4_0(this AssetList<PPtr_Transform_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017553 RID: 95571 RVA: 0x003758B8 File Offset: 0x00373AB8
		public static YamlNode ExportYamlRelease_Array_PPtr_Transform_5_0_0(this AssetList<PPtr_Transform_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017554 RID: 95572 RVA: 0x003758F8 File Offset: 0x00373AF8
		public static YamlNode ExportYamlRelease_Array_PPtr_Transition(this AssetList<PPtr_Transition> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017555 RID: 95573 RVA: 0x00375938 File Offset: 0x00373B38
		public static YamlNode ExportYamlRelease_Array_PPtrCurve_2017_1_0(this AssetList<PPtrCurve_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017556 RID: 95574 RVA: 0x00375978 File Offset: 0x00373B78
		public static YamlNode ExportYamlRelease_Array_PPtrCurve_2022_2_0(this AssetList<PPtrCurve_2022_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017557 RID: 95575 RVA: 0x003759B8 File Offset: 0x00373BB8
		public static YamlNode ExportYamlRelease_Array_PPtrCurve_4_3_0(this AssetList<PPtrCurve_4_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017558 RID: 95576 RVA: 0x003759F8 File Offset: 0x00373BF8
		public static YamlNode ExportYamlRelease_Array_PPtrCurve_5_0_0(this AssetList<PPtrCurve_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017559 RID: 95577 RVA: 0x00375A38 File Offset: 0x00373C38
		public static YamlNode ExportYamlRelease_Array_PPtrCurve_5_6_0(this AssetList<PPtrCurve_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601755A RID: 95578 RVA: 0x00375A78 File Offset: 0x00373C78
		public static YamlNode ExportYamlRelease_Array_PPtrKeyframe_4_3_0(this AssetList<PPtrKeyframe_4_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601755B RID: 95579 RVA: 0x00375AB8 File Offset: 0x00373CB8
		public static YamlNode ExportYamlRelease_Array_PPtrKeyframe_5_0_0(this AssetList<PPtrKeyframe_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601755C RID: 95580 RVA: 0x00375AF8 File Offset: 0x00373CF8
		public static YamlNode ExportYamlRelease_Array_ProbeSetIndex(this AssetList<ProbeSetIndex> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601755D RID: 95581 RVA: 0x00375B38 File Offset: 0x00373D38
		public static YamlNode ExportYamlRelease_Array_ProceduralTextureAssignment_4_5_0(this AssetList<ProceduralTextureAssignment_4_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601755E RID: 95582 RVA: 0x00375B78 File Offset: 0x00373D78
		public static YamlNode ExportYamlRelease_Array_ProceduralTextureAssignment_5_0_0(this AssetList<ProceduralTextureAssignment_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601755F RID: 95583 RVA: 0x00375BB8 File Offset: 0x00373DB8
		public static YamlNode ExportYamlRelease_Array_ProceduralTextureAssignment_5_6_0(this AssetList<ProceduralTextureAssignment_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017560 RID: 95584 RVA: 0x00375BF8 File Offset: 0x00373DF8
		public static YamlNode ExportYamlRelease_Array_PropertyModification_3_5_0(this AssetList<PropertyModification_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017561 RID: 95585 RVA: 0x00375C38 File Offset: 0x00373E38
		public static YamlNode ExportYamlRelease_Array_PropertyModification_5_0_0(this AssetList<PropertyModification_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017562 RID: 95586 RVA: 0x00375C78 File Offset: 0x00373E78
		public static YamlNode ExportYamlRelease_Array_PropertyModificationsTargetTestNativeObject(this AssetList<PropertyModificationsTargetTestNativeObject> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017563 RID: 95587 RVA: 0x00375CB8 File Offset: 0x00373EB8
		public static YamlNode ExportYamlRelease_Array_QualitySetting_2017_1_0(this AssetList<QualitySetting_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017564 RID: 95588 RVA: 0x00375CF8 File Offset: 0x00373EF8
		public static YamlNode ExportYamlRelease_Array_QualitySetting_2018_2_0(this AssetList<QualitySetting_2018_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017565 RID: 95589 RVA: 0x00375D38 File Offset: 0x00373F38
		public static YamlNode ExportYamlRelease_Array_QualitySetting_2018_3_0(this AssetList<QualitySetting_2018_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017566 RID: 95590 RVA: 0x00375D78 File Offset: 0x00373F78
		public static YamlNode ExportYamlRelease_Array_QualitySetting_2019_1_0(this AssetList<QualitySetting_2019_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017567 RID: 95591 RVA: 0x00375DB8 File Offset: 0x00373FB8
		public static YamlNode ExportYamlRelease_Array_QualitySetting_2019_3_0_a6(this AssetList<QualitySetting_2019_3_0_a6> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017568 RID: 95592 RVA: 0x00375DF8 File Offset: 0x00373FF8
		public static YamlNode ExportYamlRelease_Array_QualitySetting_2022_2_0(this AssetList<QualitySetting_2022_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017569 RID: 95593 RVA: 0x00375E38 File Offset: 0x00374038
		public static YamlNode ExportYamlRelease_Array_QualitySetting_2022_2_0_a16(this AssetList<QualitySetting_2022_2_0_a16> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601756A RID: 95594 RVA: 0x00375E78 File Offset: 0x00374078
		public static YamlNode ExportYamlRelease_Array_QualitySetting_2022_2_0_a18(this AssetList<QualitySetting_2022_2_0_a18> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601756B RID: 95595 RVA: 0x00375EB8 File Offset: 0x003740B8
		public static YamlNode ExportYamlRelease_Array_QualitySetting_2022_2_0_b3(this AssetList<QualitySetting_2022_2_0_b3> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601756C RID: 95596 RVA: 0x00375EF8 File Offset: 0x003740F8
		public static YamlNode ExportYamlRelease_Array_QualitySetting_3_5_0(this AssetList<QualitySetting_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601756D RID: 95597 RVA: 0x00375F38 File Offset: 0x00374138
		public static YamlNode ExportYamlRelease_Array_QualitySetting_4_0_0(this AssetList<QualitySetting_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601756E RID: 95598 RVA: 0x00375F78 File Offset: 0x00374178
		public static YamlNode ExportYamlRelease_Array_QualitySetting_5_0_0(this AssetList<QualitySetting_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601756F RID: 95599 RVA: 0x00375FB8 File Offset: 0x003741B8
		public static YamlNode ExportYamlRelease_Array_QualitySetting_5_2_0(this AssetList<QualitySetting_5_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017570 RID: 95600 RVA: 0x00375FF8 File Offset: 0x003741F8
		public static YamlNode ExportYamlRelease_Array_QualitySetting_5_3_0(this AssetList<QualitySetting_5_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017571 RID: 95601 RVA: 0x00376038 File Offset: 0x00374238
		public static YamlNode ExportYamlRelease_Array_QuaternionCurve_2017_1_0(this AssetList<QuaternionCurve_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017572 RID: 95602 RVA: 0x00376078 File Offset: 0x00374278
		public static YamlNode ExportYamlRelease_Array_QuaternionCurve_2018_1_0(this AssetList<QuaternionCurve_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017573 RID: 95603 RVA: 0x003760B8 File Offset: 0x003742B8
		public static YamlNode ExportYamlRelease_Array_QuaternionCurve_3_4_0(this AssetList<QuaternionCurve_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017574 RID: 95604 RVA: 0x003760F8 File Offset: 0x003742F8
		public static YamlNode ExportYamlRelease_Array_QuaternionCurve_3_5_0(this AssetList<QuaternionCurve_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017575 RID: 95605 RVA: 0x00376138 File Offset: 0x00374338
		public static YamlNode ExportYamlRelease_Array_QuaternionCurve_5_3_0(this AssetList<QuaternionCurve_5_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017576 RID: 95606 RVA: 0x00376178 File Offset: 0x00374378
		public static YamlNode ExportYamlRelease_Array_QuaternionCurve_5_5_0(this AssetList<QuaternionCurve_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017577 RID: 95607 RVA: 0x003761B8 File Offset: 0x003743B8
		public static YamlNode ExportYamlRelease_Array_RayTracingShaderBuiltinSampler(this AssetList<RayTracingShaderBuiltinSampler> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017578 RID: 95608 RVA: 0x003761F8 File Offset: 0x003743F8
		public static YamlNode ExportYamlRelease_Array_RayTracingShaderConstantBuffer_2019_3_0_a10(this AssetList<RayTracingShaderConstantBuffer_2019_3_0_a10> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017579 RID: 95609 RVA: 0x00376238 File Offset: 0x00374438
		public static YamlNode ExportYamlRelease_Array_RayTracingShaderConstantBuffer_2020_1_0_a17(this AssetList<RayTracingShaderConstantBuffer_2020_1_0_a17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601757A RID: 95610 RVA: 0x00376278 File Offset: 0x00374478
		public static YamlNode ExportYamlRelease_Array_RayTracingShaderConstantBuffer_2020_1_0_b10(this AssetList<RayTracingShaderConstantBuffer_2020_1_0_b10> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601757B RID: 95611 RVA: 0x003762B8 File Offset: 0x003744B8
		public static YamlNode ExportYamlRelease_Array_RayTracingShaderConstantBuffer_2021_1_0_a4(this AssetList<RayTracingShaderConstantBuffer_2021_1_0_a4> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601757C RID: 95612 RVA: 0x003762F8 File Offset: 0x003744F8
		public static YamlNode ExportYamlRelease_Array_RayTracingShaderFunctionDesc(this AssetList<RayTracingShaderFunctionDesc> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601757D RID: 95613 RVA: 0x00376338 File Offset: 0x00374538
		public static YamlNode ExportYamlRelease_Array_RayTracingShaderParam_2019_3_0_a10(this AssetList<RayTracingShaderParam_2019_3_0_a10> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601757E RID: 95614 RVA: 0x00376378 File Offset: 0x00374578
		public static YamlNode ExportYamlRelease_Array_RayTracingShaderParam_2020_1_0_a17(this AssetList<RayTracingShaderParam_2020_1_0_a17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601757F RID: 95615 RVA: 0x003763B8 File Offset: 0x003745B8
		public static YamlNode ExportYamlRelease_Array_RayTracingShaderParam_2021_1_0_a4(this AssetList<RayTracingShaderParam_2021_1_0_a4> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017580 RID: 95616 RVA: 0x003763F8 File Offset: 0x003745F8
		public static YamlNode ExportYamlRelease_Array_RayTracingShaderResource_2019_3_0_a10(this AssetList<RayTracingShaderResource_2019_3_0_a10> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017581 RID: 95617 RVA: 0x00376438 File Offset: 0x00374638
		public static YamlNode ExportYamlRelease_Array_RayTracingShaderResource_2020_1_0_a17(this AssetList<RayTracingShaderResource_2020_1_0_a17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017582 RID: 95618 RVA: 0x00376478 File Offset: 0x00374678
		public static YamlNode ExportYamlRelease_Array_RayTracingShaderResource_2020_1_0_b10(this AssetList<RayTracingShaderResource_2020_1_0_b10> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017583 RID: 95619 RVA: 0x003764B8 File Offset: 0x003746B8
		public static YamlNode ExportYamlRelease_Array_RayTracingShaderVariant_2019_3_0_a10(this AssetList<RayTracingShaderVariant_2019_3_0_a10> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017584 RID: 95620 RVA: 0x003764F8 File Offset: 0x003746F8
		public static YamlNode ExportYamlRelease_Array_RayTracingShaderVariant_2020_1_0_a17(this AssetList<RayTracingShaderVariant_2020_1_0_a17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017585 RID: 95621 RVA: 0x00376538 File Offset: 0x00374738
		public static YamlNode ExportYamlRelease_Array_RayTracingShaderVariant_2020_1_0_b10(this AssetList<RayTracingShaderVariant_2020_1_0_b10> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017586 RID: 95622 RVA: 0x00376578 File Offset: 0x00374778
		public static YamlNode ExportYamlRelease_Array_RayTracingShaderVariant_2021_1_0_a4(this AssetList<RayTracingShaderVariant_2021_1_0_a4> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017587 RID: 95623 RVA: 0x003765B8 File Offset: 0x003747B8
		public static YamlNode ExportYamlRelease_Array_RayTracingShaderVariant_2022_2_0(this AssetList<RayTracingShaderVariant_2022_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017588 RID: 95624 RVA: 0x003765F8 File Offset: 0x003747F8
		public static YamlNode ExportYamlRelease_Array_RendererData_2018_2_0(this AssetList<RendererData_2018_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017589 RID: 95625 RVA: 0x00376638 File Offset: 0x00374838
		public static YamlNode ExportYamlRelease_Array_RendererData_5_0_0(this AssetList<RendererData_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601758A RID: 95626 RVA: 0x00376678 File Offset: 0x00374878
		public static YamlNode ExportYamlRelease_Array_ResourceManager_Dependency_2017_1_0(this AssetList<ResourceManager_Dependency_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601758B RID: 95627 RVA: 0x003766B8 File Offset: 0x003748B8
		public static YamlNode ExportYamlRelease_Array_ResourceManager_Dependency_3_5_0(this AssetList<ResourceManager_Dependency_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601758C RID: 95628 RVA: 0x003766F8 File Offset: 0x003748F8
		public static YamlNode ExportYamlRelease_Array_ResourceManager_Dependency_5_0_0(this AssetList<ResourceManager_Dependency_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601758D RID: 95629 RVA: 0x00376738 File Offset: 0x00374938
		public static YamlNode ExportYamlRelease_Array_SamplerParameter(this AssetList<SamplerParameter> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601758E RID: 95630 RVA: 0x00376778 File Offset: 0x00374978
		public static YamlNode ExportYamlRelease_Array_SByte(this sbyte[] value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int num = value.Length;
			for (int i = 0; i < num; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease_SByte(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601758F RID: 95631 RVA: 0x003767B0 File Offset: 0x003749B0
		public static YamlNode ExportYamlRelease_Array_Scene_3_4_0(this AssetList<Scene_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017590 RID: 95632 RVA: 0x003767F0 File Offset: 0x003749F0
		public static YamlNode ExportYamlRelease_Array_Scene_5_6_0_b10(this AssetList<Scene_5_6_0_b10> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017591 RID: 95633 RVA: 0x00376830 File Offset: 0x00374A30
		public static YamlNode ExportYamlRelease_Array_SceneObjectIdentifier(this AssetList<SceneObjectIdentifier> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017592 RID: 95634 RVA: 0x00376870 File Offset: 0x00374A70
		public static YamlNode ExportYamlRelease_Array_SecondarySpriteTexture(this AssetList<SecondarySpriteTexture> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017593 RID: 95635 RVA: 0x003768B0 File Offset: 0x00374AB0
		public static YamlNode ExportYamlRelease_Array_SerializedCustomEditorForRenderPipeline(this AssetList<SerializedCustomEditorForRenderPipeline> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017594 RID: 95636 RVA: 0x003768F0 File Offset: 0x00374AF0
		public static YamlNode ExportYamlRelease_Array_SerializedPass_2017_1_0(this AssetList<SerializedPass_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017595 RID: 95637 RVA: 0x00376930 File Offset: 0x00374B30
		public static YamlNode ExportYamlRelease_Array_SerializedPass_2017_2_0(this AssetList<SerializedPass_2017_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017596 RID: 95638 RVA: 0x00376970 File Offset: 0x00374B70
		public static YamlNode ExportYamlRelease_Array_SerializedPass_2017_3_0(this AssetList<SerializedPass_2017_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017597 RID: 95639 RVA: 0x003769B0 File Offset: 0x00374BB0
		public static YamlNode ExportYamlRelease_Array_SerializedPass_2018_1_0(this AssetList<SerializedPass_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017598 RID: 95640 RVA: 0x003769F0 File Offset: 0x00374BF0
		public static YamlNode ExportYamlRelease_Array_SerializedPass_2019_1_0(this AssetList<SerializedPass_2019_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017599 RID: 95641 RVA: 0x00376A30 File Offset: 0x00374C30
		public static YamlNode ExportYamlRelease_Array_SerializedPass_2019_3_0_a7(this AssetList<SerializedPass_2019_3_0_a7> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601759A RID: 95642 RVA: 0x00376A70 File Offset: 0x00374C70
		public static YamlNode ExportYamlRelease_Array_SerializedPass_2020_1_0_a17(this AssetList<SerializedPass_2020_1_0_a17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601759B RID: 95643 RVA: 0x00376AB0 File Offset: 0x00374CB0
		public static YamlNode ExportYamlRelease_Array_SerializedPass_2020_2_0_a15(this AssetList<SerializedPass_2020_2_0_a15> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601759C RID: 95644 RVA: 0x00376AF0 File Offset: 0x00374CF0
		public static YamlNode ExportYamlRelease_Array_SerializedPass_2020_3_16(this AssetList<SerializedPass_2020_3_16> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601759D RID: 95645 RVA: 0x00376B30 File Offset: 0x00374D30
		public static YamlNode ExportYamlRelease_Array_SerializedPass_2020_3_2(this AssetList<SerializedPass_2020_3_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601759E RID: 95646 RVA: 0x00376B70 File Offset: 0x00374D70
		public static YamlNode ExportYamlRelease_Array_SerializedPass_2021_1_0(this AssetList<SerializedPass_2021_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601759F RID: 95647 RVA: 0x00376BB0 File Offset: 0x00374DB0
		public static YamlNode ExportYamlRelease_Array_SerializedPass_2021_1_1(this AssetList<SerializedPass_2021_1_1> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175A0 RID: 95648 RVA: 0x00376BF0 File Offset: 0x00374DF0
		public static YamlNode ExportYamlRelease_Array_SerializedPass_2021_1_17(this AssetList<SerializedPass_2021_1_17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175A1 RID: 95649 RVA: 0x00376C30 File Offset: 0x00374E30
		public static YamlNode ExportYamlRelease_Array_SerializedPass_2021_2_0(this AssetList<SerializedPass_2021_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175A2 RID: 95650 RVA: 0x00376C70 File Offset: 0x00374E70
		public static YamlNode ExportYamlRelease_Array_SerializedPass_2021_2_0_a16(this AssetList<SerializedPass_2021_2_0_a16> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175A3 RID: 95651 RVA: 0x00376CB0 File Offset: 0x00374EB0
		public static YamlNode ExportYamlRelease_Array_SerializedPass_2021_2_0_a17(this AssetList<SerializedPass_2021_2_0_a17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175A4 RID: 95652 RVA: 0x00376CF0 File Offset: 0x00374EF0
		public static YamlNode ExportYamlRelease_Array_SerializedPass_2021_3_10(this AssetList<SerializedPass_2021_3_10> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175A5 RID: 95653 RVA: 0x00376D30 File Offset: 0x00374F30
		public static YamlNode ExportYamlRelease_Array_SerializedPass_2022_1_0(this AssetList<SerializedPass_2022_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175A6 RID: 95654 RVA: 0x00376D70 File Offset: 0x00374F70
		public static YamlNode ExportYamlRelease_Array_SerializedPass_2022_1_0_b3(this AssetList<SerializedPass_2022_1_0_b3> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175A7 RID: 95655 RVA: 0x00376DB0 File Offset: 0x00374FB0
		public static YamlNode ExportYamlRelease_Array_SerializedPass_2022_1_13(this AssetList<SerializedPass_2022_1_13> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175A8 RID: 95656 RVA: 0x00376DF0 File Offset: 0x00374FF0
		public static YamlNode ExportYamlRelease_Array_SerializedPass_2022_2_0(this AssetList<SerializedPass_2022_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175A9 RID: 95657 RVA: 0x00376E30 File Offset: 0x00375030
		public static YamlNode ExportYamlRelease_Array_SerializedPass_2022_2_0_b5(this AssetList<SerializedPass_2022_2_0_b5> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175AA RID: 95658 RVA: 0x00376E70 File Offset: 0x00375070
		public static YamlNode ExportYamlRelease_Array_SerializedPass_5_5_0(this AssetList<SerializedPass_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175AB RID: 95659 RVA: 0x00376EB0 File Offset: 0x003750B0
		public static YamlNode ExportYamlRelease_Array_SerializedPass_5_6_0(this AssetList<SerializedPass_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175AC RID: 95660 RVA: 0x00376EF0 File Offset: 0x003750F0
		public static YamlNode ExportYamlRelease_Array_SerializedPlayerSubProgram_2021_3_10(this AssetList<SerializedPlayerSubProgram_2021_3_10> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175AD RID: 95661 RVA: 0x00376F30 File Offset: 0x00375130
		public static YamlNode ExportYamlRelease_Array_SerializedPlayerSubProgram_2022_1_13(this AssetList<SerializedPlayerSubProgram_2022_1_13> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175AE RID: 95662 RVA: 0x00376F70 File Offset: 0x00375170
		public static YamlNode ExportYamlRelease_Array_SerializedPlayerSubProgram_2022_2_0_b5(this AssetList<SerializedPlayerSubProgram_2022_2_0_b5> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175AF RID: 95663 RVA: 0x00376FB0 File Offset: 0x003751B0
		public static YamlNode ExportYamlRelease_Array_SerializedProperty_2017_1_0(this AssetList<SerializedProperty_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175B0 RID: 95664 RVA: 0x00376FF0 File Offset: 0x003751F0
		public static YamlNode ExportYamlRelease_Array_SerializedProperty_5_5_0(this AssetList<SerializedProperty_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175B1 RID: 95665 RVA: 0x00377030 File Offset: 0x00375230
		public static YamlNode ExportYamlRelease_Array_SerializedShaderDependency(this AssetList<SerializedShaderDependency> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175B2 RID: 95666 RVA: 0x00377070 File Offset: 0x00375270
		public static YamlNode ExportYamlRelease_Array_SerializedSubProgram_2017_1_0(this AssetList<SerializedSubProgram_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175B3 RID: 95667 RVA: 0x003770B0 File Offset: 0x003752B0
		public static YamlNode ExportYamlRelease_Array_SerializedSubProgram_2017_2_0(this AssetList<SerializedSubProgram_2017_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175B4 RID: 95668 RVA: 0x003770F0 File Offset: 0x003752F0
		public static YamlNode ExportYamlRelease_Array_SerializedSubProgram_2017_3_0(this AssetList<SerializedSubProgram_2017_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175B5 RID: 95669 RVA: 0x00377130 File Offset: 0x00375330
		public static YamlNode ExportYamlRelease_Array_SerializedSubProgram_2019_1_0(this AssetList<SerializedSubProgram_2019_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175B6 RID: 95670 RVA: 0x00377170 File Offset: 0x00375370
		public static YamlNode ExportYamlRelease_Array_SerializedSubProgram_2020_1_0_a17(this AssetList<SerializedSubProgram_2020_1_0_a17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175B7 RID: 95671 RVA: 0x003771B0 File Offset: 0x003753B0
		public static YamlNode ExportYamlRelease_Array_SerializedSubProgram_2020_3_2(this AssetList<SerializedSubProgram_2020_3_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175B8 RID: 95672 RVA: 0x003771F0 File Offset: 0x003753F0
		public static YamlNode ExportYamlRelease_Array_SerializedSubProgram_2021_1_0(this AssetList<SerializedSubProgram_2021_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175B9 RID: 95673 RVA: 0x00377230 File Offset: 0x00375430
		public static YamlNode ExportYamlRelease_Array_SerializedSubProgram_2021_1_1(this AssetList<SerializedSubProgram_2021_1_1> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175BA RID: 95674 RVA: 0x00377270 File Offset: 0x00375470
		public static YamlNode ExportYamlRelease_Array_SerializedSubProgram_2021_2_0_a16(this AssetList<SerializedSubProgram_2021_2_0_a16> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175BB RID: 95675 RVA: 0x003772B0 File Offset: 0x003754B0
		public static YamlNode ExportYamlRelease_Array_SerializedSubProgram_5_5_0(this AssetList<SerializedSubProgram_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175BC RID: 95676 RVA: 0x003772F0 File Offset: 0x003754F0
		public static YamlNode ExportYamlRelease_Array_SerializedSubProgram_5_6_0(this AssetList<SerializedSubProgram_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175BD RID: 95677 RVA: 0x00377330 File Offset: 0x00375530
		public static YamlNode ExportYamlRelease_Array_SerializedSubShader_2017_1_0(this AssetList<SerializedSubShader_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175BE RID: 95678 RVA: 0x00377370 File Offset: 0x00375570
		public static YamlNode ExportYamlRelease_Array_SerializedSubShader_2017_2_0(this AssetList<SerializedSubShader_2017_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175BF RID: 95679 RVA: 0x003773B0 File Offset: 0x003755B0
		public static YamlNode ExportYamlRelease_Array_SerializedSubShader_2017_3_0(this AssetList<SerializedSubShader_2017_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175C0 RID: 95680 RVA: 0x003773F0 File Offset: 0x003755F0
		public static YamlNode ExportYamlRelease_Array_SerializedSubShader_2018_1_0(this AssetList<SerializedSubShader_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175C1 RID: 95681 RVA: 0x00377430 File Offset: 0x00375630
		public static YamlNode ExportYamlRelease_Array_SerializedSubShader_2019_1_0(this AssetList<SerializedSubShader_2019_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175C2 RID: 95682 RVA: 0x00377470 File Offset: 0x00375670
		public static YamlNode ExportYamlRelease_Array_SerializedSubShader_2019_3_0_a7(this AssetList<SerializedSubShader_2019_3_0_a7> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175C3 RID: 95683 RVA: 0x003774B0 File Offset: 0x003756B0
		public static YamlNode ExportYamlRelease_Array_SerializedSubShader_2020_1_0_a17(this AssetList<SerializedSubShader_2020_1_0_a17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175C4 RID: 95684 RVA: 0x003774F0 File Offset: 0x003756F0
		public static YamlNode ExportYamlRelease_Array_SerializedSubShader_2020_2_0_a15(this AssetList<SerializedSubShader_2020_2_0_a15> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175C5 RID: 95685 RVA: 0x00377530 File Offset: 0x00375730
		public static YamlNode ExportYamlRelease_Array_SerializedSubShader_2020_3_16(this AssetList<SerializedSubShader_2020_3_16> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175C6 RID: 95686 RVA: 0x00377570 File Offset: 0x00375770
		public static YamlNode ExportYamlRelease_Array_SerializedSubShader_2020_3_2(this AssetList<SerializedSubShader_2020_3_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175C7 RID: 95687 RVA: 0x003775B0 File Offset: 0x003757B0
		public static YamlNode ExportYamlRelease_Array_SerializedSubShader_2021_1_0(this AssetList<SerializedSubShader_2021_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175C8 RID: 95688 RVA: 0x003775F0 File Offset: 0x003757F0
		public static YamlNode ExportYamlRelease_Array_SerializedSubShader_2021_1_1(this AssetList<SerializedSubShader_2021_1_1> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175C9 RID: 95689 RVA: 0x00377630 File Offset: 0x00375830
		public static YamlNode ExportYamlRelease_Array_SerializedSubShader_2021_1_17(this AssetList<SerializedSubShader_2021_1_17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175CA RID: 95690 RVA: 0x00377670 File Offset: 0x00375870
		public static YamlNode ExportYamlRelease_Array_SerializedSubShader_2021_2_0(this AssetList<SerializedSubShader_2021_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175CB RID: 95691 RVA: 0x003776B0 File Offset: 0x003758B0
		public static YamlNode ExportYamlRelease_Array_SerializedSubShader_2021_2_0_a16(this AssetList<SerializedSubShader_2021_2_0_a16> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175CC RID: 95692 RVA: 0x003776F0 File Offset: 0x003758F0
		public static YamlNode ExportYamlRelease_Array_SerializedSubShader_2021_2_0_a17(this AssetList<SerializedSubShader_2021_2_0_a17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175CD RID: 95693 RVA: 0x00377730 File Offset: 0x00375930
		public static YamlNode ExportYamlRelease_Array_SerializedSubShader_2021_3_10(this AssetList<SerializedSubShader_2021_3_10> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175CE RID: 95694 RVA: 0x00377770 File Offset: 0x00375970
		public static YamlNode ExportYamlRelease_Array_SerializedSubShader_2022_1_0(this AssetList<SerializedSubShader_2022_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175CF RID: 95695 RVA: 0x003777B0 File Offset: 0x003759B0
		public static YamlNode ExportYamlRelease_Array_SerializedSubShader_2022_1_0_b3(this AssetList<SerializedSubShader_2022_1_0_b3> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175D0 RID: 95696 RVA: 0x003777F0 File Offset: 0x003759F0
		public static YamlNode ExportYamlRelease_Array_SerializedSubShader_2022_1_13(this AssetList<SerializedSubShader_2022_1_13> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175D1 RID: 95697 RVA: 0x00377830 File Offset: 0x00375A30
		public static YamlNode ExportYamlRelease_Array_SerializedSubShader_2022_2_0(this AssetList<SerializedSubShader_2022_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175D2 RID: 95698 RVA: 0x00377870 File Offset: 0x00375A70
		public static YamlNode ExportYamlRelease_Array_SerializedSubShader_2022_2_0_b5(this AssetList<SerializedSubShader_2022_2_0_b5> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175D3 RID: 95699 RVA: 0x003778B0 File Offset: 0x00375AB0
		public static YamlNode ExportYamlRelease_Array_SerializedSubShader_5_5_0(this AssetList<SerializedSubShader_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175D4 RID: 95700 RVA: 0x003778F0 File Offset: 0x00375AF0
		public static YamlNode ExportYamlRelease_Array_SerializedSubShader_5_6_0(this AssetList<SerializedSubShader_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175D5 RID: 95701 RVA: 0x00377930 File Offset: 0x00375B30
		public static YamlNode ExportYamlRelease_Array_ShaderBindChannel(this AssetList<ShaderBindChannel> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175D6 RID: 95702 RVA: 0x00377970 File Offset: 0x00375B70
		public static YamlNode ExportYamlRelease_Array_Single(this float[] value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int num = value.Length;
			for (int i = 0; i < num; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease_Single(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175D7 RID: 95703 RVA: 0x003779A8 File Offset: 0x00375BA8
		public static YamlNode ExportYamlRelease_Array_SkeletonBone_4_0_0(this AssetList<SkeletonBone_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175D8 RID: 95704 RVA: 0x003779E8 File Offset: 0x00375BE8
		public static YamlNode ExportYamlRelease_Array_SkeletonBone_5_5_0(this AssetList<SkeletonBone_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175D9 RID: 95705 RVA: 0x00377A28 File Offset: 0x00375C28
		public static YamlNode ExportYamlRelease_Array_SkeletonMaskElement_4_0_0(this AssetList<SkeletonMaskElement_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175DA RID: 95706 RVA: 0x00377A68 File Offset: 0x00375C68
		public static YamlNode ExportYamlRelease_Array_SkeletonMaskElement_4_3_0(this AssetList<SkeletonMaskElement_4_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175DB RID: 95707 RVA: 0x00377AA8 File Offset: 0x00375CA8
		public static YamlNode ExportYamlRelease_Array_SketchUpImportScene_2019_1_0(this AssetList<SketchUpImportScene_2019_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175DC RID: 95708 RVA: 0x00377AE8 File Offset: 0x00375CE8
		public static YamlNode ExportYamlRelease_Array_SketchUpImportScene_5_1_0(this AssetList<SketchUpImportScene_5_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175DD RID: 95709 RVA: 0x00377B28 File Offset: 0x00375D28
		public static YamlNode ExportYamlRelease_Array_SnapshotConstant(this AssetList<SnapshotConstant> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175DE RID: 95710 RVA: 0x00377B68 File Offset: 0x00375D68
		public static YamlNode ExportYamlRelease_Array_SortingLayerEntry_4_3_0(this AssetList<SortingLayerEntry_4_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175DF RID: 95711 RVA: 0x00377BA8 File Offset: 0x00375DA8
		public static YamlNode ExportYamlRelease_Array_SortingLayerEntry_5_0_0(this AssetList<SortingLayerEntry_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175E0 RID: 95712 RVA: 0x00377BE8 File Offset: 0x00375DE8
		public static YamlNode ExportYamlRelease_Array_SphericalHarmonicsL2_3_5_0(this AssetList<SphericalHarmonicsL2_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175E1 RID: 95713 RVA: 0x00377C28 File Offset: 0x00375E28
		public static YamlNode ExportYamlRelease_Array_SphericalHarmonicsL2_5_0_0(this AssetList<SphericalHarmonicsL2_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175E2 RID: 95714 RVA: 0x00377C68 File Offset: 0x00375E68
		public static YamlNode ExportYamlRelease_Array_SplashScreenLogo(this AssetList<SplashScreenLogo> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175E3 RID: 95715 RVA: 0x00377CA8 File Offset: 0x00375EA8
		public static YamlNode ExportYamlRelease_Array_SplatPrototype_3_4_0(this AssetList<SplatPrototype_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175E4 RID: 95716 RVA: 0x00377CE8 File Offset: 0x00375EE8
		public static YamlNode ExportYamlRelease_Array_SplatPrototype_3_5_0(this AssetList<SplatPrototype_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175E5 RID: 95717 RVA: 0x00377D28 File Offset: 0x00375F28
		public static YamlNode ExportYamlRelease_Array_SplatPrototype_4_0_0(this AssetList<SplatPrototype_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175E6 RID: 95718 RVA: 0x00377D68 File Offset: 0x00375F68
		public static YamlNode ExportYamlRelease_Array_SplatPrototype_5_0_0(this AssetList<SplatPrototype_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175E7 RID: 95719 RVA: 0x00377DA8 File Offset: 0x00375FA8
		public static YamlNode ExportYamlRelease_Array_SplatPrototype_5_0_1(this AssetList<SplatPrototype_5_0_1> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175E8 RID: 95720 RVA: 0x00377DE8 File Offset: 0x00375FE8
		public static YamlNode ExportYamlRelease_Array_SpriteBone_2018_1_0(this AssetList<SpriteBone_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175E9 RID: 95721 RVA: 0x00377E28 File Offset: 0x00376028
		public static YamlNode ExportYamlRelease_Array_SpriteBone_2021_1_0(this AssetList<SpriteBone_2021_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175EA RID: 95722 RVA: 0x00377E68 File Offset: 0x00376068
		public static YamlNode ExportYamlRelease_Array_SpriteData(this AssetList<SpriteData> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175EB RID: 95723 RVA: 0x00377EA8 File Offset: 0x003760A8
		public static YamlNode ExportYamlRelease_Array_SpriteMetaData_2017_1_0(this AssetList<SpriteMetaData_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175EC RID: 95724 RVA: 0x00377EE8 File Offset: 0x003760E8
		public static YamlNode ExportYamlRelease_Array_SpriteMetaData_2018_1_0(this AssetList<SpriteMetaData_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175ED RID: 95725 RVA: 0x00377F28 File Offset: 0x00376128
		public static YamlNode ExportYamlRelease_Array_SpriteMetaData_2019_1_0(this AssetList<SpriteMetaData_2019_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175EE RID: 95726 RVA: 0x00377F68 File Offset: 0x00376168
		public static YamlNode ExportYamlRelease_Array_SpriteMetaData_2021_1_0(this AssetList<SpriteMetaData_2021_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175EF RID: 95727 RVA: 0x00377FA8 File Offset: 0x003761A8
		public static YamlNode ExportYamlRelease_Array_SpriteMetaData_4_3_0(this AssetList<SpriteMetaData_4_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175F0 RID: 95728 RVA: 0x00377FE8 File Offset: 0x003761E8
		public static YamlNode ExportYamlRelease_Array_SpriteMetaData_4_5_0(this AssetList<SpriteMetaData_4_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175F1 RID: 95729 RVA: 0x00378028 File Offset: 0x00376228
		public static YamlNode ExportYamlRelease_Array_SpriteMetaData_5_3_0(this AssetList<SpriteMetaData_5_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175F2 RID: 95730 RVA: 0x00378068 File Offset: 0x00376268
		public static YamlNode ExportYamlRelease_Array_SpriteMetaData_5_3_6(this AssetList<SpriteMetaData_5_3_6> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175F3 RID: 95731 RVA: 0x003780A8 File Offset: 0x003762A8
		public static YamlNode ExportYamlRelease_Array_SpriteMetaData_5_4_0(this AssetList<SpriteMetaData_5_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175F4 RID: 95732 RVA: 0x003780E8 File Offset: 0x003762E8
		public static YamlNode ExportYamlRelease_Array_SpriteVertex_4_3_0(this AssetList<SpriteVertex_4_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175F5 RID: 95733 RVA: 0x00378128 File Offset: 0x00376328
		public static YamlNode ExportYamlRelease_Array_SpriteVertex_4_5_0(this AssetList<SpriteVertex_4_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175F6 RID: 95734 RVA: 0x00378168 File Offset: 0x00376368
		public static YamlNode ExportYamlRelease_Array_StreamInfo_4_0_0(this AssetList<StreamInfo_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175F7 RID: 95735 RVA: 0x003781A8 File Offset: 0x003763A8
		public static YamlNode ExportYamlRelease_Array_StructParameter(this AssetList<StructParameter> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175F8 RID: 95736 RVA: 0x003781E8 File Offset: 0x003763E8
		public static YamlNode ExportYamlRelease_Array_SubCollider_2017_1_0(this AssetList<SubCollider_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175F9 RID: 95737 RVA: 0x00378228 File Offset: 0x00376428
		public static YamlNode ExportYamlRelease_Array_SubCollider_5_6_0(this AssetList<SubCollider_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175FA RID: 95738 RVA: 0x00378268 File Offset: 0x00376468
		public static YamlNode ExportYamlRelease_Array_SubEmitterData_2017_2_0_b7(this AssetList<SubEmitterData_2017_2_0_b7> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175FB RID: 95739 RVA: 0x003782A8 File Offset: 0x003764A8
		public static YamlNode ExportYamlRelease_Array_SubEmitterData_2018_3_0(this AssetList<SubEmitterData_2018_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175FC RID: 95740 RVA: 0x003782E8 File Offset: 0x003764E8
		public static YamlNode ExportYamlRelease_Array_SubEmitterData_2018_3_0_b8(this AssetList<SubEmitterData_2018_3_0_b8> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175FD RID: 95741 RVA: 0x00378328 File Offset: 0x00376528
		public static YamlNode ExportYamlRelease_Array_SubEmitterData_5_5_0(this AssetList<SubEmitterData_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175FE RID: 95742 RVA: 0x00378368 File Offset: 0x00376568
		public static YamlNode ExportYamlRelease_Array_SubMesh_2017_3_0(this AssetList<SubMesh_2017_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060175FF RID: 95743 RVA: 0x003783A8 File Offset: 0x003765A8
		public static YamlNode ExportYamlRelease_Array_SubMesh_3_4_0(this AssetList<SubMesh_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017600 RID: 95744 RVA: 0x003783E8 File Offset: 0x003765E8
		public static YamlNode ExportYamlRelease_Array_SubMesh_3_5_0(this AssetList<SubMesh_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017601 RID: 95745 RVA: 0x00378428 File Offset: 0x00376628
		public static YamlNode ExportYamlRelease_Array_SubMesh_4_0_0(this AssetList<SubMesh_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017602 RID: 95746 RVA: 0x00378468 File Offset: 0x00376668
		public static YamlNode ExportYamlRelease_Array_SubstanceEnumItem(this AssetList<SubstanceEnumItem> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017603 RID: 95747 RVA: 0x003784A8 File Offset: 0x003766A8
		public static YamlNode ExportYamlRelease_Array_SubstanceInput_2017_1_0(this AssetList<SubstanceInput_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017604 RID: 95748 RVA: 0x003784E8 File Offset: 0x003766E8
		public static YamlNode ExportYamlRelease_Array_SubstanceInput_2017_2_0_b4(this AssetList<SubstanceInput_2017_2_0_b4> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017605 RID: 95749 RVA: 0x00378528 File Offset: 0x00376728
		public static YamlNode ExportYamlRelease_Array_SubstanceInput_3_4_0(this AssetList<SubstanceInput_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017606 RID: 95750 RVA: 0x00378568 File Offset: 0x00376768
		public static YamlNode ExportYamlRelease_Array_SubstanceInput_3_5_0(this AssetList<SubstanceInput_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017607 RID: 95751 RVA: 0x003785A8 File Offset: 0x003767A8
		public static YamlNode ExportYamlRelease_Array_SubstanceInput_4_1_0(this AssetList<SubstanceInput_4_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017608 RID: 95752 RVA: 0x003785E8 File Offset: 0x003767E8
		public static YamlNode ExportYamlRelease_Array_SubstanceInput_4_5_0(this AssetList<SubstanceInput_4_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017609 RID: 95753 RVA: 0x00378628 File Offset: 0x00376828
		public static YamlNode ExportYamlRelease_Array_SubstanceInput_5_0_0(this AssetList<SubstanceInput_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601760A RID: 95754 RVA: 0x00378668 File Offset: 0x00376868
		public static YamlNode ExportYamlRelease_Array_SubstanceInput_5_2_0(this AssetList<SubstanceInput_5_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601760B RID: 95755 RVA: 0x003786A8 File Offset: 0x003768A8
		public static YamlNode ExportYamlRelease_Array_Tetrahedron_2019_4_19(this AssetList<Tetrahedron_2019_4_19> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601760C RID: 95756 RVA: 0x003786E8 File Offset: 0x003768E8
		public static YamlNode ExportYamlRelease_Array_Tetrahedron_2020_1_0(this AssetList<Tetrahedron_2020_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601760D RID: 95757 RVA: 0x00378728 File Offset: 0x00376928
		public static YamlNode ExportYamlRelease_Array_Tetrahedron_2020_1_0_a9(this AssetList<Tetrahedron_2020_1_0_a9> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601760E RID: 95758 RVA: 0x00378768 File Offset: 0x00376968
		public static YamlNode ExportYamlRelease_Array_Tetrahedron_3_5_0(this AssetList<Tetrahedron_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601760F RID: 95759 RVA: 0x003787A8 File Offset: 0x003769A8
		public static YamlNode ExportYamlRelease_Array_TextureImporterPlatformSettings_2017_2_0(this AssetList<TextureImporterPlatformSettings_2017_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017610 RID: 95760 RVA: 0x003787E8 File Offset: 0x003769E8
		public static YamlNode ExportYamlRelease_Array_TextureImporterPlatformSettings_2017_3_0(this AssetList<TextureImporterPlatformSettings_2017_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017611 RID: 95761 RVA: 0x00378828 File Offset: 0x00376A28
		public static YamlNode ExportYamlRelease_Array_TextureImporterPlatformSettings_2018_1_0(this AssetList<TextureImporterPlatformSettings_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017612 RID: 95762 RVA: 0x00378868 File Offset: 0x00376A68
		public static YamlNode ExportYamlRelease_Array_TextureImporterPlatformSettings_2019_2_0(this AssetList<TextureImporterPlatformSettings_2019_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017613 RID: 95763 RVA: 0x003788A8 File Offset: 0x00376AA8
		public static YamlNode ExportYamlRelease_Array_TextureImporterPlatformSettings_3_4_0(this AssetList<TextureImporterPlatformSettings_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017614 RID: 95764 RVA: 0x003788E8 File Offset: 0x00376AE8
		public static YamlNode ExportYamlRelease_Array_TextureImporterPlatformSettings_3_5_0(this AssetList<TextureImporterPlatformSettings_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017615 RID: 95765 RVA: 0x00378928 File Offset: 0x00376B28
		public static YamlNode ExportYamlRelease_Array_TextureImporterPlatformSettings_5_2_0(this AssetList<TextureImporterPlatformSettings_5_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017616 RID: 95766 RVA: 0x00378968 File Offset: 0x00376B68
		public static YamlNode ExportYamlRelease_Array_TextureImporterPlatformSettings_5_5_0(this AssetList<TextureImporterPlatformSettings_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017617 RID: 95767 RVA: 0x003789A8 File Offset: 0x00376BA8
		public static YamlNode ExportYamlRelease_Array_TextureParameter_2017_3_0(this AssetList<TextureParameter_2017_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017618 RID: 95768 RVA: 0x003789E8 File Offset: 0x00376BE8
		public static YamlNode ExportYamlRelease_Array_TextureParameter_5_5_0(this AssetList<TextureParameter_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017619 RID: 95769 RVA: 0x00378A28 File Offset: 0x00376C28
		public static YamlNode ExportYamlRelease_Array_TilemapRefCountedData_ColorRGBAf(this AssetList<TilemapRefCountedData_ColorRGBAf> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601761A RID: 95770 RVA: 0x00378A68 File Offset: 0x00376C68
		public static YamlNode ExportYamlRelease_Array_TilemapRefCountedData_Matrix4x4f(this AssetList<TilemapRefCountedData_Matrix4x4f> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601761B RID: 95771 RVA: 0x00378AA8 File Offset: 0x00376CA8
		public static YamlNode ExportYamlRelease_Array_TilemapRefCountedData_PPtr_GameObject(this AssetList<TilemapRefCountedData_PPtr_GameObject> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601761C RID: 95772 RVA: 0x00378AE8 File Offset: 0x00376CE8
		public static YamlNode ExportYamlRelease_Array_TilemapRefCountedData_PPtr_Object(this AssetList<TilemapRefCountedData_PPtr_Object> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601761D RID: 95773 RVA: 0x00378B28 File Offset: 0x00376D28
		public static YamlNode ExportYamlRelease_Array_TilemapRefCountedData_PPtr_Sprite(this AssetList<TilemapRefCountedData_PPtr_Sprite> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601761E RID: 95774 RVA: 0x00378B68 File Offset: 0x00376D68
		public static YamlNode ExportYamlRelease_Array_TransformMaskElement(this AssetList<TransformMaskElement> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601761F RID: 95775 RVA: 0x00378BA8 File Offset: 0x00376DA8
		public static YamlNode ExportYamlRelease_Array_TreeInstance_3_4_0(this AssetList<TreeInstance_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017620 RID: 95776 RVA: 0x00378BE8 File Offset: 0x00376DE8
		public static YamlNode ExportYamlRelease_Array_TreeInstance_3_5_0(this AssetList<TreeInstance_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017621 RID: 95777 RVA: 0x00378C28 File Offset: 0x00376E28
		public static YamlNode ExportYamlRelease_Array_TreeInstance_5_0_0(this AssetList<TreeInstance_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017622 RID: 95778 RVA: 0x00378C68 File Offset: 0x00376E68
		public static YamlNode ExportYamlRelease_Array_TreePrototype_2020_2_0_a12(this AssetList<TreePrototype_2020_2_0_a12> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017623 RID: 95779 RVA: 0x00378CA8 File Offset: 0x00376EA8
		public static YamlNode ExportYamlRelease_Array_TreePrototype_3_4_0(this AssetList<TreePrototype_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017624 RID: 95780 RVA: 0x00378CE8 File Offset: 0x00376EE8
		public static YamlNode ExportYamlRelease_Array_TreePrototype_5_0_0(this AssetList<TreePrototype_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017625 RID: 95781 RVA: 0x00378D28 File Offset: 0x00376F28
		public static YamlNode ExportYamlRelease_Array_UAVParameter(this AssetList<UAVParameter> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017626 RID: 95782 RVA: 0x00378D68 File Offset: 0x00376F68
		public static YamlNode ExportYamlRelease_Array_UInt16(this ushort[] value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int num = value.Length;
			for (int i = 0; i < num; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease_UInt16(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017627 RID: 95783 RVA: 0x00378DA0 File Offset: 0x00376FA0
		public static YamlNode ExportYamlRelease_Array_UInt32(this uint[] value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int num = value.Length;
			for (int i = 0; i < num; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease_UInt32(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017628 RID: 95784 RVA: 0x00378DD8 File Offset: 0x00376FD8
		public static YamlNode ExportYamlRelease_Array_UpdateZoneInfo(this AssetList<UpdateZoneInfo> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017629 RID: 95785 RVA: 0x00378E18 File Offset: 0x00377018
		public static YamlNode ExportYamlRelease_Array_Utf8String(this AssetList<Utf8String> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601762A RID: 95786 RVA: 0x00378E58 File Offset: 0x00377058
		public static YamlNode ExportYamlRelease_Array_ValueConstant_4_0_0(this AssetList<ValueConstant_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601762B RID: 95787 RVA: 0x00378E98 File Offset: 0x00377098
		public static YamlNode ExportYamlRelease_Array_ValueConstant_5_5_0(this AssetList<ValueConstant_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601762C RID: 95788 RVA: 0x00378ED8 File Offset: 0x003770D8
		public static YamlNode ExportYamlRelease_Array_ValueDelta(this AssetList<ValueDelta> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601762D RID: 95789 RVA: 0x00378F18 File Offset: 0x00377118
		public static YamlNode ExportYamlRelease_Array_VariantInfo(this AssetList<VariantInfo> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601762E RID: 95790 RVA: 0x00378F58 File Offset: 0x00377158
		public static YamlNode ExportYamlRelease_Array_Vector2f_3_4_0(this AssetList<Vector2f_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601762F RID: 95791 RVA: 0x00378F98 File Offset: 0x00377198
		public static YamlNode ExportYamlRelease_Array_Vector2f_3_5_0(this AssetList<Vector2f_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017630 RID: 95792 RVA: 0x00378FD8 File Offset: 0x003771D8
		public static YamlNode ExportYamlRelease_Array_Vector2Int(this AssetList<Vector2Int> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017631 RID: 95793 RVA: 0x00379018 File Offset: 0x00377218
		public static YamlNode ExportYamlRelease_Array_Vector2Long(this AssetList<Vector2Long> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017632 RID: 95794 RVA: 0x00379058 File Offset: 0x00377258
		public static YamlNode ExportYamlRelease_Array_Vector3Curve_2017_1_0(this AssetList<Vector3Curve_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017633 RID: 95795 RVA: 0x00379098 File Offset: 0x00377298
		public static YamlNode ExportYamlRelease_Array_Vector3Curve_2018_1_0(this AssetList<Vector3Curve_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017634 RID: 95796 RVA: 0x003790D8 File Offset: 0x003772D8
		public static YamlNode ExportYamlRelease_Array_Vector3Curve_3_4_0(this AssetList<Vector3Curve_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017635 RID: 95797 RVA: 0x00379118 File Offset: 0x00377318
		public static YamlNode ExportYamlRelease_Array_Vector3Curve_3_5_0(this AssetList<Vector3Curve_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017636 RID: 95798 RVA: 0x00379158 File Offset: 0x00377358
		public static YamlNode ExportYamlRelease_Array_Vector3Curve_5_3_0(this AssetList<Vector3Curve_5_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017637 RID: 95799 RVA: 0x00379198 File Offset: 0x00377398
		public static YamlNode ExportYamlRelease_Array_Vector3Curve_5_5_0(this AssetList<Vector3Curve_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017638 RID: 95800 RVA: 0x003791D8 File Offset: 0x003773D8
		public static YamlNode ExportYamlRelease_Array_Vector3f_3_4_0(this AssetList<Vector3f_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017639 RID: 95801 RVA: 0x00379218 File Offset: 0x00377418
		public static YamlNode ExportYamlRelease_Array_Vector3f_3_5_0(this AssetList<Vector3f_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601763A RID: 95802 RVA: 0x00379258 File Offset: 0x00377458
		public static YamlNode ExportYamlRelease_Array_Vector3Float_5_4_0(this AssetList<Vector3Float_5_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601763B RID: 95803 RVA: 0x00379298 File Offset: 0x00377498
		public static YamlNode ExportYamlRelease_Array_Vector3Float_5_5_0(this AssetList<Vector3Float_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601763C RID: 95804 RVA: 0x003792D8 File Offset: 0x003774D8
		public static YamlNode ExportYamlRelease_Array_Vector4f_3_4_0(this AssetList<Vector4f_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601763D RID: 95805 RVA: 0x00379318 File Offset: 0x00377518
		public static YamlNode ExportYamlRelease_Array_Vector4f_3_5_0(this AssetList<Vector4f_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601763E RID: 95806 RVA: 0x00379358 File Offset: 0x00377558
		public static YamlNode ExportYamlRelease_Array_Vector4Float_4_0_0(this AssetList<Vector4Float_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601763F RID: 95807 RVA: 0x00379398 File Offset: 0x00377598
		public static YamlNode ExportYamlRelease_Array_Vector4Float_5_5_0(this AssetList<Vector4Float_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017640 RID: 95808 RVA: 0x003793D8 File Offset: 0x003775D8
		public static YamlNode ExportYamlRelease_Array_VectorParameter(this AssetList<VectorParameter> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017641 RID: 95809 RVA: 0x00379418 File Offset: 0x00377618
		public static YamlNode ExportYamlRelease_Array_VFXCPUBufferDesc(this AssetList<VFXCPUBufferDesc> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017642 RID: 95810 RVA: 0x00379458 File Offset: 0x00377658
		public static YamlNode ExportYamlRelease_Array_VFXEditorSystemDesc_2018_3_0(this AssetList<VFXEditorSystemDesc_2018_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017643 RID: 95811 RVA: 0x00379498 File Offset: 0x00377698
		public static YamlNode ExportYamlRelease_Array_VFXEditorSystemDesc_2019_2_0_a7(this AssetList<VFXEditorSystemDesc_2019_2_0_a7> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017644 RID: 95812 RVA: 0x003794D8 File Offset: 0x003776D8
		public static YamlNode ExportYamlRelease_Array_VFXEditorTaskDesc_2018_3_0(this AssetList<VFXEditorTaskDesc_2018_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017645 RID: 95813 RVA: 0x00379518 File Offset: 0x00377718
		public static YamlNode ExportYamlRelease_Array_VFXEditorTaskDesc_2019_2_0_a7(this AssetList<VFXEditorTaskDesc_2019_2_0_a7> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017646 RID: 95814 RVA: 0x00379558 File Offset: 0x00377758
		public static YamlNode ExportYamlRelease_Array_VFXEntryExposed_AnimationCurve_Single(this AssetList<VFXEntryExposed_AnimationCurve_Single> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017647 RID: 95815 RVA: 0x00379598 File Offset: 0x00377798
		public static YamlNode ExportYamlRelease_Array_VFXEntryExposed_bool(this AssetList<VFXEntryExposed_bool> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017648 RID: 95816 RVA: 0x003795D8 File Offset: 0x003777D8
		public static YamlNode ExportYamlRelease_Array_VFXEntryExposed_float(this AssetList<VFXEntryExposed_float> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017649 RID: 95817 RVA: 0x00379618 File Offset: 0x00377818
		public static YamlNode ExportYamlRelease_Array_VFXEntryExposed_Gradient_2018_3_0(this AssetList<VFXEntryExposed_Gradient_2018_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601764A RID: 95818 RVA: 0x00379658 File Offset: 0x00377858
		public static YamlNode ExportYamlRelease_Array_VFXEntryExposed_Gradient_2022_2_0(this AssetList<VFXEntryExposed_Gradient_2022_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601764B RID: 95819 RVA: 0x00379698 File Offset: 0x00377898
		public static YamlNode ExportYamlRelease_Array_VFXEntryExposed_Matrix4x4f(this AssetList<VFXEntryExposed_Matrix4x4f> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601764C RID: 95820 RVA: 0x003796D8 File Offset: 0x003778D8
		public static YamlNode ExportYamlRelease_Array_VFXEntryExposed_PPtr_NamedObject(this AssetList<VFXEntryExposed_PPtr_NamedObject> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601764D RID: 95821 RVA: 0x00379718 File Offset: 0x00377918
		public static YamlNode ExportYamlRelease_Array_VFXEntryExposed_PPtr_Object(this AssetList<VFXEntryExposed_PPtr_Object> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601764E RID: 95822 RVA: 0x00379758 File Offset: 0x00377958
		public static YamlNode ExportYamlRelease_Array_VFXEntryExposed_SInt32(this AssetList<VFXEntryExposed_SInt32> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601764F RID: 95823 RVA: 0x00379798 File Offset: 0x00377998
		public static YamlNode ExportYamlRelease_Array_VFXEntryExposed_UInt32(this AssetList<VFXEntryExposed_UInt32> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017650 RID: 95824 RVA: 0x003797D8 File Offset: 0x003779D8
		public static YamlNode ExportYamlRelease_Array_VFXEntryExposed_Vector2f(this AssetList<VFXEntryExposed_Vector2f> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017651 RID: 95825 RVA: 0x00379818 File Offset: 0x00377A18
		public static YamlNode ExportYamlRelease_Array_VFXEntryExposed_Vector3f(this AssetList<VFXEntryExposed_Vector3f> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017652 RID: 95826 RVA: 0x00379858 File Offset: 0x00377A58
		public static YamlNode ExportYamlRelease_Array_VFXEntryExposed_Vector4f(this AssetList<VFXEntryExposed_Vector4f> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017653 RID: 95827 RVA: 0x00379898 File Offset: 0x00377A98
		public static YamlNode ExportYamlRelease_Array_VFXEntryExpressionValue_AnimationCurve_Single(this AssetList<VFXEntryExpressionValue_AnimationCurve_Single> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017654 RID: 95828 RVA: 0x003798D8 File Offset: 0x00377AD8
		public static YamlNode ExportYamlRelease_Array_VFXEntryExpressionValue_bool(this AssetList<VFXEntryExpressionValue_bool> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017655 RID: 95829 RVA: 0x00379918 File Offset: 0x00377B18
		public static YamlNode ExportYamlRelease_Array_VFXEntryExpressionValue_float(this AssetList<VFXEntryExpressionValue_float> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017656 RID: 95830 RVA: 0x00379958 File Offset: 0x00377B58
		public static YamlNode ExportYamlRelease_Array_VFXEntryExpressionValue_Gradient_2018_3_0(this AssetList<VFXEntryExpressionValue_Gradient_2018_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017657 RID: 95831 RVA: 0x00379998 File Offset: 0x00377B98
		public static YamlNode ExportYamlRelease_Array_VFXEntryExpressionValue_Gradient_2022_2_0(this AssetList<VFXEntryExpressionValue_Gradient_2022_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017658 RID: 95832 RVA: 0x003799D8 File Offset: 0x00377BD8
		public static YamlNode ExportYamlRelease_Array_VFXEntryExpressionValue_Matrix4x4f(this AssetList<VFXEntryExpressionValue_Matrix4x4f> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017659 RID: 95833 RVA: 0x00379A18 File Offset: 0x00377C18
		public static YamlNode ExportYamlRelease_Array_VFXEntryExpressionValue_PPtr_NamedObject(this AssetList<VFXEntryExpressionValue_PPtr_NamedObject> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601765A RID: 95834 RVA: 0x00379A58 File Offset: 0x00377C58
		public static YamlNode ExportYamlRelease_Array_VFXEntryExpressionValue_PPtr_Object(this AssetList<VFXEntryExpressionValue_PPtr_Object> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601765B RID: 95835 RVA: 0x00379A98 File Offset: 0x00377C98
		public static YamlNode ExportYamlRelease_Array_VFXEntryExpressionValue_SInt32(this AssetList<VFXEntryExpressionValue_SInt32> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601765C RID: 95836 RVA: 0x00379AD8 File Offset: 0x00377CD8
		public static YamlNode ExportYamlRelease_Array_VFXEntryExpressionValue_UInt32(this AssetList<VFXEntryExpressionValue_UInt32> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601765D RID: 95837 RVA: 0x00379B18 File Offset: 0x00377D18
		public static YamlNode ExportYamlRelease_Array_VFXEntryExpressionValue_Vector2f(this AssetList<VFXEntryExpressionValue_Vector2f> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601765E RID: 95838 RVA: 0x00379B58 File Offset: 0x00377D58
		public static YamlNode ExportYamlRelease_Array_VFXEntryExpressionValue_Vector3f(this AssetList<VFXEntryExpressionValue_Vector3f> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601765F RID: 95839 RVA: 0x00379B98 File Offset: 0x00377D98
		public static YamlNode ExportYamlRelease_Array_VFXEntryExpressionValue_Vector4f(this AssetList<VFXEntryExpressionValue_Vector4f> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017660 RID: 95840 RVA: 0x00379BD8 File Offset: 0x00377DD8
		public static YamlNode ExportYamlRelease_Array_VFXEventDesc_2018_3_0(this AssetList<VFXEventDesc_2018_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017661 RID: 95841 RVA: 0x00379C18 File Offset: 0x00377E18
		public static YamlNode ExportYamlRelease_Array_VFXEventDesc_2021_2_0_a19(this AssetList<VFXEventDesc_2021_2_0_a19> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017662 RID: 95842 RVA: 0x00379C58 File Offset: 0x00377E58
		public static YamlNode ExportYamlRelease_Array_VFXGPUBufferDesc(this AssetList<VFXGPUBufferDesc> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017663 RID: 95843 RVA: 0x00379C98 File Offset: 0x00377E98
		public static YamlNode ExportYamlRelease_Array_VFXLayoutElementDesc(this AssetList<VFXLayoutElementDesc> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017664 RID: 95844 RVA: 0x00379CD8 File Offset: 0x00377ED8
		public static YamlNode ExportYamlRelease_Array_VFXMapping(this AssetList<VFXMapping> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017665 RID: 95845 RVA: 0x00379D18 File Offset: 0x00377F18
		public static YamlNode ExportYamlRelease_Array_VFXMappingTemporary(this AssetList<VFXMappingTemporary> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017666 RID: 95846 RVA: 0x00379D58 File Offset: 0x00377F58
		public static YamlNode ExportYamlRelease_Array_VFXShaderSourceDesc(this AssetList<VFXShaderSourceDesc> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017667 RID: 95847 RVA: 0x00379D98 File Offset: 0x00377F98
		public static YamlNode ExportYamlRelease_Array_VFXSystemDesc_2018_3_0(this AssetList<VFXSystemDesc_2018_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017668 RID: 95848 RVA: 0x00379DD8 File Offset: 0x00377FD8
		public static YamlNode ExportYamlRelease_Array_VFXSystemDesc_2019_2_0_a7(this AssetList<VFXSystemDesc_2019_2_0_a7> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017669 RID: 95849 RVA: 0x00379E18 File Offset: 0x00378018
		public static YamlNode ExportYamlRelease_Array_VFXSystemDesc_2020_1_0_a17(this AssetList<VFXSystemDesc_2020_1_0_a17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601766A RID: 95850 RVA: 0x00379E58 File Offset: 0x00378058
		public static YamlNode ExportYamlRelease_Array_VFXTaskDesc_2018_3_0(this AssetList<VFXTaskDesc_2018_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601766B RID: 95851 RVA: 0x00379E98 File Offset: 0x00378098
		public static YamlNode ExportYamlRelease_Array_VFXTaskDesc_2019_2_0_a7(this AssetList<VFXTaskDesc_2019_2_0_a7> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601766C RID: 95852 RVA: 0x00379ED8 File Offset: 0x003780D8
		public static YamlNode ExportYamlRelease_Array_VFXTemporaryGPUBufferDesc(this AssetList<VFXTemporaryGPUBufferDesc> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601766D RID: 95853 RVA: 0x00379F18 File Offset: 0x00378118
		public static YamlNode ExportYamlRelease_Array_Xform_4_0_0(this AssetList<Xform_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601766E RID: 95854 RVA: 0x00379F58 File Offset: 0x00378158
		public static YamlNode ExportYamlRelease_Array_Xform_5_4_0(this AssetList<Xform_5_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601766F RID: 95855 RVA: 0x00379F98 File Offset: 0x00378198
		public static YamlNode ExportYamlRelease_Array_Xform_5_5_0(this AssetList<Xform_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlRelease(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017670 RID: 95856 RVA: 0x00379FD5 File Offset: 0x003781D5
		public static YamlNode ExportYamlRelease_Boolean(this bool value, IExportContainer container)
		{
			return new YamlScalarNode(value);
		}

		// Token: 0x06017671 RID: 95857 RVA: 0x00379FDD File Offset: 0x003781DD
		public static YamlNode ExportYamlRelease_Byte(this byte value, IExportContainer container)
		{
			return new YamlScalarNode(value);
		}

		// Token: 0x06017672 RID: 95858 RVA: 0x00379FE5 File Offset: 0x003781E5
		public static YamlNode ExportYamlRelease_Double(this double value, IExportContainer container)
		{
			return new YamlScalarNode(value);
		}

		// Token: 0x06017673 RID: 95859 RVA: 0x00379FED File Offset: 0x003781ED
		public static YamlNode ExportYamlRelease_Int16(this short value, IExportContainer container)
		{
			return new YamlScalarNode(value);
		}

		// Token: 0x06017674 RID: 95860 RVA: 0x00379FF5 File Offset: 0x003781F5
		public static YamlNode ExportYamlRelease_Int32(this int value, IExportContainer container)
		{
			return new YamlScalarNode(value);
		}

		// Token: 0x06017675 RID: 95861 RVA: 0x00379FFD File Offset: 0x003781FD
		public static YamlNode ExportYamlRelease_Int64(this long value, IExportContainer container)
		{
			return new YamlScalarNode(value);
		}

		// Token: 0x06017676 RID: 95862 RVA: 0x0037A008 File Offset: 0x00378208
		public static YamlNode ExportYamlRelease_Map_AssetImporterHashKey_UInt32(this AssetDictionary<AssetImporterHashKey, uint> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_AssetImporterHashKey_UInt32(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017677 RID: 95863 RVA: 0x0037A048 File Offset: 0x00378248
		public static YamlNode ExportYamlRelease_Map_FastPropertyName_ColorRGBAf_3_4_0(this AssetDictionary<FastPropertyName, ColorRGBAf_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_FastPropertyName_ColorRGBAf_3_4_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017678 RID: 95864 RVA: 0x0037A088 File Offset: 0x00378288
		public static YamlNode ExportYamlRelease_Map_FastPropertyName_ColorRGBAf_3_5_0(this AssetDictionary<FastPropertyName, ColorRGBAf_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_FastPropertyName_ColorRGBAf_3_5_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017679 RID: 95865 RVA: 0x0037A0C8 File Offset: 0x003782C8
		public static YamlNode ExportYamlRelease_Map_FastPropertyName_Single(this AssetDictionary<FastPropertyName, float> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_FastPropertyName_Single(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601767A RID: 95866 RVA: 0x0037A108 File Offset: 0x00378308
		public static YamlNode ExportYamlRelease_Map_FastPropertyName_UnityTexEnv_3_4_0(this AssetDictionary<FastPropertyName, UnityTexEnv_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_FastPropertyName_UnityTexEnv_3_4_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601767B RID: 95867 RVA: 0x0037A148 File Offset: 0x00378348
		public static YamlNode ExportYamlRelease_Map_FastPropertyName_UnityTexEnv_3_5_0(this AssetDictionary<FastPropertyName, UnityTexEnv_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_FastPropertyName_UnityTexEnv_3_5_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601767C RID: 95868 RVA: 0x0037A188 File Offset: 0x00378388
		public static YamlNode ExportYamlRelease_Map_FastPropertyName_UnityTexEnv_5_0_0(this AssetDictionary<FastPropertyName, UnityTexEnv_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_FastPropertyName_UnityTexEnv_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601767D RID: 95869 RVA: 0x0037A1C8 File Offset: 0x003783C8
		public static YamlNode ExportYamlRelease_Map_GUID_Asset_2017_1_0(this AssetDictionary<GUID, Asset_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_GUID_Asset_2017_1_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601767E RID: 95870 RVA: 0x0037A208 File Offset: 0x00378408
		public static YamlNode ExportYamlRelease_Map_GUID_Asset_2017_2_5(this AssetDictionary<GUID, Asset_2017_2_5> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_GUID_Asset_2017_2_5(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601767F RID: 95871 RVA: 0x0037A248 File Offset: 0x00378448
		public static YamlNode ExportYamlRelease_Map_GUID_Asset_2017_3_0(this AssetDictionary<GUID, Asset_2017_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_GUID_Asset_2017_3_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017680 RID: 95872 RVA: 0x0037A288 File Offset: 0x00378488
		public static YamlNode ExportYamlRelease_Map_GUID_Asset_2017_4_14(this AssetDictionary<GUID, Asset_2017_4_14> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_GUID_Asset_2017_4_14(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017681 RID: 95873 RVA: 0x0037A2C8 File Offset: 0x003784C8
		public static YamlNode ExportYamlRelease_Map_GUID_Asset_2018_1_0(this AssetDictionary<GUID, Asset_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_GUID_Asset_2018_1_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017682 RID: 95874 RVA: 0x0037A308 File Offset: 0x00378508
		public static YamlNode ExportYamlRelease_Map_GUID_Asset_2018_1_0_b11(this AssetDictionary<GUID, Asset_2018_1_0_b11> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_GUID_Asset_2018_1_0_b11(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017683 RID: 95875 RVA: 0x0037A348 File Offset: 0x00378548
		public static YamlNode ExportYamlRelease_Map_GUID_Asset_2018_3_0(this AssetDictionary<GUID, Asset_2018_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_GUID_Asset_2018_3_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017684 RID: 95876 RVA: 0x0037A388 File Offset: 0x00378588
		public static YamlNode ExportYamlRelease_Map_GUID_Asset_2019_3_0_a8(this AssetDictionary<GUID, Asset_2019_3_0_a8> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_GUID_Asset_2019_3_0_a8(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017685 RID: 95877 RVA: 0x0037A3C8 File Offset: 0x003785C8
		public static YamlNode ExportYamlRelease_Map_GUID_Asset_3_4_0(this AssetDictionary<GUID, Asset_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_GUID_Asset_3_4_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017686 RID: 95878 RVA: 0x0037A408 File Offset: 0x00378608
		public static YamlNode ExportYamlRelease_Map_GUID_Asset_3_5_0(this AssetDictionary<GUID, Asset_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_GUID_Asset_3_5_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017687 RID: 95879 RVA: 0x0037A448 File Offset: 0x00378648
		public static YamlNode ExportYamlRelease_Map_GUID_Asset_4_0_0(this AssetDictionary<GUID, Asset_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_GUID_Asset_4_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017688 RID: 95880 RVA: 0x0037A488 File Offset: 0x00378688
		public static YamlNode ExportYamlRelease_Map_GUID_Asset_4_3_0(this AssetDictionary<GUID, Asset_4_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_GUID_Asset_4_3_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017689 RID: 95881 RVA: 0x0037A4C8 File Offset: 0x003786C8
		public static YamlNode ExportYamlRelease_Map_GUID_Asset_5_0_0(this AssetDictionary<GUID, Asset_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_GUID_Asset_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601768A RID: 95882 RVA: 0x0037A508 File Offset: 0x00378708
		public static YamlNode ExportYamlRelease_Map_GUID_Asset_5_1_0(this AssetDictionary<GUID, Asset_5_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_GUID_Asset_5_1_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601768B RID: 95883 RVA: 0x0037A548 File Offset: 0x00378748
		public static YamlNode ExportYamlRelease_Map_GUID_Asset_5_5_0(this AssetDictionary<GUID, Asset_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_GUID_Asset_5_5_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601768C RID: 95884 RVA: 0x0037A588 File Offset: 0x00378788
		public static YamlNode ExportYamlRelease_Map_GUID_CachedAssetMetaData_3_4_0(this AssetDictionary<GUID, CachedAssetMetaData_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_GUID_CachedAssetMetaData_3_4_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601768D RID: 95885 RVA: 0x0037A5C8 File Offset: 0x003787C8
		public static YamlNode ExportYamlRelease_Map_GUID_CachedAssetMetaData_5_0_0(this AssetDictionary<GUID, CachedAssetMetaData_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_GUID_CachedAssetMetaData_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601768E RID: 95886 RVA: 0x0037A608 File Offset: 0x00378808
		public static YamlNode ExportYamlRelease_Map_GUID_DeletedItem_3_4_0(this AssetDictionary<GUID, DeletedItem_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_GUID_DeletedItem_3_4_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601768F RID: 95887 RVA: 0x0037A648 File Offset: 0x00378848
		public static YamlNode ExportYamlRelease_Map_GUID_DeletedItem_5_0_0(this AssetDictionary<GUID, DeletedItem_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_GUID_DeletedItem_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017690 RID: 95888 RVA: 0x0037A688 File Offset: 0x00378888
		public static YamlNode ExportYamlRelease_Map_GUID_Item(this AssetDictionary<GUID, Item> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_GUID_Item(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017691 RID: 95889 RVA: 0x0037A6C8 File Offset: 0x003788C8
		public static YamlNode ExportYamlRelease_Map_GUID_ModifiedItem_3_4_0(this AssetDictionary<GUID, ModifiedItem_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_GUID_ModifiedItem_3_4_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017692 RID: 95890 RVA: 0x0037A708 File Offset: 0x00378908
		public static YamlNode ExportYamlRelease_Map_GUID_ModifiedItem_5_0_0(this AssetDictionary<GUID, ModifiedItem_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_GUID_ModifiedItem_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017693 RID: 95891 RVA: 0x0037A748 File Offset: 0x00378948
		public static YamlNode ExportYamlRelease_Map_GUID_PPtr_GameObject_3_4_0(this AssetDictionary<GUID, PPtr_GameObject_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_GUID_PPtr_GameObject_3_4_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017694 RID: 95892 RVA: 0x0037A788 File Offset: 0x00378988
		public static YamlNode ExportYamlRelease_Map_GUID_PPtr_GameObject_5_0_0(this AssetDictionary<GUID, PPtr_GameObject_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_GUID_PPtr_GameObject_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017695 RID: 95893 RVA: 0x0037A7C8 File Offset: 0x003789C8
		public static YamlNode ExportYamlRelease_Map_GUID_Utf8String(this AssetDictionary<GUID, Utf8String> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_GUID_Utf8String(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017696 RID: 95894 RVA: 0x0037A808 File Offset: 0x00378A08
		public static YamlNode ExportYamlRelease_Map_Hash128_Hash128(this AssetDictionary<Hash128, Hash128> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Hash128_Hash128(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017697 RID: 95895 RVA: 0x0037A848 File Offset: 0x00378A48
		public static YamlNode ExportYamlRelease_Map_Hash128_Int32(this AssetDictionary<Hash128, int> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Hash128_Int32(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017698 RID: 95896 RVA: 0x0037A888 File Offset: 0x00378A88
		public static YamlNode ExportYamlRelease_Map_Int32_AssetBundleFullName(this AssetDictionary<int, AssetBundleFullName> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Int32_AssetBundleFullName(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017699 RID: 95897 RVA: 0x0037A8C8 File Offset: 0x00378AC8
		public static YamlNode ExportYamlRelease_Map_Int32_AssetBundleInfo(this AssetDictionary<int, AssetBundleInfo> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Int32_AssetBundleInfo(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601769A RID: 95898 RVA: 0x0037A908 File Offset: 0x00378B08
		public static YamlNode ExportYamlRelease_Map_Int32_Hash128(this AssetDictionary<int, Hash128> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Int32_Hash128(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601769B RID: 95899 RVA: 0x0037A948 File Offset: 0x00378B48
		public static YamlNode ExportYamlRelease_Map_Int32_Int32(this AssetDictionary<int, int> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Int32_Int32(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601769C RID: 95900 RVA: 0x0037A988 File Offset: 0x00378B88
		public static YamlNode ExportYamlRelease_Map_Int32_SampleSettings_2022_2_0_a17(this AssetDictionary<int, SampleSettings_2022_2_0_a17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Int32_SampleSettings_2022_2_0_a17(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601769D RID: 95901 RVA: 0x0037A9C8 File Offset: 0x00378BC8
		public static YamlNode ExportYamlRelease_Map_Int32_SampleSettings_5_0_0(this AssetDictionary<int, SampleSettings_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Int32_SampleSettings_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601769E RID: 95902 RVA: 0x0037AA08 File Offset: 0x00378C08
		public static YamlNode ExportYamlRelease_Map_Int32_UInt32(this AssetDictionary<int, uint> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Int32_UInt32(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601769F RID: 95903 RVA: 0x0037AA48 File Offset: 0x00378C48
		public static YamlNode ExportYamlRelease_Map_Int32_Utf8String(this AssetDictionary<int, Utf8String> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Int32_Utf8String(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176A0 RID: 95904 RVA: 0x0037AA88 File Offset: 0x00378C88
		public static YamlNode ExportYamlRelease_Map_Int32_VideoClipImporterTargetSettings(this AssetDictionary<int, VideoClipImporterTargetSettings> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Int32_VideoClipImporterTargetSettings(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176A1 RID: 95905 RVA: 0x0037AAC8 File Offset: 0x00378CC8
		public static YamlNode ExportYamlRelease_Map_Int64_Utf8String(this AssetDictionary<long, Utf8String> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Int64_Utf8String(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176A2 RID: 95906 RVA: 0x0037AB08 File Offset: 0x00378D08
		public static YamlNode ExportYamlRelease_Map_IntegerString_2017_1_0_PPtr_Object_5_0_0(this AssetDictionary<IntegerString_2017_1_0, PPtr_Object_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_IntegerString_2017_1_0_PPtr_Object_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176A3 RID: 95907 RVA: 0x0037AB48 File Offset: 0x00378D48
		public static YamlNode ExportYamlRelease_Map_IntegerString_2019_1_0_PPtr_Object_5_0_0(this AssetDictionary<IntegerString_2019_1_0, PPtr_Object_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_IntegerString_2019_1_0_PPtr_Object_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176A4 RID: 95908 RVA: 0x0037AB88 File Offset: 0x00378D88
		public static YamlNode ExportYamlRelease_Map_IntegerString_2020_1_0_PPtr_Object_5_0_0(this AssetDictionary<IntegerString_2020_1_0, PPtr_Object_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_IntegerString_2020_1_0_PPtr_Object_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176A5 RID: 95909 RVA: 0x0037ABC8 File Offset: 0x00378DC8
		public static YamlNode ExportYamlRelease_Map_IntegerString_2020_2_0_PPtr_Object_5_0_0(this AssetDictionary<IntegerString_2020_2_0, PPtr_Object_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_IntegerString_2020_2_0_PPtr_Object_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176A6 RID: 95910 RVA: 0x0037AC08 File Offset: 0x00378E08
		public static YamlNode ExportYamlRelease_Map_NestedString_2018_4_25_PPtr_Object_5_0_0(this AssetDictionary<NestedString_2018_4_25, PPtr_Object_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_NestedString_2018_4_25_PPtr_Object_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176A7 RID: 95911 RVA: 0x0037AC48 File Offset: 0x00378E48
		public static YamlNode ExportYamlRelease_Map_NestedString_2019_4_3_PPtr_Object_5_0_0(this AssetDictionary<NestedString_2019_4_3, PPtr_Object_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_NestedString_2019_4_3_PPtr_Object_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176A8 RID: 95912 RVA: 0x0037AC88 File Offset: 0x00378E88
		public static YamlNode ExportYamlRelease_Map_NestedString_2020_1_0_b15_PPtr_Object_5_0_0(this AssetDictionary<NestedString_2020_1_0_b15, PPtr_Object_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_NestedString_2020_1_0_b15_PPtr_Object_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176A9 RID: 95913 RVA: 0x0037ACC8 File Offset: 0x00378EC8
		public static YamlNode ExportYamlRelease_Map_NestedString_2020_2_0_a16_PPtr_Object_5_0_0(this AssetDictionary<NestedString_2020_2_0_a16, PPtr_Object_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_NestedString_2020_2_0_a16_PPtr_Object_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176AA RID: 95914 RVA: 0x0037AD08 File Offset: 0x00378F08
		public static YamlNode ExportYamlRelease_Map_Pair_GUID_Int32_SpriteRenderData_4_3_0(this AssetDictionary<AssetPair<GUID, int>, SpriteRenderData_4_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Pair_GUID_Int32_SpriteRenderData_4_3_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176AB RID: 95915 RVA: 0x0037AD48 File Offset: 0x00378F48
		public static YamlNode ExportYamlRelease_Map_Pair_GUID_Int32_SpriteRenderData_4_5_0(this AssetDictionary<AssetPair<GUID, int>, SpriteRenderData_4_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Pair_GUID_Int32_SpriteRenderData_4_5_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176AC RID: 95916 RVA: 0x0037AD88 File Offset: 0x00378F88
		public static YamlNode ExportYamlRelease_Map_Pair_GUID_Int64_SpriteAtlasData_2017_1_0(this AssetDictionary<AssetPair<GUID, long>, SpriteAtlasData_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteAtlasData_2017_1_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176AD RID: 95917 RVA: 0x0037ADC8 File Offset: 0x00378FC8
		public static YamlNode ExportYamlRelease_Map_Pair_GUID_Int64_SpriteAtlasData_2017_1_2(this AssetDictionary<AssetPair<GUID, long>, SpriteAtlasData_2017_1_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteAtlasData_2017_1_2(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176AE RID: 95918 RVA: 0x0037AE08 File Offset: 0x00379008
		public static YamlNode ExportYamlRelease_Map_Pair_GUID_Int64_SpriteAtlasData_2017_2_0(this AssetDictionary<AssetPair<GUID, long>, SpriteAtlasData_2017_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteAtlasData_2017_2_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176AF RID: 95919 RVA: 0x0037AE48 File Offset: 0x00379048
		public static YamlNode ExportYamlRelease_Map_Pair_GUID_Int64_SpriteAtlasData_2017_2_0_b9(this AssetDictionary<AssetPair<GUID, long>, SpriteAtlasData_2017_2_0_b9> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteAtlasData_2017_2_0_b9(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176B0 RID: 95920 RVA: 0x0037AE88 File Offset: 0x00379088
		public static YamlNode ExportYamlRelease_Map_Pair_GUID_Int64_SpriteAtlasData_2020_2_0(this AssetDictionary<AssetPair<GUID, long>, SpriteAtlasData_2020_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteAtlasData_2020_2_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176B1 RID: 95921 RVA: 0x0037AEC8 File Offset: 0x003790C8
		public static YamlNode ExportYamlRelease_Map_Pair_GUID_Int64_SpriteRenderData_2017_1_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteRenderData_2017_1_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176B2 RID: 95922 RVA: 0x0037AF08 File Offset: 0x00379108
		public static YamlNode ExportYamlRelease_Map_Pair_GUID_Int64_SpriteRenderData_2017_1_0_b4(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2017_1_0_b4> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteRenderData_2017_1_0_b4(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176B3 RID: 95923 RVA: 0x0037AF48 File Offset: 0x00379148
		public static YamlNode ExportYamlRelease_Map_Pair_GUID_Int64_SpriteRenderData_2017_3_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2017_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteRenderData_2017_3_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176B4 RID: 95924 RVA: 0x0037AF88 File Offset: 0x00379188
		public static YamlNode ExportYamlRelease_Map_Pair_GUID_Int64_SpriteRenderData_2018_1_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteRenderData_2018_1_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176B5 RID: 95925 RVA: 0x0037AFC8 File Offset: 0x003791C8
		public static YamlNode ExportYamlRelease_Map_Pair_GUID_Int64_SpriteRenderData_2018_2_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2018_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteRenderData_2018_2_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176B6 RID: 95926 RVA: 0x0037B008 File Offset: 0x00379208
		public static YamlNode ExportYamlRelease_Map_Pair_GUID_Int64_SpriteRenderData_2019_1_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2019_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteRenderData_2019_1_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176B7 RID: 95927 RVA: 0x0037B048 File Offset: 0x00379248
		public static YamlNode ExportYamlRelease_Map_Pair_GUID_Int64_SpriteRenderData_5_0_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteRenderData_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176B8 RID: 95928 RVA: 0x0037B088 File Offset: 0x00379288
		public static YamlNode ExportYamlRelease_Map_Pair_GUID_Int64_SpriteRenderData_5_2_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteRenderData_5_2_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176B9 RID: 95929 RVA: 0x0037B0C8 File Offset: 0x003792C8
		public static YamlNode ExportYamlRelease_Map_Pair_GUID_Int64_SpriteRenderData_5_4_6(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_4_6> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteRenderData_5_4_6(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176BA RID: 95930 RVA: 0x0037B108 File Offset: 0x00379308
		public static YamlNode ExportYamlRelease_Map_Pair_GUID_Int64_SpriteRenderData_5_5_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteRenderData_5_5_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176BB RID: 95931 RVA: 0x0037B148 File Offset: 0x00379348
		public static YamlNode ExportYamlRelease_Map_Pair_GUID_Int64_SpriteRenderData_5_5_3(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_5_3> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteRenderData_5_5_3(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176BC RID: 95932 RVA: 0x0037B188 File Offset: 0x00379388
		public static YamlNode ExportYamlRelease_Map_Pair_GUID_Int64_SpriteRenderData_5_6_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteRenderData_5_6_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176BD RID: 95933 RVA: 0x0037B1C8 File Offset: 0x003793C8
		public static YamlNode ExportYamlRelease_Map_Pair_GUID_Int64_SpriteRenderData_5_6_0_b10(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_6_0_b10> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteRenderData_5_6_0_b10(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176BE RID: 95934 RVA: 0x0037B208 File Offset: 0x00379408
		public static YamlNode ExportYamlRelease_Map_Pair_GUID_Int64_SpriteRenderData_5_6_2(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_6_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteRenderData_5_6_2(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176BF RID: 95935 RVA: 0x0037B248 File Offset: 0x00379448
		public static YamlNode ExportYamlRelease_Map_Pair_UInt16_UInt16_Single(this AssetDictionary<AssetPair<ushort, ushort>, float> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Pair_UInt16_UInt16_Single(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176C0 RID: 95936 RVA: 0x0037B288 File Offset: 0x00379488
		public static YamlNode ExportYamlRelease_Map_Pair_Utf8String_Utf8String_PlatformSettingsData_Plugin(this AssetDictionary<AssetPair<Utf8String, Utf8String>, PlatformSettingsData_Plugin> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Pair_Utf8String_Utf8String_PlatformSettingsData_Plugin(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176C1 RID: 95937 RVA: 0x0037B2C8 File Offset: 0x003794C8
		public static YamlNode ExportYamlRelease_Map_PPtr_AnimatorStateMachine_Array_PPtr_AnimatorTransition(this AssetDictionary<PPtr_AnimatorStateMachine, AssetList<PPtr_AnimatorTransition>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_PPtr_AnimatorStateMachine_Array_PPtr_AnimatorTransition(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176C2 RID: 95938 RVA: 0x0037B308 File Offset: 0x00379508
		public static YamlNode ExportYamlRelease_Map_PPtr_Shader_3_4_0_Utf8String(this AssetDictionary<PPtr_Shader_3_4_0, Utf8String> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_PPtr_Shader_3_4_0_Utf8String(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176C3 RID: 95939 RVA: 0x0037B348 File Offset: 0x00379548
		public static YamlNode ExportYamlRelease_Map_PPtr_Shader_5_0_0_ShaderInfo(this AssetDictionary<PPtr_Shader_5_0_0, ShaderInfo> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_PPtr_Shader_5_0_0_ShaderInfo(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176C4 RID: 95940 RVA: 0x0037B388 File Offset: 0x00379588
		public static YamlNode ExportYamlRelease_Map_PPtr_Shader_5_0_0_Utf8String(this AssetDictionary<PPtr_Shader_5_0_0, Utf8String> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_PPtr_Shader_5_0_0_Utf8String(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176C5 RID: 95941 RVA: 0x0037B3C8 File Offset: 0x003795C8
		public static YamlNode ExportYamlRelease_Map_PPtr_State_Array_PPtr_Transition(this AssetDictionary<PPtr_State, AssetList<PPtr_Transition>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_PPtr_State_Array_PPtr_Transition(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176C6 RID: 95942 RVA: 0x0037B408 File Offset: 0x00379608
		public static YamlNode ExportYamlRelease_Map_PresetType_Array_DefaultPreset_2019_3_0_a10(this AssetDictionary<PresetType, AssetList<DefaultPreset_2019_3_0_a10>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_PresetType_Array_DefaultPreset_2019_3_0_a10(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176C7 RID: 95943 RVA: 0x0037B448 File Offset: 0x00379648
		public static YamlNode ExportYamlRelease_Map_PresetType_Array_DefaultPreset_2020_1_0_a23(this AssetDictionary<PresetType, AssetList<DefaultPreset_2020_1_0_a23>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_PresetType_Array_DefaultPreset_2020_1_0_a23(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176C8 RID: 95944 RVA: 0x0037B488 File Offset: 0x00379688
		public static YamlNode ExportYamlRelease_Map_SceneIdentifier_HierarchicalSceneData(this AssetDictionary<SceneIdentifier, HierarchicalSceneData> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_SceneIdentifier_HierarchicalSceneData(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176C9 RID: 95945 RVA: 0x0037B4C8 File Offset: 0x003796C8
		public static YamlNode ExportYamlRelease_Map_SceneIdentifier_SceneVisibilityData(this AssetDictionary<SceneIdentifier, SceneVisibilityData> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_SceneIdentifier_SceneVisibilityData(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176CA RID: 95946 RVA: 0x0037B508 File Offset: 0x00379708
		public static YamlNode ExportYamlRelease_Map_SourceAssetIdentifier_PPtr_Object_5_0_0(this AssetDictionary<SourceAssetIdentifier, PPtr_Object_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_SourceAssetIdentifier_PPtr_Object_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176CB RID: 95947 RVA: 0x0037B548 File Offset: 0x00379748
		public static YamlNode ExportYamlRelease_Map_StateKey_StateRange(this AssetDictionary<StateKey, StateRange> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_StateKey_StateRange(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176CC RID: 95948 RVA: 0x0037B588 File Offset: 0x00379788
		public static YamlNode ExportYamlRelease_Map_UInt32_Utf8String(this AssetDictionary<uint, Utf8String> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_UInt32_Utf8String(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176CD RID: 95949 RVA: 0x0037B5C8 File Offset: 0x003797C8
		public static YamlNode ExportYamlRelease_Map_Utf8String_Array_Utf8String(this AssetDictionary<Utf8String, AssetList<Utf8String>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Utf8String_Array_Utf8String(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176CE RID: 95950 RVA: 0x0037B608 File Offset: 0x00379808
		public static YamlNode ExportYamlRelease_Map_Utf8String_AssetInfo_3_4_0(this AssetDictionary<Utf8String, AssetInfo_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Utf8String_AssetInfo_3_4_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176CF RID: 95951 RVA: 0x0037B648 File Offset: 0x00379848
		public static YamlNode ExportYamlRelease_Map_Utf8String_AssetInfo_5_0_0(this AssetDictionary<Utf8String, AssetInfo_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Utf8String_AssetInfo_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176D0 RID: 95952 RVA: 0x0037B688 File Offset: 0x00379888
		public static YamlNode ExportYamlRelease_Map_Utf8String_AssetTimeStamp(this AssetDictionary<Utf8String, AssetTimeStamp> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Utf8String_AssetTimeStamp(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176D1 RID: 95953 RVA: 0x0037B6C8 File Offset: 0x003798C8
		public static YamlNode ExportYamlRelease_Map_Utf8String_Boolean(this AssetDictionary<Utf8String, bool> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Utf8String_Boolean(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176D2 RID: 95954 RVA: 0x0037B708 File Offset: 0x00379908
		public static YamlNode ExportYamlRelease_Map_Utf8String_ColorRGBAf_3_5_0(this AssetDictionary<Utf8String, ColorRGBAf_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Utf8String_ColorRGBAf_3_5_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176D3 RID: 95955 RVA: 0x0037B748 File Offset: 0x00379948
		public static YamlNode ExportYamlRelease_Map_Utf8String_ComputeShaderKernel_2020_1_0_a17(this AssetDictionary<Utf8String, ComputeShaderKernel_2020_1_0_a17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Utf8String_ComputeShaderKernel_2020_1_0_a17(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176D4 RID: 95956 RVA: 0x0037B788 File Offset: 0x00379988
		public static YamlNode ExportYamlRelease_Map_Utf8String_ComputeShaderKernel_2020_1_0_a9(this AssetDictionary<Utf8String, ComputeShaderKernel_2020_1_0_a9> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Utf8String_ComputeShaderKernel_2020_1_0_a9(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176D5 RID: 95957 RVA: 0x0037B7C8 File Offset: 0x003799C8
		public static YamlNode ExportYamlRelease_Map_Utf8String_ComputeShaderKernel_2020_2_0_a15(this AssetDictionary<Utf8String, ComputeShaderKernel_2020_2_0_a15> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Utf8String_ComputeShaderKernel_2020_2_0_a15(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176D6 RID: 95958 RVA: 0x0037B808 File Offset: 0x00379A08
		public static YamlNode ExportYamlRelease_Map_Utf8String_ComputeShaderKernel_2020_3_2(this AssetDictionary<Utf8String, ComputeShaderKernel_2020_3_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Utf8String_ComputeShaderKernel_2020_3_2(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176D7 RID: 95959 RVA: 0x0037B848 File Offset: 0x00379A48
		public static YamlNode ExportYamlRelease_Map_Utf8String_ComputeShaderKernel_2021_1_0(this AssetDictionary<Utf8String, ComputeShaderKernel_2021_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Utf8String_ComputeShaderKernel_2021_1_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176D8 RID: 95960 RVA: 0x0037B888 File Offset: 0x00379A88
		public static YamlNode ExportYamlRelease_Map_Utf8String_ComputeShaderKernel_2021_1_0_b7(this AssetDictionary<Utf8String, ComputeShaderKernel_2021_1_0_b7> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Utf8String_ComputeShaderKernel_2021_1_0_b7(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176D9 RID: 95961 RVA: 0x0037B8C8 File Offset: 0x00379AC8
		public static YamlNode ExportYamlRelease_Map_Utf8String_ConfigSetting(this AssetDictionary<Utf8String, ConfigSetting> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Utf8String_ConfigSetting(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176DA RID: 95962 RVA: 0x0037B908 File Offset: 0x00379B08
		public static YamlNode ExportYamlRelease_Map_Utf8String_GUID(this AssetDictionary<Utf8String, GUID> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Utf8String_GUID(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176DB RID: 95963 RVA: 0x0037B948 File Offset: 0x00379B48
		public static YamlNode ExportYamlRelease_Map_Utf8String_Int32(this AssetDictionary<Utf8String, int> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Utf8String_Int32(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176DC RID: 95964 RVA: 0x0037B988 File Offset: 0x00379B88
		public static YamlNode ExportYamlRelease_Map_Utf8String_Int64(this AssetDictionary<Utf8String, long> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Utf8String_Int64(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176DD RID: 95965 RVA: 0x0037B9C8 File Offset: 0x00379BC8
		public static YamlNode ExportYamlRelease_Map_Utf8String_NonAlignedStruct(this AssetDictionary<Utf8String, NonAlignedStruct> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Utf8String_NonAlignedStruct(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176DE RID: 95966 RVA: 0x0037BA08 File Offset: 0x00379C08
		public static YamlNode ExportYamlRelease_Map_Utf8String_PlatformSettingsData_Editor(this AssetDictionary<Utf8String, PlatformSettingsData_Editor> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Utf8String_PlatformSettingsData_Editor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176DF RID: 95967 RVA: 0x0037BA48 File Offset: 0x00379C48
		public static YamlNode ExportYamlRelease_Map_Utf8String_PlatformSettingsData_Plugin(this AssetDictionary<Utf8String, PlatformSettingsData_Plugin> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Utf8String_PlatformSettingsData_Plugin(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176E0 RID: 95968 RVA: 0x0037BA88 File Offset: 0x00379C88
		public static YamlNode ExportYamlRelease_Map_Utf8String_PPtr_Object_3_4_0(this AssetDictionary<Utf8String, PPtr_Object_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Utf8String_PPtr_Object_3_4_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176E1 RID: 95969 RVA: 0x0037BAC8 File Offset: 0x00379CC8
		public static YamlNode ExportYamlRelease_Map_Utf8String_PPtr_Object_5_0_0(this AssetDictionary<Utf8String, PPtr_Object_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Utf8String_PPtr_Object_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176E2 RID: 95970 RVA: 0x0037BB08 File Offset: 0x00379D08
		public static YamlNode ExportYamlRelease_Map_Utf8String_PPtr_Texture_5_0_0(this AssetDictionary<Utf8String, PPtr_Texture_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Utf8String_PPtr_Texture_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176E3 RID: 95971 RVA: 0x0037BB48 File Offset: 0x00379D48
		public static YamlNode ExportYamlRelease_Map_Utf8String_PPtr_Texture2D_3_4_0(this AssetDictionary<Utf8String, PPtr_Texture2D_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Utf8String_PPtr_Texture2D_3_4_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176E4 RID: 95972 RVA: 0x0037BB88 File Offset: 0x00379D88
		public static YamlNode ExportYamlRelease_Map_Utf8String_PPtr_Texture2D_5_0_0(this AssetDictionary<Utf8String, PPtr_Texture2D_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Utf8String_PPtr_Texture2D_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176E5 RID: 95973 RVA: 0x0037BBC8 File Offset: 0x00379DC8
		public static YamlNode ExportYamlRelease_Map_Utf8String_SecondaryTextureSettings_2020_2_0(this AssetDictionary<Utf8String, SecondaryTextureSettings_2020_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Utf8String_SecondaryTextureSettings_2020_2_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176E6 RID: 95974 RVA: 0x0037BC08 File Offset: 0x00379E08
		public static YamlNode ExportYamlRelease_Map_Utf8String_SecondaryTextureSettings_2020_2_0_a12(this AssetDictionary<Utf8String, SecondaryTextureSettings_2020_2_0_a12> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Utf8String_SecondaryTextureSettings_2020_2_0_a12(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176E7 RID: 95975 RVA: 0x0037BC48 File Offset: 0x00379E48
		public static YamlNode ExportYamlRelease_Map_Utf8String_Single(this AssetDictionary<Utf8String, float> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Utf8String_Single(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176E8 RID: 95976 RVA: 0x0037BC88 File Offset: 0x00379E88
		public static YamlNode ExportYamlRelease_Map_Utf8String_UnityTexEnv_5_0_0(this AssetDictionary<Utf8String, UnityTexEnv_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Utf8String_UnityTexEnv_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176E9 RID: 95977 RVA: 0x0037BCC8 File Offset: 0x00379EC8
		public static YamlNode ExportYamlRelease_Map_Utf8String_Utf8String(this AssetDictionary<Utf8String, Utf8String> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Utf8String_Utf8String(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176EA RID: 95978 RVA: 0x0037BD08 File Offset: 0x00379F08
		public static YamlNode ExportYamlRelease_Map_Vector3Int_Tile_2017_2_0(this AssetDictionary<Vector3Int, Tile_2017_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Vector3Int_Tile_2017_2_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176EB RID: 95979 RVA: 0x0037BD48 File Offset: 0x00379F48
		public static YamlNode ExportYamlRelease_Map_Vector3Int_Tile_2017_2_0_b7(this AssetDictionary<Vector3Int, Tile_2017_2_0_b7> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Vector3Int_Tile_2017_2_0_b7(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176EC RID: 95980 RVA: 0x0037BD88 File Offset: 0x00379F88
		public static YamlNode ExportYamlRelease_Map_Vector3Int_Tile_2019_3_0_a12(this AssetDictionary<Vector3Int, Tile_2019_3_0_a12> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Vector3Int_Tile_2019_3_0_a12(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176ED RID: 95981 RVA: 0x0037BDC8 File Offset: 0x00379FC8
		public static YamlNode ExportYamlRelease_Map_Vector3Int_Tile_2019_4_24(this AssetDictionary<Vector3Int, Tile_2019_4_24> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Vector3Int_Tile_2019_4_24(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176EE RID: 95982 RVA: 0x0037BE08 File Offset: 0x0037A008
		public static YamlNode ExportYamlRelease_Map_Vector3Int_Tile_2020_1_0(this AssetDictionary<Vector3Int, Tile_2020_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Vector3Int_Tile_2020_1_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176EF RID: 95983 RVA: 0x0037BE48 File Offset: 0x0037A048
		public static YamlNode ExportYamlRelease_Map_Vector3Int_Tile_2020_1_8(this AssetDictionary<Vector3Int, Tile_2020_1_8> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Vector3Int_Tile_2020_1_8(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176F0 RID: 95984 RVA: 0x0037BE88 File Offset: 0x0037A088
		public static YamlNode ExportYamlRelease_Map_Vector3Int_Tile_2020_2_0(this AssetDictionary<Vector3Int, Tile_2020_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Vector3Int_Tile_2020_2_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176F1 RID: 95985 RVA: 0x0037BEC8 File Offset: 0x0037A0C8
		public static YamlNode ExportYamlRelease_Map_Vector3Int_Tile_2020_2_0_b1(this AssetDictionary<Vector3Int, Tile_2020_2_0_b1> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Vector3Int_Tile_2020_2_0_b1(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176F2 RID: 95986 RVA: 0x0037BF08 File Offset: 0x0037A108
		public static YamlNode ExportYamlRelease_Map_Vector3Int_TileAnimationData_2017_2_0(this AssetDictionary<Vector3Int, TileAnimationData_2017_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Vector3Int_TileAnimationData_2017_2_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176F3 RID: 95987 RVA: 0x0037BF48 File Offset: 0x0037A148
		public static YamlNode ExportYamlRelease_Map_Vector3Int_TileAnimationData_2022_2_0(this AssetDictionary<Vector3Int, TileAnimationData_2022_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlRelease_Pair_Vector3Int_TileAnimationData_2022_2_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060176F4 RID: 95988 RVA: 0x0037BF85 File Offset: 0x0037A185
		public static YamlNode ExportYamlRelease_Pair_AssetImporterHashKey_UInt32(this AccessPairBase<AssetImporterHashKey, uint> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease_UInt32(container));
			return yamlMappingNode;
		}

		// Token: 0x060176F5 RID: 95989 RVA: 0x0037BFC4 File Offset: 0x0037A1C4
		public static YamlNode ExportYamlRelease_Pair_FastPropertyName_ColorRGBAf_3_4_0(this AccessPairBase<FastPropertyName, ColorRGBAf_3_4_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x060176F6 RID: 95990 RVA: 0x0037C003 File Offset: 0x0037A203
		public static YamlNode ExportYamlRelease_Pair_FastPropertyName_ColorRGBAf_3_5_0(this AccessPairBase<FastPropertyName, ColorRGBAf_3_5_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x060176F7 RID: 95991 RVA: 0x0037C042 File Offset: 0x0037A242
		public static YamlNode ExportYamlRelease_Pair_FastPropertyName_Single(this AccessPairBase<FastPropertyName, float> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease_Single(container));
			return yamlMappingNode;
		}

		// Token: 0x060176F8 RID: 95992 RVA: 0x0037C081 File Offset: 0x0037A281
		public static YamlNode ExportYamlRelease_Pair_FastPropertyName_UnityTexEnv_3_4_0(this AccessPairBase<FastPropertyName, UnityTexEnv_3_4_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x060176F9 RID: 95993 RVA: 0x0037C0C0 File Offset: 0x0037A2C0
		public static YamlNode ExportYamlRelease_Pair_FastPropertyName_UnityTexEnv_3_5_0(this AccessPairBase<FastPropertyName, UnityTexEnv_3_5_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x060176FA RID: 95994 RVA: 0x0037C0FF File Offset: 0x0037A2FF
		public static YamlNode ExportYamlRelease_Pair_FastPropertyName_UnityTexEnv_5_0_0(this AccessPairBase<FastPropertyName, UnityTexEnv_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x060176FB RID: 95995 RVA: 0x0037C13E File Offset: 0x0037A33E
		public static YamlNode ExportYamlRelease_Pair_GUID_Asset_2017_1_0(this AccessPairBase<GUID, Asset_2017_1_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x060176FC RID: 95996 RVA: 0x0037C163 File Offset: 0x0037A363
		public static YamlNode ExportYamlRelease_Pair_GUID_Asset_2017_2_5(this AccessPairBase<GUID, Asset_2017_2_5> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x060176FD RID: 95997 RVA: 0x0037C188 File Offset: 0x0037A388
		public static YamlNode ExportYamlRelease_Pair_GUID_Asset_2017_3_0(this AccessPairBase<GUID, Asset_2017_3_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x060176FE RID: 95998 RVA: 0x0037C1AD File Offset: 0x0037A3AD
		public static YamlNode ExportYamlRelease_Pair_GUID_Asset_2017_4_14(this AccessPairBase<GUID, Asset_2017_4_14> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x060176FF RID: 95999 RVA: 0x0037C1D2 File Offset: 0x0037A3D2
		public static YamlNode ExportYamlRelease_Pair_GUID_Asset_2018_1_0(this AccessPairBase<GUID, Asset_2018_1_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017700 RID: 96000 RVA: 0x0037C1F7 File Offset: 0x0037A3F7
		public static YamlNode ExportYamlRelease_Pair_GUID_Asset_2018_1_0_b11(this AccessPairBase<GUID, Asset_2018_1_0_b11> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017701 RID: 96001 RVA: 0x0037C21C File Offset: 0x0037A41C
		public static YamlNode ExportYamlRelease_Pair_GUID_Asset_2018_3_0(this AccessPairBase<GUID, Asset_2018_3_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017702 RID: 96002 RVA: 0x0037C241 File Offset: 0x0037A441
		public static YamlNode ExportYamlRelease_Pair_GUID_Asset_2019_3_0_a8(this AccessPairBase<GUID, Asset_2019_3_0_a8> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017703 RID: 96003 RVA: 0x0037C266 File Offset: 0x0037A466
		public static YamlNode ExportYamlRelease_Pair_GUID_Asset_3_4_0(this AccessPairBase<GUID, Asset_3_4_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017704 RID: 96004 RVA: 0x0037C28B File Offset: 0x0037A48B
		public static YamlNode ExportYamlRelease_Pair_GUID_Asset_3_5_0(this AccessPairBase<GUID, Asset_3_5_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017705 RID: 96005 RVA: 0x0037C2B0 File Offset: 0x0037A4B0
		public static YamlNode ExportYamlRelease_Pair_GUID_Asset_4_0_0(this AccessPairBase<GUID, Asset_4_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017706 RID: 96006 RVA: 0x0037C2D5 File Offset: 0x0037A4D5
		public static YamlNode ExportYamlRelease_Pair_GUID_Asset_4_3_0(this AccessPairBase<GUID, Asset_4_3_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017707 RID: 96007 RVA: 0x0037C2FA File Offset: 0x0037A4FA
		public static YamlNode ExportYamlRelease_Pair_GUID_Asset_5_0_0(this AccessPairBase<GUID, Asset_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017708 RID: 96008 RVA: 0x0037C31F File Offset: 0x0037A51F
		public static YamlNode ExportYamlRelease_Pair_GUID_Asset_5_1_0(this AccessPairBase<GUID, Asset_5_1_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017709 RID: 96009 RVA: 0x0037C344 File Offset: 0x0037A544
		public static YamlNode ExportYamlRelease_Pair_GUID_Asset_5_5_0(this AccessPairBase<GUID, Asset_5_5_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601770A RID: 96010 RVA: 0x0037C369 File Offset: 0x0037A569
		public static YamlNode ExportYamlRelease_Pair_GUID_CachedAssetMetaData_3_4_0(this AccessPairBase<GUID, CachedAssetMetaData_3_4_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601770B RID: 96011 RVA: 0x0037C38E File Offset: 0x0037A58E
		public static YamlNode ExportYamlRelease_Pair_GUID_CachedAssetMetaData_5_0_0(this AccessPairBase<GUID, CachedAssetMetaData_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601770C RID: 96012 RVA: 0x0037C3B3 File Offset: 0x0037A5B3
		public static YamlNode ExportYamlRelease_Pair_GUID_DeletedItem_3_4_0(this AccessPairBase<GUID, DeletedItem_3_4_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601770D RID: 96013 RVA: 0x0037C3D8 File Offset: 0x0037A5D8
		public static YamlNode ExportYamlRelease_Pair_GUID_DeletedItem_5_0_0(this AccessPairBase<GUID, DeletedItem_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601770E RID: 96014 RVA: 0x0037C3FD File Offset: 0x0037A5FD
		public static YamlNode ExportYamlRelease_Pair_GUID_Int32(this AccessPairBase<GUID, int> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease_Int32(container));
			return yamlMappingNode;
		}

		// Token: 0x0601770F RID: 96015 RVA: 0x0037C422 File Offset: 0x0037A622
		public static YamlNode ExportYamlRelease_Pair_GUID_Int64(this AccessPairBase<GUID, long> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease_Int64(container));
			return yamlMappingNode;
		}

		// Token: 0x06017710 RID: 96016 RVA: 0x0037C447 File Offset: 0x0037A647
		public static YamlNode ExportYamlRelease_Pair_GUID_Item(this AccessPairBase<GUID, Item> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017711 RID: 96017 RVA: 0x0037C46C File Offset: 0x0037A66C
		public static YamlNode ExportYamlRelease_Pair_GUID_ModifiedItem_3_4_0(this AccessPairBase<GUID, ModifiedItem_3_4_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017712 RID: 96018 RVA: 0x0037C491 File Offset: 0x0037A691
		public static YamlNode ExportYamlRelease_Pair_GUID_ModifiedItem_5_0_0(this AccessPairBase<GUID, ModifiedItem_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017713 RID: 96019 RVA: 0x0037C4B6 File Offset: 0x0037A6B6
		public static YamlNode ExportYamlRelease_Pair_GUID_PPtr_GameObject_3_4_0(this AccessPairBase<GUID, PPtr_GameObject_3_4_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017714 RID: 96020 RVA: 0x0037C4DB File Offset: 0x0037A6DB
		public static YamlNode ExportYamlRelease_Pair_GUID_PPtr_GameObject_5_0_0(this AccessPairBase<GUID, PPtr_GameObject_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017715 RID: 96021 RVA: 0x0037C500 File Offset: 0x0037A700
		public static YamlNode ExportYamlRelease_Pair_GUID_Utf8String(this AccessPairBase<GUID, Utf8String> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017716 RID: 96022 RVA: 0x0037C525 File Offset: 0x0037A725
		public static YamlNode ExportYamlRelease_Pair_Hash128_Hash128(this AccessPairBase<Hash128, Hash128> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017717 RID: 96023 RVA: 0x0037C564 File Offset: 0x0037A764
		public static YamlNode ExportYamlRelease_Pair_Hash128_Int32(this AccessPairBase<Hash128, int> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease_Int32(container));
			return yamlMappingNode;
		}

		// Token: 0x06017718 RID: 96024 RVA: 0x0037C5A3 File Offset: 0x0037A7A3
		public static YamlNode ExportYamlRelease_Pair_Int32_AssetBundleFullName(this AccessPairBase<int, AssetBundleFullName> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease_Int32(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017719 RID: 96025 RVA: 0x0037C5C8 File Offset: 0x0037A7C8
		public static YamlNode ExportYamlRelease_Pair_Int32_AssetBundleInfo(this AccessPairBase<int, AssetBundleInfo> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease_Int32(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601771A RID: 96026 RVA: 0x0037C5ED File Offset: 0x0037A7ED
		public static YamlNode ExportYamlRelease_Pair_Int32_Hash128(this AccessPairBase<int, Hash128> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease_Int32(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601771B RID: 96027 RVA: 0x0037C612 File Offset: 0x0037A812
		public static YamlNode ExportYamlRelease_Pair_Int32_Int32(this AccessPairBase<int, int> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease_Int32(container), value.Value.ExportYamlRelease_Int32(container));
			return yamlMappingNode;
		}

		// Token: 0x0601771C RID: 96028 RVA: 0x0037C637 File Offset: 0x0037A837
		public static YamlNode ExportYamlRelease_Pair_Int32_Int64(this AccessPairBase<int, long> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease_Int32(container), value.Value.ExportYamlRelease_Int64(container));
			return yamlMappingNode;
		}

		// Token: 0x0601771D RID: 96029 RVA: 0x0037C65C File Offset: 0x0037A85C
		public static YamlNode ExportYamlRelease_Pair_Int32_PPtr_Component_3_4_0(this AccessPairBase<int, PPtr_Component_3_4_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease_Int32(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601771E RID: 96030 RVA: 0x0037C681 File Offset: 0x0037A881
		public static YamlNode ExportYamlRelease_Pair_Int32_PPtr_Component_5_0_0(this AccessPairBase<int, PPtr_Component_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease_Int32(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601771F RID: 96031 RVA: 0x0037C6A6 File Offset: 0x0037A8A6
		public static YamlNode ExportYamlRelease_Pair_Int32_SampleSettings_2022_2_0_a17(this AccessPairBase<int, SampleSettings_2022_2_0_a17> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease_Int32(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017720 RID: 96032 RVA: 0x0037C6CB File Offset: 0x0037A8CB
		public static YamlNode ExportYamlRelease_Pair_Int32_SampleSettings_5_0_0(this AccessPairBase<int, SampleSettings_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease_Int32(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017721 RID: 96033 RVA: 0x0037C6F0 File Offset: 0x0037A8F0
		public static YamlNode ExportYamlRelease_Pair_Int32_Single(this AccessPairBase<int, float> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease_Int32(container), value.Value.ExportYamlRelease_Single(container));
			return yamlMappingNode;
		}

		// Token: 0x06017722 RID: 96034 RVA: 0x0037C715 File Offset: 0x0037A915
		public static YamlNode ExportYamlRelease_Pair_Int32_UInt32(this AccessPairBase<int, uint> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease_Int32(container), value.Value.ExportYamlRelease_UInt32(container));
			return yamlMappingNode;
		}

		// Token: 0x06017723 RID: 96035 RVA: 0x0037C73A File Offset: 0x0037A93A
		public static YamlNode ExportYamlRelease_Pair_Int32_Utf8String(this AccessPairBase<int, Utf8String> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease_Int32(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017724 RID: 96036 RVA: 0x0037C75F File Offset: 0x0037A95F
		public static YamlNode ExportYamlRelease_Pair_Int32_VideoClipImporterTargetSettings(this AccessPairBase<int, VideoClipImporterTargetSettings> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease_Int32(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017725 RID: 96037 RVA: 0x0037C784 File Offset: 0x0037A984
		public static YamlNode ExportYamlRelease_Pair_Int64_Utf8String(this AccessPairBase<long, Utf8String> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease_Int64(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017726 RID: 96038 RVA: 0x0037C7A9 File Offset: 0x0037A9A9
		public static YamlNode ExportYamlRelease_Pair_IntegerString_2017_1_0_PPtr_Object_5_0_0(this AccessPairBase<IntegerString_2017_1_0, PPtr_Object_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017727 RID: 96039 RVA: 0x0037C7E8 File Offset: 0x0037A9E8
		public static YamlNode ExportYamlRelease_Pair_IntegerString_2019_1_0_PPtr_Object_5_0_0(this AccessPairBase<IntegerString_2019_1_0, PPtr_Object_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017728 RID: 96040 RVA: 0x0037C827 File Offset: 0x0037AA27
		public static YamlNode ExportYamlRelease_Pair_IntegerString_2020_1_0_PPtr_Object_5_0_0(this AccessPairBase<IntegerString_2020_1_0, PPtr_Object_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017729 RID: 96041 RVA: 0x0037C866 File Offset: 0x0037AA66
		public static YamlNode ExportYamlRelease_Pair_IntegerString_2020_2_0_PPtr_Object_5_0_0(this AccessPairBase<IntegerString_2020_2_0, PPtr_Object_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601772A RID: 96042 RVA: 0x0037C8A5 File Offset: 0x0037AAA5
		public static YamlNode ExportYamlRelease_Pair_NestedString_2018_4_25_PPtr_Object_5_0_0(this AccessPairBase<NestedString_2018_4_25, PPtr_Object_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601772B RID: 96043 RVA: 0x0037C8E4 File Offset: 0x0037AAE4
		public static YamlNode ExportYamlRelease_Pair_NestedString_2019_4_3_PPtr_Object_5_0_0(this AccessPairBase<NestedString_2019_4_3, PPtr_Object_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601772C RID: 96044 RVA: 0x0037C923 File Offset: 0x0037AB23
		public static YamlNode ExportYamlRelease_Pair_NestedString_2020_1_0_b15_PPtr_Object_5_0_0(this AccessPairBase<NestedString_2020_1_0_b15, PPtr_Object_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601772D RID: 96045 RVA: 0x0037C962 File Offset: 0x0037AB62
		public static YamlNode ExportYamlRelease_Pair_NestedString_2020_2_0_a16_PPtr_Object_5_0_0(this AccessPairBase<NestedString_2020_2_0_a16, PPtr_Object_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601772E RID: 96046 RVA: 0x0037C9A1 File Offset: 0x0037ABA1
		public static YamlNode ExportYamlRelease_Pair_Pair_GUID_Int32_SpriteRenderData_4_3_0(this AccessPairBase<AssetPair<GUID, int>, SpriteRenderData_4_3_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease_Pair_GUID_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601772F RID: 96047 RVA: 0x0037C9E0 File Offset: 0x0037ABE0
		public static YamlNode ExportYamlRelease_Pair_Pair_GUID_Int32_SpriteRenderData_4_5_0(this AccessPairBase<AssetPair<GUID, int>, SpriteRenderData_4_5_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease_Pair_GUID_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017730 RID: 96048 RVA: 0x0037CA1F File Offset: 0x0037AC1F
		public static YamlNode ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteAtlasData_2017_1_0(this AccessPairBase<AssetPair<GUID, long>, SpriteAtlasData_2017_1_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017731 RID: 96049 RVA: 0x0037CA5E File Offset: 0x0037AC5E
		public static YamlNode ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteAtlasData_2017_1_2(this AccessPairBase<AssetPair<GUID, long>, SpriteAtlasData_2017_1_2> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017732 RID: 96050 RVA: 0x0037CA9D File Offset: 0x0037AC9D
		public static YamlNode ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteAtlasData_2017_2_0(this AccessPairBase<AssetPair<GUID, long>, SpriteAtlasData_2017_2_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017733 RID: 96051 RVA: 0x0037CADC File Offset: 0x0037ACDC
		public static YamlNode ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteAtlasData_2017_2_0_b9(this AccessPairBase<AssetPair<GUID, long>, SpriteAtlasData_2017_2_0_b9> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017734 RID: 96052 RVA: 0x0037CB1B File Offset: 0x0037AD1B
		public static YamlNode ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteAtlasData_2020_2_0(this AccessPairBase<AssetPair<GUID, long>, SpriteAtlasData_2020_2_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017735 RID: 96053 RVA: 0x0037CB5A File Offset: 0x0037AD5A
		public static YamlNode ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteRenderData_2017_1_0(this AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_2017_1_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017736 RID: 96054 RVA: 0x0037CB99 File Offset: 0x0037AD99
		public static YamlNode ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteRenderData_2017_1_0_b4(this AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_2017_1_0_b4> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017737 RID: 96055 RVA: 0x0037CBD8 File Offset: 0x0037ADD8
		public static YamlNode ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteRenderData_2017_3_0(this AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_2017_3_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017738 RID: 96056 RVA: 0x0037CC17 File Offset: 0x0037AE17
		public static YamlNode ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteRenderData_2018_1_0(this AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_2018_1_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017739 RID: 96057 RVA: 0x0037CC56 File Offset: 0x0037AE56
		public static YamlNode ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteRenderData_2018_2_0(this AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_2018_2_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601773A RID: 96058 RVA: 0x0037CC95 File Offset: 0x0037AE95
		public static YamlNode ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteRenderData_2019_1_0(this AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_2019_1_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601773B RID: 96059 RVA: 0x0037CCD4 File Offset: 0x0037AED4
		public static YamlNode ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteRenderData_5_0_0(this AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601773C RID: 96060 RVA: 0x0037CD13 File Offset: 0x0037AF13
		public static YamlNode ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteRenderData_5_2_0(this AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_5_2_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601773D RID: 96061 RVA: 0x0037CD52 File Offset: 0x0037AF52
		public static YamlNode ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteRenderData_5_4_6(this AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_5_4_6> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601773E RID: 96062 RVA: 0x0037CD91 File Offset: 0x0037AF91
		public static YamlNode ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteRenderData_5_5_0(this AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_5_5_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601773F RID: 96063 RVA: 0x0037CDD0 File Offset: 0x0037AFD0
		public static YamlNode ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteRenderData_5_5_3(this AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_5_5_3> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017740 RID: 96064 RVA: 0x0037CE0F File Offset: 0x0037B00F
		public static YamlNode ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteRenderData_5_6_0(this AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_5_6_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017741 RID: 96065 RVA: 0x0037CE4E File Offset: 0x0037B04E
		public static YamlNode ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteRenderData_5_6_0_b10(this AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_5_6_0_b10> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017742 RID: 96066 RVA: 0x0037CE8D File Offset: 0x0037B08D
		public static YamlNode ExportYamlRelease_Pair_Pair_GUID_Int64_SpriteRenderData_5_6_2(this AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_5_6_2> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017743 RID: 96067 RVA: 0x0037CECC File Offset: 0x0037B0CC
		public static YamlNode ExportYamlRelease_Pair_Pair_Int32_Int64_Utf8String(this AccessPairBase<AssetPair<int, long>, Utf8String> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease_Pair_Int32_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017744 RID: 96068 RVA: 0x0037CF0B File Offset: 0x0037B10B
		public static YamlNode ExportYamlRelease_Pair_Pair_UInt16_UInt16_Single(this AccessPairBase<AssetPair<ushort, ushort>, float> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease_Pair_UInt16_UInt16(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease_Single(container));
			return yamlMappingNode;
		}

		// Token: 0x06017745 RID: 96069 RVA: 0x0037CF4A File Offset: 0x0037B14A
		public static YamlNode ExportYamlRelease_Pair_Pair_Utf8String_Utf8String_PlatformSettingsData_Plugin(this AccessPairBase<AssetPair<Utf8String, Utf8String>, PlatformSettingsData_Plugin> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease_Pair_Utf8String_Utf8String(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017746 RID: 96070 RVA: 0x0037CF89 File Offset: 0x0037B189
		public static YamlNode ExportYamlRelease_Pair_PPtr_AnimatorStateMachine_Array_PPtr_AnimatorTransition(this AccessPairBase<PPtr_AnimatorStateMachine, AssetList<PPtr_AnimatorTransition>> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease_Array_PPtr_AnimatorTransition(container));
			return yamlMappingNode;
		}

		// Token: 0x06017747 RID: 96071 RVA: 0x0037CFC8 File Offset: 0x0037B1C8
		public static YamlNode ExportYamlRelease_Pair_PPtr_Shader_3_4_0_Utf8String(this AccessPairBase<PPtr_Shader_3_4_0, Utf8String> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017748 RID: 96072 RVA: 0x0037D007 File Offset: 0x0037B207
		public static YamlNode ExportYamlRelease_Pair_PPtr_Shader_5_0_0_ShaderInfo(this AccessPairBase<PPtr_Shader_5_0_0, ShaderInfo> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017749 RID: 96073 RVA: 0x0037D046 File Offset: 0x0037B246
		public static YamlNode ExportYamlRelease_Pair_PPtr_Shader_5_0_0_Utf8String(this AccessPairBase<PPtr_Shader_5_0_0, Utf8String> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601774A RID: 96074 RVA: 0x0037D085 File Offset: 0x0037B285
		public static YamlNode ExportYamlRelease_Pair_PPtr_SphereCollider_PPtr_SphereCollider(this AccessPairBase<PPtr_SphereCollider, PPtr_SphereCollider> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601774B RID: 96075 RVA: 0x0037D0C4 File Offset: 0x0037B2C4
		public static YamlNode ExportYamlRelease_Pair_PPtr_State_Array_PPtr_Transition(this AccessPairBase<PPtr_State, AssetList<PPtr_Transition>> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease_Array_PPtr_Transition(container));
			return yamlMappingNode;
		}

		// Token: 0x0601774C RID: 96076 RVA: 0x0037D103 File Offset: 0x0037B303
		public static YamlNode ExportYamlRelease_Pair_PresetType_Array_DefaultPreset_2019_3_0_a10(this AccessPairBase<PresetType, AssetList<DefaultPreset_2019_3_0_a10>> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease_Array_DefaultPreset_2019_3_0_a10(container));
			return yamlMappingNode;
		}

		// Token: 0x0601774D RID: 96077 RVA: 0x0037D142 File Offset: 0x0037B342
		public static YamlNode ExportYamlRelease_Pair_PresetType_Array_DefaultPreset_2020_1_0_a23(this AccessPairBase<PresetType, AssetList<DefaultPreset_2020_1_0_a23>> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease_Array_DefaultPreset_2020_1_0_a23(container));
			return yamlMappingNode;
		}

		// Token: 0x0601774E RID: 96078 RVA: 0x0037D181 File Offset: 0x0037B381
		public static YamlNode ExportYamlRelease_Pair_SceneIdentifier_HierarchicalSceneData(this AccessPairBase<SceneIdentifier, HierarchicalSceneData> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601774F RID: 96079 RVA: 0x0037D1C0 File Offset: 0x0037B3C0
		public static YamlNode ExportYamlRelease_Pair_SceneIdentifier_SceneVisibilityData(this AccessPairBase<SceneIdentifier, SceneVisibilityData> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017750 RID: 96080 RVA: 0x0037D1FF File Offset: 0x0037B3FF
		public static YamlNode ExportYamlRelease_Pair_SourceAssetIdentifier_PPtr_Object_5_0_0(this AccessPairBase<SourceAssetIdentifier, PPtr_Object_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017751 RID: 96081 RVA: 0x0037D23E File Offset: 0x0037B43E
		public static YamlNode ExportYamlRelease_Pair_StateKey_StateRange(this AccessPairBase<StateKey, StateRange> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017752 RID: 96082 RVA: 0x0037D27D File Offset: 0x0037B47D
		public static YamlNode ExportYamlRelease_Pair_UInt16_UInt16(this AccessPairBase<ushort, ushort> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease_UInt16(container), value.Value.ExportYamlRelease_UInt16(container));
			return yamlMappingNode;
		}

		// Token: 0x06017753 RID: 96083 RVA: 0x0037D2A2 File Offset: 0x0037B4A2
		public static YamlNode ExportYamlRelease_Pair_UInt32_Utf8String(this AccessPairBase<uint, Utf8String> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease_UInt32(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017754 RID: 96084 RVA: 0x0037D2C7 File Offset: 0x0037B4C7
		public static YamlNode ExportYamlRelease_Pair_Utf8String_Array_Utf8String(this AccessPairBase<Utf8String, AssetList<Utf8String>> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease_Array_Utf8String(container));
			return yamlMappingNode;
		}

		// Token: 0x06017755 RID: 96085 RVA: 0x0037D2EC File Offset: 0x0037B4EC
		public static YamlNode ExportYamlRelease_Pair_Utf8String_AssetInfo_3_4_0(this AccessPairBase<Utf8String, AssetInfo_3_4_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017756 RID: 96086 RVA: 0x0037D311 File Offset: 0x0037B511
		public static YamlNode ExportYamlRelease_Pair_Utf8String_AssetInfo_5_0_0(this AccessPairBase<Utf8String, AssetInfo_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017757 RID: 96087 RVA: 0x0037D336 File Offset: 0x0037B536
		public static YamlNode ExportYamlRelease_Pair_Utf8String_AssetTimeStamp(this AccessPairBase<Utf8String, AssetTimeStamp> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017758 RID: 96088 RVA: 0x0037D35B File Offset: 0x0037B55B
		public static YamlNode ExportYamlRelease_Pair_Utf8String_Boolean(this AccessPairBase<Utf8String, bool> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease_Boolean(container));
			return yamlMappingNode;
		}

		// Token: 0x06017759 RID: 96089 RVA: 0x0037D380 File Offset: 0x0037B580
		public static YamlNode ExportYamlRelease_Pair_Utf8String_ColorRGBAf_3_5_0(this AccessPairBase<Utf8String, ColorRGBAf_3_5_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601775A RID: 96090 RVA: 0x0037D3A5 File Offset: 0x0037B5A5
		public static YamlNode ExportYamlRelease_Pair_Utf8String_ComputeShaderKernel_2020_1_0_a17(this AccessPairBase<Utf8String, ComputeShaderKernel_2020_1_0_a17> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601775B RID: 96091 RVA: 0x0037D3CA File Offset: 0x0037B5CA
		public static YamlNode ExportYamlRelease_Pair_Utf8String_ComputeShaderKernel_2020_1_0_a9(this AccessPairBase<Utf8String, ComputeShaderKernel_2020_1_0_a9> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601775C RID: 96092 RVA: 0x0037D3EF File Offset: 0x0037B5EF
		public static YamlNode ExportYamlRelease_Pair_Utf8String_ComputeShaderKernel_2020_2_0_a15(this AccessPairBase<Utf8String, ComputeShaderKernel_2020_2_0_a15> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601775D RID: 96093 RVA: 0x0037D414 File Offset: 0x0037B614
		public static YamlNode ExportYamlRelease_Pair_Utf8String_ComputeShaderKernel_2020_3_2(this AccessPairBase<Utf8String, ComputeShaderKernel_2020_3_2> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601775E RID: 96094 RVA: 0x0037D439 File Offset: 0x0037B639
		public static YamlNode ExportYamlRelease_Pair_Utf8String_ComputeShaderKernel_2021_1_0(this AccessPairBase<Utf8String, ComputeShaderKernel_2021_1_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601775F RID: 96095 RVA: 0x0037D45E File Offset: 0x0037B65E
		public static YamlNode ExportYamlRelease_Pair_Utf8String_ComputeShaderKernel_2021_1_0_b7(this AccessPairBase<Utf8String, ComputeShaderKernel_2021_1_0_b7> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017760 RID: 96096 RVA: 0x0037D483 File Offset: 0x0037B683
		public static YamlNode ExportYamlRelease_Pair_Utf8String_ConfigSetting(this AccessPairBase<Utf8String, ConfigSetting> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017761 RID: 96097 RVA: 0x0037D4A8 File Offset: 0x0037B6A8
		public static YamlNode ExportYamlRelease_Pair_Utf8String_GUID(this AccessPairBase<Utf8String, GUID> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017762 RID: 96098 RVA: 0x0037D4CD File Offset: 0x0037B6CD
		public static YamlNode ExportYamlRelease_Pair_Utf8String_Int32(this AccessPairBase<Utf8String, int> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease_Int32(container));
			return yamlMappingNode;
		}

		// Token: 0x06017763 RID: 96099 RVA: 0x0037D4F2 File Offset: 0x0037B6F2
		public static YamlNode ExportYamlRelease_Pair_Utf8String_Int64(this AccessPairBase<Utf8String, long> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease_Int64(container));
			return yamlMappingNode;
		}

		// Token: 0x06017764 RID: 96100 RVA: 0x0037D517 File Offset: 0x0037B717
		public static YamlNode ExportYamlRelease_Pair_Utf8String_NonAlignedStruct(this AccessPairBase<Utf8String, NonAlignedStruct> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017765 RID: 96101 RVA: 0x0037D53C File Offset: 0x0037B73C
		public static YamlNode ExportYamlRelease_Pair_Utf8String_PlatformSettingsData_Editor(this AccessPairBase<Utf8String, PlatformSettingsData_Editor> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017766 RID: 96102 RVA: 0x0037D561 File Offset: 0x0037B761
		public static YamlNode ExportYamlRelease_Pair_Utf8String_PlatformSettingsData_Plugin(this AccessPairBase<Utf8String, PlatformSettingsData_Plugin> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017767 RID: 96103 RVA: 0x0037D586 File Offset: 0x0037B786
		public static YamlNode ExportYamlRelease_Pair_Utf8String_PPtr_Object_3_4_0(this AccessPairBase<Utf8String, PPtr_Object_3_4_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017768 RID: 96104 RVA: 0x0037D5AB File Offset: 0x0037B7AB
		public static YamlNode ExportYamlRelease_Pair_Utf8String_PPtr_Object_5_0_0(this AccessPairBase<Utf8String, PPtr_Object_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017769 RID: 96105 RVA: 0x0037D5D0 File Offset: 0x0037B7D0
		public static YamlNode ExportYamlRelease_Pair_Utf8String_PPtr_Texture_3_4_0(this AccessPairBase<Utf8String, PPtr_Texture_3_4_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601776A RID: 96106 RVA: 0x0037D5F5 File Offset: 0x0037B7F5
		public static YamlNode ExportYamlRelease_Pair_Utf8String_PPtr_Texture_5_0_0(this AccessPairBase<Utf8String, PPtr_Texture_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601776B RID: 96107 RVA: 0x0037D61A File Offset: 0x0037B81A
		public static YamlNode ExportYamlRelease_Pair_Utf8String_PPtr_Texture2D_3_4_0(this AccessPairBase<Utf8String, PPtr_Texture2D_3_4_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601776C RID: 96108 RVA: 0x0037D63F File Offset: 0x0037B83F
		public static YamlNode ExportYamlRelease_Pair_Utf8String_PPtr_Texture2D_5_0_0(this AccessPairBase<Utf8String, PPtr_Texture2D_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601776D RID: 96109 RVA: 0x0037D664 File Offset: 0x0037B864
		public static YamlNode ExportYamlRelease_Pair_Utf8String_SecondaryTextureSettings_2020_2_0(this AccessPairBase<Utf8String, SecondaryTextureSettings_2020_2_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601776E RID: 96110 RVA: 0x0037D689 File Offset: 0x0037B889
		public static YamlNode ExportYamlRelease_Pair_Utf8String_SecondaryTextureSettings_2020_2_0_a12(this AccessPairBase<Utf8String, SecondaryTextureSettings_2020_2_0_a12> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601776F RID: 96111 RVA: 0x0037D6AE File Offset: 0x0037B8AE
		public static YamlNode ExportYamlRelease_Pair_Utf8String_Single(this AccessPairBase<Utf8String, float> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease_Single(container));
			return yamlMappingNode;
		}

		// Token: 0x06017770 RID: 96112 RVA: 0x0037D6D3 File Offset: 0x0037B8D3
		public static YamlNode ExportYamlRelease_Pair_Utf8String_UInt32(this AccessPairBase<Utf8String, uint> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease_UInt32(container));
			return yamlMappingNode;
		}

		// Token: 0x06017771 RID: 96113 RVA: 0x0037D6F8 File Offset: 0x0037B8F8
		public static YamlNode ExportYamlRelease_Pair_Utf8String_UnityTexEnv_5_0_0(this AccessPairBase<Utf8String, UnityTexEnv_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017772 RID: 96114 RVA: 0x0037D71D File Offset: 0x0037B91D
		public static YamlNode ExportYamlRelease_Pair_Utf8String_Utf8String(this AccessPairBase<Utf8String, Utf8String> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlRelease(container), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017773 RID: 96115 RVA: 0x0037D742 File Offset: 0x0037B942
		public static YamlNode ExportYamlRelease_Pair_Vector3Int_Tile_2017_2_0(this AccessPairBase<Vector3Int, Tile_2017_2_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017774 RID: 96116 RVA: 0x0037D781 File Offset: 0x0037B981
		public static YamlNode ExportYamlRelease_Pair_Vector3Int_Tile_2017_2_0_b7(this AccessPairBase<Vector3Int, Tile_2017_2_0_b7> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017775 RID: 96117 RVA: 0x0037D7C0 File Offset: 0x0037B9C0
		public static YamlNode ExportYamlRelease_Pair_Vector3Int_Tile_2019_3_0_a12(this AccessPairBase<Vector3Int, Tile_2019_3_0_a12> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017776 RID: 96118 RVA: 0x0037D7FF File Offset: 0x0037B9FF
		public static YamlNode ExportYamlRelease_Pair_Vector3Int_Tile_2019_4_24(this AccessPairBase<Vector3Int, Tile_2019_4_24> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017777 RID: 96119 RVA: 0x0037D83E File Offset: 0x0037BA3E
		public static YamlNode ExportYamlRelease_Pair_Vector3Int_Tile_2020_1_0(this AccessPairBase<Vector3Int, Tile_2020_1_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017778 RID: 96120 RVA: 0x0037D87D File Offset: 0x0037BA7D
		public static YamlNode ExportYamlRelease_Pair_Vector3Int_Tile_2020_1_8(this AccessPairBase<Vector3Int, Tile_2020_1_8> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06017779 RID: 96121 RVA: 0x0037D8BC File Offset: 0x0037BABC
		public static YamlNode ExportYamlRelease_Pair_Vector3Int_Tile_2020_2_0(this AccessPairBase<Vector3Int, Tile_2020_2_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601777A RID: 96122 RVA: 0x0037D8FB File Offset: 0x0037BAFB
		public static YamlNode ExportYamlRelease_Pair_Vector3Int_Tile_2020_2_0_b1(this AccessPairBase<Vector3Int, Tile_2020_2_0_b1> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601777B RID: 96123 RVA: 0x0037D93A File Offset: 0x0037BB3A
		public static YamlNode ExportYamlRelease_Pair_Vector3Int_TileAnimationData_2017_2_0(this AccessPairBase<Vector3Int, TileAnimationData_2017_2_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601777C RID: 96124 RVA: 0x0037D979 File Offset: 0x0037BB79
		public static YamlNode ExportYamlRelease_Pair_Vector3Int_TileAnimationData_2022_2_0(this AccessPairBase<Vector3Int, TileAnimationData_2022_2_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0601777D RID: 96125 RVA: 0x0037D9B8 File Offset: 0x0037BBB8
		public static YamlNode ExportYamlRelease_SByte(this sbyte value, IExportContainer container)
		{
			return new YamlScalarNode(value);
		}

		// Token: 0x0601777E RID: 96126 RVA: 0x0037D9C0 File Offset: 0x0037BBC0
		public static YamlNode ExportYamlRelease_Single(this float value, IExportContainer container)
		{
			return new YamlScalarNode(value);
		}

		// Token: 0x0601777F RID: 96127 RVA: 0x0037D9C8 File Offset: 0x0037BBC8
		public static YamlNode ExportYamlRelease_UInt16(this ushort value, IExportContainer container)
		{
			return new YamlScalarNode(value);
		}

		// Token: 0x06017780 RID: 96128 RVA: 0x0037D9D0 File Offset: 0x0037BBD0
		public static YamlNode ExportYamlRelease_UInt32(this uint value, IExportContainer container)
		{
			return new YamlScalarNode(value);
		}

		// Token: 0x06017781 RID: 96129 RVA: 0x0037D9D8 File Offset: 0x0037BBD8
		public static YamlNode ExportYamlRelease_UInt64(this ulong value, IExportContainer container)
		{
			return new YamlScalarNode(value);
		}
	}
}
