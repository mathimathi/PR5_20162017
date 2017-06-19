using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InLES.Models
{
    public class DeckRepo
    {
        private List<Deck> decks;

        private static DeckRepo instance;

        public static DeckRepo GetInstance()
        {
            if (instance == null)
                instance = new DeckRepo();
            return instance;
        }

        private DeckRepo()
        {
            decks = new List<Deck>();
            CreateDecks();
        }

        private void CreateDecks()
        {
            string decklink = "http://deckbox.org/system/images/mtg/cards/985.jpg";
            Card card1 = new Card("Forest", decklink);
            Card card2 = new Card("Swamp", decklink);
            Card card3 = new Card("Llanowar Elves", decklink);
            Card card4 = new Card("City of Brass", decklink);
            Card card5 = new Card("Giant Growth", decklink);

            List<Card> deckA = new List<Card>();
            deckA.Add(card1);
            deckA.Add(card2);
            deckA.Add(card3);
            List<Card> boardA = new List<Card>();
            boardA.Add(card4);
            boardA.Add(card5);
            decks.Add(new Deck(1, "Elves", "Mathi", deckA, boardA));

            List<Card> deckB = new List<Card>();
            deckB.Add(card2);
            deckB.Add(card3);
            deckB.Add(card4);
            deckB.Add(card5);
            List<Card> boardB = new List<Card>();
            boardB.Add(card1);
            boardB.Add(card3);
            decks.Add(new Deck(2, "Miracles", "Geraar", deckB, boardB));
            for (int i = 0; i < 5; i++)
            {
                Deck thedeck = new Deck(rnd.Next(99999), randomdecknaam(), randomspeler(), kaartenlijst(60), kaartenlijst(15));
                thedeck.RatingLeuk = rnd.Next(5);
                thedeck.RatingMulligan = rnd.Next(5);
                decks.Add(thedeck);
                // decks.Add(new Deck(rnd.Next(99999), randomdecknaam(), randomspeler(), kaartenlijst(60), kaartenlijst(15)));
            }
        }
        Random rnd = new Random();
        public string randomspeler()
        {
            List<string> spelerlijst = new List<string> { "Mathi", "Superman", "Batman", "Wonderwoman", "De Hulk", "McGyver", "Chuck Norris" };
            int spelernr = rnd.Next(7);
            return spelerlijst[spelernr];
        }
        public string randomdecknaam()
        {
            List<string> decknamen = new List<string> { "Storm", "Elves", "UW Control", "8Rack", "Zoo", "Omnitell", "White Weenie" };
            int decknr = rnd.Next(7);
            return decknamen[decknr];
        }
        public Card randomcard()
        {
            int kaartnr = rnd.Next(1, 601);
            string naam = "kaartnaam " + kaartnr.ToString();
            string link = "http://deckbox.org/system/images/mtg/cards/" + kaartnr.ToString() + ".jpg";
            Card mijnkaart = new Card(naam, link);
            return mijnkaart;
        }
        public List<Card> kaartenlijst(int aantal)
        {
            List<Card> mijnlijst = new List<Card>();
            for (int i = 0; i < aantal; i++)
            {
                mijnlijst.Add(randomcard());
            }
            return mijnlijst;
        }

        public List<Deck> GetDecks()
        {
            return decks;
        }

        public Deck GetDeck(int id)
        {
            return decks.FirstOrDefault(x => x.Id == id);
        }

        public void SaveDeck (Deck d)
        {
            decks.Add(d);
        }
    }
}