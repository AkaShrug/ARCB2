using AssetRipper.VersionUtilities;
using AssetRipper.SourceGenerated.Subclasses.SplatPrototype;

namespace AssetRipper.Import.GICB2.TerrainData.SplatPrototype
{
	// Token: 0x02000332 RID: 818
	public static class SplatPrototypeFactory
	{
		// Token: 0x060055AC RID: 21932 RVA: 0x000E3518 File Offset: 0x000E1718
		public static ISplatPrototype CreateAsset(UnityVersion version)
		{
			return new SplatPrototype_5_0_1_GICB2();
		}
	}
}
