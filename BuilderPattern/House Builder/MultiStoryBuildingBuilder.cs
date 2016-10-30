using System.IO.IsolatedStorage;
using BuilderPattern.HouseEnums;

namespace BuilderPattern.House_Builder
{
    public class MultiStoryBuildingBuilder : IStoriedBuildingBuilder
    {
        private readonly IBuildingBuilder _builder;

        public MultiStoryBuildingBuilder(IBuildingBuilder builder)
        {
            this._builder = builder;
        }

        public void BuildHouse(FloorType floorType,int numberOfFloors)
        {
            _builder.DrawFloors(floorType,numberOfFloors);
        }
    }
}