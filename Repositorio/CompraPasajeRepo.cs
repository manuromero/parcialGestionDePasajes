using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Repositorio
{
    public class CompraPasajeRepo
    {
        string cnn = ConfigurationManager.ConnectionStrings["ConeccionASQL"].ConnectionString;


        public void GuardarCompra(CompraPasaje compra)
        {
            SqlConnection conn = new SqlConnection(cnn);

            string sql = "INSERT INTO ventas (idPasajero,origen,destino,fechaViaje,idLineaAerea) VALUES (@val1,@val2,@val3,@val4,@val5)";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@val1", compra.IdPasajero);
                cmd.Parameters.AddWithValue("@val2", compra.Origen);
                cmd.Parameters.AddWithValue("@val3", compra.Destino);
                cmd.Parameters.AddWithValue("@val4", compra.FechaViaje);
                cmd.Parameters.AddWithValue("@val5", compra.IdLineaAerea);
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

        public DataTable ListarCompras()
        {
            DataTable dataTable = new DataTable();
            string sql = ("SELECT Pasajero.nombre, Pasajero.Apellido,CompraPasaje.origen,CompraPasaje.Destino,CompraPasaje.fechaViaje,LineasAereas.nombre from Pasajero join CompraPasaje on CompraPasaje.idPasajero=Pasajero.idPasajero join LineasAereas on CompraPasaje.idLineaAerea=LineasAereas.idLineaAerea;");
            SqlConnection conn = new SqlConnection(cnn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
            dAdapter.Fill(dataTable);
            conn.Close();
            return dataTable;
        }
    }
}
