using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class CodeGenerator
{
    public static void CreateCustomScene(string mainFileDir, string designerFileDir, string sceneName)
    {
        Scene currentScene = SceneManager.GetActiveScene();
        GameObject[] rootObjects = currentScene.GetRootGameObjects();
        string name = sceneName;
        string mainFileText = GenerateClassMainFile(name.NormaliseString());
        IndentedStringBuilder isbVariables = new IndentedStringBuilder();
        isbVariables.Indents = 1;
        isbVariables.AppendLine("Scene scene;");
        IndentedStringBuilder isbFunctions = new IndentedStringBuilder();
        isbFunctions.Indents = 1;
        IndentedStringBuilder isbDesigner = new IndentedStringBuilder();
        isbDesigner.AppendLine("using UnityEngine;");
        isbDesigner.AppendLine("using UnityEngine.SceneManagement;");
        isbDesigner.AppendLine("using UnityEditor;");
        isbDesigner.AppendLine("using UnityEditor.SceneManagement;");
        isbDesigner.AppendLineFormat("partial class {0}", name.NormaliseString());
        isbDesigner.AppendLine("{");
        isbDesigner.Indents++;
        isbDesigner.AppendLine("#region GeneratedCode");
        isbDesigner.AppendLine("private void InitialiseComponent()");
        isbDesigner.AppendLine("{");
        isbDesigner.Indents++;
        isbDesigner.AppendLine("if (EditorApplication.isPlaying)");
        isbDesigner.AppendLine("{");
        isbDesigner.Indents++;
        isbDesigner.AppendLineFormat("scene = SceneManager.CreateScene(\"{0}\");", name);
        isbDesigner.Indents--;
        isbDesigner.AppendLine("}");
        isbDesigner.AppendLine("else");
        isbDesigner.AppendLine("{");
        isbDesigner.Indents++;
        isbDesigner.AppendLine("scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene);");
        isbDesigner.AppendLineFormat("scene.name = \"{0}\";", name);
        isbDesigner.Indents--;
        isbDesigner.AppendLine("}");
        isbDesigner.AppendLine("SceneManager.SetActiveScene(scene);");
        foreach (GameObject gameObject in rootObjects)
        {
            string function;
            string functionCall;
            GenerateGameObjectFunction(gameObject, out function, out functionCall);
            isbDesigner.AppendLine(functionCall);
            isbVariables.AppendLineFormat("GameObject {0};", gameObject.name.NormaliseString());
            isbFunctions.Append(function,false);
        }
        isbDesigner.Indents--;
        isbDesigner.AppendLine("}");
        isbDesigner.Append(isbFunctions.ToString(),false);
        isbDesigner.AppendLine("#endregion");
        isbDesigner.Append(isbVariables.ToString(),false);
        isbDesigner.Indents--;
        isbDesigner.AppendLine("}");
        File.WriteAllText(mainFileDir, mainFileText);
        File.WriteAllText(designerFileDir, isbDesigner.ToString());
    }
    static void GenerateGameObjectFunction(GameObject gameObject,out string function,out string functionCall)
    {
        IndentedStringBuilder isbFunction = new IndentedStringBuilder();
        isbFunction.Indents = 1;
        string name = gameObject.name.NormaliseString();
        string functionName = string.Format("{0}_Init",name);

        isbFunction.AppendLineFormat("private GameObject {0}()", functionName);
        isbFunction.AppendLine("{");
        isbFunction.Indents++;

        isbFunction.AppendLineFormat("GameObject {0} = new GameObject();",name);
        isbFunction.AppendLineFormat("{0}.name = \"{1}\";",name, gameObject.name);
       
        SerialiseChildObjects(gameObject, ref isbFunction);

        isbFunction.AppendLineFormat("return {0};",name);
        isbFunction.Indents--;
        isbFunction.AppendLine("}");

        function = isbFunction.ToString();
        functionCall = string.Format("{0} = {1}();", name, functionName);
    }
    static string NormaliseString(this string text)
    {
        return text.Replace(' ', '_').Replace('(','_').Replace(")","").ToLower();
    }
    static void SerialiseChildObjects(GameObject gameObject, ref IndentedStringBuilder isb)
    {
        AppendGameObject(gameObject, ref isb);

        if (gameObject.transform.childCount > 0)
        {
            isb.AppendLine("{");
            isb.Indents++;

            string gameObjectName = gameObject.name.NormaliseString();
            foreach (Transform child in gameObject.transform)
            {
                string name = child.name;
                string normName = name.NormaliseString();
                isb.AppendLineFormat("GameObject {0} = new GameObject();", normName);
                isb.AppendLineFormat("{0}.name = \"{1}\";", normName, name);
                isb.AppendLineFormat("{0}.tag = \"{1}\";", normName, child.tag);
                isb.AppendLineFormat("{0}.transform.parent = {1}.transform;", normName, gameObjectName);
                SerialiseChildObjects(child.gameObject, ref isb);
            }

            isb.Indents--;
            isb.AppendLine("}");
        }
    }
    public static void CreateCustomGameObject(GameObject gameObject, out string mainFile, out string designerFile)
    {
        Dictionary<Type, int> componentTypeCounts = new Dictionary<Type, int>();
        string name = gameObject.name;
        mainFile = GenerateClassMainFile(name);
        IndentedStringBuilder isbDesigner = new IndentedStringBuilder();
        isbDesigner.AppendLineFormat("partial class {0}", name);
        isbDesigner.AppendLine("{");
        isbDesigner.Indents++;
        isbDesigner.AppendLine("#region GeneratedCode");
        isbDesigner.AppendLine("private void InitialiseComponent()");
        isbDesigner.AppendLine("{");
        isbDesigner.Indents++;

        isbDesigner.AppendLine("gameObject = new GameObject();");
        IndentedStringBuilder isbVariables = new IndentedStringBuilder();
        isbVariables.Indents = 1;
        Component[] components = gameObject.GetComponents<Component>();
        foreach(Component c in components)
        {
            Type t = c.GetType();
            if (t != typeof(Transform))
            {
                string tName = t.ToString();
                int dotIndex = tName.LastIndexOf('.');
                if (dotIndex > -1)
                {
                    tName = tName.Substring(dotIndex + 1, tName.Length - (dotIndex + 1));
                }
                int comCount = 0;
                if (componentTypeCounts.ContainsKey(t))
                {
                    comCount = ++componentTypeCounts[t];
                }
                else
                {
                    componentTypeCounts.Add(t, comCount);
                }
                string cname = string.Format("{0}_{1}_{2}", name, tName, comCount);
                isbDesigner.AppendLineFormat("{0} = gameObject.AddComponent<{1}>();", cname, t);
                PropertyInfo[] properties = t.GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (PropertyInfo p in properties)
                {
                    try
                    {
                        isbDesigner.AppendLineFormat("/*{0}.{1} = {2}*/", cname, p.Name, p.GetValue(c));
                    }
                    catch { }
                }
                isbVariables.AppendLineFormat("{0} {1};", t, cname);
            }
        }

        isbDesigner.Indents--;
        isbDesigner.AppendLine("}");
        isbDesigner.AppendLine("#endregion");
        isbDesigner.AppendLine("UnityEngine.GameObject gameObject;");
        isbDesigner.Append(isbVariables.ToString());
        isbDesigner.Indents--;
        isbDesigner.AppendLine("}");
        designerFile = isbDesigner.ToString();
    }
    public static void AppendGameObject(GameObject gameObject, ref IndentedStringBuilder isb)
    {
        string name = gameObject.name.NormaliseString();
        //isb.AppendLineFormat("{0} = new GameObject();", name);
        Dictionary<Type, int> componentTypeCounts = new Dictionary<Type, int>();
        foreach(Component c in gameObject.GetComponents<Component>())
        {
            Type t = c.GetType();
            string tName = t.ToString();
            int dotIndex = tName.LastIndexOf('.');
            if (dotIndex > -1)
            {
                tName = tName.Substring(dotIndex+1, tName.Length - (dotIndex+1));
            }
            int comCount = 0;
            if (componentTypeCounts.ContainsKey(t))
            {
                comCount = ++componentTypeCounts[t];
            }
            else
            {
                componentTypeCounts.Add(t, comCount);
            }
            string cname = string.Format("{0}_{1}_{2}", name, tName.NormaliseString(), comCount);
            isb.AppendLineFormat("{0} {1} = {2}.AddComponent<{0}>();", t, cname, name);
        }

    }
    static string GenerateClassMainFile(string name)
    {
        IndentedStringBuilder isbMain = new IndentedStringBuilder();
        isbMain.AppendLineFormat("using UnityEngine;");
        isbMain.AppendLineFormat("using System.Collections;");
        isbMain.AppendLineFormat("public partial class {0}", name);
        isbMain.AppendLine("{");
        isbMain.Indents++;
        isbMain.AppendLineFormat("public {0}()", name);
        isbMain.AppendLine("{");
        isbMain.Indents++;
        isbMain.AppendLineFormat("InitialiseComponent();");
        isbMain.Indents--;
        isbMain.AppendLine("}");
        isbMain.Indents--;
        isbMain.AppendLine("}");
        return isbMain.ToString();
    }
    
}

