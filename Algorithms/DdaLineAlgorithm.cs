using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImplementaciónAlgoritmos.Core.Interfaces;
using ImplementaciónAlgoritmos.Core.Models;

namespace ImplementaciónAlgoritmos.Algorithms
{
    public class DdaLineAlgorithm : IRenderingAlgorithm
    {
        public IEnumerable<Pixel> Compute(params object[] parameters)
        {
            var start = (Point)parameters[0];
            var end = (Point)parameters[1];

            float x0 = start.X, y0 = start.Y;
            float x1 = end.X, y1 = end.Y;
            var puntos = new List<PointF>();

            float dx = x1 - x0, dy = y1 - y0;
            float m = dx != 0 ? dy / dx : float.MaxValue;
            float x = x0, y = y0;
            puntos.Add(new PointF(x, y));

            if (Math.Abs(m) <= 1)
            {
                float xInc = Math.Sign(dx);
                float yInc = m * xInc;
                int pasos = (int)Math.Abs(dx);
                for (int i = 0; i < pasos; i++)
                {
                    x += xInc;
                    y += yInc;
                    puntos.Add(new PointF(x, y));
                }
            }
            else
            {
                float yInc = Math.Sign(dy);
                float xInc = m != 0 ? (1 / m) * yInc : 0;
                int pasos = (int)Math.Abs(dy);
                for (int i = 0; i < pasos; i++)
                {
                    x += xInc;
                    y += yInc;
                    puntos.Add(new PointF(x, y));
                }
            }

            // Ahora convertimos esos PointF en Pixel (sin dibujar)
            return puntos
                .Select(p => new Pixel((int)Math.Round(p.X), (int)Math.Round(p.Y), Color.Red))
                .ToList();
        }
    }
}