using App_Infrastructure.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App_Infrastructure.Web.Controllers
{
    public class HomeController : Controller
    {
        IOrderService orderService;
        public HomeController(IOrderService serv)
        {
            orderService = serv;
        }

        // GET: Home
        public ActionResult Index()
        {
            var data = orderService.ListByDate(DateTime.Now.AddDays(-5));
            foreach(var d in data)
            {
                Console.Write(d.OrderNumber);
            }
            return View();
        }
    }
}