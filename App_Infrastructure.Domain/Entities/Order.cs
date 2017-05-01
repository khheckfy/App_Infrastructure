namespace App_Infrastructure.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        public Guid OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public int OrderNumber { get; set; }

        public decimal OrderSumm { get; set; }

        public string OrderDescription { get; set; }
    }
}
