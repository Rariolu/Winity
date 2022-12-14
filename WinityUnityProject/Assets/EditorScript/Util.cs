using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public enum Casing
{
    lowerCamelCase,
    UpperCamelCase
}

public static class Util
{
    public static bool IsPrefab(this GameObject gameObject)
    {
        return gameObject.scene.rootCount == 0;
    }

    public static string Normalise(this object obj)
    {
        return obj.ToString().NormaliseString();
    }

    public static string NormaliseString(this string text,Casing casing = Casing.lowerCamelCase)// bool lowerCamel = true)
    {
        string replacedChars = text.Replace('(', '_').Replace(')', '_').Replace('-', '_').Replace('.', '_');
        return casing == Casing.lowerCamelCase ? replacedChars.ToLowerCamelCase() : replacedChars.ToUpperCamelCase();
    }

    public static string ToUpperCamelCase(this string text)
    {
        string[] words = text.Replace('\n', ' ').Replace('\t', ' ').Split(' ');
        StringBuilder sb = new StringBuilder();
        foreach (string word in words)
        {
            char[] wordChars = word.ToLower().ToCharArray();
            if (wordChars.Length > 0)
            {
                wordChars[0] = wordChars[0].ToUpper();
                sb.Append(new string(wordChars));
            }
        }
        return sb.ToString();
    }

    public static string ToLowerCamelCase(this string text)
    {
        string upperCamelCase = text.ToUpperCamelCase();
        char[] chars = upperCamelCase.ToCharArray();
        chars[0] = chars[0].ToLower();
        return new string(chars);
    }

    public static char ToLower(this char c)
    {
        return c.ToString().ToLower()[0];
    }

    static char ToUpper(this char c)
    {
        return c.ToString().ToUpper()[0];
    }
    public static string GetTypeName(Type t)
    {
        string tName = t.ToString();
        int dotIndex = tName.LastIndexOf('.');
        if (dotIndex > -1)
        {
            tName = tName.Substring(dotIndex + 1, tName.Length - (dotIndex + 1));
        }
        return tName;
    }
}