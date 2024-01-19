using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackConsole {
    internal class Card {
        public int value = 0;
        public String suit = "";
        public String name => value.ToString() + " of " + suit;
    }
}
