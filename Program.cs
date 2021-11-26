using System;
using System.Globalization;

namespace AppVetorExercicio02
{
    /// <summary>
    /// Exercicio 02 - Fixação vetores.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, entre com a quantidade de produtos, o nome e o preço: ");
            int n = int.Parse(Console.ReadLine());
            Produto[] produtos = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                produtos[i] = new Produto
                {
                    nomeProduto = nome,
                    precoProduto = preco
                };
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += produtos[i].precoProduto;
            }

            double avg = soma / n;
            Console.WriteLine("A média de preço é: " + avg.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
