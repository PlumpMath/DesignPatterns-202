using BuilderPattern.HouseEnums;

namespace BuilderPattern.House_Builder
{
    public class Floor
    {
        public int FloorNo { get; set; }

        public RoofType Roof { get; set; }

        public WallType Wall { get; set; }

        public DoorType Door { get; set; }

        public WindowType Window { get; set; }
        public RoomType Room { get; set; }


    }
}
