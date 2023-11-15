using MySql.Data.MySqlClient;
using course_booking_cs.Data;
using course_booking_cs.Database;
using Microsoft.EntityFrameworkCore;
using DotNetEnv;

DotNetEnv.Env.Load();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add CORS service
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

// Create the database connection
// Make sure to modify this field accordingly
string dbHost = Environment.GetEnvironmentVariable("DBHOST") ?? "localhost";
string dbPort = Environment.GetEnvironmentVariable("MYSQLDB_LOCAL_PORT") ?? "3306";
string dbName = Environment.GetEnvironmentVariable("MYSQLDB_DATABASE") ?? "CourseBookingDb";
string dbUser = Environment.GetEnvironmentVariable("MYSQLDB_USER") ?? "root";
string dbPassword = Environment.GetEnvironmentVariable("MYSQLDB_ROOT_PASSWORD") ?? null;

string connectionString = $"server={dbHost};port={dbPort};database={dbName};userid={dbUser};pwd={dbPassword};";

// Register the DbContext as a scoped service
builder.Services.AddDbContext<AppDbContext>(options => options.UseMySQL(connectionString));

// Register the repositories as scoped services
builder.Services.AddScoped<UserRepository>();
builder.Services.AddScoped<CourseRepository>();
builder.Services.AddScoped<CourseEnrollmentRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Enable CORS
app.UseCors("AllowAllOrigins");

app.UseAuthorization();

app.MapControllers();

app.Run();

