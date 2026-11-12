using System;
using System.Collections.Generic;
using System.Text;

namespace RO_LibreriaBalones.nucleo
{
    public class DatosGenerales
    {
        public static string StringConexion()
        {
            return "server=localhost\\DEV;database=db_balones;Integrated Security=True;TrustServerCertificate=true;";
        }
    }
}
