global using SuperHero.API.Data; // bu k�sma global dedik bunu sorcam neden oyle oldugunu
global using Microsoft.EntityFrameworkCore; // bu k�sma global dedik bunu sorcam neden oyle oldugunu

var builder = WebApplication.CreateBuilder(args);
// Data Ba�lant� Kodlar�m�z� yaz�yoruz
//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddDbContext<DataContext>(options =>
//options.UseSqlServer(connectionString));
//--------------------------------- alttaki kodla ustteki kod ayn� manaya geliyor-----------------------------
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Data Ba�lant�s� bitti �imdi Migration i�lemini yapal�m----->>>>Datay� Kontrol Elelim<<<<< �lk Sat�rlar� kodlayal�m>> SuperHero Controller gidelim

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
