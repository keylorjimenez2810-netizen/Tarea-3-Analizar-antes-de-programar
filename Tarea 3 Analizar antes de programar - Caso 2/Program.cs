using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3_Analizar_antes_de_programar___Caso_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float precio;
            int cantidad;
            float total;
            float descuento;
            float totalFinal;

            try
            {
                Console.Write("Ingrese el precio del producto: ");
                precio = float.Parse(Console.ReadLine());

                Console.Write("Ingrese la cantidad de productos: ");
                cantidad = int.Parse(Console.ReadLine());

                if (precio > 0 && cantidad > 0)
                {
                    total = precio * cantidad;

                    if (total > 25000)
                    {
                        descuento = total * 0.10f;
                        totalFinal = total - descuento;

                        Console.WriteLine("Total de la compra: " + total);
                        Console.WriteLine("Descuento aplicado: " + descuento);
                        Console.WriteLine("Total a pagar: " + totalFinal);
                    }
                    else
                    {
                        Console.WriteLine("Total de la compra: " + total);
                        Console.WriteLine("No se aplica descuento.");
                        Console.WriteLine("Total a pagar: " + total);
                    }
                }
                else
                {
                    Console.WriteLine("El precio y la cantidad deben ser mayores a 0.");
                }
            }
            catch
            {
                Console.WriteLine("Debe ingresar solamente valores numéricos.");
                Console.Write("Ingrese el precio del producto: ");
                precio = float.Parse(Console.ReadLine());

                Console.Write("Ingrese la cantidad de productos: ");
                cantidad = int.Parse(Console.ReadLine());

                if (precio > 0 && cantidad > 0)
                {
                    total = precio * cantidad;

                    if (total > 25000)
                    {
                        descuento = total * 0.10f;
                        totalFinal = total - descuento;

                        Console.WriteLine("Total de la compra: " + total);
                        Console.WriteLine("Descuento aplicado: " + descuento);
                        Console.WriteLine("Total a pagar: " + totalFinal);
                    }
                    else
                    {
                        Console.WriteLine("Total de la compra: " + total);
                        Console.WriteLine("No se aplica descuento.");
                        Console.WriteLine("Total a pagar: " + total);
                    }
                }
                else
                {
                    Console.WriteLine("El precio y la cantidad deben ser mayores a 0.");
                }
            }
        }
    }
}
