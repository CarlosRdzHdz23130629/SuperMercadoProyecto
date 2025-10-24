using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMercadoProyecto.Data
{
    internal class Datos
    {
        private string connectionString =
            "Host=localhost;Username=admin;Password=carlos2313;" +
            "Database=supermercado";
        private NpgsqlConnection GetConnection()
        {
            try
            {
                NpgsqlConnection connection =
                    new NpgsqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al " +
                    "conectar a la base de datos: " + ex.Message);
                return null;
            }
        }

        public DataSet getAllData(string command)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    if (connection == null)
                    {
                        MessageBox.Show("No se pudo abrir la conexión con PostgreSQL");
                        return null;
                    }

                    DataSet dataSet = new DataSet();
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(command, connection);
                    da.Fill(dataSet);

                    return dataSet;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos: " + ex.Message);
                return null;
            }
        }



        public bool ExecuteQuery(string query)
        {
            using (var connection = GetConnection())
            {
                if (connection == null)
                    return false;

                try
                {
                    using (var comando = new NpgsqlCommand(query, connection))
                    {
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al ejecutar comando: " + ex.Message);
                    return false;
                }
            }
        }



        public bool TestConnection()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    if (connection != null && connection.State ==
                        System.Data.ConnectionState.Open)
                    {
                        Console.WriteLine("Conexión exitosa a la base de datos.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("No se pudo establecer la conexión.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al probar la conexión: " + ex.Message);
                return false;
            }
        }
    }
}
