using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4
{
    class Program
    {
        static void Main(string[] args)
        {
            // La memoria RAM tiene dos partes (Heap "Informacion volatil - Se guarda los objetos" Informacion estatica en memoria - Stack ", ej: variables") el GC "Garbaje Collector"

            #region Carros creados

            Vehiculos.MoldeCarro carro1 = new Vehiculos.MoldeCarro();
            carro1.Color = Vehiculos.ColorVehiculo.Amarillo;
            carro1.Marca = Convert.ToString(Vehiculos.MarcaCarro.Chevrolet);
            carro1.NumLlantas = Vehiculos.NumeroLLantas.Cuatro;
            carro1.NumPuertas = 2;
            carro1.Acelerar(10);

            Vehiculos.MoldeCarro carro2 = new Vehiculos.MoldeCarro();
            carro2.Color = Vehiculos.ColorVehiculo.Azul;
            carro2.Marca = Convert.ToString(Vehiculos.MarcaCarro.BMW);
            carro2.NumLlantas = Vehiculos.NumeroLLantas.Cuatro;
            carro2.NumPuertas = 4;
            carro2.Acelerar(10);

            Vehiculos.MoldeCarro carro3 = new Vehiculos.MoldeCarro();
            carro3.Color = Vehiculos.ColorVehiculo.Negro;
            carro3.Marca = Convert.ToString(Vehiculos.MarcaCarro.Kia);
            carro3.NumLlantas = Vehiculos.NumeroLLantas.Cuatro;
            carro3.NumPuertas = 4;
            carro3.Acelerar(10);

            Vehiculos.MoldeCarro carro4 = new Vehiculos.MoldeCarro(5, Vehiculos.NumeroLLantas.Cuatro , Vehiculos.ColorVehiculo.Amarillo, "Masda");
            carro3.Acelerar(10);

            Vehiculos.MoldeCarro carro5 = new Vehiculos.MoldeCarro(4, (Vehiculos.NumeroLLantas)4, "Chevrolet");
            carro5.Color = Vehiculos.ColorVehiculo.Rojo;
            #endregion

            #region Motos creadas
            Vehiculos.MoldeMoto moto = new Vehiculos.MoldeMoto();
            moto.Acelerar(60);
            moto.Color = Vehiculos.ColorVehiculo.Azul;
            moto.Marca = Vehiculos.MarcaMoto.Suzuki.ToString();
            moto.NumLlantas = Vehiculos.NumeroLLantas.Dos;

            Console.WriteLine("Vamos a crear una moto");
            Vehiculos.MoldeMoto moto2 = new Vehiculos.MoldeMoto();

            Console.WriteLine("De que color quiere la moto?, 1 => Rojo, 2 => Gris, 3 => Negro, 4 => Amarillo, 5 => Azul");
            try
            {
                int color = Convert.ToInt16(Console.ReadLine());
                if (color >= 1 && color <= 5)
                {
                    moto2.Color = (Vehiculos.ColorVehiculo)color;
                    Console.WriteLine("La moto es de color: " + moto2.Color);
                }
                else
                {
                    color = 0;
                    Console.WriteLine("No asigno un color correcto");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message + " " + ex.StackTrace + " " + ex.TargetSite);
            }


            Console.WriteLine("De que marca quiere la moto?, 3 => Suzuki, 4 => Honda");
            try
            {
                int marca = Convert.ToInt16(Console.ReadLine());
                if (marca >= 3 && marca <= 4)
                {
                    moto2.Marca = Convert.ToString((Vehiculos.MarcaCarro)marca);
                    Console.WriteLine("La marca de la moto es: " + moto2.Marca);
                }
                else
                {
                    marca = 0;
                    Console.WriteLine("No asigno una marca correcta");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message + " " + ex.StackTrace + " " + ex.TargetSite);
            }

            #endregion

            #region Aviones creados

            Vehiculos.MoldeAvion avion1 = new Vehiculos.MoldeAvion();
            avion1.Color = Vehiculos.ColorVehiculo.Amarillo;
            avion1.Marca = Vehiculos.MarcaAvion.F22.ToString();
            avion1.NumLlantas = Vehiculos.NumeroLLantas.Dos;
            avion1.NumPuertas = 2;

            Vehiculos.MoldeAvion avion2 = new Vehiculos.MoldeAvion();
            avion2.Color = Vehiculos.ColorVehiculo.Blanco;
            avion2.Marca = Vehiculos.MarcaAvion.Boeing_747.ToString();
            avion2.NumLlantas = Vehiculos.NumeroLLantas.Cuatro;
            avion2.NumPuertas = 2;

            Vehiculos.MoldeAvion avion3 = new Vehiculos.MoldeAvion();
            avion3.Color = Vehiculos.ColorVehiculo.Blanco;
            avion3.Marca = Vehiculos.MarcaAvion.Boeing_747.ToString();
            avion3.NumLlantas = Vehiculos.NumeroLLantas.Dos;
            avion3.NumPuertas = 2;

            #endregion

            #region Ciclas creadas

            Vehiculos.MoldeCicla cicla1 = new Vehiculos.MoldeCicla();
            cicla1.Color = Vehiculos.ColorVehiculo.Gris;
            cicla1.Marca = Vehiculos.MarcaCicla.Giant.ToString();
            cicla1.NumLlantas = Vehiculos.NumeroLLantas.Dos;


            #endregion

            Console.ReadKey();
        }
    }
}
