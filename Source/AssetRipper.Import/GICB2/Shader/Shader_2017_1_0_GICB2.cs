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
using AssetRipper.SourceGenerated.Classes.ClassID_1001;
using AssetRipper.SourceGenerated.Classes.ClassID_1001480554;
using AssetRipper.SourceGenerated.Classes.ClassID_1002;
using AssetRipper.SourceGenerated.Classes.ClassID_130;
using AssetRipper.SourceGenerated.Classes.ClassID_18;
using AssetRipper.SourceGenerated.Enums;
using AssetRipper.SourceGenerated.Helpers;
using AssetRipper.SourceGenerated.Interfaces;
using AssetRipper.SourceGenerated.MarkerInterfaces;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtensionImpl;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtension;
using AssetRipper.SourceGenerated.Subclasses.PPtr_PrefabInstance;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Prefab;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Shader;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Texture;
using AssetRipper.SourceGenerated.Subclasses.SerializedShader;
using AssetRipper.SourceGenerated.Subclasses.ShaderCompilationInfo;
using AssetRipper.SourceGenerated.Subclasses.ShaderError;
using AssetRipper.SourceGenerated.Subclasses.Utf8String;
using AssetRipper.Yaml;
using AssetRipper.SourceGenerated.Classes.ClassID_48;

namespace AssetRipper.Import.GICB2.Shader
{
	// Token: 0x02002835 RID: 10293


	public sealed class Shader_2017_1_0_GICB2 : NamedObject_5_0_0, IShader, IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IShaderMarker, IHasName, IHasNameString
	{
		// Token: 0x1700B28C RID: 45708
		// (get) Token: 0x06025CE6 RID: 154854 RVA: 0x00571BA2 File Offset: 0x0056FDA2
		public IShaderCompilationInfo CompileInfo_C48
		{
			[return: NotNull]
			get
			{
				return this.m_CompileInfo;
			}
		}

		// Token: 0x1700B28D RID: 45709
		// (get) Token: 0x06025CE7 RID: 154855 RVA: 0x00571BAA File Offset: 0x0056FDAA
		// (set) Token: 0x06025CE8 RID: 154856 RVA: 0x00571BAD File Offset: 0x0056FDAD
		public bool CompileSmokeTestAfterImport_C48
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700B28E RID: 45710
		// (get) Token: 0x06025CE9 RID: 154857 RVA: 0x00571BAF File Offset: 0x0056FDAF
		// (set) Token: 0x06025CEA RID: 154858 RVA: 0x00571BB7 File Offset: 0x0056FDB7
		public byte[] CompressedBlob_C48
		{
			[return: NotNull]
			get
			{
				return this.m_CompressedBlob;
			}
			set
			{
				this.m_CompressedBlob = value ?? Array.Empty<byte>();
			}
		}

		// Token: 0x1700B28F RID: 45711
		// (get) Token: 0x06025CEB RID: 154859 RVA: 0x00571BC9 File Offset: 0x0056FDC9
		// (set) Token: 0x06025CEC RID: 154860 RVA: 0x00571BD1 File Offset: 0x0056FDD1
		public uint[] CompressedLengths_C48_UInt32_Array
		{
			[return: NotNull]
			get
			{
				return this.m_CompressedLengths;
			}
			set
			{
				this.m_CompressedLengths = value ?? Array.Empty<uint>();
			}
		}

		// Token: 0x1700B290 RID: 45712
		// (get) Token: 0x06025CED RID: 154861 RVA: 0x00571BE3 File Offset: 0x0056FDE3
		// (set) Token: 0x06025CEE RID: 154862 RVA: 0x00571BE6 File Offset: 0x0056FDE6

		public uint[][] CompressedLengths_C48_UInt32_Array_Array
		{

			get
			{
				return null;
			}

			set
			{
			}
		}

		// Token: 0x1700B291 RID: 45713
		// (get) Token: 0x06025CEF RID: 154863 RVA: 0x00571BE8 File Offset: 0x0056FDE8
		public IPPtr_EditorExtension CorrespondingSourceObject_C48
		{
			[return: NotNull]
			get
			{
				return this.m_CorrespondingSourceObject;
			}
		}

