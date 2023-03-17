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
using AssetRipper.SourceGenerated.Helpers;
using AssetRipper.SourceGenerated.Interfaces;
using AssetRipper.SourceGenerated.Subclasses.MipmapLimitSettings;
using AssetRipper.SourceGenerated.Subclasses.PPtr_MonoBehaviour;
using AssetRipper.SourceGenerated.Subclasses.Utf8String;
using AssetRipper.SourceGenerated.Subclasses.Vector3f;
using AssetRipper.Yaml;
using AssetRipper.SourceGenerated.Subclasses.QualitySetting;

namespace AssetRipper.Import.GICB2.QualitySetting
{
	// Token: 0x02000511 RID: 1297


	public sealed class QualitySetting_2017_1_0_GICB2 : UnityAssetBase, IQualitySetting, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IEquatable<IQualitySetting>, IHasName, IHasNameString, IEquatable<QualitySetting_2017_1_0_GICB2>
	{
		// Token: 0x17002824 RID: 10276
		// (get) Token: 0x06009404 RID: 37892 RVA: 0x0018A364 File Offset: 0x00188564
		// (set) Token: 0x06009405 RID: 37893 RVA: 0x0018A36C File Offset: 0x0018856C
		public int AnisotropicTextures
		{
			get
			{
				return this.m_AnisotropicTextures;
			}
			set
			{
				this.m_AnisotropicTextures = value;
			}
		}

		// Token: 0x17002825 RID: 10277
		// (get) Token: 0x06009406 RID: 37894 RVA: 0x0018A375 File Offset: 0x00188575
		// (set) Token: 0x06009407 RID: 37895 RVA: 0x0018A37D File Offset: 0x0018857D
		public int AntiAliasing
		{
			get
			{
				return this.m_AntiAliasing;
			}
			set
			{
				this.m_AntiAliasing = value;
			}
		}

		// Token: 0x17002826 RID: 10278
		// (get) Token: 0x06009408 RID: 37896 RVA: 0x0018A386 File Offset: 0x00188586
		// (set) Token: 0x06009409 RID: 37897 RVA: 0x0018A38E File Offset: 0x0018858E
		public int AsyncUploadBufferSize
		{
			get
			{
				return this.m_AsyncUploadBufferSize;
			}
			set
			{
				this.m_AsyncUploadBufferSize = value;
			}
		}

		// Token: 0x17002827 RID: 10279
		// (get) Token: 0x0600940A RID: 37898 RVA: 0x0018A397 File Offset: 0x00188597
		// (set) Token: 0x0600940B RID: 37899 RVA: 0x0018A39A File Offset: 0x0018859A
		public bool AsyncUploadPersistentBuffer
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17002828 RID: 10280
		// (get) Token: 0x0600940C RID: 37900 RVA: 0x0018A39C File Offset: 0x0018859C
		// (set) Token: 0x0600940D RID: 37901 RVA: 0x0018A3A4 File Offset: 0x001885A4
		public int AsyncUploadTimeSlice
		{
			get
			{
				return this.m_AsyncUploadTimeSlice;
			}
			set
			{
				this.m_AsyncUploadTimeSlice = value;
			}
		}

		// Token: 0x17002829 RID: 10281
		// (get) Token: 0x0600940E RID: 37902 RVA: 0x0018A3AD File Offset: 0x001885AD
		// (set) Token: 0x0600940F RID: 37903 RVA: 0x0018A3B5 File Offset: 0x001885B5
		public bool BillboardsFaceCameraPosition
		{
			get
			{
				return this.m_BillboardsFaceCameraPosition;
			}
			set
			{
				this.m_BillboardsFaceCameraPosition = value;
			}
		}

		// Token: 0x1700282A RID: 10282
		// (get) Token: 0x06009410 RID: 37904 RVA: 0x0018A3BE File Offset: 0x001885BE
		// (set) Token: 0x06009411 RID: 37905 RVA: 0x0018A3C6 File Offset: 0x001885C6
		public int BlendWeights
		{
			get
			{
				return this.m_BlendWeights;
			}
			set
			{
				this.m_BlendWeights = value;
			}
		}

		// Token: 0x1700282B RID: 10283
		// (get) Token: 0x06009412 RID: 37906 RVA: 0x0018A3CF File Offset: 0x001885CF

		public PPtr_MonoBehaviour_5_0_0 CustomRenderPipeline
		{

			get
			{
				return null;
			}
		}

		// Token: 0x1700282C RID: 10284
		// (get) Token: 0x06009413 RID: 37907 RVA: 0x0018A3D2 File Offset: 0x001885D2
		// (set) Token: 0x06009414 RID: 37908 RVA: 0x0018A3D5 File Offset: 0x001885D5
		public bool EnableLODCrossFade
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700282D RID: 10285
		// (get) Token: 0x06009415 RID: 37909 RVA: 0x0018A3D7 File Offset: 0x001885D7
		public AssetList<Utf8String> ExcludedTargetPlatforms
		{
			[return: NotNull]
			get
			{
				return this.m_ExcludedTargetPlatforms;
			}
		}

		// Token: 0x1700282E RID: 10286
		// (get) Token: 0x06009416 RID: 37910 RVA: 0x0018A3DF File Offset: 0x001885DF
		// (set) Token: 0x06009417 RID: 37911 RVA: 0x0018A3E2 File Offset: 0x001885E2
		public int GlobalTextureMipmapLimit
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700282F RID: 10287
		// (get) Token: 0x06009418 RID: 37912 RVA: 0x0018A3E4 File Offset: 0x001885E4
		// (set) Token: 0x06009419 RID: 37913 RVA: 0x0018A3EC File Offset: 0x001885EC
		public float LodBias
		{
			get
			{
				return this.m_LodBias;
			}
			set
			{
				this.m_LodBias = value;
			}
		}

		// Token: 0x17002830 RID: 10288
		// (get) Token: 0x0600941A RID: 37914 RVA: 0x0018A3F5 File Offset: 0x001885F5
		// (set) Token: 0x0600941B RID: 37915 RVA: 0x0018A3FD File Offset: 0x001885FD
		public int MaximumLODLevel
		{
			get
			{
				return this.m_MaximumLODLevel;
			}
			set
			{
				this.m_MaximumLODLevel = value;
			}
		}

		// Token: 0x17002831 RID: 10289
		// (get) Token: 0x0600941C RID: 37916 RVA: 0x0018A406 File Offset: 0x00188606

		public Utf8String Name_R
		{

			[return: NotNull]
			get
			{
				return this.m_Name;
			}
		}

		// Token: 0x17002832 RID: 10290
		// (get) Token: 0x0600941D RID: 37917 RVA: 0x0018A40E File Offset: 0x0018860E
		// (set) Token: 0x0600941E RID: 37918 RVA: 0x0018A416 File Offset: 0x00188616
		public int ParticleRaycastBudget
		{
			get
			{
				return this.m_ParticleRaycastBudget;
			}
			set
			{
				this.m_ParticleRaycastBudget = value;
			}
		}

		// Token: 0x17002833 RID: 10291
		// (get) Token: 0x0600941F RID: 37919 RVA: 0x0018A41F File Offset: 0x0018861F
		// (set) Token: 0x06009420 RID: 37920 RVA: 0x0018A427 File Offset: 0x00188627
		public int PixelLightCount
		{
			get
			{
				return this.m_PixelLightCount;
			}
			set
			{
				this.m_PixelLightCount = value;
			}
		}

