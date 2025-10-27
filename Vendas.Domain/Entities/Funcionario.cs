namespace Vendas.Domain.Entities;
public class Funcionario
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Cpf { get; set; } = string.Empty;
    public int CargoId { get; set; }
    public Cargo? Cargo { get; set; }
    public decimal Salario { get; set; }
}
