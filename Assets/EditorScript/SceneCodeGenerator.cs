using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UObject = UnityEngine.Object;

public static class SceneCodeGenerator
{
    public static void CreateCustomScene(string dir)
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string name = currentScene.name;
        string normName = name.NormaliseString(Casing.UpperCamelCase);
        GameObject[] rootObjects = currentScene.GetRootGameObjects();
        //string name = sceneName;
        string mainFileText = string.Format(TextFormats.mainSceneClassFileFormat, normName, name);

        IndentedStringBuilder isbVariables = new IndentedStringBuilder();
        isbVariables.Indents = 1;

        IndentedStringBuilder isbFunctions = new IndentedStringBuilder();
        isbFunctions.Indents = 1;

        IndentedStringBuilder isbFunctionCalls = new IndentedStringBuilder();
        isbFunctionCalls.Indents = 2;

        WriterUtil util = new WriterUtil();

        IndentedStringBuilder isbObjectMap = new IndentedStringBuilder();
        isbObjectMap.Indents = 2;

        foreach (GameObject gameObject in rootObjects)
        {
            CodeGenerator.AppendGameObjectsToMap(gameObject, isbObjectMap);
        }

        foreach (GameObject gameObject in rootObjects)
        {
            string function;
            string functionCall;
            CodeGenerator.GenerateGameObjectFunction(gameObject, util, out function, out functionCall);
            isbFunctionCalls.AppendLine(functionCall);
            isbVariables.AppendLineFormat("GameObject {0};", gameObject.name.NormaliseString());
            isbFunctions.Append(function, false);
        }
        CodeGenerator.DestroyTemp();
        string designerText = string.Format(TextFormats.designerSceneClassFileFormat, normName, isbObjectMap.ToString(), isbFunctionCalls.ToString(), isbFunctions.ToString(), isbVariables.ToString());

        string mainFileDir = string.Format("{0}\\{1}.cs", dir, normName);
        string designerFileDir = string.Format("{0}\\{1}.designer.cs", dir, normName);

        File.WriteAllText(mainFileDir, mainFileText);
        File.WriteAllText(designerFileDir, designerText);
    }
}