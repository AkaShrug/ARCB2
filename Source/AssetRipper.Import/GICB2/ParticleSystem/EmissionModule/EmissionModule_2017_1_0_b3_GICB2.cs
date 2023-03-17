using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using AssetRipper.Assets;
using AssetRipper.Assets.Cloning;
using AssetRipper.Assets.Export;
using AssetRipper.Assets.Export.Dependencies;
using AssetRipper.Assets.Export.Yaml;
using AssetRipper.Assets.Generics;
using AssetRipper.Assets.Interfaces;
using AssetRipper.Assets.IO;
using AssetRipper.Assets.IO.Reading;
using AssetRipper.Assets.IO.Writing;
using AssetRipper.Assets.Metadata;
using AssetRipper.IO.Files.SerializedFiles.Parser.TypeTrees;
using AssetRipper.SourceGenerated.Enums;
using AssetRipper.SourceGenerated.Helpers;
using AssetRipper.SourceGenerated.Subclasses.MinMaxCurve;
using AssetRipper.SourceGenerated.Subclasses.ParticleSystemEmissionBurst;
using AssetRipper.Yaml;
using AssetRipper.SourceGenerated.Subclasses.EmissionModule;
using AssetRipper.SourceGenerated.Subclasses.Vector4f;

namespace AssetRipper.Import.GICB2.ParticleSystem.EmissionModule
{
	// Token: 0x020009ED RID: 2541


	public sealed class EmissionModule_2017_1_0_b3_GICB2 : UnityAssetBase, IEmissionModule, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IEquatable<IEmissionModule>, IEquatable<EmissionModule_2017_1_0_b3>
	{
		// Token: 0x170047FF RID: 18431
		// (get) Token: 0x06011854 RID: 71764 RVA: 0x0028F382 File Offset: 0x0028D582
		// (set) Token: 0x06011855 RID: 71765 RVA: 0x0028F385 File Offset: 0x0028D585
		public byte BurstCount_Byte
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17004800 RID: 18432
		// (get) Token: 0x06011856 RID: 71766 RVA: 0x0028F387 File Offset: 0x0028D587
		// (set) Token: 0x06011857 RID: 71767 RVA: 0x0028F38F File Offset: 0x0028D58F
		public int BurstCount_Int32
		{
			get
			{
				return this.m_BurstCount;
			}
			set
			{
				this.m_BurstCount = value;
			}
		}

		// Token: 0x17004801 RID: 18433
		// (get) Token: 0x06011858 RID: 71768 RVA: 0x0028F398 File Offset: 0x0028D598
		public AccessListBase<IParticleSystemEmissionBurst> Bursts
		{
			[return: NotNull]
			get
			{
				return new AccessList<ParticleSystemEmissionBurst_5_6_0_b5, IParticleSystemEmissionBurst>(this.m_Bursts);
			}
		}

