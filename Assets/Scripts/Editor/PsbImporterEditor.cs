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
            //string prefabPath = "Assets/qwe.prefab";
            //EditorUtility.CreateEmptyPrefab(prefabPath);

            GameObject s1 = new GameObject("s1");
            AssetDatabase.AddObjectToAsset(s1, "");

            AssetDatabase.CreateAsset(s1, "Assets/s1");

            //AnimationClip clip = new AnimationClip();
            //clip.name = "anim";
            //AssetDatabase.AddObjectToAsset(clip, prefabPath);

            //GameObject g2 = new GameObject("g2");
            //GameObject asset = PrefabUtility.SaveAsPrefabAsset(g2, "Assets/qwe2.prefab");
            //AssetDatabase.AddObjectToAsset(asset, prefabPath);
        }
    }
}
