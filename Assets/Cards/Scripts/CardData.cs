using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MKCL.Cards
{
    [CreateAssetMenu(fileName = "CardData", menuName = "Cards/New Card")]
    public class CardData : ScriptableObject
    {
        public DictionaryCardEventListEffect cardEvents;
    }
}