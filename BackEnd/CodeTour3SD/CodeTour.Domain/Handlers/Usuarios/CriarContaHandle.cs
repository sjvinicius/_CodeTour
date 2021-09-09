using CodeTour.Domain.Commands;
using CodeTour.Domain.Entidades;
using CodeTour.Domain.Repository.Usuario;
using CodeTour.Shared.Commands;
using CodeTour.Shared.Handlers.Contracts;
using Flunt.Notifications;

namespace CodeTour.Domain.Handlers.Usuarios
{
    class CriarContaHandle : Notifiable<Notification>, IHandler<CriarContaCommand>
    {

        private IUsuarioRepository _usuarioRepository;

        public CriarContaHandle(IUsuarioRepository usuarioRepository)
        {

            _usuarioRepository = usuarioRepository;

        }

        public ICommandResult Handler(CriarContaCommand command)
        {


            // Aplicar Regras de Negócio

            // Validação Criada Anteriormente
            command.Validar();
            if (!command.IsValid)
            {

                new GenericCommandResult(false, "Informe corretamente os dados do usuário", command.Notifications);

            };
            // Verificar se o email existe

            var usuarioBuscado = _usuarioRepository.BuscarEmail(command.Email);

            if (usuarioBuscado != null)
            {

                new GenericCommandResult(false, "Email já cadastrado", "Informe um email válido");

            }

            // Salvar no banco de dados
            Usuario usuario = new Usuario(
            
                command.Email,
                command.Senha,
                command.Nome,
                command.TipoUsuario
                
            );

            if (!usuario.IsValid)
            {

                return new GenericCommandResult(false, "Usuario não cadastrado", usuario.Notifications);

            }

            _usuarioRepository.Criar(usuario);
            
            // Criptografar senha
            // Enviar Email

            return new GenericCommandResult(true, "Completo", "token");

        }
    }
}
