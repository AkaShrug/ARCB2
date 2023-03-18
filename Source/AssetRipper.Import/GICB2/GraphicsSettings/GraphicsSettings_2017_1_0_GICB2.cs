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
using AssetRipper.SourceGenerated.Classes.ClassID_0;
using AssetRipper.SourceGenerated.Classes.ClassID_114;
using AssetRipper.SourceGenerated.Classes.ClassID_200;
using AssetRipper.SourceGenerated.Classes.ClassID_21;
using AssetRipper.SourceGenerated.Classes.ClassID_48;
using AssetRipper.SourceGenerated.Classes.ClassID_6;
using AssetRipper.SourceGenerated.Classes.ClassID_9;
using AssetRipper.SourceGenerated.Enums;
using AssetRipper.SourceGenerated.Helpers;
using AssetRipper.SourceGenerated.Interfaces;
using AssetRipper.SourceGenerated.MarkerInterfaces;
using AssetRipper.SourceGenerated.Subclasses.AlbedoSwitchInfo;
using AssetRipper.SourceGenerated.Subclasses.BuiltinShaderSettings;
using AssetRipper.SourceGenerated.Subclasses.PlatformShaderDefines;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Material;
using AssetRipper.SourceGenerated.Subclasses.PPtr_MonoBehaviour;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Object;
using AssetRipper.SourceGenerated.Subclasses.PPtr_ShaderVariantCollection;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Shader;
using AssetRipper.SourceGenerated.Subclasses.TierGraphicsSettings;
using AssetRipper.SourceGenerated.Subclasses.TierGraphicsSettingsEditor;
using AssetRipper.SourceGenerated.Subclasses.TierSettings;
using AssetRipper.SourceGenerated.Subclasses.Utf8String;
using AssetRipper.SourceGenerated.Subclasses.Vector3f;
using AssetRipper.Yaml;
using AssetRipper.SourceGenerated.Classes.ClassID_30;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Texture2D;
using AssetRipper.Import.IO.Extensions;

namespace AssetRipper.Import.GICB2.GraphicsSettings
{
	// Token: 0x02002959 RID: 10585


	public sealed class GraphicsSettings_2017_1_0_GICB2 : GlobalGameManager, IGraphicsSettings, IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IGlobalGameManager, IGlobalGameManagerMarker, IGameManager, IGameManagerMarker, IObject, IObjectMarker, IHasHideFlags, IGraphicsSettingsMarker
	{
		// Token: 0x1700D308 RID: 54024
		// (get) Token: 0x0602AD19 RID: 175385 RVA: 0x006087E2 File Offset: 0x006069E2

		public AssetList<AlbedoSwitchInfo> AlbedoSwitchInfos_C30
		{

			[return: NotNull]
			get
			{
				return this.m_AlbedoSwitchInfos;
			}
		}

		// Token: 0x1700D309 RID: 54025
		// (get) Token: 0x0602AD1A RID: 175386 RVA: 0x006087EA File Offset: 0x006069EA
		// (set) Token: 0x0602AD1B RID: 175387 RVA: 0x006087ED File Offset: 0x006069ED
		public bool AllowEnlightenSupportForUpgradedProject_C30
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700D30A RID: 54026
		// (get) Token: 0x0602AD1C RID: 175388 RVA: 0x006087EF File Offset: 0x006069EF

		public AccessListBase<IPPtr_Shader> AlwaysIncludedShaders_C30
		{

			[return: NotNull]
			get
			{
				return new AccessList<PPtr_Shader_5_0_0, IPPtr_Shader>(this.m_AlwaysIncludedShaders);
			}
		}

		// Token: 0x1700D30B RID: 54027
		// (get) Token: 0x0602AD1D RID: 175389 RVA: 0x006087FC File Offset: 0x006069FC
		// (set) Token: 0x0602AD1E RID: 175390 RVA: 0x006087FF File Offset: 0x006069FF
		public int BrgStripping_C30
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700D30C RID: 54028
		// (get) Token: 0x0602AD1F RID: 175391 RVA: 0x00608801 File Offset: 0x00606A01
		public PPtr_MonoBehaviour_5_0_0 CustomRenderPipeline_C30
		{
			[return: NotNull]
			get
			{
				return this.m_CustomRenderPipeline;
			}
		}

		// Token: 0x1700D30D RID: 54029
		// (get) Token: 0x0602AD20 RID: 175392 RVA: 0x00608809 File Offset: 0x00606A09
		// (set) Token: 0x0602AD21 RID: 175393 RVA: 0x00608811 File Offset: 0x00606A11
		public int DefaultMobileRenderingPath_C30
		{
			get
			{
				return this.m_DefaultMobileRenderingPath;
			}
			set
			{
				this.m_DefaultMobileRenderingPath = value;
			}
		}

		// Token: 0x1700D30E RID: 54030
		// (get) Token: 0x0602AD22 RID: 175394 RVA: 0x0060881A File Offset: 0x00606A1A
		// (set) Token: 0x0602AD23 RID: 175395 RVA: 0x0060881D File Offset: 0x00606A1D
		public uint DefaultRenderingLayerMask_C30
		{
			get
			{
				return 0U;
			}
			set
			{
			}
		}

		// Token: 0x1700D30F RID: 54031
		// (get) Token: 0x0602AD24 RID: 175396 RVA: 0x0060881F File Offset: 0x00606A1F
		// (set) Token: 0x0602AD25 RID: 175397 RVA: 0x00608827 File Offset: 0x00606A27
		public int DefaultRenderingPath_C30
		{
			get
			{
				return this.m_DefaultRenderingPath;
			}
			set
			{
				this.m_DefaultRenderingPath = value;
			}
		}

		// Token: 0x1700D310 RID: 54032
		// (get) Token: 0x0602AD26 RID: 175398 RVA: 0x00608830 File Offset: 0x00606A30
		public BuiltinShaderSettings Deferred_C30
		{
			[return: NotNull]
			get
			{
				return this.m_Deferred;
			}
		}

		// Token: 0x1700D311 RID: 54033
		// (get) Token: 0x0602AD27 RID: 175399 RVA: 0x00608838 File Offset: 0x00606A38
		public BuiltinShaderSettings DeferredReflections_C30
		{
			[return: NotNull]
			get
			{
				return this.m_DeferredReflections;
			}
		}

		// Token: 0x1700D312 RID: 54034
		// (get) Token: 0x0602AD28 RID: 175400 RVA: 0x00608840 File Offset: 0x00606A40
		public BuiltinShaderSettings DepthNormals_C30
		{
			[return: NotNull]
			get
			{
				return this.m_DepthNormals;
			}
		}

		// Token: 0x1700D313 RID: 54035
		// (get) Token: 0x0602AD29 RID: 175401 RVA: 0x00608848 File Offset: 0x00606A48
		// (set) Token: 0x0602AD2A RID: 175402 RVA: 0x00608850 File Offset: 0x00606A50
		public bool FogKeepExp_C30
		{
			get
			{
				return this.m_FogKeepExp;
			}
			set
			{
				this.m_FogKeepExp = value;
			}
		}

		// Token: 0x1700D314 RID: 54036
		// (get) Token: 0x0602AD2B RID: 175403 RVA: 0x00608859 File Offset: 0x00606A59
		// (set) Token: 0x0602AD2C RID: 175404 RVA: 0x00608861 File Offset: 0x00606A61
		public bool FogKeepExp2_C30
		{
			get
			{
				return this.m_FogKeepExp2;
			}
			set
			{
				this.m_FogKeepExp2 = value;
			}
		}

		// Token: 0x1700D315 RID: 54037
		// (get) Token: 0x0602AD2D RID: 175405 RVA: 0x0060886A File Offset: 0x00606A6A
		// (set) Token: 0x0602AD2E RID: 175406 RVA: 0x00608872 File Offset: 0x00606A72
		public bool FogKeepLinear_C30
		{
			get
			{
				return this.m_FogKeepLinear;
			}
			set
			{
				this.m_FogKeepLinear = value;
			}
		}

