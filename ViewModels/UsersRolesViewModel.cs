using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using URole.Models;

namespace URole.ViewModels
{
    public class UsersRolesViewModel
    {
        public ICollection<ApplicationUser> Adminstrators { get; set; }
        public ICollection<ApplicationUser> Managers { get; set; }
        public ICollection<ApplicationUser> Members { get; set; }
    }
}