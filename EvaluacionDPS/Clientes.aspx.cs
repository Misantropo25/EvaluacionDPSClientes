using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EvaluacionDPS
{
    public partial class Clientes : System.Web.UI.Page
    {
        private static SomeeReference.WebService1SoapClient servicio = new SomeeReference.WebService1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string customerID = txtCustomerId.Text.Trim();
            string companyName = txtCompanyName.Text.Trim();
            string contactName = txtContactName.Text.Trim();
            string contactTitle = txtContactTitle.Text.Trim();
            string address = txtAddress.Text.Trim();
            string city = txtCity.Text.Trim();
            string region = txtRegion.Text.Trim();
            string postalCode = txtPostalCode.Text.Trim();
            string country = txtCountry.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string fax = txtFax.Text.Trim();

            string[] rpta = servicio.AgregarCliente(customerID, companyName, contactName, contactTitle, address, city, region, postalCode, country, phone, fax);

            if (rpta[0] == "0")
            {
                Response.Write("<script>alert('Se agrego cliente');</script>");
                gvCliente.DataSource = servicio.BuscarCliente(customerID, "exacto");
                gvCliente.DataBind();
            }
            else Response.Write("<script>alert('No se agrego cliente');</script>");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string customerID = txtCustomerId.Text.Trim();
            string[] rpta = servicio.EliminarCliente(customerID);
            if (rpta[0] == "0")
            {
                Response.Write("<script>alert('Cliente eliminaod');</script>");
                gvCliente.DataSource = servicio.BuscarCliente(customerID, "exacto");
                gvCliente.DataBind();
            }
            else Response.Write("<script>alert('No se pudo eliminar el cliente');</script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string customerID = txtCustomerId.Text.Trim();
            string companyName = txtCompanyName.Text.Trim();
            string contactName = txtContactName.Text.Trim();
            string contactTitle = txtContactTitle.Text.Trim();
            string address = txtAddress.Text.Trim();
            string city = txtCity.Text.Trim();
            string region = txtRegion.Text.Trim();
            string postalCode = txtPostalCode.Text.Trim();
            string country = txtCountry.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string fax = txtFax.Text.Trim();

            string[] rpta = servicio.ActualizarCliente(customerID, companyName, contactName, contactTitle, address, city, region, postalCode, country, phone, fax);

            if (rpta[0] == "0")
            {
                Response.Write("<script>alert('Se actualizo el cliente');</script>");
                gvCliente.DataSource = servicio.BuscarCliente(customerID, "exacto");
                gvCliente.DataBind();
            }
            else Response.Write("<script>alert('No se actualizo el cliente');</script>");
        }

        protected void btnBuscar_Click(object senser, EventArgs e)
        {
            string texto = buscar.Text.Trim();
            string criterio = ddBuscar.Text.Trim();

            if (criterio == "codCliente")
            {
                criterio = "Exacto";
            }
            else if (criterio == "nombreCompania")
            {
                criterio = "Sensitivo";
            }
            else
            {
                criterio = "Ninguno";
            }

            gvCliente.DataSource = servicio.BuscarCliente(texto, criterio);
            gvCliente.DataBind();

        }

        protected void btnCargar_Click(object senser, EventArgs e)
        {
            try
            {
                string criterio = ddBuscar.Text.Trim();
                string texto = buscar.Text.Trim();
                if (criterio == "codCliente")
                {
                    criterio = "exacto";
                }
                else if (criterio == "nombreCompania")
                {
                    Response.Write("<script>alert('Criterio de codCliente');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Criterio invalido');</script>");
                }

                txtCustomerId.Text = servicio.BuscarCliente(texto, criterio).Tables[0].Rows[0]["CustomerID"].ToString();
                txtCompanyName.Text = servicio.BuscarCliente(texto, criterio).Tables[0].Rows[0]["CompanyName"].ToString();
                txtContactName.Text = servicio.BuscarCliente(texto, criterio).Tables[0].Rows[0]["ContactName"].ToString();
                txtContactTitle.Text = servicio.BuscarCliente(texto, criterio).Tables[0].Rows[0]["ContactTitle"].ToString();
                txtAddress.Text = servicio.BuscarCliente(texto, criterio).Tables[0].Rows[0]["Address"].ToString();
                txtCity.Text = servicio.BuscarCliente(texto, criterio).Tables[0].Rows[0]["City"].ToString();
                txtRegion.Text = servicio.BuscarCliente(texto, criterio).Tables[0].Rows[0]["Region"].ToString();
                txtPostalCode.Text = servicio.BuscarCliente(texto, criterio).Tables[0].Rows[0]["PostalCode"].ToString();
                txtCountry.Text = servicio.BuscarCliente(texto, criterio).Tables[0].Rows[0]["Country"].ToString();
                txtPhone.Text = servicio.BuscarCliente(texto, criterio).Tables[0].Rows[0]["Phone"].ToString();
                txtFax.Text = servicio.BuscarCliente(texto, criterio).Tables[0].Rows[0]["Fax"].ToString();
                
            }
            catch (Exception)
            {
                Response.Write("<script>alert('Datos incorrectos');</script>");
            }
        }

    }
}