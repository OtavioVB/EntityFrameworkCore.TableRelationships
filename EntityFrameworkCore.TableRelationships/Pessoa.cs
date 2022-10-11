namespace EntityFrameworkCore.TableRelationships;

public class Pessoa
{
    public Guid Identifier { get; set; }
    public string Name { get; set; }
    public List<Tarefa> Tarefas { get; set; }
}
