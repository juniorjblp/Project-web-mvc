using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Vendedor
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Senha { get; set; }

       
    }
}
