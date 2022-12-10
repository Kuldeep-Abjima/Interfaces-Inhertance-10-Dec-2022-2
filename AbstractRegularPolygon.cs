using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Library
{
    public abstract class AbstractRegularPolygon
    {
        public int NumberOfSide {get; set; }
        public int SideLength { get; set; }

        public AbstractRegularPolygon(int side, int length)
        {
            NumberOfSide= side;
            SideLength= length;

        }
        public double GetPerameter()
        {
            return NumberOfSide * SideLength;
        }
        public abstract double GetArea();
    }
}
