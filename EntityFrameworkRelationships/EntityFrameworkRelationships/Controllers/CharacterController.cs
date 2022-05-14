using EntityFrameworkRelationships.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkRelationships.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly EFContext _context;
        public CharacterController(EFContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Character>> Get(int userID)
        {
            var characters = _context.Characters.Where(u => u.User.ID == userID)
                                                .Include(w => w.Weapon)
                                                .Include(c => c.Skills).ToList(); 

            return Ok(characters);
        }

        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character character)
        {
            _context.Characters.Add(character);
            _context.SaveChanges();

            return Get(character.ID);
        }

        [HttpPost("weapon")]
        public ActionResult<List<Weapon>> AddWeapon(Weapon weapon)
        { 
            _context.Weapons.Add(weapon);
            _context.SaveChanges();

            return Ok();

        }

        [HttpPost("skill")]
        public ActionResult<List<Weapon>> AddCharacterSkill(CharacterSkillDTo request)
        {
            var character = _context.Characters.Where(c => c.ID == request.CharacterID)
                                    .Include(s => s.Skills)
                                    .FirstOrDefault();
            if (character == null)
                return NotFound();

            var skill = _context.Skills.Find(request.SkillID);
            if (skill == null)
                return NotFound();

            character.Skills.Add(skill);
            _context.SaveChanges();

            return Ok();

        }
    }
}
