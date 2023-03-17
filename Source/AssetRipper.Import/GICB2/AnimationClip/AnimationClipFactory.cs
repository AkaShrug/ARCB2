using AssetRipper.Assets.Metadata;
using AssetRipper.IClasses.AnimationClip;
using AssetRipper.VersionUtilities;

namespace AssetRipper.Import.GICB2.AnimationClip
{
	// Token: 0x0200268A RID: 9866

	public static class AnimationClipFactory
	{
		// Token: 0x0601F33B RID: 127803 RVA: 0x004B20BC File Offset: 0x004B02BC
		public static IAnimationClip_ACL CreateAsset(UnityVersion version, AssetInfo info)
		{
			return new AnimationClip_2017_1_0_GICB2(info);
		}

		// Token: 0x0601F33C RID: 127804 RVA: 0x004B2291 File Offset: 0x004B0491
		public static IAnimationClip_ACL CreateAsset(UnityVersion version)
		{
			return CreateAsset(version, AssetInfo.MakeDummyAssetInfo(74));
		}
	}
}
