using System;
using System.Collections.Generic;
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
using AssetRipper.SourceGenerated.Classes.ClassID_0;
using AssetRipper.SourceGenerated.Classes.ClassID_6;
using AssetRipper.SourceGenerated.Classes.ClassID_9;
using AssetRipper.SourceGenerated.Helpers;
using AssetRipper.SourceGenerated.Interfaces;
using AssetRipper.SourceGenerated.MarkerInterfaces;
using AssetRipper.SourceGenerated.Subclasses.AndroidBanner;
using AssetRipper.SourceGenerated.Subclasses.AspectRatios;
using AssetRipper.SourceGenerated.Subclasses.BitField;
using AssetRipper.SourceGenerated.Subclasses.BuildTargetBatching;
using AssetRipper.SourceGenerated.Subclasses.BuildTargetGraphicsAPIs;
using AssetRipper.SourceGenerated.Subclasses.BuildTargetIcons;
using AssetRipper.SourceGenerated.Subclasses.BuildTargetVRSettings;
using AssetRipper.SourceGenerated.Subclasses.ColorRGBA32;
using AssetRipper.SourceGenerated.Subclasses.ColorRGBAf;
using AssetRipper.SourceGenerated.Subclasses.GUID;
using AssetRipper.SourceGenerated.Subclasses.IOSDeviceRequirementForResourceVariant;
using AssetRipper.SourceGenerated.Subclasses.MetroFTAFileType;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Object;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Sprite;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Texture2D;
using AssetRipper.SourceGenerated.Subclasses.Rectf;
using AssetRipper.SourceGenerated.Subclasses.SplashScreenLogo;
using AssetRipper.SourceGenerated.Subclasses.Utf8String;
using AssetRipper.SourceGenerated.Subclasses.Vector2f;
using AssetRipper.SourceGenerated.Subclasses.VREditorSettings;
using AssetRipper.SourceGenerated.Subclasses.VRSettings;
using AssetRipper.SourceGenerated.Subclasses.XboxOneSocketDefinition;
using AssetRipper.Yaml;
using AssetRipper.SourceGenerated.Classes.ClassID_129;

namespace AssetRipper.Import.GICB2.PlayerSettings
{
	// Token: 0x0200320C RID: 12812


	public sealed class PlayerSettings_2017_1_0_f2_GICB2 : GlobalGameManager, IPlayerSettings, IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IPlayerSettingsMarker, IGlobalGameManager, IGlobalGameManagerMarker, IGameManager, IGameManagerMarker, IObject, IObjectMarker, IHasHideFlags
	{
		// Token: 0x1701C417 RID: 115735
		// (get) Token: 0x06050FB9 RID: 331705 RVA: 0x00A7BE37 File Offset: 0x00A7A037
		public override string ClassName
		{
			get
			{
				return "PlayerSettings";
			}
		}

		// Token: 0x06050FBA RID: 331706 RVA: 0x00A7BE3E File Offset: 0x00A7A03E
		public PlayerSettings_2017_1_0_f2_GICB2()
			: this(AssetInfo.MakeDummyAssetInfo(129))
		{
		}

		// Token: 0x06050FBB RID: 331707 RVA: 0x00A7BE50 File Offset: 0x00A7A050
		public PlayerSettings_2017_1_0_f2_GICB2(AssetInfo info)
			: base(info)
		{
			this.m_ApplicationIdentifier = new AssetDictionary<Utf8String, Utf8String>();
			this.m_BuildNumber = new AssetDictionary<Utf8String, Utf8String>();
			this.m_AotOptions = new Utf8String();
			this.m_VertexChannelCompressionMask = new BitField();
			this.m_IOSTargetOSVersionString = new Utf8String();
			this.m_TvOSTargetOSVersionString = new Utf8String();
			this.m_IPhoneSplashScreen = new PPtr_Texture2D_5_0_0();
			this.m_IPhoneHighResSplashScreen = new PPtr_Texture2D_5_0_0();
			this.m_IPhoneTallHighResSplashScreen = new PPtr_Texture2D_5_0_0();
			this.m_IPhone47inSplashScreen = new PPtr_Texture2D_5_0_0();
			this.m_IPhone55inPortraitSplashScreen = new PPtr_Texture2D_5_0_0();
			this.m_IPhone55inLandscapeSplashScreen = new PPtr_Texture2D_5_0_0();
			this.m_IPadPortraitSplashScreen = new PPtr_Texture2D_5_0_0();
			this.m_IPadHighResPortraitSplashScreen = new PPtr_Texture2D_5_0_0();
			this.m_IPadLandscapeSplashScreen = new PPtr_Texture2D_5_0_0();
			this.m_IPadHighResLandscapeSplashScreen = new PPtr_Texture2D_5_0_0();
			this.m_AppleTVSplashScreen = new PPtr_Texture2D_5_0_0();
			this.m_TvOSSmallIconLayers = new AssetList<PPtr_Texture2D_5_0_0>();
			this.m_TvOSLargeIconLayers = new AssetList<PPtr_Texture2D_5_0_0>();
			this.m_TvOSTopShelfImageLayers = new AssetList<PPtr_Texture2D_5_0_0>();
			this.m_TvOSTopShelfImageWideLayers = new AssetList<PPtr_Texture2D_5_0_0>();
			this.m_IOSLaunchScreenPortrait = new PPtr_Texture2D_5_0_0();
			this.m_IOSLaunchScreenLandscape = new PPtr_Texture2D_5_0_0();
			this.m_IOSLaunchScreenBackgroundColor = new ColorRGBA32();
			this.m_IOSLaunchScreenCustomXibPath = new Utf8String();
			this.m_IOSLaunchScreeniPadImage = new PPtr_Texture2D_5_0_0();
			this.m_IOSLaunchScreeniPadBackgroundColor = new ColorRGBA32();
			this.m_IOSLaunchScreeniPadCustomXibPath = new Utf8String();
			this.m_IOSDeviceRequirements = new AssetList<IOSDeviceRequirementForResourceVariant_2017_1_0>();
			this.m_IOSURLSchemes = new AssetList<Utf8String>();
			this.m_AppleDeveloperTeamID = new Utf8String();
			this.m_IOSManualSigningProvisioningProfileID = new Utf8String();
			this.m_TvOSManualSigningProvisioningProfileID = new Utf8String();
			this.m_AndroidSplashScreen = new PPtr_Texture2D_5_0_0();
			this.m_AndroidKeystoreName = new Utf8String();
			this.m_AndroidKeyaliasName = new Utf8String();
			this.m_AndroidBanners = new AssetList<AndroidBanner>();
			this.m_ResolutionDialogBanner = new PPtr_Texture2D_5_0_0();
			this.m_BuildTargetIcons = new AssetList<BuildTargetIcons_2017_1_0>();
			this.m_BuildTargetBatching = new AssetList<BuildTargetBatching>();
			this.m_BuildTargetGraphicsAPIs = new AssetList<BuildTargetGraphicsAPIs_2017_1_0>();
			this.m_BuildTargetVRSettings = new AssetList<BuildTargetVRSettings_2017_1_0>();
			this.m_WebPlayerTemplate = new Utf8String();
			this.m_TemplateCustomTags = new AssetDictionary<Utf8String, Utf8String>();
			this.m_WiiUTitleID = new Utf8String();
			this.m_WiiUGroupID = new Utf8String();
			this.m_WiiUOlvAccessKey = new Utf8String();
			this.m_WiiUTinCode = new Utf8String();
			this.m_WiiUJoinGameId = new Utf8String();
			this.m_WiiUJoinGameModeMask = new Utf8String();
			this.m_WiiUAddOnUniqueIDs = new AssetList<Utf8String>();
			this.m_WiiUTVStartupScreen = new PPtr_Texture2D_5_0_0();
			this.m_WiiUGamePadStartupScreen = new PPtr_Texture2D_5_0_0();
			this.m_WiiUProfilerLibPath = new Utf8String();
			this.m_CameraUsageDescription = new Utf8String();
			this.m_LocationUsageDescription = new Utf8String();
			this.m_MicrophoneUsageDescription = new Utf8String();
			this.m_SwitchNetLibKey = new Utf8String();
			this.m_SwitchApplicationID = new Utf8String();
			this.m_SwitchNSODependencies = new Utf8String();
			this.m_SwitchTitleNames_0 = new Utf8String();
			this.m_SwitchTitleNames_1 = new Utf8String();
			this.m_SwitchTitleNames_2 = new Utf8String();
			this.m_SwitchTitleNames_3 = new Utf8String();
			this.m_SwitchTitleNames_4 = new Utf8String();
			this.m_SwitchTitleNames_5 = new Utf8String();
			this.m_SwitchTitleNames_6 = new Utf8String();
			this.m_SwitchTitleNames_7 = new Utf8String();
			this.m_SwitchTitleNames_8 = new Utf8String();
			this.m_SwitchTitleNames_9 = new Utf8String();
			this.m_SwitchTitleNames_10 = new Utf8String();
			this.m_SwitchTitleNames_11 = new Utf8String();
			this.m_SwitchPublisherNames_0 = new Utf8String();
			this.m_SwitchPublisherNames_1 = new Utf8String();
			this.m_SwitchPublisherNames_2 = new Utf8String();
			this.m_SwitchPublisherNames_3 = new Utf8String();
			this.m_SwitchPublisherNames_4 = new Utf8String();
			this.m_SwitchPublisherNames_5 = new Utf8String();
			this.m_SwitchPublisherNames_6 = new Utf8String();
			this.m_SwitchPublisherNames_7 = new Utf8String();
			this.m_SwitchPublisherNames_8 = new Utf8String();
			this.m_SwitchPublisherNames_9 = new Utf8String();
			this.m_SwitchPublisherNames_10 = new Utf8String();
			this.m_SwitchPublisherNames_11 = new Utf8String();
			this.m_SwitchIcons_0 = new PPtr_Texture2D_5_0_0();
			this.m_SwitchIcons_1 = new PPtr_Texture2D_5_0_0();
			this.m_SwitchIcons_2 = new PPtr_Texture2D_5_0_0();
			this.m_SwitchIcons_3 = new PPtr_Texture2D_5_0_0();
			this.m_SwitchIcons_4 = new PPtr_Texture2D_5_0_0();
			this.m_SwitchIcons_5 = new PPtr_Texture2D_5_0_0();
			this.m_SwitchIcons_6 = new PPtr_Texture2D_5_0_0();
			this.m_SwitchIcons_7 = new PPtr_Texture2D_5_0_0();
			this.m_SwitchIcons_8 = new PPtr_Texture2D_5_0_0();
			this.m_SwitchIcons_9 = new PPtr_Texture2D_5_0_0();
			this.m_SwitchIcons_10 = new PPtr_Texture2D_5_0_0();
			this.m_SwitchIcons_11 = new PPtr_Texture2D_5_0_0();
			this.m_SwitchSmallIcons_0 = new PPtr_Texture2D_5_0_0();
			this.m_SwitchSmallIcons_1 = new PPtr_Texture2D_5_0_0();
			this.m_SwitchSmallIcons_2 = new PPtr_Texture2D_5_0_0();
			this.m_SwitchSmallIcons_3 = new PPtr_Texture2D_5_0_0();
			this.m_SwitchSmallIcons_4 = new PPtr_Texture2D_5_0_0();
			this.m_SwitchSmallIcons_5 = new PPtr_Texture2D_5_0_0();
			this.m_SwitchSmallIcons_6 = new PPtr_Texture2D_5_0_0();
			this.m_SwitchSmallIcons_7 = new PPtr_Texture2D_5_0_0();
			this.m_SwitchSmallIcons_8 = new PPtr_Texture2D_5_0_0();
			this.m_SwitchSmallIcons_9 = new PPtr_Texture2D_5_0_0();
			this.m_SwitchSmallIcons_10 = new PPtr_Texture2D_5_0_0();
			this.m_SwitchSmallIcons_11 = new PPtr_Texture2D_5_0_0();
			this.m_SwitchManualHTML = new Utf8String();
			this.m_SwitchAccessibleURLs = new Utf8String();
			this.m_SwitchLegalInformation = new Utf8String();
			this.m_SwitchPresenceGroupId = new Utf8String();
			this.m_SwitchDisplayVersion = new Utf8String();
			this.m_SwitchApplicationErrorCodeCategory = new Utf8String();
			this.m_SwitchLocalCommunicationIds_0 = new Utf8String();
			this.m_SwitchLocalCommunicationIds_1 = new Utf8String();
			this.m_SwitchLocalCommunicationIds_2 = new Utf8String();
			this.m_SwitchLocalCommunicationIds_3 = new Utf8String();
			this.m_SwitchLocalCommunicationIds_4 = new Utf8String();
			this.m_SwitchLocalCommunicationIds_5 = new Utf8String();
			this.m_SwitchLocalCommunicationIds_6 = new Utf8String();
			this.m_SwitchLocalCommunicationIds_7 = new Utf8String();
			this.m_Ps4NPTitleSecret = new Utf8String();
			this.m_Ps4NPTrophyPackPath = new Utf8String();
			this.m_Ps4ContentID = new Utf8String();
			this.m_Ps4MasterVersion = new Utf8String();
			this.m_Ps4AppVersion = new Utf8String();
			this.m_Ps4ParamSfxPath = new Utf8String();
			this.m_Ps4PronunciationXMLPath = new Utf8String();
			this.m_Ps4PronunciationSIGPath = new Utf8String();
			this.m_Ps4BackgroundImagePath = new Utf8String();
			this.m_Ps4StartupImagePath = new Utf8String();
			this.m_Ps4SaveDataImagePath = new Utf8String();
			this.m_Ps4SdkOverride = new Utf8String();
			this.m_Ps4BGMPath = new Utf8String();
			this.m_Ps4ShareFilePath = new Utf8String();
			this.m_Ps4ShareOverlayImagePath = new Utf8String();
			this.m_Ps4PrivacyGuardImagePath = new Utf8String();
			this.m_Ps4NPtitleDatPath = new Utf8String();
			this.m_Ps4RemotePlayKeyMappingDir = new Utf8String();
			this.m_Ps4Passcode = new Utf8String();
			this.m_Ps4PatchPkgPath = new Utf8String();
			this.m_Ps4PatchLatestPkgPath = new Utf8String();
			this.m_Ps4PatchChangeinfoPath = new Utf8String();
			this.m_Ps4IncludedModules = new AssetList<Utf8String>();
			this.m_MonoEnv = new Utf8String();
			this.m_Psp2Splashimage = new PPtr_Texture2D_5_0_0();
			this.m_Psp2NPTrophyPackPath = new Utf8String();
			this.m_Psp2NPTitleDatPath = new Utf8String();
			this.m_Psp2NPCommsID = new Utf8String();
			this.m_Psp2NPCommunicationsID = new Utf8String();
			this.m_Psp2NPCommsPassphrase = new Utf8String();
			this.m_Psp2NPCommsSig = new Utf8String();
			this.m_Psp2ParamSfxPath = new Utf8String();
			this.m_Psp2ManualPath = new Utf8String();
			this.m_Psp2LiveAreaGatePath = new Utf8String();
			this.m_Psp2LiveAreaBackroundPath = new Utf8String();
			this.m_Psp2LiveAreaPath = new Utf8String();
			this.m_Psp2LiveAreaTrialPath = new Utf8String();
			this.m_Psp2PatchChangeInfoPath = new Utf8String();
			this.m_Psp2PatchOriginalPackage = new Utf8String();
			this.m_Psp2PackagePassword = new Utf8String();
			this.m_Psp2KeystoneFile = new Utf8String();
			this.m_Psp2DLCConfigPath = new Utf8String();
			this.m_Psp2ThumbnailPath = new Utf8String();
			this.m_Psp2BackgroundPath = new Utf8String();
			this.m_Psp2SoundPath = new Utf8String();
			this.m_Psp2TrophyCommId = new Utf8String();
			this.m_Psp2TrophyPackagePath = new Utf8String();
			this.m_Psp2PackagedResourcesPath = new Utf8String();
			this.m_Psp2ShortTitle = new Utf8String();
			this.m_Psp2ContentID = new Utf8String();
			this.m_Psp2MasterVersion = new Utf8String();
			this.m_Psp2AppVersion = new Utf8String();
			this.m_PsmSplashimage = new PPtr_Texture2D_5_0_0();
			this.m_SplashScreenBackgroundSourceLandscape = new PPtr_Sprite_5_0_0();
			this.m_SplashScreenBackgroundSourcePortrait = new PPtr_Sprite_5_0_0();
			this.m_SpritePackerPolicy = new Utf8String();
			this.m_WebGLEmscriptenArgs = new Utf8String();
			this.m_WebGLModulesDirectory = new Utf8String();
			this.m_WebGLTemplate = new Utf8String();
			this.m_ScriptingDefineSymbols = new AssetDictionary<int, Utf8String>();
			this.m_PlatformArchitecture = new AssetDictionary<Utf8String, int>();
			this.m_ScriptingBackend = new AssetDictionary<Utf8String, int>();
			this.m_IncrementalIl2cppBuild = new AssetDictionary<Utf8String, bool>();
			this.m_AdditionalIl2CppArgs = new Utf8String();
			this.m_ApiCompatibilityLevelPerPlatform = new AssetDictionary<Utf8String, int>();
			this.m_MetroPackageName = new Utf8String();
			this.m_MetroPackageVersion = new Utf8String();
			this.m_MetroCertificatePath = new Utf8String();
			this.m_MetroCertificatePassword = new Utf8String();
			this.m_MetroCertificateSubject = new Utf8String();
			this.m_MetroCertificateIssuer = new Utf8String();
			this.m_MetroApplicationDescription = new Utf8String();
			this.m_WsaImages = new AssetDictionary<int, Utf8String>();
			this.m_MetroTileShortName = new Utf8String();
			this.m_MetroCommandLineArgsFile = new Utf8String();
			this.m_MetroTileBackgroundColor = new ColorRGBAf_3_5_0();
			this.m_MetroSplashScreenBackgroundColor = new ColorRGBAf_3_5_0();
			this.m_PlatformCapabilities = new AssetDictionary<Utf8String, AssetDictionary<Utf8String, Utf8String>>();
			this.m_MetroFTAName = new Utf8String();
			this.m_MetroFTAFileTypes = new AssetList<MetroFTAFileType>();
			this.m_MetroProtocolName = new Utf8String();
			this.m_TizenProductDescription = new Utf8String();
			this.m_TizenProductURL = new Utf8String();
			this.m_TizenSigningProfileName = new Utf8String();
			this.m_TizenDeploymentTarget = new Utf8String();
			this.m_N3dsExtSaveDataNumber = new Utf8String();
			this.m_N3dsTitle = new Utf8String();
			this.m_N3dsProductCode = new Utf8String();
			this.m_N3dsApplicationId = new Utf8String();
			this.m_StvDeviceAddress = new Utf8String();
			this.m_StvProductDescription = new Utf8String();
			this.m_StvProductAuthor = new Utf8String();
			this.m_StvProductAuthorEmail = new Utf8String();
			this.m_StvProductLink = new Utf8String();
			this.m_XboxOneProductId = new Utf8String();
			this.m_XboxOneUpdateKey = new Utf8String();
			this.m_XboxOneSandboxId = new Utf8String();
			this.m_XboxOneContentId = new Utf8String();
			this.m_XboxOneTitleId = new Utf8String();
			this.m_XboxOneSCId = new Utf8String();
			this.m_XboxOneGameOsOverridePath = new Utf8String();
			this.m_XboxOnePackagingOverridePath = new Utf8String();
			this.m_XboxOneAppManifestOverridePath = new Utf8String();
			this.m_XboxOneDescription = new Utf8String();
			this.m_XboxOneLanguage = new AssetList<Utf8String>();
			this.m_XboxOneCapability = new AssetList<Utf8String>();
			this.m_XboxOneGameRating = new AssetDictionary<Utf8String, int>();
			this.m_XboxOneSockets = new AssetDictionary<Utf8String, XboxOneSocketDefinition_2017_1_0>();
			this.m_XboxOneSplashScreen = new PPtr_Texture2D_5_0_0();
			this.m_XboxOneAllowedProductIds = new AssetList<Utf8String>();
			this.m_VrEditorSettings = new VREditorSettings_5_6_0();
			this.m_CloudServicesEnabled = new AssetDictionary<Utf8String, bool>();
			this.m_FacebookSdkVersion = new Utf8String();
			this.m_ProductGUID = new GUID();
			this.m_CompanyName = new Utf8String();
			this.m_ProductName = new Utf8String();
			this.m_DefaultCursor = new PPtr_Texture2D_5_0_0();
			this.m_CursorHotspot = new Vector2f_3_5_0();
			this.m_SplashScreenBackgroundColor = new ColorRGBAf_3_5_0();
			this.m_SplashScreenBackgroundLandscapeUvs = new Rectf();
			this.m_SplashScreenBackgroundPortraitUvs = new Rectf();
			this.m_SplashScreenLogos = new AssetList<SplashScreenLogo>();
			this.m_SplashScreenBackgroundLandscape = new PPtr_Texture2D_5_0_0();
			this.m_SplashScreenBackgroundPortrait = new PPtr_Texture2D_5_0_0();
			this.m_VirtualRealitySplashScreen = new PPtr_Texture2D_5_0_0();
			this.m_HolographicTrackingLossScreen = new PPtr_Texture2D_5_0_0();
			this.m_StackTraceTypes = Array.Empty<int>();
			this.m_MacAppStoreCategory = new Utf8String();
			this.m_SupportedAspectRatios = new AspectRatios();
			this.m_BundleVersion = new Utf8String();
			this.m_PreloadedAssets = new AssetList<PPtr_Object_5_0_0>();
			this.m_VrSettings = new VRSettings_5_6_0_b3();
			this.m_CloudProjectId = new Utf8String();
			this.m_ProjectName = new Utf8String();
			this.m_OrganizationId = new Utf8String();
			// GICB2
			this.m_ShaderCollectProductName = new Utf8String();
			this.m_ShaderCollectServer = new Utf8String();
		}

