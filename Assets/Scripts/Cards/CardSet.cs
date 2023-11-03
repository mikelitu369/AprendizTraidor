using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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
    }
}

