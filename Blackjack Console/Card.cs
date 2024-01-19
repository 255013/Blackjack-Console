using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackConsole {
    internal class Card(int value, String suit) {
        public int value = value;
        public String suit = suit;
        public String getName() {
            if (value == 1) return "Ace of " + suit;
            if (value == 11) return "Jack of " + suit;
            if (value == 12) return "Queen of " + suit;
            if (value == 13) return "King of " + suit;
            return value.ToString() + " of " + suit;
        }
    }
}
