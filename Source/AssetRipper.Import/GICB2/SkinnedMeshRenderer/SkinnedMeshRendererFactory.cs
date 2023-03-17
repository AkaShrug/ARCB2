using AssetRipper.Assets.Metadata;
using AssetRipper.VersionUtilities;
using AssetRipper.SourceGenerated.Classes.ClassID_137;

namespace AssetRipper.Import.GICB2.SkinnedMeshRenderer
{
	// Token: 0x020030E1 RID: 12513
	public static class SkinnedMeshRendererFactory
	{
		// Token: 0x0604E54C RID: 320844 RVA: 0x00A01E7C File Offset: 0x00A0007C
		public static ISkinnedMeshRenderer CreateAsset(UnityVersion version, AssetInfo info)
		{
			return new SkinnedMeshRenderer_2017_1_0_GICB2(info);
		}

		// Token: 0x0604E54D RID: 320845 RVA: 0x00A020B9 File Offset: 0x00A002B9
		public static ISkinnedMeshRenderer CreateAsset(UnityVersion version)
		{
			return CreateAsset(version, AssetInfo.MakeDummyAssetInfo(137));
		}
	}
}
