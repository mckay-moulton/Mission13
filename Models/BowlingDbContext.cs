﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission13.Models
{

    public class BowlingDbContext : DbContext
    {    //inherit from base options
        public BowlingDbContext(DbContextOptions<BowlingDbContext> options) : base (options)
        {

        }

        public DbSet<Bowler> Bowlers { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
