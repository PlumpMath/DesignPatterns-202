using System;

namespace DecoratorPattern
{
    public class StraightLine : PointDecorator
    {
        private readonly string _secondPoint;

        public StraightLine(Validator validator,string secondPoint) : base(validator)
        {
            _secondPoint = secondPoint;
        }

        public override bool Validate(string firstPoint)
        {
            return base.Validate(firstPoint) && base.Validate(_secondPoint);
        }

        public override void Draw(string firstPoint)
        {
            if (Validate(firstPoint))
            {
                Console.WriteLine("\n------Drawing Line below : ");
                base.Draw(firstPoint);
                base.Draw(_secondPoint);
                Console.WriteLine("Connecting point {0} to point {1}", firstPoint, _secondPoint);
                Console.WriteLine("---Done drawing Straight Line\n");
            }
            else
            {
                Console.WriteLine("Can not draw Lines. Invalid Points Entered");
            }
        }
    }
}