		// Token: 0x1700D316 RID: 54038
		// (get) Token: 0x0602AD2F RID: 175407 RVA: 0x0060887B File Offset: 0x00606A7B
		// (set) Token: 0x0602AD30 RID: 175408 RVA: 0x00608883 File Offset: 0x00606A83
		public int FogStripping_C30
		{
			get
			{
				return this.m_FogStripping;
			}
			set
			{
				this.m_FogStripping = value;
			}
		}

		// Token: 0x1700D317 RID: 54039
		// (get) Token: 0x0602AD31 RID: 175409 RVA: 0x0060888C File Offset: 0x00606A8C
		// (set) Token: 0x0602AD32 RID: 175410 RVA: 0x00608894 File Offset: 0x00606A94
		public uint HideFlags_C30
		{
			get
			{
				return this.m_HideFlags;
			}
			set
			{
				this.m_HideFlags = value;
			}
		}

		// Token: 0x1700D318 RID: 54040
		// (get) Token: 0x0602AD33 RID: 175411 RVA: 0x0060889D File Offset: 0x00606A9D
		// (set) Token: 0x0602AD34 RID: 175412 RVA: 0x006088A5 File Offset: 0x00606AA5
		public int InstancingStripping_C30
		{
			get
			{
				return this.m_InstancingStripping;
			}
			set
			{
				this.m_InstancingStripping = value;
			}
		}

		// Token: 0x1700D319 RID: 54041
		// (get) Token: 0x0602AD35 RID: 175413 RVA: 0x006088AE File Offset: 0x00606AAE
		public BuiltinShaderSettings LegacyDeferred_C30
		{
			[return: NotNull]
			get
			{
				return this.m_LegacyDeferred;
			}
		}

		// Token: 0x1700D31A RID: 54042
		// (get) Token: 0x0602AD36 RID: 175414 RVA: 0x006088B6 File Offset: 0x00606AB6
		public BuiltinShaderSettings LensFlare_C30
		{
			[return: NotNull]
			get
			{
				return this.m_LensFlare;
			}
		}

		// Token: 0x1700D31B RID: 54043
		// (get) Token: 0x0602AD37 RID: 175415 RVA: 0x006088BE File Offset: 0x00606ABE
		public BuiltinShaderSettings LightHalo_C30
		{
			[return: NotNull]
			get
			{
				return this.m_LightHalo;
			}
		}

		// Token: 0x1700D31C RID: 54044
		// (get) Token: 0x0602AD38 RID: 175416 RVA: 0x006088C6 File Offset: 0x00606AC6
		// (set) Token: 0x0602AD39 RID: 175417 RVA: 0x006088CE File Offset: 0x00606ACE
		public bool LightmapKeepDirCombined_C30
		{
			get
			{
				return this.m_LightmapKeepDirCombined;
			}
			set
			{
				this.m_LightmapKeepDirCombined = value;
			}
		}

		// Token: 0x1700D31D RID: 54045
		// (get) Token: 0x0602AD3A RID: 175418 RVA: 0x006088D7 File Offset: 0x00606AD7
		// (set) Token: 0x0602AD3B RID: 175419 RVA: 0x006088DA File Offset: 0x00606ADA
		public bool LightmapKeepDirSeparate_C30
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700D31E RID: 54046
		// (get) Token: 0x0602AD3C RID: 175420 RVA: 0x006088DC File Offset: 0x00606ADC
		// (set) Token: 0x0602AD3D RID: 175421 RVA: 0x006088DF File Offset: 0x00606ADF
		public bool LightmapKeepDynamic_C30
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700D31F RID: 54047
		// (get) Token: 0x0602AD3E RID: 175422 RVA: 0x006088E1 File Offset: 0x00606AE1
		// (set) Token: 0x0602AD3F RID: 175423 RVA: 0x006088E9 File Offset: 0x00606AE9
		public bool LightmapKeepDynamicDirCombined_C30
		{
			get
			{
				return this.m_LightmapKeepDynamicDirCombined;
			}
			set
			{
				this.m_LightmapKeepDynamicDirCombined = value;
			}
		}

		// Token: 0x1700D320 RID: 54048
		// (get) Token: 0x0602AD40 RID: 175424 RVA: 0x006088F2 File Offset: 0x00606AF2
		// (set) Token: 0x0602AD41 RID: 175425 RVA: 0x006088F5 File Offset: 0x00606AF5
		public bool LightmapKeepDynamicDirSeparate_C30
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700D321 RID: 54049
		// (get) Token: 0x0602AD42 RID: 175426 RVA: 0x006088F7 File Offset: 0x00606AF7
		// (set) Token: 0x0602AD43 RID: 175427 RVA: 0x006088FF File Offset: 0x00606AFF
		public bool LightmapKeepDynamicPlain_C30
		{
			get
			{
				return this.m_LightmapKeepDynamicPlain;
			}
			set
			{
				this.m_LightmapKeepDynamicPlain = value;
			}
		}

		// Token: 0x1700D322 RID: 54050
		// (get) Token: 0x0602AD44 RID: 175428 RVA: 0x00608908 File Offset: 0x00606B08
		// (set) Token: 0x0602AD45 RID: 175429 RVA: 0x00608910 File Offset: 0x00606B10
		public bool LightmapKeepPlain_C30
		{
			get
			{
				return this.m_LightmapKeepPlain;
			}
			set
			{
				this.m_LightmapKeepPlain = value;
			}
		}

		// Token: 0x1700D323 RID: 54051
		// (get) Token: 0x0602AD46 RID: 175430 RVA: 0x00608919 File Offset: 0x00606B19
		// (set) Token: 0x0602AD47 RID: 175431 RVA: 0x00608921 File Offset: 0x00606B21
		public bool LightmapKeepShadowMask_C30
		{
			get
			{
				return this.m_LightmapKeepShadowMask;
			}
			set
			{
				this.m_LightmapKeepShadowMask = value;
			}
		}

		// Token: 0x1700D324 RID: 54052
		// (get) Token: 0x0602AD48 RID: 175432 RVA: 0x0060892A File Offset: 0x00606B2A
		// (set) Token: 0x0602AD49 RID: 175433 RVA: 0x00608932 File Offset: 0x00606B32
		public bool LightmapKeepSubtractive_C30
		{
			get
			{
				return this.m_LightmapKeepSubtractive;
			}
			set
			{
				this.m_LightmapKeepSubtractive = value;
			}
		}

		// Token: 0x1700D325 RID: 54053
		// (get) Token: 0x0602AD4A RID: 175434 RVA: 0x0060893B File Offset: 0x00606B3B
		// (set) Token: 0x0602AD4B RID: 175435 RVA: 0x00608943 File Offset: 0x00606B43
		public int LightmapStripping_C30
		{
			get
			{
				return this.m_LightmapStripping;
			}
			set
			{
				this.m_LightmapStripping = value;
			}
		}

		// Token: 0x1700D326 RID: 54054
		// (get) Token: 0x0602AD4C RID: 175436 RVA: 0x0060894C File Offset: 0x00606B4C
		// (set) Token: 0x0602AD4D RID: 175437 RVA: 0x0060894F File Offset: 0x00606B4F
		public int LightProbeOutsideHullStrategy_C30
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700D327 RID: 54055
		// (get) Token: 0x0602AD4E RID: 175438 RVA: 0x00608951 File Offset: 0x00606B51
		// (set) Token: 0x0602AD4F RID: 175439 RVA: 0x00608954 File Offset: 0x00606B54
		public bool LightsUseCCT_C30
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700D328 RID: 54056
		// (get) Token: 0x0602AD50 RID: 175440 RVA: 0x00608956 File Offset: 0x00606B56
		// (set) Token: 0x0602AD51 RID: 175441 RVA: 0x0060895E File Offset: 0x00606B5E
		public bool LightsUseColorTemperature_C30
		{
			get
			{
				return this.m_LightsUseColorTemperature;
			}
			set
			{
				this.m_LightsUseColorTemperature = value;
			}
		}

		// Token: 0x1700D329 RID: 54057
		// (get) Token: 0x0602AD52 RID: 175442 RVA: 0x00608967 File Offset: 0x00606B67
		// (set) Token: 0x0602AD53 RID: 175443 RVA: 0x0060896F File Offset: 0x00606B6F
		public bool LightsUseLinearIntensity_C30
		{
			get
			{
				return this.m_LightsUseLinearIntensity;
			}
			set
			{
				this.m_LightsUseLinearIntensity = value;
			}
		}

