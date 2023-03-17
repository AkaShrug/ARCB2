using System;
using System.Collections.Generic;
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
using AssetRipper.SourceGenerated.Helpers;
using AssetRipper.SourceGenerated.Subclasses.NavMeshBuildDebugSettings;
using AssetRipper.Yaml;
using AssetRipper.SourceGenerated.Subclasses.NavMeshBuildSettings;

namespace AssetRipper.Import.GICB2.NavMeshData.NavMeshBuildSettings
{
	// Token: 0x0200078F RID: 1935
	public sealed class NavMeshBuildSettings_5_6_0_f2_GICB2 : UnityAssetBase, INavMeshBuildSettings, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IEquatable<INavMeshBuildSettings>, IEquatable<NavMeshBuildSettings_5_6_0_f2_GICB2>
	{
		// Token: 0x170032EB RID: 13035
		// (get) Token: 0x0600CAA4 RID: 51876 RVA: 0x001E3B76 File Offset: 0x001E1D76
		// (set) Token: 0x0600CAA5 RID: 51877 RVA: 0x001E3B79 File Offset: 0x001E1D79
		public bool AccuratePlacement_Boolean
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170032EC RID: 13036
		// (get) Token: 0x0600CAA6 RID: 51878 RVA: 0x001E3B7B File Offset: 0x001E1D7B
		// (set) Token: 0x0600CAA7 RID: 51879 RVA: 0x001E3B83 File Offset: 0x001E1D83
		public int AccuratePlacement_Int32
		{
			get
			{
				return this.m_AccuratePlacement;
			}
			set
			{
				this.m_AccuratePlacement = value;
			}
		}

		// Token: 0x170032ED RID: 13037
		// (get) Token: 0x0600CAA8 RID: 51880 RVA: 0x001E3B8C File Offset: 0x001E1D8C
		// (set) Token: 0x0600CAA9 RID: 51881 RVA: 0x001E3B94 File Offset: 0x001E1D94
		public float AgentClimb
		{
			get
			{
				return this.m_AgentClimb;
			}
			set
			{
				this.m_AgentClimb = value;
			}
		}

		// Token: 0x170032EE RID: 13038
		// (get) Token: 0x0600CAAA RID: 51882 RVA: 0x001E3B9D File Offset: 0x001E1D9D
		// (set) Token: 0x0600CAAB RID: 51883 RVA: 0x001E3BA5 File Offset: 0x001E1DA5
		public float AgentHeight
		{
			get
			{
				return this.m_AgentHeight;
			}
			set
			{
				this.m_AgentHeight = value;
			}
		}

		// Token: 0x170032EF RID: 13039
		// (get) Token: 0x0600CAAC RID: 51884 RVA: 0x001E3BAE File Offset: 0x001E1DAE
		// (set) Token: 0x0600CAAD RID: 51885 RVA: 0x001E3BB6 File Offset: 0x001E1DB6
		public float AgentRadius
		{
			get
			{
				return this.m_AgentRadius;
			}
			set
			{
				this.m_AgentRadius = value;
			}
		}

		// Token: 0x170032F0 RID: 13040
		// (get) Token: 0x0600CAAE RID: 51886 RVA: 0x001E3BBF File Offset: 0x001E1DBF
		// (set) Token: 0x0600CAAF RID: 51887 RVA: 0x001E3BC7 File Offset: 0x001E1DC7
		public float AgentSlope
		{
			get
			{
				return this.m_AgentSlope;
			}
			set
			{
				this.m_AgentSlope = value;
			}
		}

		// Token: 0x170032F1 RID: 13041
		// (get) Token: 0x0600CAB0 RID: 51888 RVA: 0x001E3BD0 File Offset: 0x001E1DD0
		// (set) Token: 0x0600CAB1 RID: 51889 RVA: 0x001E3BD8 File Offset: 0x001E1DD8
		public int AgentTypeID
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