		// Token: 0x06050FBC RID: 331708 RVA: 0x00A7C970 File Offset: 0x00A7AB70
		public override void ReadRelease(AssetReader reader)
		{
			this.m_ProductGUID.ReadRelease(reader);
			this.m_AndroidProfiler = reader.ReadRelease_BooleanAlign();
			this.m_DefaultScreenOrientation = reader.ReadInt32();
			this.m_TargetDevice = reader.ReadInt32();
			this.m_UseOnDemandResources = reader.ReadRelease_BooleanAlign();
			this.m_AccelerometerFrequency = reader.ReadRelease_Int32Align();
			this.m_CompanyName.ReadRelease(reader);
			this.m_ProductName.ReadRelease(reader);
			this.m_DefaultCursor.ReadRelease(reader);
			this.m_CursorHotspot.ReadRelease(reader);
			this.m_SplashScreenBackgroundColor.ReadRelease(reader);
			this.m_ShowUnitySplashScreen = reader.ReadBoolean();
			this.m_ShowUnitySplashLogo = reader.ReadRelease_BooleanAlign();
			this.m_SplashScreenOverlayOpacity = reader.ReadSingle();
			this.m_SplashScreenAnimation = reader.ReadInt32();
			this.m_SplashScreenLogoStyle = reader.ReadInt32();
			this.m_SplashScreenDrawMode = reader.ReadRelease_Int32Align();
			this.m_SplashScreenBackgroundAnimationZoom = reader.ReadSingle();
			this.m_SplashScreenLogoAnimationZoom = reader.ReadSingle();
			this.m_SplashScreenBackgroundLandscapeAspect = reader.ReadSingle();
			this.m_SplashScreenBackgroundPortraitAspect = reader.ReadSingle();
			this.m_SplashScreenBackgroundLandscapeUvs.ReadRelease(reader);
			this.m_SplashScreenBackgroundPortraitUvs.ReadRelease(reader);
			this.m_SplashScreenLogos.ReadRelease_ArrayAlign_Asset(reader);
			this.m_SplashScreenBackgroundLandscape.ReadRelease(reader);
			this.m_SplashScreenBackgroundPortrait.ReadRelease(reader);
			this.m_VirtualRealitySplashScreen.ReadRelease(reader);
			this.m_HolographicTrackingLossScreen.ReadRelease(reader);
			this.m_DefaultScreenWidth = reader.ReadInt32();
			this.m_DefaultScreenHeight = reader.ReadInt32();
			this.m_DefaultScreenWidthWeb = reader.ReadInt32();
			this.m_DefaultScreenHeightWeb = reader.ReadInt32();
			this.m_StereoRenderingPath = reader.ReadInt32();
			this.m_ActiveColorSpace = reader.ReadInt32();
			this.m_MTRendering = reader.ReadBoolean();
			this.m_MobileMTRendering = reader.ReadRelease_BooleanAlign();
			this.m_StackTraceTypes = reader.ReadRelease_ArrayAlign_Int32();
			this.m_IosShowActivityIndicatorOnLoading = reader.ReadInt32();
			this.m_AndroidShowActivityIndicatorOnLoading = reader.ReadInt32();
			this.m_TizenShowActivityIndicatorOnLoading = reader.ReadInt32();
			this.m_IosAppInBackgroundBehavior = reader.ReadInt32();
			this.m_DisplayResolutionDialog = reader.ReadInt32();
			this.m_IosAllowHTTPDownload = reader.ReadBoolean();
			this.m_AllowedAutorotateToPortrait = reader.ReadBoolean();
			this.m_AllowedAutorotateToPortraitUpsideDown = reader.ReadBoolean();
			this.m_AllowedAutorotateToLandscapeRight = reader.ReadBoolean();
			this.m_AllowedAutorotateToLandscapeLeft = reader.ReadBoolean();
			this.m_UseOSAutorotation = reader.ReadBoolean();
			this.m_Use32BitDisplayBuffer = reader.ReadBoolean();
			this.m_DisableDepthAndStencilBuffers = reader.ReadRelease_BooleanAlign();
			this.m_DefaultIsFullScreen = reader.ReadBoolean();
			this.m_DefaultIsNativeResolution = reader.ReadBoolean();
			this.m_RunInBackground = reader.ReadBoolean();
			this.m_CaptureSingleScreen = reader.ReadBoolean();
			this.m_MuteOtherAudioSources = reader.ReadBoolean();
			this.m_Prepare_IOS_For_Recording = reader.ReadBoolean();
			this.m_Force_IOS_Speakers_When_Recording = reader.ReadBoolean();
			this.m_SubmitAnalytics = reader.ReadBoolean();
			this.m_UsePlayerLog = reader.ReadBoolean();
			this.m_BakeCollisionMeshes = reader.ReadBoolean();
			this.m_ForceSingleInstance = reader.ReadBoolean();
			this.m_ResizableWindow = reader.ReadBoolean();
			this.m_UseMacAppStoreValidation = reader.ReadRelease_BooleanAlign();
			this.m_MacAppStoreCategory.ReadRelease(reader);
			this.m_GpuSkinning = reader.ReadBoolean();
			this.m_GraphicsJobs = reader.ReadBoolean();
			this.m_XboxPIXTextureCapture = reader.ReadBoolean();
			this.m_XboxEnableAvatar = reader.ReadBoolean();
			this.m_XboxEnableKinect = reader.ReadBoolean();
			this.m_XboxEnableKinectAutoTracking = reader.ReadBoolean();
			this.m_XboxEnableFitness = reader.ReadBoolean();
			this.m_VisibleInBackground = reader.ReadBoolean();
			this.m_AllowFullscreenSwitch = reader.ReadRelease_BooleanAlign();
			this.m_GraphicsJobMode = reader.ReadInt32();
			this.m_MacFullscreenMode = reader.ReadInt32();
			this.m_D3d9FullscreenMode = reader.ReadInt32();
			this.m_D3d11FullscreenMode = reader.ReadRelease_Int32Align();
			this.m_XboxSpeechDB = reader.ReadUInt32();
			this.m_XboxEnableHeadOrientation = reader.ReadRelease_BooleanAlign();
			this.m_XboxEnableGuest = reader.ReadRelease_BooleanAlign();
			this.m_XboxEnablePIXSampling = reader.ReadRelease_BooleanAlign();
			this.m_N3dsDisableStereoscopicView = reader.ReadBoolean();
			this.m_N3dsEnableSharedListOpt = reader.ReadBoolean();
			this.m_N3dsEnableVSync = reader.ReadBoolean();
			this.m_IgnoreAlphaClear = reader.ReadRelease_BooleanAlign();
			this.m_XboxOneResolution = reader.ReadInt32();
			this.m_XboxOneMonoLoggingLevel = reader.ReadInt32();
			this.m_XboxOneLoggingLevel = reader.ReadInt32();
			this.m_XboxOneDisableEsram = reader.ReadRelease_BooleanAlign();
			this.m_VideoMemoryForVertexBuffers = reader.ReadInt32();
			this.m_Psp2PowerMode = reader.ReadInt32();
			this.m_Psp2AcquireBGM = reader.ReadRelease_BooleanAlign();
			this.m_WiiUTVResolution = reader.ReadInt32();
			this.m_WiiUGamePadMSAA = reader.ReadInt32();
			this.m_WiiUSupportsNunchuk = reader.ReadBoolean();
			this.m_WiiUSupportsClassicController = reader.ReadBoolean();
			this.m_WiiUSupportsBalanceBoard = reader.ReadBoolean();
			this.m_WiiUSupportsMotionPlus = reader.ReadBoolean();
			this.m_WiiUSupportsProController = reader.ReadBoolean();
			this.m_WiiUAllowScreenCapture = reader.ReadRelease_BooleanAlign();
			this.m_WiiUControllerCount = reader.ReadInt32();
			this.m_SupportedAspectRatios.ReadRelease(reader);
			this.m_BundleVersion.ReadRelease(reader);
			this.m_PreloadedAssets.ReadRelease_ArrayAlign_Asset(reader);
			this.m_MetroInputSource = reader.ReadInt32();
			this.m_HolographicPauseOnTrackingLoss = reader.ReadBoolean();
			this.m_XboxOneDisableKinectGpuReservation = reader.ReadBoolean();
			this.m_XboxOneEnable7thCore = reader.ReadRelease_BooleanAlign();
			this.m_VrSettings.ReadRelease_AssetAlign(reader);
			this.m_ProtectGraphicsMemory = reader.ReadRelease_BooleanAlign();
			this.m_UseHDRDisplay = reader.ReadRelease_BooleanAlign();
			this.m_TargetPixelDensity = reader.ReadInt32();
			this.m_ResolutionScalingMode = reader.ReadRelease_Int32Align();
			this.m_CloudProjectId.ReadRelease(reader);
			this.m_ProjectName.ReadRelease(reader);
			this.m_OrganizationId.ReadRelease(reader);
			this.m_CloudEnabled = reader.ReadBoolean();
			this.m_EnableNativePlatformBackendsForNewInputSystem = reader.ReadBoolean();
			this.m_DisableOldInputManagerSupport = reader.ReadBoolean();
			// GICB2
			reader.AlignStream();
			this.m_ShaderCollectProductName.ReadRelease(reader);
			this.m_ShaderCollectServer.ReadRelease(reader);
		}

		// Token: 0x06050FBD RID: 331709 RVA: 0x00A7CF14 File Offset: 0x00A7B114

		// Token: 0x06050FBE RID: 331710 RVA: 0x00A7E904 File Offset: 0x00A7CB04
		public override void WriteRelease(AssetWriter writer)
		{
			this.m_ProductGUID.WriteRelease(writer);
			this.m_AndroidProfiler.WriteRelease_BooleanAlign(writer);
			this.m_DefaultScreenOrientation.WriteRelease_Int32(writer);
			this.m_TargetDevice.WriteRelease_Int32(writer);
			this.m_UseOnDemandResources.WriteRelease_BooleanAlign(writer);
			this.m_AccelerometerFrequency.WriteRelease_Int32Align(writer);
			this.m_CompanyName.WriteRelease(writer);
			this.m_ProductName.WriteRelease(writer);
			this.m_DefaultCursor.WriteRelease(writer);
			this.m_CursorHotspot.WriteRelease(writer);
			this.m_SplashScreenBackgroundColor.WriteRelease(writer);
			this.m_ShowUnitySplashScreen.WriteRelease_Boolean(writer);
			this.m_ShowUnitySplashLogo.WriteRelease_BooleanAlign(writer);
			this.m_SplashScreenOverlayOpacity.WriteRelease_Single(writer);
			this.m_SplashScreenAnimation.WriteRelease_Int32(writer);
			this.m_SplashScreenLogoStyle.WriteRelease_Int32(writer);
			this.m_SplashScreenDrawMode.WriteRelease_Int32Align(writer);
			this.m_SplashScreenBackgroundAnimationZoom.WriteRelease_Single(writer);
			this.m_SplashScreenLogoAnimationZoom.WriteRelease_Single(writer);
			this.m_SplashScreenBackgroundLandscapeAspect.WriteRelease_Single(writer);
			this.m_SplashScreenBackgroundPortraitAspect.WriteRelease_Single(writer);
			this.m_SplashScreenBackgroundLandscapeUvs.WriteRelease(writer);
			this.m_SplashScreenBackgroundPortraitUvs.WriteRelease(writer);
			this.m_SplashScreenLogos.WriteRelease_ArrayAlign_Asset(writer);
			this.m_SplashScreenBackgroundLandscape.WriteRelease(writer);
			this.m_SplashScreenBackgroundPortrait.WriteRelease(writer);
			this.m_VirtualRealitySplashScreen.WriteRelease(writer);
			this.m_HolographicTrackingLossScreen.WriteRelease(writer);
			this.m_DefaultScreenWidth.WriteRelease_Int32(writer);
			this.m_DefaultScreenHeight.WriteRelease_Int32(writer);
			this.m_DefaultScreenWidthWeb.WriteRelease_Int32(writer);
			this.m_DefaultScreenHeightWeb.WriteRelease_Int32(writer);
			this.m_StereoRenderingPath.WriteRelease_Int32(writer);
			this.m_ActiveColorSpace.WriteRelease_Int32(writer);
			this.m_MTRendering.WriteRelease_Boolean(writer);
			this.m_MobileMTRendering.WriteRelease_BooleanAlign(writer);
			this.m_StackTraceTypes.WriteRelease_ArrayAlign_Int32(writer);
			this.m_IosShowActivityIndicatorOnLoading.WriteRelease_Int32(writer);
			this.m_AndroidShowActivityIndicatorOnLoading.WriteRelease_Int32(writer);
			this.m_TizenShowActivityIndicatorOnLoading.WriteRelease_Int32(writer);
			this.m_IosAppInBackgroundBehavior.WriteRelease_Int32(writer);
			this.m_DisplayResolutionDialog.WriteRelease_Int32(writer);
			this.m_IosAllowHTTPDownload.WriteRelease_Boolean(writer);
			this.m_AllowedAutorotateToPortrait.WriteRelease_Boolean(writer);
			this.m_AllowedAutorotateToPortraitUpsideDown.WriteRelease_Boolean(writer);
			this.m_AllowedAutorotateToLandscapeRight.WriteRelease_Boolean(writer);
			this.m_AllowedAutorotateToLandscapeLeft.WriteRelease_Boolean(writer);
			this.m_UseOSAutorotation.WriteRelease_Boolean(writer);
			this.m_Use32BitDisplayBuffer.WriteRelease_Boolean(writer);
			this.m_DisableDepthAndStencilBuffers.WriteRelease_BooleanAlign(writer);
			this.m_DefaultIsFullScreen.WriteRelease_Boolean(writer);
			this.m_DefaultIsNativeResolution.WriteRelease_Boolean(writer);
			this.m_RunInBackground.WriteRelease_Boolean(writer);
			this.m_CaptureSingleScreen.WriteRelease_Boolean(writer);
			this.m_MuteOtherAudioSources.WriteRelease_Boolean(writer);
			this.m_Prepare_IOS_For_Recording.WriteRelease_Boolean(writer);
			this.m_Force_IOS_Speakers_When_Recording.WriteRelease_Boolean(writer);
			this.m_SubmitAnalytics.WriteRelease_Boolean(writer);
			this.m_UsePlayerLog.WriteRelease_Boolean(writer);
			this.m_BakeCollisionMeshes.WriteRelease_Boolean(writer);
			this.m_ForceSingleInstance.WriteRelease_Boolean(writer);
			this.m_ResizableWindow.WriteRelease_Boolean(writer);
			this.m_UseMacAppStoreValidation.WriteRelease_BooleanAlign(writer);
			this.m_MacAppStoreCategory.WriteRelease(writer);
			this.m_GpuSkinning.WriteRelease_Boolean(writer);
			this.m_GraphicsJobs.WriteRelease_Boolean(writer);
			this.m_XboxPIXTextureCapture.WriteRelease_Boolean(writer);
			this.m_XboxEnableAvatar.WriteRelease_Boolean(writer);
			this.m_XboxEnableKinect.WriteRelease_Boolean(writer);
			this.m_XboxEnableKinectAutoTracking.WriteRelease_Boolean(writer);
			this.m_XboxEnableFitness.WriteRelease_Boolean(writer);
			this.m_VisibleInBackground.WriteRelease_Boolean(writer);
			this.m_AllowFullscreenSwitch.WriteRelease_BooleanAlign(writer);
			this.m_GraphicsJobMode.WriteRelease_Int32(writer);
			this.m_MacFullscreenMode.WriteRelease_Int32(writer);
			this.m_D3d9FullscreenMode.WriteRelease_Int32(writer);
			this.m_D3d11FullscreenMode.WriteRelease_Int32Align(writer);
			this.m_XboxSpeechDB.WriteRelease_UInt32(writer);
			this.m_XboxEnableHeadOrientation.WriteRelease_BooleanAlign(writer);
			this.m_XboxEnableGuest.WriteRelease_BooleanAlign(writer);
			this.m_XboxEnablePIXSampling.WriteRelease_BooleanAlign(writer);
			this.m_N3dsDisableStereoscopicView.WriteRelease_Boolean(writer);
			this.m_N3dsEnableSharedListOpt.WriteRelease_Boolean(writer);
			this.m_N3dsEnableVSync.WriteRelease_Boolean(writer);
			this.m_IgnoreAlphaClear.WriteRelease_BooleanAlign(writer);
			this.m_XboxOneResolution.WriteRelease_Int32(writer);
			this.m_XboxOneMonoLoggingLevel.WriteRelease_Int32(writer);
			this.m_XboxOneLoggingLevel.WriteRelease_Int32(writer);
			this.m_XboxOneDisableEsram.WriteRelease_BooleanAlign(writer);
			this.m_VideoMemoryForVertexBuffers.WriteRelease_Int32(writer);
			this.m_Psp2PowerMode.WriteRelease_Int32(writer);
			this.m_Psp2AcquireBGM.WriteRelease_BooleanAlign(writer);
			this.m_WiiUTVResolution.WriteRelease_Int32(writer);
			this.m_WiiUGamePadMSAA.WriteRelease_Int32(writer);
			this.m_WiiUSupportsNunchuk.WriteRelease_Boolean(writer);
			this.m_WiiUSupportsClassicController.WriteRelease_Boolean(writer);
			this.m_WiiUSupportsBalanceBoard.WriteRelease_Boolean(writer);
			this.m_WiiUSupportsMotionPlus.WriteRelease_Boolean(writer);
			this.m_WiiUSupportsProController.WriteRelease_Boolean(writer);
			this.m_WiiUAllowScreenCapture.WriteRelease_BooleanAlign(writer);
			this.m_WiiUControllerCount.WriteRelease_Int32(writer);
			this.m_SupportedAspectRatios.WriteRelease(writer);
			this.m_BundleVersion.WriteRelease(writer);
			this.m_PreloadedAssets.WriteRelease_ArrayAlign_Asset(writer);
			this.m_MetroInputSource.WriteRelease_Int32(writer);
			this.m_HolographicPauseOnTrackingLoss.WriteRelease_Boolean(writer);
			this.m_XboxOneDisableKinectGpuReservation.WriteRelease_Boolean(writer);
			this.m_XboxOneEnable7thCore.WriteRelease_BooleanAlign(writer);
			this.m_VrSettings.WriteRelease_AssetAlign(writer);
			this.m_ProtectGraphicsMemory.WriteRelease_BooleanAlign(writer);
			this.m_UseHDRDisplay.WriteRelease_BooleanAlign(writer);
			this.m_TargetPixelDensity.WriteRelease_Int32(writer);
			this.m_ResolutionScalingMode.WriteRelease_Int32Align(writer);
			this.m_CloudProjectId.WriteRelease(writer);
			this.m_ProjectName.WriteRelease(writer);
			this.m_OrganizationId.WriteRelease(writer);
			this.m_CloudEnabled.WriteRelease_Boolean(writer);
			this.m_EnableNativePlatformBackendsForNewInputSystem.WriteRelease_Boolean(writer);
			this.m_DisableOldInputManagerSupport.WriteRelease_Boolean(writer);
		}

