using System;
using System.Collections;
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
        IndentedStringBuilder isbFunctions = new IndentedStringBuilder();
        isbFunctions.Indents = 1;
        IndentedStringBuilder isbFunctionCalls = new IndentedStringBuilder();
        isbFunctionCalls.Indents = 2;
        WriterUtil util = new WriterUtil();
        foreach (GameObject gameObject in rootObjects)
        {
            string function;
            string functionCall;
            GenerateGameObjectFunction(gameObject,util, out function, out functionCall);
            isbFunctionCalls.AppendLine(functionCall);
            isbVariables.AppendLineFormat("GameObject {0};", gameObject.name.NormaliseString());
            isbFunctions.Append(function,false);
        }
        string designerText = string.Format(FileFormats.designerClassFileFormat, name.NormaliseString(), isbFunctionCalls.ToString(), isbFunctions.ToString(), isbVariables.ToString());
        File.WriteAllText(mainFileDir, mainFileText);
        File.WriteAllText(designerFileDir, designerText);//isbDesigner.ToString());
    }
    static void GenerateGameObjectFunction(GameObject gameObject,WriterUtil util, out string function,out string functionCall)
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
        isbFunction.AppendLineFormat("{0}.tag = \"{1}\";", name, gameObject.tag);
       
        SerialiseChildObjects(gameObject,util, ref isbFunction);

        isbFunction.AppendLineFormat("return {0};",name);
        isbFunction.Indents--;
        isbFunction.AppendLine("}");

        function = isbFunction.ToString();
        functionCall = string.Format("{0} = {1}();", name, functionName);
    }
    public static string NormaliseString(this string text)
    {
        return text.Replace('(', '_').Replace(')', '_').ToLowerCamelCase();
        //return text.Replace(' ', '_').Replace('(','_').Replace(")","").ToLower();
    }

    public static string ToUpperCamelCase(this string text)
    {
        string[] words = text.Replace('\n', ' ').Replace('\t', ' ').Split(' ');
        StringBuilder sb = new StringBuilder();
        foreach (string word in words)
        {
            char[] wordChars = word.ToLower().ToCharArray();
            wordChars[0] = wordChars[0].ToUpper();
            sb.Append(wordChars.CompileString());
        }
        return sb.ToString();
    }

    static string CompileString(this char[] charArr)
    {
        return new string(charArr);
        //StringBuilder sb = new StringBuilder();
        //foreach(char c in charArr)
        //{
        //    sb.Append(c);
        //}
        //return sb.ToString();
    }

    public static string ToLowerCamelCase(this string text)
    {
        string upperCamelCase = text.ToUpperCamelCase();
        char[] chars = upperCamelCase.ToCharArray();
        chars[0] = chars[0].ToLower();
        return chars.CompileString();
    }

    static char ToLower(this char c)
    {
        return c.ToString().ToLower()[0];
    }

    static char ToUpper(this char c)
    {
        return c.ToString().ToUpper()[0];
    }

    static void SerialiseChildObjects(GameObject gameObject, WriterUtil util, ref IndentedStringBuilder isb)
    {
        AppendGameObject(gameObject,util, ref isb);

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
                SerialiseChildObjects(child.gameObject,util, ref isb);
            }

            isb.Indents--;
            isb.AppendLine("}");
        }
    }
    public static void AppendGameObject(GameObject gameObject, WriterUtil util, ref IndentedStringBuilder isb)
    {
        string name = gameObject.name.NormaliseString();
        //isb.AppendLineFormat("{0} = new GameObject();", name);
        //Dictionary<Type, int> componentTypeCounts = new Dictionary<Type, int>();
        util.ResetComponentTypeCounts();
        foreach(Component c in gameObject.GetComponents<Component>())
        {
            Type t = c.GetType();
            if (t != typeof(Transform))
            {
                string tName = GetTypeName(t);
                int comCount = util.GetTypeCount(t);
                string cname = string.Format("{0}_{1}_{2}", name, tName.NormaliseString(), comCount);
                isb.AppendLineFormat("{0} {1} = {2}.AddComponent<{0}>();", t, cname, name);
                MemberInfo[] members = t.GetMembers();
                isb.AppendLine("/*");
                foreach(MemberInfo member in members)
                {
                    if (member.IgnoreMember())
                    {
                        Debug.LogFormat("{0} is ignored.", member.Name);
                        continue;
                    }
                    try
                    {
                        object value = null;
                        if (member.MemberType == MemberTypes.Field)
                        {
                            FieldInfo fieldInfo = (FieldInfo)member;
                            value = fieldInfo.GetValue(c);
                        }
                        else
                        {
                            PropertyInfo propertyInfo = (PropertyInfo)member;
                            value = propertyInfo.GetValue(c);
                        }
                        if (value != null)
                        {
                            isb.AppendLineFormat("{0}.{1} = {2};", cname, member.Name, value.GetValueString(util));
                        }
                    }
                    catch (Exception err)
                    {
                        Debug.LogFormat("ERROR:\n{0};",err);
                    }
                }
                isb.AppendLine("*/");
            }
        }

    }
    static string GetTypeName(Type t)
    {
        string tName = t.ToString();
        int dotIndex = tName.LastIndexOf('.');
        if (dotIndex > -1)
        {
            tName = tName.Substring(dotIndex + 1, tName.Length - (dotIndex + 1));
        }
        return tName;
    }
    static bool IgnoreMember(this MemberInfo member)
    {
        if (member.MemberType != MemberTypes.Field && member.MemberType != MemberTypes.Property)
        {
            return true;
        }
        bool isGameObject = member.Name == "gameObject";
        bool isTransform = isGameObject || member.Name == "transform";
        bool isObsolete = isTransform || member.GetCustomAttributes(typeof(ObsoleteAttribute)).Count() > 0;
        if (isObsolete)
        {
            return true;
        }
        if (member.MemberType == MemberTypes.Field)
        {
            FieldInfo fieldInfo = (FieldInfo)member;
            return fieldInfo.IsInitOnly || fieldInfo.IsStatic;
        }
        PropertyInfo propertyInfo = (PropertyInfo)member;
        return (!propertyInfo.CanWrite) || propertyInfo.GetAccessors().Any(x => x.IsStatic);
    }
    static string GetComponentName(Component c, WriterUtil util)
    {
        int instanceID = c.GetInstanceID();
        string n;
        if (util.ComponentNameStored(instanceID,out n))
        {
            return n;
        }
        else
        {
            Type t = c.GetType();
            string gName = c.gameObject.name.NormaliseString();
            string tName = GetTypeName(t).NormaliseString();
       
            Component[] components = c.gameObject.GetComponents(t);
            for(int i = 0; i < components.Length; i++)
            {
                Component component = components[i];
                if (component == c)
                {
                    string cname = string.Format("{0}_{1}_{2}", gName, tName.NormaliseString(), i);
                    util.AddComponentName(instanceID, cname);
                    return cname;
                }
            }
        }
        return "e";
    }
    static string GetValueString(this object value,WriterUtil util)
    {
        if (value is string)
        {
            return string.Format("\"{0}\"", value);
        }
        if (value is bool)
        {
            return value.ToString().ToLower();
        }
        if (value is float)
        {
            return value + "f";
        }
        if (value is Vector2)
        {
            Vector2 vec2 = (Vector2)value;
            return string.Format("new Vector2({0},{1})", vec2.x.GetValueString(util), vec2.y.GetValueString(util));
        }
        if (value is Vector3)
        {
            Vector3 vec3 = (Vector3)value;
            return string.Format("new Vector3({0},{1},{2})", vec3.x.GetValueString(util), vec3.y.GetValueString(util),vec3.z.GetValueString(util));
        }
        if (value is Vector4)
        {
            Vector4 vec4 = (Vector4)value;
            return string.Format("new Vector4({0},{1},{2},{3})", vec4.x.GetValueString(util), vec4.y.GetValueString(util), vec4.z.GetValueString(util),vec4.w.GetValueString(util));
        }
        Type type = value.GetType();
        if (type.IsEnum)
        {
            return string.Format("{0}.{1}", type, value);
        }
        if (type.IsClass)
        {
            if (value is Component)
            {
                return GetComponentName(value as Component, util);
            }
        }
        if (type.IsArray)
        {
            Type elementType = type.GetElementType();
            Array arr = (Array)value;
            IndentedStringBuilder isbElements = new IndentedStringBuilder();
            for(int i = 0; i < arr.Length; i++)
            {
                isbElements.AppendFormat("{0}{1}", arr.GetValue(i).GetValueString(util), i < arr.Length - 1 ? ", " : "");
            }
            return string.Format("new {0}[] {{ {1} }}", elementType, isbElements.ToString());
        }
        return value.ToString();
    }
    static string GenerateClassMainFile(string name)
    {
        //IndentedStringBuilder isbMain = new IndentedStringBuilder();
        //isbMain.AppendLineFormat("using UnityEngine;");
        //isbMain.AppendLineFormat("using System.Collections;");
        //isbMain.BreakLine();
        //isbMain.AppendLineFormat("public partial class {0}", name);
        //isbMain.AppendLine("{");
        //isbMain.Indents++;
        //isbMain.AppendLineFormat("public {0}()", name);
        //isbMain.AppendLine("{");
        //isbMain.Indents++;
        //isbMain.AppendLineFormat("InitialiseComponent();");
        //isbMain.Indents--;
        //isbMain.AppendLine("}");
        //isbMain.Indents--;
        //isbMain.AppendLine("}");
        //return isbMain.ToString();
        return string.Format(FileFormats.mainClassFileFormat, name);
    }
    
}

public class WriterUtil
{
    Dictionary<int, string> componentNames = new Dictionary<int, string>();
    Dictionary<Type, int> componentTypeCounts = new Dictionary<Type, int>();
    public void AddComponentName(int id, string name)
    {
        if (!componentNames.ContainsKey(id))
        {
            componentNames.Add(id,name);
        }
        else
        {
            componentNames[id] = name;
            Debug.LogFormat("InstanceID \"{0}\" name reset.", id);
        }
    }
    public bool ComponentNameStored(int id, out string name)
    {
        if (componentNames.ContainsKey(id))
        {
            name = componentNames[id];
            return true;
        }
        name = "[name not found]";
        return false;
    }
    public int GetTypeCount(Type t,bool increment = true)
    {
        if (componentTypeCounts.ContainsKey(t))
        {
            return increment ? ++componentTypeCounts[t] : componentTypeCounts[t];
        }
        componentTypeCounts.Add(t, 0);
        return 0;
    }
    public void ResetComponentTypeCounts()
    {
        componentTypeCounts.Clear();
    }
}