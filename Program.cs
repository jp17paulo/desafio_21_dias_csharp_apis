using System;

namespace desafio_21_dias_csharp_apis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Daniel é um agricultor e precisa de um programa que ao digitar o numero inicial 1 e final 10, o programa mostra
                repetidamente todos os números na tela 
            */

            Console.WriteLine("Digite o numero inicial");
            var numeroInicial = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o número final");
            int numeroFinal = Convert.ToInt32(Console.ReadLine());

            int indice = numeroInicial;

            // while (indice <= numeroFinal)
            // {
            //     Console.WriteLine(indice);
            //     indice++;
            // }

            // for (int i = numeroInicial; i <= numeroFinal; i++)
            // {
            //     Console.WriteLine(i);
            // }

            int[] itens = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int item in itens)
            {
                Console.WriteLine(item);
            }




            //Se tivesse algum código abaixo do return não executaria
            return;


            //Console.WriteLine("teste");
        }
    }
}
