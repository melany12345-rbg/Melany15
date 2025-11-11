using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto_melany.Services
{
    public interface IPasswordServicio
    {
        string HashPassword(string password);
    }
}