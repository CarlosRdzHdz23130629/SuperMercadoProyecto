namespace SuperMercadoProyecto.Formularios
{
    partial class FormEmpleadosAgregar
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            label2 = new Label();
            txtEdad = new TextBox();
            label3 = new Label();
            txtFecha = new MaskedTextBox();
            label4 = new Label();
            label5 = new Label();
            txtNoDoc = new TextBox();
            label6 = new Label();
            txtDocumento = new TextBox();
            label7 = new Label();
            txtCuil = new MaskedTextBox();
            label8 = new Label();
            txtTelPrinc = new MaskedTextBox();
            label9 = new Label();
            txtEmail = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtFechaIngr = new MaskedTextBox();
            label13 = new Label();
            btnAgregar = new Button();
            btnCancelar = new Button();
            txtDireccion = new TextBox();
            txtTelSec = new MaskedTextBox();
            txtCargo = new TextBox();
            label14 = new Label();
            txtAntiguedad = new TextBox();
            label15 = new Label();
            txtSalario = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 39);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 67);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(12, 129);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 31);
            txtApellido.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 101);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(12, 191);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(150, 31);
            txtEdad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 163);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 4;
            label3.Text = "Edad";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(12, 253);
            txtFecha.Mask = "0000-00-00";
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(150, 31);
            txtFecha.TabIndex = 6;
            txtFecha.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 225);
            label4.Name = "label4";
            label4.Size = new Size(177, 25);
            label4.TabIndex = 7;
            label4.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(243, 101);
            label5.Name = "label5";
            label5.Size = new Size(41, 25);
            label5.TabIndex = 12;
            label5.Text = "Cuil";
            // 
            // txtNoDoc
            // 
            txtNoDoc.Location = new Point(241, 67);
            txtNoDoc.Name = "txtNoDoc";
            txtNoDoc.Size = new Size(150, 31);
            txtNoDoc.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(243, 39);
            label6.Name = "label6";
            label6.Size = new Size(201, 25);
            label6.TabIndex = 10;
            label6.Text = "Numero de Documento";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(14, 315);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(150, 31);
            txtDocumento.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 287);
            label7.Name = "label7";
            label7.Size = new Size(146, 25);
            label7.TabIndex = 8;
            label7.Text = "Tipo Documento";
            // 
            // txtCuil
            // 
            txtCuil.Location = new Point(243, 129);
            txtCuil.Mask = "00-000000000-0";
            txtCuil.Name = "txtCuil";
            txtCuil.Size = new Size(150, 31);
            txtCuil.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(243, 163);
            label8.Name = "label8";
            label8.Size = new Size(85, 25);
            label8.TabIndex = 14;
            label8.Text = "Direccion";
            // 
            // txtTelPrinc
            // 
            txtTelPrinc.Location = new Point(243, 253);
            txtTelPrinc.Mask = "(999)000-0000";
            txtTelPrinc.Name = "txtTelPrinc";
            txtTelPrinc.Size = new Size(150, 31);
            txtTelPrinc.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(243, 225);
            label9.Name = "label9";
            label9.Size = new Size(150, 25);
            label9.TabIndex = 16;
            label9.Text = "Telefono Principal";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(464, 67);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(466, 39);
            label10.Name = "label10";
            label10.Size = new Size(54, 25);
            label10.TabIndex = 20;
            label10.Text = "Email";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(245, 287);
            label11.Name = "label11";
            label11.Size = new Size(150, 25);
            label11.TabIndex = 18;
            label11.Text = "Telefono Principal";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(466, 225);
            label12.Name = "label12";
            label12.Size = new Size(147, 25);
            label12.TabIndex = 23;
            label12.Text = "Fecha de Ingreso";
            // 
            // txtFechaIngr
            // 
            txtFechaIngr.Location = new Point(464, 253);
            txtFechaIngr.Mask = "0000-00-00";
            txtFechaIngr.Name = "txtFechaIngr";
            txtFechaIngr.Size = new Size(150, 31);
            txtFechaIngr.TabIndex = 22;
            txtFechaIngr.ValidatingType = typeof(DateTime);
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(466, 287);
            label13.Name = "label13";
            label13.Size = new Size(115, 25);
            label13.TabIndex = 24;
            label13.Text = "Salario Anual";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(112, 381);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 26;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(308, 381);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(243, 191);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(150, 31);
            txtDireccion.TabIndex = 28;
            // 
            // txtTelSec
            // 
            txtTelSec.Location = new Point(241, 315);
            txtTelSec.Mask = "(999)000-0000";
            txtTelSec.Name = "txtTelSec";
            txtTelSec.Size = new Size(150, 31);
            txtTelSec.TabIndex = 29;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(464, 129);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(150, 31);
            txtCargo.TabIndex = 31;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(466, 101);
            label14.Name = "label14";
            label14.Size = new Size(60, 25);
            label14.TabIndex = 30;
            label14.Text = "Cargo";
            // 
            // txtAntiguedad
            // 
            txtAntiguedad.Location = new Point(464, 191);
            txtAntiguedad.Name = "txtAntiguedad";
            txtAntiguedad.Size = new Size(150, 31);
            txtAntiguedad.TabIndex = 33;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(466, 163);
            label15.Name = "label15";
            label15.Size = new Size(105, 25);
            label15.TabIndex = 32;
            label15.Text = "Antiguedad";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(464, 315);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(150, 31);
            txtSalario.TabIndex = 34;
            // 
            // FormEmpleadosAgregar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 450);
            Controls.Add(txtSalario);
            Controls.Add(txtAntiguedad);
            Controls.Add(label15);
            Controls.Add(txtCargo);
            Controls.Add(label14);
            Controls.Add(txtTelSec);
            Controls.Add(txtDireccion);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(txtFechaIngr);
            Controls.Add(txtEmail);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(txtTelPrinc);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtCuil);
            Controls.Add(label5);
            Controls.Add(txtNoDoc);
            Controls.Add(label6);
            Controls.Add(txtDocumento);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(txtFecha);
            Controls.Add(txtEdad);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "FormEmpleadosAgregar";
            Text = "Agregar Empleados ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtEdad;
        private Label label3;
        private MaskedTextBox txtFecha;
        private Label label4;
        private Label label5;
        private TextBox txtNoDoc;
        private Label label6;
        private TextBox txtDocumento;
        private Label label7;
        private MaskedTextBox txtCuil;
        private Label label8;
        private MaskedTextBox txtTelPrinc;
        private Label label9;
        private TextBox txtEmail;
        private Label label10;
        private Label label11;
        private Label label12;
        private MaskedTextBox txtFechaIngr;
        private MaskedTextBox maskedTextBox6;
        private Label label13;
        private Button btnAgregar;
        private Button btnCancelar;
        private TextBox txtDireccion;
        private MaskedTextBox txtTelSec;
        private TextBox txtCargo;
        private Label label14;
        private TextBox txtAntiguedad;
        private Label label15;
        private TextBox txtSalario;
    }
}