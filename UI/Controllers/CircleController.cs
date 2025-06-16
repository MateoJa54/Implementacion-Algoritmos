using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ImplementaciónAlgoritmos.Algorithms;
using ImplementaciónAlgoritmos.Core.Interfaces;
using ImplementaciónAlgoritmos.Core.Models;
using ImplementaciónAlgoritmos.Infraestructure.Animation;
using ImplementaciónAlgoritmos.Infraestructure.Logging;
using ImplementaciónAlgoritmos.UI.Forms;
using System.Windows.Forms;

namespace ImplementaciónAlgoritmos.UI.Controllers
{
    public class CircleController
    {
        private readonly IRenderingAlgorithm _algorithm;
        private readonly PixelAnimator _animator;
        private readonly PixelLogger _logger;
        private CancellationTokenSource _cts;

        private readonly PictureBox _canvas;
        private readonly DataGridView _grid;

        public CircleController(PictureBox canvas, DataGridView grid)
        {
            _canvas = canvas;
            _grid = grid;
            _algorithm = new BresenhamCircleAlgorithm();
            _animator = new PixelAnimator();
            _logger = new PixelLogger();
            _animator.OnPixelLit += HandlePixel;
            SetupGrid();
        }

        private void SetupGrid()
        {
            _grid.Columns.Clear();
            _grid.Columns.Add("Index", "#");
            _grid.Columns.Add("X", "X");
            _grid.Columns.Add("Y", "Y");
            _grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            _grid.ReadOnly = true;
        }

        public void Initialize()
        {
            _cts?.Cancel();
            _canvas.Refresh();
            _grid.Rows.Clear();
            _logger.Clear();
        }

        public async Task DrawAsync(int radius, int delayMs = 50)
        {
            Initialize();
            _cts = new CancellationTokenSource();
            // center at canvas center in logical coords (0,0)
            var center = new Point(0, 0);
            var pixels = _algorithm.Compute(center, radius);
            try
            {
                await _animator.AnimateAsync(pixels, delayMs)
                                .WithCancellation(_cts.Token);
            }
            catch (OperationCanceledException)
            {
                // cancelled
            }
        }

        public void Cancel() => _cts?.Cancel();

        private void HandlePixel(Pixel p)
        {
            int cx = _canvas.Width / 2;
            int cy = _canvas.Height / 2;
            int drawX = cx + p.X;
            int drawY = cy - p.Y;

            if (_canvas.InvokeRequired)
                _canvas.Invoke(new Action(() =>
                    _canvas.CreateGraphics().FillRectangle(Brushes.Red, drawX, drawY, 2, 2)
                ));
            else
                _canvas.CreateGraphics().FillRectangle(Brushes.Red, drawX, drawY, 2, 2);

            _logger.Log(p);
            int idx = _logger.GetLogged().Count;
            if (_grid.InvokeRequired)
                _grid.Invoke(new Action(() => _grid.Rows.Add(idx, p.X, p.Y)));
            else
                _grid.Rows.Add(idx, p.X, p.Y);
        }
    }
}
