using App.Datos;
using App.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace App.Web
{
    public partial class registro_clientes : System.Web.UI.Page
    {
        PersonRepositories personRepositories;
        protected void Page_Load(object sender, EventArgs e)
        {

            personRepositories = new PersonRepositories();
           

        }


        protected void btnEnviar_Click1(object sender, EventArgs e)
        {
            long identificacion = Convert.ToInt64(txtIdCliente.Text);
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string cuidad = txtCiudad.Text;
            string estado = txtEstado.Text;

            Person Customer = new Person(identificacion, nombre, direccion, cuidad, estado, 0);

            personRepositories.agregar(Customer);



            txtIdCliente.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtCiudad.Text = "";
            txtEstado.Text = "";
            

            Response.Redirect("registro_clientes.aspx");
            
        }


    }
}