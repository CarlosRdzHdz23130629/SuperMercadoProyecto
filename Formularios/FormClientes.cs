using SuperMercadoProyecto.Data;
using SuperMercadoProyecto.Formularios;
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
    public partial class FormClientes : Form
    {
        Datos datos = new Datos();
        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            DataSet ds = datos.getAllData("SELECT * FROM clientes");

            if (ds != null)
            {
                dgvClientes.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Error al cargar datos. ", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void mostrarClientes()
        {
            DataSet ds = datos.getAllData(
    "SELECT id AS \"Id\", " +
    "nombre AS \"Nombre\", " +
    "apellido AS \"Apellido\", " +
    "tipo_doc AS \"Tipo Documento\", " +
    "nro_doc AS \"Documento\", " +
    "nro_tel_princ AS \"Teléfono Principal\", " +
    "email AS \"Email\" " +
    "FROM clientes ORDER BY id");
            if (ds != null)
            {
                dgvClientes.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Error al cargar datos. ", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string r = dgvClientes[0, dgvClientes.CurrentCell.RowIndex].Value.ToString();
            FormClientesAgregar frm = new FormClientesAgregar(Convert.ToInt32(r));
            frm.ShowDialog();
        }

        private void btnAgregarClien_Click(object sender, EventArgs e)
        {

            FormClientesAgregar frm = new FormClientesAgregar();
            frm.Show();
        }

        private void FormClientes_Activated(object sender, EventArgs e)
        {
            mostrarClientes();
        }

        private void FormClientes_Click(object sender, EventArgs e)
        {

        }

        private void toolStripEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente para eliminar.", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idCliente = dgvClientes[0, dgvClientes.CurrentCell.RowIndex].Value.ToString();

            var confirmacion = MessageBox.Show("¿Deseas eliminar el cliente?", "Sistema",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    using (var connection = new Npgsql.NpgsqlConnection(
                        "Host=localhost;Username=admin;Password=carlos2313;Database=supermercado"))
                    {
                        connection.Open();

                        string query = "DELETE FROM clientes WHERE id=@id";

                        using (var cmd = new Npgsql.NpgsqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(idCliente));
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Cliente eliminado correctamente.", "Sistema",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    mostrarClientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmsDatos_Click(object sender, EventArgs e)
        {

        }

        private void dgvClientes_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

