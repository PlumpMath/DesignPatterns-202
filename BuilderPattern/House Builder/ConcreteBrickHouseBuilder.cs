using BuilderPattern.HouseEnums;

namespace BuilderPattern.House_Builder
{
    public class ConcreteBrickHouseBuilder: IBuildingBuilder
    {
        private readonly House _house;
        public ConcreteBrickHouseBuilder()
        {
            _house= new House("Brick House");
        }
        private void DrawWalls(Floor floor)
        {
           floor.Wall = WallType.Brick;
        }

        private void Drawdoors(Floor floor)
        {
           floor.Door = DoorType.Wooden;
        }

        private void DrawWindows(Floor floor)
        {
          floor.Window = WindowType.Wooden;
        }

        public void DrawFloors(FloorType floorType, int numOfFloors)
        {
            _house.FloorType = floorType;
            for (int i = 0; i < numOfFloors; i++)
            {
                var floor = new Floor {FloorNo = i+1};
                DrawRooms(floor);
                DrawWalls(floor);
                Drawdoors(floor);
                DrawWindows(floor);
               _house.Floors.Add(floor);
            }
        }

        private void DrawRooms(Floor floor)
        {
          floor.Room = RoomType.Brick;
        }

        public House House => _house;
    }
}
