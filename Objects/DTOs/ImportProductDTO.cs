﻿
using System.ComponentModel.DataAnnotations;

namespace Objects.DTOs
{
    public class ImportProductDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(5, ErrorMessage = "ProductId must be 5 characters long.")]
        public string ProductId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be a positive value.")]
        public int Quantity { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Too long! Max is 50 characters")]
        public string TypeOfQuantity { get; set; }
        [Required]

        [Range(0, double.MaxValue, ErrorMessage = "UnitPrice must be a positive value.")]
        public decimal UnitPrice { get; set; }

        [Required]
        public DateTime ImportDate { get; set; }

        [Required]
        public DateTime ExpiredDate { get; set; }

        [StringLength(250, ErrorMessage = "Notes can be up to 250 characters long.")]
        public string? Notes { get; set; }
    }
}
