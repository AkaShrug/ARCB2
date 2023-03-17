using System;
using System.Runtime.CompilerServices;
using AssetRipper.Assets.Metadata;
using AssetRipper.VersionUtilities;
using AssetRipper.SourceGenerated.Classes.ClassID_238;

namespace AssetRipper.Import.GICB2.NavMeshData
{
	// Token: 0x02002B12 RID: 11026
	public static class NavMeshDataFactory
	{
		// Token: 0x060338AC RID: 211116 RVA: 0x006F1E38 File Offset: 0x006F0038
		public static INavMeshData CreateAsset(UnityVersion version, AssetInfo info)
		{
			return new NavMeshData_2017_1_0_GICB2(info);
		}

		// Token: 0x060338AD RID: 211117 RVA: 0x006F1F7E File Offset: 0x006F017E
		public static INavMeshData CreateAsset(UnityVersion version)
		{
			return NavMeshDataFactory.CreateAsset(version, AssetInfo.MakeDummyAssetInfo(238));
		}
	}
}
