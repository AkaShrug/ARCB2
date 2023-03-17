using System;
using System.Runtime.CompilerServices;
using AssetRipper.Assets.Metadata;
using AssetRipper.VersionUtilities;
using AssetRipper.SourceGenerated.Classes.ClassID_135;

namespace AssetRipper.Import.GICB2.SphereCollider
{
    public static class SphereColliderFactory
    {
        public static ISphereCollider CreateAsset(UnityVersion version, AssetInfo info)
        {
            return new SphereCollider_5_5_0_GICB2(info);
        }
        public static ISphereCollider CreateAsset(UnityVersion version)
        {
            return CreateAsset(version, AssetInfo.MakeDummyAssetInfo(135));
        }
    }
}