using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using App.Modelo;

namespace App.Datos
{
    public class BillsRepositories
    {

            static List<Bills> data = new List<Bills>();
            static List<Package> dataPack = new List<Package>();

            static Person send = new Person();
            static Person recib = new Person();
            static  Dictionary<Package, double> packages1 = new Dictionary<Package, double>();

            public void addPackages(Package pa,double valor) {
                packages1.Add(pa, valor);
            }

            public IEnumerable<Bills> getBills()
            {
                Bills b1 = new Bills(new DateTime(), packages1);
                data.Add(b1);
                return data;
            }
        
        public IEnumerable<Package>getPackges()
        {

            return packages1.Keys;
        }
        


    }

}