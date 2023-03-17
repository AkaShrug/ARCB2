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
using AssetRipper.Assets.Interfaces;
using AssetRipper.Assets.IO;
using AssetRipper.Assets.IO.Reading;
using AssetRipper.Assets.IO.Writing;
using AssetRipper.Assets.Metadata;
using AssetRipper.IO.Files.SerializedFiles.Parser.TypeTrees;
using AssetRipper.SourceGenerated.Classes.ClassID_0;
using AssetRipper.SourceGenerated.Classes.ClassID_108;
using AssetRipper.SourceGenerated.Classes.ClassID_21;
using AssetRipper.SourceGenerated.Classes.ClassID_27;
using AssetRipper.SourceGenerated.Classes.ClassID_28;
using AssetRipper.SourceGenerated.Classes.ClassID_3;
using AssetRipper.SourceGenerated.Classes.ClassID_89;
using AssetRipper.SourceGenerated.Classes.ClassID_9;
using AssetRipper.SourceGenerated.Enums;
using AssetRipper.SourceGenerated.Helpers;
using AssetRipper.SourceGenerated.Interfaces;
using AssetRipper.SourceGenerated.MarkerInterfaces;
using AssetRipper.SourceGenerated.Subclasses.ColorRGBAf;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Cubemap;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Light;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Material;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Texture2D;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Texture;
using AssetRipper.SourceGenerated.Subclasses.SphericalHarmonicsL2;
using AssetRipper.Yaml;
using AssetRipper.SourceGenerated.Classes.ClassID_104;
using AssetRipper.SourceGenerated.Subclasses.Vector4f;

namespace AssetRipper.Import.GICB2.RenderSettings
{
	// Token: 0x02003550 RID: 13648


	public sealed class RenderSettings_5_6_0_GICB2 : LevelGameManager, IRenderSettings, IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IRenderSettingsMarker, ILevelGameManager, IGameManager, IGameManagerMarker, IObject, IObjectMarker, IHasHideFlags, ILevelGameManagerMarker
	{
		// Token: 0x1702520D RID: 152077
		// (get) Token: 0x06067EFE RID: 425726 RVA: 0x01575EF6 File Offset: 0x015740F6
		public ColorRGBAf_3_5_0 AmbientEquatorColor_C104
		{
			[return: NotNull]
			get
			{
				return this.m_AmbientEquatorColor;
			}
		}

		// Token: 0x1702520E RID: 152078
		// (get) Token: 0x06067EFF RID: 425727 RVA: 0x01575EFE File Offset: 0x015740FE
		public ColorRGBAf_3_5_0 AmbientGroundColor_C104
		{
			[return: NotNull]
			get
			{
				return this.m_AmbientGroundColor;
			}
		}

		// Token: 0x1702520F RID: 152079
		// (get) Token: 0x06067F00 RID: 425728 RVA: 0x01575F06 File Offset: 0x01574106
		// (set) Token: 0x06067F01 RID: 425729 RVA: 0x01575F0E File Offset: 0x0157410E
		public float AmbientIntensity_C104
		{
			get
			{
				return this.m_AmbientIntensity;
			}
			set
			{
				this.m_AmbientIntensity = value;
			}
		}

		// Token: 0x17025210 RID: 152080
		// (get) Token: 0x06067F02 RID: 425730 RVA: 0x01575F17 File Offset: 0x01574117
		public IColorRGBAf AmbientLight_C104
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17025211 RID: 152081
		// (get) Token: 0x06067F03 RID: 425731 RVA: 0x01575F1A File Offset: 0x0157411A
		// (set) Token: 0x06067F04 RID: 425732 RVA: 0x01575F22 File Offset: 0x01574122
		public int AmbientMode_C104
		{
			get
			{
				return this.m_AmbientMode;
			}
			set
			{
				this.m_AmbientMode = value;
			}
		}

		// Token: 0x17025212 RID: 152082
		// (get) Token: 0x06067F05 RID: 425733 RVA: 0x01575F2B File Offset: 0x0157412B
		public SphericalHarmonicsL2_5_0_0 AmbientProbe_C104
		{
			[return: NotNull]
			get
			{
				return this.m_AmbientProbe;
			}
		}

		// Token: 0x17025213 RID: 152083
		// (get) Token: 0x06067F06 RID: 425734 RVA: 0x01575F33 File Offset: 0x01574133
		public SphericalHarmonicsL2_5_0_0 AmbientProbeInGamma_C104
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17025214 RID: 152084
		// (get) Token: 0x06067F07 RID: 425735 RVA: 0x01575F36 File Offset: 0x01574136
		public ColorRGBAf_3_5_0 AmbientSkyColor_C104
		{
			[return: NotNull]
			get
			{
				return this.m_AmbientSkyColor;
			}
		}

		// Token: 0x17025215 RID: 152085
		// (get) Token: 0x06067F08 RID: 425736 RVA: 0x01575F3E File Offset: 0x0157413E
		public PPtr_Cubemap CustomReflection_C104_PPtr_Cubemap
		{
			[return: NotNull]
			get
			{
				return this.m_CustomReflection;
			}
		}

		// Token: 0x17025216 RID: 152086
		// (get) Token: 0x06067F09 RID: 425737 RVA: 0x01575F46 File Offset: 0x01574146
		public PPtr_Texture_5_0_0 CustomReflection_C104_PPtr_Texture_5_0_0
		{
			get
			{
				return null;
			}
		}

