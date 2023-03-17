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
using AssetRipper.SourceGenerated.Classes.ClassID_1001;
using AssetRipper.SourceGenerated.Classes.ClassID_1001480554;
using AssetRipper.SourceGenerated.Classes.ClassID_130;
using AssetRipper.SourceGenerated.Classes.ClassID_18;
using AssetRipper.SourceGenerated.Enums;
using AssetRipper.SourceGenerated.Helpers;
using AssetRipper.SourceGenerated.Interfaces;
using AssetRipper.SourceGenerated.MarkerInterfaces;
using AssetRipper.SourceGenerated.Subclasses.AABB;
using AssetRipper.SourceGenerated.Subclasses.AutoOffMeshLinkData;
using AssetRipper.SourceGenerated.Subclasses.HeightmapData;
using AssetRipper.SourceGenerated.Subclasses.HeightMeshData;
using AssetRipper.SourceGenerated.Subclasses.NavMeshBuildSettings;
using AssetRipper.SourceGenerated.Subclasses.NavMeshParams;
using AssetRipper.SourceGenerated.Subclasses.NavMeshTileData;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtension;
using AssetRipper.SourceGenerated.Subclasses.PPtr_PrefabInstance;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Prefab;
using AssetRipper.SourceGenerated.Subclasses.Quaternionf;
using AssetRipper.SourceGenerated.Subclasses.Utf8String;
using AssetRipper.SourceGenerated.Subclasses.Vector3f;
using AssetRipper.Yaml;
using AssetRipper.SourceGenerated.Classes.ClassID_238;
using AssetRipper.Import.GICB2.NavMeshData.NavMeshBuildSettings;

namespace AssetRipper.Import.GICB2.NavMeshData
{
	// Token: 0x02002B13 RID: 11027


	public sealed class NavMeshData_2017_1_0_GICB2 : NamedObject_5_0_0, INavMeshData, IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, INavMeshDataMarker, IHasName, IHasNameString, INamedObject, INamedObjectMarker, IEditorExtension, IEditorExtensionMarker, IObject, IObjectMarker, IHasHideFlags
	{
		// Token: 0x170109AD RID: 68013
		// (get) Token: 0x060338AE RID: 211118 RVA: 0x006F1F90 File Offset: 0x006F0190
		// (set) Token: 0x060338AF RID: 211119 RVA: 0x006F1F98 File Offset: 0x006F0198
		public int AgentTypeID_C238
		{
			get
			{
				return this.m_AgentTypeID;
			}
			set
			{
				this.m_AgentTypeID = value;
			}
		}

		// Token: 0x170109AE RID: 68014
		// (get) Token: 0x060338B0 RID: 211120 RVA: 0x006F1FA1 File Offset: 0x006F01A1
		public PPtr_EditorExtension_5_0_0 CorrespondingSourceObject_C238
		{
			get
			{
				return this.m_CorrespondingSourceObject;
			}
		}

		// Token: 0x170109AF RID: 68015
		// (get) Token: 0x060338B1 RID: 211121 RVA: 0x006F1FA9 File Offset: 0x006F01A9
		public AccessListBase<IHeightmapData> Heightmaps_C238
		{
			get
			{
				return new AccessList<HeightmapData_5_0_0, IHeightmapData>(this.m_Heightmaps);
			}
		}

		// Token: 0x170109B0 RID: 68016
		// (get) Token: 0x060338B2 RID: 211122 RVA: 0x006F1FB6 File Offset: 0x006F01B6
		public AccessListBase<IHeightMeshData> HeightMeshes_C238
		{
			get
			{
				return new AccessList<HeightMeshData_2017_1_0, IHeightMeshData>(this.m_HeightMeshes);
			}
		}

		// Token: 0x170109B1 RID: 68017
		// (get) Token: 0x060338B3 RID: 211123 RVA: 0x006F1FC3 File Offset: 0x006F01C3
		// (set) Token: 0x060338B4 RID: 211124 RVA: 0x006F1FCB File Offset: 0x006F01CB
		public uint HideFlags_C238
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

		// Token: 0x170109B2 RID: 68018
		// (get) Token: 0x060338B5 RID: 211125 RVA: 0x006F1FD4 File Offset: 0x006F01D4
		public Utf8String Name_C238
		{
			get
			{
				return this.m_Name;
			}
		}

