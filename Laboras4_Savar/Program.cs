using System.Text;

namespace Laboras4_Savar
{
    class Program
    {
        public const int MaxNumberOfBranches = 10;
        public const int MaxNumberOfAnimals = 50;
        public const int MaxNumberOfBreeds = 50;

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Branch[] branches = new Branch[MaxNumberOfBranches];

            int NumberOfBranches = 0;
            const string DataDir = @"../../../Data";

            InOut.ReadData(DataDir, branches, ref NumberOfBranches);

            InOut.PrintDataToConsole(branches, NumberOfBranches);

            Console.WriteLine();

            Console.WriteLine("Registruoti šunys surikiuoti:");
            Branch KaunoSunys = TaskUtils.GetAnimals(branches[1], branches[1].Town, typeof(Dog));

            KaunoSunys.SortAnimals();

            InOut.PrintAnimalsToConsole(KaunoSunys, branches[1].Town);

            Console.WriteLine();

            Console.WriteLine("Registruotos katės surikiuotos:");
            Branch KaunoKates = TaskUtils.GetAnimals(branches[1], branches[1].Town, typeof(Cat));

            KaunoKates.SortAnimals();

            InOut.PrintAnimalsToConsole(KaunoKates, branches[1].Town);

            Console.WriteLine();

            Console.WriteLine("Agresyvūs šunys\n {0}: {1}", branches[1].Town, TaskUtils.CountAggressive(branches[1]));

            Console.WriteLine("Agresyvūs šunys\n {0}: {1}", branches[0].Town, TaskUtils.CountAggressive(branches[0]));

            Console.WriteLine("Populiariausia šunų veislė\n {0}: {1}", branches[1].Town, TaskUtils.GetMostPopularBreed(TaskUtils.GetAnimals(branches[1], "Filialas: {0} Gyvūnas: šuo", typeof(Dog))));
           
            Console.WriteLine("Populiariausia kačių veislė\n {0}: {1}", branches[0].Town, TaskUtils.GetMostPopularBreed(TaskUtils.GetAnimals(branches[0], "Filialas: {0} Gyvūnas: katė", typeof(Cat))));
           
            Console.WriteLine();

            Console.WriteLine("Pagal lusto Nr. surūšiuotas visų filialų šunų sąrašas:");
            Branch allDogs = new Branch("Visi šunys");
            Branch allCats = new Branch("Visos katės");
            Branch allGuineaPigs = new Branch("Visos jūrų kiaulytės");

            TaskUtils.GetAllDogs(branches, NumberOfBranches, ref allDogs, "Filialas: {0} Gyvūnas: šuo");
            TaskUtils.GetAllCats(branches, NumberOfBranches, ref allCats, "Filialas: {0} Gyvūnas: katė");
            TaskUtils.GetAllGuineaPigs(branches, NumberOfBranches, ref allGuineaPigs, "Filialas: {0} Gyvūnas: jūrų kiaulytė");

            allDogs.SortAnimals();
            allCats.SortAnimals();
            allGuineaPigs.SortAnimals();

            InOut.PrintAnimalsToConsole(allDogs, allDogs.Town);

            Console.WriteLine();
            Console.WriteLine("Savarankiškos užduoties rezultatai:");
            InOut.PrintAnimalsToConsole(allDogs, allDogs.Town);
            InOut.PrintAnimalsToConsole(allCats, allCats.Town);
            InOut.PrintAnimalsToConsole(allGuineaPigs, allGuineaPigs.Town);
        }
    }
}
