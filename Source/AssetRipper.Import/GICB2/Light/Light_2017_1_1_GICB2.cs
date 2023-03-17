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
using AssetRipper.SourceGenerated.Classes.ClassID_1;
using AssetRipper.SourceGenerated.Classes.ClassID_1001;
using AssetRipper.SourceGenerated.Classes.ClassID_1001480554;
using AssetRipper.SourceGenerated.Classes.ClassID_1002;
using AssetRipper.SourceGenerated.Classes.ClassID_121;
using AssetRipper.SourceGenerated.Classes.ClassID_18;
using AssetRipper.SourceGenerated.Classes.ClassID_2;
using AssetRipper.SourceGenerated.Classes.ClassID_27;
using AssetRipper.SourceGenerated.Classes.ClassID_8;
using AssetRipper.SourceGenerated.Enums;
using AssetRipper.SourceGenerated.Helpers;
using AssetRipper.SourceGenerated.Interfaces;
using AssetRipper.SourceGenerated.MarkerInterfaces;
using AssetRipper.SourceGenerated.Subclasses.BitField;
using AssetRipper.SourceGenerated.Subclasses.ColorRGBAf;
using AssetRipper.SourceGenerated.Subclasses.FalloffTable;
using AssetRipper.SourceGenerated.Subclasses.LightBakingOutput;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtensionImpl;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtension;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Flare;
using AssetRipper.SourceGenerated.Subclasses.PPtr_GameObject;
using AssetRipper.SourceGenerated.Subclasses.PPtr_PrefabInstance;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Prefab;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Texture;
using AssetRipper.SourceGenerated.Subclasses.ShadowSettings;
using AssetRipper.SourceGenerated.Subclasses.Vector2f;
using AssetRipper.SourceGenerated.Subclasses.Vector4f;
using AssetRipper.Yaml;
using AssetRipper.SourceGenerated.Classes.ClassID_108;
using AssetRipper.Import.GICB2.Light.ShadowSettings;

namespace AssetRipper.Import.GICB2.Light
{
	// Token: 0x020034A8 RID: 13480


	public sealed class Light_2017_1_1_GICB2 : Behaviour_5_5_0, ILight, IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, ILightMarker, IBehaviour, IBehaviourMarker, IComponent, IEditorExtension, IEditorExtensionMarker, IObject, IObjectMarker, IHasHideFlags, IComponentMarker, IHasEnabled
	{
		// Token: 0x170218F2 RID: 137458
		// (get) Token: 0x0605E610 RID: 386576 RVA: 0x014946F2 File Offset: 0x014928F2
		// (set) Token: 0x0605E611 RID: 386577 RVA: 0x014946F5 File Offset: 0x014928F5
		public bool ActuallyLightmapped_C108
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170218F3 RID: 137459
		// (get) Token: 0x0605E612 RID: 386578 RVA: 0x014946F7 File Offset: 0x014928F7
		public Vector2f_3_5_0 AreaSize_C108
		{
			[return: NotNull]
			get
			{
				return this.m_AreaSize;
			}
		}

		// Token: 0x170218F4 RID: 137460
		// (get) Token: 0x0605E613 RID: 386579 RVA: 0x014946FF File Offset: 0x014928FF
		// (set) Token: 0x0605E614 RID: 386580 RVA: 0x01494702 File Offset: 0x01492902
		public int BakedIndex_C108
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170218F5 RID: 137461
		// (get) Token: 0x0605E615 RID: 386581 RVA: 0x01494704 File Offset: 0x01492904
		public ILightBakingOutput BakingOutput_C108
		{
			[return: NotNull]
			get
			{
				return this.m_BakingOutput;
			}
		}

		// Token: 0x170218F6 RID: 137462
		// (get) Token: 0x0605E616 RID: 386582 RVA: 0x0149470C File Offset: 0x0149290C
		// (set) Token: 0x0605E617 RID: 386583 RVA: 0x01494714 File Offset: 0x01492914
		public float BounceIntensity_C108
		{
			get
			{
				return this.m_BounceIntensity;
			}
			set
			{
				this.m_BounceIntensity = value;
			}
		}

		// Token: 0x170218F7 RID: 137463
		// (get) Token: 0x0605E618 RID: 386584 RVA: 0x0149471D File Offset: 0x0149291D
		public Vector4f_3_5_0 BoundingSphereOverride_C108
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170218F8 RID: 137464
		// (get) Token: 0x0605E619 RID: 386585 RVA: 0x01494720 File Offset: 0x01492920
		// (set) Token: 0x0605E61A RID: 386586 RVA: 0x01494727 File Offset: 0x01492927
		public float CCT_C108
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170218F9 RID: 137465
		// (get) Token: 0x0605E61B RID: 386587 RVA: 0x01494729 File Offset: 0x01492929

		public IColorRGBAf Color_C108
		{

			get
			{
				return this.m_Color;
			}
		}

		// Token: 0x170218FA RID: 137466
		// (get) Token: 0x0605E61C RID: 386588 RVA: 0x01494731 File Offset: 0x01492931
		// (set) Token: 0x0605E61D RID: 386589 RVA: 0x01494739 File Offset: 0x01492939
		public float ColorTemperature_C108
		{
			get
			{
				return this.m_ColorTemperature;
			}
			set
			{
				this.m_ColorTemperature = value;
			}
		}

		// Token: 0x170218FB RID: 137467
		// (get) Token: 0x0605E61E RID: 386590 RVA: 0x01494742 File Offset: 0x01492942