		// Token: 0x170109B3 RID: 68019
		// (get) Token: 0x060338B6 RID: 211126 RVA: 0x006F1FDC File Offset: 0x006F01DC

		public INavMeshBuildSettings NavMeshBuildSettings_C238
		{

			[return: NotNull]
			get
			{
				return this.m_NavMeshBuildSettings;
			}
		}

		// Token: 0x170109B4 RID: 68020
		// (get) Token: 0x060338B7 RID: 211127 RVA: 0x006F1FE4 File Offset: 0x006F01E4

		public NavMeshParams NavMeshParams_C238
		{

			get
			{
				return null;
			}
		}

		// Token: 0x170109B5 RID: 68021
		// (get) Token: 0x060338B8 RID: 211128 RVA: 0x006F1FE7 File Offset: 0x006F01E7
		public AccessListBase<INavMeshTileData> NavMeshTiles_C238
		{
			get
			{
				return new AccessList<NavMeshTileData_5_6_0, INavMeshTileData>(this.m_NavMeshTiles);
			}
		}

		// Token: 0x170109B6 RID: 68022
		// (get) Token: 0x060338B9 RID: 211129 RVA: 0x006F1FF4 File Offset: 0x006F01F4
		public AssetList<AutoOffMeshLinkData> OffMeshLinks_C238
		{
			get
			{
				return this.m_OffMeshLinks;
			}
		}

		// Token: 0x170109B7 RID: 68023
		// (get) Token: 0x060338BA RID: 211130 RVA: 0x006F1FFC File Offset: 0x006F01FC

		public Vector3f_3_5_0 Position_C238
		{

			[return: NotNull]
			get
			{
				return this.m_Position;
			}
		}

		// Token: 0x170109B8 RID: 68024
		// (get) Token: 0x060338BB RID: 211131 RVA: 0x006F2004 File Offset: 0x006F0204

		public PPtr_Prefab_2018_3_0 PrefabAsset_C238
		{

			get
			{
				return null;
			}
		}

		// Token: 0x170109B9 RID: 68025
		// (get) Token: 0x060338BC RID: 211132 RVA: 0x006F2007 File Offset: 0x006F0207

		public PPtr_PrefabInstance PrefabInstance_C238
		{

			get
			{
				return null;
			}
		}

		// Token: 0x170109BA RID: 68026
		// (get) Token: 0x060338BD RID: 211133 RVA: 0x006F200A File Offset: 0x006F020A

		public PPtr_Prefab_5_0_0 PrefabInternal_C238
		{

			[return: NotNull]
			get
			{
				return this.m_PrefabInternal;
			}
		}

		// Token: 0x170109BB RID: 68027
		// (get) Token: 0x060338BE RID: 211134 RVA: 0x006F2012 File Offset: 0x006F0212

		public Quaternionf_3_5_0 Rotation_C238
		{

			[return: NotNull]
			get
			{
				return this.m_Rotation;
			}
		}

		// Token: 0x170109BC RID: 68028
		// (get) Token: 0x060338BF RID: 211135 RVA: 0x006F201A File Offset: 0x006F021A

		public AABB_3_5_0 SourceBounds_C238
		{

			[return: NotNull]
			get
			{
				return this.m_SourceBounds;
			}
		}

		// Token: 0x170109BD RID: 68029
		// (get) Token: 0x060338C0 RID: 211136 RVA: 0x006F2022 File Offset: 0x006F0222
		// (set) Token: 0x060338C1 RID: 211137 RVA: 0x006F202A File Offset: 0x006F022A
		public HideFlags HideFlags_C238E
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

		// Token: 0x170109BE RID: 68030
		// (get) Token: 0x060338C2 RID: 211138 RVA: 0x006F2033 File Offset: 0x006F0233
		// (set) Token: 0x060338C3 RID: 211139 RVA: 0x006F2046 File Offset: 0x006F0246

		public IEditorExtension CorrespondingSourceObject_C238P
		{

			get
			{
				return PPtrExtensions.TryGetAsset<IEditorExtension>(this.CorrespondingSourceObject_C238, base.Collection);
			}

			set
			{
				PPtrExtensions.SetAsset<IEditorExtension>(this.CorrespondingSourceObject_C238, base.Collection, value);
			}
		}

		// Token: 0x170109BF RID: 68031
		// (get) Token: 0x060338C4 RID: 211140 RVA: 0x006F205A File Offset: 0x006F025A
		// (set) Token: 0x060338C5 RID: 211141 RVA: 0x006F205D File Offset: 0x006F025D

