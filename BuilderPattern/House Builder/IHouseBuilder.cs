namespace BuilderPattern.House_Builder
{
    public interface IHouseBuilder
    {
        void BuildRoof();
        void BuildWall();

        void BuildFloor();

        House House { get; }
    }
}
