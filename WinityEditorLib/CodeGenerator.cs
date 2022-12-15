using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UObject = UnityEngine.Object;

namespace WinityEditorLib
{
    public static class CodeGenerator
    {
        public static void AppendGameObjectsToMap(GameObject gameObject, IndentedStringBuilder isbObjectMap)
        {
            int instID = gameObject.GetInstanceID();
            string normInst = instID.Normalise();

            isbObjectMap.AppendLineFormat("//{0}", gameObject.name);
            isbObjectMap.AppendLineFormat("GameObject gameObject{0} = new GameObject();", normInst);
            isbObjectMap.AppendLineFormat("SetObject({0}, gameObject{1});", instID, normInst);

            int transformInst = gameObject.transform.GetInstanceID();
            string normTranInst = transformInst.Normalise();

            isbObjectMap.AppendLineFormat("Transform transform{0} = gameObject{1}.transform;", normTranInst, normInst);
            isbObjectMap.AppendLineFormat("SetObject({0},transform{1});", transformInst, normTranInst);

            Component[] components = gameObject.GetComponents<Component>();
            foreach (Component component in components)
            {
                if (!(component is Transform))
                {
                    int comInst = component.GetInstanceID();
                    string comInstNorm = comInst.Normalise();
                    Type cType = component.GetType();
                    isbObjectMap.AppendLineFormat("{0} component{1} = gameObject{2}.AddComponent<{0}>();", cType.ToString(), comInstNorm, normInst);
                    isbObjectMap.AppendLineFormat("SetObject({0},component{1});", comInst, comInstNorm);
                }
            }

            isbObjectMap.AppendLine("");

            foreach (Transform child in gameObject.transform)
            {
                AppendGameObjectsToMap(child.gameObject, isbObjectMap);
            }
        }

        public static void GenerateGameObjectFunction(GameObject gameObject, WriterUtil util, out string function, out string functionCall)
        {
            IndentedStringBuilder isbFunction = new IndentedStringBuilder();
            isbFunction.Indents = 1;
            string name = gameObject.name.NormaliseString();
            string functionName = string.Format("{0}_Init", name);

            isbFunction.AppendLineFormat("private GameObject {0}()", functionName);
            isbFunction.AppendLine("{");
            isbFunction.Indents++;

            string gameObjectVariableName = string.Format("go{0}_{1}", name, gameObject.GetInstanceID().Normalise());

            isbFunction.AppendLineFormat("GameObject {0} = (GetObject({1}) as GameObject);", gameObjectVariableName, gameObject.GetInstanceID());
            isbFunction.AppendLineFormat("{0}.name = \"{1}\";", gameObjectVariableName, gameObject.name);
            isbFunction.AppendLineFormat("{0}.tag = \"{1}\";", gameObjectVariableName, gameObject.tag);

            SerialiseChildObjects(gameObject, ref isbFunction);

            isbFunction.AppendLineFormat("return {0};", gameObjectVariableName);
            isbFunction.Indents--;
            isbFunction.AppendLine("}");

            function = isbFunction.ToString();
            functionCall = string.Format("{0} = {1}();", name, functionName);
        }


        static void SerialiseChildObjects(GameObject gameObject, ref IndentedStringBuilder isb)
        {
            AppendGameObjectComponents(gameObject, ref isb);

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
                    string childObjectVariableName = string.Format("go{0}_{1}", normName, childObject.GetInstanceID().Normalise());
                    isb.AppendLineFormat("GameObject {0} = (GetObject({1}) as GameObject);", childObjectVariableName, childObject.GetInstanceID());
                    isb.AppendLineFormat("{0}.name = \"{1}\";", childObjectVariableName, name);
                    isb.AppendLineFormat("{0}.tag = \"{1}\";", childObjectVariableName, child.tag);
                    SerialiseChildObjects(childObject, ref isb);
                }

