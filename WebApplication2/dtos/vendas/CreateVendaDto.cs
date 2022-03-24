using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace data.dtos
{
    public class CreateVendaDto
    {

        
        public string nomeCliente { get; set; }
        public string nomeProduto { get; set; }
        public int quantidadeComprada { get; set; }
        public decimal ValorTotal { get; set; }
    }
}