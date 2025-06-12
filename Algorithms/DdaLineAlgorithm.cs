using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImplementaciónAlgoritmos.Algorithms
{
    internal class DdaLineAlgorithm
    {
        private float xInicio, yInicio, xFinal, yFinal;
        private List<PointF> puntos;
        private Graphics mGraph;
        private Pen mPenPunto;

        public DdaLineAlgorithm()
        {
            puntos = new List<PointF>();
            mPenPunto = new Pen(Color.Red, 2);
        }

        public void ReadData(TextBox txtX0, TextBox txtY0, TextBox txtX1, TextBox txtY1)
        {
            if (!float.TryParse(txtX0.Text, out xInicio) ||
                !float.TryParse(txtY0.Text, out yInicio) ||
                !float.TryParse(txtX1.Text, out xFinal) ||
                !float.TryParse(txtY1.Text, out yFinal))
            {
                MessageBox.Show("Coordenadas inválidas", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtX0.Focus();
            }
        }

        public void InitializeData(TextBox txtX0, TextBox txtY0, TextBox txtX1, TextBox txtY1, PictureBox picCanvas)
        {
            puntos.Clear();
            txtX0.Clear();
            txtY0.Clear();
            txtX1.Clear();
            txtY1.Clear();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            puntos.Clear();

            float dx = xFinal - xInicio;
            float dy = yFinal - yInicio;
            float m = (dx != 0) ? dy / dx : float.MaxValue;

            float x = xInicio;
            float y = yInicio;
            puntos.Add(new PointF(x, y));

            if (Math.Abs(m) <= 1)
            {
                float xInc = (dx > 0 ? 1 : -1);
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
                float yInc = (dy > 0 ? 1 : -1);
                float xInc = (dx != 0) ? (1 / m) * yInc : 0;
                int pasos = (int)Math.Abs(dy);

                for (int i = 0; i < pasos; i++)
                {
                    x += xInc;
                    y += yInc;
                    puntos.Add(new PointF(x, y));
                }
            }

            float cx = picCanvas.Width / 2f;
            float cy = picCanvas.Height / 2f;

            foreach (PointF p in puntos)
            {
                float px = cx + p.X;
                float py = cy - p.Y;
                mGraph.FillEllipse(mPenPunto.Brush, px, py, 2, 2);
            }
        }
    }
}