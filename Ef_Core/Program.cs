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
            //RecuperarUsandoEntity();
            //DeletarUsandoEntity();
            //RecuperarUsandoEntity();
            AtualizaUsandoEntity();
            Console.ReadKey();
        }

        private static void AtualizaUsandoEntity()
        {
            // Incluir Produto.
            GravarUsandoEntity();
            RecuperarUsandoEntity();

            // Atualizar Produto.
            using (var repo = new LojaContext())
            {
                var primeiroProduto = repo.Produtos.First();
                primeiroProduto.Nome = "Cassino Royale - Alterado...";
                primeiroProduto.Preco += 0.50;
                repo.Produtos.Update(primeiroProduto);
                repo.SaveChanges();
            }

            RecuperarUsandoEntity();

        }

        private static void DeletarUsandoEntity()
        {
            using (var repo = new LojaContext())
            {
                var listaProdutos = repo.Produtos.ToList();

                foreach (var item in listaProdutos)
                {
                    repo.Produtos.Remove(item);
                }

                repo.SaveChanges();
            }
        }

        private static void RecuperarUsandoEntity()
        {
            using (var repo = new LojaContext())
            {
                var produtos = repo.Produtos.ToList();
                Console.WriteLine($"Foram encontrados {produtos.Count} produto(s) na base.");

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
        }
    }
}
