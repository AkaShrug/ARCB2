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
using AssetRipper.SourceGenerated.Classes.ClassID_18;
using AssetRipper.SourceGenerated.Classes.ClassID_2;
using AssetRipper.SourceGenerated.Classes.ClassID_8;
using AssetRipper.SourceGenerated.Classes.ClassID_90;
using AssetRipper.SourceGenerated.Classes.ClassID_91;
using AssetRipper.SourceGenerated.Classes.ClassID_93;
using AssetRipper.SourceGenerated.Enums;
using AssetRipper.SourceGenerated.Helpers;
using AssetRipper.SourceGenerated.Interfaces;
using AssetRipper.SourceGenerated.MarkerInterfaces;
using AssetRipper.SourceGenerated.Subclasses.PPtr_AnimatorController;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Avatar;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtension;
using AssetRipper.SourceGenerated.Subclasses.PPtr_GameObject;
using AssetRipper.SourceGenerated.Subclasses.PPtr_PrefabInstance;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Prefab;
using AssetRipper.SourceGenerated.Subclasses.PPtr_RuntimeAnimatorController;
using AssetRipper.SourceGenerated.Subclasses.Utf8String;
using AssetRipper.Yaml;
using AssetRipper.SourceGenerated.Subclasses.PPtr_NamedObject;
using AssetRipper.SourceGenerated.Classes.ClassID_95;

namespace AssetRipper.Import.GICB2.Animatior
{
	// Token: 0x0200256A RID: 9578


	public sealed class Animator_5_6_0_GICB2 : Behaviour_5_5_0, IAnimator, IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IAnimatorMarker, IBehaviour, IBehaviourMarker, IComponent, IEditorExtension, IEditorExtensionMarker, IObject, IObjectMarker, IHasHideFlags, IComponentMarker, IHasEnabled
	{
		// Token: 0x170068FE RID: 26878
		// (get) Token: 0x0601A5E2 RID: 108002 RVA: 0x0041EE5A File Offset: 0x0041D05A
		// (set) Token: 0x0601A5E3 RID: 108003 RVA: 0x0041EE62 File Offset: 0x0041D062
		public bool AllowConstantClipSamplingOptimization_C95
		{
			get
			{
				return this.m_AllowConstantClipSamplingOptimization;
			}
			set
			{
				this.m_AllowConstantClipSamplingOptimization = value;
			}
		}

		// Token: 0x170068FF RID: 26879
		// (get) Token: 0x0601A5E4 RID: 108004 RVA: 0x0041EE6B File Offset: 0x0041D06B
		// (set) Token: 0x0601A5E5 RID: 108005 RVA: 0x0041EE6E File Offset: 0x0041D06E
		public bool AnimatePhysics_C95
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17006900 RID: 26880
		// (get) Token: 0x0601A5E6 RID: 108006 RVA: 0x0041EE70 File Offset: 0x0041D070
		// (set) Token: 0x0601A5E7 RID: 108007 RVA: 0x0041EE78 File Offset: 0x0041D078
		public bool ApplyRootMotion_C95
		{
			get
			{
				return this.m_ApplyRootMotion;
			}
			set
			{
				this.m_ApplyRootMotion = value;
			}
		}

		// Token: 0x17006901 RID: 26881
		// (get) Token: 0x0601A5E8 RID: 108008 RVA: 0x0041EE81 File Offset: 0x0041D081

		public IPPtr_Avatar Avatar_C95
		{

			get
			{
				return this.m_Avatar;
			}
		}

		// Token: 0x17006902 RID: 26882
		// (get) Token: 0x0601A5E9 RID: 108009 RVA: 0x0041EE89 File Offset: 0x0041D089
		public PPtr_AnimatorController_4_0_0 Controller_C95_PPtr_AnimatorController_4_0_0
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006903 RID: 26883
		// (get) Token: 0x0601A5EA RID: 108010 RVA: 0x0041EE8C File Offset: 0x0041D08C
		public PPtr_RuntimeAnimatorController_4_3_0 Controller_C95_PPtr_RuntimeAnimatorController_4_3_0
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006904 RID: 26884
		// (get) Token: 0x0601A5EB RID: 108011 RVA: 0x0041EE8F File Offset: 0x0041D08F
		public PPtr_RuntimeAnimatorController_5_0_0 Controller_C95_PPtr_RuntimeAnimatorController_5_0_0
		{
			[return: NotNull]
			get
			{
				return this.m_Controller;
			}
		}

