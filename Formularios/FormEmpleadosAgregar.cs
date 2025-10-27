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
    public partial class FormEmpleadosAgregar : Form
    {
        int id = -1;
        public FormEmpleadosAgregar()
        {
            InitializeComponent();
        }
        public FormEmpleadosAgregar(int id)
        {
            InitializeComponent();
            this.id = id;

            Datos data = new Datos();
            DataSet ds = data.getAllData("SELECT * FROM empleados WHERE id = " + id);

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtNombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                txtApellido.Text = ds.Tables[0].Rows[0]["apellido"].ToString();
                txtEdad.Text = ds.Tables[0].Rows[0]["edad"].ToString();
                txtFecha.Text = ds.Tables[0].Rows[0]["fecha_nac"].ToString();
                txtDocumento.Text = ds.Tables[0].Rows[0]["tipo_doc"].ToString();
                txtNoDoc.Text = ds.Tables[0].Rows[0]["nro_doc"].ToString();
                txtCuil.Text = ds.Tables[0].Rows[0]["cuil"].ToString();
                txtDireccion.Text = ds.Tables[0].Rows[0]["direccion"].ToString();
                txtTelPrinc.Text = ds.Tables[0].Rows[0]["nro_tel_princ"].ToString();
                txtTelSec.Text = ds.Tables[0].Rows[0]["nro_tel_sec"].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();
                txtCargo.Text = ds.Tables[0].Rows[0]["cargo"].ToString();
                txtAntiguedad.Text = ds.Tables[0].Rows[0]["antiguedad"].ToString();
                txtFechaIngr.Text = ds.Tables[0].Rows[0]["fecha_ingreso"].ToString();
                txtSalario.Text = ds.Tables[0].Rows[0]["salario_anual"].ToString();

                btnAgregar.Text = "Actualizar";
            }
            else
            {
                MessageBox.Show("No se encontraron datos para el empleado con ID: " + id,
                                "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

                    // Si id == -1 --> INSERTAR
                    if (id == -1)
                    {
                        string query = "INSERT INTO public.\"empleados\" " +
                                       "(nombre, apellido, edad, fecha_nac, tipo_doc, nro_doc, cuil, direccion, " +
                                       "nro_tel_princ, nro_tel_sec, email, cargo, antiguedad, fecha_ingreso, salario_anual) " +
                                       "VALUES (@nombre, @apellido, @edad, @fecha_nac, @tipo_doc, @nro_doc, @cuil, @direccion, " +
                                       "@nro_tel_princ, @nro_tel_sec, @email, @cargo, @antiguedad, @fecha_ingreso, @salario_anual)";

                        using (var cmd = new Npgsql.NpgsqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                            cmd.Parameters.AddWithValue("@apellido", txtApellido.Text);
                            cmd.Parameters.AddWithValue("@edad", txtEdad.Text);
                            cmd.Parameters.AddWithValue("@fecha_nac", txtFecha.Text);
                            cmd.Parameters.AddWithValue("@tipo_doc", txtDocumento.Text);
                            cmd.Parameters.AddWithValue("@nro_doc", txtNoDoc.Text);
                            cmd.Parameters.AddWithValue("@cuil", txtCuil.Text);
                            cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                            cmd.Parameters.AddWithValue("@nro_tel_princ", txtTelPrinc.Text);
                            cmd.Parameters.AddWithValue("@nro_tel_sec", txtTelSec.Text);
                            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                            cmd.Parameters.AddWithValue("@cargo", txtCargo.Text);
                            cmd.Parameters.AddWithValue("@antiguedad",txtAntiguedad.Text);
                            cmd.Parameters.AddWithValue("@fecha_ingreso", txtFechaIngr.Text);
                            cmd.Parameters.AddWithValue("@salario_anual", txtSalario.Text);

                            int filas = cmd.ExecuteNonQuery();

                            if (filas > 0)
                                MessageBox.Show("Empleado agregado correctamente", "Sistema",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("No se pudo agregar el empleado", "Sistema",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        // Si id != -1 --> ACTUALIZAR
                        string query = "UPDATE public.\"empleados\" SET " +
                                       "nombre=@nombre, apellido=@apellido, edad=@edad, fecha_nac=@fecha_nac, tipo_doc=@tipo_doc, " +
                                       "nro_doc=@nro_doc, cuil=@cuil, direccion=@direccion, nro_tel_princ=@nro_tel_princ, nro_tel_sec=@nro_tel_sec, " +
                                       "email=@email, cargo=@cargo, antiguedad=@antiguedad, fecha_ingreso=@fecha_ingreso, salario_anual=@salario_anual " +
                                       "WHERE id=@id";

                        using (var cmd = new Npgsql.NpgsqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                            cmd.Parameters.AddWithValue("@apellido", txtApellido.Text);
                            cmd.Parameters.AddWithValue("@edad", txtEdad.Text);
                            cmd.Parameters.AddWithValue("@fecha_nac", txtFecha.Text);
                            cmd.Parameters.AddWithValue("@tipo_doc", txtDocumento.Text);
                            cmd.Parameters.AddWithValue("@nro_doc", txtNoDoc.Text);
                            cmd.Parameters.AddWithValue("@cuil", txtCuil.Text);
                            cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                            cmd.Parameters.AddWithValue("@nro_tel_princ", txtTelPrinc.Text);
                            cmd.Parameters.AddWithValue("@nro_tel_sec", txtTelSec.Text);
                            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                            cmd.Parameters.AddWithValue("@cargo", txtCargo.Text);
                            cmd.Parameters.AddWithValue("@antiguedad",txtAntiguedad.Text);
                            cmd.Parameters.AddWithValue("@fecha_ingreso", txtFechaIngr.Text);
                            cmd.Parameters.AddWithValue("@salario_anual",txtSalario.Text);
                            cmd.Parameters.AddWithValue("@id", id);

                            int filas = cmd.ExecuteNonQuery();

                            if (filas > 0)
                                MessageBox.Show("Empleado actualizado correctamente", "Sistema",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("No se pudo actualizar el empleado", "Sistema",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar empleado: " + ex.Message,
                "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
