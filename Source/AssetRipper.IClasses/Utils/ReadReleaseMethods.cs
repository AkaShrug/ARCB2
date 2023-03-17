using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using AssetRipper.Assets;
using AssetRipper.Assets.Generics;
using AssetRipper.Assets.IO.Reading;
using AssetRipper.SourceGenerated.Subclasses.AssetBundleFullName;
using AssetRipper.SourceGenerated.Subclasses.AssetBundleInfo;
using AssetRipper.SourceGenerated.Subclasses.AssetImporterHashKey;
using AssetRipper.SourceGenerated.Subclasses.DefaultPreset;
using AssetRipper.SourceGenerated.Subclasses.FastPropertyName;
using AssetRipper.SourceGenerated.Subclasses.GUID;
using AssetRipper.SourceGenerated.Subclasses.Hash128;
using AssetRipper.SourceGenerated.Subclasses.PlatformSettingsData_Plugin;
using AssetRipper.SourceGenerated.Subclasses.PPtr_AnimatorStateMachine;
using AssetRipper.SourceGenerated.Subclasses.PPtr_AnimatorTransition;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Component;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Object;
using AssetRipper.SourceGenerated.Subclasses.PPtr_SphereCollider;
using AssetRipper.SourceGenerated.Subclasses.PPtr_State;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Texture;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Transition;
using AssetRipper.SourceGenerated.Subclasses.PresetType;
using AssetRipper.SourceGenerated.Subclasses.SampleSettings;
using AssetRipper.SourceGenerated.Subclasses.SerializedPlayerSubProgram;
using AssetRipper.SourceGenerated.Subclasses.SpriteAtlasData;
using AssetRipper.SourceGenerated.Subclasses.SpriteRenderData;
using AssetRipper.SourceGenerated.Subclasses.Utf8String;
using AssetRipper.SourceGenerated.Subclasses.Vector2f;
using AssetRipper.SourceGenerated.Subclasses.Vector2Long;
using AssetRipper.SourceGenerated.Subclasses.VideoClipImporterTargetSettings;

namespace AssetRipper.SourceGenerated.Helpers
{
	// Token: 0x02001C28 RID: 7208
	
	
	internal static class ReadReleaseMethods
	{
		// Token: 0x06018890 RID: 100496 RVA: 0x003E7C41 File Offset: 0x003E5E41
		public static void ReadRelease_AssetAlign< T>(this T value, AssetReader reader) where T : UnityAssetBase, new()
		{
			value.ReadRelease(reader);
			reader.AlignStream();
		}

