using System;

namespace App_Infrastructure.BLL.DTO
{
    public class OrderDTO
    {
        public Guid OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public int OrderNumber { get; set; }

        public decimal OrderSumm { get; set; }

        public string OrderDescription { get; set; }
    }
}
