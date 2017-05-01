using App_Infrastructure.Domain.Entities;
using System;
using System.Linq;

namespace App_Infrastructure.Domain.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        IQueryable<Order> ListByDate(DateTime from, DateTime to);
    }
}
