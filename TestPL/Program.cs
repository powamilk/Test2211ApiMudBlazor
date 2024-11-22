using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using TestBUS.Mapper;
using TestBUS.Service.Implement;
using TestBUS.Service.Interface;
using TestDAL;
using TestDAL.Repositories.Implement;
using TestDAL.Repositories.Interface;
using TestPL.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();


builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepo, UserRepo>();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Server=powa;Database=EmailSystem;Trusted_Connection=True;TrustServerCertificate=True")));
builder.Services.AddAutoMapper(typeof(MapperProfile));

builder.Services.AddMudServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
