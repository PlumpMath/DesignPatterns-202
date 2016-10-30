using BuilderPattern.HouseEnums;

namespace BuilderPattern.House_Builder
{
    public interface IStoriedBuildingBuilder
    {
        void BuildHouse(FloorType floorType, int numberOfFloors);
    }
}
