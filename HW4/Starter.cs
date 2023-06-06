namespace Modul2HW4
{
    public class Starter
    {
        public static void Run()
        {
            SafariPark safariPark = new SafariPark();
            Console.WriteLine("Before sorting :");
            safariPark.Section.PrintList();
            Array.Sort(safariPark.Section);
            Console.WriteLine("After sorting by name :");
            safariPark.Section.PrintList();
            Console.WriteLine("Search for animals from 10 to 100 kg :");
            safariPark.Section.FindByWeight(10, 100).PrintList();
            Array.Sort(safariPark.Section, new CompareAnimal());
            Console.WriteLine("After sorting by weight :");
            safariPark.Section.PrintList();
        }
    }
}