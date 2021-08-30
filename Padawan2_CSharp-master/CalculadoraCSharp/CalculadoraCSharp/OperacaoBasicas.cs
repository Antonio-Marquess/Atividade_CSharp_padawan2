using System;


namespace CalculadoraCSharp
{

    class OperacoesBasicas
    {
        public static double Calcular(double num1, char operador, double num2)
        {
            switch (operador)
            {
                case '+':
                    return operacao.Soma.Calcular(num1, num2);
                case '-':
                    return operacao.Subtracao.Calcular(num1, num2);
                case '*':
                    return operacao.Multiplicacao.Calcular(num1, num2);
                case '/':
                    return operacao.Divisao.Calcular(num1, num2);
                default:
                    return 0.0;
            }
        }
    }
}


