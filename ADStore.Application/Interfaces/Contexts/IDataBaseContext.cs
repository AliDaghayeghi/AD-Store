using ADStore.Domain.Entities.Carts;
using ADStore.Domain.Entities.Finances;
using ADStore.Domain.Entities.HomePages;
using ADStore.Domain.Entities.Orders;
using ADStore.Domain.Entities.Products;
using ADStore.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ADStore.Application.Interfaces.Contexts
{
    public interface IDataBaseContext
    {
          DbSet<User> Users { get; set; }
          DbSet<Role> Roles { get; set; }
          DbSet<UserInRole> UserInRoles { get; set; }
          DbSet<Category> Categories { get; set; }
          DbSet<Product> Products { get; set; }
          DbSet<ProductImages> ProductImages { get; set; }
          DbSet<ProductFeatures> ProductFeatures { get; set; }
          DbSet<Slider>  Sliders { get; set; }
          DbSet<HomePageImages>   HomePageImages { get; set; }
          DbSet<Cart>    Carts { get; set; }
          DbSet<CartItem>     CartItems { get; set; }
          DbSet<RequestPay>      RequestPays { get; set; }
          DbSet<Order> Orders { get; set; }
          DbSet<OrderDetail>  OrderDetails { get; set; }

        int SaveChanges(bool acceptAllChangesOnSuccess);
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken());
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());

    }
}
