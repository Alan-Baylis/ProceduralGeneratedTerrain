using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(GenerateMap))]
public class MapGeneratorEditor : Editor
{

    public override void OnInspectorGUI()
    {
        GenerateMap mapGen = (GenerateMap)target;

        if (DrawDefaultInspector())
        {
            if (mapGen.autoUpdate)
            {
                mapGen.mapGenerate();
            }
        }

        if (GUILayout.Button("Generate"))
        {
            mapGen.mapGenerate();
        }
    }
}
