using DynamicFormAPI.Implementation;
using DynamicFormAPI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICustomerFieldService, CustomerFieldService>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseStaticFiles(); 
app.UseRouting();
app.MapControllers();

app.Run();
