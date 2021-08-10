using System;

namespace desafio_21_dias_csharp_apis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*=========================*/
            /*==PADRÃO DE CODIFICAÇÃO==*/
            /*=========================*/

            ///camelCase
            ///Ex.: numeroUm

            ///PascalCase
            ///Ex.:Program

            ///underscore
            ///Ex.: unders_core

            /*=========================*/
            /*=========================*/
            /*=========================*/

            /// var numerroUm = 1;
            /// int numeroDois = 2;

            /*===============================================*/
            /*======Dados disponibilizados pelo usuário======*/
            /*===============================================*/

            // Console.WriteLine("Digite o primeiro número: ");
            // var numerroUm = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Digite o segundo número: ");
            // int numeroDois = Convert.ToInt32(Console.ReadLine());

            /// var soma = numerroUm + numeroDois;

            //var soma = numerroUm * numeroDois;

            /// Console.WriteLine(soma);

            ///Console.WriteLine($"Que é o resultado da soma dos {numerroUm} + {numeroDois} ?");
            //Console.WriteLine($"Digite o número premiado: ");
            //int resultado = Convert.ToInt32(Console.ReadLine());

            /// if (soma == resultado)
            // if (soma == resultado || resultado == 1 || resultado == 10 || (resultado >= 100 && resultado <= 200))
            // {
            //     Console.WriteLine($"Parabéns !!! Você acertou o resultado:  {soma}");
            // }
            // else if (soma == 20)
            // {
            //     Console.WriteLine($"Você acertou a opção extraordinária:  incrível !!!");
            // }
            // else
            // {
            //     Console.WriteLine($"O resultado é:  {soma}, você errou, tente novamente !!!");
            // }

            ///Console.WriteLine($"A soma das variáveis é: {soma}");
            ///Console.WriteLine("A soma das variáveis é: " + soma);
            ///Console.WriteLine("A soma das variáveis é: {0}", soma);

            int caseSwitch = 1;

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

            if (caseSwitch == 1)
            {
                Console.WriteLine("Case 1");
            }
            else if (caseSwitch == 2)
            {
                Console.WriteLine("Case 2");
            }
            else
            {
                Console.WriteLine("Default case");
            }
        }
    }
}
