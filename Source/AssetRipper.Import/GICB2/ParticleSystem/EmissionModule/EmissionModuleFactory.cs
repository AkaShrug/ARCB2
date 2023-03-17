using System;
using System.Runtime.CompilerServices;
using AssetRipper.VersionUtilities;
using AssetRipper.SourceGenerated.Subclasses.EmissionModule;

namespace AssetRipper.Import.GICB2.ParticleSystem.EmissionModule
{
	// Token: 0x020009EB RID: 2539
	public static class EmissionModuleFactory
	{
		// Token: 0x060117EE RID: 71662 RVA: 0x0028E9D4 File Offset: 0x0028CBD4
		public static IEmissionModule CreateAsset(UnityVersion version)
		{
			return new EmissionModule_2017_1_0_b3_GICB2();
		}
	}
}
