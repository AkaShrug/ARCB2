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
using AssetRipper.SourceGenerated.Subclasses.ConstantClip;
using AssetRipper.SourceGenerated.Subclasses.DenseClip;
using AssetRipper.SourceGenerated.Subclasses.OffsetPtr_ValueArrayConstant;
using AssetRipper.SourceGenerated.Subclasses.StreamedClip;
using AssetRipper.Yaml;

namespace AssetRipper.IClasses.Clip
{
	// Token: 0x02000B0B RID: 2827
	public sealed class Clip_5_5_0_ACL : UnityAssetBase, IClip_ACL, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IEquatable<IClip_ACL>, IEquatable<Clip_5_5_0_ACL>
	{
		// Token: 0x170053B7 RID: 21431
		// (get) Token: 0x06014117 RID: 82199 RVA: 0x002F2F5A File Offset: 0x002F115A

		public IOffsetPtr_ValueArrayConstant Binding
		{

			[return: NotNull]
			get
			{
				return this.m_Binding;
			}
		}

		// Token: 0x170053B8 RID: 21432
		// (get) Token: 0x06014118 RID: 82200 RVA: 0x002F2F62 File Offset: 0x002F1162

		public ConstantClip ConstantClip
		{

			[return: NotNull]
			get
			{
				return this.m_ConstantClip;
			}
		}

		// Token: 0x170053B9 RID: 21433
		// (get) Token: 0x06014119 RID: 82201 RVA: 0x002F2F6A File Offset: 0x002F116A
		public DenseClip DenseClip
		{
			get
			{
				return this.m_DenseClip;
			}
		}

		// Token: 0x170053BA RID: 21434
		// (get) Token: 0x0601411A RID: 82202 RVA: 0x002F2F72 File Offset: 0x002F1172
		public StreamedClip StreamedClip
		{
			get
			{
				return this.m_StreamedClip;
			}
		}

		public AclClip AclClip
		{
			get
			{
				return this.m_AclClip;
			}
		}

		// Token: 0x0601411B RID: 82203 RVA: 0x002F2F7A File Offset: 0x002F117A
		public Clip_5_5_0_ACL()
		{
			this.m_StreamedClip = new StreamedClip();
			this.m_DenseClip = new DenseClip();
			this.m_ConstantClip = new ConstantClip();
			this.m_Binding = new OffsetPtr_ValueArrayConstant_5_5_0();
			this.m_AclClip = new AclClip();
		}

		// Token: 0x0601411C RID: 82204 RVA: 0x002F2FAE File Offset: 0x002F11AE
		public bool Has_Binding()
		{
			return true;
		}

		// Token: 0x0601411D RID: 82205 RVA: 0x002F2FB1 File Offset: 0x002F11B1
		public bool Has_ConstantClip()
		{
			return true;
		}

		// Token: 0x0601411E RID: 82206 RVA: 0x002F2FB4 File Offset: 0x002F11B4
		public override void ReadRelease(AssetReader reader)
		{
			this.m_StreamedClip.ReadRelease(reader);
			this.m_DenseClip.ReadRelease(reader);
			this.m_ConstantClip.ReadRelease(reader);
			this.m_AclClip.ReadRelease(reader);
			this.m_Binding.ReadRelease(reader);
		}

		// Token: 0x0601411F RID: 82207 RVA: 0x002F2FE6 File Offset: 0x002F11E6
		public override void ReadEditor(AssetReader reader)
		{
		}

		// Token: 0x06014120 RID: 82208 RVA: 0x002F2FE8 File Offset: 0x002F11E8
		public override void WriteRelease(AssetWriter writer)
		{
			this.m_StreamedClip.WriteRelease(writer);
			this.m_DenseClip.WriteRelease(writer);
			this.m_ConstantClip.WriteRelease(writer);
			this.m_Binding.WriteRelease(writer);
		}

		// Token: 0x06014121 RID: 82209 RVA: 0x002F301A File Offset: 0x002F121A
		public override void WriteEditor(AssetWriter writer)
		{
		}

