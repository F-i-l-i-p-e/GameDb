using System.ComponentModel.DataAnnotations; // Import Data Annotations

namespace GameDb.Models // Namespace Declaration
{
    public class Game // Game Class
    {
        [Key] // Primary Key
        public int GameId { get; set; } // Game ID
        public string Title { get; set; } // Game Title
        public string Genre { get; set; } // Game Genre
        public string Developer { get; set; } // Game Developer
        public string Publisher { get; set; } // Game Publisher
        public double Price { get; set; } // Game Price
    }
}
