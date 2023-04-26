namespace PlayerOppgPP
{
    public class Game
    {
        public void Start(List<Player> players)
        {

            for (var round = 0; round < 5; round++)
            {
                Console.WriteLine("Round : " + round);
                WhoWillPlay(players);
                //foreach (var player in players)
                //{
                //    Console.WriteLine($"{player.GetName()} has {player.Points} points.");
                //}
            }
            CheckWinner(players);

        }

        //public int Number1(int maxNumber)
        //{
        //    int random = new Random().Next(maxNumber);
        //    return random;
        //}
        //public int Number2(int maxNumber)
        //{
        //    int random = new Random().Next(maxNumber);
        //    if (random == Number1(maxNumber)) Number2(maxNumber);
        //    return random;
        //}

        public void WhoWillPlay(List<Player> players)
        {
            var p1 = new Random().Next(100);
            var p2 = new Random().Next(100);
            var p3 = new Random().Next(100);
            if (p1 > p2 && p2 > p3) PapirRockSissor(players[0], players[1]);
            if (p3 > p2 && p2 > p1) PapirRockSissor(players[1], players[2]);
            if (p1 > p2 && p3 > p2) PapirRockSissor(players[0], players[2]);
            else WhoWillPlay(players);
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
