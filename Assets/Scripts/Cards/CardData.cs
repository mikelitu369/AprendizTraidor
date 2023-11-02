using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace MKCL.Cards
{
    [CreateAssetMenu(fileName = "Card", menuName = "Cards/CardData")]
    public class CardData : ScriptableObject
    {
        public string cardName;
        public CardType Type;
        public int price;
        public int manaCost;
        public bool activeEffect;
        public bool pasiveEffect;
        public int prepTime;

        [Header("Effects")]
        [NonReorderable]
        public List<CardEffect> ActiveEffect;
        [NonReorderable]
        public List<CardEffect> PasiveEffect;
        [NonReorderable]
        public List<CardEffect> OnBuyEffect;
        [NonReorderable]
        public List<CardEffect> DiscardEffect;
        [NonReorderable]
        public List<CardEffect> PrepEffect;
    }

    [System.Serializable]
    public class CardEffect
    {
        public CombatEffect effectType;
        public int value;

        public void Activate()
        {
            effectType.Effect(value);
        }
    }
}