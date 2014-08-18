using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace WCF.Contrato
{

    /// <summary>
    /// Contrato com as operações que estarão disponíveis para o consumidor do serviço
    /// </summary>
    [ServiceContract]
    public interface IServicoAutenticacao
    {
        [OperationContract]
        List<Usuario> ListarUsuarios(Usuario usuario);

        [OperationContract]
        bool AutenticarAcesso(string login, string senha);
    }   
}
