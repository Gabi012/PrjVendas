namespace Vendas.Domain.Entities;

public class Cargo
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public ICollection<Funcionario>? Funcionarios { get; set; }
}