		// Token: 0x17004802 RID: 18434
		// (get) Token: 0x06011859 RID: 71769 RVA: 0x0028F3A5 File Offset: 0x0028D5A5
		// (set) Token: 0x0601185A RID: 71770 RVA: 0x0028F3A8 File Offset: 0x0028D5A8
		public ushort Cnt0_UInt16
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17004803 RID: 18435
		// (get) Token: 0x0601185B RID: 71771 RVA: 0x0028F3AA File Offset: 0x0028D5AA
		// (set) Token: 0x0601185C RID: 71772 RVA: 0x0028F3AD File Offset: 0x0028D5AD
		public int Cnt0_Int32
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17004804 RID: 18436
		// (get) Token: 0x0601185D RID: 71773 RVA: 0x0028F3AF File Offset: 0x0028D5AF
		// (set) Token: 0x0601185E RID: 71774 RVA: 0x0028F3B2 File Offset: 0x0028D5B2
		public ushort Cnt1_UInt16
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17004805 RID: 18437
		// (get) Token: 0x0601185F RID: 71775 RVA: 0x0028F3B4 File Offset: 0x0028D5B4
		// (set) Token: 0x06011860 RID: 71776 RVA: 0x0028F3B7 File Offset: 0x0028D5B7
		public int Cnt1_Int32
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17004806 RID: 18438
		// (get) Token: 0x06011861 RID: 71777 RVA: 0x0028F3B9 File Offset: 0x0028D5B9
		// (set) Token: 0x06011862 RID: 71778 RVA: 0x0028F3BC File Offset: 0x0028D5BC
		public ushort Cnt2_UInt16
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17004807 RID: 18439
		// (get) Token: 0x06011863 RID: 71779 RVA: 0x0028F3BE File Offset: 0x0028D5BE
		// (set) Token: 0x06011864 RID: 71780 RVA: 0x0028F3C1 File Offset: 0x0028D5C1
		public int Cnt2_Int32
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17004808 RID: 18440
		// (get) Token: 0x06011865 RID: 71781 RVA: 0x0028F3C3 File Offset: 0x0028D5C3
		// (set) Token: 0x06011866 RID: 71782 RVA: 0x0028F3C6 File Offset: 0x0028D5C6
		public ushort Cnt3_UInt16
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17004809 RID: 18441
		// (get) Token: 0x06011867 RID: 71783 RVA: 0x0028F3C8 File Offset: 0x0028D5C8
		// (set) Token: 0x06011868 RID: 71784 RVA: 0x0028F3CB File Offset: 0x0028D5CB
		public int Cnt3_Int32
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700480A RID: 18442
		// (get) Token: 0x06011869 RID: 71785 RVA: 0x0028F3CD File Offset: 0x0028D5CD
		// (set) Token: 0x0601186A RID: 71786 RVA: 0x0028F3D0 File Offset: 0x0028D5D0
		public ushort Cntmax0_UInt16
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700480B RID: 18443
		// (get) Token: 0x0601186B RID: 71787 RVA: 0x0028F3D2 File Offset: 0x0028D5D2
		// (set) Token: 0x0601186C RID: 71788 RVA: 0x0028F3D5 File Offset: 0x0028D5D5
		public int Cntmax0_Int32
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700480C RID: 18444
		// (get) Token: 0x0601186D RID: 71789 RVA: 0x0028F3D7 File Offset: 0x0028D5D7
		// (set) Token: 0x0601186E RID: 71790 RVA: 0x0028F3DA File Offset: 0x0028D5DA
		public ushort Cntmax1_UInt16
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700480D RID: 18445
		// (get) Token: 0x0601186F RID: 71791 RVA: 0x0028F3DC File Offset: 0x0028D5DC
		// (set) Token: 0x06011870 RID: 71792 RVA: 0x0028F3DF File Offset: 0x0028D5DF
		public int Cntmax1_Int32
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700480E RID: 18446
		// (get) Token: 0x06011871 RID: 71793 RVA: 0x0028F3E1 File Offset: 0x0028D5E1
		// (set) Token: 0x06011872 RID: 71794 RVA: 0x0028F3E4 File Offset: 0x0028D5E4
		public ushort Cntmax2_UInt16
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700480F RID: 18447
		// (get) Token: 0x06011873 RID: 71795 RVA: 0x0028F3E6 File Offset: 0x0028D5E6
		// (set) Token: 0x06011874 RID: 71796 RVA: 0x0028F3E9 File Offset: 0x0028D5E9
		public int Cntmax2_Int32
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17004810 RID: 18448
		// (get) Token: 0x06011875 RID: 71797 RVA: 0x0028F3EB File Offset: 0x0028D5EB
		// (set) Token: 0x06011876 RID: 71798 RVA: 0x0028F3EE File Offset: 0x0028D5EE
		public ushort Cntmax3_UInt16
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17004811 RID: 18449
		// (get) Token: 0x06011877 RID: 71799 RVA: 0x0028F3F0 File Offset: 0x0028D5F0
		// (set) Token: 0x06011878 RID: 71800 RVA: 0x0028F3F3 File Offset: 0x0028D5F3
		public int Cntmax3_Int32
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17004812 RID: 18450
		// (get) Token: 0x06011879 RID: 71801 RVA: 0x0028F3F5 File Offset: 0x0028D5F5
		// (set) Token: 0x0601187A RID: 71802 RVA: 0x0028F3FD File Offset: 0x0028D5FD
		public bool Enabled
		{
			get
			{
				return this.m_Enabled;
			}
			set
			{
				this.m_Enabled = value;
			}
		}

