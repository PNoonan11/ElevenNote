using System.ComponentModel.DataAnnotations;

namespace ElevenNote.Models.Note
{
    public class NoteCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "{0} must be atleast {1} characters long")]
        [MaxLength(100, ErrorMessage = "{0} must contain no more than {1} characters.")]
        public string Title { get; set; }
        [Required]
        [MaxLength(8000, ErrorMessage = "{0} must contain no more than {1} characters.")]
        public string Content { get; set; }
        public int Category { get; set; }
        public bool IsStarred { get; set; }
    }
}