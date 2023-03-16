using RentCar.Data.Common.BaseModels;
using System.ComponentModel.DataAnnotations;

namespace RentCar.Data.Models
{
    public class CarRentDays : BaseDeletableModel<int>
    {
        [Required]
        public int CarId { get; set; }

        public virtual Car Car { get; set; }

        [Required]
        public DateTime RentDate { get; set; }
    }
}