using System;
using System.Runtime.CompilerServices;
using AssetRipper.Assets.Metadata;
using AssetRipper.VersionUtilities;
using AssetRipper.SourceGenerated.Classes.ClassID_212;

namespace AssetRipper.Import.GICB2.SpriteRenderer
{
    public static class SpriteRendererFactory
    {
        public static ISpriteRenderer CreateAsset(UnityVersion version, AssetInfo info)
        {
            return new SpriteRenderer_2017_1_0_GICB2(info);
        }
        public static ISpriteRenderer CreateAsset(UnityVersion version)
        {
            return CreateAsset(version, AssetInfo.MakeDummyAssetInfo(212));
        }
    }
}