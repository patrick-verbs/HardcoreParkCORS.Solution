using System.ComponentModel.DataAnnotations;

namespace ParkAPI.Models
{
    public class Park
    {
        public int ParkId { get; set; }
        [Required]
        [StringLength(32)]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Url { get; set; }
        [Required]
        [StringLength(12)]
        public string Phone { get; set; }
    }
}