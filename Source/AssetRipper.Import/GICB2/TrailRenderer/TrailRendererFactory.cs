using System;
using System.Runtime.CompilerServices;
using AssetRipper.Assets.Metadata;
using AssetRipper.VersionUtilities;
using AssetRipper.SourceGenerated.Classes.ClassID_96;

namespace AssetRipper.Import.GICB2.TrailRenderer
{
    public static class TrailRendererFactory
    {
        public static ITrailRenderer CreateAsset(UnityVersion version, AssetInfo info)
        {
            return new TrailRenderer_2017_1_0_GICB2(info);
        }
        public static ITrailRenderer CreateAsset(UnityVersion version)
        {
            return CreateAsset(version, AssetInfo.MakeDummyAssetInfo(96));
        }
    }
}