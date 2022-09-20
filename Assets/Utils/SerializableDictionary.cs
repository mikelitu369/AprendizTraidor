using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MKCL.Cards;
using MKCL.Cards.Effects;
using System;

[Serializable]
public class EffectStorage : SerializableDictionary.Storage<List<CardEffect>> { }
[Serializable]
public class DictionaryCardEventListEffect : SerializableDictionary<CardEvents, EffectStorage> { }