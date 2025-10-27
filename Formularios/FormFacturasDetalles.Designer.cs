namespace SuperMercadoProyecto.Formularios
{
    partial class FormFacturasDetalles
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
            dgvFacturasDetalles = new DataGridView();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)dgvFacturasDetalles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvFacturasDetalles
            // 
            dgvFacturasDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacturasDetalles.Dock = DockStyle.Fill;
            dgvFacturasDetalles.Location = new Point(0, 0);
            dgvFacturasDetalles.Name = "dgvFacturasDetalles";
            dgvFacturasDetalles.RowHeadersWidth = 62;
            dgvFacturasDetalles.Size = new Size(800, 353);
            dgvFacturasDetalles.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvFacturasDetalles);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 93;
            splitContainer1.TabIndex = 1;
            // 
            // FormFacturasDetalles
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "FormFacturasDetalles";
            Text = "Detalles de Facturas";
            Load += FormFacturasDetalles_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFacturasDetalles).EndInit();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvFacturasDetalles;
        private SplitContainer splitContainer1;
    }
}