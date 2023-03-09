using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        List<Card> pack = new List<Card>(52);

        public Pack(int Value, int Suit)
        {
            //Initialise the card pack here
            Value = 1;
            for (int i = 0; i <= 12; i++)
            {
                Suit = 1;
                Value++;
            }
            Value = 1;
            for (int i = 13; i <= 25; i++)
            {
                Suit = 2;
                Value++;
            }
            Value = 1;
            for (int i = 26; i <= 38; i++)
            {
                Suit = 3;
                Value++;
            }
            Value = 1;
            for (int i = 39; i <= 51; i++)
            {
                Suit = 4;
                Value++;
            }
            
        }
        //Shuffle Type Fisher-Yates
        void fisherYates()
        {
            int lastIn = pack.Count() - 1;
            while(lastIn > 0)
            {
                Card tempValue = pack[lastIn];
                int randomIn = new Random().Next(0, lastIn);
                pack[lastIn] = pack[randomIn];
                pack[randomIn] = tempValue;

            }
        }
        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            if (typeOfShuffle == 1)
            {
                Pack np = new Pack();
                np.fisherYates();
            }
            


        }
        public static Card deal()
        {
            //Deals one card

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
        }
    }
}