		// Token: 0x17004813 RID: 18451
		// (get) Token: 0x0601187B RID: 71803 RVA: 0x0028F406 File Offset: 0x0028D606
		public IMinMaxCurve Rate
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004814 RID: 18452
		// (get) Token: 0x0601187C RID: 71804 RVA: 0x0028F409 File Offset: 0x0028D609
		public IMinMaxCurve RateOverDistance
		{
			[return: NotNull]
			get
			{
				return this.m_RateOverDistance;
			}
		}

		// Token: 0x17004815 RID: 18453
		// (get) Token: 0x0601187D RID: 71805 RVA: 0x0028F411 File Offset: 0x0028D611
		public IMinMaxCurve RateOverTime
		{
			[return: NotNull]
			get
			{
				return this.m_RateOverTime;
			}
		}

		// Token: 0x17004816 RID: 18454
		// (get) Token: 0x0601187E RID: 71806 RVA: 0x0028F419 File Offset: 0x0028D619
		// (set) Token: 0x0601187F RID: 71807 RVA: 0x0028F420 File Offset: 0x0028D620
		public float Time0
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17004817 RID: 18455
		// (get) Token: 0x06011880 RID: 71808 RVA: 0x0028F422 File Offset: 0x0028D622
		// (set) Token: 0x06011881 RID: 71809 RVA: 0x0028F429 File Offset: 0x0028D629
		public float Time1
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17004818 RID: 18456
		// (get) Token: 0x06011882 RID: 71810 RVA: 0x0028F42B File Offset: 0x0028D62B
		// (set) Token: 0x06011883 RID: 71811 RVA: 0x0028F432 File Offset: 0x0028D632
		public float Time2
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17004819 RID: 18457
		// (get) Token: 0x06011884 RID: 71812 RVA: 0x0028F434 File Offset: 0x0028D634
		// (set) Token: 0x06011885 RID: 71813 RVA: 0x0028F43B File Offset: 0x0028D63B
		public float Time3
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700481A RID: 18458
		// (get) Token: 0x06011886 RID: 71814 RVA: 0x0028F43D File Offset: 0x0028D63D
		// (set) Token: 0x06011887 RID: 71815 RVA: 0x0028F440 File Offset: 0x0028D640
		public int Type
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700481B RID: 18459
		// (get) Token: 0x06011888 RID: 71816 RVA: 0x0028F442 File Offset: 0x0028D642
		// (set) Token: 0x06011889 RID: 71817 RVA: 0x0028F445 File Offset: 0x0028D645
		public ParticleSystemEmissionType TypeE
		{
			get
			{
				return ParticleSystemEmissionType.Time;
			}
			set
			{
			}
		}

		// Token: 0x0601188A RID: 71818 RVA: 0x0028F447 File Offset: 0x0028D647
		public EmissionModule_2017_1_0_b3_GICB2()
		{
			this.m_RateOverTime = new MinMaxCurve_2017_1_0_b3();
			this.m_RateOverDistance = new MinMaxCurve_2017_1_0_b3();
			this.m_Bursts = new AssetList<ParticleSystemEmissionBurst_5_6_0_b5>();
		}

		// Token: 0x0601188B RID: 71819 RVA: 0x0028F470 File Offset: 0x0028D670
		public bool Has_BurstCount_Byte()
		{
			return false;
		}

		// Token: 0x0601188C RID: 71820 RVA: 0x0028F473 File Offset: 0x0028D673
		public bool Has_BurstCount_Int32()
		{
			return true;
		}

		// Token: 0x0601188D RID: 71821 RVA: 0x0028F476 File Offset: 0x0028D676
		public bool Has_Bursts()
		{
			return true;
		}

		// Token: 0x0601188E RID: 71822 RVA: 0x0028F479 File Offset: 0x0028D679
		public bool Has_Cnt0_UInt16()
		{
			return false;
		}

		// Token: 0x0601188F RID: 71823 RVA: 0x0028F47C File Offset: 0x0028D67C
		public bool Has_Cnt0_Int32()
		{
			return false;
		}

		// Token: 0x06011890 RID: 71824 RVA: 0x0028F47F File Offset: 0x0028D67F
		public bool Has_Cnt1_UInt16()
		{
			return false;
		}

