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
using AssetRipper.SourceGenerated.Classes.ClassID_136;
using AssetRipper.Import.GICB2.Collider;

namespace AssetRipper.Import.GICB2.CapsuleCollider
{
	// Token: 0x0200313F RID: 12607


	public sealed class CapsuleCollider_5_5_0_GICB2 : Collider_5_5_0_GICB2, ICapsuleCollider, IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, ICapsuleColliderMarker, IHasEnabled, ICollider, IColliderMarker, IComponent, IComponentMarker, IEditorExtension, IEditorExtensionMarker, IObject, IObjectMarker, IHasHideFlags
	{
		// Token: 0x1701C4AD RID: 115885
		// (get) Token: 0x0605110B RID: 332043 RVA: 0x00A44E5A File Offset: 0x00A4305A

		public IVector3f Center_C136
		{

			get
			{
				return this.m_Center;
			}
		}

		// Token: 0x1701C4AE RID: 115886
		// (get) Token: 0x0605110C RID: 332044 RVA: 0x00A44E62 File Offset: 0x00A43062
		public IPPtr_EditorExtension CorrespondingSourceObject_C136
		{

			get
			{
				return this.m_CorrespondingSourceObject;
			}
		}

		// Token: 0x1701C4AF RID: 115887
		// (get) Token: 0x0605110D RID: 332045 RVA: 0x00A44E6A File Offset: 0x00A4306A
		// (set) Token: 0x0605110E RID: 332046 RVA: 0x00A44E72 File Offset: 0x00A43072
		public int Direction_C136
		{
			get
			{
				return this.m_Direction;
			}
			set
			{
				this.m_Direction = value;
			}
		}

		// Token: 0x1701C4B0 RID: 115888
		// (get) Token: 0x0605110F RID: 332047 RVA: 0x00A44E7B File Offset: 0x00A4307B
		// (set) Token: 0x06051110 RID: 332048 RVA: 0x00A44E83 File Offset: 0x00A43083
		public bool Enabled_C136
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

		// Token: 0x1701C4B1 RID: 115889
		// (get) Token: 0x06051111 RID: 332049 RVA: 0x00A44E8C File Offset: 0x00A4308C
		public BitField ExcludeLayers_C136
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1701C4B2 RID: 115890
		// (get) Token: 0x06051112 RID: 332050 RVA: 0x00A44E8F File Offset: 0x00A4308F
		public PPtr_EditorExtensionImpl ExtensionPtr_C136
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1701C4B3 RID: 115891
		// (get) Token: 0x06051113 RID: 332051 RVA: 0x00A44E92 File Offset: 0x00A43092

		public IPPtr_GameObject GameObject_C136
		{

			get
			{
				return this.m_GameObject;
			}
		}

		// Token: 0x1701C4B4 RID: 115892
		// (get) Token: 0x06051114 RID: 332052 RVA: 0x00A44E9A File Offset: 0x00A4309A
		// (set) Token: 0x06051115 RID: 332053 RVA: 0x00A44EA2 File Offset: 0x00A430A2
		public float Height_C136
		{
			get
			{
				return this.m_Height;
			}
			set
			{
				this.m_Height = value;
			}
		}

		// Token: 0x1701C4B5 RID: 115893
		// (get) Token: 0x06051116 RID: 332054 RVA: 0x00A44EAB File Offset: 0x00A430AB
		// (set) Token: 0x06051117 RID: 332055 RVA: 0x00A44EB3 File Offset: 0x00A430B3
		public uint HideFlags_C136
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

		// Token: 0x1701C4B6 RID: 115894
		// (get) Token: 0x06051118 RID: 332056 RVA: 0x00A44EBC File Offset: 0x00A430BC
		public BitField IncludeLayers_C136
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1701C4B7 RID: 115895
		// (get) Token: 0x06051119 RID: 332057 RVA: 0x00A44EBF File Offset: 0x00A430BF
		// (set) Token: 0x0605111A RID: 332058 RVA: 0x00A44EC7 File Offset: 0x00A430C7
		public bool IsTrigger_C136
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

		// Token: 0x1701C4B8 RID: 115896
		// (get) Token: 0x0605111B RID: 332059 RVA: 0x00A44ED0 File Offset: 0x00A430D0
		// (set) Token: 0x0605111C RID: 332060 RVA: 0x00A44ED3 File Offset: 0x00A430D3
		public int LayerOverridePriority_C136
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1701C4B9 RID: 115897
		// (get) Token: 0x0605111D RID: 332061 RVA: 0x00A44ED5 File Offset: 0x00A430D5

