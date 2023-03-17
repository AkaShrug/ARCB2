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
using AssetRipper.IClasses.Clip;
using AssetRipper.Yaml;

namespace AssetRipper.IClasses.OffsetPtr_Clip
{
	// Token: 0x02000733 RID: 1843
	public sealed class OffsetPtr_Clip_5_5_0_ACL : UnityAssetBase, IOffsetPtr_Clip_ACL, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IEquatable<IOffsetPtr_Clip_ACL>, IEquatable<OffsetPtr_Clip_5_5_0_ACL>
	{
		// Token: 0x170030D1 RID: 12497
		// (get) Token: 0x0600C13A RID: 49466 RVA: 0x001D0493 File Offset: 0x001CE693
		public IClip_ACL Data
		{
			get
			{
				return this.m_Data;
			}
		}

		// Token: 0x0600C13B RID: 49467 RVA: 0x001D049B File Offset: 0x001CE69B
		public OffsetPtr_Clip_5_5_0_ACL()
		{
			this.m_Data = new Clip_5_5_0_ACL();
		}

		// Token: 0x0600C13C RID: 49468 RVA: 0x001D04AE File Offset: 0x001CE6AE
		public override void ReadRelease(AssetReader reader)
		{
			this.m_Data.ReadRelease(reader);
		}

		// Token: 0x0600C13D RID: 49469 RVA: 0x001D04BC File Offset: 0x001CE6BC
		public override void ReadEditor(AssetReader reader)
		{
		}

		// Token: 0x0600C13E RID: 49470 RVA: 0x001D04BE File Offset: 0x001CE6BE
		public override void WriteRelease(AssetWriter writer)
		{
			this.m_Data.WriteRelease(writer);
		}

		// Token: 0x0600C13F RID: 49471 RVA: 0x001D04CC File Offset: 0x001CE6CC
		public override void WriteEditor(AssetWriter writer)
		{
		}

		// Token: 0x0600C140 RID: 49472 RVA: 0x001D04CE File Offset: 0x001CE6CE
		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 1);
			yamlMappingNode.Add(new YamlScalarNode("data"), this.m_Data.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0600C141 RID: 49473 RVA: 0x001D04F8 File Offset: 0x001CE6F8
		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			return new YamlMappingNode();
		}

		// Token: 0x0600C142 RID: 49474 RVA: 0x001D04FF File Offset: 0x001CE6FF
		public override void Reset()
		{
			this.m_Data.Reset();
		}

		// Token: 0x0600C143 RID: 49475 RVA: 0x001D050C File Offset: 0x001CE70C
		public override IEnumerable<ValueTuple<FieldName, PPtr<IUnityObjectBase>>> FetchDependencies(FieldName parent)
		{
			return Enumerable.Empty<ValueTuple<FieldName, PPtr<IUnityObjectBase>>>();
		}

		// Token: 0x0600C144 RID: 49476 RVA: 0x001D0513 File Offset: 0x001CE713
		public void CopyValues(IOffsetPtr_Clip_ACL source)
		{
			if (source != null)
			{
				this.m_Data.CopyValues(source.Data);
				return;
			}
			this.Reset();
		}

		// Token: 0x0600C145 RID: 49477 RVA: 0x001D0530 File Offset: 0x001CE730
		public IOffsetPtr_Clip_ACL DeepClone()
		{
			OffsetPtr_Clip_5_5_0_ACL offsetPtr_Clip_5_5_0_f = new OffsetPtr_Clip_5_5_0_ACL();
			offsetPtr_Clip_5_5_0_f.CopyValues(this);
			return offsetPtr_Clip_5_5_0_f;
		}

		// Token: 0x0600C146 RID: 49478 RVA: 0x001D0540 File Offset: 0x001CE740

		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			IOffsetPtr_Clip_ACL offsetPtr_Clip = source as IOffsetPtr_Clip_ACL;
			if (offsetPtr_Clip != null)
			{
				this.CopyValues(offsetPtr_Clip);
				return;
			}
			this.Reset();
		}

		// Token: 0x0600C147 RID: 49479 RVA: 0x001D0565 File Offset: 0x001CE765
		public static implicit operator Clip_5_5_0_ACL(OffsetPtr_Clip_5_5_0_ACL value)
		{
			return value.m_Data;
		}

		// Token: 0x0600C148 RID: 49480 RVA: 0x001D056D File Offset: 0x001CE76D

		public bool Equals(IOffsetPtr_Clip_ACL other)
		{
			return other != null && EqualityComparer<IClip_ACL>.Default.Equals(this.Data, other.Data);
		}

		// Token: 0x0600C149 RID: 49481 RVA: 0x001D058D File Offset: 0x001CE78D

		public bool Equals(OffsetPtr_Clip_5_5_0_ACL other)
		{
			return other != null && EqualityComparer<Clip_5_5_0_ACL>.Default.Equals(this.m_Data, other.m_Data);
		}

		// Token: 0x0600C14A RID: 49482 RVA: 0x001D05AD File Offset: 0x001CE7AD

		public override bool Equals(object other)
		{
			return this.Equals(other as IOffsetPtr_Clip_ACL);
		}

		// Token: 0x0600C14B RID: 49483 RVA: 0x001D05BB File Offset: 0x001CE7BB

		public static bool operator ==(OffsetPtr_Clip_5_5_0_ACL left, OffsetPtr_Clip_5_5_0_ACL right)
		{
			return EqualityComparer<OffsetPtr_Clip_5_5_0_ACL>.Default.Equals(left, right);
		}

		// Token: 0x0600C14C RID: 49484 RVA: 0x001D05C9 File Offset: 0x001CE7C9

		public static bool operator !=(OffsetPtr_Clip_5_5_0_ACL left, OffsetPtr_Clip_5_5_0_ACL right)
		{
			return !(left == right);
		}

		// Token: 0x0600C14D RID: 49485 RVA: 0x001D05D8 File Offset: 0x001CE7D8
		public override int GetHashCode()
		{
			HashCode hashCode = default(HashCode);
			hashCode.Add<IClip_ACL>(this.Data);
			return hashCode.ToHashCode();
		}

		// Token: 0x0600C14E RID: 49486 RVA: 0x001D0601 File Offset: 0x001CE801
		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600C14F RID: 49487 RVA: 0x001D0608 File Offset: 0x001CE808
		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04001DEC RID: 7660
		public Clip_5_5_0_ACL m_Data;
	}
}
