namespace hilo
{
    //Used to make new cards and give them a value
    class Card
    {
        public int value;
        
        //Asigns cards a value from 1-13
        public Card() 
        {
            Random rnd = new Random();
            value = rnd.Next(1, 14); 
        }
        
    }
}