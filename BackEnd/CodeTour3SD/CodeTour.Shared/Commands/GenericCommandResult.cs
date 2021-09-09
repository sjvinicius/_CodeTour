using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTour.Shared.Commands
{
    public class GenericCommandResult : ICommandResult
    {
        public GenericCommandResult(bool _sucesso, string _mensagem, object _objeto)
        {
            Sucesso = _sucesso;
            Mensagem = _mensagem;
            Objeto = _objeto;
        }

        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
        public Object Objeto { get; set; }

    }
}
