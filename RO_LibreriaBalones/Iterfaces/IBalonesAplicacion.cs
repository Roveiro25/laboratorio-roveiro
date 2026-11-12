using RO_LibreriaBalones.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RO_LibreriaBalones.Iterfaces
{
    public interface IBalonesAplicacion
    {
        Balones Insertar(Balones entidad);
        Balones Actualizar(Balones entidad);
        List<Balones> Consultar();
        List<Balones> Buscar(Balones entidad);
        Balones Borrar(Balones entidad);
    }
}