		public IPPtr_Texture Cookie_C108
		{

			get
			{
				return this.m_Cookie;
			}
		}

		// Token: 0x170218FC RID: 137468
		// (get) Token: 0x0605E61F RID: 386591 RVA: 0x0149474A File Offset: 0x0149294A
		// (set) Token: 0x0605E620 RID: 386592 RVA: 0x01494752 File Offset: 0x01492952
		public float CookieSize_C108
		{
			get
			{
				return this.m_CookieSize;
			}
			set
			{
				this.m_CookieSize = value;
			}
		}

		// Token: 0x170218FD RID: 137469
		// (get) Token: 0x0605E621 RID: 386593 RVA: 0x0149475B File Offset: 0x0149295B
		public IPPtr_EditorExtension CorrespondingSourceObject_C108
		{
			[return: NotNull]
			get
			{
				return this.m_CorrespondingSourceObject;
			}
		}

		// Token: 0x170218FE RID: 137470
		// (get) Token: 0x0605E622 RID: 386594 RVA: 0x01494763 File Offset: 0x01492963

		public BitField CullingMask_C108
		{

			get
			{
				return this.m_CullingMask;
			}
		}

		// Token: 0x170218FF RID: 137471
		// (get) Token: 0x0605E623 RID: 386595 RVA: 0x0149476B File Offset: 0x0149296B
		// (set) Token: 0x0605E624 RID: 386596 RVA: 0x01494773 File Offset: 0x01492973
		public bool DrawHalo_C108
		{
			get
			{
				return this.m_DrawHalo;
			}
			set
			{
				this.m_DrawHalo = value;
			}
		}

		// Token: 0x17021900 RID: 137472
		// (get) Token: 0x0605E625 RID: 386597 RVA: 0x0149477C File Offset: 0x0149297C
		// (set) Token: 0x0605E626 RID: 386598 RVA: 0x01494784 File Offset: 0x01492984
		public byte Enabled_C108
		{
			get
			{
				return this.m_Enabled;
			}
			set
			{
				this.m_Enabled = value;
			}
		}

		// Token: 0x17021901 RID: 137473
		// (get) Token: 0x0605E627 RID: 386599 RVA: 0x0149478D File Offset: 0x0149298D
		public PPtr_EditorExtensionImpl ExtensionPtr_C108
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17021902 RID: 137474
		// (get) Token: 0x0605E628 RID: 386600 RVA: 0x01494790 File Offset: 0x01492990
		public FalloffTable FalloffTable_C108
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17021903 RID: 137475
		// (get) Token: 0x0605E629 RID: 386601 RVA: 0x01494793 File Offset: 0x01492993

		public IPPtr_Flare Flare_C108
		{

			get
			{
				return this.m_Flare;
			}
		}

		// Token: 0x17021904 RID: 137476
		// (get) Token: 0x0605E62A RID: 386602 RVA: 0x0149479B File Offset: 0x0149299B

		public IPPtr_GameObject GameObject_C108
		{

			get
			{
				return this.m_GameObject;
			}
		}

		// Token: 0x17021905 RID: 137477
		// (get) Token: 0x0605E62B RID: 386603 RVA: 0x014947A3 File Offset: 0x014929A3
		// (set) Token: 0x0605E62C RID: 386604 RVA: 0x014947AB File Offset: 0x014929AB
		public uint HideFlags_C108
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

		// Token: 0x17021906 RID: 137478
		// (get) Token: 0x0605E62D RID: 386605 RVA: 0x014947B4 File Offset: 0x014929B4
		// (set) Token: 0x0605E62E RID: 386606 RVA: 0x014947BB File Offset: 0x014929BB
		public float IndirectIntensity_C108
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17021907 RID: 137479
		// (get) Token: 0x0605E62F RID: 386607 RVA: 0x014947BD File Offset: 0x014929BD
		// (set) Token: 0x0605E630 RID: 386608 RVA: 0x014947C4 File Offset: 0x014929C4
		public float InnerSpotAngle_C108
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17021908 RID: 137480
		// (get) Token: 0x0605E631 RID: 386609 RVA: 0x014947C6 File Offset: 0x014929C6
		// (set) Token: 0x0605E632 RID: 386610 RVA: 0x014947CE File Offset: 0x014929CE
		public float Intensity_C108
		{
			get
			{
				return this.m_Intensity;
			}
			set
			{
				this.m_Intensity = value;
			}
		}

		// Token: 0x17021909 RID: 137481
		// (get) Token: 0x0605E633 RID: 386611 RVA: 0x014947D7 File Offset: 0x014929D7
		// (set) Token: 0x0605E634 RID: 386612 RVA: 0x014947DF File Offset: 0x014929DF
		public int Lightmapping_C108
		{
			get
			{
				return this.m_Lightmapping;
			}
			set
			{
				this.m_Lightmapping = value;
			}
		}

