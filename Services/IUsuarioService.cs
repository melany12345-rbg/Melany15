using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proyecto_melany.Models;

namespace proyecto_melany.Services
{
    public interface IUsuarioService
    {
        void CrearUsuario(usuariomodel usuario);
    }
}