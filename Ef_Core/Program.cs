using System;
using System.Collections.Generic;
using System.Linq;

namespace Ef_Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iniciando Entity Framework Core !");

            //GravarUsandoEntity();
            RecuperarUsandoEntity();

            Console.ReadKey();
        }

        private static void RecuperarUsandoEntity()
        {
            using (var repo = new LojaContext())
            {
                var produtos = repo.Produtos.ToList();

                foreach (var item in produtos)
                {
                    Console.WriteLine($"{item.Nome} - {item.Preco}");
                }
            }
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
