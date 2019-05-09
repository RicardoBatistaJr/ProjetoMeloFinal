using Biblioteca.classesBasicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfFarmaPopTec
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService1" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IService1
    {
        // Cliente
        [OperationContract]
        void CadastrarCliente(Cliente cliente);
        [OperationContract]
        void AlterarCliente(Cliente cliente);
        [OperationContract]
        void DeletarCliente(Cliente cliente);
        [OperationContract]
        List<Cliente> ConsultarCliente(Cliente filtro);
        [OperationContract]
        List<Cliente> ListarClientes();
        [OperationContract]
        List<Venda> ListarVendaCliente(Cliente cliente);
        [OperationContract]
        bool VerificarDuplicidadeCliente(Cliente cliente);
        [OperationContract]
        bool ValidaCpfCliente(string cpf);

        // Funcionario
        [OperationContract]
        void CadastrarFuncionario(Funcionario funcionario);
        [OperationContract]
        void AlterarFuncionario(Funcionario funcionario);
        [OperationContract]
        void DeletarFuncionario(Funcionario funcionario);
        [OperationContract]
        List<Funcionario> ConsultarFuncionario(Funcionario filtro);
        [OperationContract]
        List<Funcionario> ListarFuncionarios();
        [OperationContract]
        bool ExisteFuncionario(Funcionario funcionario);
        [OperationContract]
        bool ValidarCpfFuncionario(string cpf);

        // TODO: Adicione suas operações de serviço aqui
    }


    // Use um contrato de dados como ilustrado no exemplo abaixo para adicionar tipos compostos a operações de serviço.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
