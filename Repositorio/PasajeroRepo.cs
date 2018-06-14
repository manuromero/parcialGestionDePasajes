using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Repositorio
{
    public class PasajeroRepo
    {
        string cnn = ConfigurationManager.ConnectionStrings["ConeccionASQL"].ConnectionString;
        public void GuardarPasajero(Pasajero pasajero)
        {
            SqlConnection conn = new SqlConnection(cnn);

            string sql = "INSERT INTO Pasajero (nombre,apellido,edad,fechaNacimiento) VALUES (@val1,@val2,@val3,@val4)";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@val1", pasajero.Nombre);
                cmd.Parameters.AddWithValue("@val2", pasajero.Apellido);
                cmd.Parameters.AddWithValue("@val3", pasajero.Edad);
                cmd.Parameters.AddWithValue("@val4", pasajero.FechaNacimiento);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "error ";
                msg += ex.Message;
                throw new Exception(msg);
            }
            finally
            {
                conn.Close();

            }
        }

        public DataTable ListarPasajero()
        {
            DataTable dataTable = new DataTable();
            string sql = "select * from Pasajero";
            SqlConnection conn = new SqlConnection(cnn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
            dAdapter.Fill(dataTable);
            conn.Close();
            return dataTable;
        }

        public DataTable ListarPasajeroID(int idPasajero)
        {
            DataTable dataTable = new DataTable();
            SqlConnection conn = new SqlConnection(cnn);
            string sql = "select * from Pasajero where idPasajero=@val1";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@val1", idPasajero);
            SqlDataAdapter dA = new SqlDataAdapter(cmd);
            dA.Fill(dataTable);
            conn.Close();
            return dataTable;
        }


        public void UpdatePasajerp(Pasajero pasajero, int idPasajero)
        {
            SqlConnection conn = new SqlConnection(cnn);
            string sql = "update Pasajero set nombre=@val1, apellido=@val2, edad=@val3, fechaNacimiento=@val4 where idPasajero=@val5";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@val1", pasajero.Nombre);
                cmd.Parameters.AddWithValue("@val2", pasajero.Apellido);
                cmd.Parameters.AddWithValue("@val3", pasajero.Edad);
                cmd.Parameters.AddWithValue("@val4", pasajero.FechaNacimiento);
                cmd.Parameters.AddWithValue("@val5", idPasajero.ToString());
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "error";
                msg += ex.Message;
                throw new Exception(msg);
            }
            finally
            {
                conn.Close();
            }
        }


    }
}
