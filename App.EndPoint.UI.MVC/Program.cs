using App.Domain.AppServices.AdminEntity;
using App.Domain.AppServices.BookEntity;
using App.Domain.AppServices.CustomerEntity;
using App.Domain.Core.AdminEntity.Contracts;
using App.Domain.Core.BookEntity.Contracts;
using App.Domain.Core.CustomerEntity.Contracts;
using App.Domain.Services.AdminEntity;
using App.Domain.Services.BookEntity;
using App.Domain.Services.CustomerEntity;
using App.Infra.Data.Repo.EF.Admin;
using App.Infra.Data.Repo.EF.BookEntity;
using App.Infra.Data.Repo.EF.Customer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//Admin
builder.Services.AddScoped<IAdminService, AdminService>();
builder.Services.AddScoped<IAdminAppService, AdminAppService>();
builder.Services.AddScoped<IAdminRepository, AdminRepository>();

//Customer
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<ICustomerAppService, CustomerAppService>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();

//book
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IBookAppService, BookAppService>();
builder.Services.AddScoped<IBookRepository, BookRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
