﻿using Microsoft.EntityFrameworkCore;
using SFAModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFAData
{
   public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
