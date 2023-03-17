using System;
using System.Runtime.CompilerServices;
using AssetRipper.Assets.Metadata;
using AssetRipper.VersionUtilities;
using AssetRipper.SourceGenerated.Classes.ClassID_218;

namespace AssetRipper.Import.GICB2.Terrain
{
	public static class TerrainFactory
	{
		// Token: 0x0603788E RID: 227470 RVA: 0x00765A40 File Offset: 0x00763C40
		public static ITerrain CreateAsset(UnityVersion version, AssetInfo info)
		{
			return new Terrain_5_5_0_GICB2(info);
		}

		// Token: 0x0603788F RID: 227471 RVA: 0x00765BC7 File Offset: 0x00763DC7
		public static ITerrain CreateAsset(UnityVersion version)
		{
			return CreateAsset(version, AssetInfo.MakeDummyAssetInfo(218));
		}
	}
}
