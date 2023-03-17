namespace AssetRipper.GameChoiceClass
{
	[Flags]
	public enum GameFlags
	{
		ZZZ,
		SR,
		BH3,
		GI,
		GICB2
	}

	public static class GameChoice
	{
		public static void SetGame(int game)
		{
			game1 = (GameFlags)game;
		}

		public static GameFlags GetGame()
		{
			return game1;
		}

		private static GameFlags game1;
	}
}
