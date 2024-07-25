using BarCodeHelper.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BarCodeHelper.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<BarCode> BarCodes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
           .Entity<Product>()
           .Property(e => e.Category)
           .HasConversion<int>();

            modelBuilder.Entity<BarCode>()
            .HasKey(bc => new { bc.BarCodeNumber, bc.ProductSerialNumber });

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                // Swimwear Products
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Swimwear, Name = "Men's Swim Trunks" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Swimwear, Name = "Women's Bikini" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Swimwear, Name = "Unisex Rash Guard" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Swimwear, Name = "Kids' One-Piece Swimsuit" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Swimwear, Name = "Ladies' Tankini" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Swimwear, Name = "Board Shorts" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Swimwear, Name = "Swim Briefs" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Swimwear, Name = "High Waist Swim Bottoms" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Swimwear, Name = "Sporty Swim Top" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Swimwear, Name = "Triangle Bikini Top" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Swimwear, Name = "Full Body Swimsuit" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Swimwear, Name = "Surf Swimwear" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Swimwear, Name = "Floral Bikini Set" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Swimwear, Name = "Halter Swim Dress" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Swimwear, Name = "Crochet Swimsuit" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Swimwear, Name = "Push-up Bikini" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Swimwear, Name = "Swimming Cap" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Swimwear, Name = "Swimming Goggles" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Swimwear, Name = "Swimming Fins" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Swimwear, Name = "Swim Cap" },

                // Pants Products
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Pants, Name = "Denim Jeans" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Pants, Name = "Cargo Pants" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Pants, Name = "Formal Trousers" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Pants, Name = "Chinos" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Pants, Name = "Jogger Pants" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Pants, Name = "Capri Pants" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Pants, Name = "Corduroy Pants" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Pants, Name = "Dress Pants" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Pants, Name = "Slim Fit Jeans" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Pants, Name = "Bootcut Jeans" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Pants, Name = "Baggy Jeans" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Pants, Name = "Pleated Pants" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Pants, Name = "Harem Pants" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Pants, Name = "Stretch Leggings" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Pants, Name = "Palazzo Pants" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Pants, Name = "Wide Leg Pants" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Pants, Name = "Khaki Pants" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Pants, Name = "Yoga Pants" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Pants, Name = "Work Pants" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Pants, Name = "Sweatpants" },

                // Underwear Products
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Underwear, Name = "Men's Boxers" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Underwear, Name = "Women's Panties" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Underwear, Name = "Men's Briefs" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Underwear, Name = "Women's Thong" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Underwear, Name = "Ladies' Bras" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Underwear, Name = "Sports Bra" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Underwear, Name = "Men's Undershirt" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Underwear, Name = "Women's Chemise" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Underwear, Name = "Thermal Underwear" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Underwear, Name = "Cotton Panties" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Underwear, Name = "Lace Lingerie" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Underwear, Name = "Silk Boxers" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Underwear, Name = "Padded Bra" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Underwear, Name = "Nursing Bra" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Underwear, Name = "Shapewear Bodysuit" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Underwear, Name = "Men's Trunks" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Underwear, Name = "Bikini Briefs" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Underwear, Name = "Long Underwear" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Underwear, Name = "Men's Compression Shorts" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.Underwear, Name = "Men's Athletic Supporter" },

                // T-Shirt Products
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.TShirt, Name = "Graphic T-Shirt" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.TShirt, Name = "Plain White Tee" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.TShirt, Name = "V-Neck T-Shirt" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.TShirt, Name = "Crew Neck T-Shirt" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.TShirt, Name = "Long Sleeve Tee" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.TShirt, Name = "Striped T-Shirt" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.TShirt, Name = "Pocket Tee" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.TShirt, Name = "Henley Shirt" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.TShirt, Name = "Polo Shirt" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.TShirt, Name = "Raglan T-Shirt" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.TShirt, Name = "Crop Top" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.TShirt, Name = "Tank Top" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.TShirt, Name = "Baseball T-Shirt" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.TShirt, Name = "Muscle Tee" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.TShirt, Name = "Hooded T-Shirt" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.TShirt, Name = "Sleeveless T-Shirt" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.TShirt, Name = "Slim Fit T-Shirt" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.TShirt, Name = "Graphic Hoodie" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.TShirt, Name = "Ringer Tee" },
                new Product { SerialNumber = Guid.NewGuid().ToString(), Category = ProductCategory.TShirt, Name = "Vintage Band Tee" }
            );
        }
    }
}