		// Token: 0x1702190A RID: 137482
		// (get) Token: 0x0605E635 RID: 386613 RVA: 0x014947E8 File Offset: 0x014929E8
		// (set) Token: 0x0605E636 RID: 386614 RVA: 0x014947EB File Offset: 0x014929EB
		public int LightShadowCasterMode_C108
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1702190B RID: 137483
		// (get) Token: 0x0605E637 RID: 386615 RVA: 0x014947ED File Offset: 0x014929ED
		public PPtr_Prefab_2018_3_0 PrefabAsset_C108
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1702190C RID: 137484
		// (get) Token: 0x0605E638 RID: 386616 RVA: 0x014947F0 File Offset: 0x014929F0
		public PPtr_PrefabInstance PrefabInstance_C108
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1702190D RID: 137485
		// (get) Token: 0x0605E639 RID: 386617 RVA: 0x014947F3 File Offset: 0x014929F3
		public IPPtr_Prefab PrefabInternal_C108
		{
			[return: NotNull]
			get
			{
				return this.m_PrefabInternal;
			}
		}

		// Token: 0x1702190E RID: 137486
		// (get) Token: 0x0605E63A RID: 386618 RVA: 0x014947FB File Offset: 0x014929FB
		// (set) Token: 0x0605E63B RID: 386619 RVA: 0x01494803 File Offset: 0x01492A03
		public float Range_C108
		{
			get
			{
				return this.m_Range;
			}
			set
			{
				this.m_Range = value;
			}
		}

		// Token: 0x1702190F RID: 137487
		// (get) Token: 0x0605E63C RID: 386620 RVA: 0x0149480C File Offset: 0x01492A0C
		// (set) Token: 0x0605E63D RID: 386621 RVA: 0x0149480F File Offset: 0x01492A0F
		public uint RenderingLayerMask_C108
		{
			get
			{
				return 0U;
			}
			set
			{
			}
		}

		// Token: 0x17021910 RID: 137488
		// (get) Token: 0x0605E63E RID: 386622 RVA: 0x01494811 File Offset: 0x01492A11
		// (set) Token: 0x0605E63F RID: 386623 RVA: 0x01494819 File Offset: 0x01492A19
		public int RenderMode_C108
		{
			get
			{
				return this.m_RenderMode;
			}
			set
			{
				this.m_RenderMode = value;
			}
		}

		// Token: 0x17021911 RID: 137489
		// (get) Token: 0x0605E640 RID: 386624 RVA: 0x01494822 File Offset: 0x01492A22
		// (set) Token: 0x0605E641 RID: 386625 RVA: 0x0149482A File Offset: 0x01492A2A
		public float ShadowAngle_C108
		{
			get
			{
				return this.m_ShadowAngle;
			}
			set
			{
				this.m_ShadowAngle = value;
			}
		}

		// Token: 0x17021912 RID: 137490
		// (get) Token: 0x0605E642 RID: 386626 RVA: 0x01494833 File Offset: 0x01492A33
		// (set) Token: 0x0605E643 RID: 386627 RVA: 0x0149483B File Offset: 0x01492A3B
		public float ShadowRadius_C108
		{
			get
			{
				return this.m_ShadowRadius;
			}
			set
			{
				this.m_ShadowRadius = value;
			}
		}

		// Token: 0x17021913 RID: 137491
		// (get) Token: 0x0605E644 RID: 386628 RVA: 0x01494844 File Offset: 0x01492A44

		public IShadowSettings Shadows_C108
		{

			get
			{
				return this.m_Shadows;
			}
		}

		// Token: 0x17021914 RID: 137492
		// (get) Token: 0x0605E645 RID: 386629 RVA: 0x0149484C File Offset: 0x01492A4C
		// (set) Token: 0x0605E646 RID: 386630 RVA: 0x0149484F File Offset: 0x01492A4F
		public int ShadowSamples_C108
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17021915 RID: 137493
		// (get) Token: 0x0605E647 RID: 386631 RVA: 0x01494851 File Offset: 0x01492A51
		// (set) Token: 0x0605E648 RID: 386632 RVA: 0x01494854 File Offset: 0x01492A54
		public int Shape_C108
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17021916 RID: 137494
		// (get) Token: 0x0605E649 RID: 386633 RVA: 0x01494856 File Offset: 0x01492A56
		// (set) Token: 0x0605E64A RID: 386634 RVA: 0x0149485E File Offset: 0x01492A5E
		public float SpotAngle_C108
		{
			get
			{
				return this.m_SpotAngle;
			}
			set
			{
				this.m_SpotAngle = value;
			}
		}

		// Token: 0x17021917 RID: 137495
		// (get) Token: 0x0605E64B RID: 386635 RVA: 0x01494867 File Offset: 0x01492A67
		// (set) Token: 0x0605E64C RID: 386636 RVA: 0x0149486F File Offset: 0x01492A6F
		public int Type_C108
		{
			get
			{
				return this.m_Type;
			}
			set
			{
				this.m_Type = value;
			}
		}

		// Token: 0x17021918 RID: 137496
		// (get) Token: 0x0605E64D RID: 386637 RVA: 0x01494878 File Offset: 0x01492A78
		// (set) Token: 0x0605E64E RID: 386638 RVA: 0x0149487B File Offset: 0x01492A7B
		public bool UseBoundingSphereOverride_C108
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17021919 RID: 137497
		// (get) Token: 0x0605E64F RID: 386639 RVA: 0x0149487D File Offset: 0x01492A7D
		// (set) Token: 0x0605E650 RID: 386640 RVA: 0x01494885 File Offset: 0x01492A85
		public bool UseColorTemperature_C108
		{
			get
			{
				return this.m_UseColorTemperature;
			}
			set
			{
				this.m_UseColorTemperature = value;
			}
		}

