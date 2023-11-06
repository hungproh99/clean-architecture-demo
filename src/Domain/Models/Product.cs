using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Product_Id { get; set; }


        [Required]
        [MaxLength(100)]
        public required string Product_Name { get; set; }


        [ForeignKey("Brand")]
        public required int Brand_Id { get; set; }
        public required Brand Brand { get; set; }

        [ForeignKey("Category")]
        public required int Categoty_Id { get; set; }
        public required Category Category { get; set; }



        [Required]
        [MaxLength(100)]
        public double Product_Price { get; set; }

        public int Product_Quantity { get; set; }

        public required string Product_Code { get; set; }


    }
}