		public ITexture CustomReflection_C104_PPtr_Texture_5_0_0P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17025217 RID: 152087
		// (get) Token: 0x06067F0A RID: 425738 RVA: 0x01575F49 File Offset: 0x01574149
		// (set) Token: 0x06067F0B RID: 425739 RVA: 0x01575F51 File Offset: 0x01574151
		public int DefaultReflectionMode_C104
		{
			get
			{
				return this.m_DefaultReflectionMode;
			}
			set
			{
				this.m_DefaultReflectionMode = value;
			}
		}

		// Token: 0x17025218 RID: 152088
		// (get) Token: 0x06067F0C RID: 425740 RVA: 0x01575F5A File Offset: 0x0157415A
		// (set) Token: 0x06067F0D RID: 425741 RVA: 0x01575F62 File Offset: 0x01574162
		public int DefaultReflectionResolution_C104
		{
			get
			{
				return this.m_DefaultReflectionResolution;
			}
			set
			{
				this.m_DefaultReflectionResolution = value;
			}
		}

		// Token: 0x17025219 RID: 152089
		// (get) Token: 0x06067F0E RID: 425742 RVA: 0x01575F6B File Offset: 0x0157416B
		// (set) Token: 0x06067F0F RID: 425743 RVA: 0x01575F73 File Offset: 0x01574173
		public float FlareFadeSpeed_C104
		{
			get
			{
				return this.m_FlareFadeSpeed;
			}
			set
			{
				this.m_FlareFadeSpeed = value;
			}
		}

		// Token: 0x1702521A RID: 152090
		// (get) Token: 0x06067F10 RID: 425744 RVA: 0x01575F7C File Offset: 0x0157417C
		// (set) Token: 0x06067F11 RID: 425745 RVA: 0x01575F84 File Offset: 0x01574184
		public float FlareStrength_C104
		{
			get
			{
				return this.m_FlareStrength;
			}
			set
			{
				this.m_FlareStrength = value;
			}
		}

		// Token: 0x1702521B RID: 152091
		// (get) Token: 0x06067F12 RID: 425746 RVA: 0x01575F8D File Offset: 0x0157418D
		// (set) Token: 0x06067F13 RID: 425747 RVA: 0x01575F95 File Offset: 0x01574195
		public bool Fog_C104
		{
			get
			{
				return this.m_Fog;
			}
			set
			{
				this.m_Fog = value;
			}
		}

		// Token: 0x1702521C RID: 152092
		// (get) Token: 0x06067F14 RID: 425748 RVA: 0x01575F9E File Offset: 0x0157419E

		public IColorRGBAf FogColor_C104
		{

			get
			{
				return this.m_FogColor;
			}
		}

		// Token: 0x1702521D RID: 152093
		// (get) Token: 0x06067F15 RID: 425749 RVA: 0x01575FA6 File Offset: 0x015741A6
		// (set) Token: 0x06067F16 RID: 425750 RVA: 0x01575FAE File Offset: 0x015741AE
		public float FogDensity_C104
		{
			get
			{
				return this.m_FogDensity;
			}
			set
			{
				this.m_FogDensity = value;
			}
		}

		// Token: 0x1702521E RID: 152094
		// (get) Token: 0x06067F17 RID: 425751 RVA: 0x01575FB7 File Offset: 0x015741B7
		// (set) Token: 0x06067F18 RID: 425752 RVA: 0x01575FBF File Offset: 0x015741BF
		public int FogMode_C104
		{
			get
			{
				return this.m_FogMode;
			}
			set
			{
				this.m_FogMode = value;
			}
		}

		// Token: 0x1702521F RID: 152095
		// (get) Token: 0x06067F19 RID: 425753 RVA: 0x01575FC8 File Offset: 0x015741C8
		public PPtr_Cubemap GeneratedSkyboxReflection_C104
		{
			[return: NotNull]
			get
			{
				return this.m_GeneratedSkyboxReflection;
			}
		}

		// Token: 0x17025220 RID: 152096
		// (get) Token: 0x06067F1A RID: 425754 RVA: 0x01575FD0 File Offset: 0x015741D0
		// (set) Token: 0x06067F1B RID: 425755 RVA: 0x01575FD8 File Offset: 0x015741D8
		public float HaloStrength_C104
		{
			get
			{
				return this.m_HaloStrength;
			}
			set
			{
				this.m_HaloStrength = value;
			}
		}

		// Token: 0x17025221 RID: 152097
		// (get) Token: 0x06067F1C RID: 425756 RVA: 0x01575FE1 File Offset: 0x015741E1

		public IPPtr_Texture2D HaloTexture_C104
		{

			get
			{
				return this.m_HaloTexture;
			}
		}

		// Token: 0x17025222 RID: 152098
		// (get) Token: 0x06067F1D RID: 425757 RVA: 0x01575FE9 File Offset: 0x015741E9
		// (set) Token: 0x06067F1E RID: 425758 RVA: 0x01575FF1 File Offset: 0x015741F1
		public uint HideFlags_C104
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

		// Token: 0x17025223 RID: 152099
		// (get) Token: 0x06067F1F RID: 425759 RVA: 0x01575FFA File Offset: 0x015741FA
		public ColorRGBAf_3_5_0 IndirectSpecularColor_C104
		{
			[return: NotNull]
			get
			{
				return this.m_IndirectSpecularColor;
			}
		}

