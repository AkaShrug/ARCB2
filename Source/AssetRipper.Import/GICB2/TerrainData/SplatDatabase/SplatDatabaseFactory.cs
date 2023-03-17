using System;
using System.Runtime.CompilerServices;
using AssetRipper.VersionUtilities;
using AssetRipper.SourceGenerated.Subclasses.SplatDatabase;

namespace AssetRipper.Import.GICB2.TerrainData.SplatDatabase
{
	// Token: 0x02000339 RID: 825
	public static class SplatDatabaseFactory
	{
		// Token: 0x06005657 RID: 22103 RVA: 0x000E4E3C File Offset: 0x000E303C
		public static ISplatDatabase CreateAsset(UnityVersion version)
		{
			return new SplatDatabase_2017_1_0_GICB2();
		}
	}
}
