namespace Discoteque.Data.Models;

public class Album : BaseEntity<int>{
    public string Name { get; set; }
    public string Year { get; set; }
    public Genres Genre { get; set; }
}

public enum Genres{
    Rock,
    Salsa,
    Merengue,
    Metal,
    Urban,
    Folk,
    Indie,
    Techno,
    Vallenato,
    Unknown
}