using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using mylittle_project.Application.Interfaces;
using mylittle_project.infrastructure.Data;
using mylittle_project.infrastructure.Services;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();


// ✅ Enable ASP.NET Core OpenAPI generation
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        b => b.MigrationsAssembly("mylittle-project.infrastructure") // ✅ lowercase and correct
    )
);



builder.Services.AddScoped<ITenantService, TenantService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();               // ✅ Serves /openapi/v1.json
    app.MapScalarApiReference();    // ✅ Serves Scalar UI at /scalar/v1
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
