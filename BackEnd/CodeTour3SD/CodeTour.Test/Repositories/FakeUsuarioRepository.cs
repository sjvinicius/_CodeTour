using CodeTour.Domain.Entidades;
using CodeTour.Domain.Repository.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTour.Test.Repositories
{
    class FakeUsuarioRepository : IUsuarioRepository
    {
        public void Atualizar(Usuario usuario, Guid id)
        {
            
        }

        public Usuario BuscarEmail(string email)
        {

            if (email != "email@email.com")
            {

                return null;

            }
            else
            {
                return new Usuario("vinicius@gmail.com", "123123123", "Vinicius", Shared.EnTipoUsuario.Admin);
            }

        }

        public void Criar(Usuario usuario)
        {
            
        }

        public void DeletarId(Guid id)
        {
            
        }

        public ICollection<Usuario> Listar()
        {
            return new List<Usuario>(){

                new Usuario("vinicius@gmail.com", "123123123", "Vinicius", Shared.EnTipoUsuario.Admin),
                new Usuario("silva@gmail.com", "123123123", "Silva", Shared.EnTipoUsuario.Comum),

            };
        }
    }
}
