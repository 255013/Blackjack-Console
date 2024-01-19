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
    }


}
