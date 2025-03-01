using System;

namespace Tech_shop_U4_22
{
	class Kettle : Device
	{
		public int Strength { get; set; }
		public decimal Capacity { get; set; }

		public Kettle(int strength, decimal capacity, string creator, string model, string energyClass, string color, decimal price) : base(creator, model, energyClass, color, price)
		{
			Strength = strength;
			Capacity = capacity;
		}

		public Kettle(string data) : base(data)
		{
			SetData(data);
		}

        public override void SetData(string line)
        {
            base.SetData(line);
			string[] values = line.Split(',');
			Strength = int.Parse(values[6]);
			Capacity = decimal.Parse(values[7]);
        }

        public override string ToString()
        {
            return base.ToString() + String.Format($",{Strength},{Capacity}");
        }

        public override int CompareTo(Device obj)
        {
            return this.Strength.CompareTo((obj as Kettle).Strength);
        }

        public override bool Equals(Device other)
        {
            return base.Equals(other);
        }
    }
}
