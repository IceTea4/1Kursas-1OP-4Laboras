using System;

namespace Tech_shop_U4_22
{
	class Oven : Device
	{
		public int Power { get; set; }
		public int ProgramCount { get; set; }

		public Oven(int power, int programCount, string creator, string model, string energyClass, string color, decimal price) : base(creator, model, energyClass, color, price)
		{
			Power = power;
			ProgramCount = programCount;
		}

		public Oven(string data) : base(data)
		{
			SetData(data);
		}

        public override void SetData(string line)
        {
            base.SetData(line);
			string[] values = line.Split(',');
			Power = int.Parse(values[6]);
			ProgramCount = int.Parse(values[7]);
        }

        public override string ToString()
        {
			return base.ToString() + String.Format($",{Power},{ProgramCount}");
        }

        public override int CompareTo(Device obj)
        {
            return this.Power.CompareTo((obj as Oven).Power);
        }

        public override bool Equals(Device other)
        {
            return base.Equals(other);
        }
    }
}