		public IPrefab PrefabAsset_C238P
		{

			get
			{
				return null;
			}

			set
			{
			}
		}

		// Token: 0x170109C0 RID: 68032
		// (get) Token: 0x060338C6 RID: 211142 RVA: 0x006F205F File Offset: 0x006F025F
		// (set) Token: 0x060338C7 RID: 211143 RVA: 0x006F2062 File Offset: 0x006F0262

		public IPrefabInstance PrefabInstance_C238P
		{

			get
			{
				return null;
			}

			set
			{
			}
		}

		// Token: 0x170109C1 RID: 68033
		// (get) Token: 0x060338C8 RID: 211144 RVA: 0x006F2064 File Offset: 0x006F0264
		// (set) Token: 0x060338C9 RID: 211145 RVA: 0x006F2077 File Offset: 0x006F0277

		public IPrefabInstance PrefabInternal_C238P
		{

			get
			{
				return PPtrExtensions.TryGetAsset<IPrefabInstance>(this.PrefabInternal_C238, base.Collection);
			}

			set
			{
				PPtrExtensions.SetAsset<IPrefabInstance>(this.PrefabInternal_C238, base.Collection, value);
			}
		}

		// Token: 0x170109C2 RID: 68034
		// (get) Token: 0x060338CA RID: 211146 RVA: 0x006F208B File Offset: 0x006F028B
		public override string ClassName
		{
			get
			{
				return "NavMeshData";
			}
		}

		// Token: 0x060338CB RID: 211147 RVA: 0x006F2092 File Offset: 0x006F0292
		public NavMeshData_2017_1_0_GICB2()
			: this(AssetInfo.MakeDummyAssetInfo(238))
		{
		}

		// Token: 0x060338CC RID: 211148 RVA: 0x006F20A4 File Offset: 0x006F02A4
		public NavMeshData_2017_1_0_GICB2(AssetInfo info)
			: base(info)
		{
			this.m_NavMeshTiles = new AssetList<NavMeshTileData_5_6_0>();
			this.m_NavMeshBuildSettings = new NavMeshBuildSettings_5_6_0_f2_GICB2();
			this.m_Heightmaps = new AssetList<HeightmapData_5_0_0>();
			this.m_HeightMeshes = new AssetList<HeightMeshData_2017_1_0>();
			this.m_OffMeshLinks = new AssetList<AutoOffMeshLinkData>();
			this.m_SourceBounds = new AABB_3_5_0();
			this.m_Rotation = new Quaternionf_3_5_0();
			this.m_Position = new Vector3f_3_5_0();
		}

		// Token: 0x060338CD RID: 211149 RVA: 0x006F2110 File Offset: 0x006F0310
		public bool Has_AgentTypeID_C238()
		{
			return true;
		}

		// Token: 0x060338CE RID: 211150 RVA: 0x006F2113 File Offset: 0x006F0313
		public bool Has_NavMeshBuildSettings_C238()
		{
			return true;
		}

		// Token: 0x060338CF RID: 211151 RVA: 0x006F2116 File Offset: 0x006F0316
		public bool Has_NavMeshParams_C238()
		{
			return false;
		}

		// Token: 0x060338D0 RID: 211152 RVA: 0x006F2119 File Offset: 0x006F0319
		public bool Has_Position_C238()
		{
			return true;
		}

		// Token: 0x060338D1 RID: 211153 RVA: 0x006F211C File Offset: 0x006F031C
		public bool Has_PrefabAsset_C238()
		{
			return false;
		}

		// Token: 0x060338D2 RID: 211154 RVA: 0x006F211F File Offset: 0x006F031F
		public bool Has_PrefabInstance_C238()
		{
			return false;
		}

		// Token: 0x060338D3 RID: 211155 RVA: 0x006F2122 File Offset: 0x006F0322
		public bool Has_PrefabInternal_C238()
		{
			return true;
		}

		// Token: 0x060338D4 RID: 211156 RVA: 0x006F2125 File Offset: 0x006F0325
		public bool Has_Rotation_C238()
		{
			return true;
		}

		// Token: 0x060338D5 RID: 211157 RVA: 0x006F2128 File Offset: 0x006F0328
		public bool Has_SourceBounds_C238()
		{
			return true;
		}

