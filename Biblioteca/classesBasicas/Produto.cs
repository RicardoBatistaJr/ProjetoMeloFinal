﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.classesBasicas
{
    public class Produto
    {
        private int codProduto;
        private int saldoProduto;
        private DateTime dataFabricacao;
        private string nomeProduto;
        private float precoProduto;
        private string statusProduto;

        public int CodProduto { get => codProduto; set => codProduto = value; }
        public int SaldoProduto { get => saldoProduto; set => saldoProduto = value; }
        public DateTime DataFabricacao { get => dataFabricacao; set => dataFabricacao = value; }
        public string NomeProduto { get => nomeProduto; set => nomeProduto = value; }
        public float PrecoProduto { get => precoProduto; set => precoProduto = value; }
        public string StatusProduto { get => statusProduto; set => statusProduto = value; }
      
    }
}
