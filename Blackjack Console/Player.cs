using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackConsole {
    internal class Player {
        public static int balance = 100;
        public static int bet = 0;
        public static int handValue = 0;
        public static List<Card> hand = new List<Card>();

        public static List<Card> AppendHand(Card card) {
            hand.Add(card);
            return hand;
        }

        public static int CalculatePlayerHandValue() {
            int sum = 0;
            foreach (var card in hand){
                sum += card.value;
            }
            return sum;
        }

        public static void PrintPlayerHand() {
            Console.WriteLine("-----------------------------------");
            foreach (Card card in hand){
                Console.WriteLine("Player card: " + card.GetName());
            }
            Console.WriteLine("Player's current hand value is: " + CalculatePlayerHandValue());
            Console.WriteLine("-----------------------------------");
        }
    }


}
