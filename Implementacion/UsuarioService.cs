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

        public UsuarioService(DBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public async void CrearUsuarioAsync(usuariomodel usuario)
        {
           if (usuario != null)
             {
                dBContext.Usuarios.Add(usuario);
                await dBContext.SaveChangesAsync();

             }




        }
        public void CrearUsuario(usuariomodel usuario)
        
        {
            throw new NotImplementedException();


        }
    }
}