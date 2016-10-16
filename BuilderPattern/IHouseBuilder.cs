namespace BuilderPattern
{
    public interface IHouseBuilder
    {
        void BuildRoof();
        void BuildWall();

        void BuildFloor();

        House House { get; }
    }
}
