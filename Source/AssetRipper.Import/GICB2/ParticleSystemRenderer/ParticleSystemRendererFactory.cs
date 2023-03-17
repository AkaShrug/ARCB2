using System;
using System.Runtime.CompilerServices;
using AssetRipper.Assets.Metadata;
using AssetRipper.SourceGenerated.Classes.ClassID_199;
using AssetRipper.VersionUtilities;

namespace AssetRipper.Import.GICB2.ParticleSystemRenderer
{
	public static class ParticleSystemRendererFactory
	{
		// Token: 0x0603D439 RID: 250937 RVA: 0x0080BD08 File Offset: 0x00809F08
		public static IParticleSystemRenderer CreateAsset(UnityVersion version, AssetInfo info)
		{
			return new ParticleSystemRenderer_2017_1_0_GICB2(info);
		}

		// Token: 0x0603D43A RID: 250938 RVA: 0x0080BFAA File Offset: 0x0080A1AA
		public static IParticleSystemRenderer CreateAsset(UnityVersion version)
		{
			return CreateAsset(version, AssetInfo.MakeDummyAssetInfo(199));
		}
	}
}
