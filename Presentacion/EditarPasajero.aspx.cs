using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class EditarPasajero : System.Web.UI.Page
    {
        PasajeroNego pasajeroNego = new PasajeroNego();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["idPasajero"] != null)
                {
                    int idPasajero = int.Parse(Request.QueryString["idPasajero"]);
                    CargarPasajero(idPasajero);

                }
            }
        }

        protected void BtnModificar_Click(object sender, EventArgs e)
        {
            int idPasajero = int.Parse(LblIdPasajero.Text);
            Pasajero pasajero = new Pasajero();
            pasajero.Nombre = TbxNombre.Text;
            pasajero.Apellido = TbxApellido.Text;
            pasajero.Edad = int.Parse(TbxEdad.Text);
            pasajero.FechaNacimiento = Convert.ToDateTime(tbxFechaNacimiento.Text);
            pasajeroNego.UpdatePasajero(pasajero, idPasajero);
        }

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("/CargaPasajero.aspx");
        }

        public void CargarPasajero(int idPasajero)
        {
            DataTable dataTable = new DataTable();
            dataTable = pasajeroNego.ListarPasajeroId(idPasajero);
            LblIdPasajero.Text = dataTable.Rows[0]["idPasajero"].ToString();
            TbxNombre.Text = dataTable.Rows[0]["nombre"].ToString();
            TbxApellido.Text = dataTable.Rows[0]["apellido"].ToString();
            TbxEdad.Text = dataTable.Rows[0]["edad"].ToString();
            tbxFechaNacimiento.Text = dataTable.Rows[0]["fechaNacimiento"].ToString();
        }
    }
}