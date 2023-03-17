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
using AssetRipper.SourceGenerated.Helpers;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Texture2D;
using AssetRipper.SourceGenerated.Subclasses.Vector2f;
using AssetRipper.SourceGenerated.Subclasses.Vector4f;
using AssetRipper.Yaml;
using AssetRipper.SourceGenerated.Subclasses.SplatPrototype;

namespace AssetRipper.Import.GICB2.TerrainData.SplatPrototype
{
	// Token: 0x02000337 RID: 823


	public sealed class SplatPrototype_5_0_1_GICB2 : UnityAssetBase, ISplatPrototype, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IEquatable<ISplatPrototype>, IEquatable<SplatPrototype_5_0_1_GICB2>
	{
		// Token: 0x170015CF RID: 5583
		// (get) Token: 0x06005625 RID: 22053 RVA: 0x000E47E4 File Offset: 0x000E29E4

		public IPPtr_Texture2D NormalMap
		{

			[return: NotNull]
			get
			{
				return this.m_NormalMap;
			}
		}

		// Token: 0x170015D0 RID: 5584
		// (get) Token: 0x06005626 RID: 22054 RVA: 0x000E47EC File Offset: 0x000E29EC
		// (set) Token: 0x06005627 RID: 22055 RVA: 0x000E47F4 File Offset: 0x000E29F4
		public float Smoothness
		{
			get
			{
				return this.m_Smoothness;
			}
			set
			{
				this.m_Smoothness = value;
			}
		}

		// Token: 0x170015D1 RID: 5585
		// (get) Token: 0x06005628 RID: 22056 RVA: 0x000E47FD File Offset: 0x000E29FD

		public Vector4f_3_5_0 SpecularMetallic
		{

			[return: NotNull]
			get
			{
				return this.m_SpecularMetallic;
			}
		}

		// Token: 0x170015D2 RID: 5586
		// (get) Token: 0x06005629 RID: 22057 RVA: 0x000E4805 File Offset: 0x000E2A05
		public IPPtr_Texture2D Texture
		{
			get
			{
				return this.m_Texture;
			}
		}

		// Token: 0x170015D3 RID: 5587
		// (get) Token: 0x0600562A RID: 22058 RVA: 0x000E480D File Offset: 0x000E2A0D
		public IVector2f TileOffset
		{
			get
			{
				return this.m_TileOffset;
			}
		}

		// Token: 0x170015D4 RID: 5588
		// (get) Token: 0x0600562B RID: 22059 RVA: 0x000E4815 File Offset: 0x000E2A15
		public IVector2f TileSize
		{
			get
			{
				return this.m_TileSize;
			}
		}

		// Token: 0x0600562C RID: 22060 RVA: 0x000E481D File Offset: 0x000E2A1D
		public SplatPrototype_5_0_1_GICB2()
		{
			this.m_Texture = new PPtr_Texture2D_5_0_0();
			this.m_NormalMap = new PPtr_Texture2D_5_0_0();
			this.m_TileSize = new Vector2f_3_5_0();
			this.m_TileOffset = new Vector2f_3_5_0();
			this.m_SpecularMetallic = new Vector4f_3_5_0();
			this.TintColor = new Vector4f_3_5_0();
		}

		// Token: 0x0600562D RID: 22061 RVA: 0x000E485C File Offset: 0x000E2A5C
		public bool Has_NormalMap()
		{
			return true;
		}

		// Token: 0x0600562E RID: 22062 RVA: 0x000E485F File Offset: 0x000E2A5F
		public bool Has_Smoothness()
		{
			return true;
		}

		// Token: 0x0600562F RID: 22063 RVA: 0x000E4862 File Offset: 0x000E2A62
		public bool Has_SpecularMetallic()
		{
			return true;
		}

		// Token: 0x06005630 RID: 22064 RVA: 0x000E4868 File Offset: 0x000E2A68
		public override void ReadRelease(AssetReader reader)
		{
			this.m_Texture.ReadRelease(reader);
			this.m_NormalMap.ReadRelease(reader);
			this.m_TileSize.ReadRelease(reader);
			this.m_TileOffset.ReadRelease(reader);
			this.m_SpecularMetallic.ReadRelease(reader);
			this.m_Smoothness = reader.ReadSingle();
			var brightness = reader.ReadSingle();
			TintColor.Read(reader);
			var farTileSizeScale = reader.ReadSingle();
			var walkRunSurfaceType = reader.ReadInt32();
			var climbSurfaceType = reader.ReadInt32();
		}

