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
using AssetRipper.SourceGenerated.Classes.ClassID_134;
using AssetRipper.SourceGenerated.Classes.ClassID_18;
using AssetRipper.SourceGenerated.Classes.ClassID_2;
using AssetRipper.SourceGenerated.Enums;
using AssetRipper.SourceGenerated.Helpers;
using AssetRipper.SourceGenerated.Interfaces;
using AssetRipper.SourceGenerated.MarkerInterfaces;
using AssetRipper.SourceGenerated.Subclasses.BitField;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtensionImpl;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtension;
using AssetRipper.SourceGenerated.Subclasses.PPtr_GameObject;
using AssetRipper.SourceGenerated.Subclasses.PPtr_PhysicMaterial;
using AssetRipper.SourceGenerated.Subclasses.PPtr_PrefabInstance;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Prefab;
using AssetRipper.SourceGenerated.Subclasses.Vector3f;
using AssetRipper.Yaml;
using AssetRipper.SourceGenerated.Classes.ClassID_56;

namespace AssetRipper.Import.GICB2.Collider
{
	// Token: 0x020027D7 RID: 10199


	public abstract class Collider_5_5_0_GICB2 : Component_5_5_0, ICollider, IComponent, IEditorExtension, IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IEditorExtensionMarker, IObject, IObjectMarker, IHasHideFlags, IComponentMarker, IColliderMarker
	{
		// Token: 0x1700A814 RID: 43028
		// (get) Token: 0x0602408B RID: 147595 RVA: 0x005457BE File Offset: 0x005439BE

		public IVector3f Center_C56
		{

			get
			{
				return this.m_Center;
			}
		}

		// Token: 0x1700A815 RID: 43029
		// (get) Token: 0x0602408C RID: 147596 RVA: 0x005457C6 File Offset: 0x005439C6
		public IPPtr_EditorExtension CorrespondingSourceObject_C56
		{
			[return: NotNull]
			get
			{
				return this.m_CorrespondingSourceObject;
			}
		}

		// Token: 0x1700A816 RID: 43030
		// (get) Token: 0x0602408D RID: 147597 RVA: 0x005457CE File Offset: 0x005439CE
		public BitField ExcludeLayers_C56
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700A817 RID: 43031
		// (get) Token: 0x0602408E RID: 147598 RVA: 0x005457D1 File Offset: 0x005439D1
		public PPtr_EditorExtensionImpl ExtensionPtr_C56
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700A818 RID: 43032
		// (get) Token: 0x0602408F RID: 147599 RVA: 0x005457D4 File Offset: 0x005439D4

		public IPPtr_GameObject GameObject_C56
		{

			get
			{
				return this.m_GameObject;
			}
		}

		// Token: 0x1700A819 RID: 43033
		// (get) Token: 0x06024090 RID: 147600 RVA: 0x005457DC File Offset: 0x005439DC
		// (set) Token: 0x06024091 RID: 147601 RVA: 0x005457E4 File Offset: 0x005439E4
		public uint HideFlags_C56
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

		// Token: 0x1700A81A RID: 43034
		// (get) Token: 0x06024092 RID: 147602 RVA: 0x005457ED File Offset: 0x005439ED
		public BitField IncludeLayers_C56
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700A81B RID: 43035
		// (get) Token: 0x06024093 RID: 147603 RVA: 0x005457F0 File Offset: 0x005439F0
		// (set) Token: 0x06024094 RID: 147604 RVA: 0x005457F8 File Offset: 0x005439F8
		public bool IsTrigger_C56
		{
			get
			{
				return this.m_IsTrigger;
			}
			set
			{
				this.m_IsTrigger = value;
			}
		}

		// Token: 0x1700A81C RID: 43036
		// (get) Token: 0x06024095 RID: 147605 RVA: 0x00545801 File Offset: 0x00543A01
		// (set) Token: 0x06024096 RID: 147606 RVA: 0x00545804 File Offset: 0x00543A04
		public int LayerOverridePriority_C56
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700A81D RID: 43037
		// (get) Token: 0x06024097 RID: 147607 RVA: 0x00545806 File Offset: 0x00543A06

