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
using AssetRipper.SourceGenerated.Subclasses.AnimationCurve_Single;
using AssetRipper.SourceGenerated.Subclasses.ColorRGBA32;
using AssetRipper.SourceGenerated.Subclasses.Gradient;
using AssetRipper.SourceGenerated.Subclasses.Vector2f;
using AssetRipper.Yaml;
using AssetRipper.SourceGenerated.Subclasses.LineParameters;
using AssetRipper.SourceGenerated.Subclasses.Vector3f;

namespace AssetRipper.Import.GICB2.TrailRenderer.LineParameters
{
	// Token: 0x0200082B RID: 2091


	public sealed class LineParameters_2017_1_0_GICB2 : UnityAssetBase, ILineParameters, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IEquatable<ILineParameters>, IEquatable<LineParameters_2017_1_0>
	{
		// Token: 0x17003758 RID: 14168
		// (get) Token: 0x0600DA68 RID: 55912 RVA: 0x0020A79E File Offset: 0x0020899E
		// (set) Token: 0x0600DA69 RID: 55913 RVA: 0x0020A7A6 File Offset: 0x002089A6
		public int Alignment
		{
			get
			{
				return this.m_Alignment;
			}
			set
			{
				this.m_Alignment = value;
			}
		}

		// Token: 0x17003759 RID: 14169
		// (get) Token: 0x0600DA6A RID: 55914 RVA: 0x0020A7AF File Offset: 0x002089AF
		public IGradient ColorGradient
		{
			[return: NotNull]
			get
			{
				return this.m_ColorGradient;
			}
		}

		// Token: 0x1700375A RID: 14170
		// (get) Token: 0x0600DA6B RID: 55915 RVA: 0x0020A7B7 File Offset: 0x002089B7
		public ColorRGBA32 EndColor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700375B RID: 14171
		// (get) Token: 0x0600DA6C RID: 55916 RVA: 0x0020A7BA File Offset: 0x002089BA
		// (set) Token: 0x0600DA6D RID: 55917 RVA: 0x0020A7C1 File Offset: 0x002089C1
		public float EndWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700375C RID: 14172
		// (get) Token: 0x0600DA6E RID: 55918 RVA: 0x0020A7C3 File Offset: 0x002089C3
		// (set) Token: 0x0600DA6F RID: 55919 RVA: 0x0020A7C6 File Offset: 0x002089C6
		public bool GenerateLightingData
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700375D RID: 14173
		// (get) Token: 0x0600DA70 RID: 55920 RVA: 0x0020A7C8 File Offset: 0x002089C8
		// (set) Token: 0x0600DA71 RID: 55921 RVA: 0x0020A7D0 File Offset: 0x002089D0
		public int NumCapVertices
		{
			get
			{
				return this.m_NumCapVertices;
			}
			set
			{
				this.m_NumCapVertices = value;
			}
		}

		// Token: 0x1700375E RID: 14174
		// (get) Token: 0x0600DA72 RID: 55922 RVA: 0x0020A7D9 File Offset: 0x002089D9
		// (set) Token: 0x0600DA73 RID: 55923 RVA: 0x0020A7E1 File Offset: 0x002089E1
		public int NumCornerVertices
		{
			get
			{
				return this.m_NumCornerVertices;
			}
			set
			{
				this.m_NumCornerVertices = value;
			}
		}

		// Token: 0x1700375F RID: 14175
		// (get) Token: 0x0600DA74 RID: 55924 RVA: 0x0020A7EA File Offset: 0x002089EA
		// (set) Token: 0x0600DA75 RID: 55925 RVA: 0x0020A7F1 File Offset: 0x002089F1
		public float ShadowBias
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17003760 RID: 14176
		// (get) Token: 0x0600DA76 RID: 55926 RVA: 0x0020A7F3 File Offset: 0x002089F3
		public ColorRGBA32 StartColor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003761 RID: 14177
		// (get) Token: 0x0600DA77 RID: 55927 RVA: 0x0020A7F6 File Offset: 0x002089F6
		// (set) Token: 0x0600DA78 RID: 55928 RVA: 0x0020A7FD File Offset: 0x002089FD
		public float StartWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17003762 RID: 14178
		// (get) Token: 0x0600DA79 RID: 55929 RVA: 0x0020A7FF File Offset: 0x002089FF
		// (set) Token: 0x0600DA7A RID: 55930 RVA: 0x0020A807 File Offset: 0x00208A07
		public int TextureMode
		{
			get
			{
				return this.m_TextureMode;
			}
			set
			{
				this.m_TextureMode = value;
			}
		}

