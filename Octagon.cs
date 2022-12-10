using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Library
{
    class Octagon : Object, IRegularPolygon
    {
        public int NumberOfSide { get; set; }
        public int SideLength { get; set; }


        public Octagon(int Lenght){
            SideLength = Lenght;
            NumberOfSide = 8;
        }
        
        public double GetPerameter()
        {
            return SideLength * SideLength*(2+2* Math.Sqrt(2));

        }
        public double GetArea()
        {
            return NumberOfSide * SideLength;
        }
    }
}
