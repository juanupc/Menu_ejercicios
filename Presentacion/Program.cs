using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Menu
{

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;

            int opcion = 0;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(15, 2); Console.Write(" M E N U   P R N C I P A L");
                Console.SetCursorPosition(15, 6); Console.Write("1. Tablas de multiplicar");
                Console.SetCursorPosition(15, 8); Console.Write("2. Par o impar");
                Console.SetCursorPosition(15, 10); Console.Write("3. Notas");
                Console.SetCursorPosition(15, 12); Console.Write("4. Generar numeros pares");
                Console.SetCursorPosition(15, 14); Console.Write("5. Generar numeros impares");
                Console.SetCursorPosition(15, 16); Console.Write("6. Costo de un plato");
                Console.SetCursorPosition(15, 18); Console.Write("7. Cuadrados de un numero");
                Console.SetCursorPosition(15, 20); Console.Write("8. Mayor y menor");
                Console.SetCursorPosition(15, 22); Console.Write("9. Suma de 5 vectores");
                Console.SetCursorPosition(15, 24); Console.Write("10. Suma de pares e impares");
                Console.SetCursorPosition(15, 26); Console.Write("11. Tablas de multiplicar matriz");
                Console.SetCursorPosition(15, 28); Console.Write("12. Generacion aleatoria de una matriz (5x5)");
                Console.SetCursorPosition(15, 30); Console.Write("13. Suma de una matriz");
                Console.SetCursorPosition(15, 32); Console.Write("14. Suma de las diagonales de una matriz");
                Console.SetCursorPosition(15, 34); Console.Write("15. Transpuesta");
                Console.SetCursorPosition(15, 36); Console.Write("16. salir");
                Console.SetCursorPosition(15, 38); Console.Write("Seleccione una opcion > ");
                Console.SetCursorPosition(39, 38); opcion = int.Parse(Console.ReadLine());
                Console.ReadKey();

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Logica.tablasdemultiplicar ejercicio1 = new Logica.tablasdemultiplicar();
                        ejercicio1.tablas();
                        break;
                    case 2:
                        Console.Clear();
                        Logica.paroimpar ejercicio2 = new Logica.paroimpar();
                        ejercicio2.numeros();
                        break;
                    case 3:
                        Console.Clear();
                        Logica.notas ejercicio3 = new Logica.notas();
                        ejercicio3.promedio();
                        break;
                    case 4:
                        Console.Clear();
                        Logica.numerospares ejercicio4 = new Logica.numerospares();
                        ejercicio4.pares();
                        break;
                    case 5:
                        Console.Clear();
                        Logica.numerosimpares ejercicio5 = new Logica.numerosimpares();
                        ejercicio5.impar();
                        break;
                    case 6:
                        Console.Clear();
                        Intermedio.Ejercicio_1 ejercicio_1 = new Intermedio.Ejercicio_1();
                        ejercicio_1.Plato();
                        break;
                    case 7:
                        Console.Clear();
                        Intermedio.Ejercicio_2 ejercicio_2 = new Intermedio.Ejercicio_2();
                        ejercicio_2.cuadrados();
                        break;
                    case 8:
                        Console.Clear();
                        Intermedio.Ejercicio_3 ejercicio_3 = new Intermedio.Ejercicio_3();
                        ejercicio_3.Mayor_Menor();
                        break;
                    case 9:
                        Console.Clear();
                        Intermedio.Ejercicio_4 ejercicio_4 = new Intermedio.Ejercicio_4();
                        ejercicio_4.Suma_Vectores();
                        break;
                    case 10:
                        Console.Clear();
                        Intermedio.Ejercicio_5 ejercicio_5 = new Intermedio.Ejercicio_5();
                        ejercicio_5.Suma_pares_impares();
                        break;
                    case 11:
                        Console.Clear();
                        Matriz.Matriz_1 ejercicio_11 = new Matriz.Matriz_1();
                        ejercicio_11.Matriz_11();
                        break;
                    case 12:
                        Console.Clear();
                        Matriz.Matriz_2 ejercicio_12 = new Matriz.Matriz_2();
                        ejercicio_12.aleatorio();
                        break;
                    case 13:
                        Console.Clear();
                        Matriz.Matriz_3 ejercicio_13 = new Matriz.Matriz_3();
                        ejercicio_13.suma_matriz();
                        break;
                    case 14:
                        Console.Clear();
                        Matriz.Matriz_4 ejercicio_14 = new Matriz.Matriz_4();
                        ejercicio_14.suma_diagonal_princiapl();
                        break;
                    case 15:
                        Console.Clear();
                        Matriz.Matriz_5 ejercicio_15 = new Matriz.Matriz_5();
                        ejercicio_15.transpuesta();
                        break;
                }

            } while (opcion != 16);
        }
    }
}
