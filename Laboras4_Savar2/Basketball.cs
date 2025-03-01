using System;

namespace Laboras4_Savar2
{
	class Basketball : Player
	{
		public int StolenBalls { get; set; }
		public int Assists { get; set; }

		public Basketball(string teamName, string surname, string name, int score, int played, int stolenBalls, int assists) : base(teamName, surname, name, score, played)
		{
			StolenBalls = stolenBalls;
			Assists = assists;
		}

        public Basketball(string data) : base(data)
        {
            SetData(data);
        }

        public override void SetData(string line)
        {
            base.SetData(line);

            string[] values = line.Split(',');
            StolenBalls = int.Parse(values[6]);
            Assists = int.Parse(values[7]);
        }

        public override string ToString()
        {
            return base.ToString() + String.Format($",{StolenBalls},{Assists}");
        }
    }
}
