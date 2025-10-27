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
    public partial class FormProveedoresAgregar : Form
    {
        int id = -1;
        public FormProveedoresAgregar()
        {
            InitializeComponent();
        }
        public FormProveedoresAgregar(int id)
        {
            InitializeComponent();
            this.id = id;

            Datos data = new Datos();
            DataSet ds = data.getAllData("SELECT * FROM proveedores WHERE id=" + id);

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtEmpresa.Text = ds.Tables[0].Rows[0]["empresa"].ToString();
                txtTipoProducto.Text = ds.Tables[0].Rows[0]["tipo_producto"].ToString();
                txtDireccion.Text = ds.Tables[0].Rows[0]["direccion"].ToString();
                txtTelPrinc.Text = ds.Tables[0].Rows[0]["nro_tel_princ"].ToString();
                txtTelSec.Text = ds.Tables[0].Rows[0]["nro_tel_sec"].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();
            }
            else
            {
                MessageBox.Show("No se encontraron datos para el proveedor con ID: " + id);
            }

            btnAgregar.Text = "Actualizar";
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new Npgsql.NpgsqlConnection(
                    "Host=localhost;Username=admin;Password=carlos2313;Database=supermercado"))
                {
                    connection.Open();

                    // Si id == -1 --> INSERT
                    if (id == -1)
                    {
                        string query = "INSERT INTO proveedores" +
                                       "(empresa, tipo_producto, direccion, nro_tel_princ, nro_tel_sec, email) " +
                                       "VALUES (@empresa, @tipo_producto, @direccion, @nro_tel_princ, @nro_tel_sec, @email)";

                        using (var cmd = new Npgsql.NpgsqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@empresa", txtEmpresa.Text);
                            cmd.Parameters.AddWithValue("@tipo_producto", txtTipoProducto.Text);
                            cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                            cmd.Parameters.AddWithValue("@nro_tel_princ", txtTelPrinc.Text);
                            cmd.Parameters.AddWithValue("@nro_tel_sec", txtTelSec.Text);
                            cmd.Parameters.AddWithValue("@email", txtEmail.Text);

                            int filas = cmd.ExecuteNonQuery();

                            
                            if (filas > 0)
                                MessageBox.Show("Proveedor agregado correctamente", "Sistema",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("No se pudo agregar el proveedor", "Sistema",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        // Si id != -1 --> UPDATE
                        string query = "UPDATE public.\"proveedores\" SET " +
                                       "empresa=@empresa, tipo_producto=@tipo_producto, direccion=@direccion, " +
                                       "nro_tel_princ=@nro_tel_princ, nro_tel_sec=@nro_tel_sec, email=@email " +
                                       "WHERE id=@id";

                        using (var cmd = new Npgsql.NpgsqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@empresa", txtEmpresa.Text);
                            cmd.Parameters.AddWithValue("@tipo_producto", txtTipoProducto.Text);
                            cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                            cmd.Parameters.AddWithValue("@nro_tel_princ", txtTelPrinc.Text);
                            cmd.Parameters.AddWithValue("@nro_tel_sec", txtTelSec.Text);
                            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                            cmd.Parameters.AddWithValue("@id", id);

                            int filas = cmd.ExecuteNonQuery();

                            if (filas > 0)
                                MessageBox.Show("Proveedor actualizado correctamente", "Sistema",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("No se pudo actualizar el proveedor", "Sistema",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar proveedor: " + ex.Message,
                "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
