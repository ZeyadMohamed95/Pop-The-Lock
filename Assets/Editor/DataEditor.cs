using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(GameData))]
public class DataEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        GUI.enabled = true;

        GameData D = target as GameData;
        if (GUILayout.Button("Reset"))
        {
            D.ResetData();
        }
    }
}
