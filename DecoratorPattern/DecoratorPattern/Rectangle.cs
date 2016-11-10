using System;

namespace DecoratorPattern
{
    public class Rectangle : PointDecorator
    {
        /// <summary>
        /// The other 3 points of the rectangle except the starting point,the starting point is passed through the validate mehod
        /// </summary>
        private readonly string _point2;
        private readonly string _point3;
        private readonly string _point4;
        public Rectangle(Validator validator, string point2,
            string point3, string point4) : base(validator)
        {
            _point2 = point2;
            _point3 = point3;
            _point4 = point4;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="startingPoint">The starting Point of The Rectangle</param>
        /// <returns></returns>
        public override bool Validate(string startingPoint)
        {
            return base.Validate(startingPoint) && base.Validate(_point2)
                && base.Validate(_point3) && base.Validate(_point4);
        }

        public override void Draw(string startingPoint)
        {
            if (Validate(startingPoint))
            {
                Console.WriteLine("\n----Drawing Rectangle below : ");
                base.Draw(startingPoint);
                base.Draw(_point2);
                base.Draw(_point3);
                base.Draw(_point4);
                Console.WriteLine("Connecting Point {0} to Point {1}", startingPoint, _point2);
                Console.WriteLine("Connecting Point {0} to Point {1}", _point2, _point3);
                Console.WriteLine("Connecting Point {0} to Point {1}", _point3, _point4);
                Console.WriteLine("Connecting Point {0} to Point {1}", _point4, startingPoint);
                Console.WriteLine("-----Done Drawing Rectangle\n");
            }
            else
            {
                Console.WriteLine("Can not draw Rectangle. Invalid Points Entered");
            }
        }
    }
}
