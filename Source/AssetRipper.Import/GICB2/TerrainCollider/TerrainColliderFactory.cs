using System;
using System.Runtime.CompilerServices;
using AssetRipper.Assets.Metadata;
using AssetRipper.VersionUtilities;
using AssetRipper.SourceGenerated.Classes.ClassID_154;

namespace AssetRipper.Import.GICB2.TerrainCollider
{
    public static class TerrainColliderFactory
    {
        public static ITerrainCollider CreateAsset(UnityVersion version, AssetInfo info)
        {
            return new TerrainCollider_5_5_0_GICB2(info);
        }
        public static ITerrainCollider CreateAsset(UnityVersion version)
        {
            return CreateAsset(version, AssetInfo.MakeDummyAssetInfo(154));
        }
    }
}