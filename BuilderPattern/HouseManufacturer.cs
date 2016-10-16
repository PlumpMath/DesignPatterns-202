namespace BuilderPattern
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
