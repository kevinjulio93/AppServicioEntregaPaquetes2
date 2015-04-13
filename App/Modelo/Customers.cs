using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class Customers
    {

        private string identificacion;

        public string Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }
        private string nombres;

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        private string apellidos;

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Customers(string identificacion, string nombres, string apellidos, string direccion, string telefono, string email)
        {
            this.identificacion = identificacion;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
        }


        
        public String imprimir() {
            return "Customers{" + "identificacion=" + identificacion + ", nombres=" + nombres + ", apellidos=" + apellidos + ", direccion=" + direccion + ", telefono=" + telefono + ", email=" + email + '}';
        }

    }
}