		// Token: 0x1700B292 RID: 45714
		// (get) Token: 0x06025CF0 RID: 154864 RVA: 0x00571BF0 File Offset: 0x0056FDF0
		// (set) Token: 0x06025CF1 RID: 154865 RVA: 0x00571BF8 File Offset: 0x0056FDF8
		public uint[] DecompressedLengths_C48_UInt32_Array
		{
			[return: NotNull]
			get
			{
				return this.m_DecompressedLengths;
			}
			set
			{
				this.m_DecompressedLengths = value ?? Array.Empty<uint>();
			}
		}

		// Token: 0x1700B293 RID: 45715
		// (get) Token: 0x06025CF2 RID: 154866 RVA: 0x00571C0A File Offset: 0x0056FE0A
		// (set) Token: 0x06025CF3 RID: 154867 RVA: 0x00571C0D File Offset: 0x0056FE0D

		public uint[][] DecompressedLengths_C48_UInt32_Array_Array
		{

			get
			{
				return null;
			}

			set
			{
			}
		}

		// Token: 0x1700B294 RID: 45716
		// (get) Token: 0x06025CF4 RID: 154868 RVA: 0x00571C0F File Offset: 0x0056FE0F
		// (set) Token: 0x06025CF5 RID: 154869 RVA: 0x00571C12 File Offset: 0x0056FE12
		public uint DecompressedSize_C48
		{
			get
			{
				return 0U;
			}
			set
			{
			}
		}

		// Token: 0x1700B295 RID: 45717
		// (get) Token: 0x06025CF6 RID: 154870 RVA: 0x00571C14 File Offset: 0x0056FE14
		public AccessDictionaryBase<Utf8String, IPPtr_Texture> DefaultTextures_C48
		{
			[return: NotNull]
			get
			{
				return new AccessDictionary<Utf8String, PPtr_Texture_5_0_0, Utf8String, IPPtr_Texture>(this.m_DefaultTextures);
			}
		}

		// Token: 0x1700B296 RID: 45718
		// (get) Token: 0x06025CF7 RID: 154871 RVA: 0x00571C21 File Offset: 0x0056FE21

		public AccessListBase<IPPtr_Shader> Dependencies_C48
		{

			[return: NotNull]
			get
			{
				return new AccessList<PPtr_Shader_5_0_0, IPPtr_Shader>(this.m_Dependencies);
			}
		}

		// Token: 0x1700B297 RID: 45719
		// (get) Token: 0x06025CF8 RID: 154872 RVA: 0x00571C2E File Offset: 0x0056FE2E

		public AccessListBase<IShaderError> Errors_C48
		{

			get
			{
				return null;
			}
		}

		// Token: 0x1700B298 RID: 45720
		// (get) Token: 0x06025CF9 RID: 154873 RVA: 0x00571C31 File Offset: 0x0056FE31
		public PPtr_EditorExtensionImpl ExtensionPtr_C48
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700B299 RID: 45721
		// (get) Token: 0x06025CFA RID: 154874 RVA: 0x00571C34 File Offset: 0x0056FE34
		// (set) Token: 0x06025CFB RID: 154875 RVA: 0x00571C3C File Offset: 0x0056FE3C
		public uint HideFlags_C48
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

		// Token: 0x1700B29A RID: 45722
		// (get) Token: 0x06025CFC RID: 154876 RVA: 0x00571C45 File Offset: 0x0056FE45

		public Utf8String Name_C48
		{

			get
			{
				return this.m_Name;
			}
		}

		// Token: 0x1700B29B RID: 45723
		// (get) Token: 0x06025CFD RID: 154877 RVA: 0x00571C4D File Offset: 0x0056FE4D
		public AssetDictionary<Utf8String, PPtr_Texture_5_0_0> NonModifiableTextures_C48
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700B29C RID: 45724
		// (get) Token: 0x06025CFE RID: 154878 RVA: 0x00571C50 File Offset: 0x0056FE50
		// (set) Token: 0x06025CFF RID: 154879 RVA: 0x00571C58 File Offset: 0x0056FE58
		public uint[] Offsets_C48_UInt32_Array
		{
			[return: NotNull]
			get
			{
				return this.m_Offsets;
			}
			set
			{
				this.m_Offsets = value ?? Array.Empty<uint>();
			}
		}

		// Token: 0x1700B29D RID: 45725
		// (get) Token: 0x06025D00 RID: 154880 RVA: 0x00571C6A File Offset: 0x0056FE6A
		// (set) Token: 0x06025D01 RID: 154881 RVA: 0x00571C6D File Offset: 0x0056FE6D

