﻿using Bibliocanto.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bibliocanto;

public class Login : IdentityDbContext<BibliocantoUser>
{
    public Login()
    {

    }
    public Login(DbContextOptions<Login> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

=> optionsBuilder.UseSqlServer("data source=NOTEBOOK-MARCOS\\SQLEXPRESS;Initial Catalog=Bibliocanto_DB;User Id=sa;Password=2000@edu.sau;TrustserverCertificate=True");

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}