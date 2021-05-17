using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dio.ApiCurso.Entities
{ /// <summary>
/// This Class Provide guide set to the controler like an Entitie
/// </summary>
    public class Jogo
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Produtora { get; set; }
        public double Preco { get; set; }

    }
}
