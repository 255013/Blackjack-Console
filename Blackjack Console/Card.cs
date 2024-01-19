using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackConsole {
    internal class Card(String face, int value, String suit) {
        public int value = value;
        public String suit = suit;
        public String? face = face;

        public String GetName() {

            if(value > 10 || value == 1) return face + " of " + suit;
            return value.ToString() + " of " + suit;
        }
    }
}
