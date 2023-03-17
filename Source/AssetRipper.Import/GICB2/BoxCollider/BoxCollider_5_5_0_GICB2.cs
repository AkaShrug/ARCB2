using System.Diagnostics.CodeAnalysis;
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
using AssetRipper.SourceGenerated.Classes.ClassID_56;
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
using AssetRipper.SourceGenerated.Classes.ClassID_65;
using AssetRipper.Import.GICB2.Collider;

namespace AssetRipper.Import.GICB2.BoxCollider
{
	public sealed class BoxCollider_5_5_0_GICB2 : Collider_5_5_0_GICB2, IBoxCollider, IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IBoxColliderMarker, IHasEnabled, ICollider, IColliderMarker, IComponent, IComponentMarker, IEditorExtension, IEditorExtensionMarker, IObject, IObjectMarker, IHasHideFlags
	{
		// Token: 0x17009AFA RID: 39674
		// (get) Token: 0x060220F1 RID: 139505 RVA: 0x0050D592 File Offset: 0x0050B792

		public IVector3f Center_C65
		{
			get
			{
				return m_Center;
			}
		}

		// Token: 0x17009AFB RID: 39675
		// (get) Token: 0x060220F2 RID: 139506 RVA: 0x0050D59A File Offset: 0x0050B79A
		public IPPtr_EditorExtension CorrespondingSourceObject_C65
		{
			[return: NotNull]
			get
			{
				return m_CorrespondingSourceObject;
			}
		}

		// Token: 0x17009AFC RID: 39676
		// (get) Token: 0x060220F3 RID: 139507 RVA: 0x0050D5A2 File Offset: 0x0050B7A2
		// (set) Token: 0x060220F4 RID: 139508 RVA: 0x0050D5AA File Offset: 0x0050B7AA
		public bool Enabled_C65
		{
			get
			{
				return m_Enabled;
			}
			set
			{
				m_Enabled = value;
			}
		}

		// Token: 0x17009AFD RID: 39677
		// (get) Token: 0x060220F5 RID: 139509 RVA: 0x0050D5B3 File Offset: 0x0050B7B3
		public BitField ExcludeLayers_C65
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17009AFE RID: 39678
		// (get) Token: 0x060220F6 RID: 139510 RVA: 0x0050D5B6 File Offset: 0x0050B7B6
		public PPtr_EditorExtensionImpl ExtensionPtr_C65
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17009AFF RID: 39679
		// (get) Token: 0x060220F7 RID: 139511 RVA: 0x0050D5B9 File Offset: 0x0050B7B9

		public IPPtr_GameObject GameObject_C65
		{

			get
			{
				return m_GameObject;
			}
		}

		// Token: 0x17009B00 RID: 39680
		// (get) Token: 0x060220F8 RID: 139512 RVA: 0x0050D5C1 File Offset: 0x0050B7C1
		// (set) Token: 0x060220F9 RID: 139513 RVA: 0x0050D5C9 File Offset: 0x0050B7C9
		public uint HideFlags_C65
		{
			get
			{
				return m_HideFlags;
			}
			set
			{
				m_HideFlags = value;
			}
		}

		// Token: 0x17009B01 RID: 39681
		// (get) Token: 0x060220FA RID: 139514 RVA: 0x0050D5D2 File Offset: 0x0050B7D2
		public BitField IncludeLayers_C65
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17009B02 RID: 39682
		// (get) Token: 0x060220FB RID: 139515 RVA: 0x0050D5D5 File Offset: 0x0050B7D5
		// (set) Token: 0x060220FC RID: 139516 RVA: 0x0050D5DD File Offset: 0x0050B7DD
		public bool IsTrigger_C65
		{
			get
			{
				return m_IsTrigger;
			}
			set
			{
				m_IsTrigger = value;
			}
		}

		// Token: 0x17009B03 RID: 39683
		// (get) Token: 0x060220FD RID: 139517 RVA: 0x0050D5E6 File Offset: 0x0050B7E6
		// (set) Token: 0x060220FE RID: 139518 RVA: 0x0050D5E9 File Offset: 0x0050B7E9
		public int LayerOverridePriority_C65
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17009B04 RID: 39684
		// (get) Token: 0x060220FF RID: 139519 RVA: 0x0050D5EB File Offset: 0x0050B7EB

		public IPPtr_PhysicMaterial Material_C65
		{

			get
			{
				return m_Material;
			}
		}

