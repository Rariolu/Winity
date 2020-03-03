using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class temp : ScriptableObject
{
    [MenuItem("Tools/CodeGeneration/Generate Code")]
    static void GenerateCode()
    {
        GameObject b = GameObject.Find("blep");
        string mf;
        string df;
        CodeGenerator.CreateCustomGameObject(b, out mf, out df);
        Debug.Log(mf);
        Debug.Log(df);
    }
    [MenuItem("Tools/CodeGeneration/Appendier")]
    static void GenerateCode1()
    {
        GameObject obj = GameObject.Find("blep");
        IndentedStringBuilder isb = new IndentedStringBuilder();
        CodeGenerator.AppendGameObject(obj, ref isb);
        Debug.Log(isb.ToString());
    }
    [MenuItem("Tools/CodeGeneration/GameObject code generation")]
    static void GameObjectGeneration()
    {
        int currentPickerWindow = EditorGUIUtility.GetControlID(FocusType.Passive) + 100;
        EditorGUIUtility.ShowObjectPicker<GameObject>(null, true, "", currentPickerWindow);
        GameObject obj = (GameObject)EditorGUIUtility.GetObjectPickerObject();
        IndentedStringBuilder isb = new IndentedStringBuilder();
        CodeGenerator.AppendGameObject(obj, ref isb);
        Debug.Log(isb.ToString());
    }
}