		// Token: 0x17025224 RID: 152100
		// (get) Token: 0x06067F20 RID: 425760 RVA: 0x01576002 File Offset: 0x01574202
		// (set) Token: 0x06067F21 RID: 425761 RVA: 0x0157600A File Offset: 0x0157420A
		public float LinearFogEnd_C104
		{
			get
			{
				return this.m_LinearFogEnd;
			}
			set
			{
				this.m_LinearFogEnd = value;
			}
		}

		// Token: 0x17025225 RID: 152101
		// (get) Token: 0x06067F22 RID: 425762 RVA: 0x01576013 File Offset: 0x01574213
		// (set) Token: 0x06067F23 RID: 425763 RVA: 0x0157601B File Offset: 0x0157421B
		public float LinearFogStart_C104
		{
			get
			{
				return this.m_LinearFogStart;
			}
			set
			{
				this.m_LinearFogStart = value;
			}
		}

		// Token: 0x17025226 RID: 152102
		// (get) Token: 0x06067F24 RID: 425764 RVA: 0x01576024 File Offset: 0x01574224
		// (set) Token: 0x06067F25 RID: 425765 RVA: 0x0157602C File Offset: 0x0157422C
		public int ReflectionBounces_C104
		{
			get
			{
				return this.m_ReflectionBounces;
			}
			set
			{
				this.m_ReflectionBounces = value;
			}
		}

		// Token: 0x17025227 RID: 152103
		// (get) Token: 0x06067F26 RID: 425766 RVA: 0x01576035 File Offset: 0x01574235
		// (set) Token: 0x06067F27 RID: 425767 RVA: 0x0157603D File Offset: 0x0157423D
		public float ReflectionIntensity_C104
		{
			get
			{
				return this.m_ReflectionIntensity;
			}
			set
			{
				this.m_ReflectionIntensity = value;
			}
		}

		// Token: 0x17025228 RID: 152104
		// (get) Token: 0x06067F28 RID: 425768 RVA: 0x01576046 File Offset: 0x01574246

		public IPPtr_Material SkyboxMaterial_C104
		{

			get
			{
				return this.m_SkyboxMaterial;
			}
		}

		// Token: 0x17025229 RID: 152105
		// (get) Token: 0x06067F29 RID: 425769 RVA: 0x0157604E File Offset: 0x0157424E

		public IPPtr_Texture2D SpotCookie_C104
		{

			get
			{
				return this.m_SpotCookie;
			}
		}

		// Token: 0x1702522A RID: 152106
		// (get) Token: 0x06067F2A RID: 425770 RVA: 0x01576056 File Offset: 0x01574256
		public ColorRGBAf_3_5_0 SubtractiveShadowColor_C104
		{
			[return: NotNull]
			get
			{
				return this.m_SubtractiveShadowColor;
			}
		}

		// Token: 0x1702522B RID: 152107
		// (get) Token: 0x06067F2B RID: 425771 RVA: 0x0157605E File Offset: 0x0157425E
		public PPtr_Light Sun_C104
		{
			[return: NotNull]
			get
			{
				return this.m_Sun;
			}
		}

		// Token: 0x1702522C RID: 152108
		// (get) Token: 0x06067F2C RID: 425772 RVA: 0x01576066 File Offset: 0x01574266
		// (set) Token: 0x06067F2D RID: 425773 RVA: 0x01576069 File Offset: 0x01574269
		public bool UseRadianceAmbientProbe_C104
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1702522D RID: 152109
		// (get) Token: 0x06067F2E RID: 425774 RVA: 0x0157606B File Offset: 0x0157426B
		// (set) Token: 0x06067F2F RID: 425775 RVA: 0x01576073 File Offset: 0x01574273
		public AmbientMode AmbientMode_C104E
		{
			get
			{
				return (AmbientMode)this.m_AmbientMode;
			}
			set
			{
				this.m_AmbientMode = (int)value;
			}
		}

		// Token: 0x1702522E RID: 152110
		// (get) Token: 0x06067F30 RID: 425776 RVA: 0x0157607C File Offset: 0x0157427C
		// (set) Token: 0x06067F31 RID: 425777 RVA: 0x01576084 File Offset: 0x01574284
		public DefaultReflectionMode_0 DefaultReflectionMode_C104E
		{
			get
			{
				return (DefaultReflectionMode_0)this.m_DefaultReflectionMode;
			}
			set
			{
				this.m_DefaultReflectionMode = (int)value;
			}
		}

		// Token: 0x1702522F RID: 152111
		// (get) Token: 0x06067F32 RID: 425778 RVA: 0x0157608D File Offset: 0x0157428D
		// (set) Token: 0x06067F33 RID: 425779 RVA: 0x01576095 File Offset: 0x01574295
		public FogMode FogMode_C104E
		{
			get
			{
				return (FogMode)this.m_FogMode;
			}
			set
			{
				this.m_FogMode = (int)value;
			}
		}

		// Token: 0x17025230 RID: 152112
		// (get) Token: 0x06067F34 RID: 425780 RVA: 0x0157609E File Offset: 0x0157429E
		// (set) Token: 0x06067F35 RID: 425781 RVA: 0x015760A6 File Offset: 0x015742A6
		public HideFlags HideFlags_C104E
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

