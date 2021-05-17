using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dio.ApiCurso.InputModel
{
    public class JogoInputModel
    {
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome do jogo deve conter entre 3 e 100 caracteres")]
        public string Nome { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "O nome da produtora deve conter entre 3 e 100 carcteres")]
        public string Produtora { get; set; }
        [Required]
        [Range(0, 1000, ErrorMessage = " O preço do jogo deve estar entre 0 e 1000 reais")]
        public double Preco { get; set; }
    }
}
