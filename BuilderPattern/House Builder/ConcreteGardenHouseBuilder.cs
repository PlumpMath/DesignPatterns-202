using BuilderPattern.HouseEnums;

namespace BuilderPattern.House_Builder
{
    public class ConcreteGardenHouseBuilder : IBuildingBuilder
    {
        private readonly House _house;
        public ConcreteGardenHouseBuilder()
        {
            _house = new House("Garden House") { HasGarden = true };
        }
        private void DrawWalls(Floor floor)
        {
            floor.Wall = WallType.Wood;
        }

        public void Drawdoors(Floor floor)
        {
            floor.Door = DoorType.Wooden;
        }

        private void DrawWindows(Floor floor)
        {
            floor.Window = WindowType.Glass;
        }

        public void DrawFloors(FloorType floorType, int numOfFloors)
        {
            _house.FloorType = floorType;
            for (int i = 0; i < numOfFloors; i++)
            {
                var floor = new Floor { FloorNo = i + 1 };
                DrawRooms(floor);
                DrawWalls(floor);
                Drawdoors(floor);
                DrawWindows(floor);
                _house.Floors.Add(floor);
            }

        }

        public void DrawRooms(Floor floor)
        {
            floor.Room = RoomType.Wood;
        }

        public House House => _house;
    }
}
