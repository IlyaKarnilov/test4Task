using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using test.Areas.Identity.Data;

namespace test.Data;

public class testContext : IdentityDbContext<testUser>
{
    public testContext(DbContextOptions<testContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        var admin = new IdentityRole("admin");
        admin.NormalizedName = "admin";

        var client = new IdentityRole("client");
        client.NormalizedName = "client";

        var seller = new IdentityRole("seller");
        seller.NormalizedName = "seller";

        builder.Entity<IdentityRole>().HasData(admin, client, seller);
    }
}
