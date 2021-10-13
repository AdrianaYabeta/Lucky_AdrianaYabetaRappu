using ApiLuckyParcial.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLuckyParcial.Data
{
    public class AppDbContext : DbContext
    {
	 public DbSet<Suerte> Suerte { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
