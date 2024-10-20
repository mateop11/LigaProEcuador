<<<<<<< HEAD
﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LigaProEcuador.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<LigaProEcuadorContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LigaProEcuadorContext") ?? throw new InvalidOperationException("Connection string 'LigaProEcuadorContext' not found.")));
=======
var builder = WebApplication.CreateBuilder(args);
>>>>>>> d9ba2bdd6ff03c5660216b3f073bb8554dadf245

// Add services to the container.
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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