		// Token: 0x06018891 RID: 100497 RVA: 0x003E7C58 File Offset: 0x003E5E58
		public static void ReadRelease_Array_Asset< T>(this AssetList<T> value, AssetReader reader) where T : UnityAssetBase, new()
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				T t = new T();
				t.ReadRelease(reader);
				value.Add(t);
			}
		}

		// Token: 0x06018892 RID: 100498 RVA: 0x003E7C98 File Offset: 0x003E5E98
		public static void ReadRelease_ArrayAlign_Asset< T>(this AssetList<T> value, AssetReader reader) where T : UnityAssetBase, new()
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				T t = new T();
				t.ReadRelease(reader);
				value.Add(t);
			}
			reader.AlignStream();
		}

		// Token: 0x06018893 RID: 100499 RVA: 0x003E7CE0 File Offset: 0x003E5EE0
		public static void ReadRelease_Map_Asset_Asset< TKey,  TValue>(this AssetDictionary<TKey, TValue> value, AssetReader reader) where TKey : UnityAssetBase, new() where TValue : UnityAssetBase, new()
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				TKey tkey = new TKey();
				tkey.ReadRelease(reader);
				TValue tvalue = new TValue();
				tvalue.ReadRelease(reader);
				value.Add(tkey, tvalue);
			}
		}

		// Token: 0x06018894 RID: 100500 RVA: 0x003E7D34 File Offset: 0x003E5F34
		public static void ReadRelease_MapAlign_Asset_Asset< TKey,  TValue>(this AssetDictionary<TKey, TValue> value, AssetReader reader) where TKey : UnityAssetBase, new() where TValue : UnityAssetBase, new()
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				TKey tkey = new TKey();
				tkey.ReadRelease(reader);
				TValue tvalue = new TValue();
				tvalue.ReadRelease(reader);
				value.Add(tkey, tvalue);
			}
			reader.AlignStream();
		}

		// Token: 0x06018895 RID: 100501 RVA: 0x003E7D8C File Offset: 0x003E5F8C
		public static void ReadRelease_Array_Array_Vector2f_3_5_0(this AssetList<AssetList<Vector2f_3_5_0>> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetList<Vector2f_3_5_0> assetList = new AssetList<Vector2f_3_5_0>();
				assetList.ReadRelease_Array_Asset(reader);
				value.Add(assetList);
			}
		}

		// Token: 0x06018896 RID: 100502 RVA: 0x003E7DC8 File Offset: 0x003E5FC8
		public static void ReadRelease_Array_Array_Vector2Long(this AssetList<AssetList<Vector2Long>> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetList<Vector2Long> assetList = new AssetList<Vector2Long>();
				assetList.ReadRelease_Array_Asset(reader);
				value.Add(assetList);
			}
		}

		// Token: 0x06018897 RID: 100503 RVA: 0x003E7E04 File Offset: 0x003E6004
		public static int[] ReadRelease_Array_Int32(this AssetReader reader)
		{
			int num = reader.ReadInt32();
			int[] array;
			if (num <= 1024)
			{
				array = new int[num];
				for (int i = 0; i < num; i++)
				{
					array[i] = reader.ReadInt32();
				}
			}
			else
			{
				List<int> list = new List<int>(1024);
				for (int j = 0; j < num; j++)
				{
					list.Add(reader.ReadInt32());
				}
				array = list.ToArray();
			}
			return array;
		}

		// Token: 0x06018898 RID: 100504 RVA: 0x003E7E70 File Offset: 0x003E6070
		public static void ReadRelease_Array_Pair_Int32_PPtr_Component_3_4_0(this AssetList<AssetPair<int, PPtr_Component_3_4_0>> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<int, PPtr_Component_3_4_0> assetPair = new AssetPair<int, PPtr_Component_3_4_0>();
				assetPair.ReadRelease_Pair_Int32_PPtr_Component_3_4_0(reader);
				value.Add(assetPair);
			}
		}

		// Token: 0x06018899 RID: 100505 RVA: 0x003E7EAC File Offset: 0x003E60AC
		public static void ReadRelease_Array_Pair_Int32_PPtr_Component_5_0_0(this AssetList<AssetPair<int, PPtr_Component_5_0_0>> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<int, PPtr_Component_5_0_0> assetPair = new AssetPair<int, PPtr_Component_5_0_0>();
				assetPair.ReadRelease_Pair_Int32_PPtr_Component_5_0_0(reader);
				value.Add(assetPair);
			}
		}

		// Token: 0x0601889A RID: 100506 RVA: 0x003E7EE8 File Offset: 0x003E60E8
		public static void ReadRelease_Array_Pair_Int32_Single(this AssetList<AssetPair<int, float>> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<int, float> assetPair = new AssetPair<int, float>();
				assetPair.ReadRelease_Pair_Int32_Single(reader);
				value.Add(assetPair);
			}
		}

		// Token: 0x0601889B RID: 100507 RVA: 0x003E7F24 File Offset: 0x003E6124
		public static void ReadRelease_Array_Pair_Int32_UInt32(this AssetList<AssetPair<int, uint>> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<int, uint> assetPair = new AssetPair<int, uint>();
				assetPair.ReadRelease_Pair_Int32_UInt32(reader);
				value.Add(assetPair);
			}
		}

		// Token: 0x0601889C RID: 100508 RVA: 0x003E7F60 File Offset: 0x003E6160
		public static void ReadRelease_Array_Pair_PPtr_SphereCollider_PPtr_SphereCollider(this AssetList<AssetPair<PPtr_SphereCollider, PPtr_SphereCollider>> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<PPtr_SphereCollider, PPtr_SphereCollider> assetPair = new AssetPair<PPtr_SphereCollider, PPtr_SphereCollider>();
				assetPair.ReadRelease_Pair_PPtr_SphereCollider_PPtr_SphereCollider(reader);
				value.Add(assetPair);
			}
		}

		// Token: 0x0601889D RID: 100509 RVA: 0x003E7F9C File Offset: 0x003E619C
		public static void ReadRelease_Array_Pair_Utf8String_PPtr_Object_3_4_0(this AssetList<AssetPair<Utf8String, PPtr_Object_3_4_0>> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<Utf8String, PPtr_Object_3_4_0> assetPair = new AssetPair<Utf8String, PPtr_Object_3_4_0>();
				assetPair.ReadRelease_Pair_Utf8String_PPtr_Object_3_4_0(reader);
				value.Add(assetPair);
			}
		}

		// Token: 0x0601889E RID: 100510 RVA: 0x003E7FD8 File Offset: 0x003E61D8
		public static void ReadRelease_Array_Pair_Utf8String_PPtr_Object_5_0_0(this AssetList<AssetPair<Utf8String, PPtr_Object_5_0_0>> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<Utf8String, PPtr_Object_5_0_0> assetPair = new AssetPair<Utf8String, PPtr_Object_5_0_0>();
				assetPair.ReadRelease_Pair_Utf8String_PPtr_Object_5_0_0(reader);
				value.Add(assetPair);
			}
		}

		// Token: 0x0601889F RID: 100511 RVA: 0x003E8014 File Offset: 0x003E6214
		public static sbyte[] ReadRelease_Array_SByte(this AssetReader reader)
		{
			int num = reader.ReadInt32();
			sbyte[] array;
			if (num <= 1024)
			{
				array = new sbyte[num];
				for (int i = 0; i < num; i++)
				{
					array[i] = reader.ReadSByte();
				}
			}
			else
			{
				List<sbyte> list = new List<sbyte>(1024);
				for (int j = 0; j < num; j++)
				{
					list.Add(reader.ReadSByte());
				}
				array = list.ToArray();
			}
			return array;
		}

		// Token: 0x060188A0 RID: 100512 RVA: 0x003E8080 File Offset: 0x003E6280
		public static float[] ReadRelease_Array_Single(this AssetReader reader)
		{
			int num = reader.ReadInt32();
			float[] array;
			if (num <= 1024)
			{
				array = new float[num];
				for (int i = 0; i < num; i++)
				{
					array[i] = reader.ReadSingle();
				}
			}
			else
			{
				List<float> list = new List<float>(1024);
				for (int j = 0; j < num; j++)
				{
					list.Add(reader.ReadSingle());
				}
				array = list.ToArray();
			}
			return array;
		}

		// Token: 0x060188A1 RID: 100513 RVA: 0x003E80EC File Offset: 0x003E62EC
		public static ushort[] ReadRelease_Array_UInt16(this AssetReader reader)
		{
			int num = reader.ReadInt32();
			ushort[] array;
			if (num <= 1024)
			{
				array = new ushort[num];
				for (int i = 0; i < num; i++)
				{
					array[i] = reader.ReadUInt16();
				}
			}
			else
			{
				List<ushort> list = new List<ushort>(1024);
				for (int j = 0; j < num; j++)
				{
					list.Add(reader.ReadUInt16());
				}
				array = list.ToArray();
			}
			return array;
		}

		// Token: 0x060188A2 RID: 100514 RVA: 0x003E8158 File Offset: 0x003E6358
		public static uint[] ReadRelease_Array_UInt32(this AssetReader reader)
		{
			int num = reader.ReadInt32();
			uint[] array;
			if (num <= 1024)
			{
				array = new uint[num];
				for (int i = 0; i < num; i++)
				{
					array[i] = reader.ReadUInt32();
				}
			}
			else
			{
				List<uint> list = new List<uint>(1024);
				for (int j = 0; j < num; j++)
				{
					list.Add(reader.ReadUInt32());
				}
				array = list.ToArray();
			}
			return array;
		}

		// Token: 0x060188A3 RID: 100515 RVA: 0x003E81C4 File Offset: 0x003E63C4
		public static void ReadRelease_ArrayAlign_ArrayAlign_SerializedPlayerSubProgram_2021_3_10(this AssetList<AssetList<SerializedPlayerSubProgram_2021_3_10>> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetList<SerializedPlayerSubProgram_2021_3_10> assetList = new AssetList<SerializedPlayerSubProgram_2021_3_10>();
				assetList.ReadRelease_ArrayAlign_Asset(reader);
				value.Add(assetList);
			}
			reader.AlignStream();
		}

		// Token: 0x060188A4 RID: 100516 RVA: 0x003E8204 File Offset: 0x003E6404
		public static void ReadRelease_ArrayAlign_ArrayAlign_SerializedPlayerSubProgram_2022_1_13(this AssetList<AssetList<SerializedPlayerSubProgram_2022_1_13>> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetList<SerializedPlayerSubProgram_2022_1_13> assetList = new AssetList<SerializedPlayerSubProgram_2022_1_13>();
				assetList.ReadRelease_ArrayAlign_Asset(reader);
				value.Add(assetList);
			}
			reader.AlignStream();
		}

		// Token: 0x060188A5 RID: 100517 RVA: 0x003E8244 File Offset: 0x003E6444
		public static void ReadRelease_ArrayAlign_ArrayAlign_SerializedPlayerSubProgram_2022_2_0_b5(this AssetList<AssetList<SerializedPlayerSubProgram_2022_2_0_b5>> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetList<SerializedPlayerSubProgram_2022_2_0_b5> assetList = new AssetList<SerializedPlayerSubProgram_2022_2_0_b5>();
				assetList.ReadRelease_ArrayAlign_Asset(reader);
				value.Add(assetList);
			}
			reader.AlignStream();
		}

		// Token: 0x060188A6 RID: 100518 RVA: 0x003E8284 File Offset: 0x003E6484
		public static uint[][] ReadRelease_ArrayAlign_ArrayAlign_UInt32(this AssetReader reader)
		{
			int num = reader.ReadInt32();
			uint[][] array;
			if (num <= 1024)
			{
				array = new uint[num][];
				for (int i = 0; i < num; i++)
				{
					array[i] = reader.ReadRelease_ArrayAlign_UInt32();
				}
			}
			else
			{
				List<uint[]> list = new List<uint[]>(1024);
				for (int j = 0; j < num; j++)
				{
					list.Add(reader.ReadRelease_ArrayAlign_UInt32());
				}
				array = list.ToArray();
			}
			reader.AlignStream();
			return array;
		}

		// Token: 0x060188A7 RID: 100519 RVA: 0x003E82F4 File Offset: 0x003E64F4
		public static void ReadRelease_ArrayAlign_ArrayAlign_Vector2f_3_5_0(this AssetList<AssetList<Vector2f_3_5_0>> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetList<Vector2f_3_5_0> assetList = new AssetList<Vector2f_3_5_0>();
				assetList.ReadRelease_ArrayAlign_Asset(reader);
				value.Add(assetList);
			}
			reader.AlignStream();
		}

		// Token: 0x060188A8 RID: 100520 RVA: 0x003E8334 File Offset: 0x003E6534
		public static void ReadRelease_ArrayAlign_ArrayAlign_Vector2Long(this AssetList<AssetList<Vector2Long>> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetList<Vector2Long> assetList = new AssetList<Vector2Long>();
				assetList.ReadRelease_ArrayAlign_Asset(reader);
				value.Add(assetList);
			}
			reader.AlignStream();
		}

		// Token: 0x060188A9 RID: 100521 RVA: 0x003E8374 File Offset: 0x003E6574
		public static bool[] ReadRelease_ArrayAlign_Boolean(this AssetReader reader)
		{
			int num = reader.ReadInt32();
			bool[] array;
			if (num <= 1024)
			{
				array = new bool[num];
				for (int i = 0; i < num; i++)
				{
					array[i] = reader.ReadBoolean();
				}
			}
			else
			{
				List<bool> list = new List<bool>(1024);
				for (int j = 0; j < num; j++)
				{
					list.Add(reader.ReadBoolean());
				}
				array = list.ToArray();
			}
			reader.AlignStream();
			return array;
		}

		// Token: 0x060188AA RID: 100522 RVA: 0x003E83E4 File Offset: 0x003E65E4
		public static byte[] ReadRelease_ArrayAlign_Byte(this AssetReader reader)
		{
			int num = reader.ReadInt32();
			byte[] array;
			if (num <= 1048576)
			{
				array = reader.ReadBytes(num);
				if (array.Length != num)
				{
					throw new EndOfStreamException();
				}
			}
			else
			{
				List<byte> list = new List<byte>(1024);
				for (int i = 0; i < num; i++)
				{
					list.Add(reader.ReadByte());
				}
				array = list.ToArray();
			}
			reader.AlignStream();
			return array;
		}

		// Token: 0x060188AB RID: 100523 RVA: 0x003E8448 File Offset: 0x003E6648
		public static short[] ReadRelease_ArrayAlign_Int16(this AssetReader reader)
		{
			int num = reader.ReadInt32();
			short[] array;
			if (num <= 1024)
			{
				array = new short[num];
				for (int i = 0; i < num; i++)
				{
					array[i] = reader.ReadInt16();
				}
			}
			else
			{
				List<short> list = new List<short>(1024);
				for (int j = 0; j < num; j++)
				{
					list.Add(reader.ReadInt16());
				}
				array = list.ToArray();
			}
			reader.AlignStream();
			return array;
		}

		// Token: 0x060188AC RID: 100524 RVA: 0x003E84B8 File Offset: 0x003E66B8
		public static int[] ReadRelease_ArrayAlign_Int32(this AssetReader reader)
		{
			int num = reader.ReadInt32();
			int[] array;
			if (num <= 1024)
			{
				array = new int[num];
				for (int i = 0; i < num; i++)
				{
					array[i] = reader.ReadInt32();
				}
			}
			else
			{
				List<int> list = new List<int>(1024);
				for (int j = 0; j < num; j++)
				{
					list.Add(reader.ReadInt32());
				}
				array = list.ToArray();
			}
			reader.AlignStream();
			return array;
		}

		// Token: 0x060188AD RID: 100525 RVA: 0x003E8528 File Offset: 0x003E6728
		public static long[] ReadRelease_ArrayAlign_Int64(this AssetReader reader)
		{
			int num = reader.ReadInt32();
			long[] array;
			if (num <= 1024)
			{
				array = new long[num];
				for (int i = 0; i < num; i++)
				{
					array[i] = reader.ReadInt64();
				}
			}
			else
			{
				List<long> list = new List<long>(1024);
				for (int j = 0; j < num; j++)
				{
					list.Add(reader.ReadInt64());
				}
				array = list.ToArray();
			}
			reader.AlignStream();
			return array;
		}

		// Token: 0x060188AE RID: 100526 RVA: 0x003E8598 File Offset: 0x003E6798
		public static void ReadRelease_ArrayAlign_Pair_Pair_Int32_Int64_Utf8String(this AssetList<AssetPair<AssetPair<int, long>, Utf8String>> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<AssetPair<int, long>, Utf8String> assetPair = new AssetPair<AssetPair<int, long>, Utf8String>();
				assetPair.ReadRelease_Pair_Pair_Int32_Int64_Utf8String(reader);
				value.Add(assetPair);
			}
			reader.AlignStream();
		}

		// Token: 0x060188AF RID: 100527 RVA: 0x003E85D8 File Offset: 0x003E67D8
		public static void ReadRelease_ArrayAlign_Pair_PPtr_SphereCollider_PPtr_SphereCollider(this AssetList<AssetPair<PPtr_SphereCollider, PPtr_SphereCollider>> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<PPtr_SphereCollider, PPtr_SphereCollider> assetPair = new AssetPair<PPtr_SphereCollider, PPtr_SphereCollider>();
				assetPair.ReadRelease_Pair_PPtr_SphereCollider_PPtr_SphereCollider(reader);
				value.Add(assetPair);
			}
			reader.AlignStream();
		}

		// Token: 0x060188B0 RID: 100528 RVA: 0x003E8618 File Offset: 0x003E6818
		public static void ReadRelease_ArrayAlign_Pair_Utf8String_Boolean(this AssetList<AssetPair<Utf8String, bool>> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<Utf8String, bool> assetPair = new AssetPair<Utf8String, bool>();
				assetPair.ReadRelease_Pair_Utf8String_Boolean(reader);
				value.Add(assetPair);
			}
			reader.AlignStream();
		}

		// Token: 0x060188B1 RID: 100529 RVA: 0x003E8658 File Offset: 0x003E6858
		public static void ReadRelease_ArrayAlign_Pair_Utf8String_PPtr_Object_5_0_0(this AssetList<AssetPair<Utf8String, PPtr_Object_5_0_0>> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<Utf8String, PPtr_Object_5_0_0> assetPair = new AssetPair<Utf8String, PPtr_Object_5_0_0>();
				assetPair.ReadRelease_Pair_Utf8String_PPtr_Object_5_0_0(reader);
				value.Add(assetPair);
			}
			reader.AlignStream();
		}

		// Token: 0x060188B2 RID: 100530 RVA: 0x003E8698 File Offset: 0x003E6898
		public static void ReadRelease_ArrayAlign_Pair_Utf8String_PPtr_Texture_3_4_0(this AssetList<AssetPair<Utf8String, PPtr_Texture_3_4_0>> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<Utf8String, PPtr_Texture_3_4_0> assetPair = new AssetPair<Utf8String, PPtr_Texture_3_4_0>();
				assetPair.ReadRelease_Pair_Utf8String_PPtr_Texture_3_4_0(reader);
				value.Add(assetPair);
			}
			reader.AlignStream();
		}

		// Token: 0x060188B3 RID: 100531 RVA: 0x003E86D8 File Offset: 0x003E68D8
		public static void ReadRelease_ArrayAlign_Pair_Utf8String_PPtr_Texture_5_0_0(this AssetList<AssetPair<Utf8String, PPtr_Texture_5_0_0>> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<Utf8String, PPtr_Texture_5_0_0> assetPair = new AssetPair<Utf8String, PPtr_Texture_5_0_0>();
				assetPair.ReadRelease_Pair_Utf8String_PPtr_Texture_5_0_0(reader);
				value.Add(assetPair);
			}
			reader.AlignStream();
		}

		// Token: 0x060188B4 RID: 100532 RVA: 0x003E8718 File Offset: 0x003E6918
		public static void ReadRelease_ArrayAlign_Pair_Utf8String_UInt32(this AssetList<AssetPair<Utf8String, uint>> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<Utf8String, uint> assetPair = new AssetPair<Utf8String, uint>();
				assetPair.ReadRelease_Pair_Utf8String_UInt32(reader);
				value.Add(assetPair);
			}
			reader.AlignStream();
		}

		// Token: 0x060188B5 RID: 100533 RVA: 0x003E8758 File Offset: 0x003E6958
		public static float[] ReadRelease_ArrayAlign_Single(this AssetReader reader)
		{
			int num = reader.ReadInt32();
			float[] array;
			if (num <= 1024)
			{
				array = new float[num];
				for (int i = 0; i < num; i++)
				{
					array[i] = reader.ReadSingle();
				}
			}
			else
			{
				List<float> list = new List<float>(1024);
				for (int j = 0; j < num; j++)
				{
					list.Add(reader.ReadSingle());
				}
				array = list.ToArray();
			}
			reader.AlignStream();
			return array;
		}

		// Token: 0x060188B6 RID: 100534 RVA: 0x003E87C8 File Offset: 0x003E69C8
		public static ushort[] ReadRelease_ArrayAlign_UInt16(this AssetReader reader)
		{
			int num = reader.ReadInt32();
			ushort[] array;
			if (num <= 1024)
			{
				array = new ushort[num];
				for (int i = 0; i < num; i++)
				{
					array[i] = reader.ReadUInt16();
				}
			}
			else
			{
				List<ushort> list = new List<ushort>(1024);
				for (int j = 0; j < num; j++)
				{
					list.Add(reader.ReadUInt16());
				}
				array = list.ToArray();
			}
			reader.AlignStream();
			return array;
		}

		// Token: 0x060188B7 RID: 100535 RVA: 0x003E8838 File Offset: 0x003E6A38
		public static uint[] ReadRelease_ArrayAlign_UInt32(this AssetReader reader)
		{
			int num = reader.ReadInt32();
			uint[] array;
			if (num <= 1024)
			{
				array = new uint[num];
				for (int i = 0; i < num; i++)
				{
					array[i] = reader.ReadUInt32();
				}
			}
			else
			{
				List<uint> list = new List<uint>(1024);
				for (int j = 0; j < num; j++)
				{
					list.Add(reader.ReadUInt32());
				}
				array = list.ToArray();
			}
			reader.AlignStream();
			return array;
		}

		// Token: 0x060188B8 RID: 100536 RVA: 0x003E88A7 File Offset: 0x003E6AA7
		public static bool ReadRelease_BooleanAlign(this AssetReader reader)
		{
			bool flag = reader.ReadBoolean();
			reader.AlignStream();
			return flag;
		}

		// Token: 0x060188B9 RID: 100537 RVA: 0x003E88B5 File Offset: 0x003E6AB5
		public static byte ReadRelease_ByteAlign(this AssetReader reader)
		{
			byte b = reader.ReadByte();
			reader.AlignStream();
			return b;
		}

		// Token: 0x060188BA RID: 100538 RVA: 0x003E88C3 File Offset: 0x003E6AC3
		public static short ReadRelease_Int16Align(this AssetReader reader)
		{
			short num = reader.ReadInt16();
			reader.AlignStream();
			return num;
		}

		// Token: 0x060188BB RID: 100539 RVA: 0x003E88D1 File Offset: 0x003E6AD1
		public static int ReadRelease_Int32Align(this AssetReader reader)
		{
			int num = reader.ReadInt32();
			reader.AlignStream();
			return num;
		}

		// Token: 0x060188BC RID: 100540 RVA: 0x003E88DF File Offset: 0x003E6ADF
		public static long ReadRelease_Int64Align(this AssetReader reader)
		{
			long num = reader.ReadInt64();
			reader.AlignStream();
			return num;
		}

		// Token: 0x060188BD RID: 100541 RVA: 0x003E88F0 File Offset: 0x003E6AF0
		public static void ReadRelease_Map_AssetImporterHashKey_UInt32(this AssetDictionary<AssetImporterHashKey, uint> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetImporterHashKey assetImporterHashKey = new AssetImporterHashKey();
				assetImporterHashKey.ReadRelease(reader);
				uint num2 = reader.ReadUInt32();
				value.Add(assetImporterHashKey, num2);
			}
		}

		// Token: 0x060188BE RID: 100542 RVA: 0x003E8934 File Offset: 0x003E6B34
		public static void ReadRelease_Map_FastPropertyName_Single(this AssetDictionary<FastPropertyName, float> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				FastPropertyName fastPropertyName = new FastPropertyName();
				fastPropertyName.ReadRelease(reader);
				float num2 = reader.ReadSingle();
				value.Add(fastPropertyName, num2);
			}
		}

		// Token: 0x060188BF RID: 100543 RVA: 0x003E8978 File Offset: 0x003E6B78
		public static void ReadRelease_Map_Hash128_Int32(this AssetDictionary<Hash128, int> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				Hash128 hash = new Hash128();
				hash.ReadRelease(reader);
				int num2 = reader.ReadInt32();
				value.Add(hash, num2);
			}
		}

		// Token: 0x060188C0 RID: 100544 RVA: 0x003E89BC File Offset: 0x003E6BBC
		public static void ReadRelease_Map_Int32_AssetBundleFullName(this AssetDictionary<int, AssetBundleFullName> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				int num2 = reader.ReadInt32();
				AssetBundleFullName assetBundleFullName = new AssetBundleFullName();
				assetBundleFullName.ReadRelease(reader);
				value.Add(num2, assetBundleFullName);
			}
		}

		// Token: 0x060188C1 RID: 100545 RVA: 0x003E8A00 File Offset: 0x003E6C00
		public static void ReadRelease_Map_Int32_AssetBundleInfo(this AssetDictionary<int, AssetBundleInfo> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				int num2 = reader.ReadInt32();
				AssetBundleInfo assetBundleInfo = new AssetBundleInfo();
				assetBundleInfo.ReadRelease(reader);
				value.Add(num2, assetBundleInfo);
			}
		}

		// Token: 0x060188C2 RID: 100546 RVA: 0x003E8A44 File Offset: 0x003E6C44
		public static void ReadRelease_Map_Int32_Hash128(this AssetDictionary<int, Hash128> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				int num2 = reader.ReadInt32();
				Hash128 hash = new Hash128();
				hash.ReadRelease(reader);
				value.Add(num2, hash);
			}
		}

		// Token: 0x060188C3 RID: 100547 RVA: 0x003E8A88 File Offset: 0x003E6C88
		public static void ReadRelease_Map_Int32_Int32(this AssetDictionary<int, int> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				int num2 = reader.ReadInt32();
				int num3 = reader.ReadInt32();
				value.Add(num2, num3);
			}
		}

		// Token: 0x060188C4 RID: 100548 RVA: 0x003E8AC4 File Offset: 0x003E6CC4
		public static void ReadRelease_Map_Int32_SampleSettings_2022_2_0_a17(this AssetDictionary<int, SampleSettings_2022_2_0_a17> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				int num2 = reader.ReadInt32();
				SampleSettings_2022_2_0_a17 sampleSettings_2022_2_0_a = new SampleSettings_2022_2_0_a17();
				sampleSettings_2022_2_0_a.ReadRelease(reader);
				value.Add(num2, sampleSettings_2022_2_0_a);
			}
		}

		// Token: 0x060188C5 RID: 100549 RVA: 0x003E8B08 File Offset: 0x003E6D08
		public static void ReadRelease_Map_Int32_SampleSettings_5_0_0(this AssetDictionary<int, SampleSettings_5_0_0> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				int num2 = reader.ReadInt32();
				SampleSettings_5_0_0 sampleSettings_5_0_ = new SampleSettings_5_0_0();
				sampleSettings_5_0_.ReadRelease(reader);
				value.Add(num2, sampleSettings_5_0_);
			}
		}

		// Token: 0x060188C6 RID: 100550 RVA: 0x003E8B4C File Offset: 0x003E6D4C
		public static void ReadRelease_Map_Int32_UInt32(this AssetDictionary<int, uint> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				int num2 = reader.ReadInt32();
				uint num3 = reader.ReadUInt32();
				value.Add(num2, num3);
			}
		}

		// Token: 0x060188C7 RID: 100551 RVA: 0x003E8B88 File Offset: 0x003E6D88
		public static void ReadRelease_Map_Int32_Utf8String(this AssetDictionary<int, Utf8String> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				int num2 = reader.ReadInt32();
				Utf8String utf8String = new Utf8String();
				utf8String.ReadRelease(reader);
				value.Add(num2, utf8String);
			}
		}

		// Token: 0x060188C8 RID: 100552 RVA: 0x003E8BCC File Offset: 0x003E6DCC
		public static void ReadRelease_Map_Int32_VideoClipImporterTargetSettings(this AssetDictionary<int, VideoClipImporterTargetSettings> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				int num2 = reader.ReadInt32();
				VideoClipImporterTargetSettings videoClipImporterTargetSettings = new VideoClipImporterTargetSettings();
				videoClipImporterTargetSettings.ReadRelease(reader);
				value.Add(num2, videoClipImporterTargetSettings);
			}
		}

		// Token: 0x060188C9 RID: 100553 RVA: 0x003E8C10 File Offset: 0x003E6E10
		public static void ReadRelease_Map_Int64_Utf8String(this AssetDictionary<long, Utf8String> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				long num2 = reader.ReadInt64();
				Utf8String utf8String = new Utf8String();
				utf8String.ReadRelease(reader);
				value.Add(num2, utf8String);
			}
		}

		// Token: 0x060188CA RID: 100554 RVA: 0x003E8C54 File Offset: 0x003E6E54
		public static void ReadRelease_Map_Pair_GUID_Int32_SpriteRenderData_4_3_0(this AssetDictionary<AssetPair<GUID, int>, SpriteRenderData_4_3_0> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<GUID, int> assetPair = new AssetPair<GUID, int>();
				assetPair.ReadRelease_Pair_GUID_Int32(reader);
				SpriteRenderData_4_3_0 spriteRenderData_4_3_ = new SpriteRenderData_4_3_0();
				spriteRenderData_4_3_.ReadRelease(reader);
				value.Add(assetPair, spriteRenderData_4_3_);
			}
		}

		// Token: 0x060188CB RID: 100555 RVA: 0x003E8C9C File Offset: 0x003E6E9C
		public static void ReadRelease_Map_Pair_GUID_Int32_SpriteRenderData_4_5_0(this AssetDictionary<AssetPair<GUID, int>, SpriteRenderData_4_5_0> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<GUID, int> assetPair = new AssetPair<GUID, int>();
				assetPair.ReadRelease_Pair_GUID_Int32(reader);
				SpriteRenderData_4_5_0 spriteRenderData_4_5_ = new SpriteRenderData_4_5_0();
				spriteRenderData_4_5_.ReadRelease(reader);
				value.Add(assetPair, spriteRenderData_4_5_);
			}
		}

		// Token: 0x060188CC RID: 100556 RVA: 0x003E8CE4 File Offset: 0x003E6EE4
		public static void ReadRelease_Map_Pair_GUID_Int64_SpriteAtlasData_2017_1_0(this AssetDictionary<AssetPair<GUID, long>, SpriteAtlasData_2017_1_0> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<GUID, long> assetPair = new AssetPair<GUID, long>();
				assetPair.ReadRelease_Pair_GUID_Int64(reader);
				SpriteAtlasData_2017_1_0 spriteAtlasData_2017_1_ = new SpriteAtlasData_2017_1_0();
				spriteAtlasData_2017_1_.ReadRelease(reader);
				value.Add(assetPair, spriteAtlasData_2017_1_);
			}
		}

		// Token: 0x060188CD RID: 100557 RVA: 0x003E8D2C File Offset: 0x003E6F2C
		public static void ReadRelease_Map_Pair_GUID_Int64_SpriteAtlasData_2017_1_2(this AssetDictionary<AssetPair<GUID, long>, SpriteAtlasData_2017_1_2> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<GUID, long> assetPair = new AssetPair<GUID, long>();
				assetPair.ReadRelease_Pair_GUID_Int64(reader);
				SpriteAtlasData_2017_1_2 spriteAtlasData_2017_1_ = new SpriteAtlasData_2017_1_2();
				spriteAtlasData_2017_1_.ReadRelease(reader);
				value.Add(assetPair, spriteAtlasData_2017_1_);
			}
		}

		// Token: 0x060188CE RID: 100558 RVA: 0x003E8D74 File Offset: 0x003E6F74
		public static void ReadRelease_Map_Pair_GUID_Int64_SpriteAtlasData_2017_2_0(this AssetDictionary<AssetPair<GUID, long>, SpriteAtlasData_2017_2_0> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<GUID, long> assetPair = new AssetPair<GUID, long>();
				assetPair.ReadRelease_Pair_GUID_Int64(reader);
				SpriteAtlasData_2017_2_0 spriteAtlasData_2017_2_ = new SpriteAtlasData_2017_2_0();
				spriteAtlasData_2017_2_.ReadRelease(reader);
				value.Add(assetPair, spriteAtlasData_2017_2_);
			}
		}

		// Token: 0x060188CF RID: 100559 RVA: 0x003E8DBC File Offset: 0x003E6FBC
		public static void ReadRelease_Map_Pair_GUID_Int64_SpriteAtlasData_2017_2_0_b9(this AssetDictionary<AssetPair<GUID, long>, SpriteAtlasData_2017_2_0_b9> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<GUID, long> assetPair = new AssetPair<GUID, long>();
				assetPair.ReadRelease_Pair_GUID_Int64(reader);
				SpriteAtlasData_2017_2_0_b9 spriteAtlasData_2017_2_0_b = new SpriteAtlasData_2017_2_0_b9();
				spriteAtlasData_2017_2_0_b.ReadRelease(reader);
				value.Add(assetPair, spriteAtlasData_2017_2_0_b);
			}
		}

		// Token: 0x060188D0 RID: 100560 RVA: 0x003E8E04 File Offset: 0x003E7004
		public static void ReadRelease_Map_Pair_GUID_Int64_SpriteAtlasData_2020_2_0(this AssetDictionary<AssetPair<GUID, long>, SpriteAtlasData_2020_2_0> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<GUID, long> assetPair = new AssetPair<GUID, long>();
				assetPair.ReadRelease_Pair_GUID_Int64(reader);
				SpriteAtlasData_2020_2_0 spriteAtlasData_2020_2_ = new SpriteAtlasData_2020_2_0();
				spriteAtlasData_2020_2_.ReadRelease(reader);
				value.Add(assetPair, spriteAtlasData_2020_2_);
			}
		}

		// Token: 0x060188D1 RID: 100561 RVA: 0x003E8E4C File Offset: 0x003E704C
		public static void ReadRelease_Map_Pair_GUID_Int64_SpriteRenderData_2017_1_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2017_1_0> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<GUID, long> assetPair = new AssetPair<GUID, long>();
				assetPair.ReadRelease_Pair_GUID_Int64(reader);
				SpriteRenderData_2017_1_0 spriteRenderData_2017_1_ = new SpriteRenderData_2017_1_0();
				spriteRenderData_2017_1_.ReadRelease(reader);
				value.Add(assetPair, spriteRenderData_2017_1_);
			}
		}

		// Token: 0x060188D2 RID: 100562 RVA: 0x003E8E94 File Offset: 0x003E7094
		public static void ReadRelease_Map_Pair_GUID_Int64_SpriteRenderData_2017_1_0_b4(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2017_1_0_b4> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<GUID, long> assetPair = new AssetPair<GUID, long>();
				assetPair.ReadRelease_Pair_GUID_Int64(reader);
				SpriteRenderData_2017_1_0_b4 spriteRenderData_2017_1_0_b = new SpriteRenderData_2017_1_0_b4();
				spriteRenderData_2017_1_0_b.ReadRelease(reader);
				value.Add(assetPair, spriteRenderData_2017_1_0_b);
			}
		}

		// Token: 0x060188D3 RID: 100563 RVA: 0x003E8EDC File Offset: 0x003E70DC
		public static void ReadRelease_Map_Pair_GUID_Int64_SpriteRenderData_2017_3_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2017_3_0> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<GUID, long> assetPair = new AssetPair<GUID, long>();
				assetPair.ReadRelease_Pair_GUID_Int64(reader);
				SpriteRenderData_2017_3_0 spriteRenderData_2017_3_ = new SpriteRenderData_2017_3_0();
				spriteRenderData_2017_3_.ReadRelease(reader);
				value.Add(assetPair, spriteRenderData_2017_3_);
			}
		}

		// Token: 0x060188D4 RID: 100564 RVA: 0x003E8F24 File Offset: 0x003E7124
		public static void ReadRelease_Map_Pair_GUID_Int64_SpriteRenderData_2018_1_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2018_1_0> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<GUID, long> assetPair = new AssetPair<GUID, long>();
				assetPair.ReadRelease_Pair_GUID_Int64(reader);
				SpriteRenderData_2018_1_0 spriteRenderData_2018_1_ = new SpriteRenderData_2018_1_0();
				spriteRenderData_2018_1_.ReadRelease(reader);
				value.Add(assetPair, spriteRenderData_2018_1_);
			}
		}

		// Token: 0x060188D5 RID: 100565 RVA: 0x003E8F6C File Offset: 0x003E716C
		public static void ReadRelease_Map_Pair_GUID_Int64_SpriteRenderData_2018_2_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2018_2_0> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<GUID, long> assetPair = new AssetPair<GUID, long>();
				assetPair.ReadRelease_Pair_GUID_Int64(reader);
				SpriteRenderData_2018_2_0 spriteRenderData_2018_2_ = new SpriteRenderData_2018_2_0();
				spriteRenderData_2018_2_.ReadRelease(reader);
				value.Add(assetPair, spriteRenderData_2018_2_);
			}
		}

		// Token: 0x060188D6 RID: 100566 RVA: 0x003E8FB4 File Offset: 0x003E71B4
		public static void ReadRelease_Map_Pair_GUID_Int64_SpriteRenderData_2019_1_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_2019_1_0> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<GUID, long> assetPair = new AssetPair<GUID, long>();
				assetPair.ReadRelease_Pair_GUID_Int64(reader);
				SpriteRenderData_2019_1_0 spriteRenderData_2019_1_ = new SpriteRenderData_2019_1_0();
				spriteRenderData_2019_1_.ReadRelease(reader);
				value.Add(assetPair, spriteRenderData_2019_1_);
			}
		}

		// Token: 0x060188D7 RID: 100567 RVA: 0x003E8FFC File Offset: 0x003E71FC
		public static void ReadRelease_Map_Pair_GUID_Int64_SpriteRenderData_5_0_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_0_0> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<GUID, long> assetPair = new AssetPair<GUID, long>();
				assetPair.ReadRelease_Pair_GUID_Int64(reader);
				SpriteRenderData_5_0_0 spriteRenderData_5_0_ = new SpriteRenderData_5_0_0();
				spriteRenderData_5_0_.ReadRelease(reader);
				value.Add(assetPair, spriteRenderData_5_0_);
			}
		}

		// Token: 0x060188D8 RID: 100568 RVA: 0x003E9044 File Offset: 0x003E7244
		public static void ReadRelease_Map_Pair_GUID_Int64_SpriteRenderData_5_2_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_2_0> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<GUID, long> assetPair = new AssetPair<GUID, long>();
				assetPair.ReadRelease_Pair_GUID_Int64(reader);
				SpriteRenderData_5_2_0 spriteRenderData_5_2_ = new SpriteRenderData_5_2_0();
				spriteRenderData_5_2_.ReadRelease(reader);
				value.Add(assetPair, spriteRenderData_5_2_);
			}
		}

		// Token: 0x060188D9 RID: 100569 RVA: 0x003E908C File Offset: 0x003E728C
		public static void ReadRelease_Map_Pair_GUID_Int64_SpriteRenderData_5_4_6(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_4_6> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<GUID, long> assetPair = new AssetPair<GUID, long>();
				assetPair.ReadRelease_Pair_GUID_Int64(reader);
				SpriteRenderData_5_4_6 spriteRenderData_5_4_ = new SpriteRenderData_5_4_6();
				spriteRenderData_5_4_.ReadRelease(reader);
				value.Add(assetPair, spriteRenderData_5_4_);
			}
		}

		// Token: 0x060188DA RID: 100570 RVA: 0x003E90D4 File Offset: 0x003E72D4
		public static void ReadRelease_Map_Pair_GUID_Int64_SpriteRenderData_5_5_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_5_0> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<GUID, long> assetPair = new AssetPair<GUID, long>();
				assetPair.ReadRelease_Pair_GUID_Int64(reader);
				SpriteRenderData_5_5_0 spriteRenderData_5_5_ = new SpriteRenderData_5_5_0();
				spriteRenderData_5_5_.ReadRelease(reader);
				value.Add(assetPair, spriteRenderData_5_5_);
			}
		}

		// Token: 0x060188DB RID: 100571 RVA: 0x003E911C File Offset: 0x003E731C
		public static void ReadRelease_Map_Pair_GUID_Int64_SpriteRenderData_5_5_3(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_5_3> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<GUID, long> assetPair = new AssetPair<GUID, long>();
				assetPair.ReadRelease_Pair_GUID_Int64(reader);
				SpriteRenderData_5_5_3 spriteRenderData_5_5_ = new SpriteRenderData_5_5_3();
				spriteRenderData_5_5_.ReadRelease(reader);
				value.Add(assetPair, spriteRenderData_5_5_);
			}
		}

		// Token: 0x060188DC RID: 100572 RVA: 0x003E9164 File Offset: 0x003E7364
		public static void ReadRelease_Map_Pair_GUID_Int64_SpriteRenderData_5_6_0(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_6_0> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<GUID, long> assetPair = new AssetPair<GUID, long>();
				assetPair.ReadRelease_Pair_GUID_Int64(reader);
				SpriteRenderData_5_6_0 spriteRenderData_5_6_ = new SpriteRenderData_5_6_0();
				spriteRenderData_5_6_.ReadRelease(reader);
				value.Add(assetPair, spriteRenderData_5_6_);
			}
		}

		// Token: 0x060188DD RID: 100573 RVA: 0x003E91AC File Offset: 0x003E73AC
		public static void ReadRelease_Map_Pair_GUID_Int64_SpriteRenderData_5_6_0_b10(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_6_0_b10> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<GUID, long> assetPair = new AssetPair<GUID, long>();
				assetPair.ReadRelease_Pair_GUID_Int64(reader);
				SpriteRenderData_5_6_0_b10 spriteRenderData_5_6_0_b = new SpriteRenderData_5_6_0_b10();
				spriteRenderData_5_6_0_b.ReadRelease(reader);
				value.Add(assetPair, spriteRenderData_5_6_0_b);
			}
		}

		// Token: 0x060188DE RID: 100574 RVA: 0x003E91F4 File Offset: 0x003E73F4
		public static void ReadRelease_Map_Pair_GUID_Int64_SpriteRenderData_5_6_2(this AssetDictionary<AssetPair<GUID, long>, SpriteRenderData_5_6_2> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<GUID, long> assetPair = new AssetPair<GUID, long>();
				assetPair.ReadRelease_Pair_GUID_Int64(reader);
				SpriteRenderData_5_6_2 spriteRenderData_5_6_ = new SpriteRenderData_5_6_2();
				spriteRenderData_5_6_.ReadRelease(reader);
				value.Add(assetPair, spriteRenderData_5_6_);
			}
		}

		// Token: 0x060188DF RID: 100575 RVA: 0x003E923C File Offset: 0x003E743C
		public static void ReadRelease_Map_Pair_UInt16_UInt16_Single(this AssetDictionary<AssetPair<ushort, ushort>, float> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<ushort, ushort> assetPair = new AssetPair<ushort, ushort>();
				assetPair.ReadRelease_Pair_UInt16_UInt16(reader);
				float num2 = reader.ReadSingle();
				value.Add(assetPair, num2);
			}
		}

		// Token: 0x060188E0 RID: 100576 RVA: 0x003E9280 File Offset: 0x003E7480
		public static void ReadRelease_Map_Pair_Utf8String_Utf8String_PlatformSettingsData_Plugin(this AssetDictionary<AssetPair<Utf8String, Utf8String>, PlatformSettingsData_Plugin> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				AssetPair<Utf8String, Utf8String> assetPair = new AssetPair<Utf8String, Utf8String>();
				assetPair.ReadRelease_Pair_Utf8String_Utf8String(reader);
				PlatformSettingsData_Plugin platformSettingsData_Plugin = new PlatformSettingsData_Plugin();
				platformSettingsData_Plugin.ReadRelease(reader);
				value.Add(assetPair, platformSettingsData_Plugin);
			}
		}

		// Token: 0x060188E1 RID: 100577 RVA: 0x003E92C8 File Offset: 0x003E74C8
		public static void ReadRelease_Map_PPtr_AnimatorStateMachine_Array_PPtr_AnimatorTransition(this AssetDictionary<PPtr_AnimatorStateMachine, AssetList<PPtr_AnimatorTransition>> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				PPtr_AnimatorStateMachine pptr_AnimatorStateMachine = new PPtr_AnimatorStateMachine();
				pptr_AnimatorStateMachine.ReadRelease(reader);
				AssetList<PPtr_AnimatorTransition> assetList = new AssetList<PPtr_AnimatorTransition>();
				assetList.ReadRelease_Array_Asset(reader);
				value.Add(pptr_AnimatorStateMachine, assetList);
			}
		}

		// Token: 0x060188E2 RID: 100578 RVA: 0x003E9310 File Offset: 0x003E7510
		public static void ReadRelease_Map_PPtr_AnimatorStateMachine_ArrayAlign_PPtr_AnimatorTransition(this AssetDictionary<PPtr_AnimatorStateMachine, AssetList<PPtr_AnimatorTransition>> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				PPtr_AnimatorStateMachine pptr_AnimatorStateMachine = new PPtr_AnimatorStateMachine();
				pptr_AnimatorStateMachine.ReadRelease(reader);
				AssetList<PPtr_AnimatorTransition> assetList = new AssetList<PPtr_AnimatorTransition>();
				assetList.ReadRelease_ArrayAlign_Asset(reader);
				value.Add(pptr_AnimatorStateMachine, assetList);
			}
		}

		// Token: 0x060188E3 RID: 100579 RVA: 0x003E9358 File Offset: 0x003E7558
		public static void ReadRelease_Map_PPtr_State_Array_PPtr_Transition(this AssetDictionary<PPtr_State, AssetList<PPtr_Transition>> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				PPtr_State pptr_State = new PPtr_State();
				pptr_State.ReadRelease(reader);
				AssetList<PPtr_Transition> assetList = new AssetList<PPtr_Transition>();
				assetList.ReadRelease_Array_Asset(reader);
				value.Add(pptr_State, assetList);
			}
		}

		// Token: 0x060188E4 RID: 100580 RVA: 0x003E93A0 File Offset: 0x003E75A0
		public static void ReadRelease_Map_PresetType_ArrayAlign_DefaultPreset_2019_3_0_a10(this AssetDictionary<PresetType, AssetList<DefaultPreset_2019_3_0_a10>> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				PresetType presetType = new PresetType();
				presetType.ReadRelease(reader);
				AssetList<DefaultPreset_2019_3_0_a10> assetList = new AssetList<DefaultPreset_2019_3_0_a10>();
				assetList.ReadRelease_ArrayAlign_Asset(reader);
				value.Add(presetType, assetList);
			}
		}

		// Token: 0x060188E5 RID: 100581 RVA: 0x003E93E8 File Offset: 0x003E75E8
		public static void ReadRelease_Map_PresetType_ArrayAlign_DefaultPreset_2020_1_0_a23(this AssetDictionary<PresetType, AssetList<DefaultPreset_2020_1_0_a23>> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				PresetType presetType = new PresetType();
				presetType.ReadRelease(reader);
				AssetList<DefaultPreset_2020_1_0_a23> assetList = new AssetList<DefaultPreset_2020_1_0_a23>();
				assetList.ReadRelease_ArrayAlign_Asset(reader);
				value.Add(presetType, assetList);
			}
		}

		// Token: 0x060188E6 RID: 100582 RVA: 0x003E9430 File Offset: 0x003E7630
		public static void ReadRelease_Map_UInt32_Utf8String(this AssetDictionary<uint, Utf8String> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				uint num2 = reader.ReadUInt32();
				Utf8String utf8String = new Utf8String();
				utf8String.ReadRelease(reader);
				value.Add(num2, utf8String);
			}
		}

		// Token: 0x060188E7 RID: 100583 RVA: 0x003E9474 File Offset: 0x003E7674
		public static void ReadRelease_Map_Utf8String_Array_Utf8String(this AssetDictionary<Utf8String, AssetList<Utf8String>> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				Utf8String utf8String = new Utf8String();
				utf8String.ReadRelease(reader);
				AssetList<Utf8String> assetList = new AssetList<Utf8String>();
				assetList.ReadRelease_Array_Asset(reader);
				value.Add(utf8String, assetList);
			}
		}

		// Token: 0x060188E8 RID: 100584 RVA: 0x003E94BC File Offset: 0x003E76BC
		public static void ReadRelease_Map_Utf8String_Int32(this AssetDictionary<Utf8String, int> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				Utf8String utf8String = new Utf8String();
				utf8String.ReadRelease(reader);
				int num2 = reader.ReadInt32();
				value.Add(utf8String, num2);
			}
		}

		// Token: 0x060188E9 RID: 100585 RVA: 0x003E9500 File Offset: 0x003E7700
		public static void ReadRelease_Map_Utf8String_Int64(this AssetDictionary<Utf8String, long> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				Utf8String utf8String = new Utf8String();
				utf8String.ReadRelease(reader);
				long num2 = reader.ReadInt64();
				value.Add(utf8String, num2);
			}
		}

		// Token: 0x060188EA RID: 100586 RVA: 0x003E9544 File Offset: 0x003E7744
		public static void ReadRelease_Map_Utf8String_Single(this AssetDictionary<Utf8String, float> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				Utf8String utf8String = new Utf8String();
				utf8String.ReadRelease(reader);
				float num2 = reader.ReadSingle();
				value.Add(utf8String, num2);
			}
		}

		// Token: 0x060188EB RID: 100587 RVA: 0x003E9588 File Offset: 0x003E7788
		public static void ReadRelease_MapAlign_Utf8String_Boolean(this AssetDictionary<Utf8String, bool> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				Utf8String utf8String = new Utf8String();
				utf8String.ReadRelease(reader);
				bool flag = reader.ReadBoolean();
				value.Add(utf8String, flag);
			}
			reader.AlignStream();
		}

		// Token: 0x060188EC RID: 100588 RVA: 0x003E95D0 File Offset: 0x003E77D0
		public static void ReadRelease_MapAlign_Utf8String_Int32(this AssetDictionary<Utf8String, int> value, AssetReader reader)
		{
			value.Clear();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				Utf8String utf8String = new Utf8String();
				utf8String.ReadRelease(reader);
				int num2 = reader.ReadInt32();
				value.Add(utf8String, num2);
			}
			reader.AlignStream();
		}

		// Token: 0x060188ED RID: 100589 RVA: 0x003E9618 File Offset: 0x003E7818
		public static void ReadRelease_Pair_GUID_Int32(this AssetPair<GUID, int> value, AssetReader reader)
		{
			value.Key.ReadRelease(reader);
			value.Value = reader.ReadInt32();
		}

		// Token: 0x060188EE RID: 100590 RVA: 0x003E9632 File Offset: 0x003E7832
		public static void ReadRelease_Pair_GUID_Int64(this AssetPair<GUID, long> value, AssetReader reader)
		{
			value.Key.ReadRelease(reader);
			value.Value = reader.ReadInt64();
		}

		// Token: 0x060188EF RID: 100591 RVA: 0x003E964C File Offset: 0x003E784C
		public static void ReadRelease_Pair_Int32_Int64(this AssetPair<int, long> value, AssetReader reader)
		{
			value.Key = reader.ReadInt32();
			value.Value = reader.ReadInt64();
		}

		// Token: 0x060188F0 RID: 100592 RVA: 0x003E9666 File Offset: 0x003E7866
		public static void ReadRelease_Pair_Int32_PPtr_Component_3_4_0(this AssetPair<int, PPtr_Component_3_4_0> value, AssetReader reader)
		{
			value.Key = reader.ReadInt32();
			value.Value.ReadRelease(reader);
		}

		// Token: 0x060188F1 RID: 100593 RVA: 0x003E9680 File Offset: 0x003E7880
		public static void ReadRelease_Pair_Int32_PPtr_Component_5_0_0(this AssetPair<int, PPtr_Component_5_0_0> value, AssetReader reader)
		{
			value.Key = reader.ReadInt32();
			value.Value.ReadRelease(reader);
		}

		// Token: 0x060188F2 RID: 100594 RVA: 0x003E969A File Offset: 0x003E789A
		public static void ReadRelease_Pair_Int32_Single(this AssetPair<int, float> value, AssetReader reader)
		{
			value.Key = reader.ReadInt32();
			value.Value = reader.ReadSingle();
		}

		// Token: 0x060188F3 RID: 100595 RVA: 0x003E96B4 File Offset: 0x003E78B4
		public static void ReadRelease_Pair_Int32_UInt32(this AssetPair<int, uint> value, AssetReader reader)
		{
			value.Key = reader.ReadInt32();
			value.Value = reader.ReadUInt32();
		}

		// Token: 0x060188F4 RID: 100596 RVA: 0x003E96CE File Offset: 0x003E78CE
		public static void ReadRelease_Pair_Pair_Int32_Int64_Utf8String(this AssetPair<AssetPair<int, long>, Utf8String> value, AssetReader reader)
		{
			value.Key.ReadRelease_Pair_Int32_Int64(reader);
			value.Value.ReadRelease(reader);
		}

		// Token: 0x060188F5 RID: 100597 RVA: 0x003E96E8 File Offset: 0x003E78E8
		public static void ReadRelease_Pair_PPtr_SphereCollider_PPtr_SphereCollider(this AssetPair<PPtr_SphereCollider, PPtr_SphereCollider> value, AssetReader reader)
		{
			value.Key.ReadRelease(reader);
			value.Value.ReadRelease(reader);
		}

		// Token: 0x060188F6 RID: 100598 RVA: 0x003E9702 File Offset: 0x003E7902
		public static void ReadRelease_Pair_UInt16_UInt16(this AssetPair<ushort, ushort> value, AssetReader reader)
		{
			value.Key = reader.ReadUInt16();
			value.Value = reader.ReadUInt16();
		}

		// Token: 0x060188F7 RID: 100599 RVA: 0x003E971C File Offset: 0x003E791C
		public static void ReadRelease_Pair_Utf8String_Boolean(this AssetPair<Utf8String, bool> value, AssetReader reader)
		{
			value.Key.ReadRelease(reader);
			value.Value = reader.ReadBoolean();
		}

		// Token: 0x060188F8 RID: 100600 RVA: 0x003E9736 File Offset: 0x003E7936
		public static void ReadRelease_Pair_Utf8String_PPtr_Object_3_4_0(this AssetPair<Utf8String, PPtr_Object_3_4_0> value, AssetReader reader)
		{
			value.Key.ReadRelease(reader);
			value.Value.ReadRelease(reader);
		}

		// Token: 0x060188F9 RID: 100601 RVA: 0x003E9750 File Offset: 0x003E7950
		public static void ReadRelease_Pair_Utf8String_PPtr_Object_5_0_0(this AssetPair<Utf8String, PPtr_Object_5_0_0> value, AssetReader reader)
		{
			value.Key.ReadRelease(reader);
			value.Value.ReadRelease(reader);
		}

		// Token: 0x060188FA RID: 100602 RVA: 0x003E976A File Offset: 0x003E796A
		public static void ReadRelease_Pair_Utf8String_PPtr_Texture_3_4_0(this AssetPair<Utf8String, PPtr_Texture_3_4_0> value, AssetReader reader)
		{
			value.Key.ReadRelease(reader);
			value.Value.ReadRelease(reader);
		}

		// Token: 0x060188FB RID: 100603 RVA: 0x003E9784 File Offset: 0x003E7984
		public static void ReadRelease_Pair_Utf8String_PPtr_Texture_5_0_0(this AssetPair<Utf8String, PPtr_Texture_5_0_0> value, AssetReader reader)
		{
			value.Key.ReadRelease(reader);
			value.Value.ReadRelease(reader);
		}

		// Token: 0x060188FC RID: 100604 RVA: 0x003E979E File Offset: 0x003E799E
		public static void ReadRelease_Pair_Utf8String_UInt32(this AssetPair<Utf8String, uint> value, AssetReader reader)
		{
			value.Key.ReadRelease(reader);
			value.Value = reader.ReadUInt32();
		}

		// Token: 0x060188FD RID: 100605 RVA: 0x003E97B8 File Offset: 0x003E79B8
		public static void ReadRelease_Pair_Utf8String_Utf8String(this AssetPair<Utf8String, Utf8String> value, AssetReader reader)
		{
			value.Key.ReadRelease(reader);
			value.Value.ReadRelease(reader);
		}

		// Token: 0x060188FE RID: 100606 RVA: 0x003E97D2 File Offset: 0x003E79D2
		public static sbyte ReadRelease_SByteAlign(this AssetReader reader)
		{
			sbyte b = reader.ReadSByte();
			reader.AlignStream();
			return b;
		}

		// Token: 0x060188FF RID: 100607 RVA: 0x003E97E0 File Offset: 0x003E79E0
		public static float ReadRelease_SingleAlign(this AssetReader reader)
		{
			float num = reader.ReadSingle();
			reader.AlignStream();
			return num;
		}

		// Token: 0x06018900 RID: 100608 RVA: 0x003E97F0 File Offset: 0x003E79F0
		public static byte[] ReadRelease_TypelessDataAlign(this AssetReader reader)
		{
			int num = reader.ReadInt32();
			byte[] array;
			if (num <= 1048576)
			{
				array = reader.ReadBytes(num);
				if (array.Length != num)
				{
					throw new EndOfStreamException();
				}
			}
			else
			{
				List<byte> list = new List<byte>(1024);
				for (int i = 0; i < num; i++)
				{
					list.Add(reader.ReadByte());
				}
				array = list.ToArray();
			}
			reader.AlignStream();
			return array;
		}

		// Token: 0x06018901 RID: 100609 RVA: 0x003E9851 File Offset: 0x003E7A51
		public static ushort ReadRelease_UInt16Align(this AssetReader reader)
		{
			ushort num = reader.ReadUInt16();
			reader.AlignStream();
			return num;
		}

		// Token: 0x06018902 RID: 100610 RVA: 0x003E985F File Offset: 0x003E7A5F
		public static uint ReadRelease_UInt32Align(this AssetReader reader)
		{
			uint num = reader.ReadUInt32();
			reader.AlignStream();
			return num;
		}
	}
}
