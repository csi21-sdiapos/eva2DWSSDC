using Microsoft.EntityFrameworkCore;
using DAL.contexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// A�adimos nuestra conexi�n a la BBDD de PostgreSQL
builder.Services.AddEntityFrameworkNpgsql()
    .AddDbContext<NotasEvaluacionContext>(options =>
    {
        options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSqlConnection"));
    });

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true); // para evitar posibles errores en la vista Create por el Datetime

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

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
