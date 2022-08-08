using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TP1
{
    public class Operando
    {
        private double numero;
        
        private double Numero
        {
            set { numero = ValidarOperando(value.ToString()); }
        }

        public Operando()
        {
            this.numero = 0;
        }

        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando(string strNumero)
        {
            this.numero = ValidarOperando(strNumero);
        }

        public static string BinarioDecimal(string binario)
        {
            if(!EsBinario(binario))
            {
                return "Valor Invalido";
            }
            else
            {
                int resultado = 0;
                int cantidadCaracteres = binario.Length;
                foreach (char caracter in binario)
                {
                    cantidadCaracteres--;
                    if (caracter == '1')
                    {
                        resultado += (int)Math.Pow(2, cantidadCaracteres);
                    }
                }
                return resultado.ToString();
            }
        }

        public static string DecimalBinario(double numero)
        { 

            return DecimalBinario(numero.ToString());

            /*string valorBinario = string.Empty;
            double resultDiv = numero;
            double restoDiv;

            if (resultDiv >= 0)
            {
                do
                {
                    restoDiv = resultDiv % 2;
                    restoDiv /= 2;
                    valorBinario = restoDiv.ToString() + valorBinario;

                } while (restoDiv > 0);
            }

            return valorBinario;*/
        }

        public static string DecimalBinario(string numero)
        {
            if(numero.All(char.IsDigit))
            {
                double doubleNumero = Convert.ToDouble(numero);
                string valorBinario = string.Empty;
                int resultDiv = (int)doubleNumero;
                int restoDiv;

                if (resultDiv >= 0)
                {
                    do
                    {
                        restoDiv = resultDiv % 2;
                        resultDiv /= 2;
                        valorBinario = restoDiv.ToString() + valorBinario;

                    } while (resultDiv > 0);
                }
                return valorBinario;
            }
            else
            {
                return "Valor inválido";
            }
        }

        private static bool EsBinario(string binario)
        {
            foreach (char c in binario)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }

        private double ValidarOperando(string strNumero)
        {
            if (double.TryParse(strNumero, out double entero) && entero > 0)
            {
                return entero;
            }
            return 0;
        }

        public static double operator -(Operando n1, Operando n2)
        {
            string n1String = n1.numero.ToString();
            string n2String = n2.numero.ToString();

            if(EsBinario(n1String) && EsBinario(n2String))
            {
                double doubleN1 = Convert.ToDouble(BinarioDecimal(n1String));
                double doubleN2 = Convert.ToDouble(BinarioDecimal(n2String));
                return doubleN1 - doubleN2;
            }
            else if (EsBinario(n1String) && !EsBinario(n2String))
            {
                double doubleN1 = Convert.ToDouble(BinarioDecimal(n1String));
                return doubleN1 - n2.numero;
            }
            else if (!EsBinario(n1String) && EsBinario(n2String))
            {
                double doubleN2 = Convert.ToDouble(BinarioDecimal(n2String));
                return n1.numero - doubleN2;
            }
            return (n1.numero - n2.numero);
        }

        public static double operator +(Operando n1, Operando n2)
        {
            string n1String = n1.numero.ToString();
            string n2String = n2.numero.ToString();

            if (EsBinario(n1String) && EsBinario(n2String))
            {
                double doubleN1 = Convert.ToDouble(BinarioDecimal(n1String));
                double doubleN2 = Convert.ToDouble(BinarioDecimal(n2String));
                return doubleN1 + doubleN2;
            }
            else if (EsBinario(n1String) && !EsBinario(n2String))
            {
                double doubleN1 = Convert.ToDouble(BinarioDecimal(n1String));
                return doubleN1 + n2.numero;
            }
            else if (!EsBinario(n1String) && EsBinario(n2String))
            {
                double doubleN2 = Convert.ToDouble(BinarioDecimal(n2String));
                return n1.numero + doubleN2;
            }
            return (n1.numero + n2.numero);
        }

        public static double operator /(Operando n1, Operando n2)
        {
            string n1String = n1.numero.ToString();
            string n2String = n2.numero.ToString();
            if (n2.numero == 0 )
            {
                return double.MinValue;
            }
            else
            {
                if (EsBinario(n1String) && EsBinario(n2String))
                {
                    double doubleN1 = Convert.ToDouble(BinarioDecimal(n1String));
                    double doubleN2 = Convert.ToDouble(BinarioDecimal(n2String));
                    return doubleN1 / doubleN2;
                }
                else if (EsBinario(n1String) && !EsBinario(n2String))
                {
                    double doubleN1 = Convert.ToDouble(BinarioDecimal(n1String));
                    return doubleN1 / n2.numero;
                }
                else if (!EsBinario(n1String) && EsBinario(n2String))
                {
                    double doubleN2 = Convert.ToDouble(BinarioDecimal(n2String));
                    return n1.numero / doubleN2;
                }
            }
            return (n1.numero / n2.numero);
        }

        public static double operator *(Operando n1, Operando n2)
        {
            string n1String = n1.numero.ToString();
            string n2String = n2.numero.ToString();

            if (EsBinario(n1String) && EsBinario(n2String))
            {
                double doubleN1 = Convert.ToDouble(BinarioDecimal(n1String));
                double doubleN2 = Convert.ToDouble(BinarioDecimal(n2String));
                return doubleN1 * doubleN2;
            }
            else if (EsBinario(n1String) && !EsBinario(n2String))
            {
                double doubleN1 = Convert.ToDouble(BinarioDecimal(n1String));
                return doubleN1 * n2.numero;
            }
            else if (!EsBinario(n1String) && EsBinario(n2String))
            {
                double doubleN2 = Convert.ToDouble(BinarioDecimal(n2String));
                return n1.numero * doubleN2;
            }
            return (n1.numero * n2.numero);
        }
    }
}
