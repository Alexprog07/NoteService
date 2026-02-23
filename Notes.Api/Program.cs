using Notes.DataBases;
using Notes.Domain;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDataBases();
builder.Services.AddDomain();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
var app = builder.Build();

app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI();
app.Run();
