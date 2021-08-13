using System;
using System.Collections.Generic;
using console_desafio21dias_api;

namespace desafio_21_dias_csharp_apis
{
    class Program
    {
        static void Main(string[] args)
        {
            new Aluno() { Nome = "Gilmar", Matricula = "003", Notas = new List<double>() { 6, 6, 9 } }.Salvar();
            // new Aluno(){Nome = "Raul", Matricula = "004", Notas = new List<double>() {5, 6, 3} }.Salvar();
            // new Aluno(){Nome = "Marina", Matricula = "005", Notas = new List<double>() {9, 9, 10} }.Salvar();


            var alunosNoBanco = AlunoService.Todos();
            foreach (var aluno in alunosNoBanco)
            {
                // aluno.Notas.Add(10);
                // aluno.Salvar();
                // aluno.Apagar();
                // break;

                Console.WriteLine("────────────────────────────────");
                Console.WriteLine($"Nome: {aluno.Nome}");
                Console.WriteLine($"Matrícula: {aluno.Matricula}");
                Console.WriteLine($"Notas: {string.Join(",", aluno.Notas.ToArray())}");
                Console.WriteLine($"Média: {aluno.CalcularMedia()}");
                Console.WriteLine($"Situação: {aluno.Situacao()}");
                Console.WriteLine("────────────────────────────────");
            }

            // return;


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

