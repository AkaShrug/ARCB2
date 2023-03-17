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
using AssetRipper.SourceGenerated.Classes.ClassID_43;
using AssetRipper.SourceGenerated.Classes.ClassID_56;
using AssetRipper.SourceGenerated.Enums;
using AssetRipper.SourceGenerated.Helpers;
using AssetRipper.SourceGenerated.Interfaces;
using AssetRipper.SourceGenerated.MarkerInterfaces;
using AssetRipper.SourceGenerated.Subclasses.BitField;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtensionImpl;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtension;
using AssetRipper.SourceGenerated.Subclasses.PPtr_GameObject;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Mesh;
using AssetRipper.SourceGenerated.Subclasses.PPtr_PhysicMaterial;
using AssetRipper.SourceGenerated.Subclasses.PPtr_PrefabInstance;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Prefab;
using AssetRipper.Yaml;
using AssetRipper.SourceGenerated.Classes.ClassID_64;
using AssetRipper.Import.IO.Extensions;

namespace AssetRipper.Import.GICB2.MeshCollider
{
	// Token: 0x02002749 RID: 10057
	public sealed class MeshCollider_5_5_0_GICB2 : Collider_5_5_0, IMeshCollider, IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IMeshColliderMarker, IHasEnabled, ICollider, IComponent, IEditorExtension, IEditorExtensionMarker, IObject, IObjectMarker, IHasHideFlags, IComponentMarker, IColliderMarker
	{
		// Token: 0x17009B22 RID: 39714
		// (get) Token: 0x06022052 RID: 139346 RVA: 0x0050ABD2 File Offset: 0x00508DD2
		// (set) Token: 0x06022053 RID: 139347 RVA: 0x0050ABDA File Offset: 0x00508DDA
		public bool Convex_C64
		{
			get
			{
				return this.m_Convex;
			}
			set
			{
				this.m_Convex = value;
			}
		}

		// Token: 0x17009B23 RID: 39715
		// (get) Token: 0x06022054 RID: 139348 RVA: 0x0050ABE3 File Offset: 0x00508DE3
		// (set) Token: 0x06022055 RID: 139349 RVA: 0x0050ABE6 File Offset: 0x00508DE6
		public int CookingOptions_C64
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17009B24 RID: 39716
		// (get) Token: 0x06022056 RID: 139350 RVA: 0x0050ABE8 File Offset: 0x00508DE8
		public IPPtr_EditorExtension CorrespondingSourceObject_C64
		{
			[return: NotNull]
			get
			{
				return this.m_CorrespondingSourceObject;
			}
		}

		// Token: 0x17009B25 RID: 39717
		// (get) Token: 0x06022057 RID: 139351 RVA: 0x0050ABF0 File Offset: 0x00508DF0
		// (set) Token: 0x06022058 RID: 139352 RVA: 0x0050ABF8 File Offset: 0x00508DF8
		public bool Enabled_C64
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

		// Token: 0x17009B26 RID: 39718
		// (get) Token: 0x06022059 RID: 139353 RVA: 0x0050AC01 File Offset: 0x00508E01
		public BitField ExcludeLayers_C64
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17009B27 RID: 39719
		// (get) Token: 0x0602205A RID: 139354 RVA: 0x0050AC04 File Offset: 0x00508E04
		public PPtr_EditorExtensionImpl ExtensionPtr_C64
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17009B28 RID: 39720
		// (get) Token: 0x0602205B RID: 139355 RVA: 0x0050AC07 File Offset: 0x00508E07

		public IPPtr_GameObject GameObject_C64
		{

			get
			{
				return this.m_GameObject;
			}
		}

		// Token: 0x17009B29 RID: 39721
		// (get) Token: 0x0602205C RID: 139356 RVA: 0x0050AC0F File Offset: 0x00508E0F
		// (set) Token: 0x0602205D RID: 139357 RVA: 0x0050AC17 File Offset: 0x00508E17
		public uint HideFlags_C64
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

		// Token: 0x17009B2A RID: 39722
		// (get) Token: 0x0602205E RID: 139358 RVA: 0x0050AC20 File Offset: 0x00508E20
		public BitField IncludeLayers_C64
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17009B2B RID: 39723
		// (get) Token: 0x0602205F RID: 139359 RVA: 0x0050AC23 File Offset: 0x00508E23
		// (set) Token: 0x06022060 RID: 139360 RVA: 0x0050AC2B File Offset: 0x00508E2B
		public bool InflateMesh_C64
		{
			get
			{
				return this.m_InflateMesh;
			}
			set
			{
				this.m_InflateMesh = value;
			}
		}

