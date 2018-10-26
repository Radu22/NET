using System;
using System.ComponentModel.DataAnnotations;

namespace ProductClassLib
{
    public class Customer
    {
        private Customer()
        {

        }

        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public string Address { get; private set; }

        [Required]
        [RegularExpression(@"^(07)", ErrorMessage = "phone number not valid for RO")]
        [MaxLength(10)]
        [MinLength(10)]
        public int PhoneNumber { get; private set; }

        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",ErrorMessage = "Email not valid")]
        public string Email { get; private set; }

    }
}