		// Token: 0x06005631 RID: 22065 RVA: 0x000E48C0 File Offset: 0x000E2AC0
		public override void ReadEditor(AssetReader reader)
		{
		}

		// Token: 0x06005632 RID: 22066 RVA: 0x000E4918 File Offset: 0x000E2B18
		public override void WriteRelease(AssetWriter writer)
		{
			this.m_Texture.WriteRelease(writer);
			this.m_NormalMap.WriteRelease(writer);
			this.m_TileSize.WriteRelease(writer);
			this.m_TileOffset.WriteRelease(writer);
			this.m_SpecularMetallic.WriteRelease(writer);
			this.m_Smoothness.WriteRelease_Single(writer);
		}

		// Token: 0x06005633 RID: 22067 RVA: 0x000E4970 File Offset: 0x000E2B70
		public override void WriteEditor(AssetWriter writer)
		{
		}

		// Token: 0x06005634 RID: 22068 RVA: 0x000E49C8 File Offset: 0x000E2BC8
		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 1);
			yamlMappingNode.Add(new YamlScalarNode("texture"), this.m_Texture.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("normalMap"), this.m_NormalMap.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("tileSize"), this.m_TileSize.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("tileOffset"), this.m_TileOffset.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("specularMetallic"), this.m_SpecularMetallic.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("smoothness"), this.m_Smoothness.ExportYamlRelease_Single(container));
			return yamlMappingNode;
		}

		// Token: 0x06005635 RID: 22069 RVA: 0x000E4A8C File Offset: 0x000E2C8C
		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 1);
			yamlMappingNode.Add(new YamlScalarNode("texture"), this.m_Texture.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("normalMap"), this.m_NormalMap.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("tileSize"), this.m_TileSize.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("tileOffset"), this.m_TileOffset.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("specularMetallic"), this.m_SpecularMetallic.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("smoothness"), this.m_Smoothness.ExportYamlEditor_Single(container));
			return yamlMappingNode;
		}

		// Token: 0x06005636 RID: 22070 RVA: 0x000E4B50 File Offset: 0x000E2D50
		public override void Reset()
		{
			this.m_NormalMap.Reset();
			this.m_Smoothness = 0f;
			this.m_SpecularMetallic.Reset();
			this.m_Texture.Reset();
			this.m_TileOffset.Reset();
			this.m_TileSize.Reset();
		}

		// Token: 0x06005637 RID: 22071 RVA: 0x000E4B9F File Offset: 0x000E2D9F

		//public override IEnumerable<ValueTuple<FieldName, PPtr<IUnityObjectBase>>> FetchDependencies(FieldName parent)
		//{
		//	return Enumerable.Empty<ValueTuple<FieldName, PPtr<IUnityObjectBase>>>().Append_SplatPrototype_5_0_1(parent, this);
		//}

		// Token: 0x06005638 RID: 22072 RVA: 0x000E4BB0 File Offset: 0x000E2DB0

		public void CopyValues(ISplatPrototype source, PPtrConverter converter)
		{
			if (source != null)
			{
				this.m_NormalMap.CopyValues(source.NormalMap, converter);
				this.m_Smoothness = source.Smoothness;
				this.m_SpecularMetallic.CopyValues(source.SpecularMetallic);
				this.m_Texture.CopyValues(source.Texture, converter);
				this.m_TileOffset.CopyValues(source.TileOffset);
				this.m_TileSize.CopyValues(source.TileSize);
				return;
			}
			this.Reset();
		}

		// Token: 0x06005639 RID: 22073 RVA: 0x000E4C2A File Offset: 0x000E2E2A
		public ISplatPrototype DeepClone(PPtrConverter converter)
		{
			SplatPrototype_5_0_1_GICB2 splatPrototype_5_0_1_f = new SplatPrototype_5_0_1_GICB2();
			splatPrototype_5_0_1_f.CopyValues(this, converter);
			return splatPrototype_5_0_1_f;
		}

		// Token: 0x0600563A RID: 22074 RVA: 0x000E4C3C File Offset: 0x000E2E3C

		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			ISplatPrototype splatPrototype = source as ISplatPrototype;
			if (splatPrototype != null)
			{
				this.CopyValues(splatPrototype, converter);
				return;
			}
			this.Reset();
		}

		// Token: 0x0600563B RID: 22075 RVA: 0x000E4C64 File Offset: 0x000E2E64

		public bool Equals(ISplatPrototype other)
		{
			return other != null && EqualityComparer<IPPtr_Texture2D>.Default.Equals(this.NormalMap, other.NormalMap) && this.Smoothness == other.Smoothness && EqualityComparer<Vector4f_3_5_0>.Default.Equals(this.SpecularMetallic, other.SpecularMetallic) && EqualityComparer<IPPtr_Texture2D>.Default.Equals(this.Texture, other.Texture) && EqualityComparer<IVector2f>.Default.Equals(this.TileOffset, other.TileOffset) && EqualityComparer<IVector2f>.Default.Equals(this.TileSize, other.TileSize);
		}

		// Token: 0x0600563C RID: 22076 RVA: 0x000E4D00 File Offset: 0x000E2F00

		public bool Equals(SplatPrototype_5_0_1_GICB2 other)
		{
			return other != null && EqualityComparer<PPtr_Texture2D_5_0_0>.Default.Equals(this.m_Texture, other.m_Texture) && EqualityComparer<PPtr_Texture2D_5_0_0>.Default.Equals(this.m_NormalMap, other.m_NormalMap) && EqualityComparer<Vector2f_3_5_0>.Default.Equals(this.m_TileSize, other.m_TileSize) && EqualityComparer<Vector2f_3_5_0>.Default.Equals(this.m_TileOffset, other.m_TileOffset) && EqualityComparer<Vector4f_3_5_0>.Default.Equals(this.m_SpecularMetallic, other.m_SpecularMetallic) && this.m_Smoothness == other.m_Smoothness;
		}

		// Token: 0x0600563D RID: 22077 RVA: 0x000E4D9C File Offset: 0x000E2F9C

		public override bool Equals(object other)
		{
			return this.Equals(other as ISplatPrototype);
		}

		// Token: 0x0600563E RID: 22078 RVA: 0x000E4DAA File Offset: 0x000E2FAA

		public static bool operator ==(SplatPrototype_5_0_1_GICB2 left, SplatPrototype_5_0_1_GICB2 right)
		{
			return EqualityComparer<SplatPrototype_5_0_1_GICB2>.Default.Equals(left, right);
		}

		// Token: 0x0600563F RID: 22079 RVA: 0x000E4DB8 File Offset: 0x000E2FB8

		public static bool operator !=(SplatPrototype_5_0_1_GICB2 left, SplatPrototype_5_0_1_GICB2 right)
		{
			return !(left == right);
		}

		// Token: 0x06005640 RID: 22080 RVA: 0x000E4DC4 File Offset: 0x000E2FC4
		public override int GetHashCode()
		{
			HashCode hashCode = default(HashCode);
			hashCode.Add<IPPtr_Texture2D>(this.NormalMap);
			hashCode.Add<float>(this.Smoothness);
			hashCode.Add<Vector4f_3_5_0>(this.SpecularMetallic);
			hashCode.Add<IPPtr_Texture2D>(this.Texture);
			hashCode.Add<IVector2f>(this.TileOffset);
			hashCode.Add<IVector2f>(this.TileSize);
			return hashCode.ToHashCode();
		}

		// Token: 0x06005641 RID: 22081 RVA: 0x000E4E2E File Offset: 0x000E302E
		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06005642 RID: 22082 RVA: 0x000E4E35 File Offset: 0x000E3035
		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04000F2C RID: 3884
		public PPtr_Texture2D_5_0_0 m_Texture;

		// Token: 0x04000F2D RID: 3885
		public PPtr_Texture2D_5_0_0 m_NormalMap;

		// Token: 0x04000F2E RID: 3886
		public Vector2f_3_5_0 m_TileSize;

		// Token: 0x04000F2F RID: 3887
		public Vector2f_3_5_0 m_TileOffset;

		// Token: 0x04000F30 RID: 3888
		public Vector4f_3_5_0 m_SpecularMetallic;

		public Vector4f_3_5_0 TintColor;

		// Token: 0x04000F31 RID: 3889
		public float m_Smoothness;
	}
}