		// Token: 0x17009B2C RID: 39724
		// (get) Token: 0x06022061 RID: 139361 RVA: 0x0050AC34 File Offset: 0x00508E34
		// (set) Token: 0x06022062 RID: 139362 RVA: 0x0050AC3C File Offset: 0x00508E3C
		public bool IsTrigger_C64
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

		// Token: 0x17009B2D RID: 39725
		// (get) Token: 0x06022063 RID: 139363 RVA: 0x0050AC45 File Offset: 0x00508E45
		// (set) Token: 0x06022064 RID: 139364 RVA: 0x0050AC48 File Offset: 0x00508E48
		public int LayerOverridePriority_C64
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17009B2E RID: 39726
		// (get) Token: 0x06022065 RID: 139365 RVA: 0x0050AC4A File Offset: 0x00508E4A

		public IPPtr_PhysicMaterial Material_C64
		{

			get
			{
				return this.m_Material;
			}
		}

		// Token: 0x17009B2F RID: 39727
		// (get) Token: 0x06022066 RID: 139366 RVA: 0x0050AC52 File Offset: 0x00508E52

		public IPPtr_Mesh Mesh_C64
		{

			get
			{
				return this.m_Mesh;
			}
		}

		// Token: 0x17009B30 RID: 39728
		// (get) Token: 0x06022067 RID: 139367 RVA: 0x0050AC5A File Offset: 0x00508E5A
		public PPtr_Prefab_2018_3_0 PrefabAsset_C64
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17009B31 RID: 39729
		// (get) Token: 0x06022068 RID: 139368 RVA: 0x0050AC5D File Offset: 0x00508E5D
		public PPtr_PrefabInstance PrefabInstance_C64
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17009B32 RID: 39730
		// (get) Token: 0x06022069 RID: 139369 RVA: 0x0050AC60 File Offset: 0x00508E60
		public IPPtr_Prefab PrefabInternal_C64
		{
			[return: NotNull]
			get
			{
				return this.m_PrefabInternal;
			}
		}

		// Token: 0x17009B33 RID: 39731
		// (get) Token: 0x0602206A RID: 139370 RVA: 0x0050AC68 File Offset: 0x00508E68
		// (set) Token: 0x0602206B RID: 139371 RVA: 0x0050AC6B File Offset: 0x00508E6B
		public bool ProvidesContacts_C64
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17009B34 RID: 39732
		// (get) Token: 0x0602206C RID: 139372 RVA: 0x0050AC6D File Offset: 0x00508E6D
		// (set) Token: 0x0602206D RID: 139373 RVA: 0x0050AC75 File Offset: 0x00508E75
		public float SkinWidth_C64
		{
			get
			{
				return this.m_SkinWidth;
			}
			set
			{
				this.m_SkinWidth = value;
			}
		}

		// Token: 0x17009B35 RID: 39733
		// (get) Token: 0x0602206E RID: 139374 RVA: 0x0050AC7E File Offset: 0x00508E7E
		// (set) Token: 0x0602206F RID: 139375 RVA: 0x0050AC81 File Offset: 0x00508E81
		public bool SmoothSphereCollisions_C64
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17009B36 RID: 39734
		// (get) Token: 0x06022070 RID: 139376 RVA: 0x0050AC83 File Offset: 0x00508E83
		// (set) Token: 0x06022071 RID: 139377 RVA: 0x0050AC86 File Offset: 0x00508E86
		public MeshColliderCookingOptions CookingOptions_C64E
		{
			get
			{
				return MeshColliderCookingOptions.None;
			}
			set
			{
			}
		}

		// Token: 0x17009B37 RID: 39735
		// (get) Token: 0x06022072 RID: 139378 RVA: 0x0050AC88 File Offset: 0x00508E88
		// (set) Token: 0x06022073 RID: 139379 RVA: 0x0050AC90 File Offset: 0x00508E90
		public HideFlags HideFlags_C64E
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

		// Token: 0x17009B38 RID: 39736
		// (get) Token: 0x06022074 RID: 139380 RVA: 0x0050AC99 File Offset: 0x00508E99
		// (set) Token: 0x06022075 RID: 139381 RVA: 0x0050ACAC File Offset: 0x00508EAC
		public IEditorExtension CorrespondingSourceObject_C64P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IEditorExtension>(this.CorrespondingSourceObject_C64, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IEditorExtension>(this.CorrespondingSourceObject_C64, base.Collection, value);
			}
		}

