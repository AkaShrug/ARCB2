using System;
using System.Runtime.CompilerServices;
using AssetRipper.VersionUtilities;
using AssetRipper.SourceGenerated.Subclasses.QualitySetting;

namespace AssetRipper.Import.GICB2.QualitySetting
{
	// Token: 0x02000510 RID: 1296
	public static class QualitySettingFactory
	{
		// Token: 0x06009403 RID: 37891 RVA: 0x0018A214 File Offset: 0x00188414
		public static IQualitySetting CreateAsset(UnityVersion version)
		{
			return new QualitySetting_2017_1_0_GICB2();
		}
	}
}
