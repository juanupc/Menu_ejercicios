using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Matriz
{
    internal class Matriz_1
    {
        public void Matriz_11()
        {
            int F = 0;
            int C = 0;
            int N = 0;
            int M = 0;
            string linea;

            Console.Write("FILAS DE LA MATRIZ:");
            linea = Console.ReadLine();
            N = int.Parse(linea);
            Console.Write("COLUMNAS DE LA MATRIZ:");
            linea = Console.ReadLine();
            M = int.Parse(linea);
            int[,] MAT = new int[N + 1, M + 1];
            for (F = 1; F <= N; F++)
            {
                for (C = 1; C <= M; C++)
                {
                    MAT[F, C] = F * C;
                }
            }

            for (F = 1; F <= N; F++)
            {
                for (C = 1; C <= M; C++)
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
