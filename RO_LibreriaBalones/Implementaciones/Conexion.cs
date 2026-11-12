using Microsoft.EntityFrameworkCore;
using RO_LibreriaBalones.Entidades;
using RO_LibreriaBalones.Iterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using static RO_LibreriaBalones.Implementaciones.Conexion;

namespace RO_LibreriaBalones.Implementaciones
{
    
    
        public class Conexion : DbContext, IConexion
    {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(DatosGenerales.StringConexion()!, p => { });
                optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            }

            public DbSet<Balones>? Balones { get; set; }
        }
    
}
