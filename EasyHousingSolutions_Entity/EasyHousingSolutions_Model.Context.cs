﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EasyHousingSolutions_Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EasyHousingSolutions_Entities : DbContext
    {
        public EasyHousingSolutions_Entities()
            : base("name=EasyHousingSolutions_Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Buyer> Buyers { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<Seller> Sellers { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
