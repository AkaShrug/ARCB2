using System;
using System.Runtime.CompilerServices;
using AssetRipper.Assets;
using AssetRipper.Assets.Generics;
using AssetRipper.Assets.IO.Writing;
using AssetRipper.SourceGenerated.Subclasses.Asset;
using AssetRipper.SourceGenerated.Subclasses.AssetBundleFullName;
using AssetRipper.SourceGenerated.Subclasses.AssetBundleInfo;
using AssetRipper.SourceGenerated.Subclasses.AssetImporterHashKey;
using AssetRipper.SourceGenerated.Subclasses.AssetInfo;
using AssetRipper.SourceGenerated.Subclasses.AssetTimeStamp;
using AssetRipper.SourceGenerated.Subclasses.CachedAssetMetaData;
using AssetRipper.SourceGenerated.Subclasses.ColorRGBAf;
using AssetRipper.SourceGenerated.Subclasses.ComputeShaderKernel;
using AssetRipper.SourceGenerated.Subclasses.ConfigSetting;
using AssetRipper.SourceGenerated.Subclasses.DefaultPreset;
using AssetRipper.SourceGenerated.Subclasses.DeletedItem;
using AssetRipper.SourceGenerated.Subclasses.FastPropertyName;
using AssetRipper.SourceGenerated.Subclasses.GUID;
using AssetRipper.SourceGenerated.Subclasses.Hash128;
using AssetRipper.SourceGenerated.Subclasses.HierarchicalSceneData;
using AssetRipper.SourceGenerated.Subclasses.IntegerString;
using AssetRipper.SourceGenerated.Subclasses.Item;
using AssetRipper.SourceGenerated.Subclasses.ModifiedItem;
using AssetRipper.SourceGenerated.Subclasses.NestedString;
using AssetRipper.SourceGenerated.Subclasses.NonAlignedStruct;
using AssetRipper.SourceGenerated.Subclasses.PlatformSettingsData_Editor;
using AssetRipper.SourceGenerated.Subclasses.PlatformSettingsData_Plugin;
using AssetRipper.SourceGenerated.Subclasses.PPtr_AnimatorStateMachine;
using AssetRipper.SourceGenerated.Subclasses.PPtr_AnimatorTransition;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Component;
using AssetRipper.SourceGenerated.Subclasses.PPtr_GameObject;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Object;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Shader;
using AssetRipper.SourceGenerated.Subclasses.PPtr_SphereCollider;
using AssetRipper.SourceGenerated.Subclasses.PPtr_State;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Texture;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Texture2D;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Transition;
using AssetRipper.SourceGenerated.Subclasses.PresetType;
using AssetRipper.SourceGenerated.Subclasses.SampleSettings;
using AssetRipper.SourceGenerated.Subclasses.SceneIdentifier;
using AssetRipper.SourceGenerated.Subclasses.SceneVisibilityData;
using AssetRipper.SourceGenerated.Subclasses.SecondaryTextureSettings;
using AssetRipper.SourceGenerated.Subclasses.SerializedPlayerSubProgram;
using AssetRipper.SourceGenerated.Subclasses.ShaderInfo;
using AssetRipper.SourceGenerated.Subclasses.SourceAssetIdentifier;
using AssetRipper.SourceGenerated.Subclasses.SpriteAtlasData;
using AssetRipper.SourceGenerated.Subclasses.SpriteRenderData;
using AssetRipper.SourceGenerated.Subclasses.StateKey;
using AssetRipper.SourceGenerated.Subclasses.StateRange;
using AssetRipper.SourceGenerated.Subclasses.Tile;
using AssetRipper.SourceGenerated.Subclasses.TileAnimationData;
using AssetRipper.SourceGenerated.Subclasses.UnityTexEnv;
using AssetRipper.SourceGenerated.Subclasses.Utf8String;
using AssetRipper.SourceGenerated.Subclasses.Vector2f;
using AssetRipper.SourceGenerated.Subclasses.Vector2Long;
using AssetRipper.SourceGenerated.Subclasses.Vector3Int;
using AssetRipper.SourceGenerated.Subclasses.VideoClipImporterTargetSettings;

namespace AssetRipper.SourceGenerated.Helpers
{
	// Token: 0x02001C2B RID: 7211
	
	
	internal static class WriteReleaseMethods
	{
		// Token: 0x060189EE RID: 100846 RVA: 0x003ED1DF File Offset: 0x003EB3DF
		public static void WriteRelease_AssetAlign< T>(this T value, AssetWriter writer) where T : UnityAssetBase, new()
		{
			value.WriteRelease(writer);
			writer.AlignStream();
		}

