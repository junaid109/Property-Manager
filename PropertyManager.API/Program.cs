using Microsoft.EntityFrameworkCore;
using PropertyManager.API.Data;
using PropertyManager.API.Repository;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container

// serilog config
Log.Logger = new LoggerConfiguration()
	.MinimumLevel.Debug()
	.WriteTo.Console()
	.WriteTo.File("logs\\log.txt", rollingInterval: RollingInterval.Day)
	.CreateLogger();

builder.Services.AddDbContext<PropertyContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
try
{
	var context = builder.Services.BuildServiceProvider().GetRequiredService<PropertyContext>();
	context.Database.Migrate();

	PropertySeedData.Seed(context);

}
catch (Exception e)
{
	Console.WriteLine("Error migrating database: " + e.Message);
}

builder.Services.AddScoped<IRepository, PropertyRepository>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers(option =>
{
	option.ReturnHttpNotAcceptable = true;
}).AddNewtonsoftJson().AddXmlDataContractSerializerFormatters();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddLogging();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
