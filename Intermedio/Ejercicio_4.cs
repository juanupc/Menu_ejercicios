using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Intermedio
{
    internal class Ejercicio_4
    {
        public void Suma_Vectores()
        {
            byte I = 0;
            int[] A = new int[10];
            int[] B = new int[10];
            int[] S = new int[6];
            string linea;

            Console.WriteLine("PRIMERO SEGUNDO RESULTADO");
            for (I = 1; I <= 5; I++)
            {
                Console.SetCursorPosition(3, I + 2);
                linea = Console.ReadLine();
                A[I] = int.Parse(linea);

                Console.ReadLine(); Console.SetCursorPosition(10, I + 2);
                linea = Console.ReadLine();
                B[I] = int.Parse(linea);
                S[I] = A[I] + B[I];
            }

            for (I = 1; I <= 5; I++)
            {
                Console.SetCursorPosition(18, I + 2);
                Console.WriteLine(S[I]);
            }
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
}
        
