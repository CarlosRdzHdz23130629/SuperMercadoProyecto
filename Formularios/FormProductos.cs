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

    public partial class FormProductos : Form
    {
        Datos datos = new Datos();
        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            DataSet ds = datos.getAllData("SELECT id,id_proveedor,codigo,nombre,marca,tipo,grupo,peso,precio_unidad,stock, imagen FROM productos");

            if (ds != null)
            {
                dgvProductos.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Error al cargar datos. ", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void empledadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmpleados frm = new FormEmpleados();
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes frm = new FormClientes();  // ← creas una instancia del formulario
            frm.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVentas frm = new FormVentas();  // ← creas una instancia del formulario
            frm.Show();
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

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            FormProductosAgregar frm = new FormProductosAgregar();
            frm.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string r = dgvProductos[0, dgvProductos.CurrentCell.RowIndex].Value.ToString();
            FormProductosAgregar frm = new FormProductosAgregar(Convert.ToInt32(r));
            frm.ShowDialog();

            mostrarProductos();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto para eliminar.", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idProducto = dgvProductos[0, dgvProductos.CurrentCell.RowIndex].Value.ToString();

            var confirmacion = MessageBox.Show("¿Deseas eliminar el producto?", "Sistema",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    using (var connection = new Npgsql.NpgsqlConnection(
                        "Host=localhost;Username=admin;Password=carlos2313;Database=supermercado"))
                    {
                        connection.Open();

                        string query = "DELETE FROM productos WHERE id=@id";
                        // ⚠️ Cambia 'id' si tu columna primaria se llama diferente (por ejemplo, id_producto)

                        using (var cmd = new Npgsql.NpgsqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(idProducto));
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Producto eliminado correctamente.", "Sistema",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Actualiza el DataGridView
                    mostrarProductos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar producto: " + ex.Message, "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void mostrarProductos()
        {
            DataSet ds = datos.getAllData(
                "SELECT " +
                "id AS \"ID\", " +
                "id_proveedor AS \"ID Proveedor\", " +
                "codigo AS \"Código\", " +
                "nombre AS \"Nombre\", " +
                "marca AS \"Marca\", " +
                "tipo AS \"Tipo\", " +
                "grupo AS \"Grupo\", " +
                "peso AS \"Peso\", " +
                "precio_unidad AS \"Precio por Unidad\", " +
                "stock AS \"Stock\" " +
                "FROM productos ORDER BY id");

            if (ds != null)
            {
                dgvProductos.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Error al cargar los datos de productos.", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void agregarAlCarritoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProveedores frm = new FormProveedores();  // ← creas una instancia del formulario
            frm.Show();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string urlImagen = dgvProductos.Rows[e.RowIndex].Cells["imagen"].Value.ToString();

                if (!string.IsNullOrEmpty(urlImagen))
                {
                    try
                    {
                        pictureBoxProducto.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBoxProducto.Load(urlImagen); // Puede ser URL o ruta local
                    }
                    catch
                    {
                        pictureBoxProducto.Image = null;
                        MessageBox.Show("No se pudo cargar la imagen del producto.");
                    }
                }
                else
                {
                    pictureBoxProducto.Image = null;
                }
            }
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormVentas frm = new FormVentas();  // ← creas una instancia del formulario
            frm.Show();
        }

        private void comprasDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormComprasClientes frm = new FormComprasClientes();  // ← creas una instancia del formulario
            frm.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFacturas frm = new FormFacturas();  // ← creas una instancia del formulario
            frm.Show();
        }

        private void detallesDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFacturasDetalles frm = new FormFacturasDetalles();  // ← creas una instancia del formulario
            frm.Show();

        }

        private void ventasDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVentasProductos frm = new FormVentasProductos();  // ← creas una instancia del formulario
            frm.Show();
        }
    }
}
