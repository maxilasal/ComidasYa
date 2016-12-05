using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComidasYa.Acceso_Datos
{
    class Consultas
    {
        public static string DevolverUsuarios()
        {
            return "SELECT Usuario, Password FROM Usuarios WHERE IdPerfil = 1;";
        }
    }
}
