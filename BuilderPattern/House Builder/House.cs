using System.Collections.Generic;
using System.Text;
using BuilderPattern.HouseEnums;

namespace BuilderPattern.House_Builder
{
    public class House
    {
        public string Name { get; set; }
        public List<Floor> Floors { get; set; }
        public FloorType FloorType { get; set; }

        public int NumberOfFloors => Floors.Count;

        public bool HasGarden { get; set; }

        public House(string name)
        {
            Name = name;
            Floors = new List<Floor>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("House Name : {0} \n", Name));
            sb.Append(string.Format("House Type : {0} \n", FloorType));
            sb.Append(string.Format("House Has Garden: {0} \n", HasGarden));

            foreach (var floor in Floors)
            {
                sb.Append(string.Format("House Details at floor # {0} \n", floor.FloorNo));
                sb.Append(string.Format("\t wall Type: {0} \n", floor.Wall));
                sb.Append(string.Format("\t Door Type: {0} \n", floor.Door));
                sb.Append(string.Format("\t Room Type: {0} \n", floor.Room));
                sb.Append(string.Format("\t Window Type: {0} \n", floor.Window));
            }
            return sb.ToString();
        }
    }

}
