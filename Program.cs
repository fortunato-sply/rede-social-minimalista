using temp;
using temp.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
  options.AddPolicy(name: "MainPolicy",
  policy =>
  {
    policy
        .AllowAnyHeader()
        .AllowAnyOrigin()
        .AllowAnyMethod();
  });
});

var env = builder.Environment;

builder.Services.AddScoped<RepoExemploContext>();
builder.Services.AddTransient<IRepository<Mensagem>, MessageRepository>();

builder.Services.AddTransient<CpfService>();

var app = builder.Build();

app.UseCors(); // Usando Cors

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();