
/////////////////////////////////////////////////////////////////
//
//              AUTO-GENERATED | DON'T CHANGE
//
/////////////////////////////////////////////////////////////////

using BirdCageShop.DataAccess.Models;

using BirdCageShop.BusinessLogic.Services;

using Microsoft.EntityFrameworkCore;
using BirdCageShop.DataAccess.Repositories;

namespace BirdCageShop.BusinessLogic.Generations.DependencyInjection
{
    public static class DependencyInjectionResolverGen
    {
        public static void InitializerDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<DbContext, BirdCageShopContext>();
        

            services.AddScoped<IEquipmentService, EquipmentService>();
            services.AddScoped<IEquipmentRepository, EquipmentRepository>();
        

            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderRepository, OrderRepository>();
        

            services.AddScoped<IOrderDetailService, OrderDetailService>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
        

            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();
        

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepository, ProductRepository>();
        

            services.AddScoped<IProductEquipmentService, ProductEquipmentService>();
            services.AddScoped<IProductEquipmentRepository, ProductEquipmentRepository>();
        

            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IRoleRepository, RoleRepository>();
        

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();
        

            services.AddScoped<IVoucherService, VoucherService>();
            services.AddScoped<IVoucherRepository, VoucherRepository>();
        
}
    }
}
