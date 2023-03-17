using AssetRipper.Assets.IO.Reading;
using AssetRipper.SourceGenerated.Subclasses.MinMaxGradient;

namespace AssetRipper.Import.GICB2.ParticleSystem
{
	public sealed class ColorOverDayModule
	{
		public void Read(AssetReader reader)
		{
			//base.Read(reader);
			Enabled = reader.ReadBoolean();
			reader.AlignStream();

			Gradient.Read(reader);
		}

		public bool Enabled { get; protected set; }

		public MinMaxGradient_2017_1_0 Gradient = new();
	}
}
