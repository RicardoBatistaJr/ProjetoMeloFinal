﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.classesBasicas
{
    public class Cliente
    {
        private string cpfCliente;
        private string nomeCliente;
        private string emailCliente;
        private string telCliente;

        public string CpfCliente { get => cpfCliente; set => cpfCliente = value; }
        public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public string TelCliente { get => telCliente; set => telCliente = value; }
    }
}
