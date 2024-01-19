using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackConsole {
    internal class CardPicker {
        static Random random = new();

        public static Card DrawSingleCard() {
            int randValue = RandomValue();
            Card card = new Card(RandomFace(randValue), RandomValueFix(randValue), RandomSuit());
            return card;
        }

        private static int RandomValue() {
            int value = random.Next(1, 14); //Non-inclusive method. Grants value from 1-13.
            return value;
        }
        private static int RandomValueFix(int value) {
            if(value > 10) {
                value = 10;
            };
            return value;
        }

        private static String RandomFace(int value) {
            if (value == 1)   return "Ace";
            if (value == 11)  return "Ace";
            if (value == 12)  return "Queen";
            if (value == 13)  return "King";
            return "";
        }

        private static string RandomSuit() {
            int value = random.Next(1, 5); //Non-inclusive method. Grants value from 1-4.
            if (value == 1) return "Clubs";
            if (value == 2) return "Hearts";
            if (value == 3) return "Diamonds";
            return "Spades"; //last return branch because of guard clause
        }
    }
}