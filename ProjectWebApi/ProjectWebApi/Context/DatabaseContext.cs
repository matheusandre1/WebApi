using Microsoft.EntityFrameworkCore;
namespace ProjectWebApi.Persistencia;

using ProjectWebApi.Models;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {

    }
    public DbSet<Pessoa> Pessoas { get; set; }

    public DbSet<Contrato> Contratos { get; set; }

    protected void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Pessoa>(Tabela => { Tabela.HasKey(e => e.Id) });

        builder.Entity<Contrato>(e => { });
    }
}