using System;

namespace Laboras4_Savar2
{
	public class Team
	{
		public string TeamName { get; }
		public string Town { get; }
		public string Coach { get; }
		public int PlayedGames { get; }
		public string Sport { get; }
		private List<Player> players;

        public Team(string teamName, string town, string coach, int playedGames, string sport)
		{
			TeamName = teamName;
			Town = town;
			Coach = coach;
			PlayedGames = playedGames;
			Sport = sport;
			players = new List<Player>();
		}

		public void AddPlayer(Player player)
		{
			players.Add(player);
		}

		public List<Player> GetPlayers()
		{
			return players;
		}

        public override string ToString()
        {
			string line;

			line = String.Format($"{TeamName},{Town},{Coach},{PlayedGames},{Sport}");

			if (players.Count > 0)
			{
                foreach (Player player in players)
                {
                    line += "\r\n" + "  " + player.ToString();
                }
            }

			return line;
        }
    }
}
