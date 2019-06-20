using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class Chef : Cocinero
    {
        internal override Plato PrepararPlato()
        {
            var plato = new Plato();
            plato.AgregarIngrediente(new Ingrediente { Nombre = "Carne", Costo = 15 });
            plato.AgregarIngrediente(new Ingrediente { Nombre = "Papa", Costo = 9 });
            plato.AgregarIngrediente(new Ingrediente { Nombre = "Papa", Costo = 9 });
            plato.AgregarIngrediente(new Ingrediente { Nombre = "Cebolla", Costo = 6 });

            return plato;
        }
    }
}
