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
using AssetRipper.SourceGenerated.Classes.ClassID_0;
using AssetRipper.SourceGenerated.Classes.ClassID_1120;
using AssetRipper.SourceGenerated.Classes.ClassID_3;
using AssetRipper.SourceGenerated.Classes.ClassID_850595691;
using AssetRipper.SourceGenerated.Classes.ClassID_9;
using AssetRipper.SourceGenerated.Enums;
using AssetRipper.SourceGenerated.Helpers;
using AssetRipper.SourceGenerated.Interfaces;
using AssetRipper.SourceGenerated.MarkerInterfaces;
using AssetRipper.SourceGenerated.Subclasses.EnlightenSceneMapping;
using AssetRipper.SourceGenerated.Subclasses.GISettings;
using AssetRipper.SourceGenerated.Subclasses.LightmapData;
using AssetRipper.SourceGenerated.Subclasses.LightmapEditorSettings;
using AssetRipper.SourceGenerated.Subclasses.PPtr_LightingDataAsset;
using AssetRipper.SourceGenerated.Subclasses.PPtr_LightingSettings;
using AssetRipper.SourceGenerated.Subclasses.PPtr_LightmapSnapshot;
using AssetRipper.SourceGenerated.Subclasses.PPtr_LightProbes;
using AssetRipper.Yaml;
using AssetRipper.SourceGenerated.Classes.ClassID_157;

namespace AssetRipper.Import.GICB2.LightmapSettings
{
	// Token: 0x02002FB1 RID: 12209


	public sealed class LightmapSettings_2017_1_0_GICB2 : LevelGameManager, ILightmapSettings, IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, ILightmapSettingsMarker, ILevelGameManager, IGameManager, IGameManagerMarker, IObject, IObjectMarker, IHasHideFlags, ILevelGameManagerMarker
	{
		// Token: 0x1701982D RID: 104493
		// (get) Token: 0x0604A001 RID: 303105 RVA: 0x00980357 File Offset: 0x0097E557
		// (set) Token: 0x0604A002 RID: 303106 RVA: 0x0098035A File Offset: 0x0097E55A
		public int BakedColorSpace_C157
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1701982E RID: 104494
		// (get) Token: 0x0604A003 RID: 303107 RVA: 0x0098035C File Offset: 0x0097E55C
		public IEnlightenSceneMapping EnlightenSceneMapping_C157
		{
			[return: NotNull]
			get
			{
				return this.m_EnlightenSceneMapping;
			}
		}

		// Token: 0x1701982F RID: 104495
		// (get) Token: 0x0604A004 RID: 303108 RVA: 0x00980364 File Offset: 0x0097E564
		public IGISettings GISettings_C157
		{
			[return: NotNull]
			get
			{
				return this.m_GISettings;
			}
		}

		// Token: 0x17019830 RID: 104496
		// (get) Token: 0x0604A005 RID: 303109 RVA: 0x0098036C File Offset: 0x0097E56C
		// (set) Token: 0x0604A006 RID: 303110 RVA: 0x00980374 File Offset: 0x0097E574
		public int GIWorkflowMode_C157
		{
			get
			{
				return this.m_GIWorkflowMode;
			}
			set
			{
				this.m_GIWorkflowMode = value;
			}
		}

		// Token: 0x17019831 RID: 104497
		// (get) Token: 0x0604A007 RID: 303111 RVA: 0x0098037D File Offset: 0x0097E57D
		// (set) Token: 0x0604A008 RID: 303112 RVA: 0x00980385 File Offset: 0x0097E585
		public uint HideFlags_C157
		{
			get
			{
				return this.m_HideFlags;
			}
			set
			{
				this.m_HideFlags = value;
			}
		}

		// Token: 0x17019832 RID: 104498
		// (get) Token: 0x0604A009 RID: 303113 RVA: 0x0098038E File Offset: 0x0097E58E
		public PPtr_LightingDataAsset LightingDataAsset_C157
		{
			[return: NotNull]
			get
			{
				return this.m_LightingDataAsset;
			}
		}

		// Token: 0x17019833 RID: 104499
		// (get) Token: 0x0604A00A RID: 303114 RVA: 0x00980396 File Offset: 0x0097E596
		public PPtr_LightingSettings LightingSettings_C157
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17019834 RID: 104500
		// (get) Token: 0x0604A00B RID: 303115 RVA: 0x00980399 File Offset: 0x0097E599