		// Token: 0x17003763 RID: 14179
		// (get) Token: 0x0600DA7B RID: 55931 RVA: 0x0020A810 File Offset: 0x00208A10
		public Vector2f_3_5_0 TextureScale
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003764 RID: 14180
		// (get) Token: 0x0600DA7C RID: 55932 RVA: 0x0020A813 File Offset: 0x00208A13
		public IAnimationCurve_Single WidthCurve
		{
			[return: NotNull]
			get
			{
				return this.m_WidthCurve;
			}
		}

		// Token: 0x17003765 RID: 14181
		// (get) Token: 0x0600DA7D RID: 55933 RVA: 0x0020A81B File Offset: 0x00208A1B
		// (set) Token: 0x0600DA7E RID: 55934 RVA: 0x0020A823 File Offset: 0x00208A23
		public float WidthMultiplier
		{
			get
			{
				return this.m_WidthMultiplier;
			}
			set
			{
				this.m_WidthMultiplier = value;
			}
		}

		// Token: 0x0600DA7F RID: 55935 RVA: 0x0020A82C File Offset: 0x00208A2C
		public LineParameters_2017_1_0_GICB2()
		{
			this.m_WidthCurve = new AnimationCurve_Single_2017_1_0();
			this.m_ColorGradient = new Gradient_5_6_0();
		}

		// Token: 0x0600DA80 RID: 55936 RVA: 0x0020A84A File Offset: 0x00208A4A
		public bool Has_Alignment()
		{
			return true;
		}

		// Token: 0x0600DA81 RID: 55937 RVA: 0x0020A84D File Offset: 0x00208A4D
		public bool Has_ColorGradient()
		{
			return true;
		}

		// Token: 0x0600DA82 RID: 55938 RVA: 0x0020A850 File Offset: 0x00208A50
		public bool Has_EndColor()
		{
			return false;
		}

		// Token: 0x0600DA83 RID: 55939 RVA: 0x0020A853 File Offset: 0x00208A53
		public bool Has_EndWidth()
		{
			return false;
		}

		// Token: 0x0600DA84 RID: 55940 RVA: 0x0020A856 File Offset: 0x00208A56
		public bool Has_GenerateLightingData()
		{
			return false;
		}

		// Token: 0x0600DA85 RID: 55941 RVA: 0x0020A859 File Offset: 0x00208A59
		public bool Has_NumCapVertices()
		{
			return true;
		}

		// Token: 0x0600DA86 RID: 55942 RVA: 0x0020A85C File Offset: 0x00208A5C
		public bool Has_NumCornerVertices()
		{
			return true;
		}

		// Token: 0x0600DA87 RID: 55943 RVA: 0x0020A85F File Offset: 0x00208A5F
		public bool Has_ShadowBias()
		{
			return false;
		}

		// Token: 0x0600DA88 RID: 55944 RVA: 0x0020A862 File Offset: 0x00208A62
		public bool Has_StartColor()
		{
			return false;
		}

		// Token: 0x0600DA89 RID: 55945 RVA: 0x0020A865 File Offset: 0x00208A65
		public bool Has_StartWidth()
		{
			return false;
		}

		// Token: 0x0600DA8A RID: 55946 RVA: 0x0020A868 File Offset: 0x00208A68
		public bool Has_TextureMode()
		{
			return true;
		}

		// Token: 0x0600DA8B RID: 55947 RVA: 0x0020A86B File Offset: 0x00208A6B
		public bool Has_TextureScale()
		{
			return false;
		}

		// Token: 0x0600DA8C RID: 55948 RVA: 0x0020A86E File Offset: 0x00208A6E
		public bool Has_WidthCurve()
		{
			return true;
		}

		// Token: 0x0600DA8D RID: 55949 RVA: 0x0020A871 File Offset: 0x00208A71
		public bool Has_WidthMultiplier()
		{
			return true;
		}

		// Token: 0x0600DA8E RID: 55950 RVA: 0x0020A874 File Offset: 0x00208A74

		public override void ReadRelease(AssetReader reader)
		{
			this.m_WidthMultiplier = reader.ReadSingle();
			this.m_WidthCurve.ReadRelease(reader);
			this.m_ColorGradient.ReadRelease(reader);
			this.m_NumCornerVertices = reader.ReadInt32();
			this.m_NumCapVertices = reader.ReadInt32();
			this.m_Alignment = reader.ReadInt32();
			this.m_TextureMode = reader.ReadInt32();

			// GICB2
			var generateLightingData = reader.ReadBoolean();
			reader.AlignStream();
			var UseOffset = reader.ReadBoolean();
			reader.AlignStream();
			var PlaneNormal = reader.ReadAsset<Vector3f_3_5_0>();
			var OffsetWidth = reader.ReadSingle();
		}

