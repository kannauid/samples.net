using Serialization1.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IJsonRepository, JsonRepository>();
builder.Services.AddSingleton<IXmlRepository, XmlRepository>();

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
