using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace FAEmlak.Data
{
    public class User : IdentityUser
    {
        public User()
        {
            Created = DateTime.UtcNow;
        }

        [PersonalData]
        [Column(TypeName="nvarchar(100)")]
        public string FirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }

        public string Address { get; set; }
        public DateTime Created { get; set; }
    }
}
