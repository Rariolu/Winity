using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEditor.SceneManagement;
using UObject = UnityEngine.Object;

namespace WinformsUnity
{
    public abstract class BaseScene
    {
        public BaseScene()
        {
#if UNITY_EDITOR
            if (EditorApplication.isPlaying)
            {
                scene = SceneManager.CreateScene("newScene");

                SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
            }
            else
            {
                scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene);
                scene.name = "newScene";
            }
#else
            scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene);
            scene.name = "newScene";
#endif
            SceneManager.SetActiveScene(scene);
            
            MapObjects();
            InitialiseGameObjects();
        }

        protected abstract void MapObjects();
        protected abstract void InitialiseGameObjects();

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

        Scene scene;
        Dictionary<int, UObject> unityObjectMap = new Dictionary<int, UObject>();
    }
}