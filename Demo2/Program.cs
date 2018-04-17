using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int valor = 34;
            Funciones_sobrecarga funcion = new Funciones_sobrecarga();
            //funcion.StopService();
            //funcion.StopService(45);
            //funcion.StopService("Aldedier");
            //funcion.EnviarValor(valor);
            //Console.WriteLine("El valor es: " + valor);
            //funcion.EnviarValorPorReferencia(ref valor);
            //Console.WriteLine("El valor con referencia es: " + valor);


            //var forceStop = true;
            //int respuesta = funcion.StopServiceParametrosOpcionales(forceStop);
            //Console.WriteLine("La longitud del nombre es: " + respuesta);
            //respuesta = funcion.StopServiceParametrosOpcionales(forceStop, _serviceName: "Aldedier", _serviceId: 3);
            //Console.WriteLine("La longitud del nombre es: " + respuesta);


            //string statusMessage = string.Empty; // El string.Empty es igual a "".
            string serviceName = "Hola mundo";
            string statusMessage = null;
            bool isServiceOnline = funcion.IsServiceOnline(serviceName, out statusMessage);
            Console.WriteLine("El estado del mensaje es: " + statusMessage);
            if (isServiceOnline)
            {
                isServiceOnline = funcion.IsServiceOnline("SalesService", out statusMessage);
            }
            Console.WriteLine("El estado del mensaje es: " + statusMessage);




            // Concatenar strings con StringBuilder

            //StringBuilder nombre = new StringBuilder();
            //nombre.Append("Aldedier ");
            //nombre.Append("Alberto ");
            //nombre.Append("Martinez ");
            //nombre.Append("Bejarano");
            //string nombrecompleto = nombre.ToString();

            ////Concatenar con operador +
            //Console.WriteLine("Su nombre completo es: " + nombrecompleto);
            ////Concatenar string con corchetes
            //Console.WriteLine("Su nombre completo es: {0}", nombrecompleto);


            //// if - else if - else
            //int num1 = 5;
            //int num2 = 6;
            //if (num1 < num2)
            //{
            //    Console.WriteLine("El numero {0} es menor que {1}", num1, num2);
            //}else if (num1 == num2)
            //{
            //    Console.WriteLine("El numero {0} es igual que {1}", num1, num2);
            //}
            //else
            //{
            //    Console.WriteLine("El numero {0} es mayor que {1}", num1, num2);
            //}

            //// switch
            //Console.WriteLine("Digite un numero del 1 al 3");
            //switch (Convert.ToInt16(Console.ReadLine()))
            //{
            //    case 1:
            //        Console.WriteLine("El numero digitado es uno");
            //        break;

            //    case 2:
            //        Console.WriteLine("El numero digitado es dos");
            //        break;

            //    case 3:
            //        Console.WriteLine("El numero digitado es tres");
            //        break;

            //    default:
            //        Console.WriteLine("El numero {0} no corresponde a un numero o valor valido");
            //        break;
            //}


            //// Implementacion de iteracion logica "FOR"
            //for (int i = 0; i < 10; i++)
            //{

            //}

            //// "Foreach"
            //string[] names = new string[10];
            //foreach (var name in names)
            //{

            //}


            //// "While"
            //while (num1 < num2)
            //{
            //    Console.WriteLine("Entro al ciclo while");
            //    break;
            //}

            //// "Do while"
            //do
            //{
            //    Console.WriteLine("Entra una sola vez cumpla o no cumpla");
            //    break;
            //} while (true);

            // Arreglo de una sola dimension "Array"

            //string[] ListaMercado = new string[5];
            //for (int i = 0; i < ListaMercado.Length; i++)
            //{
            //    Console.WriteLine("Ingrese elemento de la lista");
            //    ListaMercado[i] = Console.ReadLine();
            //}

            //Console.WriteLine("La lista de elementos es: ");
            //foreach (var item in ListaMercado)
            //{
            //    Console.WriteLine(item);
            //}

            //string[] ListaMercado2 = { "Pera", ", Manzana", ", Mango", ", Fresa", ", Mora."};
            //Console.WriteLine(string.Concat(ListaMercado2));

            // Arreglo de bidimensionalidad "Matrices"

            //int[,] numeros = new int[4, 4];
            //for (int c = 0; c < 4; c++)
            //{
            //    for (int f = 0; f < 4; f++)
            //    {
            //        Console.WriteLine("Columna numero {0} de la fila {1}", c, f);
            //        Console.WriteLine("Ingrese elemento de la lista");
            //        numeros[f, c] = Convert.ToInt16(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("La lista de elementos es: ");
            //foreach (var item in numeros)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadKey();
        }
    }
}
