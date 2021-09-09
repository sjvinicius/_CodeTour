using CodeTour.Domain.Commands.Comentario;
using CodeTour.Domain.Repositories.Comentarios;
using CodeTour.Shared.Commands;
using CodeTour.Shared.Handlers.Contracts;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTour.Domain.Handlers.Comentario
{
    class InserirComentarioHandle : Notifiable<Notification>, IHandler<InserirComentarioCommand>
    {
        private IComentarioRepository _comentarioRepository { get; set; }

        public InserirComentarioHandle(IComentarioRepository comentarioRepository)
        {
            _comentarioRepository = comentarioRepository;
        }

        public ICommandResult Handler(InserirComentarioCommand command)
        {
            // Regras de Negócio

            //
        }
    }
}