		// Token: 0x060338D6 RID: 211158 RVA: 0x006F212C File Offset: 0x006F032C
		public override void ReadRelease(AssetReader reader)
		{
			this.m_Name.ReadRelease(reader);
			this.m_NavMeshTiles.ReadRelease_ArrayAlign_Asset(reader);
			this.m_NavMeshBuildSettings.ReadRelease(reader);
			this.m_Heightmaps.ReadRelease_ArrayAlign_Asset(reader);
			this.m_HeightMeshes.ReadRelease_ArrayAlign_Asset(reader);
			this.m_OffMeshLinks.ReadRelease_ArrayAlign_Asset(reader);
			this.m_SourceBounds.ReadRelease(reader);
			this.m_Rotation.ReadRelease(reader);
			this.m_Position.ReadRelease(reader);
			this.m_AgentTypeID = reader.ReadInt32();
		}

		// Token: 0x060338D7 RID: 211159 RVA: 0x006F21B4 File Offset: 0x006F03B4
		public override void ReadEditor(AssetReader reader)
		{
		}

		// Token: 0x060338D8 RID: 211160 RVA: 0x006F2260 File Offset: 0x006F0460
		public override void WriteRelease(AssetWriter writer)
		{
			this.m_Name.WriteRelease(writer);
			this.m_NavMeshTiles.WriteRelease_ArrayAlign_Asset(writer);
			this.m_NavMeshBuildSettings.WriteRelease(writer);
			this.m_Heightmaps.WriteRelease_ArrayAlign_Asset(writer);
			this.m_HeightMeshes.WriteRelease_ArrayAlign_Asset(writer);
			this.m_OffMeshLinks.WriteRelease_ArrayAlign_Asset(writer);
			this.m_SourceBounds.WriteRelease(writer);
			this.m_Rotation.WriteRelease(writer);
			this.m_Position.WriteRelease(writer);
			this.m_AgentTypeID.WriteRelease_Int32(writer);
		}

		// Token: 0x060338D9 RID: 211161 RVA: 0x006F22E8 File Offset: 0x006F04E8
		public override void WriteEditor(AssetWriter writer)
		{
		}

