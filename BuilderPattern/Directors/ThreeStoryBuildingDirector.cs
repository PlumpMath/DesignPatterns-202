using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.HouseEnums;
using BuilderPattern.House_Builder;

namespace BuilderPattern.Directors
{
    public class ThreeStoryBuildingDirector: IBuildingDirector
    {
        public void Construct(IBuildingBuilder builder)
        {
            builder.DrawFloors(FloorType.ThreeStoried ,3);
        }
    }
}
