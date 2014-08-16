using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace WCF.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri[] listaEnderecos = new Uri[] { new Uri("http://localhost:9092") };

            using (ServiceHost host = new ServiceHost(typeof(WCF.Servico.Mensagem), listaEnderecos))
            {
                host.AddServiceEndpoint(typeof(WCF.Contrato.IMensagem), new BasicHttpBinding(), "Mensagem");

                host.Description.Behaviors.Add(new ServiceMetadataBehavior { HttpGetEnabled = true });

                host.Open();

                Console.Write("Serviço ativado \nPressione ENTER para desativar");

                Console.ReadKey();
            }
        }
    }
}
