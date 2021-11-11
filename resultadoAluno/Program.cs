using System;

namespace resultadoAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, media;
            Console.WriteLine("Digite a primeira nota do aluno:");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota do aluno:");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota do aluno:");
            nota3 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;

            if (media >= 7)
            {
                Console.WriteLine($"A média do aluno foi de {media.ToString("0.00")}.\n Aluno foi aprovado!");
            } else if (media >= 4)
            {
                Console.WriteLine($"A média do aluno é de {media.ToString("0.00")}.\n Aluno está em prova final!");
            } else
            {
                Console.WriteLine($"A média do aluno foi de {media.ToString("0.00")}.\n Aluno foi reprovado.");
            }
        }
    }
}
