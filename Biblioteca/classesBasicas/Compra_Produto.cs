    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.classesBasicas
{
    public class Compra_Produto
    {
        private int qtdCompra;
        private float valorTotal;
        private Produto produto;
        private Compra compra;
        private DateTime validade;

        public int QtdCompra { get => qtdCompra; set => qtdCompra = value; }
        public float ValorTotal { get => valorTotal; set => valorTotal = value; }
        public Produto Produto { get => produto; set => produto = value; }
        public Compra Compra { get => compra; set => compra = value; }
        public DateTime Validade { get => validade; set => validade = value; }
    }
}
