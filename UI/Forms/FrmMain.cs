using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImplementaciónAlgoritmos.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void AbrirFormulario<T>() where T : Form, new()
        {
            // 1) Oculto el Home
            PanelHome.Visible = false;

            // 2) Cierro cualquier child abierto para evitar duplicados
            foreach (var frm in this.MdiChildren)
                frm.Close();

            // 3) Creo y muestro el nuevo child dentro del MDI
            T nuevo = new T
            {
                MdiParent = this,
                FormBorderStyle = FormBorderStyle.None,
                WindowState = FormWindowState.Maximized,
                Dock = DockStyle.Fill
            };
            nuevo.Show();
        }


        private void dDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmDda>();
        }

        private void picDDa_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmDda>();
        }

        private void PicCircle_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmBresenhamCircle>();
        }
        private void picBresenham_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmBresenhamLine>();
        }
        private void PicFloodFill_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmFloodFill>();
        }

        // Repite el mismo patrón para todos los métodos
        private void bresenhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmBresenhamLine>();
        }

        private void círculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmBresenhamCircle>();
        }

        private void floodFillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmFloodFill>();
        }
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var child in this.MdiChildren)
                child.Close();

            PanelHome.Visible = true;
        }

    }
}
