using System;
using System.Text;

namespace Laboras4_Savar2
{
	public static class InOut
	{
		public static List<Team> ReadTeams(string file)
		{
			List<Team> teams = new List<Team>();

			using (StreamReader reader = new StreamReader(file, Encoding.UTF8))
			{
				string line;

				while ((line = reader.ReadLine()) != null)
				{
					string[] values = line.Split(',');

					Team team = new Team(values[0], values[1], values[2], int.Parse(values[3]), values[4]);

					teams.Add(team);
				}
			}

			return teams;
		}

		public static List<Player> ReadPlayers(string file)
		{
			List<Player> players = new List<Player>();

			using (StreamReader reader = new StreamReader(file, Encoding.UTF8))
			{
				string line;

				while ((line = reader.ReadLine()) != null)
				{
					string[] values = line.Split(',');

					switch (values[0])
					{
						case "S":
							players.Add(new Socer(line));
							break;
						case "B":
							players.Add(new Basketball(line));
							break;
					}
				}
			}

			return players;
		}

		public static void PrintTeams(List<Team> teams, string head)
		{
            Console.WriteLine(head);

			foreach(Team team in teams)
			{
				Console.WriteLine(team.ToString());
			}

			Console.WriteLine();
		}

		public static void PrintPlayers(List<Player> players)
		{
			foreach (Player player in players)
			{
				Console.WriteLine(player.ToString());
			}

			Console.WriteLine();
		}
	}
}

