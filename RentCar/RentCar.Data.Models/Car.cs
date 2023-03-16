using RentCar.Data.Common.BaseModels;
using RentCar.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace RentCar.Data.Models
{
    public class Car : BaseDeletableModel<int>
    {
        public Car()
        {
            RentDays = new HashSet<CarRentDays>();
            InUse = true;
            CreatedOn = DateTime.UtcNow;
        }

        public bool InUse { get; set; }

        [Required]
        [MinLength(5)]
        public string Model { get; set; }

        [Required]
        [MinLength(15)]
        public string Description { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public int Speed { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public GearType GearType { get; set; }

        [Required]
        public decimal PricePerDay { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<CarRentDays> RentDays { get; set; }
    }
}