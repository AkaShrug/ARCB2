using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


public static class GenshinUtils
{
	public static HashSet<string> assetNameset = new HashSet<string>();
	public static Dictionary<uint, string> animPathHash = new Dictionary<uint, string>();
	public static ResourceIndex hashTable;
	public static void InitGenshinHashTable()
	{
		StreamReader sr = new StreamReader("index.json");
		string jsonWordTemplate = sr.ReadToEnd();
		hashTable = JsonConvert.DeserializeObject<ResourceIndex>(jsonWordTemplate);
	}
	public static void LoadGenshinAnimPathHash()
	{
		string[] lines = File.ReadAllLines("AllUnityStringHash.txt");

/*
		HashSet<string> uniqueLines = new HashSet<string>();
		string[] lines1 = File.ReadAllLines("D:\\Ruri\\Dev\\GitProject\\UnityToolkit\\Assets\\Genshit\\AnimationTest\\AllUnityString.txt");

		foreach (string line in lines1)
		{
			if (!uniqueLines.Contains(line))
			{
				uniqueLines.Add(line);
			}
		}

		File.WriteAllLines("D:\\Ruri\\Dev\\GitProject\\UnityToolkit\\Assets\\Genshit\\AnimationTest\\AllUnityString.txt", uniqueLines);*/
		foreach (string line in lines)
		{
			string[] fields = line.Split(new[] { "⇨" }, StringSplitOptions.None);
			uint hash = uint.Parse(fields[0]);
			string animPath = fields[1];
			if (!animPathHash.ContainsKey(hash))
			{
				animPathHash.Add(hash, animPath);
			}
			else
			{
				animPathHash[hash] += "或" + animPath;
			}
		}
	}
	public static string LoadGenshinHashTable(string key)
	{
		BundleInfo bundleInfo;
		foreach (var hash in hashTable.AssetLocationMap)
		{
			hash.TryGetValue(key, out bundleInfo);
			if (bundleInfo != null)
			{
				return bundleInfo.Path;
			}
		}
		return null;
	}
	public class ResourceIndex
	{
		public List<Dictionary<string, BundleInfo>> AssetLocationMap;
	}
	public class BundleInfo
	{
		public int Bundle;
		public string Path;
		public BundleInfo(int bundle, string path)
		{
			Bundle = bundle;
			Path = path;
		}
	}
}
