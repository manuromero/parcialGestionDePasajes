using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class AltaPasajero : System.Web.UI.Page
    {
        PasajeroNego pasajeroNego = new PasajeroNego();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            GuardarPasajero();
        }

        protected void BtnListar_Click(object sender, EventArgs e)
        {
            ListarPasajeros();
        }

        protected void BtnEditar_Click(object sender, EventArgs e)
        {
            Button btnSelect = (sender as Button);
            //string commandName = btnSelect.CommandName;
            string commandArgument = btnSelect.CommandArgument;
            GridViewRow row = (btnSelect.NamingContainer as GridViewRow);
            int rowIndex = row.RowIndex;
            //LblId.Text = GdvAutos.Rows[rowIndex].Cells[0].Text;
            //int idAuto = Convert.ToInt32(GdvAutos.Rows[rowIndex].Cells[4].Text);
            Response.Redirect("~/EditarPasajero.aspx?idPasajero=" + commandArgument);
        }

        protected void BtnComprar_Click(object sender, EventArgs e)
        {
            Button btnSelect = (sender as Button);
            //string commandName = btnSelect.CommandName;
            string commandArgument = btnSelect.CommandArgument;
            GridViewRow row = (btnSelect.NamingContainer as GridViewRow);
            int rowIndex = row.RowIndex;
            //LblId.Text = GdvAutos.Rows[rowIndex].Cells[0].Text;
            //int idAuto = Convert.ToInt32(GdvAutos.Rows[rowIndex].Cells[4].Text);
            Response.Redirect("~/ComprarPasaje.aspx?iPasajero=" + commandArgument);
        }

        public void GuardarPasajero()
        {
            Pasajero pasajero=new Pasajero();
            pasajero.Nombre = TbxNombre.Text;
            pasajero.Apellido = TbxApellido.Text;
            pasajero.Edad = int.Parse(TbxEdad.Text);
            pasajero.FechaNacimiento = Convert.ToDateTime(tbxFechaNacimiento.Text);
            pasajeroNego.GuardarPasajero(pasajero);
        }
        public void ListarPasajeros()
        {
            GdvPasajeros.DataSource = pasajeroNego.ListarPasajero();
            GdvPasajeros.DataBind();
        }
    }
}