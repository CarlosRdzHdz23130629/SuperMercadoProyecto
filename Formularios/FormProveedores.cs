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
    public partial class FormProveedores : Form
    {
        Datos datos = new Datos();
        public FormProveedores()
        {
            InitializeComponent();
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            DataSet ds = datos.getAllData("SELECT * FROM proveedores");

            if (ds != null)
            {
                dgvProveedores.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Error al cargar datos. ", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mostrarProveedores();
        }

        private void btnAgregarProveedores_Click(object sender, EventArgs e)
        {
            FormProveedoresAgregar frm = new FormProveedoresAgregar();
            frm.Show();
            mostrarProveedores();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string r = dgvProveedores[0, dgvProveedores.CurrentCell.RowIndex].Value.ToString();
            FormProveedoresAgregar frm = new FormProveedoresAgregar(Convert.ToInt32(r));
            frm.ShowDialog();
            mostrarProveedores();
        }

        private void eLiminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un proveedor para eliminar.", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idProveedor = dgvProveedores.CurrentRow.Cells[0].Value.ToString();

            var confirmacion = MessageBox.Show("¿Deseas eliminar el proveedor?", "Sistema",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    using (var connection = new Npgsql.NpgsqlConnection(
                        "Host=localhost;Username=admin;Password=carlos2313;Database=supermercado"))
                    {
                        connection.Open();

                        string query = "DELETE FROM proveedores WHERE id=@id";

                        using (var cmd = new Npgsql.NpgsqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(idProveedor));
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Proveedor eliminado correctamente.", "Sistema",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Refresca la tabla
                    mostrarProveedores();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar proveedor: " + ex.Message, "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void mostrarProveedores()
        {
            try
            {
                Datos datos = new Datos();
                DataSet ds = datos.getAllData(
                    "SELECT id AS \"Id\", " +
                    "empresa AS \"Empresa\", " +
                    "tipo_producto AS \"Tipo de Producto\", " +
                    "direccion AS \"Dirección\", " +
                    "nro_tel_princ AS \"Teléfono Principal\", " +
                    "nro_tel_sec AS \"Teléfono Secundario\", " +
                    "email AS \"Email\" " +
                    "FROM proveedores ORDER BY id"
                );

                if (ds != null && ds.Tables.Count > 0)
                {
                    dgvProveedores.DataSource = ds.Tables[0];

                    // Si no deseas mostrar el Id visualmente:
                    // dgvProveedores.Columns["Id"].Visible = false;
                }
                else
                {
                    MessageBox.Show("No se encontraron proveedores.", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message, "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