		// Token: 0x17002834 RID: 10292
		// (get) Token: 0x06009421 RID: 37921 RVA: 0x0018A430 File Offset: 0x00188630
		// (set) Token: 0x06009422 RID: 37922 RVA: 0x0018A438 File Offset: 0x00188638
		public bool RealtimeReflectionProbes
		{
			get
			{
				return this.m_RealtimeReflectionProbes;
			}
			set
			{
				this.m_RealtimeReflectionProbes = value;
			}
		}

		// Token: 0x17002835 RID: 10293
		// (get) Token: 0x06009423 RID: 37923 RVA: 0x0018A441 File Offset: 0x00188641
		// (set) Token: 0x06009424 RID: 37924 RVA: 0x0018A449 File Offset: 0x00188649
		public float ResolutionScalingFixedDPIFactor
		{
			get
			{
				return this.m_ResolutionScalingFixedDPIFactor;
			}
			set
			{
				this.m_ResolutionScalingFixedDPIFactor = value;
			}
		}

		// Token: 0x17002836 RID: 10294
		// (get) Token: 0x06009425 RID: 37925 RVA: 0x0018A452 File Offset: 0x00188652
		// (set) Token: 0x06009426 RID: 37926 RVA: 0x0018A45A File Offset: 0x0018865A
		public float ShadowCascade2Split
		{
			get
			{
				return this.m_ShadowCascade2Split;
			}
			set
			{
				this.m_ShadowCascade2Split = value;
			}
		}

		// Token: 0x17002837 RID: 10295
		// (get) Token: 0x06009427 RID: 37927 RVA: 0x0018A463 File Offset: 0x00188663

		public Vector3f_3_5_0 ShadowCascade4Split
		{

			[return: NotNull]
			get
			{
				return this.m_ShadowCascade4Split;
			}
		}

		// Token: 0x17002838 RID: 10296
		// (get) Token: 0x06009428 RID: 37928 RVA: 0x0018A46B File Offset: 0x0018866B
		// (set) Token: 0x06009429 RID: 37929 RVA: 0x0018A473 File Offset: 0x00188673
		public int ShadowCascades
		{
			get
			{
				return this.m_ShadowCascades;
			}
			set
			{
				this.m_ShadowCascades = value;
			}
		}

		// Token: 0x17002839 RID: 10297
		// (get) Token: 0x0600942A RID: 37930 RVA: 0x0018A47C File Offset: 0x0018867C
		// (set) Token: 0x0600942B RID: 37931 RVA: 0x0018A484 File Offset: 0x00188684
		public float ShadowDistance
		{
			get
			{
				return this.m_ShadowDistance;
			}
			set
			{
				this.m_ShadowDistance = value;
			}
		}

		// Token: 0x1700283A RID: 10298
		// (get) Token: 0x0600942C RID: 37932 RVA: 0x0018A48D File Offset: 0x0018868D
		// (set) Token: 0x0600942D RID: 37933 RVA: 0x0018A495 File Offset: 0x00188695
		public int ShadowmaskMode
		{
			get
			{
				return this.m_ShadowmaskMode;
			}
			set
			{
				this.m_ShadowmaskMode = value;
			}
		}

		// Token: 0x1700283B RID: 10299
		// (get) Token: 0x0600942E RID: 37934 RVA: 0x0018A49E File Offset: 0x0018869E
		// (set) Token: 0x0600942F RID: 37935 RVA: 0x0018A4A6 File Offset: 0x001886A6
		public float ShadowNearPlaneOffset
		{
			get
			{
				return this.m_ShadowNearPlaneOffset;
			}
			set
			{
				this.m_ShadowNearPlaneOffset = value;
			}
		}

		// Token: 0x1700283C RID: 10300
		// (get) Token: 0x06009430 RID: 37936 RVA: 0x0018A4AF File Offset: 0x001886AF
		// (set) Token: 0x06009431 RID: 37937 RVA: 0x0018A4B7 File Offset: 0x001886B7
		public int ShadowProjection
		{
			get
			{
				return this.m_ShadowProjection;
			}
			set
			{
				this.m_ShadowProjection = value;
			}
		}

		// Token: 0x1700283D RID: 10301
		// (get) Token: 0x06009432 RID: 37938 RVA: 0x0018A4C0 File Offset: 0x001886C0
		// (set) Token: 0x06009433 RID: 37939 RVA: 0x0018A4C8 File Offset: 0x001886C8
		public int ShadowResolution
		{
			get
			{
				return this.m_ShadowResolution;
			}
			set
			{
				this.m_ShadowResolution = value;
			}
		}

		// Token: 0x1700283E RID: 10302
		// (get) Token: 0x06009434 RID: 37940 RVA: 0x0018A4D1 File Offset: 0x001886D1
		// (set) Token: 0x06009435 RID: 37941 RVA: 0x0018A4D9 File Offset: 0x001886D9
		public int Shadows
		{
			get
			{
				return this.m_Shadows;
			}
			set
			{
				this.m_Shadows = value;
			}
		}

		// Token: 0x1700283F RID: 10303
		// (get) Token: 0x06009436 RID: 37942 RVA: 0x0018A4E2 File Offset: 0x001886E2
		// (set) Token: 0x06009437 RID: 37943 RVA: 0x0018A4E5 File Offset: 0x001886E5
		public int SkinWeights
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17002840 RID: 10304
		// (get) Token: 0x06009438 RID: 37944 RVA: 0x0018A4E7 File Offset: 0x001886E7
		// (set) Token: 0x06009439 RID: 37945 RVA: 0x0018A4EF File Offset: 0x001886EF
		public bool SoftParticles
		{
			get
			{
				return this.m_SoftParticles;
			}
			set
			{
				this.m_SoftParticles = value;
			}
		}

		// Token: 0x17002841 RID: 10305
		// (get) Token: 0x0600943A RID: 37946 RVA: 0x0018A4F8 File Offset: 0x001886F8
		// (set) Token: 0x0600943B RID: 37947 RVA: 0x0018A500 File Offset: 0x00188700
		public bool SoftVegetation
		{
			get
			{
				return this.m_SoftVegetation;
			}
			set
			{
				this.m_SoftVegetation = value;
			}
		}

