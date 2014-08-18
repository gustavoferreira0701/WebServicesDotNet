using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using WCF.Servico;

namespace WCF.Host_Declarativo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(ServicoAutenticacao), new Uri[]{}))
            {
                host.Open();
                Console.WriteLine("Executando com configurações editadas no web.config \nAperte Enter para interromper o serviço.");
                Console.ReadKey();
            }
        }
    }
}
