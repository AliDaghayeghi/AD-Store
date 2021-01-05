using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using ADStore.Persistence.Contexts;
using ADStore.Application.Interfaces.Contexts;
using ADStore.Application.Services.Users.Queries.GetUsers;
using ADStore.Application.Services.Users.Queries.GetRoles;
using ADStore.Application.Services.Users.Commands.RegisterUser;
using ADStore.Application.Services.Users.Commands.RemoveUser;
using ADStore.Application.Services.Users.Commands.UserLogin;
using ADStore.Application.Services.Users.Commands.UserStatusChange;
using ADStore.Application.Services.Users.Commands.EditUser;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using ADStore.Application.Interfaces.FacadPatterns;
using ADStore.Application.Services.Products.FacadPattern;
using ADStore.Application.Services.Common.Queries.GetMenuItem;
using ADStore.Application.Services.Common.Queries.GetCategory;
using ADStore.Application.Services.HomePages.AddNewSlider;
using Microsoft.Extensions.Hosting.Internal;
using ADStore.Application.Services.Common.Queries.GetSlider;
using ADStore.Application.Services.HomePages.AddHomePageImages;
using ADStore.Application.Services.Common.Queries.GetHomePageImages;
using ADStore.Application.Services.Carts;
using ADStore.Application.Services.Fainances.Commands.AddRequestPay;
using ADStore.Common.Roles;
using ADStore.Application.Services.Fainances.Queries.GetRequestPayService;
using ADStore.Application.Services.Orders.Commands.AddNewOrder;
using ADStore.Application.Services.Orders.Queries.GetUserOrders;
using ADStore.Application.Services.Orders.Queries.GetOrdersForAdmin;
using ADStore.Application.Services.Fainances.Queries.GetRequestPayForAdmin;

namespace EndPoint.Site
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddAuthorization(options =>
            {
                options.AddPolicy(UserRoles.Admin, policy => policy.RequireRole(UserRoles.Admin));
                options.AddPolicy(UserRoles.Customer, policy => policy.RequireRole(UserRoles.Customer));
                options.AddPolicy(UserRoles.Operator, policy => policy.RequireRole(UserRoles.Operator));
            });

            services.AddAuthentication(options =>
            {
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(options =>
            {
                options.LoginPath = new PathString("/Authentication/Signin");
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5.0);
                options.AccessDeniedPath = new PathString("/Authentication/Signin");
            });


            services.AddScoped<IDataBaseContext, DataBaseContext>();
            services.AddScoped<IGetUsersService, GetUsersService>();
            services.AddScoped<IGetRolesService, GetRolesService>();
            services.AddScoped<IRegisterUserService, RegisterUserService>();
            services.AddScoped<IRemoveUserService, RemoveUserService>();
            services.AddScoped<IUserLoginService, UserLoginService>();
            services.AddScoped<IUserStatusChangeService, UserStatusChangeService>();
            services.AddScoped<IEditUserService, EditUserService>();

            //FacadeInject
            services.AddScoped<IProductFacad, ProductFacad>();


            //------------------
            services.AddScoped<IGetMenuItemService, GetMenuItemService>();
            services.AddScoped<IGetCategoryService, GetCategoryService>();
            services.AddScoped<IAddNewSliderService, AddNewSliderService>();
            services.AddScoped<IGetSliderService, GetSliderService>();
            services.AddScoped<IAddHomePageImagesService, AddHomePageImagesService>();
            services.AddScoped<IGetHomePageImagesService, GetHomePageImagesService>();

            services.AddScoped<ICartService, CartService>();
            services.AddScoped<IAddRequestPayService, AddRequestPayService>();
            services.AddScoped<IGetRequestPayService, GetRequestPayService>();
            services.AddScoped<IAddNewOrderService, AddNewOrderService>();
            services.AddScoped<IGetUserOrdersService, GetUserOrdersService>();
            services.AddScoped<IGetOrdersForAdminService, GetOrdersForAdminService>();
            services.AddScoped<IGetRequestPayForAdminService, GetRequestPayForAdminService>();




            string contectionString = "Data Source=DESKTOP-0NJDLGV; Initial Catalog= ADStoreDb; Integrated Security=True;";
            services.AddEntityFrameworkSqlServer().AddDbContext<DataBaseContext>(option => option.UseSqlServer(contectionString));
            services.AddControllersWithViews();   
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");


                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

            });
        }
    }
}
