using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyDatingApp.Entities;

namespace MyDatingApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {


        }

        public DbSet<AppUser> Users {get; set;}
        //  public DbSet<Photo> photo {get; set;}
    }

}