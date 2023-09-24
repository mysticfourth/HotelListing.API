﻿using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Core.Models.Users
{
    public class APIUserDto : LoginDto
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}