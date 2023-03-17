using System;
using System.Runtime.CompilerServices;
using AssetRipper.Assets.Metadata;
using AssetRipper.VersionUtilities;
using AssetRipper.SourceGenerated.Classes.ClassID_156;

namespace AssetRipper.Import.GICB2.TerrainData
{
    public static class TerrainDataFactory
    {
        public static ITerrainData CreateAsset(UnityVersion version, AssetInfo info)
        {
            return new TerrainData_2017_1_0_GICB2(info);
        }
        public static ITerrainData CreateAsset(UnityVersion version)
        {
            return CreateAsset(version, AssetInfo.MakeDummyAssetInfo(156));
        }
    }
}