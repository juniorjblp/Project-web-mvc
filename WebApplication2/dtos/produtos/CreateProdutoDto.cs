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
    public class CreateProdutoDto
    {

        public string nomeProduto { get; set; }
        public int quantidadeProduto { get; set; }
        public decimal valorProduto { get; set; }

    }
}