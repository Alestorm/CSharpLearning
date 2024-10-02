using ContactsApi.Models.Interfaces;
using ContactsApi.Repositories.Database;
using ContactsApi.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string server = builder.Configuration.GetValue<string>("MySqlConnectionString:server") ?? string.Empty;
string database = builder.Configuration.GetValue<string>("MySqlConnectionString:database") ?? string.Empty;
string user = builder.Configuration.GetValue<string>("MySqlConnectionString:user") ?? string.Empty;
string password = builder.Configuration.GetValue<string>("MySqlConnectionString:password") ?? string.Empty;

string connectionString = $"server={server};database={database};user={user};password={password}";

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseMySQL(connectionString);
});

builder.Services.AddScoped<IUser, UserRepository>();
builder.Services.AddScoped<IContact, ContactRepository>();

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
