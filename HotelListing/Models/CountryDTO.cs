using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Models
{

    public class CreateCountryDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Country Name Is Too Long.")]
        public string CountryName { get; set; }

        [Required]
        [StringLength(maximumLength: 2, ErrorMessage = "Country Abbreviation Is Too Long.")]
        public string CountryAbbreviation { get; set; }
    }

    public class CountryDTO : CreateCountryDTO
    {
        public int CountryId { get; set; }

        public IList<HotelDTO> HotelDTOs { get; set; }
    }
}
