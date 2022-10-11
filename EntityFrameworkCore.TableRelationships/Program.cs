using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore.TableRelationships;

internal class Program
{
    static void Main(string[] args)
    {
        DataContext dataContext = new DataContext();
        dataContext.Pessoas.Add(new Pessoa()
        {
            Name = "Otávio",
            Identifier = Guid.NewGuid(),
            Tarefas = new List<Tarefa>()
            {
                new Tarefa()
                {
                    Identifier = Guid.NewGuid(),
                    Titulo = "Estudar"
                }
            }
        });
        dataContext.SaveChanges();

        var resultado = dataContext.Pessoas.AsNoTracking().Include("Tarefas").ToList();

        foreach (var teste in resultado)
        {
            foreach (Tarefa tarefa in teste.Tarefas)
            {
                Console.WriteLine(tarefa.Titulo);
            }
        }

        Console.WriteLine("Terminou");
        Console.ReadKey();
    }
}