using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using RO_LibreriaBalones.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RO_LibreriaBalones.Iterfaces
{
    public interface IConexion
    {
        DbSet<Balones>? Balones { get; set; }

        EntityEntry<T> Entry<T>(T entity) where T : class;
        int SaveChanges();
    }
}
