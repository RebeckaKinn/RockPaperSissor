namespace PlayerOppgPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var players = new List<Player> { new Player("Per", 10), new Player("Pål", 10), new Player("Espen", 10) };
            Console.WriteLine($"---GAME TIME---");
            foreach (var player in players)
            {
                Console.WriteLine($"{player.GetName()} - {player.Points}.");
            }
            var game = new Game();
            game.Start(players);
        }
    }
}