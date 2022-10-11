namespace EntityFrameworkCore.TableRelationships;

public class Tarefa
{
    public Guid Identifier { get; set; }
    public string Titulo { get; set; }
    public Pessoa Pessoa { get; set; }
}