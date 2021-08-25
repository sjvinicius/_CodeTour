using CodeTour.Shared;
using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTour.Domain
{
    public class Usuario : Base
    {


        public Usuario(string _nome, string _email, string _senha, EnTipoUsuario _tipoUsuario)
        {

            AddNotifications(
                new Contract<Notification>()
                    .Requires()
                    .IsNotEmpty(_nome, "Nome", "Nome não pode ser nulo")
                    .IsEmail(_email, "Email", "Nome não pode ser nulo")
                    .IsGreaterThan(_senha, 7, "Senha", "Senha deve conter no mínimo 7 caracteres")
            );

            Nome = _nome;
            Email = _email;
            Senha = _senha;
            TipoUsuario = _tipoUsuario;
        }

        public string Nome { get; private set; }

        public string Email { get; private set; }

        public string Senha { get ; private set; }

        public EnTipoUsuario TipoUsuario { get; private set; }

    }
}
