using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImplementaciónAlgoritmos.Core.Models
{
    public class Pixel
    {
        public int X { get; }
        public int Y { get; }
        public System.Drawing.Color Color { get; }

        public Pixel(int x, int y, System.Drawing.Color color)
        {
            X = x;
            Y = y;
            Color = color;
        }
    }

}
