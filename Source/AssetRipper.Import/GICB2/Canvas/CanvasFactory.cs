using System;
using System.Runtime.CompilerServices;
using AssetRipper.Assets.Metadata;
using AssetRipper.VersionUtilities;
using AssetRipper.SourceGenerated.Classes.ClassID_223;

namespace AssetRipper.Import.GICB2.Canvas
{
	// Token: 0x02002BC3 RID: 11203
	public static class CanvasFactory
	{
		// Token: 0x060367EA RID: 223210 RVA: 0x0074C9A8 File Offset: 0x0074ABA8
		public static ICanvas CreateAsset(UnityVersion version, AssetInfo info)
		{
			return new Canvas_5_6_0_GICB2(info);
		}

		// Token: 0x060367EB RID: 223211 RVA: 0x0074CAB2 File Offset: 0x0074ACB2
		public static ICanvas CreateAsset(UnityVersion version)
		{
			return CreateAsset(version, AssetInfo.MakeDummyAssetInfo(223));
		}
	}
}
