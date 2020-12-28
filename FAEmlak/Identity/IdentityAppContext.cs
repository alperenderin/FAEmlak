using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FAEmlak.Entity;
namespace FAEmlak.Identity
{
    public class IdentityAppContext : IdentityDbContext<User>
    {
        public IdentityAppContext(DbContextOptions<IdentityAppContext> options) : base(options)
        {
        }
    }
}
