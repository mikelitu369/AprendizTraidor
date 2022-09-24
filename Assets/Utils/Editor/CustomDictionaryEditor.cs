using UnityEditor;
using MKCL.Cards.Effects;
using MKCL.Cards;

[CustomPropertyDrawer(typeof(DictionaryCardEventListEffect))]
public class AnySerializableDictionaryPropertyDrawer : SerializableDictionaryPropertyDrawer { }



[CustomPropertyDrawer(typeof(EffectStorage))]
public class AnySerializableDictionaryStoragePropertyDrawer : SerializableDictionaryStoragePropertyDrawer { }