		// Token: 0x170032F2 RID: 13042
		// (get) Token: 0x0600CAB2 RID: 51890 RVA: 0x001E3BE1 File Offset: 0x001E1DE1
		// (set) Token: 0x0600CAB3 RID: 51891 RVA: 0x001E3BE4 File Offset: 0x001E1DE4
		public int BuildHeightMesh
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170032F3 RID: 13043
		// (get) Token: 0x0600CAB4 RID: 51892 RVA: 0x001E3BE6 File Offset: 0x001E1DE6
		// (set) Token: 0x0600CAB5 RID: 51893 RVA: 0x001E3BEE File Offset: 0x001E1DEE
		public float CellSize
		{
			get
			{
				return this.m_CellSize;
			}
			set
			{
				this.m_CellSize = value;
			}
		}

		// Token: 0x170032F4 RID: 13044
		// (get) Token: 0x0600CAB6 RID: 51894 RVA: 0x001E3BF7 File Offset: 0x001E1DF7
		public NavMeshBuildDebugSettings Debug
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032F5 RID: 13045
		// (get) Token: 0x0600CAB7 RID: 51895 RVA: 0x001E3BFA File Offset: 0x001E1DFA
		// (set) Token: 0x0600CAB8 RID: 51896 RVA: 0x001E3C01 File Offset: 0x001E1E01
		public float HeightInaccuracy
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170032F6 RID: 13046
		// (get) Token: 0x0600CAB9 RID: 51897 RVA: 0x001E3C03 File Offset: 0x001E1E03
		// (set) Token: 0x0600CABA RID: 51898 RVA: 0x001E3C06 File Offset: 0x001E1E06
		public int KeepTiles
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170032F7 RID: 13047
		// (get) Token: 0x0600CABB RID: 51899 RVA: 0x001E3C08 File Offset: 0x001E1E08
		// (set) Token: 0x0600CABC RID: 51900 RVA: 0x001E3C10 File Offset: 0x001E1E10
		public float LedgeDropHeight
		{
			get
			{
				return this.m_LedgeDropHeight;
			}
			set
			{
				this.m_LedgeDropHeight = value;
			}
		}

		// Token: 0x170032F8 RID: 13048
		// (get) Token: 0x0600CABD RID: 51901 RVA: 0x001E3C19 File Offset: 0x001E1E19
		// (set) Token: 0x0600CABE RID: 51902 RVA: 0x001E3C1C File Offset: 0x001E1E1C
		public bool ManualCellSize_Boolean
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170032F9 RID: 13049
		// (get) Token: 0x0600CABF RID: 51903 RVA: 0x001E3C1E File Offset: 0x001E1E1E
		// (set) Token: 0x0600CAC0 RID: 51904 RVA: 0x001E3C26 File Offset: 0x001E1E26
		public int ManualCellSize_Int32
		{
			get
			{
				return this.m_ManualCellSize;
			}
			set
			{
				this.m_ManualCellSize = value;
			}
		}

		// Token: 0x170032FA RID: 13050
		// (get) Token: 0x0600CAC1 RID: 51905 RVA: 0x001E3C2F File Offset: 0x001E1E2F
		// (set) Token: 0x0600CAC2 RID: 51906 RVA: 0x001E3C32 File Offset: 0x001E1E32
		public bool ManualTileSize_Boolean
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170032FB RID: 13051
		// (get) Token: 0x0600CAC3 RID: 51907 RVA: 0x001E3C34 File Offset: 0x001E1E34
		// (set) Token: 0x0600CAC4 RID: 51908 RVA: 0x001E3C3C File Offset: 0x001E1E3C
		public int ManualTileSize_Int32
		{
			get
			{
				return this.m_ManualTileSize;
			}
			set
			{
				this.m_ManualTileSize = value;
			}
		}

		// Token: 0x170032FC RID: 13052
		// (get) Token: 0x0600CAC5 RID: 51909 RVA: 0x001E3C45 File Offset: 0x001E1E45
		// (set) Token: 0x0600CAC6 RID: 51910 RVA: 0x001E3C48 File Offset: 0x001E1E48
		public uint MaxJobWorkers
		{
			get
			{
				return 0U;
			}
			set
			{
			}
		}

