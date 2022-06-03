using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Intermedio
{
    internal class Ejercicio_2
    {
		public void cuadrados()
		{
			int i;
			int n;
			Console.SetCursorPosition(15, 2); Console.WriteLine("Ingresar la cantidad de numeros > ");
			Console.SetCursorPosition(49, 2); n = int.Parse(Console.ReadLine());
			double[] valores = new double[n];
			double[] c = new double[n];
			for (i = 1; i <= n; i++)
			{
				Console.WriteLine("Ingrese el " + i + " numero");
				valores[i - 1] = Double.Parse(Console.ReadLine());
				c[i - 1] = valores[i - 1] * valores[i - 1];
				Console.WriteLine("Elevado al cuadrado es : " + c[i - 1]);
			}
			Console.ReadKey();
		}
    }
}
 