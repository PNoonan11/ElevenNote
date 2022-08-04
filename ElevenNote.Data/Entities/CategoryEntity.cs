using System.ComponentModel.DataAnnotations;

namespace ElevenNote.Data.Entities
{
    public class CategoryEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CategoryName { get; set; }
        [Required]

        public int CategoryId { get; set; }
    }
}