using RentCar.Data.Common.BaseModels;
using System.ComponentModel.DataAnnotations;

namespace RentCar.Data.Models
{
    public class Review : BaseDeletableModel<int>
    {
        [Required]
        public int CarId { get; set; }

        public virtual Car Car { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        [Required]
        [Range(1, 5)]
        public int Rating { get; set; }

        [Required]
        [MinLength(16)]
        public string Comment { get; set; }
    }
}