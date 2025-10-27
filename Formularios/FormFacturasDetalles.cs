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

namespace SuperMercadoProyecto.Formularios
{
    public partial class FormFacturasDetalles : Form
    {
        Datos datos = new Datos();
        public FormFacturasDetalles()
        {
            InitializeComponent();
        }

        private void FormFacturasDetalles_Load(object sender, EventArgs e)
        {
            DataSet ds = datos.getAllData("SELECT * FROM facturas_detalles");

            if (ds != null)
            {
                dgvFacturasDetalles.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Error al cargar datos. ", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
