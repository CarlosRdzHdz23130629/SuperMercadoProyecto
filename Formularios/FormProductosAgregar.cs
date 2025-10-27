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
    public partial class FormProductosAgregar : Form
    {
        int id = -1;
        public FormProductosAgregar()
        {
            InitializeComponent();
        }
        public FormProductosAgregar(int id)
        {
            InitializeComponent();
            this.id = id;

            Datos data = new Datos();
            DataSet ds = data.getAllData("SELECT * FROM productos WHERE id = " + id);

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtIdProveedor.Text = ds.Tables[0].Rows[0]["id_proveedor"].ToString();
                txtCodigo.Text = ds.Tables[0].Rows[0]["codigo"].ToString();
                txtLink.Text = ds.Tables[0].Rows[0]["imagen"].ToString();
                txtNombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                txtMarca.Text = ds.Tables[0].Rows[0]["marca"].ToString();
                txtTipo.Text = ds.Tables[0].Rows[0]["tipo"].ToString();
                txtGrupo.Text = ds.Tables[0].Rows[0]["grupo"].ToString();
                txtPeso.Text = ds.Tables[0].Rows[0]["peso"].ToString();
                txtPrecioUnidad.Text = ds.Tables[0].Rows[0]["precio_unidad"].ToString();
                txtStock.Text = ds.Tables[0].Rows[0]["stock"].ToString();

                // Si tienes un PictureBox para la imagen, puedes mostrarla:
                if (!string.IsNullOrEmpty(txtLink.Text) && System.IO.File.Exists(txtLink.Text))
                {
                    //picProducto.Image = Image.FromFile(txtLink.Text);
                }
            }
            else
            {
                MessageBox.Show("No se encontraron datos para el producto con ID: " + id);
            }

            btnAgregar.Text = "Actualizar";

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new Npgsql.NpgsqlConnection(
                    "Host=localhost;Username=admin;Password=carlos2313;Database=supermercado"))
                {
                    connection.Open();

                    // Si id == -1 --> INSERTAR
                    if (id == -1)
                    {
                        string query = "INSERT INTO public.\"productos\" " +
                                       "(id_proveedor, codigo, imagen, nombre, marca, tipo, grupo, peso, precio_unidad, stock) " +
                                       "VALUES (@id_proveedor, @codigo, @imagen, @nombre, @marca, @tipo, @grupo, @peso, @precio_unidad, @stock)";

                        using (var cmd = new Npgsql.NpgsqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@id_proveedor", Convert.ToInt32(txtIdProveedor.Text));
                            cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                            cmd.Parameters.AddWithValue("@imagen", txtLink.Text);
                            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                            cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
                            cmd.Parameters.AddWithValue("@tipo", txtTipo.Text);
                            cmd.Parameters.AddWithValue("@grupo", txtGrupo.Text);
                            cmd.Parameters.AddWithValue("@peso", Convert.ToDecimal(txtPeso.Text));
                            cmd.Parameters.AddWithValue("@precio_unidad", Convert.ToDecimal(txtPrecioUnidad.Text));
                            cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(txtStock.Text));

                            int filas = cmd.ExecuteNonQuery();

                            if (filas > 0)
                                MessageBox.Show("Producto agregado correctamente", "Sistema",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("No se pudo agregar el producto", "Sistema",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        // Si id != -1 --> ACTUALIZAR
                        string query = "UPDATE public.\"productos\" SET " +
                                       "id_proveedor=@id_proveedor, codigo=@codigo, imagen=@imagen, nombre=@nombre, marca=@marca, " +
                                       "tipo=@tipo, grupo=@grupo, peso=@peso, precio_unidad=@precio_unidad, stock=@stock " +
                                       "WHERE id=@id"; // ⚠️ Cambia 'id' por tu columna PK si es diferente

                        using (var cmd = new Npgsql.NpgsqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@id_proveedor", Convert.ToInt32(txtIdProveedor.Text));
                            cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                            cmd.Parameters.AddWithValue("@imagen", txtLink.Text);
                            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                            cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
                            cmd.Parameters.AddWithValue("@tipo", txtTipo.Text);
                            cmd.Parameters.AddWithValue("@grupo", txtGrupo.Text);
                            cmd.Parameters.AddWithValue("@peso", Convert.ToDecimal(txtPeso.Text));
                            cmd.Parameters.AddWithValue("@precio_unidad", Convert.ToDecimal(txtPrecioUnidad.Text));
                            cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(txtStock.Text));
                            cmd.Parameters.AddWithValue("@id", id);

                            int filas = cmd.ExecuteNonQuery();

                            if (filas > 0)
                                MessageBox.Show("Producto actualizado correctamente", "Sistema",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("No se pudo actualizar el producto", "Sistema",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar producto: " + ex.Message,
                "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
