namespace SuperHero.API
{
    public class SuperHeroModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty; // Name Altı yeşil olmasın diye null dönmesin 
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string Place { get; set; } = String.Empty;
    }
}

// Modeli oluşturduk-------Şimdi Controller Oluşturalım-------> SuperHeroController