using System;
using api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace api.Data;

public class ApplicationDBContext : IdentityDbContext<AppUser>
{
  public ApplicationDBContext(DbContextOptions dbContextOptions)
  : base(dbContextOptions)
  {

  }

  public DbSet<Stock> Stocks { get; set; }
  public DbSet<Comment> Comments { get; set; }

  protected override void OnModelCreating(ModelBuilder builder)
  {
    base.OnModelCreating(builder);

    List<IdentityRole> roles = new List<IdentityRole>
    {
      new IdentityRole
      {
        Id = "1",
        Name = "Admin",
        NormalizedName = "ADMIN",
        ConcurrencyStamp = "4d9af3f2-1734-49f8-841f-a2285051a467"
      },
      new IdentityRole
      {
        Id = "2",
        Name = "User",
        NormalizedName = "USER",
        ConcurrencyStamp = "216cbe14-a1d5-4183-878c-044897fb870b"
      }
    };

    builder.Entity<IdentityRole>().HasData(roles);
  }
}