		public IPPtr_PhysicMaterial Material_C56
		{

			get
			{
				return this.m_Material;
			}
		}

		// Token: 0x1700A81E RID: 43038
		// (get) Token: 0x06024098 RID: 147608 RVA: 0x0054580E File Offset: 0x00543A0E
		public PPtr_Prefab_2018_3_0 PrefabAsset_C56
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700A81F RID: 43039
		// (get) Token: 0x06024099 RID: 147609 RVA: 0x00545811 File Offset: 0x00543A11
		public PPtr_PrefabInstance PrefabInstance_C56
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700A820 RID: 43040
		// (get) Token: 0x0602409A RID: 147610 RVA: 0x00545814 File Offset: 0x00543A14
		public IPPtr_Prefab PrefabInternal_C56
		{
			[return: NotNull]
			get
			{
				return this.m_PrefabInternal;
			}
		}

		// Token: 0x1700A821 RID: 43041
		// (get) Token: 0x0602409B RID: 147611 RVA: 0x0054581C File Offset: 0x00543A1C
		// (set) Token: 0x0602409C RID: 147612 RVA: 0x0054581F File Offset: 0x00543A1F
		public bool ProvidesContacts_C56
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700A822 RID: 43042
		// (get) Token: 0x0602409D RID: 147613 RVA: 0x00545821 File Offset: 0x00543A21
		// (set) Token: 0x0602409E RID: 147614 RVA: 0x00545829 File Offset: 0x00543A29
		public HideFlags HideFlags_C56E
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

		// Token: 0x1700A823 RID: 43043
		// (get) Token: 0x0602409F RID: 147615 RVA: 0x00545832 File Offset: 0x00543A32
		// (set) Token: 0x060240A0 RID: 147616 RVA: 0x00545845 File Offset: 0x00543A45
		public IEditorExtension CorrespondingSourceObject_C56P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IEditorExtension>(this.CorrespondingSourceObject_C56, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IEditorExtension>(this.CorrespondingSourceObject_C56, base.Collection, value);
			}
		}

