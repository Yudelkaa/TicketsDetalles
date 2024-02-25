using Microsoft.EntityFrameworkCore;
using RegistroDetalle.Models;
using System.Collections.Generic;

namespace RegistroDetalle.Api.Context
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        public DbSet<Tickets> Tickets { get; set; }

    }
}