		// Token: 0x170032FD RID: 13053
		// (get) Token: 0x0600CAC7 RID: 51911 RVA: 0x001E3C4A File Offset: 0x001E1E4A
		// (set) Token: 0x0600CAC8 RID: 51912 RVA: 0x001E3C52 File Offset: 0x001E1E52
		public float MaxJumpAcrossDistance
		{
			get
			{
				return this.m_MaxJumpAcrossDistance;
			}
			set
			{
				this.m_MaxJumpAcrossDistance = value;
			}
		}

		// Token: 0x170032FE RID: 13054
		// (get) Token: 0x0600CAC9 RID: 51913 RVA: 0x001E3C5B File Offset: 0x001E1E5B
		// (set) Token: 0x0600CACA RID: 51914 RVA: 0x001E3C63 File Offset: 0x001E1E63
		public float MinRegionArea
		{
			get
			{
				return this.m_MinRegionArea;
			}
			set
			{
				this.m_MinRegionArea = value;
			}
		}

		// Token: 0x170032FF RID: 13055
		// (get) Token: 0x0600CACB RID: 51915 RVA: 0x001E3C6C File Offset: 0x001E1E6C
		// (set) Token: 0x0600CACC RID: 51916 RVA: 0x001E3C6F File Offset: 0x001E1E6F
		public int PreserveTilesOutsideBounds
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17003300 RID: 13056
		// (get) Token: 0x0600CACD RID: 51917 RVA: 0x001E3C71 File Offset: 0x001E1E71
		// (set) Token: 0x0600CACE RID: 51918 RVA: 0x001E3C79 File Offset: 0x001E1E79
		public int TileSize
		{
			get
			{
				return this.m_TileSize;
			}
			set
			{
				this.m_TileSize = value;
			}
		}

		// Token: 0x17003301 RID: 13057
		// (get) Token: 0x0600CACF RID: 51919 RVA: 0x001E3C82 File Offset: 0x001E1E82
		// (set) Token: 0x0600CAD0 RID: 51920 RVA: 0x001E3C89 File Offset: 0x001E1E89
		public float TileSizeHint
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17003302 RID: 13058
		// (get) Token: 0x0600CAD1 RID: 51921 RVA: 0x001E3C8B File Offset: 0x001E1E8B
		// (set) Token: 0x0600CAD2 RID: 51922 RVA: 0x001E3C92 File Offset: 0x001E1E92
		public float WidthInaccuracy
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x0600CAD3 RID: 51923 RVA: 0x001E3C94 File Offset: 0x001E1E94
		public bool Has_AccuratePlacement_Boolean()
		{
			return false;
		}

		// Token: 0x0600CAD4 RID: 51924 RVA: 0x001E3C97 File Offset: 0x001E1E97
		public bool Has_AccuratePlacement_Int32()
		{
			return true;
		}

		// Token: 0x0600CAD5 RID: 51925 RVA: 0x001E3C9A File Offset: 0x001E1E9A
		public bool Has_AgentTypeID()
		{
			return true;
		}

		// Token: 0x0600CAD6 RID: 51926 RVA: 0x001E3C9D File Offset: 0x001E1E9D
		public bool Has_BuildHeightMesh()
		{
			return false;
		}

		// Token: 0x0600CAD7 RID: 51927 RVA: 0x001E3CA0 File Offset: 0x001E1EA0
		public bool Has_CellSize()
		{
			return true;
		}

		// Token: 0x0600CAD8 RID: 51928 RVA: 0x001E3CA3 File Offset: 0x001E1EA3
		public bool Has_Debug()
		{
			return false;
		}

		// Token: 0x0600CAD9 RID: 51929 RVA: 0x001E3CA6 File Offset: 0x001E1EA6
		public bool Has_HeightInaccuracy()
		{
			return false;
		}

		// Token: 0x0600CADA RID: 51930 RVA: 0x001E3CA9 File Offset: 0x001E1EA9
		public bool Has_KeepTiles()
		{
			return false;
		}