		// Token: 0x060338DA RID: 211162 RVA: 0x006F2394 File Offset: 0x006F0594
		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 2);
			yamlMappingNode.Add(new YamlScalarNode("m_Name"), this.m_Name.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_NavMeshTiles"), this.m_NavMeshTiles.ExportYamlRelease_Array_NavMeshTileData_5_6_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_NavMeshBuildSettings"), this.m_NavMeshBuildSettings.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Heightmaps"), this.m_Heightmaps.ExportYamlRelease_Array_HeightmapData_5_0_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_HeightMeshes"), this.m_HeightMeshes.ExportYamlRelease_Array_HeightMeshData_2017_1_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_OffMeshLinks"), this.m_OffMeshLinks.ExportYamlRelease_Array_AutoOffMeshLinkData(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SourceBounds"), this.m_SourceBounds.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Rotation"), this.m_Rotation.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Position"), this.m_Position.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AgentTypeID"), this.m_AgentTypeID.ExportYamlRelease_Int32(container));
			return yamlMappingNode;
		}

		// Token: 0x060338DB RID: 211163 RVA: 0x006F24C8 File Offset: 0x006F06C8
		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 2);
			yamlMappingNode.Add(new YamlScalarNode("m_ObjectHideFlags"), this.m_HideFlags.ExportYamlEditor_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabParentObject"), this.m_CorrespondingSourceObject.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabInternal"), this.m_PrefabInternal.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Name"), this.m_Name.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_NavMeshTiles"), this.m_NavMeshTiles.ExportYamlEditor_Array_NavMeshTileData_5_6_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_NavMeshBuildSettings"), this.m_NavMeshBuildSettings.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Heightmaps"), this.m_Heightmaps.ExportYamlEditor_Array_HeightmapData_5_0_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_HeightMeshes"), this.m_HeightMeshes.ExportYamlEditor_Array_HeightMeshData_2017_1_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_OffMeshLinks"), this.m_OffMeshLinks.ExportYamlEditor_Array_AutoOffMeshLinkData(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SourceBounds"), this.m_SourceBounds.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Rotation"), this.m_Rotation.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Position"), this.m_Position.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AgentTypeID"), this.m_AgentTypeID.ExportYamlEditor_Int32(container));
			return yamlMappingNode;
		}

		// Token: 0x060338DC RID: 211164 RVA: 0x006F2650 File Offset: 0x006F0850
		public override void Reset()
		{
			this.m_AgentTypeID = 0;
			this.m_CorrespondingSourceObject.Reset();
			this.m_Heightmaps.Clear();
			this.m_HeightMeshes.Clear();
			this.m_HideFlags = 0U;
			this.m_Name.Reset();
			this.m_NavMeshBuildSettings.Reset();
			this.m_NavMeshTiles.Clear();
			this.m_OffMeshLinks.Clear();
			this.m_Position.Reset();
			this.m_PrefabInternal.Reset();
			this.m_Rotation.Reset();
			this.m_SourceBounds.Reset();
		}

		// Token: 0x060338DD RID: 211165 RVA: 0x006F26E4 File Offset: 0x006F08E4

		// Token: 0x060338DE RID: 211166 RVA: 0x006F26F4 File Offset: 0x006F08F4
		public void CopyValues(INavMeshData source, PPtrConverter converter)
		{
			this.m_AgentTypeID = source.AgentTypeID_C238;
			this.m_CorrespondingSourceObject.CopyValues(source.CorrespondingSourceObject_C238, converter);
			CopyValuesHelper.CopyValues__AssetList_HeightmapData_5_0_0__AccessListBase_IHeightmapData(this.m_Heightmaps, source.Heightmaps_C238, converter);
			CopyValuesHelper.CopyValues__AssetList_HeightMeshData_2017_1_0__AccessListBase_IHeightMeshData(this.m_HeightMeshes, source.HeightMeshes_C238);
			this.m_HideFlags = source.HideFlags_C238;
			this.m_Name.CopyValues(source.Name_C238);
			this.m_NavMeshBuildSettings.CopyValues(source.NavMeshBuildSettings_C238);
			CopyValuesHelper.CopyValues__AssetList_NavMeshTileData_5_6_0__AccessListBase_INavMeshTileData(this.m_NavMeshTiles, source.NavMeshTiles_C238);
			CopyValuesHelper.CopyValues__AssetList_AutoOffMeshLinkData__AssetList_AutoOffMeshLinkData(this.m_OffMeshLinks, source.OffMeshLinks_C238);
			this.m_Position.CopyValues(source.Position_C238);
			this.m_PrefabInternal.CopyValues(source.PrefabInternal_C238, converter);
			this.m_Rotation.CopyValues(source.Rotation_C238);
			this.m_SourceBounds.CopyValues(source.SourceBounds_C238);
		}

		// Token: 0x060338DF RID: 211167 RVA: 0x006F27D7 File Offset: 0x006F09D7
		public void CopyValues(INavMeshData source)
		{
			this.CopyValues(source, new PPtrConverter(source, this));
		}

		// Token: 0x060338E0 RID: 211168 RVA: 0x006F27E8 File Offset: 0x006F09E8

		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			INavMeshData navMeshData = source as INavMeshData;
			if (navMeshData != null)
			{
				this.CopyValues(navMeshData, converter);
				return;
			}
			base.CopyValues(source, converter);
		}

		// Token: 0x060338E1 RID: 211169 RVA: 0x006F2810 File Offset: 0x006F0A10
		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060338E2 RID: 211170 RVA: 0x006F2817 File Offset: 0x006F0A17
		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04013151 RID: 78161
		public AssetList<NavMeshTileData_5_6_0> m_NavMeshTiles;

		// Token: 0x04013152 RID: 78162
		public NavMeshBuildSettings_5_6_0_f2_GICB2 m_NavMeshBuildSettings;

		// Token: 0x04013153 RID: 78163
		public AssetList<HeightmapData_5_0_0> m_Heightmaps;

		// Token: 0x04013154 RID: 78164
		public AssetList<HeightMeshData_2017_1_0> m_HeightMeshes;

		// Token: 0x04013155 RID: 78165
		public AssetList<AutoOffMeshLinkData> m_OffMeshLinks;

		// Token: 0x04013156 RID: 78166
		public AABB_3_5_0 m_SourceBounds;

		// Token: 0x04013157 RID: 78167
		public Quaternionf_3_5_0 m_Rotation;

		// Token: 0x04013158 RID: 78168
		public Vector3f_3_5_0 m_Position;

		// Token: 0x04013159 RID: 78169
		public int m_AgentTypeID;
	}
}
