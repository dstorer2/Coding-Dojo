namespace CardDeck
{
    interface IRandomizable
    {
        void Randomize();
    }

    public class Card
    {
        public string StringVal;
        public string Suit;
        public int Val;
        public Card(string stringVal, string suit, int val)
        {
            StringVal = stringVal;
            Suit = suit;
            Val = val;
        }
    }
    public class Deck : IRandomizable
    {
        private List<Card> cards;
        public Deck()
        {
            cards = new List<Card>();
            populateDeck();
        }
        private void populateDeck()
        {
            Console.WriteLine("populate the deck");
            string[] suits = new string[]{"Spade", "Heart", "Diamond", "Club"};
            for (int i = 0; i < suits.Length; ++i)
            {
                for (int val = 1; val <= 13; ++val)
                {
                    string stringVal;
                    switch(val)
                    {
                        case 1:
                            stringVal = "Ace";
                            break;
                        case 11:
                            stringVal = "Jack";
                            break;
                        case 12:
                            stringVal = "Queen";
                            break;
                        case 13:
                            stringVal = "King";
                            break;
                        default:
                            stringVal = val.ToString();
                            break;
                    }
                    cards.Add(new Card(stringVal, suits[i], val));
                }
            }

        }
        public Card dealCard()
        {
            Card draw = cards[0];
            cards.Remove(cards[0]);
            return draw;
        }
        public void resetDeck()
        {
            while (cards.Count > 0)
            {
                cards.Remove(cards[0]);
            }
            populateDeck();
        }
        public void Randomize()
        {
            Random rand = new Random();
            for (int i = 0; i < cards.Count; ++i){
                int ran = rand.Next(cards.Count);
                Card temp = cards[i];
                cards[i] = cards[ran];
                cards[ran] = temp;
            }
        }
    }
    class Player
    {
        public string Name;
        public List<Card> Hand;
        public Deck deck = new Deck();
        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>();
        }
        public bool HasCards
        {
            get
            {
                if (Hand.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Card Draw()
        {
            Card dealtCard = deck.dealCard();
            Hand.Add(dealtCard);
            return dealtCard;
        }
        public Card? Discard(int index)
        {
            if (HasCards)
            {
                Card discarded = Hand[index];
                Hand.Remove(discarded);
                return discarded;
            }
            else
            {
                return null;
            }
        }
    }
}