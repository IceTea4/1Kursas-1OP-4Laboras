using System;

namespace Laboras4_Savar2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = InOut.ReadTeams(@"../../../Teams.csv");
            List<Player> players = InOut.ReadPlayers(@"../../../Players.csv");

            InOut.PrintTeams(teams, "Pradiniai duomenys:");
            InOut.PrintPlayers(players);

            players = TaskUtils.SelectPlayers(players, teams);

            TaskUtils.AddPlayersToTeams(players, teams);

            InOut.PrintTeams(teams, "Rezultatai:");
        }
    }
}
