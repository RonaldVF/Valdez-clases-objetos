namespace POO_Actividad1
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" SISTEMA DE CONTROL DE INVENTARIO - TECNOPUNTO ");

            
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"\n-- Ingrese los datos para el Producto {i} --");

                Console.Write("Ingrese el codigo: ");
                string codigo = Console.ReadLine();

                string nombre = "";
                //bucle para validar el nombre del producto
                while (string.IsNullOrWhiteSpace(nombre))
                {
                    Console.Write("Ingrese el nombre: ");
                    nombre = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(nombre))
                    {
                        Console.WriteLine("Dato invalido. El nombre no puede estar vacio. Intente de nuevo.");
                    }
                }
                //bucle para validar el precio del producto
                double precio = 0;
                while (precio <= 0)
                {
                    Console.Write("Ingrese el precio (> 0): ");
                    if (double.TryParse(Console.ReadLine(), out double tempPrecio) && tempPrecio > 0)
                    {
                        precio = tempPrecio;
                    }
                    else
                    {
                        Console.WriteLine("Dato invalido. El precio debe ser un numero mayor a 0.");
                    }
                }
                //bucle para validar la cantidad del producto
                int cantidad = -1;
                while (cantidad < 0)
                {
                    Console.Write("Ingrese la cantidad (>= 0): ");
                    if (int.TryParse(Console.ReadLine(), out int tempCantidad) && tempCantidad >= 0)
                    {
                        cantidad = tempCantidad;
                    }
                    else
                    {
                        Console.WriteLine("Dato invalido. La cantidad no puede ser negativa.");
                    }
                }

               
                Producto producto = new(codigo, nombre, precio, cantidad);

                Console.WriteLine("\nResultado del registro:");
                producto.MostrarInfo();
            }

            Console.WriteLine("\nProceso de inventario finalizado. Presione cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
