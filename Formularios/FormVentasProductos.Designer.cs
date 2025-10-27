namespace SuperMercadoProyecto.Formularios
{
    partial class FormVentasProductos
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
            dgvVentasProductos = new DataGridView();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)dgvVentasProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvVentasProductos
            // 
            dgvVentasProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentasProductos.Dock = DockStyle.Fill;
            dgvVentasProductos.Location = new Point(0, 0);
            dgvVentasProductos.Name = "dgvVentasProductos";
            dgvVentasProductos.RowHeadersWidth = 62;
            dgvVentasProductos.Size = new Size(800, 380);
            dgvVentasProductos.TabIndex = 0;
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
            splitContainer1.Panel2.Controls.Add(dgvVentasProductos);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 66;
            splitContainer1.TabIndex = 1;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // FormVentasProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "FormVentasProductos";
            Text = "Productos Ventas";
            Load += FormVentasProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentasProductos).EndInit();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvVentasProductos;
        private SplitContainer splitContainer1;
    }
}