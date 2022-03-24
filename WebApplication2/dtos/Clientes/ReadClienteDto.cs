using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace models
{
    public class ReadClienteDto
    {
        [Key]
        [Required]
        public int id { get; set; }
        public string nomeCliente { get; set; }
        public string sobrenomeCliente { get; set; }
        public string Cpf { get; set; }
        public string dataNascimento { get; set; }
    }
}
