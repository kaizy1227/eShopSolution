using eShopSolution.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key ="HomeTittile", Value = "This is home page of eShopSolution"},
                new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of eShopSolution" },
                new AppConfig() { Key = "HomeDescription", Value = "This is description of eShopSolution" }
                );

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id="vi-VN", Name = "Tieng Viet", IsDefault=true},
                new Language() { Id = "en-US", Name = "English", IsDefault = false }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id=1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Enums.Status.Active,
                   
                },
                new Category()
                {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Enums.Status.Active,
                   
                }
                );

            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation() { Id=1,CategoryId=1,Name = "Ao nu", LanguageId = "vi-VN", SeoAlias = "ao-nu", SeoDescription = "san pham thoi trang nu", SeoTitle = "ao nu" },
                         new CategoryTranslation() {Id=2, CategoryId = 1, Name = "woman Shirt", LanguageId = "en-US", SeoAlias = "woman-shirt", SeoDescription = "The shirt products for women", SeoTitle = "women shirt" },
                          new CategoryTranslation() {Id=3, CategoryId = 2,Name = "Ao nam", LanguageId = "vi-VN", SeoAlias = "ao-nam", SeoDescription = "san pham thoi trang nam", SeoTitle = "ao nam" },
                         new CategoryTranslation() {Id=4, CategoryId = 2, Name = "Men Shirt", LanguageId = "en-US", SeoAlias = "men-shirt", SeoDescription = "The shirt products for men", SeoTitle = "men shirt" }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {Id=1,
                    DateCreated=DateTime.Now,OriginalPrice = 100000,Price=200000,Stock=0,ViewCount=0,
                    
                }

                );
            modelBuilder.Entity<ProductTranslation>().HasData(
                    new ProductTranslation(){Id=1,ProductId=1,Name="Ao nam",LanguageId="vi-VN",SeoAlias="ao-nam",SeoDescription="san pham thoi trang nam",Details="" ,SeoTitle="ao nam",Description="ao nam ne"},
                    new ProductTranslation(){Id=2,ProductId=1,Name="Men Shirt",LanguageId="en-US",SeoAlias="men-shirt",SeoDescription="The shirt products for men", Details = "", SeoTitle ="men shirt",Description="ao nam ne"}

                ) ;
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId=1,CategoryId = 1 }
                );


            var roleId=new Guid("0A47003C-2540-49EA-83ED-6151B529304E");
            var adminId = new Guid("1B1BE361-8E76-4CA8-BB34-9DFFD9C74780");


            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description="Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "some-admin-email@nonce.fake",
                NormalizedEmail = "some-admin-email@nonce.fake",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName="Hai",
                LastName="Vu"
               
            }) ;

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }
        // any guid
        
    }
}
