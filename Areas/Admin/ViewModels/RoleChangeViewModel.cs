﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace KSAdmin.Areas.Admin.ViewModels
{
    public class RoleChangeViewModel
    {
        public string UserId { get; set; }
        public string UserEmail { get; set; }
        public List<IdentityRole> AllRoles { get; set; }
        public IList<string> UserRoles { get; set; }
        public RoleChangeViewModel()
        {
            AllRoles = new List<IdentityRole>();
            UserRoles = new List<string>();
        }
    }
}
