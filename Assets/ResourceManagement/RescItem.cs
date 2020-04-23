using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

/// <summary>
/// A class which specifies a particular resource
/// and gives it a designated name.
/// </summary>
/// <typeparam name="T"></typeparam>
[Serializable]
public class RescItem<T>
{
    [SerializeField]
    public string Name;
    [SerializeField]
    public T Item;

    public RescItem()
    {

    }
    public RescItem(string name, T item)
    {
        Name = name;
        Item = item;
    }
}

[Serializable] public class FontRescItem : RescItem<Font> { }

[Serializable] public class GameObjectRescItem : RescItem<GameObject> { }

[Serializable] public class MaterialRescItem : RescItem<Material> { }

[Serializable] public class MeshRescItem : RescItem<Mesh> { }

[Serializable] public class SpriteRescItem : RescItem<Sprite> { }

[Serializable] public class TextureRescItem : RescItem<Texture2D> { }

/// <summary>
/// A struct used to identify specific instances of "RescItem"
/// inside the ResourceManager.
/// </summary>
struct RescItemKey
{
    string strKey;
    Type type;
    public RescItemKey(string key, Type t)
    {
        strKey = key;
        type = t;
    }
}