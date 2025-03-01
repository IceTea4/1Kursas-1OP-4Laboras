using System;
using System.Text;

namespace Tech_shop_U4_22
{
	public static class InOut
	{
		public static List<Shops> ReadData(string file)
		{
			List<Shops> shops = new List<Shops>();
			string[] filePaths = Directory.GetFiles(file, "*.csv");

			foreach (string path in filePaths)
			{
				shops.Add(ReadDevices(path));
			}

			return shops;
		}

		private static Shops ReadDevices(string path)
		{
			using (StreamReader reader = new StreamReader(@path, Encoding.UTF8))
			{
				string line;
				string shopName = reader.ReadLine();
				string address = reader.ReadLine();
				string phone = reader.ReadLine();

				Shops shop = new Shops(shopName, address, phone);

				while ((line = reader.ReadLine()) != null)
				{
					switch (line[0])
					{
						case 'F':
							shop.AddDevice(new Fridge(line));
							break;
						case 'O':
							shop.AddDevice(new Oven(line));
							break;
						case 'K':
							shop.AddDevice(new Kettle(line));
							break;
					}
				}

				return shop;
			}
		}

		public static void PrintShops(string file, string header, List<Shops> shops)
		{
			using (StreamWriter writer = new StreamWriter(file, true))
			{
				writer.WriteLine(header);

				foreach (Shops shop in shops)
				{
					writer.WriteLine($"{shop.ShopName},{shop.Address},{shop.Phone}");

					foreach (Device device in shop.GetDevices())
					{
						writer.WriteLine(device.ToString());
					}

					writer.WriteLine();
				}
			}
		}

		public static void PrintColors(List<string> colors, string header)
		{
			Console.WriteLine(header);

			foreach (string color in colors)
			{
				Console.WriteLine(color);
			}

			Console.WriteLine();
		}

		public static void PrintSpecFriges(string file, string header, List<Fridge> fridges)
		{
			using (StreamWriter writer = new StreamWriter(file, true))
			{
				writer.WriteLine(header);

				foreach (Fridge fridge in fridges)
				{
					writer.WriteLine(fridge.ToString());
				}

				writer.WriteLine();
			}
		}

		public static void PrintExpensive(string file, string header, Shops shop)
		{
			using (StreamWriter writer = new StreamWriter(file, true))
			{
				writer.WriteLine(header);

                foreach (Device device in shop.GetDevices())
				{
					writer.WriteLine(device.ToString());
				}

				writer.WriteLine();
            }
        }
    }
}
