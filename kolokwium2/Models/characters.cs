using System.ComponentModel.DataAnnotations;

namespace kolokwium2.Models;

public class characters
{
    [Key]
    public int Id { get; set; }
    [MaxLength(50)]
    public string FirstName { get; set; }
    [MaxLength(120)]
    public string LastName { get; set; }
    public int CurrentWei { get; set; }
    public int MaxWeight { get; set; }
    
    public ICollection<backpacks> Backpacks { get; set; } = new HashSet<backpacks>();
    public ICollection<character_titles> CharacterTitles { get; set; } = new HashSet<character_titles>();
}