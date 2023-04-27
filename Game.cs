namespace PlayerOppgPP
{
    public class Game
    {
        public void Start(List<Player> players)
        {
            for (var round = 1; round < 11; round++)
            {
                Console.WriteLine("Round : " + round);
                var rnd = new Random();
                int indexOfPlayer1 = rnd.Next(players.Count);
                int indexOfPlayer2 = indexOfPlayer1 + 1;
                var player1 = players[indexOfPlayer1];
                var player2 = players[indexOfPlayer2 == players.Count ? 0 : indexOfPlayer2];
                PapirRockSissor(player1, player2);
            }
            CheckWinner(players);
        }
        public void PapirRockSissor(Player player1, Player player2)
        {
            var rnd = new Random();
            int choicePlayer1 = rnd.Next(1, 3);
            int choicePlayer2 = rnd.Next(1, 3);
            if (choicePlayer1 == choicePlayer2) PapirRockSissor(player1, player2);
            if (choicePlayer1 == 1 && choicePlayer2 == 2 || choicePlayer1 == 2 && choicePlayer2 == 3 || choicePlayer1 == 3 && choicePlayer2 == 1) player1.Win(player2);
            if (choicePlayer1 == 2 && choicePlayer2 == 1 || choicePlayer1 == 3 && choicePlayer2 == 2 || choicePlayer1 == 1 && choicePlayer2 == 3) player2.Win(player1);
        }
        public void CheckWinner(List<Player> players)
        {
            players.OrderByDescending(p => p.Points).ToList();
            var player = players[players.Count - 1];
            player.WinScreen(players);
        }
    }
}
