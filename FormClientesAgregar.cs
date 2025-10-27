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
    public partial class FormClientesAgregar : Form
    {
        int id = -1;

        public FormClientesAgregar()
        {
            InitializeComponent();
        }
        public FormClientesAgregar(int id)
        {
            InitializeComponent();
            this.id = id;

            Datos data = new Datos();
            DataSet ds = data.getAllData("SELECT * FROM clientes WHERE id=" + id);

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtNombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                txtApellido.Text = ds.Tables[0].Rows[0]["apellido"].ToString();
                txtTipoDoc.Text = ds.Tables[0].Rows[0]["tipo_doc"].ToString();
                txtNoDoc.Text = ds.Tables[0].Rows[0]["nro_doc"].ToString();
                mtbTelPrin.Text = ds.Tables[0].Rows[0]["nro_tel_princ"].ToString();
                mtbTelSec.Text = ds.Tables[0].Rows[0]["nro_tel_sec"].ToString();
                mtbEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();
            }
            else
            {
                MessageBox.Show("No se encontraron datos para el cliente con ID: " + id);
            }

            btnAgregar.Text = "Actualizar";

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
                        string query = "INSERT INTO public.\"clientes\" " +
                                       "(nombre, apellido, tipo_doc, nro_doc, nro_tel_princ, nro_tel_sec, email) " +
                                       "VALUES (@nombre, @apellido, @tipo_doc, @nro_doc, @nro_tel_princ, @nro_tel_sec, @email)";

                        using (var cmd = new Npgsql.NpgsqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                            cmd.Parameters.AddWithValue("@apellido", txtApellido.Text);
                            cmd.Parameters.AddWithValue("@tipo_doc", txtTipoDoc.Text);
                            cmd.Parameters.AddWithValue("@nro_doc", txtNoDoc.Text);
                            cmd.Parameters.AddWithValue("@nro_tel_princ", mtbTelPrin.Text);
                            cmd.Parameters.AddWithValue("@nro_tel_sec", mtbTelSec.Text);
                            cmd.Parameters.AddWithValue("@email", mtbEmail.Text);

                            int filas = cmd.ExecuteNonQuery();

                            if (filas > 0)
                                MessageBox.Show("Cliente agregado correctamente", "Sistema",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("No se pudo agregar el cliente", "Sistema",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        // Si id != -1 --> UPDATE
                        string query = "UPDATE public.\"clientes\" SET " +
                                       "nombre=@nombre, apellido=@apellido, tipo_doc=@tipo_doc, nro_doc=@nro_doc, " +
                                       "nro_tel_princ=@nro_tel_princ, nro_tel_sec=@nro_tel_sec, email=@email " +
                                       "WHERE id=@id";

                        using (var cmd = new Npgsql.NpgsqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                            cmd.Parameters.AddWithValue("@apellido", txtApellido.Text);
                            cmd.Parameters.AddWithValue("@tipo_doc", txtTipoDoc.Text);
                            cmd.Parameters.AddWithValue("@nro_doc", txtNoDoc.Text);
                            cmd.Parameters.AddWithValue("@nro_tel_princ", mtbTelPrin.Text);
                            cmd.Parameters.AddWithValue("@nro_tel_sec", mtbTelSec.Text);
                            cmd.Parameters.AddWithValue("@email", mtbEmail.Text);
                            cmd.Parameters.AddWithValue("@id", id);

                            int filas = cmd.ExecuteNonQuery();

                            if (filas > 0)
                                MessageBox.Show("Cliente actualizado correctamente", "Sistema",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("No se pudo actualizar el cliente", "Sistema",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cliente: " + ex.Message,
                "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormClientesAgregar_Load(object sender, EventArgs e)
        {

        }
    }
}
