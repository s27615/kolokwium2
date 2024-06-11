using System.ComponentModel.DataAnnotations;

namespace kolokwium2.Models;

public class titles
{
    [Key]
    public int Id { get; set; }
    [MaxLength(100)]
    public string Name { get; set; }
    
    public ICollection<character_titles> CharacterTitles { get; set; } = new HashSet<character_titles>();
}