﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagmentApp.Models
{
    public class SaleProduct
    {
        [Required(ErrorMessage = "Sale Id is required.")]
        [ForeignKey("SaleId")]
        public int SaleId { get; set; }
        [Required(ErrorMessage = "Product Id is required.")]
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Quantity is required.")]
        [Range(0,int.MaxValue,ErrorMessage = "Quantity cannot be negative.")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "Price is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Price cannot be negative.")]
        public decimal Price { get; set; }

        public virtual Sale Sale { get; set; }
        public virtual Product Product { get; set; }
    }
}
