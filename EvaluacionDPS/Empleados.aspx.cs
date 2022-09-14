using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace EvaluacionDPS
{
    public partial class Empleados : System.Web.UI.Page
    {

        private static SomeeReference.WebService1SoapClient servicio = new SomeeReference.WebService1SoapClient();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                calBirthDate.Visible = false;
                calHireDate.Visible = false;
            }
        }

        protected void btnAsignarFecha_Click(object sender, EventArgs e) {
            calBirthDate.Visible = !calBirthDate.Visible;
        }

        protected void btnAsignarFechaNac_SelectionChanged(object sender, EventArgs e) {
            txtBirthDate.Text = calBirthDate.SelectedDate.ToString();
        }

        protected void btnAsignarContrato_SelectionChanged(object sender, EventArgs e) {
            txtHireDate.Text = calHireDate.SelectedDate.ToString();
        }

        protected void btnAsignarFechaContrato_Click(object sender, EventArgs e) {
            calHireDate.Visible = !calHireDate.Visible;
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string lastName = txtLastName.Text.Trim();
            string firstName = txtFirstName.Text.Trim();
            string title = txtTitle.Text.Trim();
            string titleOfCourtesy = txtTitleOfCourtesy.Text.Trim();
            DateTime nacFecha = DateTime.Parse(txtBirthDate.Text.Trim());
            string birthDate = nacFecha.ToString("yyyy-MM-dd HH:mm:ss.fff");
            DateTime contFecha = DateTime.Parse(txtHireDate.Text.Trim());
            string hireDate = contFecha.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string address = txtAddress.Text.Trim();
            string city = txtCity.Text.Trim();
            string region = txtRegion.Text.Trim();
            string postalCode = txtPostalCode.Text.Trim();
            string country = txtCountry.Text.Trim();
            string homePhone = txtHomePhone.Text.Trim();
            string extension = txtExtension.Text.Trim();
            string photo = "";
            string notes = txtNotes.Text.Trim();
            int reportsTo = Int32.Parse(txtReportsTo.Text.Trim());
            string photoPath = EnlaceFoto.Text.Trim();
            
            string[] rpta = servicio.AgregarEmpleado(lastName, firstName, title, titleOfCourtesy, birthDate, hireDate, address, city, region, postalCode, country, homePhone, extension, photo, notes, reportsTo, photoPath);

            if (rpta[0] == "0")
            {
                //Listar();
            }
            else Response.Write("<script>alert('No se agrego empleado');</script>");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string employeeID = textEmployeeId.Text.Trim();
            string[] rpta = servicio.EliminarEmpleado(Int32.Parse(employeeID));
            if (rpta[0] == "0")
            {
                //Listar();
            }
            else Response.Write("<script>alert('No se pudo eliminar empleado');</script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            int idEmployee = Int32.Parse(textEmployeeId.Text.Trim());
            string lastName = txtLastName.Text.Trim();
            string firstName = txtFirstName.Text.Trim();
            string title = txtTitle.Text.Trim();
            string titleOfCourtesy = txtTitleOfCourtesy.Text.Trim();
            DateTime nacFecha = DateTime.Parse(txtBirthDate.Text.Trim());
            string birthDate = nacFecha.ToString("yyyy-MM-dd HH:mm:ss.fff");
            DateTime contFecha = DateTime.Parse(txtHireDate.Text.Trim());
            string hireDate = contFecha.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string address = txtAddress.Text.Trim();
            string city = txtCity.Text.Trim();
            string region = txtRegion.Text.Trim();
            string postalCode = txtPostalCode.Text.Trim();
            string country = txtCountry.Text.Trim();
            string homePhone = txtHomePhone.Text.Trim();
            string extension = txtExtension.Text.Trim();
            string photo = "";
            string notes = txtNotes.Text.Trim();
            int reportsTo = Int32.Parse(txtReportsTo.Text.Trim());
            string photoPath = EnlaceFoto.Text.Trim();

            string[] rpta = servicio.ActualizarEmpleado(idEmployee, lastName, firstName, title, titleOfCourtesy, birthDate, hireDate, address, city, region, postalCode, country, homePhone, extension, photo, notes, reportsTo, photoPath);

            if (rpta[0] == "0")
            {
                Response.Write("<script>alert('Empleado Actualizado correctamente');</script>");
                gvEmpleado.DataSource = servicio.BuscarEmpleado(textEmployeeId.Text.Trim(), "exacto");
                gvEmpleado.DataBind();
            }
            else Response.Write("<script>alert('No se pudo actualizar empleado');</script>");
        }

        protected void btnBuscar_Click(object senser, EventArgs e)
        {
            string texto = buscar.Text.Trim();
            string criterio = ddBuscar.Text.Trim();

            if (criterio == "codEmpleado")
            {
                criterio = "exacto";
            }
            else if (criterio == "nombreEmpleado")
            {
                criterio = "sensitivo";
            }
            else {
                criterio = "0";
            }

            gvEmpleado.DataSource = servicio.BuscarEmpleado(texto, criterio);
            gvEmpleado.DataBind();
        }

        protected void btnCargar_Click(object senser, EventArgs e)
        {
            try
            {
                string criterio = ddBuscar.Text.Trim();
                string texto = buscar.Text.Trim();
                if (criterio == "codEmpleado")
                {
                    criterio = "exacto";
                }
                else if (criterio == "nombreEmpleado")
                {
                    Response.Write("<script>alert('No se pudo actualizar empleado');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Nulo');</script>");
                }

                textEmployeeId.Text = servicio.BuscarEmpleado(texto, criterio).Tables[0].Rows[0]["EmployeeID"].ToString();
                txtLastName.Text = servicio.BuscarEmpleado(texto, criterio).Tables[0].Rows[0]["LastName"].ToString();
                txtFirstName.Text = servicio.BuscarEmpleado(texto, criterio).Tables[0].Rows[0]["FirstName"].ToString();
                txtTitle.Text = servicio.BuscarEmpleado(texto, criterio).Tables[0].Rows[0]["Title"].ToString();
                txtTitleOfCourtesy.Text = servicio.BuscarEmpleado(texto, criterio).Tables[0].Rows[0]["TitleOfCourtesy"].ToString();
                txtBirthDate.Text = servicio.BuscarEmpleado(texto, criterio).Tables[0].Rows[0]["BirthDate"].ToString();
                txtHireDate.Text = servicio.BuscarEmpleado(texto, criterio).Tables[0].Rows[0]["HireDate"].ToString();
                txtAddress.Text = servicio.BuscarEmpleado(texto, criterio).Tables[0].Rows[0]["Address"].ToString();
                txtCity.Text = servicio.BuscarEmpleado(texto, criterio).Tables[0].Rows[0]["City"].ToString();
                txtRegion.Text = servicio.BuscarEmpleado(texto, criterio).Tables[0].Rows[0]["Region"].ToString();
                txtPostalCode.Text = servicio.BuscarEmpleado(texto, criterio).Tables[0].Rows[0]["PostalCode"].ToString();
                txtCountry.Text = servicio.BuscarEmpleado(texto, criterio).Tables[0].Rows[0]["Country"].ToString();
                txtHomePhone.Text = servicio.BuscarEmpleado(texto, criterio).Tables[0].Rows[0]["HomePhone"].ToString();
                txtExtension.Text = servicio.BuscarEmpleado(texto, criterio).Tables[0].Rows[0]["Extension"].ToString();
                EnlaceFoto.Text = servicio.BuscarEmpleado(texto, criterio).Tables[0].Rows[0]["PhotoPath"].ToString();
                txtReportsTo.Text = servicio.BuscarEmpleado(texto, criterio).Tables[0].Rows[0]["ReportsTo"].ToString();
                // --
                txtNotes.Text = servicio.BuscarEmpleado(texto, criterio).Tables[0].Rows[0]["Notes"].ToString();

                // --
            }
            catch (Exception) {
                Response.Write("<script>alert('Debe ingresar un codigo');</script>");
            }
        }




    }
}