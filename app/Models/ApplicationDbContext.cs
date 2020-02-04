using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace app.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
        : base(options)
    	{
    	}

    	protected override void OnModelCreating(ModelBuilder modelBuilder)
    	{
		//modelBuilder.Entity<xxIBM_PRODUCT_STYLE>()
		//	.Property(e -> e.DESCRIPTION)
		//	.ISNIcode(false);

		//modelBuilder.Entity<xxIBM_PRODUCT_STYLE>()
		//	.Property(e -> e.LONG_DESCRIPTION)
		//	.ISNIcode(false);

		//modelBuilder.Entity<xxIBM_PRODUCT_STYLE>()
		//	.Property(e -> e.BRAND)
		//	.ISNIcode(false);

        	//base.OnModelCreating(builder);
        	// Customize the ASP.NET Identity model and override the defaults if needed.
        	// For example, you can rename the ASP.NET Identity table names and more.
        	// Add your customizations after calling base.OnModelCreating(builder);
    	}

	public virtual DbSet<xxIBM_PRODUCT_SKU> XXIBM_PRODUCT_SKU {get; set;}
	public virtual DbSet<xxIBM_PRODUCT_PRICING> XXIBM_PRODUCT_PRICING {get; set;}
	public virtual DbSet<xxIBM_PRODUCT_CATALOGUE> XXIBM_PRODUCT_CATALOGUE {get; set;}
	public virtual DbSet<xxIBM_PRODUCT_STYLE> XXIBM_PRODUCT_STYLE {get; set;}


    }
}