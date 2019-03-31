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

        public static List<Pillar> getPillars()
        {
            var pillars = new List<Pillar>();

            pillars.Add(new Pillar(0.1, 10, new Point(0, 0, 0)));
            pillars.Add(new Pillar(0.1, 10, new Point(5, 10, 0)));
            pillars.Add(new Pillar(0.1, 10, new Point(5, 0, 0)));
            pillars.Add(new Pillar(0.1, 10, new Point(0, 10, 0)));

            return pillars;
        }
    }
}
