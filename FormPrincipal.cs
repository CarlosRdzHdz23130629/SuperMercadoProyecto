using SuperMercadoProyecto.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMercadoProyecto
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
       
        private void btnConectar_Click(object sender, EventArgs e)
        {
            Datos data = new Datos();
            bool conexion = data.TestConnection();

            if (conexion)
                MessageBox.Show("Conectado");
            else
                MessageBox.Show("No Conectado");

        }
    }
}
