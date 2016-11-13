using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using System.Web;
using Todoapp1;

namespace TodoAsp
{
    public class DataContext : DbContext
    {

        public DataContext() : base(@"DefaultConnection")
        {
        }


        public DbSet<Task> Tasks { get; set; }
    }
}