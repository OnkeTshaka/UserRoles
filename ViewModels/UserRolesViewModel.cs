﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using URole.Models;

namespace URole.ViewModels
{
    public class UserRolesViewModel
    {
        public int ID { get; set; }
        public ApplicationUser User { get; set; }
        public ICollection<string> UserRoles { get; set; }

        //For Adding Or Deleting Role from User
        public ICollection<string> AllRoles { get; set; }
        public string RoleName { get; set; }
    }
}