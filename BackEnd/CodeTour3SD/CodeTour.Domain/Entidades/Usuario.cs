using CodeTour.Shared;
using System;
using System.Collections.Generic;

namespace CodeTour.Domain.Entidades
{
    public class Usuario : Base
    {

        public Usuario(string _email, string _senha, string _nome, EnTipoUsuario _tipoUsuario )
        {
            Email = _email;
            Senha = _senha;
            Nome = _nome;
            TipoUsuario = _tipoUsuario;
        }

        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public EnTipoUsuario TipoUsuario { get; set; }

        // Composição

        public IReadOnlyCollection<Comentario> Comentarios { get; private set; }

    }
}