		// Token: 0x17025231 RID: 152113
		// (get) Token: 0x06067F36 RID: 425782 RVA: 0x015760AF File Offset: 0x015742AF
		// (set) Token: 0x06067F37 RID: 425783 RVA: 0x015760C2 File Offset: 0x015742C2
		public ICubemap CustomReflection_C104_PPtr_CubemapP
		{
			get
			{
				return PPtrExtensions.TryGetAsset<ICubemap>(this.CustomReflection_C104_PPtr_Cubemap, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<ICubemap>(this.CustomReflection_C104_PPtr_Cubemap, base.Collection, value);
			}
		}

		// Token: 0x17025232 RID: 152114
		// (get) Token: 0x06067F38 RID: 425784 RVA: 0x015760D6 File Offset: 0x015742D6
		// (set) Token: 0x06067F39 RID: 425785 RVA: 0x015760D9 File Offset: 0x015742D9
		public ITexture CustomReflection_C104_PPtr_Texture__5_0_0P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17025233 RID: 152115
		// (get) Token: 0x06067F3A RID: 425786 RVA: 0x015760DB File Offset: 0x015742DB
		// (set) Token: 0x06067F3B RID: 425787 RVA: 0x015760EE File Offset: 0x015742EE
		public ICubemap GeneratedSkyboxReflection_C104P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<ICubemap>(this.GeneratedSkyboxReflection_C104, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<ICubemap>(this.GeneratedSkyboxReflection_C104, base.Collection, value);
			}
		}

		// Token: 0x17025234 RID: 152116
		// (get) Token: 0x06067F3C RID: 425788 RVA: 0x01576102 File Offset: 0x01574302
		// (set) Token: 0x06067F3D RID: 425789 RVA: 0x01576115 File Offset: 0x01574315
		public ITexture2D HaloTexture_C104P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<ITexture2D>(this.HaloTexture_C104, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<ITexture2D>(this.HaloTexture_C104, base.Collection, value);
			}
		}

