using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double _numero;

        /// <summary>
        /// Recibe un string y lo asigna al atributo _numero de la instancia previa validación
        /// </summary>
        /// <param name="numero">String a ser asignado en _numero</param>
        private string SetNumero
        {
            set
            {
                this._numero = ValidarNumero(value);
            }
        }

        /// <summary>
        /// Inicializa el atributo _numero en 0
        /// </summary>
        public Numero() : this(0)
        {

        }

        /// <summary>
        /// Inicializa el atributo _numero con el valor del parametro recibido
        /// </summary>
        /// <param name="numero">Valor para inicializar el atributo _numero</param>
        public Numero(double numero)
        {
            this._numero = numero;
        }

        /// <summary>
        /// Inicializa luego de validar
        /// </summary>
        /// <param name="numero"></param>
        public Numero(string numero)
        {
            this.SetNumero = numero;
        }


        /// <summary>
        /// Recibe un string y lo parsea a double
        /// </summary>
        /// <param name="numeroString">String a parsear</param>
        /// <returns> Devuelve el valor del string recibido en forma de double, si no lo puede parsear devuelve 0</returns>
        private double ValidarNumero(string numeroString)
        {
            double value = 0;
            double.TryParse(numeroString, out value);


            return value;
        }


        /// <summary>
        /// convertirá un número binario a decimal, en caso de ser posible. Caso contrario retornará "Valor inválido".
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public string BinarioDecimal(string a)
        {
            double d = 0, resultado = 0, potencia = 0;
            string s2 = "", s3 = "";

            for (int i = (a.Length - (1)); i >= 0; i--)
            {

                s2 = s2 + a.Substring(i, 1);

            }

            for (int i = (s2.Length - (1)); i >= 0; i--)
            {

                s3 = s2.Substring(i, 1);

                if (s3 == "1")
                {
                    potencia = Math.Pow(2, i);
                    resultado += potencia;
                }
                else if (s3 != "0" && s3 != "1")
                {
                    return "valor invalido";
                }
            }


            d = resultado;
            string ok = d.ToString();
            return ok;
        }

        /// <summary>
        /// convertirán un número decimal a binario, en caso de ser posible. Caso contrario retornará "Valor inválido
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {
            if (numero == 0)
            {
                return "valor invalido";
            }
            int resto = 0;
            int division;
            string strng = "";

            division = (int)numero;

            do
            {

                resto = division % 2;

                division = division / 2;

                strng += resto;

            } while (division > 0);
            string result = "";
            for (int i = strng.Length - 1; i >= 0; i--)
            {
                result += strng.Substring(i, 1);
            }

            return result;
        }


        /// <summary>
        /// convertira un número decimal a binario, en caso de ser posible. Caso contrario retornará "Valor inválido
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(string numero)
        {
            double resultado = this.ValidarNumero(numero);
            if (resultado == 0)
                return "valor invalido";
            string ok = this.DecimalBinario(resultado);
            return ok;
        }


        public static double operator -(Numero n1, Numero n2)
        {
            return n1._numero - n2._numero;
        }
        public static double operator *(Numero n1, Numero n2)
        {
            return (n2._numero * n1._numero);
        }
        public static double operator /(Numero n1, Numero n2)
        {
            if (n1._numero != 0 && n2._numero != 0)
                return (n2._numero / n1._numero);
            else
                return 0;
        }
        public static double operator +(Numero n1, Numero n2)
        {
            return n1._numero + n2._numero;

        }
    }
}
