using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class Repostero : Cocinero
    {
        internal override Plato PrepararPlato()
        {
            var plato = new Plato();
            plato.AgregarIngrediente(new Ingrediente { Nombre = "Azucar", Costo = 3 });
            plato.AgregarIngrediente(new Ingrediente { Nombre = "Azucar", Costo = 3 });
            plato.AgregarIngrediente(new Ingrediente { Nombre = "Azucar", Costo = 3 });
            plato.AgregarIngrediente(new Ingrediente { Nombre = "Harina", Costo = 4 });
            plato.AgregarIngrediente(new Ingrediente { Nombre = "Harina", Costo = 4 });
            plato.AgregarIngrediente(new Ingrediente { Nombre = "Harina", Costo = 4 });
            plato.AgregarIngrediente(new Ingrediente { Nombre = "Huevo", Costo = 3 });
            plato.AgregarIngrediente(new Ingrediente { Nombre = "Huevo", Costo = 3 });
            return plato;
        }
    }
}
