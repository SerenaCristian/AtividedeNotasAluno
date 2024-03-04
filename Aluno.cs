using System;


namespace Notas_alunos
{
    public class Aluno
    {
        public double Nota1, Nota2, Nota3;
        public double Resultado;
        public string NomeAluno;
        public double PontosFaltantes;
        public string dot = new string('*', 50);
        public double CalculaNota(string NomeAluno, double Nota1, double Nota2, double Nota3, double Resultado, double PontosFaltantes )
        {
            Resultado = (Nota1 * 30 / 100) + (Nota2 * 35 / 100) + (Nota3 * 35 / 100);

            if (Resultado >= 60)
            {
                Console.WriteLine($"O Aluno {NomeAluno} está APROVADO com o resultado {Resultado.ToString("F2")}");
            }
            else
            {
                PontosFaltantes = 60 - Resultado;
                Console.WriteLine($"O aluno {NomeAluno} está REPROVADO com nota final {Resultado.ToString("F2")}.");
                Console.WriteLine($"Faltam {PontosFaltantes.ToString("F2")} pontos para o aluno ser aprovado.");
                Console.WriteLine(dot);
            }

            return Resultado;
        }

    }
}