		// Token: 0x1702191A RID: 137498
		// (get) Token: 0x0605E651 RID: 386641 RVA: 0x0149488E File Offset: 0x01492A8E
		// (set) Token: 0x0605E652 RID: 386642 RVA: 0x01494891 File Offset: 0x01492A91
		public bool UseViewFrustumForShadowCasterCull_C108
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1702191B RID: 137499
		// (get) Token: 0x0605E653 RID: 386643 RVA: 0x01494893 File Offset: 0x01492A93
		// (set) Token: 0x0605E654 RID: 386644 RVA: 0x0149489B File Offset: 0x01492A9B
		public HideFlags HideFlags_C108E
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

		// Token: 0x1702191C RID: 137500
		// (get) Token: 0x0605E655 RID: 386645 RVA: 0x014948A4 File Offset: 0x01492AA4
		// (set) Token: 0x0605E656 RID: 386646 RVA: 0x014948A7 File Offset: 0x01492AA7
		public LightShadowCasterMode LightShadowCasterMode_C108E
		{
			get
			{
				return LightShadowCasterMode.Default;
			}
			set
			{
			}
		}

		// Token: 0x1702191D RID: 137501
		// (get) Token: 0x0605E657 RID: 386647 RVA: 0x014948A9 File Offset: 0x01492AA9
		// (set) Token: 0x0605E658 RID: 386648 RVA: 0x014948B1 File Offset: 0x01492AB1
		public LightRenderMode RenderMode_C108E
		{
			get
			{
				return (LightRenderMode)this.m_RenderMode;
			}
			set
			{
				this.m_RenderMode = (int)value;
			}
		}

		// Token: 0x1702191E RID: 137502
		// (get) Token: 0x0605E659 RID: 386649 RVA: 0x014948BA File Offset: 0x01492ABA
		// (set) Token: 0x0605E65A RID: 386650 RVA: 0x014948BD File Offset: 0x01492ABD
		public LightShadows Shadows_C108E
		{
			get
			{
				return LightShadows.None;
			}
			set
			{
			}
		}

		// Token: 0x1702191F RID: 137503
		// (get) Token: 0x0605E65B RID: 386651 RVA: 0x014948BF File Offset: 0x01492ABF
		// (set) Token: 0x0605E65C RID: 386652 RVA: 0x014948C2 File Offset: 0x01492AC2
		public LightShape Shape_C108E
		{
			get
			{
				return LightShape.Cone;
			}
			set
			{
			}
		}

		// Token: 0x17021920 RID: 137504
		// (get) Token: 0x0605E65D RID: 386653 RVA: 0x014948C4 File Offset: 0x01492AC4
		// (set) Token: 0x0605E65E RID: 386654 RVA: 0x014948CC File Offset: 0x01492ACC
		public LightType_0 Type_C108E
		{
			get
			{
				return (LightType_0)this.m_Type;
			}
			set
			{
				this.m_Type = (int)value;
			}
		}

		// Token: 0x17021921 RID: 137505
		// (get) Token: 0x0605E65F RID: 386655 RVA: 0x014948D5 File Offset: 0x01492AD5
		// (set) Token: 0x0605E660 RID: 386656 RVA: 0x014948E8 File Offset: 0x01492AE8
		public ITexture Cookie_C108P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<ITexture>(this.Cookie_C108, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<ITexture>(this.Cookie_C108, base.Collection, value);
			}
		}

