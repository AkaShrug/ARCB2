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

using AssetRipper.SourceGenerated.Classes.ClassID_135;

namespace AssetRipper.Import.GICB2.SphereCollider
{
	// Token: 0x02003112 RID: 12562


	public sealed class SphereCollider_5_5_0_GICB2 : Collider_5_5_0, ISphereCollider, IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, ISphereColliderMarker, IHasEnabled, ICollider, IComponent, IEditorExtension, IEditorExtensionMarker, IObject, IObjectMarker, IHasHideFlags, IComponentMarker, IColliderMarker
	{
		// Token: 0x1701BE20 RID: 114208
		// (get) Token: 0x0604FEEA RID: 327402 RVA: 0x00A2D19E File Offset: 0x00A2B39E

		public IVector3f Center_C135
		{

			get
			{
				return this.m_Center;
			}
		}

		// Token: 0x1701BE21 RID: 114209
		// (get) Token: 0x0604FEEB RID: 327403 RVA: 0x00A2D1A6 File Offset: 0x00A2B3A6
		public IPPtr_EditorExtension CorrespondingSourceObject_C135
		{
			[return: NotNull]
			get
			{
				return this.m_CorrespondingSourceObject;
			}
		}

		// Token: 0x1701BE22 RID: 114210
		// (get) Token: 0x0604FEEC RID: 327404 RVA: 0x00A2D1AE File Offset: 0x00A2B3AE
		// (set) Token: 0x0604FEED RID: 327405 RVA: 0x00A2D1B6 File Offset: 0x00A2B3B6
		public bool Enabled_C135
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

		// Token: 0x1701BE23 RID: 114211
		// (get) Token: 0x0604FEEE RID: 327406 RVA: 0x00A2D1BF File Offset: 0x00A2B3BF
		public BitField ExcludeLayers_C135
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1701BE24 RID: 114212
		// (get) Token: 0x0604FEEF RID: 327407 RVA: 0x00A2D1C2 File Offset: 0x00A2B3C2
		public PPtr_EditorExtensionImpl ExtensionPtr_C135
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1701BE25 RID: 114213
		// (get) Token: 0x0604FEF0 RID: 327408 RVA: 0x00A2D1C5 File Offset: 0x00A2B3C5

		public IPPtr_GameObject GameObject_C135
		{

			get
			{
				return this.m_GameObject;
			}
		}

		// Token: 0x1701BE26 RID: 114214
		// (get) Token: 0x0604FEF1 RID: 327409 RVA: 0x00A2D1CD File Offset: 0x00A2B3CD
		// (set) Token: 0x0604FEF2 RID: 327410 RVA: 0x00A2D1D5 File Offset: 0x00A2B3D5
		public uint HideFlags_C135
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

		// Token: 0x1701BE27 RID: 114215
		// (get) Token: 0x0604FEF3 RID: 327411 RVA: 0x00A2D1DE File Offset: 0x00A2B3DE
		public BitField IncludeLayers_C135
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1701BE28 RID: 114216
		// (get) Token: 0x0604FEF4 RID: 327412 RVA: 0x00A2D1E1 File Offset: 0x00A2B3E1
		// (set) Token: 0x0604FEF5 RID: 327413 RVA: 0x00A2D1E9 File Offset: 0x00A2B3E9
		public bool IsTrigger_C135
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

		// Token: 0x1701BE29 RID: 114217
		// (get) Token: 0x0604FEF6 RID: 327414 RVA: 0x00A2D1F2 File Offset: 0x00A2B3F2
		// (set) Token: 0x0604FEF7 RID: 327415 RVA: 0x00A2D1F5 File Offset: 0x00A2B3F5
		public int LayerOverridePriority_C135
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1701BE2A RID: 114218
		// (get) Token: 0x0604FEF8 RID: 327416 RVA: 0x00A2D1F7 File Offset: 0x00A2B3F7

		public IPPtr_PhysicMaterial Material_C135
		{

			get
			{
				return this.m_Material;
			}
		}

