﻿using Microsoft.EntityFrameworkCore;

namespace NetCoreMVCLab07.Models
{
    public class ProductManagementContext:DbContext
    {
        public ProductManagementContext(DbContextOptions<ProductManagementContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}
