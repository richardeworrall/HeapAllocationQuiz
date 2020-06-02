using System;

namespace Questions
{
    public class Question2 : IQuestion
    {
        private interface ICoord2D { double X { get; } double Y { get; } }
    
        private struct Coord2D : ICoord2D
        {
            public double X { get; } public double Y { get; }
        
            public Coord2D(double x, double y) { X = x; Y = y; }
        }
        
        private double L2Distance(ICoord2D a, ICoord2D b)
        {
            var dx = a.X - b.X; var dy = a.Y - b.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        
        // Does the following allocate per-call?
        public void Run()
        {
            var p1 = new Coord2D(1.1, 1.3); var p2 = new Coord2D(2.8, -7.6);
            
            var dist = L2Distance(p1, p2);
        }
    }
}