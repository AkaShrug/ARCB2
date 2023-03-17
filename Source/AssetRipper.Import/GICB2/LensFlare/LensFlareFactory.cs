using System;
using System.Runtime.CompilerServices;
using AssetRipper.Assets.Metadata;
using AssetRipper.VersionUtilities;
using AssetRipper.SourceGenerated.Classes.ClassID_123;

namespace AssetRipper.Import.GICB2.LensFlare
{
	public static class LensFlareFactory
	{
		// Token: 0x06052C62 RID: 339042 RVA: 0x0131E758 File Offset: 0x0131C958
		public static ILensFlare CreateAsset(UnityVersion version, AssetInfo info)
		{
			return new LensFlare_5_5_0_GICB2(info);
		}

		// Token: 0x06052C63 RID: 339043 RVA: 0x0131E80A File Offset: 0x0131CA0A
		public static ILensFlare CreateAsset(UnityVersion version)
		{
			return CreateAsset(version, AssetInfo.MakeDummyAssetInfo(123));
		}
	}
}
