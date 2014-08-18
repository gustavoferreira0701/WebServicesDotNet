using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using WCF.Servico;

namespace WCF.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri[] listaEnderecos = new Uri[] { new Uri("http://localhost:19233") };

            using (ServiceHost host = new ServiceHost(typeof(ServicoAutenticacao), listaEnderecos))
            {
                host.Description.Behaviors.Add(new ServiceMetadataBehavior { HttpGetEnabled = true });

                host.AddServiceEndpoint(typeof(WCF.Contrato.IServicoAutenticacao), 
                                        new BasicHttpBinding(), 
                                        "ServicoAutenticacao");
                host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");
                
                host.Open();

                Console.WriteLine("Executando com configurações editadas via código C# \nAperte Enter para interromper o serviço.");

                Console.ReadKey();
            }
        }
    }
}
