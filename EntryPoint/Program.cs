using Services;
using System.Text.Json.Serialization;
using Models;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Bson;
using Data.Repositories;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Services.Interfaces;

static async Task SeedDatabaseOnStartup(WebApplication app)
{
    using var scope = app.Services.CreateScope();
    var services = scope.ServiceProvider;
    var logger = services.GetRequiredService<ILogger<Program>>();

    try
    {
        logger.LogInformation("Checking database seed status on startup");
        var seeder = services.GetRequiredService<Seeder>();
        await seeder.SeedAllData();
        logger.LogInformation("Database seeding check completed");
    }
    catch (Exception ex)
    {
        logger.LogError(ex, "An error occurred during automatic database seeding");
    }
}

var pack = new ConventionPack
{
    new CamelCaseElementNameConvention(),
    new IgnoreIfNullConvention(true),
    new EnumRepresentationConvention(BsonType.String)
};
ConventionRegistry.Register("Custom Conventions", pack, t => true);

Console.WriteLine($"MongoDB Driver Version: {typeof(MongoClient).Assembly.GetName().Version}");
BsonSerializer.RegisterSerializer(new GuidSerializer(BsonType.String));

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("http://localhost:5173", "http://localhost:5174", "https://vdeijk.github.io")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.Configure<MongoDbSettings>(
builder.Configuration.GetSection("MongoDbSettings"));

builder.Services.AddScoped<Seeder>();
builder.Services.AddHttpClient<WeatherService>();
builder.Services.AddScoped<WeatherService>();
builder.Services.AddScoped<IFieldRepo, FieldRepo>();
builder.Services.AddScoped<ITodoRepo, TodoRepo>();
builder.Services.AddScoped<IBatchRepo, BatchRepo>();
builder.Services.AddScoped<ICropRepo, CropRepo>();
builder.Services.AddScoped<IReadingRepo, ReadingRepo>();

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.UseInlineDefinitionsForEnums();
});

var app = builder.Build();

var port = Environment.GetEnvironmentVariable("PORT") ?? "5000";
app.Urls.Add($"http://*:{port}");

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
}

if (app.Environment.IsDevelopment())
{
    await SeedDatabaseOnStartup(app);
}

await SeedDatabaseOnStartup(app);

app.Run();