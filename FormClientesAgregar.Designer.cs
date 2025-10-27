namespace SuperMercadoProyecto
{
    partial class FormClientesAgregar
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtTipoDoc = new TextBox();
            txtNoDoc = new TextBox();
            mtbTelPrin = new MaskedTextBox();
            mtbTelSec = new MaskedTextBox();
            mtbEmail = new MaskedTextBox();
            btnAgregar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 18);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 80);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 142);
            label3.Name = "label3";
            label3.Size = new Size(146, 25);
            label3.TabIndex = 2;
            label3.Text = "Tipo Documento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 204);
            label4.Name = "label4";
            label4.Size = new Size(139, 25);
            label4.TabIndex = 3;
            label4.Text = "No. Documento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 266);
            label5.Name = "label5";
            label5.Size = new Size(103, 25);
            label5.TabIndex = 4;
            label5.Text = "Tel Principal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 328);
            label6.Name = "label6";
            label6.Size = new Size(125, 25);
            label6.TabIndex = 5;
            label6.Text = "Tel Secundario";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 390);
            label7.Name = "label7";
            label7.Size = new Size(54, 25);
            label7.TabIndex = 6;
            label7.Text = "Email";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(28, 46);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(249, 31);
            txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(28, 108);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(249, 31);
            txtApellido.TabIndex = 8;
            // 
            // txtTipoDoc
            // 
            txtTipoDoc.Location = new Point(28, 170);
            txtTipoDoc.Name = "txtTipoDoc";
            txtTipoDoc.Size = new Size(249, 31);
            txtTipoDoc.TabIndex = 9;
            // 
            // txtNoDoc
            // 
            txtNoDoc.Location = new Point(28, 232);
            txtNoDoc.Name = "txtNoDoc";
            txtNoDoc.Size = new Size(249, 31);
            txtNoDoc.TabIndex = 10;
            // 
            // mtbTelPrin
            // 
            mtbTelPrin.Location = new Point(28, 294);
            mtbTelPrin.Mask = "(999)000-0000";
            mtbTelPrin.Name = "mtbTelPrin";
            mtbTelPrin.Size = new Size(150, 31);
            mtbTelPrin.TabIndex = 11;
            // 
            // mtbTelSec
            // 
            mtbTelSec.Location = new Point(28, 356);
            mtbTelSec.Mask = "(999)000-0000";
            mtbTelSec.Name = "mtbTelSec";
            mtbTelSec.Size = new Size(150, 31);
            mtbTelSec.TabIndex = 12;
            // 
            // mtbEmail
            // 
            mtbEmail.Location = new Point(28, 418);
            mtbEmail.Name = "mtbEmail";
            mtbEmail.Size = new Size(249, 31);
            mtbEmail.TabIndex = 13;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(23, 487);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(197, 487);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormClientesAgregar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 539);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(mtbEmail);
            Controls.Add(mtbTelSec);
            Controls.Add(mtbTelPrin);
            Controls.Add(txtNoDoc);
            Controls.Add(txtTipoDoc);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormClientesAgregar";
            Text = "Agregar Clientes";
            Load += FormClientesAgregar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtTipoDoc;
        private TextBox txtNoDoc;
        private MaskedTextBox mtbTelPrin;
        private MaskedTextBox mtbTelSec;
        private MaskedTextBox mtbEmail;
        private Button btnAgregar;
        private Button btnCancelar;
    }
}