using System;
using System.Runtime.CompilerServices;
using AssetRipper.Assets;
using AssetRipper.Assets.Cloning;
using AssetRipper.Assets.Export.Dependencies;
using AssetRipper.Assets.Export.Yaml;
using AssetRipper.Assets.Interfaces;
using AssetRipper.Assets.IO;
using AssetRipper.Assets.IO.Reading;
using AssetRipper.Assets.IO.Writing;
using AssetRipper.Assets.Metadata;
using AssetRipper.IClasses.AnimationClip;

namespace AssetRipper.IClasses.PPtr_AnimationClip
{
	// Token: 0x02000679 RID: 1657
	public interface IPPtr_AnimationClip_ACL : IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IPPtr<IAnimationClip_ACL>, IPPtr, IEquatable<IPPtr_AnimationClip_ACL>
	{
		// Token: 0x17002EDC RID: 11996
		// (get) Token: 0x0600B459 RID: 46169
		// (set) Token: 0x0600B45A RID: 46170
		int FileID_ { get; set; }

		// Token: 0x17002EDD RID: 11997
		// (get) Token: 0x0600B45B RID: 46171
		// (set) Token: 0x0600B45C RID: 46172
		int PathID__Int32 { get; set; }

		// Token: 0x17002EDE RID: 11998
		// (get) Token: 0x0600B45D RID: 46173
		// (set) Token: 0x0600B45E RID: 46174
		long PathID__Int64 { get; set; }

		// Token: 0x0600B45F RID: 46175
		bool Has_PathID__Int32();

		// Token: 0x0600B460 RID: 46176
		bool Has_PathID__Int64();

		// Token: 0x0600B461 RID: 46177

		void CopyValues(IPPtr_AnimationClip_ACL source, PPtrConverter converter);

		// Token: 0x0600B462 RID: 46178

		IPPtr_AnimationClip_ACL DeepClone(PPtrConverter converter);

		// Token: 0x0600B463 RID: 46179
		void SetValues(int fileID_, int pathID__Int32, long pathID__Int64);
	}
}