		// Token: 0x1700D32A RID: 54058
		// (get) Token: 0x0602AD54 RID: 175444 RVA: 0x00608978 File Offset: 0x00606B78
		// (set) Token: 0x0602AD55 RID: 175445 RVA: 0x0060897B File Offset: 0x00606B7B
		public bool LogWhenShaderIsCompiled_C30
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700D32B RID: 54059
		// (get) Token: 0x0602AD56 RID: 175446 RVA: 0x0060897D File Offset: 0x00606B7D
		public BuiltinShaderSettings MotionVectors_C30
		{
			[return: NotNull]
			get
			{
				return this.m_MotionVectors;
			}
		}

		// Token: 0x1700D32C RID: 54060
		// (get) Token: 0x0602AD57 RID: 175447 RVA: 0x00608985 File Offset: 0x00606B85

		public AssetList<PPtr_ShaderVariantCollection> PreloadedShaders_C30
		{

			[return: NotNull]
			get
			{
				return this.m_PreloadedShaders;
			}
		}

		// Token: 0x1700D32D RID: 54061
		// (get) Token: 0x0602AD58 RID: 175448 RVA: 0x0060898D File Offset: 0x00606B8D
		// (set) Token: 0x0602AD59 RID: 175449 RVA: 0x00608990 File Offset: 0x00606B90
		public int PreloadShadersBatchTimeLimit_C30
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700D32E RID: 54062
		// (get) Token: 0x0602AD5A RID: 175450 RVA: 0x00608992 File Offset: 0x00606B92
		public BuiltinShaderSettings ScreenSpaceShadows_C30
		{
			[return: NotNull]
			get
			{
				return this.m_ScreenSpaceShadows;
			}
		}

		// Token: 0x1700D32F RID: 54063
		// (get) Token: 0x0602AD5B RID: 175451 RVA: 0x0060899A File Offset: 0x00606B9A

		public AssetList<PlatformShaderDefines> ShaderDefinesPerShaderCompiler_C30
		{

			[return: NotNull]
			get
			{
				return this.m_ShaderDefinesPerShaderCompiler;
			}
		}

		// Token: 0x1700D330 RID: 54064
		// (get) Token: 0x0602AD5C RID: 175452 RVA: 0x006089A2 File Offset: 0x00606BA2
		public TierGraphicsSettingsEditor_5_3_0 ShaderSettings_C30
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700D331 RID: 54065
		// (get) Token: 0x0602AD5D RID: 175453 RVA: 0x006089A5 File Offset: 0x00606BA5
		public TierGraphicsSettingsEditor_5_4_0 ShaderSettings_Tier1_C30
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700D332 RID: 54066
		// (get) Token: 0x0602AD5E RID: 175454 RVA: 0x006089A8 File Offset: 0x00606BA8
		public TierGraphicsSettingsEditor_5_4_0 ShaderSettings_Tier2_C30
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700D333 RID: 54067
		// (get) Token: 0x0602AD5F RID: 175455 RVA: 0x006089AB File Offset: 0x00606BAB
		public TierGraphicsSettingsEditor_5_4_0 ShaderSettings_Tier3_C30
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700D334 RID: 54068
		// (get) Token: 0x0602AD60 RID: 175456 RVA: 0x006089AE File Offset: 0x00606BAE
		public PPtr_Material_5_0_0 SpritesDefaultMaterial_C30
		{
			[return: NotNull]
			get
			{
				return this.m_SpritesDefaultMaterial;
			}
		}

		// Token: 0x1700D335 RID: 54069
		// (get) Token: 0x0602AD61 RID: 175457 RVA: 0x006089B6 File Offset: 0x00606BB6

		public AssetDictionary<Utf8String, PPtr_Object_5_0_0> SRPDefaultSettings_C30
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700D336 RID: 54070
		// (get) Token: 0x0602AD62 RID: 175458 RVA: 0x006089B9 File Offset: 0x00606BB9

		public AccessListBase<ITierSettings> TierSettings_C30
		{

			[return: NotNull]
			get
			{
				return new AccessList<TierSettings_2017_1_0, ITierSettings>(this.m_TierSettings);
			}
		}

		// Token: 0x1700D337 RID: 54071
		// (get) Token: 0x0602AD63 RID: 175459 RVA: 0x006089C6 File Offset: 0x00606BC6
		public ITierGraphicsSettings TierSettings_Tier1_C30
		{
			[return: NotNull]
			get
			{
				return this.m_TierSettings_Tier1;
			}
		}

		// Token: 0x1700D338 RID: 54072
		// (get) Token: 0x0602AD64 RID: 175460 RVA: 0x006089CE File Offset: 0x00606BCE
		public ITierGraphicsSettings TierSettings_Tier2_C30
		{
			[return: NotNull]
			get
			{
				return this.m_TierSettings_Tier2;
			}
		}

		// Token: 0x1700D339 RID: 54073
		// (get) Token: 0x0602AD65 RID: 175461 RVA: 0x006089D6 File Offset: 0x00606BD6
		public ITierGraphicsSettings TierSettings_Tier3_C30
		{
			[return: NotNull]
			get
			{
				return this.m_TierSettings_Tier3;
			}
		}

		// Token: 0x1700D33A RID: 54074
		// (get) Token: 0x0602AD66 RID: 175462 RVA: 0x006089DE File Offset: 0x00606BDE
		public Vector3f_3_5_0 TransparencySortAxis_C30
		{
			[return: NotNull]
			get
			{
				return this.m_TransparencySortAxis;
			}
		}

		// Token: 0x1700D33B RID: 54075
		// (get) Token: 0x0602AD67 RID: 175463 RVA: 0x006089E6 File Offset: 0x00606BE6
		// (set) Token: 0x0602AD68 RID: 175464 RVA: 0x006089EE File Offset: 0x00606BEE
		public int TransparencySortMode_C30
		{
			get
			{
				return this.m_TransparencySortMode;
			}
			set
			{
				this.m_TransparencySortMode = value;
			}
		}

		// Token: 0x1700D33C RID: 54076
		// (get) Token: 0x0602AD69 RID: 175465 RVA: 0x006089F7 File Offset: 0x00606BF7
		// (set) Token: 0x0602AD6A RID: 175466 RVA: 0x006089FA File Offset: 0x00606BFA
		public int VideoShadersIncludeMode_C30
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700D33D RID: 54077
		// (get) Token: 0x0602AD6B RID: 175467 RVA: 0x006089FC File Offset: 0x00606BFC
		// (set) Token: 0x0602AD6C RID: 175468 RVA: 0x00608A04 File Offset: 0x00606C04
		public HideFlags HideFlags_C30E
		{
			get
			{
				return (HideFlags)this.m_HideFlags;
			}
			set
			{
				this.m_HideFlags = (uint)value;
			}
		}

		// Token: 0x1700D33E RID: 54078
		// (get) Token: 0x0602AD6D RID: 175469 RVA: 0x00608A0D File Offset: 0x00606C0D
		// (set) Token: 0x0602AD6E RID: 175470 RVA: 0x00608A10 File Offset: 0x00606C10
		public LightProbeOutsideHullStrategy LightProbeOutsideHullStrategy_C30E
		{
			get
			{
				return LightProbeOutsideHullStrategy.kLightProbeSearchTetrahedralHull;
			}
			set
			{
			}
		}

		// Token: 0x1700D33F RID: 54079
		// (get) Token: 0x0602AD6F RID: 175471 RVA: 0x00608A12 File Offset: 0x00606C12
		// (set) Token: 0x0602AD70 RID: 175472 RVA: 0x00608A1A File Offset: 0x00606C1A
		public TransparencySortMode TransparencySortMode_C30E
		{
			get
			{
				return (TransparencySortMode)this.m_TransparencySortMode;
			}
			set
			{
				this.m_TransparencySortMode = (int)value;
			}
		}

