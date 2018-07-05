using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ef_Core
{
    public class ProdutoDAO : IProdutoDAO, IDisposable
    {
        private readonly LojaContext _context;

        public ProdutoDAO()
        {
            _context = new LojaContext();
        }

        public void Adicionar(Produto p)
        {
            _context.Produtos.Add(p);
            _context.SaveChanges();
        }

        public void Atualizar(Produto p)
        {
            _context.Produtos.Update(p);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IList<Produto> Produtos()
        {
            return _context.Produtos.ToList();
        }

        public void Remover(Produto p)
        {
            _context.Produtos.Remove(p);
            _context.SaveChanges();
        }
    }
}
