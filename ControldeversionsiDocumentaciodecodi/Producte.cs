﻿using System;
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

        /// <summary>
        /// Propietat de preu, per visualitzar i modificar.
        /// </summary>
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
        /// <summary>
        /// Constructor amb tots els parametres.
        /// </summary>
        /// <param name="preu">parametre preu</param>
        /// <param name="id">parametre id</param>
        /// <param name="descripció">parametre descripcio</param>
        /// <param name="talla">parametre talla</param>
        public Producte(double preu, int id, string descripció, string talla)
        {
            this.preu = preu;
            this.id = id;
            this.descripció = descripció;
            this.talla = talla;
        }

        public Producte Copia()
        {
            return (Producte)MemberwiseClone();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            else
            {
                Producte p = (Producte)obj;

                if (preu == p.Preu) return true;
                else
                {
                    return false;
                }
            }
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            Producte otherobj = obj as Producte;
            if (otherobj != null)
                return this.preu.CompareTo(otherobj.Preu);
            else
                throw new ArgumentException("Error!!");
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