		// Token: 0x17009B05 RID: 39685
		// (get) Token: 0x06022100 RID: 139520 RVA: 0x0050D5F3 File Offset: 0x0050B7F3
		public PPtr_Prefab_2018_3_0 PrefabAsset_C65
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17009B06 RID: 39686
		// (get) Token: 0x06022101 RID: 139521 RVA: 0x0050D5F6 File Offset: 0x0050B7F6
		public PPtr_PrefabInstance PrefabInstance_C65
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17009B07 RID: 39687
		// (get) Token: 0x06022102 RID: 139522 RVA: 0x0050D5F9 File Offset: 0x0050B7F9
		public IPPtr_Prefab PrefabInternal_C65
		{
			[return: NotNull]
			get
			{
				return m_PrefabInternal;
			}
		}

		// Token: 0x17009B08 RID: 39688
		// (get) Token: 0x06022103 RID: 139523 RVA: 0x0050D601 File Offset: 0x0050B801
		// (set) Token: 0x06022104 RID: 139524 RVA: 0x0050D604 File Offset: 0x0050B804
		public bool ProvidesContacts_C65
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17009B09 RID: 39689
		// (get) Token: 0x06022105 RID: 139525 RVA: 0x0050D606 File Offset: 0x0050B806

		public IVector3f Size_C65
		{

			get
			{
				return m_Size;
			}
		}

		// Token: 0x17009B0A RID: 39690
		// (get) Token: 0x06022106 RID: 139526 RVA: 0x0050D60E File Offset: 0x0050B80E
		// (set) Token: 0x06022107 RID: 139527 RVA: 0x0050D616 File Offset: 0x0050B816
		public HideFlags HideFlags_C65E
		{
			get
			{
				return (HideFlags)m_HideFlags;
			}
			set
			{
				m_HideFlags = (uint)value;
			}
		}

		// Token: 0x17009B0B RID: 39691
		// (get) Token: 0x06022108 RID: 139528 RVA: 0x0050D61F File Offset: 0x0050B81F
		// (set) Token: 0x06022109 RID: 139529 RVA: 0x0050D632 File Offset: 0x0050B832
		public IEditorExtension CorrespondingSourceObject_C65P
		{
			get
			{
				return CorrespondingSourceObject_C65.TryGetAsset(Collection);
			}
			set
			{
				CorrespondingSourceObject_C65.SetAsset(Collection, value);
			}
		}

		// Token: 0x17009B0C RID: 39692
		// (get) Token: 0x0602210A RID: 139530 RVA: 0x0050D646 File Offset: 0x0050B846
		// (set) Token: 0x0602210B RID: 139531 RVA: 0x0050D649 File Offset: 0x0050B849
		public IEditorExtensionImpl ExtensionPtr_C65P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17009B0D RID: 39693
		// (get) Token: 0x0602210C RID: 139532 RVA: 0x0050D64B File Offset: 0x0050B84B
		// (set) Token: 0x0602210D RID: 139533 RVA: 0x0050D65E File Offset: 0x0050B85E
		public IGameObject GameObject_C65P
		{
			get
			{
				return GameObject_C65.TryGetAsset(Collection);
			}
			set
			{
				GameObject_C65.SetAsset(Collection, value);
			}
		}

		// Token: 0x17009B0E RID: 39694
		// (get) Token: 0x0602210E RID: 139534 RVA: 0x0050D672 File Offset: 0x0050B872
		// (set) Token: 0x0602210F RID: 139535 RVA: 0x0050D685 File Offset: 0x0050B885
		public IPhysicMaterial Material_C65P
		{
			get
			{
				return Material_C65.TryGetAsset(Collection);
			}
			set
			{
				Material_C65.SetAsset(Collection, value);
			}
		}

		// Token: 0x17009B0F RID: 39695
		// (get) Token: 0x06022110 RID: 139536 RVA: 0x0050D699 File Offset: 0x0050B899
		// (set) Token: 0x06022111 RID: 139537 RVA: 0x0050D69C File Offset: 0x0050B89C
		public IPrefab PrefabAsset_C65P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17009B10 RID: 39696
		// (get) Token: 0x06022112 RID: 139538 RVA: 0x0050D69E File Offset: 0x0050B89E
		// (set) Token: 0x06022113 RID: 139539 RVA: 0x0050D6A1 File Offset: 0x0050B8A1
		public IPrefabInstance PrefabInstance_C65P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17009B11 RID: 39697
		// (get) Token: 0x06022114 RID: 139540 RVA: 0x0050D6A3 File Offset: 0x0050B8A3
		// (set) Token: 0x06022115 RID: 139541 RVA: 0x0050D6B6 File Offset: 0x0050B8B6
		public IPrefabMarker PrefabInternal_C65P
		{
			get
			{
				return PrefabInternal_C65.TryGetAsset(Collection);
			}
			set
			{
				PrefabInternal_C65.SetAsset(Collection, value);
			}
		}

