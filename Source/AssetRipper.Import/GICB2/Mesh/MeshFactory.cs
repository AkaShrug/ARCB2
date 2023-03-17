using AssetRipper.Assets.Metadata;
using AssetRipper.SourceGenerated.Classes.ClassID_43;
using AssetRipper.VersionUtilities;

namespace AssetRipper.Import.GICB2.Mesh
{
	// Token: 0x020028BC RID: 10428
	public static class MeshFactory
	{
		// Token: 0x0602879B RID: 165787 RVA: 0x005B918C File Offset: 0x005B738C
		public static IMesh CreateAsset(UnityVersion version, AssetInfo info)
		{
			return new Mesh_2017_1_0_GICB2(info);
		}

		// Token: 0x0602879C RID: 165788 RVA: 0x005B933B File Offset: 0x005B753B
		public static IMesh CreateAsset(UnityVersion version)
		{
			return CreateAsset(version, AssetInfo.MakeDummyAssetInfo(43));
		}
	}
}
