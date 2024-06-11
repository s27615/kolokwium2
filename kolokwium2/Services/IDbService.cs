using kolokwium2.Models;

namespace kolokwium2.Services;

public interface IDbService
{
    public Task<ICollection<characters>> DoesCharacterExist(int characterId);
    public Task<bool> DoItemsExists(int[] items );
    public Task<bool> IsWeightApropriate(int characterId, int[] items );
}