		// Token: 0x17009B39 RID: 39737
		// (get) Token: 0x06022076 RID: 139382 RVA: 0x0050ACC0 File Offset: 0x00508EC0
		// (set) Token: 0x06022077 RID: 139383 RVA: 0x0050ACC3 File Offset: 0x00508EC3
		public IEditorExtensionImpl ExtensionPtr_C64P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17009B3A RID: 39738
		// (get) Token: 0x06022078 RID: 139384 RVA: 0x0050ACC5 File Offset: 0x00508EC5
		// (set) Token: 0x06022079 RID: 139385 RVA: 0x0050ACD8 File Offset: 0x00508ED8
		public IGameObject GameObject_C64P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IGameObject>(this.GameObject_C64, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IGameObject>(this.GameObject_C64, base.Collection, value);
			}
		}

		// Token: 0x17009B3B RID: 39739
		// (get) Token: 0x0602207A RID: 139386 RVA: 0x0050ACEC File Offset: 0x00508EEC
		// (set) Token: 0x0602207B RID: 139387 RVA: 0x0050ACFF File Offset: 0x00508EFF
		public IPhysicMaterial Material_C64P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IPhysicMaterial>(this.Material_C64, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IPhysicMaterial>(this.Material_C64, base.Collection, value);
			}
		}

		// Token: 0x17009B3C RID: 39740
		// (get) Token: 0x0602207C RID: 139388 RVA: 0x0050AD13 File Offset: 0x00508F13
		// (set) Token: 0x0602207D RID: 139389 RVA: 0x0050AD26 File Offset: 0x00508F26
		public IMesh Mesh_C64P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IMesh>(this.Mesh_C64, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IMesh>(this.Mesh_C64, base.Collection, value);
			}
		}

		// Token: 0x17009B3D RID: 39741
		// (get) Token: 0x0602207E RID: 139390 RVA: 0x0050AD3A File Offset: 0x00508F3A
		// (set) Token: 0x0602207F RID: 139391 RVA: 0x0050AD3D File Offset: 0x00508F3D
		public IPrefab PrefabAsset_C64P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17009B3E RID: 39742
		// (get) Token: 0x06022080 RID: 139392 RVA: 0x0050AD3F File Offset: 0x00508F3F
		// (set) Token: 0x06022081 RID: 139393 RVA: 0x0050AD42 File Offset: 0x00508F42
		public IPrefabInstance PrefabInstance_C64P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17009B3F RID: 39743
		// (get) Token: 0x06022082 RID: 139394 RVA: 0x0050AD44 File Offset: 0x00508F44
		// (set) Token: 0x06022083 RID: 139395 RVA: 0x0050AD57 File Offset: 0x00508F57
		public IPrefabMarker PrefabInternal_C64P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IPrefabMarker>(this.PrefabInternal_C64, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IPrefabMarker>(this.PrefabInternal_C64, base.Collection, value);
			}
		}

		// Token: 0x17009B40 RID: 39744
		// (get) Token: 0x06022084 RID: 139396 RVA: 0x0050AD6B File Offset: 0x00508F6B

		public override string ClassName
		{

			get
			{
				return "MeshCollider";
			}
		}

		// Token: 0x17009B41 RID: 39745
		// (get) Token: 0x06022085 RID: 139397 RVA: 0x0050AD72 File Offset: 0x00508F72
		// (set) Token: 0x06022086 RID: 139398 RVA: 0x0050AD7A File Offset: 0x00508F7A
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

		// Token: 0x06022087 RID: 139399 RVA: 0x0050AD83 File Offset: 0x00508F83
		public MeshCollider_5_5_0_GICB2()
			: this(AssetInfo.MakeDummyAssetInfo(64))
		{
		}

		// Token: 0x06022088 RID: 139400 RVA: 0x0050AD92 File Offset: 0x00508F92
		public MeshCollider_5_5_0_GICB2(AssetInfo info)
			: base(info)
		{
			this.m_Mesh = new PPtr_Mesh_5_0_0();
		}

		// Token: 0x06022089 RID: 139401 RVA: 0x0050ADA6 File Offset: 0x00508FA6
		public bool Has_CookingOptions_C64()
		{
			return false;
		}

		// Token: 0x0602208A RID: 139402 RVA: 0x0050ADA9 File Offset: 0x00508FA9
		public bool Has_CorrespondingSourceObject_C64()
		{
			return true;
		}

		// Token: 0x0602208B RID: 139403 RVA: 0x0050ADAC File Offset: 0x00508FAC
		public bool Has_ExcludeLayers_C64()
		{
			return false;
		}

		// Token: 0x0602208C RID: 139404 RVA: 0x0050ADAF File Offset: 0x00508FAF
		public bool Has_ExtensionPtr_C64()
		{
			return false;
		}

		// Token: 0x0602208D RID: 139405 RVA: 0x0050ADB2 File Offset: 0x00508FB2
		public bool Has_IncludeLayers_C64()
		{
			return false;
		}

		// Token: 0x0602208E RID: 139406 RVA: 0x0050ADB5 File Offset: 0x00508FB5
		public bool Has_InflateMesh_C64()
		{
			return true;
		}

		// Token: 0x0602208F RID: 139407 RVA: 0x0050ADB8 File Offset: 0x00508FB8
		public bool Has_LayerOverridePriority_C64()
		{
			return false;
		}

		// Token: 0x06022090 RID: 139408 RVA: 0x0050ADBB File Offset: 0x00508FBB
		public bool Has_PrefabAsset_C64()
		{
			return false;
		}

		// Token: 0x06022091 RID: 139409 RVA: 0x0050ADBE File Offset: 0x00508FBE
		public bool Has_PrefabInstance_C64()
		{
			return false;
		}

		// Token: 0x06022092 RID: 139410 RVA: 0x0050ADC1 File Offset: 0x00508FC1
		public bool Has_PrefabInternal_C64()
		{
			return true;
		}

		// Token: 0x06022093 RID: 139411 RVA: 0x0050ADC4 File Offset: 0x00508FC4
		public bool Has_ProvidesContacts_C64()
		{
			return false;
		}

		// Token: 0x06022094 RID: 139412 RVA: 0x0050ADC7 File Offset: 0x00508FC7
		public bool Has_SkinWidth_C64()
		{
			return true;
		}

		// Token: 0x06022095 RID: 139413 RVA: 0x0050ADCA File Offset: 0x00508FCA
		public bool Has_SmoothSphereCollisions_C64()
		{
			return false;
		}

		// Token: 0x06022096 RID: 139414 RVA: 0x0050ADD0 File Offset: 0x00508FD0

		public override void ReadRelease(AssetReader reader)
		{
			this.m_GameObject.ReadRelease(reader);
			this.m_Material.ReadRelease(reader);
			this.m_IsTrigger = reader.ReadBoolean();
			this.m_Enabled = reader.ReadRelease_BooleanAlign();

			// GICB2
			this.WalkRunSurfaceType = reader.ReadInt32();
			this.ClimbSurfaceType = reader.ReadRelease_Int32Align();
			this.IsSceneQuery = reader.ReadRelease_BooleanAlign();
			this.IsLocalPoseConvertibility = reader.ReadRelease_BooleanAlign();

			this.m_Convex = reader.ReadBoolean();
			this.m_InflateMesh = reader.ReadRelease_BooleanAlign();
			this.m_SkinWidth = reader.ReadSingle();
			this.m_Mesh.ReadRelease(reader);
			this.m_UseRangeInfos = reader.ReadRelease_BooleanAlign();
			this.m_RangeInfos = reader.ReadAssetArray<ColliderRangeInfoType>(false);
			reader.AlignStream();
		}

		// Token: 0x06022097 RID: 139415 RVA: 0x0050AE40 File Offset: 0x00509040

		public override void ReadEditor(AssetReader reader)
		{
		}

		// Token: 0x06022098 RID: 139416 RVA: 0x0050AED4 File Offset: 0x005090D4

		public override void WriteRelease(AssetWriter writer)
		{
			this.m_GameObject.WriteRelease(writer);
			this.m_Material.WriteRelease(writer);
			this.m_IsTrigger.WriteRelease_Boolean(writer);
			this.m_Enabled.WriteRelease_BooleanAlign(writer);
			this.m_Convex.WriteRelease_Boolean(writer);
			this.m_InflateMesh.WriteRelease_BooleanAlign(writer);
			this.m_SkinWidth.WriteRelease_Single(writer);
			this.m_Mesh.WriteRelease(writer);
		}

		// Token: 0x06022099 RID: 139417 RVA: 0x0050AF44 File Offset: 0x00509144

		public override void WriteEditor(AssetWriter writer)
		{
		}

		// Token: 0x0602209A RID: 139418 RVA: 0x0050AFD8 File Offset: 0x005091D8

		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 2);
			yamlMappingNode.Add(new YamlScalarNode("m_GameObject"), this.m_GameObject.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Material"), this.m_Material.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_IsTrigger"), this.m_IsTrigger.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Enabled"), this.m_Enabled.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Convex"), this.m_Convex.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_InflateMesh"), this.m_InflateMesh.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SkinWidth"), this.m_SkinWidth.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Mesh"), this.m_Mesh.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0602209B RID: 139419 RVA: 0x0050B0D4 File Offset: 0x005092D4

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
			yamlMappingNode.Add(new YamlScalarNode("m_Convex"), this.m_Convex.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_InflateMesh"), this.m_InflateMesh.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SkinWidth"), this.m_SkinWidth.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Mesh"), this.m_Mesh.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0602209C RID: 139420 RVA: 0x0050B224 File Offset: 0x00509424
		public override void Reset()
		{
			this.m_Convex = false;
			this.m_CorrespondingSourceObject.Reset();
			this.m_Enabled = false;
			this.m_GameObject.Reset();
			this.m_HideFlags = 0U;
			this.m_InflateMesh = false;
			this.m_IsTrigger = false;
			this.m_Material.Reset();
			this.m_Mesh.Reset();
			this.m_PrefabInternal.Reset();
			this.m_SkinWidth = 0f;
		}

		// Token: 0x0602209D RID: 139421 RVA: 0x0050B296 File Offset: 0x00509496
		//public override IEnumerable<ValueTuple<FieldName, PPtr<IUnityObjectBase>>> FetchDependencies(FieldName parent)
		//{
		//	return Enumerable.Empty<ValueTuple<FieldName, PPtr<IUnityObjectBase>>>().Append_MeshCollider_5_5_0(parent, this);
		//}

		// Token: 0x0602209E RID: 139422 RVA: 0x0050B2A4 File Offset: 0x005094A4

		public void CopyValues(IMeshCollider source, PPtrConverter converter)
		{
			this.m_Convex = source.Convex_C64;
			this.m_CorrespondingSourceObject.CopyValues(source.CorrespondingSourceObject_C64, converter);
			this.m_Enabled = source.Enabled_C64;
			this.m_GameObject.CopyValues(source.GameObject_C64, converter);
			this.m_HideFlags = source.HideFlags_C64;
			this.m_InflateMesh = source.InflateMesh_C64;
			this.m_IsTrigger = source.IsTrigger_C64;
			this.m_Material.CopyValues(source.Material_C64, converter);
			this.m_Mesh.CopyValues(source.Mesh_C64, converter);
			this.m_PrefabInternal.CopyValues(source.PrefabInternal_C64, converter);
			this.m_SkinWidth = source.SkinWidth_C64;
		}

		// Token: 0x0602209F RID: 139423 RVA: 0x0050B353 File Offset: 0x00509553

		public void CopyValues(IMeshCollider source)
		{
			this.CopyValues(source, new PPtrConverter(source, this));
		}

		// Token: 0x060220A0 RID: 139424 RVA: 0x0050B364 File Offset: 0x00509564
		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			IMeshCollider meshCollider = source as IMeshCollider;
			if (meshCollider != null)
			{
				this.CopyValues(meshCollider, converter);
				return;
			}
			base.CopyValues(source, converter);
		}

		// Token: 0x060220A1 RID: 139425 RVA: 0x0050B38C File Offset: 0x0050958C

		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060220A2 RID: 139426 RVA: 0x0050B393 File Offset: 0x00509593

		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0401184F RID: 71759
		public bool m_Enabled;

		// Token: 0x04011850 RID: 71760
		public bool m_Convex;

		// Token: 0x04011851 RID: 71761
		public bool m_InflateMesh;

		// Token: 0x04011852 RID: 71762
		public float m_SkinWidth;

		// Token: 0x04011853 RID: 71763

		public PPtr_Mesh_5_0_0 m_Mesh;

		public bool m_UseRangeInfos;

		public ColliderRangeInfoType[] m_RangeInfos { get; set; }

		public int WalkRunSurfaceType { get; set; }
		public int ClimbSurfaceType { get; set; }
		public bool IsSceneQuery { get; set; }
		public bool IsLocalPoseConvertibility { get; set; }
	}
}
