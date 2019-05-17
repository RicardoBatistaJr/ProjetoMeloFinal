using Biblioteca.classesBasicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaPopTec_1._0.Dados
{
    public interface ICompraDados
    {
        void CadastrarCompra(Compra compra);
        void AlterarCompra(Compra compra);
        void CancelarCompra(Compra compra);
        List<Compra> ConsultarCompra(Compra filtro);
        List<Compra> ListarCompras();
    }
}
