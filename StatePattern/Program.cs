using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatePattern.WizardControl;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var wizard = new Wizard();

            while (true)
            {
                Console.WriteLine("Type prev to go to previous step or type next to go to next step");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "next":
                        wizard.GoNext();
                        break;
                    case "prev":
                        wizard.GoPrevious();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice Entered.Type prev to go to previous step or type next to go to next step");
                        break;
                }
            }
        }
    }
}
