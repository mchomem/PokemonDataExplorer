var builder = WebApplication.CreateBuilder(args);

// Configure a licença do QuestPDF
QuestPDF.Settings.License = LicenseType.Community;

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var pokeApiConfig = new PokemonApiConfig();

builder.Configuration.GetSection("PokeApi").Bind(pokeApiConfig);
builder.Services.Configure<PokemonApiConfig>(builder.Configuration.GetSection("PokeApi"));
builder.Services
    .AddRefitClient<IPokemonApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(pokeApiConfig.BaseUrl));

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
await app.RunAsync();
