using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(DepthLayerManager))]
public class DepthLayerManagerEditor : Editor
{
    
    public override void OnInspectorGUI()
    {

        DrawDefaultInspector();

        DepthLayerManager myScript = (DepthLayerManager)target;
        if(GUILayout.Button("Sort Sprites"))
        {
            myScript.SortSprites();
        }

    }
    
}