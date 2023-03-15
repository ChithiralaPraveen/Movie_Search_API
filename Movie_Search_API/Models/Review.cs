using System.ComponentModel.DataAnnotations;

namespace MovieReview.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Review")]
        public string Reviewdata { get; set; }
        public string Moviename { get; set; }
        public DateTime Reviewdate { get; set; }
        public string Username { get; set; }


    }
}