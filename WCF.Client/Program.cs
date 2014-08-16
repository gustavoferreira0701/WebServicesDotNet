using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Servico.MensagemClient client = new Servico.MensagemClient("BasicHttpBinding_IMensagem"))
            {
                Console.Write(client.MensagemBoasVindas());
                Console.ReadKey();
            }
        }
    }
}
