using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(float))]
public class customdrawer : PropertyDrawer
{
    // Start is called before the first frame update
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        //base.OnGUI(position, property, label);
        EditorGUI.BeginProperty(position, label, property);
        position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);
        GUI.backgroundColor = Color.Lerp(Color.red, Color.green, property.floatValue / 100);
        EditorGUI.PropertyField(position, property, GUIContent.none);
        EditorGUI.EndProperty();
    }
}
