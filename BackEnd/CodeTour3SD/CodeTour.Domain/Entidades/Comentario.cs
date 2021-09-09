using CodeTour.Shared;
using CodeTour.Shared.Enum;
using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTour.Domain.Entidades
{
    public class Comentario : Base
    {

        public Comentario(string _texto, string _sentimento, EnStatusComentario _status, Guid _idUsuario, Usuario _usuario, Guid _idPacote, Pacote _pacote)
        {

            AddNotifications(

                new Contract<Notification>()
                    .Requires()
                    .IsNotEmpty(_texto, "texto", "Insira um texto no comentários")
                    .IsNotEmpty(_sentimento, "sentimento", "Sentimento não pode ser vazio")
                    .IsNotNull(_status, "status", "Status não pode ser nulo")
                    .IsNotNull(_idUsuario, "idusuario", "Id do usuário não pode ser nulo")
                    .IsNotNull(_idPacote, "idpacote", "Id do pacote não pode ser nulo")

            );


            Texto = _texto;
            Sentimento = _sentimento;
            Status = _status;
            IdUsuario = _idUsuario;
            Usuario = _usuario;
            IdPacote = _idPacote;
            Pacote = _pacote;
        }

        public string Texto { get; private set; }
        public string Sentimento { get; private set; }
        public EnStatusComentario Status { get; private set; }

        //Composição

        public Guid IdUsuario { get; private set; }
        public Usuario Usuario { get; private set; }

        public Guid IdPacote { get; private set; }
        public Pacote Pacote { get; private set; }

    }
}
