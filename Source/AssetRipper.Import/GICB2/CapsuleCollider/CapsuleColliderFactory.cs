using AssetRipper.Assets.Metadata;
using AssetRipper.SourceGenerated.Classes.ClassID_136;
using AssetRipper.VersionUtilities;

namespace AssetRipper.Import.GICB2.CapsuleCollider
{
	// Token: 0x02003134 RID: 12596
	public static class CapsuleColliderFactory
	{
		// Token: 0x06050E57 RID: 331351 RVA: 0x00A40064 File Offset: 0x00A3E264
		public static ICapsuleCollider CreateAsset(UnityVersion version, AssetInfo info)
		{
			return new CapsuleCollider_5_5_0_GICB2(info);
		}

		// Token: 0x06050E58 RID: 331352 RVA: 0x00A4015A File Offset: 0x00A3E35A
		public static ICapsuleCollider CreateAsset(UnityVersion version)
		{
			return CreateAsset(version, AssetInfo.MakeDummyAssetInfo(136));
		}
	}
}
