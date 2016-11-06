using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Validator pointvalidator = new PointValidator();
            while (true)
            {
                Console.WriteLine("What do you Want to Draw?" +
                                  " \n Type 1 for point " +
                                  "\n 2 for Striaght Line" +
                                  " \n 3 for Rectangle ");
                string choice = Console.ReadLine();
                DrawGeometricalShape(choice, pointvalidator);
            }
        }

        private static void DrawGeometricalShape(string choice, Validator pointvalidator)
        {
            switch (choice)
            {
                case "1":
                    string singlePoint = Console.ReadLine();
                    pointvalidator.Draw(singlePoint);
                    break;
                case "2":
                    Console.WriteLine("Enter Point # 1");
                    string p1 = Console.ReadLine();
                    Console.WriteLine("Enter Point # 2");
                    string p2 = Console.ReadLine();
                    new StraightLine(pointvalidator, p1, p2).Draw();
                    break;

                case "3":
                    Console.WriteLine("Enter Point # 1");
                    string rp1 = Console.ReadLine();
                    Console.WriteLine("Enter Point # 2");
                    string rp2 = Console.ReadLine();
                    Console.WriteLine("Enter Point # 3");
                    string rp3 = Console.ReadLine();
                    Console.WriteLine("Enter Point # 4");
                    string rp4 = Console.ReadLine();
                    new Rectangle(pointvalidator, rp1, rp2, rp3, rp4).Draw();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
