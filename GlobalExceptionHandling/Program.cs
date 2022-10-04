using GlobalExceptionHandling.Extensions;
using GlobalExceptionHandling.Filters;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers(/*options => options.Filters.Add(new ExceptionHandlingAttribute())*/);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Global Excepion Handler  Middleware
app.UseGlobalExcepionHandler();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
