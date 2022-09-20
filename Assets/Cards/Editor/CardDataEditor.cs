using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace MKCL.Cards
{
    [CustomEditor(typeof(CardData))]
    public class CardDataEditor : Editor
    {
        CardData card;
        CardEvents selectedEvent;


        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            EditorFunctionsUtils.GuiLine();

            selectedEvent = (CardEvents)EditorGUILayout.EnumPopup(selectedEvent);
        }
    }
}