		// Token: 0x17006905 RID: 26885
		// (get) Token: 0x0601A5EC RID: 108012 RVA: 0x0041EE97 File Offset: 0x0041D097

		public IPPtr_EditorExtension CorrespondingSourceObject_C95
		{

			get
			{
				return this.m_CorrespondingSourceObject;
			}
		}

		// Token: 0x17006906 RID: 26886
		// (get) Token: 0x0601A5ED RID: 108013 RVA: 0x0041EE9F File Offset: 0x0041D09F
		// (set) Token: 0x0601A5EE RID: 108014 RVA: 0x0041EEA7 File Offset: 0x0041D0A7
		public int CullingMode_C95
		{
			get
			{
				return this.m_CullingMode;
			}
			set
			{
				this.m_CullingMode = value;
			}
		}

		// Token: 0x17006907 RID: 26887
		// (get) Token: 0x0601A5EF RID: 108015 RVA: 0x0041EEB0 File Offset: 0x0041D0B0
		// (set) Token: 0x0601A5F0 RID: 108016 RVA: 0x0041EEB8 File Offset: 0x0041D0B8
		public byte Enabled_C95
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

		// Token: 0x17006908 RID: 26888
		// (get) Token: 0x0601A5F1 RID: 108017 RVA: 0x0041EEC1 File Offset: 0x0041D0C1

		public IPPtr_GameObject GameObject_C95
		{

			get
			{
				return this.m_GameObject;
			}
		}

		// Token: 0x17006909 RID: 26889
		// (get) Token: 0x0601A5F2 RID: 108018 RVA: 0x0041EEC9 File Offset: 0x0041D0C9
		// (set) Token: 0x0601A5F3 RID: 108019 RVA: 0x0041EED1 File Offset: 0x0041D0D1
		public bool HasTransformHierarchy_C95
		{
			get
			{
				return this.m_HasTransformHierarchy;
			}
			set
			{
				this.m_HasTransformHierarchy = value;
			}
		}

		// Token: 0x1700690A RID: 26890
		// (get) Token: 0x0601A5F4 RID: 108020 RVA: 0x0041EEDA File Offset: 0x0041D0DA
		// (set) Token: 0x0601A5F5 RID: 108021 RVA: 0x0041EEE2 File Offset: 0x0041D0E2
		public uint HideFlags_C95
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

		// Token: 0x1700690B RID: 26891
		// (get) Token: 0x0601A5F6 RID: 108022 RVA: 0x0041EEEB File Offset: 0x0041D0EB
		// (set) Token: 0x0601A5F7 RID: 108023 RVA: 0x0041EEEE File Offset: 0x0041D0EE
		public bool KeepAnimatorControllerStateOnDisable_C95
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17006A39 RID: 27193
		// (get) Token: 0x0601A9E8 RID: 109032 RVA: 0x0041F960 File Offset: 0x0041DB60
		// (set) Token: 0x0601A9E9 RID: 109033 RVA: 0x0041F963 File Offset: 0x0041DB63
		public bool KeepAnimatorStateOnDisable_C95
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool WriteDefaultValueOnlyOnAwake_C95
		{
			get
			{
				return this.m_WriteDefaultValueOnlyOnAwake;
			}
			set
			{
				this.m_WriteDefaultValueOnlyOnAwake = value;
			}
		}

		// Token: 0x1700690C RID: 26892
		// (get) Token: 0x0601A5F8 RID: 108024 RVA: 0x0041EEF0 File Offset: 0x0041D0F0
		// (set) Token: 0x0601A5F9 RID: 108025 RVA: 0x0041EEF8 File Offset: 0x0041D0F8
		public bool LinearVelocityBlending_C95
		{
			get
			{
				return this.m_LinearVelocityBlending;
			}
			set
			{
				this.m_LinearVelocityBlending = value;
			}
		}

