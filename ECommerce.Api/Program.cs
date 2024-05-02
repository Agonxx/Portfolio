using ECommerce.Api.Core.Config;
using ECommerce.Api.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

ConfigRepositorys.ConfigurarRepositorys(builder.Services);
var connectionString = builder.Configuration.GetConnectionString("ConexaoBanco");

builder.Services.AddDbContext<DBECommerce>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
