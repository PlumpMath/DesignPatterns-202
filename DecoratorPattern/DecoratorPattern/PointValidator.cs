using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class PointValidator : Validator
    {
        public override bool Validate(string value)
        {
            return new Regex(@"^\d{1,16}(\.\d{1,6})?$").IsMatch(value);
        }

        public override void Draw(string value)
        {
            if (Validate(value))
            {
                Console.WriteLine("Drawing point: {0}", value);
            }
            else
            {
                Console.WriteLine("Unable to draw Points. Invalid Point Entered");
            }
        }
    }
}
