namespace SuperMercadoProyecto.Formularios
{
    partial class FormProductos
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
            dgvProductos = new DataGridView();
            cmsProductosA = new ContextMenuStrip(components);
            agregarAlCarritoToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            abiriToolStripMenuItem = new ToolStripMenuItem();
            empledadosToolStripMenuItem = new ToolStripMenuItem();
            proveedoresToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            otrosToolStripMenuItem = new ToolStripMenuItem();
            comprasDeClientesToolStripMenuItem = new ToolStripMenuItem();
            facturasToolStripMenuItem = new ToolStripMenuItem();
            detallesDeFacturasToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem1 = new ToolStripMenuItem();
            ventasDeProductosToolStripMenuItem = new ToolStripMenuItem();
            btnConectar = new Button();
            splitContainer1 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            dgvCompras = new DataGridView();
            pictureBoxProducto = new PictureBox();
            btnAgregarProductos = new Button();
            splitContainer2 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            cmsProductosA.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.ContextMenuStrip = cmsProductosA;
            dgvProductos.Dock = DockStyle.Fill;
            dgvProductos.Location = new Point(0, 0);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(1314, 292);
            dgvProductos.TabIndex = 0;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // cmsProductosA
            // 
            cmsProductosA.ImageScalingSize = new Size(24, 24);
            cmsProductosA.Items.AddRange(new ToolStripItem[] { agregarAlCarritoToolStripMenuItem, eliminarToolStripMenuItem, editarToolStripMenuItem });
            cmsProductosA.Name = "cmsProductosA";
            cmsProductosA.Size = new Size(222, 100);
            // 
            // agregarAlCarritoToolStripMenuItem
            // 
            agregarAlCarritoToolStripMenuItem.Name = "agregarAlCarritoToolStripMenuItem";
            agregarAlCarritoToolStripMenuItem.Size = new Size(221, 32);
            agregarAlCarritoToolStripMenuItem.Text = "Agregar al carrito";
            agregarAlCarritoToolStripMenuItem.Click += agregarAlCarritoToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(221, 32);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(221, 32);
            editarToolStripMenuItem.Text = "Editar";
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { abiriToolStripMenuItem, otrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1314, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // abiriToolStripMenuItem
            // 
            abiriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { empledadosToolStripMenuItem, proveedoresToolStripMenuItem, clientesToolStripMenuItem });
            abiriToolStripMenuItem.Name = "abiriToolStripMenuItem";
            abiriToolStripMenuItem.Size = new Size(79, 29);
            abiriToolStripMenuItem.Text = "Abrir...";
            // 
            // empledadosToolStripMenuItem
            // 
            empledadosToolStripMenuItem.Name = "empledadosToolStripMenuItem";
            empledadosToolStripMenuItem.Size = new Size(213, 34);
            empledadosToolStripMenuItem.Text = "Empledados";
            empledadosToolStripMenuItem.Click += empledadosToolStripMenuItem_Click;
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.Size = new Size(213, 34);
            proveedoresToolStripMenuItem.Text = "Proveedores";
            proveedoresToolStripMenuItem.Click += proveedoresToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(213, 34);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // otrosToolStripMenuItem
            // 
            otrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { comprasDeClientesToolStripMenuItem, facturasToolStripMenuItem, detallesDeFacturasToolStripMenuItem, ventasToolStripMenuItem1, ventasDeProductosToolStripMenuItem });
            otrosToolStripMenuItem.Name = "otrosToolStripMenuItem";
            otrosToolStripMenuItem.Size = new Size(85, 29);
            otrosToolStripMenuItem.Text = "Otros...";
            // 
            // comprasDeClientesToolStripMenuItem
            // 
            comprasDeClientesToolStripMenuItem.Name = "comprasDeClientesToolStripMenuItem";
            comprasDeClientesToolStripMenuItem.Size = new Size(277, 34);
            comprasDeClientesToolStripMenuItem.Text = "Compras de Clientes";
            comprasDeClientesToolStripMenuItem.Click += comprasDeClientesToolStripMenuItem_Click;
            // 
            // facturasToolStripMenuItem
            // 
            facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            facturasToolStripMenuItem.Size = new Size(277, 34);
            facturasToolStripMenuItem.Text = "Facturas";
            facturasToolStripMenuItem.Click += facturasToolStripMenuItem_Click;
            // 
            // detallesDeFacturasToolStripMenuItem
            // 
            detallesDeFacturasToolStripMenuItem.Name = "detallesDeFacturasToolStripMenuItem";
            detallesDeFacturasToolStripMenuItem.Size = new Size(277, 34);
            detallesDeFacturasToolStripMenuItem.Text = "Detalles de Facturas";
            detallesDeFacturasToolStripMenuItem.Click += detallesDeFacturasToolStripMenuItem_Click;
            // 
            // ventasToolStripMenuItem1
            // 
            ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            ventasToolStripMenuItem1.Size = new Size(277, 34);
            ventasToolStripMenuItem1.Text = "Ventas";
            ventasToolStripMenuItem1.Click += ventasToolStripMenuItem1_Click;
            // 
            // ventasDeProductosToolStripMenuItem
            // 
            ventasDeProductosToolStripMenuItem.Name = "ventasDeProductosToolStripMenuItem";
            ventasDeProductosToolStripMenuItem.Size = new Size(277, 34);
            ventasDeProductosToolStripMenuItem.Text = "Ventas de Productos";
            ventasDeProductosToolStripMenuItem.Click += ventasDeProductosToolStripMenuItem_Click;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(1164, 3);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(147, 34);
            btnConectar.TabIndex = 2;
            btnConectar.Text = "Conectar BD";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
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
            splitContainer1.Panel1.Controls.Add(dgvProductos);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer3);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1314, 509);
            splitContainer1.SplitterDistance = 292;
            splitContainer1.TabIndex = 3;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(dgvCompras);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(pictureBoxProducto);
            splitContainer3.Size = new Size(1314, 213);
            splitContainer3.SplitterDistance = 850;
            splitContainer3.TabIndex = 1;
            // 
            // dgvCompras
            // 
            dgvCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompras.Dock = DockStyle.Fill;
            dgvCompras.GridColor = SystemColors.Info;
            dgvCompras.Location = new Point(0, 0);
            dgvCompras.Name = "dgvCompras";
            dgvCompras.RowHeadersWidth = 62;
            dgvCompras.Size = new Size(850, 213);
            dgvCompras.TabIndex = 0;
            // 
            // pictureBoxProducto
            // 
            pictureBoxProducto.Dock = DockStyle.Fill;
            pictureBoxProducto.Location = new Point(0, 0);
            pictureBoxProducto.Name = "pictureBoxProducto";
            pictureBoxProducto.Size = new Size(460, 213);
            pictureBoxProducto.TabIndex = 0;
            pictureBoxProducto.TabStop = false;
            // 
            // btnAgregarProductos
            // 
            btnAgregarProductos.Location = new Point(934, 3);
            btnAgregarProductos.Name = "btnAgregarProductos";
            btnAgregarProductos.Size = new Size(183, 34);
            btnAgregarProductos.TabIndex = 4;
            btnAgregarProductos.Text = "Agregar Productos";
            btnAgregarProductos.UseVisualStyleBackColor = true;
            btnAgregarProductos.Click += btnAgregarProductos_Click;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 33);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(btnAgregarProductos);
            splitContainer2.Panel1.Controls.Add(btnConectar);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer1);
            splitContainer2.Size = new Size(1314, 586);
            splitContainer2.SplitterDistance = 73;
            splitContainer2.TabIndex = 5;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 619);
            Controls.Add(splitContainer2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormProductos";
            Text = "Productos";
            Load += FormProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            cmsProductosA.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProducto).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem abiriToolStripMenuItem;
        private ToolStripMenuItem empledadosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private Button btnConectar;
        private SplitContainer splitContainer1;
        private Button btnAgregarProductos;
        private ContextMenuStrip cmsProductosA;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private SplitContainer splitContainer2;
        private DataGridView dgvCompras;
        private ToolStripMenuItem agregarAlCarritoToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private SplitContainer splitContainer3;
        private PictureBox pictureBoxProducto;
        private ToolStripMenuItem otrosToolStripMenuItem;
        private ToolStripMenuItem comprasDeClientesToolStripMenuItem;
        private ToolStripMenuItem facturasToolStripMenuItem;
        private ToolStripMenuItem detallesDeFacturasToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem1;
        private ToolStripMenuItem ventasDeProductosToolStripMenuItem;
    }
}