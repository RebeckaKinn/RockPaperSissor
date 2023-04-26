namespace PlayerOppgPP
{
    public class Player
    {
        private string _name { get; }
        public int Points { get; set; }

        public Player(string name, int points)
        {
            _name = name;
            Points = points;
        }

        public string GetName()
        {
            return _name;
        }

        public void Win(Player player)
        {
            Points++;
            player.Points--;
            Console.WriteLine($"\n{_name} won against {player._name}!");
            Console.WriteLine($"{player.GetName()} - {player.Points} points.\n{_name} - {Points} points.\n");
        }

        public void WinScreen(List<Player> players)
        {
            Console.WriteLine($"\nCongratulations {_name}! With {Points} points!\n");
            players.OrderByDescending(p => p.Points).ToList();
            foreach (Player player in players)
            {
                if (player._name != _name) Console.WriteLine($"---{player._name} - {player.Points}---");
            }
        }
    }
}
