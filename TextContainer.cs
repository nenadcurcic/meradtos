using System.ComponentModel.DataAnnotations;

namespace DTOs
{
    public class TextContainer
    {
        [Required]
        public string Subject { get; set; }

        [Required]
        public string Text { get; set; }
    }
}
