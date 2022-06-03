using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Logica
{
    class notas
    {
        public void promedio()
        {
            double cont;
            double i;
            string nombre;
            double nota;
            int num_notas;
            double promedio;
            string op;
            do
            {
                cont = 0;
                Console.SetCursorPosition(15, 2); Console.WriteLine("ingrese el nombre del estudiante >");
                Console.SetCursorPosition(50, 2); nombre = Console.ReadLine();
                Console.SetCursorPosition(15, 4); Console.WriteLine("Cuantas notas va a ingresar >");
                Console.SetCursorPosition(45, 4); num_notas = int.Parse(Console.ReadLine());
                for (i = 1; i <= num_notas; i++)
                {
                    Console.SetCursorPosition(15, 6); Console.WriteLine("Ingrese las notas >");
                    Console.SetCursorPosition(35, 6); nota = Double.Parse(Console.ReadLine());
                    cont = cont + nota;
                }
                promedio = cont / num_notas;
                Console.SetCursorPosition(15, 6); Console.WriteLine("El promedio del estudiante " + nombre + " es de " + promedio);

                Console.SetCursorPosition(30, 8); Console.WriteLine("Desea otro estudiante? >");
                Console.SetCursorPosition(55, 8); op = Console.ReadLine();
                Console.Clear();
            } while (!(op.Equals("no") || op.Equals("NO")));
            Console.SetCursorPosition(15, 10); Console.WriteLine("Terminado...");
            Console.ReadKey();
        }
    }
}
