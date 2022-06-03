using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Intermedio
{
	internal class Ejercicio_1
	{
		public void Plato()
		{
			double gasto;
			int i;
			int p;
			string plato;
			string op;
			do
			{
				Console.SetCursorPosition(15, 2); Console.WriteLine("Ingrese el nombre del plato > ");
				Console.SetCursorPosition(45, 2); plato = Console.ReadLine();
				Console.SetCursorPosition(15, 4); Console.WriteLine("Ingrese la cantidad de ingredientes > ");
				Console.SetCursorPosition(53, 4); p = int.Parse(Console.ReadLine());
				string[] productos = new string[p];
				double[] precios = new double[p];
				gasto = 0;
				for (i = 1; i <= p; i++)
				{
					Console.WriteLine("Ingrese el nombre del " + i + " ingrediente ");
					productos[i - 1] = Console.ReadLine();
					Console.WriteLine("Ingrese el precio del " + i + " ingrediente ");
					precios[i - 1] = Double.Parse(Console.ReadLine());
					gasto = gasto + precios[i - 1];
				}
				Console.SetCursorPosition(45, 15); Console.WriteLine("El costo del plato es de: " + gasto);
			Console.SetCursorPosition(45, 18); Console.WriteLine("Desea otro plato? >");
			Console.SetCursorPosition(65, 18); op = Console.ReadLine();
			Console.Clear();
			} while (!(op.Equals("no") || op.Equals("NO")));
			Console.SetCursorPosition(40, 18); Console.WriteLine("Terminado...");
			Console.ReadKey();
		}
	}
}
