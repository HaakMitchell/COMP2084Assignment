using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using COMP2084Assigment.Models;

namespace COMP2084Assigment.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<COMP2084Assigment.Models.Brands> Brands { get; set; }
        public DbSet<COMP2084Assigment.Models.ShoeType> ShoeType { get; set; }
        public DbSet<COMP2084Assigment.Models.Shoe> Shoe { get; set; }
    }
}
