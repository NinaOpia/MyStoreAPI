using System;
using System.ComponentModel.DataAnnotations;

namespace MyStoreAPI.Models
{
	public class UserDataTransferObj
	{
        [Required]
		public string Firstname { get; set; } = "";

        [Required(ErrorMessage = "Lastname required")]
        public string Lastname { get; set; } = "";

        public string Nickname { get; set; } = "";

        public string Mobilenumber { get; set; } = "";

        [Required]
        [EmailAddress]
        public string Email { get; set; } = "";

        [Required]
        [MinLength(5, ErrorMessage = "The Address should be at least 5 characters long, thank you!")]
        [MaxLength(1000, ErrorMessage = "The Address should be less than 1000 characters long, thank you!")]
        public string Address { get; set; } = "";
    }
}

