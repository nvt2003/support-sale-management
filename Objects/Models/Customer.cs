﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Objects.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required(ErrorMessage = "Customer name is required!")]
        [StringLength(50, ErrorMessage = "Max is 50 charaters!")]
        public string CustomerName { get; set; }

        [StringLength(100, ErrorMessage = "Max is 100 charaters")]
        public string Address { get; set; }

        [StringLength(20, ErrorMessage = "Max is 20 numbers")]
        [RegularExpression(@"^\d*$", ErrorMessage = "Input must be number!")]
        public string PhoneNumber { get; set; }

        [StringLength(255, ErrorMessage = "Max is 255 charaters")]
        [EmailAddress(ErrorMessage = "Invalid email! Exmaple: example@gmail.com")]
        public string Email { get; set; }
        public string? UserId;

        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