		// Token: 0x17009B12 RID: 39698
		// (get) Token: 0x06022116 RID: 139542 RVA: 0x0050D6CA File Offset: 0x0050B8CA

		public override string ClassName
		{

			get
			{
				return "BoxCollider";
			}
		}

		// Token: 0x17009B13 RID: 39699
		// (get) Token: 0x06022117 RID: 139543 RVA: 0x0050D6D1 File Offset: 0x0050B8D1
		// (set) Token: 0x06022118 RID: 139544 RVA: 0x0050D6D9 File Offset: 0x0050B8D9
		public bool Enabled
		{
			get
			{
				return m_Enabled;
			}
			set
			{
				m_Enabled = value;
			}
		}

		// Token: 0x06022119 RID: 139545 RVA: 0x0050D6E2 File Offset: 0x0050B8E2
		public BoxCollider_5_5_0_GICB2()
			: this(AssetInfo.MakeDummyAssetInfo(65))
		{
		}

		// Token: 0x0602211A RID: 139546 RVA: 0x0050D6F1 File Offset: 0x0050B8F1
		public BoxCollider_5_5_0_GICB2(AssetInfo info)
			: base(info)
		{
			m_Size = new Vector3f_3_5_0();
			m_LocalAngle = new Vector3f_3_5_0();
		}

		// Token: 0x0602211B RID: 139547 RVA: 0x0050D705 File Offset: 0x0050B905
		public bool Has_CorrespondingSourceObject_C65()
		{
			return true;
		}

		// Token: 0x0602211C RID: 139548 RVA: 0x0050D708 File Offset: 0x0050B908
		public bool Has_ExcludeLayers_C65()
		{
			return false;
		}

		// Token: 0x0602211D RID: 139549 RVA: 0x0050D70B File Offset: 0x0050B90B
		public bool Has_ExtensionPtr_C65()
		{
			return false;
		}

		// Token: 0x0602211E RID: 139550 RVA: 0x0050D70E File Offset: 0x0050B90E
		public bool Has_IncludeLayers_C65()
		{
			return false;
		}

		// Token: 0x0602211F RID: 139551 RVA: 0x0050D711 File Offset: 0x0050B911
		public bool Has_LayerOverridePriority_C65()
		{
			return false;
		}

		// Token: 0x06022120 RID: 139552 RVA: 0x0050D714 File Offset: 0x0050B914
		public bool Has_PrefabAsset_C65()
		{
			return false;
		}

		// Token: 0x06022121 RID: 139553 RVA: 0x0050D717 File Offset: 0x0050B917
		public bool Has_PrefabInstance_C65()
		{
			return false;
		}

		// Token: 0x06022122 RID: 139554 RVA: 0x0050D71A File Offset: 0x0050B91A
		public bool Has_PrefabInternal_C65()
		{
			return true;
		}

		// Token: 0x06022123 RID: 139555 RVA: 0x0050D71D File Offset: 0x0050B91D
		public bool Has_ProvidesContacts_C65()
		{
			return false;
		}

		// Token: 0x06022124 RID: 139556 RVA: 0x0050D720 File Offset: 0x0050B920

		public override void ReadRelease(AssetReader reader)
		{
			m_GameObject.ReadRelease(reader);
			m_Material.ReadRelease(reader);
			m_IsTrigger = reader.ReadBoolean();
			m_Enabled = reader.ReadRelease_BooleanAlign();
			var WalkRunSurfaceType = reader.ReadInt32();
			var ClimbSurfaceType = reader.ReadInt32();
			reader.AlignStream();
			var IsSceneQuery = reader.ReadBoolean();
			reader.AlignStream();
			var IsLocalPoseConvertibility = reader.ReadBoolean();
			reader.AlignStream();
			m_Size.ReadRelease(reader);
			m_Center.ReadRelease(reader);
			m_LocalAngle.ReadRelease(reader);
		}

		// Token: 0x06022125 RID: 139557 RVA: 0x0050D778 File Offset: 0x0050B978

		public override void ReadEditor(AssetReader reader)
		{
		}

		// Token: 0x06022126 RID: 139558 RVA: 0x0050D7F4 File Offset: 0x0050B9F4

