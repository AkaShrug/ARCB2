using AssetRipper.Assets.Metadata;
using AssetRipper.SourceGenerated.Classes.ClassID_95;
using AssetRipper.VersionUtilities;

namespace AssetRipper.Import.GICB2.Animatior
{
	public static class AnimatorFactory
	{
		// Token: 0x0601A1D8 RID: 106968 RVA: 0x00417F9C File Offset: 0x0041619C
		public static IAnimator CreateAsset(UnityVersion version, AssetInfo info)
		{
			return new Animator_5_6_0_GICB2(info);
		}

		// Token: 0x0601A1D9 RID: 106969 RVA: 0x004180BF File Offset: 0x004162BF
		public static IAnimator CreateAsset(UnityVersion version)
		{
			return CreateAsset(version, AssetInfo.MakeDummyAssetInfo(95));
		}
	}
}
