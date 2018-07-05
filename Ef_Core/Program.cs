using System;

namespace Ef_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando Entity Framework Core !");

            GravarUsandoEntity();

        }

        private static void GravarUsandoEntity()
        {
            var produto = new Produto
            {
                Nome = "Cassino Royale",
                Categoria = "Ação",
                Preco = 19.50
            };

            using (var repo = new LojaContext())
            {
                repo.Produtos.Add(produto);
                repo.SaveChanges();
            }

            Console.ReadKey();

        }
    }
}
