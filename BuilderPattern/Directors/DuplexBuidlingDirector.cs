using BuilderPattern.HouseEnums;
using BuilderPattern.House_Builder;

namespace BuilderPattern.Directors
{
    public class DuplexBuidlingDirector: IBuildingDirector
    {
        public void Construct(IBuildingBuilder builder)
        {
            builder.DrawFloors(FloorType.Duplex,2);
        }
    }
}
