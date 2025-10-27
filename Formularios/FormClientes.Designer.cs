namespace SuperMercadoProyecto
{
    partial class FormClientes
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
            components = new System.ComponentModel.Container();
            dgvClientes = new DataGridView();
            cmsDatos = new ContextMenuStrip(components);
            toolStripEditar = new ToolStripMenuItem();
            toolStripEliminar = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            btnAgregarClien = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            cmsDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.ContextMenuStrip = cmsDatos;
            dgvClientes.Dock = DockStyle.Fill;
            dgvClientes.Location = new Point(0, 0);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 62;
            dgvClientes.Size = new Size(1235, 295);
            dgvClientes.TabIndex = 0;
            dgvClientes.Click += dgvClientes_Click;
            // 
            // cmsDatos
            // 
            cmsDatos.ImageScalingSize = new Size(24, 24);
            cmsDatos.Items.AddRange(new ToolStripItem[] { toolStripEditar, toolStripEliminar });
            cmsDatos.Name = "contextMenuStrip1";
            cmsDatos.Size = new Size(147, 68);
            cmsDatos.Click += cmsDatos_Click;
            // 
            // toolStripEditar
            // 
            toolStripEditar.Name = "toolStripEditar";
            toolStripEditar.Size = new Size(146, 32);
            toolStripEditar.Text = "Editar";
            toolStripEditar.Click += editarToolStripMenuItem_Click;
            // 
            // toolStripEliminar
            // 
            toolStripEliminar.Name = "toolStripEliminar";
            toolStripEliminar.Size = new Size(146, 32);
            toolStripEliminar.Text = "Eliminar";
            toolStripEliminar.Click += toolStripEliminar_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(btnAgregarClien);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvClientes);
            splitContainer1.Size = new Size(1235, 379);
            splitContainer1.SplitterDistance = 80;
            splitContainer1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 24);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 1;
            label1.Text = "CLIENTES";
            // 
            // btnAgregarClien
            // 
            btnAgregarClien.Location = new Point(1006, 28);
            btnAgregarClien.Name = "btnAgregarClien";
            btnAgregarClien.Size = new Size(217, 34);
            btnAgregarClien.TabIndex = 0;
            btnAgregarClien.Text = "Agregar Clientes";
            btnAgregarClien.UseVisualStyleBackColor = true;
            btnAgregarClien.Click += btnAgregarClien_Click;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 379);
            Controls.Add(splitContainer1);
            Name = "FormClientes";
            Text = "Clientes";
            Activated += FormClientes_Activated;
            Load += FormClientes_Load;
            Click += FormClientes_Click;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            cmsDatos.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvClientes;
        private ContextMenuStrip cmsDatos;
        private ToolStripMenuItem toolStripEditar;
        private ToolStripMenuItem toolStripEliminar;
        private SplitContainer splitContainer1;
        private Button btnAgregarClien;
        private Label label1;
    }
}