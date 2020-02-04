using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(BaseButtonEvent))]
public class ButtonEventEditor : Editor
{
    enum EVENT_TYPE
    {
        OPEN,
        ANIMATION,
    }

    BaseButtonEvent m_buttonEvent;

    private void OnEnable()
    {
        m_buttonEvent = target as BaseButtonEvent;
    }

    public override void OnInspectorGUI()
    {
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Event Type");
        string[] eventNames = new string[] { "Open", "Menu" };
        int[] eventValues = new int[] { (int)EVENT_TYPE.OPEN, (int)EVENT_TYPE.ANIMATION };
        m_buttonEvent.eventNum = EditorGUILayout.IntPopup(m_buttonEvent.eventNum, eventNames,eventValues);
        EditorGUILayout.EndHorizontal();

        if (m_buttonEvent.eventNum == (int)EVENT_TYPE.OPEN)
        {
            EditorGUILayout.BeginHorizontal();
            m_buttonEvent.selectObject = (GameObject)EditorGUILayout.ObjectField("Select Object", m_buttonEvent.selectObject,typeof(GameObject),true);
            EditorGUILayout.EndHorizontal();
        }

        if (m_buttonEvent.eventNum == (int)EVENT_TYPE.ANIMATION)
        {
            EditorGUILayout.BeginHorizontal();
            m_buttonEvent.selectObject = (GameObject)EditorGUILayout.ObjectField("Select Object", m_buttonEvent.selectObject, typeof(GameObject), true);
            EditorGUILayout.EndHorizontal();
        }
        
        if (GUI.changed)
        {
            EditorUtility.SetDirty(target);
        }
    }

}
