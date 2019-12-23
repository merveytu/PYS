using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PYS.Web.Models.User
{
    public class UserDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? Age { get; set; }
        public string Description { get; set; }
    }

}