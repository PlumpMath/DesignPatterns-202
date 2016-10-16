using BuilderPattern.HouseEnums;

namespace BuilderPattern.House_Builder
{
    public class BrickHouseBuilder : IHouseBuilder
    {
        private House _house;
        public BrickHouseBuilder()
        {
            _house = new House("Brick Made House");

        }

        public void BuildRoof()
        {
            _house.Roof = RoofType.Brick;
        }

        public void BuildWall()
        {
            _house.Wall = WallType.Brick;
        }

        public void BuildFloor()
        {
            _house.Floor = FloorType.Mosaic;
        }

        public House House => _house;
    }
}
