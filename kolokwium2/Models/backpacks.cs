using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace kolokwium2.Models;

[PrimaryKey(nameof(CharacterId), nameof(ItemId))]
public class backpacks
{
   
    public int CharacterId { get; set; }
    [ForeignKey(nameof(CharacterId))]
    public int ItemId { get; set; }
    [ForeignKey(nameof(ItemId))]
    public int Amount { get; set; }
    
    public ICollection<items> Items { get; set; } = new HashSet<items>();
    public ICollection<characters> Character { get; set; } = new HashSet<characters>();
}