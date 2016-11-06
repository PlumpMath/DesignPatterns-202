using System;

namespace DecoratorPattern
{
    public class Rectangle : PointDecorator
    {
        private readonly string _point1;
        private readonly string _point2;
        private readonly string _point3;
        private readonly string _point4;
        public Rectangle(Validator validator, string point1, string point2,
            string point3, string point4) : base(validator)
        {
            _point1 = point1;
            _point2 = point2;
            _point3 = point3;
            _point4 = point4;
        }

        public bool Validate()
        {
            return base.Validate(_point1) && base.Validate(_point2)
                && base.Validate(_point3) && base.Validate(_point4);
        }

        public void Draw()
        {
            if (Validate())
            {
                Console.WriteLine("\n----Drawing Rectangle below : ");
                base.Draw(_point1);
                base.Draw(_point2);
                base.Draw(_point3);
                base.Draw(_point4);
                Console.WriteLine("Connecting Point {0} to Point {1}", _point1,_point2);
                Console.WriteLine("Connecting Point {0} to Point {1}", _point2, _point3);
                Console.WriteLine("Connecting Point {0} to Point {1}", _point3, _point4);
                Console.WriteLine("Connecting Point {0} to Point {1}", _point4, _point1);
                Console.WriteLine("-----Done Drawing Rectangle\n");
            }
            else
            {
                Console.WriteLine("Can not draw Rectangle. Invalid Points Entered");
            }
        }
    }
}
