using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WCF.Contrato;

namespace WCF.WebServiceASMX
{
    /// <summary>
    /// Summary description for ServicoAutenticacao
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class ServicoAutenticacao : System.Web.Services.WebService
    {
        //Propriedade usada para acessar os métodos já criados no projeto 
        ServicoAutenticacao svcAutenticacao = new ServicoAutenticacao();

        [WebMethod]
        public List<Usuario> ListarUsuarios(Usuario usuario)
        {
            return svcAutenticacao.ListarUsuarios(usuario);
        }

        [WebMethod]
        public bool AutenticarAcesso(string login, string senha)
        {
            return svcAutenticacao.AutenticarAcesso(login, senha);
        }
    }
}
