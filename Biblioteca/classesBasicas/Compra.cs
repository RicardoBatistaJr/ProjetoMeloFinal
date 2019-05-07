﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.classesBasicas
{
   public class Compra
    {
        private int numCompra;
        private DateTime dataCompra;
        private Funcionario funcionario;
        private Fornecedor fornecedor;

        public int NumCompra { get => numCompra; set => numCompra = value; }
        public DateTime DataCompra { get => dataCompra; set => dataCompra = value; }
        public Funcionario Funcionario { get => funcionario; set => funcionario = value; }
        public Fornecedor Fornecedor { get => fornecedor; set => fornecedor = value; }
    }
}
