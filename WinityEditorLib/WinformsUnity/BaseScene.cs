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
    /// <summary>
    /// The class which manages the scene's initialisation
    /// and resource management.
    /// </summary>
    public abstract class BaseScene
    {
        public BaseScene(string sceneName)
        {
#if UNITY_EDITOR
            if (EditorApplication.isPlaying)
            {
                scene = SceneManager.CreateScene(sceneName);

                SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
            }
            else
            {
                scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene);
                scene.name = sceneName;
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
        protected Scene GetScene()
        {
            return scene;
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