		// Token: 0x06050FBF RID: 331711 RVA: 0x00A7EEA8 File Offset: 0x00A7D0A8

		// Token: 0x06050FC0 RID: 331712 RVA: 0x00A80898 File Offset: 0x00A7EA98
		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 12);
			yamlMappingNode.Add(new YamlScalarNode("productGUID"), this.m_ProductGUID.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("AndroidProfiler"), this.m_AndroidProfiler.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("defaultScreenOrientation"), this.m_DefaultScreenOrientation.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("targetDevice"), this.m_TargetDevice.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("useOnDemandResources"), this.m_UseOnDemandResources.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("accelerometerFrequency"), this.m_AccelerometerFrequency.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("companyName"), this.m_CompanyName.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("productName"), this.m_ProductName.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("defaultCursor"), this.m_DefaultCursor.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("cursorHotspot"), this.m_CursorHotspot.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SplashScreenBackgroundColor"), this.m_SplashScreenBackgroundColor.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ShowUnitySplashScreen"), this.m_ShowUnitySplashScreen.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ShowUnitySplashLogo"), this.m_ShowUnitySplashLogo.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SplashScreenOverlayOpacity"), this.m_SplashScreenOverlayOpacity.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SplashScreenAnimation"), this.m_SplashScreenAnimation.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SplashScreenLogoStyle"), this.m_SplashScreenLogoStyle.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SplashScreenDrawMode"), this.m_SplashScreenDrawMode.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SplashScreenBackgroundAnimationZoom"), this.m_SplashScreenBackgroundAnimationZoom.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SplashScreenLogoAnimationZoom"), this.m_SplashScreenLogoAnimationZoom.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SplashScreenBackgroundLandscapeAspect"), this.m_SplashScreenBackgroundLandscapeAspect.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SplashScreenBackgroundPortraitAspect"), this.m_SplashScreenBackgroundPortraitAspect.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SplashScreenBackgroundLandscapeUvs"), this.m_SplashScreenBackgroundLandscapeUvs.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SplashScreenBackgroundPortraitUvs"), this.m_SplashScreenBackgroundPortraitUvs.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SplashScreenLogos"), this.m_SplashScreenLogos.ExportYamlRelease_Array_SplashScreenLogo(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SplashScreenBackgroundLandscape"), this.m_SplashScreenBackgroundLandscape.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SplashScreenBackgroundPortrait"), this.m_SplashScreenBackgroundPortrait.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_VirtualRealitySplashScreen"), this.m_VirtualRealitySplashScreen.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_HolographicTrackingLossScreen"), this.m_HolographicTrackingLossScreen.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("defaultScreenWidth"), this.m_DefaultScreenWidth.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("defaultScreenHeight"), this.m_DefaultScreenHeight.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("defaultScreenWidthWeb"), this.m_DefaultScreenWidthWeb.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("defaultScreenHeightWeb"), this.m_DefaultScreenHeightWeb.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_StereoRenderingPath"), this.m_StereoRenderingPath.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ActiveColorSpace"), this.m_ActiveColorSpace.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MTRendering"), this.m_MTRendering.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MobileMTRendering"), this.m_MobileMTRendering.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_StackTraceTypes"), this.m_StackTraceTypes.ExportYamlRelease_Array_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("iosShowActivityIndicatorOnLoading"), this.m_IosShowActivityIndicatorOnLoading.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("androidShowActivityIndicatorOnLoading"), this.m_AndroidShowActivityIndicatorOnLoading.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("tizenShowActivityIndicatorOnLoading"), this.m_TizenShowActivityIndicatorOnLoading.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("iosAppInBackgroundBehavior"), this.m_IosAppInBackgroundBehavior.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("displayResolutionDialog"), this.m_DisplayResolutionDialog.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("iosAllowHTTPDownload"), this.m_IosAllowHTTPDownload.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("allowedAutorotateToPortrait"), this.m_AllowedAutorotateToPortrait.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("allowedAutorotateToPortraitUpsideDown"), this.m_AllowedAutorotateToPortraitUpsideDown.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("allowedAutorotateToLandscapeRight"), this.m_AllowedAutorotateToLandscapeRight.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("allowedAutorotateToLandscapeLeft"), this.m_AllowedAutorotateToLandscapeLeft.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("useOSAutorotation"), this.m_UseOSAutorotation.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("use32BitDisplayBuffer"), this.m_Use32BitDisplayBuffer.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("disableDepthAndStencilBuffers"), this.m_DisableDepthAndStencilBuffers.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("defaultIsFullScreen"), this.m_DefaultIsFullScreen.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("defaultIsNativeResolution"), this.m_DefaultIsNativeResolution.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("runInBackground"), this.m_RunInBackground.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("captureSingleScreen"), this.m_CaptureSingleScreen.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("muteOtherAudioSources"), this.m_MuteOtherAudioSources.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("Prepare IOS For Recording"), this.m_Prepare_IOS_For_Recording.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("Force IOS Speakers When Recording"), this.m_Force_IOS_Speakers_When_Recording.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("submitAnalytics"), this.m_SubmitAnalytics.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("usePlayerLog"), this.m_UsePlayerLog.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("bakeCollisionMeshes"), this.m_BakeCollisionMeshes.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("forceSingleInstance"), this.m_ForceSingleInstance.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("resizableWindow"), this.m_ResizableWindow.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("useMacAppStoreValidation"), this.m_UseMacAppStoreValidation.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("macAppStoreCategory"), this.m_MacAppStoreCategory.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("gpuSkinning"), this.m_GpuSkinning.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("graphicsJobs"), this.m_GraphicsJobs.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("xboxPIXTextureCapture"), this.m_XboxPIXTextureCapture.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("xboxEnableAvatar"), this.m_XboxEnableAvatar.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("xboxEnableKinect"), this.m_XboxEnableKinect.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("xboxEnableKinectAutoTracking"), this.m_XboxEnableKinectAutoTracking.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("xboxEnableFitness"), this.m_XboxEnableFitness.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("visibleInBackground"), this.m_VisibleInBackground.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("allowFullscreenSwitch"), this.m_AllowFullscreenSwitch.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("graphicsJobMode"), this.m_GraphicsJobMode.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("macFullscreenMode"), this.m_MacFullscreenMode.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("d3d9FullscreenMode"), this.m_D3d9FullscreenMode.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("d3d11FullscreenMode"), this.m_D3d11FullscreenMode.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("xboxSpeechDB"), this.m_XboxSpeechDB.ExportYamlRelease_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("xboxEnableHeadOrientation"), this.m_XboxEnableHeadOrientation.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("xboxEnableGuest"), this.m_XboxEnableGuest.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("xboxEnablePIXSampling"), this.m_XboxEnablePIXSampling.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("n3dsDisableStereoscopicView"), this.m_N3dsDisableStereoscopicView.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("n3dsEnableSharedListOpt"), this.m_N3dsEnableSharedListOpt.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("n3dsEnableVSync"), this.m_N3dsEnableVSync.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("ignoreAlphaClear"), this.m_IgnoreAlphaClear.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("xboxOneResolution"), this.m_XboxOneResolution.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("xboxOneMonoLoggingLevel"), this.m_XboxOneMonoLoggingLevel.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("xboxOneLoggingLevel"), this.m_XboxOneLoggingLevel.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("xboxOneDisableEsram"), this.m_XboxOneDisableEsram.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("videoMemoryForVertexBuffers"), this.m_VideoMemoryForVertexBuffers.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2PowerMode"), this.m_Psp2PowerMode.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2AcquireBGM"), this.m_Psp2AcquireBGM.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUTVResolution"), this.m_WiiUTVResolution.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUGamePadMSAA"), this.m_WiiUGamePadMSAA.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUSupportsNunchuk"), this.m_WiiUSupportsNunchuk.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUSupportsClassicController"), this.m_WiiUSupportsClassicController.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUSupportsBalanceBoard"), this.m_WiiUSupportsBalanceBoard.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUSupportsMotionPlus"), this.m_WiiUSupportsMotionPlus.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUSupportsProController"), this.m_WiiUSupportsProController.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUAllowScreenCapture"), this.m_WiiUAllowScreenCapture.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUControllerCount"), this.m_WiiUControllerCount.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SupportedAspectRatios"), this.m_SupportedAspectRatios.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("bundleVersion"), this.m_BundleVersion.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("preloadedAssets"), this.m_PreloadedAssets.ExportYamlRelease_Array_PPtr_Object_5_0_0(container));
			yamlMappingNode.Add(new YamlScalarNode("metroInputSource"), this.m_MetroInputSource.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_HolographicPauseOnTrackingLoss"), this.m_HolographicPauseOnTrackingLoss.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("xboxOneDisableKinectGpuReservation"), this.m_XboxOneDisableKinectGpuReservation.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("xboxOneEnable7thCore"), this.m_XboxOneEnable7thCore.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("vrSettings"), this.m_VrSettings.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("protectGraphicsMemory"), this.m_ProtectGraphicsMemory.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("useHDRDisplay"), this.m_UseHDRDisplay.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("targetPixelDensity"), this.m_TargetPixelDensity.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("resolutionScalingMode"), this.m_ResolutionScalingMode.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("cloudProjectId"), this.m_CloudProjectId.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("projectName"), this.m_ProjectName.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("organizationId"), this.m_OrganizationId.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("cloudEnabled"), this.m_CloudEnabled.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("enableNativePlatformBackendsForNewInputSystem"), this.m_EnableNativePlatformBackendsForNewInputSystem.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("disableOldInputManagerSupport"), this.m_DisableOldInputManagerSupport.ExportYamlRelease_Boolean(container));
			return yamlMappingNode;
		}

		// Token: 0x06050FC1 RID: 331713 RVA: 0x00A815B8 File Offset: 0x00A7F7B8
		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 12);
			yamlMappingNode.Add(new YamlScalarNode("m_ObjectHideFlags"), this.m_HideFlags.ExportYamlEditor_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("productGUID"), this.m_ProductGUID.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("AndroidProfiler"), this.m_AndroidProfiler.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("defaultScreenOrientation"), this.m_DefaultScreenOrientation.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("targetDevice"), this.m_TargetDevice.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("useOnDemandResources"), this.m_UseOnDemandResources.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("accelerometerFrequency"), this.m_AccelerometerFrequency.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("companyName"), this.m_CompanyName.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("productName"), this.m_ProductName.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("defaultCursor"), this.m_DefaultCursor.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("cursorHotspot"), this.m_CursorHotspot.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SplashScreenBackgroundColor"), this.m_SplashScreenBackgroundColor.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ShowUnitySplashScreen"), this.m_ShowUnitySplashScreen.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ShowUnitySplashLogo"), this.m_ShowUnitySplashLogo.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SplashScreenOverlayOpacity"), this.m_SplashScreenOverlayOpacity.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SplashScreenAnimation"), this.m_SplashScreenAnimation.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SplashScreenLogoStyle"), this.m_SplashScreenLogoStyle.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SplashScreenDrawMode"), this.m_SplashScreenDrawMode.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SplashScreenBackgroundAnimationZoom"), this.m_SplashScreenBackgroundAnimationZoom.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SplashScreenLogoAnimationZoom"), this.m_SplashScreenLogoAnimationZoom.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SplashScreenBackgroundLandscapeAspect"), this.m_SplashScreenBackgroundLandscapeAspect.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SplashScreenBackgroundPortraitAspect"), this.m_SplashScreenBackgroundPortraitAspect.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SplashScreenBackgroundLandscapeUvs"), this.m_SplashScreenBackgroundLandscapeUvs.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SplashScreenBackgroundPortraitUvs"), this.m_SplashScreenBackgroundPortraitUvs.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SplashScreenLogos"), this.m_SplashScreenLogos.ExportYamlEditor_Array_SplashScreenLogo(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SplashScreenBackgroundLandscape"), this.m_SplashScreenBackgroundLandscape.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SplashScreenBackgroundPortrait"), this.m_SplashScreenBackgroundPortrait.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_VirtualRealitySplashScreen"), this.m_VirtualRealitySplashScreen.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_HolographicTrackingLossScreen"), this.m_HolographicTrackingLossScreen.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("defaultScreenWidth"), this.m_DefaultScreenWidth.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("defaultScreenHeight"), this.m_DefaultScreenHeight.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("defaultScreenWidthWeb"), this.m_DefaultScreenWidthWeb.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("defaultScreenHeightWeb"), this.m_DefaultScreenHeightWeb.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_StereoRenderingPath"), this.m_StereoRenderingPath.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ActiveColorSpace"), this.m_ActiveColorSpace.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MTRendering"), this.m_MTRendering.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MobileMTRendering"), this.m_MobileMTRendering.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_StackTraceTypes"), this.m_StackTraceTypes.ExportYamlEditor_Array_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("iosShowActivityIndicatorOnLoading"), this.m_IosShowActivityIndicatorOnLoading.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("androidShowActivityIndicatorOnLoading"), this.m_AndroidShowActivityIndicatorOnLoading.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("tizenShowActivityIndicatorOnLoading"), this.m_TizenShowActivityIndicatorOnLoading.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("iosAppInBackgroundBehavior"), this.m_IosAppInBackgroundBehavior.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("displayResolutionDialog"), this.m_DisplayResolutionDialog.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("iosAllowHTTPDownload"), this.m_IosAllowHTTPDownload.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("allowedAutorotateToPortrait"), this.m_AllowedAutorotateToPortrait.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("allowedAutorotateToPortraitUpsideDown"), this.m_AllowedAutorotateToPortraitUpsideDown.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("allowedAutorotateToLandscapeRight"), this.m_AllowedAutorotateToLandscapeRight.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("allowedAutorotateToLandscapeLeft"), this.m_AllowedAutorotateToLandscapeLeft.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("useOSAutorotation"), this.m_UseOSAutorotation.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("use32BitDisplayBuffer"), this.m_Use32BitDisplayBuffer.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("disableDepthAndStencilBuffers"), this.m_DisableDepthAndStencilBuffers.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("defaultIsFullScreen"), this.m_DefaultIsFullScreen.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("defaultIsNativeResolution"), this.m_DefaultIsNativeResolution.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("runInBackground"), this.m_RunInBackground.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("captureSingleScreen"), this.m_CaptureSingleScreen.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("muteOtherAudioSources"), this.m_MuteOtherAudioSources.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("Prepare IOS For Recording"), this.m_Prepare_IOS_For_Recording.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("Force IOS Speakers When Recording"), this.m_Force_IOS_Speakers_When_Recording.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("submitAnalytics"), this.m_SubmitAnalytics.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("usePlayerLog"), this.m_UsePlayerLog.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("bakeCollisionMeshes"), this.m_BakeCollisionMeshes.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("forceSingleInstance"), this.m_ForceSingleInstance.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("resizableWindow"), this.m_ResizableWindow.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("useMacAppStoreValidation"), this.m_UseMacAppStoreValidation.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("macAppStoreCategory"), this.m_MacAppStoreCategory.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("gpuSkinning"), this.m_GpuSkinning.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("graphicsJobs"), this.m_GraphicsJobs.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("xboxPIXTextureCapture"), this.m_XboxPIXTextureCapture.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("xboxEnableAvatar"), this.m_XboxEnableAvatar.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("xboxEnableKinect"), this.m_XboxEnableKinect.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("xboxEnableKinectAutoTracking"), this.m_XboxEnableKinectAutoTracking.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("xboxEnableFitness"), this.m_XboxEnableFitness.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("visibleInBackground"), this.m_VisibleInBackground.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("allowFullscreenSwitch"), this.m_AllowFullscreenSwitch.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("graphicsJobMode"), this.m_GraphicsJobMode.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("macFullscreenMode"), this.m_MacFullscreenMode.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("d3d9FullscreenMode"), this.m_D3d9FullscreenMode.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("d3d11FullscreenMode"), this.m_D3d11FullscreenMode.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("xboxSpeechDB"), this.m_XboxSpeechDB.ExportYamlEditor_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("xboxEnableHeadOrientation"), this.m_XboxEnableHeadOrientation.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("xboxEnableGuest"), this.m_XboxEnableGuest.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("xboxEnablePIXSampling"), this.m_XboxEnablePIXSampling.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("n3dsDisableStereoscopicView"), this.m_N3dsDisableStereoscopicView.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("n3dsEnableSharedListOpt"), this.m_N3dsEnableSharedListOpt.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("n3dsEnableVSync"), this.m_N3dsEnableVSync.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("ignoreAlphaClear"), this.m_IgnoreAlphaClear.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("xboxOneResolution"), this.m_XboxOneResolution.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("xboxOneMonoLoggingLevel"), this.m_XboxOneMonoLoggingLevel.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("xboxOneLoggingLevel"), this.m_XboxOneLoggingLevel.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("xboxOneDisableEsram"), this.m_XboxOneDisableEsram.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("videoMemoryForVertexBuffers"), this.m_VideoMemoryForVertexBuffers.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2PowerMode"), this.m_Psp2PowerMode.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2AcquireBGM"), this.m_Psp2AcquireBGM.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUTVResolution"), this.m_WiiUTVResolution.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUGamePadMSAA"), this.m_WiiUGamePadMSAA.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUSupportsNunchuk"), this.m_WiiUSupportsNunchuk.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUSupportsClassicController"), this.m_WiiUSupportsClassicController.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUSupportsBalanceBoard"), this.m_WiiUSupportsBalanceBoard.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUSupportsMotionPlus"), this.m_WiiUSupportsMotionPlus.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUSupportsProController"), this.m_WiiUSupportsProController.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUAllowScreenCapture"), this.m_WiiUAllowScreenCapture.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUControllerCount"), this.m_WiiUControllerCount.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SupportedAspectRatios"), this.m_SupportedAspectRatios.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("bundleVersion"), this.m_BundleVersion.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("preloadedAssets"), this.m_PreloadedAssets.ExportYamlEditor_Array_PPtr_Object_5_0_0(container));
			yamlMappingNode.Add(new YamlScalarNode("metroInputSource"), this.m_MetroInputSource.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_HolographicPauseOnTrackingLoss"), this.m_HolographicPauseOnTrackingLoss.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("xboxOneDisableKinectGpuReservation"), this.m_XboxOneDisableKinectGpuReservation.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("xboxOneEnable7thCore"), this.m_XboxOneEnable7thCore.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("vrSettings"), this.m_VrSettings.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("protectGraphicsMemory"), this.m_ProtectGraphicsMemory.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("useHDRDisplay"), this.m_UseHDRDisplay.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("targetPixelDensity"), this.m_TargetPixelDensity.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("resolutionScalingMode"), this.m_ResolutionScalingMode.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("applicationIdentifier"), this.m_ApplicationIdentifier.ExportYamlEditor_Map_Utf8String_Utf8String(container));
			yamlMappingNode.Add(new YamlScalarNode("buildNumber"), this.m_BuildNumber.ExportYamlEditor_Map_Utf8String_Utf8String(container));
			yamlMappingNode.Add(new YamlScalarNode("AndroidBundleVersionCode"), this.m_AndroidBundleVersionCode.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("AndroidMinSdkVersion"), this.m_AndroidMinSdkVersion.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("AndroidTargetSdkVersion"), this.m_AndroidTargetSdkVersion.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("AndroidPreferredInstallLocation"), this.m_AndroidPreferredInstallLocation.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("aotOptions"), this.m_AotOptions.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("stripEngineCode"), this.m_StripEngineCode.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("iPhoneStrippingLevel"), this.m_IPhoneStrippingLevel.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("iPhoneScriptCallOptimization"), this.m_IPhoneScriptCallOptimization.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("ForceInternetPermission"), this.m_ForceInternetPermission.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("ForceSDCardPermission"), this.m_ForceSDCardPermission.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("CreateWallpaper"), this.m_CreateWallpaper.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("APKExpansionFiles"), this.m_APKExpansionFiles.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("keepLoadedShadersAlive"), this.m_KeepLoadedShadersAlive.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("StripUnusedMeshComponents"), this.m_StripUnusedMeshComponents.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("VertexChannelCompressionMask"), this.m_VertexChannelCompressionMask.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("iPhoneSdkVersion"), this.m_IPhoneSdkVersion.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("iOSTargetOSVersionString"), this.m_IOSTargetOSVersionString.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("tvOSSdkVersion"), this.m_TvOSSdkVersion.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("tvOSRequireExtendedGameController"), this.m_TvOSRequireExtendedGameController.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("tvOSTargetOSVersionString"), this.m_TvOSTargetOSVersionString.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("uIPrerenderedIcon"), this.m_UIPrerenderedIcon.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("uIRequiresPersistentWiFi"), this.m_UIRequiresPersistentWiFi.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("uIRequiresFullScreen"), this.m_UIRequiresFullScreen.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("uIStatusBarHidden"), this.m_UIStatusBarHidden.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("uIExitOnSuspend"), this.m_UIExitOnSuspend.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("uIStatusBarStyle"), this.m_UIStatusBarStyle.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("iPhoneSplashScreen"), this.m_IPhoneSplashScreen.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("iPhoneHighResSplashScreen"), this.m_IPhoneHighResSplashScreen.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("iPhoneTallHighResSplashScreen"), this.m_IPhoneTallHighResSplashScreen.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("iPhone47inSplashScreen"), this.m_IPhone47inSplashScreen.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("iPhone55inPortraitSplashScreen"), this.m_IPhone55inPortraitSplashScreen.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("iPhone55inLandscapeSplashScreen"), this.m_IPhone55inLandscapeSplashScreen.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("iPadPortraitSplashScreen"), this.m_IPadPortraitSplashScreen.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("iPadHighResPortraitSplashScreen"), this.m_IPadHighResPortraitSplashScreen.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("iPadLandscapeSplashScreen"), this.m_IPadLandscapeSplashScreen.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("iPadHighResLandscapeSplashScreen"), this.m_IPadHighResLandscapeSplashScreen.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("appleTVSplashScreen"), this.m_AppleTVSplashScreen.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("tvOSSmallIconLayers"), this.m_TvOSSmallIconLayers.ExportYamlEditor_Array_PPtr_Texture2D_5_0_0(container));
			yamlMappingNode.Add(new YamlScalarNode("tvOSLargeIconLayers"), this.m_TvOSLargeIconLayers.ExportYamlEditor_Array_PPtr_Texture2D_5_0_0(container));
			yamlMappingNode.Add(new YamlScalarNode("tvOSTopShelfImageLayers"), this.m_TvOSTopShelfImageLayers.ExportYamlEditor_Array_PPtr_Texture2D_5_0_0(container));
			yamlMappingNode.Add(new YamlScalarNode("tvOSTopShelfImageWideLayers"), this.m_TvOSTopShelfImageWideLayers.ExportYamlEditor_Array_PPtr_Texture2D_5_0_0(container));
			yamlMappingNode.Add(new YamlScalarNode("iOSLaunchScreenType"), this.m_IOSLaunchScreenType.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("iOSLaunchScreenPortrait"), this.m_IOSLaunchScreenPortrait.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("iOSLaunchScreenLandscape"), this.m_IOSLaunchScreenLandscape.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("iOSLaunchScreenBackgroundColor"), this.m_IOSLaunchScreenBackgroundColor.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("iOSLaunchScreenFillPct"), this.m_IOSLaunchScreenFillPct.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("iOSLaunchScreenSize"), this.m_IOSLaunchScreenSize.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("iOSLaunchScreenCustomXibPath"), this.m_IOSLaunchScreenCustomXibPath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("iOSLaunchScreeniPadType"), this.m_IOSLaunchScreeniPadType.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("iOSLaunchScreeniPadImage"), this.m_IOSLaunchScreeniPadImage.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("iOSLaunchScreeniPadBackgroundColor"), this.m_IOSLaunchScreeniPadBackgroundColor.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("iOSLaunchScreeniPadFillPct"), this.m_IOSLaunchScreeniPadFillPct.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("iOSLaunchScreeniPadSize"), this.m_IOSLaunchScreeniPadSize.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("iOSLaunchScreeniPadCustomXibPath"), this.m_IOSLaunchScreeniPadCustomXibPath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("iOSDeviceRequirements"), this.m_IOSDeviceRequirements.ExportYamlEditor_Array_IOSDeviceRequirementForResourceVariant_2017_1_0(container));
			yamlMappingNode.Add(new YamlScalarNode("iOSURLSchemes"), this.m_IOSURLSchemes.ExportYamlEditor_Array_Utf8String(container));
			yamlMappingNode.Add(new YamlScalarNode("iOSBackgroundModes"), this.m_IOSBackgroundModes.ExportYamlEditor_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("iOSMetalForceHardShadows"), this.m_IOSMetalForceHardShadows.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("metalEditorSupport"), this.m_MetalEditorSupport.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("metalAPIValidation"), this.m_MetalAPIValidation.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("iOSRenderExtraFrameOnPause"), this.m_IOSRenderExtraFrameOnPause.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("appleDeveloperTeamID"), this.m_AppleDeveloperTeamID.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("iOSManualSigningProvisioningProfileID"), this.m_IOSManualSigningProvisioningProfileID.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("tvOSManualSigningProvisioningProfileID"), this.m_TvOSManualSigningProvisioningProfileID.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("appleEnableAutomaticSigning"), this.m_AppleEnableAutomaticSigning.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("AndroidTargetDevice"), this.m_AndroidTargetDevice.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("AndroidSplashScreenScale"), this.m_AndroidSplashScreenScale.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("androidSplashScreen"), this.m_AndroidSplashScreen.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("AndroidKeystoreName"), this.m_AndroidKeystoreName.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("AndroidKeyaliasName"), this.m_AndroidKeyaliasName.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("AndroidTVCompatibility"), this.m_AndroidTVCompatibility.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("AndroidIsGame"), this.m_AndroidIsGame.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("androidEnableBanner"), this.m_AndroidEnableBanner.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AndroidBanners"), this.m_AndroidBanners.ExportYamlEditor_Array_AndroidBanner(container));
			yamlMappingNode.Add(new YamlScalarNode("androidGamepadSupportLevel"), this.m_AndroidGamepadSupportLevel.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("resolutionDialogBanner"), this.m_ResolutionDialogBanner.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_BuildTargetIcons"), this.m_BuildTargetIcons.ExportYamlEditor_Array_BuildTargetIcons_2017_1_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_BuildTargetBatching"), this.m_BuildTargetBatching.ExportYamlEditor_Array_BuildTargetBatching(container));
			yamlMappingNode.Add(new YamlScalarNode("m_BuildTargetGraphicsAPIs"), this.m_BuildTargetGraphicsAPIs.ExportYamlEditor_Array_BuildTargetGraphicsAPIs_2017_1_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_BuildTargetVRSettings"), this.m_BuildTargetVRSettings.ExportYamlEditor_Array_BuildTargetVRSettings_2017_1_0(container));
			yamlMappingNode.Add(new YamlScalarNode("openGLRequireES31"), this.m_OpenGLRequireES31.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("openGLRequireES31AEP"), this.m_OpenGLRequireES31AEP.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("webPlayerTemplate"), this.m_WebPlayerTemplate.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_TemplateCustomTags"), this.m_TemplateCustomTags.ExportYamlEditor_Map_Utf8String_Utf8String(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUTitleID"), this.m_WiiUTitleID.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUGroupID"), this.m_WiiUGroupID.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUCommonSaveSize"), this.m_WiiUCommonSaveSize.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUAccountSaveSize"), this.m_WiiUAccountSaveSize.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUOlvAccessKey"), this.m_WiiUOlvAccessKey.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUTinCode"), this.m_WiiUTinCode.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUJoinGameId"), this.m_WiiUJoinGameId.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUJoinGameModeMask"), this.m_WiiUJoinGameModeMask.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUCommonBossSize"), this.m_WiiUCommonBossSize.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUAccountBossSize"), this.m_WiiUAccountBossSize.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUAddOnUniqueIDs"), this.m_WiiUAddOnUniqueIDs.ExportYamlEditor_Array_Utf8String(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUMainThreadStackSize"), this.m_WiiUMainThreadStackSize.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiULoaderThreadStackSize"), this.m_WiiULoaderThreadStackSize.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUSystemHeapSize"), this.m_WiiUSystemHeapSize.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUTVStartupScreen"), this.m_WiiUTVStartupScreen.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUGamePadStartupScreen"), this.m_WiiUGamePadStartupScreen.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUDrcBufferDisabled"), this.m_WiiUDrcBufferDisabled.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("wiiUProfilerLibPath"), this.m_WiiUProfilerLibPath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("playModeTestRunnerEnabled"), this.m_PlayModeTestRunnerEnabled.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("actionOnDotNetUnhandledException"), this.m_ActionOnDotNetUnhandledException.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("enableInternalProfiler"), this.m_EnableInternalProfiler.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("logObjCUncaughtExceptions"), this.m_LogObjCUncaughtExceptions.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("enableCrashReportAPI"), this.m_EnableCrashReportAPI.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("cameraUsageDescription"), this.m_CameraUsageDescription.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("locationUsageDescription"), this.m_LocationUsageDescription.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("microphoneUsageDescription"), this.m_MicrophoneUsageDescription.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchNetLibKey"), this.m_SwitchNetLibKey.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchSocketMemoryPoolSize"), this.m_SwitchSocketMemoryPoolSize.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchSocketAllocatorPoolSize"), this.m_SwitchSocketAllocatorPoolSize.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchSocketConcurrencyLimit"), this.m_SwitchSocketConcurrencyLimit.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchScreenResolutionBehavior"), this.m_SwitchScreenResolutionBehavior.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchUseCPUProfiler"), this.m_SwitchUseCPUProfiler.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("switchApplicationID"), this.m_SwitchApplicationID.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchNSODependencies"), this.m_SwitchNSODependencies.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchTitleNames_0"), this.m_SwitchTitleNames_0.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchTitleNames_1"), this.m_SwitchTitleNames_1.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchTitleNames_2"), this.m_SwitchTitleNames_2.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchTitleNames_3"), this.m_SwitchTitleNames_3.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchTitleNames_4"), this.m_SwitchTitleNames_4.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchTitleNames_5"), this.m_SwitchTitleNames_5.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchTitleNames_6"), this.m_SwitchTitleNames_6.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchTitleNames_7"), this.m_SwitchTitleNames_7.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchTitleNames_8"), this.m_SwitchTitleNames_8.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchTitleNames_9"), this.m_SwitchTitleNames_9.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchTitleNames_10"), this.m_SwitchTitleNames_10.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchTitleNames_11"), this.m_SwitchTitleNames_11.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchPublisherNames_0"), this.m_SwitchPublisherNames_0.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchPublisherNames_1"), this.m_SwitchPublisherNames_1.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchPublisherNames_2"), this.m_SwitchPublisherNames_2.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchPublisherNames_3"), this.m_SwitchPublisherNames_3.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchPublisherNames_4"), this.m_SwitchPublisherNames_4.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchPublisherNames_5"), this.m_SwitchPublisherNames_5.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchPublisherNames_6"), this.m_SwitchPublisherNames_6.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchPublisherNames_7"), this.m_SwitchPublisherNames_7.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchPublisherNames_8"), this.m_SwitchPublisherNames_8.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchPublisherNames_9"), this.m_SwitchPublisherNames_9.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchPublisherNames_10"), this.m_SwitchPublisherNames_10.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchPublisherNames_11"), this.m_SwitchPublisherNames_11.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchIcons_0"), this.m_SwitchIcons_0.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchIcons_1"), this.m_SwitchIcons_1.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchIcons_2"), this.m_SwitchIcons_2.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchIcons_3"), this.m_SwitchIcons_3.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchIcons_4"), this.m_SwitchIcons_4.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchIcons_5"), this.m_SwitchIcons_5.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchIcons_6"), this.m_SwitchIcons_6.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchIcons_7"), this.m_SwitchIcons_7.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchIcons_8"), this.m_SwitchIcons_8.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchIcons_9"), this.m_SwitchIcons_9.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchIcons_10"), this.m_SwitchIcons_10.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchIcons_11"), this.m_SwitchIcons_11.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchSmallIcons_0"), this.m_SwitchSmallIcons_0.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchSmallIcons_1"), this.m_SwitchSmallIcons_1.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchSmallIcons_2"), this.m_SwitchSmallIcons_2.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchSmallIcons_3"), this.m_SwitchSmallIcons_3.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchSmallIcons_4"), this.m_SwitchSmallIcons_4.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchSmallIcons_5"), this.m_SwitchSmallIcons_5.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchSmallIcons_6"), this.m_SwitchSmallIcons_6.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchSmallIcons_7"), this.m_SwitchSmallIcons_7.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchSmallIcons_8"), this.m_SwitchSmallIcons_8.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchSmallIcons_9"), this.m_SwitchSmallIcons_9.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchSmallIcons_10"), this.m_SwitchSmallIcons_10.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchSmallIcons_11"), this.m_SwitchSmallIcons_11.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchManualHTML"), this.m_SwitchManualHTML.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchAccessibleURLs"), this.m_SwitchAccessibleURLs.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchLegalInformation"), this.m_SwitchLegalInformation.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchMainThreadStackSize"), this.m_SwitchMainThreadStackSize.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchPresenceGroupId"), this.m_SwitchPresenceGroupId.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchLogoHandling"), this.m_SwitchLogoHandling.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchReleaseVersion"), this.m_SwitchReleaseVersion.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchDisplayVersion"), this.m_SwitchDisplayVersion.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchStartupUserAccount"), this.m_SwitchStartupUserAccount.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchTouchScreenUsage"), this.m_SwitchTouchScreenUsage.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchSupportedLanguagesMask"), this.m_SwitchSupportedLanguagesMask.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchLogoType"), this.m_SwitchLogoType.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchApplicationErrorCodeCategory"), this.m_SwitchApplicationErrorCodeCategory.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchUserAccountSaveDataSize"), this.m_SwitchUserAccountSaveDataSize.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchUserAccountSaveDataJournalSize"), this.m_SwitchUserAccountSaveDataJournalSize.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchApplicationAttribute"), this.m_SwitchApplicationAttribute.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchCardSpecSize"), this.m_SwitchCardSpecSize.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchCardSpecClock"), this.m_SwitchCardSpecClock.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchRatingsMask"), this.m_SwitchRatingsMask.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchRatingsInt_0"), this.m_SwitchRatingsInt_0.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchRatingsInt_1"), this.m_SwitchRatingsInt_1.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchRatingsInt_2"), this.m_SwitchRatingsInt_2.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchRatingsInt_3"), this.m_SwitchRatingsInt_3.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchRatingsInt_4"), this.m_SwitchRatingsInt_4.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchRatingsInt_5"), this.m_SwitchRatingsInt_5.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchRatingsInt_6"), this.m_SwitchRatingsInt_6.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchRatingsInt_7"), this.m_SwitchRatingsInt_7.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchRatingsInt_8"), this.m_SwitchRatingsInt_8.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchRatingsInt_9"), this.m_SwitchRatingsInt_9.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchRatingsInt_10"), this.m_SwitchRatingsInt_10.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchRatingsInt_11"), this.m_SwitchRatingsInt_11.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchLocalCommunicationIds_0"), this.m_SwitchLocalCommunicationIds_0.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchLocalCommunicationIds_1"), this.m_SwitchLocalCommunicationIds_1.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchLocalCommunicationIds_2"), this.m_SwitchLocalCommunicationIds_2.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchLocalCommunicationIds_3"), this.m_SwitchLocalCommunicationIds_3.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchLocalCommunicationIds_4"), this.m_SwitchLocalCommunicationIds_4.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchLocalCommunicationIds_5"), this.m_SwitchLocalCommunicationIds_5.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchLocalCommunicationIds_6"), this.m_SwitchLocalCommunicationIds_6.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchLocalCommunicationIds_7"), this.m_SwitchLocalCommunicationIds_7.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("switchParentalControl"), this.m_SwitchParentalControl.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("switchAllowsScreenshot"), this.m_SwitchAllowsScreenshot.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("switchDataLossConfirmation"), this.m_SwitchDataLossConfirmation.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("switchSupportedNpadStyles"), this.m_SwitchSupportedNpadStyles.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchSocketConfigEnabled"), this.m_SwitchSocketConfigEnabled.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("switchTcpInitialSendBufferSize"), this.m_SwitchTcpInitialSendBufferSize.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchTcpInitialReceiveBufferSize"), this.m_SwitchTcpInitialReceiveBufferSize.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchTcpAutoSendBufferSizeMax"), this.m_SwitchTcpAutoSendBufferSizeMax.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchTcpAutoReceiveBufferSizeMax"), this.m_SwitchTcpAutoReceiveBufferSizeMax.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchUdpSendBufferSize"), this.m_SwitchUdpSendBufferSize.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchUdpReceiveBufferSize"), this.m_SwitchUdpReceiveBufferSize.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("switchSocketBufferEfficiency"), this.m_SwitchSocketBufferEfficiency.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4NPAgeRating"), this.m_Ps4NPAgeRating.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4NPTitleSecret"), this.m_Ps4NPTitleSecret.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4NPTrophyPackPath"), this.m_Ps4NPTrophyPackPath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4ParentalLevel"), this.m_Ps4ParentalLevel.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4ContentID"), this.m_Ps4ContentID.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4Category"), this.m_Ps4Category.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4MasterVersion"), this.m_Ps4MasterVersion.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4AppVersion"), this.m_Ps4AppVersion.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4AppType"), this.m_Ps4AppType.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4ParamSfxPath"), this.m_Ps4ParamSfxPath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4VideoOutPixelFormat"), this.m_Ps4VideoOutPixelFormat.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4VideoOutInitialWidth"), this.m_Ps4VideoOutInitialWidth.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4VideoOutBaseModeInitialWidth"), this.m_Ps4VideoOutBaseModeInitialWidth.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4VideoOutReprojectionRate"), this.m_Ps4VideoOutReprojectionRate.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4PronunciationXMLPath"), this.m_Ps4PronunciationXMLPath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4PronunciationSIGPath"), this.m_Ps4PronunciationSIGPath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4BackgroundImagePath"), this.m_Ps4BackgroundImagePath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4StartupImagePath"), this.m_Ps4StartupImagePath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4SaveDataImagePath"), this.m_Ps4SaveDataImagePath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4SdkOverride"), this.m_Ps4SdkOverride.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4BGMPath"), this.m_Ps4BGMPath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4ShareFilePath"), this.m_Ps4ShareFilePath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4ShareOverlayImagePath"), this.m_Ps4ShareOverlayImagePath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4PrivacyGuardImagePath"), this.m_Ps4PrivacyGuardImagePath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4NPtitleDatPath"), this.m_Ps4NPtitleDatPath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4RemotePlayKeyAssignment"), this.m_Ps4RemotePlayKeyAssignment.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4RemotePlayKeyMappingDir"), this.m_Ps4RemotePlayKeyMappingDir.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4PlayTogetherPlayerCount"), this.m_Ps4PlayTogetherPlayerCount.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4EnterButtonAssignment"), this.m_Ps4EnterButtonAssignment.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4ApplicationParam1"), this.m_Ps4ApplicationParam1.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4ApplicationParam2"), this.m_Ps4ApplicationParam2.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4ApplicationParam3"), this.m_Ps4ApplicationParam3.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4ApplicationParam4"), this.m_Ps4ApplicationParam4.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4DownloadDataSize"), this.m_Ps4DownloadDataSize.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4GarlicHeapSize"), this.m_Ps4GarlicHeapSize.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4ProGarlicHeapSize"), this.m_Ps4ProGarlicHeapSize.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4Passcode"), this.m_Ps4Passcode.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4pnSessions"), this.m_Ps4pnSessions.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4pnPresence"), this.m_Ps4pnPresence.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4pnFriends"), this.m_Ps4pnFriends.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4pnGameCustomData"), this.m_Ps4pnGameCustomData.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("playerPrefsSupport"), this.m_PlayerPrefsSupport.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("restrictedAudioUsageRights"), this.m_RestrictedAudioUsageRights.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4UseResolutionFallback"), this.m_Ps4UseResolutionFallback.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4ReprojectionSupport"), this.m_Ps4ReprojectionSupport.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4UseAudio3dBackend"), this.m_Ps4UseAudio3dBackend.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4SocialScreenEnabled"), this.m_Ps4SocialScreenEnabled.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4ScriptOptimizationLevel"), this.m_Ps4ScriptOptimizationLevel.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4Audio3dVirtualSpeakerCount"), this.m_Ps4Audio3dVirtualSpeakerCount.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4attribCpuUsage"), this.m_Ps4attribCpuUsage.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4PatchPkgPath"), this.m_Ps4PatchPkgPath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4PatchLatestPkgPath"), this.m_Ps4PatchLatestPkgPath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4PatchChangeinfoPath"), this.m_Ps4PatchChangeinfoPath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4PatchDayOne"), this.m_Ps4PatchDayOne.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4attribUserManagement"), this.m_Ps4attribUserManagement.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4attribMoveSupport"), this.m_Ps4attribMoveSupport.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4attrib3DSupport"), this.m_Ps4attrib3DSupport.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4attribShareSupport"), this.m_Ps4attribShareSupport.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4attribExclusiveVR"), this.m_Ps4attribExclusiveVR.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4disableAutoHideSplash"), this.m_Ps4disableAutoHideSplash.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4videoRecordingFeaturesUsed"), this.m_Ps4videoRecordingFeaturesUsed.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4contentSearchFeaturesUsed"), this.m_Ps4contentSearchFeaturesUsed.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4attribEyeToEyeDistanceSettingVR"), this.m_Ps4attribEyeToEyeDistanceSettingVR.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("ps4IncludedModules"), this.m_Ps4IncludedModules.ExportYamlEditor_Array_Utf8String(container));
			yamlMappingNode.Add(new YamlScalarNode("monoEnv"), this.m_MonoEnv.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2Splashimage"), this.m_Psp2Splashimage.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2NPTrophyPackPath"), this.m_Psp2NPTrophyPackPath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2NPSupportGBMorGJP"), this.m_Psp2NPSupportGBMorGJP.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2NPAgeRating"), this.m_Psp2NPAgeRating.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2NPTitleDatPath"), this.m_Psp2NPTitleDatPath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2NPCommsID"), this.m_Psp2NPCommsID.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2NPCommunicationsID"), this.m_Psp2NPCommunicationsID.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2NPCommsPassphrase"), this.m_Psp2NPCommsPassphrase.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2NPCommsSig"), this.m_Psp2NPCommsSig.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2ParamSfxPath"), this.m_Psp2ParamSfxPath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2ManualPath"), this.m_Psp2ManualPath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2LiveAreaGatePath"), this.m_Psp2LiveAreaGatePath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2LiveAreaBackroundPath"), this.m_Psp2LiveAreaBackroundPath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2LiveAreaPath"), this.m_Psp2LiveAreaPath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2LiveAreaTrialPath"), this.m_Psp2LiveAreaTrialPath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2PatchChangeInfoPath"), this.m_Psp2PatchChangeInfoPath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2PatchOriginalPackage"), this.m_Psp2PatchOriginalPackage.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2PackagePassword"), this.m_Psp2PackagePassword.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2KeystoneFile"), this.m_Psp2KeystoneFile.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2MemoryExpansionMode"), this.m_Psp2MemoryExpansionMode.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2DRMType"), this.m_Psp2DRMType.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2StorageType"), this.m_Psp2StorageType.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2MediaCapacity"), this.m_Psp2MediaCapacity.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2DLCConfigPath"), this.m_Psp2DLCConfigPath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2ThumbnailPath"), this.m_Psp2ThumbnailPath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2BackgroundPath"), this.m_Psp2BackgroundPath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2SoundPath"), this.m_Psp2SoundPath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2TrophyCommId"), this.m_Psp2TrophyCommId.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2TrophyPackagePath"), this.m_Psp2TrophyPackagePath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2PackagedResourcesPath"), this.m_Psp2PackagedResourcesPath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2SaveDataQuota"), this.m_Psp2SaveDataQuota.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2ParentalLevel"), this.m_Psp2ParentalLevel.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2ShortTitle"), this.m_Psp2ShortTitle.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2ContentID"), this.m_Psp2ContentID.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2Category"), this.m_Psp2Category.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2MasterVersion"), this.m_Psp2MasterVersion.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2AppVersion"), this.m_Psp2AppVersion.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2TVBootMode"), this.m_Psp2TVBootMode.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2EnterButtonAssignment"), this.m_Psp2EnterButtonAssignment.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2TVDisableEmu"), this.m_Psp2TVDisableEmu.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2AllowTwitterDialog"), this.m_Psp2AllowTwitterDialog.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2Upgradable"), this.m_Psp2Upgradable.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2HealthWarning"), this.m_Psp2HealthWarning.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2UseLibLocation"), this.m_Psp2UseLibLocation.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2InfoBarOnStartup"), this.m_Psp2InfoBarOnStartup.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2InfoBarColor"), this.m_Psp2InfoBarColor.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("psp2ScriptOptimizationLevel"), this.m_Psp2ScriptOptimizationLevel.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("psmSplashimage"), this.m_PsmSplashimage.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("splashScreenBackgroundSourceLandscape"), this.m_SplashScreenBackgroundSourceLandscape.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("splashScreenBackgroundSourcePortrait"), this.m_SplashScreenBackgroundSourcePortrait.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("spritePackerPolicy"), this.m_SpritePackerPolicy.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("webGLMemorySize"), this.m_WebGLMemorySize.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("webGLExceptionSupport"), this.m_WebGLExceptionSupport.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("webGLNameFilesAsHashes"), this.m_WebGLNameFilesAsHashes.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("webGLDataCaching"), this.m_WebGLDataCaching.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("webGLDebugSymbols"), this.m_WebGLDebugSymbols.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("webGLEmscriptenArgs"), this.m_WebGLEmscriptenArgs.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("webGLModulesDirectory"), this.m_WebGLModulesDirectory.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("webGLTemplate"), this.m_WebGLTemplate.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("webGLAnalyzeBuildSize"), this.m_WebGLAnalyzeBuildSize.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("webGLUseEmbeddedResources"), this.m_WebGLUseEmbeddedResources.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("webGLUseWasm"), this.m_WebGLUseWasm.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("webGLCompressionFormat"), this.m_WebGLCompressionFormat.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("scriptingDefineSymbols"), this.m_ScriptingDefineSymbols.ExportYamlEditor_Map_Int32_Utf8String(container));
			yamlMappingNode.Add(new YamlScalarNode("platformArchitecture"), this.m_PlatformArchitecture.ExportYamlEditor_Map_Utf8String_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("scriptingBackend"), this.m_ScriptingBackend.ExportYamlEditor_Map_Utf8String_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("incrementalIl2cppBuild"), this.m_IncrementalIl2cppBuild.ExportYamlEditor_Map_Utf8String_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("additionalIl2CppArgs"), this.m_AdditionalIl2CppArgs.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("scriptingRuntimeVersion"), this.m_ScriptingRuntimeVersion.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("apiCompatibilityLevelPerPlatform"), this.m_ApiCompatibilityLevelPerPlatform.ExportYamlEditor_Map_Utf8String_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_RenderingPath"), this.m_RenderingPath.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MobileRenderingPath"), this.m_MobileRenderingPath.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("metroPackageName"), this.m_MetroPackageName.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("metroPackageVersion"), this.m_MetroPackageVersion.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("metroCertificatePath"), this.m_MetroCertificatePath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("metroCertificatePassword"), this.m_MetroCertificatePassword.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("metroCertificateSubject"), this.m_MetroCertificateSubject.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("metroCertificateIssuer"), this.m_MetroCertificateIssuer.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("metroCertificateNotAfter"), this.m_MetroCertificateNotAfter.ExportYamlEditor_Int64(container));
			yamlMappingNode.Add(new YamlScalarNode("metroApplicationDescription"), this.m_MetroApplicationDescription.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("wsaImages"), this.m_WsaImages.ExportYamlEditor_Map_Int32_Utf8String(container));
			yamlMappingNode.Add(new YamlScalarNode("metroTileShortName"), this.m_MetroTileShortName.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("metroCommandLineArgsFile"), this.m_MetroCommandLineArgsFile.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("metroTileShowName"), this.m_MetroTileShowName.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("metroMediumTileShowName"), this.m_MetroMediumTileShowName.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("metroLargeTileShowName"), this.m_MetroLargeTileShowName.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("metroWideTileShowName"), this.m_MetroWideTileShowName.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("metroDefaultTileSize"), this.m_MetroDefaultTileSize.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("metroTileForegroundText"), this.m_MetroTileForegroundText.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("metroTileBackgroundColor"), this.m_MetroTileBackgroundColor.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("metroSplashScreenBackgroundColor"), this.m_MetroSplashScreenBackgroundColor.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("metroSplashScreenUseBackgroundColor"), this.m_MetroSplashScreenUseBackgroundColor.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("platformCapabilities"), this.m_PlatformCapabilities.ExportYamlEditor_Map_Utf8String_Map_Utf8String_Utf8String(container));
			yamlMappingNode.Add(new YamlScalarNode("metroFTAName"), this.m_MetroFTAName.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("metroFTAFileTypes"), this.m_MetroFTAFileTypes.ExportYamlEditor_Array_MetroFTAFileType(container));
			yamlMappingNode.Add(new YamlScalarNode("metroProtocolName"), this.m_MetroProtocolName.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("metroCompilationOverrides"), this.m_MetroCompilationOverrides.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("tizenProductDescription"), this.m_TizenProductDescription.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("tizenProductURL"), this.m_TizenProductURL.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("tizenSigningProfileName"), this.m_TizenSigningProfileName.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("tizenGPSPermissions"), this.m_TizenGPSPermissions.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("tizenMicrophonePermissions"), this.m_TizenMicrophonePermissions.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("tizenDeploymentTarget"), this.m_TizenDeploymentTarget.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("tizenDeploymentTargetType"), this.m_TizenDeploymentTargetType.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("tizenMinOSVersion"), this.m_TizenMinOSVersion.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("n3dsUseExtSaveData"), this.m_N3dsUseExtSaveData.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("n3dsCompressStaticMem"), this.m_N3dsCompressStaticMem.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("n3dsExtSaveDataNumber"), this.m_N3dsExtSaveDataNumber.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("n3dsStackSize"), this.m_N3dsStackSize.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("n3dsTargetPlatform"), this.m_N3dsTargetPlatform.ExportYamlEditor_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("n3dsRegion"), this.m_N3dsRegion.ExportYamlEditor_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("n3dsMediaSize"), this.m_N3dsMediaSize.ExportYamlEditor_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("n3dsLogoStyle"), this.m_N3dsLogoStyle.ExportYamlEditor_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("n3dsTitle"), this.m_N3dsTitle.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("n3dsProductCode"), this.m_N3dsProductCode.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("n3dsApplicationId"), this.m_N3dsApplicationId.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("stvDeviceAddress"), this.m_StvDeviceAddress.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("stvProductDescription"), this.m_StvProductDescription.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("stvProductAuthor"), this.m_StvProductAuthor.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("stvProductAuthorEmail"), this.m_StvProductAuthorEmail.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("stvProductLink"), this.m_StvProductLink.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("stvProductCategory"), this.m_StvProductCategory.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("XboxOneProductId"), this.m_XboxOneProductId.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("XboxOneUpdateKey"), this.m_XboxOneUpdateKey.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("XboxOneSandboxId"), this.m_XboxOneSandboxId.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("XboxOneContentId"), this.m_XboxOneContentId.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("XboxOneTitleId"), this.m_XboxOneTitleId.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("XboxOneSCId"), this.m_XboxOneSCId.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("XboxOneGameOsOverridePath"), this.m_XboxOneGameOsOverridePath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("XboxOnePackagingOverridePath"), this.m_XboxOnePackagingOverridePath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("XboxOneAppManifestOverridePath"), this.m_XboxOneAppManifestOverridePath.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("XboxOnePackageEncryption"), this.m_XboxOnePackageEncryption.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("XboxOnePackageUpdateGranularity"), this.m_XboxOnePackageUpdateGranularity.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("XboxOneDescription"), this.m_XboxOneDescription.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("XboxOneLanguage"), this.m_XboxOneLanguage.ExportYamlEditor_Array_Utf8String(container));
			yamlMappingNode.Add(new YamlScalarNode("XboxOneCapability"), this.m_XboxOneCapability.ExportYamlEditor_Array_Utf8String(container));
			yamlMappingNode.Add(new YamlScalarNode("XboxOneGameRating"), this.m_XboxOneGameRating.ExportYamlEditor_Map_Utf8String_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("XboxOneIsContentPackage"), this.m_XboxOneIsContentPackage.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("XboxOneEnableGPUVariability"), this.m_XboxOneEnableGPUVariability.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("XboxOneSockets"), this.m_XboxOneSockets.ExportYamlEditor_Map_Utf8String_XboxOneSocketDefinition_2017_1_0(container));
			yamlMappingNode.Add(new YamlScalarNode("XboxOneSplashScreen"), this.m_XboxOneSplashScreen.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("XboxOneAllowedProductIds"), this.m_XboxOneAllowedProductIds.ExportYamlEditor_Array_Utf8String(container));
			yamlMappingNode.Add(new YamlScalarNode("XboxOnePersistentLocalStorageSize"), this.m_XboxOnePersistentLocalStorageSize.ExportYamlEditor_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("xboxOneScriptCompiler"), this.m_XboxOneScriptCompiler.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("vrEditorSettings"), this.m_VrEditorSettings.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("cloudServicesEnabled"), this.m_CloudServicesEnabled.ExportYamlEditor_Map_Utf8String_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("facebookSdkVersion"), this.m_FacebookSdkVersion.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("apiCompatibilityLevel"), this.m_ApiCompatibilityLevel.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("cloudProjectId"), this.m_CloudProjectId.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("projectName"), this.m_ProjectName.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("organizationId"), this.m_OrganizationId.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("cloudEnabled"), this.m_CloudEnabled.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("enableNativePlatformBackendsForNewInputSystem"), this.m_EnableNativePlatformBackendsForNewInputSystem.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("disableOldInputManagerSupport"), this.m_DisableOldInputManagerSupport.ExportYamlEditor_Boolean(container));
			return yamlMappingNode;
		}

		// Token: 0x06050FC2 RID: 331714 RVA: 0x00A85232 File Offset: 0x00A83432
		public override void Reset()
		{
		}

		// Token: 0x06050FC3 RID: 331715 RVA: 0x00A85234 File Offset: 0x00A83434

		// Token: 0x06050FC4 RID: 331716 RVA: 0x00A8523B File Offset: 0x00A8343B
		public void CopyValues(IPlayerSettings source)
		{
		}

		// Token: 0x06050FC5 RID: 331717 RVA: 0x00A85240 File Offset: 0x00A83440

		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			IPlayerSettings playerSettings = source as IPlayerSettings;
			if (playerSettings != null)
			{
				this.CopyValues(playerSettings);
				return;
			}
			base.CopyValues(source, converter);
		}

		// Token: 0x04016D28 RID: 93480
		public AssetDictionary<Utf8String, Utf8String> m_ApplicationIdentifier;

		// Token: 0x04016D29 RID: 93481
		public AssetDictionary<Utf8String, Utf8String> m_BuildNumber;

		// Token: 0x04016D2A RID: 93482
		public int m_AndroidBundleVersionCode;

		// Token: 0x04016D2B RID: 93483
		public int m_AndroidMinSdkVersion;

		// Token: 0x04016D2C RID: 93484
		public int m_AndroidTargetSdkVersion;

		// Token: 0x04016D2D RID: 93485
		public int m_AndroidPreferredInstallLocation;

		// Token: 0x04016D2E RID: 93486
		public Utf8String m_AotOptions;

		// Token: 0x04016D2F RID: 93487
		public bool m_StripEngineCode;

		// Token: 0x04016D30 RID: 93488
		public int m_IPhoneStrippingLevel;

		// Token: 0x04016D31 RID: 93489
		public int m_IPhoneScriptCallOptimization;

		// Token: 0x04016D32 RID: 93490
		public bool m_ForceInternetPermission;

		// Token: 0x04016D33 RID: 93491
		public bool m_ForceSDCardPermission;

		// Token: 0x04016D34 RID: 93492
		public bool m_CreateWallpaper;

		// Token: 0x04016D35 RID: 93493
		public bool m_APKExpansionFiles;

		// Token: 0x04016D36 RID: 93494
		public bool m_KeepLoadedShadersAlive;

		// Token: 0x04016D37 RID: 93495
		public bool m_StripUnusedMeshComponents;

		// Token: 0x04016D38 RID: 93496
		public BitField m_VertexChannelCompressionMask;

		// Token: 0x04016D39 RID: 93497
		public int m_IPhoneSdkVersion;

		// Token: 0x04016D3A RID: 93498
		public Utf8String m_IOSTargetOSVersionString;

		// Token: 0x04016D3B RID: 93499
		public int m_TvOSSdkVersion;

		// Token: 0x04016D3C RID: 93500
		public bool m_TvOSRequireExtendedGameController;

		// Token: 0x04016D3D RID: 93501
		public Utf8String m_TvOSTargetOSVersionString;

		// Token: 0x04016D3E RID: 93502
		public bool m_UIPrerenderedIcon;

		// Token: 0x04016D3F RID: 93503
		public bool m_UIRequiresPersistentWiFi;

		// Token: 0x04016D40 RID: 93504
		public bool m_UIRequiresFullScreen;

		// Token: 0x04016D41 RID: 93505
		public bool m_UIStatusBarHidden;

		// Token: 0x04016D42 RID: 93506
		public bool m_UIExitOnSuspend;

		// Token: 0x04016D43 RID: 93507
		public int m_UIStatusBarStyle;

		// Token: 0x04016D44 RID: 93508
		public PPtr_Texture2D_5_0_0 m_IPhoneSplashScreen;

		// Token: 0x04016D45 RID: 93509
		public PPtr_Texture2D_5_0_0 m_IPhoneHighResSplashScreen;

		// Token: 0x04016D46 RID: 93510
		public PPtr_Texture2D_5_0_0 m_IPhoneTallHighResSplashScreen;

		// Token: 0x04016D47 RID: 93511
		public PPtr_Texture2D_5_0_0 m_IPhone47inSplashScreen;

		// Token: 0x04016D48 RID: 93512
		public PPtr_Texture2D_5_0_0 m_IPhone55inPortraitSplashScreen;

		// Token: 0x04016D49 RID: 93513
		public PPtr_Texture2D_5_0_0 m_IPhone55inLandscapeSplashScreen;

		// Token: 0x04016D4A RID: 93514
		public PPtr_Texture2D_5_0_0 m_IPadPortraitSplashScreen;

		// Token: 0x04016D4B RID: 93515
		public PPtr_Texture2D_5_0_0 m_IPadHighResPortraitSplashScreen;

		// Token: 0x04016D4C RID: 93516
		public PPtr_Texture2D_5_0_0 m_IPadLandscapeSplashScreen;

		// Token: 0x04016D4D RID: 93517
		public PPtr_Texture2D_5_0_0 m_IPadHighResLandscapeSplashScreen;

		// Token: 0x04016D4E RID: 93518
		public PPtr_Texture2D_5_0_0 m_AppleTVSplashScreen;

		// Token: 0x04016D4F RID: 93519
		public AssetList<PPtr_Texture2D_5_0_0> m_TvOSSmallIconLayers;

		// Token: 0x04016D50 RID: 93520
		public AssetList<PPtr_Texture2D_5_0_0> m_TvOSLargeIconLayers;

		// Token: 0x04016D51 RID: 93521
		public AssetList<PPtr_Texture2D_5_0_0> m_TvOSTopShelfImageLayers;

		// Token: 0x04016D52 RID: 93522
		public AssetList<PPtr_Texture2D_5_0_0> m_TvOSTopShelfImageWideLayers;

		// Token: 0x04016D53 RID: 93523
		public int m_IOSLaunchScreenType;

		// Token: 0x04016D54 RID: 93524
		public PPtr_Texture2D_5_0_0 m_IOSLaunchScreenPortrait;

		// Token: 0x04016D55 RID: 93525
		public PPtr_Texture2D_5_0_0 m_IOSLaunchScreenLandscape;

		// Token: 0x04016D56 RID: 93526
		public ColorRGBA32 m_IOSLaunchScreenBackgroundColor;

		// Token: 0x04016D57 RID: 93527
		public float m_IOSLaunchScreenFillPct;

		// Token: 0x04016D58 RID: 93528
		public float m_IOSLaunchScreenSize;

		// Token: 0x04016D59 RID: 93529
		public Utf8String m_IOSLaunchScreenCustomXibPath;

		// Token: 0x04016D5A RID: 93530
		public int m_IOSLaunchScreeniPadType;

		// Token: 0x04016D5B RID: 93531
		public PPtr_Texture2D_5_0_0 m_IOSLaunchScreeniPadImage;

		// Token: 0x04016D5C RID: 93532
		public ColorRGBA32 m_IOSLaunchScreeniPadBackgroundColor;

		// Token: 0x04016D5D RID: 93533
		public float m_IOSLaunchScreeniPadFillPct;

		// Token: 0x04016D5E RID: 93534
		public float m_IOSLaunchScreeniPadSize;

		// Token: 0x04016D5F RID: 93535
		public Utf8String m_IOSLaunchScreeniPadCustomXibPath;

		// Token: 0x04016D60 RID: 93536
		public AssetList<IOSDeviceRequirementForResourceVariant_2017_1_0> m_IOSDeviceRequirements;

		// Token: 0x04016D61 RID: 93537
		public AssetList<Utf8String> m_IOSURLSchemes;

		// Token: 0x04016D62 RID: 93538
		public uint m_IOSBackgroundModes;

		// Token: 0x04016D63 RID: 93539
		public bool m_IOSMetalForceHardShadows;

		// Token: 0x04016D64 RID: 93540
		public bool m_MetalEditorSupport;

		// Token: 0x04016D65 RID: 93541
		public bool m_MetalAPIValidation;

		// Token: 0x04016D66 RID: 93542
		public bool m_IOSRenderExtraFrameOnPause;

		// Token: 0x04016D67 RID: 93543
		public Utf8String m_AppleDeveloperTeamID;

		// Token: 0x04016D68 RID: 93544
		public Utf8String m_IOSManualSigningProvisioningProfileID;

		// Token: 0x04016D69 RID: 93545
		public Utf8String m_TvOSManualSigningProvisioningProfileID;

		// Token: 0x04016D6A RID: 93546
		public int m_AppleEnableAutomaticSigning;

		// Token: 0x04016D6B RID: 93547
		public int m_AndroidTargetDevice;

		// Token: 0x04016D6C RID: 93548
		public int m_AndroidSplashScreenScale;

		// Token: 0x04016D6D RID: 93549
		public PPtr_Texture2D_5_0_0 m_AndroidSplashScreen;

		// Token: 0x04016D6E RID: 93550
		public Utf8String m_AndroidKeystoreName;

		// Token: 0x04016D6F RID: 93551
		public Utf8String m_AndroidKeyaliasName;

		// Token: 0x04016D70 RID: 93552
		public bool m_AndroidTVCompatibility;

		// Token: 0x04016D71 RID: 93553
		public bool m_AndroidIsGame;

		// Token: 0x04016D72 RID: 93554
		public bool m_AndroidEnableBanner;

		// Token: 0x04016D73 RID: 93555
		public AssetList<AndroidBanner> m_AndroidBanners;

		// Token: 0x04016D74 RID: 93556
		public int m_AndroidGamepadSupportLevel;

		// Token: 0x04016D75 RID: 93557
		public PPtr_Texture2D_5_0_0 m_ResolutionDialogBanner;

		// Token: 0x04016D76 RID: 93558
		public AssetList<BuildTargetIcons_2017_1_0> m_BuildTargetIcons;

		// Token: 0x04016D77 RID: 93559
		public AssetList<BuildTargetBatching> m_BuildTargetBatching;

		// Token: 0x04016D78 RID: 93560
		public AssetList<BuildTargetGraphicsAPIs_2017_1_0> m_BuildTargetGraphicsAPIs;

		// Token: 0x04016D79 RID: 93561
		public AssetList<BuildTargetVRSettings_2017_1_0> m_BuildTargetVRSettings;

		// Token: 0x04016D7A RID: 93562
		public bool m_OpenGLRequireES31;

		// Token: 0x04016D7B RID: 93563
		public bool m_OpenGLRequireES31AEP;

		// Token: 0x04016D7C RID: 93564
		public Utf8String m_WebPlayerTemplate;

		// Token: 0x04016D7D RID: 93565
		public AssetDictionary<Utf8String, Utf8String> m_TemplateCustomTags;

		// Token: 0x04016D7E RID: 93566
		public Utf8String m_WiiUTitleID;

		// Token: 0x04016D7F RID: 93567
		public Utf8String m_WiiUGroupID;

		// Token: 0x04016D80 RID: 93568
		public int m_WiiUCommonSaveSize;

		// Token: 0x04016D81 RID: 93569
		public int m_WiiUAccountSaveSize;

		// Token: 0x04016D82 RID: 93570
		public Utf8String m_WiiUOlvAccessKey;

		// Token: 0x04016D83 RID: 93571
		public Utf8String m_WiiUTinCode;

		// Token: 0x04016D84 RID: 93572
		public Utf8String m_WiiUJoinGameId;

		// Token: 0x04016D85 RID: 93573
		public Utf8String m_WiiUJoinGameModeMask;

		// Token: 0x04016D86 RID: 93574
		public int m_WiiUCommonBossSize;

		// Token: 0x04016D87 RID: 93575
		public int m_WiiUAccountBossSize;

		// Token: 0x04016D88 RID: 93576
		public AssetList<Utf8String> m_WiiUAddOnUniqueIDs;

		// Token: 0x04016D89 RID: 93577
		public int m_WiiUMainThreadStackSize;

		// Token: 0x04016D8A RID: 93578
		public int m_WiiULoaderThreadStackSize;

		// Token: 0x04016D8B RID: 93579
		public int m_WiiUSystemHeapSize;

		// Token: 0x04016D8C RID: 93580
		public PPtr_Texture2D_5_0_0 m_WiiUTVStartupScreen;

		// Token: 0x04016D8D RID: 93581
		public PPtr_Texture2D_5_0_0 m_WiiUGamePadStartupScreen;

		// Token: 0x04016D8E RID: 93582
		public bool m_WiiUDrcBufferDisabled;

		// Token: 0x04016D8F RID: 93583
		public Utf8String m_WiiUProfilerLibPath;

		// Token: 0x04016D90 RID: 93584
		public bool m_PlayModeTestRunnerEnabled;

		// Token: 0x04016D91 RID: 93585
		public int m_ActionOnDotNetUnhandledException;

		// Token: 0x04016D92 RID: 93586
		public bool m_EnableInternalProfiler;

		// Token: 0x04016D93 RID: 93587
		public bool m_LogObjCUncaughtExceptions;

		// Token: 0x04016D94 RID: 93588
		public bool m_EnableCrashReportAPI;

		// Token: 0x04016D95 RID: 93589
		public Utf8String m_CameraUsageDescription;

		// Token: 0x04016D96 RID: 93590
		public Utf8String m_LocationUsageDescription;

		// Token: 0x04016D97 RID: 93591
		public Utf8String m_MicrophoneUsageDescription;

		// Token: 0x04016D98 RID: 93592
		public Utf8String m_SwitchNetLibKey;

		// Token: 0x04016D99 RID: 93593
		public int m_SwitchSocketMemoryPoolSize;

		// Token: 0x04016D9A RID: 93594
		public int m_SwitchSocketAllocatorPoolSize;

		// Token: 0x04016D9B RID: 93595
		public int m_SwitchSocketConcurrencyLimit;

		// Token: 0x04016D9C RID: 93596
		public int m_SwitchScreenResolutionBehavior;

		// Token: 0x04016D9D RID: 93597
		public bool m_SwitchUseCPUProfiler;

		// Token: 0x04016D9E RID: 93598
		public Utf8String m_SwitchApplicationID;

		// Token: 0x04016D9F RID: 93599
		public Utf8String m_SwitchNSODependencies;

		// Token: 0x04016DA0 RID: 93600
		public Utf8String m_SwitchTitleNames_0;

		// Token: 0x04016DA1 RID: 93601
		public Utf8String m_SwitchTitleNames_1;

		// Token: 0x04016DA2 RID: 93602
		public Utf8String m_SwitchTitleNames_2;

		// Token: 0x04016DA3 RID: 93603
		public Utf8String m_SwitchTitleNames_3;

		// Token: 0x04016DA4 RID: 93604
		public Utf8String m_SwitchTitleNames_4;

		// Token: 0x04016DA5 RID: 93605
		public Utf8String m_SwitchTitleNames_5;

		// Token: 0x04016DA6 RID: 93606
		public Utf8String m_SwitchTitleNames_6;

		// Token: 0x04016DA7 RID: 93607
		public Utf8String m_SwitchTitleNames_7;

		// Token: 0x04016DA8 RID: 93608
		public Utf8String m_SwitchTitleNames_8;

		// Token: 0x04016DA9 RID: 93609
		public Utf8String m_SwitchTitleNames_9;

		// Token: 0x04016DAA RID: 93610
		public Utf8String m_SwitchTitleNames_10;

		// Token: 0x04016DAB RID: 93611
		public Utf8String m_SwitchTitleNames_11;

		// Token: 0x04016DAC RID: 93612
		public Utf8String m_SwitchPublisherNames_0;

		// Token: 0x04016DAD RID: 93613
		public Utf8String m_SwitchPublisherNames_1;

		// Token: 0x04016DAE RID: 93614
		public Utf8String m_SwitchPublisherNames_2;

		// Token: 0x04016DAF RID: 93615
		public Utf8String m_SwitchPublisherNames_3;

		// Token: 0x04016DB0 RID: 93616
		public Utf8String m_SwitchPublisherNames_4;

		// Token: 0x04016DB1 RID: 93617
		public Utf8String m_SwitchPublisherNames_5;

		// Token: 0x04016DB2 RID: 93618
		public Utf8String m_SwitchPublisherNames_6;

		// Token: 0x04016DB3 RID: 93619
		public Utf8String m_SwitchPublisherNames_7;

		// Token: 0x04016DB4 RID: 93620
		public Utf8String m_SwitchPublisherNames_8;

		// Token: 0x04016DB5 RID: 93621
		public Utf8String m_SwitchPublisherNames_9;

		// Token: 0x04016DB6 RID: 93622
		public Utf8String m_SwitchPublisherNames_10;

		// Token: 0x04016DB7 RID: 93623
		public Utf8String m_SwitchPublisherNames_11;

		// Token: 0x04016DB8 RID: 93624
		public PPtr_Texture2D_5_0_0 m_SwitchIcons_0;

		// Token: 0x04016DB9 RID: 93625
		public PPtr_Texture2D_5_0_0 m_SwitchIcons_1;

		// Token: 0x04016DBA RID: 93626
		public PPtr_Texture2D_5_0_0 m_SwitchIcons_2;

		// Token: 0x04016DBB RID: 93627
		public PPtr_Texture2D_5_0_0 m_SwitchIcons_3;

		// Token: 0x04016DBC RID: 93628
		public PPtr_Texture2D_5_0_0 m_SwitchIcons_4;

		// Token: 0x04016DBD RID: 93629
		public PPtr_Texture2D_5_0_0 m_SwitchIcons_5;

		// Token: 0x04016DBE RID: 93630
		public PPtr_Texture2D_5_0_0 m_SwitchIcons_6;

		// Token: 0x04016DBF RID: 93631
		public PPtr_Texture2D_5_0_0 m_SwitchIcons_7;

		// Token: 0x04016DC0 RID: 93632
		public PPtr_Texture2D_5_0_0 m_SwitchIcons_8;

		// Token: 0x04016DC1 RID: 93633
		public PPtr_Texture2D_5_0_0 m_SwitchIcons_9;

		// Token: 0x04016DC2 RID: 93634
		public PPtr_Texture2D_5_0_0 m_SwitchIcons_10;

		// Token: 0x04016DC3 RID: 93635
		public PPtr_Texture2D_5_0_0 m_SwitchIcons_11;

		// Token: 0x04016DC4 RID: 93636
		public PPtr_Texture2D_5_0_0 m_SwitchSmallIcons_0;

		// Token: 0x04016DC5 RID: 93637
		public PPtr_Texture2D_5_0_0 m_SwitchSmallIcons_1;

		// Token: 0x04016DC6 RID: 93638
		public PPtr_Texture2D_5_0_0 m_SwitchSmallIcons_2;

		// Token: 0x04016DC7 RID: 93639
		public PPtr_Texture2D_5_0_0 m_SwitchSmallIcons_3;

		// Token: 0x04016DC8 RID: 93640
		public PPtr_Texture2D_5_0_0 m_SwitchSmallIcons_4;

		// Token: 0x04016DC9 RID: 93641
		public PPtr_Texture2D_5_0_0 m_SwitchSmallIcons_5;

		// Token: 0x04016DCA RID: 93642
		public PPtr_Texture2D_5_0_0 m_SwitchSmallIcons_6;

		// Token: 0x04016DCB RID: 93643
		public PPtr_Texture2D_5_0_0 m_SwitchSmallIcons_7;

		// Token: 0x04016DCC RID: 93644
		public PPtr_Texture2D_5_0_0 m_SwitchSmallIcons_8;

		// Token: 0x04016DCD RID: 93645
		public PPtr_Texture2D_5_0_0 m_SwitchSmallIcons_9;

		// Token: 0x04016DCE RID: 93646
		public PPtr_Texture2D_5_0_0 m_SwitchSmallIcons_10;

		// Token: 0x04016DCF RID: 93647
		public PPtr_Texture2D_5_0_0 m_SwitchSmallIcons_11;

		// Token: 0x04016DD0 RID: 93648
		public Utf8String m_SwitchManualHTML;

		// Token: 0x04016DD1 RID: 93649
		public Utf8String m_SwitchAccessibleURLs;

		// Token: 0x04016DD2 RID: 93650
		public Utf8String m_SwitchLegalInformation;

		// Token: 0x04016DD3 RID: 93651
		public int m_SwitchMainThreadStackSize;

		// Token: 0x04016DD4 RID: 93652
		public Utf8String m_SwitchPresenceGroupId;

		// Token: 0x04016DD5 RID: 93653
		public int m_SwitchLogoHandling;

		// Token: 0x04016DD6 RID: 93654
		public int m_SwitchReleaseVersion;

		// Token: 0x04016DD7 RID: 93655
		public Utf8String m_SwitchDisplayVersion;

		// Token: 0x04016DD8 RID: 93656
		public int m_SwitchStartupUserAccount;

		// Token: 0x04016DD9 RID: 93657
		public int m_SwitchTouchScreenUsage;

		// Token: 0x04016DDA RID: 93658
		public int m_SwitchSupportedLanguagesMask;

		// Token: 0x04016DDB RID: 93659
		public int m_SwitchLogoType;

		// Token: 0x04016DDC RID: 93660
		public Utf8String m_SwitchApplicationErrorCodeCategory;

		// Token: 0x04016DDD RID: 93661
		public int m_SwitchUserAccountSaveDataSize;

		// Token: 0x04016DDE RID: 93662
		public int m_SwitchUserAccountSaveDataJournalSize;

		// Token: 0x04016DDF RID: 93663
		public int m_SwitchApplicationAttribute;

		// Token: 0x04016DE0 RID: 93664
		public int m_SwitchCardSpecSize;

		// Token: 0x04016DE1 RID: 93665
		public int m_SwitchCardSpecClock;

		// Token: 0x04016DE2 RID: 93666
		public int m_SwitchRatingsMask;

		// Token: 0x04016DE3 RID: 93667
		public int m_SwitchRatingsInt_0;

		// Token: 0x04016DE4 RID: 93668
		public int m_SwitchRatingsInt_1;

		// Token: 0x04016DE5 RID: 93669
		public int m_SwitchRatingsInt_2;

		// Token: 0x04016DE6 RID: 93670
		public int m_SwitchRatingsInt_3;

		// Token: 0x04016DE7 RID: 93671
		public int m_SwitchRatingsInt_4;

		// Token: 0x04016DE8 RID: 93672
		public int m_SwitchRatingsInt_5;

		// Token: 0x04016DE9 RID: 93673
		public int m_SwitchRatingsInt_6;

		// Token: 0x04016DEA RID: 93674
		public int m_SwitchRatingsInt_7;

		// Token: 0x04016DEB RID: 93675
		public int m_SwitchRatingsInt_8;

		// Token: 0x04016DEC RID: 93676
		public int m_SwitchRatingsInt_9;

		// Token: 0x04016DED RID: 93677
		public int m_SwitchRatingsInt_10;

		// Token: 0x04016DEE RID: 93678
		public int m_SwitchRatingsInt_11;

		// Token: 0x04016DEF RID: 93679
		public Utf8String m_SwitchLocalCommunicationIds_0;

		// Token: 0x04016DF0 RID: 93680
		public Utf8String m_SwitchLocalCommunicationIds_1;

		// Token: 0x04016DF1 RID: 93681
		public Utf8String m_SwitchLocalCommunicationIds_2;

		// Token: 0x04016DF2 RID: 93682
		public Utf8String m_SwitchLocalCommunicationIds_3;

		// Token: 0x04016DF3 RID: 93683
		public Utf8String m_SwitchLocalCommunicationIds_4;

		// Token: 0x04016DF4 RID: 93684
		public Utf8String m_SwitchLocalCommunicationIds_5;

		// Token: 0x04016DF5 RID: 93685
		public Utf8String m_SwitchLocalCommunicationIds_6;

		// Token: 0x04016DF6 RID: 93686
		public Utf8String m_SwitchLocalCommunicationIds_7;

		// Token: 0x04016DF7 RID: 93687
		public bool m_SwitchParentalControl;

		// Token: 0x04016DF8 RID: 93688
		public bool m_SwitchAllowsScreenshot;

		// Token: 0x04016DF9 RID: 93689
		public bool m_SwitchDataLossConfirmation;

		// Token: 0x04016DFA RID: 93690
		public int m_SwitchSupportedNpadStyles;

		// Token: 0x04016DFB RID: 93691
		public bool m_SwitchSocketConfigEnabled;

		// Token: 0x04016DFC RID: 93692
		public int m_SwitchTcpInitialSendBufferSize;

		// Token: 0x04016DFD RID: 93693
		public int m_SwitchTcpInitialReceiveBufferSize;

		// Token: 0x04016DFE RID: 93694
		public int m_SwitchTcpAutoSendBufferSizeMax;

		// Token: 0x04016DFF RID: 93695
		public int m_SwitchTcpAutoReceiveBufferSizeMax;

		// Token: 0x04016E00 RID: 93696
		public int m_SwitchUdpSendBufferSize;

		// Token: 0x04016E01 RID: 93697
		public int m_SwitchUdpReceiveBufferSize;

		// Token: 0x04016E02 RID: 93698
		public int m_SwitchSocketBufferEfficiency;

		// Token: 0x04016E03 RID: 93699
		public int m_Ps4NPAgeRating;

		// Token: 0x04016E04 RID: 93700
		public Utf8String m_Ps4NPTitleSecret;

		// Token: 0x04016E05 RID: 93701
		public Utf8String m_Ps4NPTrophyPackPath;

		// Token: 0x04016E06 RID: 93702
		public int m_Ps4ParentalLevel;

		// Token: 0x04016E07 RID: 93703
		public Utf8String m_Ps4ContentID;

		// Token: 0x04016E08 RID: 93704
		public int m_Ps4Category;

		// Token: 0x04016E09 RID: 93705
		public Utf8String m_Ps4MasterVersion;

		// Token: 0x04016E0A RID: 93706
		public Utf8String m_Ps4AppVersion;

		// Token: 0x04016E0B RID: 93707
		public int m_Ps4AppType;

		// Token: 0x04016E0C RID: 93708
		public Utf8String m_Ps4ParamSfxPath;

		// Token: 0x04016E0D RID: 93709
		public int m_Ps4VideoOutPixelFormat;

		// Token: 0x04016E0E RID: 93710
		public int m_Ps4VideoOutInitialWidth;

		// Token: 0x04016E0F RID: 93711
		public int m_Ps4VideoOutBaseModeInitialWidth;

		// Token: 0x04016E10 RID: 93712
		public int m_Ps4VideoOutReprojectionRate;

		// Token: 0x04016E11 RID: 93713
		public Utf8String m_Ps4PronunciationXMLPath;

		// Token: 0x04016E12 RID: 93714
		public Utf8String m_Ps4PronunciationSIGPath;

		// Token: 0x04016E13 RID: 93715
		public Utf8String m_Ps4BackgroundImagePath;

		// Token: 0x04016E14 RID: 93716
		public Utf8String m_Ps4StartupImagePath;

		// Token: 0x04016E15 RID: 93717
		public Utf8String m_Ps4SaveDataImagePath;

		// Token: 0x04016E16 RID: 93718
		public Utf8String m_Ps4SdkOverride;

		// Token: 0x04016E17 RID: 93719
		public Utf8String m_Ps4BGMPath;

		// Token: 0x04016E18 RID: 93720
		public Utf8String m_Ps4ShareFilePath;

		// Token: 0x04016E19 RID: 93721
		public Utf8String m_Ps4ShareOverlayImagePath;

		// Token: 0x04016E1A RID: 93722
		public Utf8String m_Ps4PrivacyGuardImagePath;

		// Token: 0x04016E1B RID: 93723
		public Utf8String m_Ps4NPtitleDatPath;

		// Token: 0x04016E1C RID: 93724
		public int m_Ps4RemotePlayKeyAssignment;

		// Token: 0x04016E1D RID: 93725
		public Utf8String m_Ps4RemotePlayKeyMappingDir;

		// Token: 0x04016E1E RID: 93726
		public int m_Ps4PlayTogetherPlayerCount;

		// Token: 0x04016E1F RID: 93727
		public int m_Ps4EnterButtonAssignment;

		// Token: 0x04016E20 RID: 93728
		public int m_Ps4ApplicationParam1;

		// Token: 0x04016E21 RID: 93729
		public int m_Ps4ApplicationParam2;

		// Token: 0x04016E22 RID: 93730
		public int m_Ps4ApplicationParam3;

		// Token: 0x04016E23 RID: 93731
		public int m_Ps4ApplicationParam4;

		// Token: 0x04016E24 RID: 93732
		public int m_Ps4DownloadDataSize;

		// Token: 0x04016E25 RID: 93733
		public int m_Ps4GarlicHeapSize;

		// Token: 0x04016E26 RID: 93734
		public int m_Ps4ProGarlicHeapSize;

		// Token: 0x04016E27 RID: 93735
		public Utf8String m_Ps4Passcode;

		// Token: 0x04016E28 RID: 93736
		public bool m_Ps4pnSessions;

		// Token: 0x04016E29 RID: 93737
		public bool m_Ps4pnPresence;

		// Token: 0x04016E2A RID: 93738
		public bool m_Ps4pnFriends;

		// Token: 0x04016E2B RID: 93739
		public bool m_Ps4pnGameCustomData;

		// Token: 0x04016E2C RID: 93740
		public bool m_PlayerPrefsSupport;

		// Token: 0x04016E2D RID: 93741
		public bool m_RestrictedAudioUsageRights;

		// Token: 0x04016E2E RID: 93742
		public bool m_Ps4UseResolutionFallback;

		// Token: 0x04016E2F RID: 93743
		public bool m_Ps4ReprojectionSupport;

		// Token: 0x04016E30 RID: 93744
		public bool m_Ps4UseAudio3dBackend;

		// Token: 0x04016E31 RID: 93745
		public bool m_Ps4SocialScreenEnabled;

		// Token: 0x04016E32 RID: 93746
		public int m_Ps4ScriptOptimizationLevel;

		// Token: 0x04016E33 RID: 93747
		public int m_Ps4Audio3dVirtualSpeakerCount;

		// Token: 0x04016E34 RID: 93748
		public int m_Ps4attribCpuUsage;

		// Token: 0x04016E35 RID: 93749
		public Utf8String m_Ps4PatchPkgPath;

		// Token: 0x04016E36 RID: 93750
		public Utf8String m_Ps4PatchLatestPkgPath;

		// Token: 0x04016E37 RID: 93751
		public Utf8String m_Ps4PatchChangeinfoPath;

		// Token: 0x04016E38 RID: 93752
		public bool m_Ps4PatchDayOne;

		// Token: 0x04016E39 RID: 93753
		public bool m_Ps4attribUserManagement;

		// Token: 0x04016E3A RID: 93754
		public bool m_Ps4attribMoveSupport;

		// Token: 0x04016E3B RID: 93755
		public bool m_Ps4attrib3DSupport;

		// Token: 0x04016E3C RID: 93756
		public bool m_Ps4attribShareSupport;

		// Token: 0x04016E3D RID: 93757
		public bool m_Ps4attribExclusiveVR;

		// Token: 0x04016E3E RID: 93758
		public bool m_Ps4disableAutoHideSplash;

		// Token: 0x04016E3F RID: 93759
		public bool m_Ps4videoRecordingFeaturesUsed;

		// Token: 0x04016E40 RID: 93760
		public bool m_Ps4contentSearchFeaturesUsed;

		// Token: 0x04016E41 RID: 93761
		public int m_Ps4attribEyeToEyeDistanceSettingVR;

		// Token: 0x04016E42 RID: 93762
		public AssetList<Utf8String> m_Ps4IncludedModules;

		// Token: 0x04016E43 RID: 93763
		public Utf8String m_MonoEnv;

		// Token: 0x04016E44 RID: 93764
		public PPtr_Texture2D_5_0_0 m_Psp2Splashimage;

		// Token: 0x04016E45 RID: 93765
		public Utf8String m_Psp2NPTrophyPackPath;

		// Token: 0x04016E46 RID: 93766
		public bool m_Psp2NPSupportGBMorGJP;

		// Token: 0x04016E47 RID: 93767
		public int m_Psp2NPAgeRating;

		// Token: 0x04016E48 RID: 93768
		public Utf8String m_Psp2NPTitleDatPath;

		// Token: 0x04016E49 RID: 93769
		public Utf8String m_Psp2NPCommsID;

		// Token: 0x04016E4A RID: 93770
		public Utf8String m_Psp2NPCommunicationsID;

		// Token: 0x04016E4B RID: 93771
		public Utf8String m_Psp2NPCommsPassphrase;

		// Token: 0x04016E4C RID: 93772
		public Utf8String m_Psp2NPCommsSig;

		// Token: 0x04016E4D RID: 93773
		public Utf8String m_Psp2ParamSfxPath;

		// Token: 0x04016E4E RID: 93774
		public Utf8String m_Psp2ManualPath;

		// Token: 0x04016E4F RID: 93775
		public Utf8String m_Psp2LiveAreaGatePath;

		// Token: 0x04016E50 RID: 93776
		public Utf8String m_Psp2LiveAreaBackroundPath;

		// Token: 0x04016E51 RID: 93777
		public Utf8String m_Psp2LiveAreaPath;

		// Token: 0x04016E52 RID: 93778
		public Utf8String m_Psp2LiveAreaTrialPath;

		// Token: 0x04016E53 RID: 93779
		public Utf8String m_Psp2PatchChangeInfoPath;

		// Token: 0x04016E54 RID: 93780
		public Utf8String m_Psp2PatchOriginalPackage;

		// Token: 0x04016E55 RID: 93781
		public Utf8String m_Psp2PackagePassword;

		// Token: 0x04016E56 RID: 93782
		public Utf8String m_Psp2KeystoneFile;

		// Token: 0x04016E57 RID: 93783
		public int m_Psp2MemoryExpansionMode;

		// Token: 0x04016E58 RID: 93784
		public int m_Psp2DRMType;

		// Token: 0x04016E59 RID: 93785
		public int m_Psp2StorageType;

		// Token: 0x04016E5A RID: 93786
		public int m_Psp2MediaCapacity;

		// Token: 0x04016E5B RID: 93787
		public Utf8String m_Psp2DLCConfigPath;

		// Token: 0x04016E5C RID: 93788
		public Utf8String m_Psp2ThumbnailPath;

		// Token: 0x04016E5D RID: 93789
		public Utf8String m_Psp2BackgroundPath;

		// Token: 0x04016E5E RID: 93790
		public Utf8String m_Psp2SoundPath;

		// Token: 0x04016E5F RID: 93791
		public Utf8String m_Psp2TrophyCommId;

		// Token: 0x04016E60 RID: 93792
		public Utf8String m_Psp2TrophyPackagePath;

		// Token: 0x04016E61 RID: 93793
		public Utf8String m_Psp2PackagedResourcesPath;

		// Token: 0x04016E62 RID: 93794
		public int m_Psp2SaveDataQuota;

		// Token: 0x04016E63 RID: 93795
		public int m_Psp2ParentalLevel;

		// Token: 0x04016E64 RID: 93796
		public Utf8String m_Psp2ShortTitle;

		// Token: 0x04016E65 RID: 93797
		public Utf8String m_Psp2ContentID;

		// Token: 0x04016E66 RID: 93798
		public int m_Psp2Category;

		// Token: 0x04016E67 RID: 93799
		public Utf8String m_Psp2MasterVersion;

		// Token: 0x04016E68 RID: 93800
		public Utf8String m_Psp2AppVersion;

		// Token: 0x04016E69 RID: 93801
		public int m_Psp2TVBootMode;

		// Token: 0x04016E6A RID: 93802
		public int m_Psp2EnterButtonAssignment;

		// Token: 0x04016E6B RID: 93803
		public bool m_Psp2TVDisableEmu;

		// Token: 0x04016E6C RID: 93804
		public bool m_Psp2AllowTwitterDialog;

		// Token: 0x04016E6D RID: 93805
		public bool m_Psp2Upgradable;

		// Token: 0x04016E6E RID: 93806
		public bool m_Psp2HealthWarning;

		// Token: 0x04016E6F RID: 93807
		public bool m_Psp2UseLibLocation;

		// Token: 0x04016E70 RID: 93808
		public bool m_Psp2InfoBarOnStartup;

		// Token: 0x04016E71 RID: 93809
		public bool m_Psp2InfoBarColor;

		// Token: 0x04016E72 RID: 93810
		public int m_Psp2ScriptOptimizationLevel;

		// Token: 0x04016E73 RID: 93811
		public PPtr_Texture2D_5_0_0 m_PsmSplashimage;

		// Token: 0x04016E74 RID: 93812
		public PPtr_Sprite_5_0_0 m_SplashScreenBackgroundSourceLandscape;

		// Token: 0x04016E75 RID: 93813
		public PPtr_Sprite_5_0_0 m_SplashScreenBackgroundSourcePortrait;

		// Token: 0x04016E76 RID: 93814
		public Utf8String m_SpritePackerPolicy;

		// Token: 0x04016E77 RID: 93815
		public int m_WebGLMemorySize;

		// Token: 0x04016E78 RID: 93816
		public int m_WebGLExceptionSupport;

		// Token: 0x04016E79 RID: 93817
		public bool m_WebGLNameFilesAsHashes;

		// Token: 0x04016E7A RID: 93818
		public bool m_WebGLDataCaching;

		// Token: 0x04016E7B RID: 93819
		public bool m_WebGLDebugSymbols;

		// Token: 0x04016E7C RID: 93820
		public Utf8String m_WebGLEmscriptenArgs;

		// Token: 0x04016E7D RID: 93821
		public Utf8String m_WebGLModulesDirectory;

		// Token: 0x04016E7E RID: 93822
		public Utf8String m_WebGLTemplate;

		// Token: 0x04016E7F RID: 93823
		public bool m_WebGLAnalyzeBuildSize;

		// Token: 0x04016E80 RID: 93824
		public bool m_WebGLUseEmbeddedResources;

		// Token: 0x04016E81 RID: 93825
		public bool m_WebGLUseWasm;

		// Token: 0x04016E82 RID: 93826
		public int m_WebGLCompressionFormat;

		// Token: 0x04016E83 RID: 93827
		public AssetDictionary<int, Utf8String> m_ScriptingDefineSymbols;

		// Token: 0x04016E84 RID: 93828
		public AssetDictionary<Utf8String, int> m_PlatformArchitecture;

		// Token: 0x04016E85 RID: 93829
		public AssetDictionary<Utf8String, int> m_ScriptingBackend;

		// Token: 0x04016E86 RID: 93830
		public AssetDictionary<Utf8String, bool> m_IncrementalIl2cppBuild;

		// Token: 0x04016E87 RID: 93831
		public Utf8String m_AdditionalIl2CppArgs;

		// Token: 0x04016E88 RID: 93832
		public int m_ScriptingRuntimeVersion;

		// Token: 0x04016E89 RID: 93833
		public AssetDictionary<Utf8String, int> m_ApiCompatibilityLevelPerPlatform;

		// Token: 0x04016E8A RID: 93834
		public int m_RenderingPath;

		// Token: 0x04016E8B RID: 93835
		public int m_MobileRenderingPath;

		// Token: 0x04016E8C RID: 93836
		public Utf8String m_MetroPackageName;

		// Token: 0x04016E8D RID: 93837
		public Utf8String m_MetroPackageVersion;

		// Token: 0x04016E8E RID: 93838
		public Utf8String m_MetroCertificatePath;

		// Token: 0x04016E8F RID: 93839
		public Utf8String m_MetroCertificatePassword;

		// Token: 0x04016E90 RID: 93840
		public Utf8String m_MetroCertificateSubject;

		// Token: 0x04016E91 RID: 93841
		public Utf8String m_MetroCertificateIssuer;

		// Token: 0x04016E92 RID: 93842
		public long m_MetroCertificateNotAfter;

		// Token: 0x04016E93 RID: 93843
		public Utf8String m_MetroApplicationDescription;

		// Token: 0x04016E94 RID: 93844
		public AssetDictionary<int, Utf8String> m_WsaImages;

		// Token: 0x04016E95 RID: 93845
		public Utf8String m_MetroTileShortName;

		// Token: 0x04016E96 RID: 93846
		public Utf8String m_MetroCommandLineArgsFile;

		// Token: 0x04016E97 RID: 93847
		public int m_MetroTileShowName;

		// Token: 0x04016E98 RID: 93848
		public bool m_MetroMediumTileShowName;

		// Token: 0x04016E99 RID: 93849
		public bool m_MetroLargeTileShowName;

		// Token: 0x04016E9A RID: 93850
		public bool m_MetroWideTileShowName;

		// Token: 0x04016E9B RID: 93851
		public int m_MetroDefaultTileSize;

		// Token: 0x04016E9C RID: 93852
		public int m_MetroTileForegroundText;

		// Token: 0x04016E9D RID: 93853
		public ColorRGBAf_3_5_0 m_MetroTileBackgroundColor;

		// Token: 0x04016E9E RID: 93854
		public ColorRGBAf_3_5_0 m_MetroSplashScreenBackgroundColor;

		// Token: 0x04016E9F RID: 93855
		public bool m_MetroSplashScreenUseBackgroundColor;

		// Token: 0x04016EA0 RID: 93856
		public AssetDictionary<Utf8String, AssetDictionary<Utf8String, Utf8String>> m_PlatformCapabilities;

		// Token: 0x04016EA1 RID: 93857
		public Utf8String m_MetroFTAName;

		// Token: 0x04016EA2 RID: 93858
		public AssetList<MetroFTAFileType> m_MetroFTAFileTypes;

		// Token: 0x04016EA3 RID: 93859
		public Utf8String m_MetroProtocolName;

		// Token: 0x04016EA4 RID: 93860
		public int m_MetroCompilationOverrides;

		// Token: 0x04016EA5 RID: 93861
		public Utf8String m_TizenProductDescription;

		// Token: 0x04016EA6 RID: 93862
		public Utf8String m_TizenProductURL;

		// Token: 0x04016EA7 RID: 93863
		public Utf8String m_TizenSigningProfileName;

		// Token: 0x04016EA8 RID: 93864
		public bool m_TizenGPSPermissions;

		// Token: 0x04016EA9 RID: 93865
		public bool m_TizenMicrophonePermissions;

		// Token: 0x04016EAA RID: 93866
		public Utf8String m_TizenDeploymentTarget;

		// Token: 0x04016EAB RID: 93867
		public int m_TizenDeploymentTargetType;

		// Token: 0x04016EAC RID: 93868
		public int m_TizenMinOSVersion;

		// Token: 0x04016EAD RID: 93869
		public bool m_N3dsUseExtSaveData;

		// Token: 0x04016EAE RID: 93870
		public bool m_N3dsCompressStaticMem;

		// Token: 0x04016EAF RID: 93871
		public Utf8String m_N3dsExtSaveDataNumber;

		// Token: 0x04016EB0 RID: 93872
		public int m_N3dsStackSize;

		// Token: 0x04016EB1 RID: 93873
		public byte m_N3dsTargetPlatform;

		// Token: 0x04016EB2 RID: 93874
		public byte m_N3dsRegion;

		// Token: 0x04016EB3 RID: 93875
		public byte m_N3dsMediaSize;

		// Token: 0x04016EB4 RID: 93876
		public byte m_N3dsLogoStyle;

		// Token: 0x04016EB5 RID: 93877
		public Utf8String m_N3dsTitle;

		// Token: 0x04016EB6 RID: 93878
		public Utf8String m_N3dsProductCode;

		// Token: 0x04016EB7 RID: 93879
		public Utf8String m_N3dsApplicationId;

		// Token: 0x04016EB8 RID: 93880
		public Utf8String m_StvDeviceAddress;

		// Token: 0x04016EB9 RID: 93881
		public Utf8String m_StvProductDescription;

		// Token: 0x04016EBA RID: 93882
		public Utf8String m_StvProductAuthor;

		// Token: 0x04016EBB RID: 93883
		public Utf8String m_StvProductAuthorEmail;

		// Token: 0x04016EBC RID: 93884
		public Utf8String m_StvProductLink;

		// Token: 0x04016EBD RID: 93885
		public int m_StvProductCategory;

		// Token: 0x04016EBE RID: 93886
		public Utf8String m_XboxOneProductId;

		// Token: 0x04016EBF RID: 93887
		public Utf8String m_XboxOneUpdateKey;

		// Token: 0x04016EC0 RID: 93888
		public Utf8String m_XboxOneSandboxId;

		// Token: 0x04016EC1 RID: 93889
		public Utf8String m_XboxOneContentId;

		// Token: 0x04016EC2 RID: 93890
		public Utf8String m_XboxOneTitleId;

		// Token: 0x04016EC3 RID: 93891
		public Utf8String m_XboxOneSCId;

		// Token: 0x04016EC4 RID: 93892
		public Utf8String m_XboxOneGameOsOverridePath;

		// Token: 0x04016EC5 RID: 93893
		public Utf8String m_XboxOnePackagingOverridePath;

		// Token: 0x04016EC6 RID: 93894
		public Utf8String m_XboxOneAppManifestOverridePath;

		// Token: 0x04016EC7 RID: 93895
		public int m_XboxOnePackageEncryption;

		// Token: 0x04016EC8 RID: 93896
		public int m_XboxOnePackageUpdateGranularity;

		// Token: 0x04016EC9 RID: 93897
		public Utf8String m_XboxOneDescription;

		// Token: 0x04016ECA RID: 93898
		public AssetList<Utf8String> m_XboxOneLanguage;

		// Token: 0x04016ECB RID: 93899
		public AssetList<Utf8String> m_XboxOneCapability;

		// Token: 0x04016ECC RID: 93900
		public AssetDictionary<Utf8String, int> m_XboxOneGameRating;

		// Token: 0x04016ECD RID: 93901
		public bool m_XboxOneIsContentPackage;

		// Token: 0x04016ECE RID: 93902
		public bool m_XboxOneEnableGPUVariability;

		// Token: 0x04016ECF RID: 93903
		public AssetDictionary<Utf8String, XboxOneSocketDefinition_2017_1_0> m_XboxOneSockets;

		// Token: 0x04016ED0 RID: 93904
		public PPtr_Texture2D_5_0_0 m_XboxOneSplashScreen;

		// Token: 0x04016ED1 RID: 93905
		public AssetList<Utf8String> m_XboxOneAllowedProductIds;

		// Token: 0x04016ED2 RID: 93906
		public uint m_XboxOnePersistentLocalStorageSize;

		// Token: 0x04016ED3 RID: 93907
		public int m_XboxOneScriptCompiler;

		// Token: 0x04016ED4 RID: 93908
		public VREditorSettings_5_6_0 m_VrEditorSettings;

		// Token: 0x04016ED5 RID: 93909
		public AssetDictionary<Utf8String, bool> m_CloudServicesEnabled;

		// Token: 0x04016ED6 RID: 93910
		public Utf8String m_FacebookSdkVersion;

		// Token: 0x04016ED7 RID: 93911
		public int m_ApiCompatibilityLevel;

		// Token: 0x04016ED8 RID: 93912
		public GUID m_ProductGUID;

		// Token: 0x04016ED9 RID: 93913
		public bool m_AndroidProfiler;

		// Token: 0x04016EDA RID: 93914
		public int m_DefaultScreenOrientation;

		// Token: 0x04016EDB RID: 93915
		public int m_TargetDevice;

		// Token: 0x04016EDC RID: 93916
		public bool m_UseOnDemandResources;

		// Token: 0x04016EDD RID: 93917
		public int m_AccelerometerFrequency;

		// Token: 0x04016EDE RID: 93918
		public Utf8String m_CompanyName;

		// Token: 0x04016EDF RID: 93919
		public Utf8String m_ProductName;

		// Token: 0x04016EE0 RID: 93920
		public PPtr_Texture2D_5_0_0 m_DefaultCursor;

		// Token: 0x04016EE1 RID: 93921
		public Vector2f_3_5_0 m_CursorHotspot;

		// Token: 0x04016EE2 RID: 93922
		public ColorRGBAf_3_5_0 m_SplashScreenBackgroundColor;

		// Token: 0x04016EE3 RID: 93923
		public bool m_ShowUnitySplashScreen;

		// Token: 0x04016EE4 RID: 93924
		public bool m_ShowUnitySplashLogo;

		// Token: 0x04016EE5 RID: 93925
		public float m_SplashScreenOverlayOpacity;

		// Token: 0x04016EE6 RID: 93926
		public int m_SplashScreenAnimation;

		// Token: 0x04016EE7 RID: 93927
		public int m_SplashScreenLogoStyle;

		// Token: 0x04016EE8 RID: 93928
		public int m_SplashScreenDrawMode;

		// Token: 0x04016EE9 RID: 93929
		public float m_SplashScreenBackgroundAnimationZoom;

		// Token: 0x04016EEA RID: 93930
		public float m_SplashScreenLogoAnimationZoom;

		// Token: 0x04016EEB RID: 93931
		public float m_SplashScreenBackgroundLandscapeAspect;

		// Token: 0x04016EEC RID: 93932
		public float m_SplashScreenBackgroundPortraitAspect;

		// Token: 0x04016EED RID: 93933
		public Rectf m_SplashScreenBackgroundLandscapeUvs;

		// Token: 0x04016EEE RID: 93934
		public Rectf m_SplashScreenBackgroundPortraitUvs;

		// Token: 0x04016EEF RID: 93935
		public AssetList<SplashScreenLogo> m_SplashScreenLogos;

		// Token: 0x04016EF0 RID: 93936
		public PPtr_Texture2D_5_0_0 m_SplashScreenBackgroundLandscape;

		// Token: 0x04016EF1 RID: 93937
		public PPtr_Texture2D_5_0_0 m_SplashScreenBackgroundPortrait;

		// Token: 0x04016EF2 RID: 93938
		public PPtr_Texture2D_5_0_0 m_VirtualRealitySplashScreen;

		// Token: 0x04016EF3 RID: 93939
		public PPtr_Texture2D_5_0_0 m_HolographicTrackingLossScreen;

		// Token: 0x04016EF4 RID: 93940
		public int m_DefaultScreenWidth;

		// Token: 0x04016EF5 RID: 93941
		public int m_DefaultScreenHeight;

		// Token: 0x04016EF6 RID: 93942
		public int m_DefaultScreenWidthWeb;

		// Token: 0x04016EF7 RID: 93943
		public int m_DefaultScreenHeightWeb;

		// Token: 0x04016EF8 RID: 93944
		public int m_StereoRenderingPath;

		// Token: 0x04016EF9 RID: 93945
		public int m_ActiveColorSpace;

		// Token: 0x04016EFA RID: 93946
		public bool m_MTRendering;

		// Token: 0x04016EFB RID: 93947
		public bool m_MobileMTRendering;

		// Token: 0x04016EFC RID: 93948
		public int[] m_StackTraceTypes;

		// Token: 0x04016EFD RID: 93949
		public int m_IosShowActivityIndicatorOnLoading;

		// Token: 0x04016EFE RID: 93950
		public int m_AndroidShowActivityIndicatorOnLoading;

		// Token: 0x04016EFF RID: 93951
		public int m_TizenShowActivityIndicatorOnLoading;

		// Token: 0x04016F00 RID: 93952
		public int m_IosAppInBackgroundBehavior;

		// Token: 0x04016F01 RID: 93953
		public int m_DisplayResolutionDialog;

		// Token: 0x04016F02 RID: 93954
		public bool m_IosAllowHTTPDownload;

		// Token: 0x04016F03 RID: 93955
		public bool m_AllowedAutorotateToPortrait;

		// Token: 0x04016F04 RID: 93956
		public bool m_AllowedAutorotateToPortraitUpsideDown;

		// Token: 0x04016F05 RID: 93957
		public bool m_AllowedAutorotateToLandscapeRight;

		// Token: 0x04016F06 RID: 93958
		public bool m_AllowedAutorotateToLandscapeLeft;

		// Token: 0x04016F07 RID: 93959
		public bool m_UseOSAutorotation;

		// Token: 0x04016F08 RID: 93960
		public bool m_Use32BitDisplayBuffer;

		// Token: 0x04016F09 RID: 93961
		public bool m_DisableDepthAndStencilBuffers;

		// Token: 0x04016F0A RID: 93962
		public bool m_DefaultIsFullScreen;

		// Token: 0x04016F0B RID: 93963
		public bool m_DefaultIsNativeResolution;

		// Token: 0x04016F0C RID: 93964
		public bool m_RunInBackground;

		// Token: 0x04016F0D RID: 93965
		public bool m_CaptureSingleScreen;

		// Token: 0x04016F0E RID: 93966
		public bool m_MuteOtherAudioSources;

		// Token: 0x04016F0F RID: 93967
		public bool m_Prepare_IOS_For_Recording;

		// Token: 0x04016F10 RID: 93968
		public bool m_Force_IOS_Speakers_When_Recording;

		// Token: 0x04016F11 RID: 93969
		public bool m_SubmitAnalytics;

		// Token: 0x04016F12 RID: 93970
		public bool m_UsePlayerLog;

		// Token: 0x04016F13 RID: 93971
		public bool m_BakeCollisionMeshes;

		// Token: 0x04016F14 RID: 93972
		public bool m_ForceSingleInstance;

		// Token: 0x04016F15 RID: 93973
		public bool m_ResizableWindow;

		// Token: 0x04016F16 RID: 93974
		public bool m_UseMacAppStoreValidation;

		// Token: 0x04016F17 RID: 93975
		public Utf8String m_MacAppStoreCategory;

		// Token: 0x04016F18 RID: 93976
		public bool m_GpuSkinning;

		// Token: 0x04016F19 RID: 93977
		public bool m_GraphicsJobs;

		// Token: 0x04016F1A RID: 93978
		public bool m_XboxPIXTextureCapture;

		// Token: 0x04016F1B RID: 93979
		public bool m_XboxEnableAvatar;

		// Token: 0x04016F1C RID: 93980
		public bool m_XboxEnableKinect;

		// Token: 0x04016F1D RID: 93981
		public bool m_XboxEnableKinectAutoTracking;

		// Token: 0x04016F1E RID: 93982
		public bool m_XboxEnableFitness;

		// Token: 0x04016F1F RID: 93983
		public bool m_VisibleInBackground;

		// Token: 0x04016F20 RID: 93984
		public bool m_AllowFullscreenSwitch;

		// Token: 0x04016F21 RID: 93985
		public int m_GraphicsJobMode;

		// Token: 0x04016F22 RID: 93986
		public int m_MacFullscreenMode;

		// Token: 0x04016F23 RID: 93987
		public int m_D3d9FullscreenMode;

		// Token: 0x04016F24 RID: 93988
		public int m_D3d11FullscreenMode;

		// Token: 0x04016F25 RID: 93989
		public uint m_XboxSpeechDB;

		// Token: 0x04016F26 RID: 93990
		public bool m_XboxEnableHeadOrientation;

		// Token: 0x04016F27 RID: 93991
		public bool m_XboxEnableGuest;

		// Token: 0x04016F28 RID: 93992
		public bool m_XboxEnablePIXSampling;

		// Token: 0x04016F29 RID: 93993
		public bool m_N3dsDisableStereoscopicView;

		// Token: 0x04016F2A RID: 93994
		public bool m_N3dsEnableSharedListOpt;

		// Token: 0x04016F2B RID: 93995
		public bool m_N3dsEnableVSync;

		// Token: 0x04016F2C RID: 93996
		public bool m_IgnoreAlphaClear;

		// Token: 0x04016F2D RID: 93997
		public int m_XboxOneResolution;

		// Token: 0x04016F2E RID: 93998
		public int m_XboxOneMonoLoggingLevel;

		// Token: 0x04016F2F RID: 93999
		public int m_XboxOneLoggingLevel;

		// Token: 0x04016F30 RID: 94000
		public bool m_XboxOneDisableEsram;

		// Token: 0x04016F31 RID: 94001
		public int m_VideoMemoryForVertexBuffers;

		// Token: 0x04016F32 RID: 94002
		public int m_Psp2PowerMode;

		// Token: 0x04016F33 RID: 94003
		public bool m_Psp2AcquireBGM;

		// Token: 0x04016F34 RID: 94004
		public int m_WiiUTVResolution;

		// Token: 0x04016F35 RID: 94005
		public int m_WiiUGamePadMSAA;

		// Token: 0x04016F36 RID: 94006
		public bool m_WiiUSupportsNunchuk;

		// Token: 0x04016F37 RID: 94007
		public bool m_WiiUSupportsClassicController;

		// Token: 0x04016F38 RID: 94008
		public bool m_WiiUSupportsBalanceBoard;

		// Token: 0x04016F39 RID: 94009
		public bool m_WiiUSupportsMotionPlus;

		// Token: 0x04016F3A RID: 94010
		public bool m_WiiUSupportsProController;

		// Token: 0x04016F3B RID: 94011
		public bool m_WiiUAllowScreenCapture;

		// Token: 0x04016F3C RID: 94012
		public int m_WiiUControllerCount;

		// Token: 0x04016F3D RID: 94013
		public AspectRatios m_SupportedAspectRatios;

		// Token: 0x04016F3E RID: 94014
		public Utf8String m_BundleVersion;

		// Token: 0x04016F3F RID: 94015
		public AssetList<PPtr_Object_5_0_0> m_PreloadedAssets;

		// Token: 0x04016F40 RID: 94016
		public int m_MetroInputSource;

		// Token: 0x04016F41 RID: 94017
		public bool m_HolographicPauseOnTrackingLoss;

		// Token: 0x04016F42 RID: 94018
		public bool m_XboxOneDisableKinectGpuReservation;

		// Token: 0x04016F43 RID: 94019
		public bool m_XboxOneEnable7thCore;

		// Token: 0x04016F44 RID: 94020
		public VRSettings_5_6_0_b3 m_VrSettings;

		// Token: 0x04016F45 RID: 94021
		public bool m_ProtectGraphicsMemory;

		// Token: 0x04016F46 RID: 94022
		public bool m_UseHDRDisplay;

		// Token: 0x04016F47 RID: 94023
		public int m_TargetPixelDensity;

		// Token: 0x04016F48 RID: 94024
		public int m_ResolutionScalingMode;

		// Token: 0x04016F49 RID: 94025
		public Utf8String m_CloudProjectId;

		// Token: 0x04016F4A RID: 94026
		public Utf8String m_ProjectName;

		// Token: 0x04016F4B RID: 94027
		public Utf8String m_OrganizationId;

		// GICB2
		public Utf8String m_ShaderCollectProductName;

		public Utf8String m_ShaderCollectServer;

		// Token: 0x04016F4C RID: 94028
		public bool m_CloudEnabled;

		// Token: 0x04016F4D RID: 94029
		public bool m_EnableNativePlatformBackendsForNewInputSystem;

		// Token: 0x04016F4E RID: 94030
		public bool m_DisableOldInputManagerSupport;
	}
}
