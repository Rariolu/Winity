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
using UObject = UnityEngine.Object;

public static class CodeGenerator
{
    public static void CreateCustomScene(string mainFileDir, string designerFileDir)
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string name = currentScene.name;
        GameObject[] rootObjects = currentScene.GetRootGameObjects();
        //string name = sceneName;
        string mainFileText = string.Format(TextFormats.mainClassFileFormat, name.NormaliseString(false),name);

        IndentedStringBuilder isbVariables = new IndentedStringBuilder();
        isbVariables.Indents = 1;

        IndentedStringBuilder isbFunctions = new IndentedStringBuilder();
        isbFunctions.Indents = 1;

        IndentedStringBuilder isbFunctionCalls = new IndentedStringBuilder();
        isbFunctionCalls.Indents = 2;

        WriterUtil util = new WriterUtil();

        IndentedStringBuilder isbObjectMap = new IndentedStringBuilder();
        isbObjectMap.Indents = 2;
        
        foreach(GameObject gameObject in rootObjects)
        {
            AppendGameObjectsToMap(gameObject, isbObjectMap);
        }

        foreach (GameObject gameObject in rootObjects)
        {
            string function;
            string functionCall;
            GenerateGameObjectFunction(gameObject,util, out function, out functionCall);
            isbFunctionCalls.AppendLine(functionCall);
            isbVariables.AppendLineFormat("GameObject {0};", gameObject.name.NormaliseString());
            isbFunctions.Append(function,false);
        }
        string designerText = string.Format(TextFormats.designerClassFileFormat, name.NormaliseString(false), isbObjectMap.ToString(), isbFunctionCalls.ToString(), isbFunctions.ToString(), isbVariables.ToString());
        File.WriteAllText(mainFileDir, mainFileText);
        File.WriteAllText(designerFileDir, designerText);
    }

    static void AppendGameObjectsToMap(GameObject gameObject, IndentedStringBuilder isbObjectMap)
    {
        int instID = gameObject.GetInstanceID();
        string normInst = instID.Normalise();

        isbObjectMap.AppendLineFormat("//{0}", gameObject.name);
        isbObjectMap.AppendLineFormat("GameObject gameObject{0} = new GameObject();", normInst);
        isbObjectMap.AppendLineFormat("SetObject({0}, gameObject{1});", instID, normInst);

        int transformInst = gameObject.transform.GetInstanceID();
        string normTranInst = transformInst.Normalise();

        isbObjectMap.AppendLineFormat("Transform transform{0} = gameObject{1}.transform;", normTranInst, normInst);
        isbObjectMap.AppendLineFormat("SetObject({0},transform{1});", transformInst,normTranInst);

        Component[] components = gameObject.GetComponents<Component>();
        foreach(Component component in components)
        {
            if (!(component is Transform))
            {
                int comInst = component.GetInstanceID();
                string comInstNorm = comInst.Normalise();
                Type cType = component.GetType();
                isbObjectMap.AppendLineFormat("{0} component{1} = gameObject{2}.AddComponent<{0}>();", cType.ToString(), comInstNorm, normInst);
                isbObjectMap.AppendLineFormat("SetObject({0},component{1});", comInst ,comInstNorm);
            }
        }

        isbObjectMap.AppendLine("");

        foreach(Transform child in gameObject.transform)
        {
            AppendGameObjectsToMap(child.gameObject, isbObjectMap);
        }
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

        isbFunction.AppendLineFormat("GameObject {0} = (GetObject({1}) as GameObject);", name, gameObject.GetInstanceID());
        //isbFunction.AppendLineFormat("GameObject {0} = new GameObject();",name);
        isbFunction.AppendLineFormat("{0}.name = \"{1}\";",name, gameObject.name);
        isbFunction.AppendLineFormat("{0}.tag = \"{1}\";", name, gameObject.tag);
       
        SerialiseChildObjects(gameObject,util, ref isbFunction);

        //isbFunction.AppendLineFormat("unityObjectMap[{0}] = {1};", gameObject.GetInstanceID(), name);

        isbFunction.AppendLineFormat("return {0};",name);
        isbFunction.Indents--;
        isbFunction.AppendLine("}");

        function = isbFunction.ToString();
        functionCall = string.Format("{0} = {1}();", name, functionName);
    }


    static void SerialiseChildObjects(GameObject gameObject, WriterUtil util, ref IndentedStringBuilder isb)
    {
        AppendGameObjectComponents(gameObject,util, ref isb);

        if (gameObject.transform.childCount > 0)
        {
            isb.AppendLine("{");
            isb.Indents++;

            string gameObjectName = gameObject.name.NormaliseString();
            foreach (Transform child in gameObject.transform)
            {
                GameObject childObject = child.gameObject;
                string name = child.name;
                string normName = name.NormaliseString();
                isb.AppendLineFormat("GameObject {0} = (GetObject({1}) as GameObject);", normName, childObject.GetInstanceID());
                //isb.AppendLineFormat("GameObject {0} = new GameObject();", normName);
                isb.AppendLineFormat("{0}.name = \"{1}\";", normName, name);
                isb.AppendLineFormat("{0}.tag = \"{1}\";", normName, child.tag);
                //isb.AppendLineFormat("{0}.transform.parent = {1}.transform;", normName, gameObjectName);
                SerialiseChildObjects(childObject,util, ref isb);
                //isb.AppendLineFormat("unityObjectMap[{0}] = {1};", gameObject.GetInstanceID(), normName);
            }

            isb.Indents--;
            isb.AppendLine("}");
        }
    }
    public static void AppendGameObjectComponents(GameObject gameObject, WriterUtil util, ref IndentedStringBuilder isb)
    {
        string name = gameObject.name.NormaliseString();
        //isb.AppendLineFormat("{0} = new GameObject();", name);
        //Dictionary<Type, int> componentTypeCounts = new Dictionary<Type, int>();
        util.ResetComponentTypeCounts();
        foreach(Component c in gameObject.GetComponents<Component>())
        {
            Type t = c.GetType();
            //if (t != typeof(Transform))
            //{
               
            //    //isb.AppendLine("*/");
            //}
            string tName = Util.GetTypeName(t);
            int comCount = util.GetTypeCount(t);
            string cname = string.Format("{0}_{1}_{2}", name, tName.NormaliseString(), comCount);
            //isb.AppendLineFormat("{0} {1} = {2}.GetComponent<{0}>();", t, cname, name);
            isb.AppendLineFormat("{0} {1} = (GetObject({2}) as {0});", t, cname, c.GetInstanceID());
            MemberInfo[] members = t.GetMembers();
            //isb.AppendLine("/*");
            foreach (MemberInfo member in members)
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
                    else
                    {
                        isb.AppendLineFormat("{0}.{1} = null;", cname, member.Name);
                    }
                }
                catch (Exception err)
                {
                    Debug.LogFormat("ERROR:\n{0};", err);
                }
            }
            //isb.AppendLineFormat("unityObjectMap[{0}] = {1};", c.GetInstanceID(), cname);
        }

    }

    static bool IgnoreMember(this MemberInfo member)
    {
        if (member.MemberType != MemberTypes.Field && member.MemberType != MemberTypes.Property)
        {
            return true;
        }
        bool isGameObject = member.Name == "gameObject";
        bool isTransform = isGameObject || member.Name == "transform";
        bool isName = isTransform || member.Name == "name";
        bool isObsolete = isName || member.GetCustomAttributes(typeof(ObsoleteAttribute)).Count() > 0;
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
    static string GetValueString(this object value,WriterUtil util)
    {
        if (value is long || value is int || value is short)
        {
            return value.ToString();
        }
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
        if (value is Matrix4x4)
        {
            Matrix4x4 mat = (Matrix4x4)value;

            return string.Format("new Matrix4x4({0},{1},{2},{3})", mat.GetColumn(0).GetValueString(util), mat.GetColumn(1).GetValueString(util), mat.GetColumn(2).GetValueString(util), mat.GetColumn(3).GetValueString(util));
        }
        if (value is Rect)
        {
            Rect rect = (Rect)value;

            return string.Format("new Rect({0},{1},{2},{3})", rect.x.GetValueString(util), rect.y.GetValueString(util), rect.width.GetValueString(util), rect.height.GetValueString(util));
        }
        if (value is Quaternion)
        {
            Quaternion quat = (Quaternion)value;
            return string.Format("new Quaternion({0},{1},{2},{3})",quat.x.GetValueString(util),quat.y.GetValueString(util),quat.z.GetValueString(util),quat.w.GetValueString(util));
        }
        if (value is Scene)
        {
            return "GetScene()";
        }
        if (value is Color)
        {
            Color colour = (Color)value;

            return string.Format("new Color({0},{1},{2},{3})", colour.r.GetValueString(util), colour.g.GetValueString(util), colour.b.GetValueString(util), colour.a.GetValueString(util));
        }
        Type type = value.GetType();
        if (type.IsEnum)
        {
            return string.Format("{0}.{1}", type.ToString().Replace('+','.'), value);
        }
        if (value is UObject)
        {
            Debug.Log("fjriofjroijf");
            UObject obj = value as UObject;
            return string.Format("(GetObject({0}) as {1})", obj.GetInstanceID(), type.ToString());
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
        return string.Format("default({0})", type);
        //return value.ToString();
    }
}

public class WriterUtil
{
    Dictionary<Type, int> componentTypeCounts = new Dictionary<Type, int>();
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