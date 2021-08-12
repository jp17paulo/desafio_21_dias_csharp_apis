using System;
using System.Collections.Generic;

namespace desafio_21_dias_csharp_apis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Valkiria é a diretora da escola Mundo Melhor
            Ela precisa de um programa que armazene alunos com suas matrículas e notas em uma tabela,
            no final ela tem a necessidade de saber se o aluno foi aprovado ou não.
            Faça um programa para resolver a questão da Valkiria
            */


            Console.WriteLine("=================================");
            Console.WriteLine("=====Bem vindo(a) ao sistema=====");
            Console.WriteLine("=================================");

            /**************************Objeto dinamico para criar os atributos do aluno**************************
              Obs: Norrmalmente um objeto dinamico é utilizado quando não se sabe o tipo do objeto que se recebe
            /**************************Objeto dinamico para criar os atributos do aluno***************************/
            List<dynamic> alunos = new List<dynamic>();

            double[] notas = new double[4];

            var nome = "";
            var matricula = "";

            while (true)
            {

                Console.WriteLine("Digite o nome do aluno");
                // alunos.Add(new
                // {
                //     Nome = Console.ReadLine(),
                // });
                nome = Console.ReadLine();

                Console.WriteLine("Digite a matrícula do aluno");
                // alunos.Add(new
                // {
                //     Matricula = Console.ReadLine(),
                // });
                matricula = Console.ReadLine();

                for (int i = 0; i <= 3; i++)
                {
                    Console.WriteLine($"Digite a {i + 1}ª nota do aluno");
                    notas[i] = Convert.ToDouble(Console.ReadLine());
                }

                alunos.Add(new
                {
                    Nome = nome,
                    Matricula = matricula,
                    Notas = notas,
                });

                Console.WriteLine("Deseja cadastrar outro aluno?\n1 - Sim\n2 - Não");

                if (Console.ReadLine() == "2")
                {
                    foreach (var aluno in alunos)
                    {
                        double somaNotas = 0;
                        for (int i = 0; i < 3; i++)
                        {
                            somaNotas += notas[i];
                        }
                        double media = somaNotas / 4;
                        string resultadoFinal = media >= 7 ? "Aprovado" : "Reprovado";

                        /*Situação resumida do aluno*/
                        // Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                        // Console.WriteLine($"O aluno {aluno.Nome} de matrícula {aluno.Matricula} obteve média {Math.Round(media, 1)} e foi {resultadoFinal}");
                        // Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

                        Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine($"Nome: {aluno.Nome}\nMatrícula: {aluno.Matricula}");
                        int n = 1;
                        foreach (double nota in notas)
                        {
                            Console.WriteLine($"{n}ª nota: {nota}");
                            n += 1;
                        }
                        Console.WriteLine($"Média: {Math.Round(media, 1)}\n{resultadoFinal}");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                    }
                    break;
                }

            }
            Console.ReadKey();
        }
    }
}

