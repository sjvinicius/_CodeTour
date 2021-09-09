using CodeTour.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTour.Domain.Repository.Usuario
{
    public interface IUsuarioRepository
    {

        public void Atualizar(Entidades.Usuario usuario, Guid id);
        public void Criar(Entidades.Usuario usuario);
        public void DeletarId(Guid id);
        public ICollection<Entidades.Usuario> Listar();
        public Entidades.Usuario BuscarEmail(string email);

    }
}
