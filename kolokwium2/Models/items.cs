using System.ComponentModel.DataAnnotations;

namespace kolokwium2.Models;

public class items
{
    [Key]
    public int Id { get; set; }
    [MaxLength(100)]
    public string Name { get; set; }
    public int Weight { get; set; }
    
    public ICollection<backpacks> Backpacks { get; set; } = new HashSet<backpacks>();
}