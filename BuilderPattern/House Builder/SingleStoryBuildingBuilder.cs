using BuilderPattern.HouseEnums;

namespace BuilderPattern.House_Builder
{
    public class SingleStoryBuildingBuilder : IStoriedBuildingBuilder
    {
        private readonly IBuildingBuilder _builder;

        public SingleStoryBuildingBuilder(IBuildingBuilder builder)
        {
            this._builder = builder;
        }

        public void BuildHouse(FloorType floorType, int numberOfFloors)
        {
            _builder.DrawFloors(floorType, numberOfFloors);
        }
    }
}