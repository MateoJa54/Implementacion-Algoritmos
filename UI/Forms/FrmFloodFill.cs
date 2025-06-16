using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImplementaciónAlgoritmos.Algorithms;
using ImplementaciónAlgoritmos.Core.Interfaces;
using ImplementaciónAlgoritmos.Core.Models;
using ImplementaciónAlgoritmos.Core.Utilities;
using ImplementaciónAlgoritmos.Infraestructure.Animation;
using ImplementaciónAlgoritmos.Infraestructure.Logging;
using ImplementaciónAlgoritmos.UI.Controllers;

namespace ImplementaciónAlgoritmos.UI
{
    public partial class FrmFloodFill : Form
    {
        private readonly FloodFillController _controller;

    public FrmFloodFill()
    {
        InitializeComponent();
        _controller = new FloodFillController(picCanvas, dgvPixels);

        // Configurar el modo 'bote'
        chkBucket.CheckedChanged += ChkBucket_CheckedChanged;
    }

    private void ChkBucket_CheckedChanged(object sender, EventArgs e)
    {
        if (chkBucket.Checked)
        {
            picCanvas.MouseClick += PicCanvas_MouseClick;
            picCanvas.Cursor = Cursors.Hand;
        }
        else
        {
            picCanvas.MouseClick -= PicCanvas_MouseClick;
            picCanvas.Cursor = Cursors.Default;
        }
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
        if (int.TryParse(txtSides.Text, out int sides) && sides >= 3)
        {
            _controller.DrawPolygon(sides, 70);
        }
        else
        {
            MessageBox.Show("Ingrese lados >= 3",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void PicCanvas_MouseClick(object sender, MouseEventArgs e)
    {
        // Desactivar el bote para un solo uso
        chkBucket.Checked = false;
        await _controller.FillAsync(e.Location, delayMs: 0);
    }

    private void btnClean_Click(object sender, EventArgs e)
    {
        _controller.Cancel();
        _controller.Initialize();
        chkBucket.Checked = false;
    }
}
}
