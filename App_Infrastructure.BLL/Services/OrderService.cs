using App_Infrastructure.BLL.DTO;
using App_Infrastructure.BLL.Interfaces;
using App_Infrastructure.Domain;
using App_Infrastructure.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Infrastructure.BLL.Services
{
    public class OrderService : IOrderService
    {
        IUnitOfWork Database { get; set; }

        public OrderService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public IEnumerable<OrderDTO> ListByDate(DateTime date)
        {
            DateTime from = date.Date;
            DateTime to = date.AddDays(1).Date.AddSeconds(-1);

            Mapper.Initialize(cfg => cfg.CreateMap<Order, OrderDTO>());
            return Mapper.Map<IQueryable<Order>, IEnumerable<OrderDTO>>(Database.OrderRepository.ListByDate(from, to));
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}