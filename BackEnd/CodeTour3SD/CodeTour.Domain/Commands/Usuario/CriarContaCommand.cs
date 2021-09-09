using CodeTour.Shared;
using CodeTour.Shared.Commands;
using Flunt.Notifications;
using Flunt.Validations;

namespace CodeTour.Domain.Commands
{
    class CriarContaCommand : Notifiable<Notification>, ICommand
    {

        public CriarContaCommand()
        {

        }

        public CriarContaCommand(string _nome, string _email, string _senha, EnTipoUsuario _tipoUsuario)
        {
            Nome = _nome;
            Email = _email;
            Senha = _senha;
            TipoUsuario = _tipoUsuario;
        }

        public string Nome { get; private set; }

        public string Email { get; private set; }

        public string Senha { get; private set; }

        public EnTipoUsuario TipoUsuario { get; private set; }


        public void Validar()
        {

            AddNotifications(
                new Contract<Notification>()
                    .Requires()
                    .IsNotEmpty(Nome, "Nome", "Nome não pode ser nulo")
                    .IsEmail(Email, "Email", "Nome não pode ser nulo")
                    .IsGreaterThan(Senha, 7, "Senha", "Senha deve conter no mínimo 7 (sete) caracteres")
            );

            if (IsValid)
            {
                Nome = Nome;
                Email = Email;
                Senha = Senha;
                TipoUsuario = TipoUsuario;
            }

        }
    }
}
