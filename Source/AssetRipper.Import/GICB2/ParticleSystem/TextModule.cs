using AssetRipper.Assets.IO.Reading;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Camera;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Object;
using AssetRipper.SourceGenerated.Subclasses.Vector2f;

namespace AssetRipper.Import.GICB2.ParticleSystem
{
	public sealed class TextModule
	{
		public void Read(AssetReader reader)
		{
			//base.Read(reader);
			Enabled = reader.ReadBoolean();
			reader.AlignStream();

			SceneCamera.Read(reader);
			Canvas.Read(reader);
			Font.Read(reader);
			FontSize = reader.ReadInt32();
			FontStyle = reader.ReadInt32();
			OutlineEnable = reader.ReadBoolean();
			reader.AlignStream();
			OutlineDistance.Read(reader);
			EmitWithWorldPosition = reader.ReadBoolean();
			reader.AlignStream();
		}


		public int FontSize { get; set; }
		public int FontStyle { get; set; }
		public bool OutlineEnable { get; set; }
		public bool EmitWithWorldPosition { get; set; }
		public bool Enabled { get; protected set; }

		public PPtr_Camera_5_0_0 SceneCamera = new();
		public PPtr_Object_5_0_0 Canvas = new();
		public PPtr_Object_5_0_0 Font = new();
		public Vector2f_3_5_0 OutlineDistance = new();
	}
}
