﻿using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Core.Models.Countries
{
    public abstract class BaseCountryDto
    {
        [Required]
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
