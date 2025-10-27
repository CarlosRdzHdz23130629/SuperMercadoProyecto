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
    public partial class FormVentasProductos : Form
    {
        Datos datos = new Datos();
        public FormVentasProductos()
        {
            InitializeComponent();
        }

        private void FormVentasProductos_Load(object sender, EventArgs e)
        {
            DataSet ds = datos.getAllData("SELECT * FROM ventas_productos");

            if (ds != null)
            {
                dgvVentasProductos.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Error al cargar datos. ", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
