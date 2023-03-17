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
using AssetRipper.SourceGenerated.Subclasses.Matrix4x4f;
using AssetRipper.Yaml;
using AssetRipper.SourceGenerated.Subclasses.ShadowSettings;
using AssetRipper.SourceGenerated.Subclasses.Vector3f;

namespace AssetRipper.Import.GICB2.Light.ShadowSettings
{
	// Token: 0x020003B7 RID: 951


	public sealed class ShadowSettings_5_4_0_f3_GICB2 : UnityAssetBase, IShadowSettings, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IEquatable<IShadowSettings>, IEquatable<ShadowSettings_5_4_0_f3>
	{
		// Token: 0x17001BC0 RID: 7104
		// (get) Token: 0x060069E7 RID: 27111 RVA: 0x00114D61 File Offset: 0x00112F61
		// (set) Token: 0x060069E8 RID: 27112 RVA: 0x00114D69 File Offset: 0x00112F69
		public float Bias
		{
			get
			{
				return this.m_Bias;
			}
			set
			{
				this.m_Bias = value;
			}
		}

		// Token: 0x17001BC1 RID: 7105
		// (get) Token: 0x060069E9 RID: 27113 RVA: 0x00114D72 File Offset: 0x00112F72
		public Matrix4x4f CullingMatrixOverride
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BC2 RID: 7106
		// (get) Token: 0x060069EA RID: 27114 RVA: 0x00114D75 File Offset: 0x00112F75
		// (set) Token: 0x060069EB RID: 27115 RVA: 0x00114D7D File Offset: 0x00112F7D
		public int CustomResolution
		{
			get
			{
				return this.m_CustomResolution;
			}
			set
			{
				this.m_CustomResolution = value;
			}
		}

		// Token: 0x17001BC3 RID: 7107
		// (get) Token: 0x060069EC RID: 27116 RVA: 0x00114D86 File Offset: 0x00112F86
		// (set) Token: 0x060069ED RID: 27117 RVA: 0x00114D8E File Offset: 0x00112F8E
		public float NearPlane
		{
			get
			{
				return this.m_NearPlane;
			}
			set
			{
				this.m_NearPlane = value;
			}
		}

		// Token: 0x17001BC4 RID: 7108
		// (get) Token: 0x060069EE RID: 27118 RVA: 0x00114D97 File Offset: 0x00112F97
		// (set) Token: 0x060069EF RID: 27119 RVA: 0x00114D9F File Offset: 0x00112F9F
		public float NormalBias
		{
			get
			{
				return this.m_NormalBias;
			}
			set
			{
				this.m_NormalBias = value;
			}
		}

		// Token: 0x17001BC5 RID: 7109
		// (get) Token: 0x060069F0 RID: 27120 RVA: 0x00114DA8 File Offset: 0x00112FA8
		// (set) Token: 0x060069F1 RID: 27121 RVA: 0x00114DB0 File Offset: 0x00112FB0
		public int Resolution
		{
			get
			{
				return this.m_Resolution;
			}
			set
			{
				this.m_Resolution = value;
			}
		}

		// Token: 0x17001BC6 RID: 7110
		// (get) Token: 0x060069F2 RID: 27122 RVA: 0x00114DB9 File Offset: 0x00112FB9
		// (set) Token: 0x060069F3 RID: 27123 RVA: 0x00114DC0 File Offset: 0x00112FC0
		public float Softness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17001BC7 RID: 7111
		// (get) Token: 0x060069F4 RID: 27124 RVA: 0x00114DC2 File Offset: 0x00112FC2
		// (set) Token: 0x060069F5 RID: 27125 RVA: 0x00114DC9 File Offset: 0x00112FC9
		public float SoftnessFade
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17001BC8 RID: 7112
		// (get) Token: 0x060069F6 RID: 27126 RVA: 0x00114DCB File Offset: 0x00112FCB
		// (set) Token: 0x060069F7 RID: 27127 RVA: 0x00114DD3 File Offset: 0x00112FD3
		public float Strength
		{
			get
			{
				return this.m_Strength;
			}
			set
			{
				this.m_Strength = value;
			}
		}

		// Token: 0x17001BC9 RID: 7113
		// (get) Token: 0x060069F8 RID: 27128 RVA: 0x00114DDC File Offset: 0x00112FDC
		// (set) Token: 0x060069F9 RID: 27129 RVA: 0x00114DE4 File Offset: 0x00112FE4
		public int Type
		{
			get
			{
				return this.m_Type;
			}
			set
			{
				this.m_Type = value;
			}
		}

		// Token: 0x17001BCA RID: 7114
		// (get) Token: 0x060069FA RID: 27130 RVA: 0x00114DED File Offset: 0x00112FED
		// (set) Token: 0x060069FB RID: 27131 RVA: 0x00114DF0 File Offset: 0x00112FF0
		public bool UseCullingMatrixOverride
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x060069FC RID: 27132 RVA: 0x00114DF2 File Offset: 0x00112FF2
		public bool Has_CullingMatrixOverride()
		{
			return false;
		}

