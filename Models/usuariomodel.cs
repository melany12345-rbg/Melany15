using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto_melany.Models
{
    public class usuariomodel
    {
        public int UserId { get; set; }
        public required string Usuario_Nombre { get; set; }
        public required string Usuario_Apellido { get; set; }
        public required string Usuario_Correo { get; set; }
        public required string Usuario_Constrasena { get; set; }



    }

}