using System.Collections.Generic;


namespace EntityFrameworkRelationships.Models
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public List<Character> Characters { get; set; }
    }
}
