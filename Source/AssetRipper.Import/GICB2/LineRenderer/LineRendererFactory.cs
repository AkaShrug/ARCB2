using System;
using System.Runtime.CompilerServices;
using AssetRipper.Assets.Metadata;
using AssetRipper.VersionUtilities;
using AssetRipper.SourceGenerated.Classes.ClassID_120;

namespace AssetRipper.Import.GICB2.LineRenderer
{
    public static class LineRendererFactory
    {
        public static ILineRenderer CreateAsset(UnityVersion version, AssetInfo info)
        {
            return new LineRenderer_2017_1_0_GICB2(info);
        }
        public static ILineRenderer CreateAsset(UnityVersion version)
        {
            return CreateAsset(version, AssetInfo.MakeDummyAssetInfo(120));
        }
    }
}