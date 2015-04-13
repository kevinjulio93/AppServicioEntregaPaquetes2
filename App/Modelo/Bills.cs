using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class Bills
    {
        private long id;
        private DateTime date;
        private Person customers;
        private Dictionary<Package, double> items = new Dictionary<Package, double>();
        protected static long val = 0;

        public long Id
        {
            get { return id; }
            set { id = ++val; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public Person Customers
        {
            get { return customers; }
            set { customers = value; }
        }

        protected Dictionary<Package, double> Items
        {
            get { return items; }
            set { items = value; }
        }

        public Bills()
        {
            this.id = ++val;
            this.customers = null;
            this.date = new DateTime();
            this.items  = null;

        }
        public Bills(DateTime date, Dictionary<Package, double> packages)
        {
            this.id = ++val;
            this.date = date;
            this.items = packages;
        }

       

        #region "Métodos SobreEscritos"
        public override string ToString()
        {
            return "\nId :" + this.id +
                   "\nDate :" + this.date +
                   "\nCustomer :" + this.customers +
                   "\n_______________________________________";
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        /*
        public override bool Equals(object obj)
        {
            TwoDayPackage o = (TwoDayPackage)obj;
            bool result = false;

            if (base.Equals(o) && (this.fixedFee == o.fixedFee))

                result = true;

            return result;
        }
         * */

        #endregion

    }
}