		// Token: 0x0600DA8F RID: 55951 RVA: 0x0020A8D8 File Offset: 0x00208AD8

		public override void ReadEditor(AssetReader reader)
		{
		}

		// Token: 0x0600DA90 RID: 55952 RVA: 0x0020A93C File Offset: 0x00208B3C

		public override void WriteRelease(AssetWriter writer)
		{
			this.m_WidthMultiplier.WriteRelease_Single(writer);
			this.m_WidthCurve.WriteRelease(writer);
			this.m_ColorGradient.WriteRelease(writer);
			this.m_NumCornerVertices.WriteRelease_Int32(writer);
			this.m_NumCapVertices.WriteRelease_Int32(writer);
			this.m_Alignment.WriteRelease_Int32(writer);
			this.m_TextureMode.WriteRelease_Int32(writer);
		}

		// Token: 0x0600DA91 RID: 55953 RVA: 0x0020A9A0 File Offset: 0x00208BA0

		public override void WriteEditor(AssetWriter writer)
		{
		}

		// Token: 0x0600DA92 RID: 55954 RVA: 0x0020AA04 File Offset: 0x00208C04

		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 2);
			yamlMappingNode.Add(new YamlScalarNode("widthMultiplier"), this.m_WidthMultiplier.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("widthCurve"), this.m_WidthCurve.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("colorGradient"), this.m_ColorGradient.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("numCornerVertices"), this.m_NumCornerVertices.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("numCapVertices"), this.m_NumCapVertices.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("alignment"), this.m_Alignment.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("textureMode"), this.m_TextureMode.ExportYamlRelease_Int32(container));
			return yamlMappingNode;
		}

		// Token: 0x0600DA93 RID: 55955 RVA: 0x0020AAE4 File Offset: 0x00208CE4

		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 2);
			yamlMappingNode.Add(new YamlScalarNode("widthMultiplier"), this.m_WidthMultiplier.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("widthCurve"), this.m_WidthCurve.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("colorGradient"), this.m_ColorGradient.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("numCornerVertices"), this.m_NumCornerVertices.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("numCapVertices"), this.m_NumCapVertices.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("alignment"), this.m_Alignment.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("textureMode"), this.m_TextureMode.ExportYamlEditor_Int32(container));
			return yamlMappingNode;
		}

		// Token: 0x0600DA94 RID: 55956 RVA: 0x0020ABC1 File Offset: 0x00208DC1
		public override void Reset()
		{
			this.m_Alignment = 0;
			this.m_ColorGradient.Reset();
			this.m_NumCapVertices = 0;
			this.m_NumCornerVertices = 0;
			this.m_TextureMode = 0;
			this.m_WidthCurve.Reset();
			this.m_WidthMultiplier = 0f;
		}

		// Token: 0x0600DA95 RID: 55957 RVA: 0x0020AC00 File Offset: 0x00208E00
		public override IEnumerable<ValueTuple<FieldName, PPtr<IUnityObjectBase>>> FetchDependencies(FieldName parent)
		{
			return Enumerable.Empty<ValueTuple<FieldName, PPtr<IUnityObjectBase>>>();
		}

		// Token: 0x0600DA96 RID: 55958 RVA: 0x0020AC08 File Offset: 0x00208E08
		public void CopyValues(ILineParameters source)
		{
			if (source != null)
			{
				this.m_Alignment = source.Alignment;
				this.m_ColorGradient.CopyValues(source.ColorGradient);
				this.m_NumCapVertices = source.NumCapVertices;
				this.m_NumCornerVertices = source.NumCornerVertices;
				this.m_TextureMode = source.TextureMode;
				this.m_WidthCurve.CopyValues(source.WidthCurve);
				this.m_WidthMultiplier = source.WidthMultiplier;
				return;
			}
			this.Reset();
		}

		// Token: 0x0600DA97 RID: 55959 RVA: 0x0020AC7D File Offset: 0x00208E7D

		public ILineParameters DeepClone()
		{
			LineParameters_2017_1_0 lineParameters_2017_1_0_b = new LineParameters_2017_1_0();
			lineParameters_2017_1_0_b.CopyValues(this);
			return lineParameters_2017_1_0_b;
		}

		// Token: 0x0600DA98 RID: 55960 RVA: 0x0020AC8C File Offset: 0x00208E8C
		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			ILineParameters lineParameters = source as ILineParameters;
			if (lineParameters != null)
			{
				this.CopyValues(lineParameters);
				return;
			}
			this.Reset();
		}

		// Token: 0x0600DA99 RID: 55961 RVA: 0x0020ACB4 File Offset: 0x00208EB4
		public bool Equals(ILineParameters other)
		{
			return other != null && this.Alignment == other.Alignment && EqualityComparer<IGradient>.Default.Equals(this.ColorGradient, other.ColorGradient) && EqualityComparer<ColorRGBA32>.Default.Equals(this.EndColor, other.EndColor) && this.EndWidth == other.EndWidth && this.GenerateLightingData == other.GenerateLightingData && this.NumCapVertices == other.NumCapVertices && this.NumCornerVertices == other.NumCornerVertices && this.ShadowBias == other.ShadowBias && EqualityComparer<ColorRGBA32>.Default.Equals(this.StartColor, other.StartColor) && this.StartWidth == other.StartWidth && this.TextureMode == other.TextureMode && EqualityComparer<Vector2f_3_5_0>.Default.Equals(this.TextureScale, other.TextureScale) && EqualityComparer<IAnimationCurve_Single>.Default.Equals(this.WidthCurve, other.WidthCurve) && this.WidthMultiplier == other.WidthMultiplier;
		}

		// Token: 0x0600DA9A RID: 55962 RVA: 0x0020ADD8 File Offset: 0x00208FD8
		public bool Equals(LineParameters_2017_1_0 other)
		{
			return other != null && this.m_WidthMultiplier == other.m_WidthMultiplier && EqualityComparer<AnimationCurve_Single_2017_1_0>.Default.Equals(this.m_WidthCurve, other.m_WidthCurve) && EqualityComparer<Gradient_5_6_0>.Default.Equals(this.m_ColorGradient, other.m_ColorGradient) && this.m_NumCornerVertices == other.m_NumCornerVertices && this.m_NumCapVertices == other.m_NumCapVertices && this.m_Alignment == other.m_Alignment && this.m_TextureMode == other.m_TextureMode;
		}

		// Token: 0x0600DA9B RID: 55963 RVA: 0x0020AE61 File Offset: 0x00209061
		public override bool Equals(object other)
		{
			return this.Equals(other as ILineParameters);
		}

		// Token: 0x0600DA9C RID: 55964 RVA: 0x0020AE6F File Offset: 0x0020906F
		public static bool operator ==(LineParameters_2017_1_0_GICB2 left, LineParameters_2017_1_0_GICB2 right)
		{
			return EqualityComparer<LineParameters_2017_1_0_GICB2>.Default.Equals(left, right);
		}

		// Token: 0x0600DA9D RID: 55965 RVA: 0x0020AE7D File Offset: 0x0020907D
		public static bool operator !=(LineParameters_2017_1_0_GICB2 left, LineParameters_2017_1_0_GICB2 right)
		{
			return !(left == right);
		}

		// Token: 0x0600DA9E RID: 55966 RVA: 0x0020AE8C File Offset: 0x0020908C
		public override int GetHashCode()
		{
			HashCode hashCode = default(HashCode);
			hashCode.Add<int>(this.Alignment);
			hashCode.Add<IGradient>(this.ColorGradient);
			hashCode.Add<ColorRGBA32>(this.EndColor);
			hashCode.Add<float>(this.EndWidth);
			hashCode.Add<bool>(this.GenerateLightingData);
			hashCode.Add<int>(this.NumCapVertices);
			hashCode.Add<int>(this.NumCornerVertices);
			hashCode.Add<float>(this.ShadowBias);
			hashCode.Add<ColorRGBA32>(this.StartColor);
			hashCode.Add<float>(this.StartWidth);
			hashCode.Add<int>(this.TextureMode);
			hashCode.Add<Vector2f_3_5_0>(this.TextureScale);
			hashCode.Add<IAnimationCurve_Single>(this.WidthCurve);
			hashCode.Add<float>(this.WidthMultiplier);
			return hashCode.ToHashCode();
		}

		// Token: 0x0600DA9F RID: 55967 RVA: 0x0020AF5E File Offset: 0x0020915E

		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600DAA0 RID: 55968 RVA: 0x0020AF65 File Offset: 0x00209165

		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x040021E1 RID: 8673
		public float m_WidthMultiplier;

		// Token: 0x040021E2 RID: 8674

		public AnimationCurve_Single_2017_1_0 m_WidthCurve;

		// Token: 0x040021E3 RID: 8675

		public Gradient_5_6_0 m_ColorGradient;

		// Token: 0x040021E4 RID: 8676
		public int m_NumCornerVertices;

		// Token: 0x040021E5 RID: 8677
		public int m_NumCapVertices;

		// Token: 0x040021E6 RID: 8678
		public int m_Alignment;

		// Token: 0x040021E7 RID: 8679
		public int m_TextureMode;
	}
}
