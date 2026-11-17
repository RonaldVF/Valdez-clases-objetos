using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Actividad1
{
    public class Producto
    {
      private string _nombre;
      private string _codigo;
      private double _precio;   
      private int _cantidad;

        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }   

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Error: El nombre del producto no puede estar vacio.");
                }
                else
                {
                    _nombre = value;
                }
            }
        }

        public double Precio
        {
            get { return _precio; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Error: El precio debe ser mayor que 0.");
                }
                else
                {
                    _precio = value;
                }
            }
        }

        public int Cantidad
        {
            get { return _cantidad; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error: La cantidad no puede ser negativa.");
                }
                else
                {
                    _cantidad = value;
                }
            }
        }
        public double ValorTotal
        {
            get { return _precio * _cantidad; }
        }

        // El constructor de la clase Producto
        public Producto(string codigo, string nombre, double precio, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"---------------------------------------");
            Console.WriteLine($"\nCódigo: {Codigo}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Precio: ${Precio:F2}");
            Console.WriteLine($"Cantidad: {Cantidad}");
            Console.WriteLine($"Valor Total en Existencia: ${ValorTotal:F2}");
            Console.WriteLine($"\n----------------------------------------");
        }


    }
}
