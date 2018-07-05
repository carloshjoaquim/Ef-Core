using System;
using System.Collections.Generic;
using System.Text;

namespace Ef_Core
{
    interface IProdutoDAO
    {
        void Adicionar(Produto p);
        void Atualizar(Produto p);
        void Remover(Produto p);
        IList<Produto> Produtos();
    }
}
