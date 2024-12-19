public class HockeyPlayer
{
    public string LastName { get; set; }
    public int Age { get; set; }
    public int GamesPlayed { get; set; }
    public int GoalsScored { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<HockeyPlayer> players = new List<HockeyPlayer>()
        {
            new HockeyPlayer { LastName = "Гретцки", Age = 28, GamesPlayed = 50, GoalsScored = 20 },
            new HockeyPlayer { LastName = "Овечкин", Age = 22, GamesPlayed = 60, GoalsScored = 25 },
            new HockeyPlayer { LastName = "Кеннеди", Age = 30, GamesPlayed = 45, GoalsScored = 15 },
            new HockeyPlayer { LastName = "Коффи", Age = 24, GamesPlayed = 70, GoalsScored = 30 },
            new HockeyPlayer { LastName = "Пронгер", Age = 21, GamesPlayed = 55, GoalsScored = 22 },
            new HockeyPlayer {LastName = "Фёдоров", Age = 26, GamesPlayed = 40, GoalsScored = 18}
        };
        double averageAge = players.Average(p => p.Age);
        Console.WriteLine($"Средний возраст хоккеистов: {averageAge:F1}");
        Console.WriteLine("\nХоккеисты младше 25 лет:");
        var youngPlayers = players.Where(p => p.Age < 25);

        if (youngPlayers.Any())
        {
            foreach (var player in youngPlayers)
            {
                Console.WriteLine($"Фамилия: {player.LastName} Возраст: {player.Age} Игры: {player.GamesPlayed}, Шайбы: {player.GoalsScored}");
            }
        }
        else
        {
            Console.WriteLine("Хоккеистов младше 25 лет нет");
        }
    }
}
