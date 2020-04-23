using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

/// <summary>
/// A script which loads given resources into the "ResourceManager".
/// </summary>
public class ResourceLoader : MonoBehaviour
{
    public List<FontRescItem> fonts;
    public List<GameObjectRescItem> gameobjects;
    public List<MaterialRescItem> materials;
    public List<MeshRescItem> meshes;
    public List<SpriteRescItem> sprites;
    public List<TextureRescItem> textures;
    private void Awake()
    {
        ResourceManager.AddItems(fonts);
        ResourceManager.AddItems(gameobjects);
        ResourceManager.AddItems(materials);
        ResourceManager.AddItems(meshes);
        ResourceManager.AddItems(sprites);
        ResourceManager.AddItems(textures);
    }
}