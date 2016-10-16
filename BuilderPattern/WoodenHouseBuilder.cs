using BuilderPattern.HouseEnums;

namespace BuilderPattern
{
    public class WoodenHouseBuilder : IHouseBuilder
    {
        private readonly House _house;
        public WoodenHouseBuilder()
        {
            _house = new House("Wooden House");
        }
        public void BuildRoof()
        {
            _house.Roof = RoofType.Tin;
        }

        public void BuildWall()
        {
            _house.Wall = WallType.Wood;
        }

        public void BuildFloor()
        {
            _house.Floor = FloorType.Wood;
        }

        public House House => _house;
    }
}
