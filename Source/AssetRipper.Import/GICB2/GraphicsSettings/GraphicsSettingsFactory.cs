using AssetRipper.Assets.Metadata;
using AssetRipper.VersionUtilities;
using AssetRipper.SourceGenerated.Classes.ClassID_30;

namespace AssetRipper.Import.GICB2.GraphicsSettings
{
	// Token: 0x02002956 RID: 10582

	public static class GraphicsSettingsFactory
	{
		// Token: 0x0602ABCF RID: 175055 RVA: 0x00605DE8 File Offset: 0x00603FE8
		public static IGraphicsSettings CreateAsset(UnityVersion version, AssetInfo info)
		{
			return new GraphicsSettings_2017_1_0_GICB2(info);
		}

		// Token: 0x0602ABD0 RID: 175056 RVA: 0x00606159 File Offset: 0x00604359
		public static IGraphicsSettings CreateAsset(UnityVersion version)
		{
			return CreateAsset(version, AssetInfo.MakeDummyAssetInfo(30));
		}
	}
}
