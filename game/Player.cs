namespace hilo
{
    //Deals with players decisions and keeps track of their point value
    class Player
    {
        // Program new_program = new Program();
        public int points = 300;

        public string player_guess;

        public string player_choice;

        //Gets a guess from the player
        public string guess() {
            Console.Write("Higher or lower? [h/l] ");
            player_guess = Console.ReadLine();
            return player_guess;
        }

        //Gets answer of whether player wants to play again
        public string play_again() {
            Console.Write("Do you want to play again? [y/n] ");
            player_choice = Console.ReadLine();
            return player_choice;
        }


        //Adds points
        public int point_adder(int points) {
            points += 100;
            return points;
        }

        //Subtracts points
        public int point_subtractor(int points) {
            points -= 75;
            return points;
        }

        // }
    }
}