		// Token: 0x1700A824 RID: 43044
		// (get) Token: 0x060240A1 RID: 147617 RVA: 0x00545859 File Offset: 0x00543A59
		// (set) Token: 0x060240A2 RID: 147618 RVA: 0x0054585C File Offset: 0x00543A5C
		public IEditorExtensionImpl ExtensionPtr_C56P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700A825 RID: 43045
		// (get) Token: 0x060240A3 RID: 147619 RVA: 0x0054585E File Offset: 0x00543A5E
		// (set) Token: 0x060240A4 RID: 147620 RVA: 0x00545871 File Offset: 0x00543A71
		public IGameObject GameObject_C56P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IGameObject>(this.GameObject_C56, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IGameObject>(this.GameObject_C56, base.Collection, value);
			}
		}

		// Token: 0x1700A826 RID: 43046
		// (get) Token: 0x060240A5 RID: 147621 RVA: 0x00545885 File Offset: 0x00543A85
		// (set) Token: 0x060240A6 RID: 147622 RVA: 0x00545898 File Offset: 0x00543A98
		public IPhysicMaterial Material_C56P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IPhysicMaterial>(this.Material_C56, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IPhysicMaterial>(this.Material_C56, base.Collection, value);
			}
		}

		// Token: 0x1700A827 RID: 43047
		// (get) Token: 0x060240A7 RID: 147623 RVA: 0x005458AC File Offset: 0x00543AAC
		// (set) Token: 0x060240A8 RID: 147624 RVA: 0x005458AF File Offset: 0x00543AAF
		public IPrefab PrefabAsset_C56P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700A828 RID: 43048
		// (get) Token: 0x060240A9 RID: 147625 RVA: 0x005458B1 File Offset: 0x00543AB1
		// (set) Token: 0x060240AA RID: 147626 RVA: 0x005458B4 File Offset: 0x00543AB4
		public IPrefabInstance PrefabInstance_C56P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700A829 RID: 43049
		// (get) Token: 0x060240AB RID: 147627 RVA: 0x005458B6 File Offset: 0x00543AB6
		// (set) Token: 0x060240AC RID: 147628 RVA: 0x005458C9 File Offset: 0x00543AC9
		public IPrefabMarker PrefabInternal_C56P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IPrefabMarker>(this.PrefabInternal_C56, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IPrefabMarker>(this.PrefabInternal_C56, base.Collection, value);
			}
		}

		// Token: 0x1700A82A RID: 43050
		// (get) Token: 0x060240AD RID: 147629 RVA: 0x005458DD File Offset: 0x00543ADD

		public override string ClassName
		{

			get
			{
				return "Collider";
			}
		}

		// Token: 0x060240AE RID: 147630 RVA: 0x005458E4 File Offset: 0x00543AE4
		public Collider_5_5_0_GICB2()
			: this(AssetInfo.MakeDummyAssetInfo(56))
		{
		}

		// Token: 0x060240AF RID: 147631 RVA: 0x005458F3 File Offset: 0x00543AF3
		public Collider_5_5_0_GICB2(AssetInfo info)
			: base(info)
		{
			this.m_Material = new PPtr_PhysicMaterial_5_0_0();
			this.m_Center = new Vector3f_3_5_0();
		}

		// Token: 0x060240B0 RID: 147632 RVA: 0x00545912 File Offset: 0x00543B12
		public bool Has_CorrespondingSourceObject_C56()
		{
			return true;
		}

		// Token: 0x060240B1 RID: 147633 RVA: 0x00545915 File Offset: 0x00543B15
		public bool Has_ExcludeLayers_C56()
		{
			return false;
		}

		// Token: 0x060240B2 RID: 147634 RVA: 0x00545918 File Offset: 0x00543B18
		public bool Has_ExtensionPtr_C56()
		{
			return false;
		}

		// Token: 0x060240B3 RID: 147635 RVA: 0x0054591B File Offset: 0x00543B1B
		public bool Has_IncludeLayers_C56()
		{
			return false;
		}

		// Token: 0x060240B4 RID: 147636 RVA: 0x0054591E File Offset: 0x00543B1E
		public bool Has_LayerOverridePriority_C56()
		{
			return false;
		}

		// Token: 0x060240B5 RID: 147637 RVA: 0x00545921 File Offset: 0x00543B21
		public bool Has_PrefabAsset_C56()
		{
			return false;
		}

		// Token: 0x060240B6 RID: 147638 RVA: 0x00545924 File Offset: 0x00543B24
		public bool Has_PrefabInstance_C56()
		{
			return false;
		}

		// Token: 0x060240B7 RID: 147639 RVA: 0x00545927 File Offset: 0x00543B27
		public bool Has_PrefabInternal_C56()
		{
			return true;
		}

		// Token: 0x060240B8 RID: 147640 RVA: 0x0054592A File Offset: 0x00543B2A
		public bool Has_ProvidesContacts_C56()
		{
			return false;
		}

		// Token: 0x060240B9 RID: 147641 RVA: 0x0054592D File Offset: 0x00543B2D

		public override void ReadRelease(AssetReader reader)
		{
			this.m_GameObject.ReadRelease(reader);
			this.m_Material.ReadRelease(reader);
			this.m_IsTrigger = reader.ReadBoolean();
			//this.m_Center.ReadRelease(reader); // ???? 
			this.m_Enabled = reader.ReadRelease_BooleanAlign();

			// GICB2
			this.WalkRunSurfaceType = reader.ReadInt32();
			this.ClimbSurfaceType = reader.ReadRelease_Int32Align();
			this.IsSceneQuery = reader.ReadRelease_BooleanAlign();
			this.IsLocalPoseConvertibility = reader.ReadRelease_BooleanAlign();
		}

		// Token: 0x060240BA RID: 147642 RVA: 0x00545960 File Offset: 0x00543B60

		public override void ReadEditor(AssetReader reader)
		{
		}

		// Token: 0x060240BB RID: 147643 RVA: 0x005459C1 File Offset: 0x00543BC1

		public override void WriteRelease(AssetWriter writer)
		{
			this.m_GameObject.WriteRelease(writer);
			this.m_Material.WriteRelease(writer);
			this.m_IsTrigger.WriteRelease_Boolean(writer);
			this.m_Center.WriteRelease(writer);
		}

		// Token: 0x060240BC RID: 147644 RVA: 0x005459F4 File Offset: 0x00543BF4

		public override void WriteEditor(AssetWriter writer)
		{
		}

		// Token: 0x060240BD RID: 147645 RVA: 0x00545A58 File Offset: 0x00543C58

		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 1);
			yamlMappingNode.Add(new YamlScalarNode("m_GameObject"), this.m_GameObject.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Material"), this.m_Material.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_IsTrigger"), this.m_IsTrigger.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Center"), this.m_Center.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x060240BE RID: 147646 RVA: 0x00545AE4 File Offset: 0x00543CE4

		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 1);
			yamlMappingNode.Add(new YamlScalarNode("m_ObjectHideFlags"), this.m_HideFlags.ExportYamlEditor_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabParentObject"), this.m_CorrespondingSourceObject.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabInternal"), this.m_PrefabInternal.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_GameObject"), this.m_GameObject.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Material"), this.m_Material.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_IsTrigger"), this.m_IsTrigger.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Center"), this.m_Center.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x060240BF RID: 147647 RVA: 0x00545BC4 File Offset: 0x00543DC4
		public override void Reset()
		{
			this.m_Center.Reset();
			this.m_CorrespondingSourceObject.Reset();
			this.m_GameObject.Reset();
			this.m_HideFlags = 0U;
			this.m_IsTrigger = false;
			this.m_Material.Reset();
			this.m_PrefabInternal.Reset();
		}

		// Token: 0x060240C0 RID: 147648 RVA: 0x00545C16 File Offset: 0x00543E16

		// Token: 0x060240C1 RID: 147649 RVA: 0x00545C24 File Offset: 0x00543E24

		public void CopyValues(ICollider source, PPtrConverter converter)
		{
			this.m_Center.CopyValues(source.Center_C56);
			this.m_CorrespondingSourceObject.CopyValues(source.CorrespondingSourceObject_C56, converter);
			this.m_GameObject.CopyValues(source.GameObject_C56, converter);
			this.m_HideFlags = source.HideFlags_C56;
			this.m_IsTrigger = source.IsTrigger_C56;
			this.m_Material.CopyValues(source.Material_C56, converter);
			this.m_PrefabInternal.CopyValues(source.PrefabInternal_C56, converter);
		}

		// Token: 0x060240C2 RID: 147650 RVA: 0x00545CA2 File Offset: 0x00543EA2

		public void CopyValues(ICollider source)
		{
			this.CopyValues(source, new PPtrConverter(source, this));
		}

		// Token: 0x060240C3 RID: 147651 RVA: 0x00545CB4 File Offset: 0x00543EB4
		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			ICollider collider = source as ICollider;
			if (collider != null)
			{
				this.CopyValues(collider, converter);
				return;
			}
			base.CopyValues(source, converter);
		}

		// Token: 0x060240C4 RID: 147652 RVA: 0x00545CDC File Offset: 0x00543EDC

		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060240C5 RID: 147653 RVA: 0x00545CE3 File Offset: 0x00543EE3

		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04011A16 RID: 72214

		public PPtr_PhysicMaterial_5_0_0 m_Material;

		// Token: 0x04011A17 RID: 72215
		public bool m_IsTrigger;

		// Token: 0x04011A18 RID: 72216

		public Vector3f_3_5_0 m_Center;

		public int WalkRunSurfaceType { get; set; }
		public int ClimbSurfaceType { get; set; }
		public bool IsSceneQuery { get; set; }
		public bool IsLocalPoseConvertibility { get; set; }

		public bool m_Enabled { get; set; }
	}
}
