using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using MKCL.Cards.Effects;
using MKCL.Reflection;
using System;

namespace MKCL.Cards
{
    [CustomEditor(typeof(CardData))]
    public class CardDataEditor : Editor
    {
        CardData data = null;

        CardEvents selectedEvent;
        List<string> cardEffectList = new List<string>();
        Dictionary<string, string> cardEffectDictionary = new Dictionary<string, string>();
        int effectIndex;


        public override void OnInspectorGUI()
        {
            if (data == null) data = (CardData)target;
            if (cardEffectList.Count == 0) LoadTypes();

            base.OnInspectorGUI();
            
            EditorFunctionsUtils.GuiLine();

            selectedEvent = (CardEvents)EditorGUILayout.EnumPopup(selectedEvent);

            effectIndex = EditorGUILayout.Popup(effectIndex, cardEffectList.ToArray());

            if (GUILayout.Button("Add Effect")) AddEffect();
        }

        void LoadTypes()
        {

            foreach(Type t in ReflectionUtils.GetInheritedClasses(typeof(CardEffect)))
            {
                cardEffectList.Add(t.Name);
                cardEffectDictionary[t.Name] = t.FullName;
            }
        }

        void AddEffect()
        {
            if (cardEffectList.Count == 0) LoadTypes();

            string fullNameClass = cardEffectDictionary[cardEffectList[effectIndex]];

            object newEffectHandle = Activator.CreateInstance("Assembly-CSharp", fullNameClass).Unwrap();

            CardEffect effect = (CardEffect)newEffectHandle;

            data.cardEvents[selectedEvent].data.Add(effect);
        }
    }
}