		public ILightmapEditorSettings LightmapEditorSettings_C157
		{

			get
			{
				return this.m_LightmapEditorSettings;
			}
		}

		// Token: 0x17019835 RID: 104501
		// (get) Token: 0x0604A00C RID: 303116 RVA: 0x009803A1 File Offset: 0x0097E5A1

		public AccessListBase<ILightmapData> Lightmaps_C157
		{

			get
			{
				return new AccessList<LightmapData_5_6_0_b2, ILightmapData>(this.m_Lightmaps);
			}
		}

		// Token: 0x17019836 RID: 104502
		// (get) Token: 0x0604A00D RID: 303117 RVA: 0x009803AE File Offset: 0x0097E5AE
		// (set) Token: 0x0604A00E RID: 303118 RVA: 0x009803B6 File Offset: 0x0097E5B6
		public int LightmapsMode_C157
		{
			get
			{
				return this.m_LightmapsMode;
			}
			set
			{
				this.m_LightmapsMode = value;
			}
		}

		// Token: 0x17019837 RID: 104503
		// (get) Token: 0x0604A00F RID: 303119 RVA: 0x009803BF File Offset: 0x0097E5BF
		public PPtr_LightmapSnapshot LightmapSnapshot_C157
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17019838 RID: 104504
		// (get) Token: 0x0604A010 RID: 303120 RVA: 0x009803C2 File Offset: 0x0097E5C2
		public IPPtr_LightProbes LightProbes_C157
		{
			[return: NotNull]
			get
			{
				return this.m_LightProbes;
			}
		}

		// Token: 0x17019839 RID: 104505
		// (get) Token: 0x0604A011 RID: 303121 RVA: 0x009803CA File Offset: 0x0097E5CA
		// (set) Token: 0x0604A012 RID: 303122 RVA: 0x009803CD File Offset: 0x0097E5CD
		public int RuntimeCPUUsage_C157
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1701983A RID: 104506
		// (get) Token: 0x0604A013 RID: 303123 RVA: 0x009803CF File Offset: 0x0097E5CF
		// (set) Token: 0x0604A014 RID: 303124 RVA: 0x009803D2 File Offset: 0x0097E5D2
		public int ShadowMaskMode_C157
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1701983B RID: 104507
		// (get) Token: 0x0604A015 RID: 303125 RVA: 0x009803D4 File Offset: 0x0097E5D4
		// (set) Token: 0x0604A016 RID: 303126 RVA: 0x009803D7 File Offset: 0x0097E5D7
		public bool UseDualLightmapsInForward_C157
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1701983C RID: 104508
		// (get) Token: 0x0604A017 RID: 303127 RVA: 0x009803D9 File Offset: 0x0097E5D9
		// (set) Token: 0x0604A018 RID: 303128 RVA: 0x009803E1 File Offset: 0x0097E5E1
		public bool UseShadowmask_C157
		{
			get
			{
				return this.m_UseShadowmask;
			}
			set
			{
				this.m_UseShadowmask = value;
			}
		}

		// Token: 0x1701983D RID: 104509
		// (get) Token: 0x0604A019 RID: 303129 RVA: 0x009803EA File Offset: 0x0097E5EA
		// (set) Token: 0x0604A01A RID: 303130 RVA: 0x009803ED File Offset: 0x0097E5ED
		public ColorSpace BakedColorSpace_C157E
		{
			get
			{
				return ColorSpace.Gamma;
			}
			set
			{
			}
		}

		// Token: 0x1701983E RID: 104510
		// (get) Token: 0x0604A01B RID: 303131 RVA: 0x009803EF File Offset: 0x0097E5EF
		// (set) Token: 0x0604A01C RID: 303132 RVA: 0x009803F7 File Offset: 0x0097E5F7
		public HideFlags HideFlags_C157E
		{
			get
			{
				return (HideFlags)this.m_HideFlags;
			}
			set
			{
				this.m_HideFlags = (uint)value;
			}
		}

		// Token: 0x1701983F RID: 104511
		// (get) Token: 0x0604A01D RID: 303133 RVA: 0x00980400 File Offset: 0x0097E600
		// (set) Token: 0x0604A01E RID: 303134 RVA: 0x00980408 File Offset: 0x0097E608
		public LightmapsMode LightmapsMode_C157E
		{
			get
			{
				return (LightmapsMode)this.m_LightmapsMode;
			}
			set
			{
				this.m_LightmapsMode = (int)value;
			}
		}

