using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MKCL.Utils;

namespace MKCL.Cards
{
    [CreateAssetMenu(fileName = "CardData", menuName = "Cards/New Card")]
    public class CardData : ScriptableObject
    {
        [SerializeField] public DictionaryCardEventListEffect cardEvents;
    }
}