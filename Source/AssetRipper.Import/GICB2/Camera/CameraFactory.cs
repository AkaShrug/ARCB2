using AssetRipper.Assets.Metadata;
using AssetRipper.SourceGenerated.Classes.ClassID_20;
using AssetRipper.VersionUtilities;

namespace AssetRipper.Import.GICB2.Camera
{
	// Token: 0x02002C93 RID: 11411
	public static class CameraFactory
	{
		// Token: 0x0603B13B RID: 241979 RVA: 0x007C7330 File Offset: 0x007C5530
		public static ICamera CreateAsset(UnityVersion version, AssetInfo info)
		{
			return new Camera_5_6_0_GICB2();
		}

		// Token: 0x0603B13C RID: 241980 RVA: 0x007C74DA File Offset: 0x007C56DA
		public static ICamera CreateAsset(UnityVersion version)
		{
			return CreateAsset(version, AssetInfo.MakeDummyAssetInfo(20));
		}
	}
}
