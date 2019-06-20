# Consignas:

Se solicita que desarrolle una aplicación que permita representar la preparación de platos de un restaurante. Clases: Ingrediente, Plato, Cocinero, Chef, Repostero, Restaurante, Mesa. Implméntelo en dos assemblies (Windows y Clases).

## Detalles de implementación:

1) * La clase Ingrediente tendrá los atributos Nombre (string) y Costo (single).
2) * Plato encapsulará una colección de ingredientes. Expondrá una propiedad de sólo lectura Costo que devolverá el costo total del plato (double)
3) * Cocinero será abstracta. Expondrá un método PrepararPLato que devolverá un plato (vacío). Este método sólo podrá invocarse desde dentro del mismo assembly.
4) * Chef heredará de Cocinero y reemplazará el método PrepararPLato agregando en él dos partes del ingrediente Carne (con un costo de 15),
dos de Papa (9) y uno de Cebolla (6). Repostero heredará de Cocinero y reemplazará el mismo método devolviendo un plato con tres partes de Azúcar (costo 8 c/u),
tres de Harina (4 c/u) y dos de Huevo (3).
5) * La clase Restaurante expondrá un método SacarPlato que recibirá como parámetro un Cocinero y devolverá un Plato. Restaurante irá calculando los costos de los platos preparados e irá sumándolos. Mostrará el total de costos acumulados mediante la propiedad Readonly CostoTotal
6) * Genere desde un formulario las instancia necesarias para invocar al menos tres veces SacarPLato (dos veces con un chef y una con un Repostero) y consultar el costo acumulado).

* Puntos necesarios para aprobar
