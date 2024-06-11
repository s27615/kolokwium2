
using kolokwium2.Data;
using kolokwium2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace kolokwium2.Controller;

    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly IDbService _dbService;
        public CharacterController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        [Route("{characterId}")]
        public async Task<IActionResult> GetCharacter(int characterId)
        {
            return Ok(await _dbService.DoesCharacterExist(characterId));
        }  
        
        [HttpPost]
        [Route("{characterId}/backpacks")]
        public async Task<IActionResult> AddItem(int characterId, int[] itemsId)
        {
            var doExist = await _dbService.DoItemsExists(itemsId);
            if (!doExist)
                return BadRequest("Nie ma takich przedmiotow!");
            return Ok();
        }  
    }
