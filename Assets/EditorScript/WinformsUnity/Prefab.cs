using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UObject = UnityEngine.Object;

namespace WinformsUnity
{
    public abstract class Prefab
    {
        public Prefab(string name)
        {
            gameObject = new GameObject(name);
            MapObjects();
            InitialiseGameObjects();
        }
        protected abstract void MapObjects();
        protected abstract void InitialiseGameObjects();
        protected GameObject GetGameObject()
        {
            return gameObject;
        }
        protected UObject GetObject(int id)
        {
            return unityObjectMap[id];
        }
        protected void SetObject(int id, UObject obj)
        {
            if (unityObjectMap.ContainsKey(id))
            {
                unityObjectMap[id] = obj;
            }
            else
            {
                unityObjectMap.Add(id, obj);
            }
        }

        GameObject gameObject;
        Dictionary<int, UObject> unityObjectMap = new Dictionary<int, UObject>();
    }
}