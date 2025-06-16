using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImplementaciónAlgoritmos.Core.Models;

namespace ImplementaciónAlgoritmos.Infraestructure.Animation
{
    public class PixelAnimator
    {
        public event Action<Pixel> OnPixelLit;

        public async Task AnimateAsync(
            IEnumerable<Pixel> pixels,
            int delayMs)
        {
            foreach (var p in pixels)
            {
                OnPixelLit?.Invoke(p);
                await Task.Delay(delayMs);
            }
        }
    }
}
