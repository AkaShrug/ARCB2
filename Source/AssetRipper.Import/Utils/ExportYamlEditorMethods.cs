using System;
using System.Runtime.CompilerServices;
using AssetRipper.Assets.Export;
using AssetRipper.Assets.Generics;
using AssetRipper.SourceGenerated.Subclasses.AddedComponent;
using AssetRipper.SourceGenerated.Subclasses.AddedGameObject;
using AssetRipper.SourceGenerated.Subclasses.AlbedoSwitchInfo;
using AssetRipper.SourceGenerated.Subclasses.AndroidBanner;
using AssetRipper.SourceGenerated.Subclasses.AnimationClipOverride;
using AssetRipper.SourceGenerated.Subclasses.AnimationEvent;
using AssetRipper.SourceGenerated.Subclasses.AnimatorCondition;
using AssetRipper.SourceGenerated.Subclasses.AnimatorControllerLayer;
using AssetRipper.SourceGenerated.Subclasses.AnimatorControllerParameter;
using AssetRipper.SourceGenerated.Subclasses.Annotation;
using AssetRipper.SourceGenerated.Subclasses.Asset;
using AssetRipper.SourceGenerated.Subclasses.AssetBundleFullName;
using AssetRipper.SourceGenerated.Subclasses.AssetBundleInfo;
using AssetRipper.SourceGenerated.Subclasses.AssetBundleScriptInfo;
using AssetRipper.SourceGenerated.Subclasses.AssetImporterHashKey;
using AssetRipper.SourceGenerated.Subclasses.AssetImporter_ImportError;
using AssetRipper.SourceGenerated.Subclasses.AssetInfo;
using AssetRipper.SourceGenerated.Subclasses.AssetTimeStamp;
using AssetRipper.SourceGenerated.Subclasses.AudioMixerGroupView;
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
using AssetRipper.SourceGenerated.Subclasses.BuildTargetBatching;
using AssetRipper.SourceGenerated.Subclasses.BuildTargetDefaultTextureCompressionFormat;
using AssetRipper.SourceGenerated.Subclasses.BuildTargetEnableVuforia;
using AssetRipper.SourceGenerated.Subclasses.BuildTargetGraphicsAPIs;
using AssetRipper.SourceGenerated.Subclasses.BuildTargetGraphicsJobMode;
using AssetRipper.SourceGenerated.Subclasses.BuildTargetGraphicsJobs;
using AssetRipper.SourceGenerated.Subclasses.BuildTargetGroupHDRCubemapEncodingQuality;
using AssetRipper.SourceGenerated.Subclasses.BuildTargetGroupLightmapEncodingQuality;
using AssetRipper.SourceGenerated.Subclasses.BuildTargetGroupLightmapSettings;
using AssetRipper.SourceGenerated.Subclasses.BuildTargetGroupLoadStoreDebugMode;
using AssetRipper.SourceGenerated.Subclasses.BuildTargetGroupNormalMapEncoding;
using AssetRipper.SourceGenerated.Subclasses.BuildTargetIcons;
using AssetRipper.SourceGenerated.Subclasses.BuildTargetIconsNew;
using AssetRipper.SourceGenerated.Subclasses.BuildTargetSettings_Material;
using AssetRipper.SourceGenerated.Subclasses.BuildTargetShaderSettings;
using AssetRipper.SourceGenerated.Subclasses.BuildTargetVRSettings;
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
using AssetRipper.SourceGenerated.Subclasses.EnlightenRendererInformation;
using AssetRipper.SourceGenerated.Subclasses.EnlightenSystemAtlasInformation;
using AssetRipper.SourceGenerated.Subclasses.EnlightenSystemInformation;
using AssetRipper.SourceGenerated.Subclasses.EnlightenTerrainChunksInformation;
using AssetRipper.SourceGenerated.Subclasses.ExpandedData;
using AssetRipper.SourceGenerated.Subclasses.ExposedAudioParameter;
using AssetRipper.SourceGenerated.Subclasses.Expression;
using AssetRipper.SourceGenerated.Subclasses.ExtensionPropertyValue;
using AssetRipper.SourceGenerated.Subclasses.FastPropertyName;
using AssetRipper.SourceGenerated.Subclasses.FlareElement;
using AssetRipper.SourceGenerated.Subclasses.FloatCurve;
using AssetRipper.SourceGenerated.Subclasses.GenericBinding;
using AssetRipper.SourceGenerated.Subclasses.GUID;
using AssetRipper.SourceGenerated.Subclasses.Handle;
using AssetRipper.SourceGenerated.Subclasses.Hash128;
using AssetRipper.SourceGenerated.Subclasses.HeightmapData;
using AssetRipper.SourceGenerated.Subclasses.HeightMeshBVNode;
using AssetRipper.SourceGenerated.Subclasses.HeightMeshData;
using AssetRipper.SourceGenerated.Subclasses.HierarchicalSceneData;
using AssetRipper.SourceGenerated.Subclasses.HumanBone;
using AssetRipper.SourceGenerated.Subclasses.HumanHandle;
using AssetRipper.SourceGenerated.Subclasses.IconWithSize;
using AssetRipper.SourceGenerated.Subclasses.ImportLog_ImportLogEntry;
using AssetRipper.SourceGenerated.Subclasses.InputAxis;
using AssetRipper.SourceGenerated.Subclasses.InputImportSettings;
using AssetRipper.SourceGenerated.Subclasses.InputImportSettings_SubstanceValue;
using AssetRipper.SourceGenerated.Subclasses.IOSDeviceRequirementForResourceVariant;
using AssetRipper.SourceGenerated.Subclasses.Item;
using AssetRipper.SourceGenerated.Subclasses.Keyframe_Quaternionf;
using AssetRipper.SourceGenerated.Subclasses.Keyframe_Single;
using AssetRipper.SourceGenerated.Subclasses.Keyframe_Vector3f;
using AssetRipper.SourceGenerated.Subclasses.KeywordTargetInfo;
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
using AssetRipper.SourceGenerated.Subclasses.MetroFTAFileType;
using AssetRipper.SourceGenerated.Subclasses.MinMaxAABB;
using AssetRipper.SourceGenerated.Subclasses.MipmapLimitSettings;
using AssetRipper.SourceGenerated.Subclasses.ModifiedItem;
using AssetRipper.SourceGenerated.Subclasses.Module;
using AssetRipper.SourceGenerated.Subclasses.NavMeshAreaData;
using AssetRipper.SourceGenerated.Subclasses.NavMeshBuildSettings;
using AssetRipper.SourceGenerated.Subclasses.NavMeshTileData;
using AssetRipper.SourceGenerated.Subclasses.Node;
using AssetRipper.SourceGenerated.Subclasses.NonAlignedStruct;
using AssetRipper.SourceGenerated.Subclasses.OcclusionScene;
using AssetRipper.SourceGenerated.Subclasses.Parameter;
using AssetRipper.SourceGenerated.Subclasses.ParticleSystemEmissionBurst;
using AssetRipper.SourceGenerated.Subclasses.PerLODSettings;
using AssetRipper.SourceGenerated.Subclasses.PhysicsShape;
using AssetRipper.SourceGenerated.Subclasses.PlatformIcon;
using AssetRipper.SourceGenerated.Subclasses.PlatformMemorySettings;
using AssetRipper.SourceGenerated.Subclasses.PlatformSettingsData_Editor;
using AssetRipper.SourceGenerated.Subclasses.PlatformSettingsData_Plugin;
using AssetRipper.SourceGenerated.Subclasses.PPtrCurve;
using AssetRipper.SourceGenerated.Subclasses.PPtrKeyframe;
using AssetRipper.SourceGenerated.Subclasses.PPtr_AnimationClip;
using AssetRipper.SourceGenerated.Subclasses.PPtr_AnimatorStateMachine;
using AssetRipper.SourceGenerated.Subclasses.PPtr_AnimatorStateTransition;
using AssetRipper.SourceGenerated.Subclasses.PPtr_AnimatorTransition;
using AssetRipper.SourceGenerated.Subclasses.PPtr_AudioMixerEffectController;
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
using AssetRipper.SourceGenerated.Subclasses.PPtr_SpriteAtlas;
using AssetRipper.SourceGenerated.Subclasses.PPtr_State;
using AssetRipper.SourceGenerated.Subclasses.PPtr_StateMachine;
using AssetRipper.SourceGenerated.Subclasses.PPtr_TerrainLayer;
using AssetRipper.SourceGenerated.Subclasses.PPtr_TextAsset;
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
using AssetRipper.SourceGenerated.Subclasses.SamplerParameter;
using AssetRipper.SourceGenerated.Subclasses.SampleSettings;
using AssetRipper.SourceGenerated.Subclasses.Scene;
using AssetRipper.SourceGenerated.Subclasses.SceneIdentifier;
using AssetRipper.SourceGenerated.Subclasses.SceneObjectIdentifier;
using AssetRipper.SourceGenerated.Subclasses.SceneVisibilityData;
using AssetRipper.SourceGenerated.Subclasses.SecondarySpriteTexture;
using AssetRipper.SourceGenerated.Subclasses.SecondaryTextureSettings;
using AssetRipper.SourceGenerated.Subclasses.SerializedCustomEditorForRenderPipeline;
using AssetRipper.SourceGenerated.Subclasses.SerializedPackageRequirement;
using AssetRipper.SourceGenerated.Subclasses.SerializedPass;
using AssetRipper.SourceGenerated.Subclasses.SerializedPlayerSubProgram;
using AssetRipper.SourceGenerated.Subclasses.SerializedProperty;
using AssetRipper.SourceGenerated.Subclasses.SerializedShaderDependency;
using AssetRipper.SourceGenerated.Subclasses.SerializedSubProgram;
using AssetRipper.SourceGenerated.Subclasses.SerializedSubShader;
using AssetRipper.SourceGenerated.Subclasses.ShaderBindChannel;
using AssetRipper.SourceGenerated.Subclasses.ShaderError;
using AssetRipper.SourceGenerated.Subclasses.ShaderInfo;
using AssetRipper.SourceGenerated.Subclasses.ShaderSnippet;
using AssetRipper.SourceGenerated.Subclasses.SkeletonBone;
using AssetRipper.SourceGenerated.Subclasses.SketchUpImportScene;
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
using AssetRipper.SourceGenerated.Subclasses.StateBehavioursPair;
using AssetRipper.SourceGenerated.Subclasses.StateMotionPair;
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
using AssetRipper.SourceGenerated.Subclasses.TierSettings;
using AssetRipper.SourceGenerated.Subclasses.Tile;
using AssetRipper.SourceGenerated.Subclasses.TileAnimationData;
using AssetRipper.SourceGenerated.Subclasses.TilemapRefCountedData_ColorRGBAf;
using AssetRipper.SourceGenerated.Subclasses.TilemapRefCountedData_Matrix4x4f;
using AssetRipper.SourceGenerated.Subclasses.TilemapRefCountedData_PPtr_GameObject;
using AssetRipper.SourceGenerated.Subclasses.TilemapRefCountedData_PPtr_Object;
using AssetRipper.SourceGenerated.Subclasses.TilemapRefCountedData_PPtr_Sprite;
using AssetRipper.SourceGenerated.Subclasses.TilemapTileDirtyData;
using AssetRipper.SourceGenerated.Subclasses.TransformMaskElement;
using AssetRipper.SourceGenerated.Subclasses.TreeInstance;
using AssetRipper.SourceGenerated.Subclasses.TreePrototype;
using AssetRipper.SourceGenerated.Subclasses.UAVParameter;
using AssetRipper.SourceGenerated.Subclasses.UnityTexEnv;
using AssetRipper.SourceGenerated.Subclasses.UpdateZoneInfo;
using AssetRipper.SourceGenerated.Subclasses.Utf8String;
using AssetRipper.SourceGenerated.Subclasses.VariantInfo;
using AssetRipper.SourceGenerated.Subclasses.Vector2f;
using AssetRipper.SourceGenerated.Subclasses.Vector2Int;
using AssetRipper.SourceGenerated.Subclasses.Vector2Long;
using AssetRipper.SourceGenerated.Subclasses.Vector3Curve;
using AssetRipper.SourceGenerated.Subclasses.Vector3f;
using AssetRipper.SourceGenerated.Subclasses.Vector3Int;
using AssetRipper.SourceGenerated.Subclasses.Vector4f;
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
using AssetRipper.SourceGenerated.Subclasses.XboxOneSocketDefinition;
using AssetRipper.SourceGenerated.Subclasses.Xform;
using AssetRipper.Yaml;
using AssetRipper.Yaml.Extensions;
using AssetRipper.Import.GICB2.PPtr_AnimationClip;
using AssetRipper.Import.GICB2.TerrainData.SplatPrototype;

namespace AssetRipper.SourceGenerated.Helpers
{
	// Token: 0x02001C22 RID: 7202