		// Token: 0x060069FD RID: 27133 RVA: 0x00114DF5 File Offset: 0x00112FF5
		public bool Has_CustomResolution()
		{
			return true;
		}

		// Token: 0x060069FE RID: 27134 RVA: 0x00114DF8 File Offset: 0x00112FF8
		public bool Has_NearPlane()
		{
			return true;
		}

		// Token: 0x060069FF RID: 27135 RVA: 0x00114DFB File Offset: 0x00112FFB
		public bool Has_NormalBias()
		{
			return true;
		}

		// Token: 0x06006A00 RID: 27136 RVA: 0x00114DFE File Offset: 0x00112FFE
		public bool Has_Softness()
		{
			return false;
		}

		// Token: 0x06006A01 RID: 27137 RVA: 0x00114E01 File Offset: 0x00113001
		public bool Has_SoftnessFade()
		{
			return false;
		}

		// Token: 0x06006A02 RID: 27138 RVA: 0x00114E04 File Offset: 0x00113004
		public bool Has_UseCullingMatrixOverride()
		{
			return false;
		}

		// Token: 0x06006A03 RID: 27139 RVA: 0x00114E08 File Offset: 0x00113008

		public override void ReadRelease(AssetReader reader)
		{
			this.m_Type = reader.ReadInt32();
			this.m_Resolution = reader.ReadInt32();
			this.m_CustomResolution = reader.ReadInt32();
			this.m_Strength = reader.ReadSingle();
			this.m_Bias = reader.ReadSingle();
			this.m_NormalBias = reader.ReadSingle();
			this.m_NearPlane = reader.ReadSingle();
			BoundScale = reader.ReadSingle();
			BoundThresh.ReadRelease(reader);
			UsePerObjectShadow = reader.ReadBoolean();
			reader.AlignStream();
		}

		// Token: 0x06006A04 RID: 27140 RVA: 0x00114E6C File Offset: 0x0011306C

		public override void ReadEditor(AssetReader reader)
		{
		}

		// Token: 0x06006A05 RID: 27141 RVA: 0x00114ED0 File Offset: 0x001130D0

		public override void WriteRelease(AssetWriter writer)
		{
			this.m_Type.WriteRelease_Int32(writer);
			this.m_Resolution.WriteRelease_Int32(writer);
			this.m_CustomResolution.WriteRelease_Int32(writer);
			this.m_Strength.WriteRelease_Single(writer);
			this.m_Bias.WriteRelease_Single(writer);
			this.m_NormalBias.WriteRelease_Single(writer);
			this.m_NearPlane.WriteRelease_Single(writer);
		}

		// Token: 0x06006A06 RID: 27142 RVA: 0x00114F34 File Offset: 0x00113134

		public override void WriteEditor(AssetWriter writer)
		{
		}

