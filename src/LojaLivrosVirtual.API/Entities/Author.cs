namespace LojaLivrosVirtual.API.Entities;

public class Author : BaseEntity
{
  public string Name { get; set; }
  public string Email { get; set; }
  public string Description { get; set; }

  public Author(string name, string email, string description)
  {
    if (name.stringIsNullOrEmpty() || email.stringIsNullOrEmpty() || description.stringIsNullOrEmpty())
      throw ArgumentNullException("Campos não preenchidos corretamente");

    Name = name;
    Email = email;
    Description = description;
  }
}