using BuilderPattern.HouseEnums;

namespace BuilderPattern.House_Builder
{
    public class GlassHouseBuilder : IHouseBuilder
    {
        private House _house;

        public GlassHouseBuilder()
        {
            _house = new House("Glass House");
        }
        public void BuildRoof()
        {
            _house.Roof = RoofType.Glass;
        }

        public void BuildWall()
        {
            _house.Wall = WallType.Glass;
        }

        public void BuildFloor()
        {
            _house.Floor = FloorType.Tiles;
        }

        public House House => _house;
    }
}
