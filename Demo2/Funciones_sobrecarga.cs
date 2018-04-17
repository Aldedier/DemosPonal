using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    class Funciones_sobrecarga
    {
        // Sobrecarga de metodos
        /// <summary>
        /// Este metodo lo que hace es procesar la información y ya
        /// </summary>
        public void StopService()
        {

        }

        /// <summary>
        /// Este metodolo que hace es procesar la información, de acuerdo al valor del parametro cadena de texto
        /// </summary>
        /// <param name="_serviceName"></param>
        public void StopService(string _serviceName)
        {

        }

        /// <summary>
        /// Este metodolo que hace es procesar la información, de acuerdo al valor del parametro entero
        /// </summary>
        /// <param name="_serviceId"></param>
        public void StopService(int _serviceId)
        {

        }

        /// <summary>
        /// Este metodo tiene 1 parametro obligatorio y 2 opcionales.
        /// </summary>
        /// <param name="forceStop"></param>
        /// <param name="serviceName"></param>
        /// <param name="_serviceId"></param>
        /// <returns></returns>
        public int StopServiceParametrosOpcionales(bool _forceStop, string _serviceName = null, int _serviceId = 1)
        {
            if (_serviceName == null)
                return 0;
            else
                return _serviceName.Length;
        }

        /// <summary>
        /// Este metodo sirve para declarar 2 parametro de entrada y 2 de salida
        /// </summary>
        /// <param name="serviceName"></param>
        /// <param name="statusMessage"></param>
        /// <returns></returns>
        public bool IsServiceOnline(string serviceName, out string statusMessage)
        {
            var isOnline = true;
            if (serviceName == null)
            {
                isOnline = false;
                statusMessage = "El nombre del servicio es nulo";
            }
            else
            {
                if (serviceName == "SalesService")
                {
                    statusMessage = "El servicio está actualmente encendido";
                }
                else
                {
                    statusMessage = "El servicio está actualmente apagado";
                }
            }
            return isOnline;
        }

        // Utilizacion de la palabra ref "utiliza un espacio en memoria de una variable ya creada"
        /// <summary>
        /// Este metodolo que hace es procesar la información, de acuerdo al valor del parametro
        /// </summary>
        /// <param name="upTime"></param>
        public void EnviarValor(int upTime)
        {
            upTime = 3;
        }


        /// <summary>
        /// Este metodolo que hace es procesar la información, de acuerdo al valor del parametro por referencia
        /// </summary>
        /// <param name="upTime"></param>
        public void EnviarValorPorReferencia(ref int upTime)
        {
            upTime = 3;
        }




    }
}
