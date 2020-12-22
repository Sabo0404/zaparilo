﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WebApp.Database.Context
{
    public class MainContex : IdentityDbContext<Person>
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<FriendEntry> FriendEntrys { get; set; }
        public DbSet<Quality> Qualities { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Citizenship> Citizenships { get; set; }
        public MainContex(DbContextOptions<MainContex> options) : base(options) {
            Database.EnsureCreated();
        }
    }
}
