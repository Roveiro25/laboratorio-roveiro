using Libreria_Front.Interfaces;
using RO_LibreriaBalones.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Libreria_Front.Implementaciones
{
    public class BalonesPresentacion : IBalonesPresentacion
    {
        private IComunicaciones IComunicaciones;

        public BalonesPresentacion(IComunicaciones IComunicaciones)
        {
            this.IComunicaciones = IComunicaciones;
        }

        public Balones Actualizar(Balones entidad)
        {
            if (entidad.Id == 0)
                throw new Exception("No se ha guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            var task = this.IComunicaciones.Ejecutar<Balones>(
                "Postres/Actualizar",
                entidad);
            task.Wait();
            return task.Result;
        }

        public Balones Borrar(Balones entidad)
        {
            if (entidad.Id == 0)
                throw new Exception("No se ha guardo");

            var task = this.IComunicaciones.Ejecutar<Balones>(
                "Postres/Borrar",
                entidad);
            task.Wait();
            return task.Result;
        }

        public List<Balones> Buscar(Balones entidad)
        {
            var task = this.IComunicaciones.Ejecutar<List<Balones>>(
                "Postres/Buscar",
                entidad);
            task.Wait();
            return task.Result;
        }

        public List<Balones> Consultar()
        {
            var task = this.IComunicaciones.Ejecutar<List<Balones>>(
                "Postres/Consultar",
                null);
            task.Wait();
            return task.Result;
        }

        public Balones Insertar(Balones entidad)
        {
            if (entidad.Id != 0)
                throw new Exception("Ya se guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            var task = this.IComunicaciones.Ejecutar<Balones>(
                "Postres/Insertar",
                entidad);
            task.Wait();
            return task.Result;
        }

        private bool Validar(Balones entidad)
        {
            return string.IsNullOrEmpty(entidad.Marca) ||
                string.IsNullOrEmpty(entidad.Modelo) ||
                entidad.Precio <= 0.0m ;
        }
    }
}
