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
    }
}