		// Token: 0x1700D340 RID: 54080
		// (get) Token: 0x0602AD71 RID: 175473 RVA: 0x00608A23 File Offset: 0x00606C23
		// (set) Token: 0x0602AD72 RID: 175474 RVA: 0x00608A26 File Offset: 0x00606C26
		public VideoShadersIncludeMode VideoShadersIncludeMode_C30E
		{
			get
			{
				return VideoShadersIncludeMode.Never;
			}
			set
			{
			}
		}

		// Token: 0x1700D341 RID: 54081
		// (get) Token: 0x0602AD73 RID: 175475 RVA: 0x00608A28 File Offset: 0x00606C28

		public PPtrAccessList<IPPtr_Shader, IShader> AlwaysIncludedShaders_C30P
		{

			get
			{
				return new PPtrAccessList<IPPtr_Shader, IShader>(this.AlwaysIncludedShaders_C30, this);
			}
		}

		// Token: 0x1700D342 RID: 54082
		// (get) Token: 0x0602AD74 RID: 175476 RVA: 0x00608A36 File Offset: 0x00606C36
		// (set) Token: 0x0602AD75 RID: 175477 RVA: 0x00608A49 File Offset: 0x00606C49
		public IMonoBehaviour CustomRenderPipeline_C30P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IMonoBehaviour>(this.CustomRenderPipeline_C30, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IMonoBehaviour>(this.CustomRenderPipeline_C30, base.Collection, value);
			}
		}

		// Token: 0x1700D343 RID: 54083
		// (get) Token: 0x0602AD76 RID: 175478 RVA: 0x00608A5D File Offset: 0x00606C5D

		public PPtrAccessList<PPtr_ShaderVariantCollection, IShaderVariantCollection> PreloadedShaders_C30P
		{

			get
			{
				return new PPtrAccessList<PPtr_ShaderVariantCollection, IShaderVariantCollection>(this.PreloadedShaders_C30, this);
			}
		}

