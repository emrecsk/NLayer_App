using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NLayer.API.Filters;
using NLayer.CORE.Repositories;
using NLayer.CORE.Service;
using NLayer.CORE.UnitofWorks;
using NLayer.REPOSITORY;
using NLayer.REPOSITORY.Repositories;
using NLayer.REPOSITORY.UnitofWorks;
using NLayer.SERVICE.Mapping;
using NLayer.SERVICE.Services;
using NLayer.SERVICE.Validations;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options => options.Filters.Add(new ValidateFilterAttribute())).AddFluentValidation(x=>x.RegisterValidatorsFromAssemblyContaining<ProductDtoValidator>());

builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true; //API kendisi bir filtrasyon uyguluyor. Bizim customresponsedto'muzu dönmemiz için o filtreyi baskýlýyoruz.
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUnitofWork, UnitofWork>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));
builder.Services.AddAutoMapper(typeof(MapProfile));

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddCors(options =>
    options.AddDefaultPolicy(p =>
    {
        p.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    })
);

var constrBuilder = new SqlConnectionStringBuilder(builder.Configuration.GetConnectionString("SqlConnection"));
constrBuilder.Password = builder.Configuration["Password"];
var connection = constrBuilder.ConnectionString;

builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(connection, option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(); //to allow for accessing to api
app.UseAuthorization();

app.MapControllers();

app.Run();