		// Token: 0x06014122 RID: 82210 RVA: 0x002F301C File Offset: 0x002F121C
		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 1);
			yamlMappingNode.Add(new YamlScalarNode("m_StreamedClip"), this.m_StreamedClip.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_DenseClip"), this.m_DenseClip.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ConstantClip"), this.m_ConstantClip.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Binding"), this.m_Binding.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06014123 RID: 82211 RVA: 0x002F30A5 File Offset: 0x002F12A5
		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			return new YamlMappingNode();
		}

		// Token: 0x06014124 RID: 82212 RVA: 0x002F30AC File Offset: 0x002F12AC
		public override void Reset()
		{
			this.m_Binding.Reset();
			this.m_ConstantClip.Reset();
			this.m_DenseClip.Reset();
			this.m_StreamedClip.Reset();
		}

		// Token: 0x06014125 RID: 82213 RVA: 0x002F30DA File Offset: 0x002F12DA

		public override IEnumerable<ValueTuple<FieldName, PPtr<IUnityObjectBase>>> FetchDependencies(FieldName parent)
		{
			return Enumerable.Empty<ValueTuple<FieldName, PPtr<IUnityObjectBase>>>();
		}

		// Token: 0x06014126 RID: 82214 RVA: 0x002F30E4 File Offset: 0x002F12E4

		public void CopyValues(IClip_ACL source)
		{
			if (source != null)
			{
				this.m_Binding.CopyValues(source.Binding);
				this.m_ConstantClip.CopyValues(source.ConstantClip);
				this.m_DenseClip.CopyValues(source.DenseClip);
				this.m_StreamedClip.CopyValues(source.StreamedClip);
				return;
			}
			this.Reset();
		}

		// Token: 0x06014127 RID: 82215 RVA: 0x002F313F File Offset: 0x002F133F
		public IClip_ACL DeepClone()
		{
			Clip_5_5_0_ACL clip_5_5_0_f = new Clip_5_5_0_ACL();
			clip_5_5_0_f.CopyValues(this);
			return clip_5_5_0_f;
		}

		// Token: 0x06014128 RID: 82216 RVA: 0x002F3150 File Offset: 0x002F1350

		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			IClip_ACL clip = source as IClip_ACL;
			if (clip != null)
			{
				this.CopyValues(clip);
				return;
			}
			this.Reset();
		}

		// Token: 0x06014129 RID: 82217 RVA: 0x002F3178 File Offset: 0x002F1378

		public bool Equals(IClip_ACL other)
		{
			return other != null && EqualityComparer<IOffsetPtr_ValueArrayConstant>.Default.Equals(this.Binding, other.Binding) && EqualityComparer<ConstantClip>.Default.Equals(this.ConstantClip, other.ConstantClip) && EqualityComparer<DenseClip>.Default.Equals(this.DenseClip, other.DenseClip) && EqualityComparer<StreamedClip>.Default.Equals(this.StreamedClip, other.StreamedClip);
		}

		// Token: 0x0601412A RID: 82218 RVA: 0x002F31EC File Offset: 0x002F13EC

		public bool Equals(Clip_5_5_0_ACL other)
		{
			return other != null && EqualityComparer<StreamedClip>.Default.Equals(this.m_StreamedClip, other.m_StreamedClip) && EqualityComparer<DenseClip>.Default.Equals(this.m_DenseClip, other.m_DenseClip) && EqualityComparer<ConstantClip>.Default.Equals(this.m_ConstantClip, other.m_ConstantClip) && EqualityComparer<OffsetPtr_ValueArrayConstant_5_5_0>.Default.Equals(this.m_Binding, other.m_Binding);
		}

		// Token: 0x0601412B RID: 82219 RVA: 0x002F325F File Offset: 0x002F145F

		public override bool Equals(object other)
		{
			return this.Equals(other as IClip_ACL);
		}

		// Token: 0x0601412C RID: 82220 RVA: 0x002F326D File Offset: 0x002F146D

		public static bool operator ==(Clip_5_5_0_ACL left, Clip_5_5_0_ACL right)
		{
			return EqualityComparer<Clip_5_5_0_ACL>.Default.Equals(left, right);
		}

		// Token: 0x0601412D RID: 82221 RVA: 0x002F327B File Offset: 0x002F147B

		public static bool operator !=(Clip_5_5_0_ACL left, Clip_5_5_0_ACL right)
		{
			return !(left == right);
		}

		// Token: 0x0601412E RID: 82222 RVA: 0x002F3288 File Offset: 0x002F1488
		public override int GetHashCode()
		{
			HashCode hashCode = default(HashCode);
			hashCode.Add<IOffsetPtr_ValueArrayConstant>(this.Binding);
			hashCode.Add<ConstantClip>(this.ConstantClip);
			hashCode.Add<DenseClip>(this.DenseClip);
			hashCode.Add<StreamedClip>(this.StreamedClip);
			return hashCode.ToHashCode();
		}

		// Token: 0x0601412F RID: 82223 RVA: 0x002F32D8 File Offset: 0x002F14D8
		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06014130 RID: 82224 RVA: 0x002F32DF File Offset: 0x002F14DF
		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x040030CD RID: 12493
		public StreamedClip m_StreamedClip;

		// Token: 0x040030CE RID: 12494
		public DenseClip m_DenseClip;

		// Token: 0x040030CF RID: 12495
		public ConstantClip m_ConstantClip;

		// Token: 0x040030D0 RID: 12496
		public OffsetPtr_ValueArrayConstant_5_5_0 m_Binding;

		public AclClip m_AclClip;
	}
}