		// Token: 0x06011891 RID: 71825 RVA: 0x0028F482 File Offset: 0x0028D682
		public bool Has_Cnt1_Int32()
		{
			return false;
		}

		// Token: 0x06011892 RID: 71826 RVA: 0x0028F485 File Offset: 0x0028D685
		public bool Has_Cnt2_UInt16()
		{
			return false;
		}

		// Token: 0x06011893 RID: 71827 RVA: 0x0028F488 File Offset: 0x0028D688
		public bool Has_Cnt2_Int32()
		{
			return false;
		}

		// Token: 0x06011894 RID: 71828 RVA: 0x0028F48B File Offset: 0x0028D68B
		public bool Has_Cnt3_UInt16()
		{
			return false;
		}

		// Token: 0x06011895 RID: 71829 RVA: 0x0028F48E File Offset: 0x0028D68E
		public bool Has_Cnt3_Int32()
		{
			return false;
		}

		// Token: 0x06011896 RID: 71830 RVA: 0x0028F491 File Offset: 0x0028D691
		public bool Has_Cntmax0_UInt16()
		{
			return false;
		}

		// Token: 0x06011897 RID: 71831 RVA: 0x0028F494 File Offset: 0x0028D694
		public bool Has_Cntmax0_Int32()
		{
			return false;
		}

		// Token: 0x06011898 RID: 71832 RVA: 0x0028F497 File Offset: 0x0028D697
		public bool Has_Cntmax1_UInt16()
		{
			return false;
		}

		// Token: 0x06011899 RID: 71833 RVA: 0x0028F49A File Offset: 0x0028D69A
		public bool Has_Cntmax1_Int32()
		{
			return false;
		}

		// Token: 0x0601189A RID: 71834 RVA: 0x0028F49D File Offset: 0x0028D69D
		public bool Has_Cntmax2_UInt16()
		{
			return false;
		}

		// Token: 0x0601189B RID: 71835 RVA: 0x0028F4A0 File Offset: 0x0028D6A0
		public bool Has_Cntmax2_Int32()
		{
			return false;
		}

		// Token: 0x0601189C RID: 71836 RVA: 0x0028F4A3 File Offset: 0x0028D6A3
		public bool Has_Cntmax3_UInt16()
		{
			return false;
		}

		// Token: 0x0601189D RID: 71837 RVA: 0x0028F4A6 File Offset: 0x0028D6A6
		public bool Has_Cntmax3_Int32()
		{
			return false;
		}

		// Token: 0x0601189E RID: 71838 RVA: 0x0028F4A9 File Offset: 0x0028D6A9
		public bool Has_Rate()
		{
			return false;
		}

		// Token: 0x0601189F RID: 71839 RVA: 0x0028F4AC File Offset: 0x0028D6AC
		public bool Has_RateOverDistance()
		{
			return true;
		}

		// Token: 0x060118A0 RID: 71840 RVA: 0x0028F4AF File Offset: 0x0028D6AF
		public bool Has_RateOverTime()
		{
			return true;
		}

		// Token: 0x060118A1 RID: 71841 RVA: 0x0028F4B2 File Offset: 0x0028D6B2
		public bool Has_Time0()
		{
			return false;
		}

		// Token: 0x060118A2 RID: 71842 RVA: 0x0028F4B5 File Offset: 0x0028D6B5
		public bool Has_Time1()
		{
			return false;
		}

		// Token: 0x060118A3 RID: 71843 RVA: 0x0028F4B8 File Offset: 0x0028D6B8
		public bool Has_Time2()
		{
			return false;
		}

		// Token: 0x060118A4 RID: 71844 RVA: 0x0028F4BB File Offset: 0x0028D6BB
		public bool Has_Time3()
		{
			return false;
		}

		// Token: 0x060118A5 RID: 71845 RVA: 0x0028F4BE File Offset: 0x0028D6BE
		public bool Has_Type()
		{
			return false;
		}

		// Token: 0x060118A6 RID: 71846 RVA: 0x0028F4C1 File Offset: 0x0028D6C1

