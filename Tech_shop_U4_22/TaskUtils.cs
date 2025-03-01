using System;

namespace Tech_shop_U4_22
{
	public static class TaskUtils
	{
		public static List<string> Colors(List<Shops> shops, string product)
		{
			List<string> colors = new List<string>();

			foreach (Shops shop in shops)
			{
				foreach (Device device in shop.GetDevices())
				{
					if (device is Fridge && product == "fridge" && !HasColor(colors, device.Color))
					{
                        colors.Add(device.Color);
                    }
                    else if (device is Kettle && product == "kettle" && !HasColor(colors, device.Color))
					{
						colors.Add(device.Color);
					}
				}
			}

			return colors;
		}

		private static bool HasColor(List<string> colors, string newColor)
		{
			foreach (string color in colors)
			{
				if (color.Equals(newColor))
				{
					return true;
				}
			}

			return false;
		}

		public static Device SpecialCheapDevices(List<Shops> shops, string product)
		{
			List<Device> temp = SpesificDevices(shops);

			return CheapestDevice(temp, product);
		}

		private static List<Device> SpesificDevices(List<Shops> shops)
		{
			List<Device> result = new List<Device>();

			foreach (Shops shop in shops)
			{
                foreach (Device device in shop.GetDevices())
                {
                    if (device.EnergyClass.Equals("A+"))
                    {
                        result.Add(device);
                    }
                }
            }

			return result;
		}

		private static Device CheapestDevice(List<Device> devices, string product)
		{
			decimal price = -1;
			Device res = null;

			foreach (Device device in devices)
			{
				if (device.Price < price || price == -1)
				{
                    if (device is Fridge && product == "fridge")
                    {
                        price = device.Price;
						res = device;
                    }
                    else if (device is Oven && product == "oven")
                    {
                        price = device.Price;
                        res = device;
                    }
                    else if (device is Kettle && product == "kettle")
                    {
                        price = device.Price;
                        res = device;
                    }
                }
			}

			return res;
		}

		public static List<Fridge> FrigesCapacity(List<Shops> shops)
		{
			List<Fridge> fridges = new List<Fridge>();

			foreach (Shops shop in shops)
			{
				foreach (Device device in shop.GetDevices())
				{
					if (device is Fridge fridge)
					{
						if (fridge.Width >= 52 && fridge.Width <= 56)
						{
							fridges.Add(fridge);
						}
					}
				}
			}

			return fridges;
		}

		public static List<Device> ExpensiveDevices(List<Shops> shops)
		{
			List<Device> devices = new List<Device>();

			foreach (Shops shop in shops)
			{
				foreach (Device device in shop.GetDevices())
				{
					if (device is Fridge && device.Price > 1000)
					{
						devices.Add(device);
					}
					else if (device is Oven && device.Price > 500)
					{
						devices.Add(device);
					}
					else if (device is Kettle && device.Price > 50)
					{
						devices.Add(device);
					}
				}
			}

			return devices;
		}
	}
}

