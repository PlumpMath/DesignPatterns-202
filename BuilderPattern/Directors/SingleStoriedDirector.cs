using BuilderPattern.HouseEnums;
using BuilderPattern.House_Builder;

namespace BuilderPattern.Directors
{
    public class SingleStoriedDirector: IBuildingDirector
    {
        public void Construct(IBuildingBuilder builder)
        {
            builder.DrawFloors(FloorType.SingleStoried, 1);
        }

        
    }
}