		// Token: 0x17002842 RID: 10306
		// (get) Token: 0x0600943C RID: 37948 RVA: 0x0018A509 File Offset: 0x00188709
		// (set) Token: 0x0600943D RID: 37949 RVA: 0x0018A50C File Offset: 0x0018870C
		public bool StreamingMipmapsActive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17002843 RID: 10307
		// (get) Token: 0x0600943E RID: 37950 RVA: 0x0018A50E File Offset: 0x0018870E
		// (set) Token: 0x0600943F RID: 37951 RVA: 0x0018A511 File Offset: 0x00188711
		public bool StreamingMipmapsAddAllCameras
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17002844 RID: 10308
		// (get) Token: 0x06009440 RID: 37952 RVA: 0x0018A513 File Offset: 0x00188713
		// (set) Token: 0x06009441 RID: 37953 RVA: 0x0018A516 File Offset: 0x00188716
		public int StreamingMipmapsMaxFileIORequests
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17002845 RID: 10309
		// (get) Token: 0x06009442 RID: 37954 RVA: 0x0018A518 File Offset: 0x00188718
		// (set) Token: 0x06009443 RID: 37955 RVA: 0x0018A51B File Offset: 0x0018871B
		public int StreamingMipmapsMaxLevelReduction
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17002846 RID: 10310
		// (get) Token: 0x06009444 RID: 37956 RVA: 0x0018A51D File Offset: 0x0018871D
		// (set) Token: 0x06009445 RID: 37957 RVA: 0x0018A524 File Offset: 0x00188724
		public float StreamingMipmapsMemoryBudget
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17002847 RID: 10311
		// (get) Token: 0x06009446 RID: 37958 RVA: 0x0018A526 File Offset: 0x00188726
		// (set) Token: 0x06009447 RID: 37959 RVA: 0x0018A529 File Offset: 0x00188729
		public int StreamingMipmapsRenderersPerFrame
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17002848 RID: 10312
		// (get) Token: 0x06009448 RID: 37960 RVA: 0x0018A52B File Offset: 0x0018872B
		// (set) Token: 0x06009449 RID: 37961 RVA: 0x0018A532 File Offset: 0x00188732
		public float TerrainBasemapDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17002849 RID: 10313
		// (get) Token: 0x0600944A RID: 37962 RVA: 0x0018A534 File Offset: 0x00188734
		// (set) Token: 0x0600944B RID: 37963 RVA: 0x0018A53B File Offset: 0x0018873B
		public float TerrainBillboardStart
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700284A RID: 10314
		// (get) Token: 0x0600944C RID: 37964 RVA: 0x0018A53D File Offset: 0x0018873D
		// (set) Token: 0x0600944D RID: 37965 RVA: 0x0018A544 File Offset: 0x00188744
		public float TerrainDetailDensityScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700284B RID: 10315
		// (get) Token: 0x0600944E RID: 37966 RVA: 0x0018A546 File Offset: 0x00188746
		// (set) Token: 0x0600944F RID: 37967 RVA: 0x0018A54D File Offset: 0x0018874D
		public float TerrainDetailDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700284C RID: 10316
		// (get) Token: 0x06009450 RID: 37968 RVA: 0x0018A54F File Offset: 0x0018874F
		// (set) Token: 0x06009451 RID: 37969 RVA: 0x0018A556 File Offset: 0x00188756
		public float TerrainFadeLength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700284D RID: 10317
		// (get) Token: 0x06009452 RID: 37970 RVA: 0x0018A558 File Offset: 0x00188758
		// (set) Token: 0x06009453 RID: 37971 RVA: 0x0018A55B File Offset: 0x0018875B
		public int TerrainMaxTrees
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700284E RID: 10318
		// (get) Token: 0x06009454 RID: 37972 RVA: 0x0018A55D File Offset: 0x0018875D
		// (set) Token: 0x06009455 RID: 37973 RVA: 0x0018A564 File Offset: 0x00188764
		public float TerrainPixelError
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700284F RID: 10319
		// (get) Token: 0x06009456 RID: 37974 RVA: 0x0018A566 File Offset: 0x00188766
		// (set) Token: 0x06009457 RID: 37975 RVA: 0x0018A569 File Offset: 0x00188769
		public int TerrainQualityOverrides
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17002850 RID: 10320
		// (get) Token: 0x06009458 RID: 37976 RVA: 0x0018A56B File Offset: 0x0018876B
		// (set) Token: 0x06009459 RID: 37977 RVA: 0x0018A572 File Offset: 0x00188772
		public float TerrainTreeDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17002851 RID: 10321
		// (get) Token: 0x0600945A RID: 37978 RVA: 0x0018A574 File Offset: 0x00188774
		public AssetList<MipmapLimitSettings> TextureMipmapLimitSettings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002852 RID: 10322
		// (get) Token: 0x0600945B RID: 37979 RVA: 0x0018A577 File Offset: 0x00188777
		// (set) Token: 0x0600945C RID: 37980 RVA: 0x0018A57F File Offset: 0x0018877F
		public int TextureQuality
		{
			get
			{
				return this.m_TextureQuality;
			}
			set
			{
				this.m_TextureQuality = value;
			}
		}

		// Token: 0x17002853 RID: 10323
		// (get) Token: 0x0600945D RID: 37981 RVA: 0x0018A588 File Offset: 0x00188788
		// (set) Token: 0x0600945E RID: 37982 RVA: 0x0018A58B File Offset: 0x0018878B
		public bool UseLegacyDetailDistribution
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17002854 RID: 10324
		// (get) Token: 0x0600945F RID: 37983 RVA: 0x0018A58D File Offset: 0x0018878D
		// (set) Token: 0x06009460 RID: 37984 RVA: 0x0018A595 File Offset: 0x00188795
		public int VSyncCount
		{
			get
			{
				return this.m_VSyncCount;
			}
			set
			{
				this.m_VSyncCount = value;
			}
		}

		// Token: 0x17002855 RID: 10325
		// (get) Token: 0x06009461 RID: 37985 RVA: 0x0018A59E File Offset: 0x0018879E
		public Utf8String Name
		{
			get
			{
				return this.m_Name;
			}
		}

		// Token: 0x17002856 RID: 10326
		// (get) Token: 0x06009462 RID: 37986 RVA: 0x0018A5A6 File Offset: 0x001887A6
		// (set) Token: 0x06009463 RID: 37987 RVA: 0x0018A5B3 File Offset: 0x001887B3
		public string NameString
		{
			get
			{
				return this.m_Name.String;
			}
			set
			{
				this.m_Name.String = value;
			}
		}

		// Token: 0x06009464 RID: 37988 RVA: 0x0018A5C1 File Offset: 0x001887C1
		public QualitySetting_2017_1_0_GICB2()
		{
			this.m_ExcludedTargetPlatforms = new AssetList<Utf8String>();
			this.m_Name = new Utf8String();
			this.m_ShadowCascade4Split = new Vector3f_3_5_0();
		}

		// Token: 0x06009465 RID: 37989 RVA: 0x0018A5EA File Offset: 0x001887EA
		public bool Has_AsyncUploadBufferSize()
		{
			return true;
		}

		// Token: 0x06009466 RID: 37990 RVA: 0x0018A5ED File Offset: 0x001887ED
		public bool Has_AsyncUploadPersistentBuffer()
		{
			return false;
		}

		// Token: 0x06009467 RID: 37991 RVA: 0x0018A5F0 File Offset: 0x001887F0
		public bool Has_AsyncUploadTimeSlice()
		{
			return true;
		}

		// Token: 0x06009468 RID: 37992 RVA: 0x0018A5F3 File Offset: 0x001887F3
		public bool Has_BillboardsFaceCameraPosition()
		{
			return true;
		}

		// Token: 0x06009469 RID: 37993 RVA: 0x0018A5F6 File Offset: 0x001887F6
		public bool Has_BlendWeights()
		{
			return true;
		}

		// Token: 0x0600946A RID: 37994 RVA: 0x0018A5F9 File Offset: 0x001887F9
		public bool Has_CustomRenderPipeline()
		{
			return false;
		}

		// Token: 0x0600946B RID: 37995 RVA: 0x0018A5FC File Offset: 0x001887FC
		public bool Has_EnableLODCrossFade()
		{
			return false;
		}

		// Token: 0x0600946C RID: 37996 RVA: 0x0018A5FF File Offset: 0x001887FF
		public bool Has_ExcludedTargetPlatforms()
		{
			return true;
		}

