using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementaciónAlgoritmos.Core.Utilities
{
    public static class RegularPolygonGenerator
    {
        public static List<System.Drawing.Point> Generate(
            System.Drawing.Point center,
            int sides,
            int radius)
        {
            var verts = new List<System.Drawing.Point>();
            double angleStep = 2 * Math.PI / sides;
            for (int i = 0; i < sides; i++)
            {
                double angle = i * angleStep;
                int x = center.X + (int)(radius * Math.Cos(angle));
                int y = center.Y + (int)(radius * Math.Sin(angle));
                verts.Add(new System.Drawing.Point(x, y));
            }
            return verts;
        }
    }
}
