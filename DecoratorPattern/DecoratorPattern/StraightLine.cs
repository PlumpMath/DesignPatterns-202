using System;

namespace DecoratorPattern
{
    public class StraightLine : PointDecorator
    {
        private readonly string _point1;
        private readonly string _point2;

        public StraightLine(Validator validator,string p1,string p2) : base(validator)
        {
            _point1 = p1;
            _point2 = p2;
        }

        public bool Validate()
        {
            return base.Validate(_point1) && base.Validate(_point2);
        }

        public void Draw()
        {
            if (Validate())
            {
                Console.WriteLine("\n------Drawing Line below : ");
                base.Draw(_point1);
                base.Draw(_point2);
                Console.WriteLine("Connecting point {0} to point {1}",_point1,_point2);
                Console.WriteLine("---Done drawing Straight Line\n");
            }
            else
            {
                Console.WriteLine("Can not draw Lines. Invalid Points Entered");
            }
        }
    }
}
