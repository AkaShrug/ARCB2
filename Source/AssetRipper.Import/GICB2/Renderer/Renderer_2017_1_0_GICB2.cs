using AssetRipper.Assets.IO.Reading;
using AssetRipper.SourceGenerated.Classes.ClassID_25;
using AssetRipper.SourceGenerated.Helpers;

namespace AssetRipper.Import.GICB2.Renderer
{
	public class Renderer_2017_1_0_GICB2 : Renderer_2017_1_0
	{
		public void ReadRelease(AssetReader reader)
		{
			this.m_GameObject.ReadRelease(reader);
			this.m_CastShadows = reader.ReadByte();
			this.m_ReceiveShadows = reader.ReadByte();

			// GICB2
			this.ReceiveDecals = reader.ReadByte();
			this.EnableShadowCulling = reader.ReadByte();
			this.EnableGpuQuery = reader.ReadByte();
			this.AllowHalfResolution = reader.ReadByte();
			this.IsRainOccluder = reader.ReadByte();
			this.IsDynamic = reader.ReadByte();

			this.m_MotionVectors = reader.ReadByte();
			this.m_LightProbeUsage = reader.ReadByte();
			this.m_ReflectionProbeUsage = reader.ReadRelease_ByteAlign();
			this.m_LightmapIndex = reader.ReadUInt16();
			this.m_LightmapIndexDynamic = reader.ReadUInt16();
			this.m_LightmapTilingOffset.ReadRelease(reader);
			this.m_LightmapTilingOffsetDynamic.ReadRelease(reader);

			// GICB2
			this.ViewDistanceRatio = reader.ReadSingle();
			this.ShaderLODDistanceRatio = reader.ReadSingle();

			this.m_Materials.ReadRelease_ArrayAlign_Asset(reader);
			this.m_StaticBatchInfo.ReadRelease(reader);
			this.m_StaticBatchRoot.ReadRelease(reader);

			this.MatLayers = reader.ReadInt32(); // GICB2

			this.m_ProbeAnchor.ReadRelease(reader);
			this.m_LightProbeVolumeOverride.ReadRelease_AssetAlign(reader);
			this.m_SortingLayerID = reader.ReadInt32();
			this.m_SortingLayer = reader.ReadInt16();
			this.m_SortingOrder = reader.ReadRelease_Int16Align();

			this.UseHighestMip = reader.ReadRelease_BooleanAlign(); // GICB2
		}

		public byte ReceiveDecals { get; set; }
		public byte EnableShadowCulling { get; set; }
		public byte EnableGpuQuery { get; set; }
		public byte AllowHalfResolution { get; set; }
		public byte IsRainOccluder { get; set; }
		public byte IsDynamic { get; set; }
		public float ViewDistanceRatio { get; set; }
		public float ShaderLODDistanceRatio { get; set; }
		public int MatLayers { get; set; }
		public bool UseHighestMip { get; set; }
	}
}
