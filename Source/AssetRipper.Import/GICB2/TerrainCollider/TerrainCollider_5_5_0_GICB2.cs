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
using AssetRipper.SourceGenerated.Classes.ClassID_156;
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
using AssetRipper.SourceGenerated.Subclasses.PPtr_TerrainData;
using AssetRipper.Yaml;

using AssetRipper.SourceGenerated.Classes.ClassID_154;

namespace AssetRipper.Import.GICB2.TerrainCollider
{
	// Token: 0x02003007 RID: 12295


	public sealed class TerrainCollider_5_5_0_GICB2 : Collider_5_5_0, ITerrainCollider, IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, ITerrainColliderMarker, IHasEnabled, ICollider, IComponent, IEditorExtension, IEditorExtensionMarker, IObject, IObjectMarker, IHasHideFlags, IComponentMarker, IColliderMarker
	{
		// Token: 0x17019E74 RID: 106100
		// (get) Token: 0x0604B06B RID: 307307 RVA: 0x00998F3A File Offset: 0x0099713A
		public IPPtr_EditorExtension CorrespondingSourceObject_C154
		{
			[return: NotNull]
			get
			{
				return this.m_CorrespondingSourceObject;
			}
		}

		// Token: 0x17019E75 RID: 106101
		// (get) Token: 0x0604B06C RID: 307308 RVA: 0x00998F42 File Offset: 0x00997142
		// (set) Token: 0x0604B06D RID: 307309 RVA: 0x00998F45 File Offset: 0x00997145
		public bool CreateTreeColliders_C154
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17019E76 RID: 106102
		// (get) Token: 0x0604B06E RID: 307310 RVA: 0x00998F47 File Offset: 0x00997147
		// (set) Token: 0x0604B06F RID: 307311 RVA: 0x00998F4F File Offset: 0x0099714F
		public bool Enabled_C154
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

		// Token: 0x17019E77 RID: 106103
		// (get) Token: 0x0604B070 RID: 307312 RVA: 0x00998F58 File Offset: 0x00997158
		// (set) Token: 0x0604B071 RID: 307313 RVA: 0x00998F60 File Offset: 0x00997160
		public bool EnableTreeColliders_C154
		{
			get
			{
				return this.m_EnableTreeColliders;
			}
			set
			{
				this.m_EnableTreeColliders = value;
			}
		}

		// Token: 0x17019E78 RID: 106104
		// (get) Token: 0x0604B072 RID: 307314 RVA: 0x00998F69 File Offset: 0x00997169
		public BitField ExcludeLayers_C154
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17019E79 RID: 106105
		// (get) Token: 0x0604B073 RID: 307315 RVA: 0x00998F6C File Offset: 0x0099716C
		public PPtr_EditorExtensionImpl ExtensionPtr_C154
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17019E7A RID: 106106
		// (get) Token: 0x0604B074 RID: 307316 RVA: 0x00998F6F File Offset: 0x0099716F

		public IPPtr_GameObject GameObject_C154
		{

			get
			{
				return this.m_GameObject;
			}
		}

		// Token: 0x17019E7B RID: 106107
		// (get) Token: 0x0604B075 RID: 307317 RVA: 0x00998F77 File Offset: 0x00997177
		// (set) Token: 0x0604B076 RID: 307318 RVA: 0x00998F7F File Offset: 0x0099717F
		public uint HideFlags_C154
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

		// Token: 0x17019E7C RID: 106108
		// (get) Token: 0x0604B077 RID: 307319 RVA: 0x00998F88 File Offset: 0x00997188
		public BitField IncludeLayers_C154
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17019E7D RID: 106109
		// (get) Token: 0x0604B078 RID: 307320 RVA: 0x00998F8B File Offset: 0x0099718B
		// (set) Token: 0x0604B079 RID: 307321 RVA: 0x00998F8E File Offset: 0x0099718E
		public bool IsTrigger_C154
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17019E7E RID: 106110
		// (get) Token: 0x0604B07A RID: 307322 RVA: 0x00998F90 File Offset: 0x00997190
		// (set) Token: 0x0604B07B RID: 307323 RVA: 0x00998F93 File Offset: 0x00997193
		public int LayerOverridePriority_C154
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17019E7F RID: 106111
		// (get) Token: 0x0604B07C RID: 307324 RVA: 0x00998F95 File Offset: 0x00997195
		public IPPtr_PhysicMaterial Material_C154
		{
			[return: NotNull]
			get
			{
				return this.m_Material;
			}
		}

