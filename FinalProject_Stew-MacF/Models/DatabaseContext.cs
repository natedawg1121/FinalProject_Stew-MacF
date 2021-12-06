﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject_Stew_MacF.Models
{
    public class DatabaseContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public DatabaseContext() : base()
        {
        }

        public DbSet<GroupInformation> GroupInformation { get; set; }
        public DbSet<GroupFood> GroupFood { get; set; }
        public DbSet<GroupHobby> GroupHobby { get; set; }
        public DbSet<GroupSchool> GroupSchool { get; set; }
    }
}