		// Token: 0x17019840 RID: 104512
		// (get) Token: 0x0604A01F RID: 303135 RVA: 0x00980411 File Offset: 0x0097E611
		// (set) Token: 0x0604A020 RID: 303136 RVA: 0x00980424 File Offset: 0x0097E624
		public ILightingDataAsset LightingDataAsset_C157P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<ILightingDataAsset>(this.LightingDataAsset_C157, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<ILightingDataAsset>(this.LightingDataAsset_C157, base.Collection, value);
			}
		}

		// Token: 0x17019841 RID: 104513
		// (get) Token: 0x0604A021 RID: 303137 RVA: 0x00980438 File Offset: 0x0097E638
		// (set) Token: 0x0604A022 RID: 303138 RVA: 0x0098043B File Offset: 0x0097E63B
		public ILightingSettings LightingSettings_C157P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17019842 RID: 104514
		// (get) Token: 0x0604A023 RID: 303139 RVA: 0x0098043D File Offset: 0x0097E63D
		// (set) Token: 0x0604A024 RID: 303140 RVA: 0x00980440 File Offset: 0x0097E640
		public ILightingDataAsset LightmapSnapshot_C157P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17019843 RID: 104515
		// (get) Token: 0x0604A025 RID: 303141 RVA: 0x00980442 File Offset: 0x0097E642
		// (set) Token: 0x0604A026 RID: 303142 RVA: 0x00980455 File Offset: 0x0097E655
		public ILightProbesMarker LightProbes_C157P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<ILightProbesMarker>(this.LightProbes_C157, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<ILightProbesMarker>(this.LightProbes_C157, base.Collection, value);
			}
		}

		// Token: 0x17019844 RID: 104516
		// (get) Token: 0x0604A027 RID: 303143 RVA: 0x00980469 File Offset: 0x0097E669

		public override string ClassName
		{

			get
			{
				return "LightmapSettings";
			}
		}

		// Token: 0x0604A028 RID: 303144 RVA: 0x00980470 File Offset: 0x0097E670
		public LightmapSettings_2017_1_0_GICB2()
			: this(AssetInfo.MakeDummyAssetInfo(157))
		{
		}

		// Token: 0x0604A029 RID: 303145 RVA: 0x00980484 File Offset: 0x0097E684
		public LightmapSettings_2017_1_0_GICB2(AssetInfo info)
			: base(info)
		{
			this.m_EnlightenSceneMapping = new EnlightenSceneMapping_2017_1_0();
			this.m_LightProbes = new PPtr_LightProbes_5_0_0();
			this.m_Lightmaps = new AssetList<LightmapData_5_6_0_b2>();
			this.m_LightmapEditorSettings = new LightmapEditorSettings_2017_1_0();
			this.m_LightingDataAsset = new PPtr_LightingDataAsset();
			this.m_GISettings = new GISettings_5_0_0();
		}

		// Token: 0x0604A02A RID: 303146 RVA: 0x009804DA File Offset: 0x0097E6DA
		public bool Has_BakedColorSpace_C157()
		{
			return false;
		}

		// Token: 0x0604A02B RID: 303147 RVA: 0x009804DD File Offset: 0x0097E6DD
		public bool Has_EnlightenSceneMapping_C157()
		{
			return true;
		}

		// Token: 0x0604A02C RID: 303148 RVA: 0x009804E0 File Offset: 0x0097E6E0
		public bool Has_GISettings_C157()
		{
			return true;
		}

		// Token: 0x0604A02D RID: 303149 RVA: 0x009804E3 File Offset: 0x0097E6E3
		public bool Has_GIWorkflowMode_C157()
		{
			return true;
		}

		// Token: 0x0604A02E RID: 303150 RVA: 0x009804E6 File Offset: 0x0097E6E6
		public bool Has_LightingDataAsset_C157()
		{
			return true;
		}

		// Token: 0x0604A02F RID: 303151 RVA: 0x009804E9 File Offset: 0x0097E6E9
		public bool Has_LightingSettings_C157()
		{
			return false;
		}

		// Token: 0x0604A030 RID: 303152 RVA: 0x009804EC File Offset: 0x0097E6EC
		public bool Has_LightmapSnapshot_C157()
		{
			return false;
		}

		// Token: 0x0604A031 RID: 303153 RVA: 0x009804EF File Offset: 0x0097E6EF
		public bool Has_LightProbes_C157()
		{
			return true;
		}

		// Token: 0x0604A032 RID: 303154 RVA: 0x009804F2 File Offset: 0x0097E6F2
		public bool Has_RuntimeCPUUsage_C157()
		{
			return false;
		}

		// Token: 0x0604A033 RID: 303155 RVA: 0x009804F5 File Offset: 0x0097E6F5
		public bool Has_ShadowMaskMode_C157()
		{
			return false;
		}

		// Token: 0x0604A034 RID: 303156 RVA: 0x009804F8 File Offset: 0x0097E6F8
		public bool Has_UseDualLightmapsInForward_C157()
		{
			return false;
		}

		// Token: 0x0604A035 RID: 303157 RVA: 0x009804FB File Offset: 0x0097E6FB
		public bool Has_UseShadowmask_C157()
		{
			return true;
		}

		// Token: 0x0604A036 RID: 303158 RVA: 0x00980500 File Offset: 0x0097E700

		public override void ReadRelease(AssetReader reader)
		{
			this.m_EnlightenSceneMapping.ReadRelease(reader);
			this.m_LightProbes.ReadRelease(reader);
			this.m_Lightmaps.ReadRelease_ArrayAlign_Asset(reader);
			this.m_LightmapsMode = reader.ReadRelease_Int32Align();
			this.m_GISettings.ReadRelease(reader);
			this.m_UseShadowmask = reader.ReadBoolean();
			this.UseLightMapSTBatch = reader.ReadBoolean();
			reader.AlignStream();
		}

		// Token: 0x0604A037 RID: 303159 RVA: 0x00980558 File Offset: 0x0097E758

		public override void ReadEditor(AssetReader reader)
		{
			// this.m_HideFlags = reader.ReadUInt32();
			// this.m_GIWorkflowMode = reader.ReadEditor_Int32Align();
			// this.m_GISettings.ReadEditor(reader);
			// this.m_LightmapEditorSettings.ReadEditor(reader);
			// this.m_LightingDataAsset.ReadEditor(reader);
			// this.m_UseShadowmask = reader.ReadBoolean();
		}

		// Token: 0x0604A038 RID: 303160 RVA: 0x009805B0 File Offset: 0x0097E7B0

		public override void WriteRelease(AssetWriter writer)
		{
			this.m_EnlightenSceneMapping.WriteRelease(writer);
			this.m_LightProbes.WriteRelease(writer);
			this.m_Lightmaps.WriteRelease_ArrayAlign_Asset(writer);
			this.m_LightmapsMode.WriteRelease_Int32Align(writer);
			this.m_GISettings.WriteRelease(writer);
			this.m_UseShadowmask.WriteRelease_Boolean(writer);
		}

		// Token: 0x0604A039 RID: 303161 RVA: 0x00980608 File Offset: 0x0097E808

		public override void WriteEditor(AssetWriter writer)
		{
			// this.m_HideFlags.WriteEditor_UInt32(writer);
			// this.m_GIWorkflowMode.WriteEditor_Int32Align(writer);
			// this.m_GISettings.WriteEditor(writer);
			// this.m_LightmapEditorSettings.WriteEditor(writer);
			// this.m_LightingDataAsset.WriteEditor(writer);
			// this.m_UseShadowmask.WriteEditor_Boolean(writer);
		}

		// Token: 0x0604A03A RID: 303162 RVA: 0x00980660 File Offset: 0x0097E860

		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 11);
			yamlMappingNode.Add(new YamlScalarNode("m_EnlightenSceneMapping"), this.m_EnlightenSceneMapping.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LightProbes"), this.m_LightProbes.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Lightmaps"), this.m_Lightmaps.ExportYamlRelease_Array_LightmapData_5_6_0_b2(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LightmapsMode"), this.m_LightmapsMode.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_GISettings"), this.m_GISettings.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_UseShadowmask"), this.m_UseShadowmask.ExportYamlRelease_Boolean(container));
			return yamlMappingNode;
		}

		// Token: 0x0604A03B RID: 303163 RVA: 0x00980724 File Offset: 0x0097E924

		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 11);
			yamlMappingNode.Add(new YamlScalarNode("m_ObjectHideFlags"), this.m_HideFlags.ExportYamlEditor_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_GIWorkflowMode"), this.m_GIWorkflowMode.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_GISettings"), this.m_GISettings.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LightmapEditorSettings"), this.m_LightmapEditorSettings.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LightingDataAsset"), this.m_LightingDataAsset.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_UseShadowmask"), this.m_UseShadowmask.ExportYamlEditor_Boolean(container));
			return yamlMappingNode;
		}

		// Token: 0x0604A03C RID: 303164 RVA: 0x009807E8 File Offset: 0x0097E9E8
		public override void Reset()
		{
			this.m_EnlightenSceneMapping.Reset();
			this.m_GISettings.Reset();
			this.m_GIWorkflowMode = 0;
			this.m_HideFlags = 0U;
			this.m_LightingDataAsset.Reset();
			this.m_LightmapEditorSettings.Reset();
			this.m_Lightmaps.Clear();
			this.m_LightmapsMode = 0;
			this.m_LightProbes.Reset();
			this.m_UseShadowmask = false;
		}

		// Token: 0x0604A03D RID: 303165 RVA: 0x00980853 File Offset: 0x0097EA53
		// [return: Nullable(new byte[] { 1, 0, 1, 0, 1 })]
		// public override IEnumerable<ValueTuple<FieldName, PPtr<IUnityObjectBase>>> FetchDependencies(FieldName parent)
		// {
		// 	return Enumerable.Empty<ValueTuple<FieldName, PPtr<IUnityObjectBase>>>().Append_LightmapSettings_2017_1_0(parent, this);
		// }

		// Token: 0x0604A03E RID: 303166 RVA: 0x00980864 File Offset: 0x0097EA64

		public void CopyValues(ILightmapSettings source, PPtrConverter converter)
		{
			this.m_EnlightenSceneMapping.CopyValues(source.EnlightenSceneMapping_C157, converter);
			this.m_GISettings.CopyValues(source.GISettings_C157);
			this.m_GIWorkflowMode = source.GIWorkflowMode_C157;
			this.m_HideFlags = source.HideFlags_C157;
			this.m_LightingDataAsset.CopyValues(source.LightingDataAsset_C157, converter);
			this.m_LightmapEditorSettings.CopyValues(source.LightmapEditorSettings_C157, converter);
			CopyValuesHelper.CopyValues__AssetList_LightmapData_5_6_0_b2__AccessListBase_ILightmapData(this.m_Lightmaps, source.Lightmaps_C157, converter);
			this.m_LightmapsMode = source.LightmapsMode_C157;
			this.m_LightProbes.CopyValues(source.LightProbes_C157, converter);
			this.m_UseShadowmask = source.UseShadowmask_C157;
		}

		// Token: 0x0604A03F RID: 303167 RVA: 0x0098090C File Offset: 0x0097EB0C

		public void CopyValues(ILightmapSettings source)
		{
			this.CopyValues(source, new PPtrConverter(source, this));
		}

		// Token: 0x0604A040 RID: 303168 RVA: 0x0098091C File Offset: 0x0097EB1C
		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			ILightmapSettings lightmapSettings = source as ILightmapSettings;
			if (lightmapSettings != null)
			{
				this.CopyValues(lightmapSettings, converter);
				return;
			}
			base.CopyValues(source, converter);
		}

		// Token: 0x0604A041 RID: 303169 RVA: 0x00980944 File Offset: 0x0097EB44

		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0604A042 RID: 303170 RVA: 0x0098094B File Offset: 0x0097EB4B

		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04015411 RID: 87057

		public EnlightenSceneMapping_2017_1_0 m_EnlightenSceneMapping;

		// Token: 0x04015412 RID: 87058

		public PPtr_LightProbes_5_0_0 m_LightProbes;

		// Token: 0x04015413 RID: 87059

		public AssetList<LightmapData_5_6_0_b2> m_Lightmaps;

		// Token: 0x04015414 RID: 87060
		public int m_LightmapsMode;

		// Token: 0x04015415 RID: 87061
		public int m_GIWorkflowMode;

		// Token: 0x04015416 RID: 87062

		public LightmapEditorSettings_2017_1_0 m_LightmapEditorSettings;

		// Token: 0x04015417 RID: 87063

		public PPtr_LightingDataAsset m_LightingDataAsset;

		// Token: 0x04015418 RID: 87064

		public GISettings_5_0_0 m_GISettings;

		// Token: 0x04015419 RID: 87065
		public bool m_UseShadowmask;
		public bool UseLightMapSTBatch { get; set; }
	}
}
