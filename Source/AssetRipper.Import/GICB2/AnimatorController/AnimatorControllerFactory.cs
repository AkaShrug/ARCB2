using System;
using System.Runtime.CompilerServices;
using AssetRipper.Assets.Metadata;
using AssetRipper.VersionUtilities;
using AssetRipper.IClasses.IAnimatorController;

namespace AssetRipper.Import.GICB2.AnimatorController
{
	// Token: 0x02002597 RID: 9623

	public static class AnimatorControllerFactory
	{
		// Token: 0x0601AC27 RID: 109607 RVA: 0x004274C4 File Offset: 0x004256C4
		public static IAnimatorController_ACL CreateAsset(UnityVersion version, AssetInfo info)
		{
			return new AnimatorController_2017_1_0_GICB2(info);
		}

		// Token: 0x0601AC28 RID: 109608 RVA: 0x004276A4 File Offset: 0x004258A4
		public static IAnimatorController_ACL CreateAsset(UnityVersion version)
		{
			return CreateAsset(version, AssetInfo.MakeDummyAssetInfo(91));
		}
	}
}
