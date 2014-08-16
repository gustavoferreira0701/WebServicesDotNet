using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using WCF.Contrato;

namespace WCF.Servico
{   
    public class Mensagem:IMensagem
    {   
        public string MensagemBoasVindas()
        {
            return "Mais um projeto WCF";
        }
    }
}
