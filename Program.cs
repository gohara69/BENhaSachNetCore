using Microsoft.EntityFrameworkCore;
using NhaSachDotNet.DTO;
using NhaSachDotNet.DTO.Sach;
using NhaSachDotNet.Entity;
using NhaSachDotNet.Repository;
using NhaSachDotNet.Service;
using NhaSachDotNet.Service.Sach;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MyDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyDB"));
});

//handle CORS
builder.Services.AddCors(p => p.AddPolicy("MyCors", build =>
{
    build.WithOrigins("http://localhost:4200");
    build.AllowAnyMethod();
    build.AllowAnyHeader();
}));

//DI config repository
builder.Services.AddScoped<IRepository<TheLoai>, TheLoaiRepository>();

//DI config paginated repository
builder.Services.AddScoped<IPaginatedRepository<Sachs>, SachRepository>();

//DI config service
builder.Services.AddScoped<IService<TheLoaiDTO>, TheLoaiService>();

//DI config paginated service
builder.Services.AddScoped<IPaginatedService<SachOnCartDTO>, SachOnCartService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

app.Run();


