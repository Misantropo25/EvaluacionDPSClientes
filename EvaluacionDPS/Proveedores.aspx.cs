using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EvaluacionDPS
{
    public partial class Proveedores : System.Web.UI.Page
    {
        private static SomeeReference.WebService1SoapClient servicio = new SomeeReference.WebService1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
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
            string homePage = txtHomePage.Text.Trim();

            string[] rpta = servicio.AgregarProveedor(companyName, contactName, contactTitle, address, city, region, postalCode, country, phone, fax, homePage);

            if (rpta[0] == "0")
            {
                Response.Write("<script>alert('Se agrego proveedor');</script>");
                gvProveedor.DataSource = servicio.BuscarProveedor(companyName, "sensitivo");
                gvProveedor.DataBind();
            }
            else Response.Write("<script>alert('No se agrego proveedor');</script>");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string supplierId = txtSupplierId.Text.Trim();
            string[] rpta = servicio.EliminarProveedor(Int32.Parse(supplierId));
            if (rpta[0] == "0")
            {
                Response.Write("<script>alert('Proveedor Eliminado');</script>");
                gvProveedor.DataSource = servicio.BuscarProveedor(supplierId, "exacto");
                gvProveedor.DataBind();
            }
            else Response.Write("<script>alert('No se pudo eliminar el proveedor');</script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string supplierID = txtSupplierId.Text.Trim();
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
            string homePage = txtHomePage.Text.Trim();

            string[] rpta = servicio.ActualizarProveedor(Int32.Parse(supplierID), companyName, contactName, contactTitle, address, city, region, postalCode, country, phone, fax, homePage);

            if (rpta[0] == "0")
            {
                Response.Write("<script>alert('Se actualizo el proveedor');</script>");
                gvProveedor.DataSource = servicio.BuscarProveedor(supplierID, "exacto");
                gvProveedor.DataBind();
            }
            else Response.Write("<script>alert('No se actualizo el proveedor');</script>");
        }

        protected void btnBuscar_Click(object senser, EventArgs e)
        {
            string texto = buscar.Text.Trim();
            string criterio = ddBuscar.Text.Trim();

            if (criterio == "codProveedor")
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

            gvProveedor.DataSource = servicio.BuscarProveedor(texto, criterio);
            gvProveedor.DataBind();

        }

        protected void btnCargar_Click(object senser, EventArgs e)
        {
            try
            {
                string criterio = ddBuscar.Text.Trim();
                string texto = buscar.Text.Trim();
                if (criterio == "codProveedor")
                {
                    criterio = "exacto";
                }
                else if (criterio == "nombreCompania")
                {
                    Response.Write("<script>alert('Criterio de codProveedor');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Criterio invalido');</script>");
                }

                txtSupplierId.Text = servicio.BuscarProveedor(texto, criterio).Tables[0].Rows[0]["SupplierID"].ToString();
                txtCompanyName.Text = servicio.BuscarProveedor(texto, criterio).Tables[0].Rows[0]["CompanyName"].ToString();
                txtContactName.Text = servicio.BuscarProveedor(texto, criterio).Tables[0].Rows[0]["ContactName"].ToString();
                txtContactTitle.Text = servicio.BuscarProveedor(texto, criterio).Tables[0].Rows[0]["ContactTitle"].ToString();
                txtAddress.Text = servicio.BuscarProveedor(texto, criterio).Tables[0].Rows[0]["Address"].ToString();
                txtCity.Text = servicio.BuscarProveedor(texto, criterio).Tables[0].Rows[0]["City"].ToString();
                txtRegion.Text = servicio.BuscarProveedor(texto, criterio).Tables[0].Rows[0]["Region"].ToString();
                txtPostalCode.Text = servicio.BuscarProveedor(texto, criterio).Tables[0].Rows[0]["PostalCode"].ToString();
                txtCountry.Text = servicio.BuscarProveedor(texto, criterio).Tables[0].Rows[0]["Country"].ToString();
                txtPhone.Text = servicio.BuscarProveedor(texto, criterio).Tables[0].Rows[0]["Phone"].ToString();
                txtFax.Text = servicio.BuscarProveedor(texto, criterio).Tables[0].Rows[0]["Fax"].ToString();
                txtHomePage.Text = servicio.BuscarProveedor(texto, criterio).Tables[0].Rows[0]["HomePage"].ToString();
            }
            catch (Exception)
            {
                Response.Write("<script>alert('Datos incorrectos');</script>");
            }
        }






    }
}