using AssetRipper.Assets.Metadata;
using AssetRipper.VersionUtilities;
using AssetRipper.SourceGenerated.Classes.ClassID_64;

namespace AssetRipper.Import.GICB2.MeshCollider
{
	// Token: 0x0200273C RID: 10044
	public static class MeshColliderFactory
	{
		// Token: 0x06021C84 RID: 138372 RVA: 0x00504F30 File Offset: 0x00503130
		public static IMeshCollider CreateAsset(UnityVersion version, AssetInfo info)
		{
			return new MeshCollider_5_5_0_GICB2(info);
		}

		// Token: 0x06021C85 RID: 138373 RVA: 0x0050505D File Offset: 0x0050325D
		public static IMeshCollider CreateAsset(UnityVersion version)
		{
			return CreateAsset(version, AssetInfo.MakeDummyAssetInfo(64));
		}
	}
}
