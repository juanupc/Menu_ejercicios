using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Matriz
{
    internal class Matriz_3
    {
        public void suma_matriz()
        {
            int F = 0;
            int C = 0;
            int N = 0;
            int SUM = 0;
            string linea;
            Console.Write("TAMAÑO DE LA MATRIZ:");
            linea = Console.ReadLine();
            N = int.Parse(linea);
            int[,] MAT = new int[N + 1, N + 1];
            for (F = 1; F <= N; F++)
            {
                for (C = 1; C <= N; C++)
                {
                    Console.SetCursorPosition(C * 4, F + 1);
                    linea = Console.ReadLine();
                    MAT[F, C] = int.Parse(linea);
                }
            }
            for (F = 1; F <= N; F++)
            {
                for (C = 1; C <= N; C++)
                {
                    SUM = SUM + MAT[F, C];
                }
            }
            Console.WriteLine();
            Console.WriteLine("SUMA TOTAL ES:" + SUM);
            Console.WriteLine("PROMEDIO TOTAL ES:" + SUM / (N * N));
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
}
