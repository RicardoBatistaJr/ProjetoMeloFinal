using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.classesBasicas
{
     public class VendaProduto 
    {
        private int qtd;
        private float preco;
        private Produto produto;
        // talvez deva receber uma LiST de produtos
        private Venda venda;

        public int Qtd { get => qtd; set => qtd = value; }
        public float Preco { get => preco; set => preco = value; }
        public Produto Produto { get => produto; set => produto = value; }
        public Venda Venda { get => venda; set => venda = value; }
    }
}
