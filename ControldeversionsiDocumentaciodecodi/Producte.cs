using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControldeversionsiDocumentaciodecodi
{
    class Producte
    {
        private double preu;
        private int id;
        private string descripció, talla;

        public double Preu
        {
            get { return preu; }
            set { preu = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Descripció
        {
            get { return descripció; }
            set { descripció = value; }
        }

        public string Talla
        {
            get { return talla; }
            set { talla = value; }
        }

        public Producte()
        {

        }

        public Producte(double preu, int id, string descripció, string talla)
        {
            this.preu = preu;
            this.id = id;
            this.descripció = descripció;
            this.talla = talla;
        }
    }
}
