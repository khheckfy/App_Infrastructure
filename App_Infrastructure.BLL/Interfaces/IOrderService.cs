using App_Infrastructure.BLL.DTO;
using System;
using System.Collections.Generic;

namespace App_Infrastructure.BLL.Interfaces
{
    public interface IOrderService
    {
        IEnumerable<OrderDTO> ListByDate(DateTime date);
        void Dispose();
    }
}
