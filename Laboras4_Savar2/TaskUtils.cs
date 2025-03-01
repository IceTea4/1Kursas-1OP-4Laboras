using System;

namespace Laboras4_Savar2
{
	public static class TaskUtils
	{
		public static void AddPlayersToTeams(List<Player> players, List<Team> teams)
		{
			foreach (Team team in teams)
			{
				foreach (Player player in players)
				{
					if (team.TeamName.Equals(player.TeamName))
					{
                        if (team.Sport == "Basketball" && player is Basketball)
                        {
                            team.AddPlayer(player);
                        }
                        else if (team.Sport == "Socer" && player is Socer)
                        {
                            team.AddPlayer(player);
                        }
					}
				}
			}
		}

		public static List<Player> SelectPlayers(List<Player> players, List<Team> teams)
		{
			List<Player> res = new List<Player>();

			foreach (Team team in teams)
			{
				foreach(Player player in Selecting(team, players))
				{
					res.Add(player);
				}
            }
			
			return res;
		}

		private static List<Player> Selecting(Team team, List<Player> players)
		{
            List<Player> res = new List<Player>();

            foreach (Player player in players)
            {
                if (player.Played == team.PlayedGames)
                {
                    if (player is Basketball baller)
                    {
                        if (baller.StolenBalls >= StolenBallsAverage(players) && player.Score >= AverageBaller(players))
                        {
                            res.Add(player);
                        }
                    }
                    else if (player is Socer socer)
                    {
                        if (socer.YellowCards >= YellowCardsAverage(players) && player.Score >= AverageSocer(players))
                        {
                            res.Add(player);
                        }
                    }
                }
            }

			return res;
        }

		private static double AverageBaller(List<Player> players)
		{
			int sum = 0;
			int count = 0;

			foreach (Player player in players)
			{
				if (player is Basketball baller)
				{
                    sum += player.Score;
					count++;
                }
            }

			return (double)sum / count;
		}

		private static double StolenBallsAverage(List<Player> players)
		{
			int sum = 0;
			int count = 0;

			foreach (Player player in players)
			{
				if (player is Basketball baller)
				{
					sum += baller.StolenBalls;
					count++;
				}
			}

			return (double)sum / count;
		}

        private static double AverageSocer(List<Player> players)
        {
            int sum = 0;
			int count = 0;

            foreach (Player player in players)
            {
                if (player is Socer socer)
                {
                    sum += player.Score;
					count++;
                }
            }

            return (double)sum / count;
        }

        private static double YellowCardsAverage(List<Player> players)
		{
			int sum = 0;
			int count = 0;

			foreach (Player player in players)
			{
				if (player is Socer socer)
				{
					sum += socer.YellowCards;
					count++;
				}
			}

			return (double)sum / count;
		}
	}
}

