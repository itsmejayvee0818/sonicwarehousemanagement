﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SonicWarehouseManagement.Shared
{
    public class Discount
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public string Customer_Code { get; set; }
        public string Site { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Discount_Amount { get; set; }
    }
}
