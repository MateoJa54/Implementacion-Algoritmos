namespace ImplementaciónAlgoritmos.UI
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.picBresenham = new System.Windows.Forms.PictureBox();
            this.picDDa = new System.Windows.Forms.PictureBox();
            this.PicCircle = new System.Windows.Forms.PictureBox();
            this.PicFloodFill = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bresenhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.círculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floodFillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelHome = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBresenham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDDa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFloodFill)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.PanelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBresenham
            // 
            this.picBresenham.Image = ((System.Drawing.Image)(resources.GetObject("picBresenham.Image")));
            this.picBresenham.Location = new System.Drawing.Point(371, 189);
            this.picBresenham.Margin = new System.Windows.Forms.Padding(2);
            this.picBresenham.Name = "picBresenham";
            this.picBresenham.Size = new System.Drawing.Size(195, 195);
            this.picBresenham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBresenham.TabIndex = 0;
            this.picBresenham.TabStop = false;
            this.picBresenham.Click += new System.EventHandler(this.picBresenham_Click);
            // 
            // picDDa
            // 
            this.picDDa.Image = ((System.Drawing.Image)(resources.GetObject("picDDa.Image")));
            this.picDDa.Location = new System.Drawing.Point(121, 189);
            this.picDDa.Margin = new System.Windows.Forms.Padding(2);
            this.picDDa.Name = "picDDa";
            this.picDDa.Size = new System.Drawing.Size(192, 197);
            this.picDDa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDDa.TabIndex = 1;
            this.picDDa.TabStop = false;
            this.picDDa.Click += new System.EventHandler(this.picDDa_Click);
            // 
            // PicCircle
            // 
            this.PicCircle.Image = ((System.Drawing.Image)(resources.GetObject("PicCircle.Image")));
            this.PicCircle.Location = new System.Drawing.Point(636, 189);
            this.PicCircle.Margin = new System.Windows.Forms.Padding(2);
            this.PicCircle.Name = "PicCircle";
            this.PicCircle.Size = new System.Drawing.Size(186, 195);
            this.PicCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicCircle.TabIndex = 2;
            this.PicCircle.TabStop = false;
            this.PicCircle.Click += new System.EventHandler(this.PicCircle_Click);
            // 
            // PicFloodFill
            // 
            this.PicFloodFill.Image = ((System.Drawing.Image)(resources.GetObject("PicFloodFill.Image")));
            this.PicFloodFill.Location = new System.Drawing.Point(869, 189);
            this.PicFloodFill.Margin = new System.Windows.Forms.Padding(2);
            this.PicFloodFill.Name = "PicFloodFill";
            this.PicFloodFill.Size = new System.Drawing.Size(198, 195);
            this.PicFloodFill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicFloodFill.TabIndex = 3;
            this.PicFloodFill.TabStop = false;
            this.PicFloodFill.Click += new System.EventHandler(this.PicFloodFill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(706, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Implementación de algoritmos ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.lineasToolStripMenuItem,
            this.círculoToolStripMenuItem,
            this.floodFillToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1186, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // lineasToolStripMenuItem
            // 
            this.lineasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dDAToolStripMenuItem,
            this.bresenhamToolStripMenuItem});
            this.lineasToolStripMenuItem.Name = "lineasToolStripMenuItem";
            this.lineasToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.lineasToolStripMenuItem.Text = "Lineas";
            // 
            // dDAToolStripMenuItem
            // 
            this.dDAToolStripMenuItem.Name = "dDAToolStripMenuItem";
            this.dDAToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.dDAToolStripMenuItem.Text = "DDA";
            this.dDAToolStripMenuItem.Click += new System.EventHandler(this.dDAToolStripMenuItem_Click);
            // 
            // bresenhamToolStripMenuItem
            // 
            this.bresenhamToolStripMenuItem.Name = "bresenhamToolStripMenuItem";
            this.bresenhamToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.bresenhamToolStripMenuItem.Text = "Bresenham";
            this.bresenhamToolStripMenuItem.Click += new System.EventHandler(this.bresenhamToolStripMenuItem_Click);
            // 
            // círculoToolStripMenuItem
            // 
            this.círculoToolStripMenuItem.Name = "círculoToolStripMenuItem";
            this.círculoToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.círculoToolStripMenuItem.Text = "Círculo";
            this.círculoToolStripMenuItem.Click += new System.EventHandler(this.círculoToolStripMenuItem_Click);
            // 
            // floodFillToolStripMenuItem
            // 
            this.floodFillToolStripMenuItem.Name = "floodFillToolStripMenuItem";
            this.floodFillToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.floodFillToolStripMenuItem.Text = "FloodFill";
            this.floodFillToolStripMenuItem.Click += new System.EventHandler(this.floodFillToolStripMenuItem_Click);
            // 
            // PanelHome
            // 
            this.PanelHome.Controls.Add(this.label1);
            this.PanelHome.Controls.Add(this.PicFloodFill);
            this.PanelHome.Controls.Add(this.PicCircle);
            this.PanelHome.Controls.Add(this.picDDa);
            this.PanelHome.Controls.Add(this.picBresenham);
            this.PanelHome.Location = new System.Drawing.Point(2, 25);
            this.PanelHome.Name = "PanelHome";
            this.PanelHome.Size = new System.Drawing.Size(1184, 649);
            this.PanelHome.TabIndex = 6;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1186, 674);
            this.Controls.Add(this.PanelHome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            ((System.ComponentModel.ISupportInitialize)(this.picBresenham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDDa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFloodFill)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PanelHome.ResumeLayout(false);
            this.PanelHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBresenham;
        private System.Windows.Forms.PictureBox picDDa;
        private System.Windows.Forms.PictureBox PicCircle;
        private System.Windows.Forms.PictureBox PicFloodFill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bresenhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem círculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floodFillToolStripMenuItem;
        private System.Windows.Forms.Panel PanelHome;
    }
}