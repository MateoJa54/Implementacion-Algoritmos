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
    public class BresenhamCircleAlgorithm : IRenderingAlgorithm
    {
        // parameters: center point, radius
        public IEnumerable<Pixel> Compute(params object[] parameters)
        {
            var center = (Point)parameters[0];
            var radius = (int)parameters[1];
            var pixels = new List<Pixel>();

            int cx = center.X;
            int cy = center.Y;
            int x = 0;
            int y = radius;
            int d = 3 - 2 * radius;

            void PlotCirclePoints(int px, int py)
            {
                pixels.Add(new Pixel(cx + px, cy + py, Color.Red));
                pixels.Add(new Pixel(cx - px, cy + py, Color.Red));
                pixels.Add(new Pixel(cx + px, cy - py, Color.Red));
                pixels.Add(new Pixel(cx - px, cy - py, Color.Red));
                pixels.Add(new Pixel(cx + py, cy + px, Color.Red));
                pixels.Add(new Pixel(cx - py, cy + px, Color.Red));
                pixels.Add(new Pixel(cx + py, cy - px, Color.Red));
                pixels.Add(new Pixel(cx - py, cy - px, Color.Red));
            }

            PlotCirclePoints(x, y);
            while (y >= x)
            {
                x++;
                if (d > 0)
                {
                    y--;
                    d += 4 * (x - y) + 10;
                }
                else
                {
                    d += 4 * x + 6;
                }
                PlotCirclePoints(x, y);
            }

            return pixels;
        }
    }
}
