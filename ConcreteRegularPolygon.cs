using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Library
{

     public class ConcreteRegularPolygon
    {
        public int NumberOfSide { get; set; }
        //public int SideLength { get; set; }

        private int sideLength;

        public int SideLength
        {
            get { return sideLength; }
            set { sideLength = value; }
        }

        public ConcreteRegularPolygon(int Side, int Length)
        {
            NumberOfSide = Side;
            SideLength = Length;
        }
        public double GetPerameter()
        {
            return NumberOfSide* SideLength;
        }
        public virtual double GetArea()
        {
            throw new NotImplementedException();

        }
    }
}