		// Token: 0x17021922 RID: 137506
		// (get) Token: 0x0605E661 RID: 386657 RVA: 0x014948FC File Offset: 0x01492AFC
		// (set) Token: 0x0605E662 RID: 386658 RVA: 0x0149490F File Offset: 0x01492B0F
		public IEditorExtension CorrespondingSourceObject_C108P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IEditorExtension>(this.CorrespondingSourceObject_C108, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IEditorExtension>(this.CorrespondingSourceObject_C108, base.Collection, value);
			}
		}

		// Token: 0x17021923 RID: 137507
		// (get) Token: 0x0605E663 RID: 386659 RVA: 0x01494923 File Offset: 0x01492B23
		// (set) Token: 0x0605E664 RID: 386660 RVA: 0x01494926 File Offset: 0x01492B26
		public IEditorExtensionImpl ExtensionPtr_C108P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17021924 RID: 137508
		// (get) Token: 0x0605E665 RID: 386661 RVA: 0x01494928 File Offset: 0x01492B28
		// (set) Token: 0x0605E666 RID: 386662 RVA: 0x0149493B File Offset: 0x01492B3B
		public IFlare Flare_C108P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IFlare>(this.Flare_C108, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IFlare>(this.Flare_C108, base.Collection, value);
			}
		}

		// Token: 0x17021925 RID: 137509
		// (get) Token: 0x0605E667 RID: 386663 RVA: 0x0149494F File Offset: 0x01492B4F
		// (set) Token: 0x0605E668 RID: 386664 RVA: 0x01494962 File Offset: 0x01492B62
		public IGameObject GameObject_C108P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IGameObject>(this.GameObject_C108, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IGameObject>(this.GameObject_C108, base.Collection, value);
			}
		}

		// Token: 0x17021926 RID: 137510
		// (get) Token: 0x0605E669 RID: 386665 RVA: 0x01494976 File Offset: 0x01492B76
		// (set) Token: 0x0605E66A RID: 386666 RVA: 0x01494979 File Offset: 0x01492B79
		public IPrefab PrefabAsset_C108P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17021927 RID: 137511
		// (get) Token: 0x0605E66B RID: 386667 RVA: 0x0149497B File Offset: 0x01492B7B
		// (set) Token: 0x0605E66C RID: 386668 RVA: 0x0149497E File Offset: 0x01492B7E
		public IPrefabInstance PrefabInstance_C108P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17021928 RID: 137512
		// (get) Token: 0x0605E66D RID: 386669 RVA: 0x01494980 File Offset: 0x01492B80
		// (set) Token: 0x0605E66E RID: 386670 RVA: 0x01494993 File Offset: 0x01492B93
		public IPrefabMarker PrefabInternal_C108P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IPrefabMarker>(this.PrefabInternal_C108, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IPrefabMarker>(this.PrefabInternal_C108, base.Collection, value);
			}
		}

		// Token: 0x17021929 RID: 137513
		// (get) Token: 0x0605E66F RID: 386671 RVA: 0x014949A7 File Offset: 0x01492BA7

		public override string ClassName
		{

			get
			{
				return "Light";
			}
		}

		// Token: 0x0605E670 RID: 386672 RVA: 0x014949AE File Offset: 0x01492BAE
		public Light_2017_1_1_GICB2()
			: this(AssetInfo.MakeDummyAssetInfo(108))
		{
		}

		// Token: 0x0605E671 RID: 386673 RVA: 0x014949C0 File Offset: 0x01492BC0
		public Light_2017_1_1_GICB2(AssetInfo info)
			: base(info)
		{
			this.m_BakingOutput = new LightBakingOutput_5_6_0_b5();
			this.m_Color = new ColorRGBAf_3_5_0();
			this.m_Shadows = new ShadowSettings_5_4_0_f3_GICB2();
			this.m_Cookie = new PPtr_Texture_5_0_0();
			this.m_Flare = new PPtr_Flare_5_0_0();
			this.m_CullingMask = new BitField();
			this.m_AreaSize = new Vector2f_3_5_0();
		}

		// Token: 0x0605E672 RID: 386674 RVA: 0x01494A21 File Offset: 0x01492C21
		public bool Has_ActuallyLightmapped_C108()
		{
			return false;
		}

		// Token: 0x0605E673 RID: 386675 RVA: 0x01494A24 File Offset: 0x01492C24
		public bool Has_AreaSize_C108()
		{
			return true;
		}

		// Token: 0x0605E674 RID: 386676 RVA: 0x01494A27 File Offset: 0x01492C27
		public bool Has_BakedIndex_C108()
		{
			return false;
		}

		// Token: 0x0605E675 RID: 386677 RVA: 0x01494A2A File Offset: 0x01492C2A
		public bool Has_BakingOutput_C108()
		{
			return true;
		}

		// Token: 0x0605E676 RID: 386678 RVA: 0x01494A2D File Offset: 0x01492C2D
		public bool Has_BounceIntensity_C108()
		{
			return true;
		}

		// Token: 0x0605E677 RID: 386679 RVA: 0x01494A30 File Offset: 0x01492C30
		public bool Has_BoundingSphereOverride_C108()
		{
			return false;
		}

		// Token: 0x0605E678 RID: 386680 RVA: 0x01494A33 File Offset: 0x01492C33
		public bool Has_CCT_C108()
		{
			return false;
		}

		// Token: 0x0605E679 RID: 386681 RVA: 0x01494A36 File Offset: 0x01492C36
		public bool Has_ColorTemperature_C108()
		{
			return true;
		}

		// Token: 0x0605E67A RID: 386682 RVA: 0x01494A39 File Offset: 0x01492C39
		public bool Has_CorrespondingSourceObject_C108()
		{
			return true;
		}

		// Token: 0x0605E67B RID: 386683 RVA: 0x01494A3C File Offset: 0x01492C3C
		public bool Has_ExtensionPtr_C108()
		{
			return false;
		}

		// Token: 0x0605E67C RID: 386684 RVA: 0x01494A3F File Offset: 0x01492C3F
		public bool Has_FalloffTable_C108()
		{
			return false;
		}

		// Token: 0x0605E67D RID: 386685 RVA: 0x01494A42 File Offset: 0x01492C42
		public bool Has_IndirectIntensity_C108()
		{
			return false;
		}

		// Token: 0x0605E67E RID: 386686 RVA: 0x01494A45 File Offset: 0x01492C45
		public bool Has_InnerSpotAngle_C108()
		{
			return false;
		}

		// Token: 0x0605E67F RID: 386687 RVA: 0x01494A48 File Offset: 0x01492C48
		public bool Has_LightShadowCasterMode_C108()
		{
			return false;
		}

		// Token: 0x0605E680 RID: 386688 RVA: 0x01494A4B File Offset: 0x01492C4B
		public bool Has_PrefabAsset_C108()
		{
			return false;
		}

		// Token: 0x0605E681 RID: 386689 RVA: 0x01494A4E File Offset: 0x01492C4E
		public bool Has_PrefabInstance_C108()
		{
			return false;
		}

		// Token: 0x0605E682 RID: 386690 RVA: 0x01494A51 File Offset: 0x01492C51
		public bool Has_PrefabInternal_C108()
		{
			return true;
		}

		// Token: 0x0605E683 RID: 386691 RVA: 0x01494A54 File Offset: 0x01492C54
		public bool Has_RenderingLayerMask_C108()
		{
			return false;
		}

		// Token: 0x0605E684 RID: 386692 RVA: 0x01494A57 File Offset: 0x01492C57
		public bool Has_ShadowSamples_C108()
		{
			return false;
		}

		// Token: 0x0605E685 RID: 386693 RVA: 0x01494A5A File Offset: 0x01492C5A
		public bool Has_Shape_C108()
		{
			return false;
		}

		// Token: 0x0605E686 RID: 386694 RVA: 0x01494A5D File Offset: 0x01492C5D
		public bool Has_UseBoundingSphereOverride_C108()
		{
			return false;
		}

		// Token: 0x0605E687 RID: 386695 RVA: 0x01494A60 File Offset: 0x01492C60
		public bool Has_UseColorTemperature_C108()
		{
			return true;
		}

		// Token: 0x0605E688 RID: 386696 RVA: 0x01494A63 File Offset: 0x01492C63
		public bool Has_UseViewFrustumForShadowCasterCull_C108()
		{
			return false;
		}

		// Token: 0x0605E689 RID: 386697 RVA: 0x01494A68 File Offset: 0x01492C68

		public override void ReadRelease(AssetReader reader)
		{
			this.m_GameObject.ReadRelease(reader);
			this.m_Enabled = reader.ReadRelease_ByteAlign();
			this.m_Type = reader.ReadInt32();
			this.m_Color.ReadRelease(reader);
			this.m_Intensity = reader.ReadSingle();
			this.m_Range = reader.ReadSingle();
			this.m_SpotAngle = reader.ReadSingle();
			SpotInnerAngle = reader.ReadSingle();
			this.m_CookieSize = reader.ReadSingle();
			this.m_Shadows.ReadRelease(reader);
			this.m_Cookie.ReadRelease(reader);
			this.m_DrawHalo = reader.ReadRelease_BooleanAlign();
			this.m_BakingOutput.ReadRelease(reader);
			this.m_Flare.ReadRelease(reader);
			this.m_RenderMode = reader.ReadInt32();
			this.m_CullingMask.ReadRelease(reader);
			//var m_Bits = reader.ReadUInt32();
			this.m_Lightmapping = reader.ReadInt32();
			this.m_AreaSize.ReadRelease(reader);
			this.m_BounceIntensity = reader.ReadSingle();
			this.m_ColorTemperature = reader.ReadSingle();
			this.m_UseColorTemperature = reader.ReadRelease_BooleanAlign();
			ViewDistanceRatio = reader.ReadSingle();
			ShadowAngleLimit = reader.ReadSingle();
			ForceShadow = reader.ReadBoolean();
			reader.AlignStream();
			LightOnLevel = reader.ReadInt32();
			reader.AlignStream();
		}

		// Token: 0x0605E68A RID: 386698 RVA: 0x01494B68 File Offset: 0x01492D68

		public override void ReadEditor(AssetReader reader)
		{
			// this.m_HideFlags = reader.ReadUInt32();
			// this.m_CorrespondingSourceObject.ReadEditor(reader);
			// this.m_PrefabInternal.ReadEditor(reader);
			// this.m_GameObject.ReadEditor(reader);
			// this.m_Enabled = reader.ReadEditor_ByteAlign();
			// this.m_Type = reader.ReadInt32();
			// this.m_Color.ReadEditor(reader);
			// this.m_Intensity = reader.ReadSingle();
			// this.m_Range = reader.ReadSingle();
			// this.m_SpotAngle = reader.ReadSingle();
			// this.m_CookieSize = reader.ReadSingle();
			// this.m_Shadows.ReadEditor(reader);
			// this.m_Cookie.ReadEditor(reader);
			// this.m_DrawHalo = reader.ReadEditor_BooleanAlign();
			// this.m_Flare.ReadEditor(reader);
			// this.m_RenderMode = reader.ReadInt32();
			// this.m_CullingMask.ReadEditor(reader);
			// this.m_Lightmapping = reader.ReadInt32();
			// this.m_AreaSize.ReadEditor(reader);
			// this.m_BounceIntensity = reader.ReadSingle();
			// this.m_ColorTemperature = reader.ReadSingle();
			// this.m_UseColorTemperature = reader.ReadEditor_BooleanAlign();
			// this.m_ShadowRadius = reader.ReadSingle();
			// this.m_ShadowAngle = reader.ReadSingle();
		}

		// Token: 0x0605E68B RID: 386699 RVA: 0x01494C98 File Offset: 0x01492E98

		public override void WriteRelease(AssetWriter writer)
		{
			this.m_GameObject.WriteRelease(writer);
			this.m_Enabled.WriteRelease_ByteAlign(writer);
			this.m_Type.WriteRelease_Int32(writer);
			this.m_Color.WriteRelease(writer);
			this.m_Intensity.WriteRelease_Single(writer);
			this.m_Range.WriteRelease_Single(writer);
			this.m_SpotAngle.WriteRelease_Single(writer);
			this.m_CookieSize.WriteRelease_Single(writer);
			this.m_Shadows.WriteRelease(writer);
			this.m_Cookie.WriteRelease(writer);
			this.m_DrawHalo.WriteRelease_BooleanAlign(writer);
			this.m_BakingOutput.WriteRelease(writer);
			this.m_Flare.WriteRelease(writer);
			this.m_RenderMode.WriteRelease_Int32(writer);
			this.m_CullingMask.WriteRelease(writer);
			this.m_Lightmapping.WriteRelease_Int32(writer);
			this.m_AreaSize.WriteRelease(writer);
			this.m_BounceIntensity.WriteRelease_Single(writer);
			this.m_ColorTemperature.WriteRelease_Single(writer);
			this.m_UseColorTemperature.WriteRelease_BooleanAlign(writer);
		}

		// Token: 0x0605E68C RID: 386700 RVA: 0x01494D98 File Offset: 0x01492F98

		public override void WriteEditor(AssetWriter writer)
		{
			// this.m_HideFlags.WriteEditor_UInt32(writer);
			// this.m_CorrespondingSourceObject.WriteEditor(writer);
			// this.m_PrefabInternal.WriteEditor(writer);
			// this.m_GameObject.WriteEditor(writer);
			// this.m_Enabled.WriteEditor_ByteAlign(writer);
			// this.m_Type.WriteEditor_Int32(writer);
			// this.m_Color.WriteEditor(writer);
			// this.m_Intensity.WriteEditor_Single(writer);
			// this.m_Range.WriteEditor_Single(writer);
			// this.m_SpotAngle.WriteEditor_Single(writer);
			// this.m_CookieSize.WriteEditor_Single(writer);
			// this.m_Shadows.WriteEditor(writer);
			// this.m_Cookie.WriteEditor(writer);
			// this.m_DrawHalo.WriteEditor_BooleanAlign(writer);
			// this.m_Flare.WriteEditor(writer);
			// this.m_RenderMode.WriteEditor_Int32(writer);
			// this.m_CullingMask.WriteEditor(writer);
			// this.m_Lightmapping.WriteEditor_Int32(writer);
			// this.m_AreaSize.WriteEditor(writer);
			// this.m_BounceIntensity.WriteEditor_Single(writer);
			// this.m_ColorTemperature.WriteEditor_Single(writer);
			// this.m_UseColorTemperature.WriteEditor_BooleanAlign(writer);
			// this.m_ShadowRadius.WriteEditor_Single(writer);
			// this.m_ShadowAngle.WriteEditor_Single(writer);
		}

		// Token: 0x0605E68D RID: 386701 RVA: 0x01494EC8 File Offset: 0x014930C8

		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 8);
			yamlMappingNode.Add(new YamlScalarNode("m_GameObject"), this.m_GameObject.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Enabled"), this.m_Enabled.ExportYamlRelease_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Type"), this.m_Type.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Color"), this.m_Color.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Intensity"), this.m_Intensity.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Range"), this.m_Range.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SpotAngle"), this.m_SpotAngle.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_CookieSize"), this.m_CookieSize.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Shadows"), this.m_Shadows.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Cookie"), this.m_Cookie.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_DrawHalo"), this.m_DrawHalo.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_BakingOutput"), this.m_BakingOutput.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Flare"), this.m_Flare.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_RenderMode"), this.m_RenderMode.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_CullingMask"), this.m_CullingMask.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Lightmapping"), this.m_Lightmapping.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AreaSize"), this.m_AreaSize.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_BounceIntensity"), this.m_BounceIntensity.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ColorTemperature"), this.m_ColorTemperature.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_UseColorTemperature"), this.m_UseColorTemperature.ExportYamlRelease_Boolean(container));
			return yamlMappingNode;
		}

		// Token: 0x0605E68E RID: 386702 RVA: 0x01495114 File Offset: 0x01493314

		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 8);
			yamlMappingNode.Add(new YamlScalarNode("m_ObjectHideFlags"), this.m_HideFlags.ExportYamlEditor_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabParentObject"), this.m_CorrespondingSourceObject.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabInternal"), this.m_PrefabInternal.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_GameObject"), this.m_GameObject.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Enabled"), this.m_Enabled.ExportYamlEditor_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Type"), this.m_Type.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Color"), this.m_Color.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Intensity"), this.m_Intensity.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Range"), this.m_Range.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SpotAngle"), this.m_SpotAngle.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_CookieSize"), this.m_CookieSize.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Shadows"), this.m_Shadows.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Cookie"), this.m_Cookie.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_DrawHalo"), this.m_DrawHalo.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Flare"), this.m_Flare.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_RenderMode"), this.m_RenderMode.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_CullingMask"), this.m_CullingMask.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Lightmapping"), this.m_Lightmapping.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AreaSize"), this.m_AreaSize.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_BounceIntensity"), this.m_BounceIntensity.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ColorTemperature"), this.m_ColorTemperature.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_UseColorTemperature"), this.m_UseColorTemperature.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ShadowRadius"), this.m_ShadowRadius.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ShadowAngle"), this.m_ShadowAngle.ExportYamlEditor_Single(container));
			return yamlMappingNode;
		}

		// Token: 0x0605E68F RID: 386703 RVA: 0x014953D0 File Offset: 0x014935D0
		public override void Reset()
		{
			this.m_AreaSize.Reset();
			this.m_BakingOutput.Reset();
			this.m_BounceIntensity = 0f;
			this.m_Color.Reset();
			this.m_ColorTemperature = 0f;
			this.m_Cookie.Reset();
			this.m_CookieSize = 0f;
			this.m_CorrespondingSourceObject.Reset();
			this.m_CullingMask.Reset();
			this.m_DrawHalo = false;
			this.m_Enabled = 0;
			this.m_Flare.Reset();
			this.m_GameObject.Reset();
			this.m_HideFlags = 0U;
			this.m_Intensity = 0f;
			this.m_Lightmapping = 0;
			this.m_PrefabInternal.Reset();
			this.m_Range = 0f;
			this.m_RenderMode = 0;
			this.m_ShadowAngle = 0f;
			this.m_ShadowRadius = 0f;
			this.m_Shadows.Reset();
			this.m_SpotAngle = 0f;
			this.m_Type = 0;
			this.m_UseColorTemperature = false;
		}

		// Token: 0x0605E690 RID: 386704 RVA: 0x014954D4 File Offset: 0x014936D4
		//public override IEnumerable<ValueTuple<FieldName, PPtr<IUnityObjectBase>>> FetchDependencies(FieldName parent)
		//{
		//	return Enumerable.Empty<ValueTuple<FieldName, PPtr<IUnityObjectBase>>>().Append_Light_2017_1_1(parent, this);
		//}

		// Token: 0x0605E691 RID: 386705 RVA: 0x014954E4 File Offset: 0x014936E4

		public void CopyValues(ILight source, PPtrConverter converter)
		{
			this.m_AreaSize.CopyValues(source.AreaSize_C108);
			this.m_BakingOutput.CopyValues(source.BakingOutput_C108);
			this.m_BounceIntensity = source.BounceIntensity_C108;
			this.m_Color.CopyValues(source.Color_C108);
			this.m_ColorTemperature = source.ColorTemperature_C108;
			this.m_Cookie.CopyValues(source.Cookie_C108, converter);
			this.m_CookieSize = source.CookieSize_C108;
			this.m_CorrespondingSourceObject.CopyValues(source.CorrespondingSourceObject_C108, converter);
			this.m_CullingMask.CopyValues(source.CullingMask_C108);
			this.m_DrawHalo = source.DrawHalo_C108;
			this.m_Enabled = source.Enabled_C108;
			this.m_Flare.CopyValues(source.Flare_C108, converter);
			this.m_GameObject.CopyValues(source.GameObject_C108, converter);
			this.m_HideFlags = source.HideFlags_C108;
			this.m_Intensity = source.Intensity_C108;
			this.m_Lightmapping = source.Lightmapping_C108;
			this.m_PrefabInternal.CopyValues(source.PrefabInternal_C108, converter);
			this.m_Range = source.Range_C108;
			this.m_RenderMode = source.RenderMode_C108;
			this.m_ShadowAngle = source.ShadowAngle_C108;
			this.m_ShadowRadius = source.ShadowRadius_C108;
			this.m_Shadows.CopyValues(source.Shadows_C108);
			this.m_SpotAngle = source.SpotAngle_C108;
			this.m_Type = source.Type_C108;
			this.m_UseColorTemperature = source.UseColorTemperature_C108;
		}

		// Token: 0x0605E692 RID: 386706 RVA: 0x01495654 File Offset: 0x01493854

		public void CopyValues(ILight source)
		{
			this.CopyValues(source, new PPtrConverter(source, this));
		}

		// Token: 0x0605E693 RID: 386707 RVA: 0x01495664 File Offset: 0x01493864
		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			ILight light = source as ILight;
			if (light != null)
			{
				this.CopyValues(light, converter);
				return;
			}
			base.CopyValues(source, converter);
		}

		// Token: 0x0605E694 RID: 386708 RVA: 0x0149568C File Offset: 0x0149388C

		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0605E695 RID: 386709 RVA: 0x01495693 File Offset: 0x01493893

		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04036CDE RID: 224478

		public LightBakingOutput_5_6_0_b5 m_BakingOutput;

		// Token: 0x04036CDF RID: 224479
		public float m_ShadowRadius;

		// Token: 0x04036CE0 RID: 224480
		public float m_ShadowAngle;

		// Token: 0x04036CE1 RID: 224481
		public int m_Type;

		// Token: 0x04036CE2 RID: 224482

		public ColorRGBAf_3_5_0 m_Color;

		// Token: 0x04036CE3 RID: 224483
		public float m_Intensity;

		// Token: 0x04036CE4 RID: 224484
		public float m_Range;

		// Token: 0x04036CE5 RID: 224485
		public float m_SpotAngle;

		// Token: 0x04036CE6 RID: 224486
		public float m_CookieSize;

		// Token: 0x04036CE7 RID: 224487

		public ShadowSettings_5_4_0_f3_GICB2 m_Shadows;

		// Token: 0x04036CE8 RID: 224488

		public PPtr_Texture_5_0_0 m_Cookie;

		// Token: 0x04036CE9 RID: 224489
		public bool m_DrawHalo;

		// Token: 0x04036CEA RID: 224490

		public PPtr_Flare_5_0_0 m_Flare;

		// Token: 0x04036CEB RID: 224491
		public int m_RenderMode;

		// Token: 0x04036CEC RID: 224492

		public BitField m_CullingMask;

		// Token: 0x04036CED RID: 224493
		public int m_Lightmapping;

		// Token: 0x04036CEE RID: 224494

		public Vector2f_3_5_0 m_AreaSize;

		// Token: 0x04036CEF RID: 224495
		public float m_BounceIntensity;

		// Token: 0x04036CF0 RID: 224496
		public float m_ColorTemperature;

		// Token: 0x04036CF1 RID: 224497
		public bool m_UseColorTemperature;

		public float SpotInnerAngle { get; set; }
		public float ViewDistanceRatio { get; set; }
		public float ShadowAngleLimit { get; set; }
		public bool ForceShadow { get; set; }
		public int LightOnLevel { get; set; }
		public float VolumetricLightStrength { get; set; }
	}
}
