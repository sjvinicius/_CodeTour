using CodeTour.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTour.Domain.Repositories.Comentarios
{
    interface IComentarioRepository
    {

        public void Criar(Comentario comentario);

        public void Atualizar(Guid id);

        public void Deletar(Guid id);

        public ICollection<Comentario> Listar();

        public Comentario BuscarId(Guid id);

    }
}
