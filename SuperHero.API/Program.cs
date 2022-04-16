global using SuperHero.API.Data; // bu kýsma global dedik bunu sorcam neden oyle oldugunu
global using Microsoft.EntityFrameworkCore; // bu kýsma global dedik bunu sorcam neden oyle oldugunu

var builder = WebApplication.CreateBuilder(args);
// Data Baðlantý Kodlarýmýzý yazýyoruz
//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddDbContext<DataContext>(options =>
//options.UseSqlServer(connectionString));
//--------------------------------- alttaki kodla ustteki kod ayný manaya geliyor-----------------------------
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Data Baðlantýsý bitti Þimdi Migration iþlemini yapalým----->>>>Datayý Kontrol Elelim<<<<< Ýlk Satýrlarý kodlayalým>> SuperHero Controller gidelim

// Add services to the container.

builder.Services.AddControllers();




// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