		// Token: 0x06006A07 RID: 27143 RVA: 0x00114F98 File Offset: 0x00113198

		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 1);
			yamlMappingNode.Add(new YamlScalarNode("m_Type"), this.m_Type.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Resolution"), this.m_Resolution.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_CustomResolution"), this.m_CustomResolution.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Strength"), this.m_Strength.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Bias"), this.m_Bias.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_NormalBias"), this.m_NormalBias.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_NearPlane"), this.m_NearPlane.ExportYamlRelease_Single(container));
			return yamlMappingNode;
		}

		// Token: 0x06006A08 RID: 27144 RVA: 0x00115078 File Offset: 0x00113278

		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 1);
			yamlMappingNode.Add(new YamlScalarNode("m_Type"), this.m_Type.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Resolution"), this.m_Resolution.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_CustomResolution"), this.m_CustomResolution.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Strength"), this.m_Strength.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Bias"), this.m_Bias.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_NormalBias"), this.m_NormalBias.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_NearPlane"), this.m_NearPlane.ExportYamlEditor_Single(container));
			return yamlMappingNode;
		}

		// Token: 0x06006A09 RID: 27145 RVA: 0x00115158 File Offset: 0x00113358
		public override void Reset()
		{
			this.m_Bias = 0f;
			this.m_CustomResolution = 0;
			this.m_NearPlane = 0f;
			this.m_NormalBias = 0f;
			this.m_Resolution = 0;
			this.m_Strength = 0f;
			this.m_Type = 0;
		}

		// Token: 0x06006A0A RID: 27146 RVA: 0x001151A6 File Offset: 0x001133A6
		public override IEnumerable<ValueTuple<FieldName, PPtr<IUnityObjectBase>>> FetchDependencies(FieldName parent)
		{
			return Enumerable.Empty<ValueTuple<FieldName, PPtr<IUnityObjectBase>>>();
		}

		// Token: 0x06006A0B RID: 27147 RVA: 0x001151B0 File Offset: 0x001133B0
		public void CopyValues(IShadowSettings source)
		{
			if (source != null)
			{
				this.m_Bias = source.Bias;
				this.m_CustomResolution = source.CustomResolution;
				this.m_NearPlane = source.NearPlane;
				this.m_NormalBias = source.NormalBias;
				this.m_Resolution = source.Resolution;
				this.m_Strength = source.Strength;
				this.m_Type = source.Type;
				return;
			}
			this.Reset();
		}

		// Token: 0x06006A0C RID: 27148 RVA: 0x0011521B File Offset: 0x0011341B

		public IShadowSettings DeepClone()
		{
			ShadowSettings_5_4_0_f3 shadowSettings_5_4_0_f = new ShadowSettings_5_4_0_f3();
			shadowSettings_5_4_0_f.CopyValues(this);
			return shadowSettings_5_4_0_f;
		}

		// Token: 0x06006A0D RID: 27149 RVA: 0x0011522C File Offset: 0x0011342C
		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			IShadowSettings shadowSettings = source as IShadowSettings;
			if (shadowSettings != null)
			{
				this.CopyValues(shadowSettings);
				return;
			}
			this.Reset();
		}

		// Token: 0x06006A0E RID: 27150 RVA: 0x00115254 File Offset: 0x00113454
		public bool Equals(IShadowSettings other)
		{
			return other != null && this.Bias == other.Bias && EqualityComparer<Matrix4x4f>.Default.Equals(this.CullingMatrixOverride, other.CullingMatrixOverride) && this.CustomResolution == other.CustomResolution && this.NearPlane == other.NearPlane && this.NormalBias == other.NormalBias && this.Resolution == other.Resolution && this.Softness == other.Softness && this.SoftnessFade == other.SoftnessFade && this.Strength == other.Strength && this.Type == other.Type && this.UseCullingMatrixOverride == other.UseCullingMatrixOverride;
		}

		// Token: 0x06006A0F RID: 27151 RVA: 0x00115314 File Offset: 0x00113514
		public bool Equals(ShadowSettings_5_4_0_f3 other)
		{
			return other != null && this.m_Type == other.m_Type && this.m_Resolution == other.m_Resolution && this.m_CustomResolution == other.m_CustomResolution && this.m_Strength == other.m_Strength && this.m_Bias == other.m_Bias && this.m_NormalBias == other.m_NormalBias && this.m_NearPlane == other.m_NearPlane;
		}

		// Token: 0x06006A10 RID: 27152 RVA: 0x00115389 File Offset: 0x00113589
		public override bool Equals(object other)
		{
			return this.Equals(other as IShadowSettings);
		}

		// Token: 0x06006A11 RID: 27153 RVA: 0x00115397 File Offset: 0x00113597
		public static bool operator ==(ShadowSettings_5_4_0_f3_GICB2 left, ShadowSettings_5_4_0_f3_GICB2 right)
		{
			return EqualityComparer<ShadowSettings_5_4_0_f3_GICB2>.Default.Equals(left, right);
		}

		// Token: 0x06006A12 RID: 27154 RVA: 0x001153A5 File Offset: 0x001135A5
		public static bool operator !=(ShadowSettings_5_4_0_f3_GICB2 left, ShadowSettings_5_4_0_f3_GICB2 right)
		{
			return !(left == right);
		}

		// Token: 0x06006A13 RID: 27155 RVA: 0x001153B4 File Offset: 0x001135B4
		public override int GetHashCode()
		{
			HashCode hashCode = default(HashCode);
			hashCode.Add<float>(this.Bias);
			hashCode.Add<Matrix4x4f>(this.CullingMatrixOverride);
			hashCode.Add<int>(this.CustomResolution);
			hashCode.Add<float>(this.NearPlane);
			hashCode.Add<float>(this.NormalBias);
			hashCode.Add<int>(this.Resolution);
			hashCode.Add<float>(this.Softness);
			hashCode.Add<float>(this.SoftnessFade);
			hashCode.Add<float>(this.Strength);
			hashCode.Add<int>(this.Type);
			hashCode.Add<bool>(this.UseCullingMatrixOverride);
			return hashCode.ToHashCode();
		}

		// Token: 0x06006A14 RID: 27156 RVA: 0x0011545F File Offset: 0x0011365F

		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06006A15 RID: 27157 RVA: 0x00115466 File Offset: 0x00113666

		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04001252 RID: 4690
		public int m_Type;

		// Token: 0x04001253 RID: 4691
		public int m_Resolution;

		// Token: 0x04001254 RID: 4692
		public int m_CustomResolution;

		// Token: 0x04001255 RID: 4693
		public float m_Strength;

		// Token: 0x04001256 RID: 4694
		public float m_Bias;

		// Token: 0x04001257 RID: 4695
		public float m_NormalBias;

		// Token: 0x04001258 RID: 4696
		public float m_NearPlane;

		public float BoundScale { get; set; }
		public bool UsePerObjectShadow { get; set; }
		public Vector3f_3_5_0 BoundThresh = new();
	}
}
