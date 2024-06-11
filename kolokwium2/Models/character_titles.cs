using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace kolokwium2.Models;



[PrimaryKey(nameof(CharacterId), nameof(TitleId))]

public class character_titles
{
    public int CharacterId { get; set; }
    [ForeignKey(nameof(CharacterId))]
    public int TitleId { get; set; }
    [ForeignKey(nameof(TitleId))]
    public DateTime AcquiredAt { get; set; }
    
    public ICollection<characters> Characters { get; set; } = new HashSet<characters>();
    public ICollection<titles> Titles { get; set; } = new HashSet<titles>();
}