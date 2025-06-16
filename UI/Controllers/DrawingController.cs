using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImplementaciónAlgoritmos.Core.Interfaces;
using ImplementaciónAlgoritmos.Core.Models;
using ImplementaciónAlgoritmos.Infraestructure.Animation;
using ImplementaciónAlgoritmos.Infraestructure.Logging;

namespace ImplementaciónAlgoritmos.UI.Controllers
{
    public class DrawingController
    {
        private readonly IRenderingAlgorithm _algorithm;
        private readonly PixelAnimator _animator;
        private readonly PixelLogger _logger;

        public DrawingController(
            IRenderingAlgorithm algorithm,
            PixelAnimator animator,
            PixelLogger logger)
        {
            _algorithm = algorithm;
            _animator = animator;
            _logger = logger;
        }

        public async Task DrawAsync(Point p1, Point p2, int delayMs)
        {
            _logger.Clear();
            var pixels = _algorithm.Compute(p1, p2);
            _animator.OnPixelLit += _logger.Log;
            await _animator.AnimateAsync(pixels, delayMs);
        }

        public IReadOnlyList<Pixel> GetLoggedPixels() => _logger.GetLogged();
    }
}