		// Token: 0x0600946D RID: 37997 RVA: 0x0018A602 File Offset: 0x00188802
		public bool Has_GlobalTextureMipmapLimit()
		{
			return false;
		}

		// Token: 0x0600946E RID: 37998 RVA: 0x0018A605 File Offset: 0x00188805
		public bool Has_LodBias()
		{
			return true;
		}

		// Token: 0x0600946F RID: 37999 RVA: 0x0018A608 File Offset: 0x00188808
		public bool Has_MaximumLODLevel()
		{
			return true;
		}

		// Token: 0x06009470 RID: 38000 RVA: 0x0018A60B File Offset: 0x0018880B
		public bool Has_Name_R()
		{
			return true;
		}

		// Token: 0x06009471 RID: 38001 RVA: 0x0018A60E File Offset: 0x0018880E
		public bool Has_ParticleRaycastBudget()
		{
			return true;
		}

		// Token: 0x06009472 RID: 38002 RVA: 0x0018A611 File Offset: 0x00188811
		public bool Has_RealtimeReflectionProbes()
		{
			return true;
		}

		// Token: 0x06009473 RID: 38003 RVA: 0x0018A614 File Offset: 0x00188814
		public bool Has_ResolutionScalingFixedDPIFactor()
		{
			return true;
		}

		// Token: 0x06009474 RID: 38004 RVA: 0x0018A617 File Offset: 0x00188817
		public bool Has_ShadowCascade2Split()
		{
			return true;
		}

		// Token: 0x06009475 RID: 38005 RVA: 0x0018A61A File Offset: 0x0018881A
		public bool Has_ShadowCascade4Split()
		{
			return true;
		}

		// Token: 0x06009476 RID: 38006 RVA: 0x0018A61D File Offset: 0x0018881D
		public bool Has_ShadowmaskMode()
		{
			return true;
		}

		// Token: 0x06009477 RID: 38007 RVA: 0x0018A620 File Offset: 0x00188820
		public bool Has_ShadowNearPlaneOffset()
		{
			return true;
		}

		// Token: 0x06009478 RID: 38008 RVA: 0x0018A623 File Offset: 0x00188823
		public bool Has_SkinWeights()
		{
			return false;
		}

		// Token: 0x06009479 RID: 38009 RVA: 0x0018A626 File Offset: 0x00188826
		public bool Has_StreamingMipmapsActive()
		{
			return false;
		}

		// Token: 0x0600947A RID: 38010 RVA: 0x0018A629 File Offset: 0x00188829
		public bool Has_StreamingMipmapsAddAllCameras()
		{
			return false;
		}

		// Token: 0x0600947B RID: 38011 RVA: 0x0018A62C File Offset: 0x0018882C
		public bool Has_StreamingMipmapsMaxFileIORequests()
		{
			return false;
		}

		// Token: 0x0600947C RID: 38012 RVA: 0x0018A62F File Offset: 0x0018882F
		public bool Has_StreamingMipmapsMaxLevelReduction()
		{
			return false;
		}

		// Token: 0x0600947D RID: 38013 RVA: 0x0018A632 File Offset: 0x00188832
		public bool Has_StreamingMipmapsMemoryBudget()
		{
			return false;
		}

		// Token: 0x0600947E RID: 38014 RVA: 0x0018A635 File Offset: 0x00188835
		public bool Has_StreamingMipmapsRenderersPerFrame()
		{
			return false;
		}

		// Token: 0x0600947F RID: 38015 RVA: 0x0018A638 File Offset: 0x00188838
		public bool Has_TerrainBasemapDistance()
		{
			return false;
		}

		// Token: 0x06009480 RID: 38016 RVA: 0x0018A63B File Offset: 0x0018883B
		public bool Has_TerrainBillboardStart()
		{
			return false;
		}

		// Token: 0x06009481 RID: 38017 RVA: 0x0018A63E File Offset: 0x0018883E
		public bool Has_TerrainDetailDensityScale()
		{
			return false;
		}

		// Token: 0x06009482 RID: 38018 RVA: 0x0018A641 File Offset: 0x00188841
		public bool Has_TerrainDetailDistance()
		{
			return false;
		}

		// Token: 0x06009483 RID: 38019 RVA: 0x0018A644 File Offset: 0x00188844
		public bool Has_TerrainFadeLength()
		{
			return false;
		}

		// Token: 0x06009484 RID: 38020 RVA: 0x0018A647 File Offset: 0x00188847
		public bool Has_TerrainMaxTrees()
		{
			return false;
		}

		// Token: 0x06009485 RID: 38021 RVA: 0x0018A64A File Offset: 0x0018884A
		public bool Has_TerrainPixelError()
		{
			return false;
		}

		// Token: 0x06009486 RID: 38022 RVA: 0x0018A64D File Offset: 0x0018884D
		public bool Has_TerrainQualityOverrides()
		{
			return false;
		}

		// Token: 0x06009487 RID: 38023 RVA: 0x0018A650 File Offset: 0x00188850
		public bool Has_TerrainTreeDistance()
		{
			return false;
		}

		// Token: 0x06009488 RID: 38024 RVA: 0x0018A653 File Offset: 0x00188853
		public bool Has_TextureMipmapLimitSettings()
		{
			return false;
		}

		// Token: 0x06009489 RID: 38025 RVA: 0x0018A656 File Offset: 0x00188856
		public bool Has_TextureQuality()
		{
			return true;
		}

		// Token: 0x0600948A RID: 38026 RVA: 0x0018A659 File Offset: 0x00188859
		public bool Has_UseLegacyDetailDistribution()
		{
			return false;
		}

		// Token: 0x0600948B RID: 38027 RVA: 0x0018A65C File Offset: 0x0018885C
		public override void ReadRelease(AssetReader reader)
		{
			this.m_Name.ReadRelease(reader);
			this.m_PixelLightCount = reader.ReadInt32();
			this.m_Shadows = reader.ReadInt32();
			this.m_ShadowResolution = reader.ReadInt32();
			this.m_ShadowProjection = reader.ReadInt32();
			this.m_ShadowCascades = reader.ReadInt32();
			this.m_ShadowDistance = reader.ReadSingle();
			this.m_ShadowNearPlaneOffset = reader.ReadSingle();
			this.m_ShadowCascade2Split = reader.ReadSingle();
			this.m_ShadowCascade4Split.ReadRelease(reader);
			this.m_ShadowmaskMode = reader.ReadInt32();
			this.m_BlendWeights = reader.ReadInt32();
			this.m_TextureQuality = reader.ReadInt32();
			this.m_AnisotropicTextures = reader.ReadInt32();
			this.m_AntiAliasing = reader.ReadInt32();
			this.m_SoftParticles = reader.ReadBoolean();
			this.m_SoftVegetation = reader.ReadBoolean();
			this.m_RealtimeReflectionProbes = reader.ReadBoolean();
			this.m_BillboardsFaceCameraPosition = reader.ReadRelease_BooleanAlign();
			this.m_VSyncCount = reader.ReadInt32();
			this.m_LodBias = reader.ReadSingle();
			this.m_MaximumLODLevel = reader.ReadInt32();

			var textureStreamingBudget = reader.ReadSingle();
			var minStreamingMipLevel = reader.ReadInt32();
			var textureStreamingEnabled = reader.ReadBoolean();
			reader.AlignStream();

			this.m_ParticleRaycastBudget = reader.ReadInt32();
			this.m_AsyncUploadTimeSlice = reader.ReadInt32();
			this.m_AsyncUploadBufferSize = reader.ReadInt32();
			this.m_ResolutionScalingFixedDPIFactor = reader.ReadRelease_SingleAlign();

			var meshDynamicCompressionLevel = reader.ReadInt32();
			reader.AlignStream();
			var useOctagonParticleGlobal = reader.ReadBoolean();
			reader.AlignStream();
			var particleEmitLevel = reader.ReadInt32();
			reader.AlignStream();
			var useParticleDistanceLOD = reader.ReadBoolean();
			reader.AlignStream();
			var particleLODDistance = reader.ReadSingle();
			reader.AlignStream();
			var useMeshParticleInstancing = reader.ReadBoolean();
			reader.AlignStream();
			var lightOnLevel = reader.ReadInt32();
			reader.AlignStream();
			var perObjetShadowQuality = reader.ReadInt32();
			reader.AlignStream();
			var optimizeUIUpdate = reader.ReadBoolean();
			reader.AlignStream();
			var avatarOutlineThresh = reader.ReadSingle();
			var avatarShadowThresh = reader.ReadSingle();
			var avatarMotionVectorThresh = reader.ReadSingle();
		}

