using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RowingApp.Models;

namespace RowingApp.Controllers
{
    public class MemberController : Controller
    {
        //
        // GET: /Member/
        public ActionResult Index()
        {
            return View();
        }

        public string GetString()
        {
            return "Hello World is old now. It’s time for wassup bro ;)";
        }

        public ActionResult GetMember()
        {
            Member emp = new Member();
            emp.Name = "Mark";
            emp.Email = "Marla";
            emp.Phone = "20000";

            if (emp.Name == "Sukesh")
            {
                emp.NameColor = "yellow";
            }
            else
            {
                emp.NameColor = "green";
            }

            return View("GetMember", emp);
        }
	}
}