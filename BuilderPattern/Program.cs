using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseManufacturer houseManufacturer = new HouseManufacturer();
            IHouseBuilder builder;
            while (true)
            {
                Console.WriteLine("Which Type of House You want to build. Type glass / brick / wood");
                var input = Console.ReadLine();
                builder = GetHouseBuilder(input);
                if (builder != null)
                {
                    houseManufacturer.BuildHouse(builder);
                    Console.WriteLine(builder.House.ToString());
                }
                else
                {
                    Console.WriteLine("Invalid Choice entered. Please type glass/ brick / wood");
                }
            }
        }

        public static IHouseBuilder GetHouseBuilder(string inp)
        {
            switch (inp)
            {
                case "glass":
                    return new GlassHouseBuilder();
                case "brick":
                    return new BrickHouseBuilder();
                case "wood":
                    return new WoodenHouseBuilder();
                default:
                    return null;
            }
        }
    }
}
