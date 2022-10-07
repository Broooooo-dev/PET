using System.ComponentModel.DataAnnotations;

namespace Shop_asp.Models
{
    public class Teams
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