                isb.Indents--;
                isb.AppendLine("}");
            }
        }

        static Dictionary<Type, Component> defaultValues = new Dictionary<Type, Component>();
        static GameObject tempObject;
        static Component GetDefaultComponent(Type type)
        {
            if (defaultValues.ContainsKey(type))
            {
                return defaultValues[type];
            }
            if (type.IsSubclassOf(typeof(Component)))
            {
                GameObject gameObject = tempObject ?? (tempObject = new GameObject());
                Component component = type == typeof(Transform) ? gameObject.transform : gameObject.AddComponent(type);
                defaultValues.Add(type, component);
                return component;
            }
            return null;
        }

        public static void AppendGameObjectComponents(GameObject gameObject, ref IndentedStringBuilder isb)
        {
            WriterUtil util = new WriterUtil();

            string name = gameObject.name.NormaliseString();

            foreach (Component c in gameObject.GetComponents<Component>())
            {
                Type t = c.GetType();

                string tName = Util.GetTypeName(t);
                int comCount = util.GetTypeCount(t);
                string cname = string.Format("com{0}_{1}_{2}_{3}", name, tName.NormaliseString(), comCount, c.GetInstanceID().Normalise());

                isb.AppendLineFormat("{0} {1} = (GetObject({2}) as {0});", t, cname, c.GetInstanceID());

                MemberInfo[] members = t.GetMembers();
                foreach (MemberInfo member in members)
                {
                    //Skip this member if it is neither a property nor a field
                    if (member.MemberType != MemberTypes.Property && member.MemberType != MemberTypes.Field)
                    {
                        continue;
                    }


                    MemberWrapper memberWrapper = MemberWrapper.GenerateWrapper(member);

                    if (memberWrapper.IgnoreMember())
                    {
                        continue;
                    }
                    try
                    {
                        Type mt = memberWrapper.TypeOfMember;
                        if (mt.IsSubclassOf(typeof(UObject)))
                        {
                            Debug.LogFormat("{0} is UObject: {1}", member.Name, mt);
                            if (!mt.IsAssignableFrom(typeof(Component)))
                            {
                                Debug.LogFormat("{0} is not component.", member.Name);
                                if (mt != typeof(GameObject))
                                {
                                    Debug.LogFormat("{0} skipped.", member.Name);
                                    continue;
                                }
                            }
                        }

                        object value = memberWrapper.GetValue(c);

                        Component defaultMember = GetDefaultComponent(t);
                        object defaultValue = memberWrapper.GetValue(defaultMember);

                        bool eitherAreNull = value == null ^ defaultValue == null;
                        bool notEqual = value != defaultValue;
                        bool objNotEqual = value != null && !value.Equals(defaultValue);
                        if (eitherAreNull || objNotEqual)
                        {
                            if (value != null)
                            {
                                isb.AppendLineFormat("{0}.{1} = {2};", cname, member.Name, value.GetValueString());
                            }
                            else
                            {
                                isb.AppendLineFormat("{0}.{1} = null;", cname, member.Name);
                            }
                        }
                    }
                    catch (Exception err)
                    {
                        Debug.LogWarningFormat("ERROR type{0}:\n{1};\n\nStack Trace:\n{2}", err.GetType(), err, err.StackTrace);
                    }
                }
            }

        }

        static bool IgnoreMember(this MemberWrapper member)
        {
            try
            {
                return member.HasIgnoredName || member.IsObsolete || (!member.CanWrite) || member.HasStaticAccessor;
            }
            catch (Exception err)
            {
                Debug.LogWarningFormat("Err caught: {0}; {1}", err.GetType(), err.Message);
                return true;
            }
        }
        public static bool IsStruct(this Type source)
        {
            return source.IsValueType && !source.IsPrimitive && !source.IsEnum;
        }
        static string GetValueString(this object value)
        {
            if (value is long || value is int || value is short || value is uint || value is ulong || value is ushort || value is double)
            {
                return value.ToString();
            }
            if (value is string)
            {
                string v = value.ToString().Replace("\n", "\\n").Replace("\t", "\\t");
                return string.Format("\"{0}\"", v);
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
                return string.Format("new Vector2({0},{1})", vec2.x.GetValueString(), vec2.y.GetValueString());
            }
            if (value is Vector3)
            {
                Vector3 vec3 = (Vector3)value;
                return string.Format("new Vector3({0},{1},{2})", vec3.x.GetValueString(), vec3.y.GetValueString(), vec3.z.GetValueString());
            }
            if (value is Vector4)
            {
                Vector4 vec4 = (Vector4)value;
                return string.Format("new Vector4({0},{1},{2},{3})", vec4.x.GetValueString(), vec4.y.GetValueString(), vec4.z.GetValueString(), vec4.w.GetValueString());
            }
            if (value is Matrix4x4)
            {
                Matrix4x4 mat = (Matrix4x4)value;

                return string.Format("new Matrix4x4({0},{1},{2},{3})", mat.GetColumn(0).GetValueString(), mat.GetColumn(1).GetValueString(), mat.GetColumn(2).GetValueString(), mat.GetColumn(3).GetValueString());
            }
            if (value is Rect)
            {
                Rect rect = (Rect)value;
                return string.Format("new Rect({0},{1},{2},{3})", rect.x.GetValueString(), rect.y.GetValueString(), rect.width.GetValueString(), rect.height.GetValueString());
            }
            if (value is Quaternion)
            {
                Quaternion quat = (Quaternion)value;
                return string.Format("new Quaternion({0},{1},{2},{3})", quat.x.GetValueString(), quat.y.GetValueString(), quat.z.GetValueString(), quat.w.GetValueString());
            }
            if (value is Scene)
            {
                return "GetScene()";
            }
            if (value is Color)
            {
                Color colour = (Color)value;

                return string.Format("new Color({0},{1},{2},{3})", colour.r.GetValueString(), colour.g.GetValueString(), colour.b.GetValueString(), colour.a.GetValueString());
            }
            Type type = value.GetType();
            if (type.IsEnum)
            {
                return string.Format("{0}.{1}", type.ToString().Replace('+', '.'), value);
            }
            if (value is UObject)
            {
                UObject obj = value as UObject;
                if ((value is GameObject && !(value as GameObject).IsPrefab()) || value is Component)
                {
                    return string.Format("(GetObject({0}) as {1})", obj.GetInstanceID(), type.ToString());
                }
                else if (value is GameObject)
                {
                    Debug.LogFormat("{0} is prefab.", obj.name);

                }
            }
            if (type.IsArray)
            {
                Type elementType = type.GetElementType();
                Array arr = (Array)value;
                IndentedStringBuilder isbElements = new IndentedStringBuilder();
                for (int i = 0; i < arr.Length; i++)
                {
                    isbElements.AppendFormat("{0}{1}", arr.GetValue(i).GetValueString(), i < arr.Length - 1 ? ", " : "");
                }
                return string.Format("new {0}[] {{ {1} }}", elementType, isbElements.ToString());
            }
            if (type.IsStruct() || type.IsClass)
            {
                return StandardInitialisation(type, value);
            }
            if (value is Delegate || value is UnityEngine.Events.UnityEventBase)
            {
                return "null";
            }
            return string.Format("default({0})", type);
        }

        static string StandardInitialisation(Type type, object value)
        {
            IndentedStringBuilder sbStruct = new IndentedStringBuilder();
            sbStruct.Indents = 4;
            string name = "temp";
            sbStruct.AppendLineFormat("{0} {1} = new {0}();", type, name);
            MemberInfo[] members = type.GetMembers();
            foreach (MemberInfo member in members)
            {
                if (member.MemberType == MemberTypes.Field)
                {
                    FieldInfo fieldInfo = (FieldInfo)member;
                    if (!(fieldInfo.IsInitOnly || fieldInfo.IsStatic))
                    {
                        sbStruct.AppendLineFormat("{0}.{1} = {2};", name, member.Name, fieldInfo.GetValue(value).GetValueString());
                    }
                }
                else if (member.MemberType == MemberTypes.Property)
                {
                    PropertyInfo propertyInfo = (PropertyInfo)member;
                    if ((propertyInfo.CanWrite) && (!propertyInfo.GetAccessors().Any(x => x.IsStatic)))
                    {
                        sbStruct.AppendLineFormat("{0}.{1} = {2};", name, member.Name, propertyInfo.GetValue(value).GetValueString());
                    }
                }
            }
            sbStruct.AppendLineFormat("return {0};", name);

            IndentedStringBuilder sbStructFunc = new IndentedStringBuilder();
            sbStructFunc.AppendLineFormat("new System.Func<{0}> (() => {{", type);
            sbStructFunc.AppendLine(sbStruct.ToString());
            sbStructFunc.Indents = 3;
            sbStructFunc.Append("})()");
            return sbStructFunc.ToString();
        }

        public static void DestroyTemp()
        {
            UObject.DestroyImmediate(tempObject);
        }
    }
}