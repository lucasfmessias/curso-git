using System;

namespace Exerc_FixacaoMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a dimensão da matriz N x M:");

            string[] s = Console.ReadLine().Split(' ');

            int n = int.Parse(s[0]);
            int m = int.Parse(s[1]);

            int[,] mat = new int[n, m];

            // Loading data in matrix
            Console.WriteLine("Informe os elementos da Matriz " + n + " x " + m );
            for (int i = 0; i < n; i++)
            {
                string[] sVetor = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    mat[i, j] = int.Parse(sVetor[j]);
                }
            }

            Console.WriteLine("Informe um número a localizar na matriz:");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mat[i, j] == num)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");

                        if (j - 1 >= 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (j + 1 < m)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i - 1 >= 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (i + 1 < n) // n = Linha
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
            
            Console.ReadLine();

        }
    }
}
