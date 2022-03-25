using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace models
{
    public class BancoContext : DbContext
    {
        /*   public BancoContext(DbContextOptions<BancoContext> opt) : base(opt) 
           {


           }*/
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }
        public DbSet<Clientes> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          
        }

        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Vendas> vendas { get; set; }
        public DbSet<Clientes> clientes { get; set; }


    }
}
