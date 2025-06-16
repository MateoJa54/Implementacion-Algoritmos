using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImplementaciónAlgoritmos.Core.Interfaces;
using ImplementaciónAlgoritmos.Core.Models;

namespace ImplementaciónAlgoritmos.Algorithms
{
    public class BresenhamLineAlgorithm : IRenderingAlgorithm
    {
        public IEnumerable<Pixel> Compute(params object[] parameters)
        {
            var start = (Point)parameters[0];
            var end = (Point)parameters[1];
            var pixels = new List<Pixel>();

            int x0 = start.X;
            int y0 = start.Y;
            int x1 = end.X;
            int y1 = end.Y;

            int dx = Math.Abs(x1 - x0);
            int dy = Math.Abs(y1 - y0);
            int sx = x0 < x1 ? 1 : -1;
            int sy = y0 < y1 ? 1 : -1;
            int err = dx - dy;

            int x = x0;
            int y = y0;

            while (true)
            {
                pixels.Add(new Pixel(x, y, Color.Red));
                if (x == x1 && y == y1) break;
                int e2 = 2 * err;
                if (e2 > -dy)
                {
                    err -= dy;
                    x += sx;
                }
                if (e2 < dx)
                {
                    err += dx;
                    y += sy;
                }
            }

            return pixels;
        }
    }
}
