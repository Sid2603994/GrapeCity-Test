using GrapeCityBlogging.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrapeCityBlogging.Data.DBContext
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
       : base(options)
        { }

        public virtual DbSet<tbl_users> Users { get; set; }
        public virtual DbSet<tbl_blogs> Blogs { get; set; }
    }

}
