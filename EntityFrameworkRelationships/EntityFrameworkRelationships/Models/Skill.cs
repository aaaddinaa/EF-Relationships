using System.Collections.Generic;


namespace EntityFrameworkRelationships.Models
{
    public class Skill : BaseEntity
    {
        public string Name { get; set; }

        public List<Character> Characters { get; set; }

    }
}
