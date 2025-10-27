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
    public partial class FormEmpleados : Form
    {
        Datos datos = new Datos();
        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            DataSet ds = datos.getAllData("SELECT * FROM empleados");

            if (ds != null)
            {
                dgvEmpleados.DataSource = ds.Tables[0];
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

        private void btnAgregarEmpledos_Click(object sender, EventArgs e)
        {
            FormEmpleadosAgregar frm = new FormEmpleadosAgregar();
            frm.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string r = dgvEmpleados[0, dgvEmpleados.CurrentCell.RowIndex].Value.ToString();
            FormEmpleadosAgregar frm = new FormEmpleadosAgregar(Convert.ToInt32(r));
            frm.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente para eliminar.", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idCliente = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();

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

                        string query = "DELETE FROM empleados WHERE id=@id";

                        using (var cmd = new Npgsql.NpgsqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(idCliente));
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Cliente eliminado correctamente.", "Sistema",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Refresca la tabla
                    mostrarEmpleados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void mostrarEmpleados()
        {
            try
            {
                Datos datos = new Datos();
                DataSet ds = datos.getAllData(
                    "SELECT id AS \"Id\", " +
                    "nombre AS \"Nombre\", " +
                    "apellido AS \"Apellido\", " +
                    "edad AS \"Edad\", " +
                    "fecha_nac AS \"Fecha de Nacimiento\", " +
                    "tipo_doc AS \"Tipo de Documento\", " +
                    "nro_doc AS \"Número de Documento\", " +
                    "cuil AS \"CUIL\", " +
                    "direccion AS \"Dirección\", " +
                    "telefono_principal AS \"Teléfono Principal\", " +
                    "telefono_secundario AS \"Teléfono Secundario\", " +
                    "email AS \"Email\", " +
                    "cargo AS \"Cargo\", " +
                    "antiguedad AS \"Antigüedad\", " +
                    "fecha_ingreso AS \"Fecha de Ingreso\", " +
                    "salario_anual AS \"Salario Anual\" " +
                    "FROM empleados ORDER BY id"
                );

                if (ds != null && ds.Tables.Count > 0)
                {
                    dgvEmpleados.DataSource = ds.Tables[0];

                    // Si NO quieres mostrar visualmente el Id:
                    // dgvEmpleados.Columns["Id"].Visible = false;
                }
                else
                {
                    MessageBox.Show("No se encontraron empleados.", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message, "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }

}
