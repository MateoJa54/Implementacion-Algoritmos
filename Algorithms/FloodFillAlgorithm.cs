using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImplementaciónAlgoritmos.Core.Models;
using ImplementaciónAlgoritmos.Core.Interfaces;

namespace ImplementaciónAlgoritmos.Algorithms
{
    public class FloodFillAlgorithm : IFillAlgorithm
    {
        public IEnumerable<Pixel> ComputeFill(Point seed, Func<Point, bool> isBoundary)
        {
            var stack = new Stack<Point>();
            var visited = new HashSet<Point>();
            var result = new List<Pixel>();
            stack.Push(seed);

            while (stack.Count > 0)
            {
                var pt = stack.Pop();
                if (visited.Contains(pt) || isBoundary(pt))
                    continue;
                visited.Add(pt);
                result.Add(new Pixel(pt.X, pt.Y, Color.Blue));

                stack.Push(new Point(pt.X, pt.Y + 1));
                stack.Push(new Point(pt.X + 1, pt.Y));
                stack.Push(new Point(pt.X, pt.Y - 1));
                stack.Push(new Point(pt.X - 1, pt.Y));
            }

            return result;
        }
    }
}

