using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoligonSquare
{
    public class Point
    {
        public Point()
        {
        }

        public Point(string x, string y)
        {
            X = Convert.ToInt32(x);
            Y = Convert.ToInt32(y);
        }

        public int X { get; set; }
        public int Y { get; set; }

    }
}
