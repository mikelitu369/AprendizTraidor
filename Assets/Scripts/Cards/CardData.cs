using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace MKCL.Cards
{
    [CreateAssetMenu(fileName = "Card", menuName = "Cards/CardData")]
    public class CardData : ScriptableObject
    {
        public string name;
        public CardType Type;
        public int price;
        public int manaCost;
        public bool activeEffect;
        public bool pasiveEffect;        

        [Header("Effects")]
        public List<CardEffect> ActiveEffect;
        public List<CardEffect> PasiveEffect;
        public List<CardEffect> OnBuyEffect;
        public List<CardEffect> DiscardEffect;
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