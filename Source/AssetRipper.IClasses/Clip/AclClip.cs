using AssetRipper.Assets.IO.Reading;
using AssetRipper.GameChoiceClass;

public class AclClip
{
	public byte[] ClipData { get; set; }
	public uint[] ClipDataUint { get; set; }

	public uint CurveCount { get; set; }
	public uint ConstCurveCount { get; set; }
	public void ReadRelease(AssetReader reader)
	{
		if (GameChoice.GetGame() == GameFlags.SR)
		{
			ClipDataUint = reader.ReadUInt32Array();
		}
		else
		{
			ClipData = reader.ReadByteArray();
			reader.AlignStream();
		}

		CurveCount = reader.ReadUInt32();

		if (GameChoice.GetGame() == GameFlags.SR)
		{
			ConstCurveCount = reader.ReadUInt32();
		}
	}

	public bool IsSet => ClipDataUint != null && ClipDataUint.Length > 0 || ClipData != null && ClipData.Length > 0;
}
