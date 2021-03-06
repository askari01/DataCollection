﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DataCollection.Models
{
    public class DataCollectionContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public DataCollectionContext() : base("name=DataCollectionContext")
        {
        }

        public System.Data.Entity.DbSet<DataCollection.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<DataCollection.Models.Teachers> Teachers { get; set; }

        public System.Data.Entity.DbSet<DataCollection.Models.Project> Projects { get; set; }
    }
}