		public uint[][] Offsets_C48_UInt32_Array_Array
		{

			get
			{
				return null;
			}

			set
			{
			}
		}

		// Token: 0x1700B29E RID: 45726
		// (get) Token: 0x06025D02 RID: 154882 RVA: 0x00571C6F File Offset: 0x0056FE6F
		public ISerializedShader ParsedForm_C48
		{
			[return: NotNull]
			get
			{
				return this.m_ParsedForm;
			}
		}

		// Token: 0x1700B29F RID: 45727
		// (get) Token: 0x06025D03 RID: 154883 RVA: 0x00571C77 File Offset: 0x0056FE77
		public Utf8String PathName_C48
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700B2A0 RID: 45728
		// (get) Token: 0x06025D04 RID: 154884 RVA: 0x00571C7A File Offset: 0x0056FE7A
		// (set) Token: 0x06025D05 RID: 154885 RVA: 0x00571C82 File Offset: 0x0056FE82
		public uint[] Platforms_C48
		{
			[return: NotNull]
			get
			{
				return this.m_Platforms;
			}
			set
			{
				this.m_Platforms = value ?? Array.Empty<uint>();
			}
		}

		// Token: 0x1700B2A1 RID: 45729
		// (get) Token: 0x06025D06 RID: 154886 RVA: 0x00571C94 File Offset: 0x0056FE94
		public PPtr_Prefab_2018_3_0 PrefabAsset_C48
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700B2A2 RID: 45730
		// (get) Token: 0x06025D07 RID: 154887 RVA: 0x00571C97 File Offset: 0x0056FE97
		public PPtr_PrefabInstance PrefabInstance_C48
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700B2A3 RID: 45731
		// (get) Token: 0x06025D08 RID: 154888 RVA: 0x00571C9A File Offset: 0x0056FE9A
		public IPPtr_Prefab PrefabInternal_C48
		{
			[return: NotNull]
			get
			{
				return this.m_PrefabInternal;
			}
		}

		// Token: 0x1700B2A4 RID: 45732
		// (get) Token: 0x06025D09 RID: 154889 RVA: 0x00571CA2 File Offset: 0x0056FEA2
		public Utf8String Script_C48
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700B2A5 RID: 45733
		// (get) Token: 0x06025D0A RID: 154890 RVA: 0x00571CA5 File Offset: 0x0056FEA5
		// (set) Token: 0x06025D0B RID: 154891 RVA: 0x00571CAD File Offset: 0x0056FEAD
		public bool ShaderIsBaked_C48
		{
			get
			{
				return this.m_ShaderIsBaked;
			}
			set
			{
				this.m_ShaderIsBaked = value;
			}
		}

		// Token: 0x1700B2A6 RID: 45734
		// (get) Token: 0x06025D0C RID: 154892 RVA: 0x00571CB6 File Offset: 0x0056FEB6
		// (set) Token: 0x06025D0D RID: 154893 RVA: 0x00571CB9 File Offset: 0x0056FEB9
		public uint[] StageCounts_C48
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700B2A7 RID: 45735
		// (get) Token: 0x06025D0E RID: 154894 RVA: 0x00571CBB File Offset: 0x0056FEBB
		// (set) Token: 0x06025D0F RID: 154895 RVA: 0x00571CBE File Offset: 0x0056FEBE
		public byte[] SubProgramBlob_C48
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700B2A8 RID: 45736
		// (get) Token: 0x06025D10 RID: 154896 RVA: 0x00571CC0 File Offset: 0x0056FEC0
		// (set) Token: 0x06025D11 RID: 154897 RVA: 0x00571CC8 File Offset: 0x0056FEC8
		public HideFlags HideFlags_C48E
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

		// Token: 0x1700B2A9 RID: 45737
		// (get) Token: 0x06025D12 RID: 154898 RVA: 0x00571CD1 File Offset: 0x0056FED1
		// (set) Token: 0x06025D13 RID: 154899 RVA: 0x00571CE4 File Offset: 0x0056FEE4
		public IEditorExtension CorrespondingSourceObject_C48P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IEditorExtension>(this.CorrespondingSourceObject_C48, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IEditorExtension>(this.CorrespondingSourceObject_C48, base.Collection, value);
			}
		}

		// Token: 0x1700B2AA RID: 45738
		// (get) Token: 0x06025D14 RID: 154900 RVA: 0x00571CF8 File Offset: 0x0056FEF8
		public PPtrAccessList<IPPtr_Shader, IShader> Dependencies_C48P
		{
			get
			{
				return new PPtrAccessList<IPPtr_Shader, IShader>(this.Dependencies_C48, this);
			}
		}

