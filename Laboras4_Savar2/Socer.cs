using System;

namespace Laboras4_Savar2
{
	class Socer : Player
	{
		public int YellowCards { get; set; }

		public Socer(string teamName, string surname, string name, int score, int played, int yellowCards) : base(teamName, surname, name, score, played)
		{
			YellowCards = yellowCards;
		}

		public Socer(string data) : base(data)
		{
			SetData(data);
		}

        public override void SetData(string line)
        {
            base.SetData(line);

			string[] values = line.Split(',');
			YellowCards = int.Parse(values[6]);
        }

        public override string ToString()
        {
            return base.ToString() + String.Format($",{YellowCards}");
        }
    }
}
