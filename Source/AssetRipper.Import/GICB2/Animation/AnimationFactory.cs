using System;
using System.Runtime.CompilerServices;
using AssetRipper.Assets.Metadata;
using AssetRipper.IClasses.Animation;
using AssetRipper.VersionUtilities;

namespace AssetRipper.Import.GICB2.Animation
{
	public static class AnimationFactory
	{
		// Token: 0x0605B55F RID: 374111 RVA: 0x01434A58 File Offset: 0x01432C58
		public static IAnimation_ACL CreateAsset(UnityVersion version, AssetInfo info)
		{
			return new Animation_2017_1_0_GICB2(info);
		}

		// Token: 0x0605B560 RID: 374112 RVA: 0x01434B52 File Offset: 0x01432D52
		public static IAnimation_ACL CreateAsset(UnityVersion version)
		{
			return CreateAsset(version, AssetInfo.MakeDummyAssetInfo(111));
		}
	}
}
