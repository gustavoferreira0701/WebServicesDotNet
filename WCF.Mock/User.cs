using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF.Mock
{
    public class Usuario
    {
        public int Id { get; set; }
        
        public string Nome { get; set; }
        
        public string Endereco { get; set; }
        
        public bool Ativo { get; set; }

        public List<Usuario> Listar(int seed)
        {
            try
            {
                List<Usuario> lista = new List<Usuario>();

                for (int i = 0; i < seed; i++)
                {
                    lista.Add(new Usuario { 
                        Id = i,
                        Nome = "Usuario: " + i,
                        Endereco = "Uma rua qualquer",
                        Ativo = true
                    });
                }

                return lista;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}
