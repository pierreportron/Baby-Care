using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(WaterTap))]
public class WaterTapEditor : Editor
{

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        WaterTap wt = (WaterTap)target;

        if (GUILayout.Button("open tap"))
        {
            wt.OpenRobinet();
        }

        if (GUILayout.Button("close tap"))
        {
            wt.CloseRobinet();
        }

    }
        
}
