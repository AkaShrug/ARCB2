using System;
using System.Runtime.CompilerServices;
using AssetRipper.Assets.Metadata;
using AssetRipper.VersionUtilities;
using AssetRipper.SourceGenerated.Classes.ClassID_108;

namespace AssetRipper.Import.GICB2.Light
{
	// Token: 0x020034A6 RID: 13478
	public static class LightFactory
	{
		// Token: 0x0605E588 RID: 386440 RVA: 0x014934AC File Offset: 0x014916AC
		public static ILight CreateAsset(UnityVersion version, AssetInfo info)
		{
			return new Light_2017_1_1_GICB2(info);
		}

		// Token: 0x0605E589 RID: 386441 RVA: 0x014936A3 File Offset: 0x014918A3
		public static ILight CreateAsset(UnityVersion version)
		{
			return CreateAsset(version, AssetInfo.MakeDummyAssetInfo(108));
		}
	}
}
