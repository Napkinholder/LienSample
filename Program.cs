using System.Globalization;
using LienSample.Mocks;
using LienSample.Models;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddLocalization();

builder.Services.AddSingleton<ILienStorageContext>(provider => new LienStorageContext());
builder.Services.AddSingleton<ILienTypeStorageContext>(provider => new LienTypeStorageContext());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseStatusCodePagesWithReExecute("/Error");

app.UseRouting();

app.UseRequestLocalization("en-US");

app.UseAuthorization();

app.MapRazorPages();

app.Run();
