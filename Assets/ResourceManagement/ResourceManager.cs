using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

/// <summary>
/// Class to manage ubiquitous use of resources (e.g. Textures, Meshes, etc.).
/// </summary>
public static class ResourceManager
{
    /// <summary>
    /// A dictionary which stores all resources, using a combination of
    /// their designated name and value type as a key.
    /// </summary>
    static Dictionary<RescItemKey, object> items = new Dictionary<RescItemKey, object>();
    
    /// <summary>
    /// Store a given value if the given key isn't already used
    /// for a value of that type.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="item"></param>
    public static void AddItem<T>(RescItem<T> item)
    {
        RescItemKey rescItemKey = new RescItemKey(item.Name.NormaliseString(), typeof(T));
        if (!items.ContainsKey(rescItemKey))
        {
            items.Add(rescItemKey, item.Item);
        }
    }
    
    /// <summary>
    /// Iterate through a collection of items and call
    /// "AddItem" on each.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="items"></param>
    public static void AddItems<T>(IEnumerable<RescItem<T>> items)
    {
        foreach(RescItem<T> item in items)
        {
            AddItem(item);
        }
    }

    /// <summary>
    /// A method which returns true if a resource of the
    /// given type and name is stored and outputs said
    /// resource.
    /// </summary>
    /// <typeparam name="T">The type of the requested resource.</typeparam>
    /// <param name="objKey">The name of the requested resource.</param>
    /// <param name="item">The outputted resource (if it is found).</param>
    /// <returns></returns>
    public static bool GetItem<T>(object objKey, out T item)
    {
        return GetItem(objKey.ToString(), out item);
    }

    /// <summary>
    /// A method which returns true if a resource of the
    /// given type and name is stored and outputs said
    /// resource.
    /// </summary>
    /// <typeparam name="T">The type of the requested resource.</typeparam>
    /// <param name="key">The name of the requested resource.</param>
    /// <param name="item">The outputted resource (if it is found).</param>
    /// <returns></returns>
    public static bool GetItem<T>(string key, out T item)
    {
        Type type = typeof(T);
        RescItemKey rescItemKey = new RescItemKey(key.NormaliseString(), type);
        if (items.ContainsKey(rescItemKey))
        {
            item = (T)(items[rescItemKey]);
            return true;
        }
        item = default(T);
        return false;
    }
}