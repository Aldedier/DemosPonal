using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.Codigo
{
    class miSegundaClase
    {
        // Variables
        string ColorOjos = "Azules";
        int a = 0;

        // Variable publica
        public int identificacion = 1055273250;


        // Propiedades
        public int miEdad { get; set; }
        public bool Sexo { get; set; }

        /* Funciones: 
        1. Ambito (Protected - Public - Private)
        2. Tipo de dato (int - bool - string)
        3. Nombre de la funcion
        4. Puede la función recibir parametros con parentesis (Aqui van los parametros, ejemplo: int edad, int precio)
        5. si no retorna valores se utiliza void en el tipo de dato.
         */

        // Funcion que no retorna nada y no recibe ningun parametros
        public void FuncionNoRetornaNoRecibeParametro()
        {
            miEdad = 45;
        }

        // Función que retorna un entero y no recibe parametros
        public int FuncionRetornaNoRecibeParametros()
        {
            return miEdad;
        }

        // Función que retorna un entero y recibe como parametros dos enteros
        public int FuncionRetornaRecibeParametros(int _a, int _b)
        {
            // this.a = a; // El this sirve para llamar una variable local y no las definidas en los parametros en el caso que se llamen igual.
            return _a * _b;
        }


        // Función que no retorna nada pero recibe un parametro
        public void FuncionNoRetornaRecibeParametro(int _a)
        {
            miEdad = _a;
        }
    }
}
