using Contract.Helpers;
using Contracts.Middlewares.MiddlewaresService;
using Data.Configuration;
using Service.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(Mapper));


builder.Services.AddChallengeDbContext(builder.Configuration);

builder.Services.AddScoped<IClientInterface, ClientRepository>();
builder.Services.AddScoped<IExceptionService, ExceptionService>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();


app.Run();

