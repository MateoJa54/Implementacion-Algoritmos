using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImplementaciónAlgoritmos.UI.Controllers;

namespace ImplementaciónAlgoritmos.UI.Forms
{
    public partial class FrmCircle : Form
    {
        private readonly CircleController _controller;

        public FrmCircle()
        {
            InitializeComponent();
            _controller = new CircleController(picCanvas, dgvPixels);
        }

        private async void btnCalculate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtRadius.Text, out int r) && r > 0)
            {
                await _controller.DrawAsync(r);
            }
            else
            {
                MessageBox.Show("Radio inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            _controller.Cancel();
            _controller.Initialize();
        }
    }
}
