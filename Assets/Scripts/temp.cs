using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEditor.SceneManagement;

public class temp : ScriptableObject
{

    [MenuItem("Tools/CodeGeneration/Scene")]
    static void CreateSceneFiles()
    {
        string mainDir = "Assets\\Scripts\\Result\\Scene.cs";
        string designerDir = "Assets\\Scripts\\Result\\Scene.Designer.cs";
        CodeGenerator.CreateCustomScene(mainDir, designerDir,"Phoenix");
    }

    [MenuItem("Tools/CodeGenTest/Test")]
    static void Test()
    {
        new phoenix();
    }
}