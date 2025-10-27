namespace SuperMercadoProyecto.Formularios
{
    partial class FormEmpleados
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
            dgvEmpleados = new DataGridView();
            cmsEmpleados = new ContextMenuStrip(components);
            editarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            btnAgregarEmpledos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            cmsEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.ContextMenuStrip = cmsEmpleados;
            dgvEmpleados.Dock = DockStyle.Fill;
            dgvEmpleados.Location = new Point(0, 0);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 62;
            dgvEmpleados.Size = new Size(1179, 376);
            dgvEmpleados.TabIndex = 0;
            // 
            // cmsEmpleados
            // 
            cmsEmpleados.ImageScalingSize = new Size(24, 24);
            cmsEmpleados.Items.AddRange(new ToolStripItem[] { editarToolStripMenuItem, eliminarToolStripMenuItem });
            cmsEmpleados.Name = "cmsEmpleados";
            cmsEmpleados.Size = new Size(147, 68);
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(146, 32);
            editarToolStripMenuItem.Text = "Editar";
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(146, 32);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
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
            splitContainer1.Panel1.Controls.Add(btnAgregarEmpledos);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvEmpleados);
            splitContainer1.Size = new Size(1179, 450);
            splitContainer1.SplitterDistance = 70;
            splitContainer1.TabIndex = 1;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // btnAgregarEmpledos
            // 
            btnAgregarEmpledos.Location = new Point(636, 22);
            btnAgregarEmpledos.Name = "btnAgregarEmpledos";
            btnAgregarEmpledos.Size = new Size(204, 34);
            btnAgregarEmpledos.TabIndex = 0;
            btnAgregarEmpledos.Text = "Agregra Empleados";
            btnAgregarEmpledos.UseVisualStyleBackColor = true;
            btnAgregarEmpledos.Click += btnAgregarEmpledos_Click;
            // 
            // FormEmpleados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 450);
            Controls.Add(splitContainer1);
            Name = "FormEmpleados";
            Text = "Empleados";
            Load += FormEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            cmsEmpleados.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEmpleados;
        private SplitContainer splitContainer1;
        private ContextMenuStrip cmsEmpleados;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private Button btnAgregarEmpledos;
    }
}