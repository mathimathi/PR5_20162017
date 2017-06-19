using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InLES.Models
{
    public class Deck
    {
        public int Id { get; set; }
        public string Deckname { get; set; }
        public string Creator { get; set; }
        public List<Card> Decklist { get; set; }
        public List<Card> Sideboard { get; set; }
        public int RatingLeuk { get; set; }
        public int RatingLeukAantal { get; set; }
        public int RatingMulligan { get; set; }
        public int RatingMulliganAantal { get; set; }

        public Deck(int id, string name, string maker, List<Card> deck, List<Card> side)
        {
            this.Id = id;
            this.Deckname = name;
            this.Creator = maker;
            this.Decklist = deck;
            this.Sideboard = side;
            this.RatingLeuk = 0;
            this.RatingLeukAantal = 0;
            this.RatingMulligan = 0;
            this.RatingMulliganAantal = 0;
        }
    }
}