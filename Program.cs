using System;
using System.Collections.Generic;
using console_desafio21dias_api;

namespace desafio_21_dias_csharp_apis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Valkiria é a diretora da escola Mundo Melhor
            Ela precisa de um programa que armazene alunos com suas matrículas e notas em uma tabela
            no final ela tem a necessidade de saber se o aluno foi aprovado ou não.
            Faça um programa para resolver a questão da Valkiria
            */

            Console.WriteLine("Bem vinda, Valkiria!\n");
            var opcao = "s";
            List<Aluno> alunos = new List<Aluno>();
            while (opcao.ToLower() == "s")
            {
                var aluno = new Aluno();

                Console.WriteLine("Digite o nome do aluno:");
                aluno.Nome = Console.ReadLine();
                Console.WriteLine("Digite a matrícula do aluno:");
                aluno.Matricula = Console.ReadLine();
                Console.WriteLine("Digite as notas do aluno:");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"{i + 1}ª nota:");
                    aluno.Notas.Add(Convert.ToDouble(Console.ReadLine()));
                }
                alunos.Add(aluno);

                Console.Clear();
                Console.WriteLine("Cadastrar outro aluno? s/n");
                opcao = Console.ReadLine();
            }
            Console.Clear();
            foreach (var aluno in alunos)
            {
                Console.WriteLine("────────────────────────────────");
                Console.WriteLine($"Nome: {aluno.Nome}");
                Console.WriteLine($"Matrícula: {aluno.Matricula}");
                Console.WriteLine($"Notas: {string.Join(",", aluno.Notas.ToArray())}");
                Console.WriteLine($"Média: {aluno.CalcularMedia()}");
                Console.WriteLine($"Situação: {aluno.Situacao()}");
                Console.WriteLine("────────────────────────────────");
            }
            Console.WriteLine("────────────────────────────────");
        }
    }
}

