using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackConsole {
    internal class Dealer {
        public static int handValue = 0;
        public static List<Card> hand = new List<Card>();

        public static List<Card> AppendHand(Card card) {
            hand.Add(card);
            return hand;
        }

        public static int CalculateDealerHandValue() {
            int sum = 0;
            foreach (var card in hand) {
                sum += card.value;
            }
            return sum;
        }

        public static void PrintDealerHand() {
            Console.WriteLine("-----------------------------------");
            foreach (Card card in hand) {
                Console.WriteLine("Player card: " + card.GetName());
            }
            Console.WriteLine("Dealer's current hand value is: " + CalculateDealerHandValue());
            Console.WriteLine("-----------------------------------");
        }
    }
}
