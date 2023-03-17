using System;
using System.Runtime.CompilerServices;
using AssetRipper.VersionUtilities;
using AssetRipper.SourceGenerated.Subclasses.ShapeModule;

namespace AssetRipper.Import.GICB2.ParticleSystem.ShapeModule
{
	// Token: 0x020003A2 RID: 930
	public static class ShapeModuleFactory
	{
		// Token: 0x06006215 RID: 25109 RVA: 0x00100494 File Offset: 0x000FE694
		public static IShapeModule CreateAsset(UnityVersion version)
		{
			return new ShapeModule_2017_1_0_b3_GICB2();
		}
	}
}
