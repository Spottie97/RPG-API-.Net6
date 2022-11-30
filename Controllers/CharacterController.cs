using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService characterService;
        public CharacterController(ICharacterService characterService)
        {
            this.characterService = characterService;
        }

        [HttpGet("GetALL")]
        public ActionResult<List<Character>> Get()
        {
            return Ok(characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public ActionResult<Character>GetSingle(int id)
        {
            return Ok(characterService.GetCharacterById(id));
        }

        [HttpPost]
        public ActionResult<List<Character>>AddCharacter(Character newCharacter)
        {

            return Ok(characterService.AddCharacter(newCharacter));
        }
    }
}