using System;

namespace Tech_shop_U4_22
{
	public class Fridge : Device
	{
		public decimal Space { get; set; }
		public string Design { get; set; }
		public bool Freezer { get; set; }
		public decimal Height { get; set; }
		public decimal Width { get; set; }
		public decimal Depth { get; set; }

		public Fridge(decimal space, string design, bool freezer, decimal height, decimal width, decimal depth, string creator, string model, string energyClass, string color, decimal price) : base(creator, model, energyClass, color, price)
		{
			Space = space;
			Design = design;
			Freezer = freezer;
			Height = height;
			Width = width;
			Depth = depth;
		}

		public Fridge(string data) : base(data)
		{
			SetData(data);
		}

		public override void SetData(string line)
		{
			base.SetData(line);
			string[] values = line.Split(',');
			Space = decimal.Parse(values[6]);
			Design = values[7];
			Freezer = bool.Parse(values[8]);
			Height = decimal.Parse(values[9]);
			Width = decimal.Parse(values[10]);
			Depth = decimal.Parse(values[11]);
		}

        public override string ToString()
        {
            return base.ToString() + String.Format($",{Space},{Design},{Freezer},{Height},{Width},{Depth}");
        }

        public override int CompareTo(Device obj)
        {
            return this.Height.CompareTo((obj as Fridge).Height);
        }

        public override bool Equals(Device other)
        {
            return base.Equals(other);
        }
    }
}
