using System;

namespace Notas_alunos
{
    class NotasAlunos
    {
        static void Main(string[] args)
        {
            string dot = new string('.', 50);

            Aluno aluno = new Aluno();
            
            Console.WriteLine("Sistema Notas de Alunos");
            Console.WriteLine(dot);
    
            Console.Write("Digite o Nome do Aluno: ");
            aluno.NomeAluno = Console.ReadLine();

            Console.Write("Digite a Nota do primeiro trimestre: ");
            aluno.Nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a Nota do segundo trimestre: ");
            aluno.Nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a Nota do terceiro trimestre: ");
            aluno.Nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine(dot);

            aluno.CalculaNota(aluno.NomeAluno, aluno.Nota1, aluno.Nota2, aluno.Nota3, aluno.Resultado, aluno.PontosFaltantes);

        }
    }
}