		// Token: 0x060189EF RID: 100847 RVA: 0x003ED1F4 File Offset: 0x003EB3F4
		public static void WriteRelease_Array_Asset< T>(this AssetList<T> value, AssetWriter writer) where T : UnityAssetBase, new()
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				value[i].WriteRelease(writer);
			}
		}

		// Token: 0x060189F0 RID: 100848 RVA: 0x003ED230 File Offset: 0x003EB430
		public static void WriteRelease_ArrayAlign_Asset< T>(this AssetList<T> value, AssetWriter writer) where T : UnityAssetBase, new()
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				value[i].WriteRelease(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x060189F1 RID: 100849 RVA: 0x003ED270 File Offset: 0x003EB470
		public static void WriteRelease_Array_Array_Vector2f_3_5_0(this AssetList<AssetList<Vector2f_3_5_0>> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				value[i].WriteRelease_Array_Asset(writer);
			}
		}

		// Token: 0x060189F2 RID: 100850 RVA: 0x003ED2A4 File Offset: 0x003EB4A4
		public static void WriteRelease_Array_Array_Vector2Long(this AssetList<AssetList<Vector2Long>> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				value[i].WriteRelease_Array_Asset(writer);
			}
		}

		// Token: 0x060189F3 RID: 100851 RVA: 0x003ED2D8 File Offset: 0x003EB4D8
		public static void WriteRelease_Array_Int32(this int[] value, AssetWriter writer)
		{
			int num = value.Length;
			writer.Write(num);
			for (int i = 0; i < num; i++)
			{
				value[i].WriteRelease_Int32(writer);
			}
		}

		// Token: 0x060189F4 RID: 100852 RVA: 0x003ED308 File Offset: 0x003EB508
		public static void WriteRelease_Array_Pair_Int32_PPtr_Component_3_4_0(this AssetList<AssetPair<int, PPtr_Component_3_4_0>> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				value[i].WriteRelease_Pair_Int32_PPtr_Component_3_4_0(writer);
			}
		}

		// Token: 0x060189F5 RID: 100853 RVA: 0x003ED33C File Offset: 0x003EB53C
		public static void WriteRelease_Array_Pair_Int32_PPtr_Component_5_0_0(this AssetList<AssetPair<int, PPtr_Component_5_0_0>> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				value[i].WriteRelease_Pair_Int32_PPtr_Component_5_0_0(writer);
			}
		}

		// Token: 0x060189F6 RID: 100854 RVA: 0x003ED370 File Offset: 0x003EB570
		public static void WriteRelease_Array_Pair_Int32_Single(this AssetList<AssetPair<int, float>> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				value[i].WriteRelease_Pair_Int32_Single(writer);
			}
		}

		// Token: 0x060189F7 RID: 100855 RVA: 0x003ED3A4 File Offset: 0x003EB5A4
		public static void WriteRelease_Array_Pair_Int32_UInt32(this AssetList<AssetPair<int, uint>> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				value[i].WriteRelease_Pair_Int32_UInt32(writer);
			}
		}

		// Token: 0x060189F8 RID: 100856 RVA: 0x003ED3D8 File Offset: 0x003EB5D8
		public static void WriteRelease_Array_Pair_PPtr_SphereCollider_PPtr_SphereCollider(this AssetList<AssetPair<PPtr_SphereCollider, PPtr_SphereCollider>> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				value[i].WriteRelease_Pair_PPtr_SphereCollider_PPtr_SphereCollider(writer);
			}
		}

		// Token: 0x060189F9 RID: 100857 RVA: 0x003ED40C File Offset: 0x003EB60C
		public static void WriteRelease_Array_Pair_Utf8String_PPtr_Object_3_4_0(this AssetList<AssetPair<Utf8String, PPtr_Object_3_4_0>> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				value[i].WriteRelease_Pair_Utf8String_PPtr_Object_3_4_0(writer);
			}
		}

		// Token: 0x060189FA RID: 100858 RVA: 0x003ED440 File Offset: 0x003EB640
		public static void WriteRelease_Array_Pair_Utf8String_PPtr_Object_5_0_0(this AssetList<AssetPair<Utf8String, PPtr_Object_5_0_0>> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				value[i].WriteRelease_Pair_Utf8String_PPtr_Object_5_0_0(writer);
			}
		}

		// Token: 0x060189FB RID: 100859 RVA: 0x003ED474 File Offset: 0x003EB674
		public static void WriteRelease_Array_SByte(this sbyte[] value, AssetWriter writer)
		{
			int num = value.Length;
			writer.Write(num);
			for (int i = 0; i < num; i++)
			{
				value[i].WriteRelease_SByte(writer);
			}
		}

		// Token: 0x060189FC RID: 100860 RVA: 0x003ED4A4 File Offset: 0x003EB6A4
		public static void WriteRelease_Array_Single(this float[] value, AssetWriter writer)
		{
			int num = value.Length;
			writer.Write(num);
			for (int i = 0; i < num; i++)
			{
				value[i].WriteRelease_Single(writer);
			}
		}

		// Token: 0x060189FD RID: 100861 RVA: 0x003ED4D4 File Offset: 0x003EB6D4
		public static void WriteRelease_Array_UInt16(this ushort[] value, AssetWriter writer)
		{
			int num = value.Length;
			writer.Write(num);
			for (int i = 0; i < num; i++)
			{
				value[i].WriteRelease_UInt16(writer);
			}
		}

		// Token: 0x060189FE RID: 100862 RVA: 0x003ED504 File Offset: 0x003EB704
		public static void WriteRelease_Array_UInt32(this uint[] value, AssetWriter writer)
		{
			int num = value.Length;
			writer.Write(num);
			for (int i = 0; i < num; i++)
			{
				value[i].WriteRelease_UInt32(writer);
			}
		}

		// Token: 0x060189FF RID: 100863 RVA: 0x003ED534 File Offset: 0x003EB734
		public static void WriteRelease_ArrayAlign_ArrayAlign_SerializedPlayerSubProgram_2021_3_10(this AssetList<AssetList<SerializedPlayerSubProgram_2021_3_10>> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				value[i].WriteRelease_ArrayAlign_Asset(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A00 RID: 100864 RVA: 0x003ED570 File Offset: 0x003EB770
		public static void WriteRelease_ArrayAlign_ArrayAlign_SerializedPlayerSubProgram_2022_1_13(this AssetList<AssetList<SerializedPlayerSubProgram_2022_1_13>> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				value[i].WriteRelease_ArrayAlign_Asset(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A01 RID: 100865 RVA: 0x003ED5AC File Offset: 0x003EB7AC
		public static void WriteRelease_ArrayAlign_ArrayAlign_SerializedPlayerSubProgram_2022_2_0_b5(this AssetList<AssetList<SerializedPlayerSubProgram_2022_2_0_b5>> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				value[i].WriteRelease_ArrayAlign_Asset(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A02 RID: 100866 RVA: 0x003ED5E8 File Offset: 0x003EB7E8
		public static void WriteRelease_ArrayAlign_ArrayAlign_UInt32(this uint[][] value, AssetWriter writer)
		{
			int num = value.Length;
			writer.Write(num);
			for (int i = 0; i < num; i++)
			{
				value[i].WriteRelease_ArrayAlign_UInt32(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A03 RID: 100867 RVA: 0x003ED61C File Offset: 0x003EB81C
		public static void WriteRelease_ArrayAlign_ArrayAlign_Vector2f_3_5_0(this AssetList<AssetList<Vector2f_3_5_0>> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				value[i].WriteRelease_ArrayAlign_Asset(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A04 RID: 100868 RVA: 0x003ED658 File Offset: 0x003EB858
		public static void WriteRelease_ArrayAlign_ArrayAlign_Vector2Long(this AssetList<AssetList<Vector2Long>> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				value[i].WriteRelease_ArrayAlign_Asset(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A05 RID: 100869 RVA: 0x003ED694 File Offset: 0x003EB894
		public static void WriteRelease_ArrayAlign_Boolean(this bool[] value, AssetWriter writer)
		{
			int num = value.Length;
			writer.Write(num);
			for (int i = 0; i < num; i++)
			{
				value[i].WriteRelease_Boolean(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A06 RID: 100870 RVA: 0x003ED6C8 File Offset: 0x003EB8C8
		public static void WriteRelease_ArrayAlign_Byte(this byte[] value, AssetWriter writer)
		{
			int num = value.Length;
			writer.Write(num);
			for (int i = 0; i < num; i++)
			{
				value[i].WriteRelease_Byte(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A07 RID: 100871 RVA: 0x003ED6FC File Offset: 0x003EB8FC
		public static void WriteRelease_ArrayAlign_Int16(this short[] value, AssetWriter writer)
		{
			int num = value.Length;
			writer.Write(num);
			for (int i = 0; i < num; i++)
			{
				value[i].WriteRelease_Int16(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A08 RID: 100872 RVA: 0x003ED730 File Offset: 0x003EB930
		public static void WriteRelease_ArrayAlign_Int32(this int[] value, AssetWriter writer)
		{
			int num = value.Length;
			writer.Write(num);
			for (int i = 0; i < num; i++)
			{
				value[i].WriteRelease_Int32(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A09 RID: 100873 RVA: 0x003ED764 File Offset: 0x003EB964
		public static void WriteRelease_ArrayAlign_Int64(this long[] value, AssetWriter writer)
		{
			int num = value.Length;
			writer.Write(num);
			for (int i = 0; i < num; i++)
			{
				value[i].WriteRelease_Int64(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A0A RID: 100874 RVA: 0x003ED798 File Offset: 0x003EB998
		public static void WriteRelease_ArrayAlign_Pair_Pair_Int32_Int64_Utf8String(this AssetList<AssetPair<AssetPair<int, long>, Utf8String>> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				value[i].WriteRelease_Pair_Pair_Int32_Int64_Utf8String(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A0B RID: 100875 RVA: 0x003ED7D4 File Offset: 0x003EB9D4
		public static void WriteRelease_ArrayAlign_Pair_PPtr_SphereCollider_PPtr_SphereCollider(this AssetList<AssetPair<PPtr_SphereCollider, PPtr_SphereCollider>> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				value[i].WriteRelease_Pair_PPtr_SphereCollider_PPtr_SphereCollider(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A0C RID: 100876 RVA: 0x003ED810 File Offset: 0x003EBA10
		public static void WriteRelease_ArrayAlign_Pair_Utf8String_Boolean(this AssetList<AssetPair<Utf8String, bool>> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				value[i].WriteRelease_Pair_Utf8String_Boolean(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A0D RID: 100877 RVA: 0x003ED84C File Offset: 0x003EBA4C
		public static void WriteRelease_ArrayAlign_Pair_Utf8String_PPtr_Object_5_0_0(this AssetList<AssetPair<Utf8String, PPtr_Object_5_0_0>> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				value[i].WriteRelease_Pair_Utf8String_PPtr_Object_5_0_0(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A0E RID: 100878 RVA: 0x003ED888 File Offset: 0x003EBA88
		public static void WriteRelease_ArrayAlign_Pair_Utf8String_PPtr_Texture_3_4_0(this AssetList<AssetPair<Utf8String, PPtr_Texture_3_4_0>> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				value[i].WriteRelease_Pair_Utf8String_PPtr_Texture_3_4_0(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A0F RID: 100879 RVA: 0x003ED8C4 File Offset: 0x003EBAC4
		public static void WriteRelease_ArrayAlign_Pair_Utf8String_PPtr_Texture_5_0_0(this AssetList<AssetPair<Utf8String, PPtr_Texture_5_0_0>> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				value[i].WriteRelease_Pair_Utf8String_PPtr_Texture_5_0_0(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A10 RID: 100880 RVA: 0x003ED900 File Offset: 0x003EBB00
		public static void WriteRelease_ArrayAlign_Pair_Utf8String_UInt32(this AssetList<AssetPair<Utf8String, uint>> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				value[i].WriteRelease_Pair_Utf8String_UInt32(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A11 RID: 100881 RVA: 0x003ED93C File Offset: 0x003EBB3C
		public static void WriteRelease_ArrayAlign_Single(this float[] value, AssetWriter writer)
		{
			int num = value.Length;
			writer.Write(num);
			for (int i = 0; i < num; i++)
			{
				value[i].WriteRelease_Single(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A12 RID: 100882 RVA: 0x003ED970 File Offset: 0x003EBB70
		public static void WriteRelease_ArrayAlign_UInt16(this ushort[] value, AssetWriter writer)
		{
			int num = value.Length;
			writer.Write(num);
			for (int i = 0; i < num; i++)
			{
				value[i].WriteRelease_UInt16(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A13 RID: 100883 RVA: 0x003ED9A4 File Offset: 0x003EBBA4
		public static void WriteRelease_ArrayAlign_UInt32(this uint[] value, AssetWriter writer)
		{
			int num = value.Length;
			writer.Write(num);
			for (int i = 0; i < num; i++)
			{
				value[i].WriteRelease_UInt32(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A14 RID: 100884 RVA: 0x003ED9D7 File Offset: 0x003EBBD7
		public static void WriteRelease_Boolean(this bool value, AssetWriter writer)
		{
			writer.Write(value);
		}

		// Token: 0x06018A15 RID: 100885 RVA: 0x003ED9E0 File Offset: 0x003EBBE0
		public static void WriteRelease_BooleanAlign(this bool value, AssetWriter writer)
		{
			writer.Write(value);
			writer.AlignStream();
		}

		// Token: 0x06018A16 RID: 100886 RVA: 0x003ED9EF File Offset: 0x003EBBEF
		public static void WriteRelease_Byte(this byte value, AssetWriter writer)
		{
			writer.Write(value);
		}

		// Token: 0x06018A17 RID: 100887 RVA: 0x003ED9F8 File Offset: 0x003EBBF8
		public static void WriteRelease_ByteAlign(this byte value, AssetWriter writer)
		{
			writer.Write(value);
			writer.AlignStream();
		}

		// Token: 0x06018A18 RID: 100888 RVA: 0x003EDA07 File Offset: 0x003EBC07
		public static void WriteRelease_Double(this double value, AssetWriter writer)
		{
			writer.Write(value);
		}

		// Token: 0x06018A19 RID: 100889 RVA: 0x003EDA10 File Offset: 0x003EBC10
		public static void WriteRelease_Int16(this short value, AssetWriter writer)
		{
			writer.Write(value);
		}

		// Token: 0x06018A1A RID: 100890 RVA: 0x003EDA19 File Offset: 0x003EBC19
		public static void WriteRelease_Int16Align(this short value, AssetWriter writer)
		{
			writer.Write(value);
			writer.AlignStream();
		}

		// Token: 0x06018A1B RID: 100891 RVA: 0x003EDA28 File Offset: 0x003EBC28
		public static void WriteRelease_Int32(this int value, AssetWriter writer)
		{
			writer.Write(value);
		}

		// Token: 0x06018A1C RID: 100892 RVA: 0x003EDA31 File Offset: 0x003EBC31
		public static void WriteRelease_Int32Align(this int value, AssetWriter writer)
		{
			writer.Write(value);
			writer.AlignStream();
		}

		// Token: 0x06018A1D RID: 100893 RVA: 0x003EDA40 File Offset: 0x003EBC40
		public static void WriteRelease_Int64(this long value, AssetWriter writer)
		{
			writer.Write(value);
		}

		// Token: 0x06018A1E RID: 100894 RVA: 0x003EDA49 File Offset: 0x003EBC49
		public static void WriteRelease_Int64Align(this long value, AssetWriter writer)
		{
			writer.Write(value);
			writer.AlignStream();
		}

		// Token: 0x06018A1F RID: 100895 RVA: 0x003EDA58 File Offset: 0x003EBC58
		public static void WriteRelease_Map_AssetImporterHashKey_UInt32(this AssetDictionary<AssetImporterHashKey, uint> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<AssetImporterHashKey, uint> assetPair = (AssetPair<AssetImporterHashKey, uint>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease_UInt32(writer);
			}
		}

		// Token: 0x06018A20 RID: 100896 RVA: 0x003EDAA4 File Offset: 0x003EBCA4
		public static void WriteRelease_Map_FastPropertyName_ColorRGBAf_3_4_0(this AssetDictionary<FastPropertyName, ColorRGBAf_3_4_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<FastPropertyName, ColorRGBAf_3_4_0> assetPair = (AssetPair<FastPropertyName, ColorRGBAf_3_4_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A21 RID: 100897 RVA: 0x003EDAF0 File Offset: 0x003EBCF0
		public static void WriteRelease_Map_FastPropertyName_ColorRGBAf_3_5_0(this AssetDictionary<FastPropertyName, ColorRGBAf_3_5_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<FastPropertyName, ColorRGBAf_3_5_0> assetPair = (AssetPair<FastPropertyName, ColorRGBAf_3_5_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A22 RID: 100898 RVA: 0x003EDB3C File Offset: 0x003EBD3C
		public static void WriteRelease_Map_FastPropertyName_Single(this AssetDictionary<FastPropertyName, float> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<FastPropertyName, float> assetPair = (AssetPair<FastPropertyName, float>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease_Single(writer);
			}
		}

		// Token: 0x06018A23 RID: 100899 RVA: 0x003EDB88 File Offset: 0x003EBD88
		public static void WriteRelease_Map_FastPropertyName_UnityTexEnv_3_4_0(this AssetDictionary<FastPropertyName, UnityTexEnv_3_4_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<FastPropertyName, UnityTexEnv_3_4_0> assetPair = (AssetPair<FastPropertyName, UnityTexEnv_3_4_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A24 RID: 100900 RVA: 0x003EDBD4 File Offset: 0x003EBDD4
		public static void WriteRelease_Map_FastPropertyName_UnityTexEnv_3_5_0(this AssetDictionary<FastPropertyName, UnityTexEnv_3_5_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<FastPropertyName, UnityTexEnv_3_5_0> assetPair = (AssetPair<FastPropertyName, UnityTexEnv_3_5_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A25 RID: 100901 RVA: 0x003EDC20 File Offset: 0x003EBE20
		public static void WriteRelease_Map_FastPropertyName_UnityTexEnv_5_0_0(this AssetDictionary<FastPropertyName, UnityTexEnv_5_0_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<FastPropertyName, UnityTexEnv_5_0_0> assetPair = (AssetPair<FastPropertyName, UnityTexEnv_5_0_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A26 RID: 100902 RVA: 0x003EDC6C File Offset: 0x003EBE6C
		public static void WriteRelease_Map_GUID_Asset_2017_1_0(this AssetDictionary<GUID, Asset_2017_1_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<GUID, Asset_2017_1_0> assetPair = (AssetPair<GUID, Asset_2017_1_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A27 RID: 100903 RVA: 0x003EDCB8 File Offset: 0x003EBEB8
		public static void WriteRelease_Map_GUID_Asset_2017_2_5(this AssetDictionary<GUID, Asset_2017_2_5> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<GUID, Asset_2017_2_5> assetPair = (AssetPair<GUID, Asset_2017_2_5>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A28 RID: 100904 RVA: 0x003EDD04 File Offset: 0x003EBF04
		public static void WriteRelease_Map_GUID_Asset_2017_3_0(this AssetDictionary<GUID, Asset_2017_3_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<GUID, Asset_2017_3_0> assetPair = (AssetPair<GUID, Asset_2017_3_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A29 RID: 100905 RVA: 0x003EDD50 File Offset: 0x003EBF50
		public static void WriteRelease_Map_GUID_Asset_2017_4_14(this AssetDictionary<GUID, Asset_2017_4_14> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<GUID, Asset_2017_4_14> assetPair = (AssetPair<GUID, Asset_2017_4_14>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A2A RID: 100906 RVA: 0x003EDD9C File Offset: 0x003EBF9C
		public static void WriteRelease_Map_GUID_Asset_2018_1_0(this AssetDictionary<GUID, Asset_2018_1_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<GUID, Asset_2018_1_0> assetPair = (AssetPair<GUID, Asset_2018_1_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A2B RID: 100907 RVA: 0x003EDDE8 File Offset: 0x003EBFE8
		public static void WriteRelease_Map_GUID_Asset_2018_1_0_b11(this AssetDictionary<GUID, Asset_2018_1_0_b11> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<GUID, Asset_2018_1_0_b11> assetPair = (AssetPair<GUID, Asset_2018_1_0_b11>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A2C RID: 100908 RVA: 0x003EDE34 File Offset: 0x003EC034
		public static void WriteRelease_Map_GUID_Asset_2018_3_0(this AssetDictionary<GUID, Asset_2018_3_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<GUID, Asset_2018_3_0> assetPair = (AssetPair<GUID, Asset_2018_3_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A2D RID: 100909 RVA: 0x003EDE80 File Offset: 0x003EC080
		public static void WriteRelease_Map_GUID_Asset_2019_3_0_a8(this AssetDictionary<GUID, Asset_2019_3_0_a8> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<GUID, Asset_2019_3_0_a8> assetPair = (AssetPair<GUID, Asset_2019_3_0_a8>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A2E RID: 100910 RVA: 0x003EDECC File Offset: 0x003EC0CC
		public static void WriteRelease_Map_GUID_Asset_3_4_0(this AssetDictionary<GUID, Asset_3_4_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<GUID, Asset_3_4_0> assetPair = (AssetPair<GUID, Asset_3_4_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A2F RID: 100911 RVA: 0x003EDF18 File Offset: 0x003EC118
		public static void WriteRelease_Map_GUID_Asset_3_5_0(this AssetDictionary<GUID, Asset_3_5_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<GUID, Asset_3_5_0> assetPair = (AssetPair<GUID, Asset_3_5_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A30 RID: 100912 RVA: 0x003EDF64 File Offset: 0x003EC164
		public static void WriteRelease_Map_GUID_Asset_4_0_0(this AssetDictionary<GUID, Asset_4_0_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<GUID, Asset_4_0_0> assetPair = (AssetPair<GUID, Asset_4_0_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A31 RID: 100913 RVA: 0x003EDFB0 File Offset: 0x003EC1B0
		public static void WriteRelease_Map_GUID_Asset_4_3_0(this AssetDictionary<GUID, Asset_4_3_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<GUID, Asset_4_3_0> assetPair = (AssetPair<GUID, Asset_4_3_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A32 RID: 100914 RVA: 0x003EDFFC File Offset: 0x003EC1FC
		public static void WriteRelease_Map_GUID_Asset_5_0_0(this AssetDictionary<GUID, Asset_5_0_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<GUID, Asset_5_0_0> assetPair = (AssetPair<GUID, Asset_5_0_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A33 RID: 100915 RVA: 0x003EE048 File Offset: 0x003EC248
		public static void WriteRelease_Map_GUID_Asset_5_1_0(this AssetDictionary<GUID, Asset_5_1_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<GUID, Asset_5_1_0> assetPair = (AssetPair<GUID, Asset_5_1_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A34 RID: 100916 RVA: 0x003EE094 File Offset: 0x003EC294
		public static void WriteRelease_Map_GUID_Asset_5_5_0(this AssetDictionary<GUID, Asset_5_5_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<GUID, Asset_5_5_0> assetPair = (AssetPair<GUID, Asset_5_5_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A35 RID: 100917 RVA: 0x003EE0E0 File Offset: 0x003EC2E0
		public static void WriteRelease_Map_GUID_CachedAssetMetaData_3_4_0(this AssetDictionary<GUID, CachedAssetMetaData_3_4_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<GUID, CachedAssetMetaData_3_4_0> assetPair = (AssetPair<GUID, CachedAssetMetaData_3_4_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A36 RID: 100918 RVA: 0x003EE12C File Offset: 0x003EC32C
		public static void WriteRelease_Map_GUID_CachedAssetMetaData_5_0_0(this AssetDictionary<GUID, CachedAssetMetaData_5_0_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<GUID, CachedAssetMetaData_5_0_0> assetPair = (AssetPair<GUID, CachedAssetMetaData_5_0_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A37 RID: 100919 RVA: 0x003EE178 File Offset: 0x003EC378
		public static void WriteRelease_Map_GUID_DeletedItem_3_4_0(this AssetDictionary<GUID, DeletedItem_3_4_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<GUID, DeletedItem_3_4_0> assetPair = (AssetPair<GUID, DeletedItem_3_4_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A38 RID: 100920 RVA: 0x003EE1C4 File Offset: 0x003EC3C4
		public static void WriteRelease_Map_GUID_DeletedItem_5_0_0(this AssetDictionary<GUID, DeletedItem_5_0_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<GUID, DeletedItem_5_0_0> assetPair = (AssetPair<GUID, DeletedItem_5_0_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A39 RID: 100921 RVA: 0x003EE210 File Offset: 0x003EC410
		public static void WriteRelease_Map_GUID_Item(this AssetDictionary<GUID, Item> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<GUID, Item> assetPair = (AssetPair<GUID, Item>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A3A RID: 100922 RVA: 0x003EE25C File Offset: 0x003EC45C
		public static void WriteRelease_Map_GUID_ModifiedItem_3_4_0(this AssetDictionary<GUID, ModifiedItem_3_4_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<GUID, ModifiedItem_3_4_0> assetPair = (AssetPair<GUID, ModifiedItem_3_4_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A3B RID: 100923 RVA: 0x003EE2A8 File Offset: 0x003EC4A8
		public static void WriteRelease_Map_GUID_ModifiedItem_5_0_0(this AssetDictionary<GUID, ModifiedItem_5_0_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<GUID, ModifiedItem_5_0_0> assetPair = (AssetPair<GUID, ModifiedItem_5_0_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A3C RID: 100924 RVA: 0x003EE2F4 File Offset: 0x003EC4F4
		public static void WriteRelease_Map_GUID_PPtr_GameObject_3_4_0(this AssetDictionary<GUID, PPtr_GameObject_3_4_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<GUID, PPtr_GameObject_3_4_0> assetPair = (AssetPair<GUID, PPtr_GameObject_3_4_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A3D RID: 100925 RVA: 0x003EE340 File Offset: 0x003EC540
		public static void WriteRelease_Map_GUID_PPtr_GameObject_5_0_0(this AssetDictionary<GUID, PPtr_GameObject_5_0_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<GUID, PPtr_GameObject_5_0_0> assetPair = (AssetPair<GUID, PPtr_GameObject_5_0_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A3E RID: 100926 RVA: 0x003EE38C File Offset: 0x003EC58C
		public static void WriteRelease_Map_GUID_Utf8String(this AssetDictionary<GUID, Utf8String> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<GUID, Utf8String> assetPair = (AssetPair<GUID, Utf8String>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A3F RID: 100927 RVA: 0x003EE3D8 File Offset: 0x003EC5D8
		public static void WriteRelease_Map_Hash128_Hash128(this AssetDictionary<Hash128, Hash128> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Hash128, Hash128> assetPair = (AssetPair<Hash128, Hash128>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A40 RID: 100928 RVA: 0x003EE424 File Offset: 0x003EC624
		public static void WriteRelease_Map_Hash128_Int32(this AssetDictionary<Hash128, int> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Hash128, int> assetPair = (AssetPair<Hash128, int>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease_Int32(writer);
			}
		}

		// Token: 0x06018A41 RID: 100929 RVA: 0x003EE470 File Offset: 0x003EC670
		public static void WriteRelease_Map_Int32_AssetBundleFullName(this AssetDictionary<int, AssetBundleFullName> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<int, AssetBundleFullName> assetPair = (AssetPair<int, AssetBundleFullName>)value.GetPair(i);
				assetPair.Key.WriteRelease_Int32(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A42 RID: 100930 RVA: 0x003EE4BC File Offset: 0x003EC6BC
		public static void WriteRelease_Map_Int32_AssetBundleInfo(this AssetDictionary<int, AssetBundleInfo> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<int, AssetBundleInfo> assetPair = (AssetPair<int, AssetBundleInfo>)value.GetPair(i);
				assetPair.Key.WriteRelease_Int32(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A43 RID: 100931 RVA: 0x003EE508 File Offset: 0x003EC708
		public static void WriteRelease_Map_Int32_Hash128(this AssetDictionary<int, Hash128> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<int, Hash128> assetPair = (AssetPair<int, Hash128>)value.GetPair(i);
				assetPair.Key.WriteRelease_Int32(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A44 RID: 100932 RVA: 0x003EE554 File Offset: 0x003EC754
		public static void WriteRelease_Map_Int32_Int32(this AssetDictionary<int, int> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<int, int> assetPair = (AssetPair<int, int>)value.GetPair(i);
				assetPair.Key.WriteRelease_Int32(writer);
				assetPair.Value.WriteRelease_Int32(writer);
			}
		}

		// Token: 0x06018A45 RID: 100933 RVA: 0x003EE5A0 File Offset: 0x003EC7A0
		public static void WriteRelease_Map_Int32_SampleSettings_2022_2_0_a17(this AssetDictionary<int, SampleSettings_2022_2_0_a17> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<int, SampleSettings_2022_2_0_a17> assetPair = (AssetPair<int, SampleSettings_2022_2_0_a17>)value.GetPair(i);
				assetPair.Key.WriteRelease_Int32(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A46 RID: 100934 RVA: 0x003EE5EC File Offset: 0x003EC7EC
		public static void WriteRelease_Map_Int32_SampleSettings_5_0_0(this AssetDictionary<int, SampleSettings_5_0_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<int, SampleSettings_5_0_0> assetPair = (AssetPair<int, SampleSettings_5_0_0>)value.GetPair(i);
				assetPair.Key.WriteRelease_Int32(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A47 RID: 100935 RVA: 0x003EE638 File Offset: 0x003EC838
		public static void WriteRelease_Map_Int32_UInt32(this AssetDictionary<int, uint> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<int, uint> assetPair = (AssetPair<int, uint>)value.GetPair(i);
				assetPair.Key.WriteRelease_Int32(writer);
				assetPair.Value.WriteRelease_UInt32(writer);
			}
		}

		// Token: 0x06018A48 RID: 100936 RVA: 0x003EE684 File Offset: 0x003EC884
		public static void WriteRelease_Map_Int32_Utf8String(this AssetDictionary<int, Utf8String> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<int, Utf8String> assetPair = (AssetPair<int, Utf8String>)value.GetPair(i);
				assetPair.Key.WriteRelease_Int32(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A49 RID: 100937 RVA: 0x003EE6D0 File Offset: 0x003EC8D0
		public static void WriteRelease_Map_Int32_VideoClipImporterTargetSettings(this AssetDictionary<int, VideoClipImporterTargetSettings> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<int, VideoClipImporterTargetSettings> assetPair = (AssetPair<int, VideoClipImporterTargetSettings>)value.GetPair(i);
				assetPair.Key.WriteRelease_Int32(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A4A RID: 100938 RVA: 0x003EE71C File Offset: 0x003EC91C
		public static void WriteRelease_Map_Int64_Utf8String(this AssetDictionary<long, Utf8String> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<long, Utf8String> assetPair = (AssetPair<long, Utf8String>)value.GetPair(i);
				assetPair.Key.WriteRelease_Int64(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A4B RID: 100939 RVA: 0x003EE768 File Offset: 0x003EC968
		public static void WriteRelease_Map_Pair_GUID_Int32_SpriteRenderData_4_3_0(this AssetDictionary<AssetPair<GUID, int>, SpriteRenderData_4_3_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<AssetPair<GUID, int>, SpriteRenderData_4_3_0> assetPair = (AssetPair<AssetPair<GUID, int>, SpriteRenderData_4_3_0>)value.GetPair(i);
				assetPair.Key.WriteRelease_Pair_GUID_Int32(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A4C RID: 100940 RVA: 0x003EE7B4 File Offset: 0x003EC9B4
		public static void WriteRelease_Map_Pair_GUID_Int32_SpriteRenderData_4_5_0(this AssetDictionary<AssetPair<GUID, int>, SpriteRenderData_4_5_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<AssetPair<GUID, int>, SpriteRenderData_4_5_0> assetPair = (AssetPair<AssetPair<GUID, int>, SpriteRenderData_4_5_0>)value.GetPair(i);
				assetPair.Key.WriteRelease_Pair_GUID_Int32(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A4D RID: 100941 RVA: 0x003EE800 File Offset: 0x003ECA00
		public static void WriteRelease_Map_Pair_GUID_Int64_SpriteAtlasData_2017_1_0(this AssetDictionary<AssetPair<GUID, long>, SpriteAtlasData_2017_1_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<AssetPair<GUID, long>, SpriteAtlasData_2017_1_0> assetPair = (AssetPair<AssetPair<GUID, long>, SpriteAtlasData_2017_1_0>)value.GetPair(i);
				assetPair.Key.WriteRelease_Pair_GUID_Int64(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A4E RID: 100942 RVA: 0x003EE84C File Offset: 0x003ECA4C
		public static void WriteRelease_Map_Pair_GUID_Int64_SpriteAtlasData_2017_1_2(this AssetDictionary<AssetPair<GUID, long>, SpriteAtlasData_2017_1_2> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<AssetPair<GUID, long>, SpriteAtlasData_2017_1_2> assetPair = (AssetPair<AssetPair<GUID, long>, SpriteAtlasData_2017_1_2>)value.GetPair(i);
				assetPair.Key.WriteRelease_Pair_GUID_Int64(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A4F RID: 100943 RVA: 0x003EE898 File Offset: 0x003ECA98
		public static void WriteRelease_Map_Pair_GUID_Int64_SpriteAtlasData_2017_2_0(this AssetDictionary<AssetPair<GUID, long>, SpriteAtlasData_2017_2_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<AssetPair<GUID, long>, SpriteAtlasData_2017_2_0> assetPair = (AssetPair<AssetPair<GUID, long>, SpriteAtlasData_2017_2_0>)value.GetPair(i);
				assetPair.Key.WriteRelease_Pair_GUID_Int64(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A50 RID: 100944 RVA: 0x003EE8E4 File Offset: 0x003ECAE4
		public static void WriteRelease_Map_Pair_GUID_Int64_SpriteAtlasData_2017_2_0_b9(this AssetDictionary<AssetPair<GUID, long>, SpriteAtlasData_2017_2_0_b9> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<AssetPair<GUID, long>, SpriteAtlasData_2017_2_0_b9> assetPair = (AssetPair<AssetPair<GUID, long>, SpriteAtlasData_2017_2_0_b9>)value.GetPair(i);
				assetPair.Key.WriteRelease_Pair_GUID_Int64(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A51 RID: 100945 RVA: 0x003EE930 File Offset: 0x003ECB30
		public static void WriteRelease_Map_Pair_GUID_Int64_SpriteAtlasData_2020_2_0(this AssetDictionary<AssetPair<GUID, long>, SpriteAtlasData_2020_2_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<AssetPair<GUID, long>, SpriteAtlasData_2020_2_0> assetPair = (AssetPair<AssetPair<GUID, long>, SpriteAtlasData_2020_2_0>)value.GetPair(i);
				assetPair.Key.WriteRelease_Pair_GUID_Int64(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A52 RID: 100946 RVA: 0x003EE97C File Offset: 0x003ECB7C
		public static void WriteRelease_Map_Pair_GUID_Int64_SpriteRenderData_2017_1_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2017_1_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<AssetPair<GUID, long>, SpriteRenderData_2017_1_0> assetPair = (AssetPair<AssetPair<GUID, long>, SpriteRenderData_2017_1_0>)value.GetPair(i);
				assetPair.Key.WriteRelease_Pair_GUID_Int64(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A53 RID: 100947 RVA: 0x003EE9C8 File Offset: 0x003ECBC8
		public static void WriteRelease_Map_Pair_GUID_Int64_SpriteRenderData_2017_1_0_b4(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2017_1_0_b4> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<AssetPair<GUID, long>, SpriteRenderData_2017_1_0_b4> assetPair = (AssetPair<AssetPair<GUID, long>, SpriteRenderData_2017_1_0_b4>)value.GetPair(i);
				assetPair.Key.WriteRelease_Pair_GUID_Int64(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A54 RID: 100948 RVA: 0x003EEA14 File Offset: 0x003ECC14
		public static void WriteRelease_Map_Pair_GUID_Int64_SpriteRenderData_2017_3_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2017_3_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<AssetPair<GUID, long>, SpriteRenderData_2017_3_0> assetPair = (AssetPair<AssetPair<GUID, long>, SpriteRenderData_2017_3_0>)value.GetPair(i);
				assetPair.Key.WriteRelease_Pair_GUID_Int64(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A55 RID: 100949 RVA: 0x003EEA60 File Offset: 0x003ECC60
		public static void WriteRelease_Map_Pair_GUID_Int64_SpriteRenderData_2018_1_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2018_1_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<AssetPair<GUID, long>, SpriteRenderData_2018_1_0> assetPair = (AssetPair<AssetPair<GUID, long>, SpriteRenderData_2018_1_0>)value.GetPair(i);
				assetPair.Key.WriteRelease_Pair_GUID_Int64(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A56 RID: 100950 RVA: 0x003EEAAC File Offset: 0x003ECCAC
		public static void WriteRelease_Map_Pair_GUID_Int64_SpriteRenderData_2018_2_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2018_2_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<AssetPair<GUID, long>, SpriteRenderData_2018_2_0> assetPair = (AssetPair<AssetPair<GUID, long>, SpriteRenderData_2018_2_0>)value.GetPair(i);
				assetPair.Key.WriteRelease_Pair_GUID_Int64(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A57 RID: 100951 RVA: 0x003EEAF8 File Offset: 0x003ECCF8
		public static void WriteRelease_Map_Pair_GUID_Int64_SpriteRenderData_2019_1_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2019_1_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<AssetPair<GUID, long>, SpriteRenderData_2019_1_0> assetPair = (AssetPair<AssetPair<GUID, long>, SpriteRenderData_2019_1_0>)value.GetPair(i);
				assetPair.Key.WriteRelease_Pair_GUID_Int64(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A58 RID: 100952 RVA: 0x003EEB44 File Offset: 0x003ECD44
		public static void WriteRelease_Map_Pair_GUID_Int64_SpriteRenderData_5_0_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_0_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<AssetPair<GUID, long>, SpriteRenderData_5_0_0> assetPair = (AssetPair<AssetPair<GUID, long>, SpriteRenderData_5_0_0>)value.GetPair(i);
				assetPair.Key.WriteRelease_Pair_GUID_Int64(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A59 RID: 100953 RVA: 0x003EEB90 File Offset: 0x003ECD90
		public static void WriteRelease_Map_Pair_GUID_Int64_SpriteRenderData_5_2_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_2_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<AssetPair<GUID, long>, SpriteRenderData_5_2_0> assetPair = (AssetPair<AssetPair<GUID, long>, SpriteRenderData_5_2_0>)value.GetPair(i);
				assetPair.Key.WriteRelease_Pair_GUID_Int64(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A5A RID: 100954 RVA: 0x003EEBDC File Offset: 0x003ECDDC
		public static void WriteRelease_Map_Pair_GUID_Int64_SpriteRenderData_5_4_6(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_4_6> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<AssetPair<GUID, long>, SpriteRenderData_5_4_6> assetPair = (AssetPair<AssetPair<GUID, long>, SpriteRenderData_5_4_6>)value.GetPair(i);
				assetPair.Key.WriteRelease_Pair_GUID_Int64(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A5B RID: 100955 RVA: 0x003EEC28 File Offset: 0x003ECE28
		public static void WriteRelease_Map_Pair_GUID_Int64_SpriteRenderData_5_5_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_5_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<AssetPair<GUID, long>, SpriteRenderData_5_5_0> assetPair = (AssetPair<AssetPair<GUID, long>, SpriteRenderData_5_5_0>)value.GetPair(i);
				assetPair.Key.WriteRelease_Pair_GUID_Int64(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A5C RID: 100956 RVA: 0x003EEC74 File Offset: 0x003ECE74
		public static void WriteRelease_Map_Pair_GUID_Int64_SpriteRenderData_5_5_3(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_5_3> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<AssetPair<GUID, long>, SpriteRenderData_5_5_3> assetPair = (AssetPair<AssetPair<GUID, long>, SpriteRenderData_5_5_3>)value.GetPair(i);
				assetPair.Key.WriteRelease_Pair_GUID_Int64(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A5D RID: 100957 RVA: 0x003EECC0 File Offset: 0x003ECEC0
		public static void WriteRelease_Map_Pair_GUID_Int64_SpriteRenderData_5_6_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_6_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<AssetPair<GUID, long>, SpriteRenderData_5_6_0> assetPair = (AssetPair<AssetPair<GUID, long>, SpriteRenderData_5_6_0>)value.GetPair(i);
				assetPair.Key.WriteRelease_Pair_GUID_Int64(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A5E RID: 100958 RVA: 0x003EED0C File Offset: 0x003ECF0C
		public static void WriteRelease_Map_Pair_GUID_Int64_SpriteRenderData_5_6_0_b10(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_6_0_b10> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<AssetPair<GUID, long>, SpriteRenderData_5_6_0_b10> assetPair = (AssetPair<AssetPair<GUID, long>, SpriteRenderData_5_6_0_b10>)value.GetPair(i);
				assetPair.Key.WriteRelease_Pair_GUID_Int64(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A5F RID: 100959 RVA: 0x003EED58 File Offset: 0x003ECF58
		public static void WriteRelease_Map_Pair_GUID_Int64_SpriteRenderData_5_6_2(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_6_2> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<AssetPair<GUID, long>, SpriteRenderData_5_6_2> assetPair = (AssetPair<AssetPair<GUID, long>, SpriteRenderData_5_6_2>)value.GetPair(i);
				assetPair.Key.WriteRelease_Pair_GUID_Int64(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A60 RID: 100960 RVA: 0x003EEDA4 File Offset: 0x003ECFA4
		public static void WriteRelease_Map_Pair_UInt16_UInt16_Single(this AssetDictionary<AssetPair<ushort, ushort>, float> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<AssetPair<ushort, ushort>, float> assetPair = (AssetPair<AssetPair<ushort, ushort>, float>)value.GetPair(i);
				assetPair.Key.WriteRelease_Pair_UInt16_UInt16(writer);
				assetPair.Value.WriteRelease_Single(writer);
			}
		}

		// Token: 0x06018A61 RID: 100961 RVA: 0x003EEDF0 File Offset: 0x003ECFF0
		public static void WriteRelease_Map_Pair_Utf8String_Utf8String_PlatformSettingsData_Plugin(this AssetDictionary<AssetPair<Utf8String, Utf8String>, PlatformSettingsData_Plugin> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<AssetPair<Utf8String, Utf8String>, PlatformSettingsData_Plugin> assetPair = (AssetPair<AssetPair<Utf8String, Utf8String>, PlatformSettingsData_Plugin>)value.GetPair(i);
				assetPair.Key.WriteRelease_Pair_Utf8String_Utf8String(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A62 RID: 100962 RVA: 0x003EEE3C File Offset: 0x003ED03C
		public static void WriteRelease_Map_PPtr_AnimatorStateMachine_Array_PPtr_AnimatorTransition(this AssetDictionary<PPtr_AnimatorStateMachine, AssetList<PPtr_AnimatorTransition>> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<PPtr_AnimatorStateMachine, AssetList<PPtr_AnimatorTransition>> assetPair = (AssetPair<PPtr_AnimatorStateMachine, AssetList<PPtr_AnimatorTransition>>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease_Array_Asset(writer);
			}
		}

		// Token: 0x06018A63 RID: 100963 RVA: 0x003EEE88 File Offset: 0x003ED088
		public static void WriteRelease_Map_PPtr_AnimatorStateMachine_ArrayAlign_PPtr_AnimatorTransition(this AssetDictionary<PPtr_AnimatorStateMachine, AssetList<PPtr_AnimatorTransition>> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<PPtr_AnimatorStateMachine, AssetList<PPtr_AnimatorTransition>> assetPair = (AssetPair<PPtr_AnimatorStateMachine, AssetList<PPtr_AnimatorTransition>>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease_ArrayAlign_Asset(writer);
			}
		}

		// Token: 0x06018A64 RID: 100964 RVA: 0x003EEED4 File Offset: 0x003ED0D4
		public static void WriteRelease_Map_PPtr_Shader_3_4_0_Utf8String(this AssetDictionary<PPtr_Shader_3_4_0, Utf8String> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<PPtr_Shader_3_4_0, Utf8String> assetPair = (AssetPair<PPtr_Shader_3_4_0, Utf8String>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A65 RID: 100965 RVA: 0x003EEF20 File Offset: 0x003ED120
		public static void WriteRelease_Map_PPtr_Shader_5_0_0_ShaderInfo(this AssetDictionary<PPtr_Shader_5_0_0, ShaderInfo> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<PPtr_Shader_5_0_0, ShaderInfo> assetPair = (AssetPair<PPtr_Shader_5_0_0, ShaderInfo>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A66 RID: 100966 RVA: 0x003EEF6C File Offset: 0x003ED16C
		public static void WriteRelease_Map_PPtr_Shader_5_0_0_Utf8String(this AssetDictionary<PPtr_Shader_5_0_0, Utf8String> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<PPtr_Shader_5_0_0, Utf8String> assetPair = (AssetPair<PPtr_Shader_5_0_0, Utf8String>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A67 RID: 100967 RVA: 0x003EEFB8 File Offset: 0x003ED1B8
		public static void WriteRelease_Map_PPtr_State_Array_PPtr_Transition(this AssetDictionary<PPtr_State, AssetList<PPtr_Transition>> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<PPtr_State, AssetList<PPtr_Transition>> assetPair = (AssetPair<PPtr_State, AssetList<PPtr_Transition>>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease_Array_Asset(writer);
			}
		}

		// Token: 0x06018A68 RID: 100968 RVA: 0x003EF004 File Offset: 0x003ED204
		public static void WriteRelease_Map_PresetType_ArrayAlign_DefaultPreset_2019_3_0_a10(this AssetDictionary<PresetType, AssetList<DefaultPreset_2019_3_0_a10>> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<PresetType, AssetList<DefaultPreset_2019_3_0_a10>> assetPair = (AssetPair<PresetType, AssetList<DefaultPreset_2019_3_0_a10>>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease_ArrayAlign_Asset(writer);
			}
		}

		// Token: 0x06018A69 RID: 100969 RVA: 0x003EF050 File Offset: 0x003ED250
		public static void WriteRelease_Map_PresetType_ArrayAlign_DefaultPreset_2020_1_0_a23(this AssetDictionary<PresetType, AssetList<DefaultPreset_2020_1_0_a23>> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<PresetType, AssetList<DefaultPreset_2020_1_0_a23>> assetPair = (AssetPair<PresetType, AssetList<DefaultPreset_2020_1_0_a23>>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease_ArrayAlign_Asset(writer);
			}
		}

		// Token: 0x06018A6A RID: 100970 RVA: 0x003EF09C File Offset: 0x003ED29C
		public static void WriteRelease_Map_SceneIdentifier_HierarchicalSceneData(this AssetDictionary<SceneIdentifier, HierarchicalSceneData> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<SceneIdentifier, HierarchicalSceneData> assetPair = (AssetPair<SceneIdentifier, HierarchicalSceneData>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A6B RID: 100971 RVA: 0x003EF0E8 File Offset: 0x003ED2E8
		public static void WriteRelease_Map_SceneIdentifier_SceneVisibilityData(this AssetDictionary<SceneIdentifier, SceneVisibilityData> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<SceneIdentifier, SceneVisibilityData> assetPair = (AssetPair<SceneIdentifier, SceneVisibilityData>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A6C RID: 100972 RVA: 0x003EF134 File Offset: 0x003ED334
		public static void WriteRelease_Map_SourceAssetIdentifier_PPtr_Object_5_0_0(this AssetDictionary<SourceAssetIdentifier, PPtr_Object_5_0_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<SourceAssetIdentifier, PPtr_Object_5_0_0> assetPair = (AssetPair<SourceAssetIdentifier, PPtr_Object_5_0_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A6D RID: 100973 RVA: 0x003EF180 File Offset: 0x003ED380
		public static void WriteRelease_Map_StateKey_StateRange(this AssetDictionary<StateKey, StateRange> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<StateKey, StateRange> assetPair = (AssetPair<StateKey, StateRange>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A6E RID: 100974 RVA: 0x003EF1CC File Offset: 0x003ED3CC
		public static void WriteRelease_Map_UInt32_Utf8String(this AssetDictionary<uint, Utf8String> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<uint, Utf8String> assetPair = (AssetPair<uint, Utf8String>)value.GetPair(i);
				assetPair.Key.WriteRelease_UInt32(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A6F RID: 100975 RVA: 0x003EF218 File Offset: 0x003ED418
		public static void WriteRelease_Map_Utf8String_Array_Utf8String(this AssetDictionary<Utf8String, AssetList<Utf8String>> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Utf8String, AssetList<Utf8String>> assetPair = (AssetPair<Utf8String, AssetList<Utf8String>>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease_Array_Asset(writer);
			}
		}

		// Token: 0x06018A70 RID: 100976 RVA: 0x003EF264 File Offset: 0x003ED464
		public static void WriteRelease_Map_Utf8String_AssetInfo_3_4_0(this AssetDictionary<Utf8String, AssetInfo_3_4_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Utf8String, AssetInfo_3_4_0> assetPair = (AssetPair<Utf8String, AssetInfo_3_4_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A71 RID: 100977 RVA: 0x003EF2B0 File Offset: 0x003ED4B0
		public static void WriteRelease_Map_Utf8String_AssetInfo_5_0_0(this AssetDictionary<Utf8String, AssetInfo_5_0_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Utf8String, AssetInfo_5_0_0> assetPair = (AssetPair<Utf8String, AssetInfo_5_0_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A72 RID: 100978 RVA: 0x003EF2FC File Offset: 0x003ED4FC
		public static void WriteRelease_Map_Utf8String_AssetTimeStamp(this AssetDictionary<Utf8String, AssetTimeStamp> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Utf8String, AssetTimeStamp> assetPair = (AssetPair<Utf8String, AssetTimeStamp>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A73 RID: 100979 RVA: 0x003EF348 File Offset: 0x003ED548
		public static void WriteRelease_Map_Utf8String_ColorRGBAf_3_5_0(this AssetDictionary<Utf8String, ColorRGBAf_3_5_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Utf8String, ColorRGBAf_3_5_0> assetPair = (AssetPair<Utf8String, ColorRGBAf_3_5_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A74 RID: 100980 RVA: 0x003EF394 File Offset: 0x003ED594
		public static void WriteRelease_Map_Utf8String_ComputeShaderKernel_2020_1_0_a17(this AssetDictionary<Utf8String, ComputeShaderKernel_2020_1_0_a17> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Utf8String, ComputeShaderKernel_2020_1_0_a17> assetPair = (AssetPair<Utf8String, ComputeShaderKernel_2020_1_0_a17>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A75 RID: 100981 RVA: 0x003EF3E0 File Offset: 0x003ED5E0
		public static void WriteRelease_Map_Utf8String_ComputeShaderKernel_2020_1_0_a9(this AssetDictionary<Utf8String, ComputeShaderKernel_2020_1_0_a9> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Utf8String, ComputeShaderKernel_2020_1_0_a9> assetPair = (AssetPair<Utf8String, ComputeShaderKernel_2020_1_0_a9>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A76 RID: 100982 RVA: 0x003EF42C File Offset: 0x003ED62C
		public static void WriteRelease_Map_Utf8String_ComputeShaderKernel_2020_2_0_a15(this AssetDictionary<Utf8String, ComputeShaderKernel_2020_2_0_a15> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Utf8String, ComputeShaderKernel_2020_2_0_a15> assetPair = (AssetPair<Utf8String, ComputeShaderKernel_2020_2_0_a15>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A77 RID: 100983 RVA: 0x003EF478 File Offset: 0x003ED678
		public static void WriteRelease_Map_Utf8String_ComputeShaderKernel_2020_3_2(this AssetDictionary<Utf8String, ComputeShaderKernel_2020_3_2> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Utf8String, ComputeShaderKernel_2020_3_2> assetPair = (AssetPair<Utf8String, ComputeShaderKernel_2020_3_2>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A78 RID: 100984 RVA: 0x003EF4C4 File Offset: 0x003ED6C4
		public static void WriteRelease_Map_Utf8String_ComputeShaderKernel_2021_1_0(this AssetDictionary<Utf8String, ComputeShaderKernel_2021_1_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Utf8String, ComputeShaderKernel_2021_1_0> assetPair = (AssetPair<Utf8String, ComputeShaderKernel_2021_1_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A79 RID: 100985 RVA: 0x003EF510 File Offset: 0x003ED710
		public static void WriteRelease_Map_Utf8String_ComputeShaderKernel_2021_1_0_b7(this AssetDictionary<Utf8String, ComputeShaderKernel_2021_1_0_b7> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Utf8String, ComputeShaderKernel_2021_1_0_b7> assetPair = (AssetPair<Utf8String, ComputeShaderKernel_2021_1_0_b7>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A7A RID: 100986 RVA: 0x003EF55C File Offset: 0x003ED75C
		public static void WriteRelease_Map_Utf8String_ConfigSetting(this AssetDictionary<Utf8String, ConfigSetting> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Utf8String, ConfigSetting> assetPair = (AssetPair<Utf8String, ConfigSetting>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A7B RID: 100987 RVA: 0x003EF5A8 File Offset: 0x003ED7A8
		public static void WriteRelease_Map_Utf8String_GUID(this AssetDictionary<Utf8String, GUID> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Utf8String, GUID> assetPair = (AssetPair<Utf8String, GUID>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A7C RID: 100988 RVA: 0x003EF5F4 File Offset: 0x003ED7F4
		public static void WriteRelease_Map_Utf8String_Int32(this AssetDictionary<Utf8String, int> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Utf8String, int> assetPair = (AssetPair<Utf8String, int>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease_Int32(writer);
			}
		}

		// Token: 0x06018A7D RID: 100989 RVA: 0x003EF640 File Offset: 0x003ED840
		public static void WriteRelease_Map_Utf8String_Int64(this AssetDictionary<Utf8String, long> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Utf8String, long> assetPair = (AssetPair<Utf8String, long>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease_Int64(writer);
			}
		}

		// Token: 0x06018A7E RID: 100990 RVA: 0x003EF68C File Offset: 0x003ED88C
		public static void WriteRelease_Map_Utf8String_PlatformSettingsData_Editor(this AssetDictionary<Utf8String, PlatformSettingsData_Editor> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Utf8String, PlatformSettingsData_Editor> assetPair = (AssetPair<Utf8String, PlatformSettingsData_Editor>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A7F RID: 100991 RVA: 0x003EF6D8 File Offset: 0x003ED8D8
		public static void WriteRelease_Map_Utf8String_PlatformSettingsData_Plugin(this AssetDictionary<Utf8String, PlatformSettingsData_Plugin> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Utf8String, PlatformSettingsData_Plugin> assetPair = (AssetPair<Utf8String, PlatformSettingsData_Plugin>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A80 RID: 100992 RVA: 0x003EF724 File Offset: 0x003ED924
		public static void WriteRelease_Map_Utf8String_PPtr_Object_3_4_0(this AssetDictionary<Utf8String, PPtr_Object_3_4_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Utf8String, PPtr_Object_3_4_0> assetPair = (AssetPair<Utf8String, PPtr_Object_3_4_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A81 RID: 100993 RVA: 0x003EF770 File Offset: 0x003ED970
		public static void WriteRelease_Map_Utf8String_PPtr_Object_5_0_0(this AssetDictionary<Utf8String, PPtr_Object_5_0_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Utf8String, PPtr_Object_5_0_0> assetPair = (AssetPair<Utf8String, PPtr_Object_5_0_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A82 RID: 100994 RVA: 0x003EF7BC File Offset: 0x003ED9BC
		public static void WriteRelease_Map_Utf8String_PPtr_Texture_5_0_0(this AssetDictionary<Utf8String, PPtr_Texture_5_0_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Utf8String, PPtr_Texture_5_0_0> assetPair = (AssetPair<Utf8String, PPtr_Texture_5_0_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A83 RID: 100995 RVA: 0x003EF808 File Offset: 0x003EDA08
		public static void WriteRelease_Map_Utf8String_PPtr_Texture2D_3_4_0(this AssetDictionary<Utf8String, PPtr_Texture2D_3_4_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Utf8String, PPtr_Texture2D_3_4_0> assetPair = (AssetPair<Utf8String, PPtr_Texture2D_3_4_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A84 RID: 100996 RVA: 0x003EF854 File Offset: 0x003EDA54
		public static void WriteRelease_Map_Utf8String_PPtr_Texture2D_5_0_0(this AssetDictionary<Utf8String, PPtr_Texture2D_5_0_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Utf8String, PPtr_Texture2D_5_0_0> assetPair = (AssetPair<Utf8String, PPtr_Texture2D_5_0_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A85 RID: 100997 RVA: 0x003EF8A0 File Offset: 0x003EDAA0
		public static void WriteRelease_Map_Utf8String_SecondaryTextureSettings_2020_2_0_a12(this AssetDictionary<Utf8String, SecondaryTextureSettings_2020_2_0_a12> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Utf8String, SecondaryTextureSettings_2020_2_0_a12> assetPair = (AssetPair<Utf8String, SecondaryTextureSettings_2020_2_0_a12>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A86 RID: 100998 RVA: 0x003EF8EC File Offset: 0x003EDAEC
		public static void WriteRelease_Map_Utf8String_Single(this AssetDictionary<Utf8String, float> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Utf8String, float> assetPair = (AssetPair<Utf8String, float>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease_Single(writer);
			}
		}

		// Token: 0x06018A87 RID: 100999 RVA: 0x003EF938 File Offset: 0x003EDB38
		public static void WriteRelease_Map_Utf8String_UnityTexEnv_5_0_0(this AssetDictionary<Utf8String, UnityTexEnv_5_0_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Utf8String, UnityTexEnv_5_0_0> assetPair = (AssetPair<Utf8String, UnityTexEnv_5_0_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A88 RID: 101000 RVA: 0x003EF984 File Offset: 0x003EDB84
		public static void WriteRelease_Map_Utf8String_Utf8String(this AssetDictionary<Utf8String, Utf8String> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Utf8String, Utf8String> assetPair = (AssetPair<Utf8String, Utf8String>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A89 RID: 101001 RVA: 0x003EF9D0 File Offset: 0x003EDBD0
		public static void WriteRelease_Map_Vector3Int_Tile_2017_2_0(this AssetDictionary<Vector3Int, Tile_2017_2_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Vector3Int, Tile_2017_2_0> assetPair = (AssetPair<Vector3Int, Tile_2017_2_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A8A RID: 101002 RVA: 0x003EFA1C File Offset: 0x003EDC1C
		public static void WriteRelease_Map_Vector3Int_Tile_2017_2_0_b7(this AssetDictionary<Vector3Int, Tile_2017_2_0_b7> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Vector3Int, Tile_2017_2_0_b7> assetPair = (AssetPair<Vector3Int, Tile_2017_2_0_b7>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A8B RID: 101003 RVA: 0x003EFA68 File Offset: 0x003EDC68
		public static void WriteRelease_Map_Vector3Int_Tile_2019_3_0_a12(this AssetDictionary<Vector3Int, Tile_2019_3_0_a12> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Vector3Int, Tile_2019_3_0_a12> assetPair = (AssetPair<Vector3Int, Tile_2019_3_0_a12>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A8C RID: 101004 RVA: 0x003EFAB4 File Offset: 0x003EDCB4
		public static void WriteRelease_Map_Vector3Int_Tile_2019_4_24(this AssetDictionary<Vector3Int, Tile_2019_4_24> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Vector3Int, Tile_2019_4_24> assetPair = (AssetPair<Vector3Int, Tile_2019_4_24>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A8D RID: 101005 RVA: 0x003EFB00 File Offset: 0x003EDD00
		public static void WriteRelease_Map_Vector3Int_Tile_2020_1_0(this AssetDictionary<Vector3Int, Tile_2020_1_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Vector3Int, Tile_2020_1_0> assetPair = (AssetPair<Vector3Int, Tile_2020_1_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A8E RID: 101006 RVA: 0x003EFB4C File Offset: 0x003EDD4C
		public static void WriteRelease_Map_Vector3Int_Tile_2020_1_8(this AssetDictionary<Vector3Int, Tile_2020_1_8> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Vector3Int, Tile_2020_1_8> assetPair = (AssetPair<Vector3Int, Tile_2020_1_8>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A8F RID: 101007 RVA: 0x003EFB98 File Offset: 0x003EDD98
		public static void WriteRelease_Map_Vector3Int_Tile_2020_2_0(this AssetDictionary<Vector3Int, Tile_2020_2_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Vector3Int, Tile_2020_2_0> assetPair = (AssetPair<Vector3Int, Tile_2020_2_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A90 RID: 101008 RVA: 0x003EFBE4 File Offset: 0x003EDDE4
		public static void WriteRelease_Map_Vector3Int_Tile_2020_2_0_b1(this AssetDictionary<Vector3Int, Tile_2020_2_0_b1> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Vector3Int, Tile_2020_2_0_b1> assetPair = (AssetPair<Vector3Int, Tile_2020_2_0_b1>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A91 RID: 101009 RVA: 0x003EFC30 File Offset: 0x003EDE30
		public static void WriteRelease_Map_Vector3Int_TileAnimationData_2017_2_0(this AssetDictionary<Vector3Int, TileAnimationData_2017_2_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Vector3Int, TileAnimationData_2017_2_0> assetPair = (AssetPair<Vector3Int, TileAnimationData_2017_2_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A92 RID: 101010 RVA: 0x003EFC7C File Offset: 0x003EDE7C
		public static void WriteRelease_Map_Vector3Int_TileAnimationData_2022_2_0(this AssetDictionary<Vector3Int, TileAnimationData_2022_2_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Vector3Int, TileAnimationData_2022_2_0> assetPair = (AssetPair<Vector3Int, TileAnimationData_2022_2_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
		}

		// Token: 0x06018A93 RID: 101011 RVA: 0x003EFCC8 File Offset: 0x003EDEC8
		public static void WriteRelease_MapAlign_IntegerString_2017_1_0_PPtr_Object_5_0_0(this AssetDictionary<IntegerString_2017_1_0, PPtr_Object_5_0_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<IntegerString_2017_1_0, PPtr_Object_5_0_0> assetPair = (AssetPair<IntegerString_2017_1_0, PPtr_Object_5_0_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A94 RID: 101012 RVA: 0x003EFD18 File Offset: 0x003EDF18
		public static void WriteRelease_MapAlign_IntegerString_2019_1_0_PPtr_Object_5_0_0(this AssetDictionary<IntegerString_2019_1_0, PPtr_Object_5_0_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<IntegerString_2019_1_0, PPtr_Object_5_0_0> assetPair = (AssetPair<IntegerString_2019_1_0, PPtr_Object_5_0_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A95 RID: 101013 RVA: 0x003EFD68 File Offset: 0x003EDF68
		public static void WriteRelease_MapAlign_IntegerString_2020_1_0_PPtr_Object_5_0_0(this AssetDictionary<IntegerString_2020_1_0, PPtr_Object_5_0_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<IntegerString_2020_1_0, PPtr_Object_5_0_0> assetPair = (AssetPair<IntegerString_2020_1_0, PPtr_Object_5_0_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A96 RID: 101014 RVA: 0x003EFDB8 File Offset: 0x003EDFB8
		public static void WriteRelease_MapAlign_IntegerString_2020_2_0_PPtr_Object_5_0_0(this AssetDictionary<IntegerString_2020_2_0, PPtr_Object_5_0_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<IntegerString_2020_2_0, PPtr_Object_5_0_0> assetPair = (AssetPair<IntegerString_2020_2_0, PPtr_Object_5_0_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A97 RID: 101015 RVA: 0x003EFE08 File Offset: 0x003EE008
		public static void WriteRelease_MapAlign_NestedString_2018_4_25_PPtr_Object_5_0_0(this AssetDictionary<NestedString_2018_4_25, PPtr_Object_5_0_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<NestedString_2018_4_25, PPtr_Object_5_0_0> assetPair = (AssetPair<NestedString_2018_4_25, PPtr_Object_5_0_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A98 RID: 101016 RVA: 0x003EFE58 File Offset: 0x003EE058
		public static void WriteRelease_MapAlign_NestedString_2019_4_3_PPtr_Object_5_0_0(this AssetDictionary<NestedString_2019_4_3, PPtr_Object_5_0_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<NestedString_2019_4_3, PPtr_Object_5_0_0> assetPair = (AssetPair<NestedString_2019_4_3, PPtr_Object_5_0_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A99 RID: 101017 RVA: 0x003EFEA8 File Offset: 0x003EE0A8
		public static void WriteRelease_MapAlign_NestedString_2020_1_0_b15_PPtr_Object_5_0_0(this AssetDictionary<NestedString_2020_1_0_b15, PPtr_Object_5_0_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<NestedString_2020_1_0_b15, PPtr_Object_5_0_0> assetPair = (AssetPair<NestedString_2020_1_0_b15, PPtr_Object_5_0_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A9A RID: 101018 RVA: 0x003EFEF8 File Offset: 0x003EE0F8
		public static void WriteRelease_MapAlign_NestedString_2020_2_0_a16_PPtr_Object_5_0_0(this AssetDictionary<NestedString_2020_2_0_a16, PPtr_Object_5_0_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<NestedString_2020_2_0_a16, PPtr_Object_5_0_0> assetPair = (AssetPair<NestedString_2020_2_0_a16, PPtr_Object_5_0_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A9B RID: 101019 RVA: 0x003EFF48 File Offset: 0x003EE148
		public static void WriteRelease_MapAlign_SourceAssetIdentifier_PPtr_Object_5_0_0(this AssetDictionary<SourceAssetIdentifier, PPtr_Object_5_0_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<SourceAssetIdentifier, PPtr_Object_5_0_0> assetPair = (AssetPair<SourceAssetIdentifier, PPtr_Object_5_0_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A9C RID: 101020 RVA: 0x003EFF98 File Offset: 0x003EE198
		public static void WriteRelease_MapAlign_Utf8String_Boolean(this AssetDictionary<Utf8String, bool> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Utf8String, bool> assetPair = (AssetPair<Utf8String, bool>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease_Boolean(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A9D RID: 101021 RVA: 0x003EFFE8 File Offset: 0x003EE1E8
		public static void WriteRelease_MapAlign_Utf8String_Int32(this AssetDictionary<Utf8String, int> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Utf8String, int> assetPair = (AssetPair<Utf8String, int>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease_Int32(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A9E RID: 101022 RVA: 0x003F0038 File Offset: 0x003EE238
		public static void WriteRelease_MapAlign_Utf8String_NonAlignedStruct(this AssetDictionary<Utf8String, NonAlignedStruct> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Utf8String, NonAlignedStruct> assetPair = (AssetPair<Utf8String, NonAlignedStruct>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018A9F RID: 101023 RVA: 0x003F0088 File Offset: 0x003EE288
		public static void WriteRelease_MapAlign_Utf8String_SecondaryTextureSettings_2020_2_0(this AssetDictionary<Utf8String, SecondaryTextureSettings_2020_2_0> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Utf8String, SecondaryTextureSettings_2020_2_0> assetPair = (AssetPair<Utf8String, SecondaryTextureSettings_2020_2_0>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018AA0 RID: 101024 RVA: 0x003F00D8 File Offset: 0x003EE2D8
		public static void WriteRelease_MapAlign_Utf8String_SecondaryTextureSettings_2020_2_0_a12(this AssetDictionary<Utf8String, SecondaryTextureSettings_2020_2_0_a12> value, AssetWriter writer)
		{
			int count = value.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				AssetPair<Utf8String, SecondaryTextureSettings_2020_2_0_a12> assetPair = (AssetPair<Utf8String, SecondaryTextureSettings_2020_2_0_a12>)value.GetPair(i);
				assetPair.Key.WriteRelease(writer);
				assetPair.Value.WriteRelease(writer);
			}
			writer.AlignStream();
		}

		// Token: 0x06018AA1 RID: 101025 RVA: 0x003F0128 File Offset: 0x003EE328
		public static void WriteRelease_Pair_GUID_Int32(this AssetPair<GUID, int> value, AssetWriter writer)
		{
			value.Key.WriteRelease(writer);
			value.Value.WriteRelease_Int32(writer);
		}

		// Token: 0x06018AA2 RID: 101026 RVA: 0x003F0142 File Offset: 0x003EE342
		public static void WriteRelease_Pair_GUID_Int64(this AssetPair<GUID, long> value, AssetWriter writer)
		{
			value.Key.WriteRelease(writer);
			value.Value.WriteRelease_Int64(writer);
		}

		// Token: 0x06018AA3 RID: 101027 RVA: 0x003F015C File Offset: 0x003EE35C
		public static void WriteRelease_Pair_Int32_Int64(this AssetPair<int, long> value, AssetWriter writer)
		{
			value.Key.WriteRelease_Int32(writer);
			value.Value.WriteRelease_Int64(writer);
		}

		// Token: 0x06018AA4 RID: 101028 RVA: 0x003F0176 File Offset: 0x003EE376
		public static void WriteRelease_Pair_Int32_PPtr_Component_3_4_0(this AssetPair<int, PPtr_Component_3_4_0> value, AssetWriter writer)
		{
			value.Key.WriteRelease_Int32(writer);
			value.Value.WriteRelease(writer);
		}

		// Token: 0x06018AA5 RID: 101029 RVA: 0x003F0190 File Offset: 0x003EE390
		public static void WriteRelease_Pair_Int32_PPtr_Component_5_0_0(this AssetPair<int, PPtr_Component_5_0_0> value, AssetWriter writer)
		{
			value.Key.WriteRelease_Int32(writer);
			value.Value.WriteRelease(writer);
		}

		// Token: 0x06018AA6 RID: 101030 RVA: 0x003F01AA File Offset: 0x003EE3AA
		public static void WriteRelease_Pair_Int32_Single(this AssetPair<int, float> value, AssetWriter writer)
		{
			value.Key.WriteRelease_Int32(writer);
			value.Value.WriteRelease_Single(writer);
		}

		// Token: 0x06018AA7 RID: 101031 RVA: 0x003F01C4 File Offset: 0x003EE3C4
		public static void WriteRelease_Pair_Int32_UInt32(this AssetPair<int, uint> value, AssetWriter writer)
		{
			value.Key.WriteRelease_Int32(writer);
			value.Value.WriteRelease_UInt32(writer);
		}

		// Token: 0x06018AA8 RID: 101032 RVA: 0x003F01DE File Offset: 0x003EE3DE
		public static void WriteRelease_Pair_Pair_Int32_Int64_Utf8String(this AssetPair<AssetPair<int, long>, Utf8String> value, AssetWriter writer)
		{
			value.Key.WriteRelease_Pair_Int32_Int64(writer);
			value.Value.WriteRelease(writer);
		}

		// Token: 0x06018AA9 RID: 101033 RVA: 0x003F01F8 File Offset: 0x003EE3F8
		public static void WriteRelease_Pair_PPtr_SphereCollider_PPtr_SphereCollider(this AssetPair<PPtr_SphereCollider, PPtr_SphereCollider> value, AssetWriter writer)
		{
			value.Key.WriteRelease(writer);
			value.Value.WriteRelease(writer);
		}

		// Token: 0x06018AAA RID: 101034 RVA: 0x003F0212 File Offset: 0x003EE412
		public static void WriteRelease_Pair_UInt16_UInt16(this AssetPair<ushort, ushort> value, AssetWriter writer)
		{
			value.Key.WriteRelease_UInt16(writer);
			value.Value.WriteRelease_UInt16(writer);
		}

		// Token: 0x06018AAB RID: 101035 RVA: 0x003F022C File Offset: 0x003EE42C
		public static void WriteRelease_Pair_Utf8String_Boolean(this AssetPair<Utf8String, bool> value, AssetWriter writer)
		{
			value.Key.WriteRelease(writer);
			value.Value.WriteRelease_Boolean(writer);
		}

		// Token: 0x06018AAC RID: 101036 RVA: 0x003F0246 File Offset: 0x003EE446
		public static void WriteRelease_Pair_Utf8String_PPtr_Object_3_4_0(this AssetPair<Utf8String, PPtr_Object_3_4_0> value, AssetWriter writer)
		{
			value.Key.WriteRelease(writer);
			value.Value.WriteRelease(writer);
		}

		// Token: 0x06018AAD RID: 101037 RVA: 0x003F0260 File Offset: 0x003EE460
		public static void WriteRelease_Pair_Utf8String_PPtr_Object_5_0_0(this AssetPair<Utf8String, PPtr_Object_5_0_0> value, AssetWriter writer)
		{
			value.Key.WriteRelease(writer);
			value.Value.WriteRelease(writer);
		}

		// Token: 0x06018AAE RID: 101038 RVA: 0x003F027A File Offset: 0x003EE47A
		public static void WriteRelease_Pair_Utf8String_PPtr_Texture_3_4_0(this AssetPair<Utf8String, PPtr_Texture_3_4_0> value, AssetWriter writer)
		{
			value.Key.WriteRelease(writer);
			value.Value.WriteRelease(writer);
		}

		// Token: 0x06018AAF RID: 101039 RVA: 0x003F0294 File Offset: 0x003EE494
		public static void WriteRelease_Pair_Utf8String_PPtr_Texture_5_0_0(this AssetPair<Utf8String, PPtr_Texture_5_0_0> value, AssetWriter writer)
		{
			value.Key.WriteRelease(writer);
			value.Value.WriteRelease(writer);
		}

		// Token: 0x06018AB0 RID: 101040 RVA: 0x003F02AE File Offset: 0x003EE4AE
		public static void WriteRelease_Pair_Utf8String_UInt32(this AssetPair<Utf8String, uint> value, AssetWriter writer)
		{
			value.Key.WriteRelease(writer);
			value.Value.WriteRelease_UInt32(writer);
		}

		// Token: 0x06018AB1 RID: 101041 RVA: 0x003F02C8 File Offset: 0x003EE4C8
		public static void WriteRelease_Pair_Utf8String_Utf8String(this AssetPair<Utf8String, Utf8String> value, AssetWriter writer)
		{
			value.Key.WriteRelease(writer);
			value.Value.WriteRelease(writer);
		}

		// Token: 0x06018AB2 RID: 101042 RVA: 0x003F02E2 File Offset: 0x003EE4E2
		public static void WriteRelease_SByte(this sbyte value, AssetWriter writer)
		{
			writer.Write(value);
		}

		// Token: 0x06018AB3 RID: 101043 RVA: 0x003F02EB File Offset: 0x003EE4EB
		public static void WriteRelease_SByteAlign(this sbyte value, AssetWriter writer)
		{
			writer.Write(value);
			writer.AlignStream();
		}

		// Token: 0x06018AB4 RID: 101044 RVA: 0x003F02FA File Offset: 0x003EE4FA
		public static void WriteRelease_Single(this float value, AssetWriter writer)
		{
			writer.Write(value);
		}

		// Token: 0x06018AB5 RID: 101045 RVA: 0x003F0303 File Offset: 0x003EE503
		public static void WriteRelease_SingleAlign(this float value, AssetWriter writer)
		{
			writer.Write(value);
			writer.AlignStream();
		}

		// Token: 0x06018AB6 RID: 101046 RVA: 0x003F0312 File Offset: 0x003EE512
		public static void WriteRelease_TypelessDataAlign(this byte[] value, AssetWriter writer)
		{
			writer.Write(value.Length);
			writer.Write(value);
			writer.AlignStream();
		}

		// Token: 0x06018AB7 RID: 101047 RVA: 0x003F032A File Offset: 0x003EE52A
		public static void WriteRelease_UInt16(this ushort value, AssetWriter writer)
		{
			writer.Write(value);
		}

		// Token: 0x06018AB8 RID: 101048 RVA: 0x003F0333 File Offset: 0x003EE533
		public static void WriteRelease_UInt16Align(this ushort value, AssetWriter writer)
		{
			writer.Write(value);
			writer.AlignStream();
		}

		// Token: 0x06018AB9 RID: 101049 RVA: 0x003F0342 File Offset: 0x003EE542
		public static void WriteRelease_UInt32(this uint value, AssetWriter writer)
		{
			writer.Write(value);
		}

		// Token: 0x06018ABA RID: 101050 RVA: 0x003F034B File Offset: 0x003EE54B
		public static void WriteRelease_UInt32Align(this uint value, AssetWriter writer)
		{
			writer.Write(value);
			writer.AlignStream();
		}

		// Token: 0x06018ABB RID: 101051 RVA: 0x003F035A File Offset: 0x003EE55A
		public static void WriteRelease_UInt64(this ulong value, AssetWriter writer)
		{
			writer.Write(value);
		}
	}
}