		// Token: 0x0600CADB RID: 51931 RVA: 0x001E3CAC File Offset: 0x001E1EAC
		public bool Has_ManualCellSize_Boolean()
		{
			return false;
		}

		// Token: 0x0600CADC RID: 51932 RVA: 0x001E3CAF File Offset: 0x001E1EAF
		public bool Has_ManualCellSize_Int32()
		{
			return true;
		}

		// Token: 0x0600CADD RID: 51933 RVA: 0x001E3CB2 File Offset: 0x001E1EB2
		public bool Has_ManualTileSize_Boolean()
		{
			return false;
		}

		// Token: 0x0600CADE RID: 51934 RVA: 0x001E3CB5 File Offset: 0x001E1EB5
		public bool Has_ManualTileSize_Int32()
		{
			return true;
		}

		// Token: 0x0600CADF RID: 51935 RVA: 0x001E3CB8 File Offset: 0x001E1EB8
		public bool Has_MaxJobWorkers()
		{
			return false;
		}

		// Token: 0x0600CAE0 RID: 51936 RVA: 0x001E3CBB File Offset: 0x001E1EBB
		public bool Has_PreserveTilesOutsideBounds()
		{
			return false;
		}

		// Token: 0x0600CAE1 RID: 51937 RVA: 0x001E3CBE File Offset: 0x001E1EBE
		public bool Has_TileSize()
		{
			return true;
		}

		// Token: 0x0600CAE2 RID: 51938 RVA: 0x001E3CC1 File Offset: 0x001E1EC1
		public bool Has_TileSizeHint()
		{
			return false;
		}

		// Token: 0x0600CAE3 RID: 51939 RVA: 0x001E3CC4 File Offset: 0x001E1EC4
		public bool Has_WidthInaccuracy()
		{
			return false;
		}

		// Token: 0x0600CAE4 RID: 51940 RVA: 0x001E3CC8 File Offset: 0x001E1EC8

		public override void ReadRelease(AssetReader reader)
		{
			this.m_AgentTypeID = reader.ReadInt32();
			this.m_AgentRadius = reader.ReadSingle();
			this.m_AgentHeight = reader.ReadSingle();
			this.m_AgentSlope = reader.ReadSingle();
			this.m_AgentClimb = reader.ReadSingle();
			this.m_LedgeDropHeight = reader.ReadSingle();
			this.m_MaxJumpAcrossDistance = reader.ReadSingle();
			this.m_MinRegionArea = reader.ReadSingle();
			this.m_ManualCellSize = reader.ReadInt32();
			this.m_CellSize = reader.ReadSingle();
			this.m_ManualTileSize = reader.ReadInt32();
			this.m_TileSize = reader.ReadInt32();
			this.m_AccuratePlacement = reader.ReadInt32();
			var GenerateDetailMap = reader.ReadInt32();
		}

		// Token: 0x0600CAE5 RID: 51941 RVA: 0x001E3D74 File Offset: 0x001E1F74

		public override void ReadEditor(AssetReader reader)
		{
		}

		// Token: 0x0600CAE6 RID: 51942 RVA: 0x001E3E20 File Offset: 0x001E2020

		public override void WriteRelease(AssetWriter writer)
		{
			this.m_AgentTypeID.WriteRelease_Int32(writer);
			this.m_AgentRadius.WriteRelease_Single(writer);
			this.m_AgentHeight.WriteRelease_Single(writer);
			this.m_AgentSlope.WriteRelease_Single(writer);
			this.m_AgentClimb.WriteRelease_Single(writer);
			this.m_LedgeDropHeight.WriteRelease_Single(writer);
			this.m_MaxJumpAcrossDistance.WriteRelease_Single(writer);
			this.m_MinRegionArea.WriteRelease_Single(writer);
			this.m_ManualCellSize.WriteRelease_Int32(writer);
			this.m_CellSize.WriteRelease_Single(writer);
			this.m_ManualTileSize.WriteRelease_Int32(writer);
			this.m_TileSize.WriteRelease_Int32(writer);
			this.m_AccuratePlacement.WriteRelease_Int32(writer);
		}

