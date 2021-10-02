using HotelListing.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Models
{
    public class CreateHotelDTO
    {
        [Required]
        [StringLength(maximumLength: 150, ErrorMessage = "Hotel Name Is Too Long.")]
        public string HotelName { get; set; }

        [Required]
        [StringLength(maximumLength: 250, ErrorMessage = "Hotel Address Is Too Long.")]
        public string HotelAddress { get; set; }

        [Required]
        [Range(1,5)]
        public double HotelRating { get; set; }

        [Required]
        public int CountryId { get; set; }

    }

    public class HotelDTO : CreateHotelDTO
    {
        public int HotelId { get; set; }

        public CountryDTO Country { get; set; }
    }

}