		// Token: 0x1700690D RID: 26893
		// (get) Token: 0x0601A5FA RID: 108026 RVA: 0x0041EF01 File Offset: 0x0041D101
		public PPtr_Prefab_2018_3_0 PrefabAsset_C95
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700690E RID: 26894
		// (get) Token: 0x0601A5FB RID: 108027 RVA: 0x0041EF04 File Offset: 0x0041D104
		public PPtr_PrefabInstance PrefabInstance_C95
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700690F RID: 26895
		// (get) Token: 0x0601A5FC RID: 108028 RVA: 0x0041EF07 File Offset: 0x0041D107
		public IPPtr_Prefab PrefabInternal_C95
		{
			[return: NotNull]
			get
			{
				return this.m_PrefabInternal;
			}
		}

		// Token: 0x17006910 RID: 26896
		// (get) Token: 0x0601A5FD RID: 108029 RVA: 0x0041EF0F File Offset: 0x0041D10F
		// (set) Token: 0x0601A5FE RID: 108030 RVA: 0x0041EF12 File Offset: 0x0041D112
		public bool StabilizeFeet_C95
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17006911 RID: 26897
		// (get) Token: 0x0601A5FF RID: 108031 RVA: 0x0041EF14 File Offset: 0x0041D114
		// (set) Token: 0x0601A600 RID: 108032 RVA: 0x0041EF1C File Offset: 0x0041D11C
		public int UpdateMode_C95
		{
			get
			{
				return this.m_UpdateMode;
			}
			set
			{
				this.m_UpdateMode = value;
			}
		}

		// Token: 0x17006912 RID: 26898
		// (get) Token: 0x0601A601 RID: 108033 RVA: 0x0041EF25 File Offset: 0x0041D125
		public Utf8String WarningMessage_C95
		{
			[return: NotNull]
			get
			{
				return this.m_WarningMessage;
			}
		}

		// Token: 0x17006913 RID: 26899
		// (get) Token: 0x0601A602 RID: 108034 RVA: 0x0041EF2D File Offset: 0x0041D12D
		// (set) Token: 0x0601A603 RID: 108035 RVA: 0x0041EF35 File Offset: 0x0041D135
		public AnimatorCullingMode CullingMode_C95E
		{
			get
			{
				return (AnimatorCullingMode)this.m_CullingMode;
			}
			set
			{
				this.m_CullingMode = (int)value;
			}
		}

		// Token: 0x17006914 RID: 26900
		// (get) Token: 0x0601A604 RID: 108036 RVA: 0x0041EF3E File Offset: 0x0041D13E
		// (set) Token: 0x0601A605 RID: 108037 RVA: 0x0041EF46 File Offset: 0x0041D146
		public HideFlags HideFlags_C95E
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

		// Token: 0x17006915 RID: 26901
		// (get) Token: 0x0601A606 RID: 108038 RVA: 0x0041EF4F File Offset: 0x0041D14F
		// (set) Token: 0x0601A607 RID: 108039 RVA: 0x0041EF57 File Offset: 0x0041D157
		public AnimatorUpdateMode UpdateMode_C95E
		{
			get
			{
				return (AnimatorUpdateMode)this.m_UpdateMode;
			}
			set
			{
				this.m_UpdateMode = (int)value;
			}
		}

		// Token: 0x17006916 RID: 26902
		// (get) Token: 0x0601A608 RID: 108040 RVA: 0x0041EF60 File Offset: 0x0041D160
		// (set) Token: 0x0601A609 RID: 108041 RVA: 0x0041EF73 File Offset: 0x0041D173
		public IAvatar Avatar_C95P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IAvatar>(this.Avatar_C95, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IAvatar>(this.Avatar_C95, base.Collection, value);
			}
		}

