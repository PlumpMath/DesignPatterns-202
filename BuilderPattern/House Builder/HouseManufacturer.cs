namespace BuilderPattern.House_Builder
{
    public class HouseManufacturer
    {
        public void BuildHouse(IHouseBuilder houseBuilder)
        {
            houseBuilder.BuildRoof();
            houseBuilder.BuildWall();
            houseBuilder.BuildFloor();
        }
    }
}
