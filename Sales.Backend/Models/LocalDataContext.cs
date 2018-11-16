﻿namespace Sales.Backend.Models
{
    using Domain.Models;
    public class LocalDataContext : DataContext
    {
        public new System.Data.Entity.DbSet<Sales.Common.Models.Product> Products { get; set; }
    }
}