		// Token: 0x0600948C RID: 38028 RVA: 0x0018A7A4 File Offset: 0x001889A4
		public override void ReadEditor(AssetReader reader)
		{
			// this.m_Name.ReadEditor(reader);
			// this.m_PixelLightCount = reader.ReadInt32();
			// this.m_Shadows = reader.ReadInt32();
			// this.m_ShadowResolution = reader.ReadInt32();
			// this.m_ShadowProjection = reader.ReadInt32();
			// this.m_ShadowCascades = reader.ReadInt32();
			// this.m_ShadowDistance = reader.ReadSingle();
			// this.m_ShadowNearPlaneOffset = reader.ReadSingle();
			// this.m_ShadowCascade2Split = reader.ReadSingle();
			// this.m_ShadowCascade4Split.ReadEditor(reader);
			// this.m_ShadowmaskMode = reader.ReadInt32();
			// this.m_BlendWeights = reader.ReadInt32();
			// this.m_TextureQuality = reader.ReadInt32();
			// this.m_AnisotropicTextures = reader.ReadInt32();
			// this.m_AntiAliasing = reader.ReadInt32();
			// this.m_SoftParticles = reader.ReadBoolean();
			// this.m_SoftVegetation = reader.ReadBoolean();
			// this.m_RealtimeReflectionProbes = reader.ReadBoolean();
			// this.m_BillboardsFaceCameraPosition = reader.ReadEditor_BooleanAlign();
			// this.m_VSyncCount = reader.ReadInt32();
			// this.m_LodBias = reader.ReadSingle();
			// this.m_MaximumLODLevel = reader.ReadInt32();
			// this.m_ParticleRaycastBudget = reader.ReadInt32();
			// this.m_AsyncUploadTimeSlice = reader.ReadInt32();
			// this.m_AsyncUploadBufferSize = reader.ReadInt32();
			// this.m_ResolutionScalingFixedDPIFactor = reader.ReadEditor_SingleAlign();
			// this.m_ExcludedTargetPlatforms.ReadEditor_ArrayAlign_Asset(reader);
		}

		// Token: 0x0600948D RID: 38029 RVA: 0x0018A8F8 File Offset: 0x00188AF8
		public override void WriteRelease(AssetWriter writer)
		{
			this.m_Name.WriteRelease(writer);
			this.m_PixelLightCount.WriteRelease_Int32(writer);
			this.m_Shadows.WriteRelease_Int32(writer);
			this.m_ShadowResolution.WriteRelease_Int32(writer);
			this.m_ShadowProjection.WriteRelease_Int32(writer);
			this.m_ShadowCascades.WriteRelease_Int32(writer);
			this.m_ShadowDistance.WriteRelease_Single(writer);
			this.m_ShadowNearPlaneOffset.WriteRelease_Single(writer);
			this.m_ShadowCascade2Split.WriteRelease_Single(writer);
			this.m_ShadowCascade4Split.WriteRelease(writer);
			this.m_ShadowmaskMode.WriteRelease_Int32(writer);
			this.m_BlendWeights.WriteRelease_Int32(writer);
			this.m_TextureQuality.WriteRelease_Int32(writer);
			this.m_AnisotropicTextures.WriteRelease_Int32(writer);
			this.m_AntiAliasing.WriteRelease_Int32(writer);
			this.m_SoftParticles.WriteRelease_Boolean(writer);
			this.m_SoftVegetation.WriteRelease_Boolean(writer);
			this.m_RealtimeReflectionProbes.WriteRelease_Boolean(writer);
			this.m_BillboardsFaceCameraPosition.WriteRelease_BooleanAlign(writer);
			this.m_VSyncCount.WriteRelease_Int32(writer);
			this.m_LodBias.WriteRelease_Single(writer);
			this.m_MaximumLODLevel.WriteRelease_Int32(writer);
			this.m_ParticleRaycastBudget.WriteRelease_Int32(writer);
			this.m_AsyncUploadTimeSlice.WriteRelease_Int32(writer);
			this.m_AsyncUploadBufferSize.WriteRelease_Int32(writer);
			this.m_ResolutionScalingFixedDPIFactor.WriteRelease_SingleAlign(writer);
		}

		// Token: 0x0600948E RID: 38030 RVA: 0x0018AA40 File Offset: 0x00188C40
		public override void WriteEditor(AssetWriter writer)
		{
			// this.m_Name.WriteEditor(writer);
			// this.m_PixelLightCount.WriteEditor_Int32(writer);
			// this.m_Shadows.WriteEditor_Int32(writer);
			// this.m_ShadowResolution.WriteEditor_Int32(writer);
			// this.m_ShadowProjection.WriteEditor_Int32(writer);
			// this.m_ShadowCascades.WriteEditor_Int32(writer);
			// this.m_ShadowDistance.WriteEditor_Single(writer);
			// this.m_ShadowNearPlaneOffset.WriteEditor_Single(writer);
			// this.m_ShadowCascade2Split.WriteEditor_Single(writer);
			// this.m_ShadowCascade4Split.WriteEditor(writer);
			// this.m_ShadowmaskMode.WriteEditor_Int32(writer);
			// this.m_BlendWeights.WriteEditor_Int32(writer);
			// this.m_TextureQuality.WriteEditor_Int32(writer);
			// this.m_AnisotropicTextures.WriteEditor_Int32(writer);
			// this.m_AntiAliasing.WriteEditor_Int32(writer);
			// this.m_SoftParticles.WriteEditor_Boolean(writer);
			// this.m_SoftVegetation.WriteEditor_Boolean(writer);
			// this.m_RealtimeReflectionProbes.WriteEditor_Boolean(writer);
			// this.m_BillboardsFaceCameraPosition.WriteEditor_BooleanAlign(writer);
			// this.m_VSyncCount.WriteEditor_Int32(writer);
			// this.m_LodBias.WriteEditor_Single(writer);
			// this.m_MaximumLODLevel.WriteEditor_Int32(writer);
			// this.m_ParticleRaycastBudget.WriteEditor_Int32(writer);
			// this.m_AsyncUploadTimeSlice.WriteEditor_Int32(writer);
			// this.m_AsyncUploadBufferSize.WriteEditor_Int32(writer);
			// this.m_ResolutionScalingFixedDPIFactor.WriteEditor_SingleAlign(writer);
			// this.m_ExcludedTargetPlatforms.WriteEditor_ArrayAlign_Asset(writer);
		}

