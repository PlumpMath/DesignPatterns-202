using System;
using BuilderPattern.Directors;
using BuilderPattern.House_Builder;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IBuildingDirector buildingDirector;
            IBuildingBuilder builder;
            while (true)
            {
                Console.WriteLine("How many floor do you want to build? Type 1 for Single_Storied , 2 for Duplex, 3 for ThreeStoried Storied.");
                var floors = Console.ReadLine();
                buildingDirector = GetBuidlingDirector(floors);
                Console.WriteLine("What type of House you want to Build? type brick / garden/ glass.");
                var buildingType = Console.ReadLine();
                builder = GetHouseBuilder(buildingType);
                if (builder != null && buildingDirector != null)
                {
                    buildingDirector.Construct(builder);
                    Console.WriteLine(builder.House.ToString());
                }
                else
                {
                    Console.WriteLine("Invalid Choice entered. Please type glass/ brick / wood");
                }
            }
        }

        public static IBuildingBuilder GetHouseBuilder(string inp)
        {
            switch (inp)
            {
                case "glass":
                    return new ConcreteGlassHouseBuilder();
                case "brick":
                    return new ConcreteBrickHouseBuilder();
                case "garden":
                    return new ConcreteGardenHouseBuilder();
                default:
                    return null;
            }
        }

        public static IBuildingDirector GetBuidlingDirector(string input)
        {
            switch (input)
            {
                case "1":
                    return new SingleStoriedDirector();
                case "2":
                    return new DuplexBuidlingDirector();
                case "3":
                    return new ThreeStoryBuildingDirector();
                default:
                    return null;
            }
        }
    }
}
