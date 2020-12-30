using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FAEmlak.Data;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace FAEmlak.Identity
{
    public class IdentityAppContext : IdentityDbContext<User>
    {
        public IdentityAppContext(DbContextOptions<IdentityAppContext> options) : base(options)
        {
        }
    }
}
