﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImplementaciónAlgoritmos.UI.Controllers;

namespace ImplementaciónAlgoritmos.UI
{
    public partial class FrmBresenhamLine : Form
    {
        private readonly BresController _controller;

        public FrmBresenhamLine()
        {
            InitializeComponent();
            _controller = new BresController(picCanvas, dgvPixels);
        }

        private async void btnCalculate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtX0.Text, out int x0) &&
                int.TryParse(txtY0.Text, out int y0) &&
                int.TryParse(txtX1.Text, out int x1) &&
                int.TryParse(txtY1.Text, out int y1))
            {
                await _controller.DrawAsync(x0, y0, x1, y1);
            }
            else
            {
                MessageBox.Show("Coordenadas inválidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            _controller.Cancel();
            _controller.Initialize();
        }
    }
}
