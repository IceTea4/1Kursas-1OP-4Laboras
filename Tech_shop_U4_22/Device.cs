using System;

namespace Tech_shop_U4_22
{
	public abstract class Device : IComparable<Device>, IEquatable<Device>
	{
		public string Creator { get; set; }
		public string Model { get; set; }
		public string EnergyClass { get; set; }
		public string Color { get; set; }
		public decimal Price { get; set; }

		public Device(string creator, string model, string energyClass, string color, decimal price)
		{
			Creator = creator;
			Model = model;
			EnergyClass = energyClass;
			Color = color;
			Price = price;
		}

		public Device(string data)
		{
			SetData(data);
		}

		public virtual void SetData(string line)
		{
			string[] values = line.Split(',');
			Creator = values[1];
			Model = values[2];
			EnergyClass = values[3];
			Color = values[4];
			Price = decimal.Parse(values[5]);
		}

        public override string ToString()
        {
            return String.Format($"{Creator},{Model},{EnergyClass},{Color},{Price}");
        }

        public virtual int CompareTo(Device other)
        {
            if (other is Fridge)
            {
                return 1;
            }
            else if (other is Oven)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public virtual bool Equals(Device other)
        {
			return this.Color.Equals(other.Color);
        }
    }
}
