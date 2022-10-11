using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore.TableRelationships;

public class DataContext : DbContext
{
    public DbSet<Tarefa> Tarefas { get; set; }
    public DbSet<Pessoa> Pessoas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data source=local.db");

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tarefa>().HasKey(p => p.Identifier);
        modelBuilder.Entity<Tarefa>().HasOne(p => p.Pessoa).WithMany(p => p.Tarefas);

        modelBuilder.Entity<Pessoa>().HasKey(p => p.Identifier);



        base.OnModelCreating(modelBuilder);
    }
}
