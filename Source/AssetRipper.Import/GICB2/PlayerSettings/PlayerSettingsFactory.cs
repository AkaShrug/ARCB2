using System;
using System.Runtime.CompilerServices;
using AssetRipper.Assets.Metadata;
using AssetRipper.VersionUtilities;
using AssetRipper.SourceGenerated.Classes.ClassID_129;

namespace AssetRipper.Import.GICB2.PlayerSettings
{
	// Token: 0x02003206 RID: 12806
	public static class PlayerSettingsFactory
	{
		// Token: 0x06050F76 RID: 331638 RVA: 0x00A4BEF4 File Offset: 0x00A4A0F4
		public static IPlayerSettings CreateAsset(UnityVersion version, AssetInfo info)
		{
			return new PlayerSettings_2017_1_0_f2(info);
			//return new PlayerSettings_2017_1_0_f2_GICB2(info);
		}

		// Token: 0x06050F77 RID: 331639 RVA: 0x00A4D851 File Offset: 0x00A4BA51
		public static IPlayerSettings CreateAsset(UnityVersion version)
		{
			return PlayerSettingsFactory.CreateAsset(version, AssetInfo.MakeDummyAssetInfo(129));
		}
	}
}
