using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proyecto_melany.Models;
using proyecto_melany.Services;

namespace proyecto_melany.Controllers
{


    [Route("user")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(usuariomodel usuario)
        {
            if (usuario != null)
            {
                await usuarioService.CrearUsuario(usuario);
                return Ok("usuario creado");

            }
            else
            {
                return BadRequest("usuario no pude ser null");
            }
        }
        [HttpGet]
        [Route("register")]
        public IActionResult Register()
        {
            return View();
        }
    }
}