	internal static class ExportYamlEditorMethods
	{
		// Token: 0x06016FCB RID: 94155 RVA: 0x00360458 File Offset: 0x0035E658
		public static YamlNode ExportYamlEditor_Array_AddedComponent(this AssetList<AddedComponent> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FCC RID: 94156 RVA: 0x00360498 File Offset: 0x0035E698
		public static YamlNode ExportYamlEditor_Array_AddedGameObject(this AssetList<AddedGameObject> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FCD RID: 94157 RVA: 0x003604D8 File Offset: 0x0035E6D8
		public static YamlNode ExportYamlEditor_Array_AlbedoSwitchInfo(this AssetList<AlbedoSwitchInfo> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FCE RID: 94158 RVA: 0x00360518 File Offset: 0x0035E718
		public static YamlNode ExportYamlEditor_Array_AndroidBanner(this AssetList<AndroidBanner> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FCF RID: 94159 RVA: 0x00360558 File Offset: 0x0035E758
		public static YamlNode ExportYamlEditor_Array_AnimationClipOverride_4_3_0(this AssetList<AnimationClipOverride_4_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FD0 RID: 94160 RVA: 0x00360598 File Offset: 0x0035E798
		public static YamlNode ExportYamlEditor_Array_AnimationClipOverride_5_0_0(this AssetList<AnimationClipOverride_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FD1 RID: 94161 RVA: 0x003605D8 File Offset: 0x0035E7D8
		public static YamlNode ExportYamlEditor_Array_AnimationEvent_3_4_0(this AssetList<AnimationEvent_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FD2 RID: 94162 RVA: 0x00360618 File Offset: 0x0035E818
		public static YamlNode ExportYamlEditor_Array_AnimationEvent_5_0_0(this AssetList<AnimationEvent_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FD3 RID: 94163 RVA: 0x00360658 File Offset: 0x0035E858
		public static YamlNode ExportYamlEditor_Array_AnimatorCondition_4_0_0(this AssetList<AnimatorCondition_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FD4 RID: 94164 RVA: 0x00360698 File Offset: 0x0035E898
		public static YamlNode ExportYamlEditor_Array_AnimatorCondition_5_0_0(this AssetList<AnimatorCondition_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FD5 RID: 94165 RVA: 0x003606D8 File Offset: 0x0035E8D8
		public static YamlNode ExportYamlEditor_Array_AnimatorControllerLayer_2017_1_0(this AssetList<AnimatorControllerLayer_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FD6 RID: 94166 RVA: 0x00360718 File Offset: 0x0035E918
		public static YamlNode ExportYamlEditor_Array_AnimatorControllerLayer_4_0_0(this AssetList<AnimatorControllerLayer_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FD7 RID: 94167 RVA: 0x00360758 File Offset: 0x0035E958
		public static YamlNode ExportYamlEditor_Array_AnimatorControllerLayer_4_1_0(this AssetList<AnimatorControllerLayer_4_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FD8 RID: 94168 RVA: 0x00360798 File Offset: 0x0035E998
		public static YamlNode ExportYamlEditor_Array_AnimatorControllerLayer_4_2_0(this AssetList<AnimatorControllerLayer_4_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FD9 RID: 94169 RVA: 0x003607D8 File Offset: 0x0035E9D8
		public static YamlNode ExportYamlEditor_Array_AnimatorControllerLayer_5_0_0(this AssetList<AnimatorControllerLayer_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FDA RID: 94170 RVA: 0x00360818 File Offset: 0x0035EA18
		public static YamlNode ExportYamlEditor_Array_AnimatorControllerLayer_5_2_0(this AssetList<AnimatorControllerLayer_5_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FDB RID: 94171 RVA: 0x00360858 File Offset: 0x0035EA58
		public static YamlNode ExportYamlEditor_Array_AnimatorControllerParameter_4_0_0(this AssetList<AnimatorControllerParameter_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FDC RID: 94172 RVA: 0x00360898 File Offset: 0x0035EA98
		public static YamlNode ExportYamlEditor_Array_AnimatorControllerParameter_4_2_0(this AssetList<AnimatorControllerParameter_4_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FDD RID: 94173 RVA: 0x003608D8 File Offset: 0x0035EAD8
		public static YamlNode ExportYamlEditor_Array_AnimatorControllerParameter_4_3_0(this AssetList<AnimatorControllerParameter_4_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FDE RID: 94174 RVA: 0x00360918 File Offset: 0x0035EB18
		public static YamlNode ExportYamlEditor_Array_AnimatorControllerParameter_5_0_0(this AssetList<AnimatorControllerParameter_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FDF RID: 94175 RVA: 0x00360958 File Offset: 0x0035EB58
		public static YamlNode ExportYamlEditor_Array_Annotation_3_4_0(this AssetList<Annotation_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FE0 RID: 94176 RVA: 0x00360998 File Offset: 0x0035EB98
		public static YamlNode ExportYamlEditor_Array_Annotation_5_6_0(this AssetList<Annotation_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FE1 RID: 94177 RVA: 0x003609D8 File Offset: 0x0035EBD8
		public static YamlNode ExportYamlEditor_Array_Array_Pair_Utf8String_Utf8String(this AssetList<AssetList<AssetPair<Utf8String, Utf8String>>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor_Array_Pair_Utf8String_Utf8String(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FE2 RID: 94178 RVA: 0x00360A18 File Offset: 0x0035EC18
		public static YamlNode ExportYamlEditor_Array_Array_SerializedPlayerSubProgram_2021_3_10(this AssetList<AssetList<SerializedPlayerSubProgram_2021_3_10>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor_Array_SerializedPlayerSubProgram_2021_3_10(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FE3 RID: 94179 RVA: 0x00360A58 File Offset: 0x0035EC58
		public static YamlNode ExportYamlEditor_Array_Array_SerializedPlayerSubProgram_2022_1_13(this AssetList<AssetList<SerializedPlayerSubProgram_2022_1_13>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor_Array_SerializedPlayerSubProgram_2022_1_13(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FE4 RID: 94180 RVA: 0x00360A98 File Offset: 0x0035EC98
		public static YamlNode ExportYamlEditor_Array_Array_SerializedPlayerSubProgram_2022_2_0_b5(this AssetList<AssetList<SerializedPlayerSubProgram_2022_2_0_b5>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor_Array_SerializedPlayerSubProgram_2022_2_0_b5(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FE5 RID: 94181 RVA: 0x00360AD8 File Offset: 0x0035ECD8
		public static YamlNode ExportYamlEditor_Array_Array_UInt32(this uint[][] value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int num = value.Length;
			for (int i = 0; i < num; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor_Array_UInt32(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FE6 RID: 94182 RVA: 0x00360B10 File Offset: 0x0035ED10
		public static YamlNode ExportYamlEditor_Array_Array_Utf8String(this AssetList<AssetList<Utf8String>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor_Array_Utf8String(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FE7 RID: 94183 RVA: 0x00360B50 File Offset: 0x0035ED50
		public static YamlNode ExportYamlEditor_Array_Array_Vector2f_3_5_0(this AssetList<AssetList<Vector2f_3_5_0>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor_Array_Vector2f_3_5_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FE8 RID: 94184 RVA: 0x00360B90 File Offset: 0x0035ED90
		public static YamlNode ExportYamlEditor_Array_Array_Vector2Long(this AssetList<AssetList<Vector2Long>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor_Array_Vector2Long(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FE9 RID: 94185 RVA: 0x00360BD0 File Offset: 0x0035EDD0
		public static YamlNode ExportYamlEditor_Array_AssetBundleScriptInfo(this AssetList<AssetBundleScriptInfo> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FEA RID: 94186 RVA: 0x00360C10 File Offset: 0x0035EE10
		public static YamlNode ExportYamlEditor_Array_AssetImporter_ImportError(this AssetList<AssetImporter_ImportError> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FEB RID: 94187 RVA: 0x00360C50 File Offset: 0x0035EE50
		public static YamlNode ExportYamlEditor_Array_AudioMixerGroupView_2017_1_0(this AssetList<AudioMixerGroupView_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FEC RID: 94188 RVA: 0x00360C90 File Offset: 0x0035EE90
		public static YamlNode ExportYamlEditor_Array_AudioMixerGroupView_5_0_0(this AssetList<AudioMixerGroupView_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FED RID: 94189 RVA: 0x00360CD0 File Offset: 0x0035EED0
		public static YamlNode ExportYamlEditor_Array_AutoOffMeshLinkData(this AssetList<AutoOffMeshLinkData> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FEE RID: 94190 RVA: 0x00360D10 File Offset: 0x0035EF10
		public static YamlNode ExportYamlEditor_Array_AvatarSkeletonMaskElement(this AssetList<AvatarSkeletonMaskElement> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FEF RID: 94191 RVA: 0x00360D50 File Offset: 0x0035EF50
		public static YamlNode ExportYamlEditor_Array_Axes_4_0_0(this AssetList<Axes_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FF0 RID: 94192 RVA: 0x00360D90 File Offset: 0x0035EF90
		public static YamlNode ExportYamlEditor_Array_Axes_5_4_0(this AssetList<Axes_5_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FF1 RID: 94193 RVA: 0x00360DD0 File Offset: 0x0035EFD0
		public static YamlNode ExportYamlEditor_Array_Axes_5_5_0(this AssetList<Axes_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FF2 RID: 94194 RVA: 0x00360E10 File Offset: 0x0035F010
		public static YamlNode ExportYamlEditor_Array_BlendShapeVertex(this AssetList<BlendShapeVertex> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FF3 RID: 94195 RVA: 0x00360E50 File Offset: 0x0035F050
		public static YamlNode ExportYamlEditor_Array_BoneWeights4_2017_1_0(this AssetList<BoneWeights4_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FF4 RID: 94196 RVA: 0x00360E90 File Offset: 0x0035F090
		public static YamlNode ExportYamlEditor_Array_BoneWeights4_3_4_0(this AssetList<BoneWeights4_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FF5 RID: 94197 RVA: 0x00360ED0 File Offset: 0x0035F0D0
		public static YamlNode ExportYamlEditor_Array_Boolean(this bool[] value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int num = value.Length;
			for (int i = 0; i < num; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor_Boolean(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FF6 RID: 94198 RVA: 0x00360F08 File Offset: 0x0035F108
		public static YamlNode ExportYamlEditor_Array_BufferBinding_2020_1_0_a17(this AssetList<BufferBinding_2020_1_0_a17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FF7 RID: 94199 RVA: 0x00360F48 File Offset: 0x0035F148
		public static YamlNode ExportYamlEditor_Array_BufferBinding_5_5_0(this AssetList<BufferBinding_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FF8 RID: 94200 RVA: 0x00360F88 File Offset: 0x0035F188
		public static YamlNode ExportYamlEditor_Array_BuildReportFile(this AssetList<BuildReportFile> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FF9 RID: 94201 RVA: 0x00360FC8 File Offset: 0x0035F1C8
		public static YamlNode ExportYamlEditor_Array_BuildReportPackedAssetInfo_2019_3_0_a8(this AssetList<BuildReportPackedAssetInfo_2019_3_0_a8> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FFA RID: 94202 RVA: 0x00361008 File Offset: 0x0035F208
		public static YamlNode ExportYamlEditor_Array_BuildReportPackedAssetInfo_5_4_0(this AssetList<BuildReportPackedAssetInfo_5_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FFB RID: 94203 RVA: 0x00361048 File Offset: 0x0035F248
		public static YamlNode ExportYamlEditor_Array_BuildReportPackedAssetInfo_5_4_2(this AssetList<BuildReportPackedAssetInfo_5_4_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FFC RID: 94204 RVA: 0x00361088 File Offset: 0x0035F288
		public static YamlNode ExportYamlEditor_Array_BuildReportPackedAssetInfo_5_5_0(this AssetList<BuildReportPackedAssetInfo_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FFD RID: 94205 RVA: 0x003610C8 File Offset: 0x0035F2C8
		public static YamlNode ExportYamlEditor_Array_BuildReportScenesUsingAsset(this AssetList<BuildReportScenesUsingAsset> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FFE RID: 94206 RVA: 0x00361108 File Offset: 0x0035F308
		public static YamlNode ExportYamlEditor_Array_BuildStepInfo_2017_1_0(this AssetList<BuildStepInfo_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06016FFF RID: 94207 RVA: 0x00361148 File Offset: 0x0035F348
		public static YamlNode ExportYamlEditor_Array_BuildStepInfo_2018_1_0(this AssetList<BuildStepInfo_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017000 RID: 94208 RVA: 0x00361188 File Offset: 0x0035F388
		public static YamlNode ExportYamlEditor_Array_BuildStepInfo_5_4_0(this AssetList<BuildStepInfo_5_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017001 RID: 94209 RVA: 0x003611C8 File Offset: 0x0035F3C8
		public static YamlNode ExportYamlEditor_Array_BuildStepMessage(this AssetList<BuildStepMessage> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017002 RID: 94210 RVA: 0x00361208 File Offset: 0x0035F408
		public static YamlNode ExportYamlEditor_Array_BuildTargetBatching(this AssetList<BuildTargetBatching> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017003 RID: 94211 RVA: 0x00361248 File Offset: 0x0035F448
		public static YamlNode ExportYamlEditor_Array_BuildTargetDefaultTextureCompressionFormat(this AssetList<BuildTargetDefaultTextureCompressionFormat> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017004 RID: 94212 RVA: 0x00361288 File Offset: 0x0035F488
		public static YamlNode ExportYamlEditor_Array_BuildTargetEnableVuforia_2017_2_0(this AssetList<BuildTargetEnableVuforia_2017_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017005 RID: 94213 RVA: 0x003612C8 File Offset: 0x0035F4C8
		public static YamlNode ExportYamlEditor_Array_BuildTargetEnableVuforia_2019_3_0(this AssetList<BuildTargetEnableVuforia_2019_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017006 RID: 94214 RVA: 0x00361308 File Offset: 0x0035F508
		public static YamlNode ExportYamlEditor_Array_BuildTargetGraphicsAPIs_2017_1_0(this AssetList<BuildTargetGraphicsAPIs_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017007 RID: 94215 RVA: 0x00361348 File Offset: 0x0035F548
		public static YamlNode ExportYamlEditor_Array_BuildTargetGraphicsAPIs_5_1_0(this AssetList<BuildTargetGraphicsAPIs_5_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017008 RID: 94216 RVA: 0x00361388 File Offset: 0x0035F588
		public static YamlNode ExportYamlEditor_Array_BuildTargetGraphicsJobMode(this AssetList<BuildTargetGraphicsJobMode> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017009 RID: 94217 RVA: 0x003613C8 File Offset: 0x0035F5C8
		public static YamlNode ExportYamlEditor_Array_BuildTargetGraphicsJobs(this AssetList<BuildTargetGraphicsJobs> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601700A RID: 94218 RVA: 0x00361408 File Offset: 0x0035F608
		public static YamlNode ExportYamlEditor_Array_BuildTargetGroupHDRCubemapEncodingQuality(this AssetList<BuildTargetGroupHDRCubemapEncodingQuality> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601700B RID: 94219 RVA: 0x00361448 File Offset: 0x0035F648
		public static YamlNode ExportYamlEditor_Array_BuildTargetGroupLightmapEncodingQuality(this AssetList<BuildTargetGroupLightmapEncodingQuality> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601700C RID: 94220 RVA: 0x00361488 File Offset: 0x0035F688
		public static YamlNode ExportYamlEditor_Array_BuildTargetGroupLightmapSettings(this AssetList<BuildTargetGroupLightmapSettings> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601700D RID: 94221 RVA: 0x003614C8 File Offset: 0x0035F6C8
		public static YamlNode ExportYamlEditor_Array_BuildTargetGroupLoadStoreDebugMode(this AssetList<BuildTargetGroupLoadStoreDebugMode> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601700E RID: 94222 RVA: 0x00361508 File Offset: 0x0035F708
		public static YamlNode ExportYamlEditor_Array_BuildTargetGroupNormalMapEncoding(this AssetList<BuildTargetGroupNormalMapEncoding> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601700F RID: 94223 RVA: 0x00361548 File Offset: 0x0035F748
		public static YamlNode ExportYamlEditor_Array_BuildTargetIcons_2017_1_0(this AssetList<BuildTargetIcons_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017010 RID: 94224 RVA: 0x00361588 File Offset: 0x0035F788
		public static YamlNode ExportYamlEditor_Array_BuildTargetIcons_2017_1_2(this AssetList<BuildTargetIcons_2017_1_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017011 RID: 94225 RVA: 0x003615C8 File Offset: 0x0035F7C8
		public static YamlNode ExportYamlEditor_Array_BuildTargetIcons_2017_2_0(this AssetList<BuildTargetIcons_2017_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017012 RID: 94226 RVA: 0x00361608 File Offset: 0x0035F808
		public static YamlNode ExportYamlEditor_Array_BuildTargetIcons_2017_2_0_b9(this AssetList<BuildTargetIcons_2017_2_0_b9> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017013 RID: 94227 RVA: 0x00361648 File Offset: 0x0035F848
		public static YamlNode ExportYamlEditor_Array_BuildTargetIcons_3_4_0(this AssetList<BuildTargetIcons_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017014 RID: 94228 RVA: 0x00361688 File Offset: 0x0035F888
		public static YamlNode ExportYamlEditor_Array_BuildTargetIcons_5_0_0(this AssetList<BuildTargetIcons_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017015 RID: 94229 RVA: 0x003616C8 File Offset: 0x0035F8C8
		public static YamlNode ExportYamlEditor_Array_BuildTargetIcons_5_2_2(this AssetList<BuildTargetIcons_5_2_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017016 RID: 94230 RVA: 0x00361708 File Offset: 0x0035F908
		public static YamlNode ExportYamlEditor_Array_BuildTargetIcons_5_6_4(this AssetList<BuildTargetIcons_5_6_4> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017017 RID: 94231 RVA: 0x00361748 File Offset: 0x0035F948
		public static YamlNode ExportYamlEditor_Array_BuildTargetIconsNew(this AssetList<BuildTargetIconsNew> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017018 RID: 94232 RVA: 0x00361788 File Offset: 0x0035F988
		public static YamlNode ExportYamlEditor_Array_BuildTargetSettings_Material_3_5_0(this AssetList<BuildTargetSettings_Material_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017019 RID: 94233 RVA: 0x003617C8 File Offset: 0x0035F9C8
		public static YamlNode ExportYamlEditor_Array_BuildTargetSettings_Material_4_0_0(this AssetList<BuildTargetSettings_Material_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601701A RID: 94234 RVA: 0x00361808 File Offset: 0x0035FA08
		public static YamlNode ExportYamlEditor_Array_BuildTargetShaderSettings_2021_3_12(this AssetList<BuildTargetShaderSettings_2021_3_12> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601701B RID: 94235 RVA: 0x00361848 File Offset: 0x0035FA48
		public static YamlNode ExportYamlEditor_Array_BuildTargetShaderSettings_2022_1_21(this AssetList<BuildTargetShaderSettings_2022_1_21> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601701C RID: 94236 RVA: 0x00361888 File Offset: 0x0035FA88
		public static YamlNode ExportYamlEditor_Array_BuildTargetShaderSettings_2022_2_0_b10(this AssetList<BuildTargetShaderSettings_2022_2_0_b10> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601701D RID: 94237 RVA: 0x003618C8 File Offset: 0x0035FAC8
		public static YamlNode ExportYamlEditor_Array_BuildTargetVRSettings_2017_1_0(this AssetList<BuildTargetVRSettings_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601701E RID: 94238 RVA: 0x00361908 File Offset: 0x0035FB08
		public static YamlNode ExportYamlEditor_Array_BuildTargetVRSettings_5_5_0(this AssetList<BuildTargetVRSettings_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601701F RID: 94239 RVA: 0x00361948 File Offset: 0x0035FB48
		public static YamlNode ExportYamlEditor_Array_BuildTextureStackReference(this AssetList<BuildTextureStackReference> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017020 RID: 94240 RVA: 0x00361988 File Offset: 0x0035FB88
		public static YamlNode ExportYamlEditor_Array_BuiltAssetBundleInfo_2017_1_0_b4(this AssetList<BuiltAssetBundleInfo_2017_1_0_b4> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017021 RID: 94241 RVA: 0x003619C8 File Offset: 0x0035FBC8
		public static YamlNode ExportYamlEditor_Array_BuiltAssetBundleInfo_5_5_4(this AssetList<BuiltAssetBundleInfo_5_5_4> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017022 RID: 94242 RVA: 0x00361A08 File Offset: 0x0035FC08
		public static YamlNode ExportYamlEditor_Array_BuiltAssetBundleInfo_5_6_2(this AssetList<BuiltAssetBundleInfo_5_6_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017023 RID: 94243 RVA: 0x00361A45 File Offset: 0x0035FC45
		public static YamlNode ExportYamlEditor_Array_Byte(this byte[] value, IExportContainer container)
		{
			return YamlArrayExtensions.ExportYaml(value);
		}

		// Token: 0x06017024 RID: 94244 RVA: 0x00361A50 File Offset: 0x0035FC50
		public static YamlNode ExportYamlEditor_Array_Channel_2017_1_0(this AssetList<Channel_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017025 RID: 94245 RVA: 0x00361A90 File Offset: 0x0035FC90
		public static YamlNode ExportYamlEditor_Array_Channel_2018_1_0(this AssetList<Channel_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017026 RID: 94246 RVA: 0x00361AD0 File Offset: 0x0035FCD0
		public static YamlNode ExportYamlEditor_Array_Channel_3_4_0(this AssetList<Channel_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017027 RID: 94247 RVA: 0x00361B10 File Offset: 0x0035FD10
		public static YamlNode ExportYamlEditor_Array_Channel_5_3_0(this AssetList<Channel_5_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017028 RID: 94248 RVA: 0x00361B50 File Offset: 0x0035FD50
		public static YamlNode ExportYamlEditor_Array_Channel_5_5_0(this AssetList<Channel_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017029 RID: 94249 RVA: 0x00361B90 File Offset: 0x0035FD90
		public static YamlNode ExportYamlEditor_Array_ChannelInfo(this AssetList<ChannelInfo> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601702A RID: 94250 RVA: 0x00361BD0 File Offset: 0x0035FDD0
		public static YamlNode ExportYamlEditor_Array_CharacterInfo_3_4_0(this AssetList<CharacterInfo_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601702B RID: 94251 RVA: 0x00361C10 File Offset: 0x0035FE10
		public static YamlNode ExportYamlEditor_Array_CharacterInfo_4_0_0(this AssetList<CharacterInfo_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601702C RID: 94252 RVA: 0x00361C50 File Offset: 0x0035FE50
		public static YamlNode ExportYamlEditor_Array_CharacterInfo_5_3_0(this AssetList<CharacterInfo_5_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601702D RID: 94253 RVA: 0x00361C90 File Offset: 0x0035FE90
		public static YamlNode ExportYamlEditor_Array_ChildAnimatorState(this AssetList<ChildAnimatorState> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601702E RID: 94254 RVA: 0x00361CD0 File Offset: 0x0035FED0
		public static YamlNode ExportYamlEditor_Array_ChildAnimatorStateMachine(this AssetList<ChildAnimatorStateMachine> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601702F RID: 94255 RVA: 0x00361D10 File Offset: 0x0035FF10
		public static YamlNode ExportYamlEditor_Array_ChildMotion_4_0_0(this AssetList<ChildMotion_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017030 RID: 94256 RVA: 0x00361D50 File Offset: 0x0035FF50
		public static YamlNode ExportYamlEditor_Array_ChildMotion_4_1_0(this AssetList<ChildMotion_4_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017031 RID: 94257 RVA: 0x00361D90 File Offset: 0x0035FF90
		public static YamlNode ExportYamlEditor_Array_ChildMotion_5_0_0(this AssetList<ChildMotion_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017032 RID: 94258 RVA: 0x00361DD0 File Offset: 0x0035FFD0
		public static YamlNode ExportYamlEditor_Array_ClassInfo_2019_4_29(this AssetList<ClassInfo_2019_4_29> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017033 RID: 94259 RVA: 0x00361E10 File Offset: 0x00360010
		public static YamlNode ExportYamlEditor_Array_ClassInfo_2020_1_0(this AssetList<ClassInfo_2020_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017034 RID: 94260 RVA: 0x00361E50 File Offset: 0x00360050
		public static YamlNode ExportYamlEditor_Array_ClassInfo_5_0_0(this AssetList<ClassInfo_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017035 RID: 94261 RVA: 0x00361E90 File Offset: 0x00360090
		public static YamlNode ExportYamlEditor_Array_ClassMethodInfo(this AssetList<ClassMethodInfo> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017036 RID: 94262 RVA: 0x00361ED0 File Offset: 0x003600D0
		public static YamlNode ExportYamlEditor_Array_ClipAnimationInfo_2017_1_0(this AssetList<ClipAnimationInfo_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017037 RID: 94263 RVA: 0x00361F10 File Offset: 0x00360110
		public static YamlNode ExportYamlEditor_Array_ClipAnimationInfo_2018_1_0(this AssetList<ClipAnimationInfo_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017038 RID: 94264 RVA: 0x00361F50 File Offset: 0x00360150
		public static YamlNode ExportYamlEditor_Array_ClipAnimationInfo_2019_1_0(this AssetList<ClipAnimationInfo_2019_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017039 RID: 94265 RVA: 0x00361F90 File Offset: 0x00360190
		public static YamlNode ExportYamlEditor_Array_ClipAnimationInfo_3_4_0(this AssetList<ClipAnimationInfo_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601703A RID: 94266 RVA: 0x00361FD0 File Offset: 0x003601D0
		public static YamlNode ExportYamlEditor_Array_ClipAnimationInfo_4_0_0(this AssetList<ClipAnimationInfo_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601703B RID: 94267 RVA: 0x00362010 File Offset: 0x00360210
		public static YamlNode ExportYamlEditor_Array_ClipAnimationInfo_4_1_0(this AssetList<ClipAnimationInfo_4_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601703C RID: 94268 RVA: 0x00362050 File Offset: 0x00360250
		public static YamlNode ExportYamlEditor_Array_ClipAnimationInfo_4_3_0(this AssetList<ClipAnimationInfo_4_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601703D RID: 94269 RVA: 0x00362090 File Offset: 0x00360290
		public static YamlNode ExportYamlEditor_Array_ClipAnimationInfo_5_0_0(this AssetList<ClipAnimationInfo_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601703E RID: 94270 RVA: 0x003620D0 File Offset: 0x003602D0
		public static YamlNode ExportYamlEditor_Array_ClipAnimationInfo_5_3_0(this AssetList<ClipAnimationInfo_5_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601703F RID: 94271 RVA: 0x00362110 File Offset: 0x00360310
		public static YamlNode ExportYamlEditor_Array_ClipAnimationInfo_5_5_0(this AssetList<ClipAnimationInfo_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017040 RID: 94272 RVA: 0x00362150 File Offset: 0x00360350
		public static YamlNode ExportYamlEditor_Array_ClipAnimationInfoCurve_2017_1_0(this AssetList<ClipAnimationInfoCurve_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017041 RID: 94273 RVA: 0x00362190 File Offset: 0x00360390
		public static YamlNode ExportYamlEditor_Array_ClipAnimationInfoCurve_2018_1_0(this AssetList<ClipAnimationInfoCurve_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017042 RID: 94274 RVA: 0x003621D0 File Offset: 0x003603D0
		public static YamlNode ExportYamlEditor_Array_ClipAnimationInfoCurve_4_0_0(this AssetList<ClipAnimationInfoCurve_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017043 RID: 94275 RVA: 0x00362210 File Offset: 0x00360410
		public static YamlNode ExportYamlEditor_Array_ClipAnimationInfoCurve_5_3_0(this AssetList<ClipAnimationInfoCurve_5_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017044 RID: 94276 RVA: 0x00362250 File Offset: 0x00360450
		public static YamlNode ExportYamlEditor_Array_ClipAnimationInfoCurve_5_5_0(this AssetList<ClipAnimationInfoCurve_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017045 RID: 94277 RVA: 0x00362290 File Offset: 0x00360490
		public static YamlNode ExportYamlEditor_Array_ClothAttachment(this AssetList<ClothAttachment> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017046 RID: 94278 RVA: 0x003622D0 File Offset: 0x003604D0
		public static YamlNode ExportYamlEditor_Array_ClothConstrainCoefficients_3_4_0(this AssetList<ClothConstrainCoefficients_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017047 RID: 94279 RVA: 0x00362310 File Offset: 0x00360510
		public static YamlNode ExportYamlEditor_Array_ClothConstrainCoefficients_5_0_0(this AssetList<ClothConstrainCoefficients_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017048 RID: 94280 RVA: 0x00362350 File Offset: 0x00360550
		public static YamlNode ExportYamlEditor_Array_ClothSphereColliderPair(this AssetList<ClothSphereColliderPair> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017049 RID: 94281 RVA: 0x00362390 File Offset: 0x00360590
		public static YamlNode ExportYamlEditor_Array_ClusterInput(this AssetList<ClusterInput> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601704A RID: 94282 RVA: 0x003623D0 File Offset: 0x003605D0
		public static YamlNode ExportYamlEditor_Array_Collider_4_0_0(this AssetList<Collider_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601704B RID: 94283 RVA: 0x00362410 File Offset: 0x00360610
		public static YamlNode ExportYamlEditor_Array_Collider_5_4_0(this AssetList<Collider_5_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601704C RID: 94284 RVA: 0x00362450 File Offset: 0x00360650
		public static YamlNode ExportYamlEditor_Array_Collider_5_5_0(this AssetList<Collider_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601704D RID: 94285 RVA: 0x00362490 File Offset: 0x00360690
		public static YamlNode ExportYamlEditor_Array_ColorRGBA32(this AssetList<ColorRGBA32> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601704E RID: 94286 RVA: 0x003624D0 File Offset: 0x003606D0
		public static YamlNode ExportYamlEditor_Array_ComponentPair(this AssetList<ComponentPair> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601704F RID: 94287 RVA: 0x00362510 File Offset: 0x00360710
		public static YamlNode ExportYamlEditor_Array_CompressedAnimationCurve(this AssetList<CompressedAnimationCurve> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017050 RID: 94288 RVA: 0x00362550 File Offset: 0x00360750
		public static YamlNode ExportYamlEditor_Array_ComputeShaderBuiltinSampler_2017_1_0(this AssetList<ComputeShaderBuiltinSampler_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017051 RID: 94289 RVA: 0x00362590 File Offset: 0x00360790
		public static YamlNode ExportYamlEditor_Array_ComputeShaderBuiltinSampler_4_0_0(this AssetList<ComputeShaderBuiltinSampler_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017052 RID: 94290 RVA: 0x003625D0 File Offset: 0x003607D0
		public static YamlNode ExportYamlEditor_Array_ComputeShaderCB_2017_1_0(this AssetList<ComputeShaderCB_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017053 RID: 94291 RVA: 0x00362610 File Offset: 0x00360810
		public static YamlNode ExportYamlEditor_Array_ComputeShaderCB_2020_1_0_a9(this AssetList<ComputeShaderCB_2020_1_0_a9> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017054 RID: 94292 RVA: 0x00362650 File Offset: 0x00360850
		public static YamlNode ExportYamlEditor_Array_ComputeShaderCB_4_0_0(this AssetList<ComputeShaderCB_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017055 RID: 94293 RVA: 0x00362690 File Offset: 0x00360890
		public static YamlNode ExportYamlEditor_Array_ComputeShaderCB_5_6_0(this AssetList<ComputeShaderCB_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017056 RID: 94294 RVA: 0x003626D0 File Offset: 0x003608D0
		public static YamlNode ExportYamlEditor_Array_ComputeShaderKernel_2017_1_0(this AssetList<ComputeShaderKernel_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017057 RID: 94295 RVA: 0x00362710 File Offset: 0x00360910
		public static YamlNode ExportYamlEditor_Array_ComputeShaderKernel_2018_1_0(this AssetList<ComputeShaderKernel_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017058 RID: 94296 RVA: 0x00362750 File Offset: 0x00360950
		public static YamlNode ExportYamlEditor_Array_ComputeShaderKernel_2018_2_0(this AssetList<ComputeShaderKernel_2018_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017059 RID: 94297 RVA: 0x00362790 File Offset: 0x00360990
		public static YamlNode ExportYamlEditor_Array_ComputeShaderKernel_2018_2_0_b9(this AssetList<ComputeShaderKernel_2018_2_0_b9> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601705A RID: 94298 RVA: 0x003627D0 File Offset: 0x003609D0
		public static YamlNode ExportYamlEditor_Array_ComputeShaderKernel_2021_1_0_b7(this AssetList<ComputeShaderKernel_2021_1_0_b7> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601705B RID: 94299 RVA: 0x00362810 File Offset: 0x00360A10
		public static YamlNode ExportYamlEditor_Array_ComputeShaderKernel_4_0_0(this AssetList<ComputeShaderKernel_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601705C RID: 94300 RVA: 0x00362850 File Offset: 0x00360A50
		public static YamlNode ExportYamlEditor_Array_ComputeShaderKernel_5_1_0(this AssetList<ComputeShaderKernel_5_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601705D RID: 94301 RVA: 0x00362890 File Offset: 0x00360A90
		public static YamlNode ExportYamlEditor_Array_ComputeShaderKernel_5_2_3(this AssetList<ComputeShaderKernel_5_2_3> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601705E RID: 94302 RVA: 0x003628D0 File Offset: 0x00360AD0
		public static YamlNode ExportYamlEditor_Array_ComputeShaderKernel_5_4_0(this AssetList<ComputeShaderKernel_5_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601705F RID: 94303 RVA: 0x00362910 File Offset: 0x00360B10
		public static YamlNode ExportYamlEditor_Array_ComputeShaderKernel_5_6_0(this AssetList<ComputeShaderKernel_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017060 RID: 94304 RVA: 0x00362950 File Offset: 0x00360B50
		public static YamlNode ExportYamlEditor_Array_ComputeShaderKernelParent_2020_1_0_a17(this AssetList<ComputeShaderKernelParent_2020_1_0_a17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017061 RID: 94305 RVA: 0x00362990 File Offset: 0x00360B90
		public static YamlNode ExportYamlEditor_Array_ComputeShaderKernelParent_2020_1_0_a9(this AssetList<ComputeShaderKernelParent_2020_1_0_a9> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017062 RID: 94306 RVA: 0x003629D0 File Offset: 0x00360BD0
		public static YamlNode ExportYamlEditor_Array_ComputeShaderKernelParent_2020_2_0_a15(this AssetList<ComputeShaderKernelParent_2020_2_0_a15> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017063 RID: 94307 RVA: 0x00362A10 File Offset: 0x00360C10
		public static YamlNode ExportYamlEditor_Array_ComputeShaderKernelParent_2020_3_2(this AssetList<ComputeShaderKernelParent_2020_3_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017064 RID: 94308 RVA: 0x00362A50 File Offset: 0x00360C50
		public static YamlNode ExportYamlEditor_Array_ComputeShaderKernelParent_2021_1_0(this AssetList<ComputeShaderKernelParent_2021_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017065 RID: 94309 RVA: 0x00362A90 File Offset: 0x00360C90
		public static YamlNode ExportYamlEditor_Array_ComputeShaderKernelParent_2021_1_0_b7(this AssetList<ComputeShaderKernelParent_2021_1_0_b7> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017066 RID: 94310 RVA: 0x00362AD0 File Offset: 0x00360CD0
		public static YamlNode ExportYamlEditor_Array_ComputeShaderKernelParent_2022_1_0_a15(this AssetList<ComputeShaderKernelParent_2022_1_0_a15> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017067 RID: 94311 RVA: 0x00362B10 File Offset: 0x00360D10
		public static YamlNode ExportYamlEditor_Array_ComputeShaderParam_2020_1_0_a9(this AssetList<ComputeShaderParam_2020_1_0_a9> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017068 RID: 94312 RVA: 0x00362B50 File Offset: 0x00360D50
		public static YamlNode ExportYamlEditor_Array_ComputeShaderParam_4_0_0(this AssetList<ComputeShaderParam_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017069 RID: 94313 RVA: 0x00362B90 File Offset: 0x00360D90
		public static YamlNode ExportYamlEditor_Array_ComputeShaderParam_5_6_0(this AssetList<ComputeShaderParam_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601706A RID: 94314 RVA: 0x00362BD0 File Offset: 0x00360DD0
		public static YamlNode ExportYamlEditor_Array_ComputeShaderResource_2018_1_0(this AssetList<ComputeShaderResource_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601706B RID: 94315 RVA: 0x00362C10 File Offset: 0x00360E10
		public static YamlNode ExportYamlEditor_Array_ComputeShaderResource_2018_2_0(this AssetList<ComputeShaderResource_2018_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601706C RID: 94316 RVA: 0x00362C50 File Offset: 0x00360E50
		public static YamlNode ExportYamlEditor_Array_ComputeShaderResource_2018_2_0_b9(this AssetList<ComputeShaderResource_2018_2_0_b9> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601706D RID: 94317 RVA: 0x00362C90 File Offset: 0x00360E90
		public static YamlNode ExportYamlEditor_Array_ComputeShaderResource_4_0_0(this AssetList<ComputeShaderResource_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601706E RID: 94318 RVA: 0x00362CD0 File Offset: 0x00360ED0
		public static YamlNode ExportYamlEditor_Array_ComputeShaderResource_5_1_0(this AssetList<ComputeShaderResource_5_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601706F RID: 94319 RVA: 0x00362D10 File Offset: 0x00360F10
		public static YamlNode ExportYamlEditor_Array_ComputeShaderResource_5_2_3(this AssetList<ComputeShaderResource_5_2_3> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017070 RID: 94320 RVA: 0x00362D50 File Offset: 0x00360F50
		public static YamlNode ExportYamlEditor_Array_ComputeShaderResource_5_6_0(this AssetList<ComputeShaderResource_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017071 RID: 94321 RVA: 0x00362D90 File Offset: 0x00360F90
		public static YamlNode ExportYamlEditor_Array_ComputeShaderVariant_2017_1_0(this AssetList<ComputeShaderVariant_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017072 RID: 94322 RVA: 0x00362DD0 File Offset: 0x00360FD0
		public static YamlNode ExportYamlEditor_Array_ComputeShaderVariant_2018_1_0(this AssetList<ComputeShaderVariant_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017073 RID: 94323 RVA: 0x00362E10 File Offset: 0x00361010
		public static YamlNode ExportYamlEditor_Array_ComputeShaderVariant_2018_2_0(this AssetList<ComputeShaderVariant_2018_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017074 RID: 94324 RVA: 0x00362E50 File Offset: 0x00361050
		public static YamlNode ExportYamlEditor_Array_ComputeShaderVariant_2018_2_0_b9(this AssetList<ComputeShaderVariant_2018_2_0_b9> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017075 RID: 94325 RVA: 0x00362E90 File Offset: 0x00361090
		public static YamlNode ExportYamlEditor_Array_ComputeShaderVariant_2020_1_0_a17(this AssetList<ComputeShaderVariant_2020_1_0_a17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017076 RID: 94326 RVA: 0x00362ED0 File Offset: 0x003610D0
		public static YamlNode ExportYamlEditor_Array_ComputeShaderVariant_2020_1_0_a9(this AssetList<ComputeShaderVariant_2020_1_0_a9> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017077 RID: 94327 RVA: 0x00362F10 File Offset: 0x00361110
		public static YamlNode ExportYamlEditor_Array_ComputeShaderVariant_2020_2_0_a15(this AssetList<ComputeShaderVariant_2020_2_0_a15> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017078 RID: 94328 RVA: 0x00362F50 File Offset: 0x00361150
		public static YamlNode ExportYamlEditor_Array_ComputeShaderVariant_2020_3_2(this AssetList<ComputeShaderVariant_2020_3_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017079 RID: 94329 RVA: 0x00362F90 File Offset: 0x00361190
		public static YamlNode ExportYamlEditor_Array_ComputeShaderVariant_2021_1_0(this AssetList<ComputeShaderVariant_2021_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601707A RID: 94330 RVA: 0x00362FD0 File Offset: 0x003611D0
		public static YamlNode ExportYamlEditor_Array_ComputeShaderVariant_2021_1_0_b7(this AssetList<ComputeShaderVariant_2021_1_0_b7> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601707B RID: 94331 RVA: 0x00363010 File Offset: 0x00361210
		public static YamlNode ExportYamlEditor_Array_ComputeShaderVariant_2021_2_0_a19(this AssetList<ComputeShaderVariant_2021_2_0_a19> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601707C RID: 94332 RVA: 0x00363050 File Offset: 0x00361250
		public static YamlNode ExportYamlEditor_Array_ComputeShaderVariant_2022_1_0_a15(this AssetList<ComputeShaderVariant_2022_1_0_a15> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601707D RID: 94333 RVA: 0x00363090 File Offset: 0x00361290
		public static YamlNode ExportYamlEditor_Array_ComputeShaderVariant_5_0_0(this AssetList<ComputeShaderVariant_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601707E RID: 94334 RVA: 0x003630D0 File Offset: 0x003612D0
		public static YamlNode ExportYamlEditor_Array_ComputeShaderVariant_5_1_0(this AssetList<ComputeShaderVariant_5_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601707F RID: 94335 RVA: 0x00363110 File Offset: 0x00361310
		public static YamlNode ExportYamlEditor_Array_ComputeShaderVariant_5_2_3(this AssetList<ComputeShaderVariant_5_2_3> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017080 RID: 94336 RVA: 0x00363150 File Offset: 0x00361350
		public static YamlNode ExportYamlEditor_Array_ComputeShaderVariant_5_4_0(this AssetList<ComputeShaderVariant_5_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017081 RID: 94337 RVA: 0x00363190 File Offset: 0x00361390
		public static YamlNode ExportYamlEditor_Array_ComputeShaderVariant_5_6_0(this AssetList<ComputeShaderVariant_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017082 RID: 94338 RVA: 0x003631D0 File Offset: 0x003613D0
		public static YamlNode ExportYamlEditor_Array_ConstantBuffer_2017_1_0(this AssetList<ConstantBuffer_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017083 RID: 94339 RVA: 0x00363210 File Offset: 0x00361410
		public static YamlNode ExportYamlEditor_Array_ConstantBuffer_2017_3_0(this AssetList<ConstantBuffer_2017_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017084 RID: 94340 RVA: 0x00363250 File Offset: 0x00361450
		public static YamlNode ExportYamlEditor_Array_ConstantBuffer_2020_3_2(this AssetList<ConstantBuffer_2020_3_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017085 RID: 94341 RVA: 0x00363290 File Offset: 0x00361490
		public static YamlNode ExportYamlEditor_Array_ConstantBuffer_2021_1_0(this AssetList<ConstantBuffer_2021_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017086 RID: 94342 RVA: 0x003632D0 File Offset: 0x003614D0
		public static YamlNode ExportYamlEditor_Array_ConstantBuffer_2021_1_1(this AssetList<ConstantBuffer_2021_1_1> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017087 RID: 94343 RVA: 0x00363310 File Offset: 0x00361510
		public static YamlNode ExportYamlEditor_Array_ConstantBuffer_5_5_0(this AssetList<ConstantBuffer_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017088 RID: 94344 RVA: 0x00363350 File Offset: 0x00361550
		public static YamlNode ExportYamlEditor_Array_ConstraintSource(this AssetList<ConstraintSource> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017089 RID: 94345 RVA: 0x00363390 File Offset: 0x00361590
		public static YamlNode ExportYamlEditor_Array_DefaultPreset_2018_1_0(this AssetList<DefaultPreset_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601708A RID: 94346 RVA: 0x003633D0 File Offset: 0x003615D0
		public static YamlNode ExportYamlEditor_Array_DefaultPreset_2019_3_0_a10(this AssetList<DefaultPreset_2019_3_0_a10> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601708B RID: 94347 RVA: 0x00363410 File Offset: 0x00361610
		public static YamlNode ExportYamlEditor_Array_DefaultPreset_2020_1_0_a23(this AssetList<DefaultPreset_2020_1_0_a23> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601708C RID: 94348 RVA: 0x00363450 File Offset: 0x00361650
		public static YamlNode ExportYamlEditor_Array_DefaultPresetList(this AssetList<DefaultPresetList> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601708D RID: 94349 RVA: 0x00363490 File Offset: 0x00361690
		public static YamlNode ExportYamlEditor_Array_DetailPatch_2020_2_0_b10(this AssetList<DetailPatch_2020_2_0_b10> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601708E RID: 94350 RVA: 0x003634D0 File Offset: 0x003616D0
		public static YamlNode ExportYamlEditor_Array_DetailPatch_2022_2_0(this AssetList<DetailPatch_2022_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601708F RID: 94351 RVA: 0x00363510 File Offset: 0x00361710
		public static YamlNode ExportYamlEditor_Array_DetailPatch_3_4_0(this AssetList<DetailPatch_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017090 RID: 94352 RVA: 0x00363550 File Offset: 0x00361750
		public static YamlNode ExportYamlEditor_Array_DetailPatch_3_5_0(this AssetList<DetailPatch_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017091 RID: 94353 RVA: 0x00363590 File Offset: 0x00361790
		public static YamlNode ExportYamlEditor_Array_DetailPrototype_2020_2_0_b10(this AssetList<DetailPrototype_2020_2_0_b10> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017092 RID: 94354 RVA: 0x003635D0 File Offset: 0x003617D0
		public static YamlNode ExportYamlEditor_Array_DetailPrototype_2021_2_0(this AssetList<DetailPrototype_2021_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017093 RID: 94355 RVA: 0x00363610 File Offset: 0x00361810
		public static YamlNode ExportYamlEditor_Array_DetailPrototype_2022_2_0(this AssetList<DetailPrototype_2022_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017094 RID: 94356 RVA: 0x00363650 File Offset: 0x00361850
		public static YamlNode ExportYamlEditor_Array_DetailPrototype_2022_2_0_a16(this AssetList<DetailPrototype_2022_2_0_a16> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017095 RID: 94357 RVA: 0x00363690 File Offset: 0x00361890
		public static YamlNode ExportYamlEditor_Array_DetailPrototype_3_4_0(this AssetList<DetailPrototype_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017096 RID: 94358 RVA: 0x003636D0 File Offset: 0x003618D0
		public static YamlNode ExportYamlEditor_Array_DetailPrototype_3_5_0(this AssetList<DetailPrototype_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017097 RID: 94359 RVA: 0x00363710 File Offset: 0x00361910
		public static YamlNode ExportYamlEditor_Array_DetailPrototype_5_0_0(this AssetList<DetailPrototype_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017098 RID: 94360 RVA: 0x00363750 File Offset: 0x00361950
		public static YamlNode ExportYamlEditor_Array_DirectorGenericBinding(this AssetList<DirectorGenericBinding> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017099 RID: 94361 RVA: 0x00363790 File Offset: 0x00361990
		public static YamlNode ExportYamlEditor_Array_EnlightenRendererInformation(this AssetList<EnlightenRendererInformation> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601709A RID: 94362 RVA: 0x003637D0 File Offset: 0x003619D0
		public static YamlNode ExportYamlEditor_Array_EnlightenSystemAtlasInformation(this AssetList<EnlightenSystemAtlasInformation> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601709B RID: 94363 RVA: 0x00363810 File Offset: 0x00361A10
		public static YamlNode ExportYamlEditor_Array_EnlightenSystemInformation(this AssetList<EnlightenSystemInformation> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601709C RID: 94364 RVA: 0x00363850 File Offset: 0x00361A50
		public static YamlNode ExportYamlEditor_Array_EnlightenTerrainChunksInformation(this AssetList<EnlightenTerrainChunksInformation> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601709D RID: 94365 RVA: 0x00363890 File Offset: 0x00361A90
		public static YamlNode ExportYamlEditor_Array_ExpandedData_2017_1_0(this AssetList<ExpandedData_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601709E RID: 94366 RVA: 0x003638D0 File Offset: 0x00361AD0
		public static YamlNode ExportYamlEditor_Array_ExpandedData_3_4_0(this AssetList<ExpandedData_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601709F RID: 94367 RVA: 0x00363910 File Offset: 0x00361B10
		public static YamlNode ExportYamlEditor_Array_ExpandedData_5_6_0(this AssetList<ExpandedData_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170A0 RID: 94368 RVA: 0x00363950 File Offset: 0x00361B50
		public static YamlNode ExportYamlEditor_Array_ExposedAudioParameter(this AssetList<ExposedAudioParameter> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170A1 RID: 94369 RVA: 0x00363990 File Offset: 0x00361B90
		public static YamlNode ExportYamlEditor_Array_Expression(this AssetList<Expression> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170A2 RID: 94370 RVA: 0x003639D0 File Offset: 0x00361BD0
		public static YamlNode ExportYamlEditor_Array_ExtensionPropertyValue(this AssetList<ExtensionPropertyValue> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170A3 RID: 94371 RVA: 0x00363A10 File Offset: 0x00361C10
		public static YamlNode ExportYamlEditor_Array_FlareElement_3_4_0(this AssetList<FlareElement_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170A4 RID: 94372 RVA: 0x00363A50 File Offset: 0x00361C50
		public static YamlNode ExportYamlEditor_Array_FlareElement_3_5_0(this AssetList<FlareElement_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170A5 RID: 94373 RVA: 0x00363A90 File Offset: 0x00361C90
		public static YamlNode ExportYamlEditor_Array_FloatCurve_2017_1_0(this AssetList<FloatCurve_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170A6 RID: 94374 RVA: 0x00363AD0 File Offset: 0x00361CD0
		public static YamlNode ExportYamlEditor_Array_FloatCurve_2018_1_0(this AssetList<FloatCurve_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170A7 RID: 94375 RVA: 0x00363B10 File Offset: 0x00361D10
		public static YamlNode ExportYamlEditor_Array_FloatCurve_2022_2_0(this AssetList<FloatCurve_2022_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170A8 RID: 94376 RVA: 0x00363B50 File Offset: 0x00361D50
		public static YamlNode ExportYamlEditor_Array_FloatCurve_3_4_0(this AssetList<FloatCurve_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170A9 RID: 94377 RVA: 0x00363B90 File Offset: 0x00361D90
		public static YamlNode ExportYamlEditor_Array_FloatCurve_5_0_0(this AssetList<FloatCurve_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170AA RID: 94378 RVA: 0x00363BD0 File Offset: 0x00361DD0
		public static YamlNode ExportYamlEditor_Array_FloatCurve_5_3_0(this AssetList<FloatCurve_5_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170AB RID: 94379 RVA: 0x00363C10 File Offset: 0x00361E10
		public static YamlNode ExportYamlEditor_Array_FloatCurve_5_5_0(this AssetList<FloatCurve_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170AC RID: 94380 RVA: 0x00363C50 File Offset: 0x00361E50
		public static YamlNode ExportYamlEditor_Array_FloatCurve_5_6_0(this AssetList<FloatCurve_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170AD RID: 94381 RVA: 0x00363C90 File Offset: 0x00361E90
		public static YamlNode ExportYamlEditor_Array_GenericBinding_2022_1_0_a12(this AssetList<GenericBinding_2022_1_0_a12> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170AE RID: 94382 RVA: 0x00363CD0 File Offset: 0x00361ED0
		public static YamlNode ExportYamlEditor_Array_GenericBinding_2022_2_0(this AssetList<GenericBinding_2022_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170AF RID: 94383 RVA: 0x00363D10 File Offset: 0x00361F10
		public static YamlNode ExportYamlEditor_Array_GenericBinding_4_5_0(this AssetList<GenericBinding_4_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170B0 RID: 94384 RVA: 0x00363D50 File Offset: 0x00361F50
		public static YamlNode ExportYamlEditor_Array_GenericBinding_5_0_0(this AssetList<GenericBinding_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170B1 RID: 94385 RVA: 0x00363D90 File Offset: 0x00361F90
		public static YamlNode ExportYamlEditor_Array_GenericBinding_5_6_0(this AssetList<GenericBinding_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170B2 RID: 94386 RVA: 0x00363DD0 File Offset: 0x00361FD0
		public static YamlNode ExportYamlEditor_Array_GUID(this AssetList<GUID> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170B3 RID: 94387 RVA: 0x00363E10 File Offset: 0x00362010
		public static YamlNode ExportYamlEditor_Array_Handle_4_0_0(this AssetList<Handle_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170B4 RID: 94388 RVA: 0x00363E50 File Offset: 0x00362050
		public static YamlNode ExportYamlEditor_Array_Handle_5_4_0(this AssetList<Handle_5_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170B5 RID: 94389 RVA: 0x00363E90 File Offset: 0x00362090
		public static YamlNode ExportYamlEditor_Array_Handle_5_5_0(this AssetList<Handle_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170B6 RID: 94390 RVA: 0x00363ED0 File Offset: 0x003620D0
		public static YamlNode ExportYamlEditor_Array_Hash128(this AssetList<Hash128> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170B7 RID: 94391 RVA: 0x00363F10 File Offset: 0x00362110
		public static YamlNode ExportYamlEditor_Array_HeightmapData_2022_2_0(this AssetList<HeightmapData_2022_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170B8 RID: 94392 RVA: 0x00363F50 File Offset: 0x00362150
		public static YamlNode ExportYamlEditor_Array_HeightmapData_3_5_0(this AssetList<HeightmapData_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170B9 RID: 94393 RVA: 0x00363F90 File Offset: 0x00362190
		public static YamlNode ExportYamlEditor_Array_HeightmapData_5_0_0(this AssetList<HeightmapData_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170BA RID: 94394 RVA: 0x00363FD0 File Offset: 0x003621D0
		public static YamlNode ExportYamlEditor_Array_HeightMeshBVNode(this AssetList<HeightMeshBVNode> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170BB RID: 94395 RVA: 0x00364010 File Offset: 0x00362210
		public static YamlNode ExportYamlEditor_Array_HeightMeshData_2017_1_0(this AssetList<HeightMeshData_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170BC RID: 94396 RVA: 0x00364050 File Offset: 0x00362250
		public static YamlNode ExportYamlEditor_Array_HeightMeshData_5_0_0(this AssetList<HeightMeshData_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170BD RID: 94397 RVA: 0x00364090 File Offset: 0x00362290
		public static YamlNode ExportYamlEditor_Array_HumanBone_4_0_0(this AssetList<HumanBone_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170BE RID: 94398 RVA: 0x003640D0 File Offset: 0x003622D0
		public static YamlNode ExportYamlEditor_Array_HumanBone_4_3_0(this AssetList<HumanBone_4_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170BF RID: 94399 RVA: 0x00364110 File Offset: 0x00362310
		public static YamlNode ExportYamlEditor_Array_HumanHandle(this AssetList<HumanHandle> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170C0 RID: 94400 RVA: 0x00364150 File Offset: 0x00362350
		public static YamlNode ExportYamlEditor_Array_IconWithSize_2017_1_0(this AssetList<IconWithSize_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170C1 RID: 94401 RVA: 0x00364190 File Offset: 0x00362390
		public static YamlNode ExportYamlEditor_Array_IconWithSize_2017_1_2(this AssetList<IconWithSize_2017_1_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170C2 RID: 94402 RVA: 0x003641D0 File Offset: 0x003623D0
		public static YamlNode ExportYamlEditor_Array_IconWithSize_2017_2_0(this AssetList<IconWithSize_2017_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170C3 RID: 94403 RVA: 0x00364210 File Offset: 0x00362410
		public static YamlNode ExportYamlEditor_Array_IconWithSize_2017_2_0_b9(this AssetList<IconWithSize_2017_2_0_b9> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170C4 RID: 94404 RVA: 0x00364250 File Offset: 0x00362450
		public static YamlNode ExportYamlEditor_Array_IconWithSize_3_4_0(this AssetList<IconWithSize_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170C5 RID: 94405 RVA: 0x00364290 File Offset: 0x00362490
		public static YamlNode ExportYamlEditor_Array_IconWithSize_5_0_0(this AssetList<IconWithSize_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170C6 RID: 94406 RVA: 0x003642D0 File Offset: 0x003624D0
		public static YamlNode ExportYamlEditor_Array_IconWithSize_5_2_2(this AssetList<IconWithSize_5_2_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170C7 RID: 94407 RVA: 0x00364310 File Offset: 0x00362510
		public static YamlNode ExportYamlEditor_Array_IconWithSize_5_6_4(this AssetList<IconWithSize_5_6_4> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170C8 RID: 94408 RVA: 0x00364350 File Offset: 0x00362550
		public static YamlNode ExportYamlEditor_Array_ImportLog_ImportLogEntry(this AssetList<ImportLog_ImportLogEntry> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170C9 RID: 94409 RVA: 0x00364390 File Offset: 0x00362590
		public static YamlNode ExportYamlEditor_Array_InputAxis(this AssetList<InputAxis> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170CA RID: 94410 RVA: 0x003643D0 File Offset: 0x003625D0
		public static YamlNode ExportYamlEditor_Array_InputImportSettings(this AssetList<InputImportSettings> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170CB RID: 94411 RVA: 0x00364410 File Offset: 0x00362610
		public static YamlNode ExportYamlEditor_Array_InputImportSettings_SubstanceValue_2017_2_0_b4(this AssetList<InputImportSettings_SubstanceValue_2017_2_0_b4> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170CC RID: 94412 RVA: 0x00364450 File Offset: 0x00362650
		public static YamlNode ExportYamlEditor_Array_InputImportSettings_SubstanceValue_3_4_0(this AssetList<InputImportSettings_SubstanceValue_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170CD RID: 94413 RVA: 0x00364490 File Offset: 0x00362690
		public static YamlNode ExportYamlEditor_Array_InputImportSettings_SubstanceValue_5_0_0(this AssetList<InputImportSettings_SubstanceValue_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170CE RID: 94414 RVA: 0x003644D0 File Offset: 0x003626D0
		public static YamlNode ExportYamlEditor_Array_Int16(this short[] value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int num = value.Length;
			for (int i = 0; i < num; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor_Int16(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170CF RID: 94415 RVA: 0x00364508 File Offset: 0x00362708
		public static YamlNode ExportYamlEditor_Array_Int32(this int[] value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int num = value.Length;
			for (int i = 0; i < num; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor_Int32(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170D0 RID: 94416 RVA: 0x00364540 File Offset: 0x00362740
		public static YamlNode ExportYamlEditor_Array_Int64(this long[] value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int num = value.Length;
			for (int i = 0; i < num; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor_Int64(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170D1 RID: 94417 RVA: 0x00364578 File Offset: 0x00362778
		public static YamlNode ExportYamlEditor_Array_IOSDeviceRequirementForResourceVariant_2017_1_0(this AssetList<IOSDeviceRequirementForResourceVariant_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170D2 RID: 94418 RVA: 0x003645B8 File Offset: 0x003627B8
		public static YamlNode ExportYamlEditor_Array_IOSDeviceRequirementForResourceVariant_5_2_1(this AssetList<IOSDeviceRequirementForResourceVariant_5_2_1> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170D3 RID: 94419 RVA: 0x003645F8 File Offset: 0x003627F8
		public static YamlNode ExportYamlEditor_Array_Keyframe_Quaternionf_2018_1_0(this AssetList<Keyframe_Quaternionf_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170D4 RID: 94420 RVA: 0x00364638 File Offset: 0x00362838
		public static YamlNode ExportYamlEditor_Array_Keyframe_Quaternionf_3_4_0(this AssetList<Keyframe_Quaternionf_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170D5 RID: 94421 RVA: 0x00364678 File Offset: 0x00362878
		public static YamlNode ExportYamlEditor_Array_Keyframe_Quaternionf_3_5_0(this AssetList<Keyframe_Quaternionf_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170D6 RID: 94422 RVA: 0x003646B8 File Offset: 0x003628B8
		public static YamlNode ExportYamlEditor_Array_Keyframe_Quaternionf_5_5_0(this AssetList<Keyframe_Quaternionf_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170D7 RID: 94423 RVA: 0x003646F8 File Offset: 0x003628F8
		public static YamlNode ExportYamlEditor_Array_Keyframe_Single_2018_1_0(this AssetList<Keyframe_Single_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170D8 RID: 94424 RVA: 0x00364738 File Offset: 0x00362938
		public static YamlNode ExportYamlEditor_Array_Keyframe_Single_3_4_0(this AssetList<Keyframe_Single_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170D9 RID: 94425 RVA: 0x00364778 File Offset: 0x00362978
		public static YamlNode ExportYamlEditor_Array_Keyframe_Single_5_5_0(this AssetList<Keyframe_Single_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170DA RID: 94426 RVA: 0x003647B8 File Offset: 0x003629B8
		public static YamlNode ExportYamlEditor_Array_Keyframe_Vector3f_2018_1_0(this AssetList<Keyframe_Vector3f_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170DB RID: 94427 RVA: 0x003647F8 File Offset: 0x003629F8
		public static YamlNode ExportYamlEditor_Array_Keyframe_Vector3f_3_4_0(this AssetList<Keyframe_Vector3f_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170DC RID: 94428 RVA: 0x00364838 File Offset: 0x00362A38
		public static YamlNode ExportYamlEditor_Array_Keyframe_Vector3f_3_5_0(this AssetList<Keyframe_Vector3f_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170DD RID: 94429 RVA: 0x00364878 File Offset: 0x00362A78
		public static YamlNode ExportYamlEditor_Array_Keyframe_Vector3f_5_5_0(this AssetList<Keyframe_Vector3f_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170DE RID: 94430 RVA: 0x003648B8 File Offset: 0x00362AB8
		public static YamlNode ExportYamlEditor_Array_KeywordTargetInfo_2021_1_0(this AssetList<KeywordTargetInfo_2021_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170DF RID: 94431 RVA: 0x003648F8 File Offset: 0x00362AF8
		public static YamlNode ExportYamlEditor_Array_KeywordTargetInfo_5_6_0_b2(this AssetList<KeywordTargetInfo_5_6_0_b2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170E0 RID: 94432 RVA: 0x00364938 File Offset: 0x00362B38
		public static YamlNode ExportYamlEditor_Array_LibraryRepresentation_2019_3_0_a8(this AssetList<LibraryRepresentation_2019_3_0_a8> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170E1 RID: 94433 RVA: 0x00364978 File Offset: 0x00362B78
		public static YamlNode ExportYamlEditor_Array_LibraryRepresentation_3_4_0(this AssetList<LibraryRepresentation_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170E2 RID: 94434 RVA: 0x003649B8 File Offset: 0x00362BB8
		public static YamlNode ExportYamlEditor_Array_LibraryRepresentation_3_5_0(this AssetList<LibraryRepresentation_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170E3 RID: 94435 RVA: 0x003649F8 File Offset: 0x00362BF8
		public static YamlNode ExportYamlEditor_Array_LibraryRepresentation_4_0_0(this AssetList<LibraryRepresentation_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170E4 RID: 94436 RVA: 0x00364A38 File Offset: 0x00362C38
		public static YamlNode ExportYamlEditor_Array_LibraryRepresentation_5_0_0(this AssetList<LibraryRepresentation_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170E5 RID: 94437 RVA: 0x00364A78 File Offset: 0x00362C78
		public static YamlNode ExportYamlEditor_Array_LibraryRepresentation_5_1_0(this AssetList<LibraryRepresentation_5_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170E6 RID: 94438 RVA: 0x00364AB8 File Offset: 0x00362CB8
		public static YamlNode ExportYamlEditor_Array_LibraryRepresentation_5_5_0(this AssetList<LibraryRepresentation_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170E7 RID: 94439 RVA: 0x00364AF8 File Offset: 0x00362CF8
		public static YamlNode ExportYamlEditor_Array_LightBakingOutput_2017_3_0(this AssetList<LightBakingOutput_2017_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170E8 RID: 94440 RVA: 0x00364B38 File Offset: 0x00362D38
		public static YamlNode ExportYamlEditor_Array_LightBakingOutput_5_6_0_b2(this AssetList<LightBakingOutput_5_6_0_b2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170E9 RID: 94441 RVA: 0x00364B78 File Offset: 0x00362D78
		public static YamlNode ExportYamlEditor_Array_LightBakingOutput_5_6_0_b5(this AssetList<LightBakingOutput_5_6_0_b5> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170EA RID: 94442 RVA: 0x00364BB8 File Offset: 0x00362DB8
		public static YamlNode ExportYamlEditor_Array_LightmapData_3_4_0(this AssetList<LightmapData_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170EB RID: 94443 RVA: 0x00364BF8 File Offset: 0x00362DF8
		public static YamlNode ExportYamlEditor_Array_LightmapData_5_0_0(this AssetList<LightmapData_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170EC RID: 94444 RVA: 0x00364C38 File Offset: 0x00362E38
		public static YamlNode ExportYamlEditor_Array_LightmapData_5_6_0_b2(this AssetList<LightmapData_5_6_0_b2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170ED RID: 94445 RVA: 0x00364C78 File Offset: 0x00362E78
		public static YamlNode ExportYamlEditor_Array_LightProbeOcclusion_5_4_0(this AssetList<LightProbeOcclusion_5_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170EE RID: 94446 RVA: 0x00364CB8 File Offset: 0x00362EB8
		public static YamlNode ExportYamlEditor_Array_LightProbeOcclusion_5_6_0_b2(this AssetList<LightProbeOcclusion_5_6_0_b2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170EF RID: 94447 RVA: 0x00364CF8 File Offset: 0x00362EF8
		public static YamlNode ExportYamlEditor_Array_LightProbeOcclusion_5_6_0_b5(this AssetList<LightProbeOcclusion_5_6_0_b5> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170F0 RID: 94448 RVA: 0x00364D38 File Offset: 0x00362F38
		public static YamlNode ExportYamlEditor_Array_LOD_2017_1_0(this AssetList<LOD_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170F1 RID: 94449 RVA: 0x00364D78 File Offset: 0x00362F78
		public static YamlNode ExportYamlEditor_Array_LOD_3_5_0(this AssetList<LOD_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170F2 RID: 94450 RVA: 0x00364DB8 File Offset: 0x00362FB8
		public static YamlNode ExportYamlEditor_Array_LOD_5_0_0(this AssetList<LOD_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170F3 RID: 94451 RVA: 0x00364DF8 File Offset: 0x00362FF8
		public static YamlNode ExportYamlEditor_Array_LOD_5_1_0(this AssetList<LOD_5_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170F4 RID: 94452 RVA: 0x00364E38 File Offset: 0x00363038
		public static YamlNode ExportYamlEditor_Array_LODRenderer_3_5_0(this AssetList<LODRenderer_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170F5 RID: 94453 RVA: 0x00364E78 File Offset: 0x00363078
		public static YamlNode ExportYamlEditor_Array_LODRenderer_5_0_0(this AssetList<LODRenderer_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170F6 RID: 94454 RVA: 0x00364EB8 File Offset: 0x003630B8
		public static YamlNode ExportYamlEditor_Array_Map_Utf8String_Utf8String(this AssetList<AssetDictionary<Utf8String, Utf8String>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor_Map_Utf8String_Utf8String(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170F7 RID: 94455 RVA: 0x00364EF8 File Offset: 0x003630F8
		public static YamlNode ExportYamlEditor_Array_MaterialImportOutput_4_0_0(this AssetList<MaterialImportOutput_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170F8 RID: 94456 RVA: 0x00364F38 File Offset: 0x00363138
		public static YamlNode ExportYamlEditor_Array_MaterialImportOutput_4_1_0(this AssetList<MaterialImportOutput_4_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170F9 RID: 94457 RVA: 0x00364F78 File Offset: 0x00363178
		public static YamlNode ExportYamlEditor_Array_MaterialImportOutput_4_2_0(this AssetList<MaterialImportOutput_4_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170FA RID: 94458 RVA: 0x00364FB8 File Offset: 0x003631B8
		public static YamlNode ExportYamlEditor_Array_MaterialImportOutput_4_3_0(this AssetList<MaterialImportOutput_4_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170FB RID: 94459 RVA: 0x00364FF8 File Offset: 0x003631F8
		public static YamlNode ExportYamlEditor_Array_MaterialInstanceSettings_2017_1_0(this AssetList<MaterialInstanceSettings_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170FC RID: 94460 RVA: 0x00365038 File Offset: 0x00363238
		public static YamlNode ExportYamlEditor_Array_MaterialInstanceSettings_2017_2_0_b4(this AssetList<MaterialInstanceSettings_2017_2_0_b4> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170FD RID: 94461 RVA: 0x00365078 File Offset: 0x00363278
		public static YamlNode ExportYamlEditor_Array_MaterialInstanceSettings_3_4_0(this AssetList<MaterialInstanceSettings_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170FE RID: 94462 RVA: 0x003650B8 File Offset: 0x003632B8
		public static YamlNode ExportYamlEditor_Array_MaterialInstanceSettings_3_5_0(this AssetList<MaterialInstanceSettings_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060170FF RID: 94463 RVA: 0x003650F8 File Offset: 0x003632F8
		public static YamlNode ExportYamlEditor_Array_MaterialInstanceSettings_4_0_0(this AssetList<MaterialInstanceSettings_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017100 RID: 94464 RVA: 0x00365138 File Offset: 0x00363338
		public static YamlNode ExportYamlEditor_Array_MaterialInstanceSettings_4_1_0(this AssetList<MaterialInstanceSettings_4_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017101 RID: 94465 RVA: 0x00365178 File Offset: 0x00363378
		public static YamlNode ExportYamlEditor_Array_MaterialInstanceSettings_4_2_0(this AssetList<MaterialInstanceSettings_4_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017102 RID: 94466 RVA: 0x003651B8 File Offset: 0x003633B8
		public static YamlNode ExportYamlEditor_Array_MaterialInstanceSettings_4_3_0(this AssetList<MaterialInstanceSettings_4_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017103 RID: 94467 RVA: 0x003651F8 File Offset: 0x003633F8
		public static YamlNode ExportYamlEditor_Array_MaterialInstanceSettings_4_5_0(this AssetList<MaterialInstanceSettings_4_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017104 RID: 94468 RVA: 0x00365238 File Offset: 0x00363438
		public static YamlNode ExportYamlEditor_Array_MaterialInstanceSettings_5_0_0(this AssetList<MaterialInstanceSettings_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017105 RID: 94469 RVA: 0x00365278 File Offset: 0x00363478
		public static YamlNode ExportYamlEditor_Array_MaterialInstanceSettings_5_0_2(this AssetList<MaterialInstanceSettings_5_0_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017106 RID: 94470 RVA: 0x003652B8 File Offset: 0x003634B8
		public static YamlNode ExportYamlEditor_Array_MaterialInstanceSettings_5_3_4(this AssetList<MaterialInstanceSettings_5_3_4> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017107 RID: 94471 RVA: 0x003652F8 File Offset: 0x003634F8
		public static YamlNode ExportYamlEditor_Array_MaterialInstanceSettings_5_6_0(this AssetList<MaterialInstanceSettings_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017108 RID: 94472 RVA: 0x00365338 File Offset: 0x00363538
		public static YamlNode ExportYamlEditor_Array_Matrix4x4f(this AssetList<Matrix4x4f> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017109 RID: 94473 RVA: 0x00365378 File Offset: 0x00363578
		public static YamlNode ExportYamlEditor_Array_MatrixParameter(this AssetList<MatrixParameter> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601710A RID: 94474 RVA: 0x003653B8 File Offset: 0x003635B8
		public static YamlNode ExportYamlEditor_Array_MeshBlendShape_4_1_0(this AssetList<MeshBlendShape_4_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601710B RID: 94475 RVA: 0x003653F8 File Offset: 0x003635F8
		public static YamlNode ExportYamlEditor_Array_MeshBlendShape_4_3_0(this AssetList<MeshBlendShape_4_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601710C RID: 94476 RVA: 0x00365438 File Offset: 0x00363638
		public static YamlNode ExportYamlEditor_Array_MeshBlendShapeChannel(this AssetList<MeshBlendShapeChannel> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601710D RID: 94477 RVA: 0x00365478 File Offset: 0x00363678
		public static YamlNode ExportYamlEditor_Array_MeshBlendShapeVertex(this AssetList<MeshBlendShapeVertex> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601710E RID: 94478 RVA: 0x003654B8 File Offset: 0x003636B8
		public static YamlNode ExportYamlEditor_Array_MetroFTAFileType(this AssetList<MetroFTAFileType> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601710F RID: 94479 RVA: 0x003654F8 File Offset: 0x003636F8
		public static YamlNode ExportYamlEditor_Array_MinMaxAABB(this AssetList<MinMaxAABB> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017110 RID: 94480 RVA: 0x00365538 File Offset: 0x00363738
		public static YamlNode ExportYamlEditor_Array_MipmapLimitSettings(this AssetList<MipmapLimitSettings> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017111 RID: 94481 RVA: 0x00365578 File Offset: 0x00363778
		public static YamlNode ExportYamlEditor_Array_Module_2018_1_0(this AssetList<Module_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017112 RID: 94482 RVA: 0x003655B8 File Offset: 0x003637B8
		public static YamlNode ExportYamlEditor_Array_Module_2018_2_0_b4(this AssetList<Module_2018_2_0_b4> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017113 RID: 94483 RVA: 0x003655F8 File Offset: 0x003637F8
		public static YamlNode ExportYamlEditor_Array_NavMeshAreaData(this AssetList<NavMeshAreaData> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017114 RID: 94484 RVA: 0x00365638 File Offset: 0x00363838
		public static YamlNode ExportYamlEditor_Array_NavMeshBuildSettings_2017_2_0(this AssetList<NavMeshBuildSettings_2017_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017115 RID: 94485 RVA: 0x00365678 File Offset: 0x00363878
		public static YamlNode ExportYamlEditor_Array_NavMeshBuildSettings_2020_1_0_a23(this AssetList<NavMeshBuildSettings_2020_1_0_a23> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017116 RID: 94486 RVA: 0x003656B8 File Offset: 0x003638B8
		public static YamlNode ExportYamlEditor_Array_NavMeshBuildSettings_2020_1_0_a24(this AssetList<NavMeshBuildSettings_2020_1_0_a24> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017117 RID: 94487 RVA: 0x003656F8 File Offset: 0x003638F8
		public static YamlNode ExportYamlEditor_Array_NavMeshBuildSettings_2022_2_0(this AssetList<NavMeshBuildSettings_2022_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017118 RID: 94488 RVA: 0x00365738 File Offset: 0x00363938
		public static YamlNode ExportYamlEditor_Array_NavMeshBuildSettings_5_6_0(this AssetList<NavMeshBuildSettings_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017119 RID: 94489 RVA: 0x00365778 File Offset: 0x00363978
		public static YamlNode ExportYamlEditor_Array_NavMeshBuildSettings_5_6_0_f2(this AssetList<NavMeshBuildSettings_5_6_0_f2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601711A RID: 94490 RVA: 0x003657B8 File Offset: 0x003639B8
		public static YamlNode ExportYamlEditor_Array_NavMeshTileData_5_0_0(this AssetList<NavMeshTileData_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601711B RID: 94491 RVA: 0x003657F8 File Offset: 0x003639F8
		public static YamlNode ExportYamlEditor_Array_NavMeshTileData_5_6_0(this AssetList<NavMeshTileData_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601711C RID: 94492 RVA: 0x00365838 File Offset: 0x00363A38
		public static YamlNode ExportYamlEditor_Array_Node(this AssetList<Node> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601711D RID: 94493 RVA: 0x00365878 File Offset: 0x00363A78
		public static YamlNode ExportYamlEditor_Array_OcclusionScene(this AssetList<OcclusionScene> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601711E RID: 94494 RVA: 0x003658B8 File Offset: 0x00363AB8
		public static YamlNode ExportYamlEditor_Array_Pair_GUID_Int64(this AssetList<AssetPair<GUID, long>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor_Pair_GUID_Int64(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601711F RID: 94495 RVA: 0x003658F8 File Offset: 0x00363AF8
		public static YamlNode ExportYamlEditor_Array_Pair_Int32_PPtr_Component_3_4_0(this AssetList<AssetPair<int, PPtr_Component_3_4_0>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor_Pair_Int32_PPtr_Component_3_4_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017120 RID: 94496 RVA: 0x00365938 File Offset: 0x00363B38
		public static YamlNode ExportYamlEditor_Array_Pair_Int32_PPtr_Component_5_0_0(this AssetList<AssetPair<int, PPtr_Component_5_0_0>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor_Pair_Int32_PPtr_Component_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017121 RID: 94497 RVA: 0x00365978 File Offset: 0x00363B78
		public static YamlNode ExportYamlEditor_Array_Pair_Int32_Single(this AssetList<AssetPair<int, float>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor_Pair_Int32_Single(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017122 RID: 94498 RVA: 0x003659B8 File Offset: 0x00363BB8
		public static YamlNode ExportYamlEditor_Array_Pair_Int32_UInt32(this AssetList<AssetPair<int, uint>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor_Pair_Int32_UInt32(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017123 RID: 94499 RVA: 0x003659F8 File Offset: 0x00363BF8
		public static YamlNode ExportYamlEditor_Array_Pair_Pair_Int32_Int64_Utf8String(this AssetList<AssetPair<AssetPair<int, long>, Utf8String>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor_Pair_Pair_Int32_Int64_Utf8String(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017124 RID: 94500 RVA: 0x00365A38 File Offset: 0x00363C38
		public static YamlNode ExportYamlEditor_Array_Pair_PPtr_SphereCollider_PPtr_SphereCollider(this AssetList<AssetPair<PPtr_SphereCollider, PPtr_SphereCollider>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor_Pair_PPtr_SphereCollider_PPtr_SphereCollider(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017125 RID: 94501 RVA: 0x00365A78 File Offset: 0x00363C78
		public static YamlNode ExportYamlEditor_Array_Pair_Utf8String_Boolean(this AssetList<AssetPair<Utf8String, bool>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor_Pair_Utf8String_Boolean(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017126 RID: 94502 RVA: 0x00365AB8 File Offset: 0x00363CB8
		public static YamlNode ExportYamlEditor_Array_Pair_Utf8String_PPtr_Object_3_4_0(this AssetList<AssetPair<Utf8String, PPtr_Object_3_4_0>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor_Pair_Utf8String_PPtr_Object_3_4_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017127 RID: 94503 RVA: 0x00365AF8 File Offset: 0x00363CF8
		public static YamlNode ExportYamlEditor_Array_Pair_Utf8String_PPtr_Object_5_0_0(this AssetList<AssetPair<Utf8String, PPtr_Object_5_0_0>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor_Pair_Utf8String_PPtr_Object_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017128 RID: 94504 RVA: 0x00365B38 File Offset: 0x00363D38
		public static YamlNode ExportYamlEditor_Array_Pair_Utf8String_PPtr_Texture_3_4_0(this AssetList<AssetPair<Utf8String, PPtr_Texture_3_4_0>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor_Pair_Utf8String_PPtr_Texture_3_4_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017129 RID: 94505 RVA: 0x00365B78 File Offset: 0x00363D78
		public static YamlNode ExportYamlEditor_Array_Pair_Utf8String_PPtr_Texture_5_0_0(this AssetList<AssetPair<Utf8String, PPtr_Texture_5_0_0>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor_Pair_Utf8String_PPtr_Texture_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601712A RID: 94506 RVA: 0x00365BB8 File Offset: 0x00363DB8
		public static YamlNode ExportYamlEditor_Array_Pair_Utf8String_UInt32(this AssetList<AssetPair<Utf8String, uint>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor_Pair_Utf8String_UInt32(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601712B RID: 94507 RVA: 0x00365BF8 File Offset: 0x00363DF8
		public static YamlNode ExportYamlEditor_Array_Pair_Utf8String_Utf8String(this AssetList<AssetPair<Utf8String, Utf8String>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor_Pair_Utf8String_Utf8String(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601712C RID: 94508 RVA: 0x00365C38 File Offset: 0x00363E38
		public static YamlNode ExportYamlEditor_Array_Parameter(this AssetList<Parameter> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601712D RID: 94509 RVA: 0x00365C78 File Offset: 0x00363E78
		public static YamlNode ExportYamlEditor_Array_ParticleSystemEmissionBurst_2017_2_0(this AssetList<ParticleSystemEmissionBurst_2017_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601712E RID: 94510 RVA: 0x00365CB8 File Offset: 0x00363EB8
		public static YamlNode ExportYamlEditor_Array_ParticleSystemEmissionBurst_2017_3_0(this AssetList<ParticleSystemEmissionBurst_2017_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601712F RID: 94511 RVA: 0x00365CF8 File Offset: 0x00363EF8
		public static YamlNode ExportYamlEditor_Array_ParticleSystemEmissionBurst_2018_1_0(this AssetList<ParticleSystemEmissionBurst_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017130 RID: 94512 RVA: 0x00365D38 File Offset: 0x00363F38
		public static YamlNode ExportYamlEditor_Array_ParticleSystemEmissionBurst_2018_3_0(this AssetList<ParticleSystemEmissionBurst_2018_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017131 RID: 94513 RVA: 0x00365D78 File Offset: 0x00363F78
		public static YamlNode ExportYamlEditor_Array_ParticleSystemEmissionBurst_5_6_0_b5(this AssetList<ParticleSystemEmissionBurst_5_6_0_b5> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017132 RID: 94514 RVA: 0x00365DB8 File Offset: 0x00363FB8
		public static YamlNode ExportYamlEditor_Array_PerLODSettings_2018_3_0(this AssetList<PerLODSettings_2018_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017133 RID: 94515 RVA: 0x00365DF8 File Offset: 0x00363FF8
		public static YamlNode ExportYamlEditor_Array_PerLODSettings_5_0_0(this AssetList<PerLODSettings_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017134 RID: 94516 RVA: 0x00365E38 File Offset: 0x00364038
		public static YamlNode ExportYamlEditor_Array_PhysicsShape(this AssetList<PhysicsShape> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017135 RID: 94517 RVA: 0x00365E78 File Offset: 0x00364078
		public static YamlNode ExportYamlEditor_Array_PlatformIcon(this AssetList<PlatformIcon> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017136 RID: 94518 RVA: 0x00365EB8 File Offset: 0x003640B8
		public static YamlNode ExportYamlEditor_Array_PPtr_AnimationClip_3_4_0(this AssetList<PPtr_AnimationClip_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017137 RID: 94519 RVA: 0x00365EF8 File Offset: 0x003640F8
		public static YamlNode ExportYamlEditor_Array_PPtr_AnimationClip_5_0_0(this AssetList<PPtr_AnimationClip_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		public static YamlNode ExportYamlEditor_Array_PPtr_AnimationClip_5_0_0_GICB2(this AssetList<PPtr_AnimationClip_5_0_0_GICB2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017138 RID: 94520 RVA: 0x00365F38 File Offset: 0x00364138
		public static YamlNode ExportYamlEditor_Array_PPtr_AnimatorStateTransition(this AssetList<PPtr_AnimatorStateTransition> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017139 RID: 94521 RVA: 0x00365F78 File Offset: 0x00364178
		public static YamlNode ExportYamlEditor_Array_PPtr_AnimatorTransition(this AssetList<PPtr_AnimatorTransition> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601713A RID: 94522 RVA: 0x00365FB8 File Offset: 0x003641B8
		public static YamlNode ExportYamlEditor_Array_PPtr_AudioMixerEffectController(this AssetList<PPtr_AudioMixerEffectController> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601713B RID: 94523 RVA: 0x00365FF8 File Offset: 0x003641F8
		public static YamlNode ExportYamlEditor_Array_PPtr_AudioMixerGroup(this AssetList<PPtr_AudioMixerGroup> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601713C RID: 94524 RVA: 0x00366038 File Offset: 0x00364238
		public static YamlNode ExportYamlEditor_Array_PPtr_AudioMixerSnapshot(this AssetList<PPtr_AudioMixerSnapshot> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601713D RID: 94525 RVA: 0x00366078 File Offset: 0x00364278
		public static YamlNode ExportYamlEditor_Array_PPtr_AudioSource(this AssetList<PPtr_AudioSource> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601713E RID: 94526 RVA: 0x003660B8 File Offset: 0x003642B8
		public static YamlNode ExportYamlEditor_Array_PPtr_CapsuleCollider(this AssetList<PPtr_CapsuleCollider> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601713F RID: 94527 RVA: 0x003660F8 File Offset: 0x003642F8
		public static YamlNode ExportYamlEditor_Array_PPtr_Component_5_0_0(this AssetList<PPtr_Component_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017140 RID: 94528 RVA: 0x00366138 File Offset: 0x00364338
		public static YamlNode ExportYamlEditor_Array_PPtr_EditorExtension_3_4_0(this AssetList<PPtr_EditorExtension_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017141 RID: 94529 RVA: 0x00366178 File Offset: 0x00364378
		public static YamlNode ExportYamlEditor_Array_PPtr_Font_3_4_0(this AssetList<PPtr_Font_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017142 RID: 94530 RVA: 0x003661B8 File Offset: 0x003643B8
		public static YamlNode ExportYamlEditor_Array_PPtr_Font_5_0_0(this AssetList<PPtr_Font_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017143 RID: 94531 RVA: 0x003661F8 File Offset: 0x003643F8
		public static YamlNode ExportYamlEditor_Array_PPtr_GameObject_3_4_0(this AssetList<PPtr_GameObject_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017144 RID: 94532 RVA: 0x00366238 File Offset: 0x00364438
		public static YamlNode ExportYamlEditor_Array_PPtr_GameObject_5_0_0(this AssetList<PPtr_GameObject_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017145 RID: 94533 RVA: 0x00366278 File Offset: 0x00364478
		public static YamlNode ExportYamlEditor_Array_PPtr_Material_3_4_0(this AssetList<PPtr_Material_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017146 RID: 94534 RVA: 0x003662B8 File Offset: 0x003644B8
		public static YamlNode ExportYamlEditor_Array_PPtr_Material_5_0_0(this AssetList<PPtr_Material_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017147 RID: 94535 RVA: 0x003662F8 File Offset: 0x003644F8
		public static YamlNode ExportYamlEditor_Array_PPtr_MonoBehaviour_5_0_0(this AssetList<PPtr_MonoBehaviour_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017148 RID: 94536 RVA: 0x00366338 File Offset: 0x00364538
		public static YamlNode ExportYamlEditor_Array_PPtr_MonoScript_5_0_0(this AssetList<PPtr_MonoScript_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017149 RID: 94537 RVA: 0x00366378 File Offset: 0x00364578
		public static YamlNode ExportYamlEditor_Array_PPtr_Motion_4_0_0(this AssetList<PPtr_Motion_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601714A RID: 94538 RVA: 0x003663B8 File Offset: 0x003645B8
		public static YamlNode ExportYamlEditor_Array_PPtr_Object_3_4_0(this AssetList<PPtr_Object_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601714B RID: 94539 RVA: 0x003663F8 File Offset: 0x003645F8
		public static YamlNode ExportYamlEditor_Array_PPtr_Object_5_0_0(this AssetList<PPtr_Object_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601714C RID: 94540 RVA: 0x00366438 File Offset: 0x00364638
		public static YamlNode ExportYamlEditor_Array_PPtr_OcclusionPortal_3_5_0(this AssetList<PPtr_OcclusionPortal_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601714D RID: 94541 RVA: 0x00366478 File Offset: 0x00364678
		public static YamlNode ExportYamlEditor_Array_PPtr_OcclusionPortal_5_0_0(this AssetList<PPtr_OcclusionPortal_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601714E RID: 94542 RVA: 0x003664B8 File Offset: 0x003646B8
		public static YamlNode ExportYamlEditor_Array_PPtr_ParticleSystemForceField(this AssetList<PPtr_ParticleSystemForceField> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601714F RID: 94543 RVA: 0x003664F8 File Offset: 0x003646F8
		public static YamlNode ExportYamlEditor_Array_PPtr_ProceduralTexture_3_4_0(this AssetList<PPtr_ProceduralTexture_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017150 RID: 94544 RVA: 0x00366538 File Offset: 0x00364738
		public static YamlNode ExportYamlEditor_Array_PPtr_ProceduralTexture_5_0_0(this AssetList<PPtr_ProceduralTexture_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017151 RID: 94545 RVA: 0x00366578 File Offset: 0x00364778
		public static YamlNode ExportYamlEditor_Array_PPtr_Renderer_3_4_0(this AssetList<PPtr_Renderer_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017152 RID: 94546 RVA: 0x003665B8 File Offset: 0x003647B8
		public static YamlNode ExportYamlEditor_Array_PPtr_Renderer_5_0_0(this AssetList<PPtr_Renderer_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017153 RID: 94547 RVA: 0x003665F8 File Offset: 0x003647F8
		public static YamlNode ExportYamlEditor_Array_PPtr_Shader_3_4_0(this AssetList<PPtr_Shader_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017154 RID: 94548 RVA: 0x00366638 File Offset: 0x00364838
		public static YamlNode ExportYamlEditor_Array_PPtr_Shader_5_0_0(this AssetList<PPtr_Shader_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017155 RID: 94549 RVA: 0x00366678 File Offset: 0x00364878
		public static YamlNode ExportYamlEditor_Array_PPtr_ShaderVariantCollection(this AssetList<PPtr_ShaderVariantCollection> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017156 RID: 94550 RVA: 0x003666B8 File Offset: 0x003648B8
		public static YamlNode ExportYamlEditor_Array_PPtr_Sprite_5_0_0(this AssetList<PPtr_Sprite_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017157 RID: 94551 RVA: 0x003666F8 File Offset: 0x003648F8
		public static YamlNode ExportYamlEditor_Array_PPtr_SpriteAtlas(this AssetList<PPtr_SpriteAtlas> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017158 RID: 94552 RVA: 0x00366738 File Offset: 0x00364938
		public static YamlNode ExportYamlEditor_Array_PPtr_State(this AssetList<PPtr_State> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017159 RID: 94553 RVA: 0x00366778 File Offset: 0x00364978
		public static YamlNode ExportYamlEditor_Array_PPtr_StateMachine(this AssetList<PPtr_StateMachine> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601715A RID: 94554 RVA: 0x003667B8 File Offset: 0x003649B8
		public static YamlNode ExportYamlEditor_Array_PPtr_TerrainLayer(this AssetList<PPtr_TerrainLayer> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601715B RID: 94555 RVA: 0x003667F8 File Offset: 0x003649F8
		public static YamlNode ExportYamlEditor_Array_PPtr_Texture_5_0_0(this AssetList<PPtr_Texture_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601715C RID: 94556 RVA: 0x00366838 File Offset: 0x00364A38
		public static YamlNode ExportYamlEditor_Array_PPtr_Texture2D_3_4_0(this AssetList<PPtr_Texture2D_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601715D RID: 94557 RVA: 0x00366878 File Offset: 0x00364A78
		public static YamlNode ExportYamlEditor_Array_PPtr_Texture2D_5_0_0(this AssetList<PPtr_Texture2D_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601715E RID: 94558 RVA: 0x003668B8 File Offset: 0x00364AB8
		public static YamlNode ExportYamlEditor_Array_PPtr_Transform_3_4_0(this AssetList<PPtr_Transform_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601715F RID: 94559 RVA: 0x003668F8 File Offset: 0x00364AF8
		public static YamlNode ExportYamlEditor_Array_PPtr_Transform_5_0_0(this AssetList<PPtr_Transform_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017160 RID: 94560 RVA: 0x00366938 File Offset: 0x00364B38
		public static YamlNode ExportYamlEditor_Array_PPtr_Transition(this AssetList<PPtr_Transition> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017161 RID: 94561 RVA: 0x00366978 File Offset: 0x00364B78
		public static YamlNode ExportYamlEditor_Array_PPtrCurve_2017_1_0(this AssetList<PPtrCurve_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017162 RID: 94562 RVA: 0x003669B8 File Offset: 0x00364BB8
		public static YamlNode ExportYamlEditor_Array_PPtrCurve_2022_2_0(this AssetList<PPtrCurve_2022_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017163 RID: 94563 RVA: 0x003669F8 File Offset: 0x00364BF8
		public static YamlNode ExportYamlEditor_Array_PPtrCurve_4_3_0(this AssetList<PPtrCurve_4_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017164 RID: 94564 RVA: 0x00366A38 File Offset: 0x00364C38
		public static YamlNode ExportYamlEditor_Array_PPtrCurve_5_0_0(this AssetList<PPtrCurve_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017165 RID: 94565 RVA: 0x00366A78 File Offset: 0x00364C78
		public static YamlNode ExportYamlEditor_Array_PPtrCurve_5_6_0(this AssetList<PPtrCurve_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017166 RID: 94566 RVA: 0x00366AB8 File Offset: 0x00364CB8
		public static YamlNode ExportYamlEditor_Array_PPtrKeyframe_4_3_0(this AssetList<PPtrKeyframe_4_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017167 RID: 94567 RVA: 0x00366AF8 File Offset: 0x00364CF8
		public static YamlNode ExportYamlEditor_Array_PPtrKeyframe_5_0_0(this AssetList<PPtrKeyframe_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017168 RID: 94568 RVA: 0x00366B38 File Offset: 0x00364D38
		public static YamlNode ExportYamlEditor_Array_ProbeSetIndex(this AssetList<ProbeSetIndex> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017169 RID: 94569 RVA: 0x00366B78 File Offset: 0x00364D78
		public static YamlNode ExportYamlEditor_Array_ProceduralTextureAssignment_4_5_0(this AssetList<ProceduralTextureAssignment_4_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601716A RID: 94570 RVA: 0x00366BB8 File Offset: 0x00364DB8
		public static YamlNode ExportYamlEditor_Array_ProceduralTextureAssignment_5_0_0(this AssetList<ProceduralTextureAssignment_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601716B RID: 94571 RVA: 0x00366BF8 File Offset: 0x00364DF8
		public static YamlNode ExportYamlEditor_Array_ProceduralTextureAssignment_5_6_0(this AssetList<ProceduralTextureAssignment_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601716C RID: 94572 RVA: 0x00366C38 File Offset: 0x00364E38
		public static YamlNode ExportYamlEditor_Array_PropertyModification_3_5_0(this AssetList<PropertyModification_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601716D RID: 94573 RVA: 0x00366C78 File Offset: 0x00364E78
		public static YamlNode ExportYamlEditor_Array_PropertyModification_5_0_0(this AssetList<PropertyModification_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601716E RID: 94574 RVA: 0x00366CB8 File Offset: 0x00364EB8
		public static YamlNode ExportYamlEditor_Array_PropertyModificationsTargetTestNativeObject(this AssetList<PropertyModificationsTargetTestNativeObject> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601716F RID: 94575 RVA: 0x00366CF8 File Offset: 0x00364EF8
		public static YamlNode ExportYamlEditor_Array_QualitySetting_2017_1_0(this AssetList<QualitySetting_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017170 RID: 94576 RVA: 0x00366D38 File Offset: 0x00364F38
		public static YamlNode ExportYamlEditor_Array_QualitySetting_2018_2_0(this AssetList<QualitySetting_2018_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017171 RID: 94577 RVA: 0x00366D78 File Offset: 0x00364F78
		public static YamlNode ExportYamlEditor_Array_QualitySetting_2018_3_0(this AssetList<QualitySetting_2018_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017172 RID: 94578 RVA: 0x00366DB8 File Offset: 0x00364FB8
		public static YamlNode ExportYamlEditor_Array_QualitySetting_2019_1_0(this AssetList<QualitySetting_2019_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017173 RID: 94579 RVA: 0x00366DF8 File Offset: 0x00364FF8
		public static YamlNode ExportYamlEditor_Array_QualitySetting_2019_3_0_a6(this AssetList<QualitySetting_2019_3_0_a6> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017174 RID: 94580 RVA: 0x00366E38 File Offset: 0x00365038
		public static YamlNode ExportYamlEditor_Array_QualitySetting_2022_2_0(this AssetList<QualitySetting_2022_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017175 RID: 94581 RVA: 0x00366E78 File Offset: 0x00365078
		public static YamlNode ExportYamlEditor_Array_QualitySetting_2022_2_0_a16(this AssetList<QualitySetting_2022_2_0_a16> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017176 RID: 94582 RVA: 0x00366EB8 File Offset: 0x003650B8
		public static YamlNode ExportYamlEditor_Array_QualitySetting_2022_2_0_a18(this AssetList<QualitySetting_2022_2_0_a18> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017177 RID: 94583 RVA: 0x00366EF8 File Offset: 0x003650F8
		public static YamlNode ExportYamlEditor_Array_QualitySetting_2022_2_0_b3(this AssetList<QualitySetting_2022_2_0_b3> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017178 RID: 94584 RVA: 0x00366F38 File Offset: 0x00365138
		public static YamlNode ExportYamlEditor_Array_QualitySetting_3_5_0(this AssetList<QualitySetting_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017179 RID: 94585 RVA: 0x00366F78 File Offset: 0x00365178
		public static YamlNode ExportYamlEditor_Array_QualitySetting_4_0_0(this AssetList<QualitySetting_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601717A RID: 94586 RVA: 0x00366FB8 File Offset: 0x003651B8
		public static YamlNode ExportYamlEditor_Array_QualitySetting_5_0_0(this AssetList<QualitySetting_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601717B RID: 94587 RVA: 0x00366FF8 File Offset: 0x003651F8
		public static YamlNode ExportYamlEditor_Array_QualitySetting_5_2_0(this AssetList<QualitySetting_5_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601717C RID: 94588 RVA: 0x00367038 File Offset: 0x00365238
		public static YamlNode ExportYamlEditor_Array_QualitySetting_5_3_0(this AssetList<QualitySetting_5_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601717D RID: 94589 RVA: 0x00367078 File Offset: 0x00365278
		public static YamlNode ExportYamlEditor_Array_QuaternionCurve_2017_1_0(this AssetList<QuaternionCurve_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601717E RID: 94590 RVA: 0x003670B8 File Offset: 0x003652B8
		public static YamlNode ExportYamlEditor_Array_QuaternionCurve_2018_1_0(this AssetList<QuaternionCurve_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601717F RID: 94591 RVA: 0x003670F8 File Offset: 0x003652F8
		public static YamlNode ExportYamlEditor_Array_QuaternionCurve_3_4_0(this AssetList<QuaternionCurve_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017180 RID: 94592 RVA: 0x00367138 File Offset: 0x00365338
		public static YamlNode ExportYamlEditor_Array_QuaternionCurve_3_5_0(this AssetList<QuaternionCurve_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017181 RID: 94593 RVA: 0x00367178 File Offset: 0x00365378
		public static YamlNode ExportYamlEditor_Array_QuaternionCurve_5_3_0(this AssetList<QuaternionCurve_5_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017182 RID: 94594 RVA: 0x003671B8 File Offset: 0x003653B8
		public static YamlNode ExportYamlEditor_Array_QuaternionCurve_5_5_0(this AssetList<QuaternionCurve_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017183 RID: 94595 RVA: 0x003671F8 File Offset: 0x003653F8
		public static YamlNode ExportYamlEditor_Array_RayTracingShaderBuiltinSampler(this AssetList<RayTracingShaderBuiltinSampler> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017184 RID: 94596 RVA: 0x00367238 File Offset: 0x00365438
		public static YamlNode ExportYamlEditor_Array_RayTracingShaderConstantBuffer_2019_3_0_a10(this AssetList<RayTracingShaderConstantBuffer_2019_3_0_a10> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017185 RID: 94597 RVA: 0x00367278 File Offset: 0x00365478
		public static YamlNode ExportYamlEditor_Array_RayTracingShaderConstantBuffer_2020_1_0_a17(this AssetList<RayTracingShaderConstantBuffer_2020_1_0_a17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017186 RID: 94598 RVA: 0x003672B8 File Offset: 0x003654B8
		public static YamlNode ExportYamlEditor_Array_RayTracingShaderConstantBuffer_2020_1_0_b10(this AssetList<RayTracingShaderConstantBuffer_2020_1_0_b10> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017187 RID: 94599 RVA: 0x003672F8 File Offset: 0x003654F8
		public static YamlNode ExportYamlEditor_Array_RayTracingShaderConstantBuffer_2021_1_0_a4(this AssetList<RayTracingShaderConstantBuffer_2021_1_0_a4> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017188 RID: 94600 RVA: 0x00367338 File Offset: 0x00365538
		public static YamlNode ExportYamlEditor_Array_RayTracingShaderFunctionDesc(this AssetList<RayTracingShaderFunctionDesc> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017189 RID: 94601 RVA: 0x00367378 File Offset: 0x00365578
		public static YamlNode ExportYamlEditor_Array_RayTracingShaderParam_2019_3_0_a10(this AssetList<RayTracingShaderParam_2019_3_0_a10> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601718A RID: 94602 RVA: 0x003673B8 File Offset: 0x003655B8
		public static YamlNode ExportYamlEditor_Array_RayTracingShaderParam_2020_1_0_a17(this AssetList<RayTracingShaderParam_2020_1_0_a17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601718B RID: 94603 RVA: 0x003673F8 File Offset: 0x003655F8
		public static YamlNode ExportYamlEditor_Array_RayTracingShaderParam_2021_1_0_a4(this AssetList<RayTracingShaderParam_2021_1_0_a4> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601718C RID: 94604 RVA: 0x00367438 File Offset: 0x00365638
		public static YamlNode ExportYamlEditor_Array_RayTracingShaderResource_2019_3_0_a10(this AssetList<RayTracingShaderResource_2019_3_0_a10> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601718D RID: 94605 RVA: 0x00367478 File Offset: 0x00365678
		public static YamlNode ExportYamlEditor_Array_RayTracingShaderResource_2020_1_0_a17(this AssetList<RayTracingShaderResource_2020_1_0_a17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601718E RID: 94606 RVA: 0x003674B8 File Offset: 0x003656B8
		public static YamlNode ExportYamlEditor_Array_RayTracingShaderResource_2020_1_0_b10(this AssetList<RayTracingShaderResource_2020_1_0_b10> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601718F RID: 94607 RVA: 0x003674F8 File Offset: 0x003656F8
		public static YamlNode ExportYamlEditor_Array_RayTracingShaderVariant_2019_3_0_a10(this AssetList<RayTracingShaderVariant_2019_3_0_a10> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017190 RID: 94608 RVA: 0x00367538 File Offset: 0x00365738
		public static YamlNode ExportYamlEditor_Array_RayTracingShaderVariant_2020_1_0_a17(this AssetList<RayTracingShaderVariant_2020_1_0_a17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017191 RID: 94609 RVA: 0x00367578 File Offset: 0x00365778
		public static YamlNode ExportYamlEditor_Array_RayTracingShaderVariant_2020_1_0_b10(this AssetList<RayTracingShaderVariant_2020_1_0_b10> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017192 RID: 94610 RVA: 0x003675B8 File Offset: 0x003657B8
		public static YamlNode ExportYamlEditor_Array_RayTracingShaderVariant_2021_1_0_a4(this AssetList<RayTracingShaderVariant_2021_1_0_a4> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017193 RID: 94611 RVA: 0x003675F8 File Offset: 0x003657F8
		public static YamlNode ExportYamlEditor_Array_RayTracingShaderVariant_2022_2_0(this AssetList<RayTracingShaderVariant_2022_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017194 RID: 94612 RVA: 0x00367638 File Offset: 0x00365838
		public static YamlNode ExportYamlEditor_Array_RendererData_2018_2_0(this AssetList<RendererData_2018_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017195 RID: 94613 RVA: 0x00367678 File Offset: 0x00365878
		public static YamlNode ExportYamlEditor_Array_RendererData_5_0_0(this AssetList<RendererData_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017196 RID: 94614 RVA: 0x003676B8 File Offset: 0x003658B8
		public static YamlNode ExportYamlEditor_Array_SamplerParameter(this AssetList<SamplerParameter> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017197 RID: 94615 RVA: 0x003676F8 File Offset: 0x003658F8
		public static YamlNode ExportYamlEditor_Array_SByte(this sbyte[] value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int num = value.Length;
			for (int i = 0; i < num; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor_SByte(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017198 RID: 94616 RVA: 0x00367730 File Offset: 0x00365930
		public static YamlNode ExportYamlEditor_Array_Scene_3_4_0(this AssetList<Scene_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017199 RID: 94617 RVA: 0x00367770 File Offset: 0x00365970
		public static YamlNode ExportYamlEditor_Array_Scene_5_6_0_b10(this AssetList<Scene_5_6_0_b10> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601719A RID: 94618 RVA: 0x003677B0 File Offset: 0x003659B0
		public static YamlNode ExportYamlEditor_Array_SceneObjectIdentifier(this AssetList<SceneObjectIdentifier> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601719B RID: 94619 RVA: 0x003677F0 File Offset: 0x003659F0
		public static YamlNode ExportYamlEditor_Array_SecondarySpriteTexture(this AssetList<SecondarySpriteTexture> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601719C RID: 94620 RVA: 0x00367830 File Offset: 0x00365A30
		public static YamlNode ExportYamlEditor_Array_SerializedCustomEditorForRenderPipeline(this AssetList<SerializedCustomEditorForRenderPipeline> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601719D RID: 94621 RVA: 0x00367870 File Offset: 0x00365A70
		public static YamlNode ExportYamlEditor_Array_SerializedPackageRequirement_2020_3_16(this AssetList<SerializedPackageRequirement_2020_3_16> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601719E RID: 94622 RVA: 0x003678B0 File Offset: 0x00365AB0
		public static YamlNode ExportYamlEditor_Array_SerializedPackageRequirement_2021_1_17(this AssetList<SerializedPackageRequirement_2021_1_17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601719F RID: 94623 RVA: 0x003678F0 File Offset: 0x00365AF0
		public static YamlNode ExportYamlEditor_Array_SerializedPackageRequirement_2021_2_0_a17(this AssetList<SerializedPackageRequirement_2021_2_0_a17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171A0 RID: 94624 RVA: 0x00367930 File Offset: 0x00365B30
		public static YamlNode ExportYamlEditor_Array_SerializedPass_2017_1_0(this AssetList<SerializedPass_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171A1 RID: 94625 RVA: 0x00367970 File Offset: 0x00365B70
		public static YamlNode ExportYamlEditor_Array_SerializedPass_2017_2_0(this AssetList<SerializedPass_2017_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171A2 RID: 94626 RVA: 0x003679B0 File Offset: 0x00365BB0
		public static YamlNode ExportYamlEditor_Array_SerializedPass_2017_3_0(this AssetList<SerializedPass_2017_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171A3 RID: 94627 RVA: 0x003679F0 File Offset: 0x00365BF0
		public static YamlNode ExportYamlEditor_Array_SerializedPass_2018_1_0(this AssetList<SerializedPass_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171A4 RID: 94628 RVA: 0x00367A30 File Offset: 0x00365C30
		public static YamlNode ExportYamlEditor_Array_SerializedPass_2019_1_0(this AssetList<SerializedPass_2019_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171A5 RID: 94629 RVA: 0x00367A70 File Offset: 0x00365C70
		public static YamlNode ExportYamlEditor_Array_SerializedPass_2019_3_0_a7(this AssetList<SerializedPass_2019_3_0_a7> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171A6 RID: 94630 RVA: 0x00367AB0 File Offset: 0x00365CB0
		public static YamlNode ExportYamlEditor_Array_SerializedPass_2020_1_0_a17(this AssetList<SerializedPass_2020_1_0_a17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171A7 RID: 94631 RVA: 0x00367AF0 File Offset: 0x00365CF0
		public static YamlNode ExportYamlEditor_Array_SerializedPass_2020_2_0_a15(this AssetList<SerializedPass_2020_2_0_a15> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171A8 RID: 94632 RVA: 0x00367B30 File Offset: 0x00365D30
		public static YamlNode ExportYamlEditor_Array_SerializedPass_2020_3_16(this AssetList<SerializedPass_2020_3_16> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171A9 RID: 94633 RVA: 0x00367B70 File Offset: 0x00365D70
		public static YamlNode ExportYamlEditor_Array_SerializedPass_2020_3_2(this AssetList<SerializedPass_2020_3_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171AA RID: 94634 RVA: 0x00367BB0 File Offset: 0x00365DB0
		public static YamlNode ExportYamlEditor_Array_SerializedPass_2021_1_0(this AssetList<SerializedPass_2021_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171AB RID: 94635 RVA: 0x00367BF0 File Offset: 0x00365DF0
		public static YamlNode ExportYamlEditor_Array_SerializedPass_2021_1_1(this AssetList<SerializedPass_2021_1_1> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171AC RID: 94636 RVA: 0x00367C30 File Offset: 0x00365E30
		public static YamlNode ExportYamlEditor_Array_SerializedPass_2021_1_17(this AssetList<SerializedPass_2021_1_17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171AD RID: 94637 RVA: 0x00367C70 File Offset: 0x00365E70
		public static YamlNode ExportYamlEditor_Array_SerializedPass_2021_2_0(this AssetList<SerializedPass_2021_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171AE RID: 94638 RVA: 0x00367CB0 File Offset: 0x00365EB0
		public static YamlNode ExportYamlEditor_Array_SerializedPass_2021_2_0_a16(this AssetList<SerializedPass_2021_2_0_a16> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171AF RID: 94639 RVA: 0x00367CF0 File Offset: 0x00365EF0
		public static YamlNode ExportYamlEditor_Array_SerializedPass_2021_2_0_a17(this AssetList<SerializedPass_2021_2_0_a17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171B0 RID: 94640 RVA: 0x00367D30 File Offset: 0x00365F30
		public static YamlNode ExportYamlEditor_Array_SerializedPass_2021_3_10(this AssetList<SerializedPass_2021_3_10> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171B1 RID: 94641 RVA: 0x00367D70 File Offset: 0x00365F70
		public static YamlNode ExportYamlEditor_Array_SerializedPass_2022_1_0(this AssetList<SerializedPass_2022_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171B2 RID: 94642 RVA: 0x00367DB0 File Offset: 0x00365FB0
		public static YamlNode ExportYamlEditor_Array_SerializedPass_2022_1_0_b3(this AssetList<SerializedPass_2022_1_0_b3> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171B3 RID: 94643 RVA: 0x00367DF0 File Offset: 0x00365FF0
		public static YamlNode ExportYamlEditor_Array_SerializedPass_2022_1_13(this AssetList<SerializedPass_2022_1_13> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171B4 RID: 94644 RVA: 0x00367E30 File Offset: 0x00366030
		public static YamlNode ExportYamlEditor_Array_SerializedPass_2022_2_0(this AssetList<SerializedPass_2022_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171B5 RID: 94645 RVA: 0x00367E70 File Offset: 0x00366070
		public static YamlNode ExportYamlEditor_Array_SerializedPass_2022_2_0_b5(this AssetList<SerializedPass_2022_2_0_b5> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171B6 RID: 94646 RVA: 0x00367EB0 File Offset: 0x003660B0
		public static YamlNode ExportYamlEditor_Array_SerializedPass_5_5_0(this AssetList<SerializedPass_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171B7 RID: 94647 RVA: 0x00367EF0 File Offset: 0x003660F0
		public static YamlNode ExportYamlEditor_Array_SerializedPass_5_6_0(this AssetList<SerializedPass_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171B8 RID: 94648 RVA: 0x00367F30 File Offset: 0x00366130
		public static YamlNode ExportYamlEditor_Array_SerializedPlayerSubProgram_2021_3_10(this AssetList<SerializedPlayerSubProgram_2021_3_10> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171B9 RID: 94649 RVA: 0x00367F70 File Offset: 0x00366170
		public static YamlNode ExportYamlEditor_Array_SerializedPlayerSubProgram_2022_1_13(this AssetList<SerializedPlayerSubProgram_2022_1_13> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171BA RID: 94650 RVA: 0x00367FB0 File Offset: 0x003661B0
		public static YamlNode ExportYamlEditor_Array_SerializedPlayerSubProgram_2022_2_0_b5(this AssetList<SerializedPlayerSubProgram_2022_2_0_b5> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171BB RID: 94651 RVA: 0x00367FF0 File Offset: 0x003661F0
		public static YamlNode ExportYamlEditor_Array_SerializedProperty_2017_1_0(this AssetList<SerializedProperty_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171BC RID: 94652 RVA: 0x00368030 File Offset: 0x00366230
		public static YamlNode ExportYamlEditor_Array_SerializedProperty_5_5_0(this AssetList<SerializedProperty_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171BD RID: 94653 RVA: 0x00368070 File Offset: 0x00366270
		public static YamlNode ExportYamlEditor_Array_SerializedShaderDependency(this AssetList<SerializedShaderDependency> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171BE RID: 94654 RVA: 0x003680B0 File Offset: 0x003662B0
		public static YamlNode ExportYamlEditor_Array_SerializedSubProgram_2017_1_0(this AssetList<SerializedSubProgram_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171BF RID: 94655 RVA: 0x003680F0 File Offset: 0x003662F0
		public static YamlNode ExportYamlEditor_Array_SerializedSubProgram_2017_2_0(this AssetList<SerializedSubProgram_2017_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171C0 RID: 94656 RVA: 0x00368130 File Offset: 0x00366330
		public static YamlNode ExportYamlEditor_Array_SerializedSubProgram_2017_3_0(this AssetList<SerializedSubProgram_2017_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171C1 RID: 94657 RVA: 0x00368170 File Offset: 0x00366370
		public static YamlNode ExportYamlEditor_Array_SerializedSubProgram_2019_1_0(this AssetList<SerializedSubProgram_2019_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171C2 RID: 94658 RVA: 0x003681B0 File Offset: 0x003663B0
		public static YamlNode ExportYamlEditor_Array_SerializedSubProgram_2020_1_0_a17(this AssetList<SerializedSubProgram_2020_1_0_a17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171C3 RID: 94659 RVA: 0x003681F0 File Offset: 0x003663F0
		public static YamlNode ExportYamlEditor_Array_SerializedSubProgram_2020_3_2(this AssetList<SerializedSubProgram_2020_3_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171C4 RID: 94660 RVA: 0x00368230 File Offset: 0x00366430
		public static YamlNode ExportYamlEditor_Array_SerializedSubProgram_2021_1_0(this AssetList<SerializedSubProgram_2021_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171C5 RID: 94661 RVA: 0x00368270 File Offset: 0x00366470
		public static YamlNode ExportYamlEditor_Array_SerializedSubProgram_2021_1_1(this AssetList<SerializedSubProgram_2021_1_1> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171C6 RID: 94662 RVA: 0x003682B0 File Offset: 0x003664B0
		public static YamlNode ExportYamlEditor_Array_SerializedSubProgram_2021_2_0_a16(this AssetList<SerializedSubProgram_2021_2_0_a16> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171C7 RID: 94663 RVA: 0x003682F0 File Offset: 0x003664F0
		public static YamlNode ExportYamlEditor_Array_SerializedSubProgram_5_5_0(this AssetList<SerializedSubProgram_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171C8 RID: 94664 RVA: 0x00368330 File Offset: 0x00366530
		public static YamlNode ExportYamlEditor_Array_SerializedSubProgram_5_6_0(this AssetList<SerializedSubProgram_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171C9 RID: 94665 RVA: 0x00368370 File Offset: 0x00366570
		public static YamlNode ExportYamlEditor_Array_SerializedSubShader_2017_1_0(this AssetList<SerializedSubShader_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171CA RID: 94666 RVA: 0x003683B0 File Offset: 0x003665B0
		public static YamlNode ExportYamlEditor_Array_SerializedSubShader_2017_2_0(this AssetList<SerializedSubShader_2017_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171CB RID: 94667 RVA: 0x003683F0 File Offset: 0x003665F0
		public static YamlNode ExportYamlEditor_Array_SerializedSubShader_2017_3_0(this AssetList<SerializedSubShader_2017_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171CC RID: 94668 RVA: 0x00368430 File Offset: 0x00366630
		public static YamlNode ExportYamlEditor_Array_SerializedSubShader_2018_1_0(this AssetList<SerializedSubShader_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171CD RID: 94669 RVA: 0x00368470 File Offset: 0x00366670
		public static YamlNode ExportYamlEditor_Array_SerializedSubShader_2019_1_0(this AssetList<SerializedSubShader_2019_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171CE RID: 94670 RVA: 0x003684B0 File Offset: 0x003666B0
		public static YamlNode ExportYamlEditor_Array_SerializedSubShader_2019_3_0_a7(this AssetList<SerializedSubShader_2019_3_0_a7> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171CF RID: 94671 RVA: 0x003684F0 File Offset: 0x003666F0
		public static YamlNode ExportYamlEditor_Array_SerializedSubShader_2020_1_0_a17(this AssetList<SerializedSubShader_2020_1_0_a17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171D0 RID: 94672 RVA: 0x00368530 File Offset: 0x00366730
		public static YamlNode ExportYamlEditor_Array_SerializedSubShader_2020_2_0_a15(this AssetList<SerializedSubShader_2020_2_0_a15> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171D1 RID: 94673 RVA: 0x00368570 File Offset: 0x00366770
		public static YamlNode ExportYamlEditor_Array_SerializedSubShader_2020_3_16(this AssetList<SerializedSubShader_2020_3_16> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171D2 RID: 94674 RVA: 0x003685B0 File Offset: 0x003667B0
		public static YamlNode ExportYamlEditor_Array_SerializedSubShader_2020_3_2(this AssetList<SerializedSubShader_2020_3_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171D3 RID: 94675 RVA: 0x003685F0 File Offset: 0x003667F0
		public static YamlNode ExportYamlEditor_Array_SerializedSubShader_2021_1_0(this AssetList<SerializedSubShader_2021_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171D4 RID: 94676 RVA: 0x00368630 File Offset: 0x00366830
		public static YamlNode ExportYamlEditor_Array_SerializedSubShader_2021_1_1(this AssetList<SerializedSubShader_2021_1_1> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171D5 RID: 94677 RVA: 0x00368670 File Offset: 0x00366870
		public static YamlNode ExportYamlEditor_Array_SerializedSubShader_2021_1_17(this AssetList<SerializedSubShader_2021_1_17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171D6 RID: 94678 RVA: 0x003686B0 File Offset: 0x003668B0
		public static YamlNode ExportYamlEditor_Array_SerializedSubShader_2021_2_0(this AssetList<SerializedSubShader_2021_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171D7 RID: 94679 RVA: 0x003686F0 File Offset: 0x003668F0
		public static YamlNode ExportYamlEditor_Array_SerializedSubShader_2021_2_0_a16(this AssetList<SerializedSubShader_2021_2_0_a16> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171D8 RID: 94680 RVA: 0x00368730 File Offset: 0x00366930
		public static YamlNode ExportYamlEditor_Array_SerializedSubShader_2021_2_0_a17(this AssetList<SerializedSubShader_2021_2_0_a17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171D9 RID: 94681 RVA: 0x00368770 File Offset: 0x00366970
		public static YamlNode ExportYamlEditor_Array_SerializedSubShader_2021_3_10(this AssetList<SerializedSubShader_2021_3_10> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171DA RID: 94682 RVA: 0x003687B0 File Offset: 0x003669B0
		public static YamlNode ExportYamlEditor_Array_SerializedSubShader_2022_1_0(this AssetList<SerializedSubShader_2022_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171DB RID: 94683 RVA: 0x003687F0 File Offset: 0x003669F0
		public static YamlNode ExportYamlEditor_Array_SerializedSubShader_2022_1_0_b3(this AssetList<SerializedSubShader_2022_1_0_b3> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171DC RID: 94684 RVA: 0x00368830 File Offset: 0x00366A30
		public static YamlNode ExportYamlEditor_Array_SerializedSubShader_2022_1_13(this AssetList<SerializedSubShader_2022_1_13> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171DD RID: 94685 RVA: 0x00368870 File Offset: 0x00366A70
		public static YamlNode ExportYamlEditor_Array_SerializedSubShader_2022_2_0(this AssetList<SerializedSubShader_2022_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171DE RID: 94686 RVA: 0x003688B0 File Offset: 0x00366AB0
		public static YamlNode ExportYamlEditor_Array_SerializedSubShader_2022_2_0_b5(this AssetList<SerializedSubShader_2022_2_0_b5> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171DF RID: 94687 RVA: 0x003688F0 File Offset: 0x00366AF0
		public static YamlNode ExportYamlEditor_Array_SerializedSubShader_5_5_0(this AssetList<SerializedSubShader_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171E0 RID: 94688 RVA: 0x00368930 File Offset: 0x00366B30
		public static YamlNode ExportYamlEditor_Array_SerializedSubShader_5_6_0(this AssetList<SerializedSubShader_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171E1 RID: 94689 RVA: 0x00368970 File Offset: 0x00366B70
		public static YamlNode ExportYamlEditor_Array_ShaderBindChannel(this AssetList<ShaderBindChannel> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171E2 RID: 94690 RVA: 0x003689B0 File Offset: 0x00366BB0
		public static YamlNode ExportYamlEditor_Array_ShaderError_3_4_0(this AssetList<ShaderError_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171E3 RID: 94691 RVA: 0x003689F0 File Offset: 0x00366BF0
		public static YamlNode ExportYamlEditor_Array_ShaderError_3_5_0(this AssetList<ShaderError_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171E4 RID: 94692 RVA: 0x00368A30 File Offset: 0x00366C30
		public static YamlNode ExportYamlEditor_Array_ShaderError_4_5_0(this AssetList<ShaderError_4_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171E5 RID: 94693 RVA: 0x00368A70 File Offset: 0x00366C70
		public static YamlNode ExportYamlEditor_Array_ShaderError_5_5_0(this AssetList<ShaderError_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171E6 RID: 94694 RVA: 0x00368AB0 File Offset: 0x00366CB0
		public static YamlNode ExportYamlEditor_Array_Single(this float[] value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int num = value.Length;
			for (int i = 0; i < num; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor_Single(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171E7 RID: 94695 RVA: 0x00368AE8 File Offset: 0x00366CE8
		public static YamlNode ExportYamlEditor_Array_SkeletonBone_4_0_0(this AssetList<SkeletonBone_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171E8 RID: 94696 RVA: 0x00368B28 File Offset: 0x00366D28
		public static YamlNode ExportYamlEditor_Array_SkeletonBone_5_5_0(this AssetList<SkeletonBone_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171E9 RID: 94697 RVA: 0x00368B68 File Offset: 0x00366D68
		public static YamlNode ExportYamlEditor_Array_SketchUpImportScene_2019_1_0(this AssetList<SketchUpImportScene_2019_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171EA RID: 94698 RVA: 0x00368BA8 File Offset: 0x00366DA8
		public static YamlNode ExportYamlEditor_Array_SketchUpImportScene_5_1_0(this AssetList<SketchUpImportScene_5_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171EB RID: 94699 RVA: 0x00368BE8 File Offset: 0x00366DE8
		public static YamlNode ExportYamlEditor_Array_SortingLayerEntry_4_3_0(this AssetList<SortingLayerEntry_4_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171EC RID: 94700 RVA: 0x00368C28 File Offset: 0x00366E28
		public static YamlNode ExportYamlEditor_Array_SortingLayerEntry_5_0_0(this AssetList<SortingLayerEntry_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171ED RID: 94701 RVA: 0x00368C68 File Offset: 0x00366E68
		public static YamlNode ExportYamlEditor_Array_SphericalHarmonicsL2_3_5_0(this AssetList<SphericalHarmonicsL2_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171EE RID: 94702 RVA: 0x00368CA8 File Offset: 0x00366EA8
		public static YamlNode ExportYamlEditor_Array_SphericalHarmonicsL2_5_0_0(this AssetList<SphericalHarmonicsL2_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171EF RID: 94703 RVA: 0x00368CE8 File Offset: 0x00366EE8
		public static YamlNode ExportYamlEditor_Array_SplashScreenLogo(this AssetList<SplashScreenLogo> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171F0 RID: 94704 RVA: 0x00368D28 File Offset: 0x00366F28
		public static YamlNode ExportYamlEditor_Array_SplatPrototype_3_4_0(this AssetList<SplatPrototype_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171F1 RID: 94705 RVA: 0x00368D68 File Offset: 0x00366F68
		public static YamlNode ExportYamlEditor_Array_SplatPrototype_3_5_0(this AssetList<SplatPrototype_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171F2 RID: 94706 RVA: 0x00368DA8 File Offset: 0x00366FA8
		public static YamlNode ExportYamlEditor_Array_SplatPrototype_4_0_0(this AssetList<SplatPrototype_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171F3 RID: 94707 RVA: 0x00368DE8 File Offset: 0x00366FE8
		public static YamlNode ExportYamlEditor_Array_SplatPrototype_5_0_0(this AssetList<SplatPrototype_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171F4 RID: 94708 RVA: 0x00368E28 File Offset: 0x00367028
		public static YamlNode ExportYamlEditor_Array_SplatPrototype_5_0_1(this AssetList<SplatPrototype_5_0_1> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		public static YamlNode ExportYamlEditor_Array_SplatPrototype_5_0_1_GICB2(this AssetList<SplatPrototype_5_0_1_GICB2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171F5 RID: 94709 RVA: 0x00368E68 File Offset: 0x00367068
		public static YamlNode ExportYamlEditor_Array_SpriteBone_2018_1_0(this AssetList<SpriteBone_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171F6 RID: 94710 RVA: 0x00368EA8 File Offset: 0x003670A8
		public static YamlNode ExportYamlEditor_Array_SpriteBone_2021_1_0(this AssetList<SpriteBone_2021_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171F7 RID: 94711 RVA: 0x00368EE8 File Offset: 0x003670E8
		public static YamlNode ExportYamlEditor_Array_SpriteData(this AssetList<SpriteData> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171F8 RID: 94712 RVA: 0x00368F28 File Offset: 0x00367128
		public static YamlNode ExportYamlEditor_Array_SpriteMetaData_2017_1_0(this AssetList<SpriteMetaData_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171F9 RID: 94713 RVA: 0x00368F68 File Offset: 0x00367168
		public static YamlNode ExportYamlEditor_Array_SpriteMetaData_2018_1_0(this AssetList<SpriteMetaData_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171FA RID: 94714 RVA: 0x00368FA8 File Offset: 0x003671A8
		public static YamlNode ExportYamlEditor_Array_SpriteMetaData_2019_1_0(this AssetList<SpriteMetaData_2019_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171FB RID: 94715 RVA: 0x00368FE8 File Offset: 0x003671E8
		public static YamlNode ExportYamlEditor_Array_SpriteMetaData_2021_1_0(this AssetList<SpriteMetaData_2021_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171FC RID: 94716 RVA: 0x00369028 File Offset: 0x00367228
		public static YamlNode ExportYamlEditor_Array_SpriteMetaData_4_3_0(this AssetList<SpriteMetaData_4_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171FD RID: 94717 RVA: 0x00369068 File Offset: 0x00367268
		public static YamlNode ExportYamlEditor_Array_SpriteMetaData_4_5_0(this AssetList<SpriteMetaData_4_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171FE RID: 94718 RVA: 0x003690A8 File Offset: 0x003672A8
		public static YamlNode ExportYamlEditor_Array_SpriteMetaData_5_3_0(this AssetList<SpriteMetaData_5_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060171FF RID: 94719 RVA: 0x003690E8 File Offset: 0x003672E8
		public static YamlNode ExportYamlEditor_Array_SpriteMetaData_5_3_6(this AssetList<SpriteMetaData_5_3_6> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017200 RID: 94720 RVA: 0x00369128 File Offset: 0x00367328
		public static YamlNode ExportYamlEditor_Array_SpriteMetaData_5_4_0(this AssetList<SpriteMetaData_5_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017201 RID: 94721 RVA: 0x00369168 File Offset: 0x00367368
		public static YamlNode ExportYamlEditor_Array_SpriteVertex_4_3_0(this AssetList<SpriteVertex_4_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017202 RID: 94722 RVA: 0x003691A8 File Offset: 0x003673A8
		public static YamlNode ExportYamlEditor_Array_SpriteVertex_4_5_0(this AssetList<SpriteVertex_4_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017203 RID: 94723 RVA: 0x003691E8 File Offset: 0x003673E8
		public static YamlNode ExportYamlEditor_Array_StateBehavioursPair_2017_1_0(this AssetList<StateBehavioursPair_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017204 RID: 94724 RVA: 0x00369228 File Offset: 0x00367428
		public static YamlNode ExportYamlEditor_Array_StateBehavioursPair_5_0_0(this AssetList<StateBehavioursPair_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017205 RID: 94725 RVA: 0x00369268 File Offset: 0x00367468
		public static YamlNode ExportYamlEditor_Array_StateBehavioursPair_5_2_0(this AssetList<StateBehavioursPair_5_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017206 RID: 94726 RVA: 0x003692A8 File Offset: 0x003674A8
		public static YamlNode ExportYamlEditor_Array_StateMotionPair_5_0_0(this AssetList<StateMotionPair_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017207 RID: 94727 RVA: 0x003692E8 File Offset: 0x003674E8
		public static YamlNode ExportYamlEditor_Array_StateMotionPair_5_2_0(this AssetList<StateMotionPair_5_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017208 RID: 94728 RVA: 0x00369328 File Offset: 0x00367528
		public static YamlNode ExportYamlEditor_Array_StreamInfo_4_0_0(this AssetList<StreamInfo_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017209 RID: 94729 RVA: 0x00369368 File Offset: 0x00367568
		public static YamlNode ExportYamlEditor_Array_StructParameter(this AssetList<StructParameter> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601720A RID: 94730 RVA: 0x003693A8 File Offset: 0x003675A8
		public static YamlNode ExportYamlEditor_Array_SubCollider_2017_1_0(this AssetList<SubCollider_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601720B RID: 94731 RVA: 0x003693E8 File Offset: 0x003675E8
		public static YamlNode ExportYamlEditor_Array_SubCollider_5_6_0(this AssetList<SubCollider_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601720C RID: 94732 RVA: 0x00369428 File Offset: 0x00367628
		public static YamlNode ExportYamlEditor_Array_SubEmitterData_2017_2_0_b7(this AssetList<SubEmitterData_2017_2_0_b7> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601720D RID: 94733 RVA: 0x00369468 File Offset: 0x00367668
		public static YamlNode ExportYamlEditor_Array_SubEmitterData_2018_3_0(this AssetList<SubEmitterData_2018_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601720E RID: 94734 RVA: 0x003694A8 File Offset: 0x003676A8
		public static YamlNode ExportYamlEditor_Array_SubEmitterData_2018_3_0_b8(this AssetList<SubEmitterData_2018_3_0_b8> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601720F RID: 94735 RVA: 0x003694E8 File Offset: 0x003676E8
		public static YamlNode ExportYamlEditor_Array_SubEmitterData_5_5_0(this AssetList<SubEmitterData_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017210 RID: 94736 RVA: 0x00369528 File Offset: 0x00367728
		public static YamlNode ExportYamlEditor_Array_SubMesh_2017_3_0(this AssetList<SubMesh_2017_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017211 RID: 94737 RVA: 0x00369568 File Offset: 0x00367768
		public static YamlNode ExportYamlEditor_Array_SubMesh_3_4_0(this AssetList<SubMesh_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017212 RID: 94738 RVA: 0x003695A8 File Offset: 0x003677A8
		public static YamlNode ExportYamlEditor_Array_SubMesh_3_5_0(this AssetList<SubMesh_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017213 RID: 94739 RVA: 0x003695E8 File Offset: 0x003677E8
		public static YamlNode ExportYamlEditor_Array_SubMesh_4_0_0(this AssetList<SubMesh_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017214 RID: 94740 RVA: 0x00369628 File Offset: 0x00367828
		public static YamlNode ExportYamlEditor_Array_SubstanceEnumItem(this AssetList<SubstanceEnumItem> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017215 RID: 94741 RVA: 0x00369668 File Offset: 0x00367868
		public static YamlNode ExportYamlEditor_Array_SubstanceInput_2017_1_0(this AssetList<SubstanceInput_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017216 RID: 94742 RVA: 0x003696A8 File Offset: 0x003678A8
		public static YamlNode ExportYamlEditor_Array_SubstanceInput_2017_2_0_b4(this AssetList<SubstanceInput_2017_2_0_b4> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017217 RID: 94743 RVA: 0x003696E8 File Offset: 0x003678E8
		public static YamlNode ExportYamlEditor_Array_SubstanceInput_3_4_0(this AssetList<SubstanceInput_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017218 RID: 94744 RVA: 0x00369728 File Offset: 0x00367928
		public static YamlNode ExportYamlEditor_Array_SubstanceInput_3_5_0(this AssetList<SubstanceInput_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017219 RID: 94745 RVA: 0x00369768 File Offset: 0x00367968
		public static YamlNode ExportYamlEditor_Array_SubstanceInput_4_1_0(this AssetList<SubstanceInput_4_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601721A RID: 94746 RVA: 0x003697A8 File Offset: 0x003679A8
		public static YamlNode ExportYamlEditor_Array_SubstanceInput_4_5_0(this AssetList<SubstanceInput_4_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601721B RID: 94747 RVA: 0x003697E8 File Offset: 0x003679E8
		public static YamlNode ExportYamlEditor_Array_SubstanceInput_5_0_0(this AssetList<SubstanceInput_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601721C RID: 94748 RVA: 0x00369828 File Offset: 0x00367A28
		public static YamlNode ExportYamlEditor_Array_SubstanceInput_5_2_0(this AssetList<SubstanceInput_5_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601721D RID: 94749 RVA: 0x00369868 File Offset: 0x00367A68
		public static YamlNode ExportYamlEditor_Array_Tetrahedron_2019_4_19(this AssetList<Tetrahedron_2019_4_19> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601721E RID: 94750 RVA: 0x003698A8 File Offset: 0x00367AA8
		public static YamlNode ExportYamlEditor_Array_Tetrahedron_2020_1_0(this AssetList<Tetrahedron_2020_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601721F RID: 94751 RVA: 0x003698E8 File Offset: 0x00367AE8
		public static YamlNode ExportYamlEditor_Array_Tetrahedron_2020_1_0_a9(this AssetList<Tetrahedron_2020_1_0_a9> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017220 RID: 94752 RVA: 0x00369928 File Offset: 0x00367B28
		public static YamlNode ExportYamlEditor_Array_Tetrahedron_3_5_0(this AssetList<Tetrahedron_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017221 RID: 94753 RVA: 0x00369968 File Offset: 0x00367B68
		public static YamlNode ExportYamlEditor_Array_TextureImporterPlatformSettings_2017_2_0(this AssetList<TextureImporterPlatformSettings_2017_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017222 RID: 94754 RVA: 0x003699A8 File Offset: 0x00367BA8
		public static YamlNode ExportYamlEditor_Array_TextureImporterPlatformSettings_2017_3_0(this AssetList<TextureImporterPlatformSettings_2017_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017223 RID: 94755 RVA: 0x003699E8 File Offset: 0x00367BE8
		public static YamlNode ExportYamlEditor_Array_TextureImporterPlatformSettings_2018_1_0(this AssetList<TextureImporterPlatformSettings_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017224 RID: 94756 RVA: 0x00369A28 File Offset: 0x00367C28
		public static YamlNode ExportYamlEditor_Array_TextureImporterPlatformSettings_2019_2_0(this AssetList<TextureImporterPlatformSettings_2019_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017225 RID: 94757 RVA: 0x00369A68 File Offset: 0x00367C68
		public static YamlNode ExportYamlEditor_Array_TextureImporterPlatformSettings_3_4_0(this AssetList<TextureImporterPlatformSettings_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017226 RID: 94758 RVA: 0x00369AA8 File Offset: 0x00367CA8
		public static YamlNode ExportYamlEditor_Array_TextureImporterPlatformSettings_3_5_0(this AssetList<TextureImporterPlatformSettings_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017227 RID: 94759 RVA: 0x00369AE8 File Offset: 0x00367CE8
		public static YamlNode ExportYamlEditor_Array_TextureImporterPlatformSettings_5_2_0(this AssetList<TextureImporterPlatformSettings_5_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017228 RID: 94760 RVA: 0x00369B28 File Offset: 0x00367D28
		public static YamlNode ExportYamlEditor_Array_TextureImporterPlatformSettings_5_5_0(this AssetList<TextureImporterPlatformSettings_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017229 RID: 94761 RVA: 0x00369B68 File Offset: 0x00367D68
		public static YamlNode ExportYamlEditor_Array_TextureParameter_2017_3_0(this AssetList<TextureParameter_2017_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601722A RID: 94762 RVA: 0x00369BA8 File Offset: 0x00367DA8
		public static YamlNode ExportYamlEditor_Array_TextureParameter_5_5_0(this AssetList<TextureParameter_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601722B RID: 94763 RVA: 0x00369BE8 File Offset: 0x00367DE8
		public static YamlNode ExportYamlEditor_Array_TierSettings_2017_1_0(this AssetList<TierSettings_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601722C RID: 94764 RVA: 0x00369C28 File Offset: 0x00367E28
		public static YamlNode ExportYamlEditor_Array_TierSettings_2017_1_0_f2(this AssetList<TierSettings_2017_1_0_f2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601722D RID: 94765 RVA: 0x00369C68 File Offset: 0x00367E68
		public static YamlNode ExportYamlEditor_Array_TierSettings_5_3_0(this AssetList<TierSettings_5_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601722E RID: 94766 RVA: 0x00369CA8 File Offset: 0x00367EA8
		public static YamlNode ExportYamlEditor_Array_TierSettings_5_4_0(this AssetList<TierSettings_5_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601722F RID: 94767 RVA: 0x00369CE8 File Offset: 0x00367EE8
		public static YamlNode ExportYamlEditor_Array_TierSettings_5_5_0(this AssetList<TierSettings_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017230 RID: 94768 RVA: 0x00369D28 File Offset: 0x00367F28
		public static YamlNode ExportYamlEditor_Array_TierSettings_5_6_0(this AssetList<TierSettings_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017231 RID: 94769 RVA: 0x00369D68 File Offset: 0x00367F68
		public static YamlNode ExportYamlEditor_Array_TierSettings_5_6_0_b7(this AssetList<TierSettings_5_6_0_b7> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017232 RID: 94770 RVA: 0x00369DA8 File Offset: 0x00367FA8
		public static YamlNode ExportYamlEditor_Array_TierSettings_5_6_3(this AssetList<TierSettings_5_6_3> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017233 RID: 94771 RVA: 0x00369DE8 File Offset: 0x00367FE8
		public static YamlNode ExportYamlEditor_Array_TilemapRefCountedData_ColorRGBAf(this AssetList<TilemapRefCountedData_ColorRGBAf> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017234 RID: 94772 RVA: 0x00369E28 File Offset: 0x00368028
		public static YamlNode ExportYamlEditor_Array_TilemapRefCountedData_Matrix4x4f(this AssetList<TilemapRefCountedData_Matrix4x4f> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017235 RID: 94773 RVA: 0x00369E68 File Offset: 0x00368068
		public static YamlNode ExportYamlEditor_Array_TilemapRefCountedData_PPtr_GameObject(this AssetList<TilemapRefCountedData_PPtr_GameObject> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017236 RID: 94774 RVA: 0x00369EA8 File Offset: 0x003680A8
		public static YamlNode ExportYamlEditor_Array_TilemapRefCountedData_PPtr_Object(this AssetList<TilemapRefCountedData_PPtr_Object> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017237 RID: 94775 RVA: 0x00369EE8 File Offset: 0x003680E8
		public static YamlNode ExportYamlEditor_Array_TilemapRefCountedData_PPtr_Sprite(this AssetList<TilemapRefCountedData_PPtr_Sprite> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017238 RID: 94776 RVA: 0x00369F28 File Offset: 0x00368128
		public static YamlNode ExportYamlEditor_Array_TilemapTileDirtyData_2017_2_0(this AssetList<TilemapTileDirtyData_2017_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017239 RID: 94777 RVA: 0x00369F68 File Offset: 0x00368168
		public static YamlNode ExportYamlEditor_Array_TilemapTileDirtyData_2018_1_0(this AssetList<TilemapTileDirtyData_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601723A RID: 94778 RVA: 0x00369FA8 File Offset: 0x003681A8
		public static YamlNode ExportYamlEditor_Array_TransformMaskElement(this AssetList<TransformMaskElement> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601723B RID: 94779 RVA: 0x00369FE8 File Offset: 0x003681E8
		public static YamlNode ExportYamlEditor_Array_TreeInstance_3_4_0(this AssetList<TreeInstance_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601723C RID: 94780 RVA: 0x0036A028 File Offset: 0x00368228
		public static YamlNode ExportYamlEditor_Array_TreeInstance_3_5_0(this AssetList<TreeInstance_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601723D RID: 94781 RVA: 0x0036A068 File Offset: 0x00368268
		public static YamlNode ExportYamlEditor_Array_TreeInstance_5_0_0(this AssetList<TreeInstance_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601723E RID: 94782 RVA: 0x0036A0A8 File Offset: 0x003682A8
		public static YamlNode ExportYamlEditor_Array_TreePrototype_2020_2_0_a12(this AssetList<TreePrototype_2020_2_0_a12> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601723F RID: 94783 RVA: 0x0036A0E8 File Offset: 0x003682E8
		public static YamlNode ExportYamlEditor_Array_TreePrototype_3_4_0(this AssetList<TreePrototype_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017240 RID: 94784 RVA: 0x0036A128 File Offset: 0x00368328
		public static YamlNode ExportYamlEditor_Array_TreePrototype_5_0_0(this AssetList<TreePrototype_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017241 RID: 94785 RVA: 0x0036A168 File Offset: 0x00368368
		public static YamlNode ExportYamlEditor_Array_UAVParameter(this AssetList<UAVParameter> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017242 RID: 94786 RVA: 0x0036A1A8 File Offset: 0x003683A8
		public static YamlNode ExportYamlEditor_Array_UInt16(this ushort[] value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int num = value.Length;
			for (int i = 0; i < num; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor_UInt16(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017243 RID: 94787 RVA: 0x0036A1E0 File Offset: 0x003683E0
		public static YamlNode ExportYamlEditor_Array_UInt32(this uint[] value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int num = value.Length;
			for (int i = 0; i < num; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor_UInt32(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017244 RID: 94788 RVA: 0x0036A218 File Offset: 0x00368418
		public static YamlNode ExportYamlEditor_Array_UpdateZoneInfo(this AssetList<UpdateZoneInfo> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017245 RID: 94789 RVA: 0x0036A258 File Offset: 0x00368458
		public static YamlNode ExportYamlEditor_Array_Utf8String(this AssetList<Utf8String> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017246 RID: 94790 RVA: 0x0036A298 File Offset: 0x00368498
		public static YamlNode ExportYamlEditor_Array_VariantInfo(this AssetList<VariantInfo> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017247 RID: 94791 RVA: 0x0036A2D8 File Offset: 0x003684D8
		public static YamlNode ExportYamlEditor_Array_Vector2f_3_4_0(this AssetList<Vector2f_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017248 RID: 94792 RVA: 0x0036A318 File Offset: 0x00368518
		public static YamlNode ExportYamlEditor_Array_Vector2f_3_5_0(this AssetList<Vector2f_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017249 RID: 94793 RVA: 0x0036A358 File Offset: 0x00368558
		public static YamlNode ExportYamlEditor_Array_Vector2Int(this AssetList<Vector2Int> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601724A RID: 94794 RVA: 0x0036A398 File Offset: 0x00368598
		public static YamlNode ExportYamlEditor_Array_Vector2Long(this AssetList<Vector2Long> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601724B RID: 94795 RVA: 0x0036A3D8 File Offset: 0x003685D8
		public static YamlNode ExportYamlEditor_Array_Vector3Curve_2017_1_0(this AssetList<Vector3Curve_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601724C RID: 94796 RVA: 0x0036A418 File Offset: 0x00368618
		public static YamlNode ExportYamlEditor_Array_Vector3Curve_2018_1_0(this AssetList<Vector3Curve_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601724D RID: 94797 RVA: 0x0036A458 File Offset: 0x00368658
		public static YamlNode ExportYamlEditor_Array_Vector3Curve_3_4_0(this AssetList<Vector3Curve_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601724E RID: 94798 RVA: 0x0036A498 File Offset: 0x00368698
		public static YamlNode ExportYamlEditor_Array_Vector3Curve_3_5_0(this AssetList<Vector3Curve_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601724F RID: 94799 RVA: 0x0036A4D8 File Offset: 0x003686D8
		public static YamlNode ExportYamlEditor_Array_Vector3Curve_5_3_0(this AssetList<Vector3Curve_5_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017250 RID: 94800 RVA: 0x0036A518 File Offset: 0x00368718
		public static YamlNode ExportYamlEditor_Array_Vector3Curve_5_5_0(this AssetList<Vector3Curve_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017251 RID: 94801 RVA: 0x0036A558 File Offset: 0x00368758
		public static YamlNode ExportYamlEditor_Array_Vector3f_3_4_0(this AssetList<Vector3f_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017252 RID: 94802 RVA: 0x0036A598 File Offset: 0x00368798
		public static YamlNode ExportYamlEditor_Array_Vector3f_3_5_0(this AssetList<Vector3f_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017253 RID: 94803 RVA: 0x0036A5D8 File Offset: 0x003687D8
		public static YamlNode ExportYamlEditor_Array_Vector4f_3_4_0(this AssetList<Vector4f_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017254 RID: 94804 RVA: 0x0036A618 File Offset: 0x00368818
		public static YamlNode ExportYamlEditor_Array_Vector4f_3_5_0(this AssetList<Vector4f_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017255 RID: 94805 RVA: 0x0036A658 File Offset: 0x00368858
		public static YamlNode ExportYamlEditor_Array_VectorParameter(this AssetList<VectorParameter> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017256 RID: 94806 RVA: 0x0036A698 File Offset: 0x00368898
		public static YamlNode ExportYamlEditor_Array_VFXCPUBufferDesc(this AssetList<VFXCPUBufferDesc> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017257 RID: 94807 RVA: 0x0036A6D8 File Offset: 0x003688D8
		public static YamlNode ExportYamlEditor_Array_VFXEditorSystemDesc_2018_3_0(this AssetList<VFXEditorSystemDesc_2018_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017258 RID: 94808 RVA: 0x0036A718 File Offset: 0x00368918
		public static YamlNode ExportYamlEditor_Array_VFXEditorSystemDesc_2019_2_0_a7(this AssetList<VFXEditorSystemDesc_2019_2_0_a7> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017259 RID: 94809 RVA: 0x0036A758 File Offset: 0x00368958
		public static YamlNode ExportYamlEditor_Array_VFXEditorTaskDesc_2018_3_0(this AssetList<VFXEditorTaskDesc_2018_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601725A RID: 94810 RVA: 0x0036A798 File Offset: 0x00368998
		public static YamlNode ExportYamlEditor_Array_VFXEditorTaskDesc_2019_2_0_a7(this AssetList<VFXEditorTaskDesc_2019_2_0_a7> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601725B RID: 94811 RVA: 0x0036A7D8 File Offset: 0x003689D8
		public static YamlNode ExportYamlEditor_Array_VFXEntryExposed_AnimationCurve_Single(this AssetList<VFXEntryExposed_AnimationCurve_Single> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601725C RID: 94812 RVA: 0x0036A818 File Offset: 0x00368A18
		public static YamlNode ExportYamlEditor_Array_VFXEntryExposed_bool(this AssetList<VFXEntryExposed_bool> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601725D RID: 94813 RVA: 0x0036A858 File Offset: 0x00368A58
		public static YamlNode ExportYamlEditor_Array_VFXEntryExposed_float(this AssetList<VFXEntryExposed_float> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601725E RID: 94814 RVA: 0x0036A898 File Offset: 0x00368A98
		public static YamlNode ExportYamlEditor_Array_VFXEntryExposed_Gradient_2018_3_0(this AssetList<VFXEntryExposed_Gradient_2018_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601725F RID: 94815 RVA: 0x0036A8D8 File Offset: 0x00368AD8
		public static YamlNode ExportYamlEditor_Array_VFXEntryExposed_Gradient_2022_2_0(this AssetList<VFXEntryExposed_Gradient_2022_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017260 RID: 94816 RVA: 0x0036A918 File Offset: 0x00368B18
		public static YamlNode ExportYamlEditor_Array_VFXEntryExposed_Matrix4x4f(this AssetList<VFXEntryExposed_Matrix4x4f> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017261 RID: 94817 RVA: 0x0036A958 File Offset: 0x00368B58
		public static YamlNode ExportYamlEditor_Array_VFXEntryExposed_PPtr_NamedObject(this AssetList<VFXEntryExposed_PPtr_NamedObject> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017262 RID: 94818 RVA: 0x0036A998 File Offset: 0x00368B98
		public static YamlNode ExportYamlEditor_Array_VFXEntryExposed_PPtr_Object(this AssetList<VFXEntryExposed_PPtr_Object> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017263 RID: 94819 RVA: 0x0036A9D8 File Offset: 0x00368BD8
		public static YamlNode ExportYamlEditor_Array_VFXEntryExposed_SInt32(this AssetList<VFXEntryExposed_SInt32> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017264 RID: 94820 RVA: 0x0036AA18 File Offset: 0x00368C18
		public static YamlNode ExportYamlEditor_Array_VFXEntryExposed_UInt32(this AssetList<VFXEntryExposed_UInt32> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017265 RID: 94821 RVA: 0x0036AA58 File Offset: 0x00368C58
		public static YamlNode ExportYamlEditor_Array_VFXEntryExposed_Vector2f(this AssetList<VFXEntryExposed_Vector2f> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017266 RID: 94822 RVA: 0x0036AA98 File Offset: 0x00368C98
		public static YamlNode ExportYamlEditor_Array_VFXEntryExposed_Vector3f(this AssetList<VFXEntryExposed_Vector3f> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017267 RID: 94823 RVA: 0x0036AAD8 File Offset: 0x00368CD8
		public static YamlNode ExportYamlEditor_Array_VFXEntryExposed_Vector4f(this AssetList<VFXEntryExposed_Vector4f> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017268 RID: 94824 RVA: 0x0036AB18 File Offset: 0x00368D18
		public static YamlNode ExportYamlEditor_Array_VFXEntryExpressionValue_AnimationCurve_Single(this AssetList<VFXEntryExpressionValue_AnimationCurve_Single> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017269 RID: 94825 RVA: 0x0036AB58 File Offset: 0x00368D58
		public static YamlNode ExportYamlEditor_Array_VFXEntryExpressionValue_bool(this AssetList<VFXEntryExpressionValue_bool> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601726A RID: 94826 RVA: 0x0036AB98 File Offset: 0x00368D98
		public static YamlNode ExportYamlEditor_Array_VFXEntryExpressionValue_float(this AssetList<VFXEntryExpressionValue_float> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601726B RID: 94827 RVA: 0x0036ABD8 File Offset: 0x00368DD8
		public static YamlNode ExportYamlEditor_Array_VFXEntryExpressionValue_Gradient_2018_3_0(this AssetList<VFXEntryExpressionValue_Gradient_2018_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601726C RID: 94828 RVA: 0x0036AC18 File Offset: 0x00368E18
		public static YamlNode ExportYamlEditor_Array_VFXEntryExpressionValue_Gradient_2022_2_0(this AssetList<VFXEntryExpressionValue_Gradient_2022_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601726D RID: 94829 RVA: 0x0036AC58 File Offset: 0x00368E58
		public static YamlNode ExportYamlEditor_Array_VFXEntryExpressionValue_Matrix4x4f(this AssetList<VFXEntryExpressionValue_Matrix4x4f> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601726E RID: 94830 RVA: 0x0036AC98 File Offset: 0x00368E98
		public static YamlNode ExportYamlEditor_Array_VFXEntryExpressionValue_PPtr_NamedObject(this AssetList<VFXEntryExpressionValue_PPtr_NamedObject> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601726F RID: 94831 RVA: 0x0036ACD8 File Offset: 0x00368ED8
		public static YamlNode ExportYamlEditor_Array_VFXEntryExpressionValue_PPtr_Object(this AssetList<VFXEntryExpressionValue_PPtr_Object> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017270 RID: 94832 RVA: 0x0036AD18 File Offset: 0x00368F18
		public static YamlNode ExportYamlEditor_Array_VFXEntryExpressionValue_SInt32(this AssetList<VFXEntryExpressionValue_SInt32> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017271 RID: 94833 RVA: 0x0036AD58 File Offset: 0x00368F58
		public static YamlNode ExportYamlEditor_Array_VFXEntryExpressionValue_UInt32(this AssetList<VFXEntryExpressionValue_UInt32> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017272 RID: 94834 RVA: 0x0036AD98 File Offset: 0x00368F98
		public static YamlNode ExportYamlEditor_Array_VFXEntryExpressionValue_Vector2f(this AssetList<VFXEntryExpressionValue_Vector2f> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017273 RID: 94835 RVA: 0x0036ADD8 File Offset: 0x00368FD8
		public static YamlNode ExportYamlEditor_Array_VFXEntryExpressionValue_Vector3f(this AssetList<VFXEntryExpressionValue_Vector3f> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017274 RID: 94836 RVA: 0x0036AE18 File Offset: 0x00369018
		public static YamlNode ExportYamlEditor_Array_VFXEntryExpressionValue_Vector4f(this AssetList<VFXEntryExpressionValue_Vector4f> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017275 RID: 94837 RVA: 0x0036AE58 File Offset: 0x00369058
		public static YamlNode ExportYamlEditor_Array_VFXEventDesc_2018_3_0(this AssetList<VFXEventDesc_2018_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017276 RID: 94838 RVA: 0x0036AE98 File Offset: 0x00369098
		public static YamlNode ExportYamlEditor_Array_VFXEventDesc_2021_2_0_a19(this AssetList<VFXEventDesc_2021_2_0_a19> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017277 RID: 94839 RVA: 0x0036AED8 File Offset: 0x003690D8
		public static YamlNode ExportYamlEditor_Array_VFXGPUBufferDesc(this AssetList<VFXGPUBufferDesc> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017278 RID: 94840 RVA: 0x0036AF18 File Offset: 0x00369118
		public static YamlNode ExportYamlEditor_Array_VFXLayoutElementDesc(this AssetList<VFXLayoutElementDesc> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017279 RID: 94841 RVA: 0x0036AF58 File Offset: 0x00369158
		public static YamlNode ExportYamlEditor_Array_VFXMapping(this AssetList<VFXMapping> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601727A RID: 94842 RVA: 0x0036AF98 File Offset: 0x00369198
		public static YamlNode ExportYamlEditor_Array_VFXMappingTemporary(this AssetList<VFXMappingTemporary> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601727B RID: 94843 RVA: 0x0036AFD8 File Offset: 0x003691D8
		public static YamlNode ExportYamlEditor_Array_VFXShaderSourceDesc(this AssetList<VFXShaderSourceDesc> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601727C RID: 94844 RVA: 0x0036B018 File Offset: 0x00369218
		public static YamlNode ExportYamlEditor_Array_VFXSystemDesc_2018_3_0(this AssetList<VFXSystemDesc_2018_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601727D RID: 94845 RVA: 0x0036B058 File Offset: 0x00369258
		public static YamlNode ExportYamlEditor_Array_VFXSystemDesc_2019_2_0_a7(this AssetList<VFXSystemDesc_2019_2_0_a7> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601727E RID: 94846 RVA: 0x0036B098 File Offset: 0x00369298
		public static YamlNode ExportYamlEditor_Array_VFXSystemDesc_2020_1_0_a17(this AssetList<VFXSystemDesc_2020_1_0_a17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601727F RID: 94847 RVA: 0x0036B0D8 File Offset: 0x003692D8
		public static YamlNode ExportYamlEditor_Array_VFXTaskDesc_2018_3_0(this AssetList<VFXTaskDesc_2018_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017280 RID: 94848 RVA: 0x0036B118 File Offset: 0x00369318
		public static YamlNode ExportYamlEditor_Array_VFXTaskDesc_2019_2_0_a7(this AssetList<VFXTaskDesc_2019_2_0_a7> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017281 RID: 94849 RVA: 0x0036B158 File Offset: 0x00369358
		public static YamlNode ExportYamlEditor_Array_VFXTemporaryGPUBufferDesc(this AssetList<VFXTemporaryGPUBufferDesc> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017282 RID: 94850 RVA: 0x0036B198 File Offset: 0x00369398
		public static YamlNode ExportYamlEditor_Array_Xform_4_0_0(this AssetList<Xform_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017283 RID: 94851 RVA: 0x0036B1D8 File Offset: 0x003693D8
		public static YamlNode ExportYamlEditor_Array_Xform_5_4_0(this AssetList<Xform_5_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017284 RID: 94852 RVA: 0x0036B218 File Offset: 0x00369418
		public static YamlNode ExportYamlEditor_Array_Xform_5_5_0(this AssetList<Xform_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.Block);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value[i].ExportYamlEditor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017285 RID: 94853 RVA: 0x0036B255 File Offset: 0x00369455
		public static YamlNode ExportYamlEditor_Boolean(this bool value, IExportContainer container)
		{
			return new YamlScalarNode(value);
		}

		// Token: 0x06017286 RID: 94854 RVA: 0x0036B25D File Offset: 0x0036945D
		public static YamlNode ExportYamlEditor_Byte(this byte value, IExportContainer container)
		{
			return new YamlScalarNode(value);
		}

		// Token: 0x06017287 RID: 94855 RVA: 0x0036B265 File Offset: 0x00369465
		public static YamlNode ExportYamlEditor_Double(this double value, IExportContainer container)
		{
			return new YamlScalarNode(value);
		}

		// Token: 0x06017288 RID: 94856 RVA: 0x0036B26D File Offset: 0x0036946D
		public static YamlNode ExportYamlEditor_Int16(this short value, IExportContainer container)
		{
			return new YamlScalarNode(value);
		}

		// Token: 0x06017289 RID: 94857 RVA: 0x0036B275 File Offset: 0x00369475
		public static YamlNode ExportYamlEditor_Int32(this int value, IExportContainer container)
		{
			return new YamlScalarNode(value);
		}

		// Token: 0x0601728A RID: 94858 RVA: 0x0036B27D File Offset: 0x0036947D
		public static YamlNode ExportYamlEditor_Int64(this long value, IExportContainer container)
		{
			return new YamlScalarNode(value);
		}

		// Token: 0x0601728B RID: 94859 RVA: 0x0036B288 File Offset: 0x00369488
		public static YamlNode ExportYamlEditor_Map_AssetImporterHashKey_UInt32(this AssetDictionary<AssetImporterHashKey, uint> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_AssetImporterHashKey_UInt32(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601728C RID: 94860 RVA: 0x0036B2C8 File Offset: 0x003694C8
		public static YamlNode ExportYamlEditor_Map_FastPropertyName_ColorRGBAf_3_4_0(this AssetDictionary<FastPropertyName, ColorRGBAf_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_FastPropertyName_ColorRGBAf_3_4_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601728D RID: 94861 RVA: 0x0036B308 File Offset: 0x00369508
		public static YamlNode ExportYamlEditor_Map_FastPropertyName_ColorRGBAf_3_5_0(this AssetDictionary<FastPropertyName, ColorRGBAf_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_FastPropertyName_ColorRGBAf_3_5_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601728E RID: 94862 RVA: 0x0036B348 File Offset: 0x00369548
		public static YamlNode ExportYamlEditor_Map_FastPropertyName_Single(this AssetDictionary<FastPropertyName, float> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_FastPropertyName_Single(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601728F RID: 94863 RVA: 0x0036B388 File Offset: 0x00369588
		public static YamlNode ExportYamlEditor_Map_FastPropertyName_UnityTexEnv_3_4_0(this AssetDictionary<FastPropertyName, UnityTexEnv_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_FastPropertyName_UnityTexEnv_3_4_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017290 RID: 94864 RVA: 0x0036B3C8 File Offset: 0x003695C8
		public static YamlNode ExportYamlEditor_Map_FastPropertyName_UnityTexEnv_3_5_0(this AssetDictionary<FastPropertyName, UnityTexEnv_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_FastPropertyName_UnityTexEnv_3_5_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017291 RID: 94865 RVA: 0x0036B408 File Offset: 0x00369608
		public static YamlNode ExportYamlEditor_Map_FastPropertyName_UnityTexEnv_5_0_0(this AssetDictionary<FastPropertyName, UnityTexEnv_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_FastPropertyName_UnityTexEnv_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017292 RID: 94866 RVA: 0x0036B448 File Offset: 0x00369648
		public static YamlNode ExportYamlEditor_Map_GUID_Asset_2017_1_0(this AssetDictionary<GUID, Asset_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_GUID_Asset_2017_1_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017293 RID: 94867 RVA: 0x0036B488 File Offset: 0x00369688
		public static YamlNode ExportYamlEditor_Map_GUID_Asset_2017_2_5(this AssetDictionary<GUID, Asset_2017_2_5> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_GUID_Asset_2017_2_5(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017294 RID: 94868 RVA: 0x0036B4C8 File Offset: 0x003696C8
		public static YamlNode ExportYamlEditor_Map_GUID_Asset_2017_3_0(this AssetDictionary<GUID, Asset_2017_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_GUID_Asset_2017_3_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017295 RID: 94869 RVA: 0x0036B508 File Offset: 0x00369708
		public static YamlNode ExportYamlEditor_Map_GUID_Asset_2017_4_14(this AssetDictionary<GUID, Asset_2017_4_14> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_GUID_Asset_2017_4_14(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017296 RID: 94870 RVA: 0x0036B548 File Offset: 0x00369748
		public static YamlNode ExportYamlEditor_Map_GUID_Asset_2018_1_0(this AssetDictionary<GUID, Asset_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_GUID_Asset_2018_1_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017297 RID: 94871 RVA: 0x0036B588 File Offset: 0x00369788
		public static YamlNode ExportYamlEditor_Map_GUID_Asset_2018_1_0_b11(this AssetDictionary<GUID, Asset_2018_1_0_b11> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_GUID_Asset_2018_1_0_b11(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017298 RID: 94872 RVA: 0x0036B5C8 File Offset: 0x003697C8
		public static YamlNode ExportYamlEditor_Map_GUID_Asset_2018_3_0(this AssetDictionary<GUID, Asset_2018_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_GUID_Asset_2018_3_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017299 RID: 94873 RVA: 0x0036B608 File Offset: 0x00369808
		public static YamlNode ExportYamlEditor_Map_GUID_Asset_2019_3_0_a8(this AssetDictionary<GUID, Asset_2019_3_0_a8> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_GUID_Asset_2019_3_0_a8(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601729A RID: 94874 RVA: 0x0036B648 File Offset: 0x00369848
		public static YamlNode ExportYamlEditor_Map_GUID_Asset_3_4_0(this AssetDictionary<GUID, Asset_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_GUID_Asset_3_4_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601729B RID: 94875 RVA: 0x0036B688 File Offset: 0x00369888
		public static YamlNode ExportYamlEditor_Map_GUID_Asset_3_5_0(this AssetDictionary<GUID, Asset_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_GUID_Asset_3_5_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601729C RID: 94876 RVA: 0x0036B6C8 File Offset: 0x003698C8
		public static YamlNode ExportYamlEditor_Map_GUID_Asset_4_0_0(this AssetDictionary<GUID, Asset_4_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_GUID_Asset_4_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601729D RID: 94877 RVA: 0x0036B708 File Offset: 0x00369908
		public static YamlNode ExportYamlEditor_Map_GUID_Asset_4_3_0(this AssetDictionary<GUID, Asset_4_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_GUID_Asset_4_3_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601729E RID: 94878 RVA: 0x0036B748 File Offset: 0x00369948
		public static YamlNode ExportYamlEditor_Map_GUID_Asset_5_0_0(this AssetDictionary<GUID, Asset_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_GUID_Asset_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601729F RID: 94879 RVA: 0x0036B788 File Offset: 0x00369988
		public static YamlNode ExportYamlEditor_Map_GUID_Asset_5_1_0(this AssetDictionary<GUID, Asset_5_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_GUID_Asset_5_1_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172A0 RID: 94880 RVA: 0x0036B7C8 File Offset: 0x003699C8
		public static YamlNode ExportYamlEditor_Map_GUID_Asset_5_5_0(this AssetDictionary<GUID, Asset_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_GUID_Asset_5_5_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172A1 RID: 94881 RVA: 0x0036B808 File Offset: 0x00369A08
		public static YamlNode ExportYamlEditor_Map_GUID_CachedAssetMetaData_3_4_0(this AssetDictionary<GUID, CachedAssetMetaData_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_GUID_CachedAssetMetaData_3_4_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172A2 RID: 94882 RVA: 0x0036B848 File Offset: 0x00369A48
		public static YamlNode ExportYamlEditor_Map_GUID_CachedAssetMetaData_5_0_0(this AssetDictionary<GUID, CachedAssetMetaData_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_GUID_CachedAssetMetaData_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172A3 RID: 94883 RVA: 0x0036B888 File Offset: 0x00369A88
		public static YamlNode ExportYamlEditor_Map_GUID_DeletedItem_3_4_0(this AssetDictionary<GUID, DeletedItem_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_GUID_DeletedItem_3_4_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172A4 RID: 94884 RVA: 0x0036B8C8 File Offset: 0x00369AC8
		public static YamlNode ExportYamlEditor_Map_GUID_DeletedItem_5_0_0(this AssetDictionary<GUID, DeletedItem_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_GUID_DeletedItem_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172A5 RID: 94885 RVA: 0x0036B908 File Offset: 0x00369B08
		public static YamlNode ExportYamlEditor_Map_GUID_Hash128(this AssetDictionary<GUID, Hash128> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_GUID_Hash128(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172A6 RID: 94886 RVA: 0x0036B948 File Offset: 0x00369B48
		public static YamlNode ExportYamlEditor_Map_GUID_Int32(this AssetDictionary<GUID, int> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_GUID_Int32(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172A7 RID: 94887 RVA: 0x0036B988 File Offset: 0x00369B88
		public static YamlNode ExportYamlEditor_Map_GUID_Item(this AssetDictionary<GUID, Item> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_GUID_Item(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172A8 RID: 94888 RVA: 0x0036B9C8 File Offset: 0x00369BC8
		public static YamlNode ExportYamlEditor_Map_GUID_ModifiedItem_3_4_0(this AssetDictionary<GUID, ModifiedItem_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_GUID_ModifiedItem_3_4_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172A9 RID: 94889 RVA: 0x0036BA08 File Offset: 0x00369C08
		public static YamlNode ExportYamlEditor_Map_GUID_ModifiedItem_5_0_0(this AssetDictionary<GUID, ModifiedItem_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_GUID_ModifiedItem_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172AA RID: 94890 RVA: 0x0036BA48 File Offset: 0x00369C48
		public static YamlNode ExportYamlEditor_Map_GUID_PPtr_GameObject_3_4_0(this AssetDictionary<GUID, PPtr_GameObject_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_GUID_PPtr_GameObject_3_4_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172AB RID: 94891 RVA: 0x0036BA88 File Offset: 0x00369C88
		public static YamlNode ExportYamlEditor_Map_GUID_PPtr_GameObject_5_0_0(this AssetDictionary<GUID, PPtr_GameObject_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_GUID_PPtr_GameObject_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172AC RID: 94892 RVA: 0x0036BAC8 File Offset: 0x00369CC8
		public static YamlNode ExportYamlEditor_Map_GUID_Single(this AssetDictionary<GUID, float> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_GUID_Single(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172AD RID: 94893 RVA: 0x0036BB08 File Offset: 0x00369D08
		public static YamlNode ExportYamlEditor_Map_GUID_UInt32(this AssetDictionary<GUID, uint> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_GUID_UInt32(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172AE RID: 94894 RVA: 0x0036BB48 File Offset: 0x00369D48
		public static YamlNode ExportYamlEditor_Map_GUID_Utf8String(this AssetDictionary<GUID, Utf8String> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_GUID_Utf8String(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172AF RID: 94895 RVA: 0x0036BB88 File Offset: 0x00369D88
		public static YamlNode ExportYamlEditor_Map_Hash128_Hash128(this AssetDictionary<Hash128, Hash128> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Hash128_Hash128(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172B0 RID: 94896 RVA: 0x0036BBC8 File Offset: 0x00369DC8
		public static YamlNode ExportYamlEditor_Map_Hash128_Int32(this AssetDictionary<Hash128, int> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Hash128_Int32(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172B1 RID: 94897 RVA: 0x0036BC08 File Offset: 0x00369E08
		public static YamlNode ExportYamlEditor_Map_Int32_Array_Utf8String(this AssetDictionary<int, AssetList<Utf8String>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Int32_Array_Utf8String(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172B2 RID: 94898 RVA: 0x0036BC48 File Offset: 0x00369E48
		public static YamlNode ExportYamlEditor_Map_Int32_AssetBundleFullName(this AssetDictionary<int, AssetBundleFullName> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Int32_AssetBundleFullName(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172B3 RID: 94899 RVA: 0x0036BC88 File Offset: 0x00369E88
		public static YamlNode ExportYamlEditor_Map_Int32_AssetBundleInfo(this AssetDictionary<int, AssetBundleInfo> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Int32_AssetBundleInfo(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172B4 RID: 94900 RVA: 0x0036BCC8 File Offset: 0x00369EC8
		public static YamlNode ExportYamlEditor_Map_Int32_Hash128(this AssetDictionary<int, Hash128> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Int32_Hash128(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172B5 RID: 94901 RVA: 0x0036BD08 File Offset: 0x00369F08
		public static YamlNode ExportYamlEditor_Map_Int32_Int32(this AssetDictionary<int, int> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Int32_Int32(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172B6 RID: 94902 RVA: 0x0036BD48 File Offset: 0x00369F48
		public static YamlNode ExportYamlEditor_Map_Int32_PlatformMemorySettings(this AssetDictionary<int, PlatformMemorySettings> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Int32_PlatformMemorySettings(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172B7 RID: 94903 RVA: 0x0036BD88 File Offset: 0x00369F88
		public static YamlNode ExportYamlEditor_Map_Int32_SampleSettings_2022_2_0_a17(this AssetDictionary<int, SampleSettings_2022_2_0_a17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Int32_SampleSettings_2022_2_0_a17(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172B8 RID: 94904 RVA: 0x0036BDC8 File Offset: 0x00369FC8
		public static YamlNode ExportYamlEditor_Map_Int32_SampleSettings_5_0_0(this AssetDictionary<int, SampleSettings_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Int32_SampleSettings_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172B9 RID: 94905 RVA: 0x0036BE08 File Offset: 0x0036A008
		public static YamlNode ExportYamlEditor_Map_Int32_ShaderSnippet_2017_1_0(this AssetDictionary<int, ShaderSnippet_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Int32_ShaderSnippet_2017_1_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172BA RID: 94906 RVA: 0x0036BE48 File Offset: 0x0036A048
		public static YamlNode ExportYamlEditor_Map_Int32_ShaderSnippet_2018_1_0(this AssetDictionary<int, ShaderSnippet_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Int32_ShaderSnippet_2018_1_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172BB RID: 94907 RVA: 0x0036BE88 File Offset: 0x0036A088
		public static YamlNode ExportYamlEditor_Map_Int32_ShaderSnippet_2019_1_0(this AssetDictionary<int, ShaderSnippet_2019_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Int32_ShaderSnippet_2019_1_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172BC RID: 94908 RVA: 0x0036BEC8 File Offset: 0x0036A0C8
		public static YamlNode ExportYamlEditor_Map_Int32_ShaderSnippet_2019_1_0_b1(this AssetDictionary<int, ShaderSnippet_2019_1_0_b1> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Int32_ShaderSnippet_2019_1_0_b1(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172BD RID: 94909 RVA: 0x0036BF08 File Offset: 0x0036A108
		public static YamlNode ExportYamlEditor_Map_Int32_ShaderSnippet_2019_3_0_a7(this AssetDictionary<int, ShaderSnippet_2019_3_0_a7> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Int32_ShaderSnippet_2019_3_0_a7(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172BE RID: 94910 RVA: 0x0036BF48 File Offset: 0x0036A148
		public static YamlNode ExportYamlEditor_Map_Int32_ShaderSnippet_2021_1_0(this AssetDictionary<int, ShaderSnippet_2021_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Int32_ShaderSnippet_2021_1_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172BF RID: 94911 RVA: 0x0036BF88 File Offset: 0x0036A188
		public static YamlNode ExportYamlEditor_Map_Int32_ShaderSnippet_2022_1_0_a15(this AssetDictionary<int, ShaderSnippet_2022_1_0_a15> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Int32_ShaderSnippet_2022_1_0_a15(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172C0 RID: 94912 RVA: 0x0036BFC8 File Offset: 0x0036A1C8
		public static YamlNode ExportYamlEditor_Map_Int32_ShaderSnippet_4_5_0(this AssetDictionary<int, ShaderSnippet_4_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Int32_ShaderSnippet_4_5_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172C1 RID: 94913 RVA: 0x0036C008 File Offset: 0x0036A208
		public static YamlNode ExportYamlEditor_Map_Int32_ShaderSnippet_5_0_0(this AssetDictionary<int, ShaderSnippet_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Int32_ShaderSnippet_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172C2 RID: 94914 RVA: 0x0036C048 File Offset: 0x0036A248
		public static YamlNode ExportYamlEditor_Map_Int32_ShaderSnippet_5_4_0(this AssetDictionary<int, ShaderSnippet_5_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Int32_ShaderSnippet_5_4_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172C3 RID: 94915 RVA: 0x0036C088 File Offset: 0x0036A288
		public static YamlNode ExportYamlEditor_Map_Int32_ShaderSnippet_5_5_0(this AssetDictionary<int, ShaderSnippet_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Int32_ShaderSnippet_5_5_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172C4 RID: 94916 RVA: 0x0036C0C8 File Offset: 0x0036A2C8
		public static YamlNode ExportYamlEditor_Map_Int32_ShaderSnippet_5_6_0_b2(this AssetDictionary<int, ShaderSnippet_5_6_0_b2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Int32_ShaderSnippet_5_6_0_b2(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172C5 RID: 94917 RVA: 0x0036C108 File Offset: 0x0036A308
		public static YamlNode ExportYamlEditor_Map_Int32_UInt32(this AssetDictionary<int, uint> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Int32_UInt32(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172C6 RID: 94918 RVA: 0x0036C148 File Offset: 0x0036A348
		public static YamlNode ExportYamlEditor_Map_Int32_Utf8String(this AssetDictionary<int, Utf8String> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Int32_Utf8String(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172C7 RID: 94919 RVA: 0x0036C188 File Offset: 0x0036A388
		public static YamlNode ExportYamlEditor_Map_Int32_VideoClipImporterTargetSettings(this AssetDictionary<int, VideoClipImporterTargetSettings> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Int32_VideoClipImporterTargetSettings(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172C8 RID: 94920 RVA: 0x0036C1C8 File Offset: 0x0036A3C8
		public static YamlNode ExportYamlEditor_Map_Int64_Utf8String(this AssetDictionary<long, Utf8String> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Int64_Utf8String(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172C9 RID: 94921 RVA: 0x0036C208 File Offset: 0x0036A408
		public static YamlNode ExportYamlEditor_Map_Pair_GUID_Int32_SpriteRenderData_4_3_0(this AssetDictionary<AssetPair<GUID, int>, SpriteRenderData_4_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Pair_GUID_Int32_SpriteRenderData_4_3_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172CA RID: 94922 RVA: 0x0036C248 File Offset: 0x0036A448
		public static YamlNode ExportYamlEditor_Map_Pair_GUID_Int32_SpriteRenderData_4_5_0(this AssetDictionary<AssetPair<GUID, int>, SpriteRenderData_4_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Pair_GUID_Int32_SpriteRenderData_4_5_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172CB RID: 94923 RVA: 0x0036C288 File Offset: 0x0036A488
		public static YamlNode ExportYamlEditor_Map_Pair_GUID_Int64_Array_Utf8String(this AssetDictionary<AssetPair<GUID, long>, AssetList<Utf8String>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Pair_GUID_Int64_Array_Utf8String(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172CC RID: 94924 RVA: 0x0036C2C8 File Offset: 0x0036A4C8
		public static YamlNode ExportYamlEditor_Map_Pair_GUID_Int64_SpriteAtlasData_2017_1_0(this AssetDictionary<AssetPair<GUID, long>, SpriteAtlasData_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteAtlasData_2017_1_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172CD RID: 94925 RVA: 0x0036C308 File Offset: 0x0036A508
		public static YamlNode ExportYamlEditor_Map_Pair_GUID_Int64_SpriteAtlasData_2017_1_2(this AssetDictionary<AssetPair<GUID, long>, SpriteAtlasData_2017_1_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteAtlasData_2017_1_2(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172CE RID: 94926 RVA: 0x0036C348 File Offset: 0x0036A548
		public static YamlNode ExportYamlEditor_Map_Pair_GUID_Int64_SpriteAtlasData_2017_2_0(this AssetDictionary<AssetPair<GUID, long>, SpriteAtlasData_2017_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteAtlasData_2017_2_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172CF RID: 94927 RVA: 0x0036C388 File Offset: 0x0036A588
		public static YamlNode ExportYamlEditor_Map_Pair_GUID_Int64_SpriteAtlasData_2017_2_0_b9(this AssetDictionary<AssetPair<GUID, long>, SpriteAtlasData_2017_2_0_b9> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteAtlasData_2017_2_0_b9(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172D0 RID: 94928 RVA: 0x0036C3C8 File Offset: 0x0036A5C8
		public static YamlNode ExportYamlEditor_Map_Pair_GUID_Int64_SpriteAtlasData_2020_2_0(this AssetDictionary<AssetPair<GUID, long>, SpriteAtlasData_2020_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteAtlasData_2020_2_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172D1 RID: 94929 RVA: 0x0036C408 File Offset: 0x0036A608
		public static YamlNode ExportYamlEditor_Map_Pair_GUID_Int64_SpriteRenderData_2017_1_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteRenderData_2017_1_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172D2 RID: 94930 RVA: 0x0036C448 File Offset: 0x0036A648
		public static YamlNode ExportYamlEditor_Map_Pair_GUID_Int64_SpriteRenderData_2017_1_0_b4(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2017_1_0_b4> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteRenderData_2017_1_0_b4(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172D3 RID: 94931 RVA: 0x0036C488 File Offset: 0x0036A688
		public static YamlNode ExportYamlEditor_Map_Pair_GUID_Int64_SpriteRenderData_2017_3_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2017_3_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteRenderData_2017_3_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172D4 RID: 94932 RVA: 0x0036C4C8 File Offset: 0x0036A6C8
		public static YamlNode ExportYamlEditor_Map_Pair_GUID_Int64_SpriteRenderData_2018_1_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2018_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteRenderData_2018_1_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172D5 RID: 94933 RVA: 0x0036C508 File Offset: 0x0036A708
		public static YamlNode ExportYamlEditor_Map_Pair_GUID_Int64_SpriteRenderData_2018_2_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2018_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteRenderData_2018_2_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172D6 RID: 94934 RVA: 0x0036C548 File Offset: 0x0036A748
		public static YamlNode ExportYamlEditor_Map_Pair_GUID_Int64_SpriteRenderData_2019_1_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2019_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteRenderData_2019_1_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172D7 RID: 94935 RVA: 0x0036C588 File Offset: 0x0036A788
		public static YamlNode ExportYamlEditor_Map_Pair_GUID_Int64_SpriteRenderData_5_0_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteRenderData_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172D8 RID: 94936 RVA: 0x0036C5C8 File Offset: 0x0036A7C8
		public static YamlNode ExportYamlEditor_Map_Pair_GUID_Int64_SpriteRenderData_5_2_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteRenderData_5_2_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172D9 RID: 94937 RVA: 0x0036C608 File Offset: 0x0036A808
		public static YamlNode ExportYamlEditor_Map_Pair_GUID_Int64_SpriteRenderData_5_4_6(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_4_6> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteRenderData_5_4_6(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172DA RID: 94938 RVA: 0x0036C648 File Offset: 0x0036A848
		public static YamlNode ExportYamlEditor_Map_Pair_GUID_Int64_SpriteRenderData_5_5_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteRenderData_5_5_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172DB RID: 94939 RVA: 0x0036C688 File Offset: 0x0036A888
		public static YamlNode ExportYamlEditor_Map_Pair_GUID_Int64_SpriteRenderData_5_5_3(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_5_3> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteRenderData_5_5_3(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172DC RID: 94940 RVA: 0x0036C6C8 File Offset: 0x0036A8C8
		public static YamlNode ExportYamlEditor_Map_Pair_GUID_Int64_SpriteRenderData_5_6_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_6_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteRenderData_5_6_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172DD RID: 94941 RVA: 0x0036C708 File Offset: 0x0036A908
		public static YamlNode ExportYamlEditor_Map_Pair_GUID_Int64_SpriteRenderData_5_6_0_b10(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_6_0_b10> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteRenderData_5_6_0_b10(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172DE RID: 94942 RVA: 0x0036C748 File Offset: 0x0036A948
		public static YamlNode ExportYamlEditor_Map_Pair_GUID_Int64_SpriteRenderData_5_6_2(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_6_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteRenderData_5_6_2(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172DF RID: 94943 RVA: 0x0036C788 File Offset: 0x0036A988
		public static YamlNode ExportYamlEditor_Map_Pair_UInt16_UInt16_Single(this AssetDictionary<AssetPair<ushort, ushort>, float> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Pair_UInt16_UInt16_Single(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172E0 RID: 94944 RVA: 0x0036C7C8 File Offset: 0x0036A9C8
		public static YamlNode ExportYamlEditor_Map_Pair_Utf8String_Utf8String_PlatformSettingsData_Plugin(this AssetDictionary<AssetPair<Utf8String, Utf8String>, PlatformSettingsData_Plugin> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Pair_Utf8String_Utf8String_PlatformSettingsData_Plugin(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172E1 RID: 94945 RVA: 0x0036C808 File Offset: 0x0036AA08
		public static YamlNode ExportYamlEditor_Map_PPtr_AnimatorStateMachine_Array_PPtr_AnimatorTransition(this AssetDictionary<PPtr_AnimatorStateMachine, AssetList<PPtr_AnimatorTransition>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_PPtr_AnimatorStateMachine_Array_PPtr_AnimatorTransition(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172E2 RID: 94946 RVA: 0x0036C848 File Offset: 0x0036AA48
		public static YamlNode ExportYamlEditor_Map_PPtr_Shader_3_4_0_Utf8String(this AssetDictionary<PPtr_Shader_3_4_0, Utf8String> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_PPtr_Shader_3_4_0_Utf8String(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172E3 RID: 94947 RVA: 0x0036C888 File Offset: 0x0036AA88
		public static YamlNode ExportYamlEditor_Map_PPtr_Shader_5_0_0_ShaderInfo(this AssetDictionary<PPtr_Shader_5_0_0, ShaderInfo> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_PPtr_Shader_5_0_0_ShaderInfo(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172E4 RID: 94948 RVA: 0x0036C8C8 File Offset: 0x0036AAC8
		public static YamlNode ExportYamlEditor_Map_PPtr_Shader_5_0_0_Utf8String(this AssetDictionary<PPtr_Shader_5_0_0, Utf8String> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_PPtr_Shader_5_0_0_Utf8String(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172E5 RID: 94949 RVA: 0x0036C908 File Offset: 0x0036AB08
		public static YamlNode ExportYamlEditor_Map_PPtr_State_Array_PPtr_Transition(this AssetDictionary<PPtr_State, AssetList<PPtr_Transition>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_PPtr_State_Array_PPtr_Transition(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172E6 RID: 94950 RVA: 0x0036C948 File Offset: 0x0036AB48
		public static YamlNode ExportYamlEditor_Map_PPtr_TextAsset_Utf8String(this AssetDictionary<PPtr_TextAsset, Utf8String> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_PPtr_TextAsset_Utf8String(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172E7 RID: 94951 RVA: 0x0036C988 File Offset: 0x0036AB88
		public static YamlNode ExportYamlEditor_Map_PresetType_Array_DefaultPreset_2019_3_0_a10(this AssetDictionary<PresetType, AssetList<DefaultPreset_2019_3_0_a10>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_PresetType_Array_DefaultPreset_2019_3_0_a10(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172E8 RID: 94952 RVA: 0x0036C9C8 File Offset: 0x0036ABC8
		public static YamlNode ExportYamlEditor_Map_PresetType_Array_DefaultPreset_2020_1_0_a23(this AssetDictionary<PresetType, AssetList<DefaultPreset_2020_1_0_a23>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_PresetType_Array_DefaultPreset_2020_1_0_a23(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172E9 RID: 94953 RVA: 0x0036CA08 File Offset: 0x0036AC08
		public static YamlNode ExportYamlEditor_Map_SceneIdentifier_HierarchicalSceneData(this AssetDictionary<SceneIdentifier, HierarchicalSceneData> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_SceneIdentifier_HierarchicalSceneData(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172EA RID: 94954 RVA: 0x0036CA48 File Offset: 0x0036AC48
		public static YamlNode ExportYamlEditor_Map_SceneIdentifier_SceneVisibilityData(this AssetDictionary<SceneIdentifier, SceneVisibilityData> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_SceneIdentifier_SceneVisibilityData(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172EB RID: 94955 RVA: 0x0036CA88 File Offset: 0x0036AC88
		public static YamlNode ExportYamlEditor_Map_SourceAssetIdentifier_PPtr_Object_5_0_0(this AssetDictionary<SourceAssetIdentifier, PPtr_Object_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_SourceAssetIdentifier_PPtr_Object_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172EC RID: 94956 RVA: 0x0036CAC8 File Offset: 0x0036ACC8
		public static YamlNode ExportYamlEditor_Map_UInt32_Boolean(this AssetDictionary<uint, bool> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_UInt32_Boolean(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172ED RID: 94957 RVA: 0x0036CB08 File Offset: 0x0036AD08
		public static YamlNode ExportYamlEditor_Map_UInt32_Utf8String(this AssetDictionary<uint, Utf8String> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_UInt32_Utf8String(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172EE RID: 94958 RVA: 0x0036CB48 File Offset: 0x0036AD48
		public static YamlNode ExportYamlEditor_Map_Utf8String_Array_PPtr_SpriteAtlas(this AssetDictionary<Utf8String, AssetList<PPtr_SpriteAtlas>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_Array_PPtr_SpriteAtlas(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172EF RID: 94959 RVA: 0x0036CB88 File Offset: 0x0036AD88
		public static YamlNode ExportYamlEditor_Map_Utf8String_Array_Utf8String(this AssetDictionary<Utf8String, AssetList<Utf8String>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_Array_Utf8String(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172F0 RID: 94960 RVA: 0x0036CBC8 File Offset: 0x0036ADC8
		public static YamlNode ExportYamlEditor_Map_Utf8String_AssetInfo_3_4_0(this AssetDictionary<Utf8String, AssetInfo_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_AssetInfo_3_4_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172F1 RID: 94961 RVA: 0x0036CC08 File Offset: 0x0036AE08
		public static YamlNode ExportYamlEditor_Map_Utf8String_AssetInfo_5_0_0(this AssetDictionary<Utf8String, AssetInfo_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_AssetInfo_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172F2 RID: 94962 RVA: 0x0036CC48 File Offset: 0x0036AE48
		public static YamlNode ExportYamlEditor_Map_Utf8String_AssetTimeStamp(this AssetDictionary<Utf8String, AssetTimeStamp> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_AssetTimeStamp(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172F3 RID: 94963 RVA: 0x0036CC88 File Offset: 0x0036AE88
		public static YamlNode ExportYamlEditor_Map_Utf8String_Boolean(this AssetDictionary<Utf8String, bool> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_Boolean(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172F4 RID: 94964 RVA: 0x0036CCC8 File Offset: 0x0036AEC8
		public static YamlNode ExportYamlEditor_Map_Utf8String_ColorRGBAf_3_5_0(this AssetDictionary<Utf8String, ColorRGBAf_3_5_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_ColorRGBAf_3_5_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172F5 RID: 94965 RVA: 0x0036CD08 File Offset: 0x0036AF08
		public static YamlNode ExportYamlEditor_Map_Utf8String_ComputeShaderKernel_2020_1_0_a17(this AssetDictionary<Utf8String, ComputeShaderKernel_2020_1_0_a17> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_ComputeShaderKernel_2020_1_0_a17(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172F6 RID: 94966 RVA: 0x0036CD48 File Offset: 0x0036AF48
		public static YamlNode ExportYamlEditor_Map_Utf8String_ComputeShaderKernel_2020_1_0_a9(this AssetDictionary<Utf8String, ComputeShaderKernel_2020_1_0_a9> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_ComputeShaderKernel_2020_1_0_a9(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172F7 RID: 94967 RVA: 0x0036CD88 File Offset: 0x0036AF88
		public static YamlNode ExportYamlEditor_Map_Utf8String_ComputeShaderKernel_2020_2_0_a15(this AssetDictionary<Utf8String, ComputeShaderKernel_2020_2_0_a15> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_ComputeShaderKernel_2020_2_0_a15(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172F8 RID: 94968 RVA: 0x0036CDC8 File Offset: 0x0036AFC8
		public static YamlNode ExportYamlEditor_Map_Utf8String_ComputeShaderKernel_2020_3_2(this AssetDictionary<Utf8String, ComputeShaderKernel_2020_3_2> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_ComputeShaderKernel_2020_3_2(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172F9 RID: 94969 RVA: 0x0036CE08 File Offset: 0x0036B008
		public static YamlNode ExportYamlEditor_Map_Utf8String_ComputeShaderKernel_2021_1_0(this AssetDictionary<Utf8String, ComputeShaderKernel_2021_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_ComputeShaderKernel_2021_1_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172FA RID: 94970 RVA: 0x0036CE48 File Offset: 0x0036B048
		public static YamlNode ExportYamlEditor_Map_Utf8String_ComputeShaderKernel_2021_1_0_b7(this AssetDictionary<Utf8String, ComputeShaderKernel_2021_1_0_b7> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_ComputeShaderKernel_2021_1_0_b7(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172FB RID: 94971 RVA: 0x0036CE88 File Offset: 0x0036B088
		public static YamlNode ExportYamlEditor_Map_Utf8String_ConfigSetting(this AssetDictionary<Utf8String, ConfigSetting> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_ConfigSetting(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172FC RID: 94972 RVA: 0x0036CEC8 File Offset: 0x0036B0C8
		public static YamlNode ExportYamlEditor_Map_Utf8String_GUID(this AssetDictionary<Utf8String, GUID> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_GUID(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172FD RID: 94973 RVA: 0x0036CF08 File Offset: 0x0036B108
		public static YamlNode ExportYamlEditor_Map_Utf8String_Int32(this AssetDictionary<Utf8String, int> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_Int32(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172FE RID: 94974 RVA: 0x0036CF48 File Offset: 0x0036B148
		public static YamlNode ExportYamlEditor_Map_Utf8String_Int64(this AssetDictionary<Utf8String, long> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_Int64(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x060172FF RID: 94975 RVA: 0x0036CF88 File Offset: 0x0036B188
		public static YamlNode ExportYamlEditor_Map_Utf8String_Map_Utf8String_Utf8String(this AssetDictionary<Utf8String, AssetDictionary<Utf8String, Utf8String>> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_Map_Utf8String_Utf8String(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017300 RID: 94976 RVA: 0x0036CFC8 File Offset: 0x0036B1C8
		public static YamlNode ExportYamlEditor_Map_Utf8String_NonAlignedStruct(this AssetDictionary<Utf8String, NonAlignedStruct> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_NonAlignedStruct(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017301 RID: 94977 RVA: 0x0036D008 File Offset: 0x0036B208
		public static YamlNode ExportYamlEditor_Map_Utf8String_PlatformSettingsData_Editor(this AssetDictionary<Utf8String, PlatformSettingsData_Editor> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_PlatformSettingsData_Editor(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017302 RID: 94978 RVA: 0x0036D048 File Offset: 0x0036B248
		public static YamlNode ExportYamlEditor_Map_Utf8String_PlatformSettingsData_Plugin(this AssetDictionary<Utf8String, PlatformSettingsData_Plugin> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_PlatformSettingsData_Plugin(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017303 RID: 94979 RVA: 0x0036D088 File Offset: 0x0036B288
		public static YamlNode ExportYamlEditor_Map_Utf8String_PPtr_Object_3_4_0(this AssetDictionary<Utf8String, PPtr_Object_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_PPtr_Object_3_4_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017304 RID: 94980 RVA: 0x0036D0C8 File Offset: 0x0036B2C8
		public static YamlNode ExportYamlEditor_Map_Utf8String_PPtr_Object_5_0_0(this AssetDictionary<Utf8String, PPtr_Object_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_PPtr_Object_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017305 RID: 94981 RVA: 0x0036D108 File Offset: 0x0036B308
		public static YamlNode ExportYamlEditor_Map_Utf8String_PPtr_Texture_3_4_0(this AssetDictionary<Utf8String, PPtr_Texture_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_PPtr_Texture_3_4_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017306 RID: 94982 RVA: 0x0036D148 File Offset: 0x0036B348
		public static YamlNode ExportYamlEditor_Map_Utf8String_PPtr_Texture_5_0_0(this AssetDictionary<Utf8String, PPtr_Texture_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_PPtr_Texture_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017307 RID: 94983 RVA: 0x0036D188 File Offset: 0x0036B388
		public static YamlNode ExportYamlEditor_Map_Utf8String_PPtr_Texture2D_3_4_0(this AssetDictionary<Utf8String, PPtr_Texture2D_3_4_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_PPtr_Texture2D_3_4_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017308 RID: 94984 RVA: 0x0036D1C8 File Offset: 0x0036B3C8
		public static YamlNode ExportYamlEditor_Map_Utf8String_PPtr_Texture2D_5_0_0(this AssetDictionary<Utf8String, PPtr_Texture2D_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_PPtr_Texture2D_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017309 RID: 94985 RVA: 0x0036D208 File Offset: 0x0036B408
		public static YamlNode ExportYamlEditor_Map_Utf8String_SecondaryTextureSettings_2020_2_0(this AssetDictionary<Utf8String, SecondaryTextureSettings_2020_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_SecondaryTextureSettings_2020_2_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601730A RID: 94986 RVA: 0x0036D248 File Offset: 0x0036B448
		public static YamlNode ExportYamlEditor_Map_Utf8String_SecondaryTextureSettings_2020_2_0_a12(this AssetDictionary<Utf8String, SecondaryTextureSettings_2020_2_0_a12> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_SecondaryTextureSettings_2020_2_0_a12(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601730B RID: 94987 RVA: 0x0036D288 File Offset: 0x0036B488
		public static YamlNode ExportYamlEditor_Map_Utf8String_Single(this AssetDictionary<Utf8String, float> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_Single(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601730C RID: 94988 RVA: 0x0036D2C8 File Offset: 0x0036B4C8
		public static YamlNode ExportYamlEditor_Map_Utf8String_UnityTexEnv_5_0_0(this AssetDictionary<Utf8String, UnityTexEnv_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_UnityTexEnv_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601730D RID: 94989 RVA: 0x0036D308 File Offset: 0x0036B508
		public static YamlNode ExportYamlEditor_Map_Utf8String_Utf8String(this AssetDictionary<Utf8String, Utf8String> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_Utf8String(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601730E RID: 94990 RVA: 0x0036D348 File Offset: 0x0036B548
		public static YamlNode ExportYamlEditor_Map_Utf8String_XboxOneSocketDefinition_2017_1_0(this AssetDictionary<Utf8String, XboxOneSocketDefinition_2017_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_XboxOneSocketDefinition_2017_1_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601730F RID: 94991 RVA: 0x0036D388 File Offset: 0x0036B588
		public static YamlNode ExportYamlEditor_Map_Utf8String_XboxOneSocketDefinition_5_0_0(this AssetDictionary<Utf8String, XboxOneSocketDefinition_5_0_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Utf8String_XboxOneSocketDefinition_5_0_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017310 RID: 94992 RVA: 0x0036D3C8 File Offset: 0x0036B5C8
		public static YamlNode ExportYamlEditor_Map_Vector3Int_Tile_2017_2_0(this AssetDictionary<Vector3Int, Tile_2017_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Vector3Int_Tile_2017_2_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017311 RID: 94993 RVA: 0x0036D408 File Offset: 0x0036B608
		public static YamlNode ExportYamlEditor_Map_Vector3Int_Tile_2017_2_0_b7(this AssetDictionary<Vector3Int, Tile_2017_2_0_b7> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Vector3Int_Tile_2017_2_0_b7(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017312 RID: 94994 RVA: 0x0036D448 File Offset: 0x0036B648
		public static YamlNode ExportYamlEditor_Map_Vector3Int_Tile_2019_3_0_a12(this AssetDictionary<Vector3Int, Tile_2019_3_0_a12> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Vector3Int_Tile_2019_3_0_a12(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017313 RID: 94995 RVA: 0x0036D488 File Offset: 0x0036B688
		public static YamlNode ExportYamlEditor_Map_Vector3Int_Tile_2019_4_24(this AssetDictionary<Vector3Int, Tile_2019_4_24> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Vector3Int_Tile_2019_4_24(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017314 RID: 94996 RVA: 0x0036D4C8 File Offset: 0x0036B6C8
		public static YamlNode ExportYamlEditor_Map_Vector3Int_Tile_2020_1_0(this AssetDictionary<Vector3Int, Tile_2020_1_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Vector3Int_Tile_2020_1_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017315 RID: 94997 RVA: 0x0036D508 File Offset: 0x0036B708
		public static YamlNode ExportYamlEditor_Map_Vector3Int_Tile_2020_1_8(this AssetDictionary<Vector3Int, Tile_2020_1_8> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Vector3Int_Tile_2020_1_8(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017316 RID: 94998 RVA: 0x0036D548 File Offset: 0x0036B748
		public static YamlNode ExportYamlEditor_Map_Vector3Int_Tile_2020_2_0(this AssetDictionary<Vector3Int, Tile_2020_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Vector3Int_Tile_2020_2_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017317 RID: 94999 RVA: 0x0036D588 File Offset: 0x0036B788
		public static YamlNode ExportYamlEditor_Map_Vector3Int_Tile_2020_2_0_b1(this AssetDictionary<Vector3Int, Tile_2020_2_0_b1> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Vector3Int_Tile_2020_2_0_b1(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017318 RID: 95000 RVA: 0x0036D5C8 File Offset: 0x0036B7C8
		public static YamlNode ExportYamlEditor_Map_Vector3Int_TileAnimationData_2017_2_0(this AssetDictionary<Vector3Int, TileAnimationData_2017_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Vector3Int_TileAnimationData_2017_2_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x06017319 RID: 95001 RVA: 0x0036D608 File Offset: 0x0036B808
		public static YamlNode ExportYamlEditor_Map_Vector3Int_TileAnimationData_2022_2_0(this AssetDictionary<Vector3Int, TileAnimationData_2022_2_0> value, IExportContainer container)
		{
			YamlSequenceNode yamlSequenceNode = new YamlSequenceNode(SequenceStyle.BlockCurve);
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				YamlNode yamlNode = value.GetPair(i).ExportYamlEditor_Pair_Vector3Int_TileAnimationData_2022_2_0(container);
				yamlSequenceNode.Add(yamlNode);
			}
			return yamlSequenceNode;
		}

		// Token: 0x0601731A RID: 95002 RVA: 0x0036D645 File Offset: 0x0036B845
		public static YamlNode ExportYamlEditor_Pair_AssetImporterHashKey_UInt32(this AccessPairBase<AssetImporterHashKey, uint> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor_UInt32(container));
			return yamlMappingNode;
		}

		// Token: 0x0601731B RID: 95003 RVA: 0x0036D684 File Offset: 0x0036B884
		public static YamlNode ExportYamlEditor_Pair_FastPropertyName_ColorRGBAf_3_4_0(this AccessPairBase<FastPropertyName, ColorRGBAf_3_4_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601731C RID: 95004 RVA: 0x0036D6C3 File Offset: 0x0036B8C3
		public static YamlNode ExportYamlEditor_Pair_FastPropertyName_ColorRGBAf_3_5_0(this AccessPairBase<FastPropertyName, ColorRGBAf_3_5_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601731D RID: 95005 RVA: 0x0036D702 File Offset: 0x0036B902
		public static YamlNode ExportYamlEditor_Pair_FastPropertyName_Single(this AccessPairBase<FastPropertyName, float> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor_Single(container));
			return yamlMappingNode;
		}

		// Token: 0x0601731E RID: 95006 RVA: 0x0036D741 File Offset: 0x0036B941
		public static YamlNode ExportYamlEditor_Pair_FastPropertyName_UnityTexEnv_3_4_0(this AccessPairBase<FastPropertyName, UnityTexEnv_3_4_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601731F RID: 95007 RVA: 0x0036D780 File Offset: 0x0036B980
		public static YamlNode ExportYamlEditor_Pair_FastPropertyName_UnityTexEnv_3_5_0(this AccessPairBase<FastPropertyName, UnityTexEnv_3_5_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017320 RID: 95008 RVA: 0x0036D7BF File Offset: 0x0036B9BF
		public static YamlNode ExportYamlEditor_Pair_FastPropertyName_UnityTexEnv_5_0_0(this AccessPairBase<FastPropertyName, UnityTexEnv_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017321 RID: 95009 RVA: 0x0036D7FE File Offset: 0x0036B9FE
		public static YamlNode ExportYamlEditor_Pair_GUID_Asset_2017_1_0(this AccessPairBase<GUID, Asset_2017_1_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017322 RID: 95010 RVA: 0x0036D823 File Offset: 0x0036BA23
		public static YamlNode ExportYamlEditor_Pair_GUID_Asset_2017_2_5(this AccessPairBase<GUID, Asset_2017_2_5> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017323 RID: 95011 RVA: 0x0036D848 File Offset: 0x0036BA48
		public static YamlNode ExportYamlEditor_Pair_GUID_Asset_2017_3_0(this AccessPairBase<GUID, Asset_2017_3_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017324 RID: 95012 RVA: 0x0036D86D File Offset: 0x0036BA6D
		public static YamlNode ExportYamlEditor_Pair_GUID_Asset_2017_4_14(this AccessPairBase<GUID, Asset_2017_4_14> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017325 RID: 95013 RVA: 0x0036D892 File Offset: 0x0036BA92
		public static YamlNode ExportYamlEditor_Pair_GUID_Asset_2018_1_0(this AccessPairBase<GUID, Asset_2018_1_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017326 RID: 95014 RVA: 0x0036D8B7 File Offset: 0x0036BAB7
		public static YamlNode ExportYamlEditor_Pair_GUID_Asset_2018_1_0_b11(this AccessPairBase<GUID, Asset_2018_1_0_b11> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017327 RID: 95015 RVA: 0x0036D8DC File Offset: 0x0036BADC
		public static YamlNode ExportYamlEditor_Pair_GUID_Asset_2018_3_0(this AccessPairBase<GUID, Asset_2018_3_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017328 RID: 95016 RVA: 0x0036D901 File Offset: 0x0036BB01
		public static YamlNode ExportYamlEditor_Pair_GUID_Asset_2019_3_0_a8(this AccessPairBase<GUID, Asset_2019_3_0_a8> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017329 RID: 95017 RVA: 0x0036D926 File Offset: 0x0036BB26
		public static YamlNode ExportYamlEditor_Pair_GUID_Asset_3_4_0(this AccessPairBase<GUID, Asset_3_4_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601732A RID: 95018 RVA: 0x0036D94B File Offset: 0x0036BB4B
		public static YamlNode ExportYamlEditor_Pair_GUID_Asset_3_5_0(this AccessPairBase<GUID, Asset_3_5_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601732B RID: 95019 RVA: 0x0036D970 File Offset: 0x0036BB70
		public static YamlNode ExportYamlEditor_Pair_GUID_Asset_4_0_0(this AccessPairBase<GUID, Asset_4_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601732C RID: 95020 RVA: 0x0036D995 File Offset: 0x0036BB95
		public static YamlNode ExportYamlEditor_Pair_GUID_Asset_4_3_0(this AccessPairBase<GUID, Asset_4_3_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601732D RID: 95021 RVA: 0x0036D9BA File Offset: 0x0036BBBA
		public static YamlNode ExportYamlEditor_Pair_GUID_Asset_5_0_0(this AccessPairBase<GUID, Asset_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601732E RID: 95022 RVA: 0x0036D9DF File Offset: 0x0036BBDF
		public static YamlNode ExportYamlEditor_Pair_GUID_Asset_5_1_0(this AccessPairBase<GUID, Asset_5_1_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601732F RID: 95023 RVA: 0x0036DA04 File Offset: 0x0036BC04
		public static YamlNode ExportYamlEditor_Pair_GUID_Asset_5_5_0(this AccessPairBase<GUID, Asset_5_5_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017330 RID: 95024 RVA: 0x0036DA29 File Offset: 0x0036BC29
		public static YamlNode ExportYamlEditor_Pair_GUID_CachedAssetMetaData_3_4_0(this AccessPairBase<GUID, CachedAssetMetaData_3_4_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017331 RID: 95025 RVA: 0x0036DA4E File Offset: 0x0036BC4E
		public static YamlNode ExportYamlEditor_Pair_GUID_CachedAssetMetaData_5_0_0(this AccessPairBase<GUID, CachedAssetMetaData_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017332 RID: 95026 RVA: 0x0036DA73 File Offset: 0x0036BC73
		public static YamlNode ExportYamlEditor_Pair_GUID_DeletedItem_3_4_0(this AccessPairBase<GUID, DeletedItem_3_4_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017333 RID: 95027 RVA: 0x0036DA98 File Offset: 0x0036BC98
		public static YamlNode ExportYamlEditor_Pair_GUID_DeletedItem_5_0_0(this AccessPairBase<GUID, DeletedItem_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017334 RID: 95028 RVA: 0x0036DABD File Offset: 0x0036BCBD
		public static YamlNode ExportYamlEditor_Pair_GUID_Hash128(this AccessPairBase<GUID, Hash128> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017335 RID: 95029 RVA: 0x0036DAE2 File Offset: 0x0036BCE2
		public static YamlNode ExportYamlEditor_Pair_GUID_Int32(this AccessPairBase<GUID, int> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor_Int32(container));
			return yamlMappingNode;
		}

		// Token: 0x06017336 RID: 95030 RVA: 0x0036DB07 File Offset: 0x0036BD07
		public static YamlNode ExportYamlEditor_Pair_GUID_Int64(this AccessPairBase<GUID, long> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor_Int64(container));
			return yamlMappingNode;
		}

		// Token: 0x06017337 RID: 95031 RVA: 0x0036DB2C File Offset: 0x0036BD2C
		public static YamlNode ExportYamlEditor_Pair_GUID_Item(this AccessPairBase<GUID, Item> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017338 RID: 95032 RVA: 0x0036DB51 File Offset: 0x0036BD51
		public static YamlNode ExportYamlEditor_Pair_GUID_ModifiedItem_3_4_0(this AccessPairBase<GUID, ModifiedItem_3_4_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017339 RID: 95033 RVA: 0x0036DB76 File Offset: 0x0036BD76
		public static YamlNode ExportYamlEditor_Pair_GUID_ModifiedItem_5_0_0(this AccessPairBase<GUID, ModifiedItem_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601733A RID: 95034 RVA: 0x0036DB9B File Offset: 0x0036BD9B
		public static YamlNode ExportYamlEditor_Pair_GUID_PPtr_GameObject_3_4_0(this AccessPairBase<GUID, PPtr_GameObject_3_4_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601733B RID: 95035 RVA: 0x0036DBC0 File Offset: 0x0036BDC0
		public static YamlNode ExportYamlEditor_Pair_GUID_PPtr_GameObject_5_0_0(this AccessPairBase<GUID, PPtr_GameObject_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601733C RID: 95036 RVA: 0x0036DBE5 File Offset: 0x0036BDE5
		public static YamlNode ExportYamlEditor_Pair_GUID_Single(this AccessPairBase<GUID, float> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor_Single(container));
			return yamlMappingNode;
		}

		// Token: 0x0601733D RID: 95037 RVA: 0x0036DC0A File Offset: 0x0036BE0A
		public static YamlNode ExportYamlEditor_Pair_GUID_UInt32(this AccessPairBase<GUID, uint> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor_UInt32(container));
			return yamlMappingNode;
		}

		// Token: 0x0601733E RID: 95038 RVA: 0x0036DC2F File Offset: 0x0036BE2F
		public static YamlNode ExportYamlEditor_Pair_GUID_Utf8String(this AccessPairBase<GUID, Utf8String> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601733F RID: 95039 RVA: 0x0036DC54 File Offset: 0x0036BE54
		public static YamlNode ExportYamlEditor_Pair_Hash128_Hash128(this AccessPairBase<Hash128, Hash128> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017340 RID: 95040 RVA: 0x0036DC93 File Offset: 0x0036BE93
		public static YamlNode ExportYamlEditor_Pair_Hash128_Int32(this AccessPairBase<Hash128, int> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor_Int32(container));
			return yamlMappingNode;
		}

		// Token: 0x06017341 RID: 95041 RVA: 0x0036DCD2 File Offset: 0x0036BED2
		public static YamlNode ExportYamlEditor_Pair_Int32_Array_Utf8String(this AccessPairBase<int, AssetList<Utf8String>> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor_Int32(container), value.Value.ExportYamlEditor_Array_Utf8String(container));
			return yamlMappingNode;
		}

		// Token: 0x06017342 RID: 95042 RVA: 0x0036DCF7 File Offset: 0x0036BEF7
		public static YamlNode ExportYamlEditor_Pair_Int32_AssetBundleFullName(this AccessPairBase<int, AssetBundleFullName> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor_Int32(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017343 RID: 95043 RVA: 0x0036DD1C File Offset: 0x0036BF1C
		public static YamlNode ExportYamlEditor_Pair_Int32_AssetBundleInfo(this AccessPairBase<int, AssetBundleInfo> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor_Int32(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017344 RID: 95044 RVA: 0x0036DD41 File Offset: 0x0036BF41
		public static YamlNode ExportYamlEditor_Pair_Int32_Hash128(this AccessPairBase<int, Hash128> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor_Int32(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017345 RID: 95045 RVA: 0x0036DD66 File Offset: 0x0036BF66
		public static YamlNode ExportYamlEditor_Pair_Int32_Int32(this AccessPairBase<int, int> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor_Int32(container), value.Value.ExportYamlEditor_Int32(container));
			return yamlMappingNode;
		}

		// Token: 0x06017346 RID: 95046 RVA: 0x0036DD8B File Offset: 0x0036BF8B
		public static YamlNode ExportYamlEditor_Pair_Int32_Int64(this AccessPairBase<int, long> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor_Int32(container), value.Value.ExportYamlEditor_Int64(container));
			return yamlMappingNode;
		}

		// Token: 0x06017347 RID: 95047 RVA: 0x0036DDB0 File Offset: 0x0036BFB0
		public static YamlNode ExportYamlEditor_Pair_Int32_PlatformMemorySettings(this AccessPairBase<int, PlatformMemorySettings> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor_Int32(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017348 RID: 95048 RVA: 0x0036DDD5 File Offset: 0x0036BFD5
		public static YamlNode ExportYamlEditor_Pair_Int32_PPtr_Component_3_4_0(this AccessPairBase<int, PPtr_Component_3_4_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor_Int32(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017349 RID: 95049 RVA: 0x0036DDFA File Offset: 0x0036BFFA
		public static YamlNode ExportYamlEditor_Pair_Int32_PPtr_Component_5_0_0(this AccessPairBase<int, PPtr_Component_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor_Int32(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601734A RID: 95050 RVA: 0x0036DE1F File Offset: 0x0036C01F
		public static YamlNode ExportYamlEditor_Pair_Int32_SampleSettings_2022_2_0_a17(this AccessPairBase<int, SampleSettings_2022_2_0_a17> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor_Int32(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601734B RID: 95051 RVA: 0x0036DE44 File Offset: 0x0036C044
		public static YamlNode ExportYamlEditor_Pair_Int32_SampleSettings_5_0_0(this AccessPairBase<int, SampleSettings_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor_Int32(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601734C RID: 95052 RVA: 0x0036DE69 File Offset: 0x0036C069
		public static YamlNode ExportYamlEditor_Pair_Int32_ShaderSnippet_2017_1_0(this AccessPairBase<int, ShaderSnippet_2017_1_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor_Int32(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601734D RID: 95053 RVA: 0x0036DE8E File Offset: 0x0036C08E
		public static YamlNode ExportYamlEditor_Pair_Int32_ShaderSnippet_2018_1_0(this AccessPairBase<int, ShaderSnippet_2018_1_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor_Int32(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601734E RID: 95054 RVA: 0x0036DEB3 File Offset: 0x0036C0B3
		public static YamlNode ExportYamlEditor_Pair_Int32_ShaderSnippet_2019_1_0(this AccessPairBase<int, ShaderSnippet_2019_1_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor_Int32(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601734F RID: 95055 RVA: 0x0036DED8 File Offset: 0x0036C0D8
		public static YamlNode ExportYamlEditor_Pair_Int32_ShaderSnippet_2019_1_0_b1(this AccessPairBase<int, ShaderSnippet_2019_1_0_b1> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor_Int32(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017350 RID: 95056 RVA: 0x0036DEFD File Offset: 0x0036C0FD
		public static YamlNode ExportYamlEditor_Pair_Int32_ShaderSnippet_2019_3_0_a7(this AccessPairBase<int, ShaderSnippet_2019_3_0_a7> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor_Int32(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017351 RID: 95057 RVA: 0x0036DF22 File Offset: 0x0036C122
		public static YamlNode ExportYamlEditor_Pair_Int32_ShaderSnippet_2021_1_0(this AccessPairBase<int, ShaderSnippet_2021_1_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor_Int32(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017352 RID: 95058 RVA: 0x0036DF47 File Offset: 0x0036C147
		public static YamlNode ExportYamlEditor_Pair_Int32_ShaderSnippet_2022_1_0_a15(this AccessPairBase<int, ShaderSnippet_2022_1_0_a15> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor_Int32(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017353 RID: 95059 RVA: 0x0036DF6C File Offset: 0x0036C16C
		public static YamlNode ExportYamlEditor_Pair_Int32_ShaderSnippet_4_5_0(this AccessPairBase<int, ShaderSnippet_4_5_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor_Int32(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017354 RID: 95060 RVA: 0x0036DF91 File Offset: 0x0036C191
		public static YamlNode ExportYamlEditor_Pair_Int32_ShaderSnippet_5_0_0(this AccessPairBase<int, ShaderSnippet_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor_Int32(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017355 RID: 95061 RVA: 0x0036DFB6 File Offset: 0x0036C1B6
		public static YamlNode ExportYamlEditor_Pair_Int32_ShaderSnippet_5_4_0(this AccessPairBase<int, ShaderSnippet_5_4_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor_Int32(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017356 RID: 95062 RVA: 0x0036DFDB File Offset: 0x0036C1DB
		public static YamlNode ExportYamlEditor_Pair_Int32_ShaderSnippet_5_5_0(this AccessPairBase<int, ShaderSnippet_5_5_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor_Int32(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017357 RID: 95063 RVA: 0x0036E000 File Offset: 0x0036C200
		public static YamlNode ExportYamlEditor_Pair_Int32_ShaderSnippet_5_6_0_b2(this AccessPairBase<int, ShaderSnippet_5_6_0_b2> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor_Int32(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017358 RID: 95064 RVA: 0x0036E025 File Offset: 0x0036C225
		public static YamlNode ExportYamlEditor_Pair_Int32_Single(this AccessPairBase<int, float> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor_Int32(container), value.Value.ExportYamlEditor_Single(container));
			return yamlMappingNode;
		}

		// Token: 0x06017359 RID: 95065 RVA: 0x0036E04A File Offset: 0x0036C24A
		public static YamlNode ExportYamlEditor_Pair_Int32_UInt32(this AccessPairBase<int, uint> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor_Int32(container), value.Value.ExportYamlEditor_UInt32(container));
			return yamlMappingNode;
		}

		// Token: 0x0601735A RID: 95066 RVA: 0x0036E06F File Offset: 0x0036C26F
		public static YamlNode ExportYamlEditor_Pair_Int32_Utf8String(this AccessPairBase<int, Utf8String> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor_Int32(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601735B RID: 95067 RVA: 0x0036E094 File Offset: 0x0036C294
		public static YamlNode ExportYamlEditor_Pair_Int32_VideoClipImporterTargetSettings(this AccessPairBase<int, VideoClipImporterTargetSettings> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor_Int32(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601735C RID: 95068 RVA: 0x0036E0B9 File Offset: 0x0036C2B9
		public static YamlNode ExportYamlEditor_Pair_Int64_Utf8String(this AccessPairBase<long, Utf8String> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor_Int64(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601735D RID: 95069 RVA: 0x0036E0DE File Offset: 0x0036C2DE
		public static YamlNode ExportYamlEditor_Pair_Pair_GUID_Int32_SpriteRenderData_4_3_0(this AccessPairBase<AssetPair<GUID, int>, SpriteRenderData_4_3_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor_Pair_GUID_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601735E RID: 95070 RVA: 0x0036E11D File Offset: 0x0036C31D
		public static YamlNode ExportYamlEditor_Pair_Pair_GUID_Int32_SpriteRenderData_4_5_0(this AccessPairBase<AssetPair<GUID, int>, SpriteRenderData_4_5_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor_Pair_GUID_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601735F RID: 95071 RVA: 0x0036E15C File Offset: 0x0036C35C
		public static YamlNode ExportYamlEditor_Pair_Pair_GUID_Int64_Array_Utf8String(this AccessPairBase<AssetPair<GUID, long>, AssetList<Utf8String>> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor_Array_Utf8String(container));
			return yamlMappingNode;
		}

		// Token: 0x06017360 RID: 95072 RVA: 0x0036E19B File Offset: 0x0036C39B
		public static YamlNode ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteAtlasData_2017_1_0(this AccessPairBase<AssetPair<GUID, long>, SpriteAtlasData_2017_1_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017361 RID: 95073 RVA: 0x0036E1DA File Offset: 0x0036C3DA
		public static YamlNode ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteAtlasData_2017_1_2(this AccessPairBase<AssetPair<GUID, long>, SpriteAtlasData_2017_1_2> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017362 RID: 95074 RVA: 0x0036E219 File Offset: 0x0036C419
		public static YamlNode ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteAtlasData_2017_2_0(this AccessPairBase<AssetPair<GUID, long>, SpriteAtlasData_2017_2_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017363 RID: 95075 RVA: 0x0036E258 File Offset: 0x0036C458
		public static YamlNode ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteAtlasData_2017_2_0_b9(this AccessPairBase<AssetPair<GUID, long>, SpriteAtlasData_2017_2_0_b9> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017364 RID: 95076 RVA: 0x0036E297 File Offset: 0x0036C497
		public static YamlNode ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteAtlasData_2020_2_0(this AccessPairBase<AssetPair<GUID, long>, SpriteAtlasData_2020_2_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017365 RID: 95077 RVA: 0x0036E2D6 File Offset: 0x0036C4D6
		public static YamlNode ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteRenderData_2017_1_0(this AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_2017_1_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017366 RID: 95078 RVA: 0x0036E315 File Offset: 0x0036C515
		public static YamlNode ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteRenderData_2017_1_0_b4(this AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_2017_1_0_b4> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017367 RID: 95079 RVA: 0x0036E354 File Offset: 0x0036C554
		public static YamlNode ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteRenderData_2017_3_0(this AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_2017_3_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017368 RID: 95080 RVA: 0x0036E393 File Offset: 0x0036C593
		public static YamlNode ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteRenderData_2018_1_0(this AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_2018_1_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017369 RID: 95081 RVA: 0x0036E3D2 File Offset: 0x0036C5D2
		public static YamlNode ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteRenderData_2018_2_0(this AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_2018_2_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601736A RID: 95082 RVA: 0x0036E411 File Offset: 0x0036C611
		public static YamlNode ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteRenderData_2019_1_0(this AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_2019_1_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601736B RID: 95083 RVA: 0x0036E450 File Offset: 0x0036C650
		public static YamlNode ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteRenderData_5_0_0(this AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601736C RID: 95084 RVA: 0x0036E48F File Offset: 0x0036C68F
		public static YamlNode ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteRenderData_5_2_0(this AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_5_2_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601736D RID: 95085 RVA: 0x0036E4CE File Offset: 0x0036C6CE
		public static YamlNode ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteRenderData_5_4_6(this AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_5_4_6> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601736E RID: 95086 RVA: 0x0036E50D File Offset: 0x0036C70D
		public static YamlNode ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteRenderData_5_5_0(this AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_5_5_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601736F RID: 95087 RVA: 0x0036E54C File Offset: 0x0036C74C
		public static YamlNode ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteRenderData_5_5_3(this AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_5_5_3> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017370 RID: 95088 RVA: 0x0036E58B File Offset: 0x0036C78B
		public static YamlNode ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteRenderData_5_6_0(this AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_5_6_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017371 RID: 95089 RVA: 0x0036E5CA File Offset: 0x0036C7CA
		public static YamlNode ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteRenderData_5_6_0_b10(this AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_5_6_0_b10> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017372 RID: 95090 RVA: 0x0036E609 File Offset: 0x0036C809
		public static YamlNode ExportYamlEditor_Pair_Pair_GUID_Int64_SpriteRenderData_5_6_2(this AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_5_6_2> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor_Pair_GUID_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017373 RID: 95091 RVA: 0x0036E648 File Offset: 0x0036C848
		public static YamlNode ExportYamlEditor_Pair_Pair_Int32_Int64_Utf8String(this AccessPairBase<AssetPair<int, long>, Utf8String> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor_Pair_Int32_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017374 RID: 95092 RVA: 0x0036E687 File Offset: 0x0036C887
		public static YamlNode ExportYamlEditor_Pair_Pair_UInt16_UInt16_Single(this AccessPairBase<AssetPair<ushort, ushort>, float> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor_Pair_UInt16_UInt16(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor_Single(container));
			return yamlMappingNode;
		}

		// Token: 0x06017375 RID: 95093 RVA: 0x0036E6C6 File Offset: 0x0036C8C6
		public static YamlNode ExportYamlEditor_Pair_Pair_Utf8String_Utf8String_PlatformSettingsData_Plugin(this AccessPairBase<AssetPair<Utf8String, Utf8String>, PlatformSettingsData_Plugin> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor_Pair_Utf8String_Utf8String(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017376 RID: 95094 RVA: 0x0036E705 File Offset: 0x0036C905
		public static YamlNode ExportYamlEditor_Pair_PPtr_AnimatorStateMachine_Array_PPtr_AnimatorTransition(this AccessPairBase<PPtr_AnimatorStateMachine, AssetList<PPtr_AnimatorTransition>> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor_Array_PPtr_AnimatorTransition(container));
			return yamlMappingNode;
		}

		// Token: 0x06017377 RID: 95095 RVA: 0x0036E744 File Offset: 0x0036C944
		public static YamlNode ExportYamlEditor_Pair_PPtr_Shader_3_4_0_Utf8String(this AccessPairBase<PPtr_Shader_3_4_0, Utf8String> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017378 RID: 95096 RVA: 0x0036E783 File Offset: 0x0036C983
		public static YamlNode ExportYamlEditor_Pair_PPtr_Shader_5_0_0_ShaderInfo(this AccessPairBase<PPtr_Shader_5_0_0, ShaderInfo> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017379 RID: 95097 RVA: 0x0036E7C2 File Offset: 0x0036C9C2
		public static YamlNode ExportYamlEditor_Pair_PPtr_Shader_5_0_0_Utf8String(this AccessPairBase<PPtr_Shader_5_0_0, Utf8String> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601737A RID: 95098 RVA: 0x0036E801 File Offset: 0x0036CA01
		public static YamlNode ExportYamlEditor_Pair_PPtr_SphereCollider_PPtr_SphereCollider(this AccessPairBase<PPtr_SphereCollider, PPtr_SphereCollider> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601737B RID: 95099 RVA: 0x0036E840 File Offset: 0x0036CA40
		public static YamlNode ExportYamlEditor_Pair_PPtr_State_Array_PPtr_Transition(this AccessPairBase<PPtr_State, AssetList<PPtr_Transition>> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor_Array_PPtr_Transition(container));
			return yamlMappingNode;
		}

		// Token: 0x0601737C RID: 95100 RVA: 0x0036E87F File Offset: 0x0036CA7F
		public static YamlNode ExportYamlEditor_Pair_PPtr_TextAsset_Utf8String(this AccessPairBase<PPtr_TextAsset, Utf8String> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601737D RID: 95101 RVA: 0x0036E8BE File Offset: 0x0036CABE
		public static YamlNode ExportYamlEditor_Pair_PresetType_Array_DefaultPreset_2019_3_0_a10(this AccessPairBase<PresetType, AssetList<DefaultPreset_2019_3_0_a10>> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor_Array_DefaultPreset_2019_3_0_a10(container));
			return yamlMappingNode;
		}

		// Token: 0x0601737E RID: 95102 RVA: 0x0036E8FD File Offset: 0x0036CAFD
		public static YamlNode ExportYamlEditor_Pair_PresetType_Array_DefaultPreset_2020_1_0_a23(this AccessPairBase<PresetType, AssetList<DefaultPreset_2020_1_0_a23>> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor_Array_DefaultPreset_2020_1_0_a23(container));
			return yamlMappingNode;
		}

		// Token: 0x0601737F RID: 95103 RVA: 0x0036E93C File Offset: 0x0036CB3C
		public static YamlNode ExportYamlEditor_Pair_SceneIdentifier_HierarchicalSceneData(this AccessPairBase<SceneIdentifier, HierarchicalSceneData> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017380 RID: 95104 RVA: 0x0036E97B File Offset: 0x0036CB7B
		public static YamlNode ExportYamlEditor_Pair_SceneIdentifier_SceneVisibilityData(this AccessPairBase<SceneIdentifier, SceneVisibilityData> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017381 RID: 95105 RVA: 0x0036E9BA File Offset: 0x0036CBBA
		public static YamlNode ExportYamlEditor_Pair_SourceAssetIdentifier_PPtr_Object_5_0_0(this AccessPairBase<SourceAssetIdentifier, PPtr_Object_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017382 RID: 95106 RVA: 0x0036E9F9 File Offset: 0x0036CBF9
		public static YamlNode ExportYamlEditor_Pair_UInt16_UInt16(this AccessPairBase<ushort, ushort> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor_UInt16(container), value.Value.ExportYamlEditor_UInt16(container));
			return yamlMappingNode;
		}

		// Token: 0x06017383 RID: 95107 RVA: 0x0036EA1E File Offset: 0x0036CC1E
		public static YamlNode ExportYamlEditor_Pair_UInt32_Boolean(this AccessPairBase<uint, bool> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor_UInt32(container), value.Value.ExportYamlEditor_Boolean(container));
			return yamlMappingNode;
		}

		// Token: 0x06017384 RID: 95108 RVA: 0x0036EA43 File Offset: 0x0036CC43
		public static YamlNode ExportYamlEditor_Pair_UInt32_Utf8String(this AccessPairBase<uint, Utf8String> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor_UInt32(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017385 RID: 95109 RVA: 0x0036EA68 File Offset: 0x0036CC68
		public static YamlNode ExportYamlEditor_Pair_Utf8String_Array_PPtr_SpriteAtlas(this AccessPairBase<Utf8String, AssetList<PPtr_SpriteAtlas>> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor_Array_PPtr_SpriteAtlas(container));
			return yamlMappingNode;
		}

		// Token: 0x06017386 RID: 95110 RVA: 0x0036EA8D File Offset: 0x0036CC8D
		public static YamlNode ExportYamlEditor_Pair_Utf8String_Array_Utf8String(this AccessPairBase<Utf8String, AssetList<Utf8String>> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor_Array_Utf8String(container));
			return yamlMappingNode;
		}

		// Token: 0x06017387 RID: 95111 RVA: 0x0036EAB2 File Offset: 0x0036CCB2
		public static YamlNode ExportYamlEditor_Pair_Utf8String_AssetInfo_3_4_0(this AccessPairBase<Utf8String, AssetInfo_3_4_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017388 RID: 95112 RVA: 0x0036EAD7 File Offset: 0x0036CCD7
		public static YamlNode ExportYamlEditor_Pair_Utf8String_AssetInfo_5_0_0(this AccessPairBase<Utf8String, AssetInfo_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017389 RID: 95113 RVA: 0x0036EAFC File Offset: 0x0036CCFC
		public static YamlNode ExportYamlEditor_Pair_Utf8String_AssetTimeStamp(this AccessPairBase<Utf8String, AssetTimeStamp> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601738A RID: 95114 RVA: 0x0036EB21 File Offset: 0x0036CD21
		public static YamlNode ExportYamlEditor_Pair_Utf8String_Boolean(this AccessPairBase<Utf8String, bool> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor_Boolean(container));
			return yamlMappingNode;
		}

		// Token: 0x0601738B RID: 95115 RVA: 0x0036EB46 File Offset: 0x0036CD46
		public static YamlNode ExportYamlEditor_Pair_Utf8String_ColorRGBAf_3_5_0(this AccessPairBase<Utf8String, ColorRGBAf_3_5_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601738C RID: 95116 RVA: 0x0036EB6B File Offset: 0x0036CD6B
		public static YamlNode ExportYamlEditor_Pair_Utf8String_ComputeShaderKernel_2020_1_0_a17(this AccessPairBase<Utf8String, ComputeShaderKernel_2020_1_0_a17> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601738D RID: 95117 RVA: 0x0036EB90 File Offset: 0x0036CD90
		public static YamlNode ExportYamlEditor_Pair_Utf8String_ComputeShaderKernel_2020_1_0_a9(this AccessPairBase<Utf8String, ComputeShaderKernel_2020_1_0_a9> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601738E RID: 95118 RVA: 0x0036EBB5 File Offset: 0x0036CDB5
		public static YamlNode ExportYamlEditor_Pair_Utf8String_ComputeShaderKernel_2020_2_0_a15(this AccessPairBase<Utf8String, ComputeShaderKernel_2020_2_0_a15> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601738F RID: 95119 RVA: 0x0036EBDA File Offset: 0x0036CDDA
		public static YamlNode ExportYamlEditor_Pair_Utf8String_ComputeShaderKernel_2020_3_2(this AccessPairBase<Utf8String, ComputeShaderKernel_2020_3_2> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017390 RID: 95120 RVA: 0x0036EBFF File Offset: 0x0036CDFF
		public static YamlNode ExportYamlEditor_Pair_Utf8String_ComputeShaderKernel_2021_1_0(this AccessPairBase<Utf8String, ComputeShaderKernel_2021_1_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017391 RID: 95121 RVA: 0x0036EC24 File Offset: 0x0036CE24
		public static YamlNode ExportYamlEditor_Pair_Utf8String_ComputeShaderKernel_2021_1_0_b7(this AccessPairBase<Utf8String, ComputeShaderKernel_2021_1_0_b7> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017392 RID: 95122 RVA: 0x0036EC49 File Offset: 0x0036CE49
		public static YamlNode ExportYamlEditor_Pair_Utf8String_ConfigSetting(this AccessPairBase<Utf8String, ConfigSetting> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017393 RID: 95123 RVA: 0x0036EC6E File Offset: 0x0036CE6E
		public static YamlNode ExportYamlEditor_Pair_Utf8String_GUID(this AccessPairBase<Utf8String, GUID> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017394 RID: 95124 RVA: 0x0036EC93 File Offset: 0x0036CE93
		public static YamlNode ExportYamlEditor_Pair_Utf8String_Int32(this AccessPairBase<Utf8String, int> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor_Int32(container));
			return yamlMappingNode;
		}

		// Token: 0x06017395 RID: 95125 RVA: 0x0036ECB8 File Offset: 0x0036CEB8
		public static YamlNode ExportYamlEditor_Pair_Utf8String_Int64(this AccessPairBase<Utf8String, long> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor_Int64(container));
			return yamlMappingNode;
		}

		// Token: 0x06017396 RID: 95126 RVA: 0x0036ECDD File Offset: 0x0036CEDD
		public static YamlNode ExportYamlEditor_Pair_Utf8String_Map_Utf8String_Utf8String(this AccessPairBase<Utf8String, AssetDictionary<Utf8String, Utf8String>> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor_Map_Utf8String_Utf8String(container));
			return yamlMappingNode;
		}

		// Token: 0x06017397 RID: 95127 RVA: 0x0036ED02 File Offset: 0x0036CF02
		public static YamlNode ExportYamlEditor_Pair_Utf8String_NonAlignedStruct(this AccessPairBase<Utf8String, NonAlignedStruct> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017398 RID: 95128 RVA: 0x0036ED27 File Offset: 0x0036CF27
		public static YamlNode ExportYamlEditor_Pair_Utf8String_PlatformSettingsData_Editor(this AccessPairBase<Utf8String, PlatformSettingsData_Editor> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06017399 RID: 95129 RVA: 0x0036ED4C File Offset: 0x0036CF4C
		public static YamlNode ExportYamlEditor_Pair_Utf8String_PlatformSettingsData_Plugin(this AccessPairBase<Utf8String, PlatformSettingsData_Plugin> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601739A RID: 95130 RVA: 0x0036ED71 File Offset: 0x0036CF71
		public static YamlNode ExportYamlEditor_Pair_Utf8String_PPtr_Object_3_4_0(this AccessPairBase<Utf8String, PPtr_Object_3_4_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601739B RID: 95131 RVA: 0x0036ED96 File Offset: 0x0036CF96
		public static YamlNode ExportYamlEditor_Pair_Utf8String_PPtr_Object_5_0_0(this AccessPairBase<Utf8String, PPtr_Object_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601739C RID: 95132 RVA: 0x0036EDBB File Offset: 0x0036CFBB
		public static YamlNode ExportYamlEditor_Pair_Utf8String_PPtr_Texture_3_4_0(this AccessPairBase<Utf8String, PPtr_Texture_3_4_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601739D RID: 95133 RVA: 0x0036EDE0 File Offset: 0x0036CFE0
		public static YamlNode ExportYamlEditor_Pair_Utf8String_PPtr_Texture_5_0_0(this AccessPairBase<Utf8String, PPtr_Texture_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601739E RID: 95134 RVA: 0x0036EE05 File Offset: 0x0036D005
		public static YamlNode ExportYamlEditor_Pair_Utf8String_PPtr_Texture2D_3_4_0(this AccessPairBase<Utf8String, PPtr_Texture2D_3_4_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0601739F RID: 95135 RVA: 0x0036EE2A File Offset: 0x0036D02A
		public static YamlNode ExportYamlEditor_Pair_Utf8String_PPtr_Texture2D_5_0_0(this AccessPairBase<Utf8String, PPtr_Texture2D_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x060173A0 RID: 95136 RVA: 0x0036EE4F File Offset: 0x0036D04F
		public static YamlNode ExportYamlEditor_Pair_Utf8String_SecondaryTextureSettings_2020_2_0(this AccessPairBase<Utf8String, SecondaryTextureSettings_2020_2_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x060173A1 RID: 95137 RVA: 0x0036EE74 File Offset: 0x0036D074
		public static YamlNode ExportYamlEditor_Pair_Utf8String_SecondaryTextureSettings_2020_2_0_a12(this AccessPairBase<Utf8String, SecondaryTextureSettings_2020_2_0_a12> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x060173A2 RID: 95138 RVA: 0x0036EE99 File Offset: 0x0036D099
		public static YamlNode ExportYamlEditor_Pair_Utf8String_Single(this AccessPairBase<Utf8String, float> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor_Single(container));
			return yamlMappingNode;
		}

		// Token: 0x060173A3 RID: 95139 RVA: 0x0036EEBE File Offset: 0x0036D0BE
		public static YamlNode ExportYamlEditor_Pair_Utf8String_UInt32(this AccessPairBase<Utf8String, uint> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor_UInt32(container));
			return yamlMappingNode;
		}

		// Token: 0x060173A4 RID: 95140 RVA: 0x0036EEE3 File Offset: 0x0036D0E3
		public static YamlNode ExportYamlEditor_Pair_Utf8String_UnityTexEnv_5_0_0(this AccessPairBase<Utf8String, UnityTexEnv_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x060173A5 RID: 95141 RVA: 0x0036EF08 File Offset: 0x0036D108
		public static YamlNode ExportYamlEditor_Pair_Utf8String_Utf8String(this AccessPairBase<Utf8String, Utf8String> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x060173A6 RID: 95142 RVA: 0x0036EF2D File Offset: 0x0036D12D
		public static YamlNode ExportYamlEditor_Pair_Utf8String_XboxOneSocketDefinition_2017_1_0(this AccessPairBase<Utf8String, XboxOneSocketDefinition_2017_1_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x060173A7 RID: 95143 RVA: 0x0036EF52 File Offset: 0x0036D152
		public static YamlNode ExportYamlEditor_Pair_Utf8String_XboxOneSocketDefinition_5_0_0(this AccessPairBase<Utf8String, XboxOneSocketDefinition_5_0_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(value.Key.ExportYamlEditor(container), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x060173A8 RID: 95144 RVA: 0x0036EF77 File Offset: 0x0036D177
		public static YamlNode ExportYamlEditor_Pair_Vector3Int_Tile_2017_2_0(this AccessPairBase<Vector3Int, Tile_2017_2_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x060173A9 RID: 95145 RVA: 0x0036EFB6 File Offset: 0x0036D1B6
		public static YamlNode ExportYamlEditor_Pair_Vector3Int_Tile_2017_2_0_b7(this AccessPairBase<Vector3Int, Tile_2017_2_0_b7> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x060173AA RID: 95146 RVA: 0x0036EFF5 File Offset: 0x0036D1F5
		public static YamlNode ExportYamlEditor_Pair_Vector3Int_Tile_2019_3_0_a12(this AccessPairBase<Vector3Int, Tile_2019_3_0_a12> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x060173AB RID: 95147 RVA: 0x0036F034 File Offset: 0x0036D234
		public static YamlNode ExportYamlEditor_Pair_Vector3Int_Tile_2019_4_24(this AccessPairBase<Vector3Int, Tile_2019_4_24> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x060173AC RID: 95148 RVA: 0x0036F073 File Offset: 0x0036D273
		public static YamlNode ExportYamlEditor_Pair_Vector3Int_Tile_2020_1_0(this AccessPairBase<Vector3Int, Tile_2020_1_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x060173AD RID: 95149 RVA: 0x0036F0B2 File Offset: 0x0036D2B2
		public static YamlNode ExportYamlEditor_Pair_Vector3Int_Tile_2020_1_8(this AccessPairBase<Vector3Int, Tile_2020_1_8> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x060173AE RID: 95150 RVA: 0x0036F0F1 File Offset: 0x0036D2F1
		public static YamlNode ExportYamlEditor_Pair_Vector3Int_Tile_2020_2_0(this AccessPairBase<Vector3Int, Tile_2020_2_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x060173AF RID: 95151 RVA: 0x0036F130 File Offset: 0x0036D330
		public static YamlNode ExportYamlEditor_Pair_Vector3Int_Tile_2020_2_0_b1(this AccessPairBase<Vector3Int, Tile_2020_2_0_b1> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x060173B0 RID: 95152 RVA: 0x0036F16F File Offset: 0x0036D36F
		public static YamlNode ExportYamlEditor_Pair_Vector3Int_TileAnimationData_2017_2_0(this AccessPairBase<Vector3Int, TileAnimationData_2017_2_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x060173B1 RID: 95153 RVA: 0x0036F1AE File Offset: 0x0036D3AE
		public static YamlNode ExportYamlEditor_Pair_Vector3Int_TileAnimationData_2022_2_0(this AccessPairBase<Vector3Int, TileAnimationData_2022_2_0> value, IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.Add(new YamlScalarNode("first"), value.Key.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("second"), value.Value.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x060173B2 RID: 95154 RVA: 0x0036F1ED File Offset: 0x0036D3ED
		public static YamlNode ExportYamlEditor_SByte(this sbyte value, IExportContainer container)
		{
			return new YamlScalarNode(value);
		}

		// Token: 0x060173B3 RID: 95155 RVA: 0x0036F1F5 File Offset: 0x0036D3F5
		public static YamlNode ExportYamlEditor_Single(this float value, IExportContainer container)
		{
			return new YamlScalarNode(value);
		}

		// Token: 0x060173B4 RID: 95156 RVA: 0x0036F1FD File Offset: 0x0036D3FD
		public static YamlNode ExportYamlEditor_UInt16(this ushort value, IExportContainer container)
		{
			return new YamlScalarNode(value);
		}

		// Token: 0x060173B5 RID: 95157 RVA: 0x0036F205 File Offset: 0x0036D405
		public static YamlNode ExportYamlEditor_UInt32(this uint value, IExportContainer container)
		{
			return new YamlScalarNode(value);
		}

		// Token: 0x060173B6 RID: 95158 RVA: 0x0036F20D File Offset: 0x0036D40D
		public static YamlNode ExportYamlEditor_UInt64(this ulong value, IExportContainer container)
		{
			return new YamlScalarNode(value);
		}
	}
}
