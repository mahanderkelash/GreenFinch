using GreenFinch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GreenFinch.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult signup(Customer m)
        {
            if (ModelState.IsValid)
            {
                using (ApplicationDbContext dc = new ApplicationDbContext())
                {
                     
                    Customer cm = null;

                    //this following line is for checking the email if it is already in database
                    cm = dc.customers.Where(x => x.Email == m.Email).FirstOrDefault();
                    if (cm == null)
                    {
                        dc.customers.Add(m);
                        dc.SaveChanges();
                        ModelState.Clear();
                        m = null;
                        ViewBag.Message = "Successfully Registration Done";

                    }
                    else
                    {
                        ViewBag.ErrorMessage = "Email already exits";
                    }
                }
            }

            return View();
        }


    }
}