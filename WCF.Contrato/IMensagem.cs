using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace WCF.Contrato
{
    [ServiceContract]
    public interface IMensagem
    {
        [OperationContract]
        string MensagemBoasVindas();
    }
}
