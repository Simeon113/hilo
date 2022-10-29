namespace hilo
{
    class Program
    {


      
        static void Main(string[] args)
        {

            bool lose = false;

            Player newplayer = new Player();

            string h_or_l = "n";

            
            //Creates initial card value
            Card card = new Card();

            do {

            //Gets point value from player class
            int points = newplayer.points;


            //Creates new card from card class and displays previous card value
            Card nextcard = new Card();
            Console.WriteLine($"The card is {card.value}");


            //Uses player class to get input from the player
            string player_guess = newplayer.guess();
 
            
            //Calculates whether the guess is higher or lower
            if (card.value > nextcard.value) {
                h_or_l = "l";
            }
            if (card.value < nextcard.value) {
                h_or_l = "h";
            }
             
            //Determines whether to add or subtract points using the player class
            if (h_or_l == player_guess) {
                points = newplayer.point_adder(points);
            }
            if (h_or_l != player_guess) {
                points = newplayer.point_subtractor(points);
            }

            //updates the points in player class, next the starting card for next round
            newplayer.points = points;
            card = nextcard;

            //displays what the new card was, what the new point value is
            Console.WriteLine(nextcard.value);
            Console.WriteLine($"Your score is {points}");


            //determines whether the player has lost, if not gives the option to end the game
            if (points <= 0) {
                lose = true;
            }
            else {
                lose = false;
                string choice = newplayer.play_again();
                if (choice == "n") {
                    lose = true;
                }
                }


            } while (lose != true);




        }

    }
}
