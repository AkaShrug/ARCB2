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
using AssetRipper.SourceGenerated.Classes.ClassID_1001;
using AssetRipper.SourceGenerated.Classes.ClassID_1001480554;
using AssetRipper.SourceGenerated.Classes.ClassID_1002;
using AssetRipper.SourceGenerated.Classes.ClassID_130;
using AssetRipper.SourceGenerated.Classes.ClassID_18;
using AssetRipper.SourceGenerated.Classes.ClassID_28;
using AssetRipper.SourceGenerated.Classes.ClassID_48;
using AssetRipper.SourceGenerated.Enums;
using AssetRipper.SourceGenerated.Helpers;
using AssetRipper.SourceGenerated.Interfaces;
using AssetRipper.SourceGenerated.MarkerInterfaces;
using AssetRipper.SourceGenerated.Subclasses.DetailDatabase;
using AssetRipper.SourceGenerated.Subclasses.Heightmap;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtensionImpl;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtension;
using AssetRipper.SourceGenerated.Subclasses.PPtr_PrefabInstance;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Prefab;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Shader;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Texture2D;
using AssetRipper.SourceGenerated.Subclasses.SplatDatabase;
using AssetRipper.SourceGenerated.Subclasses.Utf8String;
using AssetRipper.Yaml;

using AssetRipper.SourceGenerated.Classes.ClassID_156;
using AssetRipper.Import.GICB2.TerrainData.SplatDatabase;

namespace AssetRipper.Import.GICB2.TerrainData
{
	// Token: 0x02002FD0 RID: 12240


	public sealed class TerrainData_2017_1_0_GICB2 : NamedObject_5_0_0, ITerrainData, IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, ITerrainDataMarker, IHasName, IHasNameString, INamedObject, INamedObjectMarker, IEditorExtension, IEditorExtensionMarker, IObject, IObjectMarker, IHasHideFlags
	{
		// Token: 0x17019AB6 RID: 105142
		// (get) Token: 0x0604A6F6 RID: 304886 RVA: 0x0098A088 File Offset: 0x00988288
		public IPPtr_EditorExtension CorrespondingSourceObject_C156
		{
			[return: NotNull]
			get
			{
				return this.m_CorrespondingSourceObject;
			}
		}

		// Token: 0x17019AB7 RID: 105143
		// (get) Token: 0x0604A6F7 RID: 304887 RVA: 0x0098A090 File Offset: 0x00988290
		public PPtr_Texture2D_5_0_0 DefaultCheckerTexture_C156
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17019AB8 RID: 105144
		// (get) Token: 0x0604A6F8 RID: 304888 RVA: 0x0098A093 File Offset: 0x00988293

		public IDetailDatabase DetailDatabase_C156
		{

			get
			{
				return this.m_DetailDatabase;
			}
		}

		// Token: 0x17019AB9 RID: 105145
		// (get) Token: 0x0604A6F9 RID: 304889 RVA: 0x0098A09B File Offset: 0x0098829B
		public PPtr_EditorExtensionImpl ExtensionPtr_C156
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17019ABA RID: 105146
		// (get) Token: 0x0604A6FA RID: 304890 RVA: 0x0098A09E File Offset: 0x0098829E

		public IHeightmap Heightmap_C156
		{

			get
			{
				return this.m_Heightmap;
			}
		}

		// Token: 0x17019ABB RID: 105147
		// (get) Token: 0x0604A6FB RID: 304891 RVA: 0x0098A0A6 File Offset: 0x009882A6
		// (set) Token: 0x0604A6FC RID: 304892 RVA: 0x0098A0AE File Offset: 0x009882AE
		public uint HideFlags_C156
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

		// Token: 0x17019ABC RID: 105148
		// (get) Token: 0x0604A6FD RID: 304893 RVA: 0x0098A0B7 File Offset: 0x009882B7

		public Utf8String Name_C156
		{

			get
			{
				return this.m_Name;
			}
		}

		// Token: 0x17019ABD RID: 105149
		// (get) Token: 0x0604A6FE RID: 304894 RVA: 0x0098A0BF File Offset: 0x009882BF
		public PPtr_Prefab_2018_3_0 PrefabAsset_C156
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17019ABE RID: 105150
		// (get) Token: 0x0604A6FF RID: 304895 RVA: 0x0098A0C2 File Offset: 0x009882C2
		public PPtr_PrefabInstance PrefabInstance_C156
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17019ABF RID: 105151
		// (get) Token: 0x0604A700 RID: 304896 RVA: 0x0098A0C5 File Offset: 0x009882C5
		public IPPtr_Prefab PrefabInternal_C156
		{
			[return: NotNull]
			get
			{
				return this.m_PrefabInternal;
			}
		}

		// Token: 0x17019AC0 RID: 105152
		// (get) Token: 0x0604A701 RID: 304897 RVA: 0x0098A0CD File Offset: 0x009882CD

		public AssetList<PPtr_Shader_5_0_0> PreloadShaders_C156
		{

			get
			{
				return null;
			}
		}

