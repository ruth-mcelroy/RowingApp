using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RowingApp.Models;
using RowingApp.ViewModel;

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
    MemberViewModel memberViewModel = new MemberViewModel();

   Member mem = new Member();

    List<Member> members = mem.GetMembers();

    List<MemberViewModel> empViewModels = new List<MemberViewModel>();

foreach (Member emp in members)
    {
        MemberViewModel empViewModel = new MemberViewModel();
        empViewModel.Name = emp.Name;
        empViewModel.Cox= emp.Cox;
        if (emp.Cox == true)
        {
            empViewModel.NameColor = "green";
        }
        else
        {
            empViewModel.NameColor = "orange";
        }
        empViewModels.Add(empViewModel);
    }

    return View("GetMember", empViewModels);
        }
	}
}