using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RowingApp.Models
{
    public class Member
    {

        public int MemberId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public bool GardaVetted { get; set; }

        public bool Cox { get; set; }

        public bool WeatherCaller { get; set; }



        public List<Member> GetMembers()
        {
            List<Member> members = new List<Member>();
            Member emp = new Member();
            emp.Name = "johnson";
            emp.Phone = "0987777";
            emp.Cox = true;

            Member emp2 = new Member();
            emp2.Name = "johnson2";
            emp2.Phone = "0987777";
            emp2.Cox = true;
            members.Add(emp2);

            return members;
        }

    }
}