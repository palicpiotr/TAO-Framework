using System.Collections.Generic;

namespace Course.Building.Palic.Models
{
    public class Pillar
    {
        public double Radius;
        public double Height;
        public Point Center;

        public Pillar(double r, double h, Point center)
        {
            Radius = r;
            Height = h;
            Center = center;
        }

        public static List<Pillar> GetPillars()
        {
            var pillars = new List<Pillar>();
            pillars.Add(new Pillar(0.1, 10 - 5, new Point(5 - 5, 10 - 5, 0 - 5)));
            pillars.Add(new Pillar(0.1, 10 - 5, new Point(5 - 5, 10 - 5, 0 - 5)));
            pillars.Add(new Pillar(0.1, 10 - 5, new Point(5 - 5, 0 - 5, 0 - 5)));
            pillars.Add(new Pillar(0.1, 10 - 5, new Point(0 - 5, 10 - 5, 0 - 5)));
            return pillars;
        }
    }
}
