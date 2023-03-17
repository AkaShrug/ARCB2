using AssetRipper.Assets.Metadata;
using AssetRipper.VersionUtilities;
using AssetRipper.SourceGenerated.Classes.ClassID_198;

namespace AssetRipper.Import.GICB2.ParticleSystem
{
	// Token: 0x02002D54 RID: 11604
	public static class ParticleSystemFactory
	{
		// Token: 0x0603F5A5 RID: 259493 RVA: 0x00841800 File Offset: 0x0083FA00
		public static IParticleSystem CreateAsset(UnityVersion version, AssetInfo info)
		{
			return new ParticleSystem_2017_1_0_b10_GICB2(info);
		}

		// Token: 0x0603F5A6 RID: 259494 RVA: 0x00841B06 File Offset: 0x0083FD06
		public static IParticleSystem CreateAsset(UnityVersion version)
		{
			return CreateAsset(version, AssetInfo.MakeDummyAssetInfo(198));
		}
	}
}
