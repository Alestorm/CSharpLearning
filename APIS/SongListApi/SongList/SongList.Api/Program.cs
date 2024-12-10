using Microsoft.EntityFrameworkCore;
using SongList.Application.Contracts;
using SongList.Application.Services;
using SongList.Domain.Contracts;
using SongList.Infrastructure.MySqlDatabase;
using SongList.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


string server = builder.Configuration.GetValue<string>("MySqlConnectionString:server") ?? string.Empty;
string database = builder.Configuration.GetValue<string>("MySqlConnectionString:database") ?? string.Empty;
string user = builder.Configuration.GetValue<string>("MySqlConnectionString:user") ?? string.Empty;
string password = builder.Configuration.GetValue<string>("MySqlConnectionString:password") ?? string.Empty;

string connectionString = $"server={server};database={database};user={user};password={password}";

builder.Services.AddDbContext<MySqlDbContext>(options =>
{
    options.UseMySQL(connectionString);
});

builder.Services.AddTransient<IUser, UserRepository>();
builder.Services.AddTransient<IUserService, UserService>();

builder.Services.AddTransient<ISong, SongRepository>();
builder.Services.AddTransient<ISongService, SongService>();
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
