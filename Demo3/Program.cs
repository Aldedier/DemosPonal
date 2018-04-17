using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            EjercicioMetodos metodos = new EjercicioMetodos();

            // ***** 5 metodos del mismo nombre con diferentes sobrecargas ******
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Hola, tengo la capacidad de sumar hasta 5 numeros, digita acontinuación cuantos numeros quieres que se sumen!!!");
            switch(Convert.ToInt16(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Suma de 1 numeros es: " + metodos.SumarNumeros(1));
                    break;
                case 2:
                    Console.WriteLine("Suma de 2 numeros es: " + metodos.SumarNumeros(1, 2));
                    break;
                case 3:
                    Console.WriteLine("Suma de 3 numeros es: " + metodos.SumarNumeros(1, 2, 3));
                    break;
                case 4:
                    Console.WriteLine("Suma de 4 numeros es: " + metodos.SumarNumeros(1, 2, 3, 4));
                    break;
                case 5:
                    Console.WriteLine("Suma de 5 numeros es: " + metodos.SumarNumeros(1, 2, 3, 4, 5));
                    break;
                default:
                    Console.WriteLine("Numero no valido");
                    break;
            }

            // ***** 5 metodos con parametros por referencia "ref"******
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            int num1 = 2, num2 = 3;
            Console.WriteLine("La multiplicación de los numeros es: " + metodos.MultiplicarNumeros(ref num1, ref num2));

            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            string nombre = "Aldedier";
            Console.WriteLine("La concatenación de los nombres es: " + metodos.ConcatenarNombres(ref nombre, " Martinez"));

            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            bool varBoleana = true;
            Console.WriteLine("La variable boleana pasada por referencia es igual a: " + metodos.VariableBoleana(ref varBoleana));

            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            string nombreFuncion = "Alberto Bejarano";
            Console.WriteLine("El nombre es: " + metodos.CambiarNombre(ref nombreFuncion));

            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Programa para hacer una operación aritmetica con 2 numeros, digite 1 para sumar, 2 para restar, 3 para multiplicar y 4 para dividir");
            int operacion = Convert.ToInt16(Console.ReadLine());
            switch (operacion)
            {
                case 1:
                    Console.WriteLine("Ingrese el primer numero");
                    int numero1 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    int numero2 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("El resultado de la suma es: " + metodos.Operacion(ref operacion, ref numero1, ref numero2));
                    break;
                case 2:
                    Console.WriteLine("Ingrese el primer numero");
                    numero1 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    numero2 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("El resultado de la resta es: " + metodos.Operacion(ref operacion, ref numero1, ref numero2));
                    break;
                case 3:
                    Console.WriteLine("Ingrese el primer numero");
                    numero1 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    numero2 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("El resultado de la multiplicación es: " + metodos.Operacion(ref operacion, ref numero1, ref numero2));
                    break;
                case 4:
                    Console.WriteLine("Ingrese el primer numero");
                    numero1 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    numero2 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("El resultado de la división es: " + metodos.Operacion(ref operacion, ref numero1, ref numero2));
                    break;
                default:
                    Console.WriteLine("Numero no valido");
                    break;
            }

            // ***** 1 metodo con parametros opcionales "inicializar parametros" ******
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine("El resultado es: " + metodos.SumarNumerosOpcionales(5, 5));
            Console.WriteLine("El resultado es: " + metodos.SumarNumerosOpcionales(5, 5, 5));
            Console.WriteLine("El resultado es: " + metodos.SumarNumerosOpcionales(5, 5, 5, 5));
            Console.WriteLine("El resultado es: " + metodos.SumarNumerosOpcionales(5, 5, 5, 5, 5));



            // ***** 1 metodo con parametros de retorno "out" ******
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            int resultado;
            metodos.ParametroSalida(out resultado);
            Console.WriteLine("El resultado es: {0} ", resultado);

            Console.ReadKey();
        }
    }
}