		// Token: 0x17019E80 RID: 106112
		// (get) Token: 0x0604B07D RID: 307325 RVA: 0x00998F9D File Offset: 0x0099719D
		public PPtr_Prefab_2018_3_0 PrefabAsset_C154
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17019E81 RID: 106113
		// (get) Token: 0x0604B07E RID: 307326 RVA: 0x00998FA0 File Offset: 0x009971A0
		public PPtr_PrefabInstance PrefabInstance_C154
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17019E82 RID: 106114
		// (get) Token: 0x0604B07F RID: 307327 RVA: 0x00998FA3 File Offset: 0x009971A3
		public IPPtr_Prefab PrefabInternal_C154
		{
			[return: NotNull]
			get
			{
				return this.m_PrefabInternal;
			}
		}

		// Token: 0x17019E83 RID: 106115
		// (get) Token: 0x0604B080 RID: 307328 RVA: 0x00998FAB File Offset: 0x009971AB
		// (set) Token: 0x0604B081 RID: 307329 RVA: 0x00998FAE File Offset: 0x009971AE
		public bool ProvidesContacts_C154
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17019E84 RID: 106116
		// (get) Token: 0x0604B082 RID: 307330 RVA: 0x00998FB0 File Offset: 0x009971B0

		public IPPtr_TerrainData TerrainData_C154
		{

			get
			{
				return this.m_TerrainData;
			}
		}

		// Token: 0x17019E85 RID: 106117
		// (get) Token: 0x0604B083 RID: 307331 RVA: 0x00998FB8 File Offset: 0x009971B8
		// (set) Token: 0x0604B084 RID: 307332 RVA: 0x00998FC0 File Offset: 0x009971C0
		public HideFlags HideFlags_C154E
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

		// Token: 0x17019E86 RID: 106118
		// (get) Token: 0x0604B085 RID: 307333 RVA: 0x00998FC9 File Offset: 0x009971C9
		// (set) Token: 0x0604B086 RID: 307334 RVA: 0x00998FDC File Offset: 0x009971DC
		public IEditorExtension CorrespondingSourceObject_C154P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IEditorExtension>(this.CorrespondingSourceObject_C154, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IEditorExtension>(this.CorrespondingSourceObject_C154, base.Collection, value);
			}
		}