		public override void ReadRelease(AssetReader reader)
		{
			this.m_Enabled = reader.ReadRelease_BooleanAlign();
			this.m_RateOverTime.ReadRelease(reader);
			this.m_RateOverDistance.ReadRelease(reader);
			this.m_BurstCount = reader.ReadRelease_Int32Align();
			this.m_Bursts.ReadRelease_ArrayAlign_Asset(reader);
			PlacingOnGround = reader.ReadBoolean();
			KeepVisible = reader.ReadBoolean();
			reader.AlignStream();
			DetectLen = reader.ReadSingle();
			YDelta = reader.ReadSingle();
			LayerMask = reader.ReadUInt32();
			EmissionLevel = reader.ReadAsset<Vector4f_3_5_0>();
			EmissionFalloffStart = reader.ReadSingle();
			EmissionFalloffEnd = reader.ReadSingle();
			EnableFallOff = reader.ReadBoolean();
			reader.AlignStream();
		}

		// Token: 0x060118A7 RID: 71847 RVA: 0x0028F4FF File Offset: 0x0028D6FF

		public override void ReadEditor(AssetReader reader)
		{
			// this.m_Enabled = reader.ReadEditor_BooleanAlign();
			// this.m_RateOverTime.ReadEditor(reader);
			// this.m_RateOverDistance.ReadEditor(reader);
			// this.m_BurstCount = reader.ReadEditor_Int32Align();
			// this.m_Bursts.ReadEditor_ArrayAlign_Asset(reader);
		}

		// Token: 0x060118A8 RID: 71848 RVA: 0x0028F53D File Offset: 0x0028D73D

		public override void WriteRelease(AssetWriter writer)
		{
			this.m_Enabled.WriteRelease_BooleanAlign(writer);
			this.m_RateOverTime.WriteRelease(writer);
			this.m_RateOverDistance.WriteRelease(writer);
			this.m_BurstCount.WriteRelease_Int32Align(writer);
			this.m_Bursts.WriteRelease_ArrayAlign_Asset(writer);
		}

		// Token: 0x060118A9 RID: 71849 RVA: 0x0028F57B File Offset: 0x0028D77B

		public override void WriteEditor(AssetWriter writer)
		{
			// this.m_Enabled.WriteEditor_BooleanAlign(writer);
			// this.m_RateOverTime.WriteEditor(writer);
			// this.m_RateOverDistance.WriteEditor(writer);
			// this.m_BurstCount.WriteEditor_Int32Align(writer);
			// this.m_Bursts.WriteEditor_ArrayAlign_Asset(writer);
		}

