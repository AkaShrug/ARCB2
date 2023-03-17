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
using AssetRipper.SourceGenerated.Helpers;
using AssetRipper.SourceGenerated.Subclasses.PPtr_TerrainLayer;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Texture2D;
using AssetRipper.SourceGenerated.Subclasses.SplatPrototype;
using AssetRipper.Yaml;
using AssetRipper.SourceGenerated.Subclasses.SplatDatabase;
using AssetRipper.Import.GICB2.TerrainData.SplatPrototype;

namespace AssetRipper.Import.GICB2.TerrainData.SplatDatabase
{
	// Token: 0x0200033A RID: 826


	public sealed class SplatDatabase_2017_1_0_GICB2 : UnityAssetBase, ISplatDatabase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IEquatable<ISplatDatabase>, IEquatable<SplatDatabase_2017_1_0_GICB2>
	{
		// Token: 0x170015DD RID: 5597
		// (get) Token: 0x06005658 RID: 22104 RVA: 0x000E4ECE File Offset: 0x000E30CE
		// (set) Token: 0x06005659 RID: 22105 RVA: 0x000E4ED6 File Offset: 0x000E30D6
		public int AlphamapResolution
		{
			get
			{
				return this.m_AlphamapResolution;
			}
			set
			{
				this.m_AlphamapResolution = value;
			}
		}

		// Token: 0x170015DE RID: 5598
		// (get) Token: 0x0600565A RID: 22106 RVA: 0x000E4EDF File Offset: 0x000E30DF
		public AccessListBase<IPPtr_Texture2D> AlphaTextures
		{
			get
			{
				return new AccessList<PPtr_Texture2D_5_0_0, IPPtr_Texture2D>(this.m_AlphaTextures);
			}
		}

		// Token: 0x170015DF RID: 5599
		// (get) Token: 0x0600565B RID: 22107 RVA: 0x000E4EEC File Offset: 0x000E30EC
		// (set) Token: 0x0600565C RID: 22108 RVA: 0x000E4EF4 File Offset: 0x000E30F4
		public int BaseMapResolution
		{
			get
			{
				return this.m_BaseMapResolution;
			}
			set
			{
				this.m_BaseMapResolution = value;
			}
		}

		// Token: 0x170015E0 RID: 5600
		// (get) Token: 0x0600565D RID: 22109 RVA: 0x000E4EFD File Offset: 0x000E30FD
		// (set) Token: 0x0600565E RID: 22110 RVA: 0x000E4F05 File Offset: 0x000E3105
		public int ColorSpace
		{
			get
			{
				return this.m_ColorSpace;
			}
			set
			{
				this.m_ColorSpace = value;
			}
		}

		// Token: 0x170015E1 RID: 5601
		// (get) Token: 0x0600565F RID: 22111 RVA: 0x000E4F0E File Offset: 0x000E310E
		// (set) Token: 0x06005660 RID: 22112 RVA: 0x000E4F16 File Offset: 0x000E3116
		public bool MaterialRequiresMetallic
		{
			get
			{
				return this.m_MaterialRequiresMetallic;
			}
			set
			{
				this.m_MaterialRequiresMetallic = value;
			}
		}

		// Token: 0x170015E2 RID: 5602
		// (get) Token: 0x06005661 RID: 22113 RVA: 0x000E4F1F File Offset: 0x000E311F
		// (set) Token: 0x06005662 RID: 22114 RVA: 0x000E4F27 File Offset: 0x000E3127
		public bool MaterialRequiresSmoothness
		{
			get
			{
				return this.m_MaterialRequiresSmoothness;
			}
			set
			{
				this.m_MaterialRequiresSmoothness = value;
			}
		}

		// Token: 0x170015E3 RID: 5603
		// (get) Token: 0x06005663 RID: 22115 RVA: 0x000E4F30 File Offset: 0x000E3130

		public AccessListBase<ISplatPrototype> Splats
		{

			[return: NotNull]
			get
			{
				return new AccessList<SplatPrototype_5_0_1_GICB2, ISplatPrototype>(this.m_Splats);
			}
		}

		// Token: 0x170015E4 RID: 5604
		// (get) Token: 0x06005664 RID: 22116 RVA: 0x000E4F3D File Offset: 0x000E313D

