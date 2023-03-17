using System;
using System.Runtime.CompilerServices;
using AssetRipper.Assets.Metadata;
using AssetRipper.VersionUtilities;
using AssetRipper.SourceGenerated.Classes.ClassID_48;

namespace AssetRipper.Import.GICB2.Shader
{
	// Token: 0x02002834 RID: 10292
	public static class ShaderFactory
	{
		// Token: 0x06025CE4 RID: 154852 RVA: 0x00571758 File Offset: 0x0056F958
		public static IShader CreateAsset(UnityVersion version, AssetInfo info)
		{
			return new Shader_2017_1_0_GICB2(info);
		}

		// Token: 0x06025CE5 RID: 154853 RVA: 0x00571B93 File Offset: 0x0056FD93
		public static IShader CreateAsset(UnityVersion version)
		{
			return CreateAsset(version, AssetInfo.MakeDummyAssetInfo(48));
		}
	}
}
