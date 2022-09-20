using UnityEditor;
using MKCL.Cards.Effects;
using MKCL.Cards;

[CustomPropertyDrawer(typeof(CardEvents))]
[CustomPropertyDrawer(typeof(CardEffect))]
[CustomPropertyDrawer(typeof(EffectDealDamage))]
[CustomPropertyDrawer(typeof(EffectDrawCards))]
[CustomPropertyDrawer(typeof(EffectGainPR))]
[CustomPropertyDrawer(typeof(DictionaryCardEventListEffect))]
public class AnySerializableDictionaryPropertyDrawer : SerializableDictionaryPropertyDrawer { }



[CustomPropertyDrawer(typeof(EffectStorage))]
public class AnySerializableDictionaryStoragePropertyDrawer : SerializableDictionaryStoragePropertyDrawer { }