		public AssetList<PPtr_TerrainLayer> TerrainLayers
		{

			get
			{
				return null;
			}
		}

		// Token: 0x06005665 RID: 22117 RVA: 0x000E4F40 File Offset: 0x000E3140
		public SplatDatabase_2017_1_0_GICB2()
		{
			this.m_Splats = new AssetList<SplatPrototype_5_0_1_GICB2>();
			this.m_AlphaTextures = new AssetList<PPtr_Texture2D_5_0_0>();
		}

		// Token: 0x06005666 RID: 22118 RVA: 0x000E4F5E File Offset: 0x000E315E
		public bool Has_ColorSpace()
		{
			return true;
		}

		// Token: 0x06005667 RID: 22119 RVA: 0x000E4F61 File Offset: 0x000E3161
		public bool Has_MaterialRequiresMetallic()
		{
			return true;
		}

		// Token: 0x06005668 RID: 22120 RVA: 0x000E4F64 File Offset: 0x000E3164
		public bool Has_MaterialRequiresSmoothness()
		{
			return true;
		}

		// Token: 0x06005669 RID: 22121 RVA: 0x000E4F67 File Offset: 0x000E3167
		public bool Has_Splats()
		{
			return true;
		}

		// Token: 0x0600566A RID: 22122 RVA: 0x000E4F6A File Offset: 0x000E316A
		public bool Has_TerrainLayers()
		{
			return false;
		}

		// Token: 0x0600566B RID: 22123 RVA: 0x000E4F70 File Offset: 0x000E3170
		public override void ReadRelease(AssetReader reader)
		{
			this.m_Splats.ReadRelease_ArrayAlign_Asset(reader);
			this.m_AlphaTextures.ReadRelease_ArrayAlign_Asset(reader);
			this.m_AlphamapResolution = reader.ReadInt32();
			this.m_BaseMapResolution = reader.ReadInt32();
			this.m_ColorSpace = reader.ReadInt32();
			this.m_MaterialRequiresMetallic = reader.ReadBoolean();
			this.m_MaterialRequiresSmoothness = reader.ReadRelease_BooleanAlign();

			var MaskMap = reader.ReadAsset<PPtr_Texture2D_5_0_0>();
			var BaseMap = reader.ReadAsset<PPtr_Texture2D_5_0_0>();
			var SpecularMetallicMap = reader.ReadAsset<PPtr_Texture2D_5_0_0>();
			var HaveControlMapAndBaseMapBaked = reader.ReadBoolean();
			reader.AlignStream();
			var SplatIndexWithMaxWeightTable = reader.ReadByteArray();
			reader.AlignStream();
		}

		// Token: 0x0600566C RID: 22124 RVA: 0x000E4FD4 File Offset: 0x000E31D4
		public override void ReadEditor(AssetReader reader)
		{
		}

		// Token: 0x0600566D RID: 22125 RVA: 0x000E5038 File Offset: 0x000E3238
		public override void WriteRelease(AssetWriter writer)
		{
			this.m_Splats.WriteRelease_ArrayAlign_Asset(writer);
			this.m_AlphaTextures.WriteRelease_ArrayAlign_Asset(writer);
			this.m_AlphamapResolution.WriteRelease_Int32(writer);
			this.m_BaseMapResolution.WriteRelease_Int32(writer);
			this.m_ColorSpace.WriteRelease_Int32(writer);
			this.m_MaterialRequiresMetallic.WriteRelease_Boolean(writer);
			this.m_MaterialRequiresSmoothness.WriteRelease_BooleanAlign(writer);
		}

		// Token: 0x0600566E RID: 22126 RVA: 0x000E509C File Offset: 0x000E329C
		public override void WriteEditor(AssetWriter writer)
		{
		}