		// Token: 0x17025235 RID: 152117
		// (get) Token: 0x06067F3E RID: 425790 RVA: 0x01576129 File Offset: 0x01574329
		// (set) Token: 0x06067F3F RID: 425791 RVA: 0x0157613C File Offset: 0x0157433C
		public IMaterial SkyboxMaterial_C104P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IMaterial>(this.SkyboxMaterial_C104, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IMaterial>(this.SkyboxMaterial_C104, base.Collection, value);
			}
		}

		// Token: 0x17025236 RID: 152118
		// (get) Token: 0x06067F40 RID: 425792 RVA: 0x01576150 File Offset: 0x01574350
		// (set) Token: 0x06067F41 RID: 425793 RVA: 0x01576163 File Offset: 0x01574363
		public ITexture2D SpotCookie_C104P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<ITexture2D>(this.SpotCookie_C104, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<ITexture2D>(this.SpotCookie_C104, base.Collection, value);
			}
		}

		// Token: 0x17025237 RID: 152119
		// (get) Token: 0x06067F42 RID: 425794 RVA: 0x01576177 File Offset: 0x01574377
		// (set) Token: 0x06067F43 RID: 425795 RVA: 0x0157618A File Offset: 0x0157438A
		public ILight Sun_C104P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<ILight>(this.Sun_C104, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<ILight>(this.Sun_C104, base.Collection, value);
			}
		}

		// Token: 0x17025238 RID: 152120
		// (get) Token: 0x06067F44 RID: 425796 RVA: 0x0157619E File Offset: 0x0157439E

		public override string ClassName
		{

			get
			{
				return "RenderSettings";
			}
		}

		// Token: 0x06067F45 RID: 425797 RVA: 0x015761A5 File Offset: 0x015743A5
		public RenderSettings_5_6_0_GICB2()
			: this(AssetInfo.MakeDummyAssetInfo(104))
		{
		}

		// Token: 0x06067F46 RID: 425798 RVA: 0x015761B4 File Offset: 0x015743B4
		public RenderSettings_5_6_0_GICB2(AssetInfo info)
			: base(info)
		{
			this.m_AmbientProbe = new SphericalHarmonicsL2_5_0_0();
			this.m_GeneratedSkyboxReflection = new PPtr_Cubemap();
			this.m_FogColor = new ColorRGBAf_3_5_0();
			this.m_AmbientSkyColor = new ColorRGBAf_3_5_0();
			this.m_AmbientEquatorColor = new ColorRGBAf_3_5_0();
			this.m_AmbientGroundColor = new ColorRGBAf_3_5_0();
			this.m_SubtractiveShadowColor = new ColorRGBAf_3_5_0();
			this.m_SkyboxMaterial = new PPtr_Material_5_0_0();
			this.m_HaloTexture = new PPtr_Texture2D_5_0_0();
			this.m_SpotCookie = new PPtr_Texture2D_5_0_0();
			this.m_CustomReflection = new PPtr_Cubemap();
			this.m_Sun = new PPtr_Light();
			this.m_IndirectSpecularColor = new ColorRGBAf_3_5_0();
		}

		// Token: 0x06067F47 RID: 425799 RVA: 0x01576257 File Offset: 0x01574457
		public bool Has_AmbientEquatorColor_C104()
		{
			return true;
		}

		// Token: 0x06067F48 RID: 425800 RVA: 0x0157625A File Offset: 0x0157445A
		public bool Has_AmbientGroundColor_C104()
		{
			return true;
		}

		// Token: 0x06067F49 RID: 425801 RVA: 0x0157625D File Offset: 0x0157445D
		public bool Has_AmbientIntensity_C104()
		{
			return true;
		}

		// Token: 0x06067F4A RID: 425802 RVA: 0x01576260 File Offset: 0x01574460
		public bool Has_AmbientLight_C104()
		{
			return false;
		}

		// Token: 0x06067F4B RID: 425803 RVA: 0x01576263 File Offset: 0x01574463
		public bool Has_AmbientMode_C104()
		{
			return true;
		}

		// Token: 0x06067F4C RID: 425804 RVA: 0x01576266 File Offset: 0x01574466
		public bool Has_AmbientProbe_C104()
		{
			return true;
		}

		// Token: 0x06067F4D RID: 425805 RVA: 0x01576269 File Offset: 0x01574469
		public bool Has_AmbientProbeInGamma_C104()
		{
			return false;
		}

		// Token: 0x06067F4E RID: 425806 RVA: 0x0157626C File Offset: 0x0157446C
		public bool Has_AmbientSkyColor_C104()
		{
			return true;
		}

		// Token: 0x06067F4F RID: 425807 RVA: 0x0157626F File Offset: 0x0157446F
		public bool Has_CustomReflection_C104_PPtr_Cubemap()
		{
			return true;
		}

		// Token: 0x06067F50 RID: 425808 RVA: 0x01576272 File Offset: 0x01574472
		public bool Has_CustomReflection_C104_PPtr_Texture_5_0_0()
		{
			return false;
		}

		// Token: 0x06067F51 RID: 425809 RVA: 0x01576275 File Offset: 0x01574475
		public bool Has_DefaultReflectionMode_C104()
		{
			return true;
		}

		// Token: 0x06067F52 RID: 425810 RVA: 0x01576278 File Offset: 0x01574478
		public bool Has_DefaultReflectionResolution_C104()
		{
			return true;
		}

		// Token: 0x06067F53 RID: 425811 RVA: 0x0157627B File Offset: 0x0157447B
		public bool Has_FlareFadeSpeed_C104()
		{
			return true;
		}

		// Token: 0x06067F54 RID: 425812 RVA: 0x0157627E File Offset: 0x0157447E
		public bool Has_GeneratedSkyboxReflection_C104()
		{
			return true;
		}

		// Token: 0x06067F55 RID: 425813 RVA: 0x01576281 File Offset: 0x01574481
		public bool Has_IndirectSpecularColor_C104()
		{
			return true;
		}

		// Token: 0x06067F56 RID: 425814 RVA: 0x01576284 File Offset: 0x01574484
		public bool Has_ReflectionBounces_C104()
		{
			return true;
		}

		// Token: 0x06067F57 RID: 425815 RVA: 0x01576287 File Offset: 0x01574487
		public bool Has_ReflectionIntensity_C104()
		{
			return true;
		}

		// Token: 0x06067F58 RID: 425816 RVA: 0x0157628A File Offset: 0x0157448A
		public bool Has_SubtractiveShadowColor_C104()
		{
			return true;
		}

		// Token: 0x06067F59 RID: 425817 RVA: 0x0157628D File Offset: 0x0157448D
		public bool Has_Sun_C104()
		{
			return true;
		}

		// Token: 0x06067F5A RID: 425818 RVA: 0x01576290 File Offset: 0x01574490
		public bool Has_UseRadianceAmbientProbe_C104()
		{
			return false;
		}

		// Token: 0x06067F5B RID: 425819 RVA: 0x01576294 File Offset: 0x01574494

		public override void ReadRelease(AssetReader reader)
		{
			this.m_Fog = reader.ReadRelease_BooleanAlign();
			this.m_FogColor.ReadRelease(reader);
			this.m_FogMode = reader.ReadInt32();
			this.m_FogDensity = reader.ReadSingle();
			this.m_LinearFogStart = reader.ReadSingle();
			this.m_LinearFogEnd = reader.ReadSingle();

			LinearFogPower = reader.ReadSingle();
			BottomFogColor.ReadRelease(reader);
			BottomIntensity = reader.ReadSingle();
			bottomH = reader.ReadSingle();
			TopFogColor.ReadRelease(reader);
			TopIntensity = reader.ReadSingle();
			FarFogSwitchDistance = reader.ReadSingle();
			FarFogColor.ReadRelease(reader);
			HeightFallOff = reader.ReadSingle();
			BottomDensityScale = reader.ReadSingle();
			rangeH = reader.ReadSingle();
			HeightOffset = reader.ReadSingle();
			rampStart = reader.ReadSingle();
			rampRange = reader.ReadSingle();
			rampInfluence = reader.ReadSingle();
			densityClamp = reader.ReadSingle();
			inScatteringColor.ReadRelease(reader);
			inScatteringIntensity = reader.ReadSingle();
			radialSize = reader.ReadSingle();
			radialLobe = reader.ReadSingle();
			skyboxFogScale = reader.ReadSingle();

			this.m_AmbientSkyColor.ReadRelease(reader);
			this.m_AmbientEquatorColor.ReadRelease(reader);
			this.m_AmbientGroundColor.ReadRelease(reader);
			this.m_AmbientIntensity = reader.ReadSingle();
			this.m_AmbientMode = reader.ReadRelease_Int32Align();
			this.m_SubtractiveShadowColor.ReadRelease(reader);
			this.m_SkyboxMaterial.ReadRelease(reader);
			this.m_HaloStrength = reader.ReadSingle();
			this.m_FlareStrength = reader.ReadSingle();
			this.m_FlareFadeSpeed = reader.ReadSingle();
			this.m_HaloTexture.ReadRelease(reader);
			this.m_SpotCookie.ReadRelease(reader);
			this.m_DefaultReflectionMode = reader.ReadInt32();
			this.m_DefaultReflectionResolution = reader.ReadInt32();
			this.m_ReflectionBounces = reader.ReadInt32();
			this.m_ReflectionIntensity = reader.ReadSingle();
			this.m_CustomReflection.ReadRelease(reader);
			this.m_AmbientProbe.ReadRelease(reader);
			this.m_GeneratedSkyboxReflection.ReadRelease(reader);
			this.m_Sun.ReadRelease(reader);
			this.m_IndirectSpecularColor.ReadRelease(reader);

			UnityDebugViewInfo.ReadRelease(reader);
			DisableParticleTrailLineRender = reader.ReadBoolean();
			DisableTransWithoutParticleTrailLine = reader.ReadBoolean();
			UseSpecialLayerRenderNodes = reader.ReadBoolean();
			reader.AlignStream();
			hdrColorTemp = reader.ReadSingle();
			linearFogScale = reader.ReadSingle();
		}

		// Token: 0x06067F5C RID: 425820 RVA: 0x015763E8 File Offset: 0x015745E8

		//public override void ReadEditor(AssetReader reader)
		//{
		//}

		// Token: 0x06067F5D RID: 425821 RVA: 0x01576530 File Offset: 0x01574730

		public override void WriteRelease(AssetWriter writer)
		{
			this.m_Fog.WriteRelease_BooleanAlign(writer);
			this.m_FogColor.WriteRelease(writer);
			this.m_FogMode.WriteRelease_Int32(writer);
			this.m_FogDensity.WriteRelease_Single(writer);
			this.m_LinearFogStart.WriteRelease_Single(writer);
			this.m_LinearFogEnd.WriteRelease_Single(writer);
			this.m_AmbientSkyColor.WriteRelease(writer);
			this.m_AmbientEquatorColor.WriteRelease(writer);
			this.m_AmbientGroundColor.WriteRelease(writer);
			this.m_AmbientIntensity.WriteRelease_Single(writer);
			this.m_AmbientMode.WriteRelease_Int32Align(writer);
			this.m_SubtractiveShadowColor.WriteRelease(writer);
			this.m_SkyboxMaterial.WriteRelease(writer);
			this.m_HaloStrength.WriteRelease_Single(writer);
			this.m_FlareStrength.WriteRelease_Single(writer);
			this.m_FlareFadeSpeed.WriteRelease_Single(writer);
			this.m_HaloTexture.WriteRelease(writer);
			this.m_SpotCookie.WriteRelease(writer);
			this.m_DefaultReflectionMode.WriteRelease_Int32(writer);
			this.m_DefaultReflectionResolution.WriteRelease_Int32(writer);
			this.m_ReflectionBounces.WriteRelease_Int32(writer);
			this.m_ReflectionIntensity.WriteRelease_Single(writer);
			this.m_CustomReflection.WriteRelease(writer);
			this.m_AmbientProbe.WriteRelease(writer);
			this.m_GeneratedSkyboxReflection.WriteRelease(writer);
			this.m_Sun.WriteRelease(writer);
			this.m_IndirectSpecularColor.WriteRelease(writer);
		}

		// Token: 0x06067F5E RID: 425822 RVA: 0x01576684 File Offset: 0x01574884

		public override void WriteEditor(AssetWriter writer)
		{
		}

		// Token: 0x06067F5F RID: 425823 RVA: 0x015767CC File Offset: 0x015749CC

		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 8);
			yamlMappingNode.Add(new YamlScalarNode("m_Fog"), this.m_Fog.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_FogColor"), this.m_FogColor.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_FogMode"), this.m_FogMode.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_FogDensity"), this.m_FogDensity.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LinearFogStart"), this.m_LinearFogStart.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LinearFogEnd"), this.m_LinearFogEnd.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AmbientSkyColor"), this.m_AmbientSkyColor.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AmbientEquatorColor"), this.m_AmbientEquatorColor.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AmbientGroundColor"), this.m_AmbientGroundColor.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AmbientIntensity"), this.m_AmbientIntensity.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AmbientMode"), this.m_AmbientMode.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SubtractiveShadowColor"), this.m_SubtractiveShadowColor.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SkyboxMaterial"), this.m_SkyboxMaterial.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_HaloStrength"), this.m_HaloStrength.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_FlareStrength"), this.m_FlareStrength.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_FlareFadeSpeed"), this.m_FlareFadeSpeed.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_HaloTexture"), this.m_HaloTexture.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SpotCookie"), this.m_SpotCookie.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_DefaultReflectionMode"), this.m_DefaultReflectionMode.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_DefaultReflectionResolution"), this.m_DefaultReflectionResolution.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ReflectionBounces"), this.m_ReflectionBounces.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ReflectionIntensity"), this.m_ReflectionIntensity.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_CustomReflection"), this.m_CustomReflection.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AmbientProbe"), this.m_AmbientProbe.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_GeneratedSkyboxReflection"), this.m_GeneratedSkyboxReflection.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Sun"), this.m_Sun.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_IndirectSpecularColor"), this.m_IndirectSpecularColor.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06067F60 RID: 425824 RVA: 0x01576ADC File Offset: 0x01574CDC

		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 8);
			yamlMappingNode.Add(new YamlScalarNode("m_ObjectHideFlags"), this.m_HideFlags.ExportYamlEditor_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Fog"), this.m_Fog.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_FogColor"), this.m_FogColor.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_FogMode"), this.m_FogMode.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_FogDensity"), this.m_FogDensity.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LinearFogStart"), this.m_LinearFogStart.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LinearFogEnd"), this.m_LinearFogEnd.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AmbientSkyColor"), this.m_AmbientSkyColor.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AmbientEquatorColor"), this.m_AmbientEquatorColor.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AmbientGroundColor"), this.m_AmbientGroundColor.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AmbientIntensity"), this.m_AmbientIntensity.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AmbientMode"), this.m_AmbientMode.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SubtractiveShadowColor"), this.m_SubtractiveShadowColor.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SkyboxMaterial"), this.m_SkyboxMaterial.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_HaloStrength"), this.m_HaloStrength.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_FlareStrength"), this.m_FlareStrength.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_FlareFadeSpeed"), this.m_FlareFadeSpeed.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_HaloTexture"), this.m_HaloTexture.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SpotCookie"), this.m_SpotCookie.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_DefaultReflectionMode"), this.m_DefaultReflectionMode.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_DefaultReflectionResolution"), this.m_DefaultReflectionResolution.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ReflectionBounces"), this.m_ReflectionBounces.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ReflectionIntensity"), this.m_ReflectionIntensity.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_CustomReflection"), this.m_CustomReflection.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Sun"), this.m_Sun.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_IndirectSpecularColor"), this.m_IndirectSpecularColor.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06067F61 RID: 425825 RVA: 0x01576DD0 File Offset: 0x01574FD0
		public override void Reset()
		{
			this.m_AmbientEquatorColor.Reset();
			this.m_AmbientGroundColor.Reset();
			this.m_AmbientIntensity = 0f;
			this.m_AmbientMode = 0;
			this.m_AmbientProbe.Reset();
			this.m_AmbientSkyColor.Reset();
			this.m_CustomReflection.Reset();
			this.m_DefaultReflectionMode = 0;
			this.m_DefaultReflectionResolution = 0;
			this.m_FlareFadeSpeed = 0f;
			this.m_FlareStrength = 0f;
			this.m_Fog = false;
			this.m_FogColor.Reset();
			this.m_FogDensity = 0f;
			this.m_FogMode = 0;
			this.m_GeneratedSkyboxReflection.Reset();
			this.m_HaloStrength = 0f;
			this.m_HaloTexture.Reset();
			this.m_HideFlags = 0U;
			this.m_IndirectSpecularColor.Reset();
			this.m_LinearFogEnd = 0f;
			this.m_LinearFogStart = 0f;
			this.m_ReflectionBounces = 0;
			this.m_ReflectionIntensity = 0f;
			this.m_SkyboxMaterial.Reset();
			this.m_SpotCookie.Reset();
			this.m_SubtractiveShadowColor.Reset();
			this.m_Sun.Reset();
		}

		// Token: 0x06067F62 RID: 425826 RVA: 0x01576EF5 File Offset: 0x015750F5
		//public override IEnumerable<ValueTuple<FieldName, PPtr<IUnityObjectBase>>> FetchDependencies(FieldName parent)
		//{
		//	return Enumerable.Empty<ValueTuple<FieldName, PPtr<IUnityObjectBase>>>().Append_RenderSettings_5_6_0(parent, this);
		//}

		// Token: 0x06067F63 RID: 425827 RVA: 0x01576F04 File Offset: 0x01575104

		public void CopyValues(IRenderSettings source, PPtrConverter converter)
		{
			this.m_AmbientEquatorColor.CopyValues(source.AmbientEquatorColor_C104);
			this.m_AmbientGroundColor.CopyValues(source.AmbientGroundColor_C104);
			this.m_AmbientIntensity = source.AmbientIntensity_C104;
			this.m_AmbientMode = source.AmbientMode_C104;
			this.m_AmbientProbe.CopyValues(source.AmbientProbe_C104);
			this.m_AmbientSkyColor.CopyValues(source.AmbientSkyColor_C104);
			this.m_CustomReflection.CopyValues(source.CustomReflection_C104_PPtr_Cubemap, converter);
			this.m_DefaultReflectionMode = source.DefaultReflectionMode_C104;
			this.m_DefaultReflectionResolution = source.DefaultReflectionResolution_C104;
			this.m_FlareFadeSpeed = source.FlareFadeSpeed_C104;
			this.m_FlareStrength = source.FlareStrength_C104;
			this.m_Fog = source.Fog_C104;
			this.m_FogColor.CopyValues(source.FogColor_C104);
			this.m_FogDensity = source.FogDensity_C104;
			this.m_FogMode = source.FogMode_C104;
			this.m_GeneratedSkyboxReflection.CopyValues(source.GeneratedSkyboxReflection_C104, converter);
			this.m_HaloStrength = source.HaloStrength_C104;
			this.m_HaloTexture.CopyValues(source.HaloTexture_C104, converter);
			this.m_HideFlags = source.HideFlags_C104;
			this.m_IndirectSpecularColor.CopyValues(source.IndirectSpecularColor_C104);
			this.m_LinearFogEnd = source.LinearFogEnd_C104;
			this.m_LinearFogStart = source.LinearFogStart_C104;
			this.m_ReflectionBounces = source.ReflectionBounces_C104;
			this.m_ReflectionIntensity = source.ReflectionIntensity_C104;
			this.m_SkyboxMaterial.CopyValues(source.SkyboxMaterial_C104, converter);
			this.m_SpotCookie.CopyValues(source.SpotCookie_C104, converter);
			this.m_SubtractiveShadowColor.CopyValues(source.SubtractiveShadowColor_C104);
			this.m_Sun.CopyValues(source.Sun_C104, converter);
		}

		// Token: 0x06067F64 RID: 425828 RVA: 0x015770A8 File Offset: 0x015752A8

		public void CopyValues(IRenderSettings source)
		{
			this.CopyValues(source, new PPtrConverter(source, this));
		}

		// Token: 0x06067F65 RID: 425829 RVA: 0x015770B8 File Offset: 0x015752B8
		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			IRenderSettings renderSettings = source as IRenderSettings;
			if (renderSettings != null)
			{
				this.CopyValues(renderSettings, converter);
				return;
			}
			base.CopyValues(source, converter);
		}

		// Token: 0x06067F66 RID: 425830 RVA: 0x015770E0 File Offset: 0x015752E0

		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06067F67 RID: 425831 RVA: 0x015770E7 File Offset: 0x015752E7

		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0403811B RID: 229659

		public SphericalHarmonicsL2_5_0_0 m_AmbientProbe;

		// Token: 0x0403811C RID: 229660

		public PPtr_Cubemap m_GeneratedSkyboxReflection;

		// Token: 0x0403811D RID: 229661
		public bool m_Fog;

		// Token: 0x0403811E RID: 229662

		public ColorRGBAf_3_5_0 m_FogColor;

		// Token: 0x0403811F RID: 229663
		public int m_FogMode;

		// Token: 0x04038120 RID: 229664
		public float m_FogDensity;

		// Token: 0x04038121 RID: 229665
		public float m_LinearFogStart;

		// Token: 0x04038122 RID: 229666
		public float m_LinearFogEnd;

		// Token: 0x04038123 RID: 229667

		public ColorRGBAf_3_5_0 m_AmbientSkyColor;

		// Token: 0x04038124 RID: 229668

		public ColorRGBAf_3_5_0 m_AmbientEquatorColor;

		// Token: 0x04038125 RID: 229669

		public ColorRGBAf_3_5_0 m_AmbientGroundColor;

		// Token: 0x04038126 RID: 229670
		public float m_AmbientIntensity;

		// Token: 0x04038127 RID: 229671
		public int m_AmbientMode;

		// Token: 0x04038128 RID: 229672

		public ColorRGBAf_3_5_0 m_SubtractiveShadowColor;

		// Token: 0x04038129 RID: 229673

		public PPtr_Material_5_0_0 m_SkyboxMaterial;

		// Token: 0x0403812A RID: 229674
		public float m_HaloStrength;

		// Token: 0x0403812B RID: 229675
		public float m_FlareStrength;

		// Token: 0x0403812C RID: 229676
		public float m_FlareFadeSpeed;

		// Token: 0x0403812D RID: 229677

		public PPtr_Texture2D_5_0_0 m_HaloTexture;

		// Token: 0x0403812E RID: 229678

		public PPtr_Texture2D_5_0_0 m_SpotCookie;

		// Token: 0x0403812F RID: 229679
		public int m_DefaultReflectionMode;

		// Token: 0x04038130 RID: 229680
		public int m_DefaultReflectionResolution;

		// Token: 0x04038131 RID: 229681
		public int m_ReflectionBounces;

		// Token: 0x04038132 RID: 229682
		public float m_ReflectionIntensity;

		// Token: 0x04038133 RID: 229683

		public PPtr_Cubemap m_CustomReflection;

		// Token: 0x04038134 RID: 229684

		public PPtr_Light m_Sun;

		// Token: 0x04038135 RID: 229685

		public ColorRGBAf_3_5_0 m_IndirectSpecularColor;

		public float LinearFogPower { get; set; }
		public float BottomIntensity { get; set; }
		public float bottomH { get; set; }
		public float TopIntensity { get; set; }
		public float FarFogSwitchDistance { get; set; }
		public float HeightFallOff { get; set; }
		public float BottomDensityScale { get; set; }
		public float rangeH { get; set; }
		public float HeightOffset { get; set; }
		public float rampStart { get; set; }
		public float rampRange { get; set; }
		public float rampInfluence { get; set; }
		public float densityClamp { get; set; }
		public float inScatteringIntensity { get; set; }
		public float radialSize { get; set; }
		public float radialLobe { get; set; }
		public float skyboxFogScale { get; set; }

		public Vector4f_3_5_0 UnityDebugViewInfo = new();
		public bool DisableParticleTrailLineRender { get; set; }
		public bool DisableTransWithoutParticleTrailLine { get; set; }
		public bool UseSpecialLayerRenderNodes { get; set; }
		public float hdrColorTemp { get; set; }
		public float linearFogScale { get; set; }

		public ColorRGBAf_3_5_0 BottomFogColor = new();
		public ColorRGBAf_3_5_0 TopFogColor = new();
		public ColorRGBAf_3_5_0 FarFogColor = new();
		public ColorRGBAf_3_5_0 inScatteringColor = new();
	}
}
