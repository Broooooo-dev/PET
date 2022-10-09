using System.ComponentModel.DataAnnotations;

namespace Shop_asp.Models
{
    public class Gamers
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdTeam { get; set; }
    }
}