		// Token: 0x17019AC1 RID: 105153
		// (get) Token: 0x0604A702 RID: 304898 RVA: 0x0098A0D0 File Offset: 0x009882D0

		public ISplatDatabase SplatDatabase_C156
		{

			get
			{
				return this.m_SplatDatabase;
			}
		}

		// Token: 0x17019AC2 RID: 105154
		// (get) Token: 0x0604A703 RID: 304899 RVA: 0x0098A0D8 File Offset: 0x009882D8
		// (set) Token: 0x0604A704 RID: 304900 RVA: 0x0098A0E0 File Offset: 0x009882E0
		public HideFlags HideFlags_C156E
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

		// Token: 0x17019AC3 RID: 105155
		// (get) Token: 0x0604A705 RID: 304901 RVA: 0x0098A0E9 File Offset: 0x009882E9
		// (set) Token: 0x0604A706 RID: 304902 RVA: 0x0098A0FC File Offset: 0x009882FC
		public IEditorExtension CorrespondingSourceObject_C156P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IEditorExtension>(this.CorrespondingSourceObject_C156, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IEditorExtension>(this.CorrespondingSourceObject_C156, base.Collection, value);
			}
		}

		// Token: 0x17019AC4 RID: 105156
		// (get) Token: 0x0604A707 RID: 304903 RVA: 0x0098A110 File Offset: 0x00988310
		// (set) Token: 0x0604A708 RID: 304904 RVA: 0x0098A113 File Offset: 0x00988313
		public ITexture2D DefaultCheckerTexture_C156P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17019AC5 RID: 105157
		// (get) Token: 0x0604A709 RID: 304905 RVA: 0x0098A115 File Offset: 0x00988315
		// (set) Token: 0x0604A70A RID: 304906 RVA: 0x0098A118 File Offset: 0x00988318
		public IEditorExtensionImpl ExtensionPtr_C156P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17019AC6 RID: 105158
		// (get) Token: 0x0604A70B RID: 304907 RVA: 0x0098A11A File Offset: 0x0098831A
		// (set) Token: 0x0604A70C RID: 304908 RVA: 0x0098A11D File Offset: 0x0098831D
		public IPrefab PrefabAsset_C156P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17019AC7 RID: 105159
		// (get) Token: 0x0604A70D RID: 304909 RVA: 0x0098A11F File Offset: 0x0098831F
		// (set) Token: 0x0604A70E RID: 304910 RVA: 0x0098A122 File Offset: 0x00988322
		public IPrefabInstance PrefabInstance_C156P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17019AC8 RID: 105160
		// (get) Token: 0x0604A70F RID: 304911 RVA: 0x0098A124 File Offset: 0x00988324
		// (set) Token: 0x0604A710 RID: 304912 RVA: 0x0098A137 File Offset: 0x00988337
		public IPrefabMarker PrefabInternal_C156P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IPrefabMarker>(this.PrefabInternal_C156, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IPrefabMarker>(this.PrefabInternal_C156, base.Collection, value);
			}
		}

		// Token: 0x17019AC9 RID: 105161
		// (get) Token: 0x0604A711 RID: 304913 RVA: 0x0098A14B File Offset: 0x0098834B

		public PPtrAccessList<PPtr_Shader_5_0_0, IShader> PreloadShaders_C156P
		{

			get
			{
				return PPtrAccessList<PPtr_Shader_5_0_0, IShader>.Empty;
			}
		}

		// Token: 0x17019ACA RID: 105162
		// (get) Token: 0x0604A712 RID: 304914 RVA: 0x0098A152 File Offset: 0x00988352

		public override string ClassName
		{

			get
			{
				return "TerrainData";
			}
		}

		// Token: 0x0604A713 RID: 304915 RVA: 0x0098A159 File Offset: 0x00988359
		public TerrainData_2017_1_0_GICB2()
			: this(AssetInfo.MakeDummyAssetInfo(156))
		{
		}

		// Token: 0x0604A714 RID: 304916 RVA: 0x0098A16B File Offset: 0x0098836B
		public TerrainData_2017_1_0_GICB2(AssetInfo info)
			: base(info)
		{
			this.m_SplatDatabase = new SplatDatabase_2017_1_0_GICB2();
			this.m_DetailDatabase = new DetailDatabase_2017_1_0();
			this.m_Heightmap = new Heightmap_2017_1_0();
		}

		// Token: 0x0604A715 RID: 304917 RVA: 0x0098A195 File Offset: 0x00988395
		public bool Has_CorrespondingSourceObject_C156()
		{
			return true;
		}

		// Token: 0x0604A716 RID: 304918 RVA: 0x0098A198 File Offset: 0x00988398
		public bool Has_DefaultCheckerTexture_C156()
		{
			return false;
		}

		// Token: 0x0604A717 RID: 304919 RVA: 0x0098A19B File Offset: 0x0098839B
		public bool Has_ExtensionPtr_C156()
		{
			return false;
		}

		// Token: 0x0604A718 RID: 304920 RVA: 0x0098A19E File Offset: 0x0098839E
		public bool Has_PrefabAsset_C156()
		{
			return false;
		}

		// Token: 0x0604A719 RID: 304921 RVA: 0x0098A1A1 File Offset: 0x009883A1
		public bool Has_PrefabInstance_C156()
		{
			return false;
		}

		// Token: 0x0604A71A RID: 304922 RVA: 0x0098A1A4 File Offset: 0x009883A4
		public bool Has_PrefabInternal_C156()
		{
			return true;
		}

		// Token: 0x0604A71B RID: 304923 RVA: 0x0098A1A7 File Offset: 0x009883A7
		public bool Has_PreloadShaders_C156()
		{
			return false;
		}

		// Token: 0x0604A71C RID: 304924 RVA: 0x0098A1AA File Offset: 0x009883AA

		public override void ReadRelease(AssetReader reader)
		{
			this.m_Name.ReadRelease(reader);
			this.m_SplatDatabase.ReadRelease(reader);
			this.m_DetailDatabase.ReadRelease(reader);
			this.m_Heightmap.ReadRelease(reader);
		}

		// Token: 0x0604A71D RID: 304925 RVA: 0x0098A1DC File Offset: 0x009883DC



		// Token: 0x0604A71E RID: 304926 RVA: 0x0098A23D File Offset: 0x0098843D

		public override void WriteRelease(AssetWriter writer)
		{
			this.m_Name.WriteRelease(writer);
			this.m_SplatDatabase.WriteRelease(writer);
			this.m_DetailDatabase.WriteRelease(writer);
			this.m_Heightmap.WriteRelease(writer);
		}

		// Token: 0x0604A71F RID: 304927 RVA: 0x0098A270 File Offset: 0x00988470



		// Token: 0x0604A720 RID: 304928 RVA: 0x0098A2D4 File Offset: 0x009884D4

		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 1);
			yamlMappingNode.Add(new YamlScalarNode("m_Name"), this.m_Name.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SplatDatabase"), this.m_SplatDatabase.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_DetailDatabase"), this.m_DetailDatabase.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Heightmap"), this.m_Heightmap.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0604A721 RID: 304929 RVA: 0x0098A360 File Offset: 0x00988560

		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 1);
			yamlMappingNode.Add(new YamlScalarNode("m_ObjectHideFlags"), this.m_HideFlags.ExportYamlEditor_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabParentObject"), this.m_CorrespondingSourceObject.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabInternal"), this.m_PrefabInternal.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Name"), this.m_Name.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SplatDatabase"), this.m_SplatDatabase.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_DetailDatabase"), this.m_DetailDatabase.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Heightmap"), this.m_Heightmap.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0604A722 RID: 304930 RVA: 0x0098A440 File Offset: 0x00988640
		public override void Reset()
		{
			this.m_CorrespondingSourceObject.Reset();
			this.m_DetailDatabase.Reset();
			this.m_Heightmap.Reset();
			this.m_HideFlags = 0U;
			this.m_Name.Reset();
			this.m_PrefabInternal.Reset();
			this.m_SplatDatabase.Reset();
		}

		// Token: 0x0604A723 RID: 304931 RVA: 0x0098A496 File Offset: 0x00988696



		// Token: 0x0604A724 RID: 304932 RVA: 0x0098A4A4 File Offset: 0x009886A4

		public void CopyValues(ITerrainData source, PPtrConverter converter)
		{
			this.m_CorrespondingSourceObject.CopyValues(source.CorrespondingSourceObject_C156, converter);
			this.m_DetailDatabase.CopyValues(source.DetailDatabase_C156, converter);
			this.m_Heightmap.CopyValues(source.Heightmap_C156, converter);
			this.m_HideFlags = source.HideFlags_C156;
			this.m_Name.CopyValues(source.Name_C156);
			this.m_PrefabInternal.CopyValues(source.PrefabInternal_C156, converter);
			this.m_SplatDatabase.CopyValues(source.SplatDatabase_C156, converter);
		}

		// Token: 0x0604A725 RID: 304933 RVA: 0x0098A528 File Offset: 0x00988728

		public void CopyValues(ITerrainData source)
		{
			this.CopyValues(source, new PPtrConverter(source, this));
		}

		// Token: 0x0604A726 RID: 304934 RVA: 0x0098A538 File Offset: 0x00988738
		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			ITerrainData terrainData = source as ITerrainData;
			if (terrainData != null)
			{
				this.CopyValues(terrainData, converter);
				return;
			}
			base.CopyValues(source, converter);
		}

		// Token: 0x0604A727 RID: 304935 RVA: 0x0098A560 File Offset: 0x00988760

		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0604A728 RID: 304936 RVA: 0x0098A567 File Offset: 0x00988767

		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x040154F2 RID: 87282

		public SplatDatabase_2017_1_0_GICB2 m_SplatDatabase;

		// Token: 0x040154F3 RID: 87283

		public DetailDatabase_2017_1_0 m_DetailDatabase;

		// Token: 0x040154F4 RID: 87284

		public Heightmap_2017_1_0 m_Heightmap;
	}
}
