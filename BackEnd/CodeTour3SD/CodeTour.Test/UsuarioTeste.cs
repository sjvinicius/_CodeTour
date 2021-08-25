using CodeTour.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeTour.Test
{
    public class UsuarioTeste
    {

        [Fact]
        public void UsuarioValido()
        {

            Usuario usuario = new Usuario(

                "Teste",
                "teste@gmail.com",
                "teste123",
                Shared.EnTipoUsuario.Comum

             );

            Assert.True(usuario.IsValid, "Usuario Válido");

        }

        [Fact]
        public void UsuarioInvalidoNome()
        {

            Usuario usuario = new Usuario(

                "",
                "teste@gmail.com",
                "teste123",
                Shared.EnTipoUsuario.Comum

             );

            Assert.True(!usuario.IsValid, "Usuário Nome inválido");

        }

        [Fact]
        public void UsuarioInvalidoEmail()
        {

            Usuario usuario = new Usuario(

                "Teste",
                "teste@",
                "teste123",
                Shared.EnTipoUsuario.Comum

             );

            Assert.True(!usuario.IsValid, "Usuário email inválido");

        }

        [Fact]
        public void UsuarioInvalidoSenha()
        {

            Usuario usuario = new Usuario(

                "Teste",
                "teste@",
                "teste",
                Shared.EnTipoUsuario.Comum

             );

            Assert.True(!usuario.IsValid, "Usuário Senha Fraca");

        }

    }
}
