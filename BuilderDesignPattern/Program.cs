using BuilderDesignPattern.Builder;
using BuilderDesignPattern.Director;
using System;

namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseCreator HouseCreator1 = new HouseCreator(new DreamBuilders());
            HouseCreator1.CreateHouse();

            var DreamHouse = HouseCreator1.GetHouse();
            DreamHouse.ShowData();

            Console.WriteLine("");
            Console.WriteLine("");

            HouseCreator HouseCreator2 = new HouseCreator(new CountryHomeBuilders());
            HouseCreator2.CreateHouse();

            var CountryHome = HouseCreator2.GetHouse();
            CountryHome.ShowData();

            Console.ReadKey();
        }
    }
}
