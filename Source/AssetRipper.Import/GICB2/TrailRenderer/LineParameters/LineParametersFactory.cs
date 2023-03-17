using System;
using System.Runtime.CompilerServices;
using AssetRipper.VersionUtilities;
using AssetRipper.SourceGenerated.Subclasses.LineParameters;

namespace AssetRipper.Import.GICB2.TrailRenderer.LineParameters
{
	// Token: 0x0200082A RID: 2090
	public static class LineParametersFactory
	{
		// Token: 0x0600DA67 RID: 55911 RVA: 0x0020A6D4 File Offset: 0x002088D4
		public static ILineParameters CreateAsset(UnityVersion version)
		{
			return new LineParameters_2017_1_0_GICB2();
		}
	}
}
