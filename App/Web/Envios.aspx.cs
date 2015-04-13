using App.Datos;
using App.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Windows.Forms;
using System.Web.UI.WebControls;
using System.Collections;

namespace App.Web
{
    public partial class Envios : System.Web.UI.Page
    {
        BillsRepositories facturas;
        Dictionary<Package, double> packagesdiccionario;


        IEnumerable<Dictionary<Package, double>> Result;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            facturas = new BillsRepositories();
            packagesdiccionario = new Dictionary<Package, double>();
                        
        }

        protected void btnGuardar_Click(object sender, EventArgs e)

        {

           PersonRepositories p = new PersonRepositories();

            //Cliente Emisor
            Person customer = null;

            long id = Convert.ToInt64(selectCliente.Text);

            for (int i = 0; i < p.ObtenerLista().Count(); i++)
            {

                if (p.ObtenerLista().ElementAt(i).Id == id)
                {
                    customer = p.ObtenerLista().ElementAt(i);
                }
                else
                {
                    MessageBox.Show("El cliente no existe");
                }


            }



            //Remitente
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string ciudad = txtCiudad.Text;
            long codigoPostal = Convert.ToInt64(txtCodigo.Text);

            //Paquete
            string codigo = txtCodigo.Text;
            Person emisor = customer;
            Person receptor;
            double peso = Convert.ToDouble(txtPeso.Text);
            double costo = Convert.ToDouble(txtCosto.Text); ;

            receptor = new Person(0, nombre, direccion, ciudad, "", codigoPostal);


            Package pack = null;

            if (tipoPaquete.Text.Equals("1"))
            {
                pack = new OvernightPackage();
                pack.Code = codigo;
                pack.Sender = emisor;
                pack.Recipients = receptor;
                pack.Weight = peso;
                pack.Cost = costo;

            }

            if (tipoPaquete.Text.Equals("2"))
            {
                pack = new TwoDayPackage();
                pack.Code = codigo;
                pack.Sender = emisor;
                pack.Recipients = receptor;
                pack.Weight = peso;
                pack.Cost = costo;
            }


            packagesdiccionario.Add(pack, pack.calculateCost());

            
                        
            Bills factuara = new Bills(new DateTime(), packagesdiccionario);

            
            foreach (var item in packagesdiccionario)
            {
                txtPrintFactura.Text = item.ToString()+"<br/>";
            }


        }

       
            


    }
}