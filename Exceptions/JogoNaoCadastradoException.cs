using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dio.ApiCurso.Exceptions
{/// <summary>
/// Exception class " Game not registered "
/// </summary>
    public class JogoNaoCadastradoException : Exception
    {
        public JogoNaoCadastradoException()
            : base("Este jogo ainda não foi Cadastrado")
        { }
    }        
    
}
