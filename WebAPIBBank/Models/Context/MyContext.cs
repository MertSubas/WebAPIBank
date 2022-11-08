using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAPIBBank.Models.Entities;
using WebAPIBBank.Models.Init;

namespace WebAPIBBank.Models.Context
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyConneciton")
        {
            Database.SetInitializer(new MyInit());
        }
        public DbSet<CardInfo> Cards { get; set; }
    }
}