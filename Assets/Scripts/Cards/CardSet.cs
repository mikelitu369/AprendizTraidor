using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace MKCL.Cards
{
    [CreateAssetMenu(fileName = "Cards Set", menuName = "Cards/Card Set")]
    public class CardSet : ScriptableObject
    {
        public List<CardData> cards;

        public void Shuffle()
        {
            cards.Shuffle();
        }



        /// <summary>
        /// Takes the number of specified top cards/last cards and return a list removing them
        /// from the deck in the process
        /// </summary>
        /// <param name="numberOfCards"></param>
        /// <returns></returns>
        public List<CardData> TakeFirstCards(int numberOfCards)
        {
            List<CardData> returnValue = new List<CardData>();
            returnValue = cards.TakeLast(numberOfCards).ToList();

            for (int i = 0; i < numberOfCards; ++i)
            {
                cards.RemoveAt(cards.Count - 1);
            }

            return returnValue;
        }

        /// <summary>
        /// Takes a number of the specified card returning a list and removing them
        /// from the deck in the process
        /// </summary>
        /// <param name="nummberOfCards"> Number of times we want to find that card</param>
        /// <param name="card"> Card to search for</param>
        /// <returns></returns>
        public List<CardData> TakeNumberSpecificCards(int nummberOfCards, CardData card)
        {
            List<CardData> returnValue = new List<CardData>();

            for (int i = 0; i < nummberOfCards; ++i)
            {
                int index = cards.FindIndex((s) => s == card);
                if(index == -1)
                {
                    Debug.LogWarning("Tried to seearch for more than the current ammount of" +
                        " copys of the card in the deck");

                    break;
                }
                returnValue.Add(cards[index]);
                cards.RemoveAt(index);
            }

            return returnValue;
        }

        public List<CardData> TakeAllCopysOfSpecificCard(CardData card)
        {
            List<CardData> returnValue = new List<CardData>();

            returnValue = cards.FindAll((s) => s == card).ToList();

            return returnValue;
        }
    }
}

