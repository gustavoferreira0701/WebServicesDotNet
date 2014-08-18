using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using WCF.Contrato;


namespace WCF.Servico
{
    /// <summary>
    /// Classe contendo as implementações descritas no contrato
    /// </summary>
    public class ServicoAutenticacao : IServicoAutenticacao
    {
        public List<Usuario> ListarUsuarios(Usuario usuario)
        {
            return usuario.Listar();
        }

        public bool AutenticarAcesso(string login, string senha)
        {
            Usuario verificadorAcesso = new Usuario();

            var resultado = verificadorAcesso.Listar().Where(item => item.Login.Equals(login) &&
                                                                     item.Senha.Equals(senha)).SingleOrDefault();

            return resultado != null ? true : false;

        }
    }
}
