using FlightTicketSalesSite.Service.Abstract;
using FlightTicketSalesSite.Service.Concrete;
using FlightTicketSalesSite.Data.Concrete;
using FlightTicketSalesSite.Data.Abstract;
using FlightTicketSalesSite.Identity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BusTicketReservation.Data.Concrete.EfCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<MyIdentityContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));

builder.Services.AddIdentity<MyIdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<MyIdentityContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequiredLength = 6;

    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15);
    options.Lockout.AllowedForNewUsers = true;

    options.User.RequireUniqueEmail = true;

    options.SignIn.RequireConfirmedEmail = false;
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";
    options.LogoutPath = "/Account/Logout";
    options.AccessDeniedPath = "/account/accessdenied";
    options.SlidingExpiration = true;
    options.ExpireTimeSpan = TimeSpan.FromHours(1);
    options.Cookie = new CookieBuilder
    {
        HttpOnly = true,
        Name = ".BusTicketReservation.Security.Cookie"
    };

});


builder.Services.AddDbContext<AirplaneContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));

builder.Services.AddScoped<ICityRepository, EfCoreCityRepository>();
builder.Services.AddScoped<IAirplaneRepository, EfCoreAirplaneRepository>();
builder.Services.AddScoped<ITicketRepository, EfCoreTicketRepository>();
builder.Services.AddScoped<ITripRepository, EfCoreTripRepository>();
builder.Services.AddScoped<IPassengerRepository, EfCorePassengerRepository>();

builder.Services.AddScoped<ICityService, CityManager>();
builder.Services.AddScoped<IAirplaneService, AirplaneManager>();
builder.Services.AddScoped<IPassengerService, PassengerManager>();
builder.Services.AddScoped<ITicketService, TicketManager>();
builder.Services.AddScoped<ITripService, TripManager>();


builder.Services.AddControllersWithViews();

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
app.UseAuthentication();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); 

app.Run();
