using System;
using System.Runtime.CompilerServices;
using AssetRipper.VersionUtilities;
using AssetRipper.SourceGenerated.Subclasses.NavMeshBuildSettings;

namespace AssetRipper.Import.GICB2.NavMeshData.NavMeshBuildSettings
{
	// Token: 0x02000785 RID: 1925
	public static class NavMeshBuildSettingsFactory
	{
		// Token: 0x0600C7AF RID: 51119 RVA: 0x001DD21C File Offset: 0x001DB41C
		public static INavMeshBuildSettings CreateAsset(UnityVersion version)
		{
			return new NavMeshBuildSettings_5_6_0_f2_GICB2();
		}
	}
}