		// Token: 0x17019E87 RID: 106119
		// (get) Token: 0x0604B087 RID: 307335 RVA: 0x00998FF0 File Offset: 0x009971F0
		// (set) Token: 0x0604B088 RID: 307336 RVA: 0x00998FF3 File Offset: 0x009971F3
		public IEditorExtensionImpl ExtensionPtr_C154P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17019E88 RID: 106120
		// (get) Token: 0x0604B089 RID: 307337 RVA: 0x00998FF5 File Offset: 0x009971F5
		// (set) Token: 0x0604B08A RID: 307338 RVA: 0x00999008 File Offset: 0x00997208
		public IGameObject GameObject_C154P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IGameObject>(this.GameObject_C154, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IGameObject>(this.GameObject_C154, base.Collection, value);
			}
		}

		// Token: 0x17019E89 RID: 106121
		// (get) Token: 0x0604B08B RID: 307339 RVA: 0x0099901C File Offset: 0x0099721C
		// (set) Token: 0x0604B08C RID: 307340 RVA: 0x0099902F File Offset: 0x0099722F
		public IPhysicMaterial Material_C154P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IPhysicMaterial>(this.Material_C154, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IPhysicMaterial>(this.Material_C154, base.Collection, value);
			}
		}

		// Token: 0x17019E8A RID: 106122
		// (get) Token: 0x0604B08D RID: 307341 RVA: 0x00999043 File Offset: 0x00997243
		// (set) Token: 0x0604B08E RID: 307342 RVA: 0x00999046 File Offset: 0x00997246
		public IPrefab PrefabAsset_C154P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17019E8B RID: 106123
		// (get) Token: 0x0604B08F RID: 307343 RVA: 0x00999048 File Offset: 0x00997248
		// (set) Token: 0x0604B090 RID: 307344 RVA: 0x0099904B File Offset: 0x0099724B
		public IPrefabInstance PrefabInstance_C154P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17019E8C RID: 106124
		// (get) Token: 0x0604B091 RID: 307345 RVA: 0x0099904D File Offset: 0x0099724D
		// (set) Token: 0x0604B092 RID: 307346 RVA: 0x00999060 File Offset: 0x00997260
		public IPrefabMarker PrefabInternal_C154P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IPrefabMarker>(this.PrefabInternal_C154, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IPrefabMarker>(this.PrefabInternal_C154, base.Collection, value);
			}
		}

		// Token: 0x17019E8D RID: 106125
		// (get) Token: 0x0604B093 RID: 307347 RVA: 0x00999074 File Offset: 0x00997274
		// (set) Token: 0x0604B094 RID: 307348 RVA: 0x00999087 File Offset: 0x00997287
		public ITerrainData TerrainData_C154P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<ITerrainData>(this.TerrainData_C154, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<ITerrainData>(this.TerrainData_C154, base.Collection, value);
			}
		}

		// Token: 0x17019E8E RID: 106126
		// (get) Token: 0x0604B095 RID: 307349 RVA: 0x0099909B File Offset: 0x0099729B

		public override string ClassName
		{

			get
			{
				return "TerrainCollider";
			}
		}

		// Token: 0x17019E8F RID: 106127
		// (get) Token: 0x0604B096 RID: 307350 RVA: 0x009990A2 File Offset: 0x009972A2
		// (set) Token: 0x0604B097 RID: 307351 RVA: 0x009990AA File Offset: 0x009972AA
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

		// Token: 0x0604B098 RID: 307352 RVA: 0x009990B3 File Offset: 0x009972B3
		public TerrainCollider_5_5_0_GICB2()
			: this(AssetInfo.MakeDummyAssetInfo(154))
		{
		}

		// Token: 0x0604B099 RID: 307353 RVA: 0x009990C5 File Offset: 0x009972C5
		public TerrainCollider_5_5_0_GICB2(AssetInfo info)
			: base(info)
		{
			this.m_TerrainData = new PPtr_TerrainData_5_0_0();
		}

		// Token: 0x0604B09A RID: 307354 RVA: 0x009990D9 File Offset: 0x009972D9
		public bool Has_CorrespondingSourceObject_C154()
		{
			return true;
		}

		// Token: 0x0604B09B RID: 307355 RVA: 0x009990DC File Offset: 0x009972DC
		public bool Has_CreateTreeColliders_C154()
		{
			return false;
		}

		// Token: 0x0604B09C RID: 307356 RVA: 0x009990DF File Offset: 0x009972DF
		public bool Has_EnableTreeColliders_C154()
		{
			return true;
		}

		// Token: 0x0604B09D RID: 307357 RVA: 0x009990E2 File Offset: 0x009972E2
		public bool Has_ExcludeLayers_C154()
		{
			return false;
		}

		// Token: 0x0604B09E RID: 307358 RVA: 0x009990E5 File Offset: 0x009972E5
		public bool Has_ExtensionPtr_C154()
		{
			return false;
		}

		// Token: 0x0604B09F RID: 307359 RVA: 0x009990E8 File Offset: 0x009972E8
		public bool Has_IncludeLayers_C154()
		{
			return false;
		}

		// Token: 0x0604B0A0 RID: 307360 RVA: 0x009990EB File Offset: 0x009972EB
		public bool Has_IsTrigger_C154()
		{
			return false;
		}

		// Token: 0x0604B0A1 RID: 307361 RVA: 0x009990EE File Offset: 0x009972EE
		public bool Has_LayerOverridePriority_C154()
		{
			return false;
		}

		// Token: 0x0604B0A2 RID: 307362 RVA: 0x009990F1 File Offset: 0x009972F1
		public bool Has_Material_C154()
		{
			return true;
		}

		// Token: 0x0604B0A3 RID: 307363 RVA: 0x009990F4 File Offset: 0x009972F4
		public bool Has_PrefabAsset_C154()
		{
			return false;
		}

		// Token: 0x0604B0A4 RID: 307364 RVA: 0x009990F7 File Offset: 0x009972F7
		public bool Has_PrefabInstance_C154()
		{
			return false;
		}

		// Token: 0x0604B0A5 RID: 307365 RVA: 0x009990FA File Offset: 0x009972FA
		public bool Has_PrefabInternal_C154()
		{
			return true;
		}

		// Token: 0x0604B0A6 RID: 307366 RVA: 0x009990FD File Offset: 0x009972FD
		public bool Has_ProvidesContacts_C154()
		{
			return false;
		}

		// Token: 0x0604B0A7 RID: 307367 RVA: 0x00999100 File Offset: 0x00997300

		public override void ReadRelease(AssetReader reader)
		{
			this.m_GameObject.ReadRelease(reader);
			this.m_Material.ReadRelease(reader);
			this.m_Enabled = reader.ReadRelease_BooleanAlign();

			// GICB2
			var WalkRunSurfaceType = reader.ReadInt32();
			var ClimbSurfaceType = reader.ReadRelease_Int32Align();
			var IsSceneQuery = reader.ReadRelease_BooleanAlign();
			var IsLocalPoseConvertibility = reader.ReadRelease_BooleanAlign();

			this.m_TerrainData.ReadRelease(reader);
			this.m_EnableTreeColliders = reader.ReadBoolean();
		}

		// Token: 0x0604B0A8 RID: 307368 RVA: 0x00999140 File Offset: 0x00997340



		// Token: 0x0604B0A9 RID: 307369 RVA: 0x009991AD File Offset: 0x009973AD

		public override void WriteRelease(AssetWriter writer)
		{
			this.m_GameObject.WriteRelease(writer);
			this.m_Material.WriteRelease(writer);
			this.m_Enabled.WriteRelease_BooleanAlign(writer);
			this.m_TerrainData.WriteRelease(writer);
			this.m_EnableTreeColliders.WriteRelease_Boolean(writer);
		}

		// Token: 0x0604B0AA RID: 307370 RVA: 0x009991EC File Offset: 0x009973EC



		// Token: 0x0604B0AB RID: 307371 RVA: 0x0099925C File Offset: 0x0099745C

		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 1);
			yamlMappingNode.Add(new YamlScalarNode("m_GameObject"), this.m_GameObject.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Material"), this.m_Material.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Enabled"), this.m_Enabled.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_TerrainData"), this.m_TerrainData.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_EnableTreeColliders"), this.m_EnableTreeColliders.ExportYamlRelease_Boolean(container));
			return yamlMappingNode;
		}

		// Token: 0x0604B0AC RID: 307372 RVA: 0x00999304 File Offset: 0x00997504

		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 1);
			yamlMappingNode.Add(new YamlScalarNode("m_ObjectHideFlags"), this.m_HideFlags.ExportYamlEditor_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabParentObject"), this.m_CorrespondingSourceObject.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabInternal"), this.m_PrefabInternal.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_GameObject"), this.m_GameObject.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Material"), this.m_Material.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Enabled"), this.m_Enabled.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_TerrainData"), this.m_TerrainData.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_EnableTreeColliders"), this.m_EnableTreeColliders.ExportYamlEditor_Boolean(container));
			return yamlMappingNode;
		}

		// Token: 0x0604B0AD RID: 307373 RVA: 0x00999400 File Offset: 0x00997600
		public override void Reset()
		{
			this.m_CorrespondingSourceObject.Reset();
			this.m_Enabled = false;
			this.m_EnableTreeColliders = false;
			this.m_GameObject.Reset();
			this.m_HideFlags = 0U;
			this.m_Material.Reset();
			this.m_PrefabInternal.Reset();
			this.m_TerrainData.Reset();
		}

		// Token: 0x0604B0AE RID: 307374 RVA: 0x00999459 File Offset: 0x00997659



		// Token: 0x0604B0AF RID: 307375 RVA: 0x00999468 File Offset: 0x00997668

		public void CopyValues(ITerrainCollider source, PPtrConverter converter)
		{
			this.m_CorrespondingSourceObject.CopyValues(source.CorrespondingSourceObject_C154, converter);
			this.m_Enabled = source.Enabled_C154;
			this.m_EnableTreeColliders = source.EnableTreeColliders_C154;
			this.m_GameObject.CopyValues(source.GameObject_C154, converter);
			this.m_HideFlags = source.HideFlags_C154;
			this.m_Material.CopyValues(source.Material_C154, converter);
			this.m_PrefabInternal.CopyValues(source.PrefabInternal_C154, converter);
			this.m_TerrainData.CopyValues(source.TerrainData_C154, converter);
		}

		// Token: 0x0604B0B0 RID: 307376 RVA: 0x009994F3 File Offset: 0x009976F3

		public void CopyValues(ITerrainCollider source)
		{
			this.CopyValues(source, new PPtrConverter(source, this));
		}

		// Token: 0x0604B0B1 RID: 307377 RVA: 0x00999504 File Offset: 0x00997704
		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			ITerrainCollider terrainCollider = source as ITerrainCollider;
			if (terrainCollider != null)
			{
				this.CopyValues(terrainCollider, converter);
				return;
			}
			base.CopyValues(source, converter);
		}

		// Token: 0x0604B0B2 RID: 307378 RVA: 0x0099952C File Offset: 0x0099772C

		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0604B0B3 RID: 307379 RVA: 0x00999533 File Offset: 0x00997733

		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04015580 RID: 87424
		public bool m_Enabled;

		// Token: 0x04015581 RID: 87425

		public PPtr_TerrainData_5_0_0 m_TerrainData;

		// Token: 0x04015582 RID: 87426
		public bool m_EnableTreeColliders;
	}
}
