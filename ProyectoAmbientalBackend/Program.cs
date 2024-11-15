var builder = WebApplication.CreateBuilder(args);

// Agregar servicios al contenedor
builder.Services.AddControllers();

// Configurar CORS para permitir solicitudes desde la aplicación React
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp",
        policy =>
        {
            policy.WithOrigins("http://localhost:5178") // Cambia esta URL si es necesario
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

// Configuración de Swagger / OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configurar el pipeline de solicitudes HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Usar CORS con la política que configuramos
app.UseCors("AllowReactApp");

app.UseAuthorization();

app.MapControllers();

app.Run();

