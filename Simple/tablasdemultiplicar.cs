using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Logica
{
    class tablasdemultiplicar
    {
        public void tablas()
        {
            double i;
            int num_1;
            int num_2;
            string op;
            do
            {
                Console.SetCursorPosition(15, 2); Console.Write("¿Cual es la tabla que desea saber? >");
                Console.SetCursorPosition(52, 2); num_1 = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(15, 6); Console.Write("¿Hasta que numero desea saber la tabla? >");
                Console.SetCursorPosition(57, 6); num_2 = int.Parse(Console.ReadLine());
                for (i = 1; i <= num_2; i++)
                {

                    Console.WriteLine(num_1 + " X " + i + " = " + i * num_1);

                }
                Console.SetCursorPosition(15, 8); Console.WriteLine("Desea otro numero? >");
                Console.SetCursorPosition(36, 8); op = Console.ReadLine();
                Console.Clear();
            } while (!(op.Equals("no") || op.Equals("NO")));
            Console.SetCursorPosition(15, 8); Console.WriteLine("Terminado...");
            Console.ReadKey();

        }
    }
}
