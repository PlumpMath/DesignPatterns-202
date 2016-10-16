using BuilderPattern.HouseEnums;

namespace BuilderPattern
{
    public class BirckHouseBuilder : IHouseBuilder
    {
        private House _house;
        public BirckHouseBuilder()
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
