using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Clientes
    {
        [Key]
        public int id { get; set; }
        public string nomeCliente { get; set; }
        public string sobrenomeCliente { get; set; }
        public string Cpf { get; set; }
        public string dataNascimento { get; set; }

    }
}