		// Token: 0x1700D344 RID: 54084
		// (get) Token: 0x0602AD77 RID: 175479 RVA: 0x00608A6B File Offset: 0x00606C6B
		// (set) Token: 0x0602AD78 RID: 175480 RVA: 0x00608A7E File Offset: 0x00606C7E
		public IMaterial SpritesDefaultMaterial_C30P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IMaterial>(this.SpritesDefaultMaterial_C30, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IMaterial>(this.SpritesDefaultMaterial_C30, base.Collection, value);
			}
		}

		// Token: 0x1700D345 RID: 54085
		// (get) Token: 0x0602AD79 RID: 175481 RVA: 0x00608A92 File Offset: 0x00606C92

		public override string ClassName
		{

			get
			{
				return "GraphicsSettings";
			}
		}

		public bool CameraRelativeLightCulling_C30 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool CameraRelativeShadowCulling_C30 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		// Token: 0x0602AD7A RID: 175482 RVA: 0x00608A99 File Offset: 0x00606C99
		public GraphicsSettings_2017_1_0_GICB2()
			: this(AssetInfo.MakeDummyAssetInfo(30))
		{
		}

		// Token: 0x0602AD7B RID: 175483 RVA: 0x00608AA8 File Offset: 0x00606CA8
		public GraphicsSettings_2017_1_0_GICB2(AssetInfo info)
			: base(info)
		{
			this.m_TierSettings_Tier1 = new TierGraphicsSettings_2017_1_0();
			this.m_TierSettings_Tier2 = new TierGraphicsSettings_2017_1_0();
			this.m_TierSettings_Tier3 = new TierGraphicsSettings_2017_1_0();
			this.m_ShaderDefinesPerShaderCompiler = new AssetList<PlatformShaderDefines>();
			this.m_TierSettings = new AssetList<TierSettings_2017_1_0>();
			this.m_AlbedoSwitchInfos = new AssetList<AlbedoSwitchInfo>();
			this.m_Deferred = new BuiltinShaderSettings();
			this.m_DeferredReflections = new BuiltinShaderSettings();
			this.m_ScreenSpaceShadows = new BuiltinShaderSettings();
			this.m_LegacyDeferred = new BuiltinShaderSettings();
			this.m_DepthNormals = new BuiltinShaderSettings();
			this.m_MotionVectors = new BuiltinShaderSettings();
			this.m_LightHalo = new BuiltinShaderSettings();
			this.m_LensFlare = new BuiltinShaderSettings();
			this.m_AlwaysIncludedShaders = new AssetList<PPtr_Shader_5_0_0>();
			this.m_PreloadedShaders = new AssetList<PPtr_ShaderVariantCollection>();
			this.m_SpritesDefaultMaterial = new PPtr_Material_5_0_0();
			this.m_CustomRenderPipeline = new PPtr_MonoBehaviour_5_0_0();
			this.m_TransparencySortAxis = new Vector3f_3_5_0();
		}

		// Token: 0x0602AD7C RID: 175484 RVA: 0x00608B8D File Offset: 0x00606D8D
		public bool Has_AlbedoSwitchInfos_C30()
		{
			return true;
		}

		// Token: 0x0602AD7D RID: 175485 RVA: 0x00608B90 File Offset: 0x00606D90
		public bool Has_AllowEnlightenSupportForUpgradedProject_C30()
		{
			return false;
		}

		// Token: 0x0602AD7E RID: 175486 RVA: 0x00608B93 File Offset: 0x00606D93
		public bool Has_AlwaysIncludedShaders_C30()
		{
			return true;
		}

		// Token: 0x0602AD7F RID: 175487 RVA: 0x00608B96 File Offset: 0x00606D96
		public bool Has_BrgStripping_C30()
		{
			return false;
		}

		// Token: 0x0602AD80 RID: 175488 RVA: 0x00608B99 File Offset: 0x00606D99
		public bool Has_CustomRenderPipeline_C30()
		{
			return true;
		}

		// Token: 0x0602AD81 RID: 175489 RVA: 0x00608B9C File Offset: 0x00606D9C
		public bool Has_DefaultMobileRenderingPath_C30()
		{
			return true;
		}

		// Token: 0x0602AD82 RID: 175490 RVA: 0x00608B9F File Offset: 0x00606D9F
		public bool Has_DefaultRenderingLayerMask_C30()
		{
			return false;
		}

		// Token: 0x0602AD83 RID: 175491 RVA: 0x00608BA2 File Offset: 0x00606DA2
		public bool Has_DefaultRenderingPath_C30()
		{
			return true;
		}

		// Token: 0x0602AD84 RID: 175492 RVA: 0x00608BA5 File Offset: 0x00606DA5
		public bool Has_Deferred_C30()
		{
			return true;
		}

		// Token: 0x0602AD85 RID: 175493 RVA: 0x00608BA8 File Offset: 0x00606DA8
		public bool Has_DeferredReflections_C30()
		{
			return true;
		}

		// Token: 0x0602AD86 RID: 175494 RVA: 0x00608BAB File Offset: 0x00606DAB
		public bool Has_DepthNormals_C30()
		{
			return true;
		}

		// Token: 0x0602AD87 RID: 175495 RVA: 0x00608BAE File Offset: 0x00606DAE
		public bool Has_FogKeepExp_C30()
		{
			return true;
		}

		// Token: 0x0602AD88 RID: 175496 RVA: 0x00608BB1 File Offset: 0x00606DB1
		public bool Has_FogKeepExp2_C30()
		{
			return true;
		}

		// Token: 0x0602AD89 RID: 175497 RVA: 0x00608BB4 File Offset: 0x00606DB4
		public bool Has_FogKeepLinear_C30()
		{
			return true;
		}

		// Token: 0x0602AD8A RID: 175498 RVA: 0x00608BB7 File Offset: 0x00606DB7
		public bool Has_FogStripping_C30()
		{
			return true;
		}

		// Token: 0x0602AD8B RID: 175499 RVA: 0x00608BBA File Offset: 0x00606DBA
		public bool Has_InstancingStripping_C30()
		{
			return true;
		}

		// Token: 0x0602AD8C RID: 175500 RVA: 0x00608BBD File Offset: 0x00606DBD
		public bool Has_LegacyDeferred_C30()
		{
			return true;
		}

		// Token: 0x0602AD8D RID: 175501 RVA: 0x00608BC0 File Offset: 0x00606DC0
		public bool Has_LensFlare_C30()
		{
			return true;
		}

		// Token: 0x0602AD8E RID: 175502 RVA: 0x00608BC3 File Offset: 0x00606DC3
		public bool Has_LightHalo_C30()
		{
			return true;
		}

		// Token: 0x0602AD8F RID: 175503 RVA: 0x00608BC6 File Offset: 0x00606DC6
		public bool Has_LightmapKeepDirCombined_C30()
		{
			return true;
		}

		// Token: 0x0602AD90 RID: 175504 RVA: 0x00608BC9 File Offset: 0x00606DC9
		public bool Has_LightmapKeepDirSeparate_C30()
		{
			return false;
		}

		// Token: 0x0602AD91 RID: 175505 RVA: 0x00608BCC File Offset: 0x00606DCC
		public bool Has_LightmapKeepDynamic_C30()
		{
			return false;
		}

		// Token: 0x0602AD92 RID: 175506 RVA: 0x00608BCF File Offset: 0x00606DCF
		public bool Has_LightmapKeepDynamicDirCombined_C30()
		{
			return true;
		}

		// Token: 0x0602AD93 RID: 175507 RVA: 0x00608BD2 File Offset: 0x00606DD2
		public bool Has_LightmapKeepDynamicDirSeparate_C30()
		{
			return false;
		}

		// Token: 0x0602AD94 RID: 175508 RVA: 0x00608BD5 File Offset: 0x00606DD5
		public bool Has_LightmapKeepDynamicPlain_C30()
		{
			return true;
		}

		// Token: 0x0602AD95 RID: 175509 RVA: 0x00608BD8 File Offset: 0x00606DD8
		public bool Has_LightmapKeepPlain_C30()
		{
			return true;
		}

		// Token: 0x0602AD96 RID: 175510 RVA: 0x00608BDB File Offset: 0x00606DDB
		public bool Has_LightmapKeepShadowMask_C30()
		{
			return true;
		}

		// Token: 0x0602AD97 RID: 175511 RVA: 0x00608BDE File Offset: 0x00606DDE
		public bool Has_LightmapKeepSubtractive_C30()
		{
			return true;
		}

		// Token: 0x0602AD98 RID: 175512 RVA: 0x00608BE1 File Offset: 0x00606DE1
		public bool Has_LightmapStripping_C30()
		{
			return true;
		}

		// Token: 0x0602AD99 RID: 175513 RVA: 0x00608BE4 File Offset: 0x00606DE4
		public bool Has_LightProbeOutsideHullStrategy_C30()
		{
			return false;
		}

		// Token: 0x0602AD9A RID: 175514 RVA: 0x00608BE7 File Offset: 0x00606DE7
		public bool Has_LightsUseCCT_C30()
		{
			return false;
		}

		// Token: 0x0602AD9B RID: 175515 RVA: 0x00608BEA File Offset: 0x00606DEA
		public bool Has_LightsUseColorTemperature_C30()
		{
			return true;
		}

		// Token: 0x0602AD9C RID: 175516 RVA: 0x00608BED File Offset: 0x00606DED
		public bool Has_LightsUseLinearIntensity_C30()
		{
			return true;
		}

		// Token: 0x0602AD9D RID: 175517 RVA: 0x00608BF0 File Offset: 0x00606DF0
		public bool Has_LogWhenShaderIsCompiled_C30()
		{
			return false;
		}

		// Token: 0x0602AD9E RID: 175518 RVA: 0x00608BF3 File Offset: 0x00606DF3
		public bool Has_MotionVectors_C30()
		{
			return true;
		}

		// Token: 0x0602AD9F RID: 175519 RVA: 0x00608BF6 File Offset: 0x00606DF6
		public bool Has_PreloadedShaders_C30()
		{
			return true;
		}

		// Token: 0x0602ADA0 RID: 175520 RVA: 0x00608BF9 File Offset: 0x00606DF9
		public bool Has_PreloadShadersBatchTimeLimit_C30()
		{
			return false;
		}

		// Token: 0x0602ADA1 RID: 175521 RVA: 0x00608BFC File Offset: 0x00606DFC
		public bool Has_ScreenSpaceShadows_C30()
		{
			return true;
		}

		// Token: 0x0602ADA2 RID: 175522 RVA: 0x00608BFF File Offset: 0x00606DFF
		public bool Has_ShaderDefinesPerShaderCompiler_C30()
		{
			return true;
		}

		// Token: 0x0602ADA3 RID: 175523 RVA: 0x00608C02 File Offset: 0x00606E02
		public bool Has_ShaderSettings_C30()
		{
			return false;
		}

		// Token: 0x0602ADA4 RID: 175524 RVA: 0x00608C05 File Offset: 0x00606E05
		public bool Has_ShaderSettings_Tier1_C30()
		{
			return false;
		}

		// Token: 0x0602ADA5 RID: 175525 RVA: 0x00608C08 File Offset: 0x00606E08
		public bool Has_ShaderSettings_Tier2_C30()
		{
			return false;
		}

		// Token: 0x0602ADA6 RID: 175526 RVA: 0x00608C0B File Offset: 0x00606E0B
		public bool Has_ShaderSettings_Tier3_C30()
		{
			return false;
		}

		// Token: 0x0602ADA7 RID: 175527 RVA: 0x00608C0E File Offset: 0x00606E0E
		public bool Has_SpritesDefaultMaterial_C30()
		{
			return true;
		}

		// Token: 0x0602ADA8 RID: 175528 RVA: 0x00608C11 File Offset: 0x00606E11
		public bool Has_SRPDefaultSettings_C30()
		{
			return false;
		}

		// Token: 0x0602ADA9 RID: 175529 RVA: 0x00608C14 File Offset: 0x00606E14
		public bool Has_TierSettings_C30()
		{
			return true;
		}

		// Token: 0x0602ADAA RID: 175530 RVA: 0x00608C17 File Offset: 0x00606E17
		public bool Has_TierSettings_Tier1_C30()
		{
			return true;
		}

		// Token: 0x0602ADAB RID: 175531 RVA: 0x00608C1A File Offset: 0x00606E1A
		public bool Has_TierSettings_Tier2_C30()
		{
			return true;
		}

		// Token: 0x0602ADAC RID: 175532 RVA: 0x00608C1D File Offset: 0x00606E1D
		public bool Has_TierSettings_Tier3_C30()
		{
			return true;
		}

		// Token: 0x0602ADAD RID: 175533 RVA: 0x00608C20 File Offset: 0x00606E20
		public bool Has_TransparencySortAxis_C30()
		{
			return true;
		}

		// Token: 0x0602ADAE RID: 175534 RVA: 0x00608C23 File Offset: 0x00606E23
		public bool Has_TransparencySortMode_C30()
		{
			return true;
		}

		// Token: 0x0602ADAF RID: 175535 RVA: 0x00608C26 File Offset: 0x00606E26
		public bool Has_VideoShadersIncludeMode_C30()
		{
			return false;
		}

		// Token: 0x0602ADB0 RID: 175536 RVA: 0x00608C2C File Offset: 0x00606E2C

		public override void ReadRelease(AssetReader reader)
		{
			this.m_Deferred.ReadRelease(reader);
			this.m_DeferredReflections.ReadRelease(reader);
			this.m_ScreenSpaceShadows.ReadRelease(reader);
			this.m_LegacyDeferred.ReadRelease(reader);
			this.m_DepthNormals.ReadRelease(reader);
			this.m_MotionVectors.ReadRelease(reader);
			this.m_LightHalo.ReadRelease(reader);
			this.m_LensFlare.ReadRelease(reader);

			// GICB2
			var HeightFog = reader.ReadAsset<BuiltinShaderSettings>();
			var DepthDownSample = reader.ReadAsset<BuiltinShaderSettings>();
			var UpSampling = reader.ReadAsset<BuiltinShaderSettings>();
			var SSAO = reader.ReadAsset<BuiltinShaderSettings>();
			var HIZCulling = reader.ReadAsset<BuiltinShaderSettings>();
			var SSR = reader.ReadAsset<BuiltinShaderSettings>();
			var HalfResParticleStencil = reader.ReadAsset<BuiltinShaderSettings>();
			var BuiltinComputeShaders = reader.ReadAssetArray<BuiltinShaderSettings>();

			this.m_AlwaysIncludedShaders.ReadRelease_ArrayAlign_Asset(reader);
			this.m_PreloadedShaders.ReadRelease_ArrayAlign_Asset(reader);
			this.m_SpritesDefaultMaterial.ReadRelease(reader);
			var AOJitterTexture = reader.ReadAsset<PPtr_Texture2D_5_0_0>(); // GICB2
			this.m_CustomRenderPipeline.ReadRelease(reader);
			this.m_TransparencySortMode = reader.ReadInt32();
			this.m_TransparencySortAxis.ReadRelease(reader);
			this.m_TierSettings_Tier1.ReadRelease(reader);
			this.m_TierSettings_Tier2.ReadRelease(reader);
			this.m_TierSettings_Tier3.ReadRelease(reader);
			this.m_ShaderDefinesPerShaderCompiler.ReadRelease_ArrayAlign_Asset(reader);
			this.m_LightsUseLinearIntensity = reader.ReadBoolean();
			this.m_LightsUseColorTemperature = reader.ReadBoolean();

			// GICB2
			reader.AlignStream();
			var AlwaysWarmupShaders = reader.ReadAssetArray<PPtr_Shader_5_0_0>();
			reader.AlignStream();
			var ShaderLoadOnDemand = reader.ReadBoolean();
			reader.AlignStream();
			var FrequentlyUsedShaders = reader.ReadAsset<PPtr_ShaderVariantCollection>();
			reader.AlignStream();
			var FrequentlyUsedShadersCount = reader.ReadInt32();
			var DiffuseDefaultMaterial = reader.ReadAsset<PPtr_Material_5_0_0>();
		}

		// Token: 0x0602ADB1 RID: 175537 RVA: 0x00608D2C File Offset: 0x00606F2C

		public override void ReadEditor(AssetReader reader)
		{
			// this.m_HideFlags = reader.ReadUInt32();
			// this.m_Deferred.ReadEditor(reader);
			// this.m_DeferredReflections.ReadEditor(reader);
			// this.m_ScreenSpaceShadows.ReadEditor(reader);
			// this.m_LegacyDeferred.ReadEditor(reader);
			// this.m_DepthNormals.ReadEditor(reader);
			// this.m_MotionVectors.ReadEditor(reader);
			// this.m_LightHalo.ReadEditor(reader);
			// this.m_LensFlare.ReadEditor(reader);
			// this.m_AlwaysIncludedShaders.ReadEditor_ArrayAlign_Asset(reader);
			// this.m_PreloadedShaders.ReadEditor_ArrayAlign_Asset(reader);
			// this.m_SpritesDefaultMaterial.ReadEditor(reader);
			// this.m_CustomRenderPipeline.ReadEditor(reader);
			// this.m_TransparencySortMode = reader.ReadInt32();
			// this.m_TransparencySortAxis.ReadEditor(reader);
			// this.m_DefaultRenderingPath = reader.ReadInt32();
			// this.m_DefaultMobileRenderingPath = reader.ReadInt32();
			// this.m_TierSettings.ReadEditor_ArrayAlign_Asset(reader);
			// this.m_LightmapStripping = reader.ReadInt32();
			// this.m_FogStripping = reader.ReadInt32();
			// this.m_InstancingStripping = reader.ReadInt32();
			// this.m_LightmapKeepPlain = reader.ReadBoolean();
			// this.m_LightmapKeepDirCombined = reader.ReadBoolean();
			// this.m_LightmapKeepDynamicPlain = reader.ReadBoolean();
			// this.m_LightmapKeepDynamicDirCombined = reader.ReadBoolean();
			// this.m_LightmapKeepShadowMask = reader.ReadBoolean();
			// this.m_LightmapKeepSubtractive = reader.ReadBoolean();
			// this.m_FogKeepLinear = reader.ReadBoolean();
			// this.m_FogKeepExp = reader.ReadBoolean();
			// this.m_FogKeepExp2 = reader.ReadEditor_BooleanAlign();
			// this.m_AlbedoSwitchInfos.ReadEditor_ArrayAlign_Asset(reader);
			// this.m_LightsUseLinearIntensity = reader.ReadBoolean();
			// this.m_LightsUseColorTemperature = reader.ReadBoolean();
		}

		// Token: 0x0602ADB2 RID: 175538 RVA: 0x00608EC8 File Offset: 0x006070C8

		public override void WriteRelease(AssetWriter writer)
		{
			this.m_Deferred.WriteRelease(writer);
			this.m_DeferredReflections.WriteRelease(writer);
			this.m_ScreenSpaceShadows.WriteRelease(writer);
			this.m_LegacyDeferred.WriteRelease(writer);
			this.m_DepthNormals.WriteRelease(writer);
			this.m_MotionVectors.WriteRelease(writer);
			this.m_LightHalo.WriteRelease(writer);
			this.m_LensFlare.WriteRelease(writer);
			this.m_AlwaysIncludedShaders.WriteRelease_ArrayAlign_Asset(writer);
			this.m_PreloadedShaders.WriteRelease_ArrayAlign_Asset(writer);
			this.m_SpritesDefaultMaterial.WriteRelease(writer);
			this.m_CustomRenderPipeline.WriteRelease(writer);
			this.m_TransparencySortMode.WriteRelease_Int32(writer);
			this.m_TransparencySortAxis.WriteRelease(writer);
			this.m_TierSettings_Tier1.WriteRelease(writer);
			this.m_TierSettings_Tier2.WriteRelease(writer);
			this.m_TierSettings_Tier3.WriteRelease(writer);
			this.m_ShaderDefinesPerShaderCompiler.WriteRelease_ArrayAlign_Asset(writer);
			this.m_LightsUseLinearIntensity.WriteRelease_Boolean(writer);
			this.m_LightsUseColorTemperature.WriteRelease_Boolean(writer);
		}

		// Token: 0x0602ADB3 RID: 175539 RVA: 0x00608FC8 File Offset: 0x006071C8

		public override void WriteEditor(AssetWriter writer)
		{
			// this.m_HideFlags.WriteEditor_UInt32(writer);
			// this.m_Deferred.WriteEditor(writer);
			// this.m_DeferredReflections.WriteEditor(writer);
			// this.m_ScreenSpaceShadows.WriteEditor(writer);
			// this.m_LegacyDeferred.WriteEditor(writer);
			// this.m_DepthNormals.WriteEditor(writer);
			// this.m_MotionVectors.WriteEditor(writer);
			// this.m_LightHalo.WriteEditor(writer);
			// this.m_LensFlare.WriteEditor(writer);
			// this.m_AlwaysIncludedShaders.WriteEditor_ArrayAlign_Asset(writer);
			// this.m_PreloadedShaders.WriteEditor_ArrayAlign_Asset(writer);
			// this.m_SpritesDefaultMaterial.WriteEditor(writer);
			// this.m_CustomRenderPipeline.WriteEditor(writer);
			// this.m_TransparencySortMode.WriteEditor_Int32(writer);
			// this.m_TransparencySortAxis.WriteEditor(writer);
			// this.m_DefaultRenderingPath.WriteEditor_Int32(writer);
			// this.m_DefaultMobileRenderingPath.WriteEditor_Int32(writer);
			// this.m_TierSettings.WriteEditor_ArrayAlign_Asset(writer);
			// this.m_LightmapStripping.WriteEditor_Int32(writer);
			// this.m_FogStripping.WriteEditor_Int32(writer);
			// this.m_InstancingStripping.WriteEditor_Int32(writer);
			// this.m_LightmapKeepPlain.WriteEditor_Boolean(writer);
			// this.m_LightmapKeepDirCombined.WriteEditor_Boolean(writer);
			// this.m_LightmapKeepDynamicPlain.WriteEditor_Boolean(writer);
			// this.m_LightmapKeepDynamicDirCombined.WriteEditor_Boolean(writer);
			// this.m_LightmapKeepShadowMask.WriteEditor_Boolean(writer);
			// this.m_LightmapKeepSubtractive.WriteEditor_Boolean(writer);
			// this.m_FogKeepLinear.WriteEditor_Boolean(writer);
			// this.m_FogKeepExp.WriteEditor_Boolean(writer);
			// this.m_FogKeepExp2.WriteEditor_BooleanAlign(writer);
			// this.m_AlbedoSwitchInfos.WriteEditor_ArrayAlign_Asset(writer);
			// this.m_LightsUseLinearIntensity.WriteEditor_Boolean(writer);
			// this.m_LightsUseColorTemperature.WriteEditor_Boolean(writer);
		}

		// Token: 0x0602ADB4 RID: 175540 RVA: 0x00609164 File Offset: 0x00607364

		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 12);
			yamlMappingNode.Add(new YamlScalarNode("m_Deferred"), this.m_Deferred.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_DeferredReflections"), this.m_DeferredReflections.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ScreenSpaceShadows"), this.m_ScreenSpaceShadows.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LegacyDeferred"), this.m_LegacyDeferred.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_DepthNormals"), this.m_DepthNormals.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MotionVectors"), this.m_MotionVectors.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LightHalo"), this.m_LightHalo.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LensFlare"), this.m_LensFlare.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AlwaysIncludedShaders"), this.m_AlwaysIncludedShaders.ExportYamlRelease_Array_PPtr_Shader_5_0_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PreloadedShaders"), this.m_PreloadedShaders.ExportYamlRelease_Array_PPtr_ShaderVariantCollection(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SpritesDefaultMaterial"), this.m_SpritesDefaultMaterial.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_CustomRenderPipeline"), this.m_CustomRenderPipeline.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_TransparencySortMode"), this.m_TransparencySortMode.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_TransparencySortAxis"), this.m_TransparencySortAxis.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_TierSettings_Tier1"), this.m_TierSettings_Tier1.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_TierSettings_Tier2"), this.m_TierSettings_Tier2.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_TierSettings_Tier3"), this.m_TierSettings_Tier3.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ShaderDefinesPerShaderCompiler"), this.m_ShaderDefinesPerShaderCompiler.ExportYamlRelease_Array_PlatformShaderDefines(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LightsUseLinearIntensity"), this.m_LightsUseLinearIntensity.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LightsUseColorTemperature"), this.m_LightsUseColorTemperature.ExportYamlRelease_Boolean(container));
			return yamlMappingNode;
		}

		// Token: 0x0602ADB5 RID: 175541 RVA: 0x006093B0 File Offset: 0x006075B0

		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 12);
			yamlMappingNode.Add(new YamlScalarNode("m_ObjectHideFlags"), this.m_HideFlags.ExportYamlEditor_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Deferred"), this.m_Deferred.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_DeferredReflections"), this.m_DeferredReflections.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ScreenSpaceShadows"), this.m_ScreenSpaceShadows.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LegacyDeferred"), this.m_LegacyDeferred.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_DepthNormals"), this.m_DepthNormals.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MotionVectors"), this.m_MotionVectors.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LightHalo"), this.m_LightHalo.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LensFlare"), this.m_LensFlare.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AlwaysIncludedShaders"), this.m_AlwaysIncludedShaders.ExportYamlEditor_Array_PPtr_Shader_5_0_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PreloadedShaders"), this.m_PreloadedShaders.ExportYamlEditor_Array_PPtr_ShaderVariantCollection(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SpritesDefaultMaterial"), this.m_SpritesDefaultMaterial.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_CustomRenderPipeline"), this.m_CustomRenderPipeline.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_TransparencySortMode"), this.m_TransparencySortMode.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_TransparencySortAxis"), this.m_TransparencySortAxis.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_DefaultRenderingPath"), this.m_DefaultRenderingPath.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_DefaultMobileRenderingPath"), this.m_DefaultMobileRenderingPath.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_TierSettings"), this.m_TierSettings.ExportYamlEditor_Array_TierSettings_2017_1_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LightmapStripping"), this.m_LightmapStripping.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_FogStripping"), this.m_FogStripping.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_InstancingStripping"), this.m_InstancingStripping.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LightmapKeepPlain"), this.m_LightmapKeepPlain.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LightmapKeepDirCombined"), this.m_LightmapKeepDirCombined.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LightmapKeepDynamicPlain"), this.m_LightmapKeepDynamicPlain.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LightmapKeepDynamicDirCombined"), this.m_LightmapKeepDynamicDirCombined.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LightmapKeepShadowMask"), this.m_LightmapKeepShadowMask.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LightmapKeepSubtractive"), this.m_LightmapKeepSubtractive.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_FogKeepLinear"), this.m_FogKeepLinear.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_FogKeepExp"), this.m_FogKeepExp.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_FogKeepExp2"), this.m_FogKeepExp2.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AlbedoSwatchInfos"), this.m_AlbedoSwitchInfos.ExportYamlEditor_Array_AlbedoSwitchInfo(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LightsUseLinearIntensity"), this.m_LightsUseLinearIntensity.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LightsUseColorTemperature"), this.m_LightsUseColorTemperature.ExportYamlEditor_Boolean(container));
			return yamlMappingNode;
		}

		// Token: 0x0602ADB6 RID: 175542 RVA: 0x00609768 File Offset: 0x00607968
		public override void Reset()
		{
			this.m_AlbedoSwitchInfos.Clear();
			this.m_AlwaysIncludedShaders.Clear();
			this.m_CustomRenderPipeline.Reset();
			this.m_DefaultMobileRenderingPath = 0;
			this.m_DefaultRenderingPath = 0;
			this.m_Deferred.Reset();
			this.m_DeferredReflections.Reset();
			this.m_DepthNormals.Reset();
			this.m_FogKeepExp = false;
			this.m_FogKeepExp2 = false;
			this.m_FogKeepLinear = false;
			this.m_FogStripping = 0;
			this.m_HideFlags = 0U;
			this.m_InstancingStripping = 0;
			this.m_LegacyDeferred.Reset();
			this.m_LensFlare.Reset();
			this.m_LightHalo.Reset();
			this.m_LightmapKeepDirCombined = false;
			this.m_LightmapKeepDynamicDirCombined = false;
			this.m_LightmapKeepDynamicPlain = false;
			this.m_LightmapKeepPlain = false;
			this.m_LightmapKeepShadowMask = false;
			this.m_LightmapKeepSubtractive = false;
			this.m_LightmapStripping = 0;
			this.m_LightsUseColorTemperature = false;
			this.m_LightsUseLinearIntensity = false;
			this.m_MotionVectors.Reset();
			this.m_PreloadedShaders.Clear();
			this.m_ScreenSpaceShadows.Reset();
			this.m_ShaderDefinesPerShaderCompiler.Clear();
			this.m_SpritesDefaultMaterial.Reset();
			this.m_TierSettings.Clear();
			this.m_TierSettings_Tier1.Reset();
			this.m_TierSettings_Tier2.Reset();
			this.m_TierSettings_Tier3.Reset();
			this.m_TransparencySortAxis.Reset();
			this.m_TransparencySortMode = 0;
		}

		// Token: 0x0602ADB7 RID: 175543 RVA: 0x006098C4 File Offset: 0x00607AC4

		//public override IEnumerable<ValueTuple<FieldName, PPtr<IUnityObjectBase>>> FetchDependencies(FieldName parent)
		//{
		//	return Enumerable.Empty<ValueTuple<FieldName, PPtr<IUnityObjectBase>>>().Append_GraphicsSettings_2017_1_0(parent, this);
		//}

		// Token: 0x0602ADB8 RID: 175544 RVA: 0x006098D4 File Offset: 0x00607AD4

		public void CopyValues(IGraphicsSettings source, PPtrConverter converter)
		{
			CopyValuesHelper.CopyValues__AssetList_AlbedoSwitchInfo__AssetList_AlbedoSwitchInfo(this.m_AlbedoSwitchInfos, source.AlbedoSwitchInfos_C30);
			CopyValuesHelper.CopyValues__AssetList_PPtr_Shader_5_0_0__AccessListBase_IPPtr_Shader(this.m_AlwaysIncludedShaders, source.AlwaysIncludedShaders_C30, converter);
			this.m_CustomRenderPipeline.CopyValues(source.CustomRenderPipeline_C30, converter);
			this.m_DefaultMobileRenderingPath = source.DefaultMobileRenderingPath_C30;
			this.m_DefaultRenderingPath = source.DefaultRenderingPath_C30;
			this.m_Deferred.CopyValues(source.Deferred_C30, converter);
			this.m_DeferredReflections.CopyValues(source.DeferredReflections_C30, converter);
			this.m_DepthNormals.CopyValues(source.DepthNormals_C30, converter);
			this.m_FogKeepExp = source.FogKeepExp_C30;
			this.m_FogKeepExp2 = source.FogKeepExp2_C30;
			this.m_FogKeepLinear = source.FogKeepLinear_C30;
			this.m_FogStripping = source.FogStripping_C30;
			this.m_HideFlags = source.HideFlags_C30;
			this.m_InstancingStripping = source.InstancingStripping_C30;
			this.m_LegacyDeferred.CopyValues(source.LegacyDeferred_C30, converter);
			this.m_LensFlare.CopyValues(source.LensFlare_C30, converter);
			this.m_LightHalo.CopyValues(source.LightHalo_C30, converter);
			this.m_LightmapKeepDirCombined = source.LightmapKeepDirCombined_C30;
			this.m_LightmapKeepDynamicDirCombined = source.LightmapKeepDynamicDirCombined_C30;
			this.m_LightmapKeepDynamicPlain = source.LightmapKeepDynamicPlain_C30;
			this.m_LightmapKeepPlain = source.LightmapKeepPlain_C30;
			this.m_LightmapKeepShadowMask = source.LightmapKeepShadowMask_C30;
			this.m_LightmapKeepSubtractive = source.LightmapKeepSubtractive_C30;
			this.m_LightmapStripping = source.LightmapStripping_C30;
			this.m_LightsUseColorTemperature = source.LightsUseColorTemperature_C30;
			this.m_LightsUseLinearIntensity = source.LightsUseLinearIntensity_C30;
			this.m_MotionVectors.CopyValues(source.MotionVectors_C30, converter);
			CopyValuesHelper.CopyValues__AssetList_PPtr_ShaderVariantCollection__AssetList_PPtr_ShaderVariantCollection(this.m_PreloadedShaders, source.PreloadedShaders_C30, converter);
			this.m_ScreenSpaceShadows.CopyValues(source.ScreenSpaceShadows_C30, converter);
			CopyValuesHelper.CopyValues__AssetList_PlatformShaderDefines__AssetList_PlatformShaderDefines(this.m_ShaderDefinesPerShaderCompiler, source.ShaderDefinesPerShaderCompiler_C30);
			this.m_SpritesDefaultMaterial.CopyValues(source.SpritesDefaultMaterial_C30, converter);
			CopyValuesHelper.CopyValues__AssetList_TierSettings_2017_1_0__AccessListBase_ITierSettings(this.m_TierSettings, source.TierSettings_C30);
			this.m_TierSettings_Tier1.CopyValues(source.TierSettings_Tier1_C30);
			this.m_TierSettings_Tier2.CopyValues(source.TierSettings_Tier2_C30);
			this.m_TierSettings_Tier3.CopyValues(source.TierSettings_Tier3_C30);
			this.m_TransparencySortAxis.CopyValues(source.TransparencySortAxis_C30);
			this.m_TransparencySortMode = source.TransparencySortMode_C30;
		}

		// Token: 0x0602ADB9 RID: 175545 RVA: 0x00609B08 File Offset: 0x00607D08

		public void CopyValues(IGraphicsSettings source)
		{
			this.CopyValues(source, new PPtrConverter(source, this));
		}

		// Token: 0x0602ADBA RID: 175546 RVA: 0x00609B18 File Offset: 0x00607D18
		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			IGraphicsSettings graphicsSettings = source as IGraphicsSettings;
			if (graphicsSettings != null)
			{
				this.CopyValues(graphicsSettings, converter);
				return;
			}
			base.CopyValues(source, converter);
		}

		// Token: 0x0602ADBB RID: 175547 RVA: 0x00609B40 File Offset: 0x00607D40

		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0602ADBC RID: 175548 RVA: 0x00609B47 File Offset: 0x00607D47

		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		public bool Has_CameraRelativeLightCulling_C30()
		{
			throw new NotImplementedException();
		}

		public bool Has_CameraRelativeShadowCulling_C30()
		{
			throw new NotImplementedException();
		}

		// Token: 0x040124B2 RID: 74930

		public TierGraphicsSettings_2017_1_0 m_TierSettings_Tier1;

		// Token: 0x040124B3 RID: 74931

		public TierGraphicsSettings_2017_1_0 m_TierSettings_Tier2;

		// Token: 0x040124B4 RID: 74932

		public TierGraphicsSettings_2017_1_0 m_TierSettings_Tier3;

		// Token: 0x040124B5 RID: 74933

		public AssetList<PlatformShaderDefines> m_ShaderDefinesPerShaderCompiler;

		// Token: 0x040124B6 RID: 74934
		public int m_DefaultRenderingPath;

		// Token: 0x040124B7 RID: 74935
		public int m_DefaultMobileRenderingPath;

		// Token: 0x040124B8 RID: 74936

		public AssetList<TierSettings_2017_1_0> m_TierSettings;

		// Token: 0x040124B9 RID: 74937
		public int m_LightmapStripping;

		// Token: 0x040124BA RID: 74938
		public int m_FogStripping;

		// Token: 0x040124BB RID: 74939
		public int m_InstancingStripping;

		// Token: 0x040124BC RID: 74940
		public bool m_LightmapKeepPlain;

		// Token: 0x040124BD RID: 74941
		public bool m_LightmapKeepDirCombined;

		// Token: 0x040124BE RID: 74942
		public bool m_LightmapKeepDynamicPlain;

		// Token: 0x040124BF RID: 74943
		public bool m_LightmapKeepDynamicDirCombined;

		// Token: 0x040124C0 RID: 74944
		public bool m_LightmapKeepShadowMask;

		// Token: 0x040124C1 RID: 74945
		public bool m_LightmapKeepSubtractive;

		// Token: 0x040124C2 RID: 74946
		public bool m_FogKeepLinear;

		// Token: 0x040124C3 RID: 74947
		public bool m_FogKeepExp;

		// Token: 0x040124C4 RID: 74948
		public bool m_FogKeepExp2;

		// Token: 0x040124C5 RID: 74949

		public AssetList<AlbedoSwitchInfo> m_AlbedoSwitchInfos;

		// Token: 0x040124C6 RID: 74950

		public BuiltinShaderSettings m_Deferred;

		// Token: 0x040124C7 RID: 74951

		public BuiltinShaderSettings m_DeferredReflections;

		// Token: 0x040124C8 RID: 74952

		public BuiltinShaderSettings m_ScreenSpaceShadows;

		// Token: 0x040124C9 RID: 74953

		public BuiltinShaderSettings m_LegacyDeferred;

		// Token: 0x040124CA RID: 74954

		public BuiltinShaderSettings m_DepthNormals;

		// Token: 0x040124CB RID: 74955

		public BuiltinShaderSettings m_MotionVectors;

		// Token: 0x040124CC RID: 74956

		public BuiltinShaderSettings m_LightHalo;

		// Token: 0x040124CD RID: 74957

		public BuiltinShaderSettings m_LensFlare;

		// Token: 0x040124CE RID: 74958

		public AssetList<PPtr_Shader_5_0_0> m_AlwaysIncludedShaders;

		// Token: 0x040124CF RID: 74959

		public AssetList<PPtr_ShaderVariantCollection> m_PreloadedShaders;

		// Token: 0x040124D0 RID: 74960

		public PPtr_Material_5_0_0 m_SpritesDefaultMaterial;

		// Token: 0x040124D1 RID: 74961

		public PPtr_MonoBehaviour_5_0_0 m_CustomRenderPipeline;

		// Token: 0x040124D2 RID: 74962
		public int m_TransparencySortMode;

		// Token: 0x040124D3 RID: 74963

		public Vector3f_3_5_0 m_TransparencySortAxis;

		// Token: 0x040124D4 RID: 74964
		public bool m_LightsUseLinearIntensity;

		// Token: 0x040124D5 RID: 74965
		public bool m_LightsUseColorTemperature;
	}
}
