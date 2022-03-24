//using AutoMapper;
using data.dtos;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;


namespace Controllers
{

    public class ClientesController : ControllerBase
    {
        private BancoContext _context;
        //private IMapper _mapper;
        public ClientesController(BancoContext context)
        {
            _context = context;
          //  _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AdicionaCliente(Clientes cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));



        }

        [HttpGet]
        public IActionResult RecuperaClientes()
        {
            return Ok(_context.clientes);
        }

        [HttpGet("{Cpf}")]
        public IActionResult recuperaClientePorNome(string cpf)
        {
            var cliente = _context.clientes;
                
            if (cliente != null)
            {
                

                return Ok(_context.clientes
                 .Where(x => x.Cpf == cpf ));
            }
            return NotFound();
        }
   

    }
}
