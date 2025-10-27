namespace SuperMercadoProyecto.Formularios
{
    partial class FormProveedores
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
            dgvProveedores = new DataGridView();
            cmsProveedores = new ContextMenuStrip(components);
            editarToolStripMenuItem = new ToolStripMenuItem();
            eLiminarToolStripMenuItem = new ToolStripMenuItem();
            btnAgregarProveedores = new Button();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            cmsProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProveedores
            // 
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.ContextMenuStrip = cmsProveedores;
            dgvProveedores.Dock = DockStyle.Fill;
            dgvProveedores.Location = new Point(0, 0);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowHeadersWidth = 62;
            dgvProveedores.Size = new Size(1273, 380);
            dgvProveedores.TabIndex = 0;
            // 
            // cmsProveedores
            // 
            cmsProveedores.ImageScalingSize = new Size(24, 24);
            cmsProveedores.Items.AddRange(new ToolStripItem[] { editarToolStripMenuItem, eLiminarToolStripMenuItem });
            cmsProveedores.Name = "cmsProveedores";
            cmsProveedores.Size = new Size(147, 68);
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(146, 32);
            editarToolStripMenuItem.Text = "Editar";
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
            // 
            // eLiminarToolStripMenuItem
            // 
            eLiminarToolStripMenuItem.Name = "eLiminarToolStripMenuItem";
            eLiminarToolStripMenuItem.Size = new Size(146, 32);
            eLiminarToolStripMenuItem.Text = "Eliminar";
            eLiminarToolStripMenuItem.Click += eLiminarToolStripMenuItem_Click;
            // 
            // btnAgregarProveedores
            // 
            btnAgregarProveedores.Location = new Point(1004, 12);
            btnAgregarProveedores.Name = "btnAgregarProveedores";
            btnAgregarProveedores.Size = new Size(238, 34);
            btnAgregarProveedores.TabIndex = 1;
            btnAgregarProveedores.Text = "Agregar Proveedores";
            btnAgregarProveedores.UseVisualStyleBackColor = true;
            btnAgregarProveedores.Click += btnAgregarProveedores_Click;
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
            splitContainer1.Panel1.Controls.Add(btnAgregarProveedores);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvProveedores);
            splitContainer1.Size = new Size(1273, 454);
            splitContainer1.SplitterDistance = 70;
            splitContainer1.TabIndex = 3;
            // 
            // FormProveedores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 454);
            Controls.Add(splitContainer1);
            Name = "FormProveedores";
            Text = "Proveedores";
            Activated += FormProveedores_Load;
            Load += FormProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            cmsProveedores.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProveedores;
        private Button btnAgregarProveedores;
        private ContextMenuStrip cmsProveedores;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem eLiminarToolStripMenuItem;
        private SplitContainer splitContainer1;
    }
}