using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Experimental.AssetImporters;

[CustomEditor(typeof(PsbImporter))]
public class PsbImporterEditor : ScriptedImporterEditor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        PsbImporter main = target as PsbImporter;

        //serializedObject.Update();

        //ApplyRevertGUI();

        if(GUILayout.Button("qwe"))
        {
            string prefabPath = "Assets/qwe.prefab";
            EditorUtility.CreateEmptyPrefab(prefabPath);

            AnimationClip clip = new AnimationClip();
            clip.name = "anim";
            AssetDatabase.AddObjectToAsset(clip, prefabPath);

            EditorUtility.CreateEmptyPrefab("Assets/qwe2.prefab");
            AssetDatabase.AddObjectToAsset(clip, prefabPath);
        }
    }
}
