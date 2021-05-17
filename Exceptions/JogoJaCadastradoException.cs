using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dio.ApiCurso.Exceptions
{/// <summary>
/// Exception class game already registered
/// </summary>
    public class JogoJaCadastradoException : Exception
    {
        public JogoJaCadastradoException()
            : base("Este jogo já está cadastrado")
        { }
        
    }
}
