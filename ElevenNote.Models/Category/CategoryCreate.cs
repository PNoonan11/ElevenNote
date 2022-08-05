using System.ComponentModel.DataAnnotations;

namespace ElevenNote.Models.Category
{
    public class CategoryCreate
    {
        [Required]
        public string CategoryName { get; set; }



    }
}