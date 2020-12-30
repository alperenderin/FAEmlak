using System;
using System.Collections.Generic;

namespace FAEmlak.Models
{
    public class AdminUserViewModel
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string RoleId { get; set; }
        public List<Microsoft.AspNetCore.Identity.IdentityRole> Roles { get; set; }
    }
}
