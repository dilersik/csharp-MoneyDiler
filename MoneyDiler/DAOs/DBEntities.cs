using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace MoneyDiler
{
    class DBEntities : DbContext
    {

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Finance>().ToTable("Finances");
            modelBuilder.Entity<FinanceCategory>().ToTable("FinanceCategories");
            modelBuilder.Entity<FinanceCategorySub>().ToTable("FinanceCategoriesSubs");
            modelBuilder.Entity<PaymentForm>().ToTable("PaymentForms");

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Finance> Finances { get; set; }
        public DbSet<FinanceCategory> FinanceCategories { get; set; }
        public DbSet<FinanceCategorySub> FinanceCategoriesSubs { get; set; }
        public DbSet<PaymentForm> PaymentForms { get; set; }
        
    }
}
