var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<LineBotConfig, LineBotConfig>((s)=> new LineBotConfig
{
    channelSecret = builder.Configuration.GetSection("LineBot")["channelSecret"]!,
    accessToken = builder.Configuration.GetSection("LineBot")["accessToken"]!,
});

//DI
builder.Services.AddSingleton<ILineService, LineService>();
builder.Services.AddHttpContextAccessor();



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