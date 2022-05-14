namespace EntityFrameworkRelationships.Models
{
    public class Weapon : BaseEntity
    {
        public string Name { get; set; }
        public int Damage { get; set; }


        public Character Character { get; set; }
        public int CharacterID { get; set; }
    }
}
