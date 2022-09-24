using UnityEngine;
using UnityEditor;
using MKCL.Cards.Effects;

namespace MKCL.Cards.Effects
{
    [CustomPropertyDrawer(typeof(EffectDealDamage))]
    public class DealDamageDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);

            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

            var indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;

            var valueRect = new Rect(position.x, position.y, position.width, position.height);

            EditorGUI.PropertyField(valueRect, property.FindPropertyRelative("damage"), GUIContent.none);

            EditorGUI.indentLevel = indent;

            EditorGUI.EndProperty();
        }
    }
}