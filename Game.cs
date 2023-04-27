namespace PlayerOppgPP
{
    public class Game
    {
        public void Start(List<Player> players)
        {
            for (var round = 1; round < 11; round++)
            {
                Console.WriteLine("Round : " + round);
                int rnd = new Random().Next(players.Count);
                int rnd2 = rnd + 1;
                var player1 = players[rnd];
                var player2 = players[rnd2 == players.Count ? 0 : rnd2];
                PapirRockSissor(player1, player2);
            }
            CheckWinner(players);
        }
        public void PapirRockSissor(Player player1, Player player2)
        {
            int nmb = new Random().Next(1, 3);
            int nmb2 = new Random().Next(1, 3);
            if (nmb == nmb2) PapirRockSissor(player1, player2);
            if (nmb == 1 && nmb2 == 2 || nmb == 2 && nmb2 == 3 || nmb == 3 && nmb2 == 1) player1.Win(player2);
            if (nmb == 2 && nmb2 == 1 || nmb == 3 && nmb2 == 2 || nmb == 1 && nmb2 == 3) player2.Win(player1);
        }
        public void CheckWinner(List<Player> players)
        {
            players.OrderByDescending(p => p.Points).ToList();
            var player = players[players.Count - 1];
            player.WinScreen(players);
        }
    }
}
