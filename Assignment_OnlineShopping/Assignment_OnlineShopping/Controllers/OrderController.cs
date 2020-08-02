using Assignment_OnlineShopping.Models;
using Assignment_OnlineShopping.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_OnlineShopping.Controllers
{
    public class OrderController : Controller
    {
        HalloweenContext ord = new HalloweenContext();

        // GET: Order
        public ActionResult Order()
        {
            return View(ord.Products.ToList());
        }
      
        /*public ActionResult Order()
        {
         
            return View();
        }

        [HttpPost]

        public ActionResult Create(LineItem p)
        {

            ord.LineItems.Add(p);
            ord.SaveChanges();
            return RedirectToAction("Order");

        }*/
    }
}