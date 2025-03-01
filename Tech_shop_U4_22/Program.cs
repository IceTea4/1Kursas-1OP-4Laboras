using System;

namespace Tech_shop_U4_22
{
    class Program
    {
        static void Main(string[] args)
        {
            const string res = "Rezultatai.csv";
            const string frigeRes = "Tilps.csv";
            const string expensive = "Brangus.csv";

            File.Delete(res);
            File.Delete(frigeRes);
            File.Delete(expensive);

            List<Shops> shops = InOut.ReadData(@"../../../Data");

            InOut.PrintShops(res, "Pradiniai duomenys:", shops);

            List<string> fridgeColors = TaskUtils.Colors(shops, "fridge");
            List<string> kettleColors = TaskUtils.Colors(shops, "kettle");

            InOut.PrintColors(fridgeColors, "Šaldytuvų spalvos:");
            InOut.PrintColors(kettleColors, "Virdulių spalvos:");

            Device cheapFridge = TaskUtils.SpecialCheapDevices(shops, "fridge");
            Device cheapOven = TaskUtils.SpecialCheapDevices(shops, "oven");
            Device cheapKettle = TaskUtils.SpecialCheapDevices(shops, "kettle");

            Console.WriteLine("Pigiausi įrenginiai:");
            Console.WriteLine(cheapFridge);
            Console.WriteLine(cheapOven);
            Console.WriteLine(cheapKettle);

            List<Fridge> specFriges = TaskUtils.FrigesCapacity(shops);

            InOut.PrintSpecFriges(frigeRes, "Šaldytuvai su nustatytu pločiu:", specFriges);

            List<Device> expensiveDevices = TaskUtils.ExpensiveDevices(shops);

            Shops shop = new Shops("", "", "");
            shop.AddDevices(expensiveDevices);

            InOut.PrintExpensive(expensive, "Brangūs prietaisai:", shop);
        }
    }
}
