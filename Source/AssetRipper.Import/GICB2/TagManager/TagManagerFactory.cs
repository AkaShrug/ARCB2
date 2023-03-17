using System;
using System.Runtime.CompilerServices;
using AssetRipper.Assets.Metadata;
using AssetRipper.VersionUtilities;
using AssetRipper.SourceGenerated.Classes.ClassID_78;

namespace AssetRipper.Import.GICB2.TagManager
{
	// Token: 0x0200266D RID: 9837

	public static class TagManagerFactory
	{
		// Token: 0x0601EE26 RID: 126502 RVA: 0x004A7918 File Offset: 0x004A5B18
		public static ITagManager CreateAsset(UnityVersion version, AssetInfo info)
		{
			return new TagManager_2017_1_0_GICB2(info);
		}

		// Token: 0x0601EE27 RID: 126503 RVA: 0x004A7998 File Offset: 0x004A5B98
		public static ITagManager CreateAsset(UnityVersion version)
		{
			return CreateAsset(version, AssetInfo.MakeDummyAssetInfo(78));
		}
	}
}