		// Token: 0x060118AA RID: 71850 RVA: 0x0028F5BC File Offset: 0x0028D7BC

		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 4);
			yamlMappingNode.Add(new YamlScalarNode("enabled"), this.m_Enabled.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("rateOverTime"), this.m_RateOverTime.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("rateOverDistance"), this.m_RateOverDistance.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_BurstCount"), this.m_BurstCount.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Bursts"), this.m_Bursts.ExportYamlRelease_Array_ParticleSystemEmissionBurst_5_6_0_b5(container));
			return yamlMappingNode;
		}

		// Token: 0x060118AB RID: 71851 RVA: 0x0028F664 File Offset: 0x0028D864

		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 4);
			yamlMappingNode.Add(new YamlScalarNode("enabled"), this.m_Enabled.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("rateOverTime"), this.m_RateOverTime.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("rateOverDistance"), this.m_RateOverDistance.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_BurstCount"), this.m_BurstCount.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Bursts"), this.m_Bursts.ExportYamlEditor_Array_ParticleSystemEmissionBurst_5_6_0_b5(container));
			return yamlMappingNode;
		}

		// Token: 0x060118AC RID: 71852 RVA: 0x0028F709 File Offset: 0x0028D909
		public override void Reset()
		{
			this.m_BurstCount = 0;
			this.m_Bursts.Clear();
			this.m_Enabled = false;
			this.m_RateOverDistance.Reset();
			this.m_RateOverTime.Reset();
		}

		// Token: 0x060118AD RID: 71853 RVA: 0x0028F73A File Offset: 0x0028D93A
		public override IEnumerable<ValueTuple<FieldName, PPtr<IUnityObjectBase>>> FetchDependencies(FieldName parent)
		{
			return Enumerable.Empty<ValueTuple<FieldName, PPtr<IUnityObjectBase>>>();
		}

		// Token: 0x060118AE RID: 71854 RVA: 0x0028F744 File Offset: 0x0028D944
		public void CopyValues(IEmissionModule source)
		{
			if (source != null)
			{
				this.m_BurstCount = source.BurstCount_Int32;
				CopyValuesHelper.CopyValues__AssetList_ParticleSystemEmissionBurst_5_6_0_b5__AccessListBase_IParticleSystemEmissionBurst(this.m_Bursts, source.Bursts);
				this.m_Enabled = source.Enabled;
				this.m_RateOverDistance.CopyValues(source.RateOverDistance);
				this.m_RateOverTime.CopyValues(source.RateOverTime);
				return;
			}
			this.Reset();
		}

		// Token: 0x060118AF RID: 71855 RVA: 0x0028F7A6 File Offset: 0x0028D9A6

		public IEmissionModule DeepClone()
		{
			EmissionModule_2017_1_0_b3 emissionModule_2017_1_0_b = new EmissionModule_2017_1_0_b3();
			emissionModule_2017_1_0_b.CopyValues(this);
			return emissionModule_2017_1_0_b;
		}

		// Token: 0x060118B0 RID: 71856 RVA: 0x0028F7B4 File Offset: 0x0028D9B4
		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			IEmissionModule emissionModule = source as IEmissionModule;
			if (emissionModule != null)
			{
				this.CopyValues(emissionModule);
				return;
			}
			this.Reset();
		}

		// Token: 0x060118B1 RID: 71857 RVA: 0x0028F7DC File Offset: 0x0028D9DC
		public bool Equals(IEmissionModule other)
		{
			return other != null && this.BurstCount_Byte == other.BurstCount_Byte && this.BurstCount_Int32 == other.BurstCount_Int32 && EqualityComparer<AccessListBase<IParticleSystemEmissionBurst>>.Default.Equals(this.Bursts, other.Bursts) && this.Cnt0_UInt16 == other.Cnt0_UInt16 && this.Cnt0_Int32 == other.Cnt0_Int32 && this.Cnt1_UInt16 == other.Cnt1_UInt16 && this.Cnt1_Int32 == other.Cnt1_Int32 && this.Cnt2_UInt16 == other.Cnt2_UInt16 && this.Cnt2_Int32 == other.Cnt2_Int32 && this.Cnt3_UInt16 == other.Cnt3_UInt16 && this.Cnt3_Int32 == other.Cnt3_Int32 && this.Cntmax0_UInt16 == other.Cntmax0_UInt16 && this.Cntmax0_Int32 == other.Cntmax0_Int32 && this.Cntmax1_UInt16 == other.Cntmax1_UInt16 && this.Cntmax1_Int32 == other.Cntmax1_Int32 && this.Cntmax2_UInt16 == other.Cntmax2_UInt16 && this.Cntmax2_Int32 == other.Cntmax2_Int32 && this.Cntmax3_UInt16 == other.Cntmax3_UInt16 && this.Cntmax3_Int32 == other.Cntmax3_Int32 && this.Enabled == other.Enabled && EqualityComparer<IMinMaxCurve>.Default.Equals(this.Rate, other.Rate) && EqualityComparer<IMinMaxCurve>.Default.Equals(this.RateOverDistance, other.RateOverDistance) && EqualityComparer<IMinMaxCurve>.Default.Equals(this.RateOverTime, other.RateOverTime) && this.Time0 == other.Time0 && this.Time1 == other.Time1 && this.Time2 == other.Time2 && this.Time3 == other.Time3 && this.Type == other.Type;
		}

		// Token: 0x060118B2 RID: 71858 RVA: 0x0028F9E0 File Offset: 0x0028DBE0
		public bool Equals(EmissionModule_2017_1_0_b3 other)
		{
			return other != null && this.m_Enabled == other.m_Enabled && EqualityComparer<MinMaxCurve_2017_1_0_b3>.Default.Equals(this.m_RateOverTime, other.m_RateOverTime) && EqualityComparer<MinMaxCurve_2017_1_0_b3>.Default.Equals(this.m_RateOverDistance, other.m_RateOverDistance) && this.m_BurstCount == other.m_BurstCount && EqualityComparer<AssetList<ParticleSystemEmissionBurst_5_6_0_b5>>.Default.Equals(this.m_Bursts, other.m_Bursts);
		}

		// Token: 0x060118B3 RID: 71859 RVA: 0x0028FA57 File Offset: 0x0028DC57
		public override bool Equals(object other)
		{
			return this.Equals(other as IEmissionModule);
		}

		// Token: 0x060118B4 RID: 71860 RVA: 0x0028FA65 File Offset: 0x0028DC65
		public static bool operator ==(EmissionModule_2017_1_0_b3_GICB2 left, EmissionModule_2017_1_0_b3_GICB2 right)
		{
			return EqualityComparer<EmissionModule_2017_1_0_b3_GICB2>.Default.Equals(left, right);
		}

		// Token: 0x060118B5 RID: 71861 RVA: 0x0028FA73 File Offset: 0x0028DC73
		public static bool operator !=(EmissionModule_2017_1_0_b3_GICB2 left, EmissionModule_2017_1_0_b3_GICB2 right)
		{
			return !(left == right);
		}

		// Token: 0x060118B6 RID: 71862 RVA: 0x0028FA80 File Offset: 0x0028DC80
		public override int GetHashCode()
		{
			HashCode hashCode = default(HashCode);
			hashCode.Add<byte>(this.BurstCount_Byte);
			hashCode.Add<int>(this.BurstCount_Int32);
			hashCode.Add<AccessListBase<IParticleSystemEmissionBurst>>(this.Bursts);
			hashCode.Add<ushort>(this.Cnt0_UInt16);
			hashCode.Add<int>(this.Cnt0_Int32);
			hashCode.Add<ushort>(this.Cnt1_UInt16);
			hashCode.Add<int>(this.Cnt1_Int32);
			hashCode.Add<ushort>(this.Cnt2_UInt16);
			hashCode.Add<int>(this.Cnt2_Int32);
			hashCode.Add<ushort>(this.Cnt3_UInt16);
			hashCode.Add<int>(this.Cnt3_Int32);
			hashCode.Add<ushort>(this.Cntmax0_UInt16);
			hashCode.Add<int>(this.Cntmax0_Int32);
			hashCode.Add<ushort>(this.Cntmax1_UInt16);
			hashCode.Add<int>(this.Cntmax1_Int32);
			hashCode.Add<ushort>(this.Cntmax2_UInt16);
			hashCode.Add<int>(this.Cntmax2_Int32);
			hashCode.Add<ushort>(this.Cntmax3_UInt16);
			hashCode.Add<int>(this.Cntmax3_Int32);
			hashCode.Add<bool>(this.Enabled);
			hashCode.Add<IMinMaxCurve>(this.Rate);
			hashCode.Add<IMinMaxCurve>(this.RateOverDistance);
			hashCode.Add<IMinMaxCurve>(this.RateOverTime);
			hashCode.Add<float>(this.Time0);
			hashCode.Add<float>(this.Time1);
			hashCode.Add<float>(this.Time2);
			hashCode.Add<float>(this.Time3);
			hashCode.Add<int>(this.Type);
			return hashCode.ToHashCode();
		}

		// Token: 0x060118B7 RID: 71863 RVA: 0x0028FC08 File Offset: 0x0028DE08

		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060118B8 RID: 71864 RVA: 0x0028FC0F File Offset: 0x0028DE0F

		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04002ABE RID: 10942
		public bool m_Enabled;

		// Token: 0x04002ABF RID: 10943

		public MinMaxCurve_2017_1_0_b3 m_RateOverTime;

		// Token: 0x04002AC0 RID: 10944

		public MinMaxCurve_2017_1_0_b3 m_RateOverDistance;

		// Token: 0x04002AC1 RID: 10945
		public int m_BurstCount;

		// Token: 0x04002AC2 RID: 10946

		public AssetList<ParticleSystemEmissionBurst_5_6_0_b5> m_Bursts;

		public bool PlacingOnGround { get; set; }
		public bool KeepVisible { get; set; }
		public float DetectLen { get; set; }
		public float YDelta { get; set; }
		public uint LayerMask { get; set; }
		public Vector4f_3_5_0 EmissionLevel { get; set; }
		public float EmissionFalloffStart { get; set; }
		public float EmissionFalloffEnd { get; set; }
		public bool EnableFallOff { get; set; }
	}
}
