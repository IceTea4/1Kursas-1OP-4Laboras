using System;

namespace Laboras4_Savar2
{
	public class Player
	{
		public string TeamName { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
		public int Played { get; set; }
        public int Score { get; set; }

        public Player(string teamName, string surname, string name, int score, int played)
		{
			TeamName = teamName;
			Surname = surname;
			Name = name;
			Score = score;
			Played = played;
		}

		public Player(string data)
		{
			SetData(data);
		}

		public virtual void SetData(string line)
		{
			string[] values = line.Split(',');
			TeamName = values[1];
			Surname = values[2];
			Name = values[3];
			Played = int.Parse(values[4]);
			Score = int.Parse(values[5]);
		}

        public override string ToString()
        {
			return String.Format($"{Surname},{Name},{Played},{Score}");
        }
    }
}
