using System;
using System.Collections.Generic;
using ComidasYa.Logica;
using System.Data.SqlClient;
using System.Configuration;
using ComidasYa.Acceso_Datos;

namespace ComidasYa
{
    public class Fachada
    {
        private DAOUsuarios daoUsuarios;
        
        public Fachada()
        {
            daoUsuarios = new DAOUsuarios();
        }

        public bool LoginCorrecto(string pUsuario, string pPassword)
        {
            return this.UsuarioCorrecto(pUsuario, pPassword);
        }

        private bool UsuarioCorrecto(string nombre, string password)
        {
            return daoUsuarios.listaUsuarios.Exists(vUsuario => vUsuario.Nombre == nombre && vUsuario.Password == password);
        }
    }
}
