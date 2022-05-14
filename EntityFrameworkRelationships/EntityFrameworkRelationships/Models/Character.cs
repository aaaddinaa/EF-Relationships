using System.Collections.Generic;

namespace EntityFrameworkRelationships.Models
{
    public class Character : BaseEntity
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public User User { get; set; }
        public int UserID { get; set; }

        public Weapon Weapon { get; set; }

        public List<Skill> Skills { get; set; }
    }
}
