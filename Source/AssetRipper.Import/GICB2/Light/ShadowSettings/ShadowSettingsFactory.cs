using System;
using System.Runtime.CompilerServices;
using AssetRipper.VersionUtilities;
using AssetRipper.SourceGenerated.Subclasses.ShadowSettings;

namespace AssetRipper.Import.GICB2.Light.ShadowSettings
{
	// Token: 0x020003B2 RID: 946
	public static class ShadowSettingsFactory
	{
		// Token: 0x06006926 RID: 26918 RVA: 0x0011322C File Offset: 0x0011142C
		public static IShadowSettings CreateAsset(UnityVersion version)
		{
			return new ShadowSettings_5_4_0_f3_GICB2();
		}
	}
}
