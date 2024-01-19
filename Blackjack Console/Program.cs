using BlackjackConsole;

internal class Program {
    private static void Main(string[] args) {
        Console.WriteLine("Your current balance is: " + Player.balance.ToString());
        Console.WriteLine("Please input the amount you would like to bet: ");
        GetBetAmountFromPlayer();
        Console.WriteLine("You have chosen to bet: " + Player.bet.ToString());

        Dealer.AppendHand(CardPicker.DrawSingleCard());
        Console.WriteLine("Dealer's first card is: " + Dealer.hand[0].name);

        Player.AppendHand(CardPicker.DrawSingleCard());
        Console.WriteLine("Player's first card is: " + Player.hand[0].name);


    }

    private static int GetBetAmountFromPlayer() {
        string? input = Console.ReadLine();     //Read bet input from player
        if(input != null) {                     //Make sure bet is not null
            Player.bet = Int32.Parse(input);    //Assign input to player class value
        }
        if(Player.bet < Player.balance) {       //Make sure bet is valid (does not exceed player balance)
            return Player.bet;
        }
        else {
            Console.WriteLine("Invalid input or not enough balance");
            return GetBetAmountFromPlayer();    //Retry valid user input
        }
    }
}