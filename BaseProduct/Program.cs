using BaseProduct.Logica;

try
{
    Producto producto = CrearProducto();

    Console.WriteLine("Nombre: " + producto.Nombre);
    Console.WriteLine("Precio: " + producto.Precio);
    Console.WriteLine("Cantidad disponible: " + producto.CantidadDisponible);

    Console.WriteLine("Realizar una compra:");
    Console.Write("Ingrese la cantidad deseada: ");
    int cantidadComprada = Convert.ToInt32(Console.ReadLine());

    producto.ActualizarCantidad(cantidadComprada);
    Console.WriteLine("Cantidad disponible después de la compra: " + producto.CantidadDisponible);
    Console.WriteLine("Costo total de los productos disponibles: " + producto.CalcularCostoTotal());

    Console.ReadLine();

    Producto CrearProducto()
    {
        Producto producto = new Producto();
        producto.Nombre = "Camiseta";
        producto.Precio = 20.00m;
        producto.CantidadDisponible = 10;

        return producto;
    }
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR:....... [{ex.Message}]");
}