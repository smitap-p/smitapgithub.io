using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsingInMemory.Models;

namespace UsingInMemory.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult DisplayUserDetails()
        {
            List<workshop> lstwrkshop = new List<workshop>();

            workshop users = new workshop();

            users.UserName = "Smita";
            users.Password = "Smita@123";
            lstwrkshop.Add(users);

            users = new workshop();
            users.UserName = "Rahul";
            users.Password = "rahul@123";
            lstwrkshop.Add(users);

            return View(lstwrkshop);
        }
    }
}