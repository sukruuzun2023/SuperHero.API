namespace SuperHero.API
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}

// Merhaba Hoþ Geldin Bu Kýsmý inceleyebilirsin dikaktini çeken þey TempratureF nin TemperatureC gelen deðerle belirlendiði
// Þimdi WatherForeCast Bolumune git