using System;
using System.Runtime.CompilerServices;
using AssetRipper.Assets;
using AssetRipper.Assets.Export.Dependencies;
using AssetRipper.Assets.Export.Yaml;
using AssetRipper.Assets.Interfaces;
using AssetRipper.Assets.IO;
using AssetRipper.Assets.IO.Reading;
using AssetRipper.Assets.IO.Writing;
using AssetRipper.IClasses.Clip;


namespace AssetRipper.IClasses.OffsetPtr_Clip
{
	// Token: 0x0200072E RID: 1838
	public interface IOffsetPtr_Clip_ACL : IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IEquatable<IOffsetPtr_Clip_ACL>
	{
		// Token: 0x170030CD RID: 12493
		// (get) Token: 0x0600C0F4 RID: 49396

		IClip_ACL Data
		{
			get;
		}

		// Token: 0x0600C0F5 RID: 49397
		void CopyValues(IOffsetPtr_Clip_ACL source);

		IOffsetPtr_Clip_ACL DeepClone();
	}
}