		// Token: 0x0600CAE7 RID: 51943 RVA: 0x001E3ECC File Offset: 0x001E20CC

		public override void WriteEditor(AssetWriter writer)
		{
		}

		// Token: 0x0600CAE8 RID: 51944 RVA: 0x001E3F78 File Offset: 0x001E2178

		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 2);
			yamlMappingNode.Add(new YamlScalarNode("agentTypeID"), this.m_AgentTypeID.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("agentRadius"), this.m_AgentRadius.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("agentHeight"), this.m_AgentHeight.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("agentSlope"), this.m_AgentSlope.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("agentClimb"), this.m_AgentClimb.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("ledgeDropHeight"), this.m_LedgeDropHeight.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("maxJumpAcrossDistance"), this.m_MaxJumpAcrossDistance.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("minRegionArea"), this.m_MinRegionArea.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("manualCellSize"), this.m_ManualCellSize.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("cellSize"), this.m_CellSize.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("manualTileSize"), this.m_ManualTileSize.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("tileSize"), this.m_TileSize.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("accuratePlacement"), this.m_AccuratePlacement.ExportYamlRelease_Int32(container));
			return yamlMappingNode;
		}

		// Token: 0x0600CAE9 RID: 51945 RVA: 0x001E4100 File Offset: 0x001E2300

		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 2);
			yamlMappingNode.Add(new YamlScalarNode("agentTypeID"), this.m_AgentTypeID.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("agentRadius"), this.m_AgentRadius.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("agentHeight"), this.m_AgentHeight.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("agentSlope"), this.m_AgentSlope.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("agentClimb"), this.m_AgentClimb.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("ledgeDropHeight"), this.m_LedgeDropHeight.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("maxJumpAcrossDistance"), this.m_MaxJumpAcrossDistance.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("minRegionArea"), this.m_MinRegionArea.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("manualCellSize"), this.m_ManualCellSize.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("cellSize"), this.m_CellSize.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("manualTileSize"), this.m_ManualTileSize.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("tileSize"), this.m_TileSize.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("accuratePlacement"), this.m_AccuratePlacement.ExportYamlEditor_Int32(container));
			return yamlMappingNode;
		}

		// Token: 0x0600CAEA RID: 51946 RVA: 0x001E4288 File Offset: 0x001E2488
		public override void Reset()
		{
			this.m_AccuratePlacement = 0;
			this.m_AgentClimb = 0f;
			this.m_AgentHeight = 0f;
			this.m_AgentRadius = 0f;
			this.m_AgentSlope = 0f;
			this.m_AgentTypeID = 0;
			this.m_CellSize = 0f;
			this.m_LedgeDropHeight = 0f;
			this.m_ManualCellSize = 0;
			this.m_ManualTileSize = 0;
			this.m_MaxJumpAcrossDistance = 0f;
			this.m_MinRegionArea = 0f;
			this.m_TileSize = 0;
		}

		// Token: 0x0600CAEB RID: 51947 RVA: 0x001E4310 File Offset: 0x001E2510
		public override IEnumerable<ValueTuple<FieldName, PPtr<IUnityObjectBase>>> FetchDependencies(FieldName parent)
		{
			return Enumerable.Empty<ValueTuple<FieldName, PPtr<IUnityObjectBase>>>();
		}

		// Token: 0x0600CAEC RID: 51948 RVA: 0x001E4318 File Offset: 0x001E2518
		public void CopyValues(INavMeshBuildSettings source)
		{
			if (source != null)
			{
				this.m_AccuratePlacement = source.AccuratePlacement_Int32;
				this.m_AgentClimb = source.AgentClimb;
				this.m_AgentHeight = source.AgentHeight;
				this.m_AgentRadius = source.AgentRadius;
				this.m_AgentSlope = source.AgentSlope;
				this.m_AgentTypeID = source.AgentTypeID;
				this.m_CellSize = source.CellSize;
				this.m_LedgeDropHeight = source.LedgeDropHeight;
				this.m_ManualCellSize = source.ManualCellSize_Int32;
				this.m_ManualTileSize = source.ManualTileSize_Int32;
				this.m_MaxJumpAcrossDistance = source.MaxJumpAcrossDistance;
				this.m_MinRegionArea = source.MinRegionArea;
				this.m_TileSize = source.TileSize;
				return;
			}
			this.Reset();
		}

		// Token: 0x0600CAED RID: 51949 RVA: 0x001E43CE File Offset: 0x001E25CE

		public INavMeshBuildSettings DeepClone()
		{
			NavMeshBuildSettings_5_6_0 navMeshBuildSettings_5_6_0_f = new NavMeshBuildSettings_5_6_0();
			navMeshBuildSettings_5_6_0_f.CopyValues(this);
			return navMeshBuildSettings_5_6_0_f;
		}

		// Token: 0x0600CAEE RID: 51950 RVA: 0x001E43DC File Offset: 0x001E25DC
		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			INavMeshBuildSettings navMeshBuildSettings = source as INavMeshBuildSettings;
			if (navMeshBuildSettings != null)
			{
				this.CopyValues(navMeshBuildSettings);
				return;
			}
			this.Reset();
		}

		// Token: 0x0600CAEF RID: 51951 RVA: 0x001E4404 File Offset: 0x001E2604
		public bool Equals(INavMeshBuildSettings other)
		{
			return other != null && this.AccuratePlacement_Boolean == other.AccuratePlacement_Boolean && this.AccuratePlacement_Int32 == other.AccuratePlacement_Int32 && this.AgentClimb == other.AgentClimb && this.AgentHeight == other.AgentHeight && this.AgentRadius == other.AgentRadius && this.AgentSlope == other.AgentSlope && this.AgentTypeID == other.AgentTypeID && this.BuildHeightMesh == other.BuildHeightMesh && this.CellSize == other.CellSize && EqualityComparer<NavMeshBuildDebugSettings>.Default.Equals(this.Debug, other.Debug) && this.HeightInaccuracy == other.HeightInaccuracy && this.KeepTiles == other.KeepTiles && this.LedgeDropHeight == other.LedgeDropHeight && this.ManualCellSize_Boolean == other.ManualCellSize_Boolean && this.ManualCellSize_Int32 == other.ManualCellSize_Int32 && this.ManualTileSize_Boolean == other.ManualTileSize_Boolean && this.ManualTileSize_Int32 == other.ManualTileSize_Int32 && this.MaxJobWorkers == other.MaxJobWorkers && this.MaxJumpAcrossDistance == other.MaxJumpAcrossDistance && this.MinRegionArea == other.MinRegionArea && this.PreserveTilesOutsideBounds == other.PreserveTilesOutsideBounds && this.TileSize == other.TileSize && this.TileSizeHint == other.TileSizeHint && this.WidthInaccuracy == other.WidthInaccuracy;
		}

		// Token: 0x0600CAF0 RID: 51952 RVA: 0x001E45A4 File Offset: 0x001E27A4
		public bool Equals(NavMeshBuildSettings_5_6_0_f2_GICB2 other)
		{
			return other != null && this.m_AgentTypeID == other.m_AgentTypeID && this.m_AgentRadius == other.m_AgentRadius && this.m_AgentHeight == other.m_AgentHeight && this.m_AgentSlope == other.m_AgentSlope && this.m_AgentClimb == other.m_AgentClimb && this.m_LedgeDropHeight == other.m_LedgeDropHeight && this.m_MaxJumpAcrossDistance == other.m_MaxJumpAcrossDistance && this.m_MinRegionArea == other.m_MinRegionArea && this.m_ManualCellSize == other.m_ManualCellSize && this.m_CellSize == other.m_CellSize && this.m_ManualTileSize == other.m_ManualTileSize && this.m_TileSize == other.m_TileSize && this.m_AccuratePlacement == other.m_AccuratePlacement;
		}

		// Token: 0x0600CAF1 RID: 51953 RVA: 0x001E467C File Offset: 0x001E287C
		public override bool Equals(object other)
		{
			return this.Equals(other as INavMeshBuildSettings);
		}

		// Token: 0x0600CAF2 RID: 51954 RVA: 0x001E468A File Offset: 0x001E288A
		public static bool operator ==(NavMeshBuildSettings_5_6_0_f2_GICB2 left, NavMeshBuildSettings_5_6_0_f2_GICB2 right)
		{
			return EqualityComparer<NavMeshBuildSettings_5_6_0_f2_GICB2>.Default.Equals(left, right);
		}

		// Token: 0x0600CAF3 RID: 51955 RVA: 0x001E4698 File Offset: 0x001E2898
		public static bool operator !=(NavMeshBuildSettings_5_6_0_f2_GICB2 left, NavMeshBuildSettings_5_6_0_f2_GICB2 right)
		{
			return !(left == right);
		}

		// Token: 0x0600CAF4 RID: 51956 RVA: 0x001E46A4 File Offset: 0x001E28A4
		public override int GetHashCode()
		{
			HashCode hashCode = default(HashCode);
			hashCode.Add<bool>(this.AccuratePlacement_Boolean);
			hashCode.Add<int>(this.AccuratePlacement_Int32);
			hashCode.Add<float>(this.AgentClimb);
			hashCode.Add<float>(this.AgentHeight);
			hashCode.Add<float>(this.AgentRadius);
			hashCode.Add<float>(this.AgentSlope);
			hashCode.Add<int>(this.AgentTypeID);
			hashCode.Add<int>(this.BuildHeightMesh);
			hashCode.Add<float>(this.CellSize);
			hashCode.Add<NavMeshBuildDebugSettings>(this.Debug);
			hashCode.Add<float>(this.HeightInaccuracy);
			hashCode.Add<int>(this.KeepTiles);
			hashCode.Add<float>(this.LedgeDropHeight);
			hashCode.Add<bool>(this.ManualCellSize_Boolean);
			hashCode.Add<int>(this.ManualCellSize_Int32);
			hashCode.Add<bool>(this.ManualTileSize_Boolean);
			hashCode.Add<int>(this.ManualTileSize_Int32);
			hashCode.Add<uint>(this.MaxJobWorkers);
			hashCode.Add<float>(this.MaxJumpAcrossDistance);
			hashCode.Add<float>(this.MinRegionArea);
			hashCode.Add<int>(this.PreserveTilesOutsideBounds);
			hashCode.Add<int>(this.TileSize);
			hashCode.Add<float>(this.TileSizeHint);
			hashCode.Add<float>(this.WidthInaccuracy);
			return hashCode.ToHashCode();
		}

		// Token: 0x0600CAF5 RID: 51957 RVA: 0x001E47F8 File Offset: 0x001E29F8

		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600CAF6 RID: 51958 RVA: 0x001E47FF File Offset: 0x001E29FF

		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04001F27 RID: 7975
		public int m_AgentTypeID;

		// Token: 0x04001F28 RID: 7976
		public float m_AgentRadius;

		// Token: 0x04001F29 RID: 7977
		public float m_AgentHeight;

		// Token: 0x04001F2A RID: 7978
		public float m_AgentSlope;

		// Token: 0x04001F2B RID: 7979
		public float m_AgentClimb;

		// Token: 0x04001F2C RID: 7980
		public float m_LedgeDropHeight;

		// Token: 0x04001F2D RID: 7981
		public float m_MaxJumpAcrossDistance;

		// Token: 0x04001F2E RID: 7982
		public float m_MinRegionArea;

		// Token: 0x04001F2F RID: 7983
		public int m_ManualCellSize;

		// Token: 0x04001F30 RID: 7984
		public float m_CellSize;

		// Token: 0x04001F31 RID: 7985
		public int m_ManualTileSize;

		// Token: 0x04001F32 RID: 7986
		public int m_TileSize;

		// Token: 0x04001F33 RID: 7987
		public int m_AccuratePlacement;
	}
}
