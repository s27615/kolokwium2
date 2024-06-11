using kolokwium2.Data;
using kolokwium2.Models;
using Microsoft.EntityFrameworkCore;

namespace kolokwium2.Services;

public class DbService : IDbService
{
    private readonly ApbdContext _context;
    public DbService(ApbdContext context)
    {
        _context = context;
    }

    public async Task<ICollection<characters>> DoesCharacterExist(int characterId)
    {
        return await _context.Characters
            .Include(e => e.Backpacks)
            .Include(e => e.CharacterTitles)
            .Where(e => e.Id == characterId)
            .ToListAsync();
    }

    public async Task<bool> DoItemsExists(int[] items)
    {
        var result = true;
        foreach (var i in items)
        {
           result = _context.Items.Any(e => e.Id != items[i]);
        }

        return result;
    }

    public async Task<bool> IsWeightApropriate(int characterId, int[] items)
    {
        
        // var maxWeight = character.MaxWeight;
        //
        // var backpackItems = await _context.Backpacks
        //     .Where(e => e.CharacterId == characterId)
        //     .Select(e => e.Item)
        //     .ToListAsync();
        //
        // var currentWeight = backpackItems.Sum(item => item.Weight);
        //
        // var newItems = await _context.Items
        //     .Where(e => items.Contains(e.Id))
        //     .ToListAsync();
        //
        // var newItemsWeight = newItems.Sum(item => item.Weight);
        //
        // if (currentWeight + newItemsWeight <= maxWeight)
        // {
        //     Console.WriteLine("Postać ma wystarczająco wolnego udźwigu.");
        // }
        // else
        // {
        //     Console.WriteLine("Postać nie ma wystarczająco wolnego udźwigu.");
        // }
        //

        return true;
    }
}