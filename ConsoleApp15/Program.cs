using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int na, j;
            float media_min = 7.0f;
            string[] conc = new string[50];
            string[] nome = new string[50];
            string[] materia = new string[50];
            string[] ra = new string[50];
            float[] nota_p1 = new float[50];
            float[] nota_p2 = new float[50];
            float[] ms = new float[50];
            Console.Write("Digite a quantidade de alunos: ");
            na = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= na; i++)
            {
                Console.Write("Digite o nome do aluno: ");
                nome[i] = Console.ReadLine();
                Console.Write("Digite o ra do aluno: ");
                ra[i] = Console.ReadLine();
                Console.Write("Digite a matéria do aluno: ");
                materia[i] = Console.ReadLine();
                Console.Write("Digite a nota p1 do aluno: ");
                nota_p1[i] = Convert.ToSingle(Console.ReadLine());
                Console.Write("Digite a nota p2 do aluno: ");
                nota_p2[i] = Convert.ToSingle(Console.ReadLine());
                ms[i] = (nota_p1[i] + nota_p2[i]) / 2;
                if (ms[i] > media_min)
                    conc[i] = "Aprovado";
                else
                    conc[i] = "Reprovado";
            }
            Console.Write("\nNome:\tRa:\tMateria:\tNotaP1:\tNotaP2:\tMédia:\tConclusão:");
            for (int i = 1; i <= na; i++)
            {
                Console.Write("\n{0}\t{1}\t{2}\t{3:f1}\t{4:f1}\t{5:f1}\t{6:f1}", nome[i], ra[i], materia[i], nota_p1[i], nota_p2[i], ms[i],conc[i]);
            }
            Console.ReadKey();
        }    
    }
}
