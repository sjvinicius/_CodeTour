using CodeTour.Shared.Commands;
using Flunt.Notifications;
using System;

namespace CodeTour.Domain.Commands.Usuario
{
    class ObterDados : Notifiable<Notification>, ICommand
    {
        public ObterDados(Guid idUsuario)
        {
            IdUsuario = idUsuario;
        }

        public Guid IdUsuario { get; set; }

        public void Validar()
        {
            
        }
    }
}
