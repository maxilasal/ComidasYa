using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComidasYa.Logica;
using System.Data.SqlClient;
using System.Configuration;

namespace ComidasYa.Acceso_Datos
{
    class DAOUsuarios
    {
        public List<Usuario> listaUsuarios { get; set; } 

        public DAOUsuarios()
        {
            listaUsuarios = new List<Usuario>();
            SqlConnection myConnection = null;
            SqlCommand myCommand = null;
            SqlDataReader myReader = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                myConnection = new SqlConnection(connectionString);
                myConnection.Open();
                myCommand = new SqlCommand(Consultas.DevolverUsuarios(), myConnection);
                myReader = myCommand.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        Usuario usu = new Usuario();
                        usu.Nombre = myReader.GetString(0);
                        usu.Password = myReader.GetString(1);
                        listaUsuarios.Add(usu);
                    }  
                }
                else
                {
                    Console.WriteLine("No hay ususario en base");
                }
                myReader.Close();
                myConnection.Close();
            }
            catch (Exception)
            {
            }
            finally
            {
                myReader.Close();
                myConnection.Close();
            }
        }
    }
}

