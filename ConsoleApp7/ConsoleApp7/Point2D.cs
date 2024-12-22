using System;

namespace ConsoleApp7
{
    public struct Point2D
    {
        public int X { get; }
        public int Y { get; }

        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double distanceFromOrigin()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
    }
}