		// Token: 0x0600948F RID: 38031 RVA: 0x0018AB94 File Offset: 0x00188D94
		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 2);
			yamlMappingNode.Add(new YamlScalarNode("name"), this.m_Name.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("pixelLightCount"), this.m_PixelLightCount.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("shadows"), this.m_Shadows.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("shadowResolution"), this.m_ShadowResolution.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("shadowProjection"), this.m_ShadowProjection.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("shadowCascades"), this.m_ShadowCascades.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("shadowDistance"), this.m_ShadowDistance.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("shadowNearPlaneOffset"), this.m_ShadowNearPlaneOffset.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("shadowCascade2Split"), this.m_ShadowCascade2Split.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("shadowCascade4Split"), this.m_ShadowCascade4Split.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("shadowmaskMode"), this.m_ShadowmaskMode.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("blendWeights"), this.m_BlendWeights.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("textureQuality"), this.m_TextureQuality.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("anisotropicTextures"), this.m_AnisotropicTextures.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("antiAliasing"), this.m_AntiAliasing.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("softParticles"), this.m_SoftParticles.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("softVegetation"), this.m_SoftVegetation.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("realtimeReflectionProbes"), this.m_RealtimeReflectionProbes.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("billboardsFaceCameraPosition"), this.m_BillboardsFaceCameraPosition.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("vSyncCount"), this.m_VSyncCount.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("lodBias"), this.m_LodBias.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("maximumLODLevel"), this.m_MaximumLODLevel.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("particleRaycastBudget"), this.m_ParticleRaycastBudget.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("asyncUploadTimeSlice"), this.m_AsyncUploadTimeSlice.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("asyncUploadBufferSize"), this.m_AsyncUploadBufferSize.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("resolutionScalingFixedDPIFactor"), this.m_ResolutionScalingFixedDPIFactor.ExportYamlRelease_Single(container));
			return yamlMappingNode;
		}

		// Token: 0x06009490 RID: 38032 RVA: 0x0018AE88 File Offset: 0x00189088
		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 2);
			yamlMappingNode.Add(new YamlScalarNode("name"), this.m_Name.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("pixelLightCount"), this.m_PixelLightCount.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("shadows"), this.m_Shadows.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("shadowResolution"), this.m_ShadowResolution.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("shadowProjection"), this.m_ShadowProjection.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("shadowCascades"), this.m_ShadowCascades.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("shadowDistance"), this.m_ShadowDistance.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("shadowNearPlaneOffset"), this.m_ShadowNearPlaneOffset.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("shadowCascade2Split"), this.m_ShadowCascade2Split.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("shadowCascade4Split"), this.m_ShadowCascade4Split.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("shadowmaskMode"), this.m_ShadowmaskMode.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("blendWeights"), this.m_BlendWeights.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("textureQuality"), this.m_TextureQuality.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("anisotropicTextures"), this.m_AnisotropicTextures.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("antiAliasing"), this.m_AntiAliasing.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("softParticles"), this.m_SoftParticles.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("softVegetation"), this.m_SoftVegetation.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("realtimeReflectionProbes"), this.m_RealtimeReflectionProbes.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("billboardsFaceCameraPosition"), this.m_BillboardsFaceCameraPosition.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("vSyncCount"), this.m_VSyncCount.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("lodBias"), this.m_LodBias.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("maximumLODLevel"), this.m_MaximumLODLevel.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("particleRaycastBudget"), this.m_ParticleRaycastBudget.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("asyncUploadTimeSlice"), this.m_AsyncUploadTimeSlice.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("asyncUploadBufferSize"), this.m_AsyncUploadBufferSize.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("resolutionScalingFixedDPIFactor"), this.m_ResolutionScalingFixedDPIFactor.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("excludedTargetPlatforms"), this.m_ExcludedTargetPlatforms.ExportYamlEditor_Array_Utf8String(container));
			return yamlMappingNode;
		}

		// Token: 0x06009491 RID: 38033 RVA: 0x0018B198 File Offset: 0x00189398
		public override void Reset()
		{
			this.m_AnisotropicTextures = 0;
			this.m_AntiAliasing = 0;
			this.m_AsyncUploadBufferSize = 0;
			this.m_AsyncUploadTimeSlice = 0;
			this.m_BillboardsFaceCameraPosition = false;
			this.m_BlendWeights = 0;
			this.m_ExcludedTargetPlatforms.Clear();
			this.m_LodBias = 0f;
			this.m_MaximumLODLevel = 0;
			this.m_Name.Reset();
			this.m_ParticleRaycastBudget = 0;
			this.m_PixelLightCount = 0;
			this.m_RealtimeReflectionProbes = false;
			this.m_ResolutionScalingFixedDPIFactor = 0f;
			this.m_ShadowCascade2Split = 0f;
			this.m_ShadowCascade4Split.Reset();
			this.m_ShadowCascades = 0;
			this.m_ShadowDistance = 0f;
			this.m_ShadowmaskMode = 0;
			this.m_ShadowNearPlaneOffset = 0f;
			this.m_ShadowProjection = 0;
			this.m_ShadowResolution = 0;
			this.m_Shadows = 0;
			this.m_SoftParticles = false;
			this.m_SoftVegetation = false;
			this.m_TextureQuality = 0;
			this.m_VSyncCount = 0;
		}

		// Token: 0x06009492 RID: 38034 RVA: 0x0018B282 File Offset: 0x00189482
		public override IEnumerable<ValueTuple<FieldName, PPtr<IUnityObjectBase>>> FetchDependencies(FieldName parent)
		{
			return Enumerable.Empty<ValueTuple<FieldName, PPtr<IUnityObjectBase>>>();
		}

		// Token: 0x06009493 RID: 38035 RVA: 0x0018B28C File Offset: 0x0018948C

		public void CopyValues(IQualitySetting source, PPtrConverter converter)
		{
			if (source != null)
			{
				this.m_AnisotropicTextures = source.AnisotropicTextures;
				this.m_AntiAliasing = source.AntiAliasing;
				this.m_AsyncUploadBufferSize = source.AsyncUploadBufferSize;
				this.m_AsyncUploadTimeSlice = source.AsyncUploadTimeSlice;
				this.m_BillboardsFaceCameraPosition = source.BillboardsFaceCameraPosition;
				this.m_BlendWeights = source.BlendWeights;
				CopyValuesHelper.CopyValues__AssetList_Utf8String__AssetList_Utf8String(this.m_ExcludedTargetPlatforms, source.ExcludedTargetPlatforms);
				this.m_LodBias = source.LodBias;
				this.m_MaximumLODLevel = source.MaximumLODLevel;
				this.m_Name.CopyValues(source.Name_R);
				this.m_ParticleRaycastBudget = source.ParticleRaycastBudget;
				this.m_PixelLightCount = source.PixelLightCount;
				this.m_RealtimeReflectionProbes = source.RealtimeReflectionProbes;
				this.m_ResolutionScalingFixedDPIFactor = source.ResolutionScalingFixedDPIFactor;
				this.m_ShadowCascade2Split = source.ShadowCascade2Split;
				this.m_ShadowCascade4Split.CopyValues(source.ShadowCascade4Split);
				this.m_ShadowCascades = source.ShadowCascades;
				this.m_ShadowDistance = source.ShadowDistance;
				this.m_ShadowmaskMode = source.ShadowmaskMode;
				this.m_ShadowNearPlaneOffset = source.ShadowNearPlaneOffset;
				this.m_ShadowProjection = source.ShadowProjection;
				this.m_ShadowResolution = source.ShadowResolution;
				this.m_Shadows = source.Shadows;
				this.m_SoftParticles = source.SoftParticles;
				this.m_SoftVegetation = source.SoftVegetation;
				this.m_TextureQuality = source.TextureQuality;
				this.m_VSyncCount = source.VSyncCount;
				return;
			}
			this.Reset();
		}

		// Token: 0x06009494 RID: 38036 RVA: 0x0018B3F9 File Offset: 0x001895F9
		public IQualitySetting DeepClone(PPtrConverter converter)
		{
			QualitySetting_2017_1_0_GICB2 qualitySetting_2017_1_0_b = new QualitySetting_2017_1_0_GICB2();
			qualitySetting_2017_1_0_b.CopyValues(this, converter);
			return qualitySetting_2017_1_0_b;
		}

		// Token: 0x06009495 RID: 38037 RVA: 0x0018B408 File Offset: 0x00189608

		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			IQualitySetting qualitySetting = source as IQualitySetting;
			if (qualitySetting != null)
			{
				this.CopyValues(qualitySetting, converter);
				return;
			}
			this.Reset();
		}

		// Token: 0x06009496 RID: 38038 RVA: 0x0018B430 File Offset: 0x00189630

		public bool Equals(IQualitySetting other)
		{
			return other != null && this.AnisotropicTextures == other.AnisotropicTextures && this.AntiAliasing == other.AntiAliasing && this.AsyncUploadBufferSize == other.AsyncUploadBufferSize && this.AsyncUploadPersistentBuffer == other.AsyncUploadPersistentBuffer && this.AsyncUploadTimeSlice == other.AsyncUploadTimeSlice && this.BillboardsFaceCameraPosition == other.BillboardsFaceCameraPosition && this.BlendWeights == other.BlendWeights && EqualityComparer<PPtr_MonoBehaviour_5_0_0>.Default.Equals(this.CustomRenderPipeline, other.CustomRenderPipeline) && this.EnableLODCrossFade == other.EnableLODCrossFade && EqualityComparer<AssetList<Utf8String>>.Default.Equals(this.ExcludedTargetPlatforms, other.ExcludedTargetPlatforms) && this.GlobalTextureMipmapLimit == other.GlobalTextureMipmapLimit && this.LodBias == other.LodBias && this.MaximumLODLevel == other.MaximumLODLevel && EqualityComparer<Utf8String>.Default.Equals(this.Name_R, other.Name_R) && this.ParticleRaycastBudget == other.ParticleRaycastBudget && this.PixelLightCount == other.PixelLightCount && this.RealtimeReflectionProbes == other.RealtimeReflectionProbes && this.ResolutionScalingFixedDPIFactor == other.ResolutionScalingFixedDPIFactor && this.ShadowCascade2Split == other.ShadowCascade2Split && EqualityComparer<Vector3f_3_5_0>.Default.Equals(this.ShadowCascade4Split, other.ShadowCascade4Split) && this.ShadowCascades == other.ShadowCascades && this.ShadowDistance == other.ShadowDistance && this.ShadowmaskMode == other.ShadowmaskMode && this.ShadowNearPlaneOffset == other.ShadowNearPlaneOffset && this.ShadowProjection == other.ShadowProjection && this.ShadowResolution == other.ShadowResolution && this.Shadows == other.Shadows && this.SkinWeights == other.SkinWeights && this.SoftParticles == other.SoftParticles && this.SoftVegetation == other.SoftVegetation && this.StreamingMipmapsActive == other.StreamingMipmapsActive && this.StreamingMipmapsAddAllCameras == other.StreamingMipmapsAddAllCameras && this.StreamingMipmapsMaxFileIORequests == other.StreamingMipmapsMaxFileIORequests && this.StreamingMipmapsMaxLevelReduction == other.StreamingMipmapsMaxLevelReduction && this.StreamingMipmapsMemoryBudget == other.StreamingMipmapsMemoryBudget && this.StreamingMipmapsRenderersPerFrame == other.StreamingMipmapsRenderersPerFrame && this.TerrainBasemapDistance == other.TerrainBasemapDistance && this.TerrainBillboardStart == other.TerrainBillboardStart && this.TerrainDetailDensityScale == other.TerrainDetailDensityScale && this.TerrainDetailDistance == other.TerrainDetailDistance && this.TerrainFadeLength == other.TerrainFadeLength && this.TerrainMaxTrees == other.TerrainMaxTrees && this.TerrainPixelError == other.TerrainPixelError && this.TerrainQualityOverrides == other.TerrainQualityOverrides && this.TerrainTreeDistance == other.TerrainTreeDistance && EqualityComparer<AssetList<MipmapLimitSettings>>.Default.Equals(this.TextureMipmapLimitSettings, other.TextureMipmapLimitSettings) && this.TextureQuality == other.TextureQuality && this.UseLegacyDetailDistribution == other.UseLegacyDetailDistribution && this.VSyncCount == other.VSyncCount;
		}

		// Token: 0x06009497 RID: 38039 RVA: 0x0018B7A0 File Offset: 0x001899A0

		public bool Equals(QualitySetting_2017_1_0_GICB2 other)
		{
			return other != null && EqualityComparer<AssetList<Utf8String>>.Default.Equals(this.m_ExcludedTargetPlatforms, other.m_ExcludedTargetPlatforms) && EqualityComparer<Utf8String>.Default.Equals(this.m_Name, other.m_Name) && this.m_PixelLightCount == other.m_PixelLightCount && this.m_Shadows == other.m_Shadows && this.m_ShadowResolution == other.m_ShadowResolution && this.m_ShadowProjection == other.m_ShadowProjection && this.m_ShadowCascades == other.m_ShadowCascades && this.m_ShadowDistance == other.m_ShadowDistance && this.m_ShadowNearPlaneOffset == other.m_ShadowNearPlaneOffset && this.m_ShadowCascade2Split == other.m_ShadowCascade2Split && EqualityComparer<Vector3f_3_5_0>.Default.Equals(this.m_ShadowCascade4Split, other.m_ShadowCascade4Split) && this.m_ShadowmaskMode == other.m_ShadowmaskMode && this.m_BlendWeights == other.m_BlendWeights && this.m_TextureQuality == other.m_TextureQuality && this.m_AnisotropicTextures == other.m_AnisotropicTextures && this.m_AntiAliasing == other.m_AntiAliasing && this.m_SoftParticles == other.m_SoftParticles && this.m_SoftVegetation == other.m_SoftVegetation && this.m_RealtimeReflectionProbes == other.m_RealtimeReflectionProbes && this.m_BillboardsFaceCameraPosition == other.m_BillboardsFaceCameraPosition && this.m_VSyncCount == other.m_VSyncCount && this.m_LodBias == other.m_LodBias && this.m_MaximumLODLevel == other.m_MaximumLODLevel && this.m_ParticleRaycastBudget == other.m_ParticleRaycastBudget && this.m_AsyncUploadTimeSlice == other.m_AsyncUploadTimeSlice && this.m_AsyncUploadBufferSize == other.m_AsyncUploadBufferSize && this.m_ResolutionScalingFixedDPIFactor == other.m_ResolutionScalingFixedDPIFactor;
		}

		// Token: 0x06009498 RID: 38040 RVA: 0x0018B984 File Offset: 0x00189B84

		public override bool Equals(object other)
		{
			return this.Equals(other as IQualitySetting);
		}

		// Token: 0x06009499 RID: 38041 RVA: 0x0018B992 File Offset: 0x00189B92

		public static bool operator ==(QualitySetting_2017_1_0_GICB2 left, QualitySetting_2017_1_0_GICB2 right)
		{
			return EqualityComparer<QualitySetting_2017_1_0_GICB2>.Default.Equals(left, right);
		}

		// Token: 0x0600949A RID: 38042 RVA: 0x0018B9A0 File Offset: 0x00189BA0

		public static bool operator !=(QualitySetting_2017_1_0_GICB2 left, QualitySetting_2017_1_0_GICB2 right)
		{
			return !(left == right);
		}

		// Token: 0x0600949B RID: 38043 RVA: 0x0018B9AC File Offset: 0x00189BAC
		public override int GetHashCode()
		{
			HashCode hashCode = default(HashCode);
			hashCode.Add<int>(this.AnisotropicTextures);
			hashCode.Add<int>(this.AntiAliasing);
			hashCode.Add<int>(this.AsyncUploadBufferSize);
			hashCode.Add<bool>(this.AsyncUploadPersistentBuffer);
			hashCode.Add<int>(this.AsyncUploadTimeSlice);
			hashCode.Add<bool>(this.BillboardsFaceCameraPosition);
			hashCode.Add<int>(this.BlendWeights);
			hashCode.Add<PPtr_MonoBehaviour_5_0_0>(this.CustomRenderPipeline);
			hashCode.Add<bool>(this.EnableLODCrossFade);
			hashCode.Add<AssetList<Utf8String>>(this.ExcludedTargetPlatforms);
			hashCode.Add<int>(this.GlobalTextureMipmapLimit);
			hashCode.Add<float>(this.LodBias);
			hashCode.Add<int>(this.MaximumLODLevel);
			hashCode.Add<Utf8String>(this.Name_R);
			hashCode.Add<int>(this.ParticleRaycastBudget);
			hashCode.Add<int>(this.PixelLightCount);
			hashCode.Add<bool>(this.RealtimeReflectionProbes);
			hashCode.Add<float>(this.ResolutionScalingFixedDPIFactor);
			hashCode.Add<float>(this.ShadowCascade2Split);
			hashCode.Add<Vector3f_3_5_0>(this.ShadowCascade4Split);
			hashCode.Add<int>(this.ShadowCascades);
			hashCode.Add<float>(this.ShadowDistance);
			hashCode.Add<int>(this.ShadowmaskMode);
			hashCode.Add<float>(this.ShadowNearPlaneOffset);
			hashCode.Add<int>(this.ShadowProjection);
			hashCode.Add<int>(this.ShadowResolution);
			hashCode.Add<int>(this.Shadows);
			hashCode.Add<int>(this.SkinWeights);
			hashCode.Add<bool>(this.SoftParticles);
			hashCode.Add<bool>(this.SoftVegetation);
			hashCode.Add<bool>(this.StreamingMipmapsActive);
			hashCode.Add<bool>(this.StreamingMipmapsAddAllCameras);
			hashCode.Add<int>(this.StreamingMipmapsMaxFileIORequests);
			hashCode.Add<int>(this.StreamingMipmapsMaxLevelReduction);
			hashCode.Add<float>(this.StreamingMipmapsMemoryBudget);
			hashCode.Add<int>(this.StreamingMipmapsRenderersPerFrame);
			hashCode.Add<float>(this.TerrainBasemapDistance);
			hashCode.Add<float>(this.TerrainBillboardStart);
			hashCode.Add<float>(this.TerrainDetailDensityScale);
			hashCode.Add<float>(this.TerrainDetailDistance);
			hashCode.Add<float>(this.TerrainFadeLength);
			hashCode.Add<int>(this.TerrainMaxTrees);
			hashCode.Add<float>(this.TerrainPixelError);
			hashCode.Add<int>(this.TerrainQualityOverrides);
			hashCode.Add<float>(this.TerrainTreeDistance);
			hashCode.Add<AssetList<MipmapLimitSettings>>(this.TextureMipmapLimitSettings);
			hashCode.Add<int>(this.TextureQuality);
			hashCode.Add<bool>(this.UseLegacyDetailDistribution);
			hashCode.Add<int>(this.VSyncCount);
			return hashCode.ToHashCode();
		}

		// Token: 0x0600949C RID: 38044 RVA: 0x0018BC45 File Offset: 0x00189E45
		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600949D RID: 38045 RVA: 0x0018BC4C File Offset: 0x00189E4C
		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x040019AF RID: 6575
		public AssetList<Utf8String> m_ExcludedTargetPlatforms;

		// Token: 0x040019B0 RID: 6576
		public Utf8String m_Name;

		// Token: 0x040019B1 RID: 6577
		public int m_PixelLightCount;

		// Token: 0x040019B2 RID: 6578
		public int m_Shadows;

		// Token: 0x040019B3 RID: 6579
		public int m_ShadowResolution;

		// Token: 0x040019B4 RID: 6580
		public int m_ShadowProjection;

		// Token: 0x040019B5 RID: 6581
		public int m_ShadowCascades;

		// Token: 0x040019B6 RID: 6582
		public float m_ShadowDistance;

		// Token: 0x040019B7 RID: 6583
		public float m_ShadowNearPlaneOffset;

		// Token: 0x040019B8 RID: 6584
		public float m_ShadowCascade2Split;

		// Token: 0x040019B9 RID: 6585
		public Vector3f_3_5_0 m_ShadowCascade4Split;

		// Token: 0x040019BA RID: 6586
		public int m_ShadowmaskMode;

		// Token: 0x040019BB RID: 6587
		public int m_BlendWeights;

		// Token: 0x040019BC RID: 6588
		public int m_TextureQuality;

		// Token: 0x040019BD RID: 6589
		public int m_AnisotropicTextures;

		// Token: 0x040019BE RID: 6590
		public int m_AntiAliasing;

		// Token: 0x040019BF RID: 6591
		public bool m_SoftParticles;

		// Token: 0x040019C0 RID: 6592
		public bool m_SoftVegetation;

		// Token: 0x040019C1 RID: 6593
		public bool m_RealtimeReflectionProbes;

		// Token: 0x040019C2 RID: 6594
		public bool m_BillboardsFaceCameraPosition;

		// Token: 0x040019C3 RID: 6595
		public int m_VSyncCount;

		// Token: 0x040019C4 RID: 6596
		public float m_LodBias;

		// Token: 0x040019C5 RID: 6597
		public int m_MaximumLODLevel;

		// Token: 0x040019C6 RID: 6598
		public int m_ParticleRaycastBudget;

		// Token: 0x040019C7 RID: 6599
		public int m_AsyncUploadTimeSlice;

		// Token: 0x040019C8 RID: 6600
		public int m_AsyncUploadBufferSize;

		// Token: 0x040019C9 RID: 6601
		public float m_ResolutionScalingFixedDPIFactor;
	}
}