		// Token: 0x1701BE2B RID: 114219
		// (get) Token: 0x0604FEF9 RID: 327417 RVA: 0x00A2D1FF File Offset: 0x00A2B3FF
		public PPtr_Prefab_2018_3_0 PrefabAsset_C135
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1701BE2C RID: 114220
		// (get) Token: 0x0604FEFA RID: 327418 RVA: 0x00A2D202 File Offset: 0x00A2B402
		public PPtr_PrefabInstance PrefabInstance_C135
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1701BE2D RID: 114221
		// (get) Token: 0x0604FEFB RID: 327419 RVA: 0x00A2D205 File Offset: 0x00A2B405
		public IPPtr_Prefab PrefabInternal_C135
		{
			[return: NotNull]
			get
			{
				return this.m_PrefabInternal;
			}
		}

		// Token: 0x1701BE2E RID: 114222
		// (get) Token: 0x0604FEFC RID: 327420 RVA: 0x00A2D20D File Offset: 0x00A2B40D
		// (set) Token: 0x0604FEFD RID: 327421 RVA: 0x00A2D210 File Offset: 0x00A2B410
		public bool ProvidesContacts_C135
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1701BE2F RID: 114223
		// (get) Token: 0x0604FEFE RID: 327422 RVA: 0x00A2D212 File Offset: 0x00A2B412
		// (set) Token: 0x0604FEFF RID: 327423 RVA: 0x00A2D21A File Offset: 0x00A2B41A
		public float Radius_C135
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

		// Token: 0x1701BE30 RID: 114224
		// (get) Token: 0x0604FF00 RID: 327424 RVA: 0x00A2D223 File Offset: 0x00A2B423
		// (set) Token: 0x0604FF01 RID: 327425 RVA: 0x00A2D22B File Offset: 0x00A2B42B
		public HideFlags HideFlags_C135E
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

		// Token: 0x1701BE31 RID: 114225
		// (get) Token: 0x0604FF02 RID: 327426 RVA: 0x00A2D234 File Offset: 0x00A2B434
		// (set) Token: 0x0604FF03 RID: 327427 RVA: 0x00A2D247 File Offset: 0x00A2B447
		public IEditorExtension CorrespondingSourceObject_C135P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IEditorExtension>(this.CorrespondingSourceObject_C135, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IEditorExtension>(this.CorrespondingSourceObject_C135, base.Collection, value);
			}
		}

