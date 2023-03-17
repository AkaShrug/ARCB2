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
using AssetRipper.SourceGenerated.Classes.ClassID_1;
using AssetRipper.SourceGenerated.Classes.ClassID_1001;
using AssetRipper.SourceGenerated.Classes.ClassID_1001480554;
using AssetRipper.SourceGenerated.Classes.ClassID_1002;
using AssetRipper.SourceGenerated.Classes.ClassID_18;
using AssetRipper.SourceGenerated.Classes.ClassID_2;
using AssetRipper.SourceGenerated.Classes.ClassID_74;
using AssetRipper.SourceGenerated.Classes.ClassID_8;
using AssetRipper.SourceGenerated.Enums;
using AssetRipper.SourceGenerated.Helpers;
using AssetRipper.SourceGenerated.Interfaces;
using AssetRipper.SourceGenerated.MarkerInterfaces;
using AssetRipper.SourceGenerated.Subclasses.AABB;
using AssetRipper.SourceGenerated.Subclasses.PPtr_AnimationClip;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtensionImpl;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtension;
using AssetRipper.SourceGenerated.Subclasses.PPtr_GameObject;
using AssetRipper.SourceGenerated.Subclasses.PPtr_PrefabInstance;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Prefab;
using AssetRipper.Yaml;
using AssetRipper.Import.GICB2.PPtr_AnimationClip;
using AssetRipper.IClasses.PPtr_AnimationClip;
using AssetRipper.IClasses.AnimationClip;
using AssetRipper.IClasses.Animation;

namespace AssetRipper.Import.GICB2.Animation
{
	// Token: 0x020033D9 RID: 13273


	public sealed class Animation_2017_1_0_GICB2 : Behaviour_5_5_0, IAnimation_ACL, IBehaviour, IBehaviourMarker, IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IComponent, IEditorExtension, IEditorExtensionMarker, IObject, IObjectMarker, IHasHideFlags, IComponentMarker, IHasEnabled, IAnimationMarker
	{
		// Token: 0x1702047C RID: 132220
		// (get) Token: 0x0605B561 RID: 374113 RVA: 0x01434B61 File Offset: 0x01432D61
		// (set) Token: 0x0605B562 RID: 374114 RVA: 0x01434B69 File Offset: 0x01432D69
		public bool AnimatePhysics_C111
		{
			get
			{
				return this.m_AnimatePhysics;
			}
			set
			{
				this.m_AnimatePhysics = value;
			}
		}

		// Token: 0x1702047D RID: 132221
		// (get) Token: 0x0605B563 RID: 374115 RVA: 0x01434B72 File Offset: 0x01432D72

		public IPPtr_AnimationClip_ACL Animation_C111
		{

			get
			{
				return this.m_Animation;
			}
		}

		// Token: 0x1702047E RID: 132222
		// (get) Token: 0x0605B564 RID: 374116 RVA: 0x01434B7A File Offset: 0x01432D7A

		public AccessListBase<IPPtr_AnimationClip_ACL> Animations_C111
		{

			get
			{
				return new AccessList<PPtr_AnimationClip_5_0_0_GICB2, IPPtr_AnimationClip_ACL>(this.m_Animations);
			}
		}

		// Token: 0x1702047F RID: 132223
		// (get) Token: 0x0605B565 RID: 374117 RVA: 0x01434B87 File Offset: 0x01432D87
		public IPPtr_EditorExtension CorrespondingSourceObject_C111
		{
			[return: NotNull]
			get
			{
				return this.m_CorrespondingSourceObject;
			}
		}

		// Token: 0x17020480 RID: 132224
		// (get) Token: 0x0605B566 RID: 374118 RVA: 0x01434B8F File Offset: 0x01432D8F
		// (set) Token: 0x0605B567 RID: 374119 RVA: 0x01434B97 File Offset: 0x01432D97
		public int CullingType_C111
		{
			get
			{
				return this.m_CullingType;
			}
			set
			{
				this.m_CullingType = value;
			}
		}

