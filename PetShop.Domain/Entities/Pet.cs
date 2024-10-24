using System.ComponentModel.DataAnnotations;

namespace PetShop.Domain.Entities;

public class Pet
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public double Weight { get; set; }
    public string? Color { get; set; }
}
