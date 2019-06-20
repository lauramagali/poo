using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class Plato
    {
        private List<Ingrediente> pIngredientes = new List<Ingrediente>();
        public List<Ingrediente> Ingredientes { get { return pIngredientes; } }

        public double Costo { get { return mCosto; } }

        private double mCosto { get; set; }

        public void AgregarIngrediente(Ingrediente ingrediente)
        {
            SumarCostoTotal(ingrediente.Costo);
            pIngredientes.Add(ingrediente);
        }

        public void SumarCostoTotal(float costo)
        {
            mCosto = mCosto + costo;
        }
    }
}
