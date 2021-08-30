using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculadoraCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("***************************************************************");
                Console.WriteLine("==================== Calculadora_Padawan_2 ====================");
                Console.WriteLine("***************************************************************");
                Console.WriteLine("             Insira a entrada da seguinte forma ");
                Console.WriteLine("                  Número  Operador  Número");
                Console.WriteLine("***************************************************************");
                Console.WriteLine("               Digite SAIR / sair ");
                Console.WriteLine("***************************************************************");
            }

            bool isSair = false;

            while (!isSair)
            {
                try
                {
                    string entrada = Console.ReadLine();
                    if (entrada == "SAIR" || entrada == "sair")
                    {
                        isSair = true;
                    }
                    else
                    {
                       
                        string[] operacao = entrada.Split(' ');
                        double num1 = double.Parse(operacao[0], CultureInfo.InvariantCulture);
                        char operador = char.Parse(operacao[1]);
                        double num2 = double.Parse(operacao[2], CultureInfo.InvariantCulture);
                        
                        double resultado = OperacoesBasicas.Calcular(num1, operador, num2);

                         if (!(operador == '+' || operador == '-' || operador == '*' || operador == '/'))
                        {
                            Console.WriteLine("Entrada inválida, tente novamente");
                        }
                         else if (operador == '/' && num2 == 0)
                        {
                             Console.WriteLine("Não é possível fazer divisão por zero");
                        }
                        else
                        {
                            Console.WriteLine(resultado.ToString("F3", CultureInfo.InvariantCulture));
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine(" Voçê não digitou uma entrada válida!!!");

                }
            }

        }
    }
}