		// Token: 0x17020481 RID: 132225
		// (get) Token: 0x0605B568 RID: 374120 RVA: 0x01434BA0 File Offset: 0x01432DA0
		// (set) Token: 0x0605B569 RID: 374121 RVA: 0x01434BA8 File Offset: 0x01432DA8
		public byte Enabled_C111
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

		// Token: 0x17020482 RID: 132226
		// (get) Token: 0x0605B56A RID: 374122 RVA: 0x01434BB1 File Offset: 0x01432DB1
		public PPtr_EditorExtensionImpl ExtensionPtr_C111
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17020483 RID: 132227
		// (get) Token: 0x0605B56B RID: 374123 RVA: 0x01434BB4 File Offset: 0x01432DB4

		public IPPtr_GameObject GameObject_C111
		{

			get
			{
				return this.m_GameObject;
			}
		}

		// Token: 0x17020484 RID: 132228
		// (get) Token: 0x0605B56C RID: 374124 RVA: 0x01434BBC File Offset: 0x01432DBC
		// (set) Token: 0x0605B56D RID: 374125 RVA: 0x01434BC4 File Offset: 0x01432DC4
		public uint HideFlags_C111
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

		// Token: 0x17020485 RID: 132229
		// (get) Token: 0x0605B56E RID: 374126 RVA: 0x01434BCD File Offset: 0x01432DCD
		// (set) Token: 0x0605B56F RID: 374127 RVA: 0x01434BD5 File Offset: 0x01432DD5
		public bool PlayAutomatically_C111
		{
			get
			{
				return this.m_PlayAutomatically;
			}
			set
			{
				this.m_PlayAutomatically = value;
			}
		}

		// Token: 0x17020486 RID: 132230
		// (get) Token: 0x0605B570 RID: 374128 RVA: 0x01434BDE File Offset: 0x01432DDE
		public PPtr_Prefab_2018_3_0 PrefabAsset_C111
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17020487 RID: 132231
		// (get) Token: 0x0605B571 RID: 374129 RVA: 0x01434BE1 File Offset: 0x01432DE1
		public PPtr_PrefabInstance PrefabInstance_C111
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17020488 RID: 132232
		// (get) Token: 0x0605B572 RID: 374130 RVA: 0x01434BE4 File Offset: 0x01432DE4
		public IPPtr_Prefab PrefabInternal_C111
		{
			[return: NotNull]
			get
			{
				return this.m_PrefabInternal;
			}
		}

		// Token: 0x17020489 RID: 132233
		// (get) Token: 0x0605B573 RID: 374131 RVA: 0x01434BEC File Offset: 0x01432DEC
		public IAABB UserAABB_C111
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1702048A RID: 132234
		// (get) Token: 0x0605B574 RID: 374132 RVA: 0x01434BEF File Offset: 0x01432DEF
		// (set) Token: 0x0605B575 RID: 374133 RVA: 0x01434BF7 File Offset: 0x01432DF7
		public int WrapMode_C111
		{
			get
			{
				return this.m_WrapMode;
			}
			set
			{
				this.m_WrapMode = value;
			}
		}

		// Token: 0x1702048B RID: 132235
		// (get) Token: 0x0605B576 RID: 374134 RVA: 0x01434C00 File Offset: 0x01432E00
		// (set) Token: 0x0605B577 RID: 374135 RVA: 0x01434C08 File Offset: 0x01432E08
		public AnimationCullingType CullingType_C111E
		{
			get
			{
				return (AnimationCullingType)this.m_CullingType;
			}
			set
			{
				this.m_CullingType = (int)value;
			}
		}

		// Token: 0x1702048C RID: 132236
		// (get) Token: 0x0605B578 RID: 374136 RVA: 0x01434C11 File Offset: 0x01432E11
		// (set) Token: 0x0605B579 RID: 374137 RVA: 0x01434C19 File Offset: 0x01432E19
		public HideFlags HideFlags_C111E
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

		// Token: 0x1702048D RID: 132237
		// (get) Token: 0x0605B57A RID: 374138 RVA: 0x01434C22 File Offset: 0x01432E22
		// (set) Token: 0x0605B57B RID: 374139 RVA: 0x01434C2A File Offset: 0x01432E2A
		public WrapMode WrapMode_C111E
		{
			get
			{
				return (WrapMode)this.m_WrapMode;
			}
			set
			{
				this.m_WrapMode = (int)value;
			}
		}

