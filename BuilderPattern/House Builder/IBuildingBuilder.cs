using BuilderPattern.HouseEnums;

namespace BuilderPattern.House_Builder
{
    public interface IBuildingBuilder
    {
        void DrawFloors(FloorType floorType, int numOfFloors);

        House House { get; }
    }
}
