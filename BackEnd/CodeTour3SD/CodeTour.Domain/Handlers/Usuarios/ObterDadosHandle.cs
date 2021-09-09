using CodeTour.Shared.Commands;
using CodeTour.Shared.Handlers.Contracts;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTour.Domain.Handlers.Usuarios
{
    class ObterDadosHandle : Notifiable<Notification>, IHandler<ObterDadosCommand>
    {
        public ICommandResult Handler(ObterDadosCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
