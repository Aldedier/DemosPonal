using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4
{
    /// <summary>
    /// Clase principal donde se pueden crear un carro o una moto
    /// </summary>
    public class Vehiculos : Enumeraciones
    {
        #region Constructores

        /// <summary>
        /// Constructor del carro
        /// </summary>
        public Vehiculos()
        {

        }
        /// <summary>
        /// Constructor del carro con parametros
        /// </summary>
        /// <param name="_numPuertas"></param>
        /// <param name="_numLlantas"></param>
        /// <param name="_color"></param>
        /// <param name="_marca"></param>
        public Vehiculos(int _numPuertas, NumeroLLantas _numLlantas, ColorVehiculo _color, string _marca)
        {
            NumPuertas = _numPuertas;
            NumLlantas = _numLlantas;
            Color = _color;
            Marca = _marca;
        }

        /// <summary>
        /// Constructor del carro con parametros
        /// </summary>
        /// <param name="_numPuertas"></param>
        /// <param name="_numLlantas"></param>
        /// <param name="_marca"></param>
        public Vehiculos(int _numPuertas, NumeroLLantas _numLlantas, string _marca)
        {
            NumPuertas = _numPuertas;
            NumLlantas = _numLlantas;
            Marca = _marca;
        }

        /// <summary>
        /// Constructor del carro con parametros
        /// </summary>
        /// <param name="_numPuertas"></param>
        /// <param name="_numLlantas"></param>
        /// <param name="_marca"></param>
        public Vehiculos(NumeroLLantas _numLlantas, ColorVehiculo _color, string _marca)
        {
            NumLlantas = _numLlantas;
            Color = _color;
            Marca = _marca;
        }

        /// <summary>
        /// Constructor del carro con parametros
        /// </summary>
        /// <param name="_numPuertas"></param>
        /// <param name="_numLlantas"></param>
        /// <param name="_marca"></param>
        public Vehiculos(NumeroLLantas _numLlantas, string _marca)
        {
            NumLlantas = _numLlantas;
            Marca = _marca;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Metodo procedimental "Void" para frenar
        /// </summary>
        /// <param name="_presionaPedalFrenar"></param>
        public void Frenar(int _presionaPedalFrenar)
        {
            if (_presionaPedalFrenar > 0)
                Velocidad = _presionaPedalFrenar / 2;
        }

        #endregion

        /// <summary>
        /// Clase para crear un carro
        /// </summary>
        public class MoldeCarro : Vehiculos
        {

            #region Constructores
            /// <summary>
            /// Constructor del carro
            /// </summary>
            public MoldeCarro()
            {
            }
            /// <summary>
            /// Constructor del carro con parametros
            /// </summary>
            /// <param name="_numPuertas"></param>
            /// <param name="_numLlantas"></param>
            /// <param name="_color"></param>
            /// <param name="_marca"></param>
            public MoldeCarro(int _numPuertas, NumeroLLantas _numLlantas, ColorVehiculo _color, string _marca)
                : base(_numPuertas, _numLlantas, _color, _marca)
            {
            }


            /// <summary>
            /// Constructor del carro con parametros
            /// </summary>
            /// <param name="_numPuertas"></param>
            /// <param name="_numLlantas"></param>
            /// <param name="_marca"></param>
            public MoldeCarro(int _numPuertas, NumeroLLantas _numLlantas, string _marca)
                : base(_numPuertas, _numLlantas, _marca)
            {
            }
            #endregion

            #region Metodos

            /// <summary>
            /// Metodo procedimental "Void" para reserva
            /// </summary>
            /// <param name="_presionaPedalFrenar"></param>
            public void Reversa(int _presionaPedalFrenar)
            {
                if (_presionaPedalFrenar > 0)
                    Velocidad = _presionaPedalFrenar / 2;
            }

            /// <summary>
            /// Metodo procedimental "Void" para acelerar
            /// </summary>
            /// <param name="_presionaPedalAcelerar"></param>
            public void Acelerar(int _presionaPedalAcelerar)
            {
                if (_presionaPedalAcelerar > 0)
                    Velocidad = _presionaPedalAcelerar * 2;
                Velocidad = 0;
            }

            #endregion

        }

        /// <summary>
        /// Clase para crear una moto
        /// </summary>
        public class MoldeMoto : Vehiculos
        {

            #region Constructores
            /// <summary>
            /// Constructor de la moto
            /// </summary>
            public MoldeMoto()
            {
            }

            /// <summary>
            /// Constructor de la moto con parametros
            /// </summary>
            /// <param name="_numPuertas"></param>
            /// <param name="_numLlantas"></param>
            /// <param name="_color"></param>
            /// <param name="_marca"></param>
            public MoldeMoto(NumeroLLantas _numLlantas, ColorVehiculo _color, string _marca)
                : base (_numLlantas, _color, _marca)
            {
            }


            /// <summary>
            /// Constructor de la moto con parametros
            /// </summary>
            /// <param name="_numPuertas"></param>
            /// <param name="_numLlantas"></param>
            /// <param name="_marca"></param>
            public MoldeMoto(NumeroLLantas _numLlantas, string _marca)
                : base(_numLlantas, _marca)
            {
            }
            #endregion

            #region Metodos

            /// <summary>
            /// Metodo procedimental "Void" para acelerar
            /// </summary>
            /// <param name="_presionaPedalAcelerar"></param>
            public void Acelerar(int _presionaPedalAcelerar)
            {
                if (_presionaPedalAcelerar > 0)
                    Velocidad = _presionaPedalAcelerar * 2;
                Velocidad = 0;
            }

            #endregion
        }

        /// <summary>
        /// Clase para crear un avión
        /// </summary>
        public class MoldeAvion : Vehiculos
        {

            #region Constructores

            /// <summary>
            /// Contructor Default avion
            /// </summary>
            public MoldeAvion()
            {

            }

            /// <summary>
            /// Contructor Default avion con parametros
            /// </summary>
            public MoldeAvion(int _numPuertas, NumeroLLantas _numLlantas, ColorVehiculo _color, string _marca)
                : base(_numPuertas, _numLlantas, _color, _marca)
            {
            }
            #endregion

            #region Metodos

            /// <summary>
            /// Metodo procedimental "Void" para acelerar
            /// </summary>
            /// <param name="_presionaPedalAcelerar"></param>
            public void Acelerar(int _presionaPedalAcelerar)
            {
                if (_presionaPedalAcelerar > 0)
                    Velocidad = _presionaPedalAcelerar * 2;
                Velocidad = 0;
            }

            #endregion
        }

        /// <summary>
        /// Clase para crear una cicla
        /// </summary>
        public class MoldeCicla : Vehiculos
        {

            #region Constructores
            /// <summary>
            /// Contructor default
            /// </summary>
            public MoldeCicla()
            {

            }

            /// <summary>
            /// Constructor con parametros
            /// </summary>
            /// <param name="_numPuertas"></param>
            /// <param name="_numLlantas"></param>
            /// <param name="_color"></param>
            /// <param name="_marca"></param>
            public MoldeCicla(NumeroLLantas _numLlantas, ColorVehiculo _color, string _marca)
                : base (_numLlantas, _color, _marca)
            {
            }
            #endregion

            #region Metodos

            /// <summary>
            /// Metodo procedimental "Void" para acelerar
            /// </summary>
            /// <param name="_presionaPedalAcelerar"></param>
            public void Acelerar(int _presionaPedalAcelerar)
            {
                if (_presionaPedalAcelerar > 0)
                    Velocidad = _presionaPedalAcelerar * 2;
                Velocidad = 0;
            }

            #endregion
        }
    }

}