		// Token: 0x17006917 RID: 26903
		// (get) Token: 0x0601A60A RID: 108042 RVA: 0x0041EF87 File Offset: 0x0041D187
		// (set) Token: 0x0601A60B RID: 108043 RVA: 0x0041EF8A File Offset: 0x0041D18A
		public IAnimatorController Controller_C95_PPtr_AnimatorController_4_0_0P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17006918 RID: 26904
		// (get) Token: 0x0601A60C RID: 108044 RVA: 0x0041EF8C File Offset: 0x0041D18C
		// (set) Token: 0x0601A60D RID: 108045 RVA: 0x0041EF8F File Offset: 0x0041D18F
		public IRuntimeAnimatorController Controller_C95_PPtr_RuntimeAnimatorController_4_3_0P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17006919 RID: 26905
		// (get) Token: 0x0601A60E RID: 108046 RVA: 0x0041EF91 File Offset: 0x0041D191
		// (set) Token: 0x0601A60F RID: 108047 RVA: 0x0041EFA4 File Offset: 0x0041D1A4
		public IRuntimeAnimatorController Controller_C95_PPtr_RuntimeAnimatorController_5_0_0P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IRuntimeAnimatorController>(this.Controller_C95_PPtr_RuntimeAnimatorController_5_0_0, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IRuntimeAnimatorController>(this.Controller_C95_PPtr_RuntimeAnimatorController_5_0_0, base.Collection, value);
			}
		}

		// Token: 0x1700691A RID: 26906
		// (get) Token: 0x0601A610 RID: 108048 RVA: 0x0041EFB8 File Offset: 0x0041D1B8
		// (set) Token: 0x0601A611 RID: 108049 RVA: 0x0041EFCB File Offset: 0x0041D1CB
		public IEditorExtension CorrespondingSourceObject_C95P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IEditorExtension>(this.CorrespondingSourceObject_C95, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IEditorExtension>(this.CorrespondingSourceObject_C95, base.Collection, value);
			}
		}

		// Token: 0x1700691B RID: 26907
		// (get) Token: 0x0601A612 RID: 108050 RVA: 0x0041EFDF File Offset: 0x0041D1DF
		// (set) Token: 0x0601A613 RID: 108051 RVA: 0x0041EFF2 File Offset: 0x0041D1F2
		public IGameObject GameObject_C95P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IGameObject>(this.GameObject_C95, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IGameObject>(this.GameObject_C95, base.Collection, value);
			}
		}

		// Token: 0x1700691C RID: 26908
		// (get) Token: 0x0601A614 RID: 108052 RVA: 0x0041F006 File Offset: 0x0041D206
		// (set) Token: 0x0601A615 RID: 108053 RVA: 0x0041F009 File Offset: 0x0041D209
		public IPrefab PrefabAsset_C95P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700691D RID: 26909
		// (get) Token: 0x0601A616 RID: 108054 RVA: 0x0041F00B File Offset: 0x0041D20B
		// (set) Token: 0x0601A617 RID: 108055 RVA: 0x0041F00E File Offset: 0x0041D20E
		public IPrefabInstance PrefabInstance_C95P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700691E RID: 26910
		// (get) Token: 0x0601A618 RID: 108056 RVA: 0x0041F010 File Offset: 0x0041D210
		// (set) Token: 0x0601A619 RID: 108057 RVA: 0x0041F023 File Offset: 0x0041D223
		public IPrefabMarker PrefabInternal_C95P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IPrefabMarker>(this.PrefabInternal_C95, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IPrefabMarker>(this.PrefabInternal_C95, base.Collection, value);
			}
		}

		// Token: 0x1700691F RID: 26911
		// (get) Token: 0x0601A61A RID: 108058 RVA: 0x0041F037 File Offset: 0x0041D237

		public override string ClassName
		{

			get
			{
				return "Animator";
			}
		}

		// Token: 0x0601A61B RID: 108059 RVA: 0x0041F03E File Offset: 0x0041D23E
		public Animator_5_6_0_GICB2()
			: this(AssetInfo.MakeDummyAssetInfo(95))
		{
		}

		// Token: 0x0601A61C RID: 108060 RVA: 0x0041F04D File Offset: 0x0041D24D
		public Animator_5_6_0_GICB2(AssetInfo info)
			: base(info)
		{
			this.m_WarningMessage = new Utf8String();
			this.m_Avatar = new PPtr_Avatar_5_0_0();
			this.m_Controller = new PPtr_RuntimeAnimatorController_5_0_0();
			this.m_FBIKAvatar = new PPtr_NamedObject();
		}

		// Token: 0x0601A61D RID: 108061 RVA: 0x0041F077 File Offset: 0x0041D277
		public bool Has_AllowConstantClipSamplingOptimization_C95()
		{
			return true;
		}

		// Token: 0x0601A61E RID: 108062 RVA: 0x0041F07A File Offset: 0x0041D27A
		public bool Has_AnimatePhysics_C95()
		{
			return false;
		}

		// Token: 0x0601A61F RID: 108063 RVA: 0x0041F07D File Offset: 0x0041D27D
		public bool Has_Controller_C95_PPtr_AnimatorController_4_0_0()
		{
			return false;
		}

		// Token: 0x0601A620 RID: 108064 RVA: 0x0041F080 File Offset: 0x0041D280
		public bool Has_Controller_C95_PPtr_RuntimeAnimatorController_4_3_0()
		{
			return false;
		}

		// Token: 0x0601A621 RID: 108065 RVA: 0x0041F083 File Offset: 0x0041D283
		public bool Has_Controller_C95_PPtr_RuntimeAnimatorController_5_0_0()
		{
			return true;
		}

		// Token: 0x0601A622 RID: 108066 RVA: 0x0041F086 File Offset: 0x0041D286
		public bool Has_HasTransformHierarchy_C95()
		{
			return true;
		}

		// Token: 0x0601A623 RID: 108067 RVA: 0x0041F089 File Offset: 0x0041D289
		public bool Has_KeepAnimatorControllerStateOnDisable_C95()
		{
			return false;
		}

		// Token: 0x0601A624 RID: 108068 RVA: 0x0041F08C File Offset: 0x0041D28C
		public bool Has_LinearVelocityBlending_C95()
		{
			return true;
		}

		// Token: 0x0601A625 RID: 108069 RVA: 0x0041F08F File Offset: 0x0041D28F
		public bool Has_PrefabAsset_C95()
		{
			return false;
		}

		// Token: 0x0601A626 RID: 108070 RVA: 0x0041F092 File Offset: 0x0041D292
		public bool Has_PrefabInstance_C95()
		{
			return false;
		}

		// Token: 0x0601A627 RID: 108071 RVA: 0x0041F095 File Offset: 0x0041D295
		public bool Has_PrefabInternal_C95()
		{
			return true;
		}

		// Token: 0x0601A628 RID: 108072 RVA: 0x0041F098 File Offset: 0x0041D298
		public bool Has_StabilizeFeet_C95()
		{
			return false;
		}

		// Token: 0x0601A629 RID: 108073 RVA: 0x0041F09B File Offset: 0x0041D29B
		public bool Has_UpdateMode_C95()
		{
			return true;
		}

		// Token: 0x0601A62A RID: 108074 RVA: 0x0041F09E File Offset: 0x0041D29E
		public bool Has_WarningMessage_C95()
		{
			return true;
		}

		// Token: 0x0601A62B RID: 108075 RVA: 0x0041F0A4 File Offset: 0x0041D2A4

		public override void ReadRelease(AssetReader reader)
		{
			this.m_GameObject.ReadRelease(reader);
			this.m_Enabled = reader.ReadRelease_ByteAlign();
			this.m_Avatar.ReadRelease(reader);
			this.m_Controller.ReadRelease(reader);
			this.m_FBIKAvatar.ReadRelease(reader); // GICB2
			this.m_CullingMode = reader.ReadInt32();
			this.m_UpdateMode = reader.ReadInt32();
			this.m_ApplyRootMotion = reader.ReadBoolean();
			this.m_LinearVelocityBlending = reader.ReadRelease_BooleanAlign();
			this.m_HasTransformHierarchy = reader.ReadBoolean();
			this.m_AllowConstantClipSamplingOptimization = reader.ReadRelease_BooleanAlign();
			//this.m_KeepAnimatorControllerStateOnDisable = reader.ReadBoolean(); // GICB2
			//this.m_WriteDefaultValueOnlyOnAwake = reader.ReadBoolean(); // GICB2
		}

		// Token: 0x0601A62C RID: 108076 RVA: 0x0041F12C File Offset: 0x0041D32C

		public override void ReadEditor(AssetReader reader)
		{
		}

		// Token: 0x0601A62D RID: 108077 RVA: 0x0041F1E4 File Offset: 0x0041D3E4

		public override void WriteRelease(AssetWriter writer)
		{
			this.m_GameObject.WriteRelease(writer);
			this.m_Enabled.WriteRelease_ByteAlign(writer);
			this.m_Avatar.WriteRelease(writer);
			this.m_Controller.WriteRelease(writer);
			this.m_CullingMode.WriteRelease_Int32(writer);
			this.m_UpdateMode.WriteRelease_Int32(writer);
			this.m_ApplyRootMotion.WriteRelease_Boolean(writer);
			this.m_LinearVelocityBlending.WriteRelease_BooleanAlign(writer);
			this.m_HasTransformHierarchy.WriteRelease_Boolean(writer);
			this.m_AllowConstantClipSamplingOptimization.WriteRelease_BooleanAlign(writer);
		}

		// Token: 0x0601A62E RID: 108078 RVA: 0x0041F26C File Offset: 0x0041D46C

		public override void WriteEditor(AssetWriter writer)
		{
		}

		// Token: 0x0601A62F RID: 108079 RVA: 0x0041F324 File Offset: 0x0041D524

		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 3);
			yamlMappingNode.Add(new YamlScalarNode("m_GameObject"), this.m_GameObject.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Enabled"), this.m_Enabled.ExportYamlRelease_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Avatar"), this.m_Avatar.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Controller"), this.m_Controller.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_FBIKAvatar"), this.m_FBIKAvatar.ExportYamlRelease(container)); // GICB2
			yamlMappingNode.Add(new YamlScalarNode("m_CullingMode"), this.m_CullingMode.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_UpdateMode"), this.m_UpdateMode.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ApplyRootMotion"), this.m_ApplyRootMotion.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LinearVelocityBlending"), this.m_LinearVelocityBlending.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_HasTransformHierarchy"), this.m_HasTransformHierarchy.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AllowConstantClipSamplingOptimization"), this.m_AllowConstantClipSamplingOptimization.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_KeepAnimatorControllerStateOnDisable"), this.m_KeepAnimatorControllerStateOnDisable.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_WriteDefaultValueOnlyOnAwake"), this.m_WriteDefaultValueOnlyOnAwake.ExportYamlRelease_Boolean(container));
			return yamlMappingNode;
		}

		// Token: 0x0601A630 RID: 108080 RVA: 0x0041F458 File Offset: 0x0041D658

		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 3);
			yamlMappingNode.Add(new YamlScalarNode("m_ObjectHideFlags"), this.m_HideFlags.ExportYamlEditor_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabParentObject"), this.m_CorrespondingSourceObject.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabInternal"), this.m_PrefabInternal.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_GameObject"), this.m_GameObject.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Enabled"), this.m_Enabled.ExportYamlEditor_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Avatar"), this.m_Avatar.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Controller"), this.m_Controller.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_CullingMode"), this.m_CullingMode.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_UpdateMode"), this.m_UpdateMode.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ApplyRootMotion"), this.m_ApplyRootMotion.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LinearVelocityBlending"), this.m_LinearVelocityBlending.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_WarningMessage"), this.m_WarningMessage.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_HasTransformHierarchy"), this.m_HasTransformHierarchy.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AllowConstantClipSamplingOptimization"), this.m_AllowConstantClipSamplingOptimization.ExportYamlEditor_Boolean(container));
			return yamlMappingNode;
		}

		// Token: 0x0601A631 RID: 108081 RVA: 0x0041F5FC File Offset: 0x0041D7FC
		public override void Reset()
		{
			this.m_AllowConstantClipSamplingOptimization = false;
			this.m_ApplyRootMotion = false;
			this.m_Avatar.Reset();
			this.m_Controller.Reset();
			this.m_CorrespondingSourceObject.Reset();
			this.m_CullingMode = 0;
			this.m_Enabled = 0;
			this.m_GameObject.Reset();
			this.m_HasTransformHierarchy = false;
			this.m_HideFlags = 0U;
			this.m_KeepAnimatorControllerStateOnDisable = false; // GICB2
			this.m_WriteDefaultValueOnlyOnAwake = false; // GICB2
			this.m_LinearVelocityBlending = false;
			this.m_PrefabInternal.Reset();
			this.m_UpdateMode = 0;
			this.m_WarningMessage.Reset();
		}

		// Token: 0x0601A632 RID: 108082 RVA: 0x0041F683 File Offset: 0x0041D883
		//public override IEnumerable<ValueTuple<FieldName, PPtr<IUnityObjectBase>>> FetchDependencies(FieldName parent)
		//{
		//	return Enumerable.Empty<ValueTuple<FieldName, PPtr<IUnityObjectBase>>>().Append_Animator_5_6_0(parent, this);
		//

		// Token: 0x0601A633 RID: 108083 RVA: 0x0041F694 File Offset: 0x0041D894

		public void CopyValues(IAnimator source, PPtrConverter converter)
		{
			this.m_AllowConstantClipSamplingOptimization = source.AllowConstantClipSamplingOptimization_C95;
			this.m_ApplyRootMotion = source.ApplyRootMotion_C95;
			this.m_Avatar.CopyValues(source.Avatar_C95, converter);
			this.m_Controller.CopyValues(source.Controller_C95_PPtr_RuntimeAnimatorController_5_0_0, converter);
			this.m_CorrespondingSourceObject.CopyValues(source.CorrespondingSourceObject_C95, converter);
			this.m_CullingMode = source.CullingMode_C95;
			this.m_Enabled = source.Enabled_C95;
			this.m_GameObject.CopyValues(source.GameObject_C95, converter);
			this.m_HasTransformHierarchy = source.HasTransformHierarchy_C95;
			this.m_HideFlags = source.HideFlags_C95;
			this.m_KeepAnimatorControllerStateOnDisable = source.KeepAnimatorControllerStateOnDisable_C95; // GICB2
			this.m_LinearVelocityBlending = source.LinearVelocityBlending_C95;
			this.m_PrefabInternal.CopyValues(source.PrefabInternal_C95, converter);
			this.m_UpdateMode = source.UpdateMode_C95;
			this.m_WarningMessage.CopyValues(source.WarningMessage_C95);
		}

		// Token: 0x0601A634 RID: 108084 RVA: 0x0041F76C File Offset: 0x0041D96C

		public void CopyValues(IAnimator source)
		{
			this.CopyValues(source, new PPtrConverter(source, this));
		}

		// Token: 0x0601A635 RID: 108085 RVA: 0x0041F77C File Offset: 0x0041D97C
		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			IAnimator animator = source as IAnimator;
			if (animator != null)
			{
				this.CopyValues(animator, converter);
				return;
			}
			base.CopyValues(source, converter);
		}

		// Token: 0x0601A636 RID: 108086 RVA: 0x0041F7A4 File Offset: 0x0041D9A4

		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0601A637 RID: 108087 RVA: 0x0041F7AB File Offset: 0x0041D9AB

		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		public bool Has_KeepAnimatorStateOnDisable_C95()
		{
			return false;
		}

		// Token: 0x04010BF6 RID: 68598

		public Utf8String m_WarningMessage;

		// Token: 0x04010BF7 RID: 68599

		public PPtr_Avatar_5_0_0 m_Avatar;

		// Token: 0x04010BF8 RID: 68600

		public PPtr_RuntimeAnimatorController_5_0_0 m_Controller;

		public PPtr_NamedObject m_FBIKAvatar; // GICB2

		public bool m_KeepAnimatorControllerStateOnDisable; // GICB2

		public bool m_WriteDefaultValueOnlyOnAwake; // GICB2

		// Token: 0x04010BF9 RID: 68601
		public int m_CullingMode;

		// Token: 0x04010BFA RID: 68602
		public int m_UpdateMode;

		// Token: 0x04010BFB RID: 68603
		public bool m_ApplyRootMotion;

		// Token: 0x04010BFC RID: 68604
		public bool m_LinearVelocityBlending;

		// Token: 0x04010BFD RID: 68605
		public bool m_HasTransformHierarchy;

		// Token: 0x04010BFE RID: 68606
		public bool m_AllowConstantClipSamplingOptimization;
	}
}
