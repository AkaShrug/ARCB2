using AssetRipper.Assets.Export;
using AssetRipper.Assets.Export.Yaml;
using AssetRipper.Assets.IO.Reading;
using AssetRipper.SourceGenerated.Helpers;
using AssetRipper.Yaml;

namespace AssetRipper.Import.GICB2.MeshCollider
{
	public class ColliderRangeInfoType : IAssetReadable, IYamlExportable
	{
		public void Read(AssetReader reader)
		{
			RangeEnd = reader.ReadInt32();
			WalkRunSurfaceType = reader.ReadInt32();
			ClimbSurfaceType = reader.ReadInt32();
			Tag = reader.ReadInt32();
		}

		public YamlNode ExportYaml(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 1);
			yamlMappingNode.Add(new YamlScalarNode("rangeEnd"), this.RangeEnd.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("walkRunSurfaceType"), this.WalkRunSurfaceType.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("climbSurfaceType"), this.ClimbSurfaceType.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("tag"), this.Tag.ExportYamlRelease_Int32(container));
			return yamlMappingNode;
		}

		public int RangeEnd { get; set; }
		public int WalkRunSurfaceType { get; set; }
		public int ClimbSurfaceType { get; set; }
		public int Tag { get; set; }
	}
}