		// Token: 0x0600566F RID: 22127 RVA: 0x000E5100 File Offset: 0x000E3300
		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 1);
			yamlMappingNode.Add(new YamlScalarNode("m_Splats"), this.m_Splats.ExportYamlRelease_Array_SplatPrototype_5_0_1_GICB2(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AlphaTextures"), this.m_AlphaTextures.ExportYamlRelease_Array_PPtr_Texture2D_5_0_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AlphamapResolution"), this.m_AlphamapResolution.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_BaseMapResolution"), this.m_BaseMapResolution.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ColorSpace"), this.m_ColorSpace.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MaterialRequiresMetallic"), this.m_MaterialRequiresMetallic.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MaterialRequiresSmoothness"), this.m_MaterialRequiresSmoothness.ExportYamlRelease_Boolean(container));
			return yamlMappingNode;
		}

		// Token: 0x06005670 RID: 22128 RVA: 0x000E51E0 File Offset: 0x000E33E0
		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 1);
			yamlMappingNode.Add(new YamlScalarNode("m_Splats"), this.m_Splats.ExportYamlEditor_Array_SplatPrototype_5_0_1_GICB2(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AlphaTextures"), this.m_AlphaTextures.ExportYamlEditor_Array_PPtr_Texture2D_5_0_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AlphamapResolution"), this.m_AlphamapResolution.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_BaseMapResolution"), this.m_BaseMapResolution.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ColorSpace"), this.m_ColorSpace.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MaterialRequiresMetallic"), this.m_MaterialRequiresMetallic.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MaterialRequiresSmoothness"), this.m_MaterialRequiresSmoothness.ExportYamlEditor_Boolean(container));
			return yamlMappingNode;
		}


		// Token: 0x06005671 RID: 22129 RVA: 0x000E52BD File Offset: 0x000E34BD
		public override void Reset()
		{
			this.m_AlphamapResolution = 0;
			this.m_AlphaTextures.Clear();
			this.m_BaseMapResolution = 0;
			this.m_ColorSpace = 0;
			this.m_MaterialRequiresMetallic = false;
			this.m_MaterialRequiresSmoothness = false;
			this.m_Splats.Clear();
		}

		// Token: 0x06005672 RID: 22130 RVA: 0x000E52F8 File Offset: 0x000E34F8

		//public override IEnumerable<ValueTuple<FieldName, PPtr<IUnityObjectBase>>> FetchDependencies(FieldName parent)
		//{
		//	return Enumerable.Empty<ValueTuple<FieldName, PPtr<IUnityObjectBase>>>().Append_SplatDatabase_2017_1_0(parent, this);
		//}

		// Token: 0x06005673 RID: 22131 RVA: 0x000E5308 File Offset: 0x000E3508

		public void CopyValues(ISplatDatabase source, PPtrConverter converter)
		{
			if (source != null)
			{
				this.m_AlphamapResolution = source.AlphamapResolution;
				CopyValuesHelper.CopyValues__AssetList_PPtr_Texture2D_5_0_0__AccessListBase_IPPtr_Texture2D(this.m_AlphaTextures, source.AlphaTextures, converter);
				this.m_BaseMapResolution = source.BaseMapResolution;
				this.m_ColorSpace = source.ColorSpace;
				this.m_MaterialRequiresMetallic = source.MaterialRequiresMetallic;
				this.m_MaterialRequiresSmoothness = source.MaterialRequiresSmoothness;
				CopyValuesHelper.CopyValues__AssetList_SplatPrototype_5_0_1_GICB2__AccessListBase_ISplatPrototype(this.m_Splats, source.Splats, converter);
				return;
			}
			this.Reset();
		}

		// Token: 0x06005674 RID: 22132 RVA: 0x000E537F File Offset: 0x000E357F
		public ISplatDatabase DeepClone(PPtrConverter converter)
		{
			SplatDatabase_2017_1_0 splatDatabase_2017_1_0_b = new SplatDatabase_2017_1_0();
			splatDatabase_2017_1_0_b.CopyValues(this, converter);
			return splatDatabase_2017_1_0_b;
		}

		// Token: 0x06005675 RID: 22133 RVA: 0x000E5390 File Offset: 0x000E3590

		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			ISplatDatabase splatDatabase = source as ISplatDatabase;
			if (splatDatabase != null)
			{
				this.CopyValues(splatDatabase, converter);
				return;
			}
			this.Reset();
		}

		// Token: 0x06005676 RID: 22134 RVA: 0x000E53B8 File Offset: 0x000E35B8

		public bool Equals(ISplatDatabase other)
		{
			return other != null && this.AlphamapResolution == other.AlphamapResolution && EqualityComparer<AccessListBase<IPPtr_Texture2D>>.Default.Equals(this.AlphaTextures, other.AlphaTextures) && this.BaseMapResolution == other.BaseMapResolution && this.ColorSpace == other.ColorSpace && this.MaterialRequiresMetallic == other.MaterialRequiresMetallic && this.MaterialRequiresSmoothness == other.MaterialRequiresSmoothness && EqualityComparer<AccessListBase<ISplatPrototype>>.Default.Equals(this.Splats, other.Splats) && EqualityComparer<AssetList<PPtr_TerrainLayer>>.Default.Equals(this.TerrainLayers, other.TerrainLayers);
		}

		// Token: 0x06005677 RID: 22135 RVA: 0x000E5460 File Offset: 0x000E3660

		public bool Equals(SplatDatabase_2017_1_0_GICB2 other)
		{
			return other != null && EqualityComparer<AssetList<SplatPrototype_5_0_1_GICB2>>.Default.Equals(this.m_Splats, other.m_Splats) && EqualityComparer<AssetList<PPtr_Texture2D_5_0_0>>.Default.Equals(this.m_AlphaTextures, other.m_AlphaTextures) && this.m_AlphamapResolution == other.m_AlphamapResolution && this.m_BaseMapResolution == other.m_BaseMapResolution && this.m_ColorSpace == other.m_ColorSpace && this.m_MaterialRequiresMetallic == other.m_MaterialRequiresMetallic && this.m_MaterialRequiresSmoothness == other.m_MaterialRequiresSmoothness;
		}

		// Token: 0x06005678 RID: 22136 RVA: 0x000E54E9 File Offset: 0x000E36E9

		public override bool Equals(object other)
		{
			return this.Equals(other as ISplatDatabase);
		}

		// Token: 0x06005679 RID: 22137 RVA: 0x000E54F7 File Offset: 0x000E36F7

		public static bool operator ==(SplatDatabase_2017_1_0_GICB2 left, SplatDatabase_2017_1_0_GICB2 right)
		{
			return EqualityComparer<SplatDatabase_2017_1_0_GICB2>.Default.Equals(left, right);
		}

		// Token: 0x0600567A RID: 22138 RVA: 0x000E5505 File Offset: 0x000E3705

		public static bool operator !=(SplatDatabase_2017_1_0_GICB2 left, SplatDatabase_2017_1_0_GICB2 right)
		{
			return !(left == right);
		}

		// Token: 0x0600567B RID: 22139 RVA: 0x000E5514 File Offset: 0x000E3714
		public override int GetHashCode()
		{
			HashCode hashCode = default(HashCode);
			hashCode.Add<int>(this.AlphamapResolution);
			hashCode.Add<AccessListBase<IPPtr_Texture2D>>(this.AlphaTextures);
			hashCode.Add<int>(this.BaseMapResolution);
			hashCode.Add<int>(this.ColorSpace);
			hashCode.Add<bool>(this.MaterialRequiresMetallic);
			hashCode.Add<bool>(this.MaterialRequiresSmoothness);
			hashCode.Add<AccessListBase<ISplatPrototype>>(this.Splats);
			hashCode.Add<AssetList<PPtr_TerrainLayer>>(this.TerrainLayers);
			return hashCode.ToHashCode();
		}

		// Token: 0x0600567C RID: 22140 RVA: 0x000E5598 File Offset: 0x000E3798
		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600567D RID: 22141 RVA: 0x000E559F File Offset: 0x000E379F
		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04000F32 RID: 3890
		public AssetList<SplatPrototype_5_0_1_GICB2> m_Splats;

		// Token: 0x04000F33 RID: 3891
		public AssetList<PPtr_Texture2D_5_0_0> m_AlphaTextures;

		// Token: 0x04000F34 RID: 3892
		public int m_AlphamapResolution;

		// Token: 0x04000F35 RID: 3893
		public int m_BaseMapResolution;

		// Token: 0x04000F36 RID: 3894
		public int m_ColorSpace;

		// Token: 0x04000F37 RID: 3895
		public bool m_MaterialRequiresMetallic;

		// Token: 0x04000F38 RID: 3896
		public bool m_MaterialRequiresSmoothness;
	}
}