		// Token: 0x1700B2AB RID: 45739
		// (get) Token: 0x06025D15 RID: 154901 RVA: 0x00571D06 File Offset: 0x0056FF06
		// (set) Token: 0x06025D16 RID: 154902 RVA: 0x00571D09 File Offset: 0x0056FF09
		public IEditorExtensionImpl ExtensionPtr_C48P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700B2AC RID: 45740
		// (get) Token: 0x06025D17 RID: 154903 RVA: 0x00571D0B File Offset: 0x0056FF0B
		// (set) Token: 0x06025D18 RID: 154904 RVA: 0x00571D0E File Offset: 0x0056FF0E
		public IPrefab PrefabAsset_C48P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700B2AD RID: 45741
		// (get) Token: 0x06025D19 RID: 154905 RVA: 0x00571D10 File Offset: 0x0056FF10
		// (set) Token: 0x06025D1A RID: 154906 RVA: 0x00571D13 File Offset: 0x0056FF13
		public IPrefabInstance PrefabInstance_C48P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700B2AE RID: 45742
		// (get) Token: 0x06025D1B RID: 154907 RVA: 0x00571D15 File Offset: 0x0056FF15
		// (set) Token: 0x06025D1C RID: 154908 RVA: 0x00571D28 File Offset: 0x0056FF28
		public IPrefabMarker PrefabInternal_C48P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IPrefabMarker>(this.PrefabInternal_C48, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IPrefabMarker>(this.PrefabInternal_C48, base.Collection, value);
			}
		}

		// Token: 0x1700B2AF RID: 45743
		// (get) Token: 0x06025D1D RID: 154909 RVA: 0x00571D3C File Offset: 0x0056FF3C

		public override string ClassName
		{

			get
			{
				return "Shader";
			}
		}

		// Token: 0x06025D1E RID: 154910 RVA: 0x00571D43 File Offset: 0x0056FF43
		public Shader_2017_1_0_GICB2()
			: this(AssetInfo.MakeDummyAssetInfo(48))
		{
		}

		// Token: 0x06025D1F RID: 154911 RVA: 0x00571D54 File Offset: 0x0056FF54
		public Shader_2017_1_0_GICB2(AssetInfo info)
			: base(info)
		{
			this.m_DefaultTextures = new AssetDictionary<Utf8String, PPtr_Texture_5_0_0>();
			this.m_CompileInfo = new ShaderCompilationInfo_2017_1_0();
			this.m_ParsedForm = new SerializedShader_2017_1_0();
			this.m_Platforms = Array.Empty<uint>();
			this.m_Offsets = Array.Empty<uint>();
			this.m_CompressedLengths = Array.Empty<uint>();
			this.m_DecompressedLengths = Array.Empty<uint>();
			this.m_CompressedBlob = Array.Empty<byte>();
			this.m_Dependencies = new AssetList<PPtr_Shader_5_0_0>();
		}

		// Token: 0x06025D20 RID: 154912 RVA: 0x00571DCB File Offset: 0x0056FFCB
		public bool Has_CompileInfo_C48()
		{
			return true;
		}

		// Token: 0x06025D21 RID: 154913 RVA: 0x00571DCE File Offset: 0x0056FFCE
		public bool Has_CompileSmokeTestAfterImport_C48()
		{
			return false;
		}

		// Token: 0x06025D22 RID: 154914 RVA: 0x00571DD1 File Offset: 0x0056FFD1
		public bool Has_CompressedBlob_C48()
		{
			return true;
		}

		// Token: 0x06025D23 RID: 154915 RVA: 0x00571DD4 File Offset: 0x0056FFD4
		public bool Has_CompressedLengths_C48_UInt32_Array()
		{
			return true;
		}

		// Token: 0x06025D24 RID: 154916 RVA: 0x00571DD7 File Offset: 0x0056FFD7
		public bool Has_CompressedLengths_C48_UInt32_Array_Array()
		{
			return false;
		}

		// Token: 0x06025D25 RID: 154917 RVA: 0x00571DDA File Offset: 0x0056FFDA
		public bool Has_CorrespondingSourceObject_C48()
		{
			return true;
		}

		// Token: 0x06025D26 RID: 154918 RVA: 0x00571DDD File Offset: 0x0056FFDD
		public bool Has_DecompressedLengths_C48_UInt32_Array()
		{
			return true;
		}

		// Token: 0x06025D27 RID: 154919 RVA: 0x00571DE0 File Offset: 0x0056FFE0
		public bool Has_DecompressedLengths_C48_UInt32_Array_Array()
		{
			return false;
		}

		// Token: 0x06025D28 RID: 154920 RVA: 0x00571DE3 File Offset: 0x0056FFE3
		public bool Has_DecompressedSize_C48()
		{
			return false;
		}

		// Token: 0x06025D29 RID: 154921 RVA: 0x00571DE6 File Offset: 0x0056FFE6
		public bool Has_DefaultTextures_C48()
		{
			return true;
		}

		// Token: 0x06025D2A RID: 154922 RVA: 0x00571DE9 File Offset: 0x0056FFE9
		public bool Has_Dependencies_C48()
		{
			return true;
		}

		// Token: 0x06025D2B RID: 154923 RVA: 0x00571DEC File Offset: 0x0056FFEC
		public bool Has_Errors_C48()
		{
			return false;
		}

		// Token: 0x06025D2C RID: 154924 RVA: 0x00571DEF File Offset: 0x0056FFEF
		public bool Has_ExtensionPtr_C48()
		{
			return false;
		}

		// Token: 0x06025D2D RID: 154925 RVA: 0x00571DF2 File Offset: 0x0056FFF2
		public bool Has_NonModifiableTextures_C48()
		{
			return false;
		}

		// Token: 0x06025D2E RID: 154926 RVA: 0x00571DF5 File Offset: 0x0056FFF5
		public bool Has_Offsets_C48_UInt32_Array()
		{
			return true;
		}

		// Token: 0x06025D2F RID: 154927 RVA: 0x00571DF8 File Offset: 0x0056FFF8
		public bool Has_Offsets_C48_UInt32_Array_Array()
		{
			return false;
		}

		// Token: 0x06025D30 RID: 154928 RVA: 0x00571DFB File Offset: 0x0056FFFB
		public bool Has_ParsedForm_C48()
		{
			return true;
		}

		// Token: 0x06025D31 RID: 154929 RVA: 0x00571DFE File Offset: 0x0056FFFE
		public bool Has_PathName_C48()
		{
			return false;
		}

		// Token: 0x06025D32 RID: 154930 RVA: 0x00571E01 File Offset: 0x00570001
		public bool Has_Platforms_C48()
		{
			return true;
		}

		// Token: 0x06025D33 RID: 154931 RVA: 0x00571E04 File Offset: 0x00570004
		public bool Has_PrefabAsset_C48()
		{
			return false;
		}

		// Token: 0x06025D34 RID: 154932 RVA: 0x00571E07 File Offset: 0x00570007
		public bool Has_PrefabInstance_C48()
		{
			return false;
		}

		// Token: 0x06025D35 RID: 154933 RVA: 0x00571E0A File Offset: 0x0057000A
		public bool Has_PrefabInternal_C48()
		{
			return true;
		}

		// Token: 0x06025D36 RID: 154934 RVA: 0x00571E0D File Offset: 0x0057000D
		public bool Has_Script_C48()
		{
			return false;
		}

		// Token: 0x06025D37 RID: 154935 RVA: 0x00571E10 File Offset: 0x00570010
		public bool Has_ShaderIsBaked_C48()
		{
			return true;
		}

		// Token: 0x06025D38 RID: 154936 RVA: 0x00571E13 File Offset: 0x00570013
		public bool Has_StageCounts_C48()
		{
			return false;
		}

		// Token: 0x06025D39 RID: 154937 RVA: 0x00571E16 File Offset: 0x00570016
		public bool Has_SubProgramBlob_C48()
		{
			return false;
		}

		// Token: 0x06025D3A RID: 154938 RVA: 0x00571E1C File Offset: 0x0057001C

		public override void ReadRelease(AssetReader reader)
		{
			this.m_Name.ReadRelease(reader);
			this.m_ParsedForm.ReadRelease(reader);
			this.m_Platforms = reader.ReadRelease_ArrayAlign_UInt32();
			this.m_Offsets = reader.ReadRelease_ArrayAlign_UInt32();
			this.m_CompressedLengths = reader.ReadRelease_ArrayAlign_UInt32();
			this.m_DecompressedLengths = reader.ReadRelease_ArrayAlign_UInt32();
			this.m_CompressedBlob = reader.ReadByteArray();
			if (BitConverter.ToInt32(this.m_CompressedBlob, 0) == -1)
				this.m_CompressedBlob = reader.ReadByteArray();
			this.m_Dependencies.ReadRelease_ArrayAlign_Asset(reader);
			this.m_ShaderIsBaked = reader.ReadRelease_BooleanAlign();
			this.m_Name.CopyIfNullOrEmpty(this.m_ParsedForm.m_Name);
		}

		// Token: 0x06025D3B RID: 154939 RVA: 0x00571EAC File Offset: 0x005700AC

		public override void ReadEditor(AssetReader reader)
		{
		}

		// Token: 0x06025D3C RID: 154940 RVA: 0x00571F78 File Offset: 0x00570178

		public override void WriteRelease(AssetWriter writer)
		{
			this.m_Name.WriteRelease(writer);
			this.m_ParsedForm.WriteRelease(writer);
			this.m_Platforms.WriteRelease_ArrayAlign_UInt32(writer);
			this.m_Offsets.WriteRelease_ArrayAlign_UInt32(writer);
			this.m_CompressedLengths.WriteRelease_ArrayAlign_UInt32(writer);
			this.m_DecompressedLengths.WriteRelease_ArrayAlign_UInt32(writer);
			this.m_CompressedBlob.WriteRelease_ArrayAlign_Byte(writer);
			this.m_Dependencies.WriteRelease_ArrayAlign_Asset(writer);
			this.m_ShaderIsBaked.WriteRelease_BooleanAlign(writer);
		}

		// Token: 0x06025D3D RID: 154941 RVA: 0x00571FF4 File Offset: 0x005701F4

		public override void WriteEditor(AssetWriter writer)
		{
		}

		// Token: 0x06025D3E RID: 154942 RVA: 0x005720AC File Offset: 0x005702AC

		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 1);
			yamlMappingNode.Add(new YamlScalarNode("m_Name"), this.m_Name.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ParsedForm"), this.m_ParsedForm.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("platforms"), this.m_Platforms.ExportYamlRelease_Array_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("offsets"), this.m_Offsets.ExportYamlRelease_Array_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("compressedLengths"), this.m_CompressedLengths.ExportYamlRelease_Array_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("decompressedLengths"), this.m_DecompressedLengths.ExportYamlRelease_Array_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("compressedBlob"), this.m_CompressedBlob.ExportYamlRelease_Array_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Dependencies"), this.m_Dependencies.ExportYamlRelease_Array_PPtr_Shader_5_0_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ShaderIsBaked"), this.m_ShaderIsBaked.ExportYamlRelease_Boolean(container));
			return yamlMappingNode;
		}

		// Token: 0x06025D3F RID: 154943 RVA: 0x005721C4 File Offset: 0x005703C4

		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 1);
			yamlMappingNode.Add(new YamlScalarNode("m_ObjectHideFlags"), this.m_HideFlags.ExportYamlEditor_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabParentObject"), this.m_CorrespondingSourceObject.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabInternal"), this.m_PrefabInternal.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Name"), this.m_Name.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ParsedForm"), this.m_ParsedForm.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("platforms"), this.m_Platforms.ExportYamlEditor_Array_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("offsets"), this.m_Offsets.ExportYamlEditor_Array_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("compressedLengths"), this.m_CompressedLengths.ExportYamlEditor_Array_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("decompressedLengths"), this.m_DecompressedLengths.ExportYamlEditor_Array_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("compressedBlob"), this.m_CompressedBlob.ExportYamlEditor_Array_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Dependencies"), this.m_Dependencies.ExportYamlEditor_Array_PPtr_Shader_5_0_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ShaderIsBaked"), this.m_ShaderIsBaked.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_DefaultTextures"), this.m_DefaultTextures.ExportYamlEditor_Map_Utf8String_PPtr_Texture_5_0_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_CompileInfo"), this.m_CompileInfo.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06025D40 RID: 154944 RVA: 0x00572368 File Offset: 0x00570568
		public override void Reset()
		{
			this.m_CompileInfo.Reset();
			this.m_CompressedBlob = Array.Empty<byte>();
			this.m_CompressedLengths = Array.Empty<uint>();
			this.m_CorrespondingSourceObject.Reset();
			this.m_DecompressedLengths = Array.Empty<uint>();
			this.m_DefaultTextures.Clear();
			this.m_Dependencies.Clear();
			this.m_HideFlags = 0U;
			this.m_Name.Reset();
			this.m_Offsets = Array.Empty<uint>();
			this.m_ParsedForm.Reset();
			this.m_Platforms = Array.Empty<uint>();
			this.m_PrefabInternal.Reset();
			this.m_ShaderIsBaked = false;
		}

		// Token: 0x06025D41 RID: 154945 RVA: 0x00572407 File Offset: 0x00570607
		//public override IEnumerable<ValueTuple<FieldName, PPtr<IUnityObjectBase>>> FetchDependencies(FieldName parent)
		//{
		//	return Enumerable.Empty<ValueTuple<FieldName, PPtr<IUnityObjectBase>>>().Append_Shader_2017_1_0(parent, this);
		//}

		// Token: 0x06025D42 RID: 154946 RVA: 0x00572418 File Offset: 0x00570618

		public void CopyValues(IShader source, PPtrConverter converter)
		{
			this.m_CompileInfo.CopyValues(source.CompileInfo_C48);
			this.m_CompressedBlob = CopyValuesHelper.DuplicateArray<byte>(source.CompressedBlob_C48);
			this.m_CompressedLengths = CopyValuesHelper.DuplicateArray<uint>(source.CompressedLengths_C48_UInt32_Array);
			this.m_CorrespondingSourceObject.CopyValues(source.CorrespondingSourceObject_C48, converter);
			this.m_DecompressedLengths = CopyValuesHelper.DuplicateArray<uint>(source.DecompressedLengths_C48_UInt32_Array);
			CopyValuesHelper.CopyValues__AssetDictionary_Utf8String_PPtr_Texture_5_0_0__AccessDictionaryBase_Utf8String_IPPtr_Texture(this.m_DefaultTextures, source.DefaultTextures_C48, converter);
			CopyValuesHelper.CopyValues__AssetList_PPtr_Shader_5_0_0__AccessListBase_IPPtr_Shader(this.m_Dependencies, source.Dependencies_C48, converter);
			this.m_HideFlags = source.HideFlags_C48;
			this.m_Name.CopyValues(source.Name_C48);
			this.m_Offsets = CopyValuesHelper.DuplicateArray<uint>(source.Offsets_C48_UInt32_Array);
			this.m_ParsedForm.CopyValues(source.ParsedForm_C48);
			this.m_Platforms = CopyValuesHelper.DuplicateArray<uint>(source.Platforms_C48);
			this.m_PrefabInternal.CopyValues(source.PrefabInternal_C48, converter);
			this.m_ShaderIsBaked = source.ShaderIsBaked_C48;
		}

		// Token: 0x06025D43 RID: 154947 RVA: 0x0057250D File Offset: 0x0057070D

		public void CopyValues(IShader source)
		{
			this.CopyValues(source, new PPtrConverter(source, this));
		}

		// Token: 0x06025D44 RID: 154948 RVA: 0x00572520 File Offset: 0x00570720
		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			IShader shader = source as IShader;
			if (shader != null)
			{
				this.CopyValues(shader, converter);
				return;
			}
			base.CopyValues(source, converter);
		}

		// Token: 0x06025D45 RID: 154949 RVA: 0x00572548 File Offset: 0x00570748

		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06025D46 RID: 154950 RVA: 0x0057254F File Offset: 0x0057074F

		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04011D2A RID: 73002

		public AssetDictionary<Utf8String, PPtr_Texture_5_0_0> m_DefaultTextures;

		// Token: 0x04011D2B RID: 73003

		public ShaderCompilationInfo_2017_1_0 m_CompileInfo;

		// Token: 0x04011D2C RID: 73004

		public SerializedShader_2017_1_0 m_ParsedForm;

		// Token: 0x04011D2D RID: 73005

		public uint[] m_Platforms;

		// Token: 0x04011D2E RID: 73006

		public uint[] m_Offsets;

		// Token: 0x04011D2F RID: 73007

		public uint[] m_CompressedLengths;

		// Token: 0x04011D30 RID: 73008

		public uint[] m_DecompressedLengths;

		// Token: 0x04011D31 RID: 73009

		public byte[] m_CompressedBlob;

		// Token: 0x04011D32 RID: 73010

		public AssetList<PPtr_Shader_5_0_0> m_Dependencies;

		// Token: 0x04011D33 RID: 73011
		public bool m_ShaderIsBaked;
	}
}
