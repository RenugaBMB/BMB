using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using BMB.Models;

namespace BMB.Controllers
{
  

    public class DriverController : ApiController
    {
        Driver[] drivers = new Driver[]{
         new Driver {ID = 1, OrderID = 52100, CustomerName = "person1", OrderDateTime =
            DateTime.Parse(DateTime.Today.ToString()), TotalItems = 2 },
           new Driver {ID = 2, OrderID = 52100, CustomerName = "person4", OrderDateTime =
            DateTime.Parse(DateTime.Today.ToString()), TotalItems = 3 },
             new Driver {ID = 4, OrderID = 52100, CustomerName = "person5", OrderDateTime =
            DateTime.Parse(DateTime.Today.ToString()), TotalItems = 5 },
       new Driver {ID = 2, OrderID = 52101, CustomerName = "person2", OrderDateTime =
            DateTime.Parse(DateTime.Today.ToString()), TotalItems = 1 }, 
            new Driver {ID = 3, OrderID = 52101, CustomerName = "person3", OrderDateTime =
            DateTime.Parse(DateTime.Today.ToString()), TotalItems = 4 },
                new Driver {ID = 5, OrderID = 52101, CustomerName = "person7", OrderDateTime =
            DateTime.Parse(DateTime.Today.ToString()), TotalItems = 7 },
      };

        public IEnumerable<Driver> GetAllOrders()
        {
            return drivers;
        }

        public IHttpActionResult GetOrderId(int id)
        {
            var driver = drivers.FirstOrDefault((p) => p.ID == id);
            if (driver == null)
            {
                return NotFound();
            }
            return Ok(driver);
        }

    }
}