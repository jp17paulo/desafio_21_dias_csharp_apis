using System;
using System.Collections.Generic;

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


            // int[][] alunos;

            // alunos[0][0] = "Danilo";
            // alunos[1][0] = "001";
            // alunos[2][0] = "10, 8, 5";

            // alunos[0][1] = "Jaison";
            // alunos[1][1] = "001";
            // alunos[2][1] = "10, 8, 5";

            // alunos[0][2] = "Sheila";
            // alunos[1][2] = "001";
            // alunos[2][2] = "10, 8, 5";

            // const int NOME = 0
            // const int MATRICULA = 1
            // const int NOTAS = 2

            // int linha = 0

            // alunos[linha][NOME]
            // alunos[linha][MATRICULA]
            // alunos[linha][NOTAS]

            /*
            Valkiria é a diretora da escola Mundo Melhor
            Ela precisa de um programa que armazene alunos com suas matrículas e notas em uma tabela
            no final ela tem a necessidade de saber se o aluno foi aprovado ou não.
            Faça um programa para resolver a questão da Valkiria
            */

            List<dynamic> alunos = new List<dynamic>();
            alunos.Add(new
            {
                Nome = "Danilo",
                Matricula = "001",
                Notas = "10, 8, 7"
            });

            alunos.Add(new
            {
                Nome = "Sheila",
                Matricula = "001",
                Notas = "10, 8, 7"
            });

            alunos.Add(new
            {
                Nome = "Stela",
                Matricula = "001",
                Notas = "10, 8, 7"
            });


            //Se tivesse algum código abaixo do return não executaria
            return;


            //Console.WriteLine("teste");
        }
    }
}