		// Token: 0x1702048E RID: 132238
		// (get) Token: 0x0605B57C RID: 374140 RVA: 0x01434C33 File Offset: 0x01432E33
		// (set) Token: 0x0605B57D RID: 374141 RVA: 0x01434C46 File Offset: 0x01432E46
		public IAnimationClip_ACL Animation_C111P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IAnimationClip_ACL>(this.Animation_C111, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IAnimationClip_ACL>(this.Animation_C111, base.Collection, value);
			}
		}

		// Token: 0x1702048F RID: 132239
		// (get) Token: 0x0605B57E RID: 374142 RVA: 0x01434C5A File Offset: 0x01432E5A
		public PPtrAccessList<IPPtr_AnimationClip_ACL, IAnimationClip_ACL> Animations_C111P
		{
			get
			{
				return new PPtrAccessList<IPPtr_AnimationClip_ACL, IAnimationClip_ACL>(this.Animations_C111, this);
			}
		}

		// Token: 0x17020490 RID: 132240
		// (get) Token: 0x0605B57F RID: 374143 RVA: 0x01434C68 File Offset: 0x01432E68
		// (set) Token: 0x0605B580 RID: 374144 RVA: 0x01434C7B File Offset: 0x01432E7B
		public IEditorExtension CorrespondingSourceObject_C111P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IEditorExtension>(this.CorrespondingSourceObject_C111, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IEditorExtension>(this.CorrespondingSourceObject_C111, base.Collection, value);
			}
		}

		// Token: 0x17020491 RID: 132241
		// (get) Token: 0x0605B581 RID: 374145 RVA: 0x01434C8F File Offset: 0x01432E8F
		// (set) Token: 0x0605B582 RID: 374146 RVA: 0x01434C92 File Offset: 0x01432E92
		public IEditorExtensionImpl ExtensionPtr_C111P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17020492 RID: 132242
		// (get) Token: 0x0605B583 RID: 374147 RVA: 0x01434C94 File Offset: 0x01432E94
		// (set) Token: 0x0605B584 RID: 374148 RVA: 0x01434CA7 File Offset: 0x01432EA7
		public IGameObject GameObject_C111P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IGameObject>(this.GameObject_C111, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IGameObject>(this.GameObject_C111, base.Collection, value);
			}
		}

		// Token: 0x17020493 RID: 132243
		// (get) Token: 0x0605B585 RID: 374149 RVA: 0x01434CBB File Offset: 0x01432EBB
		// (set) Token: 0x0605B586 RID: 374150 RVA: 0x01434CBE File Offset: 0x01432EBE
		public IPrefab PrefabAsset_C111P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17020494 RID: 132244
		// (get) Token: 0x0605B587 RID: 374151 RVA: 0x01434CC0 File Offset: 0x01432EC0
		// (set) Token: 0x0605B588 RID: 374152 RVA: 0x01434CC3 File Offset: 0x01432EC3
		public IPrefabInstance PrefabInstance_C111P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17020495 RID: 132245
		// (get) Token: 0x0605B589 RID: 374153 RVA: 0x01434CC5 File Offset: 0x01432EC5
		// (set) Token: 0x0605B58A RID: 374154 RVA: 0x01434CD8 File Offset: 0x01432ED8
		public IPrefabMarker PrefabInternal_C111P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IPrefabMarker>(this.PrefabInternal_C111, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IPrefabMarker>(this.PrefabInternal_C111, base.Collection, value);
			}
		}

		// Token: 0x17020496 RID: 132246
		// (get) Token: 0x0605B58B RID: 374155 RVA: 0x01434CEC File Offset: 0x01432EEC

		public override string ClassName
		{

			get
			{
				return "Animation";
			}
		}

		// Token: 0x0605B58C RID: 374156 RVA: 0x01434CF3 File Offset: 0x01432EF3
		public Animation_2017_1_0_GICB2()
			: this(AssetInfo.MakeDummyAssetInfo(111))
		{
		}

		// Token: 0x0605B58D RID: 374157 RVA: 0x01434D02 File Offset: 0x01432F02
		public Animation_2017_1_0_GICB2(AssetInfo info)
			: base(info)
		{
			this.m_Animation = new PPtr_AnimationClip_5_0_0_GICB2();
			this.m_Animations = new AssetList<PPtr_AnimationClip_5_0_0_GICB2>();
		}

		// Token: 0x0605B58E RID: 374158 RVA: 0x01434D21 File Offset: 0x01432F21
		public bool Has_CorrespondingSourceObject_C111()
		{
			return true;
		}

		// Token: 0x0605B58F RID: 374159 RVA: 0x01434D24 File Offset: 0x01432F24
		public bool Has_ExtensionPtr_C111()
		{
			return false;
		}

		// Token: 0x0605B590 RID: 374160 RVA: 0x01434D27 File Offset: 0x01432F27
		public bool Has_PrefabAsset_C111()
		{
			return false;
		}

		// Token: 0x0605B591 RID: 374161 RVA: 0x01434D2A File Offset: 0x01432F2A
		public bool Has_PrefabInstance_C111()
		{
			return false;
		}

		// Token: 0x0605B592 RID: 374162 RVA: 0x01434D2D File Offset: 0x01432F2D
		public bool Has_PrefabInternal_C111()
		{
			return true;
		}

		// Token: 0x0605B593 RID: 374163 RVA: 0x01434D30 File Offset: 0x01432F30
		public bool Has_UserAABB_C111()
		{
			return false;
		}

		// Token: 0x0605B594 RID: 374164 RVA: 0x01434D34 File Offset: 0x01432F34

		public override void ReadRelease(AssetReader reader)
		{
			this.m_GameObject.ReadRelease(reader);
			this.m_Enabled = reader.ReadRelease_ByteAlign();
			this.m_Animation.ReadRelease(reader);
			this.m_Animations.ReadRelease_ArrayAlign_Asset(reader);
			this.m_WrapMode = reader.ReadInt32();
			this.m_PlayAutomatically = reader.ReadBoolean();
			this.m_AnimatePhysics = reader.ReadRelease_BooleanAlign();
			this.m_CullingType = reader.ReadInt32();
		}

		// Token: 0x0605B595 RID: 374165 RVA: 0x01434DA4 File Offset: 0x01432FA4

		public override void ReadEditor(AssetReader reader)
		{
		}

		// Token: 0x0605B596 RID: 374166 RVA: 0x01434E38 File Offset: 0x01433038

		public override void WriteRelease(AssetWriter writer)
		{
			this.m_GameObject.WriteRelease(writer);
			this.m_Enabled.WriteRelease_ByteAlign(writer);
			this.m_Animation.WriteRelease(writer);
			this.m_Animations.WriteRelease_ArrayAlign_Asset(writer);
			this.m_WrapMode.WriteRelease_Int32(writer);
			this.m_PlayAutomatically.WriteRelease_Boolean(writer);
			this.m_AnimatePhysics.WriteRelease_BooleanAlign(writer);
			this.m_CullingType.WriteRelease_Int32(writer);
		}

		// Token: 0x0605B597 RID: 374167 RVA: 0x01434EA8 File Offset: 0x014330A8

		public override void WriteEditor(AssetWriter writer)
		{
		}

		// Token: 0x0605B598 RID: 374168 RVA: 0x01434F3C File Offset: 0x0143313C

		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 3);
			yamlMappingNode.Add(new YamlScalarNode("m_GameObject"), this.m_GameObject.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Enabled"), this.m_Enabled.ExportYamlRelease_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Animation"), this.m_Animation.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Animations"), this.m_Animations.ExportYamlRelease_Array_PPtr_AnimationClip_5_0_0_GICB2(container));
			yamlMappingNode.Add(new YamlScalarNode("m_WrapMode"), this.m_WrapMode.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PlayAutomatically"), this.m_PlayAutomatically.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AnimatePhysics"), this.m_AnimatePhysics.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_CullingType"), this.m_CullingType.ExportYamlRelease_Int32(container));
			return yamlMappingNode;
		}

		// Token: 0x0605B599 RID: 374169 RVA: 0x01435038 File Offset: 0x01433238

		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 3);
			yamlMappingNode.Add(new YamlScalarNode("m_ObjectHideFlags"), this.m_HideFlags.ExportYamlEditor_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabParentObject"), this.m_CorrespondingSourceObject.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabInternal"), this.m_PrefabInternal.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_GameObject"), this.m_GameObject.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Enabled"), this.m_Enabled.ExportYamlEditor_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Animation"), this.m_Animation.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Animations"), this.m_Animations.ExportYamlEditor_Array_PPtr_AnimationClip_5_0_0_GICB2(container));
			yamlMappingNode.Add(new YamlScalarNode("m_WrapMode"), this.m_WrapMode.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PlayAutomatically"), this.m_PlayAutomatically.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AnimatePhysics"), this.m_AnimatePhysics.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_CullingType"), this.m_CullingType.ExportYamlEditor_Int32(container));
			return yamlMappingNode;
		}

		// Token: 0x0605B59A RID: 374170 RVA: 0x01435188 File Offset: 0x01433388
		public override void Reset()
		{
			this.m_AnimatePhysics = false;
			this.m_Animation.Reset();
			this.m_Animations.Clear();
			this.m_CorrespondingSourceObject.Reset();
			this.m_CullingType = 0;
			this.m_Enabled = 0;
			this.m_GameObject.Reset();
			this.m_HideFlags = 0U;
			this.m_PlayAutomatically = false;
			this.m_PrefabInternal.Reset();
			this.m_WrapMode = 0;
		}


		// Token: 0x0605B59C RID: 374172 RVA: 0x01435204 File Offset: 0x01433404

		public void CopyValues(IAnimation_ACL source, PPtrConverter converter)
		{
			this.m_AnimatePhysics = source.AnimatePhysics_C111;
			this.m_Animation.CopyValues(source.Animation_C111, converter);
			CopyValuesHelper.CopyValues__AssetList_PPtr_AnimationClip_5_0_0_GICB2__AccessListBase_IPPtr_AnimationClip(this.m_Animations, source.Animations_C111, converter);
			this.m_CorrespondingSourceObject.CopyValues(source.CorrespondingSourceObject_C111, converter);
			this.m_CullingType = source.CullingType_C111;
			this.m_Enabled = source.Enabled_C111;
			this.m_GameObject.CopyValues(source.GameObject_C111, converter);
			this.m_HideFlags = source.HideFlags_C111;
			this.m_PlayAutomatically = source.PlayAutomatically_C111;
			this.m_PrefabInternal.CopyValues(source.PrefabInternal_C111, converter);
			this.m_WrapMode = source.WrapMode_C111;
		}

		// Token: 0x0605B59D RID: 374173 RVA: 0x014352B3 File Offset: 0x014334B3

		public void CopyValues(IAnimation_ACL source)
		{
			this.CopyValues(source, new PPtrConverter(source, this));
		}

		// Token: 0x0605B59E RID: 374174 RVA: 0x014352C4 File Offset: 0x014334C4
		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			IAnimation_ACL animation = source as IAnimation_ACL;
			if (animation != null)
			{
				this.CopyValues(animation, converter);
				return;
			}
			base.CopyValues(source, converter);
		}

		// Token: 0x0605B59F RID: 374175 RVA: 0x014352EC File Offset: 0x014334EC

		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0605B5A0 RID: 374176 RVA: 0x014352F3 File Offset: 0x014334F3

		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x040368BC RID: 223420

		public PPtr_AnimationClip_5_0_0_GICB2 m_Animation;

		// Token: 0x040368BD RID: 223421

		public AssetList<PPtr_AnimationClip_5_0_0_GICB2> m_Animations;

		// Token: 0x040368BE RID: 223422
		public int m_WrapMode;

		// Token: 0x040368BF RID: 223423
		public bool m_PlayAutomatically;

		// Token: 0x040368C0 RID: 223424
		public bool m_AnimatePhysics;

		// Token: 0x040368C1 RID: 223425
		public int m_CullingType;
	}
}
