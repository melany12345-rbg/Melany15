using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using proyecto_melany.Data;
using proyecto_melany.Models;
using proyecto_melany.Services;

namespace proyecto_melany.Implementacion
{
    public class UsuarioService : IUsuarioService
    {
        private readonly DBContext dBContext;
        private readonly IPasswordServicio passwordServicio;

        public UsuarioService(DBContext dBContext,IPasswordServicio passwordServicio)
        {
            this.dBContext = dBContext;
            this.passwordServicio = passwordServicio; 
        }
        public async Task CrearUsuario(usuariomodel usuario)
        {
            if (usuario != null)
            {
                usuario.Usuario_Constrasena = passwordServicio.HashPassword(usuario.Usuario_Constrasena);
                dBContext.Usuarios.Add(usuario);
                await dBContext.SaveChangesAsync();

            }
        }
    }
}