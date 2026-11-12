using Microsoft.AspNetCore.Mvc;
using RO_LibreriaBalones.Entidades;
using RO_LibreriaBalones.Iterfaces;

namespace RO_ServiciosBalones.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BalonesController : ControllerBase
    {
        private IBalonesAplicacion IAsignacionesAplicacion;

        public IBalonesAplicacion? IBalonesAplicacion { get; }

        public BalonesController(IBalonesAplicacion IBalonesAplicacion)
        {
            this.IBalonesAplicacion = IAsignacionesAplicacion;
        }

        [HttpPost]
        public List<Balones> Consultar()
        {
            return this.IAsignacionesAplicacion.Consultar();
        }

        [HttpPost]
        public List<Balones> Buscar(Balones entidad)
        {
            return this.IAsignacionesAplicacion.Buscar(entidad);
        }

        [HttpPost]
        public Balones Insertar(Balones entidad)
        {
            return this.IAsignacionesAplicacion.Insertar(entidad);
        }

        [HttpPost]
        public Balones Actualizar(Balones entidad)
        {
            return this.IAsignacionesAplicacion.Actualizar(entidad);
        }

        [HttpPost]
        public Balones Borrar(Balones entidad)
        {
            return this.IAsignacionesAplicacion.Borrar(entidad);
        }
    }
}

