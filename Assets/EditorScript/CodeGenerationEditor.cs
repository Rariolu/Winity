using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

#if UNITY_EDITOR

public class temp : ScriptableObject
{

    [MenuItem("Tools/CodeGeneration/Scene")]
    static void CreateSceneFiles()
    {
        string mainDir = "Assets\\Scripts\\Result\\Scene.cs";
        string designerDir = "Assets\\Scripts\\Result\\Scene.Designer.cs";
        CodeGenerator.CreateCustomScene(mainDir, designerDir);//,"Phoenix");
    }

    [MenuItem("Tools/CodeGenTest/Test")]
    static void Test()
    {
        new NewScene();//phoenix();
    }

    [MenuItem("Tools/StringStuff/Test")]
    static void Test1()
    {
        string temp = "geijfoiej fjeoifjeofij oifjeo ijfeoi jfeoijf oiefj oiejfoiejfeoi";
        EditorUtility.DisplayDialog("temp",string.Format("Text: {0}; Lower: {1}; Upper: {2};", temp, temp.ToLowerCamelCase(), temp.ToUpperCamelCase()),"K");
    }
}

#endif