using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Library
{
     public interface IRegularPolygon
    {
        int NumberOfSide { get; set; }
        int SideLength { get; set; }

        double GetPerameter();
        double GetArea();
    }
}
