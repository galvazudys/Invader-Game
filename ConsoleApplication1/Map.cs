using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Map
    {
        public readonly int Width; //class fields
        public readonly int Height;

        public Map(int width, int height) // constructop
        {
            Width = width;
            Height = height;
        }

        public bool OnMap(Point point)
        {
            //we have this option to do or easier option that fallo
            //  bool inBounds = point.X >= 0 && point.X < Width && point.Y >= 0 && point.Y < Height;
            //  return inBounds;
            return point.X >= 0 && point.X < Width &&
                   point.Y >= 0 && point.Y < Height; // that simpler option
        }
    }
}

