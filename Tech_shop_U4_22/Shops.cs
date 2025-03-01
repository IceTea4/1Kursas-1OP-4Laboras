using System;

namespace Tech_shop_U4_22
{
	public class Shops
	{
		private List<Device> devices;
		public string ShopName { get; private set; }
		public string Address { get; set; }
		public string Phone { get; set; }
		
		public Shops(string shopName, string address, string phone)
		{
			ShopName = shopName;
			Address = address;
			Phone = phone;
			devices = new List<Device>();
		}

		public void AddDevice(Device device)
		{
			devices.Add(device);
		}

        public void AddDevices(List<Device> data)
        {
			foreach(Device device in data)
			{
                devices.Add(device);
            }
        }

        public int Count()
		{
			return devices.Count;
		}

		public List<Device> GetDevices()
		{
			return devices;
		}

        public void Sort()
        {
            bool flag = true;

            while (flag)
            {
                flag = false;

                for (int i = 0; i < devices.Count - 1; i++)
				{
					Device one = devices[i];
					Device two = devices[i + 1];

					if (one.CompareTo(two) > 0)
					{
						devices[i] = two;
						devices[i + 1] = one;
						flag = true;
					}
				}
            }
        }
    }
}

