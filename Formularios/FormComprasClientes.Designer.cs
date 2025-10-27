namespace SuperMercadoProyecto.Formularios
{
    partial class FormComprasClientes
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
            dgvComprasClientes = new DataGridView();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)dgvComprasClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvComprasClientes
            // 
            dgvComprasClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComprasClientes.Dock = DockStyle.Fill;
            dgvComprasClientes.Location = new Point(0, 0);
            dgvComprasClientes.Name = "dgvComprasClientes";
            dgvComprasClientes.RowHeadersWidth = 62;
            dgvComprasClientes.Size = new Size(800, 374);
            dgvComprasClientes.TabIndex = 0;
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
            splitContainer1.Panel2.Controls.Add(dgvComprasClientes);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 72;
            splitContainer1.TabIndex = 1;
            // 
            // FormComprasClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "FormComprasClientes";
            Text = "Compras de Clientes";
            Load += FormComprasClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvComprasClientes).EndInit();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvComprasClientes;
        private SplitContainer splitContainer1;
    }
}