		public IPPtr_PhysicMaterial Material_C136
		{

			get
			{
				return this.m_Material;
			}
		}

		// Token: 0x1701C4BA RID: 115898
		// (get) Token: 0x0605111E RID: 332062 RVA: 0x00A44EDD File Offset: 0x00A430DD
		public PPtr_Prefab_2018_3_0 PrefabAsset_C136
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1701C4BB RID: 115899
		// (get) Token: 0x0605111F RID: 332063 RVA: 0x00A44EE0 File Offset: 0x00A430E0
		public PPtr_PrefabInstance PrefabInstance_C136
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1701C4BC RID: 115900
		// (get) Token: 0x06051120 RID: 332064 RVA: 0x00A44EE3 File Offset: 0x00A430E3
		public IPPtr_Prefab PrefabInternal_C136
		{

			get
			{
				return this.m_PrefabInternal;
			}
		}

		// Token: 0x1701C4BD RID: 115901
		// (get) Token: 0x06051121 RID: 332065 RVA: 0x00A44EEB File Offset: 0x00A430EB
		// (set) Token: 0x06051122 RID: 332066 RVA: 0x00A44EEE File Offset: 0x00A430EE
		public bool ProvidesContacts_C136
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1701C4BE RID: 115902
		// (get) Token: 0x06051123 RID: 332067 RVA: 0x00A44EF0 File Offset: 0x00A430F0
		// (set) Token: 0x06051124 RID: 332068 RVA: 0x00A44EF8 File Offset: 0x00A430F8
		public float Radius_C136
		{
			get
			{
				return this.m_Radius;
			}
			set
			{
				this.m_Radius = value;
			}
		}

		// Token: 0x1701C4BF RID: 115903
		// (get) Token: 0x06051125 RID: 332069 RVA: 0x00A44F01 File Offset: 0x00A43101
		// (set) Token: 0x06051126 RID: 332070 RVA: 0x00A44F09 File Offset: 0x00A43109
		public HideFlags HideFlags_C136E
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

		// Token: 0x1701C4C0 RID: 115904
		// (get) Token: 0x06051127 RID: 332071 RVA: 0x00A44F12 File Offset: 0x00A43112
		// (set) Token: 0x06051128 RID: 332072 RVA: 0x00A44F25 File Offset: 0x00A43125
		public IEditorExtension CorrespondingSourceObject_C136P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IEditorExtension>(this.CorrespondingSourceObject_C136, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IEditorExtension>(this.CorrespondingSourceObject_C136, base.Collection, value);
			}
		}

