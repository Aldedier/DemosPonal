using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4
{
    public class Enumeraciones
    {
        #region Propiedades

        /// <summary>
        /// Propiedad para acceder a el numero de llantas
        /// </summary>
        public NumeroLLantas NumLlantas { get; set; }

        /// <summary>
        /// Propiedad para acceder al color
        /// </summary>
        public ColorVehiculo Color { get; set; }

        /// <summary>
        /// Propiedad para acceder a la velocidad
        /// </summary>
        public int Velocidad { get; set; }

        /// <summary>
        /// Propiedad para acceder a el numero de puertas
        /// </summary>
        public int NumPuertas { get; set; }

        /// <summary>
        /// Propiedad para acceder a la marca
        /// </summary>
        public string Marca { get; set; }

        #endregion


        /// <summary>
        /// Colección para definir un color para el vehiculo
        /// </summary>
        public enum ColorVehiculo
        {
            Rojo = 1, Gris, Negro, Amarillo, Azul, Naranja, Verde, Blanco
        }

        /// <summary>
        /// Colección para definir el numero de llantas
        /// </summary>
        public enum NumeroLLantas : int
        {
            Una = 1, Dos, Tres, Cuatro, Cinco, Seis, Siete, Ocho
        }

        /// <summary>
        /// Colección para definir la marca del vehiculo
        /// </summary>
        public enum MarcaCarro
        {
            Mazda = 1, Chevrolet, Suzuki, Honda, Fiat, BMW, Kia
        }

        /// <summary>
        /// Colección para definir la marca del vehiculo
        /// </summary>
        public enum MarcaMoto
        {
            Pulsar = 1, AKT, Suzuki, Honda, Kawasaki, BMW, Bajaj
        }

        /// <summary>
        /// Colección para definir la marca del vehiculo
        /// </summary>
        public enum MarcaAvion
        {
            Boeing_747 = 1, Airbus, McDonnell_Douglas, F22, F15, B2, Sesna
        }

        /// <summary>
        /// Colección para definir la marca del vehiculo
        /// </summary>
        public enum MarcaCicla
        {
            Shimano = 1, Trek, Merida, Orbea, Norco, Giant
        }

    }
}
