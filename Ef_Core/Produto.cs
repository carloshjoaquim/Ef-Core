using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Ef_Core
{
    public class Produto
    {
        public int Id { get; internal set; }
        public string Nome { get; internal set; }
        public string Categoria { get; internal set; }
        public double Preco { get; internal set; }
    }
}