		public override void WriteRelease(AssetWriter writer)
		{
			m_GameObject.WriteRelease(writer);
			m_Material.WriteRelease(writer);
			m_IsTrigger.WriteRelease_Boolean(writer);
			m_Enabled.WriteRelease_BooleanAlign(writer);
			m_Size.WriteRelease(writer);
			m_Center.WriteRelease(writer);
			m_LocalAngle.WriteRelease(writer);
		}

		// Token: 0x06022127 RID: 139559 RVA: 0x0050D84C File Offset: 0x0050BA4C

		public override void WriteEditor(AssetWriter writer)
		{
		}

		// Token: 0x06022128 RID: 139560 RVA: 0x0050D8C8 File Offset: 0x0050BAC8

		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			yamlMappingNode.AddSerializedVersion(2);
			yamlMappingNode.Add(new YamlScalarNode("m_GameObject"), m_GameObject.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Material"), m_Material.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_IsTrigger"), m_IsTrigger.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Enabled"), m_Enabled.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Size"), m_Size.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Center"), m_Center.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06022129 RID: 139561 RVA: 0x0050D98C File Offset: 0x0050BB8C
		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 2);
			yamlMappingNode.Add(new YamlScalarNode("m_ObjectHideFlags"), this.m_HideFlags.ExportYamlEditor_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabParentObject"), this.m_CorrespondingSourceObject.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabInternal"), this.m_PrefabInternal.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_GameObject"), this.m_GameObject.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Material"), this.m_Material.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_IsTrigger"), this.m_IsTrigger.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Enabled"), this.m_Enabled.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Size"), this.m_Size.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Center"), this.m_Center.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0602212A RID: 139562 RVA: 0x0050DAA4 File Offset: 0x0050BCA4
		public override void Reset()
		{
			m_Center.Reset();
			m_CorrespondingSourceObject.Reset();
			m_Enabled = false;
			m_GameObject.Reset();
			m_HideFlags = 0U;
			m_IsTrigger = false;
			m_Material.Reset();
			m_PrefabInternal.Reset();
			m_Size.Reset();
		}

		// Token: 0x0602212B RID: 139563 RVA: 0x0050DB08 File Offset: 0x0050BD08
		//public override IEnumerable<ValueTuple<FieldName, PPtr<IUnityObjectBase>>> FetchDependencies(FieldName parent)
		//{
		//	return Enumerable.Empty<ValueTuple<FieldName, PPtr<IUnityObjectBase>>>().Append_BoxCollider_5_5_0(parent, this);
		//}

		// Token: 0x0602212C RID: 139564 RVA: 0x0050DB18 File Offset: 0x0050BD18

		public void CopyValues(IBoxCollider source, PPtrConverter converter)
		{
			m_Center.CopyValues(source.Center_C65);
			m_CorrespondingSourceObject.CopyValues(source.CorrespondingSourceObject_C65, converter);
			m_Enabled = source.Enabled_C65;
			m_GameObject.CopyValues(source.GameObject_C65, converter);
			m_HideFlags = source.HideFlags_C65;
			m_IsTrigger = source.IsTrigger_C65;
			m_Material.CopyValues(source.Material_C65, converter);
			m_PrefabInternal.CopyValues(source.PrefabInternal_C65, converter);
			m_Size.CopyValues(source.Size_C65);
		}

		// Token: 0x0602212D RID: 139565 RVA: 0x0050DBB3 File Offset: 0x0050BDB3

		public void CopyValues(IBoxCollider source)
		{
			CopyValues(source, new PPtrConverter(source, this));
		}

		// Token: 0x0602212E RID: 139566 RVA: 0x0050DBC4 File Offset: 0x0050BDC4
		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			IBoxCollider boxCollider = source as IBoxCollider;
			if (boxCollider != null)
			{
				CopyValues(boxCollider, converter);
				return;
			}
			base.CopyValues(source, converter);
		}

		// Token: 0x0602212F RID: 139567 RVA: 0x0050DBEC File Offset: 0x0050BDEC

		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06022130 RID: 139568 RVA: 0x0050DBF3 File Offset: 0x0050BDF3

		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04011884 RID: 71812
		public bool m_IsTrigger;

		// Token: 0x04011885 RID: 71813
		public bool m_Enabled;

		// Token: 0x04011886 RID: 71814

		public Vector3f_3_5_0 m_Size;

		public Vector3f_3_5_0 m_LocalAngle;
	}
}

