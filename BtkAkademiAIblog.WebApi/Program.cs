using BtkAkademiAIblog.WebApi.Context;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<BlokAIContext>();


// Controllers
builder.Services.AddControllers();
// Swagger services
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