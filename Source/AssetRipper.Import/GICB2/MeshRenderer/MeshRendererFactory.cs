using System;
using System.Runtime.CompilerServices;
using AssetRipper.Assets.Metadata;
using AssetRipper.VersionUtilities;
using AssetRipper.SourceGenerated.Classes.ClassID_23;

namespace AssetRipper.Import.GICB2.MeshRenderer
{
	public static class MeshRendererFactory
	{
		// Token: 0x060325F5 RID: 206325 RVA: 0x006D64C8 File Offset: 0x006D46C8
		public static IMeshRenderer CreateAsset(UnityVersion version, AssetInfo info)
		{
			return new MeshRenderer_2017_1_0_GICB2(info);
		}

		// Token: 0x060325F6 RID: 206326 RVA: 0x006D6709 File Offset: 0x006D4909
		public static IMeshRenderer CreateAsset(UnityVersion version)
		{
			return CreateAsset(version, AssetInfo.MakeDummyAssetInfo(23));
		}
	}
}
