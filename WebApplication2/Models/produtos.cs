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
    public class produto
    {
        [Key]
        [Required]
        public int id { get; set; }
        public string nomeProduto { get; set; }
        public int quantidadeProduto { get; set; }
        public decimal valorProduto { get; set; }
       // public Clientes Clientes { get; set; }

    }
}
