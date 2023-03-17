using System;
using System.Runtime.CompilerServices;
using AssetRipper.Assets.Metadata;
using AssetRipper.VersionUtilities;
using AssetRipper.SourceGenerated.Classes.ClassID_157;

namespace AssetRipper.Import.GICB2.LightmapSettings
{
	public static class LightmapSettingsFactory
	{
		// Token: 0x06049FFF RID: 303103 RVA: 0x009800EC File Offset: 0x0097E2EC
		public static ILightmapSettings CreateAsset(UnityVersion version, AssetInfo info)
		{
			return new LightmapSettings_2017_1_0_GICB2(info);
		}

		// Token: 0x0604A000 RID: 303104 RVA: 0x00980345 File Offset: 0x0097E545
		public static ILightmapSettings CreateAsset(UnityVersion version)
		{
			return CreateAsset(version, AssetInfo.MakeDummyAssetInfo(157));
		}
	}
}
