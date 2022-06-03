using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Logica
{
    class numerospares
    {
        public void pares()
        {
            double cont;
            int num_1;
            string op;
            do
            {


                Console.SetCursorPosition(15, 2); Console.WriteLine("Ingrese el numero de numeros impares que desea saber >");
                Console.SetCursorPosition(70, 2); num_1 = int.Parse(Console.ReadLine());
                for (cont = 1; cont <= num_1; cont++)
                {
                    Console.WriteLine((cont * 2) + 1);
                }
                Console.SetCursorPosition(15, 4); Console.WriteLine("Desea otros numeros? >");
                Console.SetCursorPosition(40, 4); op = Console.ReadLine();
                Console.Clear();
            } while (!(op.Equals("no") || op.Equals("NO")));
            Console.SetCursorPosition(15, 6); Console.WriteLine("Terminado...");
            Console.ReadKey();
        }
    }
}
