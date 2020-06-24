﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ERPVendas.Models;

namespace ERPVendas.Data
{
    public class ERPVendasContext : DbContext
    {
        public ERPVendasContext (DbContextOptions<ERPVendasContext> options)
            : base(options)
        {
        }

        public DbSet<ERPVendas.Models.Department> Department { get; set; }
    }
}
