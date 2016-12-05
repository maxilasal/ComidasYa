using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ComidasYa;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]

public class ComidasYaWebService : System.Web.Services.WebService
{
    private Fachada fac;

    public ComidasYaWebService()
    {
        fac = new Fachada();
    }

    [WebMethod]
    public bool Ingreso(string pNombre, string pPassword)
    {
        return fac.LoginCorrecto(pNombre, pPassword);
    }

}