		// Token: 0x1701C4C1 RID: 115905
		// (get) Token: 0x06051129 RID: 332073 RVA: 0x00A44F39 File Offset: 0x00A43139
		// (set) Token: 0x0605112A RID: 332074 RVA: 0x00A44F3C File Offset: 0x00A4313C
		public IEditorExtensionImpl ExtensionPtr_C136P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1701C4C2 RID: 115906
		// (get) Token: 0x0605112B RID: 332075 RVA: 0x00A44F3E File Offset: 0x00A4313E
		// (set) Token: 0x0605112C RID: 332076 RVA: 0x00A44F51 File Offset: 0x00A43151
		public IGameObject GameObject_C136P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IGameObject>(this.GameObject_C136, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IGameObject>(this.GameObject_C136, base.Collection, value);
			}
		}

		// Token: 0x1701C4C3 RID: 115907
		// (get) Token: 0x0605112D RID: 332077 RVA: 0x00A44F65 File Offset: 0x00A43165
		// (set) Token: 0x0605112E RID: 332078 RVA: 0x00A44F78 File Offset: 0x00A43178
		public IPhysicMaterial Material_C136P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IPhysicMaterial>(this.Material_C136, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IPhysicMaterial>(this.Material_C136, base.Collection, value);
			}
		}

		// Token: 0x1701C4C4 RID: 115908
		// (get) Token: 0x0605112F RID: 332079 RVA: 0x00A44F8C File Offset: 0x00A4318C
		// (set) Token: 0x06051130 RID: 332080 RVA: 0x00A44F8F File Offset: 0x00A4318F
		public IPrefab PrefabAsset_C136P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1701C4C5 RID: 115909
		// (get) Token: 0x06051131 RID: 332081 RVA: 0x00A44F91 File Offset: 0x00A43191
		// (set) Token: 0x06051132 RID: 332082 RVA: 0x00A44F94 File Offset: 0x00A43194
		public IPrefabInstance PrefabInstance_C136P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1701C4C6 RID: 115910
		// (get) Token: 0x06051133 RID: 332083 RVA: 0x00A44F96 File Offset: 0x00A43196
		// (set) Token: 0x06051134 RID: 332084 RVA: 0x00A44FA9 File Offset: 0x00A431A9
		public IPrefabMarker PrefabInternal_C136P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IPrefabMarker>(this.PrefabInternal_C136, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IPrefabMarker>(this.PrefabInternal_C136, base.Collection, value);
			}
		}

		// Token: 0x1701C4C7 RID: 115911
		// (get) Token: 0x06051135 RID: 332085 RVA: 0x00A44FBD File Offset: 0x00A431BD

		public override string ClassName
		{

			get
			{
				return "CapsuleCollider";
			}
		}

		// Token: 0x1701C4C8 RID: 115912
		// (get) Token: 0x06051136 RID: 332086 RVA: 0x00A44FC4 File Offset: 0x00A431C4
		// (set) Token: 0x06051137 RID: 332087 RVA: 0x00A44FCC File Offset: 0x00A431CC
		public bool Enabled
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

		// Token: 0x06051138 RID: 332088 RVA: 0x00A44FD5 File Offset: 0x00A431D5
		public CapsuleCollider_5_5_0_GICB2()
			: this(AssetInfo.MakeDummyAssetInfo(136))
		{
		}

		// Token: 0x06051139 RID: 332089 RVA: 0x00A44FE7 File Offset: 0x00A431E7
		public CapsuleCollider_5_5_0_GICB2(AssetInfo info)
			: base(info)
		{
			m_LocalAngle = new Vector3f_3_5_0();
		}

		// Token: 0x0605113A RID: 332090 RVA: 0x00A44FF0 File Offset: 0x00A431F0
		public bool Has_CorrespondingSourceObject_C136()
		{
			return true;
		}

		// Token: 0x0605113B RID: 332091 RVA: 0x00A44FF3 File Offset: 0x00A431F3
		public bool Has_ExcludeLayers_C136()
		{
			return false;
		}

		// Token: 0x0605113C RID: 332092 RVA: 0x00A44FF6 File Offset: 0x00A431F6
		public bool Has_ExtensionPtr_C136()
		{
			return false;
		}

		// Token: 0x0605113D RID: 332093 RVA: 0x00A44FF9 File Offset: 0x00A431F9
		public bool Has_IncludeLayers_C136()
		{
			return false;
		}

		// Token: 0x0605113E RID: 332094 RVA: 0x00A44FFC File Offset: 0x00A431FC
		public bool Has_LayerOverridePriority_C136()
		{
			return false;
		}

		// Token: 0x0605113F RID: 332095 RVA: 0x00A44FFF File Offset: 0x00A431FF
		public bool Has_PrefabAsset_C136()
		{
			return false;
		}

		// Token: 0x06051140 RID: 332096 RVA: 0x00A45002 File Offset: 0x00A43202
		public bool Has_PrefabInstance_C136()
		{
			return false;
		}

		// Token: 0x06051141 RID: 332097 RVA: 0x00A45005 File Offset: 0x00A43205
		public bool Has_PrefabInternal_C136()
		{
			return true;
		}

		// Token: 0x06051142 RID: 332098 RVA: 0x00A45008 File Offset: 0x00A43208
		public bool Has_ProvidesContacts_C136()
		{
			return false;
		}

		// Token: 0x06051143 RID: 332099 RVA: 0x00A4500C File Offset: 0x00A4320C

		public override void ReadRelease(AssetReader reader)
		{
			this.m_GameObject.ReadRelease(reader);
			this.m_Material.ReadRelease(reader);
			this.m_IsTrigger = reader.ReadBoolean();
			this.m_Enabled = reader.ReadRelease_BooleanAlign();

			// GICB2
			var WalkRunSurfaceType = reader.ReadInt32();
			var ClimbSurfaceType = reader.ReadRelease_Int32Align();
			var IsSceneQuery = reader.ReadRelease_BooleanAlign();
			var IsLocalPoseConvertibility = reader.ReadRelease_BooleanAlign();

			this.m_Radius = reader.ReadSingle();
			this.m_Height = reader.ReadSingle();
			this.m_Direction = reader.ReadInt32();
			this.m_Center.ReadRelease(reader);
			this.m_LocalAngle.ReadRelease(reader);
		}

		// Token: 0x06051144 RID: 332100 RVA: 0x00A4507C File Offset: 0x00A4327C

		public override void ReadEditor(AssetReader reader)
		{
		}

		// Token: 0x06051145 RID: 332101 RVA: 0x00A45110 File Offset: 0x00A43310

		public override void WriteRelease(AssetWriter writer)
		{
			this.m_GameObject.WriteRelease(writer);
			this.m_Material.WriteRelease(writer);
			this.m_IsTrigger.WriteRelease_Boolean(writer);
			this.m_Enabled.WriteRelease_BooleanAlign(writer);
			this.m_Radius.WriteRelease_Single(writer);
			this.m_Height.WriteRelease_Single(writer);
			this.m_Direction.WriteRelease_Int32(writer);
			this.m_Center.WriteRelease(writer);
			this.m_LocalAngle.WriteRelease(writer);
		}

		// Token: 0x06051146 RID: 332102 RVA: 0x00A45180 File Offset: 0x00A43380

		public override void WriteEditor(AssetWriter writer)
		{
		}

		// Token: 0x06051147 RID: 332103 RVA: 0x00A45214 File Offset: 0x00A43414

		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 1);
			yamlMappingNode.Add(new YamlScalarNode("m_GameObject"), this.m_GameObject.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Material"), this.m_Material.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_IsTrigger"), this.m_IsTrigger.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Enabled"), this.m_Enabled.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Radius"), this.m_Radius.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Height"), this.m_Height.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Direction"), this.m_Direction.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Center"), this.m_Center.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06051148 RID: 332104 RVA: 0x00A45310 File Offset: 0x00A43510

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
			yamlMappingNode.Add(new YamlScalarNode("m_Enabled"), this.m_Enabled.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Radius"), this.m_Radius.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Height"), this.m_Height.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Direction"), this.m_Direction.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Center"), this.m_Center.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06051149 RID: 332105 RVA: 0x00A45460 File Offset: 0x00A43660
		public override void Reset()
		{
			this.m_Center.Reset();
			this.m_CorrespondingSourceObject.Reset();
			this.m_Direction = 0;
			this.m_Enabled = false;
			this.m_GameObject.Reset();
			this.m_Height = 0f;
			this.m_HideFlags = 0U;
			this.m_IsTrigger = false;
			this.m_Material.Reset();
			this.m_PrefabInternal.Reset();
			this.m_Radius = 0f;
		}

		// Token: 0x0605114A RID: 332106 RVA: 0x00A454D6 File Offset: 0x00A436D6
		//public override IEnumerable<ValueTuple<FieldName, PPtr<IUnityObjectBase>>> FetchDependencies(FieldName parent)
		//{
		//	return Enumerable.Empty<ValueTuple<FieldName, PPtr<IUnityObjectBase>>>().Append_CapsuleCollider_5_5_0(parent, this);
		//}

		// Token: 0x0605114B RID: 332107 RVA: 0x00A454E4 File Offset: 0x00A436E4

		public void CopyValues(ICapsuleCollider source, PPtrConverter converter)
		{
			this.m_Center.CopyValues(source.Center_C136);
			this.m_CorrespondingSourceObject.CopyValues(source.CorrespondingSourceObject_C136, converter);
			this.m_Direction = source.Direction_C136;
			this.m_Enabled = source.Enabled_C136;
			this.m_GameObject.CopyValues(source.GameObject_C136, converter);
			this.m_Height = source.Height_C136;
			this.m_HideFlags = source.HideFlags_C136;
			this.m_IsTrigger = source.IsTrigger_C136;
			this.m_Material.CopyValues(source.Material_C136, converter);
			this.m_PrefabInternal.CopyValues(source.PrefabInternal_C136, converter);
			this.m_Radius = source.Radius_C136;
		}

		// Token: 0x0605114C RID: 332108 RVA: 0x00A45592 File Offset: 0x00A43792

		public void CopyValues(ICapsuleCollider source)
		{
			this.CopyValues(source, new PPtrConverter(source, this));
		}

		// Token: 0x0605114D RID: 332109 RVA: 0x00A455A4 File Offset: 0x00A437A4
		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			ICapsuleCollider capsuleCollider = source as ICapsuleCollider;
			if (capsuleCollider != null)
			{
				this.CopyValues(capsuleCollider, converter);
				return;
			}
			base.CopyValues(source, converter);
		}

		// Token: 0x0605114E RID: 332110 RVA: 0x00A455CC File Offset: 0x00A437CC

		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0605114F RID: 332111 RVA: 0x00A455D3 File Offset: 0x00A437D3

		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04015DC9 RID: 89545
		public bool m_IsTrigger;

		// Token: 0x04015DCA RID: 89546
		public bool m_Enabled;

		// Token: 0x04015DCB RID: 89547
		public float m_Radius;

		// Token: 0x04015DCC RID: 89548
		public float m_Height;

		// Token: 0x04015DCD RID: 89549
		public int m_Direction;

		public Vector3f_3_5_0 m_LocalAngle;
	}
}
