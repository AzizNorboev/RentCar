using RentCar.Data.Common.BaseModels;
using System.ComponentModel.DataAnnotations;

namespace RentCar.Data.Models
{
    public class Location : BaseDeletableModel<int>
    {
        public Location()
        {
            CreatedOn = DateTime.UtcNow;
        }

        [Required]
        public string Name { get; set; }
    }
}