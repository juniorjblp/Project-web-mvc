using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Controllers;

namespace WebApplication2.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }
        public string nomeDeUsuario { get; set; }
        public string senha { get; set; }

    }
}
