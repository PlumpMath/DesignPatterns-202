using System;
using BuilderPattern.HouseEnums;

namespace BuilderPattern.House_Builder
{
    public class House
    {
        public string Name { get; set; }

        public RoofType Roof { get; set; }

        public WallType Wall { get; set; }

        public FloorType Floor { get; set; }



        public House(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return string.Format("House Name: {0} {1} {2}---- Roof Type: {3} {4} Wall Type: {5} {6}  Floor Type : {7}", Name,Environment.NewLine,"\t", Roof,
                "\t",Wall,"\t" ,Floor);
        }
    }
    
}
