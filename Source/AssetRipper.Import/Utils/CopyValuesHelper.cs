using System;
using System.Runtime.CompilerServices;
using AssetRipper.Assets;
using AssetRipper.Assets.Cloning;
using AssetRipper.Assets.Generics;
using AssetRipper.Assets.Metadata;
using AssetRipper.SourceGenerated.Subclasses.AddedComponent;
using AssetRipper.SourceGenerated.Subclasses.AddedGameObject;
using AssetRipper.SourceGenerated.Subclasses.AlbedoSwitchInfo;
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
using AssetRipper.SourceGenerated.Subclasses.ExposedAudioParameter;
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
using AssetRipper.SourceGenerated.Subclasses.IconWithSize;
using AssetRipper.SourceGenerated.Subclasses.ImportLog_ImportLogEntry;
using AssetRipper.SourceGenerated.Subclasses.InputAxis;
using AssetRipper.SourceGenerated.Subclasses.InputImportSettings;
using AssetRipper.SourceGenerated.Subclasses.InputImportSettings_SubstanceValue;
using AssetRipper.SourceGenerated.Subclasses.IntegerString;
using AssetRipper.SourceGenerated.Subclasses.Item;
using AssetRipper.SourceGenerated.Subclasses.Keyframe_Quaternionf;
using AssetRipper.SourceGenerated.Subclasses.Keyframe_Single;
using AssetRipper.SourceGenerated.Subclasses.Keyframe_Vector3f;
using AssetRipper.SourceGenerated.Subclasses.KeywordTargetInfo;
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
using AssetRipper.SourceGenerated.Subclasses.PlatformIcon;
using AssetRipper.SourceGenerated.Subclasses.PlatformMemorySettings;
using AssetRipper.SourceGenerated.Subclasses.PlatformSettingsData_Editor;
using AssetRipper.SourceGenerated.Subclasses.PlatformSettingsData_Plugin;
using AssetRipper.SourceGenerated.Subclasses.PlatformShaderDefines;
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
using AssetRipper.SourceGenerated.Subclasses.SkeletonMaskElement;
using AssetRipper.SourceGenerated.Subclasses.SketchUpImportScene;
using AssetRipper.SourceGenerated.Subclasses.SnapshotConstant;
using AssetRipper.SourceGenerated.Subclasses.SortingLayerEntry;
using AssetRipper.SourceGenerated.Subclasses.SourceAssetIdentifier;
using AssetRipper.SourceGenerated.Subclasses.SphericalHarmonicsL2;
using AssetRipper.SourceGenerated.Subclasses.SplatPrototype;
using AssetRipper.SourceGenerated.Subclasses.SpriteAtlasData;
using AssetRipper.SourceGenerated.Subclasses.SpriteBone;
using AssetRipper.SourceGenerated.Subclasses.SpriteData;
using AssetRipper.SourceGenerated.Subclasses.SpriteMetaData;
using AssetRipper.SourceGenerated.Subclasses.SpriteRenderData;
using AssetRipper.SourceGenerated.Subclasses.SpriteVertex;
using AssetRipper.SourceGenerated.Subclasses.StateBehavioursPair;
using AssetRipper.SourceGenerated.Subclasses.StateKey;
using AssetRipper.SourceGenerated.Subclasses.StateMotionPair;
using AssetRipper.SourceGenerated.Subclasses.StateRange;
using AssetRipper.SourceGenerated.Subclasses.StreamInfo;
using AssetRipper.SourceGenerated.Subclasses.StructParameter;
using AssetRipper.SourceGenerated.Subclasses.SubCollider;
using AssetRipper.SourceGenerated.Subclasses.SubEmitterData;
using AssetRipper.SourceGenerated.Subclasses.SubMesh;
using AssetRipper.SourceGenerated.Subclasses.SubstanceEnumItem;
using AssetRipper.SourceGenerated.Subclasses.SubstanceInput;
using AssetRipper.SourceGenerated.Subclasses.TakeInfo;
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
using AssetRipper.IClasses.PPtr_AnimationClip;
using AssetRipper.Import.GICB2.PPtr_AnimationClip;
using AssetRipper.Import.GICB2.TerrainData.SplatPrototype;

namespace AssetRipper.SourceGenerated.Helpers
{
	// Token: 0x02001C21 RID: 7201


	internal static class CopyValuesHelper
	{
		// Token: 0x06016B85 RID: 93061 RVA: 0x0034E350 File Offset: 0x0034C550
		public static T[] DuplicateArray<T>(T[] array)
		{
			if (array == null || array.Length == 0)
			{
				return Array.Empty<T>();
			}
			T[] array2 = new T[array.Length];
			Array.Copy(array, array2, array.Length);
			return array2;
		}

		// Token: 0x06016B86 RID: 93062 RVA: 0x0034E380 File Offset: 0x0034C580
		public static T[][] DuplicateArrayArray<T>(T[][] array)
		{
			if (array == null || array.Length == 0)
			{
				return Array.Empty<T[]>();
			}
			T[][] array2 = new T[array.Length][];
			for (int i = 0; i < array.Length; i++)
			{
				array2[i] = CopyValuesHelper.DuplicateArray<T>(array[i]);
			}
			return array2;
		}

		// Token: 0x06016B87 RID: 93063 RVA: 0x0034E3BD File Offset: 0x0034C5BD
		public static void CopyPPtr<T>(IPPtr<T> targetPPtr, IPPtr sourcePPtr, PPtrConverter converter) where T : IUnityObjectBase
		{
			PPtrExtensions.CopyValues(targetPPtr, converter.Convert<T>(PPtrExtensions.ToStruct(sourcePPtr)));
		}

		// Token: 0x06016B88 RID: 93064 RVA: 0x0034E3D8 File Offset: 0x0034C5D8
		public static void CopyValues__AssetList_AssetPair_Int32_PPtr_Component_3_4_0__AssetList_AssetPair_Int32_PPtr_Component_3_4_0(AssetList<AssetPair<int, PPtr_Component_3_4_0>> target, AssetList<AssetPair<int, PPtr_Component_3_4_0>> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					CopyValuesHelper.CopyValues__AssetPair_Int32_PPtr_Component_3_4_0__AssetPair_Int32_PPtr_Component_3_4_0(target.AddNew(), source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016B89 RID: 93065 RVA: 0x0034E41F File Offset: 0x0034C61F
		public static void CopyValues__AssetPair_Int32_PPtr_Component_3_4_0__AssetPair_Int32_PPtr_Component_3_4_0(AssetPair<int, PPtr_Component_3_4_0> target, AssetPair<int, PPtr_Component_3_4_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key = source.Key;
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016B8A RID: 93066 RVA: 0x0034E444 File Offset: 0x0034C644
		public static void CopyValues__AssetList_AssetPair_Int32_PPtr_Component_5_0_0__AssetList_AssetPair_Int32_PPtr_Component_5_0_0(AssetList<AssetPair<int, PPtr_Component_5_0_0>> target, AssetList<AssetPair<int, PPtr_Component_5_0_0>> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					CopyValuesHelper.CopyValues__AssetPair_Int32_PPtr_Component_5_0_0__AssetPair_Int32_PPtr_Component_5_0_0(target.AddNew(), source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016B8B RID: 93067 RVA: 0x0034E48B File Offset: 0x0034C68B
		public static void CopyValues__AssetPair_Int32_PPtr_Component_5_0_0__AssetPair_Int32_PPtr_Component_5_0_0(AssetPair<int, PPtr_Component_5_0_0> target, AssetPair<int, PPtr_Component_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key = source.Key;
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016B8C RID: 93068 RVA: 0x0034E4B0 File Offset: 0x0034C6B0
		public static void CopyValues__AssetList_ComponentPair__AssetList_ComponentPair(AssetList<ComponentPair> target, AssetList<ComponentPair> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016B8D RID: 93069 RVA: 0x0034E4F8 File Offset: 0x0034C6F8
		public static void CopyValues__AssetList_PPtr_Transform_3_4_0__AccessListBase_IPPtr_Transform(AssetList<PPtr_Transform_3_4_0> target, AccessListBase<IPPtr_Transform> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016B8E RID: 93070 RVA: 0x0034E540 File Offset: 0x0034C740
		public static void CopyValues__AssetList_PPtr_Transform_5_0_0__AccessListBase_IPPtr_Transform(AssetList<PPtr_Transform_5_0_0> target, AccessListBase<IPPtr_Transform> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016B8F RID: 93071 RVA: 0x0034E588 File Offset: 0x0034C788
		public static void CopyValues__AssetList_InputAxis__AssetList_InputAxis(AssetList<InputAxis> target, AssetList<InputAxis> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016B90 RID: 93072 RVA: 0x0034E5D0 File Offset: 0x0034C7D0
		public static void CopyValues__AssetDictionary_FastPropertyName_ColorRGBAf_3_4_0__AssetDictionary_FastPropertyName_ColorRGBAf_3_4_0(AssetDictionary<FastPropertyName, ColorRGBAf_3_4_0> target, AssetDictionary<FastPropertyName, ColorRGBAf_3_4_0> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_FastPropertyName_ColorRGBAf_3_4_0__AccessPairBase_FastPropertyName_ColorRGBAf_3_4_0(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016B91 RID: 93073 RVA: 0x0034E61D File Offset: 0x0034C81D
		public static void CopyValues__AccessPairBase_FastPropertyName_ColorRGBAf_3_4_0__AccessPairBase_FastPropertyName_ColorRGBAf_3_4_0(AccessPairBase<FastPropertyName, ColorRGBAf_3_4_0> target, AccessPairBase<FastPropertyName, ColorRGBAf_3_4_0> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016B92 RID: 93074 RVA: 0x0034E644 File Offset: 0x0034C844
		public static void CopyValues__AssetDictionary_FastPropertyName_Single__AssetDictionary_FastPropertyName_Single(AssetDictionary<FastPropertyName, float> target, AssetDictionary<FastPropertyName, float> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_FastPropertyName_Single__AccessPairBase_FastPropertyName_Single(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016B93 RID: 93075 RVA: 0x0034E691 File Offset: 0x0034C891
		public static void CopyValues__AccessPairBase_FastPropertyName_Single__AccessPairBase_FastPropertyName_Single(AccessPairBase<FastPropertyName, float> target, AccessPairBase<FastPropertyName, float> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value = source.Value;
			}
		}

		// Token: 0x06016B94 RID: 93076 RVA: 0x0034E6B4 File Offset: 0x0034C8B4
		public static void CopyValues__AssetDictionary_FastPropertyName_UnityTexEnv_3_4_0__AssetDictionary_FastPropertyName_UnityTexEnv_3_4_0(AssetDictionary<FastPropertyName, UnityTexEnv_3_4_0> target, AssetDictionary<FastPropertyName, UnityTexEnv_3_4_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_FastPropertyName_UnityTexEnv_3_4_0__AccessPairBase_FastPropertyName_UnityTexEnv_3_4_0(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016B95 RID: 93077 RVA: 0x0034E702 File Offset: 0x0034C902
		public static void CopyValues__AccessPairBase_FastPropertyName_UnityTexEnv_3_4_0__AccessPairBase_FastPropertyName_UnityTexEnv_3_4_0(AccessPairBase<FastPropertyName, UnityTexEnv_3_4_0> target, AccessPairBase<FastPropertyName, UnityTexEnv_3_4_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016B96 RID: 93078 RVA: 0x0034E72C File Offset: 0x0034C92C
		public static void CopyValues__AssetDictionary_FastPropertyName_ColorRGBAf_3_5_0__AssetDictionary_FastPropertyName_ColorRGBAf_3_5_0(AssetDictionary<FastPropertyName, ColorRGBAf_3_5_0> target, AssetDictionary<FastPropertyName, ColorRGBAf_3_5_0> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_FastPropertyName_ColorRGBAf_3_5_0__AccessPairBase_FastPropertyName_ColorRGBAf_3_5_0(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016B97 RID: 93079 RVA: 0x0034E779 File Offset: 0x0034C979
		public static void CopyValues__AccessPairBase_FastPropertyName_ColorRGBAf_3_5_0__AccessPairBase_FastPropertyName_ColorRGBAf_3_5_0(AccessPairBase<FastPropertyName, ColorRGBAf_3_5_0> target, AccessPairBase<FastPropertyName, ColorRGBAf_3_5_0> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016B98 RID: 93080 RVA: 0x0034E7A0 File Offset: 0x0034C9A0
		public static void CopyValues__AssetDictionary_FastPropertyName_UnityTexEnv_3_5_0__AssetDictionary_FastPropertyName_UnityTexEnv_3_5_0(AssetDictionary<FastPropertyName, UnityTexEnv_3_5_0> target, AssetDictionary<FastPropertyName, UnityTexEnv_3_5_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_FastPropertyName_UnityTexEnv_3_5_0__AccessPairBase_FastPropertyName_UnityTexEnv_3_5_0(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016B99 RID: 93081 RVA: 0x0034E7EE File Offset: 0x0034C9EE
		public static void CopyValues__AccessPairBase_FastPropertyName_UnityTexEnv_3_5_0__AccessPairBase_FastPropertyName_UnityTexEnv_3_5_0(AccessPairBase<FastPropertyName, UnityTexEnv_3_5_0> target, AccessPairBase<FastPropertyName, UnityTexEnv_3_5_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016B9A RID: 93082 RVA: 0x0034E818 File Offset: 0x0034CA18
		public static void CopyValues__AssetDictionary_FastPropertyName_UnityTexEnv_5_0_0__AssetDictionary_FastPropertyName_UnityTexEnv_5_0_0(AssetDictionary<FastPropertyName, UnityTexEnv_5_0_0> target, AssetDictionary<FastPropertyName, UnityTexEnv_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_FastPropertyName_UnityTexEnv_5_0_0__AccessPairBase_FastPropertyName_UnityTexEnv_5_0_0(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016B9B RID: 93083 RVA: 0x0034E866 File Offset: 0x0034CA66
		public static void CopyValues__AccessPairBase_FastPropertyName_UnityTexEnv_5_0_0__AccessPairBase_FastPropertyName_UnityTexEnv_5_0_0(AccessPairBase<FastPropertyName, UnityTexEnv_5_0_0> target, AccessPairBase<FastPropertyName, UnityTexEnv_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016B9C RID: 93084 RVA: 0x0034E890 File Offset: 0x0034CA90
		public static void CopyValues__AssetDictionary_Utf8String_ColorRGBAf_3_5_0__AssetDictionary_Utf8String_ColorRGBAf_3_5_0(AssetDictionary<Utf8String, ColorRGBAf_3_5_0> target, AssetDictionary<Utf8String, ColorRGBAf_3_5_0> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_ColorRGBAf_3_5_0__AccessPairBase_Utf8String_ColorRGBAf_3_5_0(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016B9D RID: 93085 RVA: 0x0034E8DD File Offset: 0x0034CADD
		public static void CopyValues__AccessPairBase_Utf8String_ColorRGBAf_3_5_0__AccessPairBase_Utf8String_ColorRGBAf_3_5_0(AccessPairBase<Utf8String, ColorRGBAf_3_5_0> target, AccessPairBase<Utf8String, ColorRGBAf_3_5_0> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016B9E RID: 93086 RVA: 0x0034E904 File Offset: 0x0034CB04
		public static void CopyValues__AssetDictionary_Utf8String_Single__AssetDictionary_Utf8String_Single(AssetDictionary<Utf8String, float> target, AssetDictionary<Utf8String, float> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_Single__AccessPairBase_Utf8String_Single(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016B9F RID: 93087 RVA: 0x0034E951 File Offset: 0x0034CB51
		public static void CopyValues__AccessPairBase_Utf8String_Single__AccessPairBase_Utf8String_Single(AccessPairBase<Utf8String, float> target, AccessPairBase<Utf8String, float> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value = source.Value;
			}
		}

		// Token: 0x06016BA0 RID: 93088 RVA: 0x0034E974 File Offset: 0x0034CB74
		public static void CopyValues__AssetDictionary_Utf8String_UnityTexEnv_5_0_0__AssetDictionary_Utf8String_UnityTexEnv_5_0_0(AssetDictionary<Utf8String, UnityTexEnv_5_0_0> target, AssetDictionary<Utf8String, UnityTexEnv_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_UnityTexEnv_5_0_0__AccessPairBase_Utf8String_UnityTexEnv_5_0_0(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BA1 RID: 93089 RVA: 0x0034E9C2 File Offset: 0x0034CBC2
		public static void CopyValues__AccessPairBase_Utf8String_UnityTexEnv_5_0_0__AccessPairBase_Utf8String_UnityTexEnv_5_0_0(AccessPairBase<Utf8String, UnityTexEnv_5_0_0> target, AccessPairBase<Utf8String, UnityTexEnv_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016BA2 RID: 93090 RVA: 0x0034E9EC File Offset: 0x0034CBEC
		public static void CopyValues__AssetDictionary_Utf8String_Int32__AssetDictionary_Utf8String_Int32(AssetDictionary<Utf8String, int> target, AssetDictionary<Utf8String, int> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_Int32__AccessPairBase_Utf8String_Int32(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BA3 RID: 93091 RVA: 0x0034EA39 File Offset: 0x0034CC39
		public static void CopyValues__AccessPairBase_Utf8String_Int32__AccessPairBase_Utf8String_Int32(AccessPairBase<Utf8String, int> target, AccessPairBase<Utf8String, int> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value = source.Value;
			}
		}

		// Token: 0x06016BA4 RID: 93092 RVA: 0x0034EA5C File Offset: 0x0034CC5C
		public static void CopyValues__AssetList_Utf8String__AssetList_Utf8String(AssetList<Utf8String> target, AssetList<Utf8String> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BA5 RID: 93093 RVA: 0x0034EAA4 File Offset: 0x0034CCA4
		public static void CopyValues__AssetDictionary_Utf8String_Utf8String__AssetDictionary_Utf8String_Utf8String(AssetDictionary<Utf8String, Utf8String> target, AssetDictionary<Utf8String, Utf8String> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_Utf8String__AccessPairBase_Utf8String_Utf8String(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BA6 RID: 93094 RVA: 0x0034EAF1 File Offset: 0x0034CCF1
		public static void CopyValues__AccessPairBase_Utf8String_Utf8String__AccessPairBase_Utf8String_Utf8String(AccessPairBase<Utf8String, Utf8String> target, AccessPairBase<Utf8String, Utf8String> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016BA7 RID: 93095 RVA: 0x0034EB18 File Offset: 0x0034CD18
		public static void CopyValues__AssetList_BuildTextureStackReference__AssetList_BuildTextureStackReference(AssetList<BuildTextureStackReference> target, AssetList<BuildTextureStackReference> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BA8 RID: 93096 RVA: 0x0034EB60 File Offset: 0x0034CD60
		public static void CopyValues__AssetList_PPtr_Material_3_4_0__AccessListBase_IPPtr_Material(AssetList<PPtr_Material_3_4_0> target, AccessListBase<IPPtr_Material> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BA9 RID: 93097 RVA: 0x0034EBA8 File Offset: 0x0034CDA8
		public static void CopyValues__AssetList_PPtr_Material_5_0_0__AccessListBase_IPPtr_Material(AssetList<PPtr_Material_5_0_0> target, AccessListBase<IPPtr_Material> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BAA RID: 93098 RVA: 0x0034EBF0 File Offset: 0x0034CDF0
		public static void CopyValues__AssetList_PPtr_Renderer_3_4_0__AccessListBase_IPPtr_Renderer(AssetList<PPtr_Renderer_3_4_0> target, AccessListBase<IPPtr_Renderer> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BAB RID: 93099 RVA: 0x0034EC38 File Offset: 0x0034CE38
		public static void CopyValues__AssetList_PPtr_OcclusionPortal_3_5_0__AccessListBase_IPPtr_OcclusionPortal(AssetList<PPtr_OcclusionPortal_3_5_0> target, AccessListBase<IPPtr_OcclusionPortal> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BAC RID: 93100 RVA: 0x0034EC80 File Offset: 0x0034CE80
		public static void CopyValues__AssetList_PPtr_Renderer_5_0_0__AccessListBase_IPPtr_Renderer(AssetList<PPtr_Renderer_5_0_0> target, AccessListBase<IPPtr_Renderer> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BAD RID: 93101 RVA: 0x0034ECC8 File Offset: 0x0034CEC8
		public static void CopyValues__AssetList_PPtr_OcclusionPortal_5_0_0__AccessListBase_IPPtr_OcclusionPortal(AssetList<PPtr_OcclusionPortal_5_0_0> target, AccessListBase<IPPtr_OcclusionPortal> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BAE RID: 93102 RVA: 0x0034ED10 File Offset: 0x0034CF10
		public static void CopyValues__AssetList_PPtr_OcclusionPortal_5_5_0__AssetList_PPtr_OcclusionPortal_5_5_0(AssetList<PPtr_OcclusionPortal_5_5_0> target, AssetList<PPtr_OcclusionPortal_5_5_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BAF RID: 93103 RVA: 0x0034ED58 File Offset: 0x0034CF58
		public static void CopyValues__AssetList_PPtr_Renderer_5_0_0__AssetList_PPtr_Renderer_5_0_0(AssetList<PPtr_Renderer_5_0_0> target, AssetList<PPtr_Renderer_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BB0 RID: 93104 RVA: 0x0034EDA0 File Offset: 0x0034CFA0
		public static void CopyValues__AssetList_PPtr_Shader_3_4_0__AccessListBase_IPPtr_Shader(AssetList<PPtr_Shader_3_4_0> target, AccessListBase<IPPtr_Shader> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BB1 RID: 93105 RVA: 0x0034EDE8 File Offset: 0x0034CFE8
		public static void CopyValues__AssetList_PPtr_Shader_5_0_0__AccessListBase_IPPtr_Shader(AssetList<PPtr_Shader_5_0_0> target, AccessListBase<IPPtr_Shader> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BB2 RID: 93106 RVA: 0x0034EE30 File Offset: 0x0034D030
		public static void CopyValues__AssetList_PPtr_ShaderVariantCollection__AssetList_PPtr_ShaderVariantCollection(AssetList<PPtr_ShaderVariantCollection> target, AssetList<PPtr_ShaderVariantCollection> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BB3 RID: 93107 RVA: 0x0034EE78 File Offset: 0x0034D078
		public static void CopyValues__AssetList_TierSettings_5_3_0__AccessListBase_ITierSettings(AssetList<TierSettings_5_3_0> target, AccessListBase<ITierSettings> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BB4 RID: 93108 RVA: 0x0034EEC0 File Offset: 0x0034D0C0
		public static void CopyValues__AssetList_TierSettings_5_4_0__AccessListBase_ITierSettings(AssetList<TierSettings_5_4_0> target, AccessListBase<ITierSettings> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BB5 RID: 93109 RVA: 0x0034EF08 File Offset: 0x0034D108
		public static void CopyValues__AssetList_TierSettings_5_5_0__AccessListBase_ITierSettings(AssetList<TierSettings_5_5_0> target, AccessListBase<ITierSettings> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BB6 RID: 93110 RVA: 0x0034EF50 File Offset: 0x0034D150
		public static void CopyValues__AssetList_AlbedoSwitchInfo__AssetList_AlbedoSwitchInfo(AssetList<AlbedoSwitchInfo> target, AssetList<AlbedoSwitchInfo> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BB7 RID: 93111 RVA: 0x0034EF98 File Offset: 0x0034D198
		public static void CopyValues__AssetList_TierSettings_5_6_0__AccessListBase_ITierSettings(AssetList<TierSettings_5_6_0> target, AccessListBase<ITierSettings> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BB8 RID: 93112 RVA: 0x0034EFE0 File Offset: 0x0034D1E0
		public static void CopyValues__AssetList_TierSettings_5_6_0_b7__AccessListBase_ITierSettings(AssetList<TierSettings_5_6_0_b7> target, AccessListBase<ITierSettings> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BB9 RID: 93113 RVA: 0x0034F028 File Offset: 0x0034D228
		public static void CopyValues__AssetList_TierSettings_5_6_3__AccessListBase_ITierSettings(AssetList<TierSettings_5_6_3> target, AccessListBase<ITierSettings> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BBA RID: 93114 RVA: 0x0034F070 File Offset: 0x0034D270
		public static void CopyValues__AssetList_TierSettings_2017_1_0__AccessListBase_ITierSettings(AssetList<TierSettings_2017_1_0> target, AccessListBase<ITierSettings> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BBB RID: 93115 RVA: 0x0034F0B8 File Offset: 0x0034D2B8
		public static void CopyValues__AssetList_PlatformShaderDefines__AssetList_PlatformShaderDefines(AssetList<PlatformShaderDefines> target, AssetList<PlatformShaderDefines> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BBC RID: 93116 RVA: 0x0034F100 File Offset: 0x0034D300
		public static void CopyValues__AssetList_TierSettings_2017_1_0_f2__AccessListBase_ITierSettings(AssetList<TierSettings_2017_1_0_f2> target, AccessListBase<ITierSettings> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BBD RID: 93117 RVA: 0x0034F148 File Offset: 0x0034D348
		public static void CopyValues__AssetDictionary_Utf8String_PPtr_Object_5_0_0__AssetDictionary_Utf8String_PPtr_Object_5_0_0(AssetDictionary<Utf8String, PPtr_Object_5_0_0> target, AssetDictionary<Utf8String, PPtr_Object_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_PPtr_Object_5_0_0__AccessPairBase_Utf8String_PPtr_Object_5_0_0(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BBE RID: 93118 RVA: 0x0034F196 File Offset: 0x0034D396
		public static void CopyValues__AccessPairBase_Utf8String_PPtr_Object_5_0_0__AccessPairBase_Utf8String_PPtr_Object_5_0_0(AccessPairBase<Utf8String, PPtr_Object_5_0_0> target, AccessPairBase<Utf8String, PPtr_Object_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016BBF RID: 93119 RVA: 0x0034F1C0 File Offset: 0x0034D3C0
		public static void CopyValues__AssetList_Matrix4x4f__AssetList_Matrix4x4f(AssetList<Matrix4x4f> target, AssetList<Matrix4x4f> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BC0 RID: 93120 RVA: 0x0034F208 File Offset: 0x0034D408
		public static void CopyValues__AssetList_ColorRGBA32__AssetList_ColorRGBA32(AssetList<ColorRGBA32> target, AssetList<ColorRGBA32> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BC1 RID: 93121 RVA: 0x0034F250 File Offset: 0x0034D450
		public static void CopyValues__AssetList_Vector3f_3_4_0__AssetList_Vector3f_3_4_0(AssetList<Vector3f_3_4_0> target, AssetList<Vector3f_3_4_0> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BC2 RID: 93122 RVA: 0x0034F298 File Offset: 0x0034D498
		public static void CopyValues__AssetList_BoneWeights4_3_4_0__AccessListBase_IBoneWeights4(AssetList<BoneWeights4_3_4_0> target, AccessListBase<IBoneWeights4> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BC3 RID: 93123 RVA: 0x0034F2E0 File Offset: 0x0034D4E0
		public static void CopyValues__AssetList_SubMesh_3_4_0__AccessListBase_ISubMesh(AssetList<SubMesh_3_4_0> target, AccessListBase<ISubMesh> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BC4 RID: 93124 RVA: 0x0034F328 File Offset: 0x0034D528
		public static void CopyValues__AssetList_Vector4f_3_4_0__AssetList_Vector4f_3_4_0(AssetList<Vector4f_3_4_0> target, AssetList<Vector4f_3_4_0> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BC5 RID: 93125 RVA: 0x0034F370 File Offset: 0x0034D570
		public static void CopyValues__AssetList_Vector2f_3_4_0__AssetList_Vector2f_3_4_0(AssetList<Vector2f_3_4_0> target, AssetList<Vector2f_3_4_0> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BC6 RID: 93126 RVA: 0x0034F3B8 File Offset: 0x0034D5B8
		public static void CopyValues__AssetList_SubMesh_3_5_0__AccessListBase_ISubMesh(AssetList<SubMesh_3_5_0> target, AccessListBase<ISubMesh> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BC7 RID: 93127 RVA: 0x0034F400 File Offset: 0x0034D600
		public static void CopyValues__AssetList_ChannelInfo__AssetList_ChannelInfo(AssetList<ChannelInfo> target, AssetList<ChannelInfo> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BC8 RID: 93128 RVA: 0x0034F448 File Offset: 0x0034D648
		public static void CopyValues__AssetList_StreamInfo_4_0_0__AssetList_StreamInfo_4_0_0(AssetList<StreamInfo_4_0_0> target, AssetList<StreamInfo_4_0_0> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BC9 RID: 93129 RVA: 0x0034F490 File Offset: 0x0034D690
		public static void CopyValues__AssetList_SubMesh_4_0_0__AccessListBase_ISubMesh(AssetList<SubMesh_4_0_0> target, AccessListBase<ISubMesh> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BCA RID: 93130 RVA: 0x0034F4D8 File Offset: 0x0034D6D8
		public static void CopyValues__AssetList_MeshBlendShape_4_1_0__AssetList_MeshBlendShape_4_1_0(AssetList<MeshBlendShape_4_1_0> target, AssetList<MeshBlendShape_4_1_0> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BCB RID: 93131 RVA: 0x0034F520 File Offset: 0x0034D720
		public static void CopyValues__AssetList_MeshBlendShapeVertex__AssetList_MeshBlendShapeVertex(AssetList<MeshBlendShapeVertex> target, AssetList<MeshBlendShapeVertex> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BCC RID: 93132 RVA: 0x0034F568 File Offset: 0x0034D768
		public static void CopyValues__AssetList_MeshBlendShapeChannel__AssetList_MeshBlendShapeChannel(AssetList<MeshBlendShapeChannel> target, AssetList<MeshBlendShapeChannel> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BCD RID: 93133 RVA: 0x0034F5B0 File Offset: 0x0034D7B0
		public static void CopyValues__AssetList_MeshBlendShape_4_3_0__AssetList_MeshBlendShape_4_3_0(AssetList<MeshBlendShape_4_3_0> target, AssetList<MeshBlendShape_4_3_0> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BCE RID: 93134 RVA: 0x0034F5F8 File Offset: 0x0034D7F8
		public static void CopyValues__AssetList_BlendShapeVertex__AssetList_BlendShapeVertex(AssetList<BlendShapeVertex> target, AssetList<BlendShapeVertex> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BCF RID: 93135 RVA: 0x0034F640 File Offset: 0x0034D840
		public static void CopyValues__AssetList_BoneWeights4_2017_1_0__AccessListBase_IBoneWeights4(AssetList<BoneWeights4_2017_1_0> target, AccessListBase<IBoneWeights4> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BD0 RID: 93136 RVA: 0x0034F688 File Offset: 0x0034D888
		public static void CopyValues__AssetList_SubMesh_2017_3_0__AccessListBase_ISubMesh(AssetList<SubMesh_2017_3_0> target, AccessListBase<ISubMesh> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BD1 RID: 93137 RVA: 0x0034F6D0 File Offset: 0x0034D8D0
		public static void CopyValues__AssetList_MinMaxAABB__AssetList_MinMaxAABB(AssetList<MinMaxAABB> target, AssetList<MinMaxAABB> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BD2 RID: 93138 RVA: 0x0034F718 File Offset: 0x0034D918
		public static void CopyValues__AssetList_MipmapLimitSettings__AssetList_MipmapLimitSettings(AssetList<MipmapLimitSettings> target, AssetList<MipmapLimitSettings> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BD3 RID: 93139 RVA: 0x0034F760 File Offset: 0x0034D960
		public static void CopyValues__AssetList_QualitySetting_3_5_0__AccessListBase_IQualitySetting(AssetList<QualitySetting_3_5_0> target, AccessListBase<IQualitySetting> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BD4 RID: 93140 RVA: 0x0034F7A8 File Offset: 0x0034D9A8
		public static void CopyValues__AssetList_QualitySetting_4_0_0__AccessListBase_IQualitySetting(AssetList<QualitySetting_4_0_0> target, AccessListBase<IQualitySetting> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BD5 RID: 93141 RVA: 0x0034F7F0 File Offset: 0x0034D9F0
		public static void CopyValues__AssetList_QualitySetting_5_0_0__AccessListBase_IQualitySetting(AssetList<QualitySetting_5_0_0> target, AccessListBase<IQualitySetting> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BD6 RID: 93142 RVA: 0x0034F838 File Offset: 0x0034DA38
		public static void CopyValues__AssetList_QualitySetting_5_2_0__AccessListBase_IQualitySetting(AssetList<QualitySetting_5_2_0> target, AccessListBase<IQualitySetting> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BD7 RID: 93143 RVA: 0x0034F880 File Offset: 0x0034DA80
		public static void CopyValues__AssetList_QualitySetting_5_3_0__AccessListBase_IQualitySetting(AssetList<QualitySetting_5_3_0> target, AccessListBase<IQualitySetting> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BD8 RID: 93144 RVA: 0x0034F8C8 File Offset: 0x0034DAC8
		public static void CopyValues__AssetList_QualitySetting_2017_1_0__AccessListBase_IQualitySetting(AssetList<QualitySetting_2017_1_0> target, AccessListBase<IQualitySetting> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BD9 RID: 93145 RVA: 0x0034F910 File Offset: 0x0034DB10
		public static void CopyValues__AssetList_QualitySetting_2018_2_0__AccessListBase_IQualitySetting(AssetList<QualitySetting_2018_2_0> target, AccessListBase<IQualitySetting> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BDA RID: 93146 RVA: 0x0034F958 File Offset: 0x0034DB58
		public static void CopyValues__AssetList_QualitySetting_2018_3_0__AccessListBase_IQualitySetting(AssetList<QualitySetting_2018_3_0> target, AccessListBase<IQualitySetting> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BDB RID: 93147 RVA: 0x0034F9A0 File Offset: 0x0034DBA0
		public static void CopyValues__AssetList_QualitySetting_2019_1_0__AccessListBase_IQualitySetting(AssetList<QualitySetting_2019_1_0> target, AccessListBase<IQualitySetting> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BDC RID: 93148 RVA: 0x0034F9E8 File Offset: 0x0034DBE8
		public static void CopyValues__AssetList_QualitySetting_2019_3_0_a6__AccessListBase_IQualitySetting(AssetList<QualitySetting_2019_3_0_a6> target, AccessListBase<IQualitySetting> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BDD RID: 93149 RVA: 0x0034FA30 File Offset: 0x0034DC30
		public static void CopyValues__AssetList_QualitySetting_2022_2_0__AccessListBase_IQualitySetting(AssetList<QualitySetting_2022_2_0> target, AccessListBase<IQualitySetting> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BDE RID: 93150 RVA: 0x0034FA78 File Offset: 0x0034DC78
		public static void CopyValues__AssetList_QualitySetting_2022_2_0_a16__AccessListBase_IQualitySetting(AssetList<QualitySetting_2022_2_0_a16> target, AccessListBase<IQualitySetting> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BDF RID: 93151 RVA: 0x0034FAC0 File Offset: 0x0034DCC0
		public static void CopyValues__AssetList_QualitySetting_2022_2_0_a18__AccessListBase_IQualitySetting(AssetList<QualitySetting_2022_2_0_a18> target, AccessListBase<IQualitySetting> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BE0 RID: 93152 RVA: 0x0034FB08 File Offset: 0x0034DD08
		public static void CopyValues__AssetList_QualitySetting_2022_2_0_b3__AccessListBase_IQualitySetting(AssetList<QualitySetting_2022_2_0_b3> target, AccessListBase<IQualitySetting> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BE1 RID: 93153 RVA: 0x0034FB50 File Offset: 0x0034DD50
		public static void CopyValues__AssetList_ShaderError_3_4_0__AccessListBase_IShaderError(AssetList<ShaderError_3_4_0> target, AccessListBase<IShaderError> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BE2 RID: 93154 RVA: 0x0034FB98 File Offset: 0x0034DD98
		public static void CopyValues__AssetList_ShaderError_3_5_0__AccessListBase_IShaderError(AssetList<ShaderError_3_5_0> target, AccessListBase<IShaderError> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BE3 RID: 93155 RVA: 0x0034FBE0 File Offset: 0x0034DDE0
		public static void CopyValues__AssetDictionary_Utf8String_PPtr_Texture_3_4_0__AccessDictionaryBase_Utf8String_IPPtr_Texture(AssetDictionary<Utf8String, PPtr_Texture_3_4_0> target, AccessDictionaryBase<Utf8String, IPPtr_Texture> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_PPtr_Texture_3_4_0__AccessPairBase_Utf8String_IPPtr_Texture(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BE4 RID: 93156 RVA: 0x0034FC2E File Offset: 0x0034DE2E
		public static void CopyValues__AccessPairBase_Utf8String_PPtr_Texture_3_4_0__AccessPairBase_Utf8String_IPPtr_Texture(AccessPairBase<Utf8String, PPtr_Texture_3_4_0> target, AccessPairBase<Utf8String, IPPtr_Texture> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016BE5 RID: 93157 RVA: 0x0034FC58 File Offset: 0x0034DE58
		public static void CopyValues__AssetDictionary_Int32_ShaderSnippet_4_5_0__AccessDictionaryBase_Int32_IShaderSnippet(AssetDictionary<int, ShaderSnippet_4_5_0> target, AccessDictionaryBase<int, IShaderSnippet> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Int32_ShaderSnippet_4_5_0__AccessPairBase_Int32_IShaderSnippet(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BE6 RID: 93158 RVA: 0x0034FCA5 File Offset: 0x0034DEA5
		public static void CopyValues__AccessPairBase_Int32_ShaderSnippet_4_5_0__AccessPairBase_Int32_IShaderSnippet(AccessPairBase<int, ShaderSnippet_4_5_0> target, AccessPairBase<int, IShaderSnippet> source)
		{
			if (source != null)
			{
				target.Key = source.Key;
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016BE7 RID: 93159 RVA: 0x0034FCC8 File Offset: 0x0034DEC8
		public static void CopyValues__AssetList_AssetList_Utf8String__AssetList_AssetList_Utf8String(AssetList<AssetList<Utf8String>> target, AssetList<AssetList<Utf8String>> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					CopyValuesHelper.CopyValues__AssetList_Utf8String__AssetList_Utf8String(target.AddNew(), source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BE8 RID: 93160 RVA: 0x0034FD10 File Offset: 0x0034DF10
		public static void CopyValues__AssetList_KeywordTargetInfo_5_6_0_b2__AccessListBase_IKeywordTargetInfo(AssetList<KeywordTargetInfo_5_6_0_b2> target, AccessListBase<IKeywordTargetInfo> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BE9 RID: 93161 RVA: 0x0034FD58 File Offset: 0x0034DF58
		public static void CopyValues__AssetList_KeywordTargetInfo_2021_1_0__AccessListBase_IKeywordTargetInfo(AssetList<KeywordTargetInfo_2021_1_0> target, AccessListBase<IKeywordTargetInfo> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BEA RID: 93162 RVA: 0x0034FDA0 File Offset: 0x0034DFA0
		public static void CopyValues__AssetDictionary_Int32_ShaderSnippet_5_0_0__AccessDictionaryBase_Int32_IShaderSnippet(AssetDictionary<int, ShaderSnippet_5_0_0> target, AccessDictionaryBase<int, IShaderSnippet> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Int32_ShaderSnippet_5_0_0__AccessPairBase_Int32_IShaderSnippet(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BEB RID: 93163 RVA: 0x0034FDED File Offset: 0x0034DFED
		public static void CopyValues__AccessPairBase_Int32_ShaderSnippet_5_0_0__AccessPairBase_Int32_IShaderSnippet(AccessPairBase<int, ShaderSnippet_5_0_0> target, AccessPairBase<int, IShaderSnippet> source)
		{
			if (source != null)
			{
				target.Key = source.Key;
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016BEC RID: 93164 RVA: 0x0034FE10 File Offset: 0x0034E010
		public static void CopyValues__AssetDictionary_Int32_ShaderSnippet_5_4_0__AccessDictionaryBase_Int32_IShaderSnippet(AssetDictionary<int, ShaderSnippet_5_4_0> target, AccessDictionaryBase<int, IShaderSnippet> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Int32_ShaderSnippet_5_4_0__AccessPairBase_Int32_IShaderSnippet(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BED RID: 93165 RVA: 0x0034FE5D File Offset: 0x0034E05D
		public static void CopyValues__AccessPairBase_Int32_ShaderSnippet_5_4_0__AccessPairBase_Int32_IShaderSnippet(AccessPairBase<int, ShaderSnippet_5_4_0> target, AccessPairBase<int, IShaderSnippet> source)
		{
			if (source != null)
			{
				target.Key = source.Key;
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016BEE RID: 93166 RVA: 0x0034FE80 File Offset: 0x0034E080
		public static void CopyValues__AssetDictionary_Int32_ShaderSnippet_5_5_0__AccessDictionaryBase_Int32_IShaderSnippet(AssetDictionary<int, ShaderSnippet_5_5_0> target, AccessDictionaryBase<int, IShaderSnippet> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Int32_ShaderSnippet_5_5_0__AccessPairBase_Int32_IShaderSnippet(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BEF RID: 93167 RVA: 0x0034FECD File Offset: 0x0034E0CD
		public static void CopyValues__AccessPairBase_Int32_ShaderSnippet_5_5_0__AccessPairBase_Int32_IShaderSnippet(AccessPairBase<int, ShaderSnippet_5_5_0> target, AccessPairBase<int, IShaderSnippet> source)
		{
			if (source != null)
			{
				target.Key = source.Key;
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016BF0 RID: 93168 RVA: 0x0034FEF0 File Offset: 0x0034E0F0
		public static void CopyValues__AssetDictionary_Int32_ShaderSnippet_5_6_0_b2__AccessDictionaryBase_Int32_IShaderSnippet(AssetDictionary<int, ShaderSnippet_5_6_0_b2> target, AccessDictionaryBase<int, IShaderSnippet> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Int32_ShaderSnippet_5_6_0_b2__AccessPairBase_Int32_IShaderSnippet(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BF1 RID: 93169 RVA: 0x0034FF3D File Offset: 0x0034E13D
		public static void CopyValues__AccessPairBase_Int32_ShaderSnippet_5_6_0_b2__AccessPairBase_Int32_IShaderSnippet(AccessPairBase<int, ShaderSnippet_5_6_0_b2> target, AccessPairBase<int, IShaderSnippet> source)
		{
			if (source != null)
			{
				target.Key = source.Key;
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016BF2 RID: 93170 RVA: 0x0034FF60 File Offset: 0x0034E160
		public static void CopyValues__AssetDictionary_Int32_ShaderSnippet_2017_1_0__AccessDictionaryBase_Int32_IShaderSnippet(AssetDictionary<int, ShaderSnippet_2017_1_0> target, AccessDictionaryBase<int, IShaderSnippet> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Int32_ShaderSnippet_2017_1_0__AccessPairBase_Int32_IShaderSnippet(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BF3 RID: 93171 RVA: 0x0034FFAD File Offset: 0x0034E1AD
		public static void CopyValues__AccessPairBase_Int32_ShaderSnippet_2017_1_0__AccessPairBase_Int32_IShaderSnippet(AccessPairBase<int, ShaderSnippet_2017_1_0> target, AccessPairBase<int, IShaderSnippet> source)
		{
			if (source != null)
			{
				target.Key = source.Key;
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016BF4 RID: 93172 RVA: 0x0034FFD0 File Offset: 0x0034E1D0
		public static void CopyValues__AssetDictionary_Int32_ShaderSnippet_2018_1_0__AccessDictionaryBase_Int32_IShaderSnippet(AssetDictionary<int, ShaderSnippet_2018_1_0> target, AccessDictionaryBase<int, IShaderSnippet> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Int32_ShaderSnippet_2018_1_0__AccessPairBase_Int32_IShaderSnippet(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BF5 RID: 93173 RVA: 0x0035001D File Offset: 0x0034E21D
		public static void CopyValues__AccessPairBase_Int32_ShaderSnippet_2018_1_0__AccessPairBase_Int32_IShaderSnippet(AccessPairBase<int, ShaderSnippet_2018_1_0> target, AccessPairBase<int, IShaderSnippet> source)
		{
			if (source != null)
			{
				target.Key = source.Key;
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016BF6 RID: 93174 RVA: 0x00350040 File Offset: 0x0034E240
		public static void CopyValues__AssetDictionary_Int32_ShaderSnippet_2019_1_0__AccessDictionaryBase_Int32_IShaderSnippet(AssetDictionary<int, ShaderSnippet_2019_1_0> target, AccessDictionaryBase<int, IShaderSnippet> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Int32_ShaderSnippet_2019_1_0__AccessPairBase_Int32_IShaderSnippet(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BF7 RID: 93175 RVA: 0x0035008D File Offset: 0x0034E28D
		public static void CopyValues__AccessPairBase_Int32_ShaderSnippet_2019_1_0__AccessPairBase_Int32_IShaderSnippet(AccessPairBase<int, ShaderSnippet_2019_1_0> target, AccessPairBase<int, IShaderSnippet> source)
		{
			if (source != null)
			{
				target.Key = source.Key;
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016BF8 RID: 93176 RVA: 0x003500B0 File Offset: 0x0034E2B0
		public static void CopyValues__AssetDictionary_Int32_ShaderSnippet_2019_1_0_b1__AccessDictionaryBase_Int32_IShaderSnippet(AssetDictionary<int, ShaderSnippet_2019_1_0_b1> target, AccessDictionaryBase<int, IShaderSnippet> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Int32_ShaderSnippet_2019_1_0_b1__AccessPairBase_Int32_IShaderSnippet(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BF9 RID: 93177 RVA: 0x003500FD File Offset: 0x0034E2FD
		public static void CopyValues__AccessPairBase_Int32_ShaderSnippet_2019_1_0_b1__AccessPairBase_Int32_IShaderSnippet(AccessPairBase<int, ShaderSnippet_2019_1_0_b1> target, AccessPairBase<int, IShaderSnippet> source)
		{
			if (source != null)
			{
				target.Key = source.Key;
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016BFA RID: 93178 RVA: 0x00350120 File Offset: 0x0034E320
		public static void CopyValues__AssetDictionary_Int32_ShaderSnippet_2019_3_0_a7__AccessDictionaryBase_Int32_IShaderSnippet(AssetDictionary<int, ShaderSnippet_2019_3_0_a7> target, AccessDictionaryBase<int, IShaderSnippet> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Int32_ShaderSnippet_2019_3_0_a7__AccessPairBase_Int32_IShaderSnippet(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BFB RID: 93179 RVA: 0x0035016D File Offset: 0x0034E36D
		public static void CopyValues__AccessPairBase_Int32_ShaderSnippet_2019_3_0_a7__AccessPairBase_Int32_IShaderSnippet(AccessPairBase<int, ShaderSnippet_2019_3_0_a7> target, AccessPairBase<int, IShaderSnippet> source)
		{
			if (source != null)
			{
				target.Key = source.Key;
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016BFC RID: 93180 RVA: 0x00350190 File Offset: 0x0034E390
		public static void CopyValues__AssetDictionary_Int32_ShaderSnippet_2021_1_0__AccessDictionaryBase_Int32_IShaderSnippet(AssetDictionary<int, ShaderSnippet_2021_1_0> target, AccessDictionaryBase<int, IShaderSnippet> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Int32_ShaderSnippet_2021_1_0__AccessPairBase_Int32_IShaderSnippet(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BFD RID: 93181 RVA: 0x003501DD File Offset: 0x0034E3DD
		public static void CopyValues__AccessPairBase_Int32_ShaderSnippet_2021_1_0__AccessPairBase_Int32_IShaderSnippet(AccessPairBase<int, ShaderSnippet_2021_1_0> target, AccessPairBase<int, IShaderSnippet> source)
		{
			if (source != null)
			{
				target.Key = source.Key;
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016BFE RID: 93182 RVA: 0x00350200 File Offset: 0x0034E400
		public static void CopyValues__AssetDictionary_Int32_ShaderSnippet_2022_1_0_a15__AccessDictionaryBase_Int32_IShaderSnippet(AssetDictionary<int, ShaderSnippet_2022_1_0_a15> target, AccessDictionaryBase<int, IShaderSnippet> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Int32_ShaderSnippet_2022_1_0_a15__AccessPairBase_Int32_IShaderSnippet(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016BFF RID: 93183 RVA: 0x0035024D File Offset: 0x0034E44D
		public static void CopyValues__AccessPairBase_Int32_ShaderSnippet_2022_1_0_a15__AccessPairBase_Int32_IShaderSnippet(AccessPairBase<int, ShaderSnippet_2022_1_0_a15> target, AccessPairBase<int, IShaderSnippet> source)
		{
			if (source != null)
			{
				target.Key = source.Key;
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016C00 RID: 93184 RVA: 0x00350270 File Offset: 0x0034E470
		public static void CopyValues__AssetList_ShaderError_4_5_0__AccessListBase_IShaderError(AssetList<ShaderError_4_5_0> target, AccessListBase<IShaderError> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C01 RID: 93185 RVA: 0x003502B8 File Offset: 0x0034E4B8
		public static void CopyValues__AssetDictionary_Utf8String_PPtr_Texture_5_0_0__AccessDictionaryBase_Utf8String_IPPtr_Texture(AssetDictionary<Utf8String, PPtr_Texture_5_0_0> target, AccessDictionaryBase<Utf8String, IPPtr_Texture> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_PPtr_Texture_5_0_0__AccessPairBase_Utf8String_IPPtr_Texture(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C02 RID: 93186 RVA: 0x00350306 File Offset: 0x0034E506
		public static void CopyValues__AccessPairBase_Utf8String_PPtr_Texture_5_0_0__AccessPairBase_Utf8String_IPPtr_Texture(AccessPairBase<Utf8String, PPtr_Texture_5_0_0> target, AccessPairBase<Utf8String, IPPtr_Texture> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016C03 RID: 93187 RVA: 0x00350330 File Offset: 0x0034E530
		public static void CopyValues__AssetList_SerializedShaderDependency__AssetList_SerializedShaderDependency(AssetList<SerializedShaderDependency> target, AssetList<SerializedShaderDependency> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C04 RID: 93188 RVA: 0x00350378 File Offset: 0x0034E578
		public static void CopyValues__AssetList_SerializedProperty_5_5_0__AccessListBase_ISerializedProperty(AssetList<SerializedProperty_5_5_0> target, AccessListBase<ISerializedProperty> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C05 RID: 93189 RVA: 0x003503C0 File Offset: 0x0034E5C0
		public static void CopyValues__AssetList_SerializedProperty_2017_1_0__AccessListBase_ISerializedProperty(AssetList<SerializedProperty_2017_1_0> target, AccessListBase<ISerializedProperty> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C06 RID: 93190 RVA: 0x00350408 File Offset: 0x0034E608
		public static void CopyValues__AssetList_SerializedSubShader_5_5_0__AccessListBase_ISerializedSubShader(AssetList<SerializedSubShader_5_5_0> target, AccessListBase<ISerializedSubShader> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C07 RID: 93191 RVA: 0x00350450 File Offset: 0x0034E650
		public static void CopyValues__AssetList_SerializedPass_5_5_0__AccessListBase_ISerializedPass(AssetList<SerializedPass_5_5_0> target, AccessListBase<ISerializedPass> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C08 RID: 93192 RVA: 0x00350498 File Offset: 0x0034E698
		public static void CopyValues__AssetList_SerializedSubProgram_5_5_0__AccessListBase_ISerializedSubProgram(AssetList<SerializedSubProgram_5_5_0> target, AccessListBase<ISerializedSubProgram> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C09 RID: 93193 RVA: 0x003504E0 File Offset: 0x0034E6E0
		public static void CopyValues__AssetList_BufferBinding_5_5_0__AccessListBase_IBufferBinding(AssetList<BufferBinding_5_5_0> target, AccessListBase<IBufferBinding> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C0A RID: 93194 RVA: 0x00350528 File Offset: 0x0034E728
		public static void CopyValues__AssetList_ShaderBindChannel__AssetList_ShaderBindChannel(AssetList<ShaderBindChannel> target, AssetList<ShaderBindChannel> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C0B RID: 93195 RVA: 0x00350570 File Offset: 0x0034E770
		public static void CopyValues__AssetList_ConstantBuffer_5_5_0__AccessListBase_IConstantBuffer(AssetList<ConstantBuffer_5_5_0> target, AccessListBase<IConstantBuffer> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C0C RID: 93196 RVA: 0x003505B8 File Offset: 0x0034E7B8
		public static void CopyValues__AssetList_MatrixParameter__AssetList_MatrixParameter(AssetList<MatrixParameter> target, AssetList<MatrixParameter> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C0D RID: 93197 RVA: 0x00350600 File Offset: 0x0034E800
		public static void CopyValues__AssetList_VectorParameter__AssetList_VectorParameter(AssetList<VectorParameter> target, AssetList<VectorParameter> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C0E RID: 93198 RVA: 0x00350648 File Offset: 0x0034E848
		public static void CopyValues__AssetList_StructParameter__AssetList_StructParameter(AssetList<StructParameter> target, AssetList<StructParameter> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C0F RID: 93199 RVA: 0x00350690 File Offset: 0x0034E890
		public static void CopyValues__AssetList_TextureParameter_5_5_0__AccessListBase_ITextureParameter(AssetList<TextureParameter_5_5_0> target, AccessListBase<ITextureParameter> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C10 RID: 93200 RVA: 0x003506D8 File Offset: 0x0034E8D8
		public static void CopyValues__AssetList_UAVParameter__AssetList_UAVParameter(AssetList<UAVParameter> target, AssetList<UAVParameter> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C11 RID: 93201 RVA: 0x00350720 File Offset: 0x0034E920
		public static void CopyValues__AssetList_ConstantBuffer_2017_1_0__AccessListBase_IConstantBuffer(AssetList<ConstantBuffer_2017_1_0> target, AccessListBase<IConstantBuffer> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C12 RID: 93202 RVA: 0x00350768 File Offset: 0x0034E968
		public static void CopyValues__AssetList_SamplerParameter__AssetList_SamplerParameter(AssetList<SamplerParameter> target, AssetList<SamplerParameter> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C13 RID: 93203 RVA: 0x003507B0 File Offset: 0x0034E9B0
		public static void CopyValues__AssetList_ConstantBuffer_2017_3_0__AccessListBase_IConstantBuffer(AssetList<ConstantBuffer_2017_3_0> target, AccessListBase<IConstantBuffer> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C14 RID: 93204 RVA: 0x003507F8 File Offset: 0x0034E9F8
		public static void CopyValues__AssetList_TextureParameter_2017_3_0__AccessListBase_ITextureParameter(AssetList<TextureParameter_2017_3_0> target, AccessListBase<ITextureParameter> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C15 RID: 93205 RVA: 0x00350840 File Offset: 0x0034EA40
		public static void CopyValues__AssetList_BufferBinding_2020_1_0_a17__AccessListBase_IBufferBinding(AssetList<BufferBinding_2020_1_0_a17> target, AccessListBase<IBufferBinding> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C16 RID: 93206 RVA: 0x00350888 File Offset: 0x0034EA88
		public static void CopyValues__AssetList_BufferBinding_2020_1_0_a17__AssetList_BufferBinding_2020_1_0_a17(AssetList<BufferBinding_2020_1_0_a17> target, AssetList<BufferBinding_2020_1_0_a17> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C17 RID: 93207 RVA: 0x003508D0 File Offset: 0x0034EAD0
		public static void CopyValues__AssetList_ConstantBuffer_2020_3_2__AccessListBase_IConstantBuffer(AssetList<ConstantBuffer_2020_3_2> target, AccessListBase<IConstantBuffer> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C18 RID: 93208 RVA: 0x00350918 File Offset: 0x0034EB18
		public static void CopyValues__AssetList_TextureParameter_2017_3_0__AssetList_TextureParameter_2017_3_0(AssetList<TextureParameter_2017_3_0> target, AssetList<TextureParameter_2017_3_0> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C19 RID: 93209 RVA: 0x00350960 File Offset: 0x0034EB60
		public static void CopyValues__AssetList_ConstantBuffer_2021_1_1__AccessListBase_IConstantBuffer(AssetList<ConstantBuffer_2021_1_1> target, AccessListBase<IConstantBuffer> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C1A RID: 93210 RVA: 0x003509A8 File Offset: 0x0034EBA8
		public static void CopyValues__AssetList_ConstantBuffer_2021_1_0__AccessListBase_IConstantBuffer(AssetList<ConstantBuffer_2021_1_0> target, AccessListBase<IConstantBuffer> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C1B RID: 93211 RVA: 0x003509F0 File Offset: 0x0034EBF0
		public static void CopyValues__AssetList_SerializedSubProgram_5_6_0__AccessListBase_ISerializedSubProgram(AssetList<SerializedSubProgram_5_6_0> target, AccessListBase<ISerializedSubProgram> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C1C RID: 93212 RVA: 0x00350A38 File Offset: 0x0034EC38
		public static void CopyValues__AssetList_SerializedSubProgram_2017_1_0__AccessListBase_ISerializedSubProgram(AssetList<SerializedSubProgram_2017_1_0> target, AccessListBase<ISerializedSubProgram> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C1D RID: 93213 RVA: 0x00350A80 File Offset: 0x0034EC80
		public static void CopyValues__AssetList_SerializedSubProgram_2017_2_0__AccessListBase_ISerializedSubProgram(AssetList<SerializedSubProgram_2017_2_0> target, AccessListBase<ISerializedSubProgram> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C1E RID: 93214 RVA: 0x00350AC8 File Offset: 0x0034ECC8
		public static void CopyValues__AssetList_SerializedSubProgram_2017_3_0__AccessListBase_ISerializedSubProgram(AssetList<SerializedSubProgram_2017_3_0> target, AccessListBase<ISerializedSubProgram> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C1F RID: 93215 RVA: 0x00350B10 File Offset: 0x0034ED10
		public static void CopyValues__AssetList_SerializedSubProgram_2019_1_0__AccessListBase_ISerializedSubProgram(AssetList<SerializedSubProgram_2019_1_0> target, AccessListBase<ISerializedSubProgram> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C20 RID: 93216 RVA: 0x00350B58 File Offset: 0x0034ED58
		public static void CopyValues__AssetList_SerializedSubProgram_2020_1_0_a17__AccessListBase_ISerializedSubProgram(AssetList<SerializedSubProgram_2020_1_0_a17> target, AccessListBase<ISerializedSubProgram> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C21 RID: 93217 RVA: 0x00350BA0 File Offset: 0x0034EDA0
		public static void CopyValues__AssetList_SerializedSubProgram_2020_3_2__AccessListBase_ISerializedSubProgram(AssetList<SerializedSubProgram_2020_3_2> target, AccessListBase<ISerializedSubProgram> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C22 RID: 93218 RVA: 0x00350BE8 File Offset: 0x0034EDE8
		public static void CopyValues__AssetList_SerializedSubProgram_2021_1_0__AccessListBase_ISerializedSubProgram(AssetList<SerializedSubProgram_2021_1_0> target, AccessListBase<ISerializedSubProgram> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C23 RID: 93219 RVA: 0x00350C30 File Offset: 0x0034EE30
		public static void CopyValues__AssetList_SerializedSubProgram_2021_1_1__AccessListBase_ISerializedSubProgram(AssetList<SerializedSubProgram_2021_1_1> target, AccessListBase<ISerializedSubProgram> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C24 RID: 93220 RVA: 0x00350C78 File Offset: 0x0034EE78
		public static void CopyValues__AssetList_SerializedSubProgram_2021_2_0_a16__AccessListBase_ISerializedSubProgram(AssetList<SerializedSubProgram_2021_2_0_a16> target, AccessListBase<ISerializedSubProgram> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C25 RID: 93221 RVA: 0x00350CC0 File Offset: 0x0034EEC0
		public static void CopyValues__AssetList_AssetList_SerializedPlayerSubProgram_2021_3_10__AssetList_AssetList_SerializedPlayerSubProgram_2021_3_10(AssetList<AssetList<SerializedPlayerSubProgram_2021_3_10>> target, AssetList<AssetList<SerializedPlayerSubProgram_2021_3_10>> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					CopyValuesHelper.CopyValues__AssetList_SerializedPlayerSubProgram_2021_3_10__AssetList_SerializedPlayerSubProgram_2021_3_10(target.AddNew(), source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C26 RID: 93222 RVA: 0x00350D08 File Offset: 0x0034EF08
		public static void CopyValues__AssetList_SerializedPlayerSubProgram_2021_3_10__AssetList_SerializedPlayerSubProgram_2021_3_10(AssetList<SerializedPlayerSubProgram_2021_3_10> target, AssetList<SerializedPlayerSubProgram_2021_3_10> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C27 RID: 93223 RVA: 0x00350D50 File Offset: 0x0034EF50
		public static void CopyValues__AssetList_AssetList_SerializedPlayerSubProgram_2022_1_13__AssetList_AssetList_SerializedPlayerSubProgram_2022_1_13(AssetList<AssetList<SerializedPlayerSubProgram_2022_1_13>> target, AssetList<AssetList<SerializedPlayerSubProgram_2022_1_13>> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					CopyValuesHelper.CopyValues__AssetList_SerializedPlayerSubProgram_2022_1_13__AssetList_SerializedPlayerSubProgram_2022_1_13(target.AddNew(), source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C28 RID: 93224 RVA: 0x00350D98 File Offset: 0x0034EF98
		public static void CopyValues__AssetList_SerializedPlayerSubProgram_2022_1_13__AssetList_SerializedPlayerSubProgram_2022_1_13(AssetList<SerializedPlayerSubProgram_2022_1_13> target, AssetList<SerializedPlayerSubProgram_2022_1_13> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C29 RID: 93225 RVA: 0x00350DE0 File Offset: 0x0034EFE0
		public static void CopyValues__AssetList_AssetList_SerializedPlayerSubProgram_2022_2_0_b5__AssetList_AssetList_SerializedPlayerSubProgram_2022_2_0_b5(AssetList<AssetList<SerializedPlayerSubProgram_2022_2_0_b5>> target, AssetList<AssetList<SerializedPlayerSubProgram_2022_2_0_b5>> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					CopyValuesHelper.CopyValues__AssetList_SerializedPlayerSubProgram_2022_2_0_b5__AssetList_SerializedPlayerSubProgram_2022_2_0_b5(target.AddNew(), source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C2A RID: 93226 RVA: 0x00350E28 File Offset: 0x0034F028
		public static void CopyValues__AssetList_SerializedPlayerSubProgram_2022_2_0_b5__AssetList_SerializedPlayerSubProgram_2022_2_0_b5(AssetList<SerializedPlayerSubProgram_2022_2_0_b5> target, AssetList<SerializedPlayerSubProgram_2022_2_0_b5> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C2B RID: 93227 RVA: 0x00350E70 File Offset: 0x0034F070
		public static void CopyValues__AssetList_Hash128__AssetList_Hash128(AssetList<Hash128> target, AssetList<Hash128> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C2C RID: 93228 RVA: 0x00350EB8 File Offset: 0x0034F0B8
		public static void CopyValues__AssetList_SerializedPackageRequirement_2020_3_16__AccessListBase_ISerializedPackageRequirement(AssetList<SerializedPackageRequirement_2020_3_16> target, AccessListBase<ISerializedPackageRequirement> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C2D RID: 93229 RVA: 0x00350F00 File Offset: 0x0034F100
		public static void CopyValues__AssetList_SerializedPackageRequirement_2021_1_17__AccessListBase_ISerializedPackageRequirement(AssetList<SerializedPackageRequirement_2021_1_17> target, AccessListBase<ISerializedPackageRequirement> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C2E RID: 93230 RVA: 0x00350F48 File Offset: 0x0034F148
		public static void CopyValues__AssetList_SerializedPackageRequirement_2021_2_0_a17__AccessListBase_ISerializedPackageRequirement(AssetList<SerializedPackageRequirement_2021_2_0_a17> target, AccessListBase<ISerializedPackageRequirement> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C2F RID: 93231 RVA: 0x00350F90 File Offset: 0x0034F190
		public static void CopyValues__AssetList_SerializedPass_5_6_0__AccessListBase_ISerializedPass(AssetList<SerializedPass_5_6_0> target, AccessListBase<ISerializedPass> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C30 RID: 93232 RVA: 0x00350FD8 File Offset: 0x0034F1D8
		public static void CopyValues__AssetList_SerializedPass_2017_1_0__AccessListBase_ISerializedPass(AssetList<SerializedPass_2017_1_0> target, AccessListBase<ISerializedPass> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C31 RID: 93233 RVA: 0x00351020 File Offset: 0x0034F220
		public static void CopyValues__AssetList_SerializedPass_2017_2_0__AccessListBase_ISerializedPass(AssetList<SerializedPass_2017_2_0> target, AccessListBase<ISerializedPass> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C32 RID: 93234 RVA: 0x00351068 File Offset: 0x0034F268
		public static void CopyValues__AssetList_SerializedPass_2017_3_0__AccessListBase_ISerializedPass(AssetList<SerializedPass_2017_3_0> target, AccessListBase<ISerializedPass> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C33 RID: 93235 RVA: 0x003510B0 File Offset: 0x0034F2B0
		public static void CopyValues__AssetList_SerializedPass_2018_1_0__AccessListBase_ISerializedPass(AssetList<SerializedPass_2018_1_0> target, AccessListBase<ISerializedPass> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C34 RID: 93236 RVA: 0x003510F8 File Offset: 0x0034F2F8
		public static void CopyValues__AssetList_SerializedPass_2019_1_0__AccessListBase_ISerializedPass(AssetList<SerializedPass_2019_1_0> target, AccessListBase<ISerializedPass> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C35 RID: 93237 RVA: 0x00351140 File Offset: 0x0034F340
		public static void CopyValues__AssetList_SerializedPass_2019_3_0_a7__AccessListBase_ISerializedPass(AssetList<SerializedPass_2019_3_0_a7> target, AccessListBase<ISerializedPass> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C36 RID: 93238 RVA: 0x00351188 File Offset: 0x0034F388
		public static void CopyValues__AssetList_SerializedPass_2020_1_0_a17__AccessListBase_ISerializedPass(AssetList<SerializedPass_2020_1_0_a17> target, AccessListBase<ISerializedPass> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C37 RID: 93239 RVA: 0x003511D0 File Offset: 0x0034F3D0
		public static void CopyValues__AssetList_SerializedPass_2020_2_0_a15__AccessListBase_ISerializedPass(AssetList<SerializedPass_2020_2_0_a15> target, AccessListBase<ISerializedPass> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C38 RID: 93240 RVA: 0x00351218 File Offset: 0x0034F418
		public static void CopyValues__AssetList_SerializedPass_2020_3_2__AccessListBase_ISerializedPass(AssetList<SerializedPass_2020_3_2> target, AccessListBase<ISerializedPass> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C39 RID: 93241 RVA: 0x00351260 File Offset: 0x0034F460
		public static void CopyValues__AssetList_SerializedPass_2020_3_16__AccessListBase_ISerializedPass(AssetList<SerializedPass_2020_3_16> target, AccessListBase<ISerializedPass> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C3A RID: 93242 RVA: 0x003512A8 File Offset: 0x0034F4A8
		public static void CopyValues__AssetList_SerializedPass_2021_1_0__AccessListBase_ISerializedPass(AssetList<SerializedPass_2021_1_0> target, AccessListBase<ISerializedPass> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C3B RID: 93243 RVA: 0x003512F0 File Offset: 0x0034F4F0
		public static void CopyValues__AssetList_SerializedPass_2021_1_1__AccessListBase_ISerializedPass(AssetList<SerializedPass_2021_1_1> target, AccessListBase<ISerializedPass> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C3C RID: 93244 RVA: 0x00351338 File Offset: 0x0034F538
		public static void CopyValues__AssetList_SerializedPass_2021_1_17__AccessListBase_ISerializedPass(AssetList<SerializedPass_2021_1_17> target, AccessListBase<ISerializedPass> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C3D RID: 93245 RVA: 0x00351380 File Offset: 0x0034F580
		public static void CopyValues__AssetList_SerializedPass_2021_2_0__AccessListBase_ISerializedPass(AssetList<SerializedPass_2021_2_0> target, AccessListBase<ISerializedPass> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C3E RID: 93246 RVA: 0x003513C8 File Offset: 0x0034F5C8
		public static void CopyValues__AssetList_SerializedPass_2021_2_0_a16__AccessListBase_ISerializedPass(AssetList<SerializedPass_2021_2_0_a16> target, AccessListBase<ISerializedPass> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C3F RID: 93247 RVA: 0x00351410 File Offset: 0x0034F610
		public static void CopyValues__AssetList_SerializedPass_2021_2_0_a17__AccessListBase_ISerializedPass(AssetList<SerializedPass_2021_2_0_a17> target, AccessListBase<ISerializedPass> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C40 RID: 93248 RVA: 0x00351458 File Offset: 0x0034F658
		public static void CopyValues__AssetList_SerializedPass_2021_3_10__AccessListBase_ISerializedPass(AssetList<SerializedPass_2021_3_10> target, AccessListBase<ISerializedPass> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C41 RID: 93249 RVA: 0x003514A0 File Offset: 0x0034F6A0
		public static void CopyValues__AssetList_SerializedPass_2022_1_0__AccessListBase_ISerializedPass(AssetList<SerializedPass_2022_1_0> target, AccessListBase<ISerializedPass> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C42 RID: 93250 RVA: 0x003514E8 File Offset: 0x0034F6E8
		public static void CopyValues__AssetList_SerializedPass_2022_1_0_b3__AccessListBase_ISerializedPass(AssetList<SerializedPass_2022_1_0_b3> target, AccessListBase<ISerializedPass> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C43 RID: 93251 RVA: 0x00351530 File Offset: 0x0034F730
		public static void CopyValues__AssetList_SerializedPass_2022_1_13__AccessListBase_ISerializedPass(AssetList<SerializedPass_2022_1_13> target, AccessListBase<ISerializedPass> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C44 RID: 93252 RVA: 0x00351578 File Offset: 0x0034F778
		public static void CopyValues__AssetList_SerializedPass_2022_2_0__AccessListBase_ISerializedPass(AssetList<SerializedPass_2022_2_0> target, AccessListBase<ISerializedPass> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C45 RID: 93253 RVA: 0x003515C0 File Offset: 0x0034F7C0
		public static void CopyValues__AssetList_SerializedPass_2022_2_0_b5__AccessListBase_ISerializedPass(AssetList<SerializedPass_2022_2_0_b5> target, AccessListBase<ISerializedPass> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C46 RID: 93254 RVA: 0x00351608 File Offset: 0x0034F808
		public static void CopyValues__AssetList_SerializedSubShader_5_6_0__AccessListBase_ISerializedSubShader(AssetList<SerializedSubShader_5_6_0> target, AccessListBase<ISerializedSubShader> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C47 RID: 93255 RVA: 0x00351650 File Offset: 0x0034F850
		public static void CopyValues__AssetList_SerializedSubShader_2017_1_0__AccessListBase_ISerializedSubShader(AssetList<SerializedSubShader_2017_1_0> target, AccessListBase<ISerializedSubShader> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C48 RID: 93256 RVA: 0x00351698 File Offset: 0x0034F898
		public static void CopyValues__AssetList_SerializedSubShader_2017_2_0__AccessListBase_ISerializedSubShader(AssetList<SerializedSubShader_2017_2_0> target, AccessListBase<ISerializedSubShader> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C49 RID: 93257 RVA: 0x003516E0 File Offset: 0x0034F8E0
		public static void CopyValues__AssetList_SerializedSubShader_2017_3_0__AccessListBase_ISerializedSubShader(AssetList<SerializedSubShader_2017_3_0> target, AccessListBase<ISerializedSubShader> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C4A RID: 93258 RVA: 0x00351728 File Offset: 0x0034F928
		public static void CopyValues__AssetList_SerializedSubShader_2018_1_0__AccessListBase_ISerializedSubShader(AssetList<SerializedSubShader_2018_1_0> target, AccessListBase<ISerializedSubShader> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C4B RID: 93259 RVA: 0x00351770 File Offset: 0x0034F970
		public static void CopyValues__AssetList_SerializedSubShader_2019_1_0__AccessListBase_ISerializedSubShader(AssetList<SerializedSubShader_2019_1_0> target, AccessListBase<ISerializedSubShader> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C4C RID: 93260 RVA: 0x003517B8 File Offset: 0x0034F9B8
		public static void CopyValues__AssetList_SerializedSubShader_2019_3_0_a7__AccessListBase_ISerializedSubShader(AssetList<SerializedSubShader_2019_3_0_a7> target, AccessListBase<ISerializedSubShader> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C4D RID: 93261 RVA: 0x00351800 File Offset: 0x0034FA00
		public static void CopyValues__AssetList_SerializedSubShader_2020_1_0_a17__AccessListBase_ISerializedSubShader(AssetList<SerializedSubShader_2020_1_0_a17> target, AccessListBase<ISerializedSubShader> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C4E RID: 93262 RVA: 0x00351848 File Offset: 0x0034FA48
		public static void CopyValues__AssetList_SerializedSubShader_2020_2_0_a15__AccessListBase_ISerializedSubShader(AssetList<SerializedSubShader_2020_2_0_a15> target, AccessListBase<ISerializedSubShader> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C4F RID: 93263 RVA: 0x00351890 File Offset: 0x0034FA90
		public static void CopyValues__AssetList_SerializedSubShader_2020_3_2__AccessListBase_ISerializedSubShader(AssetList<SerializedSubShader_2020_3_2> target, AccessListBase<ISerializedSubShader> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C50 RID: 93264 RVA: 0x003518D8 File Offset: 0x0034FAD8
		public static void CopyValues__AssetList_SerializedSubShader_2020_3_16__AccessListBase_ISerializedSubShader(AssetList<SerializedSubShader_2020_3_16> target, AccessListBase<ISerializedSubShader> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C51 RID: 93265 RVA: 0x00351920 File Offset: 0x0034FB20
		public static void CopyValues__AssetList_SerializedSubShader_2021_1_0__AccessListBase_ISerializedSubShader(AssetList<SerializedSubShader_2021_1_0> target, AccessListBase<ISerializedSubShader> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C52 RID: 93266 RVA: 0x00351968 File Offset: 0x0034FB68
		public static void CopyValues__AssetList_SerializedCustomEditorForRenderPipeline__AssetList_SerializedCustomEditorForRenderPipeline(AssetList<SerializedCustomEditorForRenderPipeline> target, AssetList<SerializedCustomEditorForRenderPipeline> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C53 RID: 93267 RVA: 0x003519B0 File Offset: 0x0034FBB0
		public static void CopyValues__AssetList_SerializedSubShader_2021_1_1__AccessListBase_ISerializedSubShader(AssetList<SerializedSubShader_2021_1_1> target, AccessListBase<ISerializedSubShader> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C54 RID: 93268 RVA: 0x003519F8 File Offset: 0x0034FBF8
		public static void CopyValues__AssetList_SerializedSubShader_2021_1_17__AccessListBase_ISerializedSubShader(AssetList<SerializedSubShader_2021_1_17> target, AccessListBase<ISerializedSubShader> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C55 RID: 93269 RVA: 0x00351A40 File Offset: 0x0034FC40
		public static void CopyValues__AssetList_SerializedSubShader_2021_2_0__AccessListBase_ISerializedSubShader(AssetList<SerializedSubShader_2021_2_0> target, AccessListBase<ISerializedSubShader> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C56 RID: 93270 RVA: 0x00351A88 File Offset: 0x0034FC88
		public static void CopyValues__AssetList_SerializedSubShader_2021_2_0_a16__AccessListBase_ISerializedSubShader(AssetList<SerializedSubShader_2021_2_0_a16> target, AccessListBase<ISerializedSubShader> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C57 RID: 93271 RVA: 0x00351AD0 File Offset: 0x0034FCD0
		public static void CopyValues__AssetList_SerializedSubShader_2021_2_0_a17__AccessListBase_ISerializedSubShader(AssetList<SerializedSubShader_2021_2_0_a17> target, AccessListBase<ISerializedSubShader> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C58 RID: 93272 RVA: 0x00351B18 File Offset: 0x0034FD18
		public static void CopyValues__AssetList_SerializedSubShader_2021_3_10__AccessListBase_ISerializedSubShader(AssetList<SerializedSubShader_2021_3_10> target, AccessListBase<ISerializedSubShader> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C59 RID: 93273 RVA: 0x00351B60 File Offset: 0x0034FD60
		public static void CopyValues__AssetList_SerializedSubShader_2022_1_0__AccessListBase_ISerializedSubShader(AssetList<SerializedSubShader_2022_1_0> target, AccessListBase<ISerializedSubShader> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C5A RID: 93274 RVA: 0x00351BA8 File Offset: 0x0034FDA8
		public static void CopyValues__AssetList_SerializedSubShader_2022_1_0_b3__AccessListBase_ISerializedSubShader(AssetList<SerializedSubShader_2022_1_0_b3> target, AccessListBase<ISerializedSubShader> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C5B RID: 93275 RVA: 0x00351BF0 File Offset: 0x0034FDF0
		public static void CopyValues__AssetList_SerializedSubShader_2022_1_13__AccessListBase_ISerializedSubShader(AssetList<SerializedSubShader_2022_1_13> target, AccessListBase<ISerializedSubShader> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C5C RID: 93276 RVA: 0x00351C38 File Offset: 0x0034FE38
		public static void CopyValues__AssetList_SerializedSubShader_2022_2_0__AccessListBase_ISerializedSubShader(AssetList<SerializedSubShader_2022_2_0> target, AccessListBase<ISerializedSubShader> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C5D RID: 93277 RVA: 0x00351C80 File Offset: 0x0034FE80
		public static void CopyValues__AssetList_SerializedSubShader_2022_2_0_b5__AccessListBase_ISerializedSubShader(AssetList<SerializedSubShader_2022_2_0_b5> target, AccessListBase<ISerializedSubShader> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C5E RID: 93278 RVA: 0x00351CC8 File Offset: 0x0034FEC8
		public static void CopyValues__AssetDictionary_Utf8String_PPtr_Texture_5_0_0__AssetDictionary_Utf8String_PPtr_Texture_5_0_0(AssetDictionary<Utf8String, PPtr_Texture_5_0_0> target, AssetDictionary<Utf8String, PPtr_Texture_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_PPtr_Texture_5_0_0__AccessPairBase_Utf8String_PPtr_Texture_5_0_0(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C5F RID: 93279 RVA: 0x00351D16 File Offset: 0x0034FF16
		public static void CopyValues__AccessPairBase_Utf8String_PPtr_Texture_5_0_0__AccessPairBase_Utf8String_PPtr_Texture_5_0_0(AccessPairBase<Utf8String, PPtr_Texture_5_0_0> target, AccessPairBase<Utf8String, PPtr_Texture_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016C60 RID: 93280 RVA: 0x00351D40 File Offset: 0x0034FF40
		public static void CopyValues__AssetList_ShaderError_5_5_0__AccessListBase_IShaderError(AssetList<ShaderError_5_5_0> target, AccessListBase<IShaderError> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C61 RID: 93281 RVA: 0x00351D88 File Offset: 0x0034FF88
		public static void CopyValues__AssetList_CompressedAnimationCurve__AssetList_CompressedAnimationCurve(AssetList<CompressedAnimationCurve> target, AssetList<CompressedAnimationCurve> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C62 RID: 93282 RVA: 0x00351DD0 File Offset: 0x0034FFD0
		public static void CopyValues__AssetList_FloatCurve_3_4_0__AccessListBase_IFloatCurve(AssetList<FloatCurve_3_4_0> target, AccessListBase<IFloatCurve> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C63 RID: 93283 RVA: 0x00351E18 File Offset: 0x00350018
		public static void CopyValues__AssetList_Keyframe_Single_3_4_0__AccessListBase_IKeyframe_Single(AssetList<Keyframe_Single_3_4_0> target, AccessListBase<IKeyframe_Single> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C64 RID: 93284 RVA: 0x00351E60 File Offset: 0x00350060
		public static void CopyValues__AssetList_Keyframe_Single_5_5_0__AccessListBase_IKeyframe_Single(AssetList<Keyframe_Single_5_5_0> target, AccessListBase<IKeyframe_Single> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C65 RID: 93285 RVA: 0x00351EA8 File Offset: 0x003500A8
		public static void CopyValues__AssetList_Keyframe_Single_2018_1_0__AccessListBase_IKeyframe_Single(AssetList<Keyframe_Single_2018_1_0> target, AccessListBase<IKeyframe_Single> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C66 RID: 93286 RVA: 0x00351EF0 File Offset: 0x003500F0
		public static void CopyValues__AssetList_AnimationEvent_3_4_0__AccessListBase_IAnimationEvent(AssetList<AnimationEvent_3_4_0> target, AccessListBase<IAnimationEvent> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C67 RID: 93287 RVA: 0x00351F38 File Offset: 0x00350138
		public static void CopyValues__AssetList_Vector3Curve_3_4_0__AccessListBase_IVector3Curve(AssetList<Vector3Curve_3_4_0> target, AccessListBase<IVector3Curve> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C68 RID: 93288 RVA: 0x00351F80 File Offset: 0x00350180
		public static void CopyValues__AssetList_Keyframe_Vector3f_3_4_0__AccessListBase_IKeyframe_Vector3f(AssetList<Keyframe_Vector3f_3_4_0> target, AccessListBase<IKeyframe_Vector3f> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C69 RID: 93289 RVA: 0x00351FC8 File Offset: 0x003501C8
		public static void CopyValues__AssetList_Keyframe_Vector3f_3_5_0__AccessListBase_IKeyframe_Vector3f(AssetList<Keyframe_Vector3f_3_5_0> target, AccessListBase<IKeyframe_Vector3f> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C6A RID: 93290 RVA: 0x00352010 File Offset: 0x00350210
		public static void CopyValues__AssetList_Keyframe_Vector3f_5_5_0__AccessListBase_IKeyframe_Vector3f(AssetList<Keyframe_Vector3f_5_5_0> target, AccessListBase<IKeyframe_Vector3f> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C6B RID: 93291 RVA: 0x00352058 File Offset: 0x00350258
		public static void CopyValues__AssetList_Keyframe_Vector3f_2018_1_0__AccessListBase_IKeyframe_Vector3f(AssetList<Keyframe_Vector3f_2018_1_0> target, AccessListBase<IKeyframe_Vector3f> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C6C RID: 93292 RVA: 0x003520A0 File Offset: 0x003502A0
		public static void CopyValues__AssetList_QuaternionCurve_3_4_0__AccessListBase_IQuaternionCurve(AssetList<QuaternionCurve_3_4_0> target, AccessListBase<IQuaternionCurve> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C6D RID: 93293 RVA: 0x003520E8 File Offset: 0x003502E8
		public static void CopyValues__AssetList_Keyframe_Quaternionf_3_4_0__AccessListBase_IKeyframe_Quaternionf(AssetList<Keyframe_Quaternionf_3_4_0> target, AccessListBase<IKeyframe_Quaternionf> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C6E RID: 93294 RVA: 0x00352130 File Offset: 0x00350330
		public static void CopyValues__AssetList_Keyframe_Quaternionf_3_5_0__AccessListBase_IKeyframe_Quaternionf(AssetList<Keyframe_Quaternionf_3_5_0> target, AccessListBase<IKeyframe_Quaternionf> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C6F RID: 93295 RVA: 0x00352178 File Offset: 0x00350378
		public static void CopyValues__AssetList_Keyframe_Quaternionf_5_5_0__AccessListBase_IKeyframe_Quaternionf(AssetList<Keyframe_Quaternionf_5_5_0> target, AccessListBase<IKeyframe_Quaternionf> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C70 RID: 93296 RVA: 0x003521C0 File Offset: 0x003503C0
		public static void CopyValues__AssetList_Keyframe_Quaternionf_2018_1_0__AccessListBase_IKeyframe_Quaternionf(AssetList<Keyframe_Quaternionf_2018_1_0> target, AccessListBase<IKeyframe_Quaternionf> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C71 RID: 93297 RVA: 0x00352208 File Offset: 0x00350408
		public static void CopyValues__AssetList_Vector3Curve_3_5_0__AccessListBase_IVector3Curve(AssetList<Vector3Curve_3_5_0> target, AccessListBase<IVector3Curve> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C72 RID: 93298 RVA: 0x00352250 File Offset: 0x00350450
		public static void CopyValues__AssetList_QuaternionCurve_3_5_0__AccessListBase_IQuaternionCurve(AssetList<QuaternionCurve_3_5_0> target, AccessListBase<IQuaternionCurve> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C73 RID: 93299 RVA: 0x00352298 File Offset: 0x00350498
		public static void CopyValues__AssetList_ValueConstant_4_0_0__AccessListBase_IValueConstant(AssetList<ValueConstant_4_0_0> target, AccessListBase<IValueConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C74 RID: 93300 RVA: 0x003522E0 File Offset: 0x003504E0
		public static void CopyValues__AssetList_ValueConstant_5_5_0__AccessListBase_IValueConstant(AssetList<ValueConstant_5_5_0> target, AccessListBase<IValueConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C75 RID: 93301 RVA: 0x00352328 File Offset: 0x00350528
		public static void CopyValues__AssetList_HumanGoal_4_0_0__AccessListBase_IHumanGoal(AssetList<HumanGoal_4_0_0> target, AccessListBase<IHumanGoal> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C76 RID: 93302 RVA: 0x00352370 File Offset: 0x00350570
		public static void CopyValues__AssetList_HumanGoal_5_0_0__AccessListBase_IHumanGoal(AssetList<HumanGoal_5_0_0> target, AccessListBase<IHumanGoal> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C77 RID: 93303 RVA: 0x003523B8 File Offset: 0x003505B8
		public static void CopyValues__AssetList_Vector4Float_4_0_0__AssetList_Vector4Float_4_0_0(AssetList<Vector4Float_4_0_0> target, AssetList<Vector4Float_4_0_0> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C78 RID: 93304 RVA: 0x00352400 File Offset: 0x00350600
		public static void CopyValues__AssetList_HumanGoal_5_4_0__AccessListBase_IHumanGoal(AssetList<HumanGoal_5_4_0> target, AccessListBase<IHumanGoal> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C79 RID: 93305 RVA: 0x00352448 File Offset: 0x00350648
		public static void CopyValues__AssetList_Vector3Float_5_4_0__AssetList_Vector3Float_5_4_0(AssetList<Vector3Float_5_4_0> target, AssetList<Vector3Float_5_4_0> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C7A RID: 93306 RVA: 0x00352490 File Offset: 0x00350690
		public static void CopyValues__AssetList_HumanGoal_5_5_0__AccessListBase_IHumanGoal(AssetList<HumanGoal_5_5_0> target, AccessListBase<IHumanGoal> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C7B RID: 93307 RVA: 0x003524D8 File Offset: 0x003506D8
		public static void CopyValues__AssetList_Vector3Float_5_5_0__AssetList_Vector3Float_5_5_0(AssetList<Vector3Float_5_5_0> target, AssetList<Vector3Float_5_5_0> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C7C RID: 93308 RVA: 0x00352520 File Offset: 0x00350720
		public static void CopyValues__AssetList_ValueDelta__AssetList_ValueDelta(AssetList<ValueDelta> target, AssetList<ValueDelta> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C7D RID: 93309 RVA: 0x00352568 File Offset: 0x00350768
		public static void CopyValues__AssetList_GenericBinding_4_3_0__AccessListBase_IGenericBinding(AssetList<GenericBinding_4_3_0> target, AccessListBase<IGenericBinding> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C7E RID: 93310 RVA: 0x003525B0 File Offset: 0x003507B0
		public static void CopyValues__AssetList_PPtr_Object_3_4_0__AccessListBase_IPPtr_Object(AssetList<PPtr_Object_3_4_0> target, AccessListBase<IPPtr_Object> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C7F RID: 93311 RVA: 0x003525F8 File Offset: 0x003507F8
		public static void CopyValues__AssetList_GenericBinding_4_5_0__AccessListBase_IGenericBinding(AssetList<GenericBinding_4_5_0> target, AccessListBase<IGenericBinding> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C80 RID: 93312 RVA: 0x00352640 File Offset: 0x00350840
		public static void CopyValues__AssetList_GenericBinding_5_0_0__AccessListBase_IGenericBinding(AssetList<GenericBinding_5_0_0> target, AccessListBase<IGenericBinding> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C81 RID: 93313 RVA: 0x00352688 File Offset: 0x00350888
		public static void CopyValues__AssetList_PPtr_Object_5_0_0__AccessListBase_IPPtr_Object(AssetList<PPtr_Object_5_0_0> target, AccessListBase<IPPtr_Object> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C82 RID: 93314 RVA: 0x003526D0 File Offset: 0x003508D0
		public static void CopyValues__AssetList_GenericBinding_5_6_0__AccessListBase_IGenericBinding(AssetList<GenericBinding_5_6_0> target, AccessListBase<IGenericBinding> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C83 RID: 93315 RVA: 0x00352718 File Offset: 0x00350918
		public static void CopyValues__AssetList_GenericBinding_2022_1_0_a12__AccessListBase_IGenericBinding(AssetList<GenericBinding_2022_1_0_a12> target, AccessListBase<IGenericBinding> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C84 RID: 93316 RVA: 0x00352760 File Offset: 0x00350960
		public static void CopyValues__AssetList_GenericBinding_2022_2_0__AccessListBase_IGenericBinding(AssetList<GenericBinding_2022_2_0> target, AccessListBase<IGenericBinding> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C85 RID: 93317 RVA: 0x003527A8 File Offset: 0x003509A8
		public static void CopyValues__AssetList_PPtrCurve_4_3_0__AccessListBase_IPPtrCurve(AssetList<PPtrCurve_4_3_0> target, AccessListBase<IPPtrCurve> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C86 RID: 93318 RVA: 0x003527F0 File Offset: 0x003509F0
		public static void CopyValues__AssetList_PPtrKeyframe_4_3_0__AccessListBase_IPPtrKeyframe(AssetList<PPtrKeyframe_4_3_0> target, AccessListBase<IPPtrKeyframe> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C87 RID: 93319 RVA: 0x00352838 File Offset: 0x00350A38
		public static void CopyValues__AssetList_PPtrKeyframe_5_0_0__AccessListBase_IPPtrKeyframe(AssetList<PPtrKeyframe_5_0_0> target, AccessListBase<IPPtrKeyframe> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C88 RID: 93320 RVA: 0x00352880 File Offset: 0x00350A80
		public static void CopyValues__AssetList_FloatCurve_5_0_0__AccessListBase_IFloatCurve(AssetList<FloatCurve_5_0_0> target, AccessListBase<IFloatCurve> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C89 RID: 93321 RVA: 0x003528C8 File Offset: 0x00350AC8
		public static void CopyValues__AssetList_AnimationEvent_5_0_0__AccessListBase_IAnimationEvent(AssetList<AnimationEvent_5_0_0> target, AccessListBase<IAnimationEvent> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C8A RID: 93322 RVA: 0x00352910 File Offset: 0x00350B10
		public static void CopyValues__AssetList_PPtrCurve_5_0_0__AccessListBase_IPPtrCurve(AssetList<PPtrCurve_5_0_0> target, AccessListBase<IPPtrCurve> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C8B RID: 93323 RVA: 0x00352958 File Offset: 0x00350B58
		public static void CopyValues__AssetList_FloatCurve_5_3_0__AccessListBase_IFloatCurve(AssetList<FloatCurve_5_3_0> target, AccessListBase<IFloatCurve> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C8C RID: 93324 RVA: 0x003529A0 File Offset: 0x00350BA0
		public static void CopyValues__AssetList_Vector3Curve_5_3_0__AccessListBase_IVector3Curve(AssetList<Vector3Curve_5_3_0> target, AccessListBase<IVector3Curve> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C8D RID: 93325 RVA: 0x003529E8 File Offset: 0x00350BE8
		public static void CopyValues__AssetList_QuaternionCurve_5_3_0__AccessListBase_IQuaternionCurve(AssetList<QuaternionCurve_5_3_0> target, AccessListBase<IQuaternionCurve> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C8E RID: 93326 RVA: 0x00352A30 File Offset: 0x00350C30
		public static void CopyValues__AssetList_FloatCurve_5_5_0__AccessListBase_IFloatCurve(AssetList<FloatCurve_5_5_0> target, AccessListBase<IFloatCurve> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C8F RID: 93327 RVA: 0x00352A78 File Offset: 0x00350C78
		public static void CopyValues__AssetList_Vector3Curve_5_5_0__AccessListBase_IVector3Curve(AssetList<Vector3Curve_5_5_0> target, AccessListBase<IVector3Curve> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C90 RID: 93328 RVA: 0x00352AC0 File Offset: 0x00350CC0
		public static void CopyValues__AssetList_QuaternionCurve_5_5_0__AccessListBase_IQuaternionCurve(AssetList<QuaternionCurve_5_5_0> target, AccessListBase<IQuaternionCurve> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C91 RID: 93329 RVA: 0x00352B08 File Offset: 0x00350D08
		public static void CopyValues__AssetList_FloatCurve_5_6_0__AccessListBase_IFloatCurve(AssetList<FloatCurve_5_6_0> target, AccessListBase<IFloatCurve> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C92 RID: 93330 RVA: 0x00352B50 File Offset: 0x00350D50
		public static void CopyValues__AssetList_PPtrCurve_5_6_0__AccessListBase_IPPtrCurve(AssetList<PPtrCurve_5_6_0> target, AccessListBase<IPPtrCurve> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C93 RID: 93331 RVA: 0x00352B98 File Offset: 0x00350D98
		public static void CopyValues__AssetList_FloatCurve_2017_1_0__AccessListBase_IFloatCurve(AssetList<FloatCurve_2017_1_0> target, AccessListBase<IFloatCurve> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C94 RID: 93332 RVA: 0x00352BE0 File Offset: 0x00350DE0
		public static void CopyValues__AssetList_Vector3Curve_2017_1_0__AccessListBase_IVector3Curve(AssetList<Vector3Curve_2017_1_0> target, AccessListBase<IVector3Curve> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C95 RID: 93333 RVA: 0x00352C28 File Offset: 0x00350E28
		public static void CopyValues__AssetList_PPtrCurve_2017_1_0__AccessListBase_IPPtrCurve(AssetList<PPtrCurve_2017_1_0> target, AccessListBase<IPPtrCurve> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C96 RID: 93334 RVA: 0x00352C70 File Offset: 0x00350E70
		public static void CopyValues__AssetList_QuaternionCurve_2017_1_0__AccessListBase_IQuaternionCurve(AssetList<QuaternionCurve_2017_1_0> target, AccessListBase<IQuaternionCurve> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C97 RID: 93335 RVA: 0x00352CB8 File Offset: 0x00350EB8
		public static void CopyValues__AssetList_FloatCurve_2018_1_0__AccessListBase_IFloatCurve(AssetList<FloatCurve_2018_1_0> target, AccessListBase<IFloatCurve> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C98 RID: 93336 RVA: 0x00352D00 File Offset: 0x00350F00
		public static void CopyValues__AssetList_Vector3Curve_2018_1_0__AccessListBase_IVector3Curve(AssetList<Vector3Curve_2018_1_0> target, AccessListBase<IVector3Curve> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C99 RID: 93337 RVA: 0x00352D48 File Offset: 0x00350F48
		public static void CopyValues__AssetList_QuaternionCurve_2018_1_0__AccessListBase_IQuaternionCurve(AssetList<QuaternionCurve_2018_1_0> target, AccessListBase<IQuaternionCurve> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C9A RID: 93338 RVA: 0x00352D90 File Offset: 0x00350F90
		public static void CopyValues__AssetList_FloatCurve_2022_2_0__AccessListBase_IFloatCurve(AssetList<FloatCurve_2022_2_0> target, AccessListBase<IFloatCurve> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C9B RID: 93339 RVA: 0x00352DD8 File Offset: 0x00350FD8
		public static void CopyValues__AssetList_PPtrCurve_2022_2_0__AccessListBase_IPPtrCurve(AssetList<PPtrCurve_2022_2_0> target, AccessListBase<IPPtrCurve> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C9C RID: 93340 RVA: 0x00352E20 File Offset: 0x00351020
		public static void CopyValues__AssetList_SortingLayerEntry_4_3_0__AccessListBase_ISortingLayerEntry(AssetList<SortingLayerEntry_4_3_0> target, AccessListBase<ISortingLayerEntry> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C9D RID: 93341 RVA: 0x00352E68 File Offset: 0x00351068
		public static void CopyValues__AssetList_SortingLayerEntry_5_0_0__AccessListBase_ISortingLayerEntry(AssetList<SortingLayerEntry_5_0_0> target, AccessListBase<ISortingLayerEntry> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C9E RID: 93342 RVA: 0x00352EB0 File Offset: 0x003510B0
		public static void CopyValues__AssetList_ExtensionPropertyValue__AssetList_ExtensionPropertyValue(AssetList<ExtensionPropertyValue> target, AssetList<ExtensionPropertyValue> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016C9F RID: 93343 RVA: 0x00352EF8 File Offset: 0x003510F8
		public static void CopyValues__AssetList_PPtr_Texture2D_3_4_0__AccessListBase_IPPtr_Texture2D(AssetList<PPtr_Texture2D_3_4_0> target, AccessListBase<IPPtr_Texture2D> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CA0 RID: 93344 RVA: 0x00352F40 File Offset: 0x00351140
		public static void CopyValues__AssetList_PPtr_Texture2D_5_0_0__AccessListBase_IPPtr_Texture2D(AssetList<PPtr_Texture2D_5_0_0> target, AccessListBase<IPPtr_Texture2D> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CA1 RID: 93345 RVA: 0x00352F88 File Offset: 0x00351188
		public static void CopyValues__AssetDictionary_PPtr_TextAsset_Utf8String__AssetDictionary_PPtr_TextAsset_Utf8String(AssetDictionary<PPtr_TextAsset, Utf8String> target, AssetDictionary<PPtr_TextAsset, Utf8String> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_PPtr_TextAsset_Utf8String__AccessPairBase_PPtr_TextAsset_Utf8String(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CA2 RID: 93346 RVA: 0x00352FD6 File Offset: 0x003511D6
		public static void CopyValues__AccessPairBase_PPtr_TextAsset_Utf8String__AccessPairBase_PPtr_TextAsset_Utf8String(AccessPairBase<PPtr_TextAsset, Utf8String> target, AccessPairBase<PPtr_TextAsset, Utf8String> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key, converter);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016CA3 RID: 93347 RVA: 0x00353000 File Offset: 0x00351200
		public static void CopyValues__AssetDictionary_PPtr_Shader_3_4_0_Utf8String__AccessDictionaryBase_IPPtr_Shader_Utf8String(AssetDictionary<PPtr_Shader_3_4_0, Utf8String> target, AccessDictionaryBase<IPPtr_Shader, Utf8String> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_PPtr_Shader_3_4_0_Utf8String__AccessPairBase_IPPtr_Shader_Utf8String(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CA4 RID: 93348 RVA: 0x0035304E File Offset: 0x0035124E
		public static void CopyValues__AccessPairBase_PPtr_Shader_3_4_0_Utf8String__AccessPairBase_IPPtr_Shader_Utf8String(AccessPairBase<PPtr_Shader_3_4_0, Utf8String> target, AccessPairBase<IPPtr_Shader, Utf8String> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key, converter);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016CA5 RID: 93349 RVA: 0x00353078 File Offset: 0x00351278
		public static void CopyValues__AssetDictionary_PPtr_Shader_5_0_0_Utf8String__AccessDictionaryBase_IPPtr_Shader_Utf8String(AssetDictionary<PPtr_Shader_5_0_0, Utf8String> target, AccessDictionaryBase<IPPtr_Shader, Utf8String> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_PPtr_Shader_5_0_0_Utf8String__AccessPairBase_IPPtr_Shader_Utf8String(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CA6 RID: 93350 RVA: 0x003530C6 File Offset: 0x003512C6
		public static void CopyValues__AccessPairBase_PPtr_Shader_5_0_0_Utf8String__AccessPairBase_IPPtr_Shader_Utf8String(AccessPairBase<PPtr_Shader_5_0_0, Utf8String> target, AccessPairBase<IPPtr_Shader, Utf8String> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key, converter);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016CA7 RID: 93351 RVA: 0x003530F0 File Offset: 0x003512F0
		public static void CopyValues__AssetList_Channel_3_4_0__AccessListBase_IChannel(AssetList<Channel_3_4_0> target, AccessListBase<IChannel> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CA8 RID: 93352 RVA: 0x00353138 File Offset: 0x00351338
		public static void CopyValues__AssetList_Channel_5_3_0__AccessListBase_IChannel(AssetList<Channel_5_3_0> target, AccessListBase<IChannel> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CA9 RID: 93353 RVA: 0x00353180 File Offset: 0x00351380
		public static void CopyValues__AssetList_Channel_5_5_0__AccessListBase_IChannel(AssetList<Channel_5_5_0> target, AccessListBase<IChannel> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CAA RID: 93354 RVA: 0x003531C8 File Offset: 0x003513C8
		public static void CopyValues__AssetList_Channel_2017_1_0__AccessListBase_IChannel(AssetList<Channel_2017_1_0> target, AccessListBase<IChannel> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CAB RID: 93355 RVA: 0x00353210 File Offset: 0x00351410
		public static void CopyValues__AssetList_Channel_2018_1_0__AccessListBase_IChannel(AssetList<Channel_2018_1_0> target, AccessListBase<IChannel> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CAC RID: 93356 RVA: 0x00353258 File Offset: 0x00351458
		public static void CopyValues__AssetList_PPtr_AnimationClip_3_4_0__AccessListBase_IPPtr_AnimationClip(AssetList<PPtr_AnimationClip_3_4_0> target, AccessListBase<IPPtr_AnimationClip> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CAD RID: 93357 RVA: 0x003532A0 File Offset: 0x003514A0
		public static void CopyValues__AssetList_PPtr_AnimationClip_5_0_0__AccessListBase_IPPtr_AnimationClip(AssetList<PPtr_AnimationClip_5_0_0> target, AccessListBase<IPPtr_AnimationClip> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		public static void CopyValues__AssetList_PPtr_AnimationClip_5_0_0_GICB2__AccessListBase_IPPtr_AnimationClip(AssetList<PPtr_AnimationClip_5_0_0_GICB2> target, AccessListBase<IPPtr_AnimationClip_ACL> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CAE RID: 93358 RVA: 0x003532E8 File Offset: 0x003514E8
		public static void CopyValues__AssetDictionary_Utf8String_PPtr_Object_3_4_0__AccessDictionaryBase_Utf8String_IPPtr_Object(AssetDictionary<Utf8String, PPtr_Object_3_4_0> target, AccessDictionaryBase<Utf8String, IPPtr_Object> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_PPtr_Object_3_4_0__AccessPairBase_Utf8String_IPPtr_Object(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CAF RID: 93359 RVA: 0x00353336 File Offset: 0x00351536
		public static void CopyValues__AccessPairBase_Utf8String_PPtr_Object_3_4_0__AccessPairBase_Utf8String_IPPtr_Object(AccessPairBase<Utf8String, PPtr_Object_3_4_0> target, AccessPairBase<Utf8String, IPPtr_Object> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016CB0 RID: 93360 RVA: 0x00353360 File Offset: 0x00351560
		public static void CopyValues__AssetDictionary_Utf8String_PPtr_Object_5_0_0__AccessDictionaryBase_Utf8String_IPPtr_Object(AssetDictionary<Utf8String, PPtr_Object_5_0_0> target, AccessDictionaryBase<Utf8String, IPPtr_Object> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_PPtr_Object_5_0_0__AccessPairBase_Utf8String_IPPtr_Object(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CB1 RID: 93361 RVA: 0x003533AE File Offset: 0x003515AE
		public static void CopyValues__AccessPairBase_Utf8String_PPtr_Object_5_0_0__AccessPairBase_Utf8String_IPPtr_Object(AccessPairBase<Utf8String, PPtr_Object_5_0_0> target, AccessPairBase<Utf8String, IPPtr_Object> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016CB2 RID: 93362 RVA: 0x003533D8 File Offset: 0x003515D8
		public static void CopyValues__AssetList_PPtr_MonoScript_3_4_0__AccessListBase_IPPtr_MonoScript(AssetList<PPtr_MonoScript_3_4_0> target, AccessListBase<IPPtr_MonoScript> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CB3 RID: 93363 RVA: 0x00353420 File Offset: 0x00351620
		public static void CopyValues__AssetList_PPtr_MonoScript_5_0_0__AccessListBase_IPPtr_MonoScript(AssetList<PPtr_MonoScript_5_0_0> target, AccessListBase<IPPtr_MonoScript> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CB4 RID: 93364 RVA: 0x00353468 File Offset: 0x00351668
		public static void CopyValues__AssetDictionary_Int32_Hash128__AssetDictionary_Int32_Hash128(AssetDictionary<int, Hash128> target, AssetDictionary<int, Hash128> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Int32_Hash128__AccessPairBase_Int32_Hash128(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CB5 RID: 93365 RVA: 0x003534B5 File Offset: 0x003516B5
		public static void CopyValues__AccessPairBase_Int32_Hash128__AccessPairBase_Int32_Hash128(AccessPairBase<int, Hash128> target, AccessPairBase<int, Hash128> source)
		{
			if (source != null)
			{
				target.Key = source.Key;
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016CB6 RID: 93366 RVA: 0x003534D8 File Offset: 0x003516D8
		public static void CopyValues__AssetDictionary_Hash128_Hash128__AssetDictionary_Hash128_Hash128(AssetDictionary<Hash128, Hash128> target, AssetDictionary<Hash128, Hash128> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Hash128_Hash128__AccessPairBase_Hash128_Hash128(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CB7 RID: 93367 RVA: 0x00353525 File Offset: 0x00351725
		public static void CopyValues__AccessPairBase_Hash128_Hash128__AccessPairBase_Hash128_Hash128(AccessPairBase<Hash128, Hash128> target, AccessPairBase<Hash128, Hash128> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016CB8 RID: 93368 RVA: 0x0035354C File Offset: 0x0035174C
		public static void CopyValues__AssetList_Vector3f_3_4_0__AccessListBase_IVector3f(AssetList<Vector3f_3_4_0> target, AccessListBase<IVector3f> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CB9 RID: 93369 RVA: 0x00353594 File Offset: 0x00351794
		public static void CopyValues__AssetList_Vector3f_3_5_0__AccessListBase_IVector3f(AssetList<Vector3f_3_5_0> target, AccessListBase<IVector3f> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CBA RID: 93370 RVA: 0x003535DC File Offset: 0x003517DC
		public static void CopyValues__AssetList_FlareElement_3_4_0__AccessListBase_IFlareElement(AssetList<FlareElement_3_4_0> target, AccessListBase<IFlareElement> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CBB RID: 93371 RVA: 0x00353624 File Offset: 0x00351824
		public static void CopyValues__AssetList_FlareElement_3_5_0__AccessListBase_IFlareElement(AssetList<FlareElement_3_5_0> target, AccessListBase<IFlareElement> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CBC RID: 93372 RVA: 0x0035366C File Offset: 0x0035186C
		public static void CopyValues__AssetList_CharacterInfo_3_4_0__AccessListBase_ICharacterInfo(AssetList<CharacterInfo_3_4_0> target, AccessListBase<ICharacterInfo> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CBD RID: 93373 RVA: 0x003536B4 File Offset: 0x003518B4
		public static void CopyValues__AssetDictionary_AssetPair_UInt16_UInt16_Single__AssetDictionary_AssetPair_UInt16_UInt16_Single(AssetDictionary<AssetPair<ushort, ushort>, float> target, AssetDictionary<AssetPair<ushort, ushort>, float> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_AssetPair_UInt16_UInt16_Single__AccessPairBase_AssetPair_UInt16_UInt16_Single(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CBE RID: 93374 RVA: 0x00353701 File Offset: 0x00351901
		public static void CopyValues__AccessPairBase_AssetPair_UInt16_UInt16_Single__AccessPairBase_AssetPair_UInt16_UInt16_Single(AccessPairBase<AssetPair<ushort, ushort>, float> target, AccessPairBase<AssetPair<ushort, ushort>, float> source)
		{
			if (source != null)
			{
				CopyValuesHelper.CopyValues__AssetPair_UInt16_UInt16__AssetPair_UInt16_UInt16(target.Key, source.Key);
				target.Value = source.Value;
			}
		}

		// Token: 0x06016CBF RID: 93375 RVA: 0x00353723 File Offset: 0x00351923
		public static void CopyValues__AssetPair_UInt16_UInt16__AssetPair_UInt16_UInt16(AssetPair<ushort, ushort> target, AssetPair<ushort, ushort> source)
		{
			if (source != null)
			{
				target.Key = source.Key;
				target.Value = source.Value;
			}
		}

		// Token: 0x06016CC0 RID: 93376 RVA: 0x00353740 File Offset: 0x00351940
		public static void CopyValues__AssetList_AssetPair_Int32_Single__AssetList_AssetPair_Int32_Single(AssetList<AssetPair<int, float>> target, AssetList<AssetPair<int, float>> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					CopyValuesHelper.CopyValues__AssetPair_Int32_Single__AssetPair_Int32_Single(target.AddNew(), source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CC1 RID: 93377 RVA: 0x00353786 File Offset: 0x00351986
		public static void CopyValues__AssetPair_Int32_Single__AssetPair_Int32_Single(AssetPair<int, float> target, AssetPair<int, float> source)
		{
			if (source != null)
			{
				target.Key = source.Key;
				target.Value = source.Value;
			}
		}

		// Token: 0x06016CC2 RID: 93378 RVA: 0x003537A4 File Offset: 0x003519A4
		public static void CopyValues__AssetList_CharacterInfo_4_0_0__AccessListBase_ICharacterInfo(AssetList<CharacterInfo_4_0_0> target, AccessListBase<ICharacterInfo> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CC3 RID: 93379 RVA: 0x003537EC File Offset: 0x003519EC
		public static void CopyValues__AssetList_PPtr_Font_3_4_0__AccessListBase_IPPtr_Font(AssetList<PPtr_Font_3_4_0> target, AccessListBase<IPPtr_Font> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CC4 RID: 93380 RVA: 0x00353834 File Offset: 0x00351A34
		public static void CopyValues__AssetList_PPtr_Font_5_0_0__AccessListBase_IPPtr_Font(AssetList<PPtr_Font_5_0_0> target, AccessListBase<IPPtr_Font> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CC5 RID: 93381 RVA: 0x0035387C File Offset: 0x00351A7C
		public static void CopyValues__AssetList_CharacterInfo_5_3_0__AccessListBase_ICharacterInfo(AssetList<CharacterInfo_5_3_0> target, AccessListBase<ICharacterInfo> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CC6 RID: 93382 RVA: 0x003538C4 File Offset: 0x00351AC4
		public static void CopyValues__AssetDictionary_Int32_UInt32__AssetDictionary_Int32_UInt32(AssetDictionary<int, uint> target, AssetDictionary<int, uint> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Int32_UInt32__AccessPairBase_Int32_UInt32(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CC7 RID: 93383 RVA: 0x00353911 File Offset: 0x00351B11
		public static void CopyValues__AccessPairBase_Int32_UInt32__AccessPairBase_Int32_UInt32(AccessPairBase<int, uint> target, AccessPairBase<int, uint> source)
		{
			if (source != null)
			{
				target.Key = source.Key;
				target.Value = source.Value;
			}
		}

		// Token: 0x06016CC8 RID: 93384 RVA: 0x00353930 File Offset: 0x00351B30
		public static void CopyValues__AssetDictionary_Utf8String_AssetInfo_3_4_0__AccessDictionaryBase_Utf8String_IAssetInfo(AssetDictionary<Utf8String, AssetInfo_3_4_0> target, AccessDictionaryBase<Utf8String, IAssetInfo> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_AssetInfo_3_4_0__AccessPairBase_Utf8String_IAssetInfo(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CC9 RID: 93385 RVA: 0x0035397E File Offset: 0x00351B7E
		public static void CopyValues__AccessPairBase_Utf8String_AssetInfo_3_4_0__AccessPairBase_Utf8String_IAssetInfo(AccessPairBase<Utf8String, AssetInfo_3_4_0> target, AccessPairBase<Utf8String, IAssetInfo> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016CCA RID: 93386 RVA: 0x003539A8 File Offset: 0x00351BA8
		public static void CopyValues__AssetList_AssetBundleScriptInfo__AssetList_AssetBundleScriptInfo(AssetList<AssetBundleScriptInfo> target, AssetList<AssetBundleScriptInfo> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CCB RID: 93387 RVA: 0x003539F0 File Offset: 0x00351BF0
		public static void CopyValues__AssetList_AssetPair_Int32_UInt32__AssetList_AssetPair_Int32_UInt32(AssetList<AssetPair<int, uint>> target, AssetList<AssetPair<int, uint>> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					CopyValuesHelper.CopyValues__AssetPair_Int32_UInt32__AssetPair_Int32_UInt32(target.AddNew(), source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CCC RID: 93388 RVA: 0x00353A36 File Offset: 0x00351C36
		public static void CopyValues__AssetPair_Int32_UInt32__AssetPair_Int32_UInt32(AssetPair<int, uint> target, AssetPair<int, uint> source)
		{
			if (source != null)
			{
				target.Key = source.Key;
				target.Value = source.Value;
			}
		}

		// Token: 0x06016CCD RID: 93389 RVA: 0x00353A54 File Offset: 0x00351C54
		public static void CopyValues__AssetDictionary_Utf8String_AssetInfo_5_0_0__AccessDictionaryBase_Utf8String_IAssetInfo(AssetDictionary<Utf8String, AssetInfo_5_0_0> target, AccessDictionaryBase<Utf8String, IAssetInfo> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_AssetInfo_5_0_0__AccessPairBase_Utf8String_IAssetInfo(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CCE RID: 93390 RVA: 0x00353AA2 File Offset: 0x00351CA2
		public static void CopyValues__AccessPairBase_Utf8String_AssetInfo_5_0_0__AccessPairBase_Utf8String_IAssetInfo(AccessPairBase<Utf8String, AssetInfo_5_0_0> target, AccessPairBase<Utf8String, IAssetInfo> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016CCF RID: 93391 RVA: 0x00353ACC File Offset: 0x00351CCC
		public static void CopyValues__AssetDictionary_Int32_Int32__AssetDictionary_Int32_Int32(AssetDictionary<int, int> target, AssetDictionary<int, int> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Int32_Int32__AccessPairBase_Int32_Int32(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CD0 RID: 93392 RVA: 0x00353B19 File Offset: 0x00351D19
		public static void CopyValues__AccessPairBase_Int32_Int32__AccessPairBase_Int32_Int32(AccessPairBase<int, int> target, AccessPairBase<int, int> source)
		{
			if (source != null)
			{
				target.Key = source.Key;
				target.Value = source.Value;
			}
		}

		// Token: 0x06016CD1 RID: 93393 RVA: 0x00353B38 File Offset: 0x00351D38
		public static void CopyValues__AssetList_ResourceManager_Dependency_3_5_0__AccessListBase_IResourceManager_Dependency(AssetList<ResourceManager_Dependency_3_5_0> target, AccessListBase<IResourceManager_Dependency> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CD2 RID: 93394 RVA: 0x00353B80 File Offset: 0x00351D80
		public static void CopyValues__AssetList_ResourceManager_Dependency_5_0_0__AccessListBase_IResourceManager_Dependency(AssetList<ResourceManager_Dependency_5_0_0> target, AccessListBase<IResourceManager_Dependency> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CD3 RID: 93395 RVA: 0x00353BC8 File Offset: 0x00351DC8
		public static void CopyValues__AssetList_ResourceManager_Dependency_2017_1_0__AccessListBase_IResourceManager_Dependency(AssetList<ResourceManager_Dependency_2017_1_0> target, AccessListBase<IResourceManager_Dependency> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CD4 RID: 93396 RVA: 0x00353C10 File Offset: 0x00351E10
		public static void CopyValues__AssetDictionary_GUID_PPtr_GameObject_3_4_0__AccessDictionaryBase_GUID_IPPtr_GameObject(AssetDictionary<GUID, PPtr_GameObject_3_4_0> target, AccessDictionaryBase<GUID, IPPtr_GameObject> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_GUID_PPtr_GameObject_3_4_0__AccessPairBase_GUID_IPPtr_GameObject(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CD5 RID: 93397 RVA: 0x00353C5E File Offset: 0x00351E5E
		public static void CopyValues__AccessPairBase_GUID_PPtr_GameObject_3_4_0__AccessPairBase_GUID_IPPtr_GameObject(AccessPairBase<GUID, PPtr_GameObject_3_4_0> target, AccessPairBase<GUID, IPPtr_GameObject> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016CD6 RID: 93398 RVA: 0x00353C88 File Offset: 0x00351E88
		public static void CopyValues__AssetDictionary_GUID_PPtr_GameObject_5_0_0__AccessDictionaryBase_GUID_IPPtr_GameObject(AssetDictionary<GUID, PPtr_GameObject_5_0_0> target, AccessDictionaryBase<GUID, IPPtr_GameObject> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_GUID_PPtr_GameObject_5_0_0__AccessPairBase_GUID_IPPtr_GameObject(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CD7 RID: 93399 RVA: 0x00353CD6 File Offset: 0x00351ED6
		public static void CopyValues__AccessPairBase_GUID_PPtr_GameObject_5_0_0__AccessPairBase_GUID_IPPtr_GameObject(AccessPairBase<GUID, PPtr_GameObject_5_0_0> target, AccessPairBase<GUID, IPPtr_GameObject> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016CD8 RID: 93400 RVA: 0x00353D00 File Offset: 0x00351F00
		public static void CopyValues__AssetList_DetailPrototype_3_4_0__AccessListBase_IDetailPrototype(AssetList<DetailPrototype_3_4_0> target, AccessListBase<IDetailPrototype> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CD9 RID: 93401 RVA: 0x00353D48 File Offset: 0x00351F48
		public static void CopyValues__AssetList_DetailPatch_3_4_0__AccessListBase_IDetailPatch(AssetList<DetailPatch_3_4_0> target, AccessListBase<IDetailPatch> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CDA RID: 93402 RVA: 0x00353D90 File Offset: 0x00351F90
		public static void CopyValues__AssetList_TreeInstance_3_4_0__AccessListBase_ITreeInstance(AssetList<TreeInstance_3_4_0> target, AccessListBase<ITreeInstance> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CDB RID: 93403 RVA: 0x00353DD8 File Offset: 0x00351FD8
		public static void CopyValues__AssetList_TreePrototype_3_4_0__AccessListBase_ITreePrototype(AssetList<TreePrototype_3_4_0> target, AccessListBase<ITreePrototype> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CDC RID: 93404 RVA: 0x00353E20 File Offset: 0x00352020
		public static void CopyValues__AssetList_DetailPrototype_3_5_0__AccessListBase_IDetailPrototype(AssetList<DetailPrototype_3_5_0> target, AccessListBase<IDetailPrototype> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CDD RID: 93405 RVA: 0x00353E68 File Offset: 0x00352068
		public static void CopyValues__AssetList_DetailPatch_3_5_0__AccessListBase_IDetailPatch(AssetList<DetailPatch_3_5_0> target, AccessListBase<IDetailPatch> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CDE RID: 93406 RVA: 0x00353EB0 File Offset: 0x003520B0
		public static void CopyValues__AssetList_TreeInstance_3_5_0__AccessListBase_ITreeInstance(AssetList<TreeInstance_3_5_0> target, AccessListBase<ITreeInstance> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CDF RID: 93407 RVA: 0x00353EF8 File Offset: 0x003520F8
		public static void CopyValues__AssetList_DetailPrototype_5_0_0__AccessListBase_IDetailPrototype(AssetList<DetailPrototype_5_0_0> target, AccessListBase<IDetailPrototype> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CE0 RID: 93408 RVA: 0x00353F40 File Offset: 0x00352140
		public static void CopyValues__AssetList_TreeInstance_5_0_0__AccessListBase_ITreeInstance(AssetList<TreeInstance_5_0_0> target, AccessListBase<ITreeInstance> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CE1 RID: 93409 RVA: 0x00353F88 File Offset: 0x00352188
		public static void CopyValues__AssetList_TreePrototype_5_0_0__AccessListBase_ITreePrototype(AssetList<TreePrototype_5_0_0> target, AccessListBase<ITreePrototype> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CE2 RID: 93410 RVA: 0x00353FD0 File Offset: 0x003521D0
		public static void CopyValues__AssetList_TreePrototype_2020_2_0_a12__AccessListBase_ITreePrototype(AssetList<TreePrototype_2020_2_0_a12> target, AccessListBase<ITreePrototype> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CE3 RID: 93411 RVA: 0x00354018 File Offset: 0x00352218
		public static void CopyValues__AssetList_DetailPrototype_2020_2_0_b10__AccessListBase_IDetailPrototype(AssetList<DetailPrototype_2020_2_0_b10> target, AccessListBase<IDetailPrototype> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CE4 RID: 93412 RVA: 0x00354060 File Offset: 0x00352260
		public static void CopyValues__AssetList_DetailPatch_2020_2_0_b10__AccessListBase_IDetailPatch(AssetList<DetailPatch_2020_2_0_b10> target, AccessListBase<IDetailPatch> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CE5 RID: 93413 RVA: 0x003540A8 File Offset: 0x003522A8
		public static void CopyValues__AssetList_DetailPrototype_2021_2_0__AccessListBase_IDetailPrototype(AssetList<DetailPrototype_2021_2_0> target, AccessListBase<IDetailPrototype> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CE6 RID: 93414 RVA: 0x003540F0 File Offset: 0x003522F0
		public static void CopyValues__AssetList_DetailPrototype_2022_2_0__AccessListBase_IDetailPrototype(AssetList<DetailPrototype_2022_2_0> target, AccessListBase<IDetailPrototype> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CE7 RID: 93415 RVA: 0x00354138 File Offset: 0x00352338
		public static void CopyValues__AssetList_DetailPatch_2022_2_0__AccessListBase_IDetailPatch(AssetList<DetailPatch_2022_2_0> target, AccessListBase<IDetailPatch> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CE8 RID: 93416 RVA: 0x00354180 File Offset: 0x00352380
		public static void CopyValues__AssetList_DetailPrototype_2022_2_0_a16__AccessListBase_IDetailPrototype(AssetList<DetailPrototype_2022_2_0_a16> target, AccessListBase<IDetailPrototype> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CE9 RID: 93417 RVA: 0x003541C8 File Offset: 0x003523C8
		public static void CopyValues__AssetList_SplatPrototype_3_4_0__AccessListBase_ISplatPrototype(AssetList<SplatPrototype_3_4_0> target, AccessListBase<ISplatPrototype> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CEA RID: 93418 RVA: 0x00354210 File Offset: 0x00352410
		public static void CopyValues__AssetList_SplatPrototype_3_5_0__AccessListBase_ISplatPrototype(AssetList<SplatPrototype_3_5_0> target, AccessListBase<ISplatPrototype> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CEB RID: 93419 RVA: 0x00354258 File Offset: 0x00352458
		public static void CopyValues__AssetList_SplatPrototype_4_0_0__AccessListBase_ISplatPrototype(AssetList<SplatPrototype_4_0_0> target, AccessListBase<ISplatPrototype> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CEC RID: 93420 RVA: 0x003542A0 File Offset: 0x003524A0
		public static void CopyValues__AssetList_SplatPrototype_5_0_0__AccessListBase_ISplatPrototype(AssetList<SplatPrototype_5_0_0> target, AccessListBase<ISplatPrototype> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CED RID: 93421 RVA: 0x003542E8 File Offset: 0x003524E8
		public static void CopyValues__AssetList_SplatPrototype_5_0_1__AccessListBase_ISplatPrototype(AssetList<SplatPrototype_5_0_1> target, AccessListBase<ISplatPrototype> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		public static void CopyValues__AssetList_SplatPrototype_5_0_1_GICB2__AccessListBase_ISplatPrototype(AssetList<SplatPrototype_5_0_1_GICB2> target, AccessListBase<ISplatPrototype> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CEE RID: 93422 RVA: 0x00354330 File Offset: 0x00352530
		public static void CopyValues__AssetList_PPtr_TerrainLayer__AssetList_PPtr_TerrainLayer(AssetList<PPtr_TerrainLayer> target, AssetList<PPtr_TerrainLayer> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CEF RID: 93423 RVA: 0x00354378 File Offset: 0x00352578
		public static void CopyValues__AssetList_PPtr_Shader_5_0_0__AssetList_PPtr_Shader_5_0_0(AssetList<PPtr_Shader_5_0_0> target, AssetList<PPtr_Shader_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CF0 RID: 93424 RVA: 0x003543C0 File Offset: 0x003525C0
		public static void CopyValues__AssetList_LightmapData_3_4_0__AccessListBase_ILightmapData(AssetList<LightmapData_3_4_0> target, AccessListBase<ILightmapData> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CF1 RID: 93425 RVA: 0x00354408 File Offset: 0x00352608
		public static void CopyValues__AssetList_EnlightenRendererInformation__AssetList_EnlightenRendererInformation(AssetList<EnlightenRendererInformation> target, AssetList<EnlightenRendererInformation> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CF2 RID: 93426 RVA: 0x00354450 File Offset: 0x00352650
		public static void CopyValues__AssetList_EnlightenSystemAtlasInformation__AssetList_EnlightenSystemAtlasInformation(AssetList<EnlightenSystemAtlasInformation> target, AssetList<EnlightenSystemAtlasInformation> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CF3 RID: 93427 RVA: 0x00354498 File Offset: 0x00352698
		public static void CopyValues__AssetList_EnlightenSystemInformation__AssetList_EnlightenSystemInformation(AssetList<EnlightenSystemInformation> target, AssetList<EnlightenSystemInformation> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CF4 RID: 93428 RVA: 0x003544E0 File Offset: 0x003526E0
		public static void CopyValues__AssetList_EnlightenTerrainChunksInformation__AssetList_EnlightenTerrainChunksInformation(AssetList<EnlightenTerrainChunksInformation> target, AssetList<EnlightenTerrainChunksInformation> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CF5 RID: 93429 RVA: 0x00354528 File Offset: 0x00352728
		public static void CopyValues__AssetList_LightmapData_5_0_0__AccessListBase_ILightmapData(AssetList<LightmapData_5_0_0> target, AccessListBase<ILightmapData> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CF6 RID: 93430 RVA: 0x00354570 File Offset: 0x00352770
		public static void CopyValues__AssetList_LightmapData_5_6_0_b2__AccessListBase_ILightmapData(AssetList<LightmapData_5_6_0_b2> target, AccessListBase<ILightmapData> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CF7 RID: 93431 RVA: 0x003545B8 File Offset: 0x003527B8
		public static void CopyValues__AssetList_ClothAttachment__AssetList_ClothAttachment(AssetList<ClothAttachment> target, AssetList<ClothAttachment> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CF8 RID: 93432 RVA: 0x00354600 File Offset: 0x00352800
		public static void CopyValues__AssetList_PPtr_Material_3_4_0__AssetList_PPtr_Material_3_4_0(AssetList<PPtr_Material_3_4_0> target, AssetList<PPtr_Material_3_4_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CF9 RID: 93433 RVA: 0x00354648 File Offset: 0x00352848
		public static void CopyValues__AssetList_ClothConstrainCoefficients_3_4_0__AssetList_ClothConstrainCoefficients_3_4_0(AssetList<ClothConstrainCoefficients_3_4_0> target, AssetList<ClothConstrainCoefficients_3_4_0> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CFA RID: 93434 RVA: 0x00354690 File Offset: 0x00352890
		public static void CopyValues__AssetList_PPtr_CapsuleCollider__AssetList_PPtr_CapsuleCollider(AssetList<PPtr_CapsuleCollider> target, AssetList<PPtr_CapsuleCollider> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CFB RID: 93435 RVA: 0x003546D8 File Offset: 0x003528D8
		public static void CopyValues__AssetList_ClothConstrainCoefficients_5_0_0__AssetList_ClothConstrainCoefficients_5_0_0(AssetList<ClothConstrainCoefficients_5_0_0> target, AssetList<ClothConstrainCoefficients_5_0_0> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CFC RID: 93436 RVA: 0x00354720 File Offset: 0x00352920
		public static void CopyValues__AssetList_AssetPair_PPtr_SphereCollider_PPtr_SphereCollider__AssetList_AssetPair_PPtr_SphereCollider_PPtr_SphereCollider(AssetList<AssetPair<PPtr_SphereCollider, PPtr_SphereCollider>> target, AssetList<AssetPair<PPtr_SphereCollider, PPtr_SphereCollider>> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					CopyValuesHelper.CopyValues__AssetPair_PPtr_SphereCollider_PPtr_SphereCollider__AssetPair_PPtr_SphereCollider_PPtr_SphereCollider(target.AddNew(), source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CFD RID: 93437 RVA: 0x00354767 File Offset: 0x00352967
		public static void CopyValues__AssetPair_PPtr_SphereCollider_PPtr_SphereCollider__AssetPair_PPtr_SphereCollider_PPtr_SphereCollider(AssetPair<PPtr_SphereCollider, PPtr_SphereCollider> target, AssetPair<PPtr_SphereCollider, PPtr_SphereCollider> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key, converter);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016CFE RID: 93438 RVA: 0x00354790 File Offset: 0x00352990
		public static void CopyValues__AssetList_Vector3f_3_5_0__AssetList_Vector3f_3_5_0(AssetList<Vector3f_3_5_0> target, AssetList<Vector3f_3_5_0> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016CFF RID: 93439 RVA: 0x003547D8 File Offset: 0x003529D8
		public static void CopyValues__AssetList_ClothSphereColliderPair__AssetList_ClothSphereColliderPair(AssetList<ClothSphereColliderPair> target, AssetList<ClothSphereColliderPair> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D00 RID: 93440 RVA: 0x00354820 File Offset: 0x00352A20
		public static void CopyValues__AssetList_SubstanceInput_3_4_0__AccessListBase_ISubstanceInput(AssetList<SubstanceInput_3_4_0> target, AccessListBase<ISubstanceInput> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D01 RID: 93441 RVA: 0x00354868 File Offset: 0x00352A68
		public static void CopyValues__AssetList_SubstanceEnumItem__AssetList_SubstanceEnumItem(AssetList<SubstanceEnumItem> target, AssetList<SubstanceEnumItem> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D02 RID: 93442 RVA: 0x003548B0 File Offset: 0x00352AB0
		public static void CopyValues__AssetList_PPtr_ProceduralTexture_3_4_0__AccessListBase_IPPtr_ProceduralTexture(AssetList<PPtr_ProceduralTexture_3_4_0> target, AccessListBase<IPPtr_ProceduralTexture> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D03 RID: 93443 RVA: 0x003548F8 File Offset: 0x00352AF8
		public static void CopyValues__AssetList_SubstanceInput_3_5_0__AccessListBase_ISubstanceInput(AssetList<SubstanceInput_3_5_0> target, AccessListBase<ISubstanceInput> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D04 RID: 93444 RVA: 0x00354940 File Offset: 0x00352B40
		public static void CopyValues__AssetList_SubstanceInput_4_1_0__AccessListBase_ISubstanceInput(AssetList<SubstanceInput_4_1_0> target, AccessListBase<ISubstanceInput> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D05 RID: 93445 RVA: 0x00354988 File Offset: 0x00352B88
		public static void CopyValues__AssetList_SubstanceInput_4_5_0__AccessListBase_ISubstanceInput(AssetList<SubstanceInput_4_5_0> target, AccessListBase<ISubstanceInput> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D06 RID: 93446 RVA: 0x003549D0 File Offset: 0x00352BD0
		public static void CopyValues__AssetDictionary_UInt32_Boolean__AssetDictionary_UInt32_Boolean(AssetDictionary<uint, bool> target, AssetDictionary<uint, bool> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_UInt32_Boolean__AccessPairBase_UInt32_Boolean(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D07 RID: 93447 RVA: 0x00354A1D File Offset: 0x00352C1D
		public static void CopyValues__AccessPairBase_UInt32_Boolean__AccessPairBase_UInt32_Boolean(AccessPairBase<uint, bool> target, AccessPairBase<uint, bool> source)
		{
			if (source != null)
			{
				target.Key = source.Key;
				target.Value = source.Value;
			}
		}

		// Token: 0x06016D08 RID: 93448 RVA: 0x00354A3C File Offset: 0x00352C3C
		public static void CopyValues__AssetList_SubstanceInput_5_0_0__AccessListBase_ISubstanceInput(AssetList<SubstanceInput_5_0_0> target, AccessListBase<ISubstanceInput> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D09 RID: 93449 RVA: 0x00354A84 File Offset: 0x00352C84
		public static void CopyValues__AssetList_PPtr_ProceduralTexture_5_0_0__AccessListBase_IPPtr_ProceduralTexture(AssetList<PPtr_ProceduralTexture_5_0_0> target, AccessListBase<IPPtr_ProceduralTexture> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D0A RID: 93450 RVA: 0x00354ACC File Offset: 0x00352CCC
		public static void CopyValues__AssetList_SubstanceInput_5_2_0__AccessListBase_ISubstanceInput(AssetList<SubstanceInput_5_2_0> target, AccessListBase<ISubstanceInput> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D0B RID: 93451 RVA: 0x00354B14 File Offset: 0x00352D14
		public static void CopyValues__AssetList_SubstanceInput_2017_1_0__AccessListBase_ISubstanceInput(AssetList<SubstanceInput_2017_1_0> target, AccessListBase<ISubstanceInput> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D0C RID: 93452 RVA: 0x00354B5C File Offset: 0x00352D5C
		public static void CopyValues__AssetList_SubstanceInput_2017_2_0_b4__AccessListBase_ISubstanceInput(AssetList<SubstanceInput_2017_2_0_b4> target, AccessListBase<ISubstanceInput> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D0D RID: 93453 RVA: 0x00354BA4 File Offset: 0x00352DA4
		public static void CopyValues__AssetList_PPtr_EditorExtension_3_4_0__AssetList_PPtr_EditorExtension_3_4_0(AssetList<PPtr_EditorExtension_3_4_0> target, AssetList<PPtr_EditorExtension_3_4_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D0E RID: 93454 RVA: 0x00354BEC File Offset: 0x00352DEC
		public static void CopyValues__AssetList_PropertyModification_3_5_0__AccessListBase_IPropertyModification(AssetList<PropertyModification_3_5_0> target, AccessListBase<IPropertyModification> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D0F RID: 93455 RVA: 0x00354C34 File Offset: 0x00352E34
		public static void CopyValues__AssetList_PPtr_Object_3_4_0__AssetList_PPtr_Object_3_4_0(AssetList<PPtr_Object_3_4_0> target, AssetList<PPtr_Object_3_4_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D10 RID: 93456 RVA: 0x00354C7C File Offset: 0x00352E7C
		public static void CopyValues__AssetList_PropertyModification_5_0_0__AccessListBase_IPropertyModification(AssetList<PropertyModification_5_0_0> target, AccessListBase<IPropertyModification> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D11 RID: 93457 RVA: 0x00354CC4 File Offset: 0x00352EC4
		public static void CopyValues__AssetList_PPtr_Object_5_0_0__AssetList_PPtr_Object_5_0_0(AssetList<PPtr_Object_5_0_0> target, AssetList<PPtr_Object_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D12 RID: 93458 RVA: 0x00354D0C File Offset: 0x00352F0C
		public static void CopyValues__AssetList_PPtr_Component_5_0_0__AssetList_PPtr_Component_5_0_0(AssetList<PPtr_Component_5_0_0> target, AssetList<PPtr_Component_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D13 RID: 93459 RVA: 0x00354D54 File Offset: 0x00352F54
		public static void CopyValues__AssetList_AddedGameObject__AssetList_AddedGameObject(AssetList<AddedGameObject> target, AssetList<AddedGameObject> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D14 RID: 93460 RVA: 0x00354D9C File Offset: 0x00352F9C
		public static void CopyValues__AssetList_AddedComponent__AssetList_AddedComponent(AssetList<AddedComponent> target, AssetList<AddedComponent> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D15 RID: 93461 RVA: 0x00354DE4 File Offset: 0x00352FE4
		public static void CopyValues__AssetList_PPtr_GameObject_5_0_0__AssetList_PPtr_GameObject_5_0_0(AssetList<PPtr_GameObject_5_0_0> target, AssetList<PPtr_GameObject_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D16 RID: 93462 RVA: 0x00354E2C File Offset: 0x0035302C
		public static void CopyValues__AssetDictionary_GUID_Asset_3_4_0__AccessDictionaryBase_GUID_IAsset(AssetDictionary<GUID, Asset_3_4_0> target, AccessDictionaryBase<GUID, IAsset> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_GUID_Asset_3_4_0__AccessPairBase_GUID_IAsset(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D17 RID: 93463 RVA: 0x00354E7A File Offset: 0x0035307A
		public static void CopyValues__AccessPairBase_GUID_Asset_3_4_0__AccessPairBase_GUID_IAsset(AccessPairBase<GUID, Asset_3_4_0> target, AccessPairBase<GUID, IAsset> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016D18 RID: 93464 RVA: 0x00354EA4 File Offset: 0x003530A4
		public static void CopyValues__AssetList_GUID__AssetList_GUID(AssetList<GUID> target, AssetList<GUID> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D19 RID: 93465 RVA: 0x00354EEC File Offset: 0x003530EC
		public static void CopyValues__AssetList_LibraryRepresentation_3_4_0__AccessListBase_ILibraryRepresentation(AssetList<LibraryRepresentation_3_4_0> target, AccessListBase<ILibraryRepresentation> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D1A RID: 93466 RVA: 0x00354F34 File Offset: 0x00353134
		public static void CopyValues__AssetList_LibraryRepresentation_3_5_0__AccessListBase_ILibraryRepresentation(AssetList<LibraryRepresentation_3_5_0> target, AccessListBase<ILibraryRepresentation> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D1B RID: 93467 RVA: 0x00354F7C File Offset: 0x0035317C
		public static void CopyValues__AssetList_LibraryRepresentation_4_0_0__AccessListBase_ILibraryRepresentation(AssetList<LibraryRepresentation_4_0_0> target, AccessListBase<ILibraryRepresentation> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D1C RID: 93468 RVA: 0x00354FC4 File Offset: 0x003531C4
		public static void CopyValues__AssetList_LibraryRepresentation_5_0_0__AccessListBase_ILibraryRepresentation(AssetList<LibraryRepresentation_5_0_0> target, AccessListBase<ILibraryRepresentation> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D1D RID: 93469 RVA: 0x0035500C File Offset: 0x0035320C
		public static void CopyValues__AssetList_LibraryRepresentation_5_1_0__AccessListBase_ILibraryRepresentation(AssetList<LibraryRepresentation_5_1_0> target, AccessListBase<ILibraryRepresentation> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D1E RID: 93470 RVA: 0x00355054 File Offset: 0x00353254
		public static void CopyValues__AssetList_LibraryRepresentation_5_5_0__AccessListBase_ILibraryRepresentation(AssetList<LibraryRepresentation_5_5_0> target, AccessListBase<ILibraryRepresentation> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D1F RID: 93471 RVA: 0x0035509C File Offset: 0x0035329C
		public static void CopyValues__AssetDictionary_GUID_Utf8String__AssetDictionary_GUID_Utf8String(AssetDictionary<GUID, Utf8String> target, AssetDictionary<GUID, Utf8String> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_GUID_Utf8String__AccessPairBase_GUID_Utf8String(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D20 RID: 93472 RVA: 0x003550E9 File Offset: 0x003532E9
		public static void CopyValues__AccessPairBase_GUID_Utf8String__AccessPairBase_GUID_Utf8String(AccessPairBase<GUID, Utf8String> target, AccessPairBase<GUID, Utf8String> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016D21 RID: 93473 RVA: 0x00355110 File Offset: 0x00353310
		public static void CopyValues__AssetDictionary_Utf8String_GUID__AssetDictionary_Utf8String_GUID(AssetDictionary<Utf8String, GUID> target, AssetDictionary<Utf8String, GUID> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_GUID__AccessPairBase_Utf8String_GUID(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D22 RID: 93474 RVA: 0x0035515D File Offset: 0x0035335D
		public static void CopyValues__AccessPairBase_Utf8String_GUID__AccessPairBase_Utf8String_GUID(AccessPairBase<Utf8String, GUID> target, AccessPairBase<Utf8String, GUID> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016D23 RID: 93475 RVA: 0x00355184 File Offset: 0x00353384
		public static void CopyValues__AssetList_LibraryRepresentation_2019_3_0_a8__AccessListBase_ILibraryRepresentation(AssetList<LibraryRepresentation_2019_3_0_a8> target, AccessListBase<ILibraryRepresentation> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D24 RID: 93476 RVA: 0x003551CC File Offset: 0x003533CC
		public static void CopyValues__AssetDictionary_GUID_Asset_3_5_0__AccessDictionaryBase_GUID_IAsset(AssetDictionary<GUID, Asset_3_5_0> target, AccessDictionaryBase<GUID, IAsset> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_GUID_Asset_3_5_0__AccessPairBase_GUID_IAsset(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D25 RID: 93477 RVA: 0x0035521A File Offset: 0x0035341A
		public static void CopyValues__AccessPairBase_GUID_Asset_3_5_0__AccessPairBase_GUID_IAsset(AccessPairBase<GUID, Asset_3_5_0> target, AccessPairBase<GUID, IAsset> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016D26 RID: 93478 RVA: 0x00355244 File Offset: 0x00353444
		public static void CopyValues__AssetDictionary_Utf8String_AssetTimeStamp__AssetDictionary_Utf8String_AssetTimeStamp(AssetDictionary<Utf8String, AssetTimeStamp> target, AssetDictionary<Utf8String, AssetTimeStamp> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_AssetTimeStamp__AccessPairBase_Utf8String_AssetTimeStamp(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D27 RID: 93479 RVA: 0x00355291 File Offset: 0x00353491
		public static void CopyValues__AccessPairBase_Utf8String_AssetTimeStamp__AccessPairBase_Utf8String_AssetTimeStamp(AccessPairBase<Utf8String, AssetTimeStamp> target, AccessPairBase<Utf8String, AssetTimeStamp> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016D28 RID: 93480 RVA: 0x003552B8 File Offset: 0x003534B8
		public static void CopyValues__AssetDictionary_GUID_Asset_4_0_0__AccessDictionaryBase_GUID_IAsset(AssetDictionary<GUID, Asset_4_0_0> target, AccessDictionaryBase<GUID, IAsset> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_GUID_Asset_4_0_0__AccessPairBase_GUID_IAsset(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D29 RID: 93481 RVA: 0x00355306 File Offset: 0x00353506
		public static void CopyValues__AccessPairBase_GUID_Asset_4_0_0__AccessPairBase_GUID_IAsset(AccessPairBase<GUID, Asset_4_0_0> target, AccessPairBase<GUID, IAsset> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016D2A RID: 93482 RVA: 0x00355330 File Offset: 0x00353530
		public static void CopyValues__AssetDictionary_GUID_Asset_4_3_0__AccessDictionaryBase_GUID_IAsset(AssetDictionary<GUID, Asset_4_3_0> target, AccessDictionaryBase<GUID, IAsset> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_GUID_Asset_4_3_0__AccessPairBase_GUID_IAsset(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D2B RID: 93483 RVA: 0x0035537E File Offset: 0x0035357E
		public static void CopyValues__AccessPairBase_GUID_Asset_4_3_0__AccessPairBase_GUID_IAsset(AccessPairBase<GUID, Asset_4_3_0> target, AccessPairBase<GUID, IAsset> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016D2C RID: 93484 RVA: 0x003553A8 File Offset: 0x003535A8
		public static void CopyValues__AssetDictionary_Int32_AssetBundleFullName__AssetDictionary_Int32_AssetBundleFullName(AssetDictionary<int, AssetBundleFullName> target, AssetDictionary<int, AssetBundleFullName> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Int32_AssetBundleFullName__AccessPairBase_Int32_AssetBundleFullName(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D2D RID: 93485 RVA: 0x003553F5 File Offset: 0x003535F5
		public static void CopyValues__AccessPairBase_Int32_AssetBundleFullName__AccessPairBase_Int32_AssetBundleFullName(AccessPairBase<int, AssetBundleFullName> target, AccessPairBase<int, AssetBundleFullName> source)
		{
			if (source != null)
			{
				target.Key = source.Key;
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016D2E RID: 93486 RVA: 0x00355418 File Offset: 0x00353618
		public static void CopyValues__AssetDictionary_GUID_Asset_5_0_0__AccessDictionaryBase_GUID_IAsset(AssetDictionary<GUID, Asset_5_0_0> target, AccessDictionaryBase<GUID, IAsset> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_GUID_Asset_5_0_0__AccessPairBase_GUID_IAsset(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D2F RID: 93487 RVA: 0x00355466 File Offset: 0x00353666
		public static void CopyValues__AccessPairBase_GUID_Asset_5_0_0__AccessPairBase_GUID_IAsset(AccessPairBase<GUID, Asset_5_0_0> target, AccessPairBase<GUID, IAsset> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016D30 RID: 93488 RVA: 0x00355490 File Offset: 0x00353690
		public static void CopyValues__AssetDictionary_GUID_Asset_5_1_0__AccessDictionaryBase_GUID_IAsset(AssetDictionary<GUID, Asset_5_1_0> target, AccessDictionaryBase<GUID, IAsset> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_GUID_Asset_5_1_0__AccessPairBase_GUID_IAsset(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D31 RID: 93489 RVA: 0x003554DE File Offset: 0x003536DE
		public static void CopyValues__AccessPairBase_GUID_Asset_5_1_0__AccessPairBase_GUID_IAsset(AccessPairBase<GUID, Asset_5_1_0> target, AccessPairBase<GUID, IAsset> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016D32 RID: 93490 RVA: 0x00355508 File Offset: 0x00353708
		public static void CopyValues__AssetDictionary_GUID_Asset_5_5_0__AccessDictionaryBase_GUID_IAsset(AssetDictionary<GUID, Asset_5_5_0> target, AccessDictionaryBase<GUID, IAsset> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_GUID_Asset_5_5_0__AccessPairBase_GUID_IAsset(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D33 RID: 93491 RVA: 0x00355556 File Offset: 0x00353756
		public static void CopyValues__AccessPairBase_GUID_Asset_5_5_0__AccessPairBase_GUID_IAsset(AccessPairBase<GUID, Asset_5_5_0> target, AccessPairBase<GUID, IAsset> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016D34 RID: 93492 RVA: 0x00355580 File Offset: 0x00353780
		public static void CopyValues__AssetDictionary_GUID_Asset_2017_1_0__AccessDictionaryBase_GUID_IAsset(AssetDictionary<GUID, Asset_2017_1_0> target, AccessDictionaryBase<GUID, IAsset> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_GUID_Asset_2017_1_0__AccessPairBase_GUID_IAsset(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D35 RID: 93493 RVA: 0x003555CE File Offset: 0x003537CE
		public static void CopyValues__AccessPairBase_GUID_Asset_2017_1_0__AccessPairBase_GUID_IAsset(AccessPairBase<GUID, Asset_2017_1_0> target, AccessPairBase<GUID, IAsset> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016D36 RID: 93494 RVA: 0x003555F8 File Offset: 0x003537F8
		public static void CopyValues__AssetDictionary_AssetImporterHashKey_UInt32__AssetDictionary_AssetImporterHashKey_UInt32(AssetDictionary<AssetImporterHashKey, uint> target, AssetDictionary<AssetImporterHashKey, uint> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_AssetImporterHashKey_UInt32__AccessPairBase_AssetImporterHashKey_UInt32(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D37 RID: 93495 RVA: 0x00355645 File Offset: 0x00353845
		public static void CopyValues__AccessPairBase_AssetImporterHashKey_UInt32__AccessPairBase_AssetImporterHashKey_UInt32(AccessPairBase<AssetImporterHashKey, uint> target, AccessPairBase<AssetImporterHashKey, uint> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value = source.Value;
			}
		}

		// Token: 0x06016D38 RID: 93496 RVA: 0x00355668 File Offset: 0x00353868
		public static void CopyValues__AssetDictionary_GUID_Asset_2017_2_5__AccessDictionaryBase_GUID_IAsset(AssetDictionary<GUID, Asset_2017_2_5> target, AccessDictionaryBase<GUID, IAsset> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_GUID_Asset_2017_2_5__AccessPairBase_GUID_IAsset(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D39 RID: 93497 RVA: 0x003556B6 File Offset: 0x003538B6
		public static void CopyValues__AccessPairBase_GUID_Asset_2017_2_5__AccessPairBase_GUID_IAsset(AccessPairBase<GUID, Asset_2017_2_5> target, AccessPairBase<GUID, IAsset> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016D3A RID: 93498 RVA: 0x003556E0 File Offset: 0x003538E0
		public static void CopyValues__AssetDictionary_GUID_Asset_2017_3_0__AccessDictionaryBase_GUID_IAsset(AssetDictionary<GUID, Asset_2017_3_0> target, AccessDictionaryBase<GUID, IAsset> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_GUID_Asset_2017_3_0__AccessPairBase_GUID_IAsset(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D3B RID: 93499 RVA: 0x0035572E File Offset: 0x0035392E
		public static void CopyValues__AccessPairBase_GUID_Asset_2017_3_0__AccessPairBase_GUID_IAsset(AccessPairBase<GUID, Asset_2017_3_0> target, AccessPairBase<GUID, IAsset> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016D3C RID: 93500 RVA: 0x00355758 File Offset: 0x00353958
		public static void CopyValues__AssetDictionary_GUID_Asset_2017_4_14__AccessDictionaryBase_GUID_IAsset(AssetDictionary<GUID, Asset_2017_4_14> target, AccessDictionaryBase<GUID, IAsset> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_GUID_Asset_2017_4_14__AccessPairBase_GUID_IAsset(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D3D RID: 93501 RVA: 0x003557A6 File Offset: 0x003539A6
		public static void CopyValues__AccessPairBase_GUID_Asset_2017_4_14__AccessPairBase_GUID_IAsset(AccessPairBase<GUID, Asset_2017_4_14> target, AccessPairBase<GUID, IAsset> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016D3E RID: 93502 RVA: 0x003557D0 File Offset: 0x003539D0
		public static void CopyValues__AssetDictionary_GUID_Asset_2018_1_0__AccessDictionaryBase_GUID_IAsset(AssetDictionary<GUID, Asset_2018_1_0> target, AccessDictionaryBase<GUID, IAsset> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_GUID_Asset_2018_1_0__AccessPairBase_GUID_IAsset(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D3F RID: 93503 RVA: 0x0035581E File Offset: 0x00353A1E
		public static void CopyValues__AccessPairBase_GUID_Asset_2018_1_0__AccessPairBase_GUID_IAsset(AccessPairBase<GUID, Asset_2018_1_0> target, AccessPairBase<GUID, IAsset> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016D40 RID: 93504 RVA: 0x00355848 File Offset: 0x00353A48
		public static void CopyValues__AssetDictionary_GUID_Asset_2018_1_0_b11__AccessDictionaryBase_GUID_IAsset(AssetDictionary<GUID, Asset_2018_1_0_b11> target, AccessDictionaryBase<GUID, IAsset> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_GUID_Asset_2018_1_0_b11__AccessPairBase_GUID_IAsset(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D41 RID: 93505 RVA: 0x00355896 File Offset: 0x00353A96
		public static void CopyValues__AccessPairBase_GUID_Asset_2018_1_0_b11__AccessPairBase_GUID_IAsset(AccessPairBase<GUID, Asset_2018_1_0_b11> target, AccessPairBase<GUID, IAsset> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016D42 RID: 93506 RVA: 0x003558C0 File Offset: 0x00353AC0
		public static void CopyValues__AssetDictionary_GUID_Asset_2018_3_0__AccessDictionaryBase_GUID_IAsset(AssetDictionary<GUID, Asset_2018_3_0> target, AccessDictionaryBase<GUID, IAsset> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_GUID_Asset_2018_3_0__AccessPairBase_GUID_IAsset(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D43 RID: 93507 RVA: 0x0035590E File Offset: 0x00353B0E
		public static void CopyValues__AccessPairBase_GUID_Asset_2018_3_0__AccessPairBase_GUID_IAsset(AccessPairBase<GUID, Asset_2018_3_0> target, AccessPairBase<GUID, IAsset> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016D44 RID: 93508 RVA: 0x00355938 File Offset: 0x00353B38
		public static void CopyValues__AssetDictionary_GUID_Asset_2019_3_0_a8__AccessDictionaryBase_GUID_IAsset(AssetDictionary<GUID, Asset_2019_3_0_a8> target, AccessDictionaryBase<GUID, IAsset> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_GUID_Asset_2019_3_0_a8__AccessPairBase_GUID_IAsset(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D45 RID: 93509 RVA: 0x00355986 File Offset: 0x00353B86
		public static void CopyValues__AccessPairBase_GUID_Asset_2019_3_0_a8__AccessPairBase_GUID_IAsset(AccessPairBase<GUID, Asset_2019_3_0_a8> target, AccessPairBase<GUID, IAsset> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016D46 RID: 93510 RVA: 0x003559B0 File Offset: 0x00353BB0
		public static void CopyValues__AssetList_ClipAnimationInfo_3_4_0__AccessListBase_IClipAnimationInfo(AssetList<ClipAnimationInfo_3_4_0> target, AccessListBase<IClipAnimationInfo> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D47 RID: 93511 RVA: 0x003559F8 File Offset: 0x00353BF8
		public static void CopyValues__AssetList_ClipAnimationInfoCurve_4_0_0__AccessListBase_IClipAnimationInfoCurve(AssetList<ClipAnimationInfoCurve_4_0_0> target, AccessListBase<IClipAnimationInfoCurve> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D48 RID: 93512 RVA: 0x00355A40 File Offset: 0x00353C40
		public static void CopyValues__AssetList_AvatarSkeletonMaskElement__AssetList_AvatarSkeletonMaskElement(AssetList<AvatarSkeletonMaskElement> target, AssetList<AvatarSkeletonMaskElement> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D49 RID: 93513 RVA: 0x00355A88 File Offset: 0x00353C88
		public static void CopyValues__AssetList_TransformMaskElement__AssetList_TransformMaskElement(AssetList<TransformMaskElement> target, AssetList<TransformMaskElement> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D4A RID: 93514 RVA: 0x00355AD0 File Offset: 0x00353CD0
		public static void CopyValues__AssetList_ClipAnimationInfoCurve_5_3_0__AccessListBase_IClipAnimationInfoCurve(AssetList<ClipAnimationInfoCurve_5_3_0> target, AccessListBase<IClipAnimationInfoCurve> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D4B RID: 93515 RVA: 0x00355B18 File Offset: 0x00353D18
		public static void CopyValues__AssetList_ClipAnimationInfoCurve_5_5_0__AccessListBase_IClipAnimationInfoCurve(AssetList<ClipAnimationInfoCurve_5_5_0> target, AccessListBase<IClipAnimationInfoCurve> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D4C RID: 93516 RVA: 0x00355B60 File Offset: 0x00353D60
		public static void CopyValues__AssetList_ClipAnimationInfoCurve_2017_1_0__AccessListBase_IClipAnimationInfoCurve(AssetList<ClipAnimationInfoCurve_2017_1_0> target, AccessListBase<IClipAnimationInfoCurve> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D4D RID: 93517 RVA: 0x00355BA8 File Offset: 0x00353DA8
		public static void CopyValues__AssetList_ClipAnimationInfoCurve_2018_1_0__AccessListBase_IClipAnimationInfoCurve(AssetList<ClipAnimationInfoCurve_2018_1_0> target, AccessListBase<IClipAnimationInfoCurve> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D4E RID: 93518 RVA: 0x00355BF0 File Offset: 0x00353DF0
		public static void CopyValues__AssetDictionary_Int32_Utf8String__AssetDictionary_Int32_Utf8String(AssetDictionary<int, Utf8String> target, AssetDictionary<int, Utf8String> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Int32_Utf8String__AccessPairBase_Int32_Utf8String(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D4F RID: 93519 RVA: 0x00355C3D File Offset: 0x00353E3D
		public static void CopyValues__AccessPairBase_Int32_Utf8String__AccessPairBase_Int32_Utf8String(AccessPairBase<int, Utf8String> target, AccessPairBase<int, Utf8String> source)
		{
			if (source != null)
			{
				target.Key = source.Key;
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016D50 RID: 93520 RVA: 0x00355C60 File Offset: 0x00353E60
		public static void CopyValues__AssetList_PPtr_GameObject_3_4_0__AccessListBase_IPPtr_GameObject(AssetList<PPtr_GameObject_3_4_0> target, AccessListBase<IPPtr_GameObject> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D51 RID: 93521 RVA: 0x00355CA8 File Offset: 0x00353EA8
		public static void CopyValues__AssetList_ClipAnimationInfo_4_0_0__AccessListBase_IClipAnimationInfo(AssetList<ClipAnimationInfo_4_0_0> target, AccessListBase<IClipAnimationInfo> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D52 RID: 93522 RVA: 0x00355CF0 File Offset: 0x00353EF0
		public static void CopyValues__AssetList_HumanHandle__AssetList_HumanHandle(AssetList<HumanHandle> target, AssetList<HumanHandle> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D53 RID: 93523 RVA: 0x00355D38 File Offset: 0x00353F38
		public static void CopyValues__AssetList_HumanBone_4_0_0__AccessListBase_IHumanBone(AssetList<HumanBone_4_0_0> target, AccessListBase<IHumanBone> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D54 RID: 93524 RVA: 0x00355D80 File Offset: 0x00353F80
		public static void CopyValues__AssetList_SkeletonBone_4_0_0__AccessListBase_ISkeletonBone(AssetList<SkeletonBone_4_0_0> target, AccessListBase<ISkeletonBone> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D55 RID: 93525 RVA: 0x00355DC8 File Offset: 0x00353FC8
		public static void CopyValues__AssetList_HumanBone_4_3_0__AccessListBase_IHumanBone(AssetList<HumanBone_4_3_0> target, AccessListBase<IHumanBone> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D56 RID: 93526 RVA: 0x00355E10 File Offset: 0x00354010
		public static void CopyValues__AssetList_SkeletonBone_5_5_0__AccessListBase_ISkeletonBone(AssetList<SkeletonBone_5_5_0> target, AccessListBase<ISkeletonBone> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D57 RID: 93527 RVA: 0x00355E58 File Offset: 0x00354058
		public static void CopyValues__AssetList_TakeInfo_4_0_0__AccessListBase_ITakeInfo(AssetList<TakeInfo_4_0_0> target, AccessListBase<ITakeInfo> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D58 RID: 93528 RVA: 0x00355EA0 File Offset: 0x003540A0
		public static void CopyValues__AssetList_ClipAnimationInfo_4_1_0__AccessListBase_IClipAnimationInfo(AssetList<ClipAnimationInfo_4_1_0> target, AccessListBase<IClipAnimationInfo> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D59 RID: 93529 RVA: 0x00355EE8 File Offset: 0x003540E8
		public static void CopyValues__AssetList_ClipAnimationInfo_4_3_0__AccessListBase_IClipAnimationInfo(AssetList<ClipAnimationInfo_4_3_0> target, AccessListBase<IClipAnimationInfo> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D5A RID: 93530 RVA: 0x00355F30 File Offset: 0x00354130
		public static void CopyValues__AssetList_ClipAnimationInfo_5_0_0__AccessListBase_IClipAnimationInfo(AssetList<ClipAnimationInfo_5_0_0> target, AccessListBase<IClipAnimationInfo> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D5B RID: 93531 RVA: 0x00355F78 File Offset: 0x00354178
		public static void CopyValues__AssetDictionary_Int64_Utf8String__AssetDictionary_Int64_Utf8String(AssetDictionary<long, Utf8String> target, AssetDictionary<long, Utf8String> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Int64_Utf8String__AccessPairBase_Int64_Utf8String(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D5C RID: 93532 RVA: 0x00355FC5 File Offset: 0x003541C5
		public static void CopyValues__AccessPairBase_Int64_Utf8String__AccessPairBase_Int64_Utf8String(AccessPairBase<long, Utf8String> target, AccessPairBase<long, Utf8String> source)
		{
			if (source != null)
			{
				target.Key = source.Key;
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016D5D RID: 93533 RVA: 0x00355FE8 File Offset: 0x003541E8
		public static void CopyValues__AssetList_PPtr_GameObject_5_0_0__AccessListBase_IPPtr_GameObject(AssetList<PPtr_GameObject_5_0_0> target, AccessListBase<IPPtr_GameObject> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D5E RID: 93534 RVA: 0x00356030 File Offset: 0x00354230
		public static void CopyValues__AssetList_TakeInfo_5_0_0__AccessListBase_ITakeInfo(AssetList<TakeInfo_5_0_0> target, AccessListBase<ITakeInfo> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D5F RID: 93535 RVA: 0x00356078 File Offset: 0x00354278
		public static void CopyValues__AssetList_ClipAnimationInfo_5_3_0__AccessListBase_IClipAnimationInfo(AssetList<ClipAnimationInfo_5_3_0> target, AccessListBase<IClipAnimationInfo> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D60 RID: 93536 RVA: 0x003560C0 File Offset: 0x003542C0
		public static void CopyValues__AssetList_ClipAnimationInfo_5_5_0__AccessListBase_IClipAnimationInfo(AssetList<ClipAnimationInfo_5_5_0> target, AccessListBase<IClipAnimationInfo> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D61 RID: 93537 RVA: 0x00356108 File Offset: 0x00354308
		public static void CopyValues__AssetList_ClipAnimationInfo_2017_1_0__AccessListBase_IClipAnimationInfo(AssetList<ClipAnimationInfo_2017_1_0> target, AccessListBase<IClipAnimationInfo> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D62 RID: 93538 RVA: 0x00356150 File Offset: 0x00354350
		public static void CopyValues__AssetDictionary_SourceAssetIdentifier_PPtr_Object_5_0_0__AssetDictionary_SourceAssetIdentifier_PPtr_Object_5_0_0(AssetDictionary<SourceAssetIdentifier, PPtr_Object_5_0_0> target, AssetDictionary<SourceAssetIdentifier, PPtr_Object_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_SourceAssetIdentifier_PPtr_Object_5_0_0__AccessPairBase_SourceAssetIdentifier_PPtr_Object_5_0_0(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D63 RID: 93539 RVA: 0x0035619E File Offset: 0x0035439E
		public static void CopyValues__AccessPairBase_SourceAssetIdentifier_PPtr_Object_5_0_0__AccessPairBase_SourceAssetIdentifier_PPtr_Object_5_0_0(AccessPairBase<SourceAssetIdentifier, PPtr_Object_5_0_0> target, AccessPairBase<SourceAssetIdentifier, PPtr_Object_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016D64 RID: 93540 RVA: 0x003561C8 File Offset: 0x003543C8
		public static void CopyValues__AssetList_SourceAssetIdentifier__AssetList_SourceAssetIdentifier(AssetList<SourceAssetIdentifier> target, AssetList<SourceAssetIdentifier> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D65 RID: 93541 RVA: 0x00356210 File Offset: 0x00354410
		public static void CopyValues__AssetList_ClipAnimationInfo_2018_1_0__AccessListBase_IClipAnimationInfo(AssetList<ClipAnimationInfo_2018_1_0> target, AccessListBase<IClipAnimationInfo> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D66 RID: 93542 RVA: 0x00356258 File Offset: 0x00354458
		public static void CopyValues__AssetList_ClipAnimationInfo_2019_1_0__AccessListBase_IClipAnimationInfo(AssetList<ClipAnimationInfo_2019_1_0> target, AccessListBase<IClipAnimationInfo> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D67 RID: 93543 RVA: 0x003562A0 File Offset: 0x003544A0
		public static void CopyValues__AssetList_TakeInfo_2019_1_0__AccessListBase_ITakeInfo(AssetList<TakeInfo_2019_1_0> target, AccessListBase<ITakeInfo> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D68 RID: 93544 RVA: 0x003562E8 File Offset: 0x003544E8
		public static void CopyValues__AssetList_AssetPair_AssetPair_Int32_Int64_Utf8String__AssetList_AssetPair_AssetPair_Int32_Int64_Utf8String(AssetList<AssetPair<AssetPair<int, long>, Utf8String>> target, AssetList<AssetPair<AssetPair<int, long>, Utf8String>> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					CopyValuesHelper.CopyValues__AssetPair_AssetPair_Int32_Int64_Utf8String__AssetPair_AssetPair_Int32_Int64_Utf8String(target.AddNew(), source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D69 RID: 93545 RVA: 0x0035632E File Offset: 0x0035452E
		public static void CopyValues__AssetPair_AssetPair_Int32_Int64_Utf8String__AssetPair_AssetPair_Int32_Int64_Utf8String(AssetPair<AssetPair<int, long>, Utf8String> target, AssetPair<AssetPair<int, long>, Utf8String> source)
		{
			if (source != null)
			{
				CopyValuesHelper.CopyValues__AssetPair_Int32_Int64__AssetPair_Int32_Int64(target.Key, source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016D6A RID: 93546 RVA: 0x00356355 File Offset: 0x00354555
		public static void CopyValues__AssetPair_Int32_Int64__AssetPair_Int32_Int64(AssetPair<int, long> target, AssetPair<int, long> source)
		{
			if (source != null)
			{
				target.Key = source.Key;
				target.Value = source.Value;
			}
		}

		// Token: 0x06016D6B RID: 93547 RVA: 0x00356374 File Offset: 0x00354574
		public static void CopyValues__AssetList_TextureImporterPlatformSettings_3_4_0__AccessListBase_ITextureImporterPlatformSettings(AssetList<TextureImporterPlatformSettings_3_4_0> target, AccessListBase<ITextureImporterPlatformSettings> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D6C RID: 93548 RVA: 0x003563BC File Offset: 0x003545BC
		public static void CopyValues__AssetList_TextureImporterPlatformSettings_3_5_0__AccessListBase_ITextureImporterPlatformSettings(AssetList<TextureImporterPlatformSettings_3_5_0> target, AccessListBase<ITextureImporterPlatformSettings> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D6D RID: 93549 RVA: 0x00356404 File Offset: 0x00354604
		public static void CopyValues__AssetList_SpriteMetaData_4_3_0__AccessListBase_ISpriteMetaData(AssetList<SpriteMetaData_4_3_0> target, AccessListBase<ISpriteMetaData> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D6E RID: 93550 RVA: 0x0035644C File Offset: 0x0035464C
		public static void CopyValues__AssetList_AssetList_Vector2f_3_5_0__AssetList_AssetList_Vector2f_3_5_0(AssetList<AssetList<Vector2f_3_5_0>> target, AssetList<AssetList<Vector2f_3_5_0>> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					CopyValuesHelper.CopyValues__AssetList_Vector2f_3_5_0__AssetList_Vector2f_3_5_0(target.AddNew(), source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D6F RID: 93551 RVA: 0x00356494 File Offset: 0x00354694
		public static void CopyValues__AssetList_Vector2f_3_5_0__AssetList_Vector2f_3_5_0(AssetList<Vector2f_3_5_0> target, AssetList<Vector2f_3_5_0> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D70 RID: 93552 RVA: 0x003564DC File Offset: 0x003546DC
		public static void CopyValues__AssetList_SpriteBone_2018_1_0__AccessListBase_ISpriteBone(AssetList<SpriteBone_2018_1_0> target, AccessListBase<ISpriteBone> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D71 RID: 93553 RVA: 0x00356524 File Offset: 0x00354724
		public static void CopyValues__AssetList_Vector2Int__AssetList_Vector2Int(AssetList<Vector2Int> target, AssetList<Vector2Int> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D72 RID: 93554 RVA: 0x0035656C File Offset: 0x0035476C
		public static void CopyValues__AssetList_BoneWeights4_2017_1_0__AssetList_BoneWeights4_2017_1_0(AssetList<BoneWeights4_2017_1_0> target, AssetList<BoneWeights4_2017_1_0> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D73 RID: 93555 RVA: 0x003565B4 File Offset: 0x003547B4
		public static void CopyValues__AssetList_SpriteBone_2021_1_0__AccessListBase_ISpriteBone(AssetList<SpriteBone_2021_1_0> target, AccessListBase<ISpriteBone> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D74 RID: 93556 RVA: 0x003565FC File Offset: 0x003547FC
		public static void CopyValues__AssetList_SpriteMetaData_4_5_0__AccessListBase_ISpriteMetaData(AssetList<SpriteMetaData_4_5_0> target, AccessListBase<ISpriteMetaData> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D75 RID: 93557 RVA: 0x00356644 File Offset: 0x00354844
		public static void CopyValues__AssetList_SpriteMetaData_5_3_0__AccessListBase_ISpriteMetaData(AssetList<SpriteMetaData_5_3_0> target, AccessListBase<ISpriteMetaData> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D76 RID: 93558 RVA: 0x0035668C File Offset: 0x0035488C
		public static void CopyValues__AssetList_SpriteMetaData_5_3_6__AccessListBase_ISpriteMetaData(AssetList<SpriteMetaData_5_3_6> target, AccessListBase<ISpriteMetaData> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D77 RID: 93559 RVA: 0x003566D4 File Offset: 0x003548D4
		public static void CopyValues__AssetList_SpriteMetaData_5_4_0__AccessListBase_ISpriteMetaData(AssetList<SpriteMetaData_5_4_0> target, AccessListBase<ISpriteMetaData> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D78 RID: 93560 RVA: 0x0035671C File Offset: 0x0035491C
		public static void CopyValues__AssetList_SpriteMetaData_2017_1_0__AccessListBase_ISpriteMetaData(AssetList<SpriteMetaData_2017_1_0> target, AccessListBase<ISpriteMetaData> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D79 RID: 93561 RVA: 0x00356764 File Offset: 0x00354964
		public static void CopyValues__AssetList_SpriteMetaData_2018_1_0__AccessListBase_ISpriteMetaData(AssetList<SpriteMetaData_2018_1_0> target, AccessListBase<ISpriteMetaData> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D7A RID: 93562 RVA: 0x003567AC File Offset: 0x003549AC
		public static void CopyValues__AssetList_SecondarySpriteTexture__AssetList_SecondarySpriteTexture(AssetList<SecondarySpriteTexture> target, AssetList<SecondarySpriteTexture> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D7B RID: 93563 RVA: 0x003567F4 File Offset: 0x003549F4
		public static void CopyValues__AssetList_SpriteMetaData_2019_1_0__AccessListBase_ISpriteMetaData(AssetList<SpriteMetaData_2019_1_0> target, AccessListBase<ISpriteMetaData> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D7C RID: 93564 RVA: 0x0035683C File Offset: 0x00354A3C
		public static void CopyValues__AssetList_SpriteMetaData_2021_1_0__AccessListBase_ISpriteMetaData(AssetList<SpriteMetaData_2021_1_0> target, AccessListBase<ISpriteMetaData> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D7D RID: 93565 RVA: 0x00356884 File Offset: 0x00354A84
		public static void CopyValues__AssetDictionary_Utf8String_Int64__AssetDictionary_Utf8String_Int64(AssetDictionary<Utf8String, long> target, AssetDictionary<Utf8String, long> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_Int64__AccessPairBase_Utf8String_Int64(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D7E RID: 93566 RVA: 0x003568D1 File Offset: 0x00354AD1
		public static void CopyValues__AccessPairBase_Utf8String_Int64__AccessPairBase_Utf8String_Int64(AccessPairBase<Utf8String, long> target, AccessPairBase<Utf8String, long> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value = source.Value;
			}
		}

		// Token: 0x06016D7F RID: 93567 RVA: 0x003568F4 File Offset: 0x00354AF4
		public static void CopyValues__AssetList_TextureImporterPlatformSettings_5_2_0__AccessListBase_ITextureImporterPlatformSettings(AssetList<TextureImporterPlatformSettings_5_2_0> target, AccessListBase<ITextureImporterPlatformSettings> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D80 RID: 93568 RVA: 0x0035693C File Offset: 0x00354B3C
		public static void CopyValues__AssetList_TextureImporterPlatformSettings_5_5_0__AccessListBase_ITextureImporterPlatformSettings(AssetList<TextureImporterPlatformSettings_5_5_0> target, AccessListBase<ITextureImporterPlatformSettings> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D81 RID: 93569 RVA: 0x00356984 File Offset: 0x00354B84
		public static void CopyValues__AssetList_TextureImporterPlatformSettings_2017_2_0__AccessListBase_ITextureImporterPlatformSettings(AssetList<TextureImporterPlatformSettings_2017_2_0> target, AccessListBase<ITextureImporterPlatformSettings> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D82 RID: 93570 RVA: 0x003569CC File Offset: 0x00354BCC
		public static void CopyValues__AssetList_TextureImporterPlatformSettings_2017_3_0__AccessListBase_ITextureImporterPlatformSettings(AssetList<TextureImporterPlatformSettings_2017_3_0> target, AccessListBase<ITextureImporterPlatformSettings> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D83 RID: 93571 RVA: 0x00356A14 File Offset: 0x00354C14
		public static void CopyValues__AssetList_TextureImporterPlatformSettings_2018_1_0__AccessListBase_ITextureImporterPlatformSettings(AssetList<TextureImporterPlatformSettings_2018_1_0> target, AccessListBase<ITextureImporterPlatformSettings> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D84 RID: 93572 RVA: 0x00356A5C File Offset: 0x00354C5C
		public static void CopyValues__AssetList_TextureImporterPlatformSettings_2019_2_0__AccessListBase_ITextureImporterPlatformSettings(AssetList<TextureImporterPlatformSettings_2019_2_0> target, AccessListBase<ITextureImporterPlatformSettings> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D85 RID: 93573 RVA: 0x00356AA4 File Offset: 0x00354CA4
		public static void CopyValues__AssetList_AssetPair_Utf8String_PPtr_Texture_3_4_0__AssetList_AssetPair_Utf8String_PPtr_Texture_3_4_0(AssetList<AssetPair<Utf8String, PPtr_Texture_3_4_0>> target, AssetList<AssetPair<Utf8String, PPtr_Texture_3_4_0>> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					CopyValuesHelper.CopyValues__AssetPair_Utf8String_PPtr_Texture_3_4_0__AssetPair_Utf8String_PPtr_Texture_3_4_0(target.AddNew(), source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D86 RID: 93574 RVA: 0x00356AEB File Offset: 0x00354CEB
		public static void CopyValues__AssetPair_Utf8String_PPtr_Texture_3_4_0__AssetPair_Utf8String_PPtr_Texture_3_4_0(AssetPair<Utf8String, PPtr_Texture_3_4_0> target, AssetPair<Utf8String, PPtr_Texture_3_4_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016D87 RID: 93575 RVA: 0x00356B14 File Offset: 0x00354D14
		public static void CopyValues__AssetList_AssetPair_Utf8String_PPtr_Texture_5_0_0__AssetList_AssetPair_Utf8String_PPtr_Texture_5_0_0(AssetList<AssetPair<Utf8String, PPtr_Texture_5_0_0>> target, AssetList<AssetPair<Utf8String, PPtr_Texture_5_0_0>> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					CopyValuesHelper.CopyValues__AssetPair_Utf8String_PPtr_Texture_5_0_0__AssetPair_Utf8String_PPtr_Texture_5_0_0(target.AddNew(), source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D88 RID: 93576 RVA: 0x00356B5B File Offset: 0x00354D5B
		public static void CopyValues__AssetPair_Utf8String_PPtr_Texture_5_0_0__AssetPair_Utf8String_PPtr_Texture_5_0_0(AssetPair<Utf8String, PPtr_Texture_5_0_0> target, AssetPair<Utf8String, PPtr_Texture_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016D89 RID: 93577 RVA: 0x00356B84 File Offset: 0x00354D84
		public static void CopyValues__AssetDictionary_Int32_SampleSettings_5_0_0__AccessDictionaryBase_Int32_ISampleSettings(AssetDictionary<int, SampleSettings_5_0_0> target, AccessDictionaryBase<int, ISampleSettings> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Int32_SampleSettings_5_0_0__AccessPairBase_Int32_ISampleSettings(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D8A RID: 93578 RVA: 0x00356BD1 File Offset: 0x00354DD1
		public static void CopyValues__AccessPairBase_Int32_SampleSettings_5_0_0__AccessPairBase_Int32_ISampleSettings(AccessPairBase<int, SampleSettings_5_0_0> target, AccessPairBase<int, ISampleSettings> source)
		{
			if (source != null)
			{
				target.Key = source.Key;
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016D8B RID: 93579 RVA: 0x00356BF4 File Offset: 0x00354DF4
		public static void CopyValues__AssetDictionary_Int32_SampleSettings_2022_2_0_a17__AccessDictionaryBase_Int32_ISampleSettings(AssetDictionary<int, SampleSettings_2022_2_0_a17> target, AccessDictionaryBase<int, ISampleSettings> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Int32_SampleSettings_2022_2_0_a17__AccessPairBase_Int32_ISampleSettings(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D8C RID: 93580 RVA: 0x00356C41 File Offset: 0x00354E41
		public static void CopyValues__AccessPairBase_Int32_SampleSettings_2022_2_0_a17__AccessPairBase_Int32_ISampleSettings(AccessPairBase<int, SampleSettings_2022_2_0_a17> target, AccessPairBase<int, ISampleSettings> source)
		{
			if (source != null)
			{
				target.Key = source.Key;
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016D8D RID: 93581 RVA: 0x00356C64 File Offset: 0x00354E64
		public static void CopyValues__AssetList_AssetPair_Utf8String_PPtr_Object_3_4_0__AssetList_AssetPair_Utf8String_PPtr_Object_3_4_0(AssetList<AssetPair<Utf8String, PPtr_Object_3_4_0>> target, AssetList<AssetPair<Utf8String, PPtr_Object_3_4_0>> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					CopyValuesHelper.CopyValues__AssetPair_Utf8String_PPtr_Object_3_4_0__AssetPair_Utf8String_PPtr_Object_3_4_0(target.AddNew(), source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D8E RID: 93582 RVA: 0x00356CAB File Offset: 0x00354EAB
		public static void CopyValues__AssetPair_Utf8String_PPtr_Object_3_4_0__AssetPair_Utf8String_PPtr_Object_3_4_0(AssetPair<Utf8String, PPtr_Object_3_4_0> target, AssetPair<Utf8String, PPtr_Object_3_4_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016D8F RID: 93583 RVA: 0x00356CD4 File Offset: 0x00354ED4
		public static void CopyValues__AssetList_AssetPair_Utf8String_PPtr_Object_5_0_0__AssetList_AssetPair_Utf8String_PPtr_Object_5_0_0(AssetList<AssetPair<Utf8String, PPtr_Object_5_0_0>> target, AssetList<AssetPair<Utf8String, PPtr_Object_5_0_0>> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					CopyValuesHelper.CopyValues__AssetPair_Utf8String_PPtr_Object_5_0_0__AssetPair_Utf8String_PPtr_Object_5_0_0(target.AddNew(), source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D90 RID: 93584 RVA: 0x00356D1B File Offset: 0x00354F1B
		public static void CopyValues__AssetPair_Utf8String_PPtr_Object_5_0_0__AssetPair_Utf8String_PPtr_Object_5_0_0(AssetPair<Utf8String, PPtr_Object_5_0_0> target, AssetPair<Utf8String, PPtr_Object_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016D91 RID: 93585 RVA: 0x00356D44 File Offset: 0x00354F44
		public static void CopyValues__AssetDictionary_GUID_DeletedItem_3_4_0__AccessDictionaryBase_GUID_IDeletedItem(AssetDictionary<GUID, DeletedItem_3_4_0> target, AccessDictionaryBase<GUID, IDeletedItem> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_GUID_DeletedItem_3_4_0__AccessPairBase_GUID_IDeletedItem(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D92 RID: 93586 RVA: 0x00356D91 File Offset: 0x00354F91
		public static void CopyValues__AccessPairBase_GUID_DeletedItem_3_4_0__AccessPairBase_GUID_IDeletedItem(AccessPairBase<GUID, DeletedItem_3_4_0> target, AccessPairBase<GUID, IDeletedItem> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016D93 RID: 93587 RVA: 0x00356DB8 File Offset: 0x00354FB8
		public static void CopyValues__AssetDictionary_GUID_Item__AssetDictionary_GUID_Item(AssetDictionary<GUID, Item> target, AssetDictionary<GUID, Item> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_GUID_Item__AccessPairBase_GUID_Item(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D94 RID: 93588 RVA: 0x00356E05 File Offset: 0x00355005
		public static void CopyValues__AccessPairBase_GUID_Item__AccessPairBase_GUID_Item(AccessPairBase<GUID, Item> target, AccessPairBase<GUID, Item> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016D95 RID: 93589 RVA: 0x00356E2C File Offset: 0x0035502C
		public static void CopyValues__AssetDictionary_GUID_ModifiedItem_3_4_0__AccessDictionaryBase_GUID_IModifiedItem(AssetDictionary<GUID, ModifiedItem_3_4_0> target, AccessDictionaryBase<GUID, IModifiedItem> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_GUID_ModifiedItem_3_4_0__AccessPairBase_GUID_IModifiedItem(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D96 RID: 93590 RVA: 0x00356E79 File Offset: 0x00355079
		public static void CopyValues__AccessPairBase_GUID_ModifiedItem_3_4_0__AccessPairBase_GUID_IModifiedItem(AccessPairBase<GUID, ModifiedItem_3_4_0> target, AccessPairBase<GUID, IModifiedItem> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016D97 RID: 93591 RVA: 0x00356EA0 File Offset: 0x003550A0
		public static void CopyValues__AssetDictionary_GUID_CachedAssetMetaData_3_4_0__AccessDictionaryBase_GUID_ICachedAssetMetaData(AssetDictionary<GUID, CachedAssetMetaData_3_4_0> target, AccessDictionaryBase<GUID, ICachedAssetMetaData> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_GUID_CachedAssetMetaData_3_4_0__AccessPairBase_GUID_ICachedAssetMetaData(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D98 RID: 93592 RVA: 0x00356EED File Offset: 0x003550ED
		public static void CopyValues__AccessPairBase_GUID_CachedAssetMetaData_3_4_0__AccessPairBase_GUID_ICachedAssetMetaData(AccessPairBase<GUID, CachedAssetMetaData_3_4_0> target, AccessPairBase<GUID, ICachedAssetMetaData> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016D99 RID: 93593 RVA: 0x00356F14 File Offset: 0x00355114
		public static void CopyValues__AssetDictionary_GUID_DeletedItem_5_0_0__AccessDictionaryBase_GUID_IDeletedItem(AssetDictionary<GUID, DeletedItem_5_0_0> target, AccessDictionaryBase<GUID, IDeletedItem> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_GUID_DeletedItem_5_0_0__AccessPairBase_GUID_IDeletedItem(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D9A RID: 93594 RVA: 0x00356F61 File Offset: 0x00355161
		public static void CopyValues__AccessPairBase_GUID_DeletedItem_5_0_0__AccessPairBase_GUID_IDeletedItem(AccessPairBase<GUID, DeletedItem_5_0_0> target, AccessPairBase<GUID, IDeletedItem> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016D9B RID: 93595 RVA: 0x00356F88 File Offset: 0x00355188
		public static void CopyValues__AssetDictionary_GUID_ModifiedItem_5_0_0__AccessDictionaryBase_GUID_IModifiedItem(AssetDictionary<GUID, ModifiedItem_5_0_0> target, AccessDictionaryBase<GUID, IModifiedItem> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_GUID_ModifiedItem_5_0_0__AccessPairBase_GUID_IModifiedItem(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D9C RID: 93596 RVA: 0x00356FD5 File Offset: 0x003551D5
		public static void CopyValues__AccessPairBase_GUID_ModifiedItem_5_0_0__AccessPairBase_GUID_IModifiedItem(AccessPairBase<GUID, ModifiedItem_5_0_0> target, AccessPairBase<GUID, IModifiedItem> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016D9D RID: 93597 RVA: 0x00356FFC File Offset: 0x003551FC
		public static void CopyValues__AssetDictionary_GUID_CachedAssetMetaData_5_0_0__AccessDictionaryBase_GUID_ICachedAssetMetaData(AssetDictionary<GUID, CachedAssetMetaData_5_0_0> target, AccessDictionaryBase<GUID, ICachedAssetMetaData> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_GUID_CachedAssetMetaData_5_0_0__AccessPairBase_GUID_ICachedAssetMetaData(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016D9E RID: 93598 RVA: 0x00357049 File Offset: 0x00355249
		public static void CopyValues__AccessPairBase_GUID_CachedAssetMetaData_5_0_0__AccessPairBase_GUID_ICachedAssetMetaData(AccessPairBase<GUID, CachedAssetMetaData_5_0_0> target, AccessPairBase<GUID, ICachedAssetMetaData> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016D9F RID: 93599 RVA: 0x00357070 File Offset: 0x00355270
		public static void CopyValues__AssetList_PPtr_Font_5_0_0__AssetList_PPtr_Font_5_0_0(AssetList<PPtr_Font_5_0_0> target, AssetList<PPtr_Font_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DA0 RID: 93600 RVA: 0x003570B8 File Offset: 0x003552B8
		public static void CopyValues__AssetList_Scene_3_4_0__AccessListBase_IScene(AssetList<Scene_3_4_0> target, AccessListBase<IScene> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DA1 RID: 93601 RVA: 0x00357100 File Offset: 0x00355300
		public static void CopyValues__AssetList_Scene_5_6_0_b10__AccessListBase_IScene(AssetList<Scene_5_6_0_b10> target, AccessListBase<IScene> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DA2 RID: 93602 RVA: 0x00357148 File Offset: 0x00355348
		public static void CopyValues__AssetList_ExpandedData_3_4_0__AccessListBase_IExpandedData(AssetList<ExpandedData_3_4_0> target, AccessListBase<IExpandedData> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DA3 RID: 93603 RVA: 0x00357190 File Offset: 0x00355390
		public static void CopyValues__AssetList_ExpandedData_5_6_0__AccessListBase_IExpandedData(AssetList<ExpandedData_5_6_0> target, AccessListBase<IExpandedData> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DA4 RID: 93604 RVA: 0x003571D8 File Offset: 0x003553D8
		public static void CopyValues__AssetList_ExpandedData_2017_1_0__AccessListBase_IExpandedData(AssetList<ExpandedData_2017_1_0> target, AccessListBase<IExpandedData> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DA5 RID: 93605 RVA: 0x00357220 File Offset: 0x00355420
		public static void CopyValues__AssetList_Annotation_3_4_0__AccessListBase_IAnnotation(AssetList<Annotation_3_4_0> target, AccessListBase<IAnnotation> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DA6 RID: 93606 RVA: 0x00357268 File Offset: 0x00355468
		public static void CopyValues__AssetList_Annotation_5_6_0__AccessListBase_IAnnotation(AssetList<Annotation_5_6_0> target, AccessListBase<IAnnotation> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DA7 RID: 93607 RVA: 0x003572B0 File Offset: 0x003554B0
		public static void CopyValues__AssetDictionary_Utf8String_PPtr_Texture2D_3_4_0__AccessDictionaryBase_Utf8String_IPPtr_Texture2D(AssetDictionary<Utf8String, PPtr_Texture2D_3_4_0> target, AccessDictionaryBase<Utf8String, IPPtr_Texture2D> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_PPtr_Texture2D_3_4_0__AccessPairBase_Utf8String_IPPtr_Texture2D(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DA8 RID: 93608 RVA: 0x003572FE File Offset: 0x003554FE
		public static void CopyValues__AccessPairBase_Utf8String_PPtr_Texture2D_3_4_0__AccessPairBase_Utf8String_IPPtr_Texture2D(AccessPairBase<Utf8String, PPtr_Texture2D_3_4_0> target, AccessPairBase<Utf8String, IPPtr_Texture2D> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016DA9 RID: 93609 RVA: 0x00357328 File Offset: 0x00355528
		public static void CopyValues__AssetDictionary_Utf8String_PPtr_Texture2D_5_0_0__AccessDictionaryBase_Utf8String_IPPtr_Texture2D(AssetDictionary<Utf8String, PPtr_Texture2D_5_0_0> target, AccessDictionaryBase<Utf8String, IPPtr_Texture2D> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_PPtr_Texture2D_5_0_0__AccessPairBase_Utf8String_IPPtr_Texture2D(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DAA RID: 93610 RVA: 0x00357376 File Offset: 0x00355576
		public static void CopyValues__AccessPairBase_Utf8String_PPtr_Texture2D_5_0_0__AccessPairBase_Utf8String_IPPtr_Texture2D(AccessPairBase<Utf8String, PPtr_Texture2D_5_0_0> target, AccessPairBase<Utf8String, IPPtr_Texture2D> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016DAB RID: 93611 RVA: 0x003573A0 File Offset: 0x003555A0
		public static void CopyValues__AssetDictionary_Utf8String_PlatformSettingsData_Plugin__AssetDictionary_Utf8String_PlatformSettingsData_Plugin(AssetDictionary<Utf8String, PlatformSettingsData_Plugin> target, AssetDictionary<Utf8String, PlatformSettingsData_Plugin> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_PlatformSettingsData_Plugin__AccessPairBase_Utf8String_PlatformSettingsData_Plugin(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DAC RID: 93612 RVA: 0x003573ED File Offset: 0x003555ED
		public static void CopyValues__AccessPairBase_Utf8String_PlatformSettingsData_Plugin__AccessPairBase_Utf8String_PlatformSettingsData_Plugin(AccessPairBase<Utf8String, PlatformSettingsData_Plugin> target, AccessPairBase<Utf8String, PlatformSettingsData_Plugin> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016DAD RID: 93613 RVA: 0x00357414 File Offset: 0x00355614
		public static void CopyValues__AssetDictionary_AssetPair_Utf8String_Utf8String_PlatformSettingsData_Plugin__AssetDictionary_AssetPair_Utf8String_Utf8String_PlatformSettingsData_Plugin(AssetDictionary<AssetPair<Utf8String, Utf8String>, PlatformSettingsData_Plugin> target, AssetDictionary<AssetPair<Utf8String, Utf8String>, PlatformSettingsData_Plugin> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_AssetPair_Utf8String_Utf8String_PlatformSettingsData_Plugin__AccessPairBase_AssetPair_Utf8String_Utf8String_PlatformSettingsData_Plugin(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DAE RID: 93614 RVA: 0x00357461 File Offset: 0x00355661
		public static void CopyValues__AccessPairBase_AssetPair_Utf8String_Utf8String_PlatformSettingsData_Plugin__AccessPairBase_AssetPair_Utf8String_Utf8String_PlatformSettingsData_Plugin(AccessPairBase<AssetPair<Utf8String, Utf8String>, PlatformSettingsData_Plugin> target, AccessPairBase<AssetPair<Utf8String, Utf8String>, PlatformSettingsData_Plugin> source)
		{
			if (source != null)
			{
				CopyValuesHelper.CopyValues__AssetPair_Utf8String_Utf8String__AssetPair_Utf8String_Utf8String(target.Key, source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016DAF RID: 93615 RVA: 0x00357488 File Offset: 0x00355688
		public static void CopyValues__AssetPair_Utf8String_Utf8String__AssetPair_Utf8String_Utf8String(AssetPair<Utf8String, Utf8String> target, AssetPair<Utf8String, Utf8String> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016DB0 RID: 93616 RVA: 0x003574B0 File Offset: 0x003556B0
		public static void CopyValues__AssetDictionary_Utf8String_PlatformSettingsData_Editor__AssetDictionary_Utf8String_PlatformSettingsData_Editor(AssetDictionary<Utf8String, PlatformSettingsData_Editor> target, AssetDictionary<Utf8String, PlatformSettingsData_Editor> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_PlatformSettingsData_Editor__AccessPairBase_Utf8String_PlatformSettingsData_Editor(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DB1 RID: 93617 RVA: 0x003574FD File Offset: 0x003556FD
		public static void CopyValues__AccessPairBase_Utf8String_PlatformSettingsData_Editor__AccessPairBase_Utf8String_PlatformSettingsData_Editor(AccessPairBase<Utf8String, PlatformSettingsData_Editor> target, AccessPairBase<Utf8String, PlatformSettingsData_Editor> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016DB2 RID: 93618 RVA: 0x00357524 File Offset: 0x00355724
		public static void CopyValues__AssetList_MaterialInstanceSettings_3_4_0__AccessListBase_IMaterialInstanceSettings(AssetList<MaterialInstanceSettings_3_4_0> target, AccessListBase<IMaterialInstanceSettings> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DB3 RID: 93619 RVA: 0x0035756C File Offset: 0x0035576C
		public static void CopyValues__AssetList_TextureImporterPlatformSettings_3_4_0__AssetList_TextureImporterPlatformSettings_3_4_0(AssetList<TextureImporterPlatformSettings_3_4_0> target, AssetList<TextureImporterPlatformSettings_3_4_0> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DB4 RID: 93620 RVA: 0x003575B4 File Offset: 0x003557B4
		public static void CopyValues__AssetList_InputImportSettings_SubstanceValue_3_4_0__AccessListBase_IInputImportSettings_SubstanceValue(AssetList<InputImportSettings_SubstanceValue_3_4_0> target, AccessListBase<IInputImportSettings_SubstanceValue> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DB5 RID: 93621 RVA: 0x003575FC File Offset: 0x003557FC
		public static void CopyValues__AssetList_InputImportSettings__AssetList_InputImportSettings(AssetList<InputImportSettings> target, AssetList<InputImportSettings> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DB6 RID: 93622 RVA: 0x00357644 File Offset: 0x00355844
		public static void CopyValues__AssetList_BuildTargetSettings_Material_3_5_0__AssetList_BuildTargetSettings_Material_3_5_0(AssetList<BuildTargetSettings_Material_3_5_0> target, AssetList<BuildTargetSettings_Material_3_5_0> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DB7 RID: 93623 RVA: 0x0035768C File Offset: 0x0035588C
		public static void CopyValues__AssetList_BuildTargetSettings_Material_4_0_0__AssetList_BuildTargetSettings_Material_4_0_0(AssetList<BuildTargetSettings_Material_4_0_0> target, AssetList<BuildTargetSettings_Material_4_0_0> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DB8 RID: 93624 RVA: 0x003576D4 File Offset: 0x003558D4
		public static void CopyValues__AssetList_ProceduralTextureAssignment_4_5_0__AccessListBase_IProceduralTextureAssignment(AssetList<ProceduralTextureAssignment_4_5_0> target, AccessListBase<IProceduralTextureAssignment> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DB9 RID: 93625 RVA: 0x0035771C File Offset: 0x0035591C
		public static void CopyValues__AssetList_InputImportSettings_SubstanceValue_5_0_0__AccessListBase_IInputImportSettings_SubstanceValue(AssetList<InputImportSettings_SubstanceValue_5_0_0> target, AccessListBase<IInputImportSettings_SubstanceValue> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DBA RID: 93626 RVA: 0x00357764 File Offset: 0x00355964
		public static void CopyValues__AssetList_ProceduralTextureAssignment_5_0_0__AccessListBase_IProceduralTextureAssignment(AssetList<ProceduralTextureAssignment_5_0_0> target, AccessListBase<IProceduralTextureAssignment> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DBB RID: 93627 RVA: 0x003577AC File Offset: 0x003559AC
		public static void CopyValues__AssetList_ProceduralTextureAssignment_5_6_0__AccessListBase_IProceduralTextureAssignment(AssetList<ProceduralTextureAssignment_5_6_0> target, AccessListBase<IProceduralTextureAssignment> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DBC RID: 93628 RVA: 0x003577F4 File Offset: 0x003559F4
		public static void CopyValues__AssetList_InputImportSettings_SubstanceValue_2017_2_0_b4__AccessListBase_IInputImportSettings_SubstanceValue(AssetList<InputImportSettings_SubstanceValue_2017_2_0_b4> target, AccessListBase<IInputImportSettings_SubstanceValue> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DBD RID: 93629 RVA: 0x0035783C File Offset: 0x00355A3C
		public static void CopyValues__AssetList_MaterialInstanceSettings_3_5_0__AccessListBase_IMaterialInstanceSettings(AssetList<MaterialInstanceSettings_3_5_0> target, AccessListBase<IMaterialInstanceSettings> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DBE RID: 93630 RVA: 0x00357884 File Offset: 0x00355A84
		public static void CopyValues__AssetList_MaterialImportOutput_4_0_0__AccessListBase_IMaterialImportOutput(AssetList<MaterialImportOutput_4_0_0> target, AccessListBase<IMaterialImportOutput> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DBF RID: 93631 RVA: 0x003578CC File Offset: 0x00355ACC
		public static void CopyValues__AssetList_MaterialInstanceSettings_4_0_0__AccessListBase_IMaterialInstanceSettings(AssetList<MaterialInstanceSettings_4_0_0> target, AccessListBase<IMaterialInstanceSettings> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DC0 RID: 93632 RVA: 0x00357914 File Offset: 0x00355B14
		public static void CopyValues__AssetList_MaterialImportOutput_4_1_0__AccessListBase_IMaterialImportOutput(AssetList<MaterialImportOutput_4_1_0> target, AccessListBase<IMaterialImportOutput> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DC1 RID: 93633 RVA: 0x0035795C File Offset: 0x00355B5C
		public static void CopyValues__AssetList_MaterialInstanceSettings_4_1_0__AccessListBase_IMaterialInstanceSettings(AssetList<MaterialInstanceSettings_4_1_0> target, AccessListBase<IMaterialInstanceSettings> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DC2 RID: 93634 RVA: 0x003579A4 File Offset: 0x00355BA4
		public static void CopyValues__AssetList_MaterialImportOutput_4_2_0__AccessListBase_IMaterialImportOutput(AssetList<MaterialImportOutput_4_2_0> target, AccessListBase<IMaterialImportOutput> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DC3 RID: 93635 RVA: 0x003579EC File Offset: 0x00355BEC
		public static void CopyValues__AssetList_MaterialInstanceSettings_4_2_0__AccessListBase_IMaterialInstanceSettings(AssetList<MaterialInstanceSettings_4_2_0> target, AccessListBase<IMaterialInstanceSettings> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DC4 RID: 93636 RVA: 0x00357A34 File Offset: 0x00355C34
		public static void CopyValues__AssetList_MaterialImportOutput_4_3_0__AccessListBase_IMaterialImportOutput(AssetList<MaterialImportOutput_4_3_0> target, AccessListBase<IMaterialImportOutput> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DC5 RID: 93637 RVA: 0x00357A7C File Offset: 0x00355C7C
		public static void CopyValues__AssetList_MaterialInstanceSettings_4_3_0__AccessListBase_IMaterialInstanceSettings(AssetList<MaterialInstanceSettings_4_3_0> target, AccessListBase<IMaterialInstanceSettings> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DC6 RID: 93638 RVA: 0x00357AC4 File Offset: 0x00355CC4
		public static void CopyValues__AssetList_MaterialInstanceSettings_4_5_0__AccessListBase_IMaterialInstanceSettings(AssetList<MaterialInstanceSettings_4_5_0> target, AccessListBase<IMaterialInstanceSettings> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DC7 RID: 93639 RVA: 0x00357B0C File Offset: 0x00355D0C
		public static void CopyValues__AssetList_MaterialInstanceSettings_5_0_0__AccessListBase_IMaterialInstanceSettings(AssetList<MaterialInstanceSettings_5_0_0> target, AccessListBase<IMaterialInstanceSettings> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DC8 RID: 93640 RVA: 0x00357B54 File Offset: 0x00355D54
		public static void CopyValues__AssetList_MaterialInstanceSettings_5_0_2__AccessListBase_IMaterialInstanceSettings(AssetList<MaterialInstanceSettings_5_0_2> target, AccessListBase<IMaterialInstanceSettings> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DC9 RID: 93641 RVA: 0x00357B9C File Offset: 0x00355D9C
		public static void CopyValues__AssetList_MaterialInstanceSettings_5_3_4__AccessListBase_IMaterialInstanceSettings(AssetList<MaterialInstanceSettings_5_3_4> target, AccessListBase<IMaterialInstanceSettings> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DCA RID: 93642 RVA: 0x00357BE4 File Offset: 0x00355DE4
		public static void CopyValues__AssetList_MaterialInstanceSettings_5_6_0__AccessListBase_IMaterialInstanceSettings(AssetList<MaterialInstanceSettings_5_6_0> target, AccessListBase<IMaterialInstanceSettings> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DCB RID: 93643 RVA: 0x00357C2C File Offset: 0x00355E2C
		public static void CopyValues__AssetList_MaterialInstanceSettings_2017_1_0__AccessListBase_IMaterialInstanceSettings(AssetList<MaterialInstanceSettings_2017_1_0> target, AccessListBase<IMaterialInstanceSettings> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DCC RID: 93644 RVA: 0x00357C74 File Offset: 0x00355E74
		public static void CopyValues__AssetList_MaterialInstanceSettings_2017_2_0_b4__AccessListBase_IMaterialInstanceSettings(AssetList<MaterialInstanceSettings_2017_2_0_b4> target, AccessListBase<IMaterialInstanceSettings> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DCD RID: 93645 RVA: 0x00357CBC File Offset: 0x00355EBC
		public static void CopyValues__AssetList_NavMeshAreaData__AssetList_NavMeshAreaData(AssetList<NavMeshAreaData> target, AssetList<NavMeshAreaData> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DCE RID: 93646 RVA: 0x00357D04 File Offset: 0x00355F04
		public static void CopyValues__AssetList_NavMeshBuildSettings_5_6_0__AccessListBase_INavMeshBuildSettings(AssetList<NavMeshBuildSettings_5_6_0> target, AccessListBase<INavMeshBuildSettings> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DCF RID: 93647 RVA: 0x00357D4C File Offset: 0x00355F4C
		public static void CopyValues__AssetList_NavMeshBuildSettings_5_6_0_f2__AccessListBase_INavMeshBuildSettings(AssetList<NavMeshBuildSettings_5_6_0_f2> target, AccessListBase<INavMeshBuildSettings> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DD0 RID: 93648 RVA: 0x00357D94 File Offset: 0x00355F94
		public static void CopyValues__AssetList_NavMeshBuildSettings_2017_2_0__AccessListBase_INavMeshBuildSettings(AssetList<NavMeshBuildSettings_2017_2_0> target, AccessListBase<INavMeshBuildSettings> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DD1 RID: 93649 RVA: 0x00357DDC File Offset: 0x00355FDC
		public static void CopyValues__AssetList_NavMeshBuildSettings_2020_1_0_a23__AccessListBase_INavMeshBuildSettings(AssetList<NavMeshBuildSettings_2020_1_0_a23> target, AccessListBase<INavMeshBuildSettings> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DD2 RID: 93650 RVA: 0x00357E24 File Offset: 0x00356024
		public static void CopyValues__AssetList_NavMeshBuildSettings_2020_1_0_a24__AccessListBase_INavMeshBuildSettings(AssetList<NavMeshBuildSettings_2020_1_0_a24> target, AccessListBase<INavMeshBuildSettings> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DD3 RID: 93651 RVA: 0x00357E6C File Offset: 0x0035606C
		public static void CopyValues__AssetList_NavMeshBuildSettings_2022_2_0__AccessListBase_INavMeshBuildSettings(AssetList<NavMeshBuildSettings_2022_2_0> target, AccessListBase<INavMeshBuildSettings> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DD4 RID: 93652 RVA: 0x00357EB4 File Offset: 0x003560B4
		public static void CopyValues__AssetDictionary_Utf8String_ConfigSetting__AssetDictionary_Utf8String_ConfigSetting(AssetDictionary<Utf8String, ConfigSetting> target, AssetDictionary<Utf8String, ConfigSetting> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_ConfigSetting__AccessPairBase_Utf8String_ConfigSetting(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DD5 RID: 93653 RVA: 0x00357F01 File Offset: 0x00356101
		public static void CopyValues__AccessPairBase_Utf8String_ConfigSetting__AccessPairBase_Utf8String_ConfigSetting(AccessPairBase<Utf8String, ConfigSetting> target, AccessPairBase<Utf8String, ConfigSetting> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016DD6 RID: 93654 RVA: 0x00357F28 File Offset: 0x00356128
		public static void CopyValues__AssetList_HeightmapData_3_5_0__AssetList_HeightmapData_3_5_0(AssetList<HeightmapData_3_5_0> target, AssetList<HeightmapData_3_5_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DD7 RID: 93655 RVA: 0x00357F70 File Offset: 0x00356170
		public static void CopyValues__AssetList_SphericalHarmonicsL2_3_5_0__AssetList_SphericalHarmonicsL2_3_5_0(AssetList<SphericalHarmonicsL2_3_5_0> target, AssetList<SphericalHarmonicsL2_3_5_0> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DD8 RID: 93656 RVA: 0x00357FB8 File Offset: 0x003561B8
		public static void CopyValues__AssetList_Tetrahedron_3_5_0__AssetList_Tetrahedron_3_5_0(AssetList<Tetrahedron_3_5_0> target, AssetList<Tetrahedron_3_5_0> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DD9 RID: 93657 RVA: 0x00358000 File Offset: 0x00356200
		public static void CopyValues__AssetList_PPtr_Transform_5_0_0__AssetList_PPtr_Transform_5_0_0(AssetList<PPtr_Transform_5_0_0> target, AssetList<PPtr_Transform_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DDA RID: 93658 RVA: 0x00358048 File Offset: 0x00356248
		public static void CopyValues__AssetList_ParticleSystemEmissionBurst_5_6_0_b5__AccessListBase_IParticleSystemEmissionBurst(AssetList<ParticleSystemEmissionBurst_5_6_0_b5> target, AccessListBase<IParticleSystemEmissionBurst> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DDB RID: 93659 RVA: 0x00358090 File Offset: 0x00356290
		public static void CopyValues__AssetList_ParticleSystemEmissionBurst_2017_2_0__AccessListBase_IParticleSystemEmissionBurst(AssetList<ParticleSystemEmissionBurst_2017_2_0> target, AccessListBase<IParticleSystemEmissionBurst> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DDC RID: 93660 RVA: 0x003580D8 File Offset: 0x003562D8
		public static void CopyValues__AssetList_ParticleSystemEmissionBurst_2017_3_0__AccessListBase_IParticleSystemEmissionBurst(AssetList<ParticleSystemEmissionBurst_2017_3_0> target, AccessListBase<IParticleSystemEmissionBurst> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DDD RID: 93661 RVA: 0x00358120 File Offset: 0x00356320
		public static void CopyValues__AssetList_ParticleSystemEmissionBurst_2018_1_0__AccessListBase_IParticleSystemEmissionBurst(AssetList<ParticleSystemEmissionBurst_2018_1_0> target, AccessListBase<IParticleSystemEmissionBurst> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DDE RID: 93662 RVA: 0x00358168 File Offset: 0x00356368
		public static void CopyValues__AssetList_ParticleSystemEmissionBurst_2018_3_0__AccessListBase_IParticleSystemEmissionBurst(AssetList<ParticleSystemEmissionBurst_2018_3_0> target, AccessListBase<IParticleSystemEmissionBurst> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DDF RID: 93663 RVA: 0x003581B0 File Offset: 0x003563B0
		public static void CopyValues__AssetList_SubEmitterData_5_5_0__AccessListBase_ISubEmitterData(AssetList<SubEmitterData_5_5_0> target, AccessListBase<ISubEmitterData> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DE0 RID: 93664 RVA: 0x003581F8 File Offset: 0x003563F8
		public static void CopyValues__AssetList_SubEmitterData_2017_2_0_b7__AccessListBase_ISubEmitterData(AssetList<SubEmitterData_2017_2_0_b7> target, AccessListBase<ISubEmitterData> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DE1 RID: 93665 RVA: 0x00358240 File Offset: 0x00356440
		public static void CopyValues__AssetList_SubEmitterData_2018_3_0__AccessListBase_ISubEmitterData(AssetList<SubEmitterData_2018_3_0> target, AccessListBase<ISubEmitterData> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DE2 RID: 93666 RVA: 0x00358288 File Offset: 0x00356488
		public static void CopyValues__AssetList_SubEmitterData_2018_3_0_b8__AccessListBase_ISubEmitterData(AssetList<SubEmitterData_2018_3_0_b8> target, AccessListBase<ISubEmitterData> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DE3 RID: 93667 RVA: 0x003582D0 File Offset: 0x003564D0
		public static void CopyValues__AssetList_SpriteData__AssetList_SpriteData(AssetList<SpriteData> target, AssetList<SpriteData> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DE4 RID: 93668 RVA: 0x00358318 File Offset: 0x00356518
		public static void CopyValues__AssetList_PPtr_ParticleSystemForceField__AssetList_PPtr_ParticleSystemForceField(AssetList<PPtr_ParticleSystemForceField> target, AssetList<PPtr_ParticleSystemForceField> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DE5 RID: 93669 RVA: 0x00358360 File Offset: 0x00356560
		public static void CopyValues__AssetList_LOD_3_5_0__AccessListBase_ILOD(AssetList<LOD_3_5_0> target, AccessListBase<ILOD> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DE6 RID: 93670 RVA: 0x003583A8 File Offset: 0x003565A8
		public static void CopyValues__AssetList_LODRenderer_3_5_0__AccessListBase_ILODRenderer(AssetList<LODRenderer_3_5_0> target, AccessListBase<ILODRenderer> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DE7 RID: 93671 RVA: 0x003583F0 File Offset: 0x003565F0
		public static void CopyValues__AssetList_LODRenderer_5_0_0__AccessListBase_ILODRenderer(AssetList<LODRenderer_5_0_0> target, AccessListBase<ILODRenderer> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DE8 RID: 93672 RVA: 0x00358438 File Offset: 0x00356638
		public static void CopyValues__AssetList_LOD_5_0_0__AccessListBase_ILOD(AssetList<LOD_5_0_0> target, AccessListBase<ILOD> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DE9 RID: 93673 RVA: 0x00358480 File Offset: 0x00356680
		public static void CopyValues__AssetList_LOD_5_1_0__AccessListBase_ILOD(AssetList<LOD_5_1_0> target, AccessListBase<ILOD> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DEA RID: 93674 RVA: 0x003584C8 File Offset: 0x003566C8
		public static void CopyValues__AssetList_LOD_2017_1_0__AccessListBase_ILOD(AssetList<LOD_2017_1_0> target, AccessListBase<ILOD> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DEB RID: 93675 RVA: 0x00358510 File Offset: 0x00356710
		public static void CopyValues__AssetList_ComputeShaderCB_4_0_0__AssetList_ComputeShaderCB_4_0_0(AssetList<ComputeShaderCB_4_0_0> target, AssetList<ComputeShaderCB_4_0_0> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DEC RID: 93676 RVA: 0x00358558 File Offset: 0x00356758
		public static void CopyValues__AssetList_ComputeShaderParam_4_0_0__AccessListBase_IComputeShaderParam(AssetList<ComputeShaderParam_4_0_0> target, AccessListBase<IComputeShaderParam> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DED RID: 93677 RVA: 0x003585A0 File Offset: 0x003567A0
		public static void CopyValues__AssetList_ComputeShaderParam_5_6_0__AccessListBase_IComputeShaderParam(AssetList<ComputeShaderParam_5_6_0> target, AccessListBase<IComputeShaderParam> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DEE RID: 93678 RVA: 0x003585E8 File Offset: 0x003567E8
		public static void CopyValues__AssetList_ComputeShaderParam_2020_1_0_a9__AccessListBase_IComputeShaderParam(AssetList<ComputeShaderParam_2020_1_0_a9> target, AccessListBase<IComputeShaderParam> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DEF RID: 93679 RVA: 0x00358630 File Offset: 0x00356830
		public static void CopyValues__AssetList_ComputeShaderKernel_4_0_0__AssetList_ComputeShaderKernel_4_0_0(AssetList<ComputeShaderKernel_4_0_0> target, AssetList<ComputeShaderKernel_4_0_0> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DF0 RID: 93680 RVA: 0x00358678 File Offset: 0x00356878
		public static void CopyValues__AssetList_ComputeShaderBuiltinSampler_4_0_0__AccessListBase_IComputeShaderBuiltinSampler(AssetList<ComputeShaderBuiltinSampler_4_0_0> target, AccessListBase<IComputeShaderBuiltinSampler> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DF1 RID: 93681 RVA: 0x003586C0 File Offset: 0x003568C0
		public static void CopyValues__AssetList_ComputeShaderResource_4_0_0__AccessListBase_IComputeShaderResource(AssetList<ComputeShaderResource_4_0_0> target, AccessListBase<IComputeShaderResource> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DF2 RID: 93682 RVA: 0x00358708 File Offset: 0x00356908
		public static void CopyValues__AssetList_ComputeShaderResource_5_1_0__AccessListBase_IComputeShaderResource(AssetList<ComputeShaderResource_5_1_0> target, AccessListBase<IComputeShaderResource> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DF3 RID: 93683 RVA: 0x00358750 File Offset: 0x00356950
		public static void CopyValues__AssetList_ComputeShaderResource_5_2_3__AccessListBase_IComputeShaderResource(AssetList<ComputeShaderResource_5_2_3> target, AccessListBase<IComputeShaderResource> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DF4 RID: 93684 RVA: 0x00358798 File Offset: 0x00356998
		public static void CopyValues__AssetList_ComputeShaderResource_5_6_0__AccessListBase_IComputeShaderResource(AssetList<ComputeShaderResource_5_6_0> target, AccessListBase<IComputeShaderResource> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DF5 RID: 93685 RVA: 0x003587E0 File Offset: 0x003569E0
		public static void CopyValues__AssetList_ComputeShaderBuiltinSampler_2017_1_0__AccessListBase_IComputeShaderBuiltinSampler(AssetList<ComputeShaderBuiltinSampler_2017_1_0> target, AccessListBase<IComputeShaderBuiltinSampler> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DF6 RID: 93686 RVA: 0x00358828 File Offset: 0x00356A28
		public static void CopyValues__AssetList_ComputeShaderResource_2018_1_0__AccessListBase_IComputeShaderResource(AssetList<ComputeShaderResource_2018_1_0> target, AccessListBase<IComputeShaderResource> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DF7 RID: 93687 RVA: 0x00358870 File Offset: 0x00356A70
		public static void CopyValues__AssetList_ComputeShaderResource_2018_2_0__AccessListBase_IComputeShaderResource(AssetList<ComputeShaderResource_2018_2_0> target, AccessListBase<IComputeShaderResource> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DF8 RID: 93688 RVA: 0x003588B8 File Offset: 0x00356AB8
		public static void CopyValues__AssetList_ComputeShaderResource_2018_2_0_b9__AccessListBase_IComputeShaderResource(AssetList<ComputeShaderResource_2018_2_0_b9> target, AccessListBase<IComputeShaderResource> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DF9 RID: 93689 RVA: 0x00358900 File Offset: 0x00356B00
		public static void CopyValues__AssetList_ComputeShaderVariant_5_0_0__AccessListBase_IComputeShaderVariant(AssetList<ComputeShaderVariant_5_0_0> target, AccessListBase<IComputeShaderVariant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DFA RID: 93690 RVA: 0x00358948 File Offset: 0x00356B48
		public static void CopyValues__AssetList_ComputeShaderCB_4_0_0__AccessListBase_IComputeShaderCB(AssetList<ComputeShaderCB_4_0_0> target, AccessListBase<IComputeShaderCB> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DFB RID: 93691 RVA: 0x00358990 File Offset: 0x00356B90
		public static void CopyValues__AssetList_ComputeShaderKernel_4_0_0__AccessListBase_IComputeShaderKernel(AssetList<ComputeShaderKernel_4_0_0> target, AccessListBase<IComputeShaderKernel> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DFC RID: 93692 RVA: 0x003589D8 File Offset: 0x00356BD8
		public static void CopyValues__AssetList_ComputeShaderKernel_5_1_0__AccessListBase_IComputeShaderKernel(AssetList<ComputeShaderKernel_5_1_0> target, AccessListBase<IComputeShaderKernel> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DFD RID: 93693 RVA: 0x00358A20 File Offset: 0x00356C20
		public static void CopyValues__AssetList_ComputeShaderKernel_5_2_3__AccessListBase_IComputeShaderKernel(AssetList<ComputeShaderKernel_5_2_3> target, AccessListBase<IComputeShaderKernel> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DFE RID: 93694 RVA: 0x00358A68 File Offset: 0x00356C68
		public static void CopyValues__AssetList_ComputeShaderKernel_5_4_0__AccessListBase_IComputeShaderKernel(AssetList<ComputeShaderKernel_5_4_0> target, AccessListBase<IComputeShaderKernel> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016DFF RID: 93695 RVA: 0x00358AB0 File Offset: 0x00356CB0
		public static void CopyValues__AssetList_ComputeShaderCB_5_6_0__AccessListBase_IComputeShaderCB(AssetList<ComputeShaderCB_5_6_0> target, AccessListBase<IComputeShaderCB> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E00 RID: 93696 RVA: 0x00358AF8 File Offset: 0x00356CF8
		public static void CopyValues__AssetList_ComputeShaderKernel_5_6_0__AccessListBase_IComputeShaderKernel(AssetList<ComputeShaderKernel_5_6_0> target, AccessListBase<IComputeShaderKernel> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E01 RID: 93697 RVA: 0x00358B40 File Offset: 0x00356D40
		public static void CopyValues__AssetList_ComputeShaderCB_2017_1_0__AccessListBase_IComputeShaderCB(AssetList<ComputeShaderCB_2017_1_0> target, AccessListBase<IComputeShaderCB> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E02 RID: 93698 RVA: 0x00358B88 File Offset: 0x00356D88
		public static void CopyValues__AssetList_ComputeShaderKernel_2017_1_0__AccessListBase_IComputeShaderKernel(AssetList<ComputeShaderKernel_2017_1_0> target, AccessListBase<IComputeShaderKernel> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E03 RID: 93699 RVA: 0x00358BD0 File Offset: 0x00356DD0
		public static void CopyValues__AssetList_ComputeShaderKernel_2018_1_0__AccessListBase_IComputeShaderKernel(AssetList<ComputeShaderKernel_2018_1_0> target, AccessListBase<IComputeShaderKernel> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E04 RID: 93700 RVA: 0x00358C18 File Offset: 0x00356E18
		public static void CopyValues__AssetList_ComputeShaderKernel_2018_2_0__AccessListBase_IComputeShaderKernel(AssetList<ComputeShaderKernel_2018_2_0> target, AccessListBase<IComputeShaderKernel> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E05 RID: 93701 RVA: 0x00358C60 File Offset: 0x00356E60
		public static void CopyValues__AssetList_ComputeShaderKernel_2018_2_0_b9__AccessListBase_IComputeShaderKernel(AssetList<ComputeShaderKernel_2018_2_0_b9> target, AccessListBase<IComputeShaderKernel> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E06 RID: 93702 RVA: 0x00358CA8 File Offset: 0x00356EA8
		public static void CopyValues__AssetList_ComputeShaderCB_2020_1_0_a9__AccessListBase_IComputeShaderCB(AssetList<ComputeShaderCB_2020_1_0_a9> target, AccessListBase<IComputeShaderCB> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E07 RID: 93703 RVA: 0x00358CF0 File Offset: 0x00356EF0
		public static void CopyValues__AssetList_ComputeShaderKernelParent_2020_1_0_a9__AccessListBase_IComputeShaderKernelParent(AssetList<ComputeShaderKernelParent_2020_1_0_a9> target, AccessListBase<IComputeShaderKernelParent> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E08 RID: 93704 RVA: 0x00358D38 File Offset: 0x00356F38
		public static void CopyValues__AssetDictionary_Utf8String_ComputeShaderKernel_2020_1_0_a9__AccessDictionaryBase_Utf8String_IComputeShaderKernel(AssetDictionary<Utf8String, ComputeShaderKernel_2020_1_0_a9> target, AccessDictionaryBase<Utf8String, IComputeShaderKernel> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_ComputeShaderKernel_2020_1_0_a9__AccessPairBase_Utf8String_IComputeShaderKernel(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E09 RID: 93705 RVA: 0x00358D85 File Offset: 0x00356F85
		public static void CopyValues__AccessPairBase_Utf8String_ComputeShaderKernel_2020_1_0_a9__AccessPairBase_Utf8String_IComputeShaderKernel(AccessPairBase<Utf8String, ComputeShaderKernel_2020_1_0_a9> target, AccessPairBase<Utf8String, IComputeShaderKernel> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016E0A RID: 93706 RVA: 0x00358DAC File Offset: 0x00356FAC
		public static void CopyValues__AssetDictionary_Utf8String_ComputeShaderKernel_2020_1_0_a17__AccessDictionaryBase_Utf8String_IComputeShaderKernel(AssetDictionary<Utf8String, ComputeShaderKernel_2020_1_0_a17> target, AccessDictionaryBase<Utf8String, IComputeShaderKernel> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_ComputeShaderKernel_2020_1_0_a17__AccessPairBase_Utf8String_IComputeShaderKernel(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E0B RID: 93707 RVA: 0x00358DF9 File Offset: 0x00356FF9
		public static void CopyValues__AccessPairBase_Utf8String_ComputeShaderKernel_2020_1_0_a17__AccessPairBase_Utf8String_IComputeShaderKernel(AccessPairBase<Utf8String, ComputeShaderKernel_2020_1_0_a17> target, AccessPairBase<Utf8String, IComputeShaderKernel> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016E0C RID: 93708 RVA: 0x00358E20 File Offset: 0x00357020
		public static void CopyValues__AssetDictionary_Utf8String_ComputeShaderKernel_2020_2_0_a15__AccessDictionaryBase_Utf8String_IComputeShaderKernel(AssetDictionary<Utf8String, ComputeShaderKernel_2020_2_0_a15> target, AccessDictionaryBase<Utf8String, IComputeShaderKernel> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_ComputeShaderKernel_2020_2_0_a15__AccessPairBase_Utf8String_IComputeShaderKernel(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E0D RID: 93709 RVA: 0x00358E6D File Offset: 0x0035706D
		public static void CopyValues__AccessPairBase_Utf8String_ComputeShaderKernel_2020_2_0_a15__AccessPairBase_Utf8String_IComputeShaderKernel(AccessPairBase<Utf8String, ComputeShaderKernel_2020_2_0_a15> target, AccessPairBase<Utf8String, IComputeShaderKernel> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016E0E RID: 93710 RVA: 0x00358E94 File Offset: 0x00357094
		public static void CopyValues__AssetDictionary_Utf8String_ComputeShaderKernel_2020_3_2__AccessDictionaryBase_Utf8String_IComputeShaderKernel(AssetDictionary<Utf8String, ComputeShaderKernel_2020_3_2> target, AccessDictionaryBase<Utf8String, IComputeShaderKernel> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_ComputeShaderKernel_2020_3_2__AccessPairBase_Utf8String_IComputeShaderKernel(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E0F RID: 93711 RVA: 0x00358EE1 File Offset: 0x003570E1
		public static void CopyValues__AccessPairBase_Utf8String_ComputeShaderKernel_2020_3_2__AccessPairBase_Utf8String_IComputeShaderKernel(AccessPairBase<Utf8String, ComputeShaderKernel_2020_3_2> target, AccessPairBase<Utf8String, IComputeShaderKernel> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016E10 RID: 93712 RVA: 0x00358F08 File Offset: 0x00357108
		public static void CopyValues__AssetDictionary_Utf8String_ComputeShaderKernel_2021_1_0__AccessDictionaryBase_Utf8String_IComputeShaderKernel(AssetDictionary<Utf8String, ComputeShaderKernel_2021_1_0> target, AccessDictionaryBase<Utf8String, IComputeShaderKernel> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_ComputeShaderKernel_2021_1_0__AccessPairBase_Utf8String_IComputeShaderKernel(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E11 RID: 93713 RVA: 0x00358F55 File Offset: 0x00357155
		public static void CopyValues__AccessPairBase_Utf8String_ComputeShaderKernel_2021_1_0__AccessPairBase_Utf8String_IComputeShaderKernel(AccessPairBase<Utf8String, ComputeShaderKernel_2021_1_0> target, AccessPairBase<Utf8String, IComputeShaderKernel> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016E12 RID: 93714 RVA: 0x00358F7C File Offset: 0x0035717C
		public static void CopyValues__AssetDictionary_Utf8String_ComputeShaderKernel_2021_1_0_b7__AccessDictionaryBase_Utf8String_IComputeShaderKernel(AssetDictionary<Utf8String, ComputeShaderKernel_2021_1_0_b7> target, AccessDictionaryBase<Utf8String, IComputeShaderKernel> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_ComputeShaderKernel_2021_1_0_b7__AccessPairBase_Utf8String_IComputeShaderKernel(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E13 RID: 93715 RVA: 0x00358FC9 File Offset: 0x003571C9
		public static void CopyValues__AccessPairBase_Utf8String_ComputeShaderKernel_2021_1_0_b7__AccessPairBase_Utf8String_IComputeShaderKernel(AccessPairBase<Utf8String, ComputeShaderKernel_2021_1_0_b7> target, AccessPairBase<Utf8String, IComputeShaderKernel> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016E14 RID: 93716 RVA: 0x00358FF0 File Offset: 0x003571F0
		public static void CopyValues__AssetList_ComputeShaderKernel_2021_1_0_b7__AssetList_ComputeShaderKernel_2021_1_0_b7(AssetList<ComputeShaderKernel_2021_1_0_b7> target, AssetList<ComputeShaderKernel_2021_1_0_b7> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E15 RID: 93717 RVA: 0x00359038 File Offset: 0x00357238
		public static void CopyValues__AssetList_AssetPair_Utf8String_UInt32__AssetList_AssetPair_Utf8String_UInt32(AssetList<AssetPair<Utf8String, uint>> target, AssetList<AssetPair<Utf8String, uint>> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					CopyValuesHelper.CopyValues__AssetPair_Utf8String_UInt32__AssetPair_Utf8String_UInt32(target.AddNew(), source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E16 RID: 93718 RVA: 0x0035907E File Offset: 0x0035727E
		public static void CopyValues__AssetPair_Utf8String_UInt32__AssetPair_Utf8String_UInt32(AssetPair<Utf8String, uint> target, AssetPair<Utf8String, uint> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value = source.Value;
			}
		}

		// Token: 0x06016E17 RID: 93719 RVA: 0x003590A0 File Offset: 0x003572A0
		public static void CopyValues__AssetList_ComputeShaderKernelParent_2020_1_0_a17__AccessListBase_IComputeShaderKernelParent(AssetList<ComputeShaderKernelParent_2020_1_0_a17> target, AccessListBase<IComputeShaderKernelParent> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E18 RID: 93720 RVA: 0x003590E8 File Offset: 0x003572E8
		public static void CopyValues__AssetList_ComputeShaderKernelParent_2020_2_0_a15__AccessListBase_IComputeShaderKernelParent(AssetList<ComputeShaderKernelParent_2020_2_0_a15> target, AccessListBase<IComputeShaderKernelParent> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E19 RID: 93721 RVA: 0x00359130 File Offset: 0x00357330
		public static void CopyValues__AssetList_ComputeShaderKernelParent_2020_3_2__AccessListBase_IComputeShaderKernelParent(AssetList<ComputeShaderKernelParent_2020_3_2> target, AccessListBase<IComputeShaderKernelParent> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E1A RID: 93722 RVA: 0x00359178 File Offset: 0x00357378
		public static void CopyValues__AssetList_ComputeShaderKernelParent_2021_1_0__AccessListBase_IComputeShaderKernelParent(AssetList<ComputeShaderKernelParent_2021_1_0> target, AccessListBase<IComputeShaderKernelParent> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E1B RID: 93723 RVA: 0x003591C0 File Offset: 0x003573C0
		public static void CopyValues__AssetList_ComputeShaderKernelParent_2021_1_0_b7__AccessListBase_IComputeShaderKernelParent(AssetList<ComputeShaderKernelParent_2021_1_0_b7> target, AccessListBase<IComputeShaderKernelParent> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E1C RID: 93724 RVA: 0x00359208 File Offset: 0x00357408
		public static void CopyValues__AssetList_ComputeShaderKernelParent_2022_1_0_a15__AccessListBase_IComputeShaderKernelParent(AssetList<ComputeShaderKernelParent_2022_1_0_a15> target, AccessListBase<IComputeShaderKernelParent> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E1D RID: 93725 RVA: 0x00359250 File Offset: 0x00357450
		public static void CopyValues__AssetList_ComputeShaderVariant_5_1_0__AccessListBase_IComputeShaderVariant(AssetList<ComputeShaderVariant_5_1_0> target, AccessListBase<IComputeShaderVariant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E1E RID: 93726 RVA: 0x00359298 File Offset: 0x00357498
		public static void CopyValues__AssetList_ComputeShaderVariant_5_2_3__AccessListBase_IComputeShaderVariant(AssetList<ComputeShaderVariant_5_2_3> target, AccessListBase<IComputeShaderVariant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E1F RID: 93727 RVA: 0x003592E0 File Offset: 0x003574E0
		public static void CopyValues__AssetList_ComputeShaderVariant_5_4_0__AccessListBase_IComputeShaderVariant(AssetList<ComputeShaderVariant_5_4_0> target, AccessListBase<IComputeShaderVariant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E20 RID: 93728 RVA: 0x00359328 File Offset: 0x00357528
		public static void CopyValues__AssetList_ComputeShaderVariant_5_6_0__AccessListBase_IComputeShaderVariant(AssetList<ComputeShaderVariant_5_6_0> target, AccessListBase<IComputeShaderVariant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E21 RID: 93729 RVA: 0x00359370 File Offset: 0x00357570
		public static void CopyValues__AssetList_ComputeShaderVariant_2017_1_0__AccessListBase_IComputeShaderVariant(AssetList<ComputeShaderVariant_2017_1_0> target, AccessListBase<IComputeShaderVariant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E22 RID: 93730 RVA: 0x003593B8 File Offset: 0x003575B8
		public static void CopyValues__AssetList_ComputeShaderVariant_2018_1_0__AccessListBase_IComputeShaderVariant(AssetList<ComputeShaderVariant_2018_1_0> target, AccessListBase<IComputeShaderVariant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E23 RID: 93731 RVA: 0x00359400 File Offset: 0x00357600
		public static void CopyValues__AssetList_ComputeShaderVariant_2018_2_0__AccessListBase_IComputeShaderVariant(AssetList<ComputeShaderVariant_2018_2_0> target, AccessListBase<IComputeShaderVariant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E24 RID: 93732 RVA: 0x00359448 File Offset: 0x00357648
		public static void CopyValues__AssetList_ComputeShaderVariant_2018_2_0_b9__AccessListBase_IComputeShaderVariant(AssetList<ComputeShaderVariant_2018_2_0_b9> target, AccessListBase<IComputeShaderVariant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E25 RID: 93733 RVA: 0x00359490 File Offset: 0x00357690
		public static void CopyValues__AssetList_ComputeShaderVariant_2020_1_0_a9__AccessListBase_IComputeShaderVariant(AssetList<ComputeShaderVariant_2020_1_0_a9> target, AccessListBase<IComputeShaderVariant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E26 RID: 93734 RVA: 0x003594D8 File Offset: 0x003576D8
		public static void CopyValues__AssetList_AssetList_AssetPair_Utf8String_Utf8String__AssetList_AssetList_AssetPair_Utf8String_Utf8String(AssetList<AssetList<AssetPair<Utf8String, Utf8String>>> target, AssetList<AssetList<AssetPair<Utf8String, Utf8String>>> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					CopyValuesHelper.CopyValues__AssetList_AssetPair_Utf8String_Utf8String__AssetList_AssetPair_Utf8String_Utf8String(target.AddNew(), source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E27 RID: 93735 RVA: 0x00359520 File Offset: 0x00357720
		public static void CopyValues__AssetList_AssetPair_Utf8String_Utf8String__AssetList_AssetPair_Utf8String_Utf8String(AssetList<AssetPair<Utf8String, Utf8String>> target, AssetList<AssetPair<Utf8String, Utf8String>> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					CopyValuesHelper.CopyValues__AssetPair_Utf8String_Utf8String__AssetPair_Utf8String_Utf8String(target.AddNew(), source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E28 RID: 93736 RVA: 0x00359568 File Offset: 0x00357768
		public static void CopyValues__AssetList_ComputeShaderVariant_2020_1_0_a17__AccessListBase_IComputeShaderVariant(AssetList<ComputeShaderVariant_2020_1_0_a17> target, AccessListBase<IComputeShaderVariant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E29 RID: 93737 RVA: 0x003595B0 File Offset: 0x003577B0
		public static void CopyValues__AssetList_ComputeShaderVariant_2020_2_0_a15__AccessListBase_IComputeShaderVariant(AssetList<ComputeShaderVariant_2020_2_0_a15> target, AccessListBase<IComputeShaderVariant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E2A RID: 93738 RVA: 0x003595F8 File Offset: 0x003577F8
		public static void CopyValues__AssetList_ComputeShaderVariant_2020_3_2__AccessListBase_IComputeShaderVariant(AssetList<ComputeShaderVariant_2020_3_2> target, AccessListBase<IComputeShaderVariant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E2B RID: 93739 RVA: 0x00359640 File Offset: 0x00357840
		public static void CopyValues__AssetList_ComputeShaderVariant_2021_1_0__AccessListBase_IComputeShaderVariant(AssetList<ComputeShaderVariant_2021_1_0> target, AccessListBase<IComputeShaderVariant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E2C RID: 93740 RVA: 0x00359688 File Offset: 0x00357888
		public static void CopyValues__AssetList_ComputeShaderVariant_2021_1_0_b7__AccessListBase_IComputeShaderVariant(AssetList<ComputeShaderVariant_2021_1_0_b7> target, AccessListBase<IComputeShaderVariant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E2D RID: 93741 RVA: 0x003596D0 File Offset: 0x003578D0
		public static void CopyValues__AssetList_ComputeShaderVariant_2021_2_0_a19__AccessListBase_IComputeShaderVariant(AssetList<ComputeShaderVariant_2021_2_0_a19> target, AccessListBase<IComputeShaderVariant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E2E RID: 93742 RVA: 0x00359718 File Offset: 0x00357918
		public static void CopyValues__AssetList_ComputeShaderVariant_2022_1_0_a15__AccessListBase_IComputeShaderVariant(AssetList<ComputeShaderVariant_2022_1_0_a15> target, AccessListBase<IComputeShaderVariant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E2F RID: 93743 RVA: 0x00359760 File Offset: 0x00357960
		public static void CopyValues__AssetList_Collider_4_0_0__AccessListBase_ICollider(AssetList<Collider_4_0_0> target, AccessListBase<ICollider> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E30 RID: 93744 RVA: 0x003597A8 File Offset: 0x003579A8
		public static void CopyValues__AssetList_Handle_4_0_0__AccessListBase_IHandle(AssetList<Handle_4_0_0> target, AccessListBase<IHandle> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E31 RID: 93745 RVA: 0x003597F0 File Offset: 0x003579F0
		public static void CopyValues__AssetList_Axes_4_0_0__AccessListBase_IAxes(AssetList<Axes_4_0_0> target, AccessListBase<IAxes> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E32 RID: 93746 RVA: 0x00359838 File Offset: 0x00357A38
		public static void CopyValues__AssetList_Node__AssetList_Node(AssetList<Node> target, AssetList<Node> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E33 RID: 93747 RVA: 0x00359880 File Offset: 0x00357A80
		public static void CopyValues__AssetList_Axes_5_4_0__AccessListBase_IAxes(AssetList<Axes_5_4_0> target, AccessListBase<IAxes> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E34 RID: 93748 RVA: 0x003598C8 File Offset: 0x00357AC8
		public static void CopyValues__AssetList_Axes_5_5_0__AccessListBase_IAxes(AssetList<Axes_5_5_0> target, AccessListBase<IAxes> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E35 RID: 93749 RVA: 0x00359910 File Offset: 0x00357B10
		public static void CopyValues__AssetList_Xform_4_0_0__AccessListBase_IXform(AssetList<Xform_4_0_0> target, AccessListBase<IXform> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E36 RID: 93750 RVA: 0x00359958 File Offset: 0x00357B58
		public static void CopyValues__AssetList_Xform_5_4_0__AccessListBase_IXform(AssetList<Xform_5_4_0> target, AccessListBase<IXform> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E37 RID: 93751 RVA: 0x003599A0 File Offset: 0x00357BA0
		public static void CopyValues__AssetList_Xform_5_5_0__AccessListBase_IXform(AssetList<Xform_5_5_0> target, AccessListBase<IXform> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E38 RID: 93752 RVA: 0x003599E8 File Offset: 0x00357BE8
		public static void CopyValues__AssetList_Collider_5_4_0__AccessListBase_ICollider(AssetList<Collider_5_4_0> target, AccessListBase<ICollider> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E39 RID: 93753 RVA: 0x00359A30 File Offset: 0x00357C30
		public static void CopyValues__AssetList_Handle_5_4_0__AccessListBase_IHandle(AssetList<Handle_5_4_0> target, AccessListBase<IHandle> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E3A RID: 93754 RVA: 0x00359A78 File Offset: 0x00357C78
		public static void CopyValues__AssetList_Collider_5_5_0__AccessListBase_ICollider(AssetList<Collider_5_5_0> target, AccessListBase<ICollider> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E3B RID: 93755 RVA: 0x00359AC0 File Offset: 0x00357CC0
		public static void CopyValues__AssetList_Handle_5_5_0__AccessListBase_IHandle(AssetList<Handle_5_5_0> target, AccessListBase<IHandle> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E3C RID: 93756 RVA: 0x00359B08 File Offset: 0x00357D08
		public static void CopyValues__AssetDictionary_UInt32_Utf8String__AssetDictionary_UInt32_Utf8String(AssetDictionary<uint, Utf8String> target, AssetDictionary<uint, Utf8String> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_UInt32_Utf8String__AccessPairBase_UInt32_Utf8String(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E3D RID: 93757 RVA: 0x00359B55 File Offset: 0x00357D55
		public static void CopyValues__AccessPairBase_UInt32_Utf8String__AccessPairBase_UInt32_Utf8String(AccessPairBase<uint, Utf8String> target, AccessPairBase<uint, Utf8String> source)
		{
			if (source != null)
			{
				target.Key = source.Key;
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016E3E RID: 93758 RVA: 0x00359B78 File Offset: 0x00357D78
		public static void CopyValues__AssetList_AnimatorControllerLayer_4_0_0__AccessListBase_IAnimatorControllerLayer(AssetList<AnimatorControllerLayer_4_0_0> target, AccessListBase<IAnimatorControllerLayer> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E3F RID: 93759 RVA: 0x00359BC0 File Offset: 0x00357DC0
		public static void CopyValues__AssetList_StateBehavioursPair_5_0_0__AccessListBase_IStateBehavioursPair(AssetList<StateBehavioursPair_5_0_0> target, AccessListBase<IStateBehavioursPair> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E40 RID: 93760 RVA: 0x00359C08 File Offset: 0x00357E08
		public static void CopyValues__AssetList_PPtr_MonoBehaviour_5_0_0__AssetList_PPtr_MonoBehaviour_5_0_0(AssetList<PPtr_MonoBehaviour_5_0_0> target, AssetList<PPtr_MonoBehaviour_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E41 RID: 93761 RVA: 0x00359C50 File Offset: 0x00357E50
		public static void CopyValues__AssetList_StateMotionPair_5_0_0__AccessListBase_IStateMotionPair(AssetList<StateMotionPair_5_0_0> target, AccessListBase<IStateMotionPair> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E42 RID: 93762 RVA: 0x00359C98 File Offset: 0x00357E98
		public static void CopyValues__AssetList_StateBehavioursPair_5_2_0__AccessListBase_IStateBehavioursPair(AssetList<StateBehavioursPair_5_2_0> target, AccessListBase<IStateBehavioursPair> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E43 RID: 93763 RVA: 0x00359CE0 File Offset: 0x00357EE0
		public static void CopyValues__AssetList_StateMotionPair_5_2_0__AccessListBase_IStateMotionPair(AssetList<StateMotionPair_5_2_0> target, AccessListBase<IStateMotionPair> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E44 RID: 93764 RVA: 0x00359D28 File Offset: 0x00357F28
		public static void CopyValues__AssetList_StateBehavioursPair_2017_1_0__AccessListBase_IStateBehavioursPair(AssetList<StateBehavioursPair_2017_1_0> target, AccessListBase<IStateBehavioursPair> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E45 RID: 93765 RVA: 0x00359D70 File Offset: 0x00357F70
		public static void CopyValues__AssetList_AnimatorControllerParameter_4_0_0__AccessListBase_IAnimatorControllerParameter(AssetList<AnimatorControllerParameter_4_0_0> target, AccessListBase<IAnimatorControllerParameter> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E46 RID: 93766 RVA: 0x00359DB8 File Offset: 0x00357FB8
		public static void CopyValues__AssetList_Vector4Float_4_0_0__AccessListBase_IVector4Float(AssetList<Vector4Float_4_0_0> target, AccessListBase<IVector4Float> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E47 RID: 93767 RVA: 0x00359E00 File Offset: 0x00358000
		public static void CopyValues__AssetList_Vector3Float_5_4_0__AccessListBase_IVector3Float(AssetList<Vector3Float_5_4_0> target, AccessListBase<IVector3Float> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E48 RID: 93768 RVA: 0x00359E48 File Offset: 0x00358048
		public static void CopyValues__AssetList_Vector3Float_5_5_0__AccessListBase_IVector3Float(AssetList<Vector3Float_5_5_0> target, AccessListBase<IVector3Float> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E49 RID: 93769 RVA: 0x00359E90 File Offset: 0x00358090
		public static void CopyValues__AssetList_Vector4Float_5_5_0__AccessListBase_IVector4Float(AssetList<Vector4Float_5_5_0> target, AccessListBase<IVector4Float> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E4A RID: 93770 RVA: 0x00359ED8 File Offset: 0x003580D8
		public static void CopyValues__AssetList_OffsetPtr_LayerConstant_4_0_0__AccessListBase_IOffsetPtr_LayerConstant(AssetList<OffsetPtr_LayerConstant_4_0_0> target, AccessListBase<IOffsetPtr_LayerConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E4B RID: 93771 RVA: 0x00359F20 File Offset: 0x00358120
		public static void CopyValues__AssetList_SkeletonMaskElement_4_0_0__AccessListBase_ISkeletonMaskElement(AssetList<SkeletonMaskElement_4_0_0> target, AccessListBase<ISkeletonMaskElement> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E4C RID: 93772 RVA: 0x00359F68 File Offset: 0x00358168
		public static void CopyValues__AssetList_SkeletonMaskElement_4_3_0__AccessListBase_ISkeletonMaskElement(AssetList<SkeletonMaskElement_4_3_0> target, AccessListBase<ISkeletonMaskElement> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E4D RID: 93773 RVA: 0x00359FB0 File Offset: 0x003581B0
		public static void CopyValues__AssetList_OffsetPtr_StateMachineConstant_4_0_0__AccessListBase_IOffsetPtr_StateMachineConstant(AssetList<OffsetPtr_StateMachineConstant_4_0_0> target, AccessListBase<IOffsetPtr_StateMachineConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E4E RID: 93774 RVA: 0x00359FF8 File Offset: 0x003581F8
		public static void CopyValues__AssetList_OffsetPtr_TransitionConstant_4_0_0__AccessListBase_IOffsetPtr_TransitionConstant(AssetList<OffsetPtr_TransitionConstant_4_0_0> target, AccessListBase<IOffsetPtr_TransitionConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E4F RID: 93775 RVA: 0x0035A040 File Offset: 0x00358240
		public static void CopyValues__AssetList_OffsetPtr_ConditionConstant__AssetList_OffsetPtr_ConditionConstant(AssetList<OffsetPtr_ConditionConstant> target, AssetList<OffsetPtr_ConditionConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E50 RID: 93776 RVA: 0x0035A088 File Offset: 0x00358288
		public static void CopyValues__AssetList_OffsetPtr_StateConstant_4_0_0__AccessListBase_IOffsetPtr_StateConstant(AssetList<OffsetPtr_StateConstant_4_0_0> target, AccessListBase<IOffsetPtr_StateConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E51 RID: 93777 RVA: 0x0035A0D0 File Offset: 0x003582D0
		public static void CopyValues__AssetList_OffsetPtr_BlendTreeConstant_4_0_0__AccessListBase_IOffsetPtr_BlendTreeConstant(AssetList<OffsetPtr_BlendTreeConstant_4_0_0> target, AccessListBase<IOffsetPtr_BlendTreeConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E52 RID: 93778 RVA: 0x0035A118 File Offset: 0x00358318
		public static void CopyValues__AssetList_OffsetPtr_BlendTreeNodeConstant_4_0_0__AccessListBase_IOffsetPtr_BlendTreeNodeConstant(AssetList<OffsetPtr_BlendTreeNodeConstant_4_0_0> target, AccessListBase<IOffsetPtr_BlendTreeNodeConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E53 RID: 93779 RVA: 0x0035A160 File Offset: 0x00358360
		public static void CopyValues__AssetList_MotionNeighborList__AssetList_MotionNeighborList(AssetList<MotionNeighborList> target, AssetList<MotionNeighborList> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E54 RID: 93780 RVA: 0x0035A1A8 File Offset: 0x003583A8
		public static void CopyValues__AssetList_OffsetPtr_BlendTreeNodeConstant_4_1_0__AccessListBase_IOffsetPtr_BlendTreeNodeConstant(AssetList<OffsetPtr_BlendTreeNodeConstant_4_1_0> target, AccessListBase<IOffsetPtr_BlendTreeNodeConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E55 RID: 93781 RVA: 0x0035A1F0 File Offset: 0x003583F0
		public static void CopyValues__AssetList_OffsetPtr_BlendTreeNodeConstant_4_1_3__AccessListBase_IOffsetPtr_BlendTreeNodeConstant(AssetList<OffsetPtr_BlendTreeNodeConstant_4_1_3> target, AccessListBase<IOffsetPtr_BlendTreeNodeConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E56 RID: 93782 RVA: 0x0035A238 File Offset: 0x00358438
		public static void CopyValues__AssetList_OffsetPtr_BlendTreeNodeConstant_4_5_2__AccessListBase_IOffsetPtr_BlendTreeNodeConstant(AssetList<OffsetPtr_BlendTreeNodeConstant_4_5_2> target, AccessListBase<IOffsetPtr_BlendTreeNodeConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E57 RID: 93783 RVA: 0x0035A280 File Offset: 0x00358480
		public static void CopyValues__AssetList_OffsetPtr_BlendTreeNodeConstant_5_0_0__AccessListBase_IOffsetPtr_BlendTreeNodeConstant(AssetList<OffsetPtr_BlendTreeNodeConstant_5_0_0> target, AccessListBase<IOffsetPtr_BlendTreeNodeConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E58 RID: 93784 RVA: 0x0035A2C8 File Offset: 0x003584C8
		public static void CopyValues__AssetList_LeafInfoConstant__AssetList_LeafInfoConstant(AssetList<LeafInfoConstant> target, AssetList<LeafInfoConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E59 RID: 93785 RVA: 0x0035A310 File Offset: 0x00358510
		public static void CopyValues__AssetList_OffsetPtr_BlendTreeConstant_4_1_0__AccessListBase_IOffsetPtr_BlendTreeConstant(AssetList<OffsetPtr_BlendTreeConstant_4_1_0> target, AccessListBase<IOffsetPtr_BlendTreeConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E5A RID: 93786 RVA: 0x0035A358 File Offset: 0x00358558
		public static void CopyValues__AssetList_OffsetPtr_BlendTreeConstant_4_1_3__AccessListBase_IOffsetPtr_BlendTreeConstant(AssetList<OffsetPtr_BlendTreeConstant_4_1_3> target, AccessListBase<IOffsetPtr_BlendTreeConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E5B RID: 93787 RVA: 0x0035A3A0 File Offset: 0x003585A0
		public static void CopyValues__AssetList_OffsetPtr_BlendTreeConstant_4_5_0__AccessListBase_IOffsetPtr_BlendTreeConstant(AssetList<OffsetPtr_BlendTreeConstant_4_5_0> target, AccessListBase<IOffsetPtr_BlendTreeConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E5C RID: 93788 RVA: 0x0035A3E8 File Offset: 0x003585E8
		public static void CopyValues__AssetList_OffsetPtr_TransitionConstant_4_5_0__AccessListBase_IOffsetPtr_TransitionConstant(AssetList<OffsetPtr_TransitionConstant_4_5_0> target, AccessListBase<IOffsetPtr_TransitionConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E5D RID: 93789 RVA: 0x0035A430 File Offset: 0x00358630
		public static void CopyValues__AssetList_OffsetPtr_BlendTreeConstant_4_5_2__AccessListBase_IOffsetPtr_BlendTreeConstant(AssetList<OffsetPtr_BlendTreeConstant_4_5_2> target, AccessListBase<IOffsetPtr_BlendTreeConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E5E RID: 93790 RVA: 0x0035A478 File Offset: 0x00358678
		public static void CopyValues__AssetList_OffsetPtr_BlendTreeConstant_5_0_0__AccessListBase_IOffsetPtr_BlendTreeConstant(AssetList<OffsetPtr_BlendTreeConstant_5_0_0> target, AccessListBase<IOffsetPtr_BlendTreeConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E5F RID: 93791 RVA: 0x0035A4C0 File Offset: 0x003586C0
		public static void CopyValues__AssetList_OffsetPtr_TransitionConstant_5_0_0__AccessListBase_IOffsetPtr_TransitionConstant(AssetList<OffsetPtr_TransitionConstant_5_0_0> target, AccessListBase<IOffsetPtr_TransitionConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E60 RID: 93792 RVA: 0x0035A508 File Offset: 0x00358708
		public static void CopyValues__AssetList_OffsetPtr_TransitionConstant_5_1_0__AccessListBase_IOffsetPtr_TransitionConstant(AssetList<OffsetPtr_TransitionConstant_5_1_0> target, AccessListBase<IOffsetPtr_TransitionConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E61 RID: 93793 RVA: 0x0035A550 File Offset: 0x00358750
		public static void CopyValues__AssetList_OffsetPtr_StateConstant_4_1_0__AccessListBase_IOffsetPtr_StateConstant(AssetList<OffsetPtr_StateConstant_4_1_0> target, AccessListBase<IOffsetPtr_StateConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E62 RID: 93794 RVA: 0x0035A598 File Offset: 0x00358798
		public static void CopyValues__AssetList_OffsetPtr_StateConstant_4_1_3__AccessListBase_IOffsetPtr_StateConstant(AssetList<OffsetPtr_StateConstant_4_1_3> target, AccessListBase<IOffsetPtr_StateConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E63 RID: 93795 RVA: 0x0035A5E0 File Offset: 0x003587E0
		public static void CopyValues__AssetList_OffsetPtr_StateConstant_4_3_0__AccessListBase_IOffsetPtr_StateConstant(AssetList<OffsetPtr_StateConstant_4_3_0> target, AccessListBase<IOffsetPtr_StateConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E64 RID: 93796 RVA: 0x0035A628 File Offset: 0x00358828
		public static void CopyValues__AssetList_OffsetPtr_StateConstant_4_5_0__AccessListBase_IOffsetPtr_StateConstant(AssetList<OffsetPtr_StateConstant_4_5_0> target, AccessListBase<IOffsetPtr_StateConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E65 RID: 93797 RVA: 0x0035A670 File Offset: 0x00358870
		public static void CopyValues__AssetList_OffsetPtr_StateConstant_4_5_2__AccessListBase_IOffsetPtr_StateConstant(AssetList<OffsetPtr_StateConstant_4_5_2> target, AccessListBase<IOffsetPtr_StateConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E66 RID: 93798 RVA: 0x0035A6B8 File Offset: 0x003588B8
		public static void CopyValues__AssetList_OffsetPtr_SelectorStateConstant__AssetList_OffsetPtr_SelectorStateConstant(AssetList<OffsetPtr_SelectorStateConstant> target, AssetList<OffsetPtr_SelectorStateConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E67 RID: 93799 RVA: 0x0035A700 File Offset: 0x00358900
		public static void CopyValues__AssetList_OffsetPtr_SelectorTransitionConstant__AssetList_OffsetPtr_SelectorTransitionConstant(AssetList<OffsetPtr_SelectorTransitionConstant> target, AssetList<OffsetPtr_SelectorTransitionConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E68 RID: 93800 RVA: 0x0035A748 File Offset: 0x00358948
		public static void CopyValues__AssetList_OffsetPtr_StateConstant_5_0_0__AccessListBase_IOffsetPtr_StateConstant(AssetList<OffsetPtr_StateConstant_5_0_0> target, AccessListBase<IOffsetPtr_StateConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E69 RID: 93801 RVA: 0x0035A790 File Offset: 0x00358990
		public static void CopyValues__AssetList_OffsetPtr_StateConstant_5_1_0__AccessListBase_IOffsetPtr_StateConstant(AssetList<OffsetPtr_StateConstant_5_1_0> target, AccessListBase<IOffsetPtr_StateConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E6A RID: 93802 RVA: 0x0035A7D8 File Offset: 0x003589D8
		public static void CopyValues__AssetList_OffsetPtr_StateConstant_5_2_0__AccessListBase_IOffsetPtr_StateConstant(AssetList<OffsetPtr_StateConstant_5_2_0> target, AccessListBase<IOffsetPtr_StateConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E6B RID: 93803 RVA: 0x0035A820 File Offset: 0x00358A20
		public static void CopyValues__AssetList_OffsetPtr_StateConstant_5_2_2__AccessListBase_IOffsetPtr_StateConstant(AssetList<OffsetPtr_StateConstant_5_2_2> target, AccessListBase<IOffsetPtr_StateConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E6C RID: 93804 RVA: 0x0035A868 File Offset: 0x00358A68
		public static void CopyValues__AssetList_OffsetPtr_StateConstant_2017_2_0__AccessListBase_IOffsetPtr_StateConstant(AssetList<OffsetPtr_StateConstant_2017_2_0> target, AccessListBase<IOffsetPtr_StateConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E6D RID: 93805 RVA: 0x0035A8B0 File Offset: 0x00358AB0
		public static void CopyValues__AssetList_OffsetPtr_StateMachineConstant_4_1_0__AccessListBase_IOffsetPtr_StateMachineConstant(AssetList<OffsetPtr_StateMachineConstant_4_1_0> target, AccessListBase<IOffsetPtr_StateMachineConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E6E RID: 93806 RVA: 0x0035A8F8 File Offset: 0x00358AF8
		public static void CopyValues__AssetList_OffsetPtr_StateMachineConstant_4_1_3__AccessListBase_IOffsetPtr_StateMachineConstant(AssetList<OffsetPtr_StateMachineConstant_4_1_3> target, AccessListBase<IOffsetPtr_StateMachineConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E6F RID: 93807 RVA: 0x0035A940 File Offset: 0x00358B40
		public static void CopyValues__AssetList_OffsetPtr_LayerConstant_4_2_0__AccessListBase_IOffsetPtr_LayerConstant(AssetList<OffsetPtr_LayerConstant_4_2_0> target, AccessListBase<IOffsetPtr_LayerConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E70 RID: 93808 RVA: 0x0035A988 File Offset: 0x00358B88
		public static void CopyValues__AssetList_OffsetPtr_LayerConstant_4_3_0__AccessListBase_IOffsetPtr_LayerConstant(AssetList<OffsetPtr_LayerConstant_4_3_0> target, AccessListBase<IOffsetPtr_LayerConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E71 RID: 93809 RVA: 0x0035A9D0 File Offset: 0x00358BD0
		public static void CopyValues__AssetList_OffsetPtr_StateMachineConstant_4_3_0__AccessListBase_IOffsetPtr_StateMachineConstant(AssetList<OffsetPtr_StateMachineConstant_4_3_0> target, AccessListBase<IOffsetPtr_StateMachineConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E72 RID: 93810 RVA: 0x0035AA18 File Offset: 0x00358C18
		public static void CopyValues__AssetList_OffsetPtr_StateMachineConstant_4_5_0__AccessListBase_IOffsetPtr_StateMachineConstant(AssetList<OffsetPtr_StateMachineConstant_4_5_0> target, AccessListBase<IOffsetPtr_StateMachineConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E73 RID: 93811 RVA: 0x0035AA60 File Offset: 0x00358C60
		public static void CopyValues__AssetList_OffsetPtr_StateMachineConstant_4_5_2__AccessListBase_IOffsetPtr_StateMachineConstant(AssetList<OffsetPtr_StateMachineConstant_4_5_2> target, AccessListBase<IOffsetPtr_StateMachineConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E74 RID: 93812 RVA: 0x0035AAA8 File Offset: 0x00358CA8
		public static void CopyValues__AssetList_OffsetPtr_StateMachineConstant_5_0_0__AccessListBase_IOffsetPtr_StateMachineConstant(AssetList<OffsetPtr_StateMachineConstant_5_0_0> target, AccessListBase<IOffsetPtr_StateMachineConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E75 RID: 93813 RVA: 0x0035AAF0 File Offset: 0x00358CF0
		public static void CopyValues__AssetList_OffsetPtr_StateMachineConstant_5_1_0__AccessListBase_IOffsetPtr_StateMachineConstant(AssetList<OffsetPtr_StateMachineConstant_5_1_0> target, AccessListBase<IOffsetPtr_StateMachineConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E76 RID: 93814 RVA: 0x0035AB38 File Offset: 0x00358D38
		public static void CopyValues__AssetList_OffsetPtr_LayerConstant_5_2_0__AccessListBase_IOffsetPtr_LayerConstant(AssetList<OffsetPtr_LayerConstant_5_2_0> target, AccessListBase<IOffsetPtr_LayerConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E77 RID: 93815 RVA: 0x0035AB80 File Offset: 0x00358D80
		public static void CopyValues__AssetList_OffsetPtr_StateMachineConstant_5_2_0__AccessListBase_IOffsetPtr_StateMachineConstant(AssetList<OffsetPtr_StateMachineConstant_5_2_0> target, AccessListBase<IOffsetPtr_StateMachineConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E78 RID: 93816 RVA: 0x0035ABC8 File Offset: 0x00358DC8
		public static void CopyValues__AssetList_OffsetPtr_StateMachineConstant_5_2_2__AccessListBase_IOffsetPtr_StateMachineConstant(AssetList<OffsetPtr_StateMachineConstant_5_2_2> target, AccessListBase<IOffsetPtr_StateMachineConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E79 RID: 93817 RVA: 0x0035AC10 File Offset: 0x00358E10
		public static void CopyValues__AssetList_OffsetPtr_StateMachineConstant_2017_2_0__AccessListBase_IOffsetPtr_StateMachineConstant(AssetList<OffsetPtr_StateMachineConstant_2017_2_0> target, AccessListBase<IOffsetPtr_StateMachineConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E7A RID: 93818 RVA: 0x0035AC58 File Offset: 0x00358E58
		public static void CopyValues__AssetList_OffsetPtr_LayerConstant_2018_2_0__AccessListBase_IOffsetPtr_LayerConstant(AssetList<OffsetPtr_LayerConstant_2018_2_0> target, AccessListBase<IOffsetPtr_LayerConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E7B RID: 93819 RVA: 0x0035ACA0 File Offset: 0x00358EA0
		public static void CopyValues__AssetList_OffsetPtr_StateMachineConstant_2018_2_0__AccessListBase_IOffsetPtr_StateMachineConstant(AssetList<OffsetPtr_StateMachineConstant_2018_2_0> target, AccessListBase<IOffsetPtr_StateMachineConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E7C RID: 93820 RVA: 0x0035ACE8 File Offset: 0x00358EE8
		public static void CopyValues__AssetList_AnimatorControllerLayer_4_1_0__AccessListBase_IAnimatorControllerLayer(AssetList<AnimatorControllerLayer_4_1_0> target, AccessListBase<IAnimatorControllerLayer> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E7D RID: 93821 RVA: 0x0035AD30 File Offset: 0x00358F30
		public static void CopyValues__AssetList_AnimatorControllerLayer_4_2_0__AccessListBase_IAnimatorControllerLayer(AssetList<AnimatorControllerLayer_4_2_0> target, AccessListBase<IAnimatorControllerLayer> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E7E RID: 93822 RVA: 0x0035AD78 File Offset: 0x00358F78
		public static void CopyValues__AssetList_AnimatorControllerParameter_4_2_0__AccessListBase_IAnimatorControllerParameter(AssetList<AnimatorControllerParameter_4_2_0> target, AccessListBase<IAnimatorControllerParameter> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E7F RID: 93823 RVA: 0x0035ADC0 File Offset: 0x00358FC0
		public static void CopyValues__AssetList_AnimatorControllerParameter_4_3_0__AccessListBase_IAnimatorControllerParameter(AssetList<AnimatorControllerParameter_4_3_0> target, AccessListBase<IAnimatorControllerParameter> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E80 RID: 93824 RVA: 0x0035AE08 File Offset: 0x00359008
		public static void CopyValues__AssetList_AnimatorControllerLayer_5_0_0__AccessListBase_IAnimatorControllerLayer(AssetList<AnimatorControllerLayer_5_0_0> target, AccessListBase<IAnimatorControllerLayer> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E81 RID: 93825 RVA: 0x0035AE50 File Offset: 0x00359050
		public static void CopyValues__AssetList_AnimatorControllerParameter_5_0_0__AccessListBase_IAnimatorControllerParameter(AssetList<AnimatorControllerParameter_5_0_0> target, AccessListBase<IAnimatorControllerParameter> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E82 RID: 93826 RVA: 0x0035AE98 File Offset: 0x00359098
		public static void CopyValues__AssetDictionary_StateKey_StateRange__AssetDictionary_StateKey_StateRange(AssetDictionary<StateKey, StateRange> target, AssetDictionary<StateKey, StateRange> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_StateKey_StateRange__AccessPairBase_StateKey_StateRange(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E83 RID: 93827 RVA: 0x0035AEE5 File Offset: 0x003590E5
		public static void CopyValues__AccessPairBase_StateKey_StateRange__AccessPairBase_StateKey_StateRange(AccessPairBase<StateKey, StateRange> target, AccessPairBase<StateKey, StateRange> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016E84 RID: 93828 RVA: 0x0035AF0C File Offset: 0x0035910C
		public static void CopyValues__AssetList_AnimatorControllerLayer_5_2_0__AccessListBase_IAnimatorControllerLayer(AssetList<AnimatorControllerLayer_5_2_0> target, AccessListBase<IAnimatorControllerLayer> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E85 RID: 93829 RVA: 0x0035AF54 File Offset: 0x00359154
		public static void CopyValues__AssetList_AnimatorControllerLayer_2017_1_0__AccessListBase_IAnimatorControllerLayer(AssetList<AnimatorControllerLayer_2017_1_0> target, AccessListBase<IAnimatorControllerLayer> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E86 RID: 93830 RVA: 0x0035AF9C File Offset: 0x0035919C
		public static void CopyValues__AssetList_ChildMotion_4_0_0__AccessListBase_IChildMotion(AssetList<ChildMotion_4_0_0> target, AccessListBase<IChildMotion> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E87 RID: 93831 RVA: 0x0035AFE4 File Offset: 0x003591E4
		public static void CopyValues__AssetList_ChildMotion_4_1_0__AccessListBase_IChildMotion(AssetList<ChildMotion_4_1_0> target, AccessListBase<IChildMotion> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E88 RID: 93832 RVA: 0x0035B02C File Offset: 0x0035922C
		public static void CopyValues__AssetList_ChildMotion_5_0_0__AccessListBase_IChildMotion(AssetList<ChildMotion_5_0_0> target, AccessListBase<IChildMotion> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E89 RID: 93833 RVA: 0x0035B074 File Offset: 0x00359274
		public static void CopyValues__AssetList_AnimatorCondition_4_0_0__AccessListBase_IAnimatorCondition(AssetList<AnimatorCondition_4_0_0> target, AccessListBase<IAnimatorCondition> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E8A RID: 93834 RVA: 0x0035B0BC File Offset: 0x003592BC
		public static void CopyValues__AssetList_AnimatorCondition_5_0_0__AccessListBase_IAnimatorCondition(AssetList<AnimatorCondition_5_0_0> target, AccessListBase<IAnimatorCondition> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E8B RID: 93835 RVA: 0x0035B104 File Offset: 0x00359304
		public static void CopyValues__AssetList_PPtr_Motion_4_0_0__AssetList_PPtr_Motion_4_0_0(AssetList<PPtr_Motion_4_0_0> target, AssetList<PPtr_Motion_4_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E8C RID: 93836 RVA: 0x0035B14C File Offset: 0x0035934C
		public static void CopyValues__AssetList_PPtr_AnimatorStateTransition__AssetList_PPtr_AnimatorStateTransition(AssetList<PPtr_AnimatorStateTransition> target, AssetList<PPtr_AnimatorStateTransition> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E8D RID: 93837 RVA: 0x0035B194 File Offset: 0x00359394
		public static void CopyValues__AssetList_PPtr_StateMachine__AssetList_PPtr_StateMachine(AssetList<PPtr_StateMachine> target, AssetList<PPtr_StateMachine> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E8E RID: 93838 RVA: 0x0035B1DC File Offset: 0x003593DC
		public static void CopyValues__AssetDictionary_PPtr_State_AssetList_PPtr_Transition__AssetDictionary_PPtr_State_AssetList_PPtr_Transition(AssetDictionary<PPtr_State, AssetList<PPtr_Transition>> target, AssetDictionary<PPtr_State, AssetList<PPtr_Transition>> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_PPtr_State_AssetList_PPtr_Transition__AccessPairBase_PPtr_State_AssetList_PPtr_Transition(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E8F RID: 93839 RVA: 0x0035B22A File Offset: 0x0035942A
		public static void CopyValues__AccessPairBase_PPtr_State_AssetList_PPtr_Transition__AccessPairBase_PPtr_State_AssetList_PPtr_Transition(AccessPairBase<PPtr_State, AssetList<PPtr_Transition>> target, AccessPairBase<PPtr_State, AssetList<PPtr_Transition>> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key, converter);
				CopyValuesHelper.CopyValues__AssetList_PPtr_Transition__AssetList_PPtr_Transition(target.Value, source.Value, converter);
			}
		}

		// Token: 0x06016E90 RID: 93840 RVA: 0x0035B254 File Offset: 0x00359454
		public static void CopyValues__AssetList_PPtr_Transition__AssetList_PPtr_Transition(AssetList<PPtr_Transition> target, AssetList<PPtr_Transition> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E91 RID: 93841 RVA: 0x0035B29C File Offset: 0x0035949C
		public static void CopyValues__AssetList_PPtr_State__AssetList_PPtr_State(AssetList<PPtr_State> target, AssetList<PPtr_State> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E92 RID: 93842 RVA: 0x0035B2E4 File Offset: 0x003594E4
		public static void CopyValues__AssetList_ChildAnimatorStateMachine__AssetList_ChildAnimatorStateMachine(AssetList<ChildAnimatorStateMachine> target, AssetList<ChildAnimatorStateMachine> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E93 RID: 93843 RVA: 0x0035B32C File Offset: 0x0035952C
		public static void CopyValues__AssetList_ChildAnimatorState__AssetList_ChildAnimatorState(AssetList<ChildAnimatorState> target, AssetList<ChildAnimatorState> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E94 RID: 93844 RVA: 0x0035B374 File Offset: 0x00359574
		public static void CopyValues__AssetList_PPtr_AnimatorTransition__AssetList_PPtr_AnimatorTransition(AssetList<PPtr_AnimatorTransition> target, AssetList<PPtr_AnimatorTransition> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E95 RID: 93845 RVA: 0x0035B3BC File Offset: 0x003595BC
		public static void CopyValues__AssetDictionary_PPtr_AnimatorStateMachine_AssetList_PPtr_AnimatorTransition__AssetDictionary_PPtr_AnimatorStateMachine_AssetList_PPtr_AnimatorTransition(AssetDictionary<PPtr_AnimatorStateMachine, AssetList<PPtr_AnimatorTransition>> target, AssetDictionary<PPtr_AnimatorStateMachine, AssetList<PPtr_AnimatorTransition>> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_PPtr_AnimatorStateMachine_AssetList_PPtr_AnimatorTransition__AccessPairBase_PPtr_AnimatorStateMachine_AssetList_PPtr_AnimatorTransition(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E96 RID: 93846 RVA: 0x0035B40A File Offset: 0x0035960A
		public static void CopyValues__AccessPairBase_PPtr_AnimatorStateMachine_AssetList_PPtr_AnimatorTransition__AccessPairBase_PPtr_AnimatorStateMachine_AssetList_PPtr_AnimatorTransition(AccessPairBase<PPtr_AnimatorStateMachine, AssetList<PPtr_AnimatorTransition>> target, AccessPairBase<PPtr_AnimatorStateMachine, AssetList<PPtr_AnimatorTransition>> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key, converter);
				CopyValuesHelper.CopyValues__AssetList_PPtr_AnimatorTransition__AssetList_PPtr_AnimatorTransition(target.Value, source.Value, converter);
			}
		}

		// Token: 0x06016E97 RID: 93847 RVA: 0x0035B434 File Offset: 0x00359634
		public static void CopyValues__AssetList_PPtr_AnimationClip_3_4_0__AssetList_PPtr_AnimationClip_3_4_0(AssetList<PPtr_AnimationClip_3_4_0> target, AssetList<PPtr_AnimationClip_3_4_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E98 RID: 93848 RVA: 0x0035B47C File Offset: 0x0035967C
		public static void CopyValues__AssetList_SpriteVertex_4_3_0__AccessListBase_ISpriteVertex(AssetList<SpriteVertex_4_3_0> target, AccessListBase<ISpriteVertex> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E99 RID: 93849 RVA: 0x0035B4C4 File Offset: 0x003596C4
		public static void CopyValues__AssetList_SpriteVertex_4_5_0__AccessListBase_ISpriteVertex(AssetList<SpriteVertex_4_5_0> target, AccessListBase<ISpriteVertex> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E9A RID: 93850 RVA: 0x0035B50A File Offset: 0x0035970A
		public static void CopyValues__AssetPair_GUID_Int64__AssetPair_GUID_Int64(AssetPair<GUID, long> target, AssetPair<GUID, long> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value = source.Value;
			}
		}

		// Token: 0x06016E9B RID: 93851 RVA: 0x0035B52C File Offset: 0x0035972C
		public static void CopyValues__AssetDictionary_AssetPair_GUID_Int32_SpriteRenderData_4_3_0__AssetDictionary_AssetPair_GUID_Int32_SpriteRenderData_4_3_0(AssetDictionary<AssetPair<GUID, int>, SpriteRenderData_4_3_0> target, AssetDictionary<AssetPair<GUID, int>, SpriteRenderData_4_3_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_AssetPair_GUID_Int32_SpriteRenderData_4_3_0__AccessPairBase_AssetPair_GUID_Int32_SpriteRenderData_4_3_0(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E9C RID: 93852 RVA: 0x0035B57A File Offset: 0x0035977A
		public static void CopyValues__AccessPairBase_AssetPair_GUID_Int32_SpriteRenderData_4_3_0__AccessPairBase_AssetPair_GUID_Int32_SpriteRenderData_4_3_0(AccessPairBase<AssetPair<GUID, int>, SpriteRenderData_4_3_0> target, AccessPairBase<AssetPair<GUID, int>, SpriteRenderData_4_3_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				CopyValuesHelper.CopyValues__AssetPair_GUID_Int32__AssetPair_GUID_Int32(target.Key, source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016E9D RID: 93853 RVA: 0x0035B5A2 File Offset: 0x003597A2
		public static void CopyValues__AssetPair_GUID_Int32__AssetPair_GUID_Int32(AssetPair<GUID, int> target, AssetPair<GUID, int> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value = source.Value;
			}
		}

		// Token: 0x06016E9E RID: 93854 RVA: 0x0035B5C4 File Offset: 0x003597C4
		public static void CopyValues__AssetDictionary_AssetPair_GUID_Int32_SpriteRenderData_4_5_0__AssetDictionary_AssetPair_GUID_Int32_SpriteRenderData_4_5_0(AssetDictionary<AssetPair<GUID, int>, SpriteRenderData_4_5_0> target, AssetDictionary<AssetPair<GUID, int>, SpriteRenderData_4_5_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_AssetPair_GUID_Int32_SpriteRenderData_4_5_0__AccessPairBase_AssetPair_GUID_Int32_SpriteRenderData_4_5_0(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016E9F RID: 93855 RVA: 0x0035B612 File Offset: 0x00359812
		public static void CopyValues__AccessPairBase_AssetPair_GUID_Int32_SpriteRenderData_4_5_0__AccessPairBase_AssetPair_GUID_Int32_SpriteRenderData_4_5_0(AccessPairBase<AssetPair<GUID, int>, SpriteRenderData_4_5_0> target, AccessPairBase<AssetPair<GUID, int>, SpriteRenderData_4_5_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				CopyValuesHelper.CopyValues__AssetPair_GUID_Int32__AssetPair_GUID_Int32(target.Key, source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016EA0 RID: 93856 RVA: 0x0035B63C File Offset: 0x0035983C
		public static void CopyValues__AssetDictionary_AssetPair_GUID_Int64_SpriteRenderData_5_0_0__AssetDictionary_AssetPair_GUID_Int64_SpriteRenderData_5_0_0(AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_0_0> target, AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_5_0_0__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_5_0_0(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EA1 RID: 93857 RVA: 0x0035B68A File Offset: 0x0035988A
		public static void CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_5_0_0__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_5_0_0(AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_5_0_0> target, AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				CopyValuesHelper.CopyValues__AssetPair_GUID_Int64__AssetPair_GUID_Int64(target.Key, source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016EA2 RID: 93858 RVA: 0x0035B6B4 File Offset: 0x003598B4
		public static void CopyValues__AssetList_PPtr_Texture2D_5_0_0__AssetList_PPtr_Texture2D_5_0_0(AssetList<PPtr_Texture2D_5_0_0> target, AssetList<PPtr_Texture2D_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EA3 RID: 93859 RVA: 0x0035B6FC File Offset: 0x003598FC
		public static void CopyValues__AssetDictionary_AssetPair_GUID_Int64_SpriteRenderData_5_2_0__AssetDictionary_AssetPair_GUID_Int64_SpriteRenderData_5_2_0(AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_2_0> target, AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_2_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_5_2_0__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_5_2_0(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EA4 RID: 93860 RVA: 0x0035B74A File Offset: 0x0035994A
		public static void CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_5_2_0__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_5_2_0(AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_5_2_0> target, AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_5_2_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				CopyValuesHelper.CopyValues__AssetPair_GUID_Int64__AssetPair_GUID_Int64(target.Key, source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016EA5 RID: 93861 RVA: 0x0035B774 File Offset: 0x00359974
		public static void CopyValues__AssetDictionary_AssetPair_GUID_Int64_SpriteRenderData_5_4_6__AssetDictionary_AssetPair_GUID_Int64_SpriteRenderData_5_4_6(AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_4_6> target, AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_4_6> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_5_4_6__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_5_4_6(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EA6 RID: 93862 RVA: 0x0035B7C2 File Offset: 0x003599C2
		public static void CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_5_4_6__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_5_4_6(AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_5_4_6> target, AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_5_4_6> source, PPtrConverter converter)
		{
			if (source != null)
			{
				CopyValuesHelper.CopyValues__AssetPair_GUID_Int64__AssetPair_GUID_Int64(target.Key, source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016EA7 RID: 93863 RVA: 0x0035B7EC File Offset: 0x003599EC
		public static void CopyValues__AssetDictionary_AssetPair_GUID_Int64_SpriteRenderData_5_5_0__AssetDictionary_AssetPair_GUID_Int64_SpriteRenderData_5_5_0(AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_5_0> target, AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_5_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_5_5_0__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_5_5_0(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EA8 RID: 93864 RVA: 0x0035B83A File Offset: 0x00359A3A
		public static void CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_5_5_0__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_5_5_0(AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_5_5_0> target, AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_5_5_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				CopyValuesHelper.CopyValues__AssetPair_GUID_Int64__AssetPair_GUID_Int64(target.Key, source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016EA9 RID: 93865 RVA: 0x0035B864 File Offset: 0x00359A64
		public static void CopyValues__AssetDictionary_AssetPair_GUID_Int64_SpriteRenderData_5_5_3__AssetDictionary_AssetPair_GUID_Int64_SpriteRenderData_5_5_3(AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_5_3> target, AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_5_3> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_5_5_3__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_5_5_3(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EAA RID: 93866 RVA: 0x0035B8B2 File Offset: 0x00359AB2
		public static void CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_5_5_3__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_5_5_3(AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_5_5_3> target, AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_5_5_3> source, PPtrConverter converter)
		{
			if (source != null)
			{
				CopyValuesHelper.CopyValues__AssetPair_GUID_Int64__AssetPair_GUID_Int64(target.Key, source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016EAB RID: 93867 RVA: 0x0035B8DC File Offset: 0x00359ADC
		public static void CopyValues__AssetDictionary_AssetPair_GUID_Int64_SpriteRenderData_5_6_0__AssetDictionary_AssetPair_GUID_Int64_SpriteRenderData_5_6_0(AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_6_0> target, AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_6_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_5_6_0__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_5_6_0(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EAC RID: 93868 RVA: 0x0035B92A File Offset: 0x00359B2A
		public static void CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_5_6_0__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_5_6_0(AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_5_6_0> target, AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_5_6_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				CopyValuesHelper.CopyValues__AssetPair_GUID_Int64__AssetPair_GUID_Int64(target.Key, source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016EAD RID: 93869 RVA: 0x0035B954 File Offset: 0x00359B54
		public static void CopyValues__AssetDictionary_AssetPair_GUID_Int64_SpriteRenderData_5_6_0_b10__AssetDictionary_AssetPair_GUID_Int64_SpriteRenderData_5_6_0_b10(AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_6_0_b10> target, AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_6_0_b10> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_5_6_0_b10__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_5_6_0_b10(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EAE RID: 93870 RVA: 0x0035B9A2 File Offset: 0x00359BA2
		public static void CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_5_6_0_b10__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_5_6_0_b10(AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_5_6_0_b10> target, AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_5_6_0_b10> source, PPtrConverter converter)
		{
			if (source != null)
			{
				CopyValuesHelper.CopyValues__AssetPair_GUID_Int64__AssetPair_GUID_Int64(target.Key, source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016EAF RID: 93871 RVA: 0x0035B9CC File Offset: 0x00359BCC
		public static void CopyValues__AssetDictionary_AssetPair_GUID_Int64_SpriteRenderData_5_6_2__AssetDictionary_AssetPair_GUID_Int64_SpriteRenderData_5_6_2(AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_6_2> target, AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_6_2> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_5_6_2__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_5_6_2(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EB0 RID: 93872 RVA: 0x0035BA1A File Offset: 0x00359C1A
		public static void CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_5_6_2__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_5_6_2(AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_5_6_2> target, AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_5_6_2> source, PPtrConverter converter)
		{
			if (source != null)
			{
				CopyValuesHelper.CopyValues__AssetPair_GUID_Int64__AssetPair_GUID_Int64(target.Key, source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016EB1 RID: 93873 RVA: 0x0035BA44 File Offset: 0x00359C44
		public static void CopyValues__AssetDictionary_AssetPair_GUID_Int64_SpriteRenderData_2017_1_0__AssetDictionary_AssetPair_GUID_Int64_SpriteRenderData_2017_1_0(AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2017_1_0> target, AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2017_1_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_2017_1_0__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_2017_1_0(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EB2 RID: 93874 RVA: 0x0035BA92 File Offset: 0x00359C92
		public static void CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_2017_1_0__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_2017_1_0(AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_2017_1_0> target, AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_2017_1_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				CopyValuesHelper.CopyValues__AssetPair_GUID_Int64__AssetPair_GUID_Int64(target.Key, source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016EB3 RID: 93875 RVA: 0x0035BABC File Offset: 0x00359CBC
		public static void CopyValues__AssetDictionary_AssetPair_GUID_Int64_SpriteRenderData_2017_1_0_b4__AssetDictionary_AssetPair_GUID_Int64_SpriteRenderData_2017_1_0_b4(AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2017_1_0_b4> target, AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2017_1_0_b4> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_2017_1_0_b4__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_2017_1_0_b4(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EB4 RID: 93876 RVA: 0x0035BB0A File Offset: 0x00359D0A
		public static void CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_2017_1_0_b4__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_2017_1_0_b4(AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_2017_1_0_b4> target, AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_2017_1_0_b4> source, PPtrConverter converter)
		{
			if (source != null)
			{
				CopyValuesHelper.CopyValues__AssetPair_GUID_Int64__AssetPair_GUID_Int64(target.Key, source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016EB5 RID: 93877 RVA: 0x0035BB34 File Offset: 0x00359D34
		public static void CopyValues__AssetDictionary_AssetPair_GUID_Int64_SpriteRenderData_2017_3_0__AssetDictionary_AssetPair_GUID_Int64_SpriteRenderData_2017_3_0(AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2017_3_0> target, AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2017_3_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_2017_3_0__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_2017_3_0(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EB6 RID: 93878 RVA: 0x0035BB82 File Offset: 0x00359D82
		public static void CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_2017_3_0__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_2017_3_0(AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_2017_3_0> target, AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_2017_3_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				CopyValuesHelper.CopyValues__AssetPair_GUID_Int64__AssetPair_GUID_Int64(target.Key, source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016EB7 RID: 93879 RVA: 0x0035BBAC File Offset: 0x00359DAC
		public static void CopyValues__AssetDictionary_AssetPair_GUID_Int64_SpriteRenderData_2018_1_0__AssetDictionary_AssetPair_GUID_Int64_SpriteRenderData_2018_1_0(AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2018_1_0> target, AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2018_1_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_2018_1_0__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_2018_1_0(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EB8 RID: 93880 RVA: 0x0035BBFA File Offset: 0x00359DFA
		public static void CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_2018_1_0__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_2018_1_0(AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_2018_1_0> target, AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_2018_1_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				CopyValuesHelper.CopyValues__AssetPair_GUID_Int64__AssetPair_GUID_Int64(target.Key, source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016EB9 RID: 93881 RVA: 0x0035BC24 File Offset: 0x00359E24
		public static void CopyValues__AssetDictionary_AssetPair_GUID_Int64_SpriteRenderData_2018_2_0__AssetDictionary_AssetPair_GUID_Int64_SpriteRenderData_2018_2_0(AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2018_2_0> target, AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2018_2_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_2018_2_0__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_2018_2_0(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EBA RID: 93882 RVA: 0x0035BC72 File Offset: 0x00359E72
		public static void CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_2018_2_0__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_2018_2_0(AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_2018_2_0> target, AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_2018_2_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				CopyValuesHelper.CopyValues__AssetPair_GUID_Int64__AssetPair_GUID_Int64(target.Key, source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016EBB RID: 93883 RVA: 0x0035BC9C File Offset: 0x00359E9C
		public static void CopyValues__AssetDictionary_AssetPair_GUID_Int64_SpriteRenderData_2019_1_0__AssetDictionary_AssetPair_GUID_Int64_SpriteRenderData_2019_1_0(AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2019_1_0> target, AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2019_1_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_2019_1_0__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_2019_1_0(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EBC RID: 93884 RVA: 0x0035BCEA File Offset: 0x00359EEA
		public static void CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_2019_1_0__AccessPairBase_AssetPair_GUID_Int64_SpriteRenderData_2019_1_0(AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_2019_1_0> target, AccessPairBase<AssetPair<GUID, long>, SpriteRenderData_2019_1_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				CopyValuesHelper.CopyValues__AssetPair_GUID_Int64__AssetPair_GUID_Int64(target.Key, source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016EBD RID: 93885 RVA: 0x0035BD14 File Offset: 0x00359F14
		public static void CopyValues__AssetList_AnimationClipOverride_4_3_0__AccessListBase_IAnimationClipOverride(AssetList<AnimationClipOverride_4_3_0> target, AccessListBase<IAnimationClipOverride> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EBE RID: 93886 RVA: 0x0035BD5C File Offset: 0x00359F5C
		public static void CopyValues__AssetList_AnimationClipOverride_5_0_0__AccessListBase_IAnimationClipOverride(AssetList<AnimationClipOverride_5_0_0> target, AccessListBase<IAnimationClipOverride> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EBF RID: 93887 RVA: 0x0035BDA4 File Offset: 0x00359FA4
		public static void CopyValues__AssetDictionary_PPtr_Shader_5_0_0_ShaderInfo__AssetDictionary_PPtr_Shader_5_0_0_ShaderInfo(AssetDictionary<PPtr_Shader_5_0_0, ShaderInfo> target, AssetDictionary<PPtr_Shader_5_0_0, ShaderInfo> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_PPtr_Shader_5_0_0_ShaderInfo__AccessPairBase_PPtr_Shader_5_0_0_ShaderInfo(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EC0 RID: 93888 RVA: 0x0035BDF2 File Offset: 0x00359FF2
		public static void CopyValues__AccessPairBase_PPtr_Shader_5_0_0_ShaderInfo__AccessPairBase_PPtr_Shader_5_0_0_ShaderInfo(AccessPairBase<PPtr_Shader_5_0_0, ShaderInfo> target, AccessPairBase<PPtr_Shader_5_0_0, ShaderInfo> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key, converter);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016EC1 RID: 93889 RVA: 0x0035BE1C File Offset: 0x0035A01C
		public static void CopyValues__AssetList_VariantInfo__AssetList_VariantInfo(AssetList<VariantInfo> target, AssetList<VariantInfo> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EC2 RID: 93890 RVA: 0x0035BE64 File Offset: 0x0035A064
		public static void CopyValues__AssetList_Vector4f_3_5_0__AssetList_Vector4f_3_5_0(AssetList<Vector4f_3_5_0> target, AssetList<Vector4f_3_5_0> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EC3 RID: 93891 RVA: 0x0035BEAC File Offset: 0x0035A0AC
		public static void CopyValues__AssetList_PPtr_Material_5_0_0__AssetList_PPtr_Material_5_0_0(AssetList<PPtr_Material_5_0_0> target, AssetList<PPtr_Material_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EC4 RID: 93892 RVA: 0x0035BEF4 File Offset: 0x0035A0F4
		public static void CopyValues__AssetList_HeightmapData_5_0_0__AccessListBase_IHeightmapData(AssetList<HeightmapData_5_0_0> target, AccessListBase<IHeightmapData> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EC5 RID: 93893 RVA: 0x0035BF3C File Offset: 0x0035A13C
		public static void CopyValues__AssetList_HeightMeshData_5_0_0__AccessListBase_IHeightMeshData(AssetList<HeightMeshData_5_0_0> target, AccessListBase<IHeightMeshData> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EC6 RID: 93894 RVA: 0x0035BF84 File Offset: 0x0035A184
		public static void CopyValues__AssetList_HeightMeshBVNode__AssetList_HeightMeshBVNode(AssetList<HeightMeshBVNode> target, AssetList<HeightMeshBVNode> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EC7 RID: 93895 RVA: 0x0035BFCC File Offset: 0x0035A1CC
		public static void CopyValues__AssetList_NavMeshTileData_5_0_0__AccessListBase_INavMeshTileData(AssetList<NavMeshTileData_5_0_0> target, AccessListBase<INavMeshTileData> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EC8 RID: 93896 RVA: 0x0035C014 File Offset: 0x0035A214
		public static void CopyValues__AssetList_AutoOffMeshLinkData__AssetList_AutoOffMeshLinkData(AssetList<AutoOffMeshLinkData> target, AssetList<AutoOffMeshLinkData> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EC9 RID: 93897 RVA: 0x0035C05C File Offset: 0x0035A25C
		public static void CopyValues__AssetList_NavMeshTileData_5_6_0__AccessListBase_INavMeshTileData(AssetList<NavMeshTileData_5_6_0> target, AccessListBase<INavMeshTileData> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016ECA RID: 93898 RVA: 0x0035C0A4 File Offset: 0x0035A2A4
		public static void CopyValues__AssetList_HeightMeshData_2017_1_0__AccessListBase_IHeightMeshData(AssetList<HeightMeshData_2017_1_0> target, AccessListBase<IHeightMeshData> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016ECB RID: 93899 RVA: 0x0035C0EC File Offset: 0x0035A2EC
		public static void CopyValues__AssetList_HeightmapData_2022_2_0__AccessListBase_IHeightmapData(AssetList<HeightmapData_2022_2_0> target, AccessListBase<IHeightmapData> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016ECC RID: 93900 RVA: 0x0035C134 File Offset: 0x0035A334
		public static void CopyValues__AssetList_EffectConstant__AssetList_EffectConstant(AssetList<EffectConstant> target, AssetList<EffectConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016ECD RID: 93901 RVA: 0x0035C17C File Offset: 0x0035A37C
		public static void CopyValues__AssetList_GroupConstant_5_0_0__AccessListBase_IGroupConstant(AssetList<GroupConstant_5_0_0> target, AccessListBase<IGroupConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016ECE RID: 93902 RVA: 0x0035C1C4 File Offset: 0x0035A3C4
		public static void CopyValues__AssetList_SnapshotConstant__AssetList_SnapshotConstant(AssetList<SnapshotConstant> target, AssetList<SnapshotConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016ECF RID: 93903 RVA: 0x0035C20C File Offset: 0x0035A40C
		public static void CopyValues__AssetList_GroupConstant_2019_1_0_a13__AccessListBase_IGroupConstant(AssetList<GroupConstant_2019_1_0_a13> target, AccessListBase<IGroupConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016ED0 RID: 93904 RVA: 0x0035C254 File Offset: 0x0035A454
		public static void CopyValues__AssetList_GroupConstant_2019_4_32__AccessListBase_IGroupConstant(AssetList<GroupConstant_2019_4_32> target, AccessListBase<IGroupConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016ED1 RID: 93905 RVA: 0x0035C29C File Offset: 0x0035A49C
		public static void CopyValues__AssetList_GroupConstant_2020_1_0__AccessListBase_IGroupConstant(AssetList<GroupConstant_2020_1_0> target, AccessListBase<IGroupConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016ED2 RID: 93906 RVA: 0x0035C2E4 File Offset: 0x0035A4E4
		public static void CopyValues__AssetList_GroupConstant_2020_3_21__AccessListBase_IGroupConstant(AssetList<GroupConstant_2020_3_21> target, AccessListBase<IGroupConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016ED3 RID: 93907 RVA: 0x0035C32C File Offset: 0x0035A52C
		public static void CopyValues__AssetList_GroupConstant_2021_1_0__AccessListBase_IGroupConstant(AssetList<GroupConstant_2021_1_0> target, AccessListBase<IGroupConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016ED4 RID: 93908 RVA: 0x0035C374 File Offset: 0x0035A574
		public static void CopyValues__AssetList_GroupConstant_2021_1_26__AccessListBase_IGroupConstant(AssetList<GroupConstant_2021_1_26> target, AccessListBase<IGroupConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016ED5 RID: 93909 RVA: 0x0035C3BC File Offset: 0x0035A5BC
		public static void CopyValues__AssetList_GroupConstant_2021_2_0__AccessListBase_IGroupConstant(AssetList<GroupConstant_2021_2_0> target, AccessListBase<IGroupConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016ED6 RID: 93910 RVA: 0x0035C404 File Offset: 0x0035A604
		public static void CopyValues__AssetList_GroupConnection__AssetList_GroupConnection(AssetList<GroupConnection> target, AssetList<GroupConnection> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016ED7 RID: 93911 RVA: 0x0035C44C File Offset: 0x0035A64C
		public static void CopyValues__AssetList_GroupConstant_2021_2_0_a16__AccessListBase_IGroupConstant(AssetList<GroupConstant_2021_2_0_a16> target, AccessListBase<IGroupConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016ED8 RID: 93912 RVA: 0x0035C494 File Offset: 0x0035A694
		public static void CopyValues__AssetList_GroupConstant_2021_2_0_a21__AccessListBase_IGroupConstant(AssetList<GroupConstant_2021_2_0_a21> target, AccessListBase<IGroupConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016ED9 RID: 93913 RVA: 0x0035C4DC File Offset: 0x0035A6DC
		public static void CopyValues__AssetList_GroupConstant_2021_2_1__AccessListBase_IGroupConstant(AssetList<GroupConstant_2021_2_1> target, AccessListBase<IGroupConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EDA RID: 93914 RVA: 0x0035C524 File Offset: 0x0035A724
		public static void CopyValues__AssetList_GroupConstant_2022_1_0__AccessListBase_IGroupConstant(AssetList<GroupConstant_2022_1_0> target, AccessListBase<IGroupConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EDB RID: 93915 RVA: 0x0035C56C File Offset: 0x0035A76C
		public static void CopyValues__AssetList_GroupConstant_2022_1_0_a10__AccessListBase_IGroupConstant(AssetList<GroupConstant_2022_1_0_a10> target, AccessListBase<IGroupConstant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EDC RID: 93916 RVA: 0x0035C5B4 File Offset: 0x0035A7B4
		public static void CopyValues__AssetList_PPtr_AudioMixerSnapshot__AssetList_PPtr_AudioMixerSnapshot(AssetList<PPtr_AudioMixerSnapshot> target, AssetList<PPtr_AudioMixerSnapshot> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EDD RID: 93917 RVA: 0x0035C5FC File Offset: 0x0035A7FC
		public static void CopyValues__AssetList_AudioMixerGroupView_5_0_0__AccessListBase_IAudioMixerGroupView(AssetList<AudioMixerGroupView_5_0_0> target, AccessListBase<IAudioMixerGroupView> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EDE RID: 93918 RVA: 0x0035C644 File Offset: 0x0035A844
		public static void CopyValues__AssetList_ExposedAudioParameter__AssetList_ExposedAudioParameter(AssetList<ExposedAudioParameter> target, AssetList<ExposedAudioParameter> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EDF RID: 93919 RVA: 0x0035C68C File Offset: 0x0035A88C
		public static void CopyValues__AssetList_AudioMixerGroupView_2017_1_0__AccessListBase_IAudioMixerGroupView(AssetList<AudioMixerGroupView_2017_1_0> target, AccessListBase<IAudioMixerGroupView> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EE0 RID: 93920 RVA: 0x0035C6D4 File Offset: 0x0035A8D4
		public static void CopyValues__AssetList_PPtr_AudioMixerGroup__AssetList_PPtr_AudioMixerGroup(AssetList<PPtr_AudioMixerGroup> target, AssetList<PPtr_AudioMixerGroup> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EE1 RID: 93921 RVA: 0x0035C71C File Offset: 0x0035A91C
		public static void CopyValues__AssetList_PPtr_AudioMixerEffectController__AssetList_PPtr_AudioMixerEffectController(AssetList<PPtr_AudioMixerEffectController> target, AssetList<PPtr_AudioMixerEffectController> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EE2 RID: 93922 RVA: 0x0035C764 File Offset: 0x0035A964
		public static void CopyValues__AssetList_Parameter__AssetList_Parameter(AssetList<Parameter> target, AssetList<Parameter> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EE3 RID: 93923 RVA: 0x0035C7AC File Offset: 0x0035A9AC
		public static void CopyValues__AssetDictionary_GUID_Single__AssetDictionary_GUID_Single(AssetDictionary<GUID, float> target, AssetDictionary<GUID, float> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_GUID_Single__AccessPairBase_GUID_Single(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EE4 RID: 93924 RVA: 0x0035C7F9 File Offset: 0x0035A9F9
		public static void CopyValues__AccessPairBase_GUID_Single__AccessPairBase_GUID_Single(AccessPairBase<GUID, float> target, AccessPairBase<GUID, float> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value = source.Value;
			}
		}

		// Token: 0x06016EE5 RID: 93925 RVA: 0x0035C81C File Offset: 0x0035AA1C
		public static void CopyValues__AssetDictionary_GUID_Int32__AssetDictionary_GUID_Int32(AssetDictionary<GUID, int> target, AssetDictionary<GUID, int> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_GUID_Int32__AccessPairBase_GUID_Int32(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EE6 RID: 93926 RVA: 0x0035C869 File Offset: 0x0035AA69
		public static void CopyValues__AccessPairBase_GUID_Int32__AccessPairBase_GUID_Int32(AccessPairBase<GUID, int> target, AccessPairBase<GUID, int> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value = source.Value;
			}
		}

		// Token: 0x06016EE7 RID: 93927 RVA: 0x0035C88C File Offset: 0x0035AA8C
		public static void CopyValues__AssetList_SphericalHarmonicsL2_5_0_0__AssetList_SphericalHarmonicsL2_5_0_0(AssetList<SphericalHarmonicsL2_5_0_0> target, AssetList<SphericalHarmonicsL2_5_0_0> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EE8 RID: 93928 RVA: 0x0035C8D4 File Offset: 0x0035AAD4
		public static void CopyValues__AssetDictionary_Hash128_Int32__AssetDictionary_Hash128_Int32(AssetDictionary<Hash128, int> target, AssetDictionary<Hash128, int> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Hash128_Int32__AccessPairBase_Hash128_Int32(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EE9 RID: 93929 RVA: 0x0035C921 File Offset: 0x0035AB21
		public static void CopyValues__AccessPairBase_Hash128_Int32__AccessPairBase_Hash128_Int32(AccessPairBase<Hash128, int> target, AccessPairBase<Hash128, int> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value = source.Value;
			}
		}

		// Token: 0x06016EEA RID: 93930 RVA: 0x0035C944 File Offset: 0x0035AB44
		public static void CopyValues__AssetList_ProbeSetIndex__AssetList_ProbeSetIndex(AssetList<ProbeSetIndex> target, AssetList<ProbeSetIndex> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EEB RID: 93931 RVA: 0x0035C98C File Offset: 0x0035AB8C
		public static void CopyValues__AssetList_Tetrahedron_3_5_0__AccessListBase_ITetrahedron(AssetList<Tetrahedron_3_5_0> target, AccessListBase<ITetrahedron> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EEC RID: 93932 RVA: 0x0035C9D4 File Offset: 0x0035ABD4
		public static void CopyValues__AssetList_Tetrahedron_2019_4_19__AccessListBase_ITetrahedron(AssetList<Tetrahedron_2019_4_19> target, AccessListBase<ITetrahedron> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EED RID: 93933 RVA: 0x0035CA1C File Offset: 0x0035AC1C
		public static void CopyValues__AssetList_Tetrahedron_2020_1_0__AccessListBase_ITetrahedron(AssetList<Tetrahedron_2020_1_0> target, AccessListBase<ITetrahedron> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EEE RID: 93934 RVA: 0x0035CA64 File Offset: 0x0035AC64
		public static void CopyValues__AssetList_Tetrahedron_2020_1_0_a9__AccessListBase_ITetrahedron(AssetList<Tetrahedron_2020_1_0_a9> target, AccessListBase<ITetrahedron> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EEF RID: 93935 RVA: 0x0035CAAC File Offset: 0x0035ACAC
		public static void CopyValues__AssetList_LightProbeOcclusion_5_4_0__AccessListBase_ILightProbeOcclusion(AssetList<LightProbeOcclusion_5_4_0> target, AccessListBase<ILightProbeOcclusion> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EF0 RID: 93936 RVA: 0x0035CAF4 File Offset: 0x0035ACF4
		public static void CopyValues__AssetList_LightProbeOcclusion_5_6_0_b2__AccessListBase_ILightProbeOcclusion(AssetList<LightProbeOcclusion_5_6_0_b2> target, AccessListBase<ILightProbeOcclusion> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EF1 RID: 93937 RVA: 0x0035CB3C File Offset: 0x0035AD3C
		public static void CopyValues__AssetList_LightProbeOcclusion_5_6_0_b5__AccessListBase_ILightProbeOcclusion(AssetList<LightProbeOcclusion_5_6_0_b5> target, AccessListBase<ILightProbeOcclusion> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EF2 RID: 93938 RVA: 0x0035CB84 File Offset: 0x0035AD84
		public static void CopyValues__AssetDictionary_Int32_AssetBundleInfo__AssetDictionary_Int32_AssetBundleInfo(AssetDictionary<int, AssetBundleInfo> target, AssetDictionary<int, AssetBundleInfo> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Int32_AssetBundleInfo__AccessPairBase_Int32_AssetBundleInfo(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EF3 RID: 93939 RVA: 0x0035CBD1 File Offset: 0x0035ADD1
		public static void CopyValues__AccessPairBase_Int32_AssetBundleInfo__AccessPairBase_Int32_AssetBundleInfo(AccessPairBase<int, AssetBundleInfo> target, AccessPairBase<int, AssetBundleInfo> source)
		{
			if (source != null)
			{
				target.Key = source.Key;
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016EF4 RID: 93940 RVA: 0x0035CBF4 File Offset: 0x0035ADF4
		public static void CopyValues__AssetList_ClassInfo_5_0_0__AccessListBase_IClassInfo(AssetList<ClassInfo_5_0_0> target, AccessListBase<IClassInfo> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EF5 RID: 93941 RVA: 0x0035CC3C File Offset: 0x0035AE3C
		public static void CopyValues__AssetList_ClassMethodInfo__AssetList_ClassMethodInfo(AssetList<ClassMethodInfo> target, AssetList<ClassMethodInfo> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EF6 RID: 93942 RVA: 0x0035CC84 File Offset: 0x0035AE84
		public static void CopyValues__AssetList_ClassInfo_2019_4_29__AccessListBase_IClassInfo(AssetList<ClassInfo_2019_4_29> target, AccessListBase<IClassInfo> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EF7 RID: 93943 RVA: 0x0035CCCC File Offset: 0x0035AECC
		public static void CopyValues__AssetList_ClassInfo_2020_1_0__AccessListBase_IClassInfo(AssetList<ClassInfo_2020_1_0> target, AccessListBase<IClassInfo> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EF8 RID: 93944 RVA: 0x0035CD14 File Offset: 0x0035AF14
		public static void CopyValues__AssetList_AnimatorCondition_5_0_0__AssetList_AnimatorCondition_5_0_0(AssetList<AnimatorCondition_5_0_0> target, AssetList<AnimatorCondition_5_0_0> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EF9 RID: 93945 RVA: 0x0035CD5C File Offset: 0x0035AF5C
		public static void CopyValues__AssetList_PerLODSettings_5_0_0__AccessListBase_IPerLODSettings(AssetList<PerLODSettings_5_0_0> target, AccessListBase<IPerLODSettings> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EFA RID: 93946 RVA: 0x0035CDA4 File Offset: 0x0035AFA4
		public static void CopyValues__AssetList_PerLODSettings_2018_3_0__AccessListBase_IPerLODSettings(AssetList<PerLODSettings_2018_3_0> target, AccessListBase<IPerLODSettings> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EFB RID: 93947 RVA: 0x0035CDEC File Offset: 0x0035AFEC
		public static void CopyValues__AssetList_PPtr_Texture_5_0_0__AssetList_PPtr_Texture_5_0_0(AssetList<PPtr_Texture_5_0_0> target, AssetList<PPtr_Texture_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EFC RID: 93948 RVA: 0x0035CE34 File Offset: 0x0035B034
		public static void CopyValues__AssetList_SceneObjectIdentifier__AssetList_SceneObjectIdentifier(AssetList<SceneObjectIdentifier> target, AssetList<SceneObjectIdentifier> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EFD RID: 93949 RVA: 0x0035CE7C File Offset: 0x0035B07C
		public static void CopyValues__AssetList_RendererData_5_0_0__AccessListBase_IRendererData(AssetList<RendererData_5_0_0> target, AccessListBase<IRendererData> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EFE RID: 93950 RVA: 0x0035CEC4 File Offset: 0x0035B0C4
		public static void CopyValues__AssetList_LightBakingOutput_5_6_0_b2__AccessListBase_ILightBakingOutput(AssetList<LightBakingOutput_5_6_0_b2> target, AccessListBase<ILightBakingOutput> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016EFF RID: 93951 RVA: 0x0035CF0C File Offset: 0x0035B10C
		public static void CopyValues__AssetList_LightBakingOutput_5_6_0_b5__AccessListBase_ILightBakingOutput(AssetList<LightBakingOutput_5_6_0_b5> target, AccessListBase<ILightBakingOutput> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F00 RID: 93952 RVA: 0x0035CF54 File Offset: 0x0035B154
		public static void CopyValues__AssetList_LightBakingOutput_2017_3_0__AccessListBase_ILightBakingOutput(AssetList<LightBakingOutput_2017_3_0> target, AccessListBase<ILightBakingOutput> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F01 RID: 93953 RVA: 0x0035CF9C File Offset: 0x0035B19C
		public static void CopyValues__AssetList_RendererData_2018_2_0__AccessListBase_IRendererData(AssetList<RendererData_2018_2_0> target, AccessListBase<IRendererData> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F02 RID: 93954 RVA: 0x0035CFE4 File Offset: 0x0035B1E4
		public static void CopyValues__AssetList_SketchUpImportScene_5_1_0__AccessListBase_ISketchUpImportScene(AssetList<SketchUpImportScene_5_1_0> target, AccessListBase<ISketchUpImportScene> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F03 RID: 93955 RVA: 0x0035D02C File Offset: 0x0035B22C
		public static void CopyValues__AssetList_SketchUpImportScene_2019_1_0__AccessListBase_ISketchUpImportScene(AssetList<SketchUpImportScene_2019_1_0> target, AccessListBase<ISketchUpImportScene> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F04 RID: 93956 RVA: 0x0035D074 File Offset: 0x0035B274
		public static void CopyValues__AssetDictionary_IntegerString_2017_1_0_PPtr_Object_5_0_0__AssetDictionary_IntegerString_2017_1_0_PPtr_Object_5_0_0(AssetDictionary<IntegerString_2017_1_0, PPtr_Object_5_0_0> target, AssetDictionary<IntegerString_2017_1_0, PPtr_Object_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_IntegerString_2017_1_0_PPtr_Object_5_0_0__AccessPairBase_IntegerString_2017_1_0_PPtr_Object_5_0_0(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F05 RID: 93957 RVA: 0x0035D0C2 File Offset: 0x0035B2C2
		public static void CopyValues__AccessPairBase_IntegerString_2017_1_0_PPtr_Object_5_0_0__AccessPairBase_IntegerString_2017_1_0_PPtr_Object_5_0_0(AccessPairBase<IntegerString_2017_1_0, PPtr_Object_5_0_0> target, AccessPairBase<IntegerString_2017_1_0, PPtr_Object_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016F06 RID: 93958 RVA: 0x0035D0EC File Offset: 0x0035B2EC
		public static void CopyValues__AssetDictionary_NestedString_2018_4_25_PPtr_Object_5_0_0__AssetDictionary_NestedString_2018_4_25_PPtr_Object_5_0_0(AssetDictionary<NestedString_2018_4_25, PPtr_Object_5_0_0> target, AssetDictionary<NestedString_2018_4_25, PPtr_Object_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_NestedString_2018_4_25_PPtr_Object_5_0_0__AccessPairBase_NestedString_2018_4_25_PPtr_Object_5_0_0(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F07 RID: 93959 RVA: 0x0035D13A File Offset: 0x0035B33A
		public static void CopyValues__AccessPairBase_NestedString_2018_4_25_PPtr_Object_5_0_0__AccessPairBase_NestedString_2018_4_25_PPtr_Object_5_0_0(AccessPairBase<NestedString_2018_4_25, PPtr_Object_5_0_0> target, AccessPairBase<NestedString_2018_4_25, PPtr_Object_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016F08 RID: 93960 RVA: 0x0035D164 File Offset: 0x0035B364
		public static void CopyValues__AssetDictionary_IntegerString_2019_1_0_PPtr_Object_5_0_0__AssetDictionary_IntegerString_2019_1_0_PPtr_Object_5_0_0(AssetDictionary<IntegerString_2019_1_0, PPtr_Object_5_0_0> target, AssetDictionary<IntegerString_2019_1_0, PPtr_Object_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_IntegerString_2019_1_0_PPtr_Object_5_0_0__AccessPairBase_IntegerString_2019_1_0_PPtr_Object_5_0_0(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F09 RID: 93961 RVA: 0x0035D1B2 File Offset: 0x0035B3B2
		public static void CopyValues__AccessPairBase_IntegerString_2019_1_0_PPtr_Object_5_0_0__AccessPairBase_IntegerString_2019_1_0_PPtr_Object_5_0_0(AccessPairBase<IntegerString_2019_1_0, PPtr_Object_5_0_0> target, AccessPairBase<IntegerString_2019_1_0, PPtr_Object_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016F0A RID: 93962 RVA: 0x0035D1DC File Offset: 0x0035B3DC
		public static void CopyValues__AssetDictionary_NestedString_2019_4_3_PPtr_Object_5_0_0__AssetDictionary_NestedString_2019_4_3_PPtr_Object_5_0_0(AssetDictionary<NestedString_2019_4_3, PPtr_Object_5_0_0> target, AssetDictionary<NestedString_2019_4_3, PPtr_Object_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_NestedString_2019_4_3_PPtr_Object_5_0_0__AccessPairBase_NestedString_2019_4_3_PPtr_Object_5_0_0(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F0B RID: 93963 RVA: 0x0035D22A File Offset: 0x0035B42A
		public static void CopyValues__AccessPairBase_NestedString_2019_4_3_PPtr_Object_5_0_0__AccessPairBase_NestedString_2019_4_3_PPtr_Object_5_0_0(AccessPairBase<NestedString_2019_4_3, PPtr_Object_5_0_0> target, AccessPairBase<NestedString_2019_4_3, PPtr_Object_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016F0C RID: 93964 RVA: 0x0035D254 File Offset: 0x0035B454
		public static void CopyValues__AssetDictionary_IntegerString_2020_1_0_PPtr_Object_5_0_0__AssetDictionary_IntegerString_2020_1_0_PPtr_Object_5_0_0(AssetDictionary<IntegerString_2020_1_0, PPtr_Object_5_0_0> target, AssetDictionary<IntegerString_2020_1_0, PPtr_Object_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_IntegerString_2020_1_0_PPtr_Object_5_0_0__AccessPairBase_IntegerString_2020_1_0_PPtr_Object_5_0_0(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F0D RID: 93965 RVA: 0x0035D2A2 File Offset: 0x0035B4A2
		public static void CopyValues__AccessPairBase_IntegerString_2020_1_0_PPtr_Object_5_0_0__AccessPairBase_IntegerString_2020_1_0_PPtr_Object_5_0_0(AccessPairBase<IntegerString_2020_1_0, PPtr_Object_5_0_0> target, AccessPairBase<IntegerString_2020_1_0, PPtr_Object_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016F0E RID: 93966 RVA: 0x0035D2CC File Offset: 0x0035B4CC
		public static void CopyValues__AssetDictionary_NestedString_2020_1_0_b15_PPtr_Object_5_0_0__AssetDictionary_NestedString_2020_1_0_b15_PPtr_Object_5_0_0(AssetDictionary<NestedString_2020_1_0_b15, PPtr_Object_5_0_0> target, AssetDictionary<NestedString_2020_1_0_b15, PPtr_Object_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_NestedString_2020_1_0_b15_PPtr_Object_5_0_0__AccessPairBase_NestedString_2020_1_0_b15_PPtr_Object_5_0_0(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F0F RID: 93967 RVA: 0x0035D31A File Offset: 0x0035B51A
		public static void CopyValues__AccessPairBase_NestedString_2020_1_0_b15_PPtr_Object_5_0_0__AccessPairBase_NestedString_2020_1_0_b15_PPtr_Object_5_0_0(AccessPairBase<NestedString_2020_1_0_b15, PPtr_Object_5_0_0> target, AccessPairBase<NestedString_2020_1_0_b15, PPtr_Object_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016F10 RID: 93968 RVA: 0x0035D344 File Offset: 0x0035B544
		public static void CopyValues__AssetDictionary_IntegerString_2020_2_0_PPtr_Object_5_0_0__AssetDictionary_IntegerString_2020_2_0_PPtr_Object_5_0_0(AssetDictionary<IntegerString_2020_2_0, PPtr_Object_5_0_0> target, AssetDictionary<IntegerString_2020_2_0, PPtr_Object_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_IntegerString_2020_2_0_PPtr_Object_5_0_0__AccessPairBase_IntegerString_2020_2_0_PPtr_Object_5_0_0(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F11 RID: 93969 RVA: 0x0035D392 File Offset: 0x0035B592
		public static void CopyValues__AccessPairBase_IntegerString_2020_2_0_PPtr_Object_5_0_0__AccessPairBase_IntegerString_2020_2_0_PPtr_Object_5_0_0(AccessPairBase<IntegerString_2020_2_0, PPtr_Object_5_0_0> target, AccessPairBase<IntegerString_2020_2_0, PPtr_Object_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016F12 RID: 93970 RVA: 0x0035D3BC File Offset: 0x0035B5BC
		public static void CopyValues__AssetDictionary_NestedString_2020_2_0_a16_PPtr_Object_5_0_0__AssetDictionary_NestedString_2020_2_0_a16_PPtr_Object_5_0_0(AssetDictionary<NestedString_2020_2_0_a16, PPtr_Object_5_0_0> target, AssetDictionary<NestedString_2020_2_0_a16, PPtr_Object_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_NestedString_2020_2_0_a16_PPtr_Object_5_0_0__AccessPairBase_NestedString_2020_2_0_a16_PPtr_Object_5_0_0(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F13 RID: 93971 RVA: 0x0035D40A File Offset: 0x0035B60A
		public static void CopyValues__AccessPairBase_NestedString_2020_2_0_a16_PPtr_Object_5_0_0__AccessPairBase_NestedString_2020_2_0_a16_PPtr_Object_5_0_0(AccessPairBase<NestedString_2020_2_0_a16, PPtr_Object_5_0_0> target, AccessPairBase<NestedString_2020_2_0_a16, PPtr_Object_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016F14 RID: 93972 RVA: 0x0035D434 File Offset: 0x0035B634
		public static void CopyValues__AssetList_DirectorGenericBinding__AssetList_DirectorGenericBinding(AssetList<DirectorGenericBinding> target, AssetList<DirectorGenericBinding> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F15 RID: 93973 RVA: 0x0035D47C File Offset: 0x0035B67C
		public static void CopyValues__AssetList_ClusterInput__AssetList_ClusterInput(AssetList<ClusterInput> target, AssetList<ClusterInput> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F16 RID: 93974 RVA: 0x0035D4C4 File Offset: 0x0035B6C4
		public static void CopyValues__AssetList_BuildStepInfo_5_4_0__AccessListBase_IBuildStepInfo(AssetList<BuildStepInfo_5_4_0> target, AccessListBase<IBuildStepInfo> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F17 RID: 93975 RVA: 0x0035D50C File Offset: 0x0035B70C
		public static void CopyValues__AssetList_BuildStepMessage__AssetList_BuildStepMessage(AssetList<BuildStepMessage> target, AssetList<BuildStepMessage> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F18 RID: 93976 RVA: 0x0035D554 File Offset: 0x0035B754
		public static void CopyValues__AssetList_BuildReportFile__AssetList_BuildReportFile(AssetList<BuildReportFile> target, AssetList<BuildReportFile> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F19 RID: 93977 RVA: 0x0035D59C File Offset: 0x0035B79C
		public static void CopyValues__AssetList_BuildStepInfo_2017_1_0__AccessListBase_IBuildStepInfo(AssetList<BuildStepInfo_2017_1_0> target, AccessListBase<IBuildStepInfo> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F1A RID: 93978 RVA: 0x0035D5E4 File Offset: 0x0035B7E4
		public static void CopyValues__AssetList_BuildStepInfo_2018_1_0__AccessListBase_IBuildStepInfo(AssetList<BuildStepInfo_2018_1_0> target, AccessListBase<IBuildStepInfo> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F1B RID: 93979 RVA: 0x0035D62C File Offset: 0x0035B82C
		public static void CopyValues__AssetList_BuildReportPackedAssetInfo_5_4_0__AccessListBase_IBuildReportPackedAssetInfo(AssetList<BuildReportPackedAssetInfo_5_4_0> target, AccessListBase<IBuildReportPackedAssetInfo> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F1C RID: 93980 RVA: 0x0035D674 File Offset: 0x0035B874
		public static void CopyValues__AssetList_BuildReportPackedAssetInfo_5_4_2__AccessListBase_IBuildReportPackedAssetInfo(AssetList<BuildReportPackedAssetInfo_5_4_2> target, AccessListBase<IBuildReportPackedAssetInfo> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F1D RID: 93981 RVA: 0x0035D6BC File Offset: 0x0035B8BC
		public static void CopyValues__AssetList_BuildReportPackedAssetInfo_5_5_0__AccessListBase_IBuildReportPackedAssetInfo(AssetList<BuildReportPackedAssetInfo_5_5_0> target, AccessListBase<IBuildReportPackedAssetInfo> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F1E RID: 93982 RVA: 0x0035D704 File Offset: 0x0035B904
		public static void CopyValues__AssetList_BuildReportPackedAssetInfo_2019_3_0_a8__AccessListBase_IBuildReportPackedAssetInfo(AssetList<BuildReportPackedAssetInfo_2019_3_0_a8> target, AccessListBase<IBuildReportPackedAssetInfo> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F1F RID: 93983 RVA: 0x0035D74C File Offset: 0x0035B94C
		public static void CopyValues__AssetList_OcclusionScene__AssetList_OcclusionScene(AssetList<OcclusionScene> target, AssetList<OcclusionScene> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F20 RID: 93984 RVA: 0x0035D794 File Offset: 0x0035B994
		public static void CopyValues__AssetList_BuiltAssetBundleInfo_5_5_4__AssetList_BuiltAssetBundleInfo_5_5_4(AssetList<BuiltAssetBundleInfo_5_5_4> target, AssetList<BuiltAssetBundleInfo_5_5_4> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F21 RID: 93985 RVA: 0x0035D7DC File Offset: 0x0035B9DC
		public static void CopyValues__AssetDictionary_Int32_VideoClipImporterTargetSettings__AssetDictionary_Int32_VideoClipImporterTargetSettings(AssetDictionary<int, VideoClipImporterTargetSettings> target, AssetDictionary<int, VideoClipImporterTargetSettings> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Int32_VideoClipImporterTargetSettings__AccessPairBase_Int32_VideoClipImporterTargetSettings(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F22 RID: 93986 RVA: 0x0035D829 File Offset: 0x0035BA29
		public static void CopyValues__AccessPairBase_Int32_VideoClipImporterTargetSettings__AccessPairBase_Int32_VideoClipImporterTargetSettings(AccessPairBase<int, VideoClipImporterTargetSettings> target, AccessPairBase<int, VideoClipImporterTargetSettings> source)
		{
			if (source != null)
			{
				target.Key = source.Key;
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016F23 RID: 93987 RVA: 0x0035D84C File Offset: 0x0035BA4C
		public static void CopyValues__AssetList_SubCollider_5_6_0__AccessListBase_ISubCollider(AssetList<SubCollider_5_6_0> target, AccessListBase<ISubCollider> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F24 RID: 93988 RVA: 0x0035D894 File Offset: 0x0035BA94
		public static void CopyValues__AssetList_AssetList_Vector2Long__AssetList_AssetList_Vector2Long(AssetList<AssetList<Vector2Long>> target, AssetList<AssetList<Vector2Long>> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					CopyValuesHelper.CopyValues__AssetList_Vector2Long__AssetList_Vector2Long(target.AddNew(), source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F25 RID: 93989 RVA: 0x0035D8DC File Offset: 0x0035BADC
		public static void CopyValues__AssetList_Vector2Long__AssetList_Vector2Long(AssetList<Vector2Long> target, AssetList<Vector2Long> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F26 RID: 93990 RVA: 0x0035D924 File Offset: 0x0035BB24
		public static void CopyValues__AssetList_SubCollider_2017_1_0__AccessListBase_ISubCollider(AssetList<SubCollider_2017_1_0> target, AccessListBase<ISubCollider> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F27 RID: 93991 RVA: 0x0035D96C File Offset: 0x0035BB6C
		public static void CopyValues__AssetList_UpdateZoneInfo__AssetList_UpdateZoneInfo(AssetList<UpdateZoneInfo> target, AssetList<UpdateZoneInfo> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F28 RID: 93992 RVA: 0x0035D9B4 File Offset: 0x0035BBB4
		public static void CopyValues__AssetList_PPtr_AudioSource__AssetList_PPtr_AudioSource(AssetList<PPtr_AudioSource> target, AssetList<PPtr_AudioSource> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F29 RID: 93993 RVA: 0x0035D9FC File Offset: 0x0035BBFC
		public static void CopyValues__AssetList_AnimationEvent_5_0_0__AssetList_AnimationEvent_5_0_0(AssetList<AnimationEvent_5_0_0> target, AssetList<AnimationEvent_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F2A RID: 93994 RVA: 0x0035DA44 File Offset: 0x0035BC44
		public static void CopyValues__AssetList_BuiltAssetBundleInfo_5_6_2__AccessListBase_IBuiltAssetBundleInfo(AssetList<BuiltAssetBundleInfo_5_6_2> target, AccessListBase<IBuiltAssetBundleInfo> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F2B RID: 93995 RVA: 0x0035DA8C File Offset: 0x0035BC8C
		public static void CopyValues__AssetList_BuiltAssetBundleInfo_2017_1_0_b4__AccessListBase_IBuiltAssetBundleInfo(AssetList<BuiltAssetBundleInfo_2017_1_0_b4> target, AccessListBase<IBuiltAssetBundleInfo> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F2C RID: 93996 RVA: 0x0035DAD4 File Offset: 0x0035BCD4
		public static void CopyValues__AssetList_PPtr_SpriteAtlas__AssetList_PPtr_SpriteAtlas(AssetList<PPtr_SpriteAtlas> target, AssetList<PPtr_SpriteAtlas> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F2D RID: 93997 RVA: 0x0035DB1C File Offset: 0x0035BD1C
		public static void CopyValues__AssetDictionary_Utf8String_AssetList_PPtr_SpriteAtlas__AssetDictionary_Utf8String_AssetList_PPtr_SpriteAtlas(AssetDictionary<Utf8String, AssetList<PPtr_SpriteAtlas>> target, AssetDictionary<Utf8String, AssetList<PPtr_SpriteAtlas>> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_AssetList_PPtr_SpriteAtlas__AccessPairBase_Utf8String_AssetList_PPtr_SpriteAtlas(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F2E RID: 93998 RVA: 0x0035DB6A File Offset: 0x0035BD6A
		public static void CopyValues__AccessPairBase_Utf8String_AssetList_PPtr_SpriteAtlas__AccessPairBase_Utf8String_AssetList_PPtr_SpriteAtlas(AccessPairBase<Utf8String, AssetList<PPtr_SpriteAtlas>> target, AccessPairBase<Utf8String, AssetList<PPtr_SpriteAtlas>> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				CopyValuesHelper.CopyValues__AssetList_PPtr_SpriteAtlas__AssetList_PPtr_SpriteAtlas(target.Value, source.Value, converter);
			}
		}

		// Token: 0x06016F2F RID: 93999 RVA: 0x0035DB94 File Offset: 0x0035BD94
		public static void CopyValues__AssetDictionary_AssetPair_GUID_Int64_AssetList_Utf8String__AssetDictionary_AssetPair_GUID_Int64_AssetList_Utf8String(AssetDictionary<AssetPair<GUID, long>, AssetList<Utf8String>> target, AssetDictionary<AssetPair<GUID, long>, AssetList<Utf8String>> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_AssetPair_GUID_Int64_AssetList_Utf8String__AccessPairBase_AssetPair_GUID_Int64_AssetList_Utf8String(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F30 RID: 94000 RVA: 0x0035DBE1 File Offset: 0x0035BDE1
		public static void CopyValues__AccessPairBase_AssetPair_GUID_Int64_AssetList_Utf8String__AccessPairBase_AssetPair_GUID_Int64_AssetList_Utf8String(AccessPairBase<AssetPair<GUID, long>, AssetList<Utf8String>> target, AccessPairBase<AssetPair<GUID, long>, AssetList<Utf8String>> source)
		{
			if (source != null)
			{
				CopyValuesHelper.CopyValues__AssetPair_GUID_Int64__AssetPair_GUID_Int64(target.Key, source.Key);
				CopyValuesHelper.CopyValues__AssetList_Utf8String__AssetList_Utf8String(target.Value, source.Value);
			}
		}

		// Token: 0x06016F31 RID: 94001 RVA: 0x0035DC08 File Offset: 0x0035BE08
		public static void CopyValues__AssetDictionary_GUID_Hash128__AssetDictionary_GUID_Hash128(AssetDictionary<GUID, Hash128> target, AssetDictionary<GUID, Hash128> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_GUID_Hash128__AccessPairBase_GUID_Hash128(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F32 RID: 94002 RVA: 0x0035DC55 File Offset: 0x0035BE55
		public static void CopyValues__AccessPairBase_GUID_Hash128__AccessPairBase_GUID_Hash128(AccessPairBase<GUID, Hash128> target, AccessPairBase<GUID, Hash128> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016F33 RID: 94003 RVA: 0x0035DC7C File Offset: 0x0035BE7C
		public static void CopyValues__AssetDictionary_GUID_UInt32__AssetDictionary_GUID_UInt32(AssetDictionary<GUID, uint> target, AssetDictionary<GUID, uint> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_GUID_UInt32__AccessPairBase_GUID_UInt32(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F34 RID: 94004 RVA: 0x0035DCC9 File Offset: 0x0035BEC9
		public static void CopyValues__AccessPairBase_GUID_UInt32__AccessPairBase_GUID_UInt32(AccessPairBase<GUID, uint> target, AccessPairBase<GUID, uint> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value = source.Value;
			}
		}

		// Token: 0x06016F35 RID: 94005 RVA: 0x0035DCEC File Offset: 0x0035BEEC
		public static void CopyValues__AssetDictionary_AssetPair_GUID_Int64_SpriteAtlasData_2017_1_0__AccessDictionaryBase_AssetPair_GUID_Int64_ISpriteAtlasData(AssetDictionary<AssetPair<GUID, long>, SpriteAtlasData_2017_1_0> target, AccessDictionaryBase<AssetPair<GUID, long>, ISpriteAtlasData> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteAtlasData_2017_1_0__AccessPairBase_AssetPair_GUID_Int64_ISpriteAtlasData(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F36 RID: 94006 RVA: 0x0035DD3A File Offset: 0x0035BF3A
		public static void CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteAtlasData_2017_1_0__AccessPairBase_AssetPair_GUID_Int64_ISpriteAtlasData(AccessPairBase<AssetPair<GUID, long>, SpriteAtlasData_2017_1_0> target, AccessPairBase<AssetPair<GUID, long>, ISpriteAtlasData> source, PPtrConverter converter)
		{
			if (source != null)
			{
				CopyValuesHelper.CopyValues__AssetPair_GUID_Int64__AssetPair_GUID_Int64(target.Key, source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016F37 RID: 94007 RVA: 0x0035DD64 File Offset: 0x0035BF64
		public static void CopyValues__AssetDictionary_AssetPair_GUID_Int64_SpriteAtlasData_2017_1_2__AccessDictionaryBase_AssetPair_GUID_Int64_ISpriteAtlasData(AssetDictionary<AssetPair<GUID, long>, SpriteAtlasData_2017_1_2> target, AccessDictionaryBase<AssetPair<GUID, long>, ISpriteAtlasData> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteAtlasData_2017_1_2__AccessPairBase_AssetPair_GUID_Int64_ISpriteAtlasData(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F38 RID: 94008 RVA: 0x0035DDB2 File Offset: 0x0035BFB2
		public static void CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteAtlasData_2017_1_2__AccessPairBase_AssetPair_GUID_Int64_ISpriteAtlasData(AccessPairBase<AssetPair<GUID, long>, SpriteAtlasData_2017_1_2> target, AccessPairBase<AssetPair<GUID, long>, ISpriteAtlasData> source, PPtrConverter converter)
		{
			if (source != null)
			{
				CopyValuesHelper.CopyValues__AssetPair_GUID_Int64__AssetPair_GUID_Int64(target.Key, source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016F39 RID: 94009 RVA: 0x0035DDDC File Offset: 0x0035BFDC
		public static void CopyValues__AssetDictionary_AssetPair_GUID_Int64_SpriteAtlasData_2017_2_0__AccessDictionaryBase_AssetPair_GUID_Int64_ISpriteAtlasData(AssetDictionary<AssetPair<GUID, long>, SpriteAtlasData_2017_2_0> target, AccessDictionaryBase<AssetPair<GUID, long>, ISpriteAtlasData> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteAtlasData_2017_2_0__AccessPairBase_AssetPair_GUID_Int64_ISpriteAtlasData(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F3A RID: 94010 RVA: 0x0035DE2A File Offset: 0x0035C02A
		public static void CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteAtlasData_2017_2_0__AccessPairBase_AssetPair_GUID_Int64_ISpriteAtlasData(AccessPairBase<AssetPair<GUID, long>, SpriteAtlasData_2017_2_0> target, AccessPairBase<AssetPair<GUID, long>, ISpriteAtlasData> source, PPtrConverter converter)
		{
			if (source != null)
			{
				CopyValuesHelper.CopyValues__AssetPair_GUID_Int64__AssetPair_GUID_Int64(target.Key, source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016F3B RID: 94011 RVA: 0x0035DE54 File Offset: 0x0035C054
		public static void CopyValues__AssetDictionary_AssetPair_GUID_Int64_SpriteAtlasData_2017_2_0_b9__AccessDictionaryBase_AssetPair_GUID_Int64_ISpriteAtlasData(AssetDictionary<AssetPair<GUID, long>, SpriteAtlasData_2017_2_0_b9> target, AccessDictionaryBase<AssetPair<GUID, long>, ISpriteAtlasData> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteAtlasData_2017_2_0_b9__AccessPairBase_AssetPair_GUID_Int64_ISpriteAtlasData(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F3C RID: 94012 RVA: 0x0035DEA2 File Offset: 0x0035C0A2
		public static void CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteAtlasData_2017_2_0_b9__AccessPairBase_AssetPair_GUID_Int64_ISpriteAtlasData(AccessPairBase<AssetPair<GUID, long>, SpriteAtlasData_2017_2_0_b9> target, AccessPairBase<AssetPair<GUID, long>, ISpriteAtlasData> source, PPtrConverter converter)
		{
			if (source != null)
			{
				CopyValuesHelper.CopyValues__AssetPair_GUID_Int64__AssetPair_GUID_Int64(target.Key, source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016F3D RID: 94013 RVA: 0x0035DECC File Offset: 0x0035C0CC
		public static void CopyValues__AssetDictionary_AssetPair_GUID_Int64_SpriteAtlasData_2020_2_0__AccessDictionaryBase_AssetPair_GUID_Int64_ISpriteAtlasData(AssetDictionary<AssetPair<GUID, long>, SpriteAtlasData_2020_2_0> target, AccessDictionaryBase<AssetPair<GUID, long>, ISpriteAtlasData> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteAtlasData_2020_2_0__AccessPairBase_AssetPair_GUID_Int64_ISpriteAtlasData(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F3E RID: 94014 RVA: 0x0035DF1A File Offset: 0x0035C11A
		public static void CopyValues__AccessPairBase_AssetPair_GUID_Int64_SpriteAtlasData_2020_2_0__AccessPairBase_AssetPair_GUID_Int64_ISpriteAtlasData(AccessPairBase<AssetPair<GUID, long>, SpriteAtlasData_2020_2_0> target, AccessPairBase<AssetPair<GUID, long>, ISpriteAtlasData> source, PPtrConverter converter)
		{
			if (source != null)
			{
				CopyValuesHelper.CopyValues__AssetPair_GUID_Int64__AssetPair_GUID_Int64(target.Key, source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016F3F RID: 94015 RVA: 0x0035DF44 File Offset: 0x0035C144
		public static void CopyValues__AssetList_AssetPair_GUID_Int64__AssetList_AssetPair_GUID_Int64(AssetList<AssetPair<GUID, long>> target, AssetList<AssetPair<GUID, long>> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					CopyValuesHelper.CopyValues__AssetPair_GUID_Int64__AssetPair_GUID_Int64(target.AddNew(), source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F40 RID: 94016 RVA: 0x0035DF8C File Offset: 0x0035C18C
		public static void CopyValues__AssetDictionary_Utf8String_SecondaryTextureSettings_2020_2_0__AccessDictionaryBase_Utf8String_ISecondaryTextureSettings(AssetDictionary<Utf8String, SecondaryTextureSettings_2020_2_0> target, AccessDictionaryBase<Utf8String, ISecondaryTextureSettings> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_SecondaryTextureSettings_2020_2_0__AccessPairBase_Utf8String_ISecondaryTextureSettings(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F41 RID: 94017 RVA: 0x0035DFD9 File Offset: 0x0035C1D9
		public static void CopyValues__AccessPairBase_Utf8String_SecondaryTextureSettings_2020_2_0__AccessPairBase_Utf8String_ISecondaryTextureSettings(AccessPairBase<Utf8String, SecondaryTextureSettings_2020_2_0> target, AccessPairBase<Utf8String, ISecondaryTextureSettings> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016F42 RID: 94018 RVA: 0x0035E000 File Offset: 0x0035C200
		public static void CopyValues__AssetList_TextureImporterPlatformSettings_2019_2_0__AssetList_TextureImporterPlatformSettings_2019_2_0(AssetList<TextureImporterPlatformSettings_2019_2_0> target, AssetList<TextureImporterPlatformSettings_2019_2_0> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F43 RID: 94019 RVA: 0x0035E048 File Offset: 0x0035C248
		public static void CopyValues__AssetDictionary_Utf8String_SecondaryTextureSettings_2020_2_0_a12__AccessDictionaryBase_Utf8String_ISecondaryTextureSettings(AssetDictionary<Utf8String, SecondaryTextureSettings_2020_2_0_a12> target, AccessDictionaryBase<Utf8String, ISecondaryTextureSettings> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_SecondaryTextureSettings_2020_2_0_a12__AccessPairBase_Utf8String_ISecondaryTextureSettings(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F44 RID: 94020 RVA: 0x0035E095 File Offset: 0x0035C295
		public static void CopyValues__AccessPairBase_Utf8String_SecondaryTextureSettings_2020_2_0_a12__AccessPairBase_Utf8String_ISecondaryTextureSettings(AccessPairBase<Utf8String, SecondaryTextureSettings_2020_2_0_a12> target, AccessPairBase<Utf8String, ISecondaryTextureSettings> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016F45 RID: 94021 RVA: 0x0035E0BC File Offset: 0x0035C2BC
		public static void CopyValues__AssetList_PPtr_Sprite_5_0_0__AssetList_PPtr_Sprite_5_0_0(AssetList<PPtr_Sprite_5_0_0> target, AssetList<PPtr_Sprite_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F46 RID: 94022 RVA: 0x0035E104 File Offset: 0x0035C304
		public static void CopyValues__AssetDictionary_Vector3Int_TileAnimationData_2017_2_0__AccessDictionaryBase_Vector3Int_ITileAnimationData(AssetDictionary<Vector3Int, TileAnimationData_2017_2_0> target, AccessDictionaryBase<Vector3Int, ITileAnimationData> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Vector3Int_TileAnimationData_2017_2_0__AccessPairBase_Vector3Int_ITileAnimationData(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F47 RID: 94023 RVA: 0x0035E152 File Offset: 0x0035C352
		public static void CopyValues__AccessPairBase_Vector3Int_TileAnimationData_2017_2_0__AccessPairBase_Vector3Int_ITileAnimationData(AccessPairBase<Vector3Int, TileAnimationData_2017_2_0> target, AccessPairBase<Vector3Int, ITileAnimationData> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016F48 RID: 94024 RVA: 0x0035E17C File Offset: 0x0035C37C
		public static void CopyValues__AssetList_TilemapRefCountedData_PPtr_Object__AssetList_TilemapRefCountedData_PPtr_Object(AssetList<TilemapRefCountedData_PPtr_Object> target, AssetList<TilemapRefCountedData_PPtr_Object> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F49 RID: 94025 RVA: 0x0035E1C4 File Offset: 0x0035C3C4
		public static void CopyValues__AssetList_TilemapRefCountedData_ColorRGBAf__AssetList_TilemapRefCountedData_ColorRGBAf(AssetList<TilemapRefCountedData_ColorRGBAf> target, AssetList<TilemapRefCountedData_ColorRGBAf> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F4A RID: 94026 RVA: 0x0035E20C File Offset: 0x0035C40C
		public static void CopyValues__AssetList_TilemapRefCountedData_Matrix4x4f__AssetList_TilemapRefCountedData_Matrix4x4f(AssetList<TilemapRefCountedData_Matrix4x4f> target, AssetList<TilemapRefCountedData_Matrix4x4f> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F4B RID: 94027 RVA: 0x0035E254 File Offset: 0x0035C454
		public static void CopyValues__AssetList_TilemapTileDirtyData_2017_2_0__AccessListBase_ITilemapTileDirtyData(AssetList<TilemapTileDirtyData_2017_2_0> target, AccessListBase<ITilemapTileDirtyData> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F4C RID: 94028 RVA: 0x0035E29C File Offset: 0x0035C49C
		public static void CopyValues__AssetDictionary_Vector3Int_Tile_2017_2_0__AccessDictionaryBase_Vector3Int_ITile(AssetDictionary<Vector3Int, Tile_2017_2_0> target, AccessDictionaryBase<Vector3Int, ITile> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Vector3Int_Tile_2017_2_0__AccessPairBase_Vector3Int_ITile(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F4D RID: 94029 RVA: 0x0035E2EA File Offset: 0x0035C4EA
		public static void CopyValues__AccessPairBase_Vector3Int_Tile_2017_2_0__AccessPairBase_Vector3Int_ITile(AccessPairBase<Vector3Int, Tile_2017_2_0> target, AccessPairBase<Vector3Int, ITile> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016F4E RID: 94030 RVA: 0x0035E314 File Offset: 0x0035C514
		public static void CopyValues__AssetList_TilemapRefCountedData_PPtr_Sprite__AssetList_TilemapRefCountedData_PPtr_Sprite(AssetList<TilemapRefCountedData_PPtr_Sprite> target, AssetList<TilemapRefCountedData_PPtr_Sprite> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F4F RID: 94031 RVA: 0x0035E35C File Offset: 0x0035C55C
		public static void CopyValues__AssetDictionary_Vector3Int_Tile_2017_2_0_b7__AccessDictionaryBase_Vector3Int_ITile(AssetDictionary<Vector3Int, Tile_2017_2_0_b7> target, AccessDictionaryBase<Vector3Int, ITile> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Vector3Int_Tile_2017_2_0_b7__AccessPairBase_Vector3Int_ITile(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F50 RID: 94032 RVA: 0x0035E3AA File Offset: 0x0035C5AA
		public static void CopyValues__AccessPairBase_Vector3Int_Tile_2017_2_0_b7__AccessPairBase_Vector3Int_ITile(AccessPairBase<Vector3Int, Tile_2017_2_0_b7> target, AccessPairBase<Vector3Int, ITile> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016F51 RID: 94033 RVA: 0x0035E3D4 File Offset: 0x0035C5D4
		public static void CopyValues__AssetList_TilemapTileDirtyData_2018_1_0__AccessListBase_ITilemapTileDirtyData(AssetList<TilemapTileDirtyData_2018_1_0> target, AccessListBase<ITilemapTileDirtyData> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F52 RID: 94034 RVA: 0x0035E41C File Offset: 0x0035C61C
		public static void CopyValues__AssetList_TilemapRefCountedData_PPtr_GameObject__AssetList_TilemapRefCountedData_PPtr_GameObject(AssetList<TilemapRefCountedData_PPtr_GameObject> target, AssetList<TilemapRefCountedData_PPtr_GameObject> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F53 RID: 94035 RVA: 0x0035E464 File Offset: 0x0035C664
		public static void CopyValues__AssetDictionary_Vector3Int_Tile_2019_3_0_a12__AccessDictionaryBase_Vector3Int_ITile(AssetDictionary<Vector3Int, Tile_2019_3_0_a12> target, AccessDictionaryBase<Vector3Int, ITile> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Vector3Int_Tile_2019_3_0_a12__AccessPairBase_Vector3Int_ITile(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F54 RID: 94036 RVA: 0x0035E4B2 File Offset: 0x0035C6B2
		public static void CopyValues__AccessPairBase_Vector3Int_Tile_2019_3_0_a12__AccessPairBase_Vector3Int_ITile(AccessPairBase<Vector3Int, Tile_2019_3_0_a12> target, AccessPairBase<Vector3Int, ITile> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016F55 RID: 94037 RVA: 0x0035E4DC File Offset: 0x0035C6DC
		public static void CopyValues__AssetDictionary_Vector3Int_Tile_2019_4_24__AccessDictionaryBase_Vector3Int_ITile(AssetDictionary<Vector3Int, Tile_2019_4_24> target, AccessDictionaryBase<Vector3Int, ITile> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Vector3Int_Tile_2019_4_24__AccessPairBase_Vector3Int_ITile(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F56 RID: 94038 RVA: 0x0035E52A File Offset: 0x0035C72A
		public static void CopyValues__AccessPairBase_Vector3Int_Tile_2019_4_24__AccessPairBase_Vector3Int_ITile(AccessPairBase<Vector3Int, Tile_2019_4_24> target, AccessPairBase<Vector3Int, ITile> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016F57 RID: 94039 RVA: 0x0035E554 File Offset: 0x0035C754
		public static void CopyValues__AssetDictionary_Vector3Int_Tile_2020_1_0__AccessDictionaryBase_Vector3Int_ITile(AssetDictionary<Vector3Int, Tile_2020_1_0> target, AccessDictionaryBase<Vector3Int, ITile> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Vector3Int_Tile_2020_1_0__AccessPairBase_Vector3Int_ITile(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F58 RID: 94040 RVA: 0x0035E5A2 File Offset: 0x0035C7A2
		public static void CopyValues__AccessPairBase_Vector3Int_Tile_2020_1_0__AccessPairBase_Vector3Int_ITile(AccessPairBase<Vector3Int, Tile_2020_1_0> target, AccessPairBase<Vector3Int, ITile> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016F59 RID: 94041 RVA: 0x0035E5CC File Offset: 0x0035C7CC
		public static void CopyValues__AssetDictionary_Vector3Int_Tile_2020_1_8__AccessDictionaryBase_Vector3Int_ITile(AssetDictionary<Vector3Int, Tile_2020_1_8> target, AccessDictionaryBase<Vector3Int, ITile> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Vector3Int_Tile_2020_1_8__AccessPairBase_Vector3Int_ITile(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F5A RID: 94042 RVA: 0x0035E61A File Offset: 0x0035C81A
		public static void CopyValues__AccessPairBase_Vector3Int_Tile_2020_1_8__AccessPairBase_Vector3Int_ITile(AccessPairBase<Vector3Int, Tile_2020_1_8> target, AccessPairBase<Vector3Int, ITile> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016F5B RID: 94043 RVA: 0x0035E644 File Offset: 0x0035C844
		public static void CopyValues__AssetDictionary_Vector3Int_Tile_2020_2_0__AccessDictionaryBase_Vector3Int_ITile(AssetDictionary<Vector3Int, Tile_2020_2_0> target, AccessDictionaryBase<Vector3Int, ITile> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Vector3Int_Tile_2020_2_0__AccessPairBase_Vector3Int_ITile(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F5C RID: 94044 RVA: 0x0035E692 File Offset: 0x0035C892
		public static void CopyValues__AccessPairBase_Vector3Int_Tile_2020_2_0__AccessPairBase_Vector3Int_ITile(AccessPairBase<Vector3Int, Tile_2020_2_0> target, AccessPairBase<Vector3Int, ITile> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016F5D RID: 94045 RVA: 0x0035E6BC File Offset: 0x0035C8BC
		public static void CopyValues__AssetDictionary_Vector3Int_Tile_2020_2_0_b1__AccessDictionaryBase_Vector3Int_ITile(AssetDictionary<Vector3Int, Tile_2020_2_0_b1> target, AccessDictionaryBase<Vector3Int, ITile> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Vector3Int_Tile_2020_2_0_b1__AccessPairBase_Vector3Int_ITile(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F5E RID: 94046 RVA: 0x0035E70A File Offset: 0x0035C90A
		public static void CopyValues__AccessPairBase_Vector3Int_Tile_2020_2_0_b1__AccessPairBase_Vector3Int_ITile(AccessPairBase<Vector3Int, Tile_2020_2_0_b1> target, AccessPairBase<Vector3Int, ITile> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016F5F RID: 94047 RVA: 0x0035E734 File Offset: 0x0035C934
		public static void CopyValues__AssetDictionary_Vector3Int_TileAnimationData_2022_2_0__AccessDictionaryBase_Vector3Int_ITileAnimationData(AssetDictionary<Vector3Int, TileAnimationData_2022_2_0> target, AccessDictionaryBase<Vector3Int, ITileAnimationData> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Vector3Int_TileAnimationData_2022_2_0__AccessPairBase_Vector3Int_ITileAnimationData(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F60 RID: 94048 RVA: 0x0035E782 File Offset: 0x0035C982
		public static void CopyValues__AccessPairBase_Vector3Int_TileAnimationData_2022_2_0__AccessPairBase_Vector3Int_ITileAnimationData(AccessPairBase<Vector3Int, TileAnimationData_2022_2_0> target, AccessPairBase<Vector3Int, ITileAnimationData> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value, converter);
			}
		}

		// Token: 0x06016F61 RID: 94049 RVA: 0x0035E7AC File Offset: 0x0035C9AC
		public static void CopyValues__AssetList_AssetImporter_ImportError__AssetList_AssetImporter_ImportError(AssetList<AssetImporter_ImportError> target, AssetList<AssetImporter_ImportError> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F62 RID: 94050 RVA: 0x0035E7F4 File Offset: 0x0035C9F4
		public static void CopyValues__AssetList_ImportLog_ImportLogEntry__AssetList_ImportLog_ImportLogEntry(AssetList<ImportLog_ImportLogEntry> target, AssetList<ImportLog_ImportLogEntry> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F63 RID: 94051 RVA: 0x0035E83C File Offset: 0x0035CA3C
		public static void CopyValues__AssetList_PropertyModification_5_0_0__AssetList_PropertyModification_5_0_0(AssetList<PropertyModification_5_0_0> target, AssetList<PropertyModification_5_0_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F64 RID: 94052 RVA: 0x0035E884 File Offset: 0x0035CA84
		public static void CopyValues__AssetList_ConstraintSource__AssetList_ConstraintSource(AssetList<ConstraintSource> target, AssetList<ConstraintSource> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F65 RID: 94053 RVA: 0x0035E8CC File Offset: 0x0035CACC
		public static void CopyValues__AssetList_Module_2018_1_0__AccessListBase_IModule(AssetList<Module_2018_1_0> target, AccessListBase<IModule> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F66 RID: 94054 RVA: 0x0035E914 File Offset: 0x0035CB14
		public static void CopyValues__AssetList_Module_2018_2_0_b4__AccessListBase_IModule(AssetList<Module_2018_2_0_b4> target, AccessListBase<IModule> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F67 RID: 94055 RVA: 0x0035E95C File Offset: 0x0035CB5C
		public static void CopyValues__AssetList_DefaultPresetList__AssetList_DefaultPresetList(AssetList<DefaultPresetList> target, AssetList<DefaultPresetList> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F68 RID: 94056 RVA: 0x0035E9A4 File Offset: 0x0035CBA4
		public static void CopyValues__AssetList_DefaultPreset_2018_1_0__AssetList_DefaultPreset_2018_1_0(AssetList<DefaultPreset_2018_1_0> target, AssetList<DefaultPreset_2018_1_0> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F69 RID: 94057 RVA: 0x0035E9EC File Offset: 0x0035CBEC
		public static void CopyValues__AssetDictionary_PresetType_AssetList_DefaultPreset_2019_3_0_a10__AssetDictionary_PresetType_AssetList_DefaultPreset_2019_3_0_a10(AssetDictionary<PresetType, AssetList<DefaultPreset_2019_3_0_a10>> target, AssetDictionary<PresetType, AssetList<DefaultPreset_2019_3_0_a10>> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_PresetType_AssetList_DefaultPreset_2019_3_0_a10__AccessPairBase_PresetType_AssetList_DefaultPreset_2019_3_0_a10(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F6A RID: 94058 RVA: 0x0035EA3A File Offset: 0x0035CC3A
		public static void CopyValues__AccessPairBase_PresetType_AssetList_DefaultPreset_2019_3_0_a10__AccessPairBase_PresetType_AssetList_DefaultPreset_2019_3_0_a10(AccessPairBase<PresetType, AssetList<DefaultPreset_2019_3_0_a10>> target, AccessPairBase<PresetType, AssetList<DefaultPreset_2019_3_0_a10>> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key, converter);
				CopyValuesHelper.CopyValues__AssetList_DefaultPreset_2019_3_0_a10__AssetList_DefaultPreset_2019_3_0_a10(target.Value, source.Value, converter);
			}
		}

		// Token: 0x06016F6B RID: 94059 RVA: 0x0035EA64 File Offset: 0x0035CC64
		public static void CopyValues__AssetList_DefaultPreset_2019_3_0_a10__AssetList_DefaultPreset_2019_3_0_a10(AssetList<DefaultPreset_2019_3_0_a10> target, AssetList<DefaultPreset_2019_3_0_a10> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F6C RID: 94060 RVA: 0x0035EAAC File Offset: 0x0035CCAC
		public static void CopyValues__AssetDictionary_PresetType_AssetList_DefaultPreset_2020_1_0_a23__AssetDictionary_PresetType_AssetList_DefaultPreset_2020_1_0_a23(AssetDictionary<PresetType, AssetList<DefaultPreset_2020_1_0_a23>> target, AssetDictionary<PresetType, AssetList<DefaultPreset_2020_1_0_a23>> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_PresetType_AssetList_DefaultPreset_2020_1_0_a23__AccessPairBase_PresetType_AssetList_DefaultPreset_2020_1_0_a23(target.GetPair(i), source.GetPair(i), converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F6D RID: 94061 RVA: 0x0035EAFA File Offset: 0x0035CCFA
		public static void CopyValues__AccessPairBase_PresetType_AssetList_DefaultPreset_2020_1_0_a23__AccessPairBase_PresetType_AssetList_DefaultPreset_2020_1_0_a23(AccessPairBase<PresetType, AssetList<DefaultPreset_2020_1_0_a23>> target, AccessPairBase<PresetType, AssetList<DefaultPreset_2020_1_0_a23>> source, PPtrConverter converter)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key, converter);
				CopyValuesHelper.CopyValues__AssetList_DefaultPreset_2020_1_0_a23__AssetList_DefaultPreset_2020_1_0_a23(target.Value, source.Value, converter);
			}
		}

		// Token: 0x06016F6E RID: 94062 RVA: 0x0035EB24 File Offset: 0x0035CD24
		public static void CopyValues__AssetList_DefaultPreset_2020_1_0_a23__AssetList_DefaultPreset_2020_1_0_a23(AssetList<DefaultPreset_2020_1_0_a23> target, AssetList<DefaultPreset_2020_1_0_a23> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F6F RID: 94063 RVA: 0x0035EB6C File Offset: 0x0035CD6C
		public static void CopyValues__AssetList_VFXGPUBufferDesc__AssetList_VFXGPUBufferDesc(AssetList<VFXGPUBufferDesc> target, AssetList<VFXGPUBufferDesc> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F70 RID: 94064 RVA: 0x0035EBB4 File Offset: 0x0035CDB4
		public static void CopyValues__AssetList_VFXLayoutElementDesc__AssetList_VFXLayoutElementDesc(AssetList<VFXLayoutElementDesc> target, AssetList<VFXLayoutElementDesc> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F71 RID: 94065 RVA: 0x0035EBFC File Offset: 0x0035CDFC
		public static void CopyValues__AssetList_VFXCPUBufferDesc__AssetList_VFXCPUBufferDesc(AssetList<VFXCPUBufferDesc> target, AssetList<VFXCPUBufferDesc> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F72 RID: 94066 RVA: 0x0035EC44 File Offset: 0x0035CE44
		public static void CopyValues__AssetList_VFXEventDesc_2018_3_0__AccessListBase_IVFXEventDesc(AssetList<VFXEventDesc_2018_3_0> target, AccessListBase<IVFXEventDesc> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F73 RID: 94067 RVA: 0x0035EC8C File Offset: 0x0035CE8C
		public static void CopyValues__AssetList_VFXMapping__AssetList_VFXMapping(AssetList<VFXMapping> target, AssetList<VFXMapping> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F74 RID: 94068 RVA: 0x0035ECD4 File Offset: 0x0035CED4
		public static void CopyValues__AssetList_Expression__AssetList_Expression(AssetList<Expression> target, AssetList<Expression> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F75 RID: 94069 RVA: 0x0035ED1C File Offset: 0x0035CF1C
		public static void CopyValues__AssetList_VFXEntryExpressionValue_AnimationCurve_Single__AssetList_VFXEntryExpressionValue_AnimationCurve_Single(AssetList<VFXEntryExpressionValue_AnimationCurve_Single> target, AssetList<VFXEntryExpressionValue_AnimationCurve_Single> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F76 RID: 94070 RVA: 0x0035ED64 File Offset: 0x0035CF64
		public static void CopyValues__AssetList_VFXEntryExpressionValue_bool__AssetList_VFXEntryExpressionValue_bool(AssetList<VFXEntryExpressionValue_bool> target, AssetList<VFXEntryExpressionValue_bool> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F77 RID: 94071 RVA: 0x0035EDAC File Offset: 0x0035CFAC
		public static void CopyValues__AssetList_VFXEntryExpressionValue_float__AssetList_VFXEntryExpressionValue_float(AssetList<VFXEntryExpressionValue_float> target, AssetList<VFXEntryExpressionValue_float> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F78 RID: 94072 RVA: 0x0035EDF4 File Offset: 0x0035CFF4
		public static void CopyValues__AssetList_VFXEntryExpressionValue_Gradient_2018_3_0__AccessListBase_IVFXEntryExpressionValue_Gradient(AssetList<VFXEntryExpressionValue_Gradient_2018_3_0> target, AccessListBase<IVFXEntryExpressionValue_Gradient> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F79 RID: 94073 RVA: 0x0035EE3C File Offset: 0x0035D03C
		public static void CopyValues__AssetList_VFXEntryExpressionValue_Gradient_2022_2_0__AccessListBase_IVFXEntryExpressionValue_Gradient(AssetList<VFXEntryExpressionValue_Gradient_2022_2_0> target, AccessListBase<IVFXEntryExpressionValue_Gradient> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F7A RID: 94074 RVA: 0x0035EE84 File Offset: 0x0035D084
		public static void CopyValues__AssetList_VFXEntryExpressionValue_SInt32__AssetList_VFXEntryExpressionValue_SInt32(AssetList<VFXEntryExpressionValue_SInt32> target, AssetList<VFXEntryExpressionValue_SInt32> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F7B RID: 94075 RVA: 0x0035EECC File Offset: 0x0035D0CC
		public static void CopyValues__AssetList_VFXEntryExpressionValue_Matrix4x4f__AssetList_VFXEntryExpressionValue_Matrix4x4f(AssetList<VFXEntryExpressionValue_Matrix4x4f> target, AssetList<VFXEntryExpressionValue_Matrix4x4f> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F7C RID: 94076 RVA: 0x0035EF14 File Offset: 0x0035D114
		public static void CopyValues__AssetList_VFXEntryExpressionValue_PPtr_NamedObject__AssetList_VFXEntryExpressionValue_PPtr_NamedObject(AssetList<VFXEntryExpressionValue_PPtr_NamedObject> target, AssetList<VFXEntryExpressionValue_PPtr_NamedObject> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F7D RID: 94077 RVA: 0x0035EF5C File Offset: 0x0035D15C
		public static void CopyValues__AssetList_VFXEntryExpressionValue_UInt32__AssetList_VFXEntryExpressionValue_UInt32(AssetList<VFXEntryExpressionValue_UInt32> target, AssetList<VFXEntryExpressionValue_UInt32> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F7E RID: 94078 RVA: 0x0035EFA4 File Offset: 0x0035D1A4
		public static void CopyValues__AssetList_VFXEntryExpressionValue_Vector2f__AssetList_VFXEntryExpressionValue_Vector2f(AssetList<VFXEntryExpressionValue_Vector2f> target, AssetList<VFXEntryExpressionValue_Vector2f> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F7F RID: 94079 RVA: 0x0035EFEC File Offset: 0x0035D1EC
		public static void CopyValues__AssetList_VFXEntryExpressionValue_Vector3f__AssetList_VFXEntryExpressionValue_Vector3f(AssetList<VFXEntryExpressionValue_Vector3f> target, AssetList<VFXEntryExpressionValue_Vector3f> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F80 RID: 94080 RVA: 0x0035F034 File Offset: 0x0035D234
		public static void CopyValues__AssetList_VFXEntryExpressionValue_Vector4f__AssetList_VFXEntryExpressionValue_Vector4f(AssetList<VFXEntryExpressionValue_Vector4f> target, AssetList<VFXEntryExpressionValue_Vector4f> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F81 RID: 94081 RVA: 0x0035F07C File Offset: 0x0035D27C
		public static void CopyValues__AssetList_VFXEntryExpressionValue_PPtr_Object__AssetList_VFXEntryExpressionValue_PPtr_Object(AssetList<VFXEntryExpressionValue_PPtr_Object> target, AssetList<VFXEntryExpressionValue_PPtr_Object> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F82 RID: 94082 RVA: 0x0035F0C4 File Offset: 0x0035D2C4
		public static void CopyValues__AssetList_VFXTemporaryGPUBufferDesc__AssetList_VFXTemporaryGPUBufferDesc(AssetList<VFXTemporaryGPUBufferDesc> target, AssetList<VFXTemporaryGPUBufferDesc> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F83 RID: 94083 RVA: 0x0035F10C File Offset: 0x0035D30C
		public static void CopyValues__AssetList_VFXEventDesc_2021_2_0_a19__AccessListBase_IVFXEventDesc(AssetList<VFXEventDesc_2021_2_0_a19> target, AccessListBase<IVFXEventDesc> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F84 RID: 94084 RVA: 0x0035F154 File Offset: 0x0035D354
		public static void CopyValues__AssetList_VFXSystemDesc_2018_3_0__AccessListBase_IVFXSystemDesc(AssetList<VFXSystemDesc_2018_3_0> target, AccessListBase<IVFXSystemDesc> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F85 RID: 94085 RVA: 0x0035F19C File Offset: 0x0035D39C
		public static void CopyValues__AssetList_VFXTaskDesc_2018_3_0__AccessListBase_IVFXTaskDesc(AssetList<VFXTaskDesc_2018_3_0> target, AccessListBase<IVFXTaskDesc> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F86 RID: 94086 RVA: 0x0035F1E4 File Offset: 0x0035D3E4
		public static void CopyValues__AssetList_VFXMappingTemporary__AssetList_VFXMappingTemporary(AssetList<VFXMappingTemporary> target, AssetList<VFXMappingTemporary> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F87 RID: 94087 RVA: 0x0035F22C File Offset: 0x0035D42C
		public static void CopyValues__AssetList_VFXTaskDesc_2019_2_0_a7__AccessListBase_IVFXTaskDesc(AssetList<VFXTaskDesc_2019_2_0_a7> target, AccessListBase<IVFXTaskDesc> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F88 RID: 94088 RVA: 0x0035F274 File Offset: 0x0035D474
		public static void CopyValues__AssetList_VFXSystemDesc_2019_2_0_a7__AccessListBase_IVFXSystemDesc(AssetList<VFXSystemDesc_2019_2_0_a7> target, AccessListBase<IVFXSystemDesc> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F89 RID: 94089 RVA: 0x0035F2BC File Offset: 0x0035D4BC
		public static void CopyValues__AssetList_VFXSystemDesc_2020_1_0_a17__AccessListBase_IVFXSystemDesc(AssetList<VFXSystemDesc_2020_1_0_a17> target, AccessListBase<IVFXSystemDesc> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F8A RID: 94090 RVA: 0x0035F304 File Offset: 0x0035D504
		public static void CopyValues__AssetList_VFXShaderSourceDesc__AssetList_VFXShaderSourceDesc(AssetList<VFXShaderSourceDesc> target, AssetList<VFXShaderSourceDesc> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F8B RID: 94091 RVA: 0x0035F34C File Offset: 0x0035D54C
		public static void CopyValues__AssetList_VFXEditorSystemDesc_2018_3_0__AccessListBase_IVFXEditorSystemDesc(AssetList<VFXEditorSystemDesc_2018_3_0> target, AccessListBase<IVFXEditorSystemDesc> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F8C RID: 94092 RVA: 0x0035F394 File Offset: 0x0035D594
		public static void CopyValues__AssetList_VFXEditorTaskDesc_2018_3_0__AccessListBase_IVFXEditorTaskDesc(AssetList<VFXEditorTaskDesc_2018_3_0> target, AccessListBase<IVFXEditorTaskDesc> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F8D RID: 94093 RVA: 0x0035F3DC File Offset: 0x0035D5DC
		public static void CopyValues__AssetList_VFXEditorTaskDesc_2019_2_0_a7__AccessListBase_IVFXEditorTaskDesc(AssetList<VFXEditorTaskDesc_2019_2_0_a7> target, AccessListBase<IVFXEditorTaskDesc> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F8E RID: 94094 RVA: 0x0035F424 File Offset: 0x0035D624
		public static void CopyValues__AssetList_VFXEditorSystemDesc_2019_2_0_a7__AccessListBase_IVFXEditorSystemDesc(AssetList<VFXEditorSystemDesc_2019_2_0_a7> target, AccessListBase<IVFXEditorSystemDesc> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F8F RID: 94095 RVA: 0x0035F46C File Offset: 0x0035D66C
		public static void CopyValues__AssetList_VFXEntryExposed_AnimationCurve_Single__AssetList_VFXEntryExposed_AnimationCurve_Single(AssetList<VFXEntryExposed_AnimationCurve_Single> target, AssetList<VFXEntryExposed_AnimationCurve_Single> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F90 RID: 94096 RVA: 0x0035F4B4 File Offset: 0x0035D6B4
		public static void CopyValues__AssetList_VFXEntryExposed_bool__AssetList_VFXEntryExposed_bool(AssetList<VFXEntryExposed_bool> target, AssetList<VFXEntryExposed_bool> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F91 RID: 94097 RVA: 0x0035F4FC File Offset: 0x0035D6FC
		public static void CopyValues__AssetList_VFXEntryExposed_float__AssetList_VFXEntryExposed_float(AssetList<VFXEntryExposed_float> target, AssetList<VFXEntryExposed_float> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F92 RID: 94098 RVA: 0x0035F544 File Offset: 0x0035D744
		public static void CopyValues__AssetList_VFXEntryExposed_Gradient_2018_3_0__AccessListBase_IVFXEntryExposed_Gradient(AssetList<VFXEntryExposed_Gradient_2018_3_0> target, AccessListBase<IVFXEntryExposed_Gradient> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F93 RID: 94099 RVA: 0x0035F58C File Offset: 0x0035D78C
		public static void CopyValues__AssetList_VFXEntryExposed_Gradient_2022_2_0__AccessListBase_IVFXEntryExposed_Gradient(AssetList<VFXEntryExposed_Gradient_2022_2_0> target, AccessListBase<IVFXEntryExposed_Gradient> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F94 RID: 94100 RVA: 0x0035F5D4 File Offset: 0x0035D7D4
		public static void CopyValues__AssetList_VFXEntryExposed_SInt32__AssetList_VFXEntryExposed_SInt32(AssetList<VFXEntryExposed_SInt32> target, AssetList<VFXEntryExposed_SInt32> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F95 RID: 94101 RVA: 0x0035F61C File Offset: 0x0035D81C
		public static void CopyValues__AssetList_VFXEntryExposed_Matrix4x4f__AssetList_VFXEntryExposed_Matrix4x4f(AssetList<VFXEntryExposed_Matrix4x4f> target, AssetList<VFXEntryExposed_Matrix4x4f> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F96 RID: 94102 RVA: 0x0035F664 File Offset: 0x0035D864
		public static void CopyValues__AssetList_VFXEntryExposed_PPtr_NamedObject__AssetList_VFXEntryExposed_PPtr_NamedObject(AssetList<VFXEntryExposed_PPtr_NamedObject> target, AssetList<VFXEntryExposed_PPtr_NamedObject> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F97 RID: 94103 RVA: 0x0035F6AC File Offset: 0x0035D8AC
		public static void CopyValues__AssetList_VFXEntryExposed_UInt32__AssetList_VFXEntryExposed_UInt32(AssetList<VFXEntryExposed_UInt32> target, AssetList<VFXEntryExposed_UInt32> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F98 RID: 94104 RVA: 0x0035F6F4 File Offset: 0x0035D8F4
		public static void CopyValues__AssetList_VFXEntryExposed_Vector2f__AssetList_VFXEntryExposed_Vector2f(AssetList<VFXEntryExposed_Vector2f> target, AssetList<VFXEntryExposed_Vector2f> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F99 RID: 94105 RVA: 0x0035F73C File Offset: 0x0035D93C
		public static void CopyValues__AssetList_VFXEntryExposed_Vector3f__AssetList_VFXEntryExposed_Vector3f(AssetList<VFXEntryExposed_Vector3f> target, AssetList<VFXEntryExposed_Vector3f> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F9A RID: 94106 RVA: 0x0035F784 File Offset: 0x0035D984
		public static void CopyValues__AssetList_VFXEntryExposed_Vector4f__AssetList_VFXEntryExposed_Vector4f(AssetList<VFXEntryExposed_Vector4f> target, AssetList<VFXEntryExposed_Vector4f> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F9B RID: 94107 RVA: 0x0035F7CC File Offset: 0x0035D9CC
		public static void CopyValues__AssetList_VFXEntryExposed_PPtr_Object__AssetList_VFXEntryExposed_PPtr_Object(AssetList<VFXEntryExposed_PPtr_Object> target, AssetList<VFXEntryExposed_PPtr_Object> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F9C RID: 94108 RVA: 0x0035F814 File Offset: 0x0035DA14
		public static void CopyValues__AssetDictionary_Utf8String_NonAlignedStruct__AssetDictionary_Utf8String_NonAlignedStruct(AssetDictionary<Utf8String, NonAlignedStruct> target, AssetDictionary<Utf8String, NonAlignedStruct> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_NonAlignedStruct__AccessPairBase_Utf8String_NonAlignedStruct(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F9D RID: 94109 RVA: 0x0035F861 File Offset: 0x0035DA61
		public static void CopyValues__AccessPairBase_Utf8String_NonAlignedStruct__AccessPairBase_Utf8String_NonAlignedStruct(AccessPairBase<Utf8String, NonAlignedStruct> target, AccessPairBase<Utf8String, NonAlignedStruct> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016F9E RID: 94110 RVA: 0x0035F888 File Offset: 0x0035DA88
		public static void CopyValues__AssetDictionary_SceneIdentifier_SceneVisibilityData__AssetDictionary_SceneIdentifier_SceneVisibilityData(AssetDictionary<SceneIdentifier, SceneVisibilityData> target, AssetDictionary<SceneIdentifier, SceneVisibilityData> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_SceneIdentifier_SceneVisibilityData__AccessPairBase_SceneIdentifier_SceneVisibilityData(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016F9F RID: 94111 RVA: 0x0035F8D5 File Offset: 0x0035DAD5
		public static void CopyValues__AccessPairBase_SceneIdentifier_SceneVisibilityData__AccessPairBase_SceneIdentifier_SceneVisibilityData(AccessPairBase<SceneIdentifier, SceneVisibilityData> target, AccessPairBase<SceneIdentifier, SceneVisibilityData> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016FA0 RID: 94112 RVA: 0x0035F8FC File Offset: 0x0035DAFC
		public static void CopyValues__AssetDictionary_SceneIdentifier_HierarchicalSceneData__AssetDictionary_SceneIdentifier_HierarchicalSceneData(AssetDictionary<SceneIdentifier, HierarchicalSceneData> target, AssetDictionary<SceneIdentifier, HierarchicalSceneData> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_SceneIdentifier_HierarchicalSceneData__AccessPairBase_SceneIdentifier_HierarchicalSceneData(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FA1 RID: 94113 RVA: 0x0035F949 File Offset: 0x0035DB49
		public static void CopyValues__AccessPairBase_SceneIdentifier_HierarchicalSceneData__AccessPairBase_SceneIdentifier_HierarchicalSceneData(AccessPairBase<SceneIdentifier, HierarchicalSceneData> target, AccessPairBase<SceneIdentifier, HierarchicalSceneData> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016FA2 RID: 94114 RVA: 0x0035F970 File Offset: 0x0035DB70
		public static void CopyValues__AssetList_AssetPair_Utf8String_Boolean__AssetList_AssetPair_Utf8String_Boolean(AssetList<AssetPair<Utf8String, bool>> target, AssetList<AssetPair<Utf8String, bool>> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					CopyValuesHelper.CopyValues__AssetPair_Utf8String_Boolean__AssetPair_Utf8String_Boolean(target.AddNew(), source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FA3 RID: 94115 RVA: 0x0035F9B6 File Offset: 0x0035DBB6
		public static void CopyValues__AssetPair_Utf8String_Boolean__AssetPair_Utf8String_Boolean(AssetPair<Utf8String, bool> target, AssetPair<Utf8String, bool> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value = source.Value;
			}
		}

		// Token: 0x06016FA4 RID: 94116 RVA: 0x0035F9D8 File Offset: 0x0035DBD8
		public static void CopyValues__AssetDictionary_Utf8String_Boolean__AssetDictionary_Utf8String_Boolean(AssetDictionary<Utf8String, bool> target, AssetDictionary<Utf8String, bool> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_Boolean__AccessPairBase_Utf8String_Boolean(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FA5 RID: 94117 RVA: 0x0035FA25 File Offset: 0x0035DC25
		public static void CopyValues__AccessPairBase_Utf8String_Boolean__AccessPairBase_Utf8String_Boolean(AccessPairBase<Utf8String, bool> target, AccessPairBase<Utf8String, bool> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value = source.Value;
			}
		}

		// Token: 0x06016FA6 RID: 94118 RVA: 0x0035FA48 File Offset: 0x0035DC48
		public static void CopyValues__AssetList_PropertyModificationsTargetTestNativeObject__AssetList_PropertyModificationsTargetTestNativeObject(AssetList<PropertyModificationsTargetTestNativeObject> target, AssetList<PropertyModificationsTargetTestNativeObject> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FA7 RID: 94119 RVA: 0x0035FA90 File Offset: 0x0035DC90
		public static void CopyValues__AssetList_ShaderError_5_5_0__AssetList_ShaderError_5_5_0(AssetList<ShaderError_5_5_0> target, AssetList<ShaderError_5_5_0> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FA8 RID: 94120 RVA: 0x0035FAD8 File Offset: 0x0035DCD8
		public static void CopyValues__AssetList_RayTracingShaderVariant_2019_3_0_a10__AccessListBase_IRayTracingShaderVariant(AssetList<RayTracingShaderVariant_2019_3_0_a10> target, AccessListBase<IRayTracingShaderVariant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FA9 RID: 94121 RVA: 0x0035FB20 File Offset: 0x0035DD20
		public static void CopyValues__AssetList_RayTracingShaderFunctionDesc__AssetList_RayTracingShaderFunctionDesc(AssetList<RayTracingShaderFunctionDesc> target, AssetList<RayTracingShaderFunctionDesc> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FAA RID: 94122 RVA: 0x0035FB68 File Offset: 0x0035DD68
		public static void CopyValues__AssetList_RayTracingShaderBuiltinSampler__AssetList_RayTracingShaderBuiltinSampler(AssetList<RayTracingShaderBuiltinSampler> target, AssetList<RayTracingShaderBuiltinSampler> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FAB RID: 94123 RVA: 0x0035FBB0 File Offset: 0x0035DDB0
		public static void CopyValues__AssetList_RayTracingShaderResource_2019_3_0_a10__AccessListBase_IRayTracingShaderResource(AssetList<RayTracingShaderResource_2019_3_0_a10> target, AccessListBase<IRayTracingShaderResource> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FAC RID: 94124 RVA: 0x0035FBF8 File Offset: 0x0035DDF8
		public static void CopyValues__AssetList_RayTracingShaderConstantBuffer_2019_3_0_a10__AccessListBase_IRayTracingShaderConstantBuffer(AssetList<RayTracingShaderConstantBuffer_2019_3_0_a10> target, AccessListBase<IRayTracingShaderConstantBuffer> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FAD RID: 94125 RVA: 0x0035FC40 File Offset: 0x0035DE40
		public static void CopyValues__AssetList_RayTracingShaderParam_2019_3_0_a10__AccessListBase_IRayTracingShaderParam(AssetList<RayTracingShaderParam_2019_3_0_a10> target, AccessListBase<IRayTracingShaderParam> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FAE RID: 94126 RVA: 0x0035FC88 File Offset: 0x0035DE88
		public static void CopyValues__AssetList_RayTracingShaderParam_2020_1_0_a17__AccessListBase_IRayTracingShaderParam(AssetList<RayTracingShaderParam_2020_1_0_a17> target, AccessListBase<IRayTracingShaderParam> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FAF RID: 94127 RVA: 0x0035FCD0 File Offset: 0x0035DED0
		public static void CopyValues__AssetList_RayTracingShaderParam_2021_1_0_a4__AccessListBase_IRayTracingShaderParam(AssetList<RayTracingShaderParam_2021_1_0_a4> target, AccessListBase<IRayTracingShaderParam> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FB0 RID: 94128 RVA: 0x0035FD18 File Offset: 0x0035DF18
		public static void CopyValues__AssetList_RayTracingShaderResource_2020_1_0_a17__AccessListBase_IRayTracingShaderResource(AssetList<RayTracingShaderResource_2020_1_0_a17> target, AccessListBase<IRayTracingShaderResource> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FB1 RID: 94129 RVA: 0x0035FD60 File Offset: 0x0035DF60
		public static void CopyValues__AssetList_RayTracingShaderConstantBuffer_2020_1_0_a17__AccessListBase_IRayTracingShaderConstantBuffer(AssetList<RayTracingShaderConstantBuffer_2020_1_0_a17> target, AccessListBase<IRayTracingShaderConstantBuffer> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FB2 RID: 94130 RVA: 0x0035FDA8 File Offset: 0x0035DFA8
		public static void CopyValues__AssetList_RayTracingShaderResource_2020_1_0_b10__AccessListBase_IRayTracingShaderResource(AssetList<RayTracingShaderResource_2020_1_0_b10> target, AccessListBase<IRayTracingShaderResource> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FB3 RID: 94131 RVA: 0x0035FDF0 File Offset: 0x0035DFF0
		public static void CopyValues__AssetList_RayTracingShaderConstantBuffer_2020_1_0_b10__AccessListBase_IRayTracingShaderConstantBuffer(AssetList<RayTracingShaderConstantBuffer_2020_1_0_b10> target, AccessListBase<IRayTracingShaderConstantBuffer> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FB4 RID: 94132 RVA: 0x0035FE38 File Offset: 0x0035E038
		public static void CopyValues__AssetList_RayTracingShaderConstantBuffer_2021_1_0_a4__AccessListBase_IRayTracingShaderConstantBuffer(AssetList<RayTracingShaderConstantBuffer_2021_1_0_a4> target, AccessListBase<IRayTracingShaderConstantBuffer> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FB5 RID: 94133 RVA: 0x0035FE80 File Offset: 0x0035E080
		public static void CopyValues__AssetList_RayTracingShaderVariant_2020_1_0_a17__AccessListBase_IRayTracingShaderVariant(AssetList<RayTracingShaderVariant_2020_1_0_a17> target, AccessListBase<IRayTracingShaderVariant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FB6 RID: 94134 RVA: 0x0035FEC8 File Offset: 0x0035E0C8
		public static void CopyValues__AssetList_RayTracingShaderVariant_2020_1_0_b10__AccessListBase_IRayTracingShaderVariant(AssetList<RayTracingShaderVariant_2020_1_0_b10> target, AccessListBase<IRayTracingShaderVariant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FB7 RID: 94135 RVA: 0x0035FF10 File Offset: 0x0035E110
		public static void CopyValues__AssetList_RayTracingShaderVariant_2021_1_0_a4__AccessListBase_IRayTracingShaderVariant(AssetList<RayTracingShaderVariant_2021_1_0_a4> target, AccessListBase<IRayTracingShaderVariant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FB8 RID: 94136 RVA: 0x0035FF58 File Offset: 0x0035E158
		public static void CopyValues__AssetList_RayTracingShaderVariant_2022_2_0__AccessListBase_IRayTracingShaderVariant(AssetList<RayTracingShaderVariant_2022_2_0> target, AccessListBase<IRayTracingShaderVariant> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FB9 RID: 94137 RVA: 0x0035FFA0 File Offset: 0x0035E1A0
		public static void CopyValues__AssetDictionary_Utf8String_AssetList_Utf8String__AssetDictionary_Utf8String_AssetList_Utf8String(AssetDictionary<Utf8String, AssetList<Utf8String>> target, AssetDictionary<Utf8String, AssetList<Utf8String>> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_AssetList_Utf8String__AccessPairBase_Utf8String_AssetList_Utf8String(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FBA RID: 94138 RVA: 0x0035FFED File Offset: 0x0035E1ED
		public static void CopyValues__AccessPairBase_Utf8String_AssetList_Utf8String__AccessPairBase_Utf8String_AssetList_Utf8String(AccessPairBase<Utf8String, AssetList<Utf8String>> target, AccessPairBase<Utf8String, AssetList<Utf8String>> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				CopyValuesHelper.CopyValues__AssetList_Utf8String__AssetList_Utf8String(target.Value, source.Value);
			}
		}

		// Token: 0x06016FBB RID: 94139 RVA: 0x00360014 File Offset: 0x0035E214
		public static void CopyValues__AssetList_BuildReportScenesUsingAsset__AssetList_BuildReportScenesUsingAsset(AssetList<BuildReportScenesUsingAsset> target, AssetList<BuildReportScenesUsingAsset> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FBC RID: 94140 RVA: 0x0036005C File Offset: 0x0035E25C
		public static void CopyValues__AssetDictionary_Utf8String_SecondaryTextureSettings_2020_2_0_a12__AssetDictionary_Utf8String_SecondaryTextureSettings_2020_2_0_a12(AssetDictionary<Utf8String, SecondaryTextureSettings_2020_2_0_a12> target, AssetDictionary<Utf8String, SecondaryTextureSettings_2020_2_0_a12> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Utf8String_SecondaryTextureSettings_2020_2_0_a12__AccessPairBase_Utf8String_SecondaryTextureSettings_2020_2_0_a12(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FBD RID: 94141 RVA: 0x003600A9 File Offset: 0x0035E2A9
		public static void CopyValues__AccessPairBase_Utf8String_SecondaryTextureSettings_2020_2_0_a12__AccessPairBase_Utf8String_SecondaryTextureSettings_2020_2_0_a12(AccessPairBase<Utf8String, SecondaryTextureSettings_2020_2_0_a12> target, AccessPairBase<Utf8String, SecondaryTextureSettings_2020_2_0_a12> source)
		{
			if (source != null)
			{
				target.Key.CopyValues(source.Key);
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016FBE RID: 94142 RVA: 0x003600D0 File Offset: 0x0035E2D0
		public static void CopyValues__AssetList_PhysicsShape__AssetList_PhysicsShape(AssetList<PhysicsShape> target, AssetList<PhysicsShape> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FBF RID: 94143 RVA: 0x00360118 File Offset: 0x0035E318
		public static void CopyValues__AssetDictionary_Int32_PlatformMemorySettings__AssetDictionary_Int32_PlatformMemorySettings(AssetDictionary<int, PlatformMemorySettings> target, AssetDictionary<int, PlatformMemorySettings> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew();
					CopyValuesHelper.CopyValues__AccessPairBase_Int32_PlatformMemorySettings__AccessPairBase_Int32_PlatformMemorySettings(target.GetPair(i), source.GetPair(i));
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FC0 RID: 94144 RVA: 0x00360165 File Offset: 0x0035E365
		public static void CopyValues__AccessPairBase_Int32_PlatformMemorySettings__AccessPairBase_Int32_PlatformMemorySettings(AccessPairBase<int, PlatformMemorySettings> target, AccessPairBase<int, PlatformMemorySettings> source)
		{
			if (source != null)
			{
				target.Key = source.Key;
				target.Value.CopyValues(source.Value);
			}
		}

		// Token: 0x06016FC1 RID: 94145 RVA: 0x00360188 File Offset: 0x0035E388
		public static void CopyValues__AssetList_IconWithSize_3_4_0__AccessListBase_IIconWithSize(AssetList<IconWithSize_3_4_0> target, AccessListBase<IIconWithSize> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FC2 RID: 94146 RVA: 0x003601D0 File Offset: 0x0035E3D0
		public static void CopyValues__AssetList_IconWithSize_5_0_0__AccessListBase_IIconWithSize(AssetList<IconWithSize_5_0_0> target, AccessListBase<IIconWithSize> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FC3 RID: 94147 RVA: 0x00360218 File Offset: 0x0035E418
		public static void CopyValues__AssetList_IconWithSize_5_2_2__AccessListBase_IIconWithSize(AssetList<IconWithSize_5_2_2> target, AccessListBase<IIconWithSize> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FC4 RID: 94148 RVA: 0x00360260 File Offset: 0x0035E460
		public static void CopyValues__AssetList_IconWithSize_5_6_4__AccessListBase_IIconWithSize(AssetList<IconWithSize_5_6_4> target, AccessListBase<IIconWithSize> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FC5 RID: 94149 RVA: 0x003602A8 File Offset: 0x0035E4A8
		public static void CopyValues__AssetList_IconWithSize_2017_1_0__AccessListBase_IIconWithSize(AssetList<IconWithSize_2017_1_0> target, AccessListBase<IIconWithSize> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FC6 RID: 94150 RVA: 0x003602F0 File Offset: 0x0035E4F0
		public static void CopyValues__AssetList_IconWithSize_2017_1_2__AccessListBase_IIconWithSize(AssetList<IconWithSize_2017_1_2> target, AccessListBase<IIconWithSize> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FC7 RID: 94151 RVA: 0x00360338 File Offset: 0x0035E538
		public static void CopyValues__AssetList_IconWithSize_2017_2_0__AccessListBase_IIconWithSize(AssetList<IconWithSize_2017_2_0> target, AccessListBase<IIconWithSize> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FC8 RID: 94152 RVA: 0x00360380 File Offset: 0x0035E580
		public static void CopyValues__AssetList_IconWithSize_2017_2_0_b9__AccessListBase_IIconWithSize(AssetList<IconWithSize_2017_2_0_b9> target, AccessListBase<IIconWithSize> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FC9 RID: 94153 RVA: 0x003603C8 File Offset: 0x0035E5C8
		public static void CopyValues__AssetList_AssetDictionary_Utf8String_Utf8String__AssetList_AssetDictionary_Utf8String_Utf8String(AssetList<AssetDictionary<Utf8String, Utf8String>> target, AssetList<AssetDictionary<Utf8String, Utf8String>> source)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					CopyValuesHelper.CopyValues__AssetDictionary_Utf8String_Utf8String__AssetDictionary_Utf8String_Utf8String(target.AddNew(), source[i]);
				}
				return;
			}
			target.Capacity = 0;
		}

		// Token: 0x06016FCA RID: 94154 RVA: 0x00360410 File Offset: 0x0035E610
		public static void CopyValues__AssetList_PlatformIcon__AssetList_PlatformIcon(AssetList<PlatformIcon> target, AssetList<PlatformIcon> source, PPtrConverter converter)
		{
			if (source != null)
			{
				int num = (target.Capacity = source.Count);
				for (int i = 0; i < num; i++)
				{
					target.AddNew().CopyValues(source[i], converter);
				}
				return;
			}
			target.Capacity = 0;
		}
	}
}
