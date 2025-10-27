namespace Vendas.Domain.Entities;
public class Pedido
{
    public int Id { get; set; }
    public DateTime Data { get; set; } = DateTime.UtcNow;
    public int FuncionarioId { get; set; }
    public Funcionario? Funcionario { get; set; }
    public ICollection<ItemPedido>? Itens { get; set; }
}
