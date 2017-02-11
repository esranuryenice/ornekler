namespace StockTakibiForms.DAL.DBContext
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class StokTakibiDBContext : DbContext
    {
     
        public StokTakibiDBContext()
            : base("name=StokTakibiDB")
        {
        }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductAmountType> ProductAmountType { get; set; }
        public virtual DbSet<Sale> Sale { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Current> Current { get; set; }

    }
}