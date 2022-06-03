using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Intermedio
{
    internal class Ejercicio_3
    {
        public void Mayor_Menor()
        {
            byte I = 0;
            byte CAN = 0;
            int MAY = 0;
            int MEN = 0;
            int POS = 0;
            String cad;
            Console.Write("CUANTOS ELEMENTOS:");
            cad = Console.ReadLine();
            CAN = byte.Parse(cad);
            int[] VEC = new int[CAN + 1];

            for (I = 1; I <= CAN; I++)
            {
                Console.Write("POSICIÓN {0} ==>", I);
                cad = Console.ReadLine();
                VEC[I] = byte.Parse(cad);
            }

            MAY = VEC[1];
            POS = 1;
            MEN = VEC[1];
            for (I = 2; I <= CAN; I++)
            {
                if ((VEC[I] > MAY))
                {
                    MAY = VEC[I];
                    POS = I;
                }
                if ((VEC[I] < MEN))
                    MEN = VEC[I];
            }

            Console.WriteLine();
            Console.WriteLine("MAYOR ES :{0} Y ESTA EN LA POSICIÓN {1} ", MAY, POS);
            Console.WriteLine("EL MENOR ES: " + MEN);
            Console.Write("Pulse una Tecla:");
            Console.ReadKey();

        }

    }
}
