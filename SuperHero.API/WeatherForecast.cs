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

// Merhaba Ho� Geldin Bu K�sm� inceleyebilirsin dikaktini �eken �ey TempratureF nin TemperatureC gelen de�erle belirlendi�i
// �imdi WatherForeCast Bolumune git