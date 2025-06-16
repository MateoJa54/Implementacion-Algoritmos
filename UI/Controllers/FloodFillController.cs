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
using ImplementaciónAlgoritmos.Core.Utilities;
using ImplementaciónAlgoritmos.Infraestructure.Animation;
using ImplementaciónAlgoritmos.Infraestructure.Logging;
using ImplementaciónAlgoritmos.UI.Forms;
using System.Windows.Forms;

namespace ImplementaciónAlgoritmos.UI.Controllers
{
    public class FloodFillController
    {
        private readonly IRenderingAlgorithm _lineAlgo;
        private readonly IFillAlgorithm _fillAlgo;
        private readonly PixelAnimator _animator;
        private readonly PixelLogger _logger;
        private CancellationTokenSource _cts;

        private readonly PictureBox _canvas;
        private readonly DataGridView _grid;
        private Bitmap _buffer;

        public FloodFillController(PictureBox canvas, DataGridView grid)
        {
            _canvas = canvas;
            _grid = grid;
            _lineAlgo = new BresenhamLineAlgorithm();
            _fillAlgo = new FloodFillAlgorithm();
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
            _buffer = new Bitmap(_canvas.Width, _canvas.Height);
            // Fondo blanco
            using (var g = Graphics.FromImage(_buffer))
                g.Clear(Color.White);

            _canvas.Image = _buffer;
            _canvas.Refresh();
            _grid.Rows.Clear();
            _logger.Clear();
        }

        /// <summary>
        /// Dibuja el polígono regular (solo contorno) sin animación.
        /// </summary>
        public void DrawPolygon(int sides, int radius)
        {
            Initialize();
            var center = new Point(0, 0);
            var verts = RegularPolygonGenerator.Generate(center, sides, radius);
            // Pintar contorno en buffer
            foreach (var edge in GetEdges(verts))
            {
                foreach (var p in edge)
                {
                    int bx = _buffer.Width / 2 + p.X;
                    int by = _buffer.Height / 2 - p.Y;
                    _buffer.SetPixel(bx, by, Color.Red);
                }
            }
            _canvas.Refresh();
        }

        private IEnumerable<IEnumerable<Pixel>> GetEdges(List<Point> verts)
        {
            for (int i = 0; i < verts.Count; i++)
            {
                int j = (i + 1) % verts.Count;
                yield return _lineAlgo.Compute(verts[i], verts[j]);
            }
        }

        /// <summary>
        /// Rellena con animación solo tras hacer clic interior.
        /// </summary>
        public async Task FillAsync(Point click, int delayMs = 5)
        {
            _cts = new CancellationTokenSource();
            int centerX = _buffer.Width / 2;
            int centerY = _buffer.Height / 2;

            // Boundary: fuera de buffer o cualquier píxel no-blanco (rojo o ya pintado)
            Func<Point, bool> isBoundary = pt =>
            {
                int bx = centerX + pt.X;
                int by = centerY - pt.Y;
                if (bx < 0 || by < 0 || bx >= _buffer.Width || by >= _buffer.Height)
                    return true;
                return _buffer.GetPixel(bx, by).ToArgb() != Color.White.ToArgb();
            };

            // Mapeo del clic (canvas coords) a coords lógicas
            var seed = new Point(click.X - centerX, centerY - click.Y);
            var toFill = _fillAlgo.ComputeFill(seed, isBoundary);

            await Task.Run(async () =>
            {
                foreach (var p in toFill)
                {
                    _cts.Token.ThrowIfCancellationRequested();
                    _animator.PublishPixel(p);
                    await Task.Delay(delayMs, _cts.Token);
                }
            }, _cts.Token);
        }

        public void Cancel() => _cts?.Cancel();

        private void HandlePixel(Pixel p)
        {
            Action drawAndLog = () =>
            {
                int cx = _canvas.Width / 2;
                int cy = _canvas.Height / 2;
                int bx = cx + p.X;
                int by = cy - p.Y;
                // Sólo pintar si está dentro
                if (bx < 0 || by < 0 || bx >= _buffer.Width || by >= _buffer.Height)
                    return;

                _buffer.SetPixel(bx, by, p.Color);
                _canvas.Refresh();

                _logger.Log(p);
                int idx = _logger.GetLogged().Count;
                _grid.Rows.Add(idx, p.X, p.Y);
            };

            if (_canvas.InvokeRequired)
                _canvas.Invoke(drawAndLog);
            else
                drawAndLog();
        }
    }
}
