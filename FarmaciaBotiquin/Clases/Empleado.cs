using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FarmaciaBotiquin.Clases
{
    class Empleado
    {
        Conexion conexion = new Conexion();
        public void MostrarEmpleados(DataGridView dataGrid)
        {
            try
            {
                conexion.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Sp_Empleados", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlCommand.Parameters.AddWithValue("@accion", "mostrar");
                using (sqlDataAdapter)
                {
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    dataGrid.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.sqlConnection.Close();
            }
        }
        public void BuscarEmpleados(DataGridView dataGrid, string valorBuscado)
        {

            try
            {
                conexion.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Sp_Empleados", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlCommand.Parameters.AddWithValue("@BuscarEmpleado", valorBuscado);
                sqlCommand.Parameters.AddWithValue("@accion", "buscar");

                using (sqlDataAdapter)
                {
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    dataGrid.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.sqlConnection.Close();
            }
        }

    }
}
