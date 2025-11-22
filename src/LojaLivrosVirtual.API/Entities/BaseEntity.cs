namespace LojaLivrosVirtual.API.Entities;

public class BaseEntity
{
  public int Id { get; set; }
  public DateTime CreatedAt { get; set; } = DateTime.Now();
  public DateTime DeletedDate { get; set; }
}