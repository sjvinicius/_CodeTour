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
    public class Pacote : Base
    {
        public Pacote(string _titulo, string _imagem, string _descricao, EnStatusPacote _status)
        {

            AddNotifications(

                new Contract<Notification>()
                    .Requires()
                    .IsNotEmpty(_titulo, "Titulo", "Insira um título")
                    .IsNotEmpty(_imagem, "Imagem", "Insira uma imagem")
                    .IsNotEmpty(_descricao, "Descricao", "Insira uma descricao")
                    .IsNotNull(_status, "Status", "Preencha o Status do pacote")

            );

            if (IsValid)
            {

                Titulo = _titulo;
                Imagem = _imagem;
                Descricao = _descricao;
                Status = _status;
            
            }
        }

        public string Titulo { get; private set; }
        public string Imagem { get; private set; }
        public string Descricao { get; private set; }
        public EnStatusPacote Status { get; private set; }

        //Composição
        public IReadOnlyCollection<Comentario> Comentarios { get { return _comentarios; } }


        // Lista de Apoio para fazer o gerenciamento dos dados (Comentario)
        private List<Comentario> _comentarios { get; set; }

        public void AddComentario (Comentario comentario)
        {

            if (_comentarios.Any(coment => coment.IdUsuario == comentario.IdUsuario))
                AddNotification("Comentário", "Este usuário já possui um comentário nesse pacote");

            if( IsValid )
            {

                _comentarios.Add(comentario);
            }

        }


    }
}
