using AssetRipper.Assets;
using AssetRipper.Assets.Export.Dependencies;
using AssetRipper.Assets.Export.Yaml;
using AssetRipper.Assets.Interfaces;
using AssetRipper.Assets.IO;
using AssetRipper.Assets.IO.Reading;
using AssetRipper.Assets.IO.Writing;
using AssetRipper.SourceGenerated.Subclasses.ConstantClip;
using AssetRipper.SourceGenerated.Subclasses.DenseClip;
using AssetRipper.SourceGenerated.Subclasses.OffsetPtr_ValueArrayConstant;
using AssetRipper.SourceGenerated.Subclasses.StreamedClip;
using System.Diagnostics.CodeAnalysis;

namespace AssetRipper.IClasses.Clip
{
	public interface IClip_ACL : IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IEquatable<IClip_ACL>
	{
		IOffsetPtr_ValueArrayConstant Binding
		{
			get;
		}

		// Token: 0x170053BC RID: 21436
		// (get) Token: 0x06014132 RID: 82226

		ConstantClip ConstantClip
		{
			get;
		}

		// Token: 0x170053BD RID: 21437
		// (get) Token: 0x06014133 RID: 82227

		DenseClip DenseClip
		{
			get;
		}

		// Token: 0x170053BE RID: 21438
		// (get) Token: 0x06014134 RID: 82228

		StreamedClip StreamedClip
		{
			get;
		}

		AclClip AclClip
		{
			get;
		}

		[MemberNotNullWhen(true, "Binding")]
		[MemberNotNullWhen(false, "ConstantClip")]
		bool Has_Binding();

		[MemberNotNullWhen(false, "Binding")]
		[MemberNotNullWhen(true, "ConstantClip")]
		bool Has_ConstantClip();

		// Token: 0x06014137 RID: 82231
		void CopyValues(IClip_ACL source);

		// Token: 0x06014138 RID: 82232
		IClip_ACL DeepClone();
	}
}
