using System;
using System.Runtime.CompilerServices;
using AssetRipper.Assets.Metadata;
using AssetRipper.VersionUtilities;
using AssetRipper.SourceGenerated.Classes.ClassID_104;

namespace AssetRipper.Import.GICB2.RenderSettings
{
	// Token: 0x02003545 RID: 13637
	public static class RenderSettingsFactory
	{
		// Token: 0x06067AD8 RID: 424664 RVA: 0x0156C50C File Offset: 0x0156A70C
		public static IRenderSettings CreateAsset(UnityVersion version, AssetInfo info)
		{
			return new RenderSettings_5_6_0_GICB2(info);
		}

		// Token: 0x06067AD9 RID: 424665 RVA: 0x0156C5FD File Offset: 0x0156A7FD
		public static IRenderSettings CreateAsset(UnityVersion version)
		{
			return CreateAsset(version, AssetInfo.MakeDummyAssetInfo(104));
		}
	}
}
