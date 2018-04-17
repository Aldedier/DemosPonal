using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    class EjercicioMetodos
    {
        // ***** 5 metodos del mismo nombre con diferentes sobrecargas ******

        public int SumarNumeros(int _a)
        {
            return 0;
        }

        public int SumarNumeros(int _a, int _b)
        {
            return _a + _b;
        }

        public int SumarNumeros(int _a, int _b, int _c)
        {
            return _a + _b + _c;
        }

        public int SumarNumeros(int _a, int _b, int _c, int _d)
        {
            return _a + _b + _c + _d;
        }

        public int SumarNumeros(int _a, int _b, int _c, int _d, int _e)
        {
            return _a + _b + _c + _d + _e;
        }


        // ***** 5 metodos con parametros por referencia "ref"******


        public int MultiplicarNumeros(ref int _num1, ref int _num2)
        {
            return _num1 * _num2;
        }

        public string ConcatenarNombres(ref string _nombre, string _apellido)
        {
            return _nombre + _apellido;
        }

        public bool VariableBoleana(ref bool _vBoleana)
        {
            return _vBoleana;
        }

        public string CambiarNombre(ref string _nombre)
        {
            _nombre = "Aldedier Martinez";
            return _nombre;
        }

        public int Operacion(ref int operacion, ref int _a, ref int _b)
        {
            int resultado = 0;
            if (operacion == 1)
                resultado = _a + _b;
            else if (operacion == 2)
                resultado = _a - _b;
            else if (operacion == 3)
                resultado = _a * _b;
            else if (operacion == 4)
                resultado = _a / _b;
            else
                resultado = 0;
            return resultado;
        }

        // ***** 5 metodos con parametros opcionales "inicializar parametros" ******

        public int SumarNumerosOpcionales(int _a, int _b, int _c = 0, int _d = 0, int _e = 0)
        {
            return _a + _b + _c + _d + _e;
        }


        // ***** 5 metodos con parametros de retorno "out" ******

        public void ParametroSalida(out int res)
        {
            res = 5 * 5;
        }


    }
}