		// Token: 0x1701BE32 RID: 114226
		// (get) Token: 0x0604FF04 RID: 327428 RVA: 0x00A2D25B File Offset: 0x00A2B45B
		// (set) Token: 0x0604FF05 RID: 327429 RVA: 0x00A2D25E File Offset: 0x00A2B45E
		public IEditorExtensionImpl ExtensionPtr_C135P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1701BE33 RID: 114227
		// (get) Token: 0x0604FF06 RID: 327430 RVA: 0x00A2D260 File Offset: 0x00A2B460
		// (set) Token: 0x0604FF07 RID: 327431 RVA: 0x00A2D273 File Offset: 0x00A2B473
		public IGameObject GameObject_C135P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IGameObject>(this.GameObject_C135, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IGameObject>(this.GameObject_C135, base.Collection, value);
			}
		}

		// Token: 0x1701BE34 RID: 114228
		// (get) Token: 0x0604FF08 RID: 327432 RVA: 0x00A2D287 File Offset: 0x00A2B487
		// (set) Token: 0x0604FF09 RID: 327433 RVA: 0x00A2D29A File Offset: 0x00A2B49A
		public IPhysicMaterial Material_C135P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IPhysicMaterial>(this.Material_C135, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IPhysicMaterial>(this.Material_C135, base.Collection, value);
			}
		}

		// Token: 0x1701BE35 RID: 114229
		// (get) Token: 0x0604FF0A RID: 327434 RVA: 0x00A2D2AE File Offset: 0x00A2B4AE
		// (set) Token: 0x0604FF0B RID: 327435 RVA: 0x00A2D2B1 File Offset: 0x00A2B4B1
		public IPrefab PrefabAsset_C135P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1701BE36 RID: 114230
		// (get) Token: 0x0604FF0C RID: 327436 RVA: 0x00A2D2B3 File Offset: 0x00A2B4B3
		// (set) Token: 0x0604FF0D RID: 327437 RVA: 0x00A2D2B6 File Offset: 0x00A2B4B6
		public IPrefabInstance PrefabInstance_C135P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1701BE37 RID: 114231
		// (get) Token: 0x0604FF0E RID: 327438 RVA: 0x00A2D2B8 File Offset: 0x00A2B4B8
		// (set) Token: 0x0604FF0F RID: 327439 RVA: 0x00A2D2CB File Offset: 0x00A2B4CB
		public IPrefabMarker PrefabInternal_C135P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IPrefabMarker>(this.PrefabInternal_C135, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IPrefabMarker>(this.PrefabInternal_C135, base.Collection, value);
			}
		}

		// Token: 0x1701BE38 RID: 114232
		// (get) Token: 0x0604FF10 RID: 327440 RVA: 0x00A2D2DF File Offset: 0x00A2B4DF

		public override string ClassName
		{

			get
			{
				return "SphereCollider";
			}
		}

		// Token: 0x1701BE39 RID: 114233
		// (get) Token: 0x0604FF11 RID: 327441 RVA: 0x00A2D2E6 File Offset: 0x00A2B4E6
		// (set) Token: 0x0604FF12 RID: 327442 RVA: 0x00A2D2EE File Offset: 0x00A2B4EE
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

		// Token: 0x0604FF13 RID: 327443 RVA: 0x00A2D2F7 File Offset: 0x00A2B4F7
		public SphereCollider_5_5_0_GICB2()
			: this(AssetInfo.MakeDummyAssetInfo(135))
		{
		}

		// Token: 0x0604FF14 RID: 327444 RVA: 0x00A2D309 File Offset: 0x00A2B509
		public SphereCollider_5_5_0_GICB2(AssetInfo info)
			: base(info)
		{
		}

		// Token: 0x0604FF15 RID: 327445 RVA: 0x00A2D312 File Offset: 0x00A2B512
		public bool Has_CorrespondingSourceObject_C135()
		{
			return true;
		}

		// Token: 0x0604FF16 RID: 327446 RVA: 0x00A2D315 File Offset: 0x00A2B515
		public bool Has_ExcludeLayers_C135()
		{
			return false;
		}

		// Token: 0x0604FF17 RID: 327447 RVA: 0x00A2D318 File Offset: 0x00A2B518
		public bool Has_ExtensionPtr_C135()
		{
			return false;
		}

		// Token: 0x0604FF18 RID: 327448 RVA: 0x00A2D31B File Offset: 0x00A2B51B
		public bool Has_IncludeLayers_C135()
		{
			return false;
		}

		// Token: 0x0604FF19 RID: 327449 RVA: 0x00A2D31E File Offset: 0x00A2B51E
		public bool Has_LayerOverridePriority_C135()
		{
			return false;
		}

		// Token: 0x0604FF1A RID: 327450 RVA: 0x00A2D321 File Offset: 0x00A2B521
		public bool Has_PrefabAsset_C135()
		{
			return false;
		}

		// Token: 0x0604FF1B RID: 327451 RVA: 0x00A2D324 File Offset: 0x00A2B524
		public bool Has_PrefabInstance_C135()
		{
			return false;
		}

		// Token: 0x0604FF1C RID: 327452 RVA: 0x00A2D327 File Offset: 0x00A2B527
		public bool Has_PrefabInternal_C135()
		{
			return true;
		}

		// Token: 0x0604FF1D RID: 327453 RVA: 0x00A2D32A File Offset: 0x00A2B52A
		public bool Has_ProvidesContacts_C135()
		{
			return false;
		}

		// Token: 0x0604FF1E RID: 327454 RVA: 0x00A2D330 File Offset: 0x00A2B530

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
			this.m_Center.ReadRelease(reader);
		}

		// Token: 0x0604FF1F RID: 327455 RVA: 0x00A2D388 File Offset: 0x00A2B588



		// Token: 0x0604FF20 RID: 327456 RVA: 0x00A2D404 File Offset: 0x00A2B604

		public override void WriteRelease(AssetWriter writer)
		{
			this.m_GameObject.WriteRelease(writer);
			this.m_Material.WriteRelease(writer);
			this.m_IsTrigger.WriteRelease_Boolean(writer);
			this.m_Enabled.WriteRelease_BooleanAlign(writer);
			this.m_Radius.WriteRelease_Single(writer);
			this.m_Center.WriteRelease(writer);
		}

		// Token: 0x0604FF21 RID: 327457 RVA: 0x00A2D45C File Offset: 0x00A2B65C



		// Token: 0x0604FF22 RID: 327458 RVA: 0x00A2D4D8 File Offset: 0x00A2B6D8

		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 2);
			yamlMappingNode.Add(new YamlScalarNode("m_GameObject"), this.m_GameObject.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Material"), this.m_Material.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_IsTrigger"), this.m_IsTrigger.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Enabled"), this.m_Enabled.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Radius"), this.m_Radius.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Center"), this.m_Center.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0604FF23 RID: 327459 RVA: 0x00A2D59C File Offset: 0x00A2B79C

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
			yamlMappingNode.Add(new YamlScalarNode("m_Radius"), this.m_Radius.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Center"), this.m_Center.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0604FF24 RID: 327460 RVA: 0x00A2D6B4 File Offset: 0x00A2B8B4
		public override void Reset()
		{
			this.m_Center.Reset();
			this.m_CorrespondingSourceObject.Reset();
			this.m_Enabled = false;
			this.m_GameObject.Reset();
			this.m_HideFlags = 0U;
			this.m_IsTrigger = false;
			this.m_Material.Reset();
			this.m_PrefabInternal.Reset();
			this.m_Radius = 0f;
		}

		// Token: 0x0604FF25 RID: 327461 RVA: 0x00A2D718 File Offset: 0x00A2B918



		// Token: 0x0604FF26 RID: 327462 RVA: 0x00A2D728 File Offset: 0x00A2B928

		public void CopyValues(ISphereCollider source, PPtrConverter converter)
		{
			this.m_Center.CopyValues(source.Center_C135);
			this.m_CorrespondingSourceObject.CopyValues(source.CorrespondingSourceObject_C135, converter);
			this.m_Enabled = source.Enabled_C135;
			this.m_GameObject.CopyValues(source.GameObject_C135, converter);
			this.m_HideFlags = source.HideFlags_C135;
			this.m_IsTrigger = source.IsTrigger_C135;
			this.m_Material.CopyValues(source.Material_C135, converter);
			this.m_PrefabInternal.CopyValues(source.PrefabInternal_C135, converter);
			this.m_Radius = source.Radius_C135;
		}

		// Token: 0x0604FF27 RID: 327463 RVA: 0x00A2D7BE File Offset: 0x00A2B9BE

		public void CopyValues(ISphereCollider source)
		{
			this.CopyValues(source, new PPtrConverter(source, this));
		}

		// Token: 0x0604FF28 RID: 327464 RVA: 0x00A2D7D0 File Offset: 0x00A2B9D0
		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			ISphereCollider sphereCollider = source as ISphereCollider;
			if (sphereCollider != null)
			{
				this.CopyValues(sphereCollider, converter);
				return;
			}
			base.CopyValues(source, converter);
		}

		// Token: 0x0604FF29 RID: 327465 RVA: 0x00A2D7F8 File Offset: 0x00A2B9F8

		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0604FF2A RID: 327466 RVA: 0x00A2D7FF File Offset: 0x00A2B9FF

		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04015C4B RID: 89163
		public bool m_Enabled;

		// Token: 0x04015C4C RID: 89164
		public float m_Radius;
	}
}
