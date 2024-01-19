using BlackjackConsole;

internal class Program {
    private static void Main(string[] args) {
        InitializeRound();
    }

    private static void InitializeRound() {
        Console.WriteLine("Your current balance is: " + Player.balance.ToString());
        Console.WriteLine("Please input the amount you would like to bet: ");
        GetBetAmountFromPlayer();
        Console.WriteLine("You have chosen to bet: " + Player.bet.ToString());

        Dealer.AppendHand(CardPicker.DrawSingleCard());
        Console.WriteLine("Dealer's first card is: " + Dealer.hand[0].GetName());
        Dealer.AppendHand(CardPicker.DrawSingleCard());
        Console.WriteLine("Dealer's second card is hidden.");

        Player.AppendHand(CardPicker.DrawSingleCard());
        Player.AppendHand(CardPicker.DrawSingleCard());
        Player.PrintPlayerHand();

        GetActionFromPlayer();
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

    private static void GetActionFromPlayer() {
        Console.WriteLine("Choose action: Hit, Stand");
        String? input = Console.ReadLine();
        if(input == "Hit") {
            Console.Clear();
            Card newCard = CardPicker.DrawSingleCard();
            Player.AppendHand(newCard);

            Console.WriteLine("Player chose to Hit. Card drawn: " + newCard.GetName());
            Console.WriteLine("Current hand sum: " + Player.CalculatePlayerHandValue());

            if (Player.CalculatePlayerHandValue() > 21) {
                Console.WriteLine("Bust. Hand value exceeded 21.");
                Player.balance -= Player.bet;
            }
            else {
                GetActionFromPlayer();
            }
        }
        else if(input == "Stand") {
            Console.Clear();
            Player.PrintPlayerHand();
            Console.WriteLine("Player chose to Stand. Flipping Dealer card: " + Dealer.hand[1].GetName());
            DealerHitUntil17();
            CompareHands();
        }
    }

    private static void CompareHands() {
        if(Dealer.CalculateDealerHandValue() > 21) {
            Console.WriteLine("Dealer bust. Dealer's hand value exceeded 21. " + Player.bet + " has been added to player's balance");
            Player.balance += Player.bet;
        }
        else if(Player.CalculatePlayerHandValue() > Dealer.CalculateDealerHandValue()) {
            if(Player.CalculatePlayerHandValue() == 21) {
                Player.balance += (2 * Player.bet);
            }
            else {
                Console.WriteLine("Player won. " + Player.bet + " has been added to player's balance");
                Player.balance += Player.bet;
            }
        }
        else {
            Console.WriteLine("Dealer won. " + Player.bet + " has been deducted from player's balance");
            Player.balance -= Player.bet;
        }
    }

    private static void DealerHitUntil17() {
        if (Dealer.CalculateDealerHandValue() < 17) {
            Dealer.AppendHand(CardPicker.DrawSingleCard());
            DealerHitUntil17();
        }
        else {
            Dealer.PrintDealerHand();
        }
    }
}