﻿using System;
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
            ServiceWithouWebConfig.ServicoAutenticacaoClient proxySemWebConfig = new ServiceWithouWebConfig.ServicoAutenticacaoClient();

            ServiceWithWebConfig.ServicoAutenticacaoClient proxyComWebConfig = new ServiceWithWebConfig.ServicoAutenticacaoClient();

            
        }
    }
}
