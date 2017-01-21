﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = y;
            Y = y;
        }

        public override string ToString()
        {
            return X + "," + Y;
        }

        public int DistanceTo(int x, int y)
        {
            //one of options to formula
            // int xDiff = X - x;
            //  int yDiff = Y - y;
            //
            //int xDiffSquared = xDiff * xDiff;
            //int yDiffSquared = yDiff * yDiff;

            //return (int)Math.Sqrt(xDiffSquared + yDiffSquared);
            return (int)Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2));
        }

        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }
    }
}
