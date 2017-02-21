using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RowingApp.ViewModel
{
    public class MemberViewModel
    {

        public string NameColor { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public bool GardaVetted { get; set; }

        public bool Cox { get; set; }

        public bool WeatherCaller { get; set; }

        public List<MemberViewModel> members { get; set; }

        public string UserName { get; set; }
    }
}