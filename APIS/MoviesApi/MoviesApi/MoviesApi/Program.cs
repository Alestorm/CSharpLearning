using Microsoft.EntityFrameworkCore;
using MoviesApi.Domain.Contracts;
using MoviesApi.Infrastructure.Postgresql;
using MoviesApi.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string p_host = builder.Configuration.GetValue<string>("PostgresConnectionString:host") ?? "";
string p_database = builder.Configuration.GetValue<string>("PostgresConnectionString:database") ?? "";
string p_user = builder.Configuration.GetValue<string>("PostgresConnectionString:user") ?? "";
string p_password = builder.Configuration.GetValue<string>("PostgresConnectionString:password") ?? "";
int p_port = builder.Configuration.GetValue<int>("PostgresConnectionString:port");

string connectionString = $"Host={p_host};Port={p_port};Database={p_database};Username={p_user};Password={p_password};";
builder.Services.AddDbContext<PostgresDbContext>(options =>
{
    options.UseNpgsql(connectionString);
});

builder.Services.AddScoped<IMovie, MovieRepository>();
builder.Services.AddScoped<IRating, RatingRepository>();

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
