using CodeTour.Domain.Entidades;
using CodeTour.Shared.Commands;
using CodeTour.Shared.Enum;
using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTour.Domain.Commands.Comentario
{
    class InserirComentarioCommand : Notifiable<Notification>, ICommand
    {
        public InserirComentarioCommand(Entidades.Usuario _usuario, Pacote _pacote, string _comentario, string _texto, string _sentimento, EnStatusComentario _status)
        {
            Usuario = _usuario;
            Pacote = _pacote;
            Comentario = _comentario;
            Texto = _texto;
            Sentimento = _sentimento;
            Status = _status;
        }

        public CodeTour.Domain.Entidades.Usuario Usuario { get; set; }
        public Pacote Pacote { get; set; }
        public string Comentario { get; set; }
        public string Texto { get; set; }
        public string Sentimento { get; set; }
        public EnStatusComentario Status { get; set; }


        public void Validar()
        {
            AddNotifications(

                new Contract<Notification>()
                    .Requires()
                    .IsNotNull(Usuario, "Usuario", "Usuario não pode ser vazio")
                    .IsNotNull(Pacote, "Pacote", "Pacote não pode ser vazio")
                    .IsNotEmpty(Texto, "Texto", "Texto não pode ser vazio")
                    .IsNotEmpty(Comentario, "Comentario", "Comentario não pode ser vazio")
                    .IsNotEmpty(Sentimento, "Sentimento", "Sentimento não pode ser vazio")
                    .IsNotNull(Status, "Status", "Status não pode ser vazio")
            );

            if (IsValid)
            {

                Usuario = Usuario;
                Pacote = Pacote;
                Texto = Texto;
                Comentario = Comentario;
                Sentimento = Sentimento;
                Status = Status;

            }
        }
    }
}
