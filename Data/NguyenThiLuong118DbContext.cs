using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenThiLuong118.Models;

    public class NguyenThiLuong118DbContext : DbContext
    {
        public NguyenThiLuong118DbContext (DbContextOptions<NguyenThiLuong118DbContext> options)
            : base(options)
        {
        }

        public DbSet<NguyenThiLuong118.Models.UniversityNTL118> UniversityNTL118 { get; set; }
    }
