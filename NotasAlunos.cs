using System;

namespace Notas_alunos
{
    class NotasAlunos
    {
        static void Main(string[] args)
        {
            string dot = new string('*', 50);
            double nota1, nota2, nota3;
            double resultado;
            string nomeAluno;
            double pontosFaltantes;
            
            Console.WriteLine("Sistema Notas de Alunos");
            Console.WriteLine(dot);
    
            Console.Write("Digite o Nome do Aluno: ");
            nomeAluno = Console.ReadLine();

            Console.Write("Digite a Nota do primeiro trimestre: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a Nota do segundo trimestre: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a Nota do terceiro trimestre: ");
            nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine(dot);

            // Calcula as notas do aluno

            resultado = (nota1 * 30 / 100) + (nota2 * 35 / 100) + (nota3 * 35 / 100);

            if(resultado >= 60)
            {
                Console.WriteLine($"O Aluno {nomeAluno} está APROVADO com o resultado {resultado.ToString("F2")}");
            }
            else
            {
                pontosFaltantes = 60 - resultado;
                Console.WriteLine($"O aluno {nomeAluno} está REPROVADO com nota final {resultado.ToString("F2")}.");
                Console.WriteLine($"Faltam {pontosFaltantes.ToString("F2")} pontos para o aluno ser aprovado.");
                Console.WriteLine(dot);
            }
        }
    }
}
