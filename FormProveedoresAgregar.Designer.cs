namespace SuperMercadoProyecto
{
    partial class FormProveedoresAgregar
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
            label1 = new Label();
            txtEmpresa = new TextBox();
            txtTelPrinc = new MaskedTextBox();
            txtTipoProducto = new TextBox();
            label2 = new Label();
            txtDireccion = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTelSec = new MaskedTextBox();
            txtEmail = new TextBox();
            label6 = new Label();
            btnAgregar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 23);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 0;
            label1.Text = "Empresa";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(13, 51);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(150, 31);
            txtEmpresa.TabIndex = 1;
            // 
            // txtTelPrinc
            // 
            txtTelPrinc.Location = new Point(13, 237);
            txtTelPrinc.Mask = "(999)000-0000";
            txtTelPrinc.Name = "txtTelPrinc";
            txtTelPrinc.Size = new Size(150, 31);
            txtTelPrinc.TabIndex = 2;
            // 
            // txtTipoProducto
            // 
            txtTipoProducto.Location = new Point(13, 113);
            txtTipoProducto.Name = "txtTipoProducto";
            txtTipoProducto.Size = new Size(150, 31);
            txtTipoProducto.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 85);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 3;
            label2.Text = "Tipo Producto";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(13, 175);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(150, 31);
            txtDireccion.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 147);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 5;
            label3.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 209);
            label4.Name = "label4";
            label4.Size = new Size(150, 25);
            label4.TabIndex = 7;
            label4.Text = "Telefono Principal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 271);
            label5.Name = "label5";
            label5.Size = new Size(172, 25);
            label5.TabIndex = 9;
            label5.Text = "Telefono Secundario";
            // 
            // txtTelSec
            // 
            txtTelSec.Location = new Point(13, 299);
            txtTelSec.Mask = "(999)000-0000";
            txtTelSec.Name = "txtTelSec";
            txtTelSec.Size = new Size(150, 31);
            txtTelSec.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(13, 361);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 333);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 10;
            label6.Text = "Email";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(51, 425);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(200, 425);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormProveedoresAgregar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 480);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtTelSec);
            Controls.Add(label4);
            Controls.Add(txtDireccion);
            Controls.Add(label3);
            Controls.Add(txtTipoProducto);
            Controls.Add(label2);
            Controls.Add(txtTelPrinc);
            Controls.Add(txtEmpresa);
            Controls.Add(label1);
            Name = "FormProveedoresAgregar";
            Text = "FormProveedoresAgregar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmpresa;
        private MaskedTextBox txtTelPrinc;
        private TextBox txtTipoProducto;
        private Label label2;
        private TextBox txtDireccion;
        private Label label3;
        private Label label4;
        private Label label5;
        private MaskedTextBox txtTelSec;
        private TextBox txtEmail;
        private Label label6;
        private Button btnAgregar;
        private Button btnCancelar;
    }
}