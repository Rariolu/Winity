using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class CodeGenerator
{
    public static void CreateCustomScene(string mainFileDir, string designerFileDir)
    {
        Scene currentScene = SceneManager.GetActiveScene();
        GameObject[] rootObjects = currentScene.GetRootGameObjects();
        string name = currentScene.name;
        string mainFileText = GenerateClassMainFile(name);
        IndentedStringBuilder isbDesigner = new IndentedStringBuilder();
        isbDesigner.AppendLineFormat("partial class {0}", name);
        isbDesigner.AppendLine("{");
        isbDesigner.Indents++;
        isbDesigner.AppendLine("#region GeneratedCode");
        isbDesigner.AppendLine("private void InitialiseComponent()");
        isbDesigner.AppendLine("{");
        isbDesigner.Indents++;
        
    }
    static void GenerateGameObjectFunction(GameObject gameObject,out string function,out string functionCall)
    {
        IndentedStringBuilder isbFunction = new IndentedStringBuilder();
        isbFunction.Indents = 1;
        string name = gameObject.name;
        string functionName = string.Format("{0}_Init",name);

        

        function = isbFunction.ToString();
        functionCall = string.Format("{0} = {1}();", name, functionName);
    }
    static void SerialiseChildObjects(GameObject gameObject)
    {
        
        foreach(Transform child in gameObject.transform)
        {

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
        string name = gameObject.name;
        isb.AppendLineFormat("{0} = new GameObject();", name);
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
            string cname = string.Format("{0}_{1}_{2}", name, tName, comCount);
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