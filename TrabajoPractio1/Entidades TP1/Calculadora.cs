using System;

namespace Entidades_TP1
{
    public static class Calculadora
    {
        private static char ValidarOperando(char operador)
        {
            if(operador == '-' || operador == '+' || operador == '/' || operador == '*')
            {
                return operador;
            }
            return '+';
        }

        public static double Operar(Operando num1, Operando num2, char operador)
        {
            char operadorValidado = ValidarOperando(operador);
            double result = 0;
            switch(operadorValidado)
            {
                case '+':
                    {
                        result = num1 + num2;
                        break;
                    }
                case '-':
                    {
                        result = num1 - num2;
                        break;
                    }
                case '*':
                    {
                        result = num1 * num2;
                        break;
                    }
                case '/':
                    {
                        result = num1 / num2;
                        break;
                    }
            }
            return result;
        }
    }
}
