using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class Restaurante
    {
        public double CostoTotal { get; private set; }
        public Plato SacarPlato(Cocinero cocinero)
        {
            var plato = cocinero.PrepararPlato();
            CostoTotal += plato.Costo;
            return plato;
        }
    }
}
