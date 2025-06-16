namespace ImplementaciónAlgoritmos.UI
{
    partial class FrmFloodFill
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
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSides = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.dgvPixels = new System.Windows.Forms.DataGridView();
            this.chkBucket = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPixels)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(249)))), ((int)(((byte)(240)))));
            this.picCanvas.Location = new System.Drawing.Point(474, 64);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(690, 582);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(424, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Algoritmo Bresenham";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(56)))));
            this.label2.Location = new System.Drawing.Point(22, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lados del polígono";
            // 
            // txtSides
            // 
            this.txtSides.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(217)))));
            this.txtSides.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSides.Location = new System.Drawing.Point(63, 135);
            this.txtSides.Name = "txtSides";
            this.txtSides.Size = new System.Drawing.Size(100, 24);
            this.txtSides.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(229)))), ((int)(((byte)(194)))));
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(27, 550);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(187, 51);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(229)))), ((int)(((byte)(194)))));
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(241, 550);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(172, 51);
            this.btnClean.TabIndex = 13;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // dgvPixels
            // 
            this.dgvPixels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPixels.Location = new System.Drawing.Point(27, 205);
            this.dgvPixels.Name = "dgvPixels";
            this.dgvPixels.Size = new System.Drawing.Size(410, 317);
            this.dgvPixels.TabIndex = 14;
            // 
            // chkBucket
            // 
            this.chkBucket.AutoSize = true;
            this.chkBucket.Location = new System.Drawing.Point(264, 142);
            this.chkBucket.Name = "chkBucket";
            this.chkBucket.Size = new System.Drawing.Size(99, 17);
            this.chkBucket.TabIndex = 15;
            this.chkBucket.Text = "Bote de Pintura";
            this.chkBucket.UseVisualStyleBackColor = true;
            this.chkBucket.CheckedChanged += new System.EventHandler(this.ChkBucket_CheckedChanged);
            // 
            // FrmFloodFill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1195, 675);
            this.Controls.Add(this.chkBucket);
            this.Controls.Add(this.dgvPixels);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtSides);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmFloodFill";
            this.Text = "FrmDda";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPixels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSides;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.DataGridView dgvPixels;
        private System.Windows.Forms.CheckBox chkBucket;
    }
}