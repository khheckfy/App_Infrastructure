using App_Infrastructure.Domain.Entities;
using App_Infrastructure.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Infrastructure.Data.EntityFramework.Repositories
{
    internal class OrderRepository : Repository<Order>, IOrderRepository
    {
        internal OrderRepository(Model context)
            : base(context)
        {
        }

        public IQueryable<Order> ListByDate(DateTime from, DateTime to)
        {
            return Set
                .Where(n => n.OrderDate >= from)
                .Where(n => n.OrderDate <= to)
                .AsQueryable();
        }
    }
}
