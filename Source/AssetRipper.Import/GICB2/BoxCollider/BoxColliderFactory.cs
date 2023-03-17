using AssetRipper.Assets.Metadata;
using AssetRipper.SourceGenerated.Classes.ClassID_65;
using AssetRipper.VersionUtilities;

namespace AssetRipper.Import.GICB2.BoxCollider
{
	// Token: 0x0200273C RID: 10044
	public static class BoxColliderFactory
	{
		// Token: 0x06021E6F RID: 138863 RVA: 0x005092A0 File Offset: 0x005074A0
		public static IBoxCollider CreateAsset(UnityVersion version, AssetInfo info)
		{
			return new BoxCollider_5_5_0_GICB2(info);
		}

		// Token: 0x06021E70 RID: 138864 RVA: 0x00509396 File Offset: 0x00507596
		public static IBoxCollider CreateAsset(UnityVersion version)
		{
			return CreateAsset(version, AssetInfo.MakeDummyAssetInfo(65));
		}
	}
}
