using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Matriz
{
    internal class Matriz_2
    {
        public void aleatorio()
        {
            int F = 0;
            int C = 0;
            int[,] MAT = new int[6, 6];
            Random rnd = new Random();
            for (F = 1; F <= 5; F++)
            {
                for (C = 1; C <= 5; C++)
                {
                    MAT[F, C] = rnd.Next(0, 99);
                }
            }
            for (F = 1; F <= 5; F++)
            {
                for (C = 1; C <= 5; C++)
                {
                    Console.SetCursorPosition(C * 4, F + 1);
                    Console.Write(MAT[F, C]);
                }
            }
            Console.WriteLine();
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
}
