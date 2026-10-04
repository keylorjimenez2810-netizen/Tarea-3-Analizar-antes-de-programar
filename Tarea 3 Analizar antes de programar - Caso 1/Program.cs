using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3_Analizar_antes_de_programar___Caso_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string curso;
            float nota;

            Console.Write("Ingrese el nombre del estudiante: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese el nombre del curso: ");
            curso = Console.ReadLine();

            try
            {
                Console.Write("Ingrese la nota final del estudiante: ");
                nota = float.Parse(Console.ReadLine());

                if (nota >= 0 && nota <= 100)
                {
                    Console.WriteLine("\nNombre: " + nombre);
                    Console.WriteLine("Curso: " + curso);
                    Console.WriteLine("Nota: " + nota);

                    if (nota >= 70)
                    {
                        Console.WriteLine("Resultado: Aprobado");
                    }
                    else
                    {
                        Console.WriteLine("Resultado: Reprobado");
                    }
                }
                else
                {
                    Console.WriteLine("La nota debe estar entre 0 y 100.");
                }
            }
            catch
            {
                Console.WriteLine("La nota debe ser un número válido entre 0 y 100.");
                Console.Write("Ingrese la nota final del estudiante: ");
                nota = float.Parse(Console.ReadLine());

                if (nota >= 0 && nota <= 100)
                {
                    Console.WriteLine("\nNombre: " + nombre);
                    Console.WriteLine("Curso: " + curso);
                    Console.WriteLine("Nota: " + nota);

                    if (nota >= 70)
                    {
                        Console.WriteLine("Resultado: Aprobado");
                    }
                    else
                    {
                        Console.WriteLine("Resultado: Reprobado");
                    }
                }
                else
                {
                    Console.WriteLine("La nota debe estar entre 0 y 100.");

                }
            }
        }
    }
}
