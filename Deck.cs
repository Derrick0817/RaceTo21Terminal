﻿using System;
using System.Collections.Generic;
using System.Linq; // currently only needed if we use alternate shuffle method

namespace RaceTo21
{
    public class Deck
    {
        List<Card> cards = new List<Card>();

        public Deck()
        {
            Console.WriteLine("*********** Building deck...");
            string[] suits = { "S", "H", "C", "D" };

            for (int cardVal = 1; cardVal <= 13; cardVal++)
            {
                foreach (string cardSuit in suits)
                {
                    string cardName;
                    string cardFullName;
                    switch (cardVal)
                    {
                        case 1:
                            cardName = "A";
                            cardFullName = "Ace of";
                            break;
                        case 11:
                            cardName = "J";
                            cardFullName = "Jack of";
                            break;
                        case 12:
                            cardName = "Q";
                            cardFullName = "Queen of";
                            break;
                        case 13:
                            cardName = "K";
                            cardFullName ="King of";
                            break;
                        default:
                            cardName = cardVal.ToString();
                            cardFullName = cardVal.ToString() + "of";
                            break;
                    }
                    switch (cardSuit)
                    {
                        case "S":
                            cardFullName += "Spade";
                            break;
                        case "H":
                            cardFullName += "Heart";
                            break;
                        case "C":
                            cardFullName += "Club";
                            break;
                        case "D":
                            cardFullName += "Diamond";
                            break;
                    }
                    cards.Add(new Card {ID = cardName + cardSuit, name = cardFullName});
                }
            }
        }

        public void Shuffle()
        {
            Console.WriteLine("Shuffling Cards...");

            Random rng = new Random();

            // one-line method that uses Linq:
            // cards = cards.OrderBy(a => rng.Next()).ToList();

            // multi-line method that uses Array notation on a list!
            // (this should be easier to understand)
            for (int i=0; i<cards.Count; i++)
            {
                string tmp = cards[i];
                int swapindex = rng.Next(cards.Count);
                cards[i] = cards[swapindex];
                cards[swapindex] = tmp;
            }
        }

        /* Maybe we can make a variation on this that's more useful,
         * but at the moment it's just really to confirm that our 
         * shuffling method(s) worked! And normally we want our card 
         * table to do all of the displaying, don't we?!
         */

        public void ShowAllCards()
        {
            for (int i=0; i<cards.Count; i++)
            {
                Console.Write(i+":"+cards[i]); // a list property can look like an Array!
                if (i < cards.Count -1)
                {
                    Console.Write(" ");
                } else
                {
                    Console.WriteLine("");
                }
            }
        }

        public string DealTopCard()
        {
            string card = cards[cards.Count - 1];
            cards.RemoveAt(cards.Count - 1);
            // Console.WriteLine("I'm giving you " + card);
            return card;
        }
    }
}

