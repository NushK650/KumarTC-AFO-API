using KumarTC_AFO_API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<OddOrEvenServices>();
builder.Services.AddScoped<ReverseItANServices>();
builder.Services.AddScoped<Add2NumbersServices>();
builder.Services.AddScoped<GreetingsServices>();
builder.Services.AddScoped<GuessItService>();
builder.Services.AddScoped<MadLibServices>();
builder.Services.AddScoped<Magic8BallService>();
builder.Services.AddScoped<RestaurantPickerService>();
builder.Services.AddScoped<ReverseItNOServices>();
builder.Services.AddScoped<SayHelloServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
