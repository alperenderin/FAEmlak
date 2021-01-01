using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FAEmlak.Models
{
    public class AdminUserViewModel
    {
        public string UserId { get; set; }
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }
        [Display(Name = "LastName")]
        public string LastName { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Display(Name = "ConfirmPassword")]
        public string ConfirmPassword { get; set; }
        public string RoleId { get; set; }
        public List<Microsoft.AspNetCore.Identity.IdentityRole> Roles { get; set; }
    }
}
