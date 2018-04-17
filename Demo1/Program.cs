using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo1.Codigo;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conversión implicita
            int a = 6;
            int b = 5;
            a = b;

            //Conversión explicita
            long miNumero = 10;
            int nuevoNumero = (int)miNumero;

            //Conversores
            string numeroAConvertir = "2018";
            int numeroConvertido = Convert.ToInt16(numeroAConvertir);
            int numeroConvertido1 = int.Parse(numeroAConvertir);

            // Programa para saber la edad de una persona en meses
            Console.WriteLine("Ingrese su edad");
            int edad = Convert.ToInt16(Console.ReadLine());
            int MESES = 12;
            int EdadEnMeses = edad * MESES;
            Boolean miBoleano = true;
            String miDato = "Su edad en meses es: " + EdadEnMeses + " y es " + miBoleano;

            // Instrucción para escribir en pantalla
            Console.WriteLine(miDato);
            Console.WriteLine("Presione cualquier tecla para salir!!!");


            // Instanciar objeto miPrimeraClase
            miPrimeraClase m = new miPrimeraClase();
            Console.WriteLine(m.identificacion);
            Console.WriteLine(m.FuncionRetornaRecibeParametros(5,6));
            Console.WriteLine(m.FuncionRetornaNoRecibeParametros());

            // Instanciar objeto miSegundaClase
            miSegundaClase s = new miSegundaClase();
            s.miEdad = 30;
            Console.WriteLine("La edad del segundo objeto es "+ s.miEdad);
            s.FuncionNoRetornaNoRecibeParametro();
            Console.WriteLine("La edad del segundo objeto es " + s.miEdad);
            s.FuncionNoRetornaRecibeParametro(18);
            Console.WriteLine("La edad del segundo objeto es " + s.miEdad);
            Console.WriteLine("La edad en meses es " + s.FuncionRetornaRecibeParametros(s.miEdad, 12));


            miSegundaClase t = new miSegundaClase();
            t = s;
            t.FuncionNoRetornaRecibeParametro(17);
            Console.WriteLine("La edad del 2.2 objeto es " + s.miEdad);
            Console.WriteLine("La edad del 2.2 objeto es " + t.miEdad);

            
            Console.ReadKey();
        }
    }
}
