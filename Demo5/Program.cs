using System;

namespace Demo5
{
    // Control de excepciones
    class ManejoExcepciones
    {
        // Manejo de excepciones con try catch throw
        public decimal Dividir(int num1, int num2)
        {
            try
            {
                return num1 / num2;
            }
            catch (Exception ex)
            {
                // La palabra Throw genera un error
                throw new Exception("Error manejo excepción", ex);
            }
        }


        // Manejo de excepciones con throw
        public decimal DividirA(int num1, int num2)
        {
            var resultado = num1 / num2;
            if (num2 == 0)
                throw new DivideByZeroException();
            return resultado;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            // En el Try va el codigo fuente que quiero controlar
            try
            {
                var manejoExcepciones = new ManejoExcepciones(); 
                Console.WriteLine(manejoExcepciones.DividirA(1, 0));
            }
            // En el catch envio mensaje descriptivo del error
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message} {ex.TargetSite} {ex.StackTrace}");
            }


            // Especificar con que tecla puede el usuario salir de la consola
            ConsoleKeyInfo info;
            do
            {
                info = Console.ReadKey();
            } while (info.Key != ConsoleKey.Enter);
        }
    }
}
