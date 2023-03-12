﻿using System.ComponentModel.DataAnnotations;

namespace InqueritoWeb.Models
{
    public class Resposta
    {
        [Required(ErrorMessage = "O campo Nome deve ser preenchido!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo E-mail deve ser preenchido!")]
        [EmailAddress(ErrorMessage = "O campo Email não corresponde a um endereço válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Resposta deve ser preenchido!")]
        public bool? Sim { get; set; }
    }
}
