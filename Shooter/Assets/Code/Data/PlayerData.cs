using System;

namespace TAMKShooter.Data
{
	[Serializable]
	public class PlayerData
	{
		public enum PlayerId
		{
			None = 0,
			Player1 = 1,
			Player2 = 2,
			Player3 = 3,
			Player4 = 4
		}

		public PlayerId Id;
		public PlayerUnit.UnitType UnitType;
		// TODO: Controller type
		public int Lives;
	}
}
