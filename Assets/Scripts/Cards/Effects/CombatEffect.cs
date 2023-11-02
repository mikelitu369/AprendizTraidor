using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MKCL.Cards
{
    public abstract class CombatEffect : ScriptableObject
    {
        public abstract void Effect(int value);
    }
}