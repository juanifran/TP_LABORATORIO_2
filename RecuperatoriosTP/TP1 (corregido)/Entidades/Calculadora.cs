using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// Realiza operaciones matematicas con los parametros recibidos
        /// </summary>
        /// <param name="numero1">Primer instancia de Numero para operar</param>
        /// <param name="numero2">Segunda instancia de Numero para operar</param>
        /// <param name="operador">String que determina la operacion a realizar</param>
        /// <returns>Devuelve el resultado de la operacion, en caso de divicion por 0 devuelve 0</returns>
        public double Operar(Numero numero1, Numero numero2, string operador)
        {
            double value = 0;
            string operadorOk = ValidarOperador(operador);
            switch (operadorOk)
            {
                case "+":
                    value = numero1 + numero2;
                    break;
                case "-":
                    value = numero1 - numero2;
                    break;
                case "*":
                    value = numero1 * numero2;
                    break;
                case "/":
                    value = numero1 / numero2;
                    break;
            }
            return value;
        }

        /// <summary>
        /// Valida que el string recibido corresponda con alguna operacion
        /// </summary>
        /// <param name="operador">String a validar</param>
        /// <returns>Devuelve el string operador, si no corresponde con ninguna operacion delvuelve "+"</returns>
        private static string ValidarOperador(string operador)
        {
            if (operador != "-" && operador != "*" && operador != "/" && operador != "+")
            {
                operador = "+";
            }
            return operador;
        }
    }
}
