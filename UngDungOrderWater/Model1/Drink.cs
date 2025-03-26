namespace UngDungOrderWater.Model1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Drink
    {
        [StringLength(100)]
        public string DrinkName { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Quantity { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal Price { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal TotalPrice { get; set; }

        public DateTime? RealTime { get; set; }
    }
}
