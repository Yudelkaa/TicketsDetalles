using Microsoft.EntityFrameworkCore;
using RegistroDetalle.Models;

namespace RegistroDetalle.Api.Context
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<TicketsDetalle> TicketsDetalles { get; set; }

    }
}

