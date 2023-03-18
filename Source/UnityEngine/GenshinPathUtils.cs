using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace AssetRipper.Processing
{
	public static class GenshinPathUtils
	{
		public static ResourceIndex hashTable;
		public static void InitGenshinHashTable()
		{
			StreamReader sr = new StreamReader("index.json");
			string jsonWordTemplate = sr.ReadToEnd();
			hashTable = JsonConvert.DeserializeObject<ResourceIndex>(jsonWordTemplate);
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
}
