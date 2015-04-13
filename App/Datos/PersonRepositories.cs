using App.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Datos
{
    public class PersonRepositories
    {
        static List<Person> listaPersonas = new List<Person>();

        public void agregar(Person p) { 
            listaPersonas.Add(p);
        }

        public IEnumerable<Person> ObtenerLista(){
            return listaPersonas;
        }

        
    }
}