var builder = WebApplication.CreateBuilder(args);

// 1. Add Services
builder.Services.AddControllers();

// [Integration Step] Enable CORS to allow Frontend to talk to Backend
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend",
        policy => policy.WithOrigins("http://127.0.0.1:5500", "http://localhost:5500") // VS Code Live Server Ports
                        .AllowAnyMethod()
                        .AllowAnyHeader());
});

var app = builder.Build();

// 2. Configure Pipeline
app.UseHttpsRedirection();

// [Integration Step] Apply CORS Policy
app.UseCors("AllowFrontend");

app.UseAuthorization();